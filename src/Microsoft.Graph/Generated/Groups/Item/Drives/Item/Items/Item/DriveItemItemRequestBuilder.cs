using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Activities;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Analytics;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.AssignSensitivityLabel;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Checkin;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Checkout;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Children;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Content;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Copy;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.CreateLink;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.CreateUploadSession;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Delta;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.DeltaWithToken;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.ExtractSensitivityLabels;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Follow;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Invite;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.ListItem;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Permissions;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Preview;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Restore;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.SearchWithQ;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Subscriptions;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Thumbnails;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Unfollow;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.ValidatePermission;
using Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item.Versions;
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
namespace Microsoft.Graph.Beta.Groups.Item.Drives.Item.Items.Item {
    /// <summary>
    /// Provides operations to manage the items property of the microsoft.graph.drive entity.
    /// </summary>
    public class DriveItemItemRequestBuilder {
        /// <summary>Provides operations to manage the activities property of the microsoft.graph.driveItem entity.</summary>
        public ActivitiesRequestBuilder Activities { get =>
            new ActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.driveItem entity.</summary>
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the assignSensitivityLabel method.</summary>
        public AssignSensitivityLabelRequestBuilder AssignSensitivityLabel { get =>
            new AssignSensitivityLabelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkin method.</summary>
        public CheckinRequestBuilder Checkin { get =>
            new CheckinRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkout method.</summary>
        public CheckoutRequestBuilder Checkout { get =>
            new CheckoutRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the children property of the microsoft.graph.driveItem entity.</summary>
        public ChildrenRequestBuilder Children { get =>
            new ChildrenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the group entity.</summary>
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the copy method.</summary>
        public CopyRequestBuilder Copy { get =>
            new CopyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createLink method.</summary>
        public CreateLinkRequestBuilder CreateLink { get =>
            new CreateLinkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createUploadSession method.</summary>
        public CreateUploadSessionRequestBuilder CreateUploadSession { get =>
            new CreateUploadSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the extractSensitivityLabels method.</summary>
        public ExtractSensitivityLabelsRequestBuilder ExtractSensitivityLabels { get =>
            new ExtractSensitivityLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the follow method.</summary>
        public FollowRequestBuilder Follow { get =>
            new FollowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the invite method.</summary>
        public InviteRequestBuilder Invite { get =>
            new InviteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the listItem property of the microsoft.graph.driveItem entity.</summary>
        public ListItemRequestBuilder ListItem { get =>
            new ListItemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.driveItem entity.</summary>
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the preview method.</summary>
        public PreviewRequestBuilder Preview { get =>
            new PreviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to call the restore method.</summary>
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subscriptions property of the microsoft.graph.driveItem entity.</summary>
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the thumbnails property of the microsoft.graph.driveItem entity.</summary>
        public ThumbnailsRequestBuilder Thumbnails { get =>
            new ThumbnailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unfollow method.</summary>
        public UnfollowRequestBuilder Unfollow { get =>
            new UnfollowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to call the validatePermission method.</summary>
        public ValidatePermissionRequestBuilder ValidatePermission { get =>
            new ValidatePermissionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the versions property of the microsoft.graph.driveItem entity.</summary>
        public VersionsRequestBuilder Versions { get =>
            new VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DriveItemItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DriveItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group%2Did}/drives/{drive%2Did}/items/{driveItem%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DriveItemItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DriveItemItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group%2Did}/drives/{drive%2Did}/items/{driveItem%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property items for groups
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<DriveItemItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<DriveItemItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the delta method.
        /// </summary>
        public DeltaRequestBuilder Delta() {
            return new DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the delta method.
        /// </summary>
        /// <param name="token">Usage: token=&apos;{token}&apos;</param>
        public DeltaWithTokenRequestBuilder DeltaWithToken(string token) {
            if(string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));
            return new DeltaWithTokenRequestBuilder(PathParameters, RequestAdapter, token);
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// All items contained in the drive. Read-only. Nullable.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.DriveItem?> GetAsync(Action<DriveItemItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.DriveItem> GetAsync(Action<DriveItemItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DriveItem>(requestInfo, Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property items in groups
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.DriveItem?> PatchAsync(Microsoft.Graph.Beta.Models.DriveItem body, Action<DriveItemItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.DriveItem> PatchAsync(Microsoft.Graph.Beta.Models.DriveItem body, Action<DriveItemItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DriveItem>(requestInfo, Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the search method.
        /// </summary>
        /// <param name="q">Usage: q=&apos;{q}&apos;</param>
        public SearchWithQRequestBuilder SearchWithQ(string q) {
            if(string.IsNullOrEmpty(q)) throw new ArgumentNullException(nameof(q));
            return new SearchWithQRequestBuilder(PathParameters, RequestAdapter, q);
        }
        /// <summary>
        /// Delete navigation property items for groups
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<DriveItemItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<DriveItemItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DriveItemItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// All items contained in the drive. Read-only. Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DriveItemItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DriveItemItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DriveItemItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property items in groups
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.DriveItem body, Action<DriveItemItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.DriveItem body, Action<DriveItemItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new DriveItemItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DriveItemItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new DriveItemItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public DriveItemItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// All items contained in the drive. Read-only. Nullable.
        /// </summary>
        public class DriveItemItemRequestBuilderGetQueryParameters {
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
        public class DriveItemItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DriveItemItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DriveItemItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new DriveItemItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DriveItemItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DriveItemItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new DriveItemItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DriveItemItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
