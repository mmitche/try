// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Threading.Tasks;
using Clockwise;
using WorkspaceServer.Packaging;

namespace WorkspaceServer.Tests
{
    public class TestPackageInitializer : PackageInitializer
    {
        public int InitializeCount { get; private set; }

        public TestPackageInitializer(
            string template, 
            string projectName, 
            Func<DirectoryInfo, Budget, Task> afterCreate = null) : 
            base(template, projectName, afterCreate)
        {
        }
        public override Task Initialize(DirectoryInfo directory, Budget budget = null)
        {
            InitializeCount++;
            return base.Initialize(directory, budget);
        }

    }
}
