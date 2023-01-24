using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.AcceptRecommendations;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ApplyDecisions;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.BatchRecordDecisions;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ContactedReviewers;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Decisions;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Definition;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ResetDecisions;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.SendReminder;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stop;
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
namespace Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item {
    /// <summary>
    /// Provides operations to manage the instances property of the microsoft.graph.accessReviewScheduleDefinition entity.
    /// </summary>
    public class AccessReviewInstanceItemRequestBuilder {
        /// <summary>Provides operations to call the acceptRecommendations method.</summary>
        public AcceptRecommendationsRequestBuilder AcceptRecommendations { get =>
            new AcceptRecommendationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the applyDecisions method.</summary>
        public ApplyDecisionsRequestBuilder ApplyDecisions { get =>
            new ApplyDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the batchRecordDecisions method.</summary>
        public BatchRecordDecisionsRequestBuilder BatchRecordDecisions { get =>
            new BatchRecordDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contactedReviewers property of the microsoft.graph.accessReviewInstance entity.</summary>
        public ContactedReviewersRequestBuilder ContactedReviewers { get =>
            new ContactedReviewersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the decisions property of the microsoft.graph.accessReviewInstance entity.</summary>
        public DecisionsRequestBuilder Decisions { get =>
            new DecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the definition property of the microsoft.graph.accessReviewInstance entity.</summary>
        public DefinitionRequestBuilder Definition { get =>
            new DefinitionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to call the resetDecisions method.</summary>
        public ResetDecisionsRequestBuilder ResetDecisions { get =>
            new ResetDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendReminder method.</summary>
        public SendReminderRequestBuilder SendReminder { get =>
            new SendReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the stages property of the microsoft.graph.accessReviewInstance entity.</summary>
        public StagesRequestBuilder Stages { get =>
            new StagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stop method.</summary>
        public StopRequestBuilder Stop { get =>
            new StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new AccessReviewInstanceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewInstanceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AccessReviewInstanceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewInstanceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property instances for identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccessReviewInstance?> GetAsync(Action<AccessReviewInstanceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AccessReviewInstance> GetAsync(Action<AccessReviewInstanceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessReviewInstance>(requestInfo, AccessReviewInstance.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property instances in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccessReviewInstance?> PatchAsync(AccessReviewInstance body, Action<AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AccessReviewInstance> PatchAsync(AccessReviewInstance body, Action<AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessReviewInstance>(requestInfo, AccessReviewInstance.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property instances for identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<AccessReviewInstanceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<AccessReviewInstanceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AccessReviewInstanceItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property instances in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(AccessReviewInstance body, Action<AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(AccessReviewInstance body, Action<AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// </summary>
        public class AccessReviewInstanceItemRequestBuilderGetQueryParameters {
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
        public class AccessReviewInstanceItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AccessReviewInstanceItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AccessReviewInstanceItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new AccessReviewInstanceItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewInstanceItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
