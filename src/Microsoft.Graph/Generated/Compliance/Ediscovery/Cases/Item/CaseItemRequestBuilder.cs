using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.LegalHolds;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.MicrosoftGraphEdiscoveryClose;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.MicrosoftGraphEdiscoveryReopen;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Operations;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.ReviewSets;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Settings;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.SourceCollections;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Tags;
using Microsoft.Graph.Beta.Models.Ediscovery;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item {
    /// <summary>
    /// Provides operations to manage the cases property of the microsoft.graph.ediscovery.ediscoveryroot entity.
    /// </summary>
    public class CaseItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the custodians property of the microsoft.graph.ediscovery.case entity.</summary>
        public CustodiansRequestBuilder Custodians { get =>
            new CustodiansRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the legalHolds property of the microsoft.graph.ediscovery.case entity.</summary>
        public LegalHoldsRequestBuilder LegalHolds { get =>
            new LegalHoldsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the close method.</summary>
        public MicrosoftGraphEdiscoveryCloseRequestBuilder MicrosoftGraphEdiscoveryClose { get =>
            new MicrosoftGraphEdiscoveryCloseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reopen method.</summary>
        public MicrosoftGraphEdiscoveryReopenRequestBuilder MicrosoftGraphEdiscoveryReopen { get =>
            new MicrosoftGraphEdiscoveryReopenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the noncustodialDataSources property of the microsoft.graph.ediscovery.case entity.</summary>
        public NoncustodialDataSourcesRequestBuilder NoncustodialDataSources { get =>
            new NoncustodialDataSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.ediscovery.case entity.</summary>
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reviewSets property of the microsoft.graph.ediscovery.case entity.</summary>
        public ReviewSetsRequestBuilder ReviewSets { get =>
            new ReviewSetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settings property of the microsoft.graph.ediscovery.case entity.</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sourceCollections property of the microsoft.graph.ediscovery.case entity.</summary>
        public SourceCollectionsRequestBuilder SourceCollections { get =>
            new SourceCollectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tags property of the microsoft.graph.ediscovery.case entity.</summary>
        public TagsRequestBuilder Tags { get =>
            new TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CaseItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CaseItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CaseItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CaseItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property cases for compliance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<CaseItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<CaseItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get cases from compliance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Case?> GetAsync(Action<CaseItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Case> GetAsync(Action<CaseItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Case>(requestInfo, Case.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property cases in compliance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Case?> PatchAsync(Case body, Action<CaseItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Case> PatchAsync(Case body, Action<CaseItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Case>(requestInfo, Case.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property cases for compliance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<CaseItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<CaseItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CaseItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get cases from compliance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CaseItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CaseItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new CaseItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property cases in compliance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Case body, Action<CaseItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Case body, Action<CaseItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new CaseItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CaseItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CaseItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public CaseItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get cases from compliance
        /// </summary>
        public class CaseItemRequestBuilderGetQueryParameters {
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
        public class CaseItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CaseItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CaseItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new CaseItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CaseItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CaseItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CaseItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public CaseItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
