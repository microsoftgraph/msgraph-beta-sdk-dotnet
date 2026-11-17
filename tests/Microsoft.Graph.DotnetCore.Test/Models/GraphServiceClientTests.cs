// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.Beta;
using Microsoft.Graph.Beta.Users.Item;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Abstractions.Serialization;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.DotnetCore.Test.Models;

public class GraphServiceClientTests
{
    [Fact]
    public void InitializesClient()
    {
        // Arrange
        var graphClient = new GraphServiceClient(new AnonymousAuthenticationProvider());
        
        // Act
        var userRequestInformation = graphClient.Me.ToGetRequestInformation();
        
        // Assert
        Assert.Contains("https://graph.microsoft.com", userRequestInformation.URI.OriginalString);
    }
    
    [Fact]
    public void InitializesClientWithCustomBaseUrl()
    {
        // Arrange
        var customBaseUrl = "https://graph.microsoft-ppe.com";
        var graphClient = new GraphServiceClient(new AnonymousAuthenticationProvider(), customBaseUrl);
        
        // Act
        var userRequestInformation = graphClient.Me.ToGetRequestInformation();
        
        // Assert
        Assert.Contains(customBaseUrl, userRequestInformation.URI.OriginalString);
    }

    [Theory]
    [InlineData("https://graph.microsoft.com/beta")]
    [InlineData("https://graph.microsoft.us/beta")]
    [InlineData("https://graph.example.com/custom/beta")]
    public void MeReusesUserBuilderWithoutChangingUsers(string baseUrl)
    {
        using var graphClient = new GraphServiceClient(new AnonymousAuthenticationProvider(), baseUrl);

        var me = Assert.IsType<UserItemRequestBuilder>(graphClient.Me);
        var request = me.ToGetRequestInformation(configuration =>
        {
            configuration.QueryParameters.Select = new[] { "displayName" };
            configuration.Headers.Add("ConsistencyLevel", "eventual");
        });

        Assert.Equal($"{baseUrl}/users/TokenToReplace?%24select=displayName", request.URI.AbsoluteUri);
        Assert.Equal("TokenToReplace", request.PathParameters["user%2Did"]);
        Assert.Contains("eventual", request.Headers["ConsistencyLevel"]);
        Assert.Equal($"{baseUrl}/users/another-user", graphClient.Users["another-user"].ToGetRequestInformation().URI.AbsoluteUri);
        Assert.Equal($"{baseUrl}/users", graphClient.Users.ToGetRequestInformation().URI.AbsoluteUri);
    }

    [Fact]
    public void MePreservesRawUrls()
    {
        using var graphClient = new GraphServiceClient(new AnonymousAuthenticationProvider());
        const string nextLink = "https://graph.microsoft.com/beta/me/messages?$skiptoken=next";

        Assert.Equal(nextLink, graphClient.Me.Messages.WithUrl(nextLink).ToGetRequestInformation().URI.AbsoluteUri);
    }

    [Fact]
    public async Task MeUsesCurrentCustomAdapter()
    {
        var originalAdapter = new Mock<IRequestAdapter>();
        originalAdapter.SetupProperty(adapter => adapter.BaseUrl);
        using var graphClient = new GraphServiceClient(originalAdapter.Object, "https://graph.microsoft.us/beta");
        var replacementAdapter = new Mock<IRequestAdapter>();
        replacementAdapter.Setup(adapter => adapter.SendNoContentAsync(
            It.IsAny<RequestInformation>(),
            It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),
            It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        graphClient.RequestAdapter = replacementAdapter.Object;

        await graphClient.Me.DeleteAsync();

        replacementAdapter.Verify(adapter => adapter.SendNoContentAsync(
            It.Is<RequestInformation>(request => request.URI.AbsoluteUri == "https://graph.microsoft.us/beta/users/TokenToReplace"),
            It.IsAny<Dictionary<string, ParsableFactory<IParsable>>>(),
            It.IsAny<CancellationToken>()), Times.Once);
    }

    [Theory]
    [InlineData(false, "https://graph.microsoft.com/beta/me")]
    [InlineData(true, "https://graph.microsoft.com/beta/me/messages")]
    public async Task MeRequestsAreRemappedByGraphPipeline(bool nested, string expectedUrl)
    {
        using var handler = new RecordingHandler();
        using var httpClient = GraphClientFactory.Create(version: "beta", finalHandler: handler);
        using var graphClient = new GraphServiceClient(httpClient);

        if (nested)
        {
            await graphClient.Me.Messages.GetAsync();
        }
        else
        {
            await graphClient.Me.GetAsync();
        }

        Assert.Equal(new Uri(expectedUrl), handler.RequestUri);
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public Uri RequestUri { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            RequestUri = request.RequestUri;
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{}", System.Text.Encoding.UTF8, "application/json")
            });
        }
    }
}
