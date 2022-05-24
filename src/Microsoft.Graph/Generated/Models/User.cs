using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class User : DirectoryObject, IParsable {
        /// <summary>A freeform text entry field for the user to describe themselves. Returned only on $select.</summary>
        public string AboutMe {
            get { return BackingStore?.Get<string>(nameof(AboutMe)); }
            set { BackingStore?.Set(nameof(AboutMe), value); }
        }
        /// <summary>true if the account is enabled; otherwise, false. This property is required when a user is created. Supports $filter (eq, ne, not, and in).</summary>
        public bool? AccountEnabled {
            get { return BackingStore?.Get<bool?>(nameof(AccountEnabled)); }
            set { BackingStore?.Set(nameof(AccountEnabled), value); }
        }
        /// <summary>The user&apos;s activities across devices. Read-only. Nullable.</summary>
        public List<UserActivity> Activities {
            get { return BackingStore?.Get<List<UserActivity>>(nameof(Activities)); }
            set { BackingStore?.Set(nameof(Activities), value); }
        }
        /// <summary>Sets the age group of the user. Allowed values: null, Minor, NotAdult and Adult. Refer to the legal age group property definitions for further information. Supports $filter (eq, ne, not, and in).</summary>
        public string AgeGroup {
            get { return BackingStore?.Get<string>(nameof(AgeGroup)); }
            set { BackingStore?.Set(nameof(AgeGroup), value); }
        }
        /// <summary>The user&apos;s terms of use acceptance statuses. Read-only. Nullable.</summary>
        public List<AgreementAcceptance> AgreementAcceptances {
            get { return BackingStore?.Get<List<AgreementAcceptance>>(nameof(AgreementAcceptances)); }
            set { BackingStore?.Set(nameof(AgreementAcceptances), value); }
        }
        /// <summary>The analytics property</summary>
        public UserAnalytics Analytics {
            get { return BackingStore?.Get<UserAnalytics>(nameof(Analytics)); }
            set { BackingStore?.Set(nameof(Analytics), value); }
        }
        /// <summary>The appConsentRequestsForApproval property</summary>
        public List<AppConsentRequest> AppConsentRequestsForApproval {
            get { return BackingStore?.Get<List<AppConsentRequest>>(nameof(AppConsentRequestsForApproval)); }
            set { BackingStore?.Set(nameof(AppConsentRequestsForApproval), value); }
        }
        /// <summary>Represents the app roles a user has been granted for an application. Supports $expand.</summary>
        public List<AppRoleAssignment> AppRoleAssignments {
            get { return BackingStore?.Get<List<AppRoleAssignment>>(nameof(AppRoleAssignments)); }
            set { BackingStore?.Set(nameof(AppRoleAssignments), value); }
        }
        /// <summary>The approvals property</summary>
        public List<Approval> Approvals {
            get { return BackingStore?.Get<List<Approval>>(nameof(Approvals)); }
            set { BackingStore?.Set(nameof(Approvals), value); }
        }
        /// <summary>The licenses that are assigned to the user, including inherited (group-based) licenses. Not nullable. Supports $filter (eq, not, and counting empty collections).</summary>
        public List<AssignedLicense> AssignedLicenses {
            get { return BackingStore?.Get<List<AssignedLicense>>(nameof(AssignedLicenses)); }
            set { BackingStore?.Set(nameof(AssignedLicenses), value); }
        }
        /// <summary>The plans that are assigned to the user. Read-only. Not nullable.Supports $filter (eq and not).</summary>
        public List<AssignedPlan> AssignedPlans {
            get { return BackingStore?.Get<List<AssignedPlan>>(nameof(AssignedPlans)); }
            set { BackingStore?.Set(nameof(AssignedPlans), value); }
        }
        /// <summary>TODO: Add Description</summary>
        public Microsoft.Graph.Beta.Models.Authentication Authentication {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Authentication>(nameof(Authentication)); }
            set { BackingStore?.Set(nameof(Authentication), value); }
        }
        /// <summary>The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Returned only on $select.</summary>
        public DateTimeOffset? Birthday {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(Birthday)); }
            set { BackingStore?.Set(nameof(Birthday), value); }
        }
        /// <summary>The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced from on-premises directory. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> BusinessPhones {
            get { return BackingStore?.Get<List<string>>(nameof(BusinessPhones)); }
            set { BackingStore?.Set(nameof(BusinessPhones), value); }
        }
        /// <summary>The user&apos;s primary calendar. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Calendar Calendar {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Calendar>(nameof(Calendar)); }
            set { BackingStore?.Set(nameof(Calendar), value); }
        }
        /// <summary>The user&apos;s calendar groups. Read-only. Nullable.</summary>
        public List<CalendarGroup> CalendarGroups {
            get { return BackingStore?.Get<List<CalendarGroup>>(nameof(CalendarGroups)); }
            set { BackingStore?.Set(nameof(CalendarGroups), value); }
        }
        /// <summary>The user&apos;s calendars. Read-only. Nullable.</summary>
        public List<Microsoft.Graph.Beta.Models.Calendar> Calendars {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Calendar>>(nameof(Calendars)); }
            set { BackingStore?.Set(nameof(Calendars), value); }
        }
        /// <summary>The calendar view for the calendar. Read-only. Nullable.</summary>
        public List<Event> CalendarView {
            get { return BackingStore?.Get<List<Event>>(nameof(CalendarView)); }
            set { BackingStore?.Set(nameof(CalendarView), value); }
        }
        /// <summary>The chats property</summary>
        public List<Chat> Chats {
            get { return BackingStore?.Get<List<Chat>>(nameof(Chats)); }
            set { BackingStore?.Set(nameof(Chats), value); }
        }
        /// <summary>The city in which the user is located. Maximum length is 128 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string City {
            get { return BackingStore?.Get<string>(nameof(City)); }
            set { BackingStore?.Set(nameof(City), value); }
        }
        /// <summary>The cloudPCs property</summary>
        public List<CloudPC> CloudPCs {
            get { return BackingStore?.Get<List<CloudPC>>(nameof(CloudPCs)); }
            set { BackingStore?.Set(nameof(CloudPCs), value); }
        }
        /// <summary>The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The maximum length is 64 characters.Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string CompanyName {
            get { return BackingStore?.Get<string>(nameof(CompanyName)); }
            set { BackingStore?.Set(nameof(CompanyName), value); }
        }
        /// <summary>Sets whether consent has been obtained for minors. Allowed values: null, Granted, Denied and NotRequired. Refer to the legal age group property definitions for further information. Supports $filter (eq, ne, not, and in).</summary>
        public string ConsentProvidedForMinor {
            get { return BackingStore?.Get<string>(nameof(ConsentProvidedForMinor)); }
            set { BackingStore?.Set(nameof(ConsentProvidedForMinor), value); }
        }
        /// <summary>The user&apos;s contacts folders. Read-only. Nullable.</summary>
        public List<ContactFolder> ContactFolders {
            get { return BackingStore?.Get<List<ContactFolder>>(nameof(ContactFolders)); }
            set { BackingStore?.Set(nameof(ContactFolders), value); }
        }
        /// <summary>The user&apos;s contacts. Read-only. Nullable.</summary>
        public List<Contact> Contacts {
            get { return BackingStore?.Get<List<Contact>>(nameof(Contacts)); }
            set { BackingStore?.Set(nameof(Contacts), value); }
        }
        /// <summary>The country/region in which the user is located; for example, US or UK. Maximum length is 128 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Country {
            get { return BackingStore?.Get<string>(nameof(Country)); }
            set { BackingStore?.Set(nameof(Country), value); }
        }
        /// <summary>The date and time the user was created. The value cannot be modified and is automatically populated when the entity is created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. Property is nullable. A null value indicates that an accurate creation time couldn&apos;t be determined for the user. Read-only. Supports $filter (eq, ne, not , ge, le, in).</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Directory objects that were created by the user. Read-only. Nullable.</summary>
        public List<DirectoryObject> CreatedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(CreatedObjects)); }
            set { BackingStore?.Set(nameof(CreatedObjects), value); }
        }
        /// <summary>Indicates whether the user account was created through one of the following methods:  As a regular school or work account (null). As an external account (Invitation). As a local account for an Azure Active Directory B2C tenant (LocalAccount). Through self-service sign-up by an internal user using email verification (EmailVerified). Through self-service sign-up by an external user signing up through a link that is part of a user flow (SelfServiceSignUp).  Read-only.Supports $filter (eq, ne, not, and in).</summary>
        public string CreationType {
            get { return BackingStore?.Get<string>(nameof(CreationType)); }
            set { BackingStore?.Set(nameof(CreationType), value); }
        }
        /// <summary>An open complex type that holds the value of a custom security attribute that is assigned to a directory object. Nullable. Returned only on $select. Supports $filter (eq, ne, not, startsWith).</summary>
        public CustomSecurityAttributeValue CustomSecurityAttributes {
            get { return BackingStore?.Get<CustomSecurityAttributeValue>(nameof(CustomSecurityAttributes)); }
            set { BackingStore?.Set(nameof(CustomSecurityAttributes), value); }
        }
        /// <summary>The name for the department in which the user works. Maximum length is 64 characters.Supports $filter (eq, ne, not , ge, le, in, and eq on null values).</summary>
        public string Department {
            get { return BackingStore?.Get<string>(nameof(Department)); }
            set { BackingStore?.Set(nameof(Department), value); }
        }
        /// <summary>Get enrollment configurations targeted to the user</summary>
        public List<DeviceEnrollmentConfiguration> DeviceEnrollmentConfigurations {
            get { return BackingStore?.Get<List<DeviceEnrollmentConfiguration>>(nameof(DeviceEnrollmentConfigurations)); }
            set { BackingStore?.Set(nameof(DeviceEnrollmentConfigurations), value); }
        }
        /// <summary>The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.</summary>
        public int? DeviceEnrollmentLimit {
            get { return BackingStore?.Get<int?>(nameof(DeviceEnrollmentLimit)); }
            set { BackingStore?.Set(nameof(DeviceEnrollmentLimit), value); }
        }
        /// <summary>The deviceKeys property</summary>
        public List<DeviceKey> DeviceKeys {
            get { return BackingStore?.Get<List<DeviceKey>>(nameof(DeviceKeys)); }
            set { BackingStore?.Set(nameof(DeviceKeys), value); }
        }
        /// <summary>The list of troubleshooting events for this user.</summary>
        public List<DeviceManagementTroubleshootingEvent> DeviceManagementTroubleshootingEvents {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingEvent>>(nameof(DeviceManagementTroubleshootingEvents)); }
            set { BackingStore?.Set(nameof(DeviceManagementTroubleshootingEvents), value); }
        }
        /// <summary>The devices property</summary>
        public List<Device> Devices {
            get { return BackingStore?.Get<List<Device>>(nameof(Devices)); }
            set { BackingStore?.Set(nameof(Devices), value); }
        }
        /// <summary>The users and contacts that report to the user. (The users and contacts that have their manager property set to this user.) Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> DirectReports {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(DirectReports)); }
            set { BackingStore?.Set(nameof(DirectReports), value); }
        }
        /// <summary>The name displayed in the address book for the user. This value is usually the combination of the user&apos;s first name, middle initial, and last name. This property is required when a user is created and it cannot be cleared during updates. Maximum length is 256 characters. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values), $orderBy, and $search.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The user&apos;s OneDrive. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Drive Drive {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Drive>(nameof(Drive)); }
            set { BackingStore?.Set(nameof(Drive), value); }
        }
        /// <summary>A collection of drives available for this user. Read-only.</summary>
        public List<Microsoft.Graph.Beta.Models.Drive> Drives {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Drive>>(nameof(Drives)); }
            set { BackingStore?.Set(nameof(Drives), value); }
        }
        /// <summary>The date and time when the user was hired or will start work in case of a future hire. Supports $filter (eq, ne, not , ge, le, in).</summary>
        public DateTimeOffset? EmployeeHireDate {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EmployeeHireDate)); }
            set { BackingStore?.Set(nameof(EmployeeHireDate), value); }
        }
        /// <summary>The employee identifier assigned to the user by the organization. The maximum length is 16 characters.Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
        public string EmployeeId {
            get { return BackingStore?.Get<string>(nameof(EmployeeId)); }
            set { BackingStore?.Set(nameof(EmployeeId), value); }
        }
        /// <summary>Represents organization data (e.g. division and costCenter) associated with a user. Supports $filter (eq, ne, not , ge, le, in).</summary>
        public Microsoft.Graph.Beta.Models.EmployeeOrgData EmployeeOrgData {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmployeeOrgData>(nameof(EmployeeOrgData)); }
            set { BackingStore?.Set(nameof(EmployeeOrgData), value); }
        }
        /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Supports $filter (eq, ne, not , ge, le, in, startsWith).</summary>
        public string EmployeeType {
            get { return BackingStore?.Get<string>(nameof(EmployeeType)); }
            set { BackingStore?.Set(nameof(EmployeeType), value); }
        }
        /// <summary>The user&apos;s events. Default is to show events under the Default Calendar. Read-only. Nullable.</summary>
        public List<Event> Events {
            get { return BackingStore?.Get<List<Event>>(nameof(Events)); }
            set { BackingStore?.Set(nameof(Events), value); }
        }
        /// <summary>The collection of open extensions defined for the user. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>For an external user invited to the tenant using the invitation API, this property represents the invited user&apos;s invitation status. For invited users, the state can be PendingAcceptance or Accepted, or null for all other users. Supports $filter (eq, ne, not , in).</summary>
        public string ExternalUserState {
            get { return BackingStore?.Get<string>(nameof(ExternalUserState)); }
            set { BackingStore?.Set(nameof(ExternalUserState), value); }
        }
        /// <summary>Shows the timestamp for the latest change to the externalUserState property. Supports $filter (eq, ne, not , in).</summary>
        public string ExternalUserStateChangeDateTime {
            get { return BackingStore?.Get<string>(nameof(ExternalUserStateChangeDateTime)); }
            set { BackingStore?.Set(nameof(ExternalUserStateChangeDateTime), value); }
        }
        /// <summary>The fax number of the user. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
        public string FaxNumber {
            get { return BackingStore?.Get<string>(nameof(FaxNumber)); }
            set { BackingStore?.Set(nameof(FaxNumber), value); }
        }
        /// <summary>The followedSites property</summary>
        public List<Site> FollowedSites {
            get { return BackingStore?.Get<List<Site>>(nameof(FollowedSites)); }
            set { BackingStore?.Set(nameof(FollowedSites), value); }
        }
        /// <summary>The given name (first name) of the user. Maximum length is 64 characters. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
        public string GivenName {
            get { return BackingStore?.Get<string>(nameof(GivenName)); }
            set { BackingStore?.Set(nameof(GivenName), value); }
        }
        /// <summary>The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Returned only on $select.  Note: This property is specific to SharePoint Online. We recommend using the native employeeHireDate property to set and update hire date values using Microsoft Graph APIs.</summary>
        public DateTimeOffset? HireDate {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(HireDate)); }
            set { BackingStore?.Set(nameof(HireDate), value); }
        }
        /// <summary>Represents the identities that can be used to sign in to this user account. An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account. May contain multiple items with the same signInType value. Supports $filter (eq) including on null values, only where the signInType is not userPrincipalName.</summary>
        public List<ObjectIdentity> Identities {
            get { return BackingStore?.Get<List<ObjectIdentity>>(nameof(Identities)); }
            set { BackingStore?.Set(nameof(Identities), value); }
        }
        /// <summary>The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. Read-only. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> ImAddresses {
            get { return BackingStore?.Get<List<string>>(nameof(ImAddresses)); }
            set { BackingStore?.Set(nameof(ImAddresses), value); }
        }
        /// <summary>Relevance classification of the user&apos;s messages based on explicit designations which override inferred relevance or importance.</summary>
        public Microsoft.Graph.Beta.Models.InferenceClassification InferenceClassification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InferenceClassification>(nameof(InferenceClassification)); }
            set { BackingStore?.Set(nameof(InferenceClassification), value); }
        }
        /// <summary>Identifies the info segments assigned to the user.  Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> InfoCatalogs {
            get { return BackingStore?.Get<List<string>>(nameof(InfoCatalogs)); }
            set { BackingStore?.Set(nameof(InfoCatalogs), value); }
        }
        /// <summary>The informationProtection property</summary>
        public Microsoft.Graph.Beta.Models.InformationProtection InformationProtection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InformationProtection>(nameof(InformationProtection)); }
            set { BackingStore?.Set(nameof(InformationProtection), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public ItemInsights Insights {
            get { return BackingStore?.Get<ItemInsights>(nameof(Insights)); }
            set { BackingStore?.Set(nameof(Insights), value); }
        }
        /// <summary>A list for the user to describe their interests. Returned only on $select.</summary>
        public List<string> Interests {
            get { return BackingStore?.Get<List<string>>(nameof(Interests)); }
            set { BackingStore?.Set(nameof(Interests), value); }
        }
        /// <summary>The isManagementRestricted property</summary>
        public bool? IsManagementRestricted {
            get { return BackingStore?.Get<bool?>(nameof(IsManagementRestricted)); }
            set { BackingStore?.Set(nameof(IsManagementRestricted), value); }
        }
        /// <summary>Do not use – reserved for future use.</summary>
        public bool? IsResourceAccount {
            get { return BackingStore?.Get<bool?>(nameof(IsResourceAccount)); }
            set { BackingStore?.Set(nameof(IsResourceAccount), value); }
        }
        /// <summary>The user&apos;s job title. Maximum length is 128 characters. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
        public string JobTitle {
            get { return BackingStore?.Get<string>(nameof(JobTitle)); }
            set { BackingStore?.Set(nameof(JobTitle), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public List<Group> JoinedGroups {
            get { return BackingStore?.Get<List<Group>>(nameof(JoinedGroups)); }
            set { BackingStore?.Set(nameof(JoinedGroups), value); }
        }
        /// <summary>The Microsoft Teams teams that the user is a member of. Read-only. Nullable.</summary>
        public List<Team> JoinedTeams {
            get { return BackingStore?.Get<List<Team>>(nameof(JoinedTeams)); }
            set { BackingStore?.Set(nameof(JoinedTeams), value); }
        }
        /// <summary>The time when this Azure AD user last changed their password or when their password was created, , whichever date the latest action was performed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Returned only on $select.</summary>
        public DateTimeOffset? LastPasswordChangeDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastPasswordChangeDateTime)); }
            set { BackingStore?.Set(nameof(LastPasswordChangeDateTime), value); }
        }
        /// <summary>Used by enterprise applications to determine the legal age group of the user. This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties. Allowed values: null, MinorWithOutParentalConsent, MinorWithParentalConsent, MinorNoParentalConsentRequired, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select.</summary>
        public string LegalAgeGroupClassification {
            get { return BackingStore?.Get<string>(nameof(LegalAgeGroupClassification)); }
            set { BackingStore?.Set(nameof(LegalAgeGroupClassification), value); }
        }
        /// <summary>State of license assignments for this user. Read-only. Returned only on $select.</summary>
        public List<LicenseAssignmentState> LicenseAssignmentStates {
            get { return BackingStore?.Get<List<LicenseAssignmentState>>(nameof(LicenseAssignmentStates)); }
            set { BackingStore?.Set(nameof(LicenseAssignmentStates), value); }
        }
        /// <summary>A collection of this user&apos;s license details. Read-only.</summary>
        public List<Microsoft.Graph.Beta.Models.LicenseDetails> LicenseDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.LicenseDetails>>(nameof(LicenseDetails)); }
            set { BackingStore?.Set(nameof(LicenseDetails), value); }
        }
        /// <summary>The SMTP address for the user, for example, admin@contoso.com. Changes to this property will also update the user&apos;s proxyAddresses collection to include the value as an SMTP address. For Azure AD B2C accounts, this property can be updated up to only ten times with unique SMTP addresses. This property cannot contain accent characters.  Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith, and eq on null values).</summary>
        public string Mail {
            get { return BackingStore?.Get<string>(nameof(Mail)); }
            set { BackingStore?.Set(nameof(Mail), value); }
        }
        /// <summary>Settings for the primary mailbox of the signed-in user. You can get or update settings for sending automatic replies to incoming messages, locale, and time zone. For more information, see User preferences for languages and regional formats. Returned only on $select.</summary>
        public Microsoft.Graph.Beta.Models.MailboxSettings MailboxSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MailboxSettings>(nameof(MailboxSettings)); }
            set { BackingStore?.Set(nameof(MailboxSettings), value); }
        }
        /// <summary>The user&apos;s mail folders. Read-only. Nullable.</summary>
        public List<MailFolder> MailFolders {
            get { return BackingStore?.Get<List<MailFolder>>(nameof(MailFolders)); }
            set { BackingStore?.Set(nameof(MailFolders), value); }
        }
        /// <summary>The mail alias for the user. This property must be specified when a user is created. Maximum length is 64 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string MailNickname {
            get { return BackingStore?.Get<string>(nameof(MailNickname)); }
            set { BackingStore?.Set(nameof(MailNickname), value); }
        }
        /// <summary>Zero or more managed app registrations that belong to the user.</summary>
        public List<ManagedAppRegistration> ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>>(nameof(ManagedAppRegistrations)); }
            set { BackingStore?.Set(nameof(ManagedAppRegistrations), value); }
        }
        /// <summary>The managed devices associated with the user.</summary>
        public List<ManagedDevice> ManagedDevices {
            get { return BackingStore?.Get<List<ManagedDevice>>(nameof(ManagedDevices)); }
            set { BackingStore?.Set(nameof(ManagedDevices), value); }
        }
        /// <summary>The user or contact that is this user&apos;s manager. Read-only. (HTTP Methods: GET, PUT, DELETE.). Supports $expand.</summary>
        public DirectoryObject Manager {
            get { return BackingStore?.Get<DirectoryObject>(nameof(Manager)); }
            set { BackingStore?.Set(nameof(Manager), value); }
        }
        /// <summary>The groups, directory roles and administrative units that the user is a member of. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(MemberOf)); }
            set { BackingStore?.Set(nameof(MemberOf), value); }
        }
        /// <summary>The messages in a mailbox or folder. Read-only. Nullable.</summary>
        public List<Message> Messages {
            get { return BackingStore?.Get<List<Message>>(nameof(Messages)); }
            set { BackingStore?.Set(nameof(Messages), value); }
        }
        /// <summary>The list of troubleshooting events for this user.</summary>
        public List<MobileAppIntentAndState> MobileAppIntentAndStates {
            get { return BackingStore?.Get<List<MobileAppIntentAndState>>(nameof(MobileAppIntentAndStates)); }
            set { BackingStore?.Set(nameof(MobileAppIntentAndStates), value); }
        }
        /// <summary>The list of mobile app troubleshooting events for this user.</summary>
        public List<MobileAppTroubleshootingEvent> MobileAppTroubleshootingEvents {
            get { return BackingStore?.Get<List<MobileAppTroubleshootingEvent>>(nameof(MobileAppTroubleshootingEvents)); }
            set { BackingStore?.Set(nameof(MobileAppTroubleshootingEvents), value); }
        }
        /// <summary>The primary cellular telephone number for the user. Read-only for users synced from on-premises directory.  Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string MobilePhone {
            get { return BackingStore?.Get<string>(nameof(MobilePhone)); }
            set { BackingStore?.Set(nameof(MobilePhone), value); }
        }
        /// <summary>The URL for the user&apos;s personal site. Returned only on $select.</summary>
        public string MySite {
            get { return BackingStore?.Get<string>(nameof(MySite)); }
            set { BackingStore?.Set(nameof(MySite), value); }
        }
        /// <summary>The notifications property</summary>
        public List<Notification> Notifications {
            get { return BackingStore?.Get<List<Notification>>(nameof(Notifications)); }
            set { BackingStore?.Set(nameof(Notifications), value); }
        }
        /// <summary>The oauth2PermissionGrants property</summary>
        public List<OAuth2PermissionGrant> Oauth2PermissionGrants {
            get { return BackingStore?.Get<List<OAuth2PermissionGrant>>(nameof(Oauth2PermissionGrants)); }
            set { BackingStore?.Set(nameof(Oauth2PermissionGrants), value); }
        }
        /// <summary>The office location in the user&apos;s place of business. Maximum length is 128 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string OfficeLocation {
            get { return BackingStore?.Get<string>(nameof(OfficeLocation)); }
            set { BackingStore?.Set(nameof(OfficeLocation), value); }
        }
        /// <summary>Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Onenote Onenote {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Onenote>(nameof(Onenote)); }
            set { BackingStore?.Set(nameof(Onenote), value); }
        }
        /// <summary>The onlineMeetings property</summary>
        public List<OnlineMeeting> OnlineMeetings {
            get { return BackingStore?.Get<List<OnlineMeeting>>(nameof(OnlineMeetings)); }
            set { BackingStore?.Set(nameof(OnlineMeetings), value); }
        }
        /// <summary>Contains the on-premises Active Directory distinguished name or DN. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.</summary>
        public string OnPremisesDistinguishedName {
            get { return BackingStore?.Get<string>(nameof(OnPremisesDistinguishedName)); }
            set { BackingStore?.Set(nameof(OnPremisesDistinguishedName), value); }
        }
        /// <summary>Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.</summary>
        public string OnPremisesDomainName {
            get { return BackingStore?.Get<string>(nameof(OnPremisesDomainName)); }
            set { BackingStore?.Set(nameof(OnPremisesDomainName), value); }
        }
        /// <summary>Contains extensionAttributes1-15 for the user. The individual extension attributes are neither selectable nor filterable. For an onPremisesSyncEnabled user, the source of authority for this set of properties is the on-premises and is read-only. For a cloud-only user (where onPremisesSyncEnabled is false), these properties can be set during creation or update of a user object.  For a cloud-only user previously synced from on-premises Active Directory, these properties are read-only in Microsoft Graph but can be fully managed through the Exchange Admin Center or the Exchange Online V2 module in PowerShell. These extension attributes are also known as Exchange custom attributes 1-15. Returned only on $select.</summary>
        public Microsoft.Graph.Beta.Models.OnPremisesExtensionAttributes OnPremisesExtensionAttributes {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OnPremisesExtensionAttributes>(nameof(OnPremisesExtensionAttributes)); }
            set { BackingStore?.Set(nameof(OnPremisesExtensionAttributes), value); }
        }
        /// <summary>This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user&apos;s userPrincipalName (UPN) property. Note: The $ and _ characters cannot be used when specifying this property. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public string OnPremisesImmutableId {
            get { return BackingStore?.Get<string>(nameof(OnPremisesImmutableId)); }
            set { BackingStore?.Set(nameof(OnPremisesImmutableId), value); }
        }
        /// <summary>Indicates the last time at which the object was synced with the on-premises directory; for example: &apos;2013-02-16T03:04:54Z&apos;. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(OnPremisesLastSyncDateTime)); }
            set { BackingStore?.Set(nameof(OnPremisesLastSyncDateTime), value); }
        }
        /// <summary>Errors when using Microsoft synchronization product during provisioning.  Supports $filter (eq, not, ge, le).</summary>
        public List<OnPremisesProvisioningError> OnPremisesProvisioningErrors {
            get { return BackingStore?.Get<List<OnPremisesProvisioningError>>(nameof(OnPremisesProvisioningErrors)); }
            set { BackingStore?.Set(nameof(OnPremisesProvisioningErrors), value); }
        }
        /// <summary>Contains the on-premises sAMAccountName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Supports $filter (eq, ne, not, ge, le, in, startsWith).</summary>
        public string OnPremisesSamAccountName {
            get { return BackingStore?.Get<string>(nameof(OnPremisesSamAccountName)); }
            set { BackingStore?.Set(nameof(OnPremisesSamAccountName), value); }
        }
        /// <summary>Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only. Supports $filter (eq including on null values).</summary>
        public string OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string>(nameof(OnPremisesSecurityIdentifier)); }
            set { BackingStore?.Set(nameof(OnPremisesSecurityIdentifier), value); }
        }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled {
            get { return BackingStore?.Get<bool?>(nameof(OnPremisesSyncEnabled)); }
            set { BackingStore?.Set(nameof(OnPremisesSyncEnabled), value); }
        }
        /// <summary>Contains the on-premises userPrincipalName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Supports $filter (eq, ne, not, ge, le, in, startsWith).</summary>
        public string OnPremisesUserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(OnPremisesUserPrincipalName)); }
            set { BackingStore?.Set(nameof(OnPremisesUserPrincipalName), value); }
        }
        /// <summary>A list of additional email addresses for the user; for example: [&apos;bob@contoso.com&apos;, &apos;Robert@fabrikam.com&apos;].NOTE: This property cannot contain accent characters.Supports $filter (eq, not, ge, le, in, startsWith, and counting empty collections).</summary>
        public List<string> OtherMails {
            get { return BackingStore?.Get<List<string>>(nameof(OtherMails)); }
            set { BackingStore?.Set(nameof(OtherMails), value); }
        }
        /// <summary>Selective Outlook services available to the user. Read-only. Nullable.</summary>
        public OutlookUser Outlook {
            get { return BackingStore?.Get<OutlookUser>(nameof(Outlook)); }
            set { BackingStore?.Set(nameof(Outlook), value); }
        }
        /// <summary>Devices that are owned by the user. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> OwnedDevices {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(OwnedDevices)); }
            set { BackingStore?.Set(nameof(OwnedDevices), value); }
        }
        /// <summary>Directory objects that are owned by the user. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> OwnedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(OwnedObjects)); }
            set { BackingStore?.Set(nameof(OwnedObjects), value); }
        }
        /// <summary>Specifies password policies for the user. This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified. DisablePasswordExpiration can also be specified. The two may be specified together; for example: DisablePasswordExpiration, DisableStrongPassword. For more information on the default password policies, see Azure AD pasword policies. Supports $filter (ne, not, and eq on null values).</summary>
        public string PasswordPolicies {
            get { return BackingStore?.Get<string>(nameof(PasswordPolicies)); }
            set { BackingStore?.Set(nameof(PasswordPolicies), value); }
        }
        /// <summary>Specifies the password profile for the user. The profile contains the user&apos;s password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required. NOTE: For Azure B2C tenants, the forceChangePasswordNextSignIn property should be set to false and instead use custom policies and user flows to force password reset at first logon. See Force password reset at first logon. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public Microsoft.Graph.Beta.Models.PasswordProfile PasswordProfile {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PasswordProfile>(nameof(PasswordProfile)); }
            set { BackingStore?.Set(nameof(PasswordProfile), value); }
        }
        /// <summary>A list for the user to enumerate their past projects. Returned only on $select.</summary>
        public List<string> PastProjects {
            get { return BackingStore?.Get<List<string>>(nameof(PastProjects)); }
            set { BackingStore?.Set(nameof(PastProjects), value); }
        }
        /// <summary>Navigation property to get list of access reviews pending approval by reviewer.</summary>
        public List<AccessReviewInstance> PendingAccessReviewInstances {
            get { return BackingStore?.Get<List<AccessReviewInstance>>(nameof(PendingAccessReviewInstances)); }
            set { BackingStore?.Set(nameof(PendingAccessReviewInstances), value); }
        }
        /// <summary>Read-only. The most relevant people to the user. The collection is ordered by their relevance to the user, which is determined by the user&apos;s communication, collaboration and business relationships. A person is an aggregation of information from across mail, contacts and social networks.</summary>
        public List<Person> People {
            get { return BackingStore?.Get<List<Person>>(nameof(People)); }
            set { BackingStore?.Set(nameof(People), value); }
        }
        /// <summary>The user&apos;s profile photo. Read-only.</summary>
        public ProfilePhoto Photo {
            get { return BackingStore?.Get<ProfilePhoto>(nameof(Photo)); }
            set { BackingStore?.Set(nameof(Photo), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public List<ProfilePhoto> Photos {
            get { return BackingStore?.Get<List<ProfilePhoto>>(nameof(Photos)); }
            set { BackingStore?.Set(nameof(Photos), value); }
        }
        /// <summary>Selective Planner services available to the user. Read-only. Nullable.</summary>
        public PlannerUser Planner {
            get { return BackingStore?.Get<PlannerUser>(nameof(Planner)); }
            set { BackingStore?.Set(nameof(Planner), value); }
        }
        /// <summary>The postal code for the user&apos;s postal address. The postal code is specific to the user&apos;s country/region. In the United States of America, this attribute contains the ZIP code. Maximum length is 40 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string PostalCode {
            get { return BackingStore?.Get<string>(nameof(PostalCode)); }
            set { BackingStore?.Set(nameof(PostalCode), value); }
        }
        /// <summary>The preferred data location for the user. For more information, see OneDrive Online Multi-Geo.</summary>
        public string PreferredDataLocation {
            get { return BackingStore?.Get<string>(nameof(PreferredDataLocation)); }
            set { BackingStore?.Set(nameof(PreferredDataLocation), value); }
        }
        /// <summary>The preferred language for the user. Should follow ISO 639-1 Code; for example en-US. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string PreferredLanguage {
            get { return BackingStore?.Get<string>(nameof(PreferredLanguage)); }
            set { BackingStore?.Set(nameof(PreferredLanguage), value); }
        }
        /// <summary>The preferred name for the user. Returned only on $select.</summary>
        public string PreferredName {
            get { return BackingStore?.Get<string>(nameof(PreferredName)); }
            set { BackingStore?.Set(nameof(PreferredName), value); }
        }
        /// <summary>The presence property</summary>
        public Microsoft.Graph.Beta.Models.Presence Presence {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Presence>(nameof(Presence)); }
            set { BackingStore?.Set(nameof(Presence), value); }
        }
        /// <summary>The print property</summary>
        public UserPrint Print {
            get { return BackingStore?.Get<UserPrint>(nameof(Print)); }
            set { BackingStore?.Set(nameof(Print), value); }
        }
        /// <summary>Represents properties that are descriptive of a user in a tenant.</summary>
        public Microsoft.Graph.Beta.Models.Profile Profile {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Profile>(nameof(Profile)); }
            set { BackingStore?.Set(nameof(Profile), value); }
        }
        /// <summary>The plans that are provisioned for the user. Read-only. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<ProvisionedPlan> ProvisionedPlans {
            get { return BackingStore?.Get<List<ProvisionedPlan>>(nameof(ProvisionedPlans)); }
            set { BackingStore?.Set(nameof(ProvisionedPlans), value); }
        }
        /// <summary>For example: [&apos;SMTP: bob@contoso.com&apos;, &apos;smtp: bob@sales.contoso.com&apos;]. Changes to the mail property will also update this collection to include the value as an SMTP address. For more information, see mail and proxyAddresses properties. The proxy address prefixed with SMTP (capitalized) is the primary proxy address while those prefixed with smtp are the secondary proxy addresses. For Azure AD B2C accounts, this property has a limit of ten unique addresses. Read-only in Microsoft Graph; you can update this property only through the Microsoft 365 admin center. Not nullable. Supports $filter (eq, not, ge, le, startsWith, endsWith, and counting empty collections).</summary>
        public List<string> ProxyAddresses {
            get { return BackingStore?.Get<List<string>>(nameof(ProxyAddresses)); }
            set { BackingStore?.Set(nameof(ProxyAddresses), value); }
        }
        /// <summary>Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use invalidateAllRefreshTokens to reset.</summary>
        public DateTimeOffset? RefreshTokensValidFromDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RefreshTokensValidFromDateTime)); }
            set { BackingStore?.Set(nameof(RefreshTokensValidFromDateTime), value); }
        }
        /// <summary>Devices that are registered for the user. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> RegisteredDevices {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(RegisteredDevices)); }
            set { BackingStore?.Set(nameof(RegisteredDevices), value); }
        }
        /// <summary>A list for the user to enumerate their responsibilities. Returned only on $select.</summary>
        public List<string> Responsibilities {
            get { return BackingStore?.Get<List<string>>(nameof(Responsibilities)); }
            set { BackingStore?.Set(nameof(Responsibilities), value); }
        }
        /// <summary>A list for the user to enumerate the schools they have attended. Returned only on $select.</summary>
        public List<string> Schools {
            get { return BackingStore?.Get<List<string>>(nameof(Schools)); }
            set { BackingStore?.Set(nameof(Schools), value); }
        }
        /// <summary>The scoped-role administrative unit memberships for this user. Read-only. Nullable.</summary>
        public List<ScopedRoleMembership> ScopedRoleMemberOf {
            get { return BackingStore?.Get<List<ScopedRoleMembership>>(nameof(ScopedRoleMemberOf)); }
            set { BackingStore?.Set(nameof(ScopedRoleMemberOf), value); }
        }
        /// <summary>The security property</summary>
        public Microsoft.Graph.Beta.Models.Security.Security Security {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.Security>(nameof(Security)); }
            set { BackingStore?.Set(nameof(Security), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public UserSettings Settings {
            get { return BackingStore?.Get<UserSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>Do not use in Microsoft Graph. Manage this property through the Microsoft 365 admin center instead. Represents whether the user should be included in the Outlook global address list. See Known issue.</summary>
        public bool? ShowInAddressList {
            get { return BackingStore?.Get<bool?>(nameof(ShowInAddressList)); }
            set { BackingStore?.Set(nameof(ShowInAddressList), value); }
        }
        /// <summary>Get the last signed-in date and request ID of the sign-in for a given user. Read-only.Returned only on $select. Supports $filter (eq, ne, not, ge, le) but, not with any other filterable properties. Note: Details for this property require an Azure AD Premium P1/P2 license and the AuditLog.Read.All permission.Note: There&apos;s a known issue with retrieving this property.This property is not returned for a user who has never signed in or last signed in before April 2020.</summary>
        public Microsoft.Graph.Beta.Models.SignInActivity SignInActivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SignInActivity>(nameof(SignInActivity)); }
            set { BackingStore?.Set(nameof(SignInActivity), value); }
        }
        /// <summary>Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use revokeSignInSessions to reset.</summary>
        public DateTimeOffset? SignInSessionsValidFromDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(SignInSessionsValidFromDateTime)); }
            set { BackingStore?.Set(nameof(SignInSessionsValidFromDateTime), value); }
        }
        /// <summary>A list for the user to enumerate their skills. Returned only on $select.</summary>
        public List<string> Skills {
            get { return BackingStore?.Get<List<string>>(nameof(Skills)); }
            set { BackingStore?.Set(nameof(Skills), value); }
        }
        /// <summary>The state or province in the user&apos;s address. Maximum length is 128 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string State {
            get { return BackingStore?.Get<string>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>The street address of the user&apos;s place of business. Maximum length is 1024 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string StreetAddress {
            get { return BackingStore?.Get<string>(nameof(StreetAddress)); }
            set { BackingStore?.Set(nameof(StreetAddress), value); }
        }
        /// <summary>The user&apos;s surname (family name or last name). Maximum length is 64 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Surname {
            get { return BackingStore?.Get<string>(nameof(Surname)); }
            set { BackingStore?.Set(nameof(Surname), value); }
        }
        /// <summary>The tasks property</summary>
        public Microsoft.Graph.Beta.Models.Tasks Tasks {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Tasks>(nameof(Tasks)); }
            set { BackingStore?.Set(nameof(Tasks), value); }
        }
        /// <summary>A container for Microsoft Teams features available for the user. Read-only. Nullable.</summary>
        public UserTeamwork Teamwork {
            get { return BackingStore?.Get<UserTeamwork>(nameof(Teamwork)); }
            set { BackingStore?.Set(nameof(Teamwork), value); }
        }
        /// <summary>Represents the To Do services available to a user.</summary>
        public Microsoft.Graph.Beta.Models.Todo Todo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Todo>(nameof(Todo)); }
            set { BackingStore?.Set(nameof(Todo), value); }
        }
        /// <summary>The transitiveMemberOf property</summary>
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(TransitiveMemberOf)); }
            set { BackingStore?.Set(nameof(TransitiveMemberOf), value); }
        }
        /// <summary>The transitive reports for a user. Read-only.</summary>
        public List<DirectoryObject> TransitiveReports {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(TransitiveReports)); }
            set { BackingStore?.Set(nameof(TransitiveReports), value); }
        }
        /// <summary>A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: US, JP, and GB. Not nullable. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string UsageLocation {
            get { return BackingStore?.Get<string>(nameof(UsageLocation)); }
            set { BackingStore?.Set(nameof(UsageLocation), value); }
        }
        /// <summary>Represents the usage rights a user has been granted.</summary>
        public List<UsageRight> UsageRights {
            get { return BackingStore?.Get<List<UsageRight>>(nameof(UsageRights)); }
            set { BackingStore?.Set(nameof(UsageRights), value); }
        }
        /// <summary>The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user&apos;s email name. The general format is alias@domain, where domain must be present in the tenant&apos;s collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization.NOTE: This property cannot contain accent characters. Only the following characters are allowed A - Z, a - z, 0 - 9, &apos; . - _ ! # ^ ~. For the complete list of allowed characters, see username policies. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith) and $orderBy.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>A String value that can be used to classify user types in your directory, such as Member and Guest. Supports $filter (eq, ne, not, in, and eq on null values). NOTE: For more information about the permissions for member and guest users, see What are the default user permissions in Azure Active Directory?</summary>
        public string UserType {
            get { return BackingStore?.Get<string>(nameof(UserType)); }
            set { BackingStore?.Set(nameof(UserType), value); }
        }
        /// <summary>Zero or more WIP device registrations that belong to the user.</summary>
        public List<WindowsInformationProtectionDeviceRegistration> WindowsInformationProtectionDeviceRegistrations {
            get { return BackingStore?.Get<List<WindowsInformationProtectionDeviceRegistration>>(nameof(WindowsInformationProtectionDeviceRegistrations)); }
            set { BackingStore?.Set(nameof(WindowsInformationProtectionDeviceRegistrations), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new User CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aboutMe", n => { AboutMe = n.GetStringValue(); } },
                {"accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<UserActivity>(UserActivity.CreateFromDiscriminatorValue).ToList(); } },
                {"ageGroup", n => { AgeGroup = n.GetStringValue(); } },
                {"agreementAcceptances", n => { AgreementAcceptances = n.GetCollectionOfObjectValues<AgreementAcceptance>(AgreementAcceptance.CreateFromDiscriminatorValue).ToList(); } },
                {"analytics", n => { Analytics = n.GetObjectValue<UserAnalytics>(UserAnalytics.CreateFromDiscriminatorValue); } },
                {"appConsentRequestsForApproval", n => { AppConsentRequestsForApproval = n.GetCollectionOfObjectValues<AppConsentRequest>(AppConsentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"appRoleAssignments", n => { AppRoleAssignments = n.GetCollectionOfObjectValues<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"approvals", n => { Approvals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedLicenses", n => { AssignedLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedPlans", n => { AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"authentication", n => { Authentication = n.GetObjectValue<Microsoft.Graph.Beta.Models.Authentication>(Microsoft.Graph.Beta.Models.Authentication.CreateFromDiscriminatorValue); } },
                {"birthday", n => { Birthday = n.GetDateTimeOffsetValue(); } },
                {"businessPhones", n => { BusinessPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"calendar", n => { Calendar = n.GetObjectValue<Microsoft.Graph.Beta.Models.Calendar>(Microsoft.Graph.Beta.Models.Calendar.CreateFromDiscriminatorValue); } },
                {"calendarGroups", n => { CalendarGroups = n.GetCollectionOfObjectValues<CalendarGroup>(CalendarGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"calendars", n => { Calendars = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Calendar>(Microsoft.Graph.Beta.Models.Calendar.CreateFromDiscriminatorValue).ToList(); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"chats", n => { Chats = n.GetCollectionOfObjectValues<Chat>(Chat.CreateFromDiscriminatorValue).ToList(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<CloudPC>(CloudPC.CreateFromDiscriminatorValue).ToList(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"consentProvidedForMinor", n => { ConsentProvidedForMinor = n.GetStringValue(); } },
                {"contactFolders", n => { ContactFolders = n.GetCollectionOfObjectValues<ContactFolder>(ContactFolder.CreateFromDiscriminatorValue).ToList(); } },
                {"contacts", n => { Contacts = n.GetCollectionOfObjectValues<Contact>(Contact.CreateFromDiscriminatorValue).ToList(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdObjects", n => { CreatedObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"creationType", n => { CreationType = n.GetStringValue(); } },
                {"customSecurityAttributes", n => { CustomSecurityAttributes = n.GetObjectValue<CustomSecurityAttributeValue>(CustomSecurityAttributeValue.CreateFromDiscriminatorValue); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"deviceEnrollmentConfigurations", n => { DeviceEnrollmentConfigurations = n.GetCollectionOfObjectValues<DeviceEnrollmentConfiguration>(DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceEnrollmentLimit", n => { DeviceEnrollmentLimit = n.GetIntValue(); } },
                {"deviceKeys", n => { DeviceKeys = n.GetCollectionOfObjectValues<DeviceKey>(DeviceKey.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceManagementTroubleshootingEvents", n => { DeviceManagementTroubleshootingEvents = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>(DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"devices", n => { Devices = n.GetCollectionOfObjectValues<Device>(Device.CreateFromDiscriminatorValue).ToList(); } },
                {"directReports", n => { DirectReports = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue).ToList(); } },
                {"employeeHireDate", n => { EmployeeHireDate = n.GetDateTimeOffsetValue(); } },
                {"employeeId", n => { EmployeeId = n.GetStringValue(); } },
                {"employeeOrgData", n => { EmployeeOrgData = n.GetObjectValue<Microsoft.Graph.Beta.Models.EmployeeOrgData>(Microsoft.Graph.Beta.Models.EmployeeOrgData.CreateFromDiscriminatorValue); } },
                {"employeeType", n => { EmployeeType = n.GetStringValue(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"externalUserState", n => { ExternalUserState = n.GetStringValue(); } },
                {"externalUserStateChangeDateTime", n => { ExternalUserStateChangeDateTime = n.GetStringValue(); } },
                {"faxNumber", n => { FaxNumber = n.GetStringValue(); } },
                {"followedSites", n => { FollowedSites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue).ToList(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"hireDate", n => { HireDate = n.GetDateTimeOffsetValue(); } },
                {"identities", n => { Identities = n.GetCollectionOfObjectValues<ObjectIdentity>(ObjectIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"imAddresses", n => { ImAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inferenceClassification", n => { InferenceClassification = n.GetObjectValue<Microsoft.Graph.Beta.Models.InferenceClassification>(Microsoft.Graph.Beta.Models.InferenceClassification.CreateFromDiscriminatorValue); } },
                {"infoCatalogs", n => { InfoCatalogs = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"informationProtection", n => { InformationProtection = n.GetObjectValue<Microsoft.Graph.Beta.Models.InformationProtection>(Microsoft.Graph.Beta.Models.InformationProtection.CreateFromDiscriminatorValue); } },
                {"insights", n => { Insights = n.GetObjectValue<ItemInsights>(ItemInsights.CreateFromDiscriminatorValue); } },
                {"interests", n => { Interests = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isManagementRestricted", n => { IsManagementRestricted = n.GetBoolValue(); } },
                {"isResourceAccount", n => { IsResourceAccount = n.GetBoolValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"joinedGroups", n => { JoinedGroups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue).ToList(); } },
                {"joinedTeams", n => { JoinedTeams = n.GetCollectionOfObjectValues<Team>(Team.CreateFromDiscriminatorValue).ToList(); } },
                {"lastPasswordChangeDateTime", n => { LastPasswordChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"legalAgeGroupClassification", n => { LegalAgeGroupClassification = n.GetStringValue(); } },
                {"licenseAssignmentStates", n => { LicenseAssignmentStates = n.GetCollectionOfObjectValues<LicenseAssignmentState>(LicenseAssignmentState.CreateFromDiscriminatorValue).ToList(); } },
                {"licenseDetails", n => { LicenseDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LicenseDetails>(Microsoft.Graph.Beta.Models.LicenseDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"mail", n => { Mail = n.GetStringValue(); } },
                {"mailboxSettings", n => { MailboxSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.MailboxSettings>(Microsoft.Graph.Beta.Models.MailboxSettings.CreateFromDiscriminatorValue); } },
                {"mailFolders", n => { MailFolders = n.GetCollectionOfObjectValues<MailFolder>(MailFolder.CreateFromDiscriminatorValue).ToList(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>(ManagedAppRegistration.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"manager", n => { Manager = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"messages", n => { Messages = n.GetCollectionOfObjectValues<Message>(Message.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileAppIntentAndStates", n => { MobileAppIntentAndStates = n.GetCollectionOfObjectValues<MobileAppIntentAndState>(MobileAppIntentAndState.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileAppTroubleshootingEvents", n => { MobileAppTroubleshootingEvents = n.GetCollectionOfObjectValues<MobileAppTroubleshootingEvent>(MobileAppTroubleshootingEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                {"mySite", n => { MySite = n.GetStringValue(); } },
                {"notifications", n => { Notifications = n.GetCollectionOfObjectValues<Notification>(Notification.CreateFromDiscriminatorValue).ToList(); } },
                {"oauth2PermissionGrants", n => { Oauth2PermissionGrants = n.GetCollectionOfObjectValues<OAuth2PermissionGrant>(OAuth2PermissionGrant.CreateFromDiscriminatorValue).ToList(); } },
                {"officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                {"onenote", n => { Onenote = n.GetObjectValue<Microsoft.Graph.Beta.Models.Onenote>(Microsoft.Graph.Beta.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"onlineMeetings", n => { OnlineMeetings = n.GetCollectionOfObjectValues<OnlineMeeting>(OnlineMeeting.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesDistinguishedName", n => { OnPremisesDistinguishedName = n.GetStringValue(); } },
                {"onPremisesDomainName", n => { OnPremisesDomainName = n.GetStringValue(); } },
                {"onPremisesExtensionAttributes", n => { OnPremisesExtensionAttributes = n.GetObjectValue<Microsoft.Graph.Beta.Models.OnPremisesExtensionAttributes>(Microsoft.Graph.Beta.Models.OnPremisesExtensionAttributes.CreateFromDiscriminatorValue); } },
                {"onPremisesImmutableId", n => { OnPremisesImmutableId = n.GetStringValue(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesProvisioningErrors", n => { OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<OnPremisesProvisioningError>(OnPremisesProvisioningError.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesSamAccountName", n => { OnPremisesSamAccountName = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"onPremisesUserPrincipalName", n => { OnPremisesUserPrincipalName = n.GetStringValue(); } },
                {"otherMails", n => { OtherMails = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"outlook", n => { Outlook = n.GetObjectValue<OutlookUser>(OutlookUser.CreateFromDiscriminatorValue); } },
                {"ownedDevices", n => { OwnedDevices = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"ownedObjects", n => { OwnedObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordPolicies", n => { PasswordPolicies = n.GetStringValue(); } },
                {"passwordProfile", n => { PasswordProfile = n.GetObjectValue<Microsoft.Graph.Beta.Models.PasswordProfile>(Microsoft.Graph.Beta.Models.PasswordProfile.CreateFromDiscriminatorValue); } },
                {"pastProjects", n => { PastProjects = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"pendingAccessReviewInstances", n => { PendingAccessReviewInstances = n.GetCollectionOfObjectValues<AccessReviewInstance>(AccessReviewInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"people", n => { People = n.GetCollectionOfObjectValues<Person>(Person.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"photos", n => { Photos = n.GetCollectionOfObjectValues<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue).ToList(); } },
                {"planner", n => { Planner = n.GetObjectValue<PlannerUser>(PlannerUser.CreateFromDiscriminatorValue); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"preferredDataLocation", n => { PreferredDataLocation = n.GetStringValue(); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"preferredName", n => { PreferredName = n.GetStringValue(); } },
                {"presence", n => { Presence = n.GetObjectValue<Microsoft.Graph.Beta.Models.Presence>(Microsoft.Graph.Beta.Models.Presence.CreateFromDiscriminatorValue); } },
                {"print", n => { Print = n.GetObjectValue<UserPrint>(UserPrint.CreateFromDiscriminatorValue); } },
                {"profile", n => { Profile = n.GetObjectValue<Microsoft.Graph.Beta.Models.Profile>(Microsoft.Graph.Beta.Models.Profile.CreateFromDiscriminatorValue); } },
                {"provisionedPlans", n => { ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"proxyAddresses", n => { ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"refreshTokensValidFromDateTime", n => { RefreshTokensValidFromDateTime = n.GetDateTimeOffsetValue(); } },
                {"registeredDevices", n => { RegisteredDevices = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"responsibilities", n => { Responsibilities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"schools", n => { Schools = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"scopedRoleMemberOf", n => { ScopedRoleMemberOf = n.GetCollectionOfObjectValues<ScopedRoleMembership>(ScopedRoleMembership.CreateFromDiscriminatorValue).ToList(); } },
                {"security", n => { Security = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.Security>(Microsoft.Graph.Beta.Models.Security.Security.CreateFromDiscriminatorValue); } },
                {"settings", n => { Settings = n.GetObjectValue<UserSettings>(UserSettings.CreateFromDiscriminatorValue); } },
                {"showInAddressList", n => { ShowInAddressList = n.GetBoolValue(); } },
                {"signInActivity", n => { SignInActivity = n.GetObjectValue<Microsoft.Graph.Beta.Models.SignInActivity>(Microsoft.Graph.Beta.Models.SignInActivity.CreateFromDiscriminatorValue); } },
                {"signInSessionsValidFromDateTime", n => { SignInSessionsValidFromDateTime = n.GetDateTimeOffsetValue(); } },
                {"skills", n => { Skills = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"streetAddress", n => { StreetAddress = n.GetStringValue(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"tasks", n => { Tasks = n.GetObjectValue<Microsoft.Graph.Beta.Models.Tasks>(Microsoft.Graph.Beta.Models.Tasks.CreateFromDiscriminatorValue); } },
                {"teamwork", n => { Teamwork = n.GetObjectValue<UserTeamwork>(UserTeamwork.CreateFromDiscriminatorValue); } },
                {"todo", n => { Todo = n.GetObjectValue<Microsoft.Graph.Beta.Models.Todo>(Microsoft.Graph.Beta.Models.Todo.CreateFromDiscriminatorValue); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"transitiveReports", n => { TransitiveReports = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"usageLocation", n => { UsageLocation = n.GetStringValue(); } },
                {"usageRights", n => { UsageRights = n.GetCollectionOfObjectValues<UsageRight>(UsageRight.CreateFromDiscriminatorValue).ToList(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetStringValue(); } },
                {"windowsInformationProtectionDeviceRegistrations", n => { WindowsInformationProtectionDeviceRegistrations = n.GetCollectionOfObjectValues<WindowsInformationProtectionDeviceRegistration>(WindowsInformationProtectionDeviceRegistration.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aboutMe", AboutMe);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<UserActivity>("activities", Activities);
            writer.WriteStringValue("ageGroup", AgeGroup);
            writer.WriteCollectionOfObjectValues<AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteObjectValue<UserAnalytics>("analytics", Analytics);
            writer.WriteCollectionOfObjectValues<AppConsentRequest>("appConsentRequestsForApproval", AppConsentRequestsForApproval);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<Approval>("approvals", Approvals);
            writer.WriteCollectionOfObjectValues<AssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Authentication>("authentication", Authentication);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Calendar>("calendar", Calendar);
            writer.WriteCollectionOfObjectValues<CalendarGroup>("calendarGroups", CalendarGroups);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Calendar>("calendars", Calendars);
            writer.WriteCollectionOfObjectValues<Event>("calendarView", CalendarView);
            writer.WriteCollectionOfObjectValues<Chat>("chats", Chats);
            writer.WriteStringValue("city", City);
            writer.WriteCollectionOfObjectValues<CloudPC>("cloudPCs", CloudPCs);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("consentProvidedForMinor", ConsentProvidedForMinor);
            writer.WriteCollectionOfObjectValues<ContactFolder>("contactFolders", ContactFolders);
            writer.WriteCollectionOfObjectValues<Contact>("contacts", Contacts);
            writer.WriteStringValue("country", Country);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("createdObjects", CreatedObjects);
            writer.WriteStringValue("creationType", CreationType);
            writer.WriteObjectValue<CustomSecurityAttributeValue>("customSecurityAttributes", CustomSecurityAttributes);
            writer.WriteStringValue("department", Department);
            writer.WriteCollectionOfObjectValues<DeviceEnrollmentConfiguration>("deviceEnrollmentConfigurations", DeviceEnrollmentConfigurations);
            writer.WriteIntValue("deviceEnrollmentLimit", DeviceEnrollmentLimit);
            writer.WriteCollectionOfObjectValues<DeviceKey>("deviceKeys", DeviceKeys);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>("deviceManagementTroubleshootingEvents", DeviceManagementTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<Device>("devices", Devices);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("directReports", DirectReports);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Drive>("drives", Drives);
            writer.WriteDateTimeOffsetValue("employeeHireDate", EmployeeHireDate);
            writer.WriteStringValue("employeeId", EmployeeId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EmployeeOrgData>("employeeOrgData", EmployeeOrgData);
            writer.WriteStringValue("employeeType", EmployeeType);
            writer.WriteCollectionOfObjectValues<Event>("events", Events);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteStringValue("externalUserState", ExternalUserState);
            writer.WriteStringValue("externalUserStateChangeDateTime", ExternalUserStateChangeDateTime);
            writer.WriteStringValue("faxNumber", FaxNumber);
            writer.WriteCollectionOfObjectValues<Site>("followedSites", FollowedSites);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteDateTimeOffsetValue("hireDate", HireDate);
            writer.WriteCollectionOfObjectValues<ObjectIdentity>("identities", Identities);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.InferenceClassification>("inferenceClassification", InferenceClassification);
            writer.WriteCollectionOfPrimitiveValues<string>("infoCatalogs", InfoCatalogs);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.InformationProtection>("informationProtection", InformationProtection);
            writer.WriteObjectValue<ItemInsights>("insights", Insights);
            writer.WriteCollectionOfPrimitiveValues<string>("interests", Interests);
            writer.WriteBoolValue("isManagementRestricted", IsManagementRestricted);
            writer.WriteBoolValue("isResourceAccount", IsResourceAccount);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteCollectionOfObjectValues<Group>("joinedGroups", JoinedGroups);
            writer.WriteCollectionOfObjectValues<Team>("joinedTeams", JoinedTeams);
            writer.WriteDateTimeOffsetValue("lastPasswordChangeDateTime", LastPasswordChangeDateTime);
            writer.WriteStringValue("legalAgeGroupClassification", LegalAgeGroupClassification);
            writer.WriteCollectionOfObjectValues<LicenseAssignmentState>("licenseAssignmentStates", LicenseAssignmentStates);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LicenseDetails>("licenseDetails", LicenseDetails);
            writer.WriteStringValue("mail", Mail);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MailboxSettings>("mailboxSettings", MailboxSettings);
            writer.WriteCollectionOfObjectValues<MailFolder>("mailFolders", MailFolders);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteCollectionOfObjectValues<ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteObjectValue<DirectoryObject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteCollectionOfObjectValues<Message>("messages", Messages);
            writer.WriteCollectionOfObjectValues<MobileAppIntentAndState>("mobileAppIntentAndStates", MobileAppIntentAndStates);
            writer.WriteCollectionOfObjectValues<MobileAppTroubleshootingEvent>("mobileAppTroubleshootingEvents", MobileAppTroubleshootingEvents);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteStringValue("mySite", MySite);
            writer.WriteCollectionOfObjectValues<Notification>("notifications", Notifications);
            writer.WriteCollectionOfObjectValues<OAuth2PermissionGrant>("oauth2PermissionGrants", Oauth2PermissionGrants);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteStringValue("onPremisesDistinguishedName", OnPremisesDistinguishedName);
            writer.WriteStringValue("onPremisesDomainName", OnPremisesDomainName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.OnPremisesExtensionAttributes>("onPremisesExtensionAttributes", OnPremisesExtensionAttributes);
            writer.WriteStringValue("onPremisesImmutableId", OnPremisesImmutableId);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteCollectionOfObjectValues<OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteStringValue("onPremisesSamAccountName", OnPremisesSamAccountName);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("onPremisesUserPrincipalName", OnPremisesUserPrincipalName);
            writer.WriteCollectionOfPrimitiveValues<string>("otherMails", OtherMails);
            writer.WriteObjectValue<OutlookUser>("outlook", Outlook);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedDevices", OwnedDevices);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedObjects", OwnedObjects);
            writer.WriteStringValue("passwordPolicies", PasswordPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PasswordProfile>("passwordProfile", PasswordProfile);
            writer.WriteCollectionOfPrimitiveValues<string>("pastProjects", PastProjects);
            writer.WriteCollectionOfObjectValues<AccessReviewInstance>("pendingAccessReviewInstances", PendingAccessReviewInstances);
            writer.WriteCollectionOfObjectValues<Person>("people", People);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteCollectionOfObjectValues<ProfilePhoto>("photos", Photos);
            writer.WriteObjectValue<PlannerUser>("planner", Planner);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("preferredDataLocation", PreferredDataLocation);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteStringValue("preferredName", PreferredName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Presence>("presence", Presence);
            writer.WriteObjectValue<UserPrint>("print", Print);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Profile>("profile", Profile);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteDateTimeOffsetValue("refreshTokensValidFromDateTime", RefreshTokensValidFromDateTime);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredDevices", RegisteredDevices);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibilities", Responsibilities);
            writer.WriteCollectionOfPrimitiveValues<string>("schools", Schools);
            writer.WriteCollectionOfObjectValues<ScopedRoleMembership>("scopedRoleMemberOf", ScopedRoleMemberOf);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.Security>("security", Security);
            writer.WriteObjectValue<UserSettings>("settings", Settings);
            writer.WriteBoolValue("showInAddressList", ShowInAddressList);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SignInActivity>("signInActivity", SignInActivity);
            writer.WriteDateTimeOffsetValue("signInSessionsValidFromDateTime", SignInSessionsValidFromDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("skills", Skills);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("streetAddress", StreetAddress);
            writer.WriteStringValue("surname", Surname);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Tasks>("tasks", Tasks);
            writer.WriteObjectValue<UserTeamwork>("teamwork", Teamwork);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Todo>("todo", Todo);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveReports", TransitiveReports);
            writer.WriteStringValue("usageLocation", UsageLocation);
            writer.WriteCollectionOfObjectValues<UsageRight>("usageRights", UsageRights);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userType", UserType);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionDeviceRegistration>("windowsInformationProtectionDeviceRegistrations", WindowsInformationProtectionDeviceRegistrations);
        }
    }
}
