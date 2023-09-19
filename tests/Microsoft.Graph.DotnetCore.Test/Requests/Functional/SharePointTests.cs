// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using Microsoft.Graph.Beta.Models;
    using Microsoft.Graph.Beta.Models.ODataErrors;
    using System.Threading.Tasks;
    using Xunit;
    public class Given_a_valid_SharePoint_Site : GraphTestBase
    {
        // Test search a SharePoint site.
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task It_searches_the_SharePoint_Site_and_returns_results()
        {
            try
            {
                // Call the Microsoft Graph API. 
                // /sites?search=a
                var siteSearchResults = await graphClient.Sites.GetAsync( requestConfiguration => requestConfiguration.QueryParameters.Search = "contoso");

                Assert.True(siteSearchResults.Value.Count > 0);

            }
            catch (ODataError e)
            {
                Assert.Fail($"Something happened, check out a trace. Error code: {e.Error.Code}");
            }
        }

        // Test accessing the document libraries for a SharePoint site.
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task It_gets_the_sites_drives()
        {
            try
            {
                // Call the Microsoft Graph API. Expecting a single search entry from the tenant.
                var siteSearchResults = await graphClient.Sites.GetAsync( requestConfiguration => requestConfiguration.QueryParameters.Search = "Office 365 Demos");
                Assert.True(siteSearchResults.Value.Count > 0);

                // Call the Microsoft Graph API. Get the drives collection page.
                var drives = await graphClient.Sites[siteSearchResults.Value[0].Id].Drives.GetAsync();


                Assert.True(drives.Value.Count > 0);

            }
            catch (ODataError e)
            {
                Assert.Fail($"Something happened, check out a trace. Error code: {e.Error.Code}");
            }
        }

        // Test accessing the non-default document library on a SharePoint site.
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task It_gets_the_sites_drives_root_children()
        {
            try
            {
                // Call the Microsoft Graph API. Expecting a single search entry from the tenant.
                var siteSearchResults = await graphClient.Sites.GetAsync(requestConfiguration => requestConfiguration.QueryParameters.Search = "sales");
                Assert.True(siteSearchResults.Value.Count > 0, "Expected at least one search result. Got zero. Check test data.");

                // Call the Microsoft Graph API. Get the sites drives collection page.
                var drives = await graphClient.Sites[siteSearchResults.Value[0].Id]
                                                                                       .Drives
                                                                                       .GetAsync();

                // Call the Microsoft Graph API. Get the drives collection page.
                // var library = graphClient.Sites[siteSearchResults.Value[0].Id]
                //                                       .Drives[drives.Value[0].Id]
                //                                       .Root
                //                                       .Children
                //                                       .Request()
                //                                       .GetAsync()
                //                                       .Result;
                //
                // Assert.True(library.Count > 0);

            }
            catch (ODataError e)
            {
                Assert.Fail($"Something happened, check out a trace. Error code: {e.Error.Code}");
            }
        }

        /// <summary>
        /// Test to get information about a SharePoint site by its URL.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Task It_gets_a_site_by_URL()
        {
            try
            {
                Site site = await graphClient.Shares[UrlToSharingToken("https://m365x462896.sharepoint.com/sites/portals2")].Site.GetAsync();

                Assert.NotNull(site);
            }
            catch (ODataError e)
            {
                Assert.Fail($"Something happened, check out a trace. Error code: {e.Error.Code}");
            }
        }

        string UrlToSharingToken(string inputUrl)
        {
            var base64Value = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(inputUrl));
            return "u!" + base64Value.TrimEnd('=').Replace('/', '_').Replace('+', '-');
        }
    }
}
