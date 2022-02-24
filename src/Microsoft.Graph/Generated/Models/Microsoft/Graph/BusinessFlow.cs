using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class BusinessFlow : Entity, IParsable {
        public string CustomData { get; set; }
        public string DeDuplicationId { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public GovernancePolicy Policy { get; set; }
        public string PolicyTemplateId { get; set; }
        public string RecordVersion { get; set; }
        public string SchemaId { get; set; }
        public BusinessFlowSettings Settings { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"customData", (o,n) => { (o as BusinessFlow).CustomData = n.GetStringValue(); } },
                {"deDuplicationId", (o,n) => { (o as BusinessFlow).DeDuplicationId = n.GetStringValue(); } },
                {"description", (o,n) => { (o as BusinessFlow).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as BusinessFlow).DisplayName = n.GetStringValue(); } },
                {"policy", (o,n) => { (o as BusinessFlow).Policy = n.GetObjectValue<GovernancePolicy>(); } },
                {"policyTemplateId", (o,n) => { (o as BusinessFlow).PolicyTemplateId = n.GetStringValue(); } },
                {"recordVersion", (o,n) => { (o as BusinessFlow).RecordVersion = n.GetStringValue(); } },
                {"schemaId", (o,n) => { (o as BusinessFlow).SchemaId = n.GetStringValue(); } },
                {"settings", (o,n) => { (o as BusinessFlow).Settings = n.GetObjectValue<BusinessFlowSettings>(); } },
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
