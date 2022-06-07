using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.ActivateServicePlan;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.AssignLicense;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.ChangePassword;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.CheckMemberGroups;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.CheckMemberObjects;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.ExportDeviceAndAppManagementData;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.ExportDeviceAndAppManagementDataWithSkipWithTop;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.ExportPersonalData;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.FindMeetingTimes;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.FindRoomLists;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.FindRooms;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.FindRoomsWithRoomList;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetEffectiveDeviceEnrollmentConfigurations;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetLoggedOnManagedDevices;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetMailTips;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetManagedAppDiagnosticStatuses;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetManagedAppPolicies;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetManagedDevicesWithAppFailures;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetManagedDevicesWithFailedOrPendingApps;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetMemberGroups;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.GetMemberObjects;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.InvalidateAllRefreshTokens;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.IsManagedAppUserBlocked;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.ReminderViewWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.RemoveAllDevicesFromManagement;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.ReprocessLicenseAssignment;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.Restore;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.RevokeSignInSessions;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.SendMail;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.TranslateExchangeIds;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.UnblockManagedApps;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.WipeAndBlockManagedApps;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.WipeManagedAppRegistrationByDeviceTag;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.WipeManagedAppRegistrationsByAzureAdDeviceId;
using Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User.WipeManagedAppRegistrationsByDeviceTag;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Users.Item.Devices.Item.TransitiveMemberOf.Item.User {
    /// <summary>Casts the previous resource to user.</summary>
    public class UserRequestBuilder {
        /// <summary>The activateServicePlan property</summary>
        public ActivateServicePlanRequestBuilder ActivateServicePlan { get =>
            new ActivateServicePlanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignLicense property</summary>
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The changePassword property</summary>
        public ChangePasswordRequestBuilder ChangePassword { get =>
            new ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkMemberGroups property</summary>
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkMemberObjects property</summary>
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The exportPersonalData property</summary>
        public ExportPersonalDataRequestBuilder ExportPersonalData { get =>
            new ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The findMeetingTimes property</summary>
        public FindMeetingTimesRequestBuilder FindMeetingTimes { get =>
            new FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getMailTips property</summary>
        public GetMailTipsRequestBuilder GetMailTips { get =>
            new GetMailTipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getMemberGroups property</summary>
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getMemberObjects property</summary>
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invalidateAllRefreshTokens property</summary>
        public InvalidateAllRefreshTokensRequestBuilder InvalidateAllRefreshTokens { get =>
            new InvalidateAllRefreshTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The removeAllDevicesFromManagement property</summary>
        public RemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement { get =>
            new RemoveAllDevicesFromManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reprocessLicenseAssignment property</summary>
        public ReprocessLicenseAssignmentRequestBuilder ReprocessLicenseAssignment { get =>
            new ReprocessLicenseAssignmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The restore property</summary>
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The revokeSignInSessions property</summary>
        public RevokeSignInSessionsRequestBuilder RevokeSignInSessions { get =>
            new RevokeSignInSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sendMail property</summary>
        public SendMailRequestBuilder SendMail { get =>
            new SendMailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The translateExchangeIds property</summary>
        public TranslateExchangeIdsRequestBuilder TranslateExchangeIds { get =>
            new TranslateExchangeIdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The unblockManagedApps property</summary>
        public UnblockManagedAppsRequestBuilder UnblockManagedApps { get =>
            new UnblockManagedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The wipeAndBlockManagedApps property</summary>
        public WipeAndBlockManagedAppsRequestBuilder WipeAndBlockManagedApps { get =>
            new WipeAndBlockManagedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wipeManagedAppRegistrationByDeviceTag property</summary>
        public WipeManagedAppRegistrationByDeviceTagRequestBuilder WipeManagedAppRegistrationByDeviceTag { get =>
            new WipeManagedAppRegistrationByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wipeManagedAppRegistrationsByAzureAdDeviceId property</summary>
        public WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder WipeManagedAppRegistrationsByAzureAdDeviceId { get =>
            new WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wipeManagedAppRegistrationsByDeviceTag property</summary>
        public WipeManagedAppRegistrationsByDeviceTagRequestBuilder WipeManagedAppRegistrationsByDeviceTag { get =>
            new WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/devices/{device%2Did}/transitiveMemberOf/{directoryObject%2Did}/microsoft.graph.user{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/devices/{device%2Did}/transitiveMemberOf/{directoryObject%2Did}/microsoft.graph.user{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get the item of type microsoft.graph.directoryObject as microsoft.graph.user
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<UserRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new UserRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the exportDeviceAndAppManagementData method.
        /// </summary>
        public ExportDeviceAndAppManagementDataRequestBuilder ExportDeviceAndAppManagementData() {
            return new ExportDeviceAndAppManagementDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the exportDeviceAndAppManagementData method.
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="top">Usage: top={top}</param>
        /// </summary>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder ExportDeviceAndAppManagementDataWithSkipWithTop(int? skip, int? top) {
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(PathParameters, RequestAdapter, skip, top);
        }
        /// <summary>
        /// Provides operations to call the findRoomLists method.
        /// </summary>
        public FindRoomListsRequestBuilder FindRoomLists() {
            return new FindRoomListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the findRooms method.
        /// </summary>
        public FindRoomsRequestBuilder FindRooms() {
            return new FindRoomsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the findRooms method.
        /// <param name="roomList">Usage: RoomList=&apos;{RoomList}&apos;</param>
        /// </summary>
        public FindRoomsWithRoomListRequestBuilder FindRoomsWithRoomList(string roomList) {
            if(string.IsNullOrEmpty(roomList)) throw new ArgumentNullException(nameof(roomList));
            return new FindRoomsWithRoomListRequestBuilder(PathParameters, RequestAdapter, roomList);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.directoryObject as microsoft.graph.user
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.User> GetAsync(Action<UserRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.User>(requestInfo, Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getEffectiveDeviceEnrollmentConfigurations method.
        /// </summary>
        public GetEffectiveDeviceEnrollmentConfigurationsRequestBuilder GetEffectiveDeviceEnrollmentConfigurations() {
            return new GetEffectiveDeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getLoggedOnManagedDevices method.
        /// </summary>
        public GetLoggedOnManagedDevicesRequestBuilder GetLoggedOnManagedDevices() {
            return new GetLoggedOnManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getManagedAppDiagnosticStatuses method.
        /// </summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses() {
            return new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getManagedAppPolicies method.
        /// </summary>
        public GetManagedAppPoliciesRequestBuilder GetManagedAppPolicies() {
            return new GetManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getManagedDevicesWithAppFailures method.
        /// </summary>
        public GetManagedDevicesWithAppFailuresRequestBuilder GetManagedDevicesWithAppFailures() {
            return new GetManagedDevicesWithAppFailuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getManagedDevicesWithFailedOrPendingApps method.
        /// </summary>
        public GetManagedDevicesWithFailedOrPendingAppsRequestBuilder GetManagedDevicesWithFailedOrPendingApps() {
            return new GetManagedDevicesWithFailedOrPendingAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the isManagedAppUserBlocked method.
        /// </summary>
        public IsManagedAppUserBlockedRequestBuilder IsManagedAppUserBlocked() {
            return new IsManagedAppUserBlockedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the reminderView method.
        /// <param name="endDateTime">Usage: EndDateTime=&apos;{EndDateTime}&apos;</param>
        /// <param name="startDateTime">Usage: StartDateTime=&apos;{StartDateTime}&apos;</param>
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder ReminderViewWithStartDateTimeWithEndDateTime(string endDateTime, string startDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, startDateTime);
        }
        /// <summary>Get the item of type microsoft.graph.directoryObject as microsoft.graph.user</summary>
        public class UserRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class UserRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UserRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UserRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new userRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UserRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
