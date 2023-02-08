using Microsoft.Graph.Beta.App.Calls.Item.AudioRoutingGroups;
using Microsoft.Graph.Beta.App.Calls.Item.ContentSharingSessions;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphAddLargeGalleryView;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphAnswer;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphCancelMediaProcessing;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphChangeScreenSharingRole;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphKeepAlive;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphMute;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphPlayPrompt;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphRecord;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphRecordResponse;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphRedirect;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphReject;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphSubscribeToTone;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphTransfer;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphUnmute;
using Microsoft.Graph.Beta.App.Calls.Item.MicrosoftGraphUpdateRecordingStatus;
using Microsoft.Graph.Beta.App.Calls.Item.Operations;
using Microsoft.Graph.Beta.App.Calls.Item.Participants;
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
namespace Microsoft.Graph.Beta.App.Calls.Item {
    /// <summary>
    /// Provides operations to manage the calls property of the microsoft.graph.commsApplication entity.
    /// </summary>
    public class CallItemRequestBuilder {
        /// <summary>Provides operations to manage the audioRoutingGroups property of the microsoft.graph.call entity.</summary>
        public AudioRoutingGroupsRequestBuilder AudioRoutingGroups { get =>
            new AudioRoutingGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentSharingSessions property of the microsoft.graph.call entity.</summary>
        public ContentSharingSessionsRequestBuilder ContentSharingSessions { get =>
            new ContentSharingSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the addLargeGalleryView method.</summary>
        public MicrosoftGraphAddLargeGalleryViewRequestBuilder MicrosoftGraphAddLargeGalleryView { get =>
            new MicrosoftGraphAddLargeGalleryViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the answer method.</summary>
        public MicrosoftGraphAnswerRequestBuilder MicrosoftGraphAnswer { get =>
            new MicrosoftGraphAnswerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cancelMediaProcessing method.</summary>
        public MicrosoftGraphCancelMediaProcessingRequestBuilder MicrosoftGraphCancelMediaProcessing { get =>
            new MicrosoftGraphCancelMediaProcessingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the changeScreenSharingRole method.</summary>
        public MicrosoftGraphChangeScreenSharingRoleRequestBuilder MicrosoftGraphChangeScreenSharingRole { get =>
            new MicrosoftGraphChangeScreenSharingRoleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the keepAlive method.</summary>
        public MicrosoftGraphKeepAliveRequestBuilder MicrosoftGraphKeepAlive { get =>
            new MicrosoftGraphKeepAliveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the mute method.</summary>
        public MicrosoftGraphMuteRequestBuilder MicrosoftGraphMute { get =>
            new MicrosoftGraphMuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the playPrompt method.</summary>
        public MicrosoftGraphPlayPromptRequestBuilder MicrosoftGraphPlayPrompt { get =>
            new MicrosoftGraphPlayPromptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the record method.</summary>
        public MicrosoftGraphRecordRequestBuilder MicrosoftGraphRecord { get =>
            new MicrosoftGraphRecordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the recordResponse method.</summary>
        public MicrosoftGraphRecordResponseRequestBuilder MicrosoftGraphRecordResponse { get =>
            new MicrosoftGraphRecordResponseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the redirect method.</summary>
        public MicrosoftGraphRedirectRequestBuilder MicrosoftGraphRedirect { get =>
            new MicrosoftGraphRedirectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reject method.</summary>
        public MicrosoftGraphRejectRequestBuilder MicrosoftGraphReject { get =>
            new MicrosoftGraphRejectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the subscribeToTone method.</summary>
        public MicrosoftGraphSubscribeToToneRequestBuilder MicrosoftGraphSubscribeToTone { get =>
            new MicrosoftGraphSubscribeToToneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the transfer method.</summary>
        public MicrosoftGraphTransferRequestBuilder MicrosoftGraphTransfer { get =>
            new MicrosoftGraphTransferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unmute method.</summary>
        public MicrosoftGraphUnmuteRequestBuilder MicrosoftGraphUnmute { get =>
            new MicrosoftGraphUnmuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateRecordingStatus method.</summary>
        public MicrosoftGraphUpdateRecordingStatusRequestBuilder MicrosoftGraphUpdateRecordingStatus { get =>
            new MicrosoftGraphUpdateRecordingStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.call entity.</summary>
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the participants property of the microsoft.graph.call entity.</summary>
        public ParticipantsRequestBuilder Participants { get =>
            new ParticipantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new CallItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CallItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/app/calls/{call%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new CallItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CallItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/app/calls/{call%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property calls for app
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<CallItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<CallItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get calls from app
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Call?> GetAsync(Action<CallItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Call> GetAsync(Action<CallItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Call>(requestInfo, Call.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property calls in app
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Call?> PatchAsync(Call body, Action<CallItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Call> PatchAsync(Call body, Action<CallItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Call>(requestInfo, Call.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property calls for app
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<CallItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<CallItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CallItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get calls from app
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CallItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CallItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new CallItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property calls in app
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Call body, Action<CallItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Call body, Action<CallItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new CallItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CallItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CallItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public CallItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get calls from app
        /// </summary>
        public class CallItemRequestBuilderGetQueryParameters {
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
        public class CallItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CallItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CallItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new CallItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CallItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CallItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CallItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public CallItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
