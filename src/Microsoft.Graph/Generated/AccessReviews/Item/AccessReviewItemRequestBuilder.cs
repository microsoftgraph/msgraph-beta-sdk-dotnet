using Microsoft.Graph.Beta.AccessReviews.Item.ApplyDecisions;
using Microsoft.Graph.Beta.AccessReviews.Item.Decisions;
using Microsoft.Graph.Beta.AccessReviews.Item.Instances;
using Microsoft.Graph.Beta.AccessReviews.Item.MyDecisions;
using Microsoft.Graph.Beta.AccessReviews.Item.ResetDecisions;
using Microsoft.Graph.Beta.AccessReviews.Item.Reviewers;
using Microsoft.Graph.Beta.AccessReviews.Item.SendReminder;
using Microsoft.Graph.Beta.AccessReviews.Item.Stop;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.AccessReviews.Item {
    /// <summary>
    /// Provides operations to manage the collection of accessReview entities.
    /// </summary>
    public class AccessReviewItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the applyDecisions method.</summary>
        public ApplyDecisionsRequestBuilder ApplyDecisions { get =>
            new ApplyDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the decisions property of the microsoft.graph.accessReview entity.</summary>
        public DecisionsRequestBuilder Decisions { get =>
            new DecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the instances property of the microsoft.graph.accessReview entity.</summary>
        public InstancesRequestBuilder Instances { get =>
            new InstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the myDecisions property of the microsoft.graph.accessReview entity.</summary>
        public MyDecisionsRequestBuilder MyDecisions { get =>
            new MyDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resetDecisions method.</summary>
        public ResetDecisionsRequestBuilder ResetDecisions { get =>
            new ResetDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reviewers property of the microsoft.graph.accessReview entity.</summary>
        public ReviewersRequestBuilder Reviewers { get =>
            new ReviewersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendReminder method.</summary>
        public SendReminderRequestBuilder SendReminder { get =>
            new SendReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stop method.</summary>
        public StopRequestBuilder Stop { get =>
            new StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AccessReviewItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accessReviews/{accessReview%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AccessReviewItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accessReviews/{accessReview%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// In the Azure AD access reviews feature, delete an accessReview object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/accessreview-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<AccessReviewItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<AccessReviewItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// In the Azure AD access reviews feature, retrieve an accessReview object.   To retrieve the reviewers of the access review, use the list accessReview reviewers API. To retrieve the decisions of the access review, use the list accessReview decisions API, or the list my accessReview decisions API. If this is a recurring access review, no decisions will be associated with the recurring access review series. Instead, use the `instances` relationship of that series to retrieve an accessReview collection of the past, current, and future instances of the access review. Each past and current instance will have decisions.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/accessreview-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccessReview?> GetAsync(Action<AccessReviewItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AccessReview> GetAsync(Action<AccessReviewItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessReview>(requestInfo, AccessReview.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// In the Azure AD access reviews feature, update an existing accessReview object to change one or more of its properties. This API is not intended to change the reviewers or decisions of a review.  To change the reviewers, use the addReviewer or removeReviewer APIs.  To stop an already-started one-time review, or an already-started instance of a recurring review, early, use the stop API. To apply the decisions to the target group or app access rights, use the apply API. 
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/accessreview-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccessReview?> PatchAsync(AccessReview body, Action<AccessReviewItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AccessReview> PatchAsync(AccessReview body, Action<AccessReviewItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessReview>(requestInfo, AccessReview.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// In the Azure AD access reviews feature, delete an accessReview object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<AccessReviewItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<AccessReviewItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AccessReviewItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// In the Azure AD access reviews feature, retrieve an accessReview object.   To retrieve the reviewers of the access review, use the list accessReview reviewers API. To retrieve the decisions of the access review, use the list accessReview decisions API, or the list my accessReview decisions API. If this is a recurring access review, no decisions will be associated with the recurring access review series. Instead, use the `instances` relationship of that series to retrieve an accessReview collection of the past, current, and future instances of the access review. Each past and current instance will have decisions.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<AccessReviewItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<AccessReviewItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AccessReviewItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// In the Azure AD access reviews feature, update an existing accessReview object to change one or more of its properties. This API is not intended to change the reviewers or decisions of a review.  To change the reviewers, use the addReviewer or removeReviewer APIs.  To stop an already-started one-time review, or an already-started instance of a recurring review, early, use the stop API. To apply the decisions to the target group or app access rights, use the apply API. 
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(AccessReview body, Action<AccessReviewItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(AccessReview body, Action<AccessReviewItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new AccessReviewItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AccessReviewItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AccessReviewItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// In the Azure AD access reviews feature, retrieve an accessReview object.   To retrieve the reviewers of the access review, use the list accessReview reviewers API. To retrieve the decisions of the access review, use the list accessReview decisions API, or the list my accessReview decisions API. If this is a recurring access review, no decisions will be associated with the recurring access review series. Instead, use the `instances` relationship of that series to retrieve an accessReview collection of the past, current, and future instances of the access review. Each past and current instance will have decisions.
        /// </summary>
        public class AccessReviewItemRequestBuilderGetQueryParameters {
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
        public class AccessReviewItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AccessReviewItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AccessReviewItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new AccessReviewItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AccessReviewItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AccessReviewItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
