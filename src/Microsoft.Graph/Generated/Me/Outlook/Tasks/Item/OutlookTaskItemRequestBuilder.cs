using Microsoft.Graph.Beta.Me.Outlook.Tasks.Item.Attachments;
using Microsoft.Graph.Beta.Me.Outlook.Tasks.Item.Complete;
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
namespace Microsoft.Graph.Beta.Me.Outlook.Tasks.Item {
    /// <summary>
    /// Provides operations to manage the tasks property of the microsoft.graph.outlookUser entity.
    /// </summary>
    public class OutlookTaskItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the attachments property of the microsoft.graph.outlookTask entity.</summary>
        public AttachmentsRequestBuilder Attachments { get =>
            new AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the complete method.</summary>
        public CompleteRequestBuilder Complete { get =>
            new CompleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new OutlookTaskItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutlookTaskItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/outlook/tasks/{outlookTask%2Did}{?%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OutlookTaskItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutlookTaskItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/outlook/tasks/{outlookTask%2Did}{?%24select}", rawUrl) {
        }
        /// <summary>
        /// Delete the specified Outlook task in the user&apos;s mailbox.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/outlooktask-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(CancellationToken cancellationToken = default, Action<OutlookTaskItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public async Task DeleteAsync(CancellationToken cancellationToken = default, Action<OutlookTaskItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get the properties and relationships of an Outlook task in the user&apos;s mailbox. By default, this operation (and the POST, PATCH, and complete task operations) returns date-related properties in UTC. You can use the `Prefer: outlook.timezone` header to have all the date-related properties in the response represented in a time zone different than UTC.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/outlooktask-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OutlookTask?> GetAsync(CancellationToken cancellationToken = default, Action<OutlookTaskItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public async Task<OutlookTask> GetAsync(CancellationToken cancellationToken = default, Action<OutlookTaskItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OutlookTask>(requestInfo, OutlookTask.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Change writable properties of an Outlook task. The **completedDateTime** property can be set by the **complete** action, or explicitly by a PATCH operation. If you use PATCH to set **completedDateTime**, make sure you set **status** to `completed` as well. By default, this operation (and the POST, GET, and complete task operations) returns date-related properties in UTC. You can use the `Prefer: outlook.timezone` header to have all the date-related properties in the response represented in a time zone different than UTC.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/outlooktask-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OutlookTask?> PatchAsync(OutlookTask body, CancellationToken cancellationToken = default, Action<OutlookTaskItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public async Task<OutlookTask> PatchAsync(OutlookTask body, CancellationToken cancellationToken = default, Action<OutlookTaskItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OutlookTask>(requestInfo, OutlookTask.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete the specified Outlook task in the user&apos;s mailbox.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<OutlookTaskItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<OutlookTaskItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new OutlookTaskItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get the properties and relationships of an Outlook task in the user&apos;s mailbox. By default, this operation (and the POST, PATCH, and complete task operations) returns date-related properties in UTC. You can use the `Prefer: outlook.timezone` header to have all the date-related properties in the response represented in a time zone different than UTC.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<OutlookTaskItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<OutlookTaskItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new OutlookTaskItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Change writable properties of an Outlook task. The **completedDateTime** property can be set by the **complete** action, or explicitly by a PATCH operation. If you use PATCH to set **completedDateTime**, make sure you set **status** to `completed` as well. By default, this operation (and the POST, GET, and complete task operations) returns date-related properties in UTC. You can use the `Prefer: outlook.timezone` header to have all the date-related properties in the response represented in a time zone different than UTC.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(OutlookTask body, Action<OutlookTaskItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(OutlookTask body, Action<OutlookTaskItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new OutlookTaskItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OutlookTaskItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new OutlookTaskItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public OutlookTaskItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get the properties and relationships of an Outlook task in the user&apos;s mailbox. By default, this operation (and the POST, PATCH, and complete task operations) returns date-related properties in UTC. You can use the `Prefer: outlook.timezone` header to have all the date-related properties in the response represented in a time zone different than UTC.
        /// </summary>
        public class OutlookTaskItemRequestBuilderGetQueryParameters {
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
        public class OutlookTaskItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public OutlookTaskItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new OutlookTaskItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new OutlookTaskItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public OutlookTaskItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OutlookTaskItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new OutlookTaskItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public OutlookTaskItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
