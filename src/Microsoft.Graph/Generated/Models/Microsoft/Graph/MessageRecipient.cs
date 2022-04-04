using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MessageRecipient : Entity, IParsable {
        /// <summary>The deliveryStatus property</summary>
        public MessageStatus? DeliveryStatus { get; set; }
        /// <summary>The events property</summary>
        public List<MessageEvent> Events { get; set; }
        /// <summary>The recipientEmail property</summary>
        public string RecipientEmail { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MessageRecipient CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageRecipient();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deliveryStatus", (o,n) => { (o as MessageRecipient).DeliveryStatus = n.GetEnumValue<MessageStatus>(); } },
                {"events", (o,n) => { (o as MessageRecipient).Events = n.GetCollectionOfObjectValues<MessageEvent>(MessageEvent.CreateFromDiscriminatorValue).ToList(); } },
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
