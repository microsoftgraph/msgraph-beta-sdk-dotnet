using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Me.Onenote.Notebooks.GetNotebookFromWebUrl {
    /// <summary>Provides operations to call the getNotebookFromWebUrl method.</summary>
    public class GetNotebookFromWebUrlRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new GetNotebookFromWebUrlRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetNotebookFromWebUrlRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/onenote/notebooks/microsoft.graph.getNotebookFromWebUrl";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetNotebookFromWebUrlRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetNotebookFromWebUrlRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/onenote/notebooks/microsoft.graph.getNotebookFromWebUrl";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke action getNotebookFromWebUrl
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(GetNotebookFromWebUrlRequestBody body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke action getNotebookFromWebUrl
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<GetNotebookFromWebUrlResponse> PostAsync(GetNotebookFromWebUrlRequestBody body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePostRequestInformation(body, h, o);
            return await RequestAdapter.SendAsync<GetNotebookFromWebUrlResponse>(requestInfo, GetNotebookFromWebUrlResponse.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>Union type wrapper for classes CopyNotebookModel</summary>
        public class GetNotebookFromWebUrlResponse : IParsable, IAdditionalDataHolder {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Union type representation for type CopyNotebookModel</summary>
            public MicrosoftGraphSdk.Models.Microsoft.Graph.CopyNotebookModel CopyNotebookModel { get; set; }
            /// <summary>
            /// Instantiates a new getNotebookFromWebUrlResponse and sets the default values.
            /// </summary>
            public GetNotebookFromWebUrlResponse() {
                AdditionalData = new Dictionary<string, object>();
            }
            public static GetNotebookFromWebUrlResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                return new GetNotebookFromWebUrlResponse();
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
                return new Dictionary<string, Action<T, IParseNode>> {
                    {"copyNotebookModel", (o,n) => { (o as GetNotebookFromWebUrlResponse).CopyNotebookModel = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.CopyNotebookModel>(MicrosoftGraphSdk.Models.Microsoft.Graph.CopyNotebookModel.CreateFromDiscriminatorValue); } },
                };
            }
            /// <summary>
            /// Serializes information the current object
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            /// </summary>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.CopyNotebookModel>("copyNotebookModel", CopyNotebookModel);
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}
