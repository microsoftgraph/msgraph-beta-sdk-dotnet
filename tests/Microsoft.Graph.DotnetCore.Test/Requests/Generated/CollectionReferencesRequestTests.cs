// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph.Beta;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.DotnetCore.Test.Mocks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;
using Moq;
using Xunit;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Generated
{
    public class CollectionReferencesRequestTests
    {
        /// <summary>
        /// Tests building a request for the $ref navigation of an entity collection.
        /// </summary>
        [Fact]
        public void BuildRequest()
        {
            var graphServiceClient = new GraphServiceClient(new MockAuthenticationProvider().Object);
            var expectedRequestUri = new Uri(string.Format(Constants.Url.GraphBaseUrlFormatString, "beta") + "/groups/groupId/members/$ref");
            var requestInformation = graphServiceClient.Groups["groupId"].Members.Ref.ToGetRequestInformation();
            
            Assert.NotNull(requestInformation);
            Assert.Equal(expectedRequestUri, requestInformation.URI);
        }

        /// <summary>
        /// Tests the AddAsync() method on the $ref navigation of an entity collection.
        /// </summary>
        [Fact]
        public async System.Threading.Tasks.Task AddAsync()
        {
            var mockRequestAdapter = new Mock<IRequestAdapter>();
            var graphServiceClient = new GraphServiceClient(mockRequestAdapter.Object);
            var userToCreate = new User { Id = "id" };

            var expectedRequestBody = new ReferenceCreate()
            {
                OdataId = string.Format("{0}/directoryObjects/{1}", string.Format(Constants.Url.GraphBaseUrlFormatString, "beta"), userToCreate.Id),
            };

            mockRequestAdapter.Setup(
                adapter => adapter.SendNoContentAsync(It.IsAny<RequestInformation>(), It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),It.IsAny<CancellationToken>() )
            ).Callback(() => {} ).Returns(Task.CompletedTask);
            
            mockRequestAdapter.Setup(
                adapter => adapter.SerializationWriterFactory.GetSerializationWriter(It.IsAny<string>())
            ).Returns(new JsonSerializationWriter());            
            
            await graphServiceClient.Groups["groupId"].Members.Ref.PostAsync(expectedRequestBody);
        }

        /// <summary>
        /// Tests the AddAsync() method on the $ref navigation of an entity collection errors if ID isn't set on the supplied directoryObject.
        /// </summary>
        [Fact]
        public async System.Threading.Tasks.Task AddAsync_IdRequired()
        {             
            var mockRequestAdapter = new Mock<IRequestAdapter>();
            var graphServiceClient = new GraphServiceClient(mockRequestAdapter.Object);
            var userToCreate = new ReferenceCreate();
            
            mockRequestAdapter.Setup(
                adapter => adapter.SendNoContentAsync(It.IsAny<RequestInformation>(), It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),It.IsAny<CancellationToken>() )
            ).Callback(() => {} ).Throws(new ODataError());
            
            mockRequestAdapter.Setup(
                adapter => adapter.SerializationWriterFactory.GetSerializationWriter(It.IsAny<string>())
            ).Returns(new JsonSerializationWriter());  
            

            await Assert.ThrowsAsync<ODataError>(() => graphServiceClient.Groups["groupId"].Members.Ref.PostAsync(userToCreate));

        }
        
        /// <summary>
        /// Tests the Top() method on the request for an entity collection that has a $ref navigation.
        /// </summary>
        [Fact]
        public void Top()
        {
            var graphServiceClient = new GraphServiceClient(new MockAuthenticationProvider().Object);
            var expectedRequestUrl = string.Format("{0}/groups/groupId/members?%24top=1", string.Format(Constants.Url.GraphBaseUrlFormatString, "beta"));

            var requestInformation = graphServiceClient.Groups["groupId"].Members.ToGetRequestInformation(requestConfiguration => requestConfiguration.QueryParameters.Top = 1);
            
            Assert.NotNull(requestInformation);
            Assert.Equal(new Uri(expectedRequestUrl), requestInformation.URI);
        }

        /// <summary>
        /// Tests the OrderBy() method on the request for an entity collection that has a $ref navigation.
        /// </summary>
        [Fact]
        public void OrderBy()
        {
            var graphServiceClient = new GraphServiceClient(new MockAuthenticationProvider().Object);
            var expectedRequestUrl = string.Format("{0}/groups/groupId/members?%24orderby=value", string.Format(Constants.Url.GraphBaseUrlFormatString, "beta"));

            var requestInformation = graphServiceClient.Groups["groupId"].Members
                .ToGetRequestInformation(requestConfiguration =>
                    requestConfiguration.QueryParameters.Orderby = new[] { "value" });
            
            Assert.NotNull(requestInformation);
            Assert.Equal(new Uri(expectedRequestUrl), requestInformation.URI);
        }
    }
}
