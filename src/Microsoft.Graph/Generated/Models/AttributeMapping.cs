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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Default value to be used in case the source property was evaluated to null. Optional.</summary>
        public string DefaultValue {
            get { return BackingStore?.Get<string>(nameof(DefaultValue)); }
            set { BackingStore?.Set(nameof(DefaultValue), value); }
        }
        /// <summary>For internal use only.</summary>
        public bool? ExportMissingReferences {
            get { return BackingStore?.Get<bool?>(nameof(ExportMissingReferences)); }
            set { BackingStore?.Set(nameof(ExportMissingReferences), value); }
        }
        /// <summary>Defines when this attribute should be exported to the target directory. Possible values are: FlowWhenChanged and FlowAlways. Default is FlowWhenChanged.</summary>
        public AttributeFlowBehavior? FlowBehavior {
            get { return BackingStore?.Get<AttributeFlowBehavior?>(nameof(FlowBehavior)); }
            set { BackingStore?.Set(nameof(FlowBehavior), value); }
        }
        /// <summary>Defines when this attribute should be updated in the target directory. Possible values are: Always (default), ObjectAddOnly (only when new object is created), MultiValueAddOnly (only when the change is adding new values to a multi-valued attribute).</summary>
        public AttributeFlowType? FlowType {
            get { return BackingStore?.Get<AttributeFlowType?>(nameof(FlowType)); }
            set { BackingStore?.Set(nameof(FlowType), value); }
        }
        /// <summary>If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.</summary>
        public int? MatchingPriority {
            get { return BackingStore?.Get<int?>(nameof(MatchingPriority)); }
            set { BackingStore?.Set(nameof(MatchingPriority), value); }
        }
        /// <summary>Defines how a value should be extracted (or transformed) from the source object.</summary>
        public AttributeMappingSource Source {
            get { return BackingStore?.Get<AttributeMappingSource>(nameof(Source)); }
            set { BackingStore?.Set(nameof(Source), value); }
        }
        /// <summary>Name of the attribute on the target object.</summary>
        public string TargetAttributeName {
            get { return BackingStore?.Get<string>(nameof(TargetAttributeName)); }
            set { BackingStore?.Set(nameof(TargetAttributeName), value); }
        }
        /// <summary>
        /// Instantiates a new attributeMapping and sets the default values.
        /// </summary>
        public AttributeMapping() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
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
            writer.WriteObjectValue<AttributeMappingSource>("source", Source);
            writer.WriteStringValue("targetAttributeName", TargetAttributeName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
