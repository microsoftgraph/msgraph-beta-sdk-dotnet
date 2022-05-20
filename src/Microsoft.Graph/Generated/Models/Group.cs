using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class Group : DirectoryObject, IParsable {
        /// <summary>The list of users or groups that are allowed to create post&apos;s or calendar events in this group. If this list is non-empty then only users or groups listed here are allowed to post.</summary>
        public List<DirectoryObject> AcceptedSenders {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(AcceptedSenders)); }
            set { BackingStore?.Set(nameof(AcceptedSenders), value); }
        }
        /// <summary>The accessType property</summary>
        public GroupAccessType? AccessType {
            get { return BackingStore?.Get<GroupAccessType?>(nameof(AccessType)); }
            set { BackingStore?.Set(nameof(AccessType), value); }
        }
        /// <summary>Indicates if people external to the organization can send messages to the group. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? AllowExternalSenders {
            get { return BackingStore?.Get<bool?>(nameof(AllowExternalSenders)); }
            set { BackingStore?.Set(nameof(AllowExternalSenders), value); }
        }
        /// <summary>Represents the app roles a group has been granted for an application. Supports $expand.</summary>
        public List<AppRoleAssignment> AppRoleAssignments {
            get { return BackingStore?.Get<List<AppRoleAssignment>>(nameof(AppRoleAssignments)); }
            set { BackingStore?.Set(nameof(AppRoleAssignments), value); }
        }
        /// <summary>The list of sensitivity label pairs (label ID, label name) associated with a Microsoft 365 group. Returned only on $select.</summary>
        public List<AssignedLabel> AssignedLabels {
            get { return BackingStore?.Get<List<AssignedLabel>>(nameof(AssignedLabels)); }
            set { BackingStore?.Set(nameof(AssignedLabels), value); }
        }
        /// <summary>The licenses that are assigned to the group. Returned only on $select. Supports $filter (eq). Read-only.</summary>
        public List<AssignedLicense> AssignedLicenses {
            get { return BackingStore?.Get<List<AssignedLicense>>(nameof(AssignedLicenses)); }
            set { BackingStore?.Set(nameof(AssignedLicenses), value); }
        }
        /// <summary>Indicates if new members added to the group will be auto-subscribed to receive email notifications. You can set this property in a PATCH request for the group; do not set it in the initial POST request that creates the group. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? AutoSubscribeNewMembers {
            get { return BackingStore?.Get<bool?>(nameof(AutoSubscribeNewMembers)); }
            set { BackingStore?.Set(nameof(AutoSubscribeNewMembers), value); }
        }
        /// <summary>The group&apos;s calendar. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Calendar Calendar {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Calendar>(nameof(Calendar)); }
            set { BackingStore?.Set(nameof(Calendar), value); }
        }
        /// <summary>The calendar view for the calendar. Read-only.</summary>
        public List<Event> CalendarView {
            get { return BackingStore?.Get<List<Event>>(nameof(CalendarView)); }
            set { BackingStore?.Set(nameof(CalendarView), value); }
        }
        /// <summary>Describes a classification for the group (such as low, medium or high business impact). Valid values for this property are defined by creating a ClassificationList setting value, based on the template definition.Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith).</summary>
        public string Classification {
            get { return BackingStore?.Get<string>(nameof(Classification)); }
            set { BackingStore?.Set(nameof(Classification), value); }
        }
        /// <summary>The group&apos;s conversations.</summary>
        public List<Conversation> Conversations {
            get { return BackingStore?.Get<List<Conversation>>(nameof(Conversations)); }
            set { BackingStore?.Set(nameof(Conversations), value); }
        }
        /// <summary>App ID of the app used to create the group. Can be null for some groups. Returned by default. Read-only. Supports $filter (eq, ne, not, in, startsWith).</summary>
        public string CreatedByAppId {
            get { return BackingStore?.Get<string>(nameof(CreatedByAppId)); }
            set { BackingStore?.Set(nameof(CreatedByAppId), value); }
        }
        /// <summary>Timestamp of when the group was created. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, not, ge, le, in). Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The user (or application) that created the group. Note: This is not set if the user is an administrator. Read-only.</summary>
        public DirectoryObject CreatedOnBehalfOf {
            get { return BackingStore?.Get<DirectoryObject>(nameof(CreatedOnBehalfOf)); }
            set { BackingStore?.Set(nameof(CreatedOnBehalfOf), value); }
        }
        /// <summary>An optional description for the group. Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name for the group. Required. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The group&apos;s default drive. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Drive Drive {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Drive>(nameof(Drive)); }
            set { BackingStore?.Set(nameof(Drive), value); }
        }
        /// <summary>The group&apos;s drives. Read-only.</summary>
        public List<Microsoft.Graph.Beta.Models.Drive> Drives {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Drive>>(nameof(Drives)); }
            set { BackingStore?.Set(nameof(Drives), value); }
        }
        /// <summary>Endpoints for the group. Read-only. Nullable.</summary>
        public List<Endpoint> Endpoints {
            get { return BackingStore?.Get<List<Endpoint>>(nameof(Endpoints)); }
            set { BackingStore?.Set(nameof(Endpoints), value); }
        }
        /// <summary>The group&apos;s events.</summary>
        public List<Event> Events {
            get { return BackingStore?.Get<List<Event>>(nameof(Events)); }
            set { BackingStore?.Set(nameof(Events), value); }
        }
        /// <summary>Timestamp of when the group is set to expire. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, not, ge, le, in). Read-only.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ExpirationDateTime), value); }
        }
        /// <summary>The collection of open extensions defined for the group. Read-only. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>The collection of lifecycle policies for this group. Read-only. Nullable.</summary>
        public List<GroupLifecyclePolicy> GroupLifecyclePolicies {
            get { return BackingStore?.Get<List<GroupLifecyclePolicy>>(nameof(GroupLifecyclePolicies)); }
            set { BackingStore?.Set(nameof(GroupLifecyclePolicies), value); }
        }
        /// <summary>Specifies the group type and its membership. If the collection contains Unified, the group is a Microsoft 365 group; otherwise, it&apos;s either a security group or distribution group. For details, see groups overview.If the collection includes DynamicMembership, the group has dynamic membership; otherwise, membership is static. Returned by default. Supports $filter (eq, not).</summary>
        public List<string> GroupTypes {
            get { return BackingStore?.Get<List<string>>(nameof(GroupTypes)); }
            set { BackingStore?.Set(nameof(GroupTypes), value); }
        }
        /// <summary>Indicates whether there are members in this group that have license errors from its group-based license assignment. This property is never returned on a GET operation. You can use it as a $filter argument to get groups that have members with license errors (that is, filter for this property being true).  Supports $filter (eq).</summary>
        public bool? HasMembersWithLicenseErrors {
            get { return BackingStore?.Get<bool?>(nameof(HasMembersWithLicenseErrors)); }
            set { BackingStore?.Set(nameof(HasMembersWithLicenseErrors), value); }
        }
        /// <summary>true if the group is not displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups; false otherwise. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? HideFromAddressLists {
            get { return BackingStore?.Get<bool?>(nameof(HideFromAddressLists)); }
            set { BackingStore?.Set(nameof(HideFromAddressLists), value); }
        }
        /// <summary>true if the group is not displayed in Outlook clients, such as Outlook for Windows and Outlook on the web, false otherwise. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? HideFromOutlookClients {
            get { return BackingStore?.Get<bool?>(nameof(HideFromOutlookClients)); }
            set { BackingStore?.Set(nameof(HideFromOutlookClients), value); }
        }
        /// <summary>Identifies the info segments assigned to the group. Returned by default. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> InfoCatalogs {
            get { return BackingStore?.Get<List<string>>(nameof(InfoCatalogs)); }
            set { BackingStore?.Set(nameof(InfoCatalogs), value); }
        }
        /// <summary>When a group is associated with a team, this property determines whether the team is in read-only mode.</summary>
        public bool? IsArchived {
            get { return BackingStore?.Get<bool?>(nameof(IsArchived)); }
            set { BackingStore?.Set(nameof(IsArchived), value); }
        }
        /// <summary>Indicates whether this group can be assigned to an Azure Active Directory role. Optional. This property can only be set while creating the group and is immutable. If set to true, the securityEnabled property must also be set to true and the group cannot be a dynamic group (that is, groupTypes cannot contain DynamicMembership). Only callers in Global administrator and Privileged role administrator roles can set this property. The caller must be assigned the RoleManagement.ReadWrite.Directory permission to set this property or update the membership of such groups. For more, see Using a group to manage Azure AD role assignmentsReturned by default. Supports $filter (eq, ne, not).</summary>
        public bool? IsAssignableToRole {
            get { return BackingStore?.Get<bool?>(nameof(IsAssignableToRole)); }
            set { BackingStore?.Set(nameof(IsAssignableToRole), value); }
        }
        /// <summary>The isFavorite property</summary>
        public bool? IsFavorite {
            get { return BackingStore?.Get<bool?>(nameof(IsFavorite)); }
            set { BackingStore?.Set(nameof(IsFavorite), value); }
        }
        /// <summary>The isManagementRestricted property</summary>
        public bool? IsManagementRestricted {
            get { return BackingStore?.Get<bool?>(nameof(IsManagementRestricted)); }
            set { BackingStore?.Set(nameof(IsManagementRestricted), value); }
        }
        /// <summary>Indicates whether the signed-in user is subscribed to receive email conversations. Default value is true. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? IsSubscribedByMail {
            get { return BackingStore?.Get<bool?>(nameof(IsSubscribedByMail)); }
            set { BackingStore?.Set(nameof(IsSubscribedByMail), value); }
        }
        /// <summary>Indicates status of the group license assignment to all members of the group. Possible values: QueuedForProcessing, ProcessingInProgress, and ProcessingComplete. Returned only on $select. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.LicenseProcessingState LicenseProcessingState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LicenseProcessingState>(nameof(LicenseProcessingState)); }
            set { BackingStore?.Set(nameof(LicenseProcessingState), value); }
        }
        /// <summary>The SMTP address for the group, for example, &apos;serviceadmins@contoso.onmicrosoft.com&apos;. Returned by default. Read-only. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Mail {
            get { return BackingStore?.Get<string>(nameof(Mail)); }
            set { BackingStore?.Set(nameof(Mail), value); }
        }
        /// <summary>Specifies whether the group is mail-enabled. Required. Returned by default. Supports $filter (eq, ne, not, and eq on null values).</summary>
        public bool? MailEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MailEnabled)); }
            set { BackingStore?.Set(nameof(MailEnabled), value); }
        }
        /// <summary>The mail alias for the group, unique for Microsoft 365 groups in the organization. Maximum length is 64 characters. This property can contain only characters in the ASCII character set 0 - 127 except the following: @ () / [] &apos; ; : . &lt;&gt; , SPACE. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith).</summary>
        public string MailNickname {
            get { return BackingStore?.Get<string>(nameof(MailNickname)); }
            set { BackingStore?.Set(nameof(MailNickname), value); }
        }
        /// <summary>The mdmAppId property</summary>
        public string MdmAppId {
            get { return BackingStore?.Get<string>(nameof(MdmAppId)); }
            set { BackingStore?.Set(nameof(MdmAppId), value); }
        }
        /// <summary>Groups and administrative units that this group is a member of. HTTP Methods: GET (supported for all groups). Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(MemberOf)); }
            set { BackingStore?.Set(nameof(MemberOf), value); }
        }
        /// <summary>Members of this group, who can be users, devices, other groups, or service principals. Supports the List members, Add member, and Remove member operations. Nullable. Supports $expand including nested $select. For example, /groups?$filter=startsWith(displayName,&apos;Role&apos;)&amp;$select=id,displayName&amp;$expand=members($select=id,userPrincipalName,displayName).</summary>
        public List<DirectoryObject> Members {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(Members)); }
            set { BackingStore?.Set(nameof(Members), value); }
        }
        /// <summary>The rule that determines members for this group if the group is a dynamic group (groupTypes contains DynamicMembership). For more information about the syntax of the membership rule, see Membership Rules syntax. Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith).</summary>
        public string MembershipRule {
            get { return BackingStore?.Get<string>(nameof(MembershipRule)); }
            set { BackingStore?.Set(nameof(MembershipRule), value); }
        }
        /// <summary>Indicates whether the dynamic membership processing is on or paused. Possible values are On or Paused. Returned by default. Supports $filter (eq, ne, not, in).</summary>
        public string MembershipRuleProcessingState {
            get { return BackingStore?.Get<string>(nameof(MembershipRuleProcessingState)); }
            set { BackingStore?.Set(nameof(MembershipRuleProcessingState), value); }
        }
        /// <summary>Describes the processing status for rules-based dynamic groups. The property is null for non-rule based dynamic groups or if the dynamic group processing has been paused. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}). Read-only.</summary>
        public Microsoft.Graph.Beta.Models.MembershipRuleProcessingStatus MembershipRuleProcessingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MembershipRuleProcessingStatus>(nameof(MembershipRuleProcessingStatus)); }
            set { BackingStore?.Set(nameof(MembershipRuleProcessingStatus), value); }
        }
        /// <summary>A list of group members with license errors from this group-based license assignment. Read-only.</summary>
        public List<DirectoryObject> MembersWithLicenseErrors {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(MembersWithLicenseErrors)); }
            set { BackingStore?.Set(nameof(MembersWithLicenseErrors), value); }
        }
        /// <summary>Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Onenote Onenote {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Onenote>(nameof(Onenote)); }
            set { BackingStore?.Set(nameof(Onenote), value); }
        }
        /// <summary>Contains the on-premises domain FQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Read-only.</summary>
        public string OnPremisesDomainName {
            get { return BackingStore?.Get<string>(nameof(OnPremisesDomainName)); }
            set { BackingStore?.Set(nameof(OnPremisesDomainName), value); }
        }
        /// <summary>Indicates the last time at which the group was synced with the on-premises directory.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Read-only. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(OnPremisesLastSyncDateTime)); }
            set { BackingStore?.Set(nameof(OnPremisesLastSyncDateTime), value); }
        }
        /// <summary>Contains the on-premises netBios name synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Read-only.</summary>
        public string OnPremisesNetBiosName {
            get { return BackingStore?.Get<string>(nameof(OnPremisesNetBiosName)); }
            set { BackingStore?.Set(nameof(OnPremisesNetBiosName), value); }
        }
        /// <summary>Errors when using Microsoft synchronization product during provisioning. Returned by default. Supports $filter (eq, not).</summary>
        public List<OnPremisesProvisioningError> OnPremisesProvisioningErrors {
            get { return BackingStore?.Get<List<OnPremisesProvisioningError>>(nameof(OnPremisesProvisioningErrors)); }
            set { BackingStore?.Set(nameof(OnPremisesProvisioningErrors), value); }
        }
        /// <summary>Contains the on-premises SAM account name synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith). Read-only.</summary>
        public string OnPremisesSamAccountName {
            get { return BackingStore?.Get<string>(nameof(OnPremisesSamAccountName)); }
            set { BackingStore?.Set(nameof(OnPremisesSamAccountName), value); }
        }
        /// <summary>Contains the on-premises security identifier (SID) for the group that was synchronized from on-premises to the cloud. Returned by default. Supports $filter (eq including on null values). Read-only.</summary>
        public string OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string>(nameof(OnPremisesSecurityIdentifier)); }
            set { BackingStore?.Set(nameof(OnPremisesSecurityIdentifier), value); }
        }
        /// <summary>true if this group is synced from an on-premises directory; false if this group was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Returned by default. Read-only. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled {
            get { return BackingStore?.Get<bool?>(nameof(OnPremisesSyncEnabled)); }
            set { BackingStore?.Set(nameof(OnPremisesSyncEnabled), value); }
        }
        /// <summary>The organizationId property</summary>
        public string OrganizationId {
            get { return BackingStore?.Get<string>(nameof(OrganizationId)); }
            set { BackingStore?.Set(nameof(OrganizationId), value); }
        }
        /// <summary>The owners of the group who can be users or service principals. Nullable. If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner. Supports $expand including nested $select. For example, /groups?$filter=startsWith(displayName,&apos;Role&apos;)&amp;$select=id,displayName&amp;$expand=owners($select=id,userPrincipalName,displayName).</summary>
        public List<DirectoryObject> Owners {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(Owners)); }
            set { BackingStore?.Set(nameof(Owners), value); }
        }
        /// <summary>The permissions that have been granted for a group to a specific application. Supports $expand.</summary>
        public List<ResourceSpecificPermissionGrant> PermissionGrants {
            get { return BackingStore?.Get<List<ResourceSpecificPermissionGrant>>(nameof(PermissionGrants)); }
            set { BackingStore?.Set(nameof(PermissionGrants), value); }
        }
        /// <summary>The group&apos;s profile photo.</summary>
        public ProfilePhoto Photo {
            get { return BackingStore?.Get<ProfilePhoto>(nameof(Photo)); }
            set { BackingStore?.Set(nameof(Photo), value); }
        }
        /// <summary>The profile photos owned by the group. Read-only. Nullable.</summary>
        public List<ProfilePhoto> Photos {
            get { return BackingStore?.Get<List<ProfilePhoto>>(nameof(Photos)); }
            set { BackingStore?.Set(nameof(Photos), value); }
        }
        /// <summary>Selective Planner services available to the group. Read-only. Nullable.</summary>
        public PlannerGroup Planner {
            get { return BackingStore?.Get<PlannerGroup>(nameof(Planner)); }
            set { BackingStore?.Set(nameof(Planner), value); }
        }
        /// <summary>The preferred data location for the Microsoft 365 group. By default, the group inherits the group creator&apos;s preferred data location. To set this property, the calling user must be assigned one of the following Azure AD roles:  Global Administrator  User Account Administrator Directory Writer  Exchange Administrator  SharePoint Administrator  For more information about this property, see OneDrive Online Multi-Geo. Nullable. Returned by default.</summary>
        public string PreferredDataLocation {
            get { return BackingStore?.Get<string>(nameof(PreferredDataLocation)); }
            set { BackingStore?.Set(nameof(PreferredDataLocation), value); }
        }
        /// <summary>The preferred language for a Microsoft 365 group. Should follow ISO 639-1 Code; for example en-US. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string PreferredLanguage {
            get { return BackingStore?.Get<string>(nameof(PreferredLanguage)); }
            set { BackingStore?.Set(nameof(PreferredLanguage), value); }
        }
        /// <summary>Email addresses for the group that direct to the same group mailbox. For example: [&apos;SMTP: bob@contoso.com&apos;, &apos;smtp: bob@sales.contoso.com&apos;]. The any operator is required for filter expressions on multi-valued properties. Returned by default. Read-only. Not nullable. Supports $filter (eq, not, ge, le, startsWith, endsWith, and counting empty collections).</summary>
        public List<string> ProxyAddresses {
            get { return BackingStore?.Get<List<string>>(nameof(ProxyAddresses)); }
            set { BackingStore?.Set(nameof(ProxyAddresses), value); }
        }
        /// <summary>The list of users or groups that are not allowed to create posts or calendar events in this group. Nullable</summary>
        public List<DirectoryObject> RejectedSenders {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(RejectedSenders)); }
            set { BackingStore?.Set(nameof(RejectedSenders), value); }
        }
        /// <summary>Timestamp of when the group was last renewed. This cannot be modified directly and is only updated via the renew service action. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, not, ge, le, in). Read-only.</summary>
        public DateTimeOffset? RenewedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RenewedDateTime)); }
            set { BackingStore?.Set(nameof(RenewedDateTime), value); }
        }
        /// <summary>Specifies the group behaviors that can be set for a Microsoft 365 group during creation. This can be set only as part of creation (POST). Possible values are AllowOnlyMembersToPost, HideGroupInOutlook, SubscribeNewGroupMembers, WelcomeEmailDisabled. For more information, see Set Microsoft 365 group behaviors and provisioning options.</summary>
        public List<string> ResourceBehaviorOptions {
            get { return BackingStore?.Get<List<string>>(nameof(ResourceBehaviorOptions)); }
            set { BackingStore?.Set(nameof(ResourceBehaviorOptions), value); }
        }
        /// <summary>Specifies the group resources that are provisioned as part of Microsoft 365 group creation, that are not normally part of default group creation. Possible value is Team. For more information, see Set Microsoft 365 group behaviors and provisioning options. Returned by default. Supports $filter (eq, not, startsWith.</summary>
        public List<string> ResourceProvisioningOptions {
            get { return BackingStore?.Get<List<string>>(nameof(ResourceProvisioningOptions)); }
            set { BackingStore?.Set(nameof(ResourceProvisioningOptions), value); }
        }
        /// <summary>Specifies whether the group is a security group. Required.Returned by default. Supports $filter (eq, ne, not, in).</summary>
        public bool? SecurityEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SecurityEnabled)); }
            set { BackingStore?.Set(nameof(SecurityEnabled), value); }
        }
        /// <summary>Security identifier of the group, used in Windows scenarios. Returned by default.</summary>
        public string SecurityIdentifier {
            get { return BackingStore?.Get<string>(nameof(SecurityIdentifier)); }
            set { BackingStore?.Set(nameof(SecurityIdentifier), value); }
        }
        /// <summary>Settings that can govern this group&apos;s behavior, like whether members can invite guest users to the group. Nullable.</summary>
        public List<DirectorySetting> Settings {
            get { return BackingStore?.Get<List<DirectorySetting>>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>The list of SharePoint sites in this group. Access the default site with /sites/root.</summary>
        public List<Site> Sites {
            get { return BackingStore?.Get<List<Site>>(nameof(Sites)); }
            set { BackingStore?.Set(nameof(Sites), value); }
        }
        /// <summary>The team associated with this group.</summary>
        public Microsoft.Graph.Beta.Models.Team Team {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Team>(nameof(Team)); }
            set { BackingStore?.Set(nameof(Team), value); }
        }
        /// <summary>Specifies a Microsoft 365 group&apos;s color theme. Possible values are Teal, Purple, Green, Blue, Pink, Orange or Red. Returned by default.</summary>
        public string Theme {
            get { return BackingStore?.Get<string>(nameof(Theme)); }
            set { BackingStore?.Set(nameof(Theme), value); }
        }
        /// <summary>The group&apos;s conversation threads. Nullable.</summary>
        public List<ConversationThread> Threads {
            get { return BackingStore?.Get<List<ConversationThread>>(nameof(Threads)); }
            set { BackingStore?.Set(nameof(Threads), value); }
        }
        /// <summary>The transitiveMemberOf property</summary>
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(TransitiveMemberOf)); }
            set { BackingStore?.Set(nameof(TransitiveMemberOf), value); }
        }
        /// <summary>The transitiveMembers property</summary>
        public List<DirectoryObject> TransitiveMembers {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(TransitiveMembers)); }
            set { BackingStore?.Set(nameof(TransitiveMembers), value); }
        }
        /// <summary>Count of conversations that have been delivered one or more new posts since the signed-in user&apos;s last visit to the group. This property is the same as unseenCount. Returned only on $select.</summary>
        public int? UnseenConversationsCount {
            get { return BackingStore?.Get<int?>(nameof(UnseenConversationsCount)); }
            set { BackingStore?.Set(nameof(UnseenConversationsCount), value); }
        }
        /// <summary>Count of conversations that have received new posts since the signed-in user last visited the group. This property is the same as unseenConversationsCount.Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public int? UnseenCount {
            get { return BackingStore?.Get<int?>(nameof(UnseenCount)); }
            set { BackingStore?.Set(nameof(UnseenCount), value); }
        }
        /// <summary>Count of new posts that have been delivered to the group&apos;s conversations since the signed-in user&apos;s last visit to the group. Returned only on $select.</summary>
        public int? UnseenMessagesCount {
            get { return BackingStore?.Get<int?>(nameof(UnseenMessagesCount)); }
            set { BackingStore?.Set(nameof(UnseenMessagesCount), value); }
        }
        /// <summary>Specifies the group join policy and group content visibility for groups. Possible values are: Private, Public, or Hiddenmembership. Hiddenmembership can be set only for Microsoft 365 groups, when the groups are created. It can&apos;t be updated later. Other values of visibility can be updated after group creation. If visibility value is not specified during group creation on Microsoft Graph, a security group is created as Private by default and Microsoft 365 group is Public. Groups assignable to roles are always Private. See group visibility options to learn more. Returned by default. Nullable.</summary>
        public string Visibility {
            get { return BackingStore?.Get<string>(nameof(Visibility)); }
            set { BackingStore?.Set(nameof(Visibility), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Group CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Group();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptedSenders", n => { AcceptedSenders = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"accessType", n => { AccessType = n.GetEnumValue<GroupAccessType>(); } },
                {"allowExternalSenders", n => { AllowExternalSenders = n.GetBoolValue(); } },
                {"appRoleAssignments", n => { AppRoleAssignments = n.GetCollectionOfObjectValues<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedLabels", n => { AssignedLabels = n.GetCollectionOfObjectValues<AssignedLabel>(AssignedLabel.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedLicenses", n => { AssignedLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue).ToList(); } },
                {"autoSubscribeNewMembers", n => { AutoSubscribeNewMembers = n.GetBoolValue(); } },
                {"calendar", n => { Calendar = n.GetObjectValue<Microsoft.Graph.Beta.Models.Calendar>(Microsoft.Graph.Beta.Models.Calendar.CreateFromDiscriminatorValue); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"classification", n => { Classification = n.GetStringValue(); } },
                {"conversations", n => { Conversations = n.GetCollectionOfObjectValues<Conversation>(Conversation.CreateFromDiscriminatorValue).ToList(); } },
                {"createdByAppId", n => { CreatedByAppId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdOnBehalfOf", n => { CreatedOnBehalfOf = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue).ToList(); } },
                {"endpoints", n => { Endpoints = n.GetCollectionOfObjectValues<Endpoint>(Endpoint.CreateFromDiscriminatorValue).ToList(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"groupLifecyclePolicies", n => { GroupLifecyclePolicies = n.GetCollectionOfObjectValues<GroupLifecyclePolicy>(GroupLifecyclePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"groupTypes", n => { GroupTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"hasMembersWithLicenseErrors", n => { HasMembersWithLicenseErrors = n.GetBoolValue(); } },
                {"hideFromAddressLists", n => { HideFromAddressLists = n.GetBoolValue(); } },
                {"hideFromOutlookClients", n => { HideFromOutlookClients = n.GetBoolValue(); } },
                {"infoCatalogs", n => { InfoCatalogs = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isAssignableToRole", n => { IsAssignableToRole = n.GetBoolValue(); } },
                {"isFavorite", n => { IsFavorite = n.GetBoolValue(); } },
                {"isManagementRestricted", n => { IsManagementRestricted = n.GetBoolValue(); } },
                {"isSubscribedByMail", n => { IsSubscribedByMail = n.GetBoolValue(); } },
                {"licenseProcessingState", n => { LicenseProcessingState = n.GetObjectValue<Microsoft.Graph.Beta.Models.LicenseProcessingState>(Microsoft.Graph.Beta.Models.LicenseProcessingState.CreateFromDiscriminatorValue); } },
                {"mail", n => { Mail = n.GetStringValue(); } },
                {"mailEnabled", n => { MailEnabled = n.GetBoolValue(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"mdmAppId", n => { MdmAppId = n.GetStringValue(); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"membershipRule", n => { MembershipRule = n.GetStringValue(); } },
                {"membershipRuleProcessingState", n => { MembershipRuleProcessingState = n.GetStringValue(); } },
                {"membershipRuleProcessingStatus", n => { MembershipRuleProcessingStatus = n.GetObjectValue<Microsoft.Graph.Beta.Models.MembershipRuleProcessingStatus>(Microsoft.Graph.Beta.Models.MembershipRuleProcessingStatus.CreateFromDiscriminatorValue); } },
                {"membersWithLicenseErrors", n => { MembersWithLicenseErrors = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"onenote", n => { Onenote = n.GetObjectValue<Microsoft.Graph.Beta.Models.Onenote>(Microsoft.Graph.Beta.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"onPremisesDomainName", n => { OnPremisesDomainName = n.GetStringValue(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesNetBiosName", n => { OnPremisesNetBiosName = n.GetStringValue(); } },
                {"onPremisesProvisioningErrors", n => { OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<OnPremisesProvisioningError>(OnPremisesProvisioningError.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesSamAccountName", n => { OnPremisesSamAccountName = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"organizationId", n => { OrganizationId = n.GetStringValue(); } },
                {"owners", n => { Owners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"permissionGrants", n => { PermissionGrants = n.GetCollectionOfObjectValues<ResourceSpecificPermissionGrant>(ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"photos", n => { Photos = n.GetCollectionOfObjectValues<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue).ToList(); } },
                {"planner", n => { Planner = n.GetObjectValue<PlannerGroup>(PlannerGroup.CreateFromDiscriminatorValue); } },
                {"preferredDataLocation", n => { PreferredDataLocation = n.GetStringValue(); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"proxyAddresses", n => { ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rejectedSenders", n => { RejectedSenders = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"renewedDateTime", n => { RenewedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resourceBehaviorOptions", n => { ResourceBehaviorOptions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"resourceProvisioningOptions", n => { ResourceProvisioningOptions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"securityEnabled", n => { SecurityEnabled = n.GetBoolValue(); } },
                {"securityIdentifier", n => { SecurityIdentifier = n.GetStringValue(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<DirectorySetting>(DirectorySetting.CreateFromDiscriminatorValue).ToList(); } },
                {"sites", n => { Sites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue).ToList(); } },
                {"team", n => { Team = n.GetObjectValue<Microsoft.Graph.Beta.Models.Team>(Microsoft.Graph.Beta.Models.Team.CreateFromDiscriminatorValue); } },
                {"theme", n => { Theme = n.GetStringValue(); } },
                {"threads", n => { Threads = n.GetCollectionOfObjectValues<ConversationThread>(ConversationThread.CreateFromDiscriminatorValue).ToList(); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"transitiveMembers", n => { TransitiveMembers = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"unseenConversationsCount", n => { UnseenConversationsCount = n.GetIntValue(); } },
                {"unseenCount", n => { UnseenCount = n.GetIntValue(); } },
                {"unseenMessagesCount", n => { UnseenMessagesCount = n.GetIntValue(); } },
                {"visibility", n => { Visibility = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("acceptedSenders", AcceptedSenders);
            writer.WriteEnumValue<GroupAccessType>("accessType", AccessType);
            writer.WriteBoolValue("allowExternalSenders", AllowExternalSenders);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<AssignedLabel>("assignedLabels", AssignedLabels);
            writer.WriteCollectionOfObjectValues<AssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteBoolValue("autoSubscribeNewMembers", AutoSubscribeNewMembers);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Calendar>("calendar", Calendar);
            writer.WriteCollectionOfObjectValues<Event>("calendarView", CalendarView);
            writer.WriteStringValue("classification", Classification);
            writer.WriteCollectionOfObjectValues<Conversation>("conversations", Conversations);
            writer.WriteStringValue("createdByAppId", CreatedByAppId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DirectoryObject>("createdOnBehalfOf", CreatedOnBehalfOf);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Drive>("drives", Drives);
            writer.WriteCollectionOfObjectValues<Endpoint>("endpoints", Endpoints);
            writer.WriteCollectionOfObjectValues<Event>("events", Events);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfObjectValues<GroupLifecyclePolicy>("groupLifecyclePolicies", GroupLifecyclePolicies);
            writer.WriteCollectionOfPrimitiveValues<string>("groupTypes", GroupTypes);
            writer.WriteBoolValue("hasMembersWithLicenseErrors", HasMembersWithLicenseErrors);
            writer.WriteBoolValue("hideFromAddressLists", HideFromAddressLists);
            writer.WriteBoolValue("hideFromOutlookClients", HideFromOutlookClients);
            writer.WriteCollectionOfPrimitiveValues<string>("infoCatalogs", InfoCatalogs);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isAssignableToRole", IsAssignableToRole);
            writer.WriteBoolValue("isFavorite", IsFavorite);
            writer.WriteBoolValue("isManagementRestricted", IsManagementRestricted);
            writer.WriteBoolValue("isSubscribedByMail", IsSubscribedByMail);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.LicenseProcessingState>("licenseProcessingState", LicenseProcessingState);
            writer.WriteStringValue("mail", Mail);
            writer.WriteBoolValue("mailEnabled", MailEnabled);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteStringValue("mdmAppId", MdmAppId);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("members", Members);
            writer.WriteStringValue("membershipRule", MembershipRule);
            writer.WriteStringValue("membershipRuleProcessingState", MembershipRuleProcessingState);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MembershipRuleProcessingStatus>("membershipRuleProcessingStatus", MembershipRuleProcessingStatus);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("membersWithLicenseErrors", MembersWithLicenseErrors);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Onenote>("onenote", Onenote);
            writer.WriteStringValue("onPremisesDomainName", OnPremisesDomainName);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteStringValue("onPremisesNetBiosName", OnPremisesNetBiosName);
            writer.WriteCollectionOfObjectValues<OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteStringValue("onPremisesSamAccountName", OnPremisesSamAccountName);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("organizationId", OrganizationId);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("owners", Owners);
            writer.WriteCollectionOfObjectValues<ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteCollectionOfObjectValues<ProfilePhoto>("photos", Photos);
            writer.WriteObjectValue<PlannerGroup>("planner", Planner);
            writer.WriteStringValue("preferredDataLocation", PreferredDataLocation);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("rejectedSenders", RejectedSenders);
            writer.WriteDateTimeOffsetValue("renewedDateTime", RenewedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("resourceBehaviorOptions", ResourceBehaviorOptions);
            writer.WriteCollectionOfPrimitiveValues<string>("resourceProvisioningOptions", ResourceProvisioningOptions);
            writer.WriteBoolValue("securityEnabled", SecurityEnabled);
            writer.WriteStringValue("securityIdentifier", SecurityIdentifier);
            writer.WriteCollectionOfObjectValues<DirectorySetting>("settings", Settings);
            writer.WriteCollectionOfObjectValues<Site>("sites", Sites);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Team>("team", Team);
            writer.WriteStringValue("theme", Theme);
            writer.WriteCollectionOfObjectValues<ConversationThread>("threads", Threads);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMembers", TransitiveMembers);
            writer.WriteIntValue("unseenConversationsCount", UnseenConversationsCount);
            writer.WriteIntValue("unseenCount", UnseenCount);
            writer.WriteIntValue("unseenMessagesCount", UnseenMessagesCount);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
