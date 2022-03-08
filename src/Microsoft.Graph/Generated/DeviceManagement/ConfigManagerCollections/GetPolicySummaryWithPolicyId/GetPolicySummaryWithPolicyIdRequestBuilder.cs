using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement.ConfigManagerCollections.GetPolicySummaryWithPolicyId {
    /// <summary>Provides operations to call the getPolicySummary method.</summary>
    public class GetPolicySummaryWithPolicyIdRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new GetPolicySummaryWithPolicyIdRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="policyId">Usage: policyId='{policyId}'</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetPolicySummaryWithPolicyIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string policyId = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/configManagerCollections/microsoft.graph.getPolicySummary(policyId='{policyId}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("policyId", policyId);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetPolicySummaryWithPolicyIdRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetPolicySummaryWithPolicyIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/configManagerCollections/microsoft.graph.getPolicySummary(policyId='{policyId}')";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getPolicySummary
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function getPolicySummary
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<GetPolicySummaryWithPolicyIdResponse> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendAsync<GetPolicySummaryWithPolicyIdResponse>(requestInfo, GetPolicySummaryWithPolicyIdResponse.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>Union type wrapper for classes configManagerPolicySummary</summary>
        public class GetPolicySummaryWithPolicyIdResponse : IParsable, IAdditionalDataHolder {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Union type representation for type configManagerPolicySummary</summary>
            public MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigManagerPolicySummary ConfigManagerPolicySummary { get; set; }
            /// <summary>
            /// Instantiates a new getPolicySummaryWithPolicyIdResponse and sets the default values.
            /// </summary>
            public GetPolicySummaryWithPolicyIdResponse() {
                AdditionalData = new Dictionary<string, object>();
            }
            public static GetPolicySummaryWithPolicyIdResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                return new GetPolicySummaryWithPolicyIdResponse();
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
                return new Dictionary<string, Action<T, IParseNode>> {
                    {"configManagerPolicySummary", (o,n) => { (o as GetPolicySummaryWithPolicyIdResponse).ConfigManagerPolicySummary = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigManagerPolicySummary>(MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigManagerPolicySummary.CreateFromDiscriminatorValue); } },
                };
            }
            /// <summary>
            /// Serializes information the current object
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            /// </summary>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigManagerPolicySummary>("configManagerPolicySummary", ConfigManagerPolicySummary);
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}
