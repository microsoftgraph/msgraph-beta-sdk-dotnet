using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Me.Messages.Item.Attachments;
using MicrosoftGraph.Me.Messages.Item.CalendarSharingMessage;
using MicrosoftGraph.Me.Messages.Item.Copy;
using MicrosoftGraph.Me.Messages.Item.CreateForward;
using MicrosoftGraph.Me.Messages.Item.CreateReply;
using MicrosoftGraph.Me.Messages.Item.CreateReplyAll;
using MicrosoftGraph.Me.Messages.Item.EventMessageRequest;
using MicrosoftGraph.Me.Messages.Item.Extensions;
using MicrosoftGraph.Me.Messages.Item.Forward;
using MicrosoftGraph.Me.Messages.Item.Mentions;
using MicrosoftGraph.Me.Messages.Item.Move;
using MicrosoftGraph.Me.Messages.Item.MultiValueExtendedProperties;
using MicrosoftGraph.Me.Messages.Item.Reply;
using MicrosoftGraph.Me.Messages.Item.ReplyAll;
using MicrosoftGraph.Me.Messages.Item.Send;
using MicrosoftGraph.Me.Messages.Item.SingleValueExtendedProperties;
using MicrosoftGraph.Me.Messages.Item.Unsubscribe;
using MicrosoftGraph.Me.Messages.Item.Value;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.Me.Messages.Item {
    /// <summary>Builds and executes requests for operations under \me\messages\{message-id}</summary>
    public class MessageRequestBuilder {
        public AttachmentsRequestBuilder Attachments { get =>
            new AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarSharingMessageRequestBuilder CalendarSharingMessage { get =>
            new CalendarSharingMessageRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        public CopyRequestBuilder Copy { get =>
            new CopyRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateForwardRequestBuilder CreateForward { get =>
            new CreateForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateReplyRequestBuilder CreateReply { get =>
            new CreateReplyRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateReplyAllRequestBuilder CreateReplyAll { get =>
            new CreateReplyAllRequestBuilder(PathParameters, RequestAdapter);
        }
        public EventMessageRequestRequestBuilder EventMessageRequest { get =>
            new EventMessageRequestRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ForwardRequestBuilder Forward { get =>
            new ForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        public MentionsRequestBuilder Mentions { get =>
            new MentionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MoveRequestBuilder Move { get =>
            new MoveRequestBuilder(PathParameters, RequestAdapter);
        }
        public MultiValueExtendedPropertiesRequestBuilder MultiValueExtendedProperties { get =>
            new MultiValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public ReplyRequestBuilder Reply { get =>
            new ReplyRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReplyAllRequestBuilder ReplyAll { get =>
            new ReplyAllRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SendRequestBuilder Send { get =>
            new SendRequestBuilder(PathParameters, RequestAdapter);
        }
        public SingleValueExtendedPropertiesRequestBuilder SingleValueExtendedProperties { get =>
            new SingleValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public UnsubscribeRequestBuilder Unsubscribe { get =>
            new UnsubscribeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new MessageRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MessageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/messages/{message_id}{?select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new MessageRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MessageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/messages/{message_id}{?select}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
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
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Message> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Message>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>The messages in a mailbox or folder. Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
