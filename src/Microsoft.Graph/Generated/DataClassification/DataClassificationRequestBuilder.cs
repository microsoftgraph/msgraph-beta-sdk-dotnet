using Microsoft.Graph.Beta.DataClassification.ClassifyExactMatches;
using Microsoft.Graph.Beta.DataClassification.ClassifyFile;
using Microsoft.Graph.Beta.DataClassification.ClassifyFileJobs;
using Microsoft.Graph.Beta.DataClassification.ClassifyText;
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
    /// <summary>Provides operations to manage the dataClassificationService singleton.</summary>
    public class DataClassificationRequestBuilder {
        /// <summary>The classifyExactMatches property</summary>
        public ClassifyExactMatchesRequestBuilder ClassifyExactMatches { get =>
            new ClassifyExactMatchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The classifyFile property</summary>
        public ClassifyFileRequestBuilder ClassifyFile { get =>
            new ClassifyFileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The classifyFileJobs property</summary>
        public ClassifyFileJobsRequestBuilder ClassifyFileJobs { get =>
            new ClassifyFileJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The classifyText property</summary>
        public ClassifyTextRequestBuilder ClassifyText { get =>
            new ClassifyTextRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The classifyTextJobs property</summary>
        public ClassifyTextJobsRequestBuilder ClassifyTextJobs { get =>
            new ClassifyTextJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The evaluateDlpPoliciesJobs property</summary>
        public EvaluateDlpPoliciesJobsRequestBuilder EvaluateDlpPoliciesJobs { get =>
            new EvaluateDlpPoliciesJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The evaluateLabelJobs property</summary>
        public EvaluateLabelJobsRequestBuilder EvaluateLabelJobs { get =>
            new EvaluateLabelJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The exactMatchDataStores property</summary>
        public ExactMatchDataStoresRequestBuilder ExactMatchDataStores { get =>
            new ExactMatchDataStoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The exactMatchUploadAgents property</summary>
        public ExactMatchUploadAgentsRequestBuilder ExactMatchUploadAgents { get =>
            new ExactMatchUploadAgentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jobs property</summary>
        public JobsRequestBuilder Jobs { get =>
            new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The sensitiveTypes property</summary>
        public SensitiveTypesRequestBuilder SensitiveTypes { get =>
            new SensitiveTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sensitivityLabels property</summary>
        public SensitivityLabelsRequestBuilder SensitivityLabels { get =>
            new SensitivityLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DataClassificationRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
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
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
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
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<DataClassificationRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
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
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DataClassificationService body, Action<DataClassificationRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
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
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DataClassificationService> GetAsync(Action<DataClassificationRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DataClassificationService>(requestInfo, DataClassificationService.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update dataClassification
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DataClassificationService body, Action<DataClassificationRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get dataClassification</summary>
        public class DataClassificationRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class DataClassificationRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DataClassificationRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DataClassificationRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new dataClassificationRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DataClassificationRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class DataClassificationRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new dataClassificationRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DataClassificationRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
