using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Subscriptions.Item;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Subscriptions {
    /// <summary>
    /// Provides operations to manage the collection of subscription entities.
    /// </summary>
    public class SubscriptionsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the collection of subscription entities.</summary>
        public SubscriptionItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("subscription%2Did", position);
            return new SubscriptionItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new SubscriptionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubscriptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/subscriptions{?%24search,%24select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new SubscriptionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubscriptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/subscriptions{?%24search,%24select}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Retrieve a list of webhook subscriptions.  The content of the response depends on the context in which the app is calling; for details, see the scenarios in the Permissions section.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/subscription-list?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SubscriptionCollectionResponse?> GetAsync(Action<SubscriptionsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SubscriptionCollectionResponse> GetAsync(Action<SubscriptionsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SubscriptionCollectionResponse>(requestInfo, SubscriptionCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Subscribes a listener application to receive change notifications when the requested type of changes occur to the specified resource in Microsoft Graph. See the table in the Permissions section for the list of resources that support subscribing to change notifications. Some resources support the option to include encrypted resource data in change notifications. These resources include chatMessage, contact, event, message, onlineMeetings and presence. For more information, see Set up change notifications that include resource data and Change notifications for Outlook resources in Microsoft Graph.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/subscription-post-subscriptions?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Subscription?> PostAsync(Subscription body, Action<SubscriptionsRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Subscription> PostAsync(Subscription body, Action<SubscriptionsRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Subscription>(requestInfo, Subscription.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Retrieve a list of webhook subscriptions.  The content of the response depends on the context in which the app is calling; for details, see the scenarios in the Permissions section.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<SubscriptionsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<SubscriptionsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SubscriptionsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Subscribes a listener application to receive change notifications when the requested type of changes occur to the specified resource in Microsoft Graph. See the table in the Permissions section for the list of resources that support subscribing to change notifications. Some resources support the option to include encrypted resource data in change notifications. These resources include chatMessage, contact, event, message, onlineMeetings and presence. For more information, see Set up change notifications that include resource data and Change notifications for Outlook resources in Microsoft Graph.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Subscription body, Action<SubscriptionsRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Subscription body, Action<SubscriptionsRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new SubscriptionsRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve a list of webhook subscriptions.  The content of the response depends on the context in which the app is calling; for details, see the scenarios in the Permissions section.
        /// </summary>
        public class SubscriptionsRequestBuilderGetQueryParameters {
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
        public class SubscriptionsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SubscriptionsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SubscriptionsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new subscriptionsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SubscriptionsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SubscriptionsRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new subscriptionsRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public SubscriptionsRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
