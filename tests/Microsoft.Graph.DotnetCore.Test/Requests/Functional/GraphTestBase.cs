// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.Beta;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Kiota.Abstractions.Authentication;
    
    public class GraphTestBase
    {
        protected static GraphServiceClient graphClient = null;

        public GraphTestBase()
        {
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
                    graphClient = new GraphServiceClient(new BaseBearerTokenAuthenticationProvider( new GraphTokenProvider()));
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Could not create a graph client: " + ex.Message);
                }
            }
        }

    }

    public class GraphTokenProvider : IAccessTokenProvider
    {
        private readonly string clientId;
        private readonly string userName;
        private readonly string password;
        // Don't use password grant in your apps. Only use for legacy solutions and automated testing.
        private readonly string grantType = "password";
        private readonly string tokenEndpoint = "https://login.microsoftonline.com/common/oauth2/token";
        private readonly string resourceId = "https%3A%2F%2Fgraph.microsoft.com%2F";
        
        private readonly string contentType = "application/x-www-form-urlencoded";
        private static string accessToken = null;
        private static string tokenForUser = null;
        private static System.DateTimeOffset expiration;

        public GraphTokenProvider()
        {
            // Setup for CI
            clientId = System.Environment.GetEnvironmentVariable("test_client_id");
            userName = System.Environment.GetEnvironmentVariable("test_user_name");
            password = System.Environment.GetEnvironmentVariable("test_password");
        }
        public async Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object> additionalAuthenticationContext = null,
            CancellationToken cancellationToken = new CancellationToken())
        {
            JObject jResult = null;
            String urlParameters = String.Format(
                    "grant_type={0}&resource={1}&client_id={2}&username={3}&password={4}",
                    grantType,
                    resourceId,
                    clientId,
                    userName,
                    password
            );

            HttpClient client = new HttpClient();
            var createBody = new StringContent(urlParameters, System.Text.Encoding.UTF8, contentType);

            HttpResponseMessage response = await client.PostAsync(tokenEndpoint, createBody);

            if (response.IsSuccessStatusCode)
            {
                Task<string> responseTask = response.Content.ReadAsStringAsync();
                responseTask.Wait();
                string responseContent = responseTask.Result;
                jResult = JObject.Parse(responseContent);
                accessToken = (string)jResult["access_token"];
            }

            if (!String.IsNullOrEmpty(accessToken))
            {
                //Set AuthenticationHelper values so that the regular MSAL auth flow won't be triggered.
                tokenForUser = accessToken;
                expiration = DateTimeOffset.UtcNow.AddHours(5);
            }

            return accessToken;
        }

        public AllowedHostsValidator AllowedHostsValidator
        {
            get;
        }
    }
}
