// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NET452 || NETCOREAPP1_0 || NETCOREAPP2_0

using System;

namespace Internal.Microsoft.Extensions.DependencyModel
{
    internal class EnvironmentWrapper : IEnvironment
    {
        public static IEnvironment Default = new EnvironmentWrapper();

        public string GetEnvironmentVariable(string name)
        {
            return Environment.GetEnvironmentVariable(name);
        }
    }
}

#endif
