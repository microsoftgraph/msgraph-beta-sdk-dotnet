using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class AttributeDefinition : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.</summary>
        public bool? Anchor { get; set; }
        public List<StringKeyStringValuePair> ApiExpressions { get; set; }
        /// <summary>true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.</summary>
        public bool? CaseExact { get; set; }
        public string DefaultValue { get; set; }
        /// <summary>'true' to allow null values for attributes.</summary>
        public bool? FlowNullValues { get; set; }
        /// <summary>Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.</summary>
        public List<MetadataEntry> Metadata { get; set; }
        /// <summary>true if an attribute can have multiple values. Default is false.</summary>
        public bool? Multivalued { get; set; }
        /// <summary>An attribute's mutability. Possible values are:  ReadWrite, ReadOnly, Immutable, WriteOnly. Default is ReadWrite.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Mutability? Mutability { get; set; }
        /// <summary>Name of the attribute. Must be unique within the object definition. Not nullable.</summary>
        public string Name { get; set; }
        /// <summary>For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).</summary>
        public List<ReferencedObject> ReferencedObjects { get; set; }
        /// <summary>true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.</summary>
        public bool? Required { get; set; }
        /// <summary>Attribute value type. Possible values are: String, Integer, Reference, Binary, Boolean,DateTime. Default is String.</summary>
        public AttributeType? Type { get; set; }
        /// <summary>
        /// Instantiates a new attributeDefinition and sets the default values.
        /// </summary>
        public AttributeDefinition() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"anchor", (o,n) => { (o as AttributeDefinition).Anchor = n.GetBoolValue(); } },
                {"apiExpressions", (o,n) => { (o as AttributeDefinition).ApiExpressions = n.GetCollectionOfObjectValues<StringKeyStringValuePair>(StringKeyStringValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"caseExact", (o,n) => { (o as AttributeDefinition).CaseExact = n.GetBoolValue(); } },
                {"defaultValue", (o,n) => { (o as AttributeDefinition).DefaultValue = n.GetStringValue(); } },
                {"flowNullValues", (o,n) => { (o as AttributeDefinition).FlowNullValues = n.GetBoolValue(); } },
                {"metadata", (o,n) => { (o as AttributeDefinition).Metadata = n.GetCollectionOfObjectValues<MetadataEntry>(MetadataEntry.CreateFromDiscriminatorValue).ToList(); } },
                {"multivalued", (o,n) => { (o as AttributeDefinition).Multivalued = n.GetBoolValue(); } },
                {"mutability", (o,n) => { (o as AttributeDefinition).Mutability = n.GetEnumValue<Mutability>(); } },
                {"name", (o,n) => { (o as AttributeDefinition).Name = n.GetStringValue(); } },
                {"referencedObjects", (o,n) => { (o as AttributeDefinition).ReferencedObjects = n.GetCollectionOfObjectValues<ReferencedObject>(ReferencedObject.CreateFromDiscriminatorValue).ToList(); } },
                {"required", (o,n) => { (o as AttributeDefinition).Required = n.GetBoolValue(); } },
                {"type", (o,n) => { (o as AttributeDefinition).Type = n.GetEnumValue<AttributeType>(); } },
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
