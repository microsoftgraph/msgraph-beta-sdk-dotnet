using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AttributeDefinition : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object&apos;s attributes must be designated as the anchor to support synchronization.</summary>
        public bool? Anchor {
            get { return BackingStore?.Get<bool?>(nameof(Anchor)); }
            set { BackingStore?.Set(nameof(Anchor), value); }
        }
        /// <summary>The apiExpressions property</summary>
        public List<StringKeyStringValuePair> ApiExpressions {
            get { return BackingStore?.Get<List<StringKeyStringValuePair>>(nameof(ApiExpressions)); }
            set { BackingStore?.Set(nameof(ApiExpressions), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.</summary>
        public bool? CaseExact {
            get { return BackingStore?.Get<bool?>(nameof(CaseExact)); }
            set { BackingStore?.Set(nameof(CaseExact), value); }
        }
        /// <summary>The defaultValue property</summary>
        public string DefaultValue {
            get { return BackingStore?.Get<string>(nameof(DefaultValue)); }
            set { BackingStore?.Set(nameof(DefaultValue), value); }
        }
        /// <summary>&apos;true&apos; to allow null values for attributes.</summary>
        public bool? FlowNullValues {
            get { return BackingStore?.Get<bool?>(nameof(FlowNullValues)); }
            set { BackingStore?.Set(nameof(FlowNullValues), value); }
        }
        /// <summary>Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.</summary>
        public List<MetadataEntry> Metadata {
            get { return BackingStore?.Get<List<MetadataEntry>>(nameof(Metadata)); }
            set { BackingStore?.Set(nameof(Metadata), value); }
        }
        /// <summary>true if an attribute can have multiple values. Default is false.</summary>
        public bool? Multivalued {
            get { return BackingStore?.Get<bool?>(nameof(Multivalued)); }
            set { BackingStore?.Set(nameof(Multivalued), value); }
        }
        /// <summary>An attribute&apos;s mutability. Possible values are:  ReadWrite, ReadOnly, Immutable, WriteOnly. Default is ReadWrite.</summary>
        public Microsoft.Graph.Beta.Models.Mutability? Mutability {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Mutability?>(nameof(Mutability)); }
            set { BackingStore?.Set(nameof(Mutability), value); }
        }
        /// <summary>Name of the attribute. Must be unique within the object definition. Not nullable.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).</summary>
        public List<ReferencedObject> ReferencedObjects {
            get { return BackingStore?.Get<List<ReferencedObject>>(nameof(ReferencedObjects)); }
            set { BackingStore?.Set(nameof(ReferencedObjects), value); }
        }
        /// <summary>true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.</summary>
        public bool? Required {
            get { return BackingStore?.Get<bool?>(nameof(Required)); }
            set { BackingStore?.Set(nameof(Required), value); }
        }
        /// <summary>Attribute value type. Possible values are: String, Integer, Reference, Binary, Boolean,DateTime. Default is String.</summary>
        public AttributeType? Type {
            get { return BackingStore?.Get<AttributeType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Instantiates a new attributeDefinition and sets the default values.
        /// </summary>
        public AttributeDefinition() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttributeDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"anchor", n => { Anchor = n.GetBoolValue(); } },
                {"apiExpressions", n => { ApiExpressions = n.GetCollectionOfObjectValues<StringKeyStringValuePair>(StringKeyStringValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"caseExact", n => { CaseExact = n.GetBoolValue(); } },
                {"defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                {"flowNullValues", n => { FlowNullValues = n.GetBoolValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<MetadataEntry>(MetadataEntry.CreateFromDiscriminatorValue).ToList(); } },
                {"multivalued", n => { Multivalued = n.GetBoolValue(); } },
                {"mutability", n => { Mutability = n.GetEnumValue<Mutability>(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"referencedObjects", n => { ReferencedObjects = n.GetCollectionOfObjectValues<ReferencedObject>(ReferencedObject.CreateFromDiscriminatorValue).ToList(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
                {"type", n => { Type = n.GetEnumValue<AttributeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("anchor", Anchor);
            writer.WriteCollectionOfObjectValues<StringKeyStringValuePair>("apiExpressions", ApiExpressions);
            writer.WriteBoolValue("caseExact", CaseExact);
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteBoolValue("flowNullValues", FlowNullValues);
            writer.WriteCollectionOfObjectValues<MetadataEntry>("metadata", Metadata);
            writer.WriteBoolValue("multivalued", Multivalued);
            writer.WriteEnumValue<Mutability>("mutability", Mutability);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ReferencedObject>("referencedObjects", ReferencedObjects);
            writer.WriteBoolValue("required", Required);
            writer.WriteEnumValue<AttributeType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
