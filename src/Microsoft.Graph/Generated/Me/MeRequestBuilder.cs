using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Me.ActivateServicePlan;
using MicrosoftGraphSdk.Me.Activities;
using MicrosoftGraphSdk.Me.AgreementAcceptances;
using MicrosoftGraphSdk.Me.Analytics;
using MicrosoftGraphSdk.Me.AppConsentRequestsForApproval;
using MicrosoftGraphSdk.Me.AppRoleAssignments;
using MicrosoftGraphSdk.Me.Approvals;
using MicrosoftGraphSdk.Me.AssignLicense;
using MicrosoftGraphSdk.Me.Authentication;
using MicrosoftGraphSdk.Me.Calendar;
using MicrosoftGraphSdk.Me.CalendarGroups;
using MicrosoftGraphSdk.Me.Calendars;
using MicrosoftGraphSdk.Me.CalendarView;
using MicrosoftGraphSdk.Me.ChangePassword;
using MicrosoftGraphSdk.Me.Chats;
using MicrosoftGraphSdk.Me.CheckMemberGroups;
using MicrosoftGraphSdk.Me.CheckMemberObjects;
using MicrosoftGraphSdk.Me.CloudPCs;
using MicrosoftGraphSdk.Me.ContactFolders;
using MicrosoftGraphSdk.Me.Contacts;
using MicrosoftGraphSdk.Me.CreatedObjects;
using MicrosoftGraphSdk.Me.DeviceEnrollmentConfigurations;
using MicrosoftGraphSdk.Me.DeviceManagementTroubleshootingEvents;
using MicrosoftGraphSdk.Me.Devices;
using MicrosoftGraphSdk.Me.DirectReports;
using MicrosoftGraphSdk.Me.Drive;
using MicrosoftGraphSdk.Me.Drives;
using MicrosoftGraphSdk.Me.Events;
using MicrosoftGraphSdk.Me.ExportDeviceAndAppManagementData;
using MicrosoftGraphSdk.Me.ExportDeviceAndAppManagementDataWithSkipWithTop;
using MicrosoftGraphSdk.Me.ExportPersonalData;
using MicrosoftGraphSdk.Me.Extensions;
using MicrosoftGraphSdk.Me.FindMeetingTimes;
using MicrosoftGraphSdk.Me.FindRoomLists;
using MicrosoftGraphSdk.Me.FindRooms;
using MicrosoftGraphSdk.Me.FindRoomsWithRoomList;
using MicrosoftGraphSdk.Me.FollowedSites;
using MicrosoftGraphSdk.Me.GetEffectiveDeviceEnrollmentConfigurations;
using MicrosoftGraphSdk.Me.GetLoggedOnManagedDevices;
using MicrosoftGraphSdk.Me.GetMailTips;
using MicrosoftGraphSdk.Me.GetManagedAppDiagnosticStatuses;
using MicrosoftGraphSdk.Me.GetManagedAppPolicies;
using MicrosoftGraphSdk.Me.GetManagedDevicesWithAppFailures;
using MicrosoftGraphSdk.Me.GetManagedDevicesWithFailedOrPendingApps;
using MicrosoftGraphSdk.Me.GetMemberGroups;
using MicrosoftGraphSdk.Me.GetMemberObjects;
using MicrosoftGraphSdk.Me.InferenceClassification;
using MicrosoftGraphSdk.Me.InformationProtection;
using MicrosoftGraphSdk.Me.Insights;
using MicrosoftGraphSdk.Me.InvalidateAllRefreshTokens;
using MicrosoftGraphSdk.Me.IsManagedAppUserBlocked;
using MicrosoftGraphSdk.Me.JoinedGroups;
using MicrosoftGraphSdk.Me.JoinedTeams;
using MicrosoftGraphSdk.Me.LicenseDetails;
using MicrosoftGraphSdk.Me.MailFolders;
using MicrosoftGraphSdk.Me.ManagedAppRegistrations;
using MicrosoftGraphSdk.Me.ManagedDevices;
using MicrosoftGraphSdk.Me.Manager;
using MicrosoftGraphSdk.Me.MemberOf;
using MicrosoftGraphSdk.Me.Messages;
using MicrosoftGraphSdk.Me.MobileAppIntentAndStates;
using MicrosoftGraphSdk.Me.MobileAppTroubleshootingEvents;
using MicrosoftGraphSdk.Me.Notifications;
using MicrosoftGraphSdk.Me.Oauth2PermissionGrants;
using MicrosoftGraphSdk.Me.Onenote;
using MicrosoftGraphSdk.Me.OnlineMeetings;
using MicrosoftGraphSdk.Me.Outlook;
using MicrosoftGraphSdk.Me.OwnedDevices;
using MicrosoftGraphSdk.Me.OwnedObjects;
using MicrosoftGraphSdk.Me.PendingAccessReviewInstances;
using MicrosoftGraphSdk.Me.People;
using MicrosoftGraphSdk.Me.Photo;
using MicrosoftGraphSdk.Me.Photos;
using MicrosoftGraphSdk.Me.Planner;
using MicrosoftGraphSdk.Me.Presence;
using MicrosoftGraphSdk.Me.Profile;
using MicrosoftGraphSdk.Me.RegisteredDevices;
using MicrosoftGraphSdk.Me.ReminderViewWithStartDateTimeWithEndDateTime;
using MicrosoftGraphSdk.Me.RemoveAllDevicesFromManagement;
using MicrosoftGraphSdk.Me.ReprocessLicenseAssignment;
using MicrosoftGraphSdk.Me.Restore;
using MicrosoftGraphSdk.Me.RevokeSignInSessions;
using MicrosoftGraphSdk.Me.ScopedRoleMemberOf;
using MicrosoftGraphSdk.Me.Security;
using MicrosoftGraphSdk.Me.SendMail;
using MicrosoftGraphSdk.Me.Settings;
using MicrosoftGraphSdk.Me.Tasks;
using MicrosoftGraphSdk.Me.Teamwork;
using MicrosoftGraphSdk.Me.Todo;
using MicrosoftGraphSdk.Me.TransitiveMemberOf;
using MicrosoftGraphSdk.Me.TransitiveReports;
using MicrosoftGraphSdk.Me.TranslateExchangeIds;
using MicrosoftGraphSdk.Me.UnblockManagedApps;
using MicrosoftGraphSdk.Me.UsageRights;
using MicrosoftGraphSdk.Me.WindowsInformationProtectionDeviceRegistrations;
using MicrosoftGraphSdk.Me.WipeAndBlockManagedApps;
using MicrosoftGraphSdk.Me.WipeManagedAppRegistrationByDeviceTag;
using MicrosoftGraphSdk.Me.WipeManagedAppRegistrationsByDeviceTag;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Me {
    /// <summary>Provides operations to manage the user singleton.</summary>
    public class MeRequestBuilder {
        /// <summary>The activateServicePlan property</summary>
        public ActivateServicePlanRequestBuilder ActivateServicePlan { get =>
            new ActivateServicePlanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The activities property</summary>
        public ActivitiesRequestBuilder Activities { get =>
            new ActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The agreementAcceptances property</summary>
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The analytics property</summary>
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appConsentRequestsForApproval property</summary>
        public AppConsentRequestsForApprovalRequestBuilder AppConsentRequestsForApproval { get =>
            new AppConsentRequestsForApprovalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appRoleAssignments property</summary>
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The approvals property</summary>
        public ApprovalsRequestBuilder Approvals { get =>
            new ApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignLicense property</summary>
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authentication property</summary>
        public AuthenticationRequestBuilder Authentication { get =>
            new AuthenticationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The calendar property</summary>
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The calendarGroups property</summary>
        public CalendarGroupsRequestBuilder CalendarGroups { get =>
            new CalendarGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The calendars property</summary>
        public CalendarsRequestBuilder Calendars { get =>
            new CalendarsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The calendarView property</summary>
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The changePassword property</summary>
        public ChangePasswordRequestBuilder ChangePassword { get =>
            new ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The chats property</summary>
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkMemberGroups property</summary>
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkMemberObjects property</summary>
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cloudPCs property</summary>
        public CloudPCsRequestBuilder CloudPCs { get =>
            new CloudPCsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contactFolders property</summary>
        public ContactFoldersRequestBuilder ContactFolders { get =>
            new ContactFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contacts property</summary>
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createdObjects property</summary>
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceEnrollmentConfigurations property</summary>
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceManagementTroubleshootingEvents property</summary>
        public DeviceManagementTroubleshootingEventsRequestBuilder DeviceManagementTroubleshootingEvents { get =>
            new DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The devices property</summary>
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directReports property</summary>
        public DirectReportsRequestBuilder DirectReports { get =>
            new DirectReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The drive property</summary>
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The drives property</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The exportPersonalData property</summary>
        public ExportPersonalDataRequestBuilder ExportPersonalData { get =>
            new ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The extensions property</summary>
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The findMeetingTimes property</summary>
        public FindMeetingTimesRequestBuilder FindMeetingTimes { get =>
            new FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The followedSites property</summary>
        public FollowedSitesRequestBuilder FollowedSites { get =>
            new FollowedSitesRequestBuilder(PathParameters, RequestAdapter);
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
        /// <summary>The inferenceClassification property</summary>
        public InferenceClassificationRequestBuilder InferenceClassification { get =>
            new InferenceClassificationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The informationProtection property</summary>
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The insights property</summary>
        public InsightsRequestBuilder Insights { get =>
            new InsightsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invalidateAllRefreshTokens property</summary>
        public InvalidateAllRefreshTokensRequestBuilder InvalidateAllRefreshTokens { get =>
            new InvalidateAllRefreshTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The joinedGroups property</summary>
        public JoinedGroupsRequestBuilder JoinedGroups { get =>
            new JoinedGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The joinedTeams property</summary>
        public JoinedTeamsRequestBuilder JoinedTeams { get =>
            new JoinedTeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The licenseDetails property</summary>
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mailFolders property</summary>
        public MailFoldersRequestBuilder MailFolders { get =>
            new MailFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedAppRegistrations property</summary>
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedDevices property</summary>
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The manager property</summary>
        public ManagerRequestBuilder Manager { get =>
            new ManagerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memberOf property</summary>
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The messages property</summary>
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileAppIntentAndStates property</summary>
        public MobileAppIntentAndStatesRequestBuilder MobileAppIntentAndStates { get =>
            new MobileAppIntentAndStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileAppTroubleshootingEvents property</summary>
        public MobileAppTroubleshootingEventsRequestBuilder MobileAppTroubleshootingEvents { get =>
            new MobileAppTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notifications property</summary>
        public NotificationsRequestBuilder Notifications { get =>
            new NotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oauth2PermissionGrants property</summary>
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The onenote property</summary>
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The onlineMeetings property</summary>
        public OnlineMeetingsRequestBuilder OnlineMeetings { get =>
            new OnlineMeetingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The outlook property</summary>
        public OutlookRequestBuilder Outlook { get =>
            new OutlookRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ownedDevices property</summary>
        public OwnedDevicesRequestBuilder OwnedDevices { get =>
            new OwnedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ownedObjects property</summary>
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The pendingAccessReviewInstances property</summary>
        public PendingAccessReviewInstancesRequestBuilder PendingAccessReviewInstances { get =>
            new PendingAccessReviewInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The people property</summary>
        public PeopleRequestBuilder People { get =>
            new PeopleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The photo property</summary>
        public PhotoRequestBuilder Photo { get =>
            new PhotoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The photos property</summary>
        public PhotosRequestBuilder Photos { get =>
            new PhotosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The planner property</summary>
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The presence property</summary>
        public PresenceRequestBuilder Presence { get =>
            new PresenceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profile property</summary>
        public ProfileRequestBuilder Profile { get =>
            new ProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The registeredDevices property</summary>
        public RegisteredDevicesRequestBuilder RegisteredDevices { get =>
            new RegisteredDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
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
        /// <summary>The scopedRoleMemberOf property</summary>
        public ScopedRoleMemberOfRequestBuilder ScopedRoleMemberOf { get =>
            new ScopedRoleMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The security property</summary>
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sendMail property</summary>
        public SendMailRequestBuilder SendMail { get =>
            new SendMailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tasks property</summary>
        public TasksRequestBuilder Tasks { get =>
            new TasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teamwork property</summary>
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The todo property</summary>
        public TodoRequestBuilder Todo { get =>
            new TodoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transitiveMemberOf property</summary>
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transitiveReports property</summary>
        public TransitiveReportsRequestBuilder TransitiveReports { get =>
            new TransitiveReportsRequestBuilder(PathParameters, RequestAdapter);
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
        /// <summary>The usageRights property</summary>
        public UsageRightsRequestBuilder UsageRights { get =>
            new UsageRightsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionDeviceRegistrations property</summary>
        public WindowsInformationProtectionDeviceRegistrationsRequestBuilder WindowsInformationProtectionDeviceRegistrations { get =>
            new WindowsInformationProtectionDeviceRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wipeAndBlockManagedApps property</summary>
        public WipeAndBlockManagedAppsRequestBuilder WipeAndBlockManagedApps { get =>
            new WipeAndBlockManagedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wipeManagedAppRegistrationByDeviceTag property</summary>
        public WipeManagedAppRegistrationByDeviceTagRequestBuilder WipeManagedAppRegistrationByDeviceTag { get =>
            new WipeManagedAppRegistrationByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wipeManagedAppRegistrationsByDeviceTag property</summary>
        public WipeManagedAppRegistrationsByDeviceTagRequestBuilder WipeManagedAppRegistrationsByDeviceTag { get =>
            new WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new MeRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new MeRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get me
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update me
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
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
        /// Get me
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.User> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.User>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.User.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
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
        /// Update me
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
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
        /// <summary>Get me</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
