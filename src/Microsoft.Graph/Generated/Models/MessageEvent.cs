using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MessageEvent : Entity, IParsable {
        /// <summary>The dateTime property</summary>
        public DateTimeOffset? DateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DateTime)); }
            set { BackingStore?.Set(nameof(DateTime), value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The eventType property</summary>
        public MessageEventType? EventType {
            get { return BackingStore?.Get<MessageEventType?>(nameof(EventType)); }
            set { BackingStore?.Set(nameof(EventType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MessageEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dateTime", n => { DateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"eventType", n => { EventType = n.GetEnumValue<MessageEventType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("dateTime", DateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<MessageEventType>("eventType", EventType);
        }
    }
}
