using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ChatMessageInfo : Entity, IParsable {
        /// <summary>Body of the chatMessage. This will still contain markers for @mentions and attachments even though the object does not return @mentions and attachments.</summary>
        public ItemBody Body { get; set; }
        /// <summary>Date time object representing the time at which message was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only.  If present, represents details of an event that happened in a chat, a channel, or a team, for example, members were added, and so on. For event messages, the messageType property will be set to systemEventMessage.</summary>
        public EventMessageDetail EventDetail { get; set; }
        /// <summary>Information about the sender of the message.</summary>
        public ChatMessageFromIdentitySet From { get; set; }
        /// <summary>If set to true, the original message has been deleted.</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>The type of chat message. The possible values are: message, unknownFutureValue, systemEventMessage.</summary>
        public ChatMessageType? MessageType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"body", (o,n) => { (o as ChatMessageInfo).Body = n.GetObjectValue<ItemBody>(); } },
                {"createdDateTime", (o,n) => { (o as ChatMessageInfo).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventDetail", (o,n) => { (o as ChatMessageInfo).EventDetail = n.GetObjectValue<EventMessageDetail>(); } },
                {"from", (o,n) => { (o as ChatMessageInfo).From = n.GetObjectValue<ChatMessageFromIdentitySet>(); } },
                {"isDeleted", (o,n) => { (o as ChatMessageInfo).IsDeleted = n.GetBoolValue(); } },
                {"messageType", (o,n) => { (o as ChatMessageInfo).MessageType = n.GetEnumValue<ChatMessageType>(); } },
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
