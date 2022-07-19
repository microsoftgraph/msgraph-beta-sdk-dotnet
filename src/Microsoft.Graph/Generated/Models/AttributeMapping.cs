using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AttributeMapping : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Default value to be used in case the source property was evaluated to null. Optional.</summary>
        public string DefaultValue {
            get { return BackingStore?.Get<string>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>For internal use only.</summary>
        public bool? ExportMissingReferences {
            get { return BackingStore?.Get<bool?>("exportMissingReferences"); }
            set { BackingStore?.Set("exportMissingReferences", value); }
        }
        /// <summary>The flowBehavior property</summary>
        public AttributeFlowBehavior? FlowBehavior {
            get { return BackingStore?.Get<AttributeFlowBehavior?>("flowBehavior"); }
            set { BackingStore?.Set("flowBehavior", value); }
        }
        /// <summary>The flowType property</summary>
        public AttributeFlowType? FlowType {
            get { return BackingStore?.Get<AttributeFlowType?>("flowType"); }
            set { BackingStore?.Set("flowType", value); }
        }
        /// <summary>If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.</summary>
        public int? MatchingPriority {
            get { return BackingStore?.Get<int?>("matchingPriority"); }
            set { BackingStore?.Set("matchingPriority", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Defines how a value should be extracted (or transformed) from the source object.</summary>
        public AttributeMappingSource Source {
            get { return BackingStore?.Get<AttributeMappingSource>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>Name of the attribute on the target object.</summary>
        public string TargetAttributeName {
            get { return BackingStore?.Get<string>("targetAttributeName"); }
            set { BackingStore?.Set("targetAttributeName", value); }
        }
        /// <summary>
        /// Instantiates a new attributeMapping and sets the default values.
        /// </summary>
        public AttributeMapping() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.attributeMapping";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttributeMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                {"exportMissingReferences", n => { ExportMissingReferences = n.GetBoolValue(); } },
                {"flowBehavior", n => { FlowBehavior = n.GetEnumValue<AttributeFlowBehavior>(); } },
                {"flowType", n => { FlowType = n.GetEnumValue<AttributeFlowType>(); } },
                {"matchingPriority", n => { MatchingPriority = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"source", n => { Source = n.GetObjectValue<AttributeMappingSource>(AttributeMappingSource.CreateFromDiscriminatorValue); } },
                {"targetAttributeName", n => { TargetAttributeName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteBoolValue("exportMissingReferences", ExportMissingReferences);
            writer.WriteEnumValue<AttributeFlowBehavior>("flowBehavior", FlowBehavior);
            writer.WriteEnumValue<AttributeFlowType>("flowType", FlowType);
            writer.WriteIntValue("matchingPriority", MatchingPriority);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AttributeMappingSource>("source", Source);
            writer.WriteStringValue("targetAttributeName", TargetAttributeName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
