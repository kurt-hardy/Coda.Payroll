﻿// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Configuration;

namespace Cedita.Payroll.Abstractions
{
    /// <summary>
    /// Interface to support the retrieval of Tax Year Specifics
    /// 
    /// It is recommended for high performance applications to provide your own static in-code implementation of this,
    /// or database / cache based at a minimum. This is to apply instead of the default JSON provider.
    /// </summary>
    public interface ITaxConfigurationDataProvider
    {
        TaxYearConfigurationData GetTaxYearConfigurationData(int taxYear);
    }
}
