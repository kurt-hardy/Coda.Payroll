// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Calculation;
using Coda.Payroll.Calculation.StudentLoan;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class StudentLoanTests
    {
        private const int TaxYear = 2022;

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan1ExactMethod2022()
        {
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan1, 399.47m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan1, 399.48m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan1, 399.58m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(TaxYear, StudentLoanPlan.Plan1, 532.81m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(TaxYear, StudentLoanPlan.Plan1, 1655.03m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(TaxYear, StudentLoanPlan.Plan1, 1977.35m, PayPeriods.Weekly));
            
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan1, 787.84m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan1, 787.85m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan1, 787.95m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(TaxYear, StudentLoanPlan.Plan1, 843.40m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(TaxYear, StudentLoanPlan.Plan1, 887.85m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(TaxYear, StudentLoanPlan.Plan1, 3421.18m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(TaxYear, StudentLoanPlan.Plan1, 4965.62m, PayPeriods.Fortnightly));

            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan1, 1564.57m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan1, 1564.58m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan1, 1564.68m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(TaxYear, StudentLoanPlan.Plan1, 1642.35m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(TaxYear, StudentLoanPlan.Plan1, 3520.13m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(TaxYear, StudentLoanPlan.Plan1, 7931.24m, PayPeriods.FourWeekly));
            
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan1, 1694.02m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan1, 1694.03m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan1, 1694.13m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(TaxYear, StudentLoanPlan.Plan1, 1727.36m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(TaxYear, StudentLoanPlan.Plan1, 2183.02m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(TaxYear, StudentLoanPlan.Plan1, 4371.80m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(TaxYear, StudentLoanPlan.Plan1, 8027.36m, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan2ExactMethod2022()
        {
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan2, 536.01m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan2, 536.02m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan2, 536.12m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(TaxYear, StudentLoanPlan.Plan2, 669.35m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(TaxYear, StudentLoanPlan.Plan2, 1791.57m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(TaxYear, StudentLoanPlan.Plan2, 2113.89m, PayPeriods.Weekly));
            
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan2, 1060.91m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan2, 1060.92m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan2, 1061.02m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(TaxYear, StudentLoanPlan.Plan2, 1116.47m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(TaxYear, StudentLoanPlan.Plan2, 1160.92m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(TaxYear, StudentLoanPlan.Plan2, 3694.25m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(TaxYear, StudentLoanPlan.Plan2, 5238.69m, PayPeriods.Fortnightly));
            
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan2, 2110.72m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan2, 2110.73m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan2, 2110.83m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(TaxYear, StudentLoanPlan.Plan2, 2188.50m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(TaxYear, StudentLoanPlan.Plan2, 4066.28m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(TaxYear, StudentLoanPlan.Plan2, 8477.39m, PayPeriods.FourWeekly));
            
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan2, 2285.69m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan2, 2285.70m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan2, 2285.80m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(TaxYear, StudentLoanPlan.Plan2, 2319.03m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(TaxYear, StudentLoanPlan.Plan2, 2774.69m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(TaxYear, StudentLoanPlan.Plan2, 4963.47m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(TaxYear, StudentLoanPlan.Plan2, 8619.03m, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan4ExactMethod2022()
        {
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan4, 499.08m, PayPeriods.Weekly));
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan4, 499.09m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan4, 499.20m, PayPeriods.Weekly));
            Assert.AreEqual(12, TestShim(TaxYear, StudentLoanPlan.Plan4, 632.42m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(TaxYear, StudentLoanPlan.Plan4, 1754.65m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(TaxYear, StudentLoanPlan.Plan4, 2076.97m, PayPeriods.Weekly));
            
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan4, 987.06m, PayPeriods.Fortnightly));
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan4, 987.07m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan4, 987.18m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(TaxYear, StudentLoanPlan.Plan4, 1042.63m, PayPeriods.Fortnightly));
            Assert.AreEqual(9, TestShim(TaxYear, StudentLoanPlan.Plan4, 1087.07m, PayPeriods.Fortnightly));
            Assert.AreEqual(237, TestShim(TaxYear, StudentLoanPlan.Plan4, 3620.40m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(TaxYear, StudentLoanPlan.Plan4, 5164.85m, PayPeriods.Fortnightly));
            
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan4, 1963.02m, PayPeriods.FourWeekly));
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan4, 1963.03m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan4, 1963.14m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(TaxYear, StudentLoanPlan.Plan4, 2040.81m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(TaxYear, StudentLoanPlan.Plan4, 3918.59m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(TaxYear, StudentLoanPlan.Plan4, 8329.70m, PayPeriods.FourWeekly));
            
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan4, 2125.68m, PayPeriods.Monthly));
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.Plan4, 2125.69m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.Plan4, 2125.80m, PayPeriods.Monthly));
            Assert.AreEqual(3, TestShim(TaxYear, StudentLoanPlan.Plan4, 2159.02m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(TaxYear, StudentLoanPlan.Plan4, 2614.68m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(TaxYear, StudentLoanPlan.Plan4, 4803.47m, PayPeriods.Monthly));
            Assert.AreEqual(570, TestShim(TaxYear, StudentLoanPlan.Plan4, 8459.02m, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPostGradExactMethod2022()
        {
            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.PostGrad, 420.50m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.PostGrad, 420.51m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.PostGrad, 420.67m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(TaxYear, StudentLoanPlan.PostGrad, 620.51m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(TaxYear, StudentLoanPlan.PostGrad, 2303.84m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(TaxYear, StudentLoanPlan.PostGrad, 2787.33m, PayPeriods.Weekly));

            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.PostGrad, 824.35m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.PostGrad, 824.36m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.PostGrad, 824.52m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(TaxYear, StudentLoanPlan.PostGrad, 907.69m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(TaxYear, StudentLoanPlan.PostGrad, 974.37m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(TaxYear, StudentLoanPlan.PostGrad, 4774.36m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(TaxYear, StudentLoanPlan.PostGrad, 7091.03m, PayPeriods.Fortnightly));

            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.PostGrad, 1632.04m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.PostGrad, 1632.05m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.PostGrad, 1632.21m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(TaxYear, StudentLoanPlan.PostGrad, 1748.72m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(TaxYear, StudentLoanPlan.PostGrad, 4565.38m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(TaxYear, StudentLoanPlan.PostGrad, 11182.05m, PayPeriods.FourWeekly));

            Assert.AreEqual(0, TestShim(TaxYear, StudentLoanPlan.PostGrad, 1766.66m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.PostGrad, 1766.67m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(TaxYear, StudentLoanPlan.PostGrad, 1766.83m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(TaxYear, StudentLoanPlan.PostGrad, 1816.67m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(TaxYear, StudentLoanPlan.PostGrad, 2500.16m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(TaxYear, StudentLoanPlan.PostGrad, 5783.34m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(TaxYear, StudentLoanPlan.PostGrad, 11266.67m, PayPeriods.Monthly));
        }
    }
}
