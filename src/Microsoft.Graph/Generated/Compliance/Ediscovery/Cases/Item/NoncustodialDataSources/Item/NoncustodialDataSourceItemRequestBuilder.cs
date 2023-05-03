using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.DataSource;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.LastIndexOperation;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryApplyHold;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryRelease;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryRemoveHold;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryUpdateIndex;
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
namespace Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item {
    /// <summary>
    /// Provides operations to manage the noncustodialDataSources property of the microsoft.graph.ediscovery.case entity.
    /// </summary>
    public class NoncustodialDataSourceItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the dataSource property of the microsoft.graph.ediscovery.noncustodialDataSource entity.</summary>
        public DataSourceRequestBuilder DataSource { get =>
            new DataSourceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastIndexOperation property of the microsoft.graph.ediscovery.dataSourceContainer entity.</summary>
        public LastIndexOperationRequestBuilder LastIndexOperation { get =>
            new LastIndexOperationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the applyHold method.</summary>
        public MicrosoftGraphEdiscoveryApplyHoldRequestBuilder MicrosoftGraphEdiscoveryApplyHold { get =>
            new MicrosoftGraphEdiscoveryApplyHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the release method.</summary>
        public MicrosoftGraphEdiscoveryReleaseRequestBuilder MicrosoftGraphEdiscoveryRelease { get =>
            new MicrosoftGraphEdiscoveryReleaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeHold method.</summary>
        public MicrosoftGraphEdiscoveryRemoveHoldRequestBuilder MicrosoftGraphEdiscoveryRemoveHold { get =>
            new MicrosoftGraphEdiscoveryRemoveHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateIndex method.</summary>
        public MicrosoftGraphEdiscoveryUpdateIndexRequestBuilder MicrosoftGraphEdiscoveryUpdateIndex { get =>
            new MicrosoftGraphEdiscoveryUpdateIndexRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new NoncustodialDataSourceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NoncustodialDataSourceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/noncustodialDataSources/{noncustodialDataSource%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new NoncustodialDataSourceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NoncustodialDataSourceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/noncustodialDataSources/{noncustodialDataSource%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property noncustodialDataSources for compliance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Returns a list of case noncustodialDataSource objects for this case.  Nullable.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<NoncustodialDataSource?> GetAsync(Action<NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<NoncustodialDataSource> GetAsync(Action<NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<NoncustodialDataSource>(requestInfo, NoncustodialDataSource.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property noncustodialDataSources in compliance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<NoncustodialDataSource?> PatchAsync(NoncustodialDataSource body, Action<NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<NoncustodialDataSource> PatchAsync(NoncustodialDataSource body, Action<NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<NoncustodialDataSource>(requestInfo, NoncustodialDataSource.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property noncustodialDataSources for compliance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a list of case noncustodialDataSource objects for this case.  Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property noncustodialDataSources in compliance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(NoncustodialDataSource body, Action<NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(NoncustodialDataSource body, Action<NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Returns a list of case noncustodialDataSource objects for this case.  Nullable.
        /// </summary>
        public class NoncustodialDataSourceItemRequestBuilderGetQueryParameters {
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
        public class NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public NoncustodialDataSourceItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new NoncustodialDataSourceItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
