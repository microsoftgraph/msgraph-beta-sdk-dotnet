using Microsoft.Graph.Beta.InformationProtection.Bitlocker;
using Microsoft.Graph.Beta.InformationProtection.DataLossPreventionPolicies;
using Microsoft.Graph.Beta.InformationProtection.DecryptBuffer;
using Microsoft.Graph.Beta.InformationProtection.EncryptBuffer;
using Microsoft.Graph.Beta.InformationProtection.Policy;
using Microsoft.Graph.Beta.InformationProtection.SensitivityLabels;
using Microsoft.Graph.Beta.InformationProtection.SensitivityPolicySettings;
using Microsoft.Graph.Beta.InformationProtection.SignDigest;
using Microsoft.Graph.Beta.InformationProtection.ThreatAssessmentRequests;
using Microsoft.Graph.Beta.InformationProtection.VerifySignature;
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
namespace Microsoft.Graph.Beta.InformationProtection {
    /// <summary>Provides operations to manage the informationProtection singleton.</summary>
    public class InformationProtectionRequestBuilder {
        /// <summary>The bitlocker property</summary>
        public BitlockerRequestBuilder Bitlocker { get =>
            new BitlockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dataLossPreventionPolicies property</summary>
        public DataLossPreventionPoliciesRequestBuilder DataLossPreventionPolicies { get =>
            new DataLossPreventionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The decryptBuffer property</summary>
        public DecryptBufferRequestBuilder DecryptBuffer { get =>
            new DecryptBufferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The encryptBuffer property</summary>
        public EncryptBufferRequestBuilder EncryptBuffer { get =>
            new EncryptBufferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The policy property</summary>
        public PolicyRequestBuilder Policy { get =>
            new PolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The sensitivityLabels property</summary>
        public SensitivityLabelsRequestBuilder SensitivityLabels { get =>
            new SensitivityLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sensitivityPolicySettings property</summary>
        public SensitivityPolicySettingsRequestBuilder SensitivityPolicySettings { get =>
            new SensitivityPolicySettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The signDigest property</summary>
        public SignDigestRequestBuilder SignDigest { get =>
            new SignDigestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The threatAssessmentRequests property</summary>
        public ThreatAssessmentRequestsRequestBuilder ThreatAssessmentRequests { get =>
            new ThreatAssessmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The verifySignature property</summary>
        public VerifySignatureRequestBuilder VerifySignature { get =>
            new VerifySignatureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new InformationProtectionRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public InformationProtectionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/informationProtection{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new InformationProtectionRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public InformationProtectionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/informationProtection{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get informationProtection
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<InformationProtectionRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new InformationProtectionRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update informationProtection
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.InformationProtection body, Action<InformationProtectionRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new InformationProtectionRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get informationProtection
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.InformationProtection> GetAsync(Action<InformationProtectionRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.InformationProtection>(requestInfo, Microsoft.Graph.Beta.Models.InformationProtection.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update informationProtection
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.InformationProtection> PatchAsync(Microsoft.Graph.Beta.Models.InformationProtection body, Action<InformationProtectionRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.InformationProtection>(requestInfo, Microsoft.Graph.Beta.Models.InformationProtection.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get informationProtection</summary>
        public class InformationProtectionRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class InformationProtectionRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public InformationProtectionRequestBuilderGetQueryParameters QueryParameters { get; set; } = new InformationProtectionRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new informationProtectionRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public InformationProtectionRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class InformationProtectionRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new informationProtectionRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public InformationProtectionRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
