// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.Beta;
using Microsoft.Kiota.Abstractions.Authentication;
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
}
