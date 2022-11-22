using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class MessageRecipient : Entity, IParsable {
        /// <summary>The deliveryStatus property</summary>
        public MessageStatus? DeliveryStatus {
            get { return BackingStore?.Get<MessageStatus?>("deliveryStatus"); }
            set { BackingStore?.Set("deliveryStatus", value); }
        }
        /// <summary>The events property</summary>
        public List<MessageEvent> Events {
            get { return BackingStore?.Get<List<MessageEvent>>("events"); }
            set { BackingStore?.Set("events", value); }
        }
        /// <summary>The recipientEmail property</summary>
        public string RecipientEmail {
            get { return BackingStore?.Get<string>("recipientEmail"); }
            set { BackingStore?.Set("recipientEmail", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MessageRecipient CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageRecipient();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deliveryStatus", n => { DeliveryStatus = n.GetEnumValue<MessageStatus>(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<MessageEvent>(MessageEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"recipientEmail", n => { RecipientEmail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MessageStatus>("deliveryStatus", DeliveryStatus);
            writer.WriteCollectionOfObjectValues<MessageEvent>("events", Events);
            writer.WriteStringValue("recipientEmail", RecipientEmail);
        }
    }
}
