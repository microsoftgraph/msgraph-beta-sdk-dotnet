using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BusinessFlow : Entity, IParsable {
        /// <summary>The customData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? CustomData {
            get { return BackingStore?.Get<string?>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#else
        public string CustomData {
            get { return BackingStore?.Get<string>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#endif
        /// <summary>The deDuplicationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DeDuplicationId {
            get { return BackingStore?.Get<string?>("deDuplicationId"); }
            set { BackingStore?.Set("deDuplicationId", value); }
        }
#else
        public string DeDuplicationId {
            get { return BackingStore?.Get<string>("deDuplicationId"); }
            set { BackingStore?.Set("deDuplicationId", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The policy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public GovernancePolicy? Policy {
            get { return BackingStore?.Get<GovernancePolicy?>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#else
        public GovernancePolicy Policy {
            get { return BackingStore?.Get<GovernancePolicy>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#endif
        /// <summary>The policyTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? PolicyTemplateId {
            get { return BackingStore?.Get<string?>("policyTemplateId"); }
            set { BackingStore?.Set("policyTemplateId", value); }
        }
#else
        public string PolicyTemplateId {
            get { return BackingStore?.Get<string>("policyTemplateId"); }
            set { BackingStore?.Set("policyTemplateId", value); }
        }
#endif
        /// <summary>The recordVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? RecordVersion {
            get { return BackingStore?.Get<string?>("recordVersion"); }
            set { BackingStore?.Set("recordVersion", value); }
        }
#else
        public string RecordVersion {
            get { return BackingStore?.Get<string>("recordVersion"); }
            set { BackingStore?.Set("recordVersion", value); }
        }
#endif
        /// <summary>The schemaId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SchemaId {
            get { return BackingStore?.Get<string?>("schemaId"); }
            set { BackingStore?.Set("schemaId", value); }
        }
#else
        public string SchemaId {
            get { return BackingStore?.Get<string>("schemaId"); }
            set { BackingStore?.Set("schemaId", value); }
        }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public BusinessFlowSettings? Settings {
            get { return BackingStore?.Get<BusinessFlowSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#else
        public BusinessFlowSettings Settings {
            get { return BackingStore?.Get<BusinessFlowSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
