using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AnalyzedMessageEvidence : AlertEvidence, IParsable {
        /// <summary>The antiSpamDirection property</summary>
        public string AntiSpamDirection {
            get { return BackingStore?.Get<string>("antiSpamDirection"); }
            set { BackingStore?.Set("antiSpamDirection", value); }
        }
        /// <summary>The attachmentsCount property</summary>
        public long? AttachmentsCount {
            get { return BackingStore?.Get<long?>("attachmentsCount"); }
            set { BackingStore?.Set("attachmentsCount", value); }
        }
        /// <summary>The deliveryAction property</summary>
        public string DeliveryAction {
            get { return BackingStore?.Get<string>("deliveryAction"); }
            set { BackingStore?.Set("deliveryAction", value); }
        }
        /// <summary>The deliveryLocation property</summary>
        public string DeliveryLocation {
            get { return BackingStore?.Get<string>("deliveryLocation"); }
            set { BackingStore?.Set("deliveryLocation", value); }
        }
        /// <summary>The internetMessageId property</summary>
        public string InternetMessageId {
            get { return BackingStore?.Get<string>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
        /// <summary>The language property</summary>
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
        /// <summary>The networkMessageId property</summary>
        public string NetworkMessageId {
            get { return BackingStore?.Get<string>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
        }
        /// <summary>The p1Sender property</summary>
        public EmailSender P1Sender {
            get { return BackingStore?.Get<EmailSender>("p1Sender"); }
            set { BackingStore?.Set("p1Sender", value); }
        }
        /// <summary>The p2Sender property</summary>
        public EmailSender P2Sender {
            get { return BackingStore?.Get<EmailSender>("p2Sender"); }
            set { BackingStore?.Set("p2Sender", value); }
        }
        /// <summary>The receivedDateTime property</summary>
        public DateTimeOffset? ReceivedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTime"); }
            set { BackingStore?.Set("receivedDateTime", value); }
        }
        /// <summary>The recipientEmailAddress property</summary>
        public string RecipientEmailAddress {
            get { return BackingStore?.Get<string>("recipientEmailAddress"); }
            set { BackingStore?.Set("recipientEmailAddress", value); }
        }
        /// <summary>The senderIp property</summary>
        public string SenderIp {
            get { return BackingStore?.Get<string>("senderIp"); }
            set { BackingStore?.Set("senderIp", value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
        /// <summary>The threatDetectionMethods property</summary>
        public List<string> ThreatDetectionMethods {
            get { return BackingStore?.Get<List<string>>("threatDetectionMethods"); }
            set { BackingStore?.Set("threatDetectionMethods", value); }
        }
        /// <summary>The threats property</summary>
        public List<string> Threats {
            get { return BackingStore?.Get<List<string>>("threats"); }
            set { BackingStore?.Set("threats", value); }
        }
        /// <summary>The urlCount property</summary>
        public long? UrlCount {
            get { return BackingStore?.Get<long?>("urlCount"); }
            set { BackingStore?.Set("urlCount", value); }
        }
        /// <summary>The urls property</summary>
        public List<string> Urls {
            get { return BackingStore?.Get<List<string>>("urls"); }
            set { BackingStore?.Set("urls", value); }
        }
        /// <summary>The urn property</summary>
        public string Urn {
            get { return BackingStore?.Get<string>("urn"); }
            set { BackingStore?.Set("urn", value); }
        }
        /// <summary>
        /// Instantiates a new AnalyzedMessageEvidence and sets the default values.
        /// </summary>
        public AnalyzedMessageEvidence() : base() {
            OdataType = "#microsoft.graph.security.analyzedMessageEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AnalyzedMessageEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnalyzedMessageEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"antiSpamDirection", n => { AntiSpamDirection = n.GetStringValue(); } },
                {"attachmentsCount", n => { AttachmentsCount = n.GetLongValue(); } },
                {"deliveryAction", n => { DeliveryAction = n.GetStringValue(); } },
                {"deliveryLocation", n => { DeliveryLocation = n.GetStringValue(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"networkMessageId", n => { NetworkMessageId = n.GetStringValue(); } },
                {"p1Sender", n => { P1Sender = n.GetObjectValue<EmailSender>(EmailSender.CreateFromDiscriminatorValue); } },
                {"p2Sender", n => { P2Sender = n.GetObjectValue<EmailSender>(EmailSender.CreateFromDiscriminatorValue); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipientEmailAddress", n => { RecipientEmailAddress = n.GetStringValue(); } },
                {"senderIp", n => { SenderIp = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"threatDetectionMethods", n => { ThreatDetectionMethods = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"threats", n => { Threats = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"urlCount", n => { UrlCount = n.GetLongValue(); } },
                {"urls", n => { Urls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("antiSpamDirection", AntiSpamDirection);
            writer.WriteLongValue("attachmentsCount", AttachmentsCount);
            writer.WriteStringValue("deliveryAction", DeliveryAction);
            writer.WriteStringValue("deliveryLocation", DeliveryLocation);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("networkMessageId", NetworkMessageId);
            writer.WriteObjectValue<EmailSender>("p1Sender", P1Sender);
            writer.WriteObjectValue<EmailSender>("p2Sender", P2Sender);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteStringValue("recipientEmailAddress", RecipientEmailAddress);
            writer.WriteStringValue("senderIp", SenderIp);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfPrimitiveValues<string>("threatDetectionMethods", ThreatDetectionMethods);
            writer.WriteCollectionOfPrimitiveValues<string>("threats", Threats);
            writer.WriteLongValue("urlCount", UrlCount);
            writer.WriteCollectionOfPrimitiveValues<string>("urls", Urls);
            writer.WriteStringValue("urn", Urn);
        }
    }
}
