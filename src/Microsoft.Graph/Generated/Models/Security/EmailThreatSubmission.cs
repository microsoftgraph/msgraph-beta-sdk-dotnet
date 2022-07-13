using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EmailThreatSubmission : ThreatSubmission, IParsable {
        /// <summary>The attackSimulationInfo property</summary>
        public Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo AttackSimulationInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo>("attackSimulationInfo"); }
            set { BackingStore?.Set("attackSimulationInfo", value); }
        }
        /// <summary>The internetMessageId property</summary>
        public string InternetMessageId {
            get { return BackingStore?.Get<string>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
        /// <summary>The originalCategory property</summary>
        public SubmissionCategory? OriginalCategory {
            get { return BackingStore?.Get<SubmissionCategory?>("originalCategory"); }
            set { BackingStore?.Set("originalCategory", value); }
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
        /// <summary>The sender property</summary>
        public string Sender {
            get { return BackingStore?.Get<string>("sender"); }
            set { BackingStore?.Set("sender", value); }
        }
        /// <summary>The senderIP property</summary>
        public string SenderIP {
            get { return BackingStore?.Get<string>("senderIP"); }
            set { BackingStore?.Set("senderIP", value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
        /// <summary>The tenantAllowOrBlockListAction property</summary>
        public Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction TenantAllowOrBlockListAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction>("tenantAllowOrBlockListAction"); }
            set { BackingStore?.Set("tenantAllowOrBlockListAction", value); }
        }
        /// <summary>
        /// Instantiates a new EmailThreatSubmission and sets the default values.
        /// </summary>
        public EmailThreatSubmission() : base() {
            Type = "#microsoft.graph.security.emailThreatSubmission";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EmailThreatSubmission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.emailContentThreatSubmission" => new EmailContentThreatSubmission(),
                "#microsoft.graph.security.emailUrlThreatSubmission" => new EmailUrlThreatSubmission(),
                _ => new EmailThreatSubmission(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attackSimulationInfo", n => { AttackSimulationInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo>(Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo.CreateFromDiscriminatorValue); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"originalCategory", n => { OriginalCategory = n.GetEnumValue<SubmissionCategory>(); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipientEmailAddress", n => { RecipientEmailAddress = n.GetStringValue(); } },
                {"sender", n => { Sender = n.GetStringValue(); } },
                {"senderIP", n => { SenderIP = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"tenantAllowOrBlockListAction", n => { TenantAllowOrBlockListAction = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction>(Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo>("attackSimulationInfo", AttackSimulationInfo);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteEnumValue<SubmissionCategory>("originalCategory", OriginalCategory);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteStringValue("recipientEmailAddress", RecipientEmailAddress);
            writer.WriteStringValue("sender", Sender);
            writer.WriteStringValue("senderIP", SenderIP);
            writer.WriteStringValue("subject", Subject);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction>("tenantAllowOrBlockListAction", TenantAllowOrBlockListAction);
        }
    }
}
