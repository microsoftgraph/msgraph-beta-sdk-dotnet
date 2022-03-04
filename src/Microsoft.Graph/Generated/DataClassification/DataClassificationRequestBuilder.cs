using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DataClassification.ClassifyExactMatches;
using MicrosoftGraphSdk.DataClassification.ClassifyFile;
using MicrosoftGraphSdk.DataClassification.ClassifyFileJobs;
using MicrosoftGraphSdk.DataClassification.ClassifyText;
using MicrosoftGraphSdk.DataClassification.ClassifyTextJobs;
using MicrosoftGraphSdk.DataClassification.EvaluateDlpPoliciesJobs;
using MicrosoftGraphSdk.DataClassification.EvaluateLabelJobs;
using MicrosoftGraphSdk.DataClassification.ExactMatchDataStores;
using MicrosoftGraphSdk.DataClassification.ExactMatchUploadAgents;
using MicrosoftGraphSdk.DataClassification.Jobs;
using MicrosoftGraphSdk.DataClassification.SensitiveTypes;
using MicrosoftGraphSdk.DataClassification.SensitivityLabels;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DataClassification {
    /// <summary>Builds and executes requests for operations under \dataClassification</summary>
    public class DataClassificationRequestBuilder {
        public ClassifyExactMatchesRequestBuilder ClassifyExactMatches { get =>
            new ClassifyExactMatchesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ClassifyFileRequestBuilder ClassifyFile { get =>
            new ClassifyFileRequestBuilder(PathParameters, RequestAdapter);
        }
        public ClassifyFileJobsRequestBuilder ClassifyFileJobs { get =>
            new ClassifyFileJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ClassifyTextRequestBuilder ClassifyText { get =>
            new ClassifyTextRequestBuilder(PathParameters, RequestAdapter);
        }
        public ClassifyTextJobsRequestBuilder ClassifyTextJobs { get =>
            new ClassifyTextJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        public EvaluateDlpPoliciesJobsRequestBuilder EvaluateDlpPoliciesJobs { get =>
            new EvaluateDlpPoliciesJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        public EvaluateLabelJobsRequestBuilder EvaluateLabelJobs { get =>
            new EvaluateLabelJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExactMatchDataStoresRequestBuilder ExactMatchDataStores { get =>
            new ExactMatchDataStoresRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExactMatchUploadAgentsRequestBuilder ExactMatchUploadAgents { get =>
            new ExactMatchUploadAgentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public JobsRequestBuilder Jobs { get =>
            new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SensitiveTypesRequestBuilder SensitiveTypes { get =>
            new SensitiveTypesRequestBuilder(PathParameters, RequestAdapter);
        }
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
            UrlTemplate = "{+baseurl}/dataClassification{?select,expand}";
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
            UrlTemplate = "{+baseurl}/dataClassification{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get dataClassification
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update dataClassification
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DataClassificationService body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get dataClassification
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DataClassificationService> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<DataClassificationService>(requestInfo, DataClassificationService.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Update dataClassification
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DataClassificationService body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>Get dataClassification</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
