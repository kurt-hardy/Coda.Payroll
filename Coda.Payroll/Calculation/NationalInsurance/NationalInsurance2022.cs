// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Configuration;
using System;

namespace Coda.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2022)]
    public class NationalInsurance2022 : NationalInsurance2021
    {
        public NationalInsurance2022(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
        {
        }
        
        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods)
        {
            // The ST is back! But lower than PT.
            var niRates = TaxYearConfigurationData.NiRates[niCategory];

            // 'X' NI Code does not pay NI contributions
            if (niCategory == 'X')
            {
                gross = 0m;
            }

            var limitThresholds = GetLimitThresholdsForPeriods(payPeriods);
            
            var niCalc = new NationalInsuranceCalculation
            {
                EarningsUptoIncludingLEL = SubtractRound(gross, limitThresholds.LowerEarningsLimit, 0),
                EarningsAboveLELUptoIncludingPT = SubtractRound(gross, limitThresholds.PrimaryThreshold, limitThresholds.LowerEarningsLimit),
                EarningsAboveUEL = SubtractRound(gross, gross, limitThresholds.UpperEarningsLimit),
                EarningsAboveSTUpToIncludingPT = SubtractRound(gross, limitThresholds.PrimaryThreshold, limitThresholds.SecondaryThreshold),
                EarningsAbovePTUptoIncludingFUST = SubtractRound(gross, limitThresholds.FreeportsUpperSecondaryThreshold, limitThresholds.PrimaryThreshold),
                EarningsAboveFUSTUptoIncludingUEL = SubtractRound(gross, limitThresholds.UpperEarningsLimit, limitThresholds.FreeportsUpperSecondaryThreshold),
            };

            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUpToIncludingPT * (niRates.EeC / 100));
            // This mirrors the old method of Above PT -> UEL, "Step 4 plus Step 5 multiplied by employee’s band E % rate (round)"
            niCalc.EmployeeNiGross += TaxMath.HmrcRound((niCalc.EarningsAbovePTUptoIncludingFUST + niCalc.EarningsAboveFUSTUptoIncludingUEL) * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.EeF / 100));

            /* This gets a little weirder, we _don't_ round the figures until later now given the new FUST
             * 
             * Step 3 plus Step 4 multiplied by employer’s band D % rate (don’t round) = a
             * PLUS
             * Step 5 multiplied by employer’s band E % rate (don’t round) = b
             * a plus b = (round)
             * PLUS
             * Step 6 multiplied by employer’s band F % rate (round).
             */
            var step34 = (niCalc.EarningsAboveSTUpToIncludingPT + niCalc.EarningsAbovePTUptoIncludingFUST) * (niRates.ErD / 100);
            var step5 = niCalc.EarningsAboveFUSTUptoIncludingUEL * (niRates.ErE / 100);
            niCalc.EmployerNiGross += TaxMath.HmrcRound(step34 + step5);
            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.ErF / 100));

            return niCalc;
        }

        protected override LimitThresholds CalculateLimitThresholdsForPeriods(PayPeriods payPeriods)
        {
            var factoring = TaxMath.GetFactoring(payPeriods);
            int periods = factoring.Periods,
                weeksInPeriod = factoring.WeeksInPeriod;

            // WTF. Of course, changed again, just for fun.
            return new LimitThresholds
            {
                PrimaryThreshold = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.PrimaryThreshold, weeksInPeriod, periods), weeksInPeriod),
                SecondaryThreshold = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.SecondaryThreshold, weeksInPeriod, periods), weeksInPeriod),
                UpperEarningsLimit = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.UpperEarningsLimit, weeksInPeriod, periods), weeksInPeriod),
                LowerEarningsLimit = Math.Ceiling(TaxMath.Factor(TaxYearConfigurationData.LowerEarningsLimit, weeksInPeriod, periods)),
                FreeportsUpperSecondaryThreshold = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.FreeportsUpperSecondaryThreshold, weeksInPeriod, periods), weeksInPeriod),
            };
        }
    }
}