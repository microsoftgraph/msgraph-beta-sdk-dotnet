// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Moq;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using Microsoft.Graph.Beta;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.DotnetCore.Test.Mocks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Xunit;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Generated
{
    public class CollectionWithReferencesRequestTests
    {
        /// <summary>
        /// Tests building a request for an entity collection that has a $ref navigation.
        /// </summary>
        [Fact]
        public void BuildRequest()
        {
            var graphServiceClient = new GraphServiceClient(new MockAuthenticationProvider().Object);
            var expectedRequestUri = new Uri(string.Format(Constants.Url.GraphBaseUrlFormatString, "beta") + "/groups/groupId/members");
            var requestInformation = graphServiceClient.Groups["groupId"].Members.ToGetRequestInformation();
            
            Assert.NotNull(requestInformation);
            Assert.Equal(expectedRequestUri, requestInformation.URI);
        }

        /// <summary>
        /// Tests the GetAsync() method on the request for an entity collection that has a $ref navigation.
        /// </summary>
        [Fact]
        public async System.Threading.Tasks.Task GetAsync()
        {
            var mockRequestAdapter = new Mock<IRequestAdapter>();
            var graphServiceClient = new GraphServiceClient(mockRequestAdapter.Object);
            
            var nextQueryKey = "key";
            var nextQueryValue = "value";

            var requestUrl = string.Format("{0}/groups/groupId/members", string.Format(Constants.Url.GraphBaseUrlFormatString, "beta"));
            var nextPageRequestUrl = string.Format("{0}?{1}={2}", requestUrl, nextQueryKey, nextQueryValue);
            var nextPageRequestUrlElement = JsonDocument.Parse(string.Format("\"{0}\"", nextPageRequestUrl)).RootElement;
            
            var membersCollectionPage = new List<DirectoryObject>
            {
                new User(),
            };

            var membersCollectionResponse = new DirectoryObjectCollectionResponse
            {
                Value = membersCollectionPage,
                OdataNextLink = nextPageRequestUrl
            };
            
            mockRequestAdapter.Setup(
                adapter => adapter.SendAsync(It.IsAny<RequestInformation>(),DirectoryObjectCollectionResponse.CreateFromDiscriminatorValue, It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),It.IsAny<CancellationToken>() )
            ).ReturnsAsync(membersCollectionResponse);
            
            var returnedCollectionPage = await graphServiceClient.Groups["groupId"].Members.GetAsync();

            Assert.NotNull(returnedCollectionPage);
            Assert.Equal(membersCollectionPage, membersCollectionResponse.Value);

            var nextPageRequest = returnedCollectionPage.OdataNextLink;

            Assert.NotNull(nextPageRequest);
        }

        /// <summary>
        /// Tests the Top() method on an entity collection that has a $ref navigation.
        /// </summary>
        [Fact]
        public void Top()
        {
            var graphServiceClient = new GraphServiceClient(new MockAuthenticationProvider().Object);
            var expectedRequestUrl = string.Format("{0}/groups/groupId/members?%24top=1", string.Format(Constants.Url.GraphBaseUrlFormatString, "beta"));

            var requestInformation = graphServiceClient.Groups["groupId"].Members.ToGetRequestInformation( requestConfiguration => requestConfiguration.QueryParameters.Top = 1);
           
            Assert.NotNull(requestInformation);
            Assert.Equal(new Uri(expectedRequestUrl),requestInformation.URI);
        }
    }
}
