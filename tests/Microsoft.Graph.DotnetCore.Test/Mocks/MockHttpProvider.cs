// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Moq;
using System.Net.Http;

namespace Microsoft.Graph.DotnetCore.Core.Test.Mocks
{
    public class MockHttpProvider : Mock<IHttpProvider>
    {
        public MockHttpProvider(HttpResponseMessage httpResponseMessage, ISerializer serializer = null)
            : base(MockBehavior.Strict)
        {
            this.SetupAllProperties();

            this.Setup(
                provider => provider.SendAsync(It.IsAny<HttpRequestMessage>()))
                .Returns(System.Threading.Tasks.Task.FromResult(httpResponseMessage));

            this.SetupGet(provider => provider.Serializer).Returns(serializer);
        }
    }
}
