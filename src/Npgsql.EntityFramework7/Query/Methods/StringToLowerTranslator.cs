﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.Relational.Query.Methods;

namespace Npgsql.EntityFramework7.Query.Methods
{
    public class StringToLowerTranslator : ParameterlessInstanceMethodCallTranslator
    {
        public StringToLowerTranslator()
            : base(declaringType: typeof(string), clrMethodName: "ToLower", sqlFunctionName: "LOWER")
        {
        }
    }
}
