using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class Team : Entity, IParsable {
        /// <summary>List of channels either hosted in or shared with the team (incoming channels).</summary>
        public List<Channel> AllChannels {
            get { return BackingStore?.Get<List<Channel>>(nameof(AllChannels)); }
            set { BackingStore?.Set(nameof(AllChannels), value); }
        }
        /// <summary>The collection of channels and messages associated with the team.</summary>
        public List<Channel> Channels {
            get { return BackingStore?.Get<List<Channel>>(nameof(Channels)); }
            set { BackingStore?.Set(nameof(Channels), value); }
        }
        /// <summary>An optional label. Typically describes the data or business sensitivity of the team. Must match one of a pre-configured set in the tenant&apos;s directory.</summary>
        public string Classification {
            get { return BackingStore?.Get<string>(nameof(Classification)); }
            set { BackingStore?.Set(nameof(Classification), value); }
        }
        /// <summary>Timestamp at which the team was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>An optional description for the team. Maximum length: 1024 characters.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Settings to configure team discoverability by others.</summary>
        public TeamDiscoverySettings DiscoverySettings {
            get { return BackingStore?.Get<TeamDiscoverySettings>(nameof(DiscoverySettings)); }
            set { BackingStore?.Set(nameof(DiscoverySettings), value); }
        }
        /// <summary>The name of the team.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Settings to configure use of Giphy, memes, and stickers in the team.</summary>
        public TeamFunSettings FunSettings {
            get { return BackingStore?.Get<TeamFunSettings>(nameof(FunSettings)); }
            set { BackingStore?.Set(nameof(FunSettings), value); }
        }
        /// <summary>The group property</summary>
        public Microsoft.Graph.Beta.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group>(nameof(Group)); }
            set { BackingStore?.Set(nameof(Group), value); }
        }
        /// <summary>Settings to configure whether guests can create, update, or delete channels in the team.</summary>
        public TeamGuestSettings GuestSettings {
            get { return BackingStore?.Get<TeamGuestSettings>(nameof(GuestSettings)); }
            set { BackingStore?.Set(nameof(GuestSettings), value); }
        }
        /// <summary>The incomingChannels property</summary>
        public List<Channel> IncomingChannels {
            get { return BackingStore?.Get<List<Channel>>(nameof(IncomingChannels)); }
            set { BackingStore?.Set(nameof(IncomingChannels), value); }
        }
        /// <summary>The apps installed in this team.</summary>
        public List<TeamsAppInstallation> InstalledApps {
            get { return BackingStore?.Get<List<TeamsAppInstallation>>(nameof(InstalledApps)); }
            set { BackingStore?.Set(nameof(InstalledApps), value); }
        }
        /// <summary>A unique ID for the team that has been used in a few places such as the audit log/Office 365 Management Activity API.</summary>
        public string InternalId {
            get { return BackingStore?.Get<string>(nameof(InternalId)); }
            set { BackingStore?.Set(nameof(InternalId), value); }
        }
        /// <summary>Whether this team is in read-only mode.</summary>
        public bool? IsArchived {
            get { return BackingStore?.Get<bool?>(nameof(IsArchived)); }
            set { BackingStore?.Set(nameof(IsArchived), value); }
        }
        /// <summary>If set to true, the team is currently in the owner-only team membership state and not accessible by other team members, such as students.</summary>
        public bool? IsMembershipLimitedToOwners {
            get { return BackingStore?.Get<bool?>(nameof(IsMembershipLimitedToOwners)); }
            set { BackingStore?.Set(nameof(IsMembershipLimitedToOwners), value); }
        }
        /// <summary>Members and owners of the team.</summary>
        public List<ConversationMember> Members {
            get { return BackingStore?.Get<List<ConversationMember>>(nameof(Members)); }
            set { BackingStore?.Set(nameof(Members), value); }
        }
        /// <summary>Settings to configure whether members can perform certain actions, for example, create channels and add bots, in the team.</summary>
        public TeamMemberSettings MemberSettings {
            get { return BackingStore?.Get<TeamMemberSettings>(nameof(MemberSettings)); }
            set { BackingStore?.Set(nameof(MemberSettings), value); }
        }
        /// <summary>Settings to configure messaging and mentions in the team.</summary>
        public TeamMessagingSettings MessagingSettings {
            get { return BackingStore?.Get<TeamMessagingSettings>(nameof(MessagingSettings)); }
            set { BackingStore?.Set(nameof(MessagingSettings), value); }
        }
        /// <summary>The async operations that ran or are running on this team.</summary>
        public List<TeamsAsyncOperation> Operations {
            get { return BackingStore?.Get<List<TeamsAsyncOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>The list of this team&apos;s owners. Currently, when creating a team using application permissions, exactly one owner must be specified. When using user delegated permissions, no owner can be specified (the current user is the owner). Owner must be specified as an object ID (GUID), not a UPN.</summary>
        public List<User> Owners {
            get { return BackingStore?.Get<List<User>>(nameof(Owners)); }
            set { BackingStore?.Set(nameof(Owners), value); }
        }
        /// <summary>A collection of permissions granted to apps to access the team.</summary>
        public List<ResourceSpecificPermissionGrant> PermissionGrants {
            get { return BackingStore?.Get<List<ResourceSpecificPermissionGrant>>(nameof(PermissionGrants)); }
            set { BackingStore?.Set(nameof(PermissionGrants), value); }
        }
        /// <summary>The team photo.</summary>
        public ProfilePhoto Photo {
            get { return BackingStore?.Get<ProfilePhoto>(nameof(Photo)); }
            set { BackingStore?.Set(nameof(Photo), value); }
        }
        /// <summary>The general channel for the team.</summary>
        public Channel PrimaryChannel {
            get { return BackingStore?.Get<Channel>(nameof(PrimaryChannel)); }
            set { BackingStore?.Set(nameof(PrimaryChannel), value); }
        }
        /// <summary>The schedule of shifts for this team.</summary>
        public Microsoft.Graph.Beta.Models.Schedule Schedule {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Schedule>(nameof(Schedule)); }
            set { BackingStore?.Set(nameof(Schedule), value); }
        }
        /// <summary>Optional. Indicates whether the team is intended for a particular use case.  Each team specialization has access to unique behaviors and experiences targeted to its use case.</summary>
        public TeamSpecialization? Specialization {
            get { return BackingStore?.Get<TeamSpecialization?>(nameof(Specialization)); }
            set { BackingStore?.Set(nameof(Specialization), value); }
        }
        /// <summary>Contains summary information about the team, including number of owners, members, and guests.</summary>
        public TeamSummary Summary {
            get { return BackingStore?.Get<TeamSummary>(nameof(Summary)); }
            set { BackingStore?.Set(nameof(Summary), value); }
        }
        /// <summary>The tags associated with the team.</summary>
        public List<TeamworkTag> Tags {
            get { return BackingStore?.Get<List<TeamworkTag>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>The template this team was created from. See available templates.</summary>
        public TeamsTemplate Template {
            get { return BackingStore?.Get<TeamsTemplate>(nameof(Template)); }
            set { BackingStore?.Set(nameof(Template), value); }
        }
        /// <summary>The ID of the Azure Active Directory tenant.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>The visibility of the group and team. Defaults to Public.</summary>
        public TeamVisibilityType? Visibility {
            get { return BackingStore?.Get<TeamVisibilityType?>(nameof(Visibility)); }
            set { BackingStore?.Set(nameof(Visibility), value); }
        }
        /// <summary>A hyperlink that will go to the team in the Microsoft Teams client. This is the URL that you get when you right-click a team in the Microsoft Teams client and select Get link to team. This URL should be treated as an opaque blob, and not parsed.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>(nameof(WebUrl)); }
            set { BackingStore?.Set(nameof(WebUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Team CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Team();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allChannels", n => { AllChannels = n.GetCollectionOfObjectValues<Channel>(Channel.CreateFromDiscriminatorValue).ToList(); } },
                {"channels", n => { Channels = n.GetCollectionOfObjectValues<Channel>(Channel.CreateFromDiscriminatorValue).ToList(); } },
                {"classification", n => { Classification = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discoverySettings", n => { DiscoverySettings = n.GetObjectValue<TeamDiscoverySettings>(TeamDiscoverySettings.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"funSettings", n => { FunSettings = n.GetObjectValue<TeamFunSettings>(TeamFunSettings.CreateFromDiscriminatorValue); } },
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.Group>(Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                {"guestSettings", n => { GuestSettings = n.GetObjectValue<TeamGuestSettings>(TeamGuestSettings.CreateFromDiscriminatorValue); } },
                {"incomingChannels", n => { IncomingChannels = n.GetCollectionOfObjectValues<Channel>(Channel.CreateFromDiscriminatorValue).ToList(); } },
                {"installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<TeamsAppInstallation>(TeamsAppInstallation.CreateFromDiscriminatorValue).ToList(); } },
                {"internalId", n => { InternalId = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isMembershipLimitedToOwners", n => { IsMembershipLimitedToOwners = n.GetBoolValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<ConversationMember>(ConversationMember.CreateFromDiscriminatorValue).ToList(); } },
                {"memberSettings", n => { MemberSettings = n.GetObjectValue<TeamMemberSettings>(TeamMemberSettings.CreateFromDiscriminatorValue); } },
                {"messagingSettings", n => { MessagingSettings = n.GetObjectValue<TeamMessagingSettings>(TeamMessagingSettings.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<TeamsAsyncOperation>(TeamsAsyncOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"owners", n => { Owners = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue).ToList(); } },
                {"permissionGrants", n => { PermissionGrants = n.GetCollectionOfObjectValues<ResourceSpecificPermissionGrant>(ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"primaryChannel", n => { PrimaryChannel = n.GetObjectValue<Channel>(Channel.CreateFromDiscriminatorValue); } },
                {"schedule", n => { Schedule = n.GetObjectValue<Microsoft.Graph.Beta.Models.Schedule>(Microsoft.Graph.Beta.Models.Schedule.CreateFromDiscriminatorValue); } },
                {"specialization", n => { Specialization = n.GetEnumValue<TeamSpecialization>(); } },
                {"summary", n => { Summary = n.GetObjectValue<TeamSummary>(TeamSummary.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<TeamworkTag>(TeamworkTag.CreateFromDiscriminatorValue).ToList(); } },
                {"template", n => { Template = n.GetObjectValue<TeamsTemplate>(TeamsTemplate.CreateFromDiscriminatorValue); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"visibility", n => { Visibility = n.GetEnumValue<TeamVisibilityType>(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Channel>("allChannels", AllChannels);
            writer.WriteCollectionOfObjectValues<Channel>("channels", Channels);
            writer.WriteStringValue("classification", Classification);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<TeamDiscoverySettings>("discoverySettings", DiscoverySettings);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<TeamFunSettings>("funSettings", FunSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Group>("group", Group);
            writer.WriteObjectValue<TeamGuestSettings>("guestSettings", GuestSettings);
            writer.WriteCollectionOfObjectValues<Channel>("incomingChannels", IncomingChannels);
            writer.WriteCollectionOfObjectValues<TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteStringValue("internalId", InternalId);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isMembershipLimitedToOwners", IsMembershipLimitedToOwners);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteObjectValue<TeamMemberSettings>("memberSettings", MemberSettings);
            writer.WriteObjectValue<TeamMessagingSettings>("messagingSettings", MessagingSettings);
            writer.WriteCollectionOfObjectValues<TeamsAsyncOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<User>("owners", Owners);
            writer.WriteCollectionOfObjectValues<ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteObjectValue<Channel>("primaryChannel", PrimaryChannel);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Schedule>("schedule", Schedule);
            writer.WriteEnumValue<TeamSpecialization>("specialization", Specialization);
            writer.WriteObjectValue<TeamSummary>("summary", Summary);
            writer.WriteCollectionOfObjectValues<TeamworkTag>("tags", Tags);
            writer.WriteObjectValue<TeamsTemplate>("template", Template);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteEnumValue<TeamVisibilityType>("visibility", Visibility);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
