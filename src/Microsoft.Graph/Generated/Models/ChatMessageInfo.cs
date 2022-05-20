using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of chat entities.</summary>
    public class ChatMessageInfo : Entity, IParsable {
        /// <summary>Body of the chatMessage. This will still contain markers for @mentions and attachments even though the object does not return @mentions and attachments.</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>(nameof(Body)); }
            set { BackingStore?.Set(nameof(Body), value); }
        }
        /// <summary>Date time object representing the time at which message was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Read-only.  If present, represents details of an event that happened in a chat, a channel, or a team, for example, members were added, and so on. For event messages, the messageType property will be set to systemEventMessage.</summary>
        public EventMessageDetail EventDetail {
            get { return BackingStore?.Get<EventMessageDetail>(nameof(EventDetail)); }
            set { BackingStore?.Set(nameof(EventDetail), value); }
        }
        /// <summary>Information about the sender of the message.</summary>
        public ChatMessageFromIdentitySet From {
            get { return BackingStore?.Get<ChatMessageFromIdentitySet>(nameof(From)); }
            set { BackingStore?.Set(nameof(From), value); }
        }
        /// <summary>If set to true, the original message has been deleted.</summary>
        public bool? IsDeleted {
            get { return BackingStore?.Get<bool?>(nameof(IsDeleted)); }
            set { BackingStore?.Set(nameof(IsDeleted), value); }
        }
        /// <summary>The type of chat message. The possible values are: message, unknownFutureValue, systemEventMessage.</summary>
        public ChatMessageType? MessageType {
            get { return BackingStore?.Get<ChatMessageType?>(nameof(MessageType)); }
            set { BackingStore?.Set(nameof(MessageType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChatMessageInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessageInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventDetail", n => { EventDetail = n.GetObjectValue<EventMessageDetail>(EventMessageDetail.CreateFromDiscriminatorValue); } },
                {"from", n => { From = n.GetObjectValue<ChatMessageFromIdentitySet>(ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                {"isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                {"messageType", n => { MessageType = n.GetEnumValue<ChatMessageType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<EventMessageDetail>("eventDetail", EventDetail);
            writer.WriteObjectValue<ChatMessageFromIdentitySet>("from", From);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteEnumValue<ChatMessageType>("messageType", MessageType);
        }
    }
}
