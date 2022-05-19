using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of approvalWorkflowProvider entities.</summary>
    public class BusinessFlow : Entity, IParsable {
        /// <summary>The customData property</summary>
        public string CustomData {
            get { return BackingStore?.Get<string>(nameof(CustomData)); }
            set { BackingStore?.Set(nameof(CustomData), value); }
        }
        /// <summary>The deDuplicationId property</summary>
        public string DeDuplicationId {
            get { return BackingStore?.Get<string>(nameof(DeDuplicationId)); }
            set { BackingStore?.Set(nameof(DeDuplicationId), value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The policy property</summary>
        public GovernancePolicy Policy {
            get { return BackingStore?.Get<GovernancePolicy>(nameof(Policy)); }
            set { BackingStore?.Set(nameof(Policy), value); }
        }
        /// <summary>The policyTemplateId property</summary>
        public string PolicyTemplateId {
            get { return BackingStore?.Get<string>(nameof(PolicyTemplateId)); }
            set { BackingStore?.Set(nameof(PolicyTemplateId), value); }
        }
        /// <summary>The recordVersion property</summary>
        public string RecordVersion {
            get { return BackingStore?.Get<string>(nameof(RecordVersion)); }
            set { BackingStore?.Set(nameof(RecordVersion), value); }
        }
        /// <summary>The schemaId property</summary>
        public string SchemaId {
            get { return BackingStore?.Get<string>(nameof(SchemaId)); }
            set { BackingStore?.Set(nameof(SchemaId), value); }
        }
        /// <summary>The settings property</summary>
        public BusinessFlowSettings Settings {
            get { return BackingStore?.Get<BusinessFlowSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customData", n => { CustomData = n.GetStringValue(); } },
                {"deDuplicationId", n => { DeDuplicationId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"policy", n => { Policy = n.GetObjectValue<GovernancePolicy>(GovernancePolicy.CreateFromDiscriminatorValue); } },
                {"policyTemplateId", n => { PolicyTemplateId = n.GetStringValue(); } },
                {"recordVersion", n => { RecordVersion = n.GetStringValue(); } },
                {"schemaId", n => { SchemaId = n.GetStringValue(); } },
                {"settings", n => { Settings = n.GetObjectValue<BusinessFlowSettings>(BusinessFlowSettings.CreateFromDiscriminatorValue); } },
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
