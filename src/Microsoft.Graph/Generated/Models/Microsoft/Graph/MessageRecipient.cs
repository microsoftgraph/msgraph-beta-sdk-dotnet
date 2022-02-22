using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class MessageRecipient : Entity, IParsable {
        public MessageStatus? DeliveryStatus { get; set; }
        public List<MessageEvent> Events { get; set; }
        public string RecipientEmail { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deliveryStatus", (o,n) => { (o as MessageRecipient).DeliveryStatus = n.GetEnumValue<MessageStatus>(); } },
                {"events", (o,n) => { (o as MessageRecipient).Events = n.GetCollectionOfObjectValues<MessageEvent>().ToList(); } },
                {"recipientEmail", (o,n) => { (o as MessageRecipient).RecipientEmail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MessageStatus>("deliveryStatus", DeliveryStatus);
            writer.WriteCollectionOfObjectValues<MessageEvent>("events", Events);
            writer.WriteStringValue("recipientEmail", RecipientEmail);
        }
    }
}
