using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MessageTrace : Entity, IParsable {
        public string DestinationIPAddress { get; set; }
        public string MessageId { get; set; }
        public DateTimeOffset? ReceivedDateTime { get; set; }
        public List<MessageRecipient> Recipients { get; set; }
        public string SenderEmail { get; set; }
        public int? Size { get; set; }
        public string SourceIPAddress { get; set; }
        public string Subject { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MessageTrace CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageTrace();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"destinationIPAddress", (o,n) => { (o as MessageTrace).DestinationIPAddress = n.GetStringValue(); } },
                {"messageId", (o,n) => { (o as MessageTrace).MessageId = n.GetStringValue(); } },
                {"receivedDateTime", (o,n) => { (o as MessageTrace).ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipients", (o,n) => { (o as MessageTrace).Recipients = n.GetCollectionOfObjectValues<MessageRecipient>(MessageRecipient.CreateFromDiscriminatorValue).ToList(); } },
                {"senderEmail", (o,n) => { (o as MessageTrace).SenderEmail = n.GetStringValue(); } },
                {"size", (o,n) => { (o as MessageTrace).Size = n.GetIntValue(); } },
                {"sourceIPAddress", (o,n) => { (o as MessageTrace).SourceIPAddress = n.GetStringValue(); } },
                {"subject", (o,n) => { (o as MessageTrace).Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("destinationIPAddress", DestinationIPAddress);
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteCollectionOfObjectValues<MessageRecipient>("recipients", Recipients);
            writer.WriteStringValue("senderEmail", SenderEmail);
            writer.WriteIntValue("size", Size);
            writer.WriteStringValue("sourceIPAddress", SourceIPAddress);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
