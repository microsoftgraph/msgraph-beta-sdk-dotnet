using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Users.Item.JoinedGroups.Item.Team.PrimaryChannel.DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalName {
    /// <summary>Provides operations to call the doesUserHaveAccess method.</summary>
    public class DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/joinedGroups/{group%2Did}/team/primaryChannel/microsoft.graph.doesUserHaveAccess(userId='{userId}',tenantId='{tenantId}',userPrincipalName='{userPrincipalName}'){?userId,tenantId,userPrincipalName}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/joinedGroups/{group%2Did}/team/primaryChannel/microsoft.graph.doesUserHaveAccess(userId='{userId}',tenantId='{tenantId}',userPrincipalName='{userPrincipalName}'){?userId,tenantId,userPrincipalName}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function doesUserHaveAccess
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Invoke function doesUserHaveAccess
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameResponse> GetAsync(Action<DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameResponse>(requestInfo, DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameResponse.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>Invoke function doesUserHaveAccess</summary>
        public class DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetQueryParameters {
            /// <summary>Usage: tenantId=&apos;{tenantId}&apos;</summary>
            public string TenantId { get; set; }
            /// <summary>Usage: userId=&apos;{userId}&apos;</summary>
            public string UserId { get; set; }
            /// <summary>Usage: userPrincipalName=&apos;{userPrincipalName}&apos;</summary>
            public string UserPrincipalName { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new doesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DoesUserHaveAccessWithUserIdWithTenantIdWithUserPrincipalNameRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
