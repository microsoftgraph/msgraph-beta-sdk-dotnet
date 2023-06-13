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
namespace Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAnomalyCorrelationGroupOverview.Item {
    /// <summary>
    /// Provides operations to manage the userExperienceAnalyticsAnomalyCorrelationGroupOverview property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/userExperienceAnalyticsAnomalyCorrelationGroupOverview/{userExperienceAnalyticsAnomalyCorrelationGroupOverview%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/userExperienceAnalyticsAnomalyCorrelationGroupOverview/{userExperienceAnalyticsAnomalyCorrelationGroupOverview%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property userExperienceAnalyticsAnomalyCorrelationGroupOverview for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The user experience analytics anomaly correlation group overview entity contains the information for each correlation group of an anomaly.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview?> GetAsync(Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview> GetAsync(Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview>(requestInfo, Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property userExperienceAnalyticsAnomalyCorrelationGroupOverview in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview?> PatchAsync(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview body, Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview> PatchAsync(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview body, Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview>(requestInfo, Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property userExperienceAnalyticsAnomalyCorrelationGroupOverview for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The user experience analytics anomaly correlation group overview entity contains the information for each correlation group of an anomaly.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property userExperienceAnalyticsAnomalyCorrelationGroupOverview in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview body, Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview body, Action<UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The user experience analytics anomaly correlation group overview entity contains the information for each correlation group of an anomaly.
        /// </summary>
        public class UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetQueryParameters {
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
        public class UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public UserExperienceAnalyticsAnomalyCorrelationGroupOverviewItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
