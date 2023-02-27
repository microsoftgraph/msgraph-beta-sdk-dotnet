// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph.Beta;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Xunit;
using Microsoft.Graph.DotnetCore.Test.Mocks;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Generated
{
    public class EntityReferenceRequestTests
    {
        /// <summary>
        /// Tests building a request for an entity's $ref navigation.
        /// </summary>
        [Fact]
        public void BuildRequest()
        {
            var graphServiceClient = new GraphServiceClient(new MockAuthenticationProvider().Object);
            var expectedRequestUri = new Uri(string.Format(Constants.Url.GraphBaseUrlFormatString, "beta") + "/groups/groupId/members/memberId/$ref");
            var requestInformation = graphServiceClient.Groups["groupId"].Members["memberId"].Ref.ToDeleteRequestInformation();
            
            Assert.NotNull(requestInformation);
            Assert.Equal(expectedRequestUri, requestInformation.URI);
        }

        /// <summary>
        /// Tests the DeleteAsync() method on an entity's $ref navigation.
        /// </summary>
        [Fact]
        public async System.Threading.Tasks.Task DeleteAsync()
        {
            var mockRequestAdapter = new Mock<IRequestAdapter>();
            var graphServiceClient = new GraphServiceClient(mockRequestAdapter.Object);

            mockRequestAdapter.Setup(
                adapter => adapter.SendNoContentAsync(It.IsAny<RequestInformation>(), It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),It.IsAny<CancellationToken>() )
            ).Callback(() => {}).Returns(Task.CompletedTask);
            
            await graphServiceClient.Groups["groupId"].Members["memberId"].Ref.DeleteAsync();
        }
    }
}
