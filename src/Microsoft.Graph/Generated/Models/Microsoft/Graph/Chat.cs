using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Chat : Entity, IParsable {
        /// <summary>Specifies the type of chat. Possible values are: group, oneOnOne, meeting, unknownFutureValue.</summary>
        public ChatType? ChatType { get; set; }
        /// <summary>Date and time at which the chat was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A collection of all the apps in the chat. Nullable.</summary>
        public List<TeamsAppInstallation> InstalledApps { get; set; }
        /// <summary>Preview of the last message sent in the chat. Null if no messages have been sent in the chat. Currently, only the list chats operation supports this property.</summary>
        public ChatMessageInfo LastMessagePreview { get; set; }
        /// <summary>Date and time at which the chat was renamed or list of members were last changed. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>A collection of all the members in the chat. Nullable.</summary>
        public List<ConversationMember> Members { get; set; }
        /// <summary>A collection of all the messages in the chat. Nullable.</summary>
        public List<ChatMessage> Messages { get; set; }
        /// <summary>Represents details about an online meeting. If the chat isn't associated with an online meeting, the property is empty. Read-only.</summary>
        public TeamworkOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        /// <summary>A collection of all the Teams async operations that ran or are running on the chat. Nullable.</summary>
        public List<TeamsAsyncOperation> Operations { get; set; }
        /// <summary>A collection of permissions granted to apps for the chat.</summary>
        public List<ResourceSpecificPermissionGrant> PermissionGrants { get; set; }
        /// <summary>A collection of all the tabs in the chat. Nullable.</summary>
        public List<TeamsTab> Tabs { get; set; }
        /// <summary>The identifier of the tenant in which the chat was created. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>(Optional) Subject or topic for the chat. Only available for group chats.</summary>
        public string Topic { get; set; }
        /// <summary>Represents caller-specific information about the chat, such as last message read date and time. This property is populated only when the request is made in a delegated context.</summary>
        public ChatViewpoint Viewpoint { get; set; }
        /// <summary>The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"chatType", (o,n) => { (o as Chat).ChatType = n.GetEnumValue<ChatType>(); } },
                {"createdDateTime", (o,n) => { (o as Chat).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"installedApps", (o,n) => { (o as Chat).InstalledApps = n.GetCollectionOfObjectValues<TeamsAppInstallation>().ToList(); } },
                {"lastMessagePreview", (o,n) => { (o as Chat).LastMessagePreview = n.GetObjectValue<ChatMessageInfo>(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as Chat).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"members", (o,n) => { (o as Chat).Members = n.GetCollectionOfObjectValues<ConversationMember>().ToList(); } },
                {"messages", (o,n) => { (o as Chat).Messages = n.GetCollectionOfObjectValues<ChatMessage>().ToList(); } },
                {"onlineMeetingInfo", (o,n) => { (o as Chat).OnlineMeetingInfo = n.GetObjectValue<TeamworkOnlineMeetingInfo>(); } },
                {"operations", (o,n) => { (o as Chat).Operations = n.GetCollectionOfObjectValues<TeamsAsyncOperation>().ToList(); } },
                {"permissionGrants", (o,n) => { (o as Chat).PermissionGrants = n.GetCollectionOfObjectValues<ResourceSpecificPermissionGrant>().ToList(); } },
                {"tabs", (o,n) => { (o as Chat).Tabs = n.GetCollectionOfObjectValues<TeamsTab>().ToList(); } },
                {"tenantId", (o,n) => { (o as Chat).TenantId = n.GetStringValue(); } },
                {"topic", (o,n) => { (o as Chat).Topic = n.GetStringValue(); } },
                {"viewpoint", (o,n) => { (o as Chat).Viewpoint = n.GetObjectValue<ChatViewpoint>(); } },
                {"webUrl", (o,n) => { (o as Chat).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ChatType>("chatType", ChatType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteObjectValue<ChatMessageInfo>("lastMessagePreview", LastMessagePreview);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteCollectionOfObjectValues<ChatMessage>("messages", Messages);
            writer.WriteObjectValue<TeamworkOnlineMeetingInfo>("onlineMeetingInfo", OnlineMeetingInfo);
            writer.WriteCollectionOfObjectValues<TeamsAsyncOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteCollectionOfObjectValues<TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topic", Topic);
            writer.WriteObjectValue<ChatViewpoint>("viewpoint", Viewpoint);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
