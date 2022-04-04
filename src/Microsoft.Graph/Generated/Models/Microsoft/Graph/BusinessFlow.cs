using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class BusinessFlow : Entity, IParsable {
        /// <summary>The customData property</summary>
        public string CustomData { get; set; }
        /// <summary>The deDuplicationId property</summary>
        public string DeDuplicationId { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The policy property</summary>
        public GovernancePolicy Policy { get; set; }
        /// <summary>The policyTemplateId property</summary>
        public string PolicyTemplateId { get; set; }
        /// <summary>The recordVersion property</summary>
        public string RecordVersion { get; set; }
        /// <summary>The schemaId property</summary>
        public string SchemaId { get; set; }
        /// <summary>The settings property</summary>
        public BusinessFlowSettings Settings { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BusinessFlow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BusinessFlow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"customData", (o,n) => { (o as BusinessFlow).CustomData = n.GetStringValue(); } },
                {"deDuplicationId", (o,n) => { (o as BusinessFlow).DeDuplicationId = n.GetStringValue(); } },
                {"description", (o,n) => { (o as BusinessFlow).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as BusinessFlow).DisplayName = n.GetStringValue(); } },
                {"policy", (o,n) => { (o as BusinessFlow).Policy = n.GetObjectValue<GovernancePolicy>(GovernancePolicy.CreateFromDiscriminatorValue); } },
                {"policyTemplateId", (o,n) => { (o as BusinessFlow).PolicyTemplateId = n.GetStringValue(); } },
                {"recordVersion", (o,n) => { (o as BusinessFlow).RecordVersion = n.GetStringValue(); } },
                {"schemaId", (o,n) => { (o as BusinessFlow).SchemaId = n.GetStringValue(); } },
                {"settings", (o,n) => { (o as BusinessFlow).Settings = n.GetObjectValue<BusinessFlowSettings>(BusinessFlowSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("customData", CustomData);
            writer.WriteStringValue("deDuplicationId", DeDuplicationId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<GovernancePolicy>("policy", Policy);
            writer.WriteStringValue("policyTemplateId", PolicyTemplateId);
            writer.WriteStringValue("recordVersion", RecordVersion);
            writer.WriteStringValue("schemaId", SchemaId);
            writer.WriteObjectValue<BusinessFlowSettings>("settings", Settings);
        }
    }
}
