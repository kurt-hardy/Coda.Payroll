﻿// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Coda.Payroll.Calculation.NationalInsurance
{
    public class NationalInsuranceCalculation
    {
        public decimal EarningsUptoIncludingLEL { get; set; }
        public decimal EarningsAboveLELUptoIncludingPT { get; set; }
        public decimal EarningsAbovePTUptoIncludingST { get; set; }
        public decimal EarningsAboveSTUptoIncludingUEL { get; set; }
        public decimal EarningsAboveUEL { get; set; }
        // 2020 - ST < PT
        public decimal EarningsAboveSTUpToIncludingPT { get; set; }
        public decimal EarningsAbovePTUptoIncludingUEL { get; set; }
        // 2022 - FUST
        public decimal EarningsAbovePTUptoIncludingFUST { get; set; }
        public decimal EarningsAboveFUSTUptoIncludingUEL { get; set; }

        /// <summary>
        /// Employee National Insurance Gross Value
        /// </summary>
        public decimal EmployeeNiGross { get; set; }

        /// <summary>
        /// Employee National Insurance Rebate Value
        /// </summary>
        public decimal EmployeeNiRebate { get; set; }
        
        /// <summary>
        /// Employer National Insurance Gross Value
        /// </summary>
        public decimal EmployerNiGross { get; set; }

        /// <summary>
        /// Employer National Insurance Rebate Value
        /// </summary>
        public decimal EmployerNiRebate { get; set; }

        /// <summary>
        /// Net Employee National Insurance
        /// </summary>
        public decimal EmployeeNi { get { return EmployeeNiGross - EmployeeNiRebate; } }

        /// <summary>
        /// Net Employer National Insurance
        /// </summary>
        public decimal EmployerNi { get { return EmployerNiGross - EmployerNiRebate; } }

        /// <summary>
        /// Net National Insurance (Employer + Employee)
        /// </summary>
        public decimal NetNi { get { return EmployeeNi + EmployerNi; } }
    }
}
