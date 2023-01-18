using Microsoft.Graph.Beta.DataClassification.ClassifyExactMatches;
using Microsoft.Graph.Beta.DataClassification.ClassifyFile;
using Microsoft.Graph.Beta.DataClassification.ClassifyFileJobs;
using Microsoft.Graph.Beta.DataClassification.ClassifyTextJobs;
using Microsoft.Graph.Beta.DataClassification.EvaluateDlpPoliciesJobs;
using Microsoft.Graph.Beta.DataClassification.EvaluateLabelJobs;
using Microsoft.Graph.Beta.DataClassification.ExactMatchDataStores;
using Microsoft.Graph.Beta.DataClassification.ExactMatchUploadAgents;
using Microsoft.Graph.Beta.DataClassification.Jobs;
using Microsoft.Graph.Beta.DataClassification.SensitiveTypes;
using Microsoft.Graph.Beta.DataClassification.SensitivityLabels;
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
namespace Microsoft.Graph.Beta.DataClassification {
    /// <summary>
    /// Provides operations to manage the dataClassificationService singleton.
    /// </summary>
    public class DataClassificationRequestBuilder {
        /// <summary>Provides operations to call the classifyExactMatches method.</summary>
        public ClassifyExactMatchesRequestBuilder ClassifyExactMatches { get =>
            new ClassifyExactMatchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the classifyFile method.</summary>
        public ClassifyFileRequestBuilder ClassifyFile { get =>
            new ClassifyFileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the classifyFileJobs property of the microsoft.graph.dataClassificationService entity.</summary>
        public ClassifyFileJobsRequestBuilder ClassifyFileJobs { get =>
            new ClassifyFileJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the classifyTextJobs property of the microsoft.graph.dataClassificationService entity.</summary>
        public ClassifyTextJobsRequestBuilder ClassifyTextJobs { get =>
            new ClassifyTextJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the evaluateDlpPoliciesJobs property of the microsoft.graph.dataClassificationService entity.</summary>
        public EvaluateDlpPoliciesJobsRequestBuilder EvaluateDlpPoliciesJobs { get =>
            new EvaluateDlpPoliciesJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the evaluateLabelJobs property of the microsoft.graph.dataClassificationService entity.</summary>
        public EvaluateLabelJobsRequestBuilder EvaluateLabelJobs { get =>
            new EvaluateLabelJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exactMatchDataStores property of the microsoft.graph.dataClassificationService entity.</summary>
        public ExactMatchDataStoresRequestBuilder ExactMatchDataStores { get =>
            new ExactMatchDataStoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exactMatchUploadAgents property of the microsoft.graph.dataClassificationService entity.</summary>
        public ExactMatchUploadAgentsRequestBuilder ExactMatchUploadAgents { get =>
            new ExactMatchUploadAgentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the jobs property of the microsoft.graph.dataClassificationService entity.</summary>
        public JobsRequestBuilder Jobs { get =>
            new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the sensitiveTypes property of the microsoft.graph.dataClassificationService entity.</summary>
        public SensitiveTypesRequestBuilder SensitiveTypes { get =>
            new SensitiveTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sensitivityLabels property of the microsoft.graph.dataClassificationService entity.</summary>
        public SensitivityLabelsRequestBuilder SensitivityLabels { get =>
            new SensitivityLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DataClassificationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DataClassificationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/dataClassification{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DataClassificationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DataClassificationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/dataClassification{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get dataClassification
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public async Task<DataClassificationService?> GetAsync(Action<DataClassificationRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#else
        public async Task<DataClassificationService> GetAsync(Action<DataClassificationRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DataClassificationService>(requestInfo, DataClassificationService.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update dataClassification
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public async Task<DataClassificationService?> PatchAsync(DataClassificationService body, Action<DataClassificationRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#else
        public async Task<DataClassificationService> PatchAsync(DataClassificationService body, Action<DataClassificationRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DataClassificationService>(requestInfo, DataClassificationService.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get dataClassification
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public RequestInformation ToGetRequestInformation(Action<DataClassificationRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#else
        public RequestInformation ToGetRequestInformation(Action<DataClassificationRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DataClassificationRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update dataClassification
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public RequestInformation ToPatchRequestInformation(DataClassificationService body, Action<DataClassificationRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#else
        public RequestInformation ToPatchRequestInformation(DataClassificationService body, Action<DataClassificationRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new DataClassificationRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get dataClassification
        /// </summary>
        public class DataClassificationRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DataClassificationRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DataClassificationRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DataClassificationRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new dataClassificationRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DataClassificationRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DataClassificationRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new dataClassificationRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DataClassificationRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
