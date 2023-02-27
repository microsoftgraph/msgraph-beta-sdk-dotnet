// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using Microsoft.Graph.Beta;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;
using Xunit;
using Microsoft.Graph.DotnetCore.Test.Mocks;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Generated
{
    public class EntityRequestTests
    {
        [Fact]
        public async System.Threading.Tasks.Task GetAsync_InitializeCollectionProperties()
        {
            var mockRequestAdapter = new Mock<IRequestAdapter>();
            var graphServiceClient = new GraphServiceClient(mockRequestAdapter.Object);
            var expectedChildrenPage = new List<DriveItem>()
            {
                new DriveItem { Id = "id" }
            };

            var expectedItemResponse = new DriveItem
            {
                Children = expectedChildrenPage,
            };

            mockRequestAdapter.Setup(
                adapter => adapter.SendAsync(It.IsAny<RequestInformation>(),DriveItem.CreateFromDiscriminatorValue, It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),It.IsAny<CancellationToken>() )
            ).ReturnsAsync(expectedItemResponse);
            
            mockRequestAdapter.Setup(
                adapter => adapter.SerializationWriterFactory.GetSerializationWriter(It.IsAny<string>())
            ).Returns(new JsonSerializationWriter()); 
            
            var item = await graphServiceClient.Drives["id"].Items["id"].GetAsync();

            Assert.NotNull(item);
            Assert.NotNull(item.Children);
            Assert.Single(item.Children);
            Assert.Equal("id", item.Children[0].Id);
        }

        [Fact]
        public async System.Threading.Tasks.Task DeleteAsync()
        {
            var mockRequestAdapter = new Mock<IRequestAdapter>();
            var graphServiceClient = new GraphServiceClient(mockRequestAdapter.Object);
            using var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.NoContent);
            var requestUrl = string.Format(Constants.Url.GraphBaseUrlFormatString, "beta") + "/me/drive/items/id";

            await graphServiceClient.Drives["id"].Items["id"].DeleteAsync();
        }

        [Fact]
        public void Expand()
        {
            var graphServiceClient = new GraphServiceClient(new MockAuthenticationProvider().Object);
            var expectedRequestUri = new Uri(string.Format(Constants.Url.GraphBaseUrlFormatString, "beta") + "/drives/driveId/items/id?%24expand=value");
            var requestInformation = graphServiceClient.Drives["driveId"].Items["id"].ToGetRequestInformation( requestConfiguration => requestConfiguration.QueryParameters.Expand = new []{"value"});
            
            Assert.NotNull(requestInformation);
            Assert.Equal(expectedRequestUri, requestInformation.URI);
        }

        [Fact]
        public void Select()
        {            
            var graphServiceClient = new GraphServiceClient(new MockAuthenticationProvider().Object);
            var expectedRequestUri = new Uri(string.Format(Constants.Url.GraphBaseUrlFormatString, "beta") + "/drives/driveId/items/id?%24select=value");
            var requestInformation = graphServiceClient.Drives["driveId"].Items["id"].ToGetRequestInformation( requestConfiguration => requestConfiguration.QueryParameters.Select = new []{"value"});
            
            Assert.NotNull(requestInformation);
            Assert.Equal(expectedRequestUri, requestInformation.URI);
        }

        [Fact]
        public async System.Threading.Tasks.Task UpdateAsync_EntityWithNoCollecitonProperties()
        {
            var mockRequestAdapter = new Mock<IRequestAdapter>();
            var graphServiceClient = new GraphServiceClient(mockRequestAdapter.Object);

            var contactToUpdate = new Contact { Id = "id" };

            mockRequestAdapter.Setup(
                adapter => adapter.SendAsync(It.IsAny<RequestInformation>(),Contact.CreateFromDiscriminatorValue, It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),It.IsAny<CancellationToken>() )
            ).ReturnsAsync(contactToUpdate);
            
            mockRequestAdapter.Setup(
                adapter => adapter.SerializationWriterFactory.GetSerializationWriter(It.IsAny<string>())
            ).Returns(new JsonSerializationWriter()); 
            
            var contactResponse = await graphServiceClient.Me.Contacts["id"].PatchAsync(contactToUpdate);

            Assert.Equal(contactToUpdate, contactResponse);
        }
                
        [Fact]
        public async System.Threading.Tasks.Task UpdateAsync()
        {
            await this.RequestWithItemInBody(true);
        }

        private async System.Threading.Tasks.Task RequestWithItemInBody(bool isUpdate)
        {
            var mockRequestAdapter = new Mock<IRequestAdapter>();
            var graphServiceClient = new GraphServiceClient(mockRequestAdapter.Object);

            var expectedITem = new DriveItem() { Id = "id" };
            
            mockRequestAdapter.Setup(
                adapter => adapter.SendAsync(It.IsAny<RequestInformation>(),DriveItem.CreateFromDiscriminatorValue, It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),It.IsAny<CancellationToken>() )
            ).ReturnsAsync(expectedITem);
            
            mockRequestAdapter.Setup(
                adapter => adapter.SerializationWriterFactory.GetSerializationWriter(It.IsAny<string>())
            ).Returns(new JsonSerializationWriter()); 
            
            var itemResponse = await graphServiceClient.Drives["id"].Items["id"].PatchAsync(new DriveItem());

            Assert.Equal("id", itemResponse.Id);
        }
    }
}
