// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Text.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    public class GraphTestBase
    {
        private readonly string clientId;
        private readonly string tenantId;
        private readonly string clientSecret;
        private readonly string tokenEndpoint;

        private const string scopes = "https://graph.microsoft.com/.default";
        private const string grantType = "client_credentials";
        private const string contentType = "application/x-www-form-urlencoded";

        private static string accessToken = null;

        protected static GraphServiceClient graphClient = null;

        /// <summary>
        /// Configure tests to use values set in environment in CI.
        /// </summary>
        public GraphTestBase()
        {
            // Setup for CI
            clientSecret = System.Environment.GetEnvironmentVariable("test_secret");
            clientId = System.Environment.GetEnvironmentVariable("test_client_id");
            tenantId = System.Environment.GetEnvironmentVariable("test_tenant_id");
            tokenEndpoint = $"https://login.microsoftonline.com/{tenantId}/oauth2/token";

            GetAuthenticatedClient();
        }

        // Get an access token and provide a GraphServiceClient.
        private void GetAuthenticatedClient()
        {
            if (graphClient == null)
            {
                // Create Microsoft Graph client.
                try
                {
                    graphClient = new GraphServiceClient(
                        "https://graph.microsoft.com/beta",
                        new DelegateAuthenticationProvider(
                            async (requestMessage) =>
                            {
                                var token = await getAccessTokenUsingPasswordGrant();
                                requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);

                            }));
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Could not create a graph client: " + ex.Message);
                }
            }
        }

        private async Task<string> getAccessTokenUsingPasswordGrant()
        {
            JsonDocument jResult = null;
            String urlParameters = String.Format(
                    "client_id={0}&client_info=1&client_secret={1}&scope={2}&grant_type={3}",
                    clientId,
                    clientSecret,
                    scopes,
                    grantType
            );

            HttpClient client = new HttpClient();
            var createBody = new StringContent(urlParameters, System.Text.Encoding.UTF8, contentType);

            HttpResponseMessage response = await client.PostAsync(tokenEndpoint, createBody);

            if (response.IsSuccessStatusCode)
            {
                Task<string> responseTask = response.Content.ReadAsStringAsync();
                responseTask.Wait();
                string responseContent = responseTask.Result;
                jResult = JsonDocument.Parse(responseContent);
            }
            accessToken = jResult?.RootElement.GetProperty("access_token").ToString();

            return accessToken;
        }
    }
}
