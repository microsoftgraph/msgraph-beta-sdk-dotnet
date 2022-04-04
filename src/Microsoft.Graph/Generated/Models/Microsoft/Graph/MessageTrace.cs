using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MessageTrace : Entity, IParsable {
        /// <summary>The destinationIPAddress property</summary>
        public string DestinationIPAddress { get; set; }
        /// <summary>The messageId property</summary>
        public string MessageId { get; set; }
        /// <summary>The receivedDateTime property</summary>
        public DateTimeOffset? ReceivedDateTime { get; set; }
        /// <summary>The recipients property</summary>
        public List<MessageRecipient> Recipients { get; set; }
        /// <summary>The senderEmail property</summary>
        public string SenderEmail { get; set; }
        /// <summary>The size property</summary>
        public int? Size { get; set; }
        /// <summary>The sourceIPAddress property</summary>
        public string SourceIPAddress { get; set; }
        /// <summary>The subject property</summary>
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
