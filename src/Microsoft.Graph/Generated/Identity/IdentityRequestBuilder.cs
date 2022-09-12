using Microsoft.Graph.Beta.Identity.ApiConnectors;
using Microsoft.Graph.Beta.Identity.AuthenticationEventListeners;
using Microsoft.Graph.Beta.Identity.B2cUserFlows;
using Microsoft.Graph.Beta.Identity.B2xUserFlows;
using Microsoft.Graph.Beta.Identity.ConditionalAccess;
using Microsoft.Graph.Beta.Identity.ContinuousAccessEvaluationPolicy;
using Microsoft.Graph.Beta.Identity.CustomAuthenticationExtensions;
using Microsoft.Graph.Beta.Identity.IdentityProviders;
using Microsoft.Graph.Beta.Identity.UserFlowAttributes;
using Microsoft.Graph.Beta.Identity.UserFlows;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Identity {
    /// <summary>Provides operations to manage the identityContainer singleton.</summary>
    public class IdentityRequestBuilder {
        /// <summary>The apiConnectors property</summary>
        public ApiConnectorsRequestBuilder ApiConnectors { get =>
            new ApiConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationEventListeners property</summary>
        public AuthenticationEventListenersRequestBuilder AuthenticationEventListeners { get =>
            new AuthenticationEventListenersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The b2cUserFlows property</summary>
        public B2cUserFlowsRequestBuilder B2cUserFlows { get =>
            new B2cUserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The b2xUserFlows property</summary>
        public B2xUserFlowsRequestBuilder B2xUserFlows { get =>
            new B2xUserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The conditionalAccess property</summary>
        public ConditionalAccessRequestBuilder ConditionalAccess { get =>
            new ConditionalAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The continuousAccessEvaluationPolicy property</summary>
        public ContinuousAccessEvaluationPolicyRequestBuilder ContinuousAccessEvaluationPolicy { get =>
            new ContinuousAccessEvaluationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The customAuthenticationExtensions property</summary>
        public CustomAuthenticationExtensionsRequestBuilder CustomAuthenticationExtensions { get =>
            new CustomAuthenticationExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityProviders property</summary>
        public IdentityProvidersRequestBuilder IdentityProviders { get =>
            new IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The userFlowAttributes property</summary>
        public UserFlowAttributesRequestBuilder UserFlowAttributes { get =>
            new UserFlowAttributesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userFlows property</summary>
        public UserFlowsRequestBuilder UserFlows { get =>
            new UserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new IdentityRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public IdentityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identity{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new IdentityRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public IdentityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identity{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get identity
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IdentityRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new IdentityRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update identity
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(IdentityContainer body, Action<IdentityRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new IdentityRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get identity
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IdentityContainer> GetAsync(Action<IdentityRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<IdentityContainer>(requestInfo, IdentityContainer.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update identity
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(IdentityContainer body, Action<IdentityRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get identity</summary>
        public class IdentityRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class IdentityRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public IdentityRequestBuilderGetQueryParameters QueryParameters { get; set; } = new IdentityRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new identityRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public IdentityRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class IdentityRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new identityRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public IdentityRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
