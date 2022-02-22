using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using MicrosoftGraph.Users.Item.ActivateServicePlan;
using MicrosoftGraph.Users.Item.Activities;
using MicrosoftGraph.Users.Item.AgreementAcceptances;
using MicrosoftGraph.Users.Item.Analytics;
using MicrosoftGraph.Users.Item.AppConsentRequestsForApproval;
using MicrosoftGraph.Users.Item.AppRoleAssignments;
using MicrosoftGraph.Users.Item.Approvals;
using MicrosoftGraph.Users.Item.AssignLicense;
using MicrosoftGraph.Users.Item.Authentication;
using MicrosoftGraph.Users.Item.Calendar;
using MicrosoftGraph.Users.Item.CalendarGroups;
using MicrosoftGraph.Users.Item.Calendars;
using MicrosoftGraph.Users.Item.CalendarView;
using MicrosoftGraph.Users.Item.ChangePassword;
using MicrosoftGraph.Users.Item.Chats;
using MicrosoftGraph.Users.Item.CheckMemberGroups;
using MicrosoftGraph.Users.Item.CheckMemberObjects;
using MicrosoftGraph.Users.Item.ContactFolders;
using MicrosoftGraph.Users.Item.Contacts;
using MicrosoftGraph.Users.Item.CreatedObjects;
using MicrosoftGraph.Users.Item.DeviceEnrollmentConfigurations;
using MicrosoftGraph.Users.Item.DeviceManagementTroubleshootingEvents;
using MicrosoftGraph.Users.Item.Devices;
using MicrosoftGraph.Users.Item.DirectReports;
using MicrosoftGraph.Users.Item.Drive;
using MicrosoftGraph.Users.Item.Drives;
using MicrosoftGraph.Users.Item.Events;
using MicrosoftGraph.Users.Item.ExportDeviceAndAppManagementData;
using MicrosoftGraph.Users.Item.ExportDeviceAndAppManagementDataWithSkipWithTop;
using MicrosoftGraph.Users.Item.ExportPersonalData;
using MicrosoftGraph.Users.Item.Extensions;
using MicrosoftGraph.Users.Item.FindMeetingTimes;
using MicrosoftGraph.Users.Item.FindRoomLists;
using MicrosoftGraph.Users.Item.FindRooms;
using MicrosoftGraph.Users.Item.FindRoomsWithRoomList;
using MicrosoftGraph.Users.Item.FollowedSites;
using MicrosoftGraph.Users.Item.GetEffectiveDeviceEnrollmentConfigurations;
using MicrosoftGraph.Users.Item.GetLoggedOnManagedDevices;
using MicrosoftGraph.Users.Item.GetMailTips;
using MicrosoftGraph.Users.Item.GetManagedAppDiagnosticStatuses;
using MicrosoftGraph.Users.Item.GetManagedAppPolicies;
using MicrosoftGraph.Users.Item.GetManagedDevicesWithAppFailures;
using MicrosoftGraph.Users.Item.GetManagedDevicesWithFailedOrPendingApps;
using MicrosoftGraph.Users.Item.GetMemberGroups;
using MicrosoftGraph.Users.Item.GetMemberObjects;
using MicrosoftGraph.Users.Item.InferenceClassification;
using MicrosoftGraph.Users.Item.InformationProtection;
using MicrosoftGraph.Users.Item.Insights;
using MicrosoftGraph.Users.Item.InvalidateAllRefreshTokens;
using MicrosoftGraph.Users.Item.IsManagedAppUserBlocked;
using MicrosoftGraph.Users.Item.JoinedGroups;
using MicrosoftGraph.Users.Item.JoinedTeams;
using MicrosoftGraph.Users.Item.LicenseDetails;
using MicrosoftGraph.Users.Item.MailFolders;
using MicrosoftGraph.Users.Item.ManagedAppRegistrations;
using MicrosoftGraph.Users.Item.ManagedDevices;
using MicrosoftGraph.Users.Item.Manager;
using MicrosoftGraph.Users.Item.MemberOf;
using MicrosoftGraph.Users.Item.Messages;
using MicrosoftGraph.Users.Item.MobileAppIntentAndStates;
using MicrosoftGraph.Users.Item.MobileAppTroubleshootingEvents;
using MicrosoftGraph.Users.Item.Notifications;
using MicrosoftGraph.Users.Item.Oauth2PermissionGrants;
using MicrosoftGraph.Users.Item.Onenote;
using MicrosoftGraph.Users.Item.OnlineMeetings;
using MicrosoftGraph.Users.Item.Outlook;
using MicrosoftGraph.Users.Item.OwnedDevices;
using MicrosoftGraph.Users.Item.OwnedObjects;
using MicrosoftGraph.Users.Item.PendingAccessReviewInstances;
using MicrosoftGraph.Users.Item.People;
using MicrosoftGraph.Users.Item.Photo;
using MicrosoftGraph.Users.Item.Photos;
using MicrosoftGraph.Users.Item.Planner;
using MicrosoftGraph.Users.Item.Presence;
using MicrosoftGraph.Users.Item.Profile;
using MicrosoftGraph.Users.Item.RegisteredDevices;
using MicrosoftGraph.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime;
using MicrosoftGraph.Users.Item.RemoveAllDevicesFromManagement;
using MicrosoftGraph.Users.Item.ReprocessLicenseAssignment;
using MicrosoftGraph.Users.Item.Restore;
using MicrosoftGraph.Users.Item.RevokeSignInSessions;
using MicrosoftGraph.Users.Item.ScopedRoleMemberOf;
using MicrosoftGraph.Users.Item.SendMail;
using MicrosoftGraph.Users.Item.Settings;
using MicrosoftGraph.Users.Item.Tasks;
using MicrosoftGraph.Users.Item.Teamwork;
using MicrosoftGraph.Users.Item.Todo;
using MicrosoftGraph.Users.Item.TransitiveMemberOf;
using MicrosoftGraph.Users.Item.TransitiveReports;
using MicrosoftGraph.Users.Item.TranslateExchangeIds;
using MicrosoftGraph.Users.Item.UnblockManagedApps;
using MicrosoftGraph.Users.Item.UsageRights;
using MicrosoftGraph.Users.Item.WindowsInformationProtectionDeviceRegistrations;
using MicrosoftGraph.Users.Item.WipeAndBlockManagedApps;
using MicrosoftGraph.Users.Item.WipeManagedAppRegistrationByDeviceTag;
using MicrosoftGraph.Users.Item.WipeManagedAppRegistrationsByDeviceTag;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.Users.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}</summary>
    public class UserRequestBuilder {
        public ActivateServicePlanRequestBuilder ActivateServicePlan { get =>
            new ActivateServicePlanRequestBuilder(PathParameters, RequestAdapter);
        }
        public ActivitiesRequestBuilder Activities { get =>
            new ActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppConsentRequestsForApprovalRequestBuilder AppConsentRequestsForApproval { get =>
            new AppConsentRequestsForApprovalRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApprovalsRequestBuilder Approvals { get =>
            new ApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        public AuthenticationRequestBuilder Authentication { get =>
            new AuthenticationRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarGroupsRequestBuilder CalendarGroups { get =>
            new CalendarGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarsRequestBuilder Calendars { get =>
            new CalendarsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChangePasswordRequestBuilder ChangePassword { get =>
            new ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContactFoldersRequestBuilder ContactFolders { get =>
            new ContactFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceManagementTroubleshootingEventsRequestBuilder DeviceManagementTroubleshootingEvents { get =>
            new DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DirectReportsRequestBuilder DirectReports { get =>
            new DirectReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExportPersonalDataRequestBuilder ExportPersonalData { get =>
            new ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public FindMeetingTimesRequestBuilder FindMeetingTimes { get =>
            new FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
        }
        public FollowedSitesRequestBuilder FollowedSites { get =>
            new FollowedSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMailTipsRequestBuilder GetMailTips { get =>
            new GetMailTipsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public InferenceClassificationRequestBuilder InferenceClassification { get =>
            new InferenceClassificationRequestBuilder(PathParameters, RequestAdapter);
        }
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        public InsightsRequestBuilder Insights { get =>
            new InsightsRequestBuilder(PathParameters, RequestAdapter);
        }
        public InvalidateAllRefreshTokensRequestBuilder InvalidateAllRefreshTokens { get =>
            new InvalidateAllRefreshTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        public JoinedGroupsRequestBuilder JoinedGroups { get =>
            new JoinedGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public JoinedTeamsRequestBuilder JoinedTeams { get =>
            new JoinedTeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MailFoldersRequestBuilder MailFolders { get =>
            new MailFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagerRequestBuilder Manager { get =>
            new ManagerRequestBuilder(PathParameters, RequestAdapter);
        }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileAppIntentAndStatesRequestBuilder MobileAppIntentAndStates { get =>
            new MobileAppIntentAndStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileAppTroubleshootingEventsRequestBuilder MobileAppTroubleshootingEvents { get =>
            new MobileAppTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public NotificationsRequestBuilder Notifications { get =>
            new NotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        public OnlineMeetingsRequestBuilder OnlineMeetings { get =>
            new OnlineMeetingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OutlookRequestBuilder Outlook { get =>
            new OutlookRequestBuilder(PathParameters, RequestAdapter);
        }
        public OwnedDevicesRequestBuilder OwnedDevices { get =>
            new OwnedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PendingAccessReviewInstancesRequestBuilder PendingAccessReviewInstances { get =>
            new PendingAccessReviewInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        public PeopleRequestBuilder People { get =>
            new PeopleRequestBuilder(PathParameters, RequestAdapter);
        }
        public PhotoRequestBuilder Photo { get =>
            new PhotoRequestBuilder(PathParameters, RequestAdapter);
        }
        public PhotosRequestBuilder Photos { get =>
            new PhotosRequestBuilder(PathParameters, RequestAdapter);
        }
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        public PresenceRequestBuilder Presence { get =>
            new PresenceRequestBuilder(PathParameters, RequestAdapter);
        }
        public ProfileRequestBuilder Profile { get =>
            new ProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        public RegisteredDevicesRequestBuilder RegisteredDevices { get =>
            new RegisteredDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public RemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement { get =>
            new RemoveAllDevicesFromManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReprocessLicenseAssignmentRequestBuilder ReprocessLicenseAssignment { get =>
            new ReprocessLicenseAssignmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        public RevokeSignInSessionsRequestBuilder RevokeSignInSessions { get =>
            new RevokeSignInSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ScopedRoleMemberOfRequestBuilder ScopedRoleMemberOf { get =>
            new ScopedRoleMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public SendMailRequestBuilder SendMail { get =>
            new SendMailRequestBuilder(PathParameters, RequestAdapter);
        }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TasksRequestBuilder Tasks { get =>
            new TasksRequestBuilder(PathParameters, RequestAdapter);
        }
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        public TodoRequestBuilder Todo { get =>
            new TodoRequestBuilder(PathParameters, RequestAdapter);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public TransitiveReportsRequestBuilder TransitiveReports { get =>
            new TransitiveReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TranslateExchangeIdsRequestBuilder TranslateExchangeIds { get =>
            new TranslateExchangeIdsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UnblockManagedAppsRequestBuilder UnblockManagedApps { get =>
            new UnblockManagedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UsageRightsRequestBuilder UsageRights { get =>
            new UsageRightsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsInformationProtectionDeviceRegistrationsRequestBuilder WindowsInformationProtectionDeviceRegistrations { get =>
            new WindowsInformationProtectionDeviceRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WipeAndBlockManagedAppsRequestBuilder WipeAndBlockManagedApps { get =>
            new WipeAndBlockManagedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WipeManagedAppRegistrationByDeviceTagRequestBuilder WipeManagedAppRegistrationByDeviceTag { get =>
            new WipeManagedAppRegistrationByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
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
            UrlTemplate = "{+baseurl}/users/{user_id}{?select,expand}";
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
            UrlTemplate = "{+baseurl}/users/{user_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from users
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
        /// Get entity from users by key
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
        /// Update entity in users
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraph.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete entity from users
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
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.exportDeviceAndAppManagementData()
        /// </summary>
        public ExportDeviceAndAppManagementDataRequestBuilder ExportDeviceAndAppManagementData() {
            return new ExportDeviceAndAppManagementDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.exportDeviceAndAppManagementData(skip={skip},top={top})
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="top">Usage: top={top}</param>
        /// </summary>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder ExportDeviceAndAppManagementDataWithSkipWithTop(int? skip, int? top) {
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(PathParameters, RequestAdapter, skip, top);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.findRoomLists()
        /// </summary>
        public FindRoomListsRequestBuilder FindRoomLists() {
            return new FindRoomListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.findRooms()
        /// </summary>
        public FindRoomsRequestBuilder FindRooms() {
            return new FindRoomsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.findRooms(RoomList='{RoomList}')
        /// <param name="RoomList">Usage: RoomList={RoomList}</param>
        /// </summary>
        public FindRoomsWithRoomListRequestBuilder FindRoomsWithRoomList(string roomList) {
            if(string.IsNullOrEmpty(roomList)) throw new ArgumentNullException(nameof(roomList));
            return new FindRoomsWithRoomListRequestBuilder(PathParameters, RequestAdapter, roomList);
        }
        /// <summary>
        /// Get entity from users by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraph.Models.Microsoft.Graph.User> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraph.Models.Microsoft.Graph.User>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getEffectiveDeviceEnrollmentConfigurations()
        /// </summary>
        public GetEffectiveDeviceEnrollmentConfigurationsRequestBuilder GetEffectiveDeviceEnrollmentConfigurations() {
            return new GetEffectiveDeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getLoggedOnManagedDevices()
        /// </summary>
        public GetLoggedOnManagedDevicesRequestBuilder GetLoggedOnManagedDevices() {
            return new GetLoggedOnManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedAppDiagnosticStatuses()
        /// </summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses() {
            return new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedAppPolicies()
        /// </summary>
        public GetManagedAppPoliciesRequestBuilder GetManagedAppPolicies() {
            return new GetManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedDevicesWithAppFailures()
        /// </summary>
        public GetManagedDevicesWithAppFailuresRequestBuilder GetManagedDevicesWithAppFailures() {
            return new GetManagedDevicesWithAppFailuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedDevicesWithFailedOrPendingApps()
        /// </summary>
        public GetManagedDevicesWithFailedOrPendingAppsRequestBuilder GetManagedDevicesWithFailedOrPendingApps() {
            return new GetManagedDevicesWithFailedOrPendingAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.isManagedAppUserBlocked()
        /// </summary>
        public IsManagedAppUserBlockedRequestBuilder IsManagedAppUserBlocked() {
            return new IsManagedAppUserBlockedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update entity in users
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraph.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')
        /// <param name="EndDateTime">Usage: EndDateTime={EndDateTime}</param>
        /// <param name="StartDateTime">Usage: StartDateTime={StartDateTime}</param>
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder ReminderViewWithStartDateTimeWithEndDateTime(string startDateTime, string endDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, startDateTime, endDateTime);
        }
        /// <summary>Get entity from users by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
