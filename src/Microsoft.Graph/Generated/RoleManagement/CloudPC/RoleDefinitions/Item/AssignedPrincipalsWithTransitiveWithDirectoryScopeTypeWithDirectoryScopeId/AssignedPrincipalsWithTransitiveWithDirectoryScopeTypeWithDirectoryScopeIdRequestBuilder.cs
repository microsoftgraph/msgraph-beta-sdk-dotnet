using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.RoleManagement.CloudPC.RoleDefinitions.Item.AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeId {
    /// <summary>Provides operations to call the assignedPrincipals method.</summary>
    public class AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/roleManagement/cloudPC/roleDefinitions/{unifiedRoleDefinition%2Did}/microsoft.graph.assignedPrincipals(transitive={transitive},directoryScopeType='{directoryScopeType}',directoryScopeId='{directoryScopeId}'){?transitive,directoryScopeType,directoryScopeId}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/roleManagement/cloudPC/roleDefinitions/{unifiedRoleDefinition%2Did}/microsoft.graph.assignedPrincipals(transitive={transitive},directoryScopeType='{directoryScopeType}',directoryScopeId='{directoryScopeId}'){?transitive,directoryScopeType,directoryScopeId}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function assignedPrincipals
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Invoke function assignedPrincipals
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdResponse> GetAsync(Action<AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdResponse>(requestInfo, AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdResponse.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Invoke function assignedPrincipals</summary>
        public class AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetQueryParameters {
            /// <summary>Usage: directoryScopeId=&apos;{directoryScopeId}&apos;</summary>
            public string DirectoryScopeId { get; set; }
            /// <summary>Usage: directoryScopeType=&apos;{directoryScopeType}&apos;</summary>
            public string DirectoryScopeType { get; set; }
            /// <summary>Usage: transitive={transitive}</summary>
            public bool? Transitive { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new assignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AssignedPrincipalsWithTransitiveWithDirectoryScopeTypeWithDirectoryScopeIdRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
