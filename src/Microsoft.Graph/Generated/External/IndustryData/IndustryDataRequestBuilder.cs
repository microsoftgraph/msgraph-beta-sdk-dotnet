using Microsoft.Graph.Beta.External.IndustryData.DataConnectors;
using Microsoft.Graph.Beta.External.IndustryData.InboundFlows;
using Microsoft.Graph.Beta.External.IndustryData.Operations;
using Microsoft.Graph.Beta.External.IndustryData.ReferenceDefinitions;
using Microsoft.Graph.Beta.External.IndustryData.RoleGroups;
using Microsoft.Graph.Beta.External.IndustryData.Runs;
using Microsoft.Graph.Beta.External.IndustryData.SourceSystems;
using Microsoft.Graph.Beta.External.IndustryData.Years;
using Microsoft.Graph.Beta.Models.IndustryData;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.External.IndustryData {
    /// <summary>
    /// Provides operations to manage the industryData property of the microsoft.graph.externalConnectors.external entity.
    /// </summary>
    public class IndustryDataRequestBuilder {
        /// <summary>Provides operations to manage the dataConnectors property of the microsoft.graph.industryData.industryDataRoot entity.</summary>
        public DataConnectorsRequestBuilder DataConnectors { get =>
            new DataConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the inboundFlows property of the microsoft.graph.industryData.industryDataRoot entity.</summary>
        public InboundFlowsRequestBuilder InboundFlows { get =>
            new InboundFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.industryData.industryDataRoot entity.</summary>
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to manage the referenceDefinitions property of the microsoft.graph.industryData.industryDataRoot entity.</summary>
        public ReferenceDefinitionsRequestBuilder ReferenceDefinitions { get =>
            new ReferenceDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the roleGroups property of the microsoft.graph.industryData.industryDataRoot entity.</summary>
        public RoleGroupsRequestBuilder RoleGroups { get =>
            new RoleGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the runs property of the microsoft.graph.industryData.industryDataRoot entity.</summary>
        public RunsRequestBuilder Runs { get =>
            new RunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sourceSystems property of the microsoft.graph.industryData.industryDataRoot entity.</summary>
        public SourceSystemsRequestBuilder SourceSystems { get =>
            new SourceSystemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the years property of the microsoft.graph.industryData.industryDataRoot entity.</summary>
        public YearsRequestBuilder Years { get =>
            new YearsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new IndustryDataRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IndustryDataRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/external/industryData{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new IndustryDataRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IndustryDataRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/external/industryData{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get industryData from external
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<IndustryDataRoot?> GetAsync(Action<IndustryDataRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<IndustryDataRoot> GetAsync(Action<IndustryDataRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<IndustryDataRoot>(requestInfo, IndustryDataRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get industryData from external
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<IndustryDataRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<IndustryDataRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new IndustryDataRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get industryData from external
        /// </summary>
        public class IndustryDataRequestBuilderGetQueryParameters {
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
        public class IndustryDataRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public IndustryDataRequestBuilderGetQueryParameters QueryParameters { get; set; } = new IndustryDataRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new industryDataRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public IndustryDataRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
