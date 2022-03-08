using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement.GetAssignedRoleDetails {
    /// <summary>Provides operations to call the getAssignedRoleDetails method.</summary>
    public class GetAssignedRoleDetailsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new GetAssignedRoleDetailsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetAssignedRoleDetailsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/microsoft.graph.getAssignedRoleDetails()";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetAssignedRoleDetailsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetAssignedRoleDetailsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/microsoft.graph.getAssignedRoleDetails()";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Retrieves the assigned role definitions and role assignments of the currently authenticated user.
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
        /// Retrieves the assigned role definitions and role assignments of the currently authenticated user.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<GetAssignedRoleDetailsResponse> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendAsync<GetAssignedRoleDetailsResponse>(requestInfo, GetAssignedRoleDetailsResponse.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>Union type wrapper for classes deviceAndAppManagementAssignedRoleDetails</summary>
        public class GetAssignedRoleDetailsResponse : IParsable, IAdditionalDataHolder {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Union type representation for type deviceAndAppManagementAssignedRoleDetails</summary>
            public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignedRoleDetails DeviceAndAppManagementAssignedRoleDetails { get; set; }
            /// <summary>
            /// Instantiates a new getAssignedRoleDetailsResponse and sets the default values.
            /// </summary>
            public GetAssignedRoleDetailsResponse() {
                AdditionalData = new Dictionary<string, object>();
            }
            public static GetAssignedRoleDetailsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                return new GetAssignedRoleDetailsResponse();
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
                return new Dictionary<string, Action<T, IParseNode>> {
                    {"deviceAndAppManagementAssignedRoleDetails", (o,n) => { (o as GetAssignedRoleDetailsResponse).DeviceAndAppManagementAssignedRoleDetails = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignedRoleDetails>(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignedRoleDetails.CreateFromDiscriminatorValue); } },
                };
            }
            /// <summary>
            /// Serializes information the current object
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            /// </summary>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignedRoleDetails>("deviceAndAppManagementAssignedRoleDetails", DeviceAndAppManagementAssignedRoleDetails);
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}
