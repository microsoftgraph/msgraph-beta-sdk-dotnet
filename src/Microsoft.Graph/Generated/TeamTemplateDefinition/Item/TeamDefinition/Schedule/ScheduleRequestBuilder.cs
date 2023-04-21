using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.OfferShiftRequests;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.OpenShiftChangeRequests;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.OpenShifts;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.SchedulingGroups;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.Share;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.Shifts;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.SwapShiftsChangeRequests;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeCards;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeOffReasons;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeOffRequests;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimesOff;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Schedule {
    /// <summary>
    /// Provides operations to manage the schedule property of the microsoft.graph.team entity.
    /// </summary>
    public class ScheduleRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the offerShiftRequests property of the microsoft.graph.schedule entity.</summary>
        public OfferShiftRequestsRequestBuilder OfferShiftRequests { get =>
            new OfferShiftRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the openShiftChangeRequests property of the microsoft.graph.schedule entity.</summary>
        public OpenShiftChangeRequestsRequestBuilder OpenShiftChangeRequests { get =>
            new OpenShiftChangeRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the openShifts property of the microsoft.graph.schedule entity.</summary>
        public OpenShiftsRequestBuilder OpenShifts { get =>
            new OpenShiftsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the schedulingGroups property of the microsoft.graph.schedule entity.</summary>
        public SchedulingGroupsRequestBuilder SchedulingGroups { get =>
            new SchedulingGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the share method.</summary>
        public ShareRequestBuilder Share { get =>
            new ShareRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the shifts property of the microsoft.graph.schedule entity.</summary>
        public ShiftsRequestBuilder Shifts { get =>
            new ShiftsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the swapShiftsChangeRequests property of the microsoft.graph.schedule entity.</summary>
        public SwapShiftsChangeRequestsRequestBuilder SwapShiftsChangeRequests { get =>
            new SwapShiftsChangeRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the timeCards property of the microsoft.graph.schedule entity.</summary>
        public TimeCardsRequestBuilder TimeCards { get =>
            new TimeCardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the timeOffReasons property of the microsoft.graph.schedule entity.</summary>
        public TimeOffReasonsRequestBuilder TimeOffReasons { get =>
            new TimeOffReasonsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the timeOffRequests property of the microsoft.graph.schedule entity.</summary>
        public TimeOffRequestsRequestBuilder TimeOffRequests { get =>
            new TimeOffRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the timesOff property of the microsoft.graph.schedule entity.</summary>
        public TimesOffRequestBuilder TimesOff { get =>
            new TimesOffRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ScheduleRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teamTemplateDefinition/{teamTemplateDefinition%2Did}/teamDefinition/schedule{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ScheduleRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teamTemplateDefinition/{teamTemplateDefinition%2Did}/teamDefinition/schedule{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property schedule for teamTemplateDefinition
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<ScheduleRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<ScheduleRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The schedule of shifts for this team.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Schedule?> GetAsync(Action<ScheduleRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Schedule> GetAsync(Action<ScheduleRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Schedule>(requestInfo, Microsoft.Graph.Beta.Models.Schedule.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property schedule in teamTemplateDefinition
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Schedule?> PutAsync(Microsoft.Graph.Beta.Models.Schedule body, Action<ScheduleRequestBuilderPutRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Schedule> PutAsync(Microsoft.Graph.Beta.Models.Schedule body, Action<ScheduleRequestBuilderPutRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Schedule>(requestInfo, Microsoft.Graph.Beta.Models.Schedule.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property schedule for teamTemplateDefinition
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ScheduleRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ScheduleRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ScheduleRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The schedule of shifts for this team.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ScheduleRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ScheduleRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ScheduleRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property schedule in teamTemplateDefinition
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Microsoft.Graph.Beta.Models.Schedule body, Action<ScheduleRequestBuilderPutRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Microsoft.Graph.Beta.Models.Schedule body, Action<ScheduleRequestBuilderPutRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ScheduleRequestBuilderPutRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ScheduleRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new scheduleRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ScheduleRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The schedule of shifts for this team.
        /// </summary>
        public class ScheduleRequestBuilderGetQueryParameters {
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
        public class ScheduleRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ScheduleRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ScheduleRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new scheduleRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ScheduleRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ScheduleRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new scheduleRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public ScheduleRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
