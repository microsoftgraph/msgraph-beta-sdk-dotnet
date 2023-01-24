using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.Activate;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.ApplyHold;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.Release;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.RemoveHold;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.SiteSources;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.UnifiedGroupSources;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.UpdateIndex;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.UserSources;
using Microsoft.Graph.Beta.Models.Ediscovery;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item {
    /// <summary>
    /// Provides operations to manage the custodians property of the microsoft.graph.ediscovery.case entity.
    /// </summary>
    public class CustodianItemRequestBuilder {
        /// <summary>Provides operations to call the activate method.</summary>
        public ActivateRequestBuilder Activate { get =>
            new ActivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the applyHold method.</summary>
        public ApplyHoldRequestBuilder ApplyHold { get =>
            new ApplyHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to call the release method.</summary>
        public ReleaseRequestBuilder Release { get =>
            new ReleaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeHold method.</summary>
        public RemoveHoldRequestBuilder RemoveHold { get =>
            new RemoveHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the siteSources property of the microsoft.graph.ediscovery.custodian entity.</summary>
        public SiteSourcesRequestBuilder SiteSources { get =>
            new SiteSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the unifiedGroupSources property of the microsoft.graph.ediscovery.custodian entity.</summary>
        public UnifiedGroupSourcesRequestBuilder UnifiedGroupSources { get =>
            new UnifiedGroupSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateIndex method.</summary>
        public UpdateIndexRequestBuilder UpdateIndex { get =>
            new UpdateIndexRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the userSources property of the microsoft.graph.ediscovery.custodian entity.</summary>
        public UserSourcesRequestBuilder UserSources { get =>
            new UserSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CustodianItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustodianItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/custodians/{custodian%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new CustodianItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustodianItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/custodians/{custodian%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property custodians for compliance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<CustodianItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<CustodianItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Returns a list of case custodian objects for this case.  Nullable.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Ediscovery.Custodian?> GetAsync(Action<CustodianItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Ediscovery.Custodian> GetAsync(Action<CustodianItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Ediscovery.Custodian>(requestInfo, Microsoft.Graph.Beta.Models.Ediscovery.Custodian.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property custodians in compliance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Ediscovery.Custodian?> PatchAsync(Microsoft.Graph.Beta.Models.Ediscovery.Custodian body, Action<CustodianItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Ediscovery.Custodian> PatchAsync(Microsoft.Graph.Beta.Models.Ediscovery.Custodian body, Action<CustodianItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Ediscovery.Custodian>(requestInfo, Microsoft.Graph.Beta.Models.Ediscovery.Custodian.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property custodians for compliance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<CustodianItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<CustodianItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CustodianItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a list of case custodian objects for this case.  Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CustodianItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CustodianItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new CustodianItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property custodians in compliance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Ediscovery.Custodian body, Action<CustodianItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Ediscovery.Custodian body, Action<CustodianItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new CustodianItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CustodianItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CustodianItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public CustodianItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Returns a list of case custodian objects for this case.  Nullable.
        /// </summary>
        public class CustodianItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CustodianItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CustodianItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CustodianItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new CustodianItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CustodianItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CustodianItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CustodianItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public CustodianItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
