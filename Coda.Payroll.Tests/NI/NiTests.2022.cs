﻿// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class NiTests
    {
        private const int TaxYear = 2022;

        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2022()
        {
            // A
            var niCode = 'A';
            Assert.AreEqual(0m, TestShim(175.03m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(175.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(175.1m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(175.11m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(2.26m, TestShim(190.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(2.27m, TestShim(190.05m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(222.04m, TestShim(966.64m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(222.05m, TestShim(966.65m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(222.24m, TestShim(967.5m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(222.25m, TestShim(967.51m, niCode, PayPeriods.Weekly, TaxYear));

            Assert.AreEqual(0m, TestShim(350.03m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(350.04m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(350.1m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(350.11m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(4.56m, TestShim(380.18m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(4.56m, TestShim(380.19m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(444.22m, TestShim(1933.72m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(444.22m, TestShim(1933.73m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(444.38m, TestShim(1934.5m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(444.39m, TestShim(1934.51m, niCode, PayPeriods.Fortnightly, TaxYear));

            Assert.AreEqual(0m, TestShim(700.03m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(700.04m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(700.1m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(700.11m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(9.06m, TestShim(760.12m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(9.07m, TestShim(760.13m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(888.21m, TestShim(3866.68m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(888.23m, TestShim(3866.69m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(888.4m, TestShim(3867.5m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(888.41m, TestShim(3867.51m, niCode, PayPeriods.FourWeekly, TaxYear));

            Assert.AreEqual(0m, TestShim(758.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(758.04m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(758.17m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.03m, TestShim(758.18m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(9.78m, TestShim(823.02m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(9.79m, TestShim(823.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(962.22m, TestShim(4188.53m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(962.23m, TestShim(4188.54m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(962.44m, TestShim(4189.5m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(962.45m, TestShim(4189.51m, niCode, PayPeriods.Monthly, TaxYear));

            niCode = 'B';
            Assert.AreEqual(0m, TestShim(175.03m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(175.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(175.1m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(175.11m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(2.26m, TestShim(190.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(2.26m, TestShim(190.05m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(174.28m, TestShim(966.64m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(174.28m, TestShim(966.65m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(174.46m, TestShim(967.5m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(174.47m, TestShim(967.51m, niCode, PayPeriods.Weekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(350.03m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(350.04m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(350.1m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(350.11m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(4.55m, TestShim(380.18m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(4.55m, TestShim(380.19m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(348.66m, TestShim(1933.72m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(348.66m, TestShim(1933.73m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(348.81m, TestShim(1934.5m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(348.82m, TestShim(1934.51m, niCode, PayPeriods.Fortnightly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(700.03m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(700.04m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(700.1m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(700.11m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(9.06m, TestShim(760.12m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(9.06m, TestShim(760.13m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(697.15m, TestShim(3866.68m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(697.16m, TestShim(3866.69m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(697.32m, TestShim(3867.5m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(697.33m, TestShim(3867.51m, niCode, PayPeriods.FourWeekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(758.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(758.04m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(758.17m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.03m, TestShim(758.18m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(9.78m, TestShim(823.02m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(9.79m, TestShim(823.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(755.24m, TestShim(4188.53m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(755.25m, TestShim(4188.54m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(755.44m, TestShim(4189.5m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(755.45m, TestShim(4189.51m, niCode, PayPeriods.Monthly, TaxYear));


            niCode = 'C';
            Assert.AreEqual(0m, TestShim(175.03m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(175.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(175.1m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(175.11m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(2.26m, TestShim(190.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(2.26m, TestShim(190.05m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(119.14m, TestShim(966.64m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(119.14m, TestShim(966.65m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(119.27m, TestShim(967.5m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(119.28m, TestShim(967.51m, niCode, PayPeriods.Weekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(350.03m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(350.04m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(350.1m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(350.11m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(4.54m, TestShim(380.18m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(4.54m, TestShim(380.19m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(238.35m, TestShim(1933.72m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(238.35m, TestShim(1933.73m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(238.46m, TestShim(1934.5m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(238.47m, TestShim(1934.51m, niCode, PayPeriods.Fortnightly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(700.03m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(700.04m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(700.1m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(700.11m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(9.05m, TestShim(760.12m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(9.05m, TestShim(760.13m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(476.58m, TestShim(3866.68m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(476.59m, TestShim(3866.69m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(476.7m, TestShim(3867.5m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(476.71m, TestShim(3867.51m, niCode, PayPeriods.FourWeekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(758.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(758.04m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(758.17m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.03m, TestShim(758.18m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(9.78m, TestShim(823.02m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(9.79m, TestShim(823.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(516.29m, TestShim(4188.53m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(516.3m, TestShim(4188.54m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(516.43m, TestShim(4189.5m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(516.44m, TestShim(4189.51m, niCode, PayPeriods.Monthly, TaxYear));

            niCode = 'H';
            Assert.AreEqual(0m, TestShim(175.03m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.1m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.11m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(190.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(190.05m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(102.9m, TestShim(966.64m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(102.91m, TestShim(966.65m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(103.04m, TestShim(967.5m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(103.05m, TestShim(967.51m, niCode, PayPeriods.Weekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(350.03m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.04m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.1m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.11m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(380.18m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(380.19m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(205.87m, TestShim(1933.72m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(205.87m, TestShim(1933.73m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(205.99m, TestShim(1934.5m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(206m, TestShim(1934.51m, niCode, PayPeriods.Fortnightly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(700.03m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.04m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.1m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.11m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(760.12m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(760.13m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(411.63m, TestShim(3866.68m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(411.64m, TestShim(3866.69m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(411.77m, TestShim(3867.5m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(411.78m, TestShim(3867.51m, niCode, PayPeriods.FourWeekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(758.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.04m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.17m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.18m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(823.02m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(823.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(445.93m, TestShim(4188.53m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(445.93m, TestShim(4188.54m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(446.08m, TestShim(4189.5m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(446.09m, TestShim(4189.51m, niCode, PayPeriods.Monthly, TaxYear));


            niCode = 'J';
            Assert.AreEqual(0m, TestShim(175.03m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(175.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(175.1m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(175.11m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(2.26m, TestShim(190.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(2.26m, TestShim(190.05m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(144.38m, TestShim(966.64m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(144.38m, TestShim(966.65m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(144.54m, TestShim(967.5m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(144.55m, TestShim(967.51m, niCode, PayPeriods.Weekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(350.03m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(350.04m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(350.1m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(350.11m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(4.54m, TestShim(380.18m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(4.55m, TestShim(380.19m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(288.84m, TestShim(1933.72m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(288.85m, TestShim(1933.73m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(288.98m, TestShim(1934.5m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(288.99m, TestShim(1934.51m, niCode, PayPeriods.Fortnightly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(700.03m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(700.04m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(700.1m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(700.11m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(9.05m, TestShim(760.12m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(9.05m, TestShim(760.13m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(577.55m, TestShim(3866.68m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(577.56m, TestShim(3866.69m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(577.7m, TestShim(3867.5m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(577.71m, TestShim(3867.51m, niCode, PayPeriods.FourWeekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(758.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(758.04m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(758.17m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0.03m, TestShim(758.18m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(9.78m, TestShim(823.02m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(9.79m, TestShim(823.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(625.67m, TestShim(4188.53m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(625.68m, TestShim(4188.54m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(625.84m, TestShim(4189.5m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(625.85m, TestShim(4189.51m, niCode, PayPeriods.Monthly, TaxYear));

            niCode = 'M';
            Assert.AreEqual(0m, TestShim(175.03m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.1m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.11m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(190.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(190.05m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(102.9m, TestShim(966.64m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(102.91m, TestShim(966.65m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(103.04m, TestShim(967.5m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(103.05m, TestShim(967.51m, niCode, PayPeriods.Weekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(350.03m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.04m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.1m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.11m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(380.18m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(380.19m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(205.87m, TestShim(1933.72m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(205.87m, TestShim(1933.73m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(205.99m, TestShim(1934.5m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(206m, TestShim(1934.51m, niCode, PayPeriods.Fortnightly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(700.03m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.04m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.1m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.11m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(760.12m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0.02m, TestShim(760.13m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(411.63m, TestShim(3866.68m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(411.64m, TestShim(3866.69m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(411.77m, TestShim(3867.5m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(411.78m, TestShim(3867.51m, niCode, PayPeriods.FourWeekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(758.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.04m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.17m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.18m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(823.02m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(823.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(445.93m, TestShim(4188.53m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(445.93m, TestShim(4188.54m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(446.08m, TestShim(4189.5m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(446.09m, TestShim(4189.51m, niCode, PayPeriods.Monthly, TaxYear));

            niCode = 'Z';
            Assert.AreEqual(0m, TestShim(175.03m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.1m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(175.11m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(190.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(190.05m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(25.24m, TestShim(966.64m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(25.24m, TestShim(966.65m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(25.34m, TestShim(967.5m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(25.35m, TestShim(967.51m, niCode, PayPeriods.Weekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(350.03m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.04m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.1m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(350.11m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(380.18m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0.01m, TestShim(380.19m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(50.49m, TestShim(1933.72m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(50.5m, TestShim(1933.73m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(50.59m, TestShim(1934.5m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(50.6m, TestShim(1934.51m, niCode, PayPeriods.Fortnightly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(700.03m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.04m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.1m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(700.11m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(760.12m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(760.13m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(100.97m, TestShim(3866.68m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(100.97m, TestShim(3866.69m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(101.07m, TestShim(3867.5m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(101.08m, TestShim(3867.51m, niCode, PayPeriods.FourWeekly, TaxYear));
            
            Assert.AreEqual(0m, TestShim(758.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.04m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.17m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(758.18m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(823.02m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(823.03m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(109.38m, TestShim(4188.53m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(109.38m, TestShim(4188.54m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(109.48m, TestShim(4189.5m, niCode, PayPeriods.Monthly, TaxYear));

            // X Codes
            niCode = 'X';
            Assert.AreEqual(0m, TestShim(162.29m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(162.30m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(892.04m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(892.05m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(892.29m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(892.30m, niCode, PayPeriods.Weekly, TaxYear));
            Assert.AreEqual(0m, TestShim(1180m, niCode, PayPeriods.Weekly, TaxYear));

            Assert.AreEqual(0m, TestShim(324.29m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(324.30m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(1783.04m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(1783.05m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(1783.29m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(1783.30m, niCode, PayPeriods.Fortnightly, TaxYear));
            Assert.AreEqual(0m, TestShim(2545m, niCode, PayPeriods.Fortnightly, TaxYear));

            Assert.AreEqual(0m, TestShim(648.29m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(648.30m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(3566.04m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(3566.05m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(3566.29m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(3566.30m, niCode, PayPeriods.FourWeekly, TaxYear));
            Assert.AreEqual(0m, TestShim(4850m, niCode, PayPeriods.FourWeekly, TaxYear));

            Assert.AreEqual(0m, TestShim(702.29m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(702.30m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(3863.04m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(3863.05m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(3863.29m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(3863.30m, niCode, PayPeriods.Monthly, TaxYear));
            Assert.AreEqual(0m, TestShim(5500m, niCode, PayPeriods.Monthly, TaxYear));

            // Ensure the UEL/LEL Figures are all zero for X Code
            var niResult = GetCalculationResult(600m, niCode, PayPeriods.Weekly, TaxYear);
            Assert.AreEqual(0m, niResult.EarningsUptoIncludingLEL);
            Assert.AreEqual(0m, niResult.EarningsAboveUEL);
            Assert.AreEqual(0m, niResult.EarningsAboveSTUptoIncludingUEL);
            Assert.AreEqual(0m, niResult.EarningsAbovePTUptoIncludingST);
            Assert.AreEqual(0m, niResult.EarningsAboveLELUptoIncludingPT);
        }
    }
}