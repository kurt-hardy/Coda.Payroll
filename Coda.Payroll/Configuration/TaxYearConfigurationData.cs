﻿// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using System.Collections.Generic;

namespace Coda.Payroll.Configuration
{
    public class TaxYearConfigurationData
    {
        public int TaxYear { get; set; }
        public string DefaultTaxCode { get; set; }
        public decimal LowerEarningsLimit { get; set; }
        public decimal UpperEarningsLimit { get; set; }
        public decimal PrimaryThreshold { get; set; }
        public decimal SecondaryThreshold { get; set; }
        public decimal UpperAccrualPoint { get; set; }
        public decimal UpperSecondaryThreshold { get; set; }
        public decimal ApprenticeUpperSecondaryThreshold { get; set; }      
        public decimal FreeportsUpperSecondaryThreshold { get; set; }
        public decimal VeteransUpperSecondaryThreshold { get; set; }
        public decimal Plan1StudentLoanThreshold { get; set; }
        public decimal Plan1StudentLoanRate { get; set; }
        public decimal Plan2StudentLoanThreshold { get; set; }
        public decimal Plan2StudentLoanRate { get; set; }
        public decimal Plan4StudentLoanThreshold { get; set; }
        public decimal Plan4StudentLoanRate { get; set; }
        public decimal PostGradStudentLoanThreshold { get; set; }
        public decimal PostGradStudentLoanRate { get; set; }
        public decimal DeaProtectedEarnings { get; set; }
        public decimal PensionLowerThreshold { get; set; }
        public decimal PensionAutomaticEnrolment { get; set; }
        public decimal PensionUpperThreshold { get; set; }
        
        public decimal StatutorySickPayDayRate { get; set; }
        public decimal StatutoryMaternityPayDayRate { get; set; }
        public decimal StatutoryPaternityPayDayRate { get; set; }
        public decimal StatutoryMaternityPay6WeekRatePercentage { get; set; }

        public List<FixedCode> FixedCodes { get; set; }
        public List<FixedCode> ScottishFixedCodes { get; set; }
        public List<FixedCode> WelshFixedCodes { get; set; }
        public Dictionary<char, NationalInsuranceCode> NiRates { get; set; }
        public List<TaxBracket> Brackets { get; set; }
        public List<TaxBracket> ScottishBrackets { get; set; }
        public List<TaxBracket> WelshBrackets { get; set; }
    }
}
