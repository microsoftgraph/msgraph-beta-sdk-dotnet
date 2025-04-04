// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Channel : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of membership records associated with the channel. It includes both direct and indirect members of shared channels.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ConversationMember>? AllMembers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ConversationMember>?>("allMembers"); }
            set { BackingStore?.Set("allMembers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ConversationMember> AllMembers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ConversationMember>>("allMembers"); }
            set { BackingStore?.Set("allMembers", value); }
        }
#endif
        /// <summary>Read only. Timestamp at which the channel was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Optional textual description for the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Channel name as it appears to the user in Microsoft Teams. The maximum length is 50 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The email address for sending messages to the channel. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email
        {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email
        {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>Metadata for the location where the channel&apos;s files are stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DriveItem? FilesFolder
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DriveItem?>("filesFolder"); }
            set { BackingStore?.Set("filesFolder", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DriveItem FilesFolder
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DriveItem>("filesFolder"); }
            set { BackingStore?.Set("filesFolder", value); }
        }
#endif
        /// <summary>Indicates whether the channel is archived. Read-only.</summary>
        public bool? IsArchived
        {
            get { return BackingStore?.Get<bool?>("isArchived"); }
            set { BackingStore?.Set("isArchived", value); }
        }
        /// <summary>Indicates whether the channel should be marked as recommended for all members of the team to show in their channel list. Note: All recommended channels automatically show in the channels list for education and frontline worker users. The property can only be set programmatically via the Create team method. The default value is false.</summary>
        public bool? IsFavoriteByDefault
        {
            get { return BackingStore?.Get<bool?>("isFavoriteByDefault"); }
            set { BackingStore?.Set("isFavoriteByDefault", value); }
        }
        /// <summary>The layoutType property</summary>
        public global::Microsoft.Graph.Beta.Models.ChannelLayoutType? LayoutType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChannelLayoutType?>("layoutType"); }
            set { BackingStore?.Set("layoutType", value); }
        }
        /// <summary>A collection of membership records associated with the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ConversationMember>? Members
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ConversationMember>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ConversationMember> Members
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ConversationMember>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>The type of the channel. Can be set during creation and can&apos;t be changed. The possible values are: standard, private, unknownFutureValue, shared. The default value is standard. Use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: shared.</summary>
        public global::Microsoft.Graph.Beta.Models.ChannelMembershipType? MembershipType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChannelMembershipType?>("membershipType"); }
            set { BackingStore?.Set("membershipType", value); }
        }
        /// <summary>A collection of all the messages in the channel. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ChatMessage>? Messages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ChatMessage>?>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ChatMessage> Messages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ChatMessage>>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#endif
        /// <summary>Settings to configure channel moderation to control who can start new posts and reply to posts in that channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ChannelModerationSettings? ModerationSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChannelModerationSettings?>("moderationSettings"); }
            set { BackingStore?.Set("moderationSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ChannelModerationSettings ModerationSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChannelModerationSettings>("moderationSettings"); }
            set { BackingStore?.Set("moderationSettings", value); }
        }
#endif
        /// <summary>Selective Planner services available to this channel. Currently, only shared channels are supported. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamsChannelPlanner? Planner
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamsChannelPlanner?>("planner"); }
            set { BackingStore?.Set("planner", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamsChannelPlanner Planner
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamsChannelPlanner>("planner"); }
            set { BackingStore?.Set("planner", value); }
        }
#endif
        /// <summary>A collection of teams with which a channel is shared.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SharedWithChannelTeamInfo>? SharedWithTeams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SharedWithChannelTeamInfo>?>("sharedWithTeams"); }
            set { BackingStore?.Set("sharedWithTeams", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SharedWithChannelTeamInfo> SharedWithTeams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SharedWithChannelTeamInfo>>("sharedWithTeams"); }
            set { BackingStore?.Set("sharedWithTeams", value); }
        }
#endif
        /// <summary>Contains summary information about the channel, including number of guests, members, owners, and an indicator for members from other tenants. The summary property is only returned if it appears in the $select clause of the Get channel method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ChannelSummary? Summary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChannelSummary?>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ChannelSummary Summary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChannelSummary>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#endif
        /// <summary>A collection of all the tabs in the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.TeamsTab>? Tabs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.TeamsTab>?>("tabs"); }
            set { BackingStore?.Set("tabs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.TeamsTab> Tabs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.TeamsTab>>("tabs"); }
            set { BackingStore?.Set("tabs", value); }
        }
#endif
        /// <summary>The ID of the Microsoft Entra tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>A hyperlink to the channel in Microsoft Teams. This URL is supplied when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Channel"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Channel CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Channel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allMembers", n => { AllMembers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ConversationMember>(global::Microsoft.Graph.Beta.Models.ConversationMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "filesFolder", n => { FilesFolder = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DriveItem>(global::Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "isArchived", n => { IsArchived = n.GetBoolValue(); } },
                { "isFavoriteByDefault", n => { IsFavoriteByDefault = n.GetBoolValue(); } },
                { "layoutType", n => { LayoutType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ChannelLayoutType>(); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ConversationMember>(global::Microsoft.Graph.Beta.Models.ConversationMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "membershipType", n => { MembershipType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ChannelMembershipType>(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ChatMessage>(global::Microsoft.Graph.Beta.Models.ChatMessage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "moderationSettings", n => { ModerationSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ChannelModerationSettings>(global::Microsoft.Graph.Beta.Models.ChannelModerationSettings.CreateFromDiscriminatorValue); } },
                { "planner", n => { Planner = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamsChannelPlanner>(global::Microsoft.Graph.Beta.Models.TeamsChannelPlanner.CreateFromDiscriminatorValue); } },
                { "sharedWithTeams", n => { SharedWithTeams = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SharedWithChannelTeamInfo>(global::Microsoft.Graph.Beta.Models.SharedWithChannelTeamInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "summary", n => { Summary = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ChannelSummary>(global::Microsoft.Graph.Beta.Models.ChannelSummary.CreateFromDiscriminatorValue); } },
                { "tabs", n => { Tabs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.TeamsTab>(global::Microsoft.Graph.Beta.Models.TeamsTab.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ConversationMember>("allMembers", AllMembers);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DriveItem>("filesFolder", FilesFolder);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isFavoriteByDefault", IsFavoriteByDefault);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ChannelLayoutType>("layoutType", LayoutType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ConversationMember>("members", Members);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ChannelMembershipType>("membershipType", MembershipType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ChatMessage>("messages", Messages);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ChannelModerationSettings>("moderationSettings", ModerationSettings);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamsChannelPlanner>("planner", Planner);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SharedWithChannelTeamInfo>("sharedWithTeams", SharedWithTeams);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ChannelSummary>("summary", Summary);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
