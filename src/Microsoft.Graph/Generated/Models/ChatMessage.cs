using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ChatMessage : Entity, IParsable {
        /// <summary>References to attached objects like files, tabs, meetings etc.</summary>
        public List<ChatMessageAttachment> Attachments {
            get { return BackingStore?.Get<List<ChatMessageAttachment>>(nameof(Attachments)); }
            set { BackingStore?.Set(nameof(Attachments), value); }
        }
        /// <summary>The body property</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>(nameof(Body)); }
            set { BackingStore?.Set(nameof(Body), value); }
        }
        /// <summary>If the message was sent in a channel, represents identity of the channel.</summary>
        public Microsoft.Graph.Beta.Models.ChannelIdentity ChannelIdentity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ChannelIdentity>(nameof(ChannelIdentity)); }
            set { BackingStore?.Set(nameof(ChannelIdentity), value); }
        }
        /// <summary>If the message was sent in a chat, represents the identity of the chat.</summary>
        public string ChatId {
            get { return BackingStore?.Get<string>(nameof(ChatId)); }
            set { BackingStore?.Set(nameof(ChatId), value); }
        }
        /// <summary>Timestamp of when the chat message was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Read only. Timestamp at which the chat message was deleted, or null if not deleted.</summary>
        public DateTimeOffset? DeletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DeletedDateTime)); }
            set { BackingStore?.Set(nameof(DeletedDateTime), value); }
        }
        /// <summary>Read-only. Version number of the chat message.</summary>
        public string Etag {
            get { return BackingStore?.Get<string>(nameof(Etag)); }
            set { BackingStore?.Set(nameof(Etag), value); }
        }
        /// <summary>Read-only.  If present, represents details of an event that happened in a chat, a channel, or a team, for example, adding new members. For event messages, the messageType property will be set to systemEventMessage.</summary>
        public EventMessageDetail EventDetail {
            get { return BackingStore?.Get<EventMessageDetail>(nameof(EventDetail)); }
            set { BackingStore?.Set(nameof(EventDetail), value); }
        }
        /// <summary>Details of the sender of the chat message. Can only be set during migration.</summary>
        public ChatMessageFromIdentitySet From {
            get { return BackingStore?.Get<ChatMessageFromIdentitySet>(nameof(From)); }
            set { BackingStore?.Set(nameof(From), value); }
        }
        /// <summary>Content in a message hosted by Microsoft Teams - for example, images or code snippets.</summary>
        public List<ChatMessageHostedContent> HostedContents {
            get { return BackingStore?.Get<List<ChatMessageHostedContent>>(nameof(HostedContents)); }
            set { BackingStore?.Set(nameof(HostedContents), value); }
        }
        /// <summary>The importance of the chat message. The possible values are: normal, high, urgent.</summary>
        public ChatMessageImportance? Importance {
            get { return BackingStore?.Get<ChatMessageImportance?>(nameof(Importance)); }
            set { BackingStore?.Set(nameof(Importance), value); }
        }
        /// <summary>Read only. Timestamp when edits to the chat message were made. Triggers an &apos;Edited&apos; flag in the Teams UI. If no edits are made the value is null.</summary>
        public DateTimeOffset? LastEditedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastEditedDateTime)); }
            set { BackingStore?.Set(nameof(LastEditedDateTime), value); }
        }
        /// <summary>Read only. Timestamp when the chat message is created (initial setting) or modified, including when a reaction is added or removed.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Locale of the chat message set by the client. Always set to en-us.</summary>
        public string Locale {
            get { return BackingStore?.Get<string>(nameof(Locale)); }
            set { BackingStore?.Set(nameof(Locale), value); }
        }
        /// <summary>List of entities mentioned in the chat message. Supported entities are: user, bot, team, channel, and tag.</summary>
        public List<ChatMessageMention> Mentions {
            get { return BackingStore?.Get<List<ChatMessageMention>>(nameof(Mentions)); }
            set { BackingStore?.Set(nameof(Mentions), value); }
        }
        /// <summary>The type of chat message. The possible values are: message, chatEvent, typing, unknownFutureValue, systemEventMessage. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: systemEventMessage.</summary>
        public ChatMessageType? MessageType {
            get { return BackingStore?.Get<ChatMessageType?>(nameof(MessageType)); }
            set { BackingStore?.Set(nameof(MessageType), value); }
        }
        /// <summary>User attribution of the message when bot sends a message on behalf of a user.</summary>
        public ChatMessageFromIdentitySet OnBehalfOf {
            get { return BackingStore?.Get<ChatMessageFromIdentitySet>(nameof(OnBehalfOf)); }
            set { BackingStore?.Set(nameof(OnBehalfOf), value); }
        }
        /// <summary>Defines the properties of a policy violation set by a data loss prevention (DLP) application.</summary>
        public ChatMessagePolicyViolation PolicyViolation {
            get { return BackingStore?.Get<ChatMessagePolicyViolation>(nameof(PolicyViolation)); }
            set { BackingStore?.Set(nameof(PolicyViolation), value); }
        }
        /// <summary>Reactions for this chat message (for example, Like).</summary>
        public List<ChatMessageReaction> Reactions {
            get { return BackingStore?.Get<List<ChatMessageReaction>>(nameof(Reactions)); }
            set { BackingStore?.Set(nameof(Reactions), value); }
        }
        /// <summary>Replies for a specified message. Supports $expand for channel messages.</summary>
        public List<ChatMessage> Replies {
            get { return BackingStore?.Get<List<ChatMessage>>(nameof(Replies)); }
            set { BackingStore?.Set(nameof(Replies), value); }
        }
        /// <summary>Read-only. ID of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels, not chats.)</summary>
        public string ReplyToId {
            get { return BackingStore?.Get<string>(nameof(ReplyToId)); }
            set { BackingStore?.Set(nameof(ReplyToId), value); }
        }
        /// <summary>The subject of the chat message, in plaintext.</summary>
        public string Subject {
            get { return BackingStore?.Get<string>(nameof(Subject)); }
            set { BackingStore?.Set(nameof(Subject), value); }
        }
        /// <summary>Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.</summary>
        public string Summary {
            get { return BackingStore?.Get<string>(nameof(Summary)); }
            set { BackingStore?.Set(nameof(Summary), value); }
        }
        /// <summary>Read-only. Link to the message in Microsoft Teams.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>(nameof(WebUrl)); }
            set { BackingStore?.Set(nameof(WebUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChatMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<ChatMessageAttachment>(ChatMessageAttachment.CreateFromDiscriminatorValue).ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"channelIdentity", n => { ChannelIdentity = n.GetObjectValue<Microsoft.Graph.Beta.Models.ChannelIdentity>(Microsoft.Graph.Beta.Models.ChannelIdentity.CreateFromDiscriminatorValue); } },
                {"chatId", n => { ChatId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"etag", n => { Etag = n.GetStringValue(); } },
                {"eventDetail", n => { EventDetail = n.GetObjectValue<EventMessageDetail>(EventMessageDetail.CreateFromDiscriminatorValue); } },
                {"from", n => { From = n.GetObjectValue<ChatMessageFromIdentitySet>(ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                {"hostedContents", n => { HostedContents = n.GetCollectionOfObjectValues<ChatMessageHostedContent>(ChatMessageHostedContent.CreateFromDiscriminatorValue).ToList(); } },
                {"importance", n => { Importance = n.GetEnumValue<ChatMessageImportance>(); } },
                {"lastEditedDateTime", n => { LastEditedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"locale", n => { Locale = n.GetStringValue(); } },
                {"mentions", n => { Mentions = n.GetCollectionOfObjectValues<ChatMessageMention>(ChatMessageMention.CreateFromDiscriminatorValue).ToList(); } },
                {"messageType", n => { MessageType = n.GetEnumValue<ChatMessageType>(); } },
                {"onBehalfOf", n => { OnBehalfOf = n.GetObjectValue<ChatMessageFromIdentitySet>(ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                {"policyViolation", n => { PolicyViolation = n.GetObjectValue<ChatMessagePolicyViolation>(ChatMessagePolicyViolation.CreateFromDiscriminatorValue); } },
                {"reactions", n => { Reactions = n.GetCollectionOfObjectValues<ChatMessageReaction>(ChatMessageReaction.CreateFromDiscriminatorValue).ToList(); } },
                {"replies", n => { Replies = n.GetCollectionOfObjectValues<ChatMessage>(ChatMessage.CreateFromDiscriminatorValue).ToList(); } },
                {"replyToId", n => { ReplyToId = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<ChatMessageAttachment>("attachments", Attachments);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ChannelIdentity>("channelIdentity", ChannelIdentity);
            writer.WriteStringValue("chatId", ChatId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("etag", Etag);
            writer.WriteObjectValue<EventMessageDetail>("eventDetail", EventDetail);
            writer.WriteObjectValue<ChatMessageFromIdentitySet>("from", From);
            writer.WriteCollectionOfObjectValues<ChatMessageHostedContent>("hostedContents", HostedContents);
            writer.WriteEnumValue<ChatMessageImportance>("importance", Importance);
            writer.WriteDateTimeOffsetValue("lastEditedDateTime", LastEditedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("locale", Locale);
            writer.WriteCollectionOfObjectValues<ChatMessageMention>("mentions", Mentions);
            writer.WriteEnumValue<ChatMessageType>("messageType", MessageType);
            writer.WriteObjectValue<ChatMessageFromIdentitySet>("onBehalfOf", OnBehalfOf);
            writer.WriteObjectValue<ChatMessagePolicyViolation>("policyViolation", PolicyViolation);
            writer.WriteCollectionOfObjectValues<ChatMessageReaction>("reactions", Reactions);
            writer.WriteCollectionOfObjectValues<ChatMessage>("replies", Replies);
            writer.WriteStringValue("replyToId", ReplyToId);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("summary", Summary);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
