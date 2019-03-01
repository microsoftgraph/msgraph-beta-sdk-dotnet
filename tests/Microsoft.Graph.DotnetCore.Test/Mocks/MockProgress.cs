// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Moq;
using System;

namespace Microsoft.Graph.Beta.DotnetCore.Core.Test.Mocks
{
    public class MockProgress : Mock<IProgress<AsyncOperationStatus>>
    {
        public MockProgress()
            : base(MockBehavior.Strict)
        {
            this.Setup(mockProgress => mockProgress.Report(It.IsAny<AsyncOperationStatus>()));
        }
    }
}
