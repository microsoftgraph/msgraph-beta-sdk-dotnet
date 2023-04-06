using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Users.Item.Activities;
using Microsoft.Graph.Beta.Users.Item.AgreementAcceptances;
using Microsoft.Graph.Beta.Users.Item.Analytics;
using Microsoft.Graph.Beta.Users.Item.AppConsentRequestsForApproval;
using Microsoft.Graph.Beta.Users.Item.AppRoleAssignedResources;
using Microsoft.Graph.Beta.Users.Item.AppRoleAssignments;
using Microsoft.Graph.Beta.Users.Item.Approvals;
using Microsoft.Graph.Beta.Users.Item.AssignLicense;
using Microsoft.Graph.Beta.Users.Item.Authentication;
using Microsoft.Graph.Beta.Users.Item.Calendar;
using Microsoft.Graph.Beta.Users.Item.CalendarGroups;
using Microsoft.Graph.Beta.Users.Item.CalendarView;
using Microsoft.Graph.Beta.Users.Item.Calendars;
using Microsoft.Graph.Beta.Users.Item.ChangePassword;
using Microsoft.Graph.Beta.Users.Item.Chats;
using Microsoft.Graph.Beta.Users.Item.CheckMemberGroups;
using Microsoft.Graph.Beta.Users.Item.CheckMemberObjects;
using Microsoft.Graph.Beta.Users.Item.CloudPCs;
using Microsoft.Graph.Beta.Users.Item.ContactFolders;
using Microsoft.Graph.Beta.Users.Item.Contacts;
using Microsoft.Graph.Beta.Users.Item.CreatedObjects;
using Microsoft.Graph.Beta.Users.Item.DeviceEnrollmentConfigurations;
using Microsoft.Graph.Beta.Users.Item.DeviceManagementTroubleshootingEvents;
using Microsoft.Graph.Beta.Users.Item.Devices;
using Microsoft.Graph.Beta.Users.Item.DirectReports;
using Microsoft.Graph.Beta.Users.Item.Drive;
using Microsoft.Graph.Beta.Users.Item.Drives;
using Microsoft.Graph.Beta.Users.Item.Events;
using Microsoft.Graph.Beta.Users.Item.ExportDeviceAndAppManagementData;
using Microsoft.Graph.Beta.Users.Item.ExportDeviceAndAppManagementDataWithSkipWithTop;
using Microsoft.Graph.Beta.Users.Item.ExportPersonalData;
using Microsoft.Graph.Beta.Users.Item.Extensions;
using Microsoft.Graph.Beta.Users.Item.FindMeetingTimes;
using Microsoft.Graph.Beta.Users.Item.FindRoomLists;
using Microsoft.Graph.Beta.Users.Item.FindRooms;
using Microsoft.Graph.Beta.Users.Item.FindRoomsWithRoomList;
using Microsoft.Graph.Beta.Users.Item.FollowedSites;
using Microsoft.Graph.Beta.Users.Item.GetEffectiveDeviceEnrollmentConfigurations;
using Microsoft.Graph.Beta.Users.Item.GetLoggedOnManagedDevices;
using Microsoft.Graph.Beta.Users.Item.GetMailTips;
using Microsoft.Graph.Beta.Users.Item.GetManagedAppDiagnosticStatuses;
using Microsoft.Graph.Beta.Users.Item.GetManagedAppPolicies;
using Microsoft.Graph.Beta.Users.Item.GetManagedDevicesWithAppFailures;
using Microsoft.Graph.Beta.Users.Item.GetManagedDevicesWithFailedOrPendingApps;
using Microsoft.Graph.Beta.Users.Item.GetMemberGroups;
using Microsoft.Graph.Beta.Users.Item.GetMemberObjects;
using Microsoft.Graph.Beta.Users.Item.InferenceClassification;
using Microsoft.Graph.Beta.Users.Item.InformationProtection;
using Microsoft.Graph.Beta.Users.Item.Insights;
using Microsoft.Graph.Beta.Users.Item.InvalidateAllRefreshTokens;
using Microsoft.Graph.Beta.Users.Item.IsManagedAppUserBlocked;
using Microsoft.Graph.Beta.Users.Item.JoinedGroups;
using Microsoft.Graph.Beta.Users.Item.JoinedTeams;
using Microsoft.Graph.Beta.Users.Item.LicenseDetails;
using Microsoft.Graph.Beta.Users.Item.MailFolders;
using Microsoft.Graph.Beta.Users.Item.ManagedAppRegistrations;
using Microsoft.Graph.Beta.Users.Item.ManagedDevices;
using Microsoft.Graph.Beta.Users.Item.Manager;
using Microsoft.Graph.Beta.Users.Item.MemberOf;
using Microsoft.Graph.Beta.Users.Item.Messages;
using Microsoft.Graph.Beta.Users.Item.MobileAppIntentAndStates;
using Microsoft.Graph.Beta.Users.Item.MobileAppTroubleshootingEvents;
using Microsoft.Graph.Beta.Users.Item.Notifications;
using Microsoft.Graph.Beta.Users.Item.Oauth2PermissionGrants;
using Microsoft.Graph.Beta.Users.Item.Onenote;
using Microsoft.Graph.Beta.Users.Item.OnlineMeetings;
using Microsoft.Graph.Beta.Users.Item.Outlook;
using Microsoft.Graph.Beta.Users.Item.OwnedDevices;
using Microsoft.Graph.Beta.Users.Item.OwnedObjects;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances;
using Microsoft.Graph.Beta.Users.Item.People;
using Microsoft.Graph.Beta.Users.Item.Photo;
using Microsoft.Graph.Beta.Users.Item.Photos;
using Microsoft.Graph.Beta.Users.Item.Planner;
using Microsoft.Graph.Beta.Users.Item.Presence;
using Microsoft.Graph.Beta.Users.Item.Profile;
using Microsoft.Graph.Beta.Users.Item.RegisteredDevices;
using Microsoft.Graph.Beta.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Beta.Users.Item.RemoveAllDevicesFromManagement;
using Microsoft.Graph.Beta.Users.Item.ReprocessLicenseAssignment;
using Microsoft.Graph.Beta.Users.Item.Restore;
using Microsoft.Graph.Beta.Users.Item.RevokeSignInSessions;
using Microsoft.Graph.Beta.Users.Item.ScopedRoleMemberOf;
using Microsoft.Graph.Beta.Users.Item.Security;
using Microsoft.Graph.Beta.Users.Item.SendMail;
using Microsoft.Graph.Beta.Users.Item.Settings;
using Microsoft.Graph.Beta.Users.Item.Teamwork;
using Microsoft.Graph.Beta.Users.Item.Todo;
using Microsoft.Graph.Beta.Users.Item.TransitiveMemberOf;
using Microsoft.Graph.Beta.Users.Item.TransitiveReports;
using Microsoft.Graph.Beta.Users.Item.TranslateExchangeIds;
using Microsoft.Graph.Beta.Users.Item.UnblockManagedApps;
using Microsoft.Graph.Beta.Users.Item.UsageRights;
using Microsoft.Graph.Beta.Users.Item.WindowsInformationProtectionDeviceRegistrations;
using Microsoft.Graph.Beta.Users.Item.WipeAndBlockManagedApps;
using Microsoft.Graph.Beta.Users.Item.WipeManagedAppRegistrationByDeviceTag;
using Microsoft.Graph.Beta.Users.Item.WipeManagedAppRegistrationsByAzureAdDeviceId;
using Microsoft.Graph.Beta.Users.Item.WipeManagedAppRegistrationsByDeviceTag;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item {
    /// <summary>
    /// Provides operations to manage the collection of user entities.
    /// </summary>
    public class UserItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the activities property of the microsoft.graph.user entity.</summary>
        public ActivitiesRequestBuilder Activities { get =>
            new ActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the agreementAcceptances property of the microsoft.graph.user entity.</summary>
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.user entity.</summary>
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appConsentRequestsForApproval property of the microsoft.graph.user entity.</summary>
        public AppConsentRequestsForApprovalRequestBuilder AppConsentRequestsForApproval { get =>
            new AppConsentRequestsForApprovalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appRoleAssignedResources property of the microsoft.graph.user entity.</summary>
        public AppRoleAssignedResourcesRequestBuilder AppRoleAssignedResources { get =>
            new AppRoleAssignedResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appRoleAssignments property of the microsoft.graph.user entity.</summary>
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the approvals property of the microsoft.graph.user entity.</summary>
        public ApprovalsRequestBuilder Approvals { get =>
            new ApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the assignLicense method.</summary>
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authentication property of the microsoft.graph.user entity.</summary>
        public AuthenticationRequestBuilder Authentication { get =>
            new AuthenticationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendar property of the microsoft.graph.user entity.</summary>
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendarGroups property of the microsoft.graph.user entity.</summary>
        public CalendarGroupsRequestBuilder CalendarGroups { get =>
            new CalendarGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendars property of the microsoft.graph.user entity.</summary>
        public CalendarsRequestBuilder Calendars { get =>
            new CalendarsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendarView property of the microsoft.graph.user entity.</summary>
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the changePassword method.</summary>
        public ChangePasswordRequestBuilder ChangePassword { get =>
            new ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the chats property of the microsoft.graph.user entity.</summary>
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudPCs property of the microsoft.graph.user entity.</summary>
        public CloudPCsRequestBuilder CloudPCs { get =>
            new CloudPCsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contactFolders property of the microsoft.graph.user entity.</summary>
        public ContactFoldersRequestBuilder ContactFolders { get =>
            new ContactFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contacts property of the microsoft.graph.user entity.</summary>
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdObjects property of the microsoft.graph.user entity.</summary>
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceEnrollmentConfigurations property of the microsoft.graph.user entity.</summary>
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceManagementTroubleshootingEvents property of the microsoft.graph.user entity.</summary>
        public DeviceManagementTroubleshootingEventsRequestBuilder DeviceManagementTroubleshootingEvents { get =>
            new DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the devices property of the microsoft.graph.user entity.</summary>
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the directReports property of the microsoft.graph.user entity.</summary>
        public DirectReportsRequestBuilder DirectReports { get =>
            new DirectReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.user entity.</summary>
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.user entity.</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the events property of the microsoft.graph.user entity.</summary>
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the exportDeviceAndAppManagementData method.</summary>
        public ExportDeviceAndAppManagementDataRequestBuilder ExportDeviceAndAppManagementData { get =>
            new ExportDeviceAndAppManagementDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the exportPersonalData method.</summary>
        public ExportPersonalDataRequestBuilder ExportPersonalData { get =>
            new ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.user entity.</summary>
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the findMeetingTimes method.</summary>
        public FindMeetingTimesRequestBuilder FindMeetingTimes { get =>
            new FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the findRoomLists method.</summary>
        public FindRoomListsRequestBuilder FindRoomLists { get =>
            new FindRoomListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the findRooms method.</summary>
        public FindRoomsRequestBuilder FindRooms { get =>
            new FindRoomsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the followedSites property of the microsoft.graph.user entity.</summary>
        public FollowedSitesRequestBuilder FollowedSites { get =>
            new FollowedSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getEffectiveDeviceEnrollmentConfigurations method.</summary>
        public GetEffectiveDeviceEnrollmentConfigurationsRequestBuilder GetEffectiveDeviceEnrollmentConfigurations { get =>
            new GetEffectiveDeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getLoggedOnManagedDevices method.</summary>
        public GetLoggedOnManagedDevicesRequestBuilder GetLoggedOnManagedDevices { get =>
            new GetLoggedOnManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMailTips method.</summary>
        public GetMailTipsRequestBuilder GetMailTips { get =>
            new GetMailTipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getManagedAppDiagnosticStatuses method.</summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses { get =>
            new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getManagedAppPolicies method.</summary>
        public GetManagedAppPoliciesRequestBuilder GetManagedAppPolicies { get =>
            new GetManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getManagedDevicesWithAppFailures method.</summary>
        public GetManagedDevicesWithAppFailuresRequestBuilder GetManagedDevicesWithAppFailures { get =>
            new GetManagedDevicesWithAppFailuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getManagedDevicesWithFailedOrPendingApps method.</summary>
        public GetManagedDevicesWithFailedOrPendingAppsRequestBuilder GetManagedDevicesWithFailedOrPendingApps { get =>
            new GetManagedDevicesWithFailedOrPendingAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the inferenceClassification property of the microsoft.graph.user entity.</summary>
        public InferenceClassificationRequestBuilder InferenceClassification { get =>
            new InferenceClassificationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the informationProtection property of the microsoft.graph.user entity.</summary>
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the insights property of the microsoft.graph.user entity.</summary>
        public InsightsRequestBuilder Insights { get =>
            new InsightsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the invalidateAllRefreshTokens method.</summary>
        public InvalidateAllRefreshTokensRequestBuilder InvalidateAllRefreshTokens { get =>
            new InvalidateAllRefreshTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the isManagedAppUserBlocked method.</summary>
        public IsManagedAppUserBlockedRequestBuilder IsManagedAppUserBlocked { get =>
            new IsManagedAppUserBlockedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the joinedGroups property of the microsoft.graph.user entity.</summary>
        public JoinedGroupsRequestBuilder JoinedGroups { get =>
            new JoinedGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the joinedTeams property of the microsoft.graph.user entity.</summary>
        public JoinedTeamsRequestBuilder JoinedTeams { get =>
            new JoinedTeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the licenseDetails property of the microsoft.graph.user entity.</summary>
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mailFolders property of the microsoft.graph.user entity.</summary>
        public MailFoldersRequestBuilder MailFolders { get =>
            new MailFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedAppRegistrations property of the microsoft.graph.user entity.</summary>
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDevices property of the microsoft.graph.user entity.</summary>
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the manager property of the microsoft.graph.user entity.</summary>
        public ManagerRequestBuilder Manager { get =>
            new ManagerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the memberOf property of the microsoft.graph.user entity.</summary>
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the messages property of the microsoft.graph.user entity.</summary>
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileAppIntentAndStates property of the microsoft.graph.user entity.</summary>
        public MobileAppIntentAndStatesRequestBuilder MobileAppIntentAndStates { get =>
            new MobileAppIntentAndStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileAppTroubleshootingEvents property of the microsoft.graph.user entity.</summary>
        public MobileAppTroubleshootingEventsRequestBuilder MobileAppTroubleshootingEvents { get =>
            new MobileAppTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the notifications property of the microsoft.graph.user entity.</summary>
        public NotificationsRequestBuilder Notifications { get =>
            new NotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.user entity.</summary>
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.user entity.</summary>
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.</summary>
        public OnlineMeetingsRequestBuilder OnlineMeetings { get =>
            new OnlineMeetingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the outlook property of the microsoft.graph.user entity.</summary>
        public OutlookRequestBuilder Outlook { get =>
            new OutlookRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the ownedDevices property of the microsoft.graph.user entity.</summary>
        public OwnedDevicesRequestBuilder OwnedDevices { get =>
            new OwnedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the ownedObjects property of the microsoft.graph.user entity.</summary>
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the pendingAccessReviewInstances property of the microsoft.graph.user entity.</summary>
        public PendingAccessReviewInstancesRequestBuilder PendingAccessReviewInstances { get =>
            new PendingAccessReviewInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the people property of the microsoft.graph.user entity.</summary>
        public PeopleRequestBuilder People { get =>
            new PeopleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the photo property of the microsoft.graph.user entity.</summary>
        public PhotoRequestBuilder Photo { get =>
            new PhotoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the photos property of the microsoft.graph.user entity.</summary>
        public PhotosRequestBuilder Photos { get =>
            new PhotosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the planner property of the microsoft.graph.user entity.</summary>
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the presence property of the microsoft.graph.user entity.</summary>
        public PresenceRequestBuilder Presence { get =>
            new PresenceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the profile property of the microsoft.graph.user entity.</summary>
        public ProfileRequestBuilder Profile { get =>
            new ProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the registeredDevices property of the microsoft.graph.user entity.</summary>
        public RegisteredDevicesRequestBuilder RegisteredDevices { get =>
            new RegisteredDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeAllDevicesFromManagement method.</summary>
        public RemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement { get =>
            new RemoveAllDevicesFromManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reprocessLicenseAssignment method.</summary>
        public ReprocessLicenseAssignmentRequestBuilder ReprocessLicenseAssignment { get =>
            new ReprocessLicenseAssignmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the revokeSignInSessions method.</summary>
        public RevokeSignInSessionsRequestBuilder RevokeSignInSessions { get =>
            new RevokeSignInSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the scopedRoleMemberOf property of the microsoft.graph.user entity.</summary>
        public ScopedRoleMemberOfRequestBuilder ScopedRoleMemberOf { get =>
            new ScopedRoleMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the security property of the microsoft.graph.user entity.</summary>
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendMail method.</summary>
        public SendMailRequestBuilder SendMail { get =>
            new SendMailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settings property of the microsoft.graph.user entity.</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the teamwork property of the microsoft.graph.user entity.</summary>
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the todo property of the microsoft.graph.user entity.</summary>
        public TodoRequestBuilder Todo { get =>
            new TodoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.user entity.</summary>
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveReports property of the microsoft.graph.user entity.</summary>
        public TransitiveReportsRequestBuilder TransitiveReports { get =>
            new TransitiveReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the translateExchangeIds method.</summary>
        public TranslateExchangeIdsRequestBuilder TranslateExchangeIds { get =>
            new TranslateExchangeIdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unblockManagedApps method.</summary>
        public UnblockManagedAppsRequestBuilder UnblockManagedApps { get =>
            new UnblockManagedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the usageRights property of the microsoft.graph.user entity.</summary>
        public UsageRightsRequestBuilder UsageRights { get =>
            new UsageRightsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsInformationProtectionDeviceRegistrations property of the microsoft.graph.user entity.</summary>
        public WindowsInformationProtectionDeviceRegistrationsRequestBuilder WindowsInformationProtectionDeviceRegistrations { get =>
            new WindowsInformationProtectionDeviceRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipeAndBlockManagedApps method.</summary>
        public WipeAndBlockManagedAppsRequestBuilder WipeAndBlockManagedApps { get =>
            new WipeAndBlockManagedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipeManagedAppRegistrationByDeviceTag method.</summary>
        public WipeManagedAppRegistrationByDeviceTagRequestBuilder WipeManagedAppRegistrationByDeviceTag { get =>
            new WipeManagedAppRegistrationByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipeManagedAppRegistrationsByAzureAdDeviceId method.</summary>
        public WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder WipeManagedAppRegistrationsByAzureAdDeviceId { get =>
            new WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipeManagedAppRegistrationsByDeviceTag method.</summary>
        public WipeManagedAppRegistrationsByDeviceTagRequestBuilder WipeManagedAppRegistrationsByDeviceTag { get =>
            new WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete user.   When deleted, user resources are moved to a temporary container and can be restored within 30 days.  After that time, they are permanently deleted.  To learn more, see deletedItems.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<UserItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<UserItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the exportDeviceAndAppManagementData method.
        /// </summary>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="top">Usage: top={top}</param>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder ExportDeviceAndAppManagementDataWithSkipWithTop(int? skip, int? top) {
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(PathParameters, RequestAdapter, skip, top);
        }
        /// <summary>
        /// Provides operations to call the findRooms method.
        /// </summary>
        /// <param name="roomList">Usage: RoomList=&apos;{RoomList}&apos;</param>
        public FindRoomsWithRoomListRequestBuilder FindRoomsWithRoomList(string roomList) {
            if(string.IsNullOrEmpty(roomList)) throw new ArgumentNullException(nameof(roomList));
            return new FindRoomsWithRoomListRequestBuilder(PathParameters, RequestAdapter, roomList);
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object. This operation returns by default only a subset of the more commonly used properties for each user. These _default_ properties are noted in the Properties section. To get properties that are _not_ returned by default, do a GET operation for the user and specify the properties in a `$select` OData query option. Because the **user** resource supports extensions, you can also use the `GET` operation to get custom properties and extension data in a **user** instance.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.User?> GetAsync(Action<UserItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.User> GetAsync(Action<UserItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.User>(requestInfo, Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the properties of a user object. Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles. Compare member and guest default permissions to see properties they can manage.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/user-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.User?> PatchAsync(Microsoft.Graph.Beta.Models.User body, Action<UserItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.User> PatchAsync(Microsoft.Graph.Beta.Models.User body, Action<UserItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.User>(requestInfo, Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the reminderView method.
        /// </summary>
        /// <param name="endDateTime">Usage: EndDateTime=&apos;{EndDateTime}&apos;</param>
        /// <param name="startDateTime">Usage: StartDateTime=&apos;{StartDateTime}&apos;</param>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder ReminderViewWithStartDateTimeWithEndDateTime(string endDateTime, string startDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, startDateTime);
        }
        /// <summary>
        /// Delete user.   When deleted, user resources are moved to a temporary container and can be restored within 30 days.  After that time, they are permanently deleted.  To learn more, see deletedItems.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<UserItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<UserItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new UserItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object. This operation returns by default only a subset of the more commonly used properties for each user. These _default_ properties are noted in the Properties section. To get properties that are _not_ returned by default, do a GET operation for the user and specify the properties in a `$select` OData query option. Because the **user** resource supports extensions, you can also use the `GET` operation to get custom properties and extension data in a **user** instance.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<UserItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<UserItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new UserItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a user object. Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles. Compare member and guest default permissions to see properties they can manage.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.User body, Action<UserItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.User body, Action<UserItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new UserItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public UserItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object. This operation returns by default only a subset of the more commonly used properties for each user. These _default_ properties are noted in the Properties section. To get properties that are _not_ returned by default, do a GET operation for the user and specify the properties in a `$select` OData query option. Because the **user** resource supports extensions, you can also use the `GET` operation to get custom properties and extension data in a **user** instance.
        /// </summary>
        public class UserItemRequestBuilderGetQueryParameters {
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
        public class UserItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UserItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UserItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new UserItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UserItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public UserItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
