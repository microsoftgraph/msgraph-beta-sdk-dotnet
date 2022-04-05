using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ObjectMapping : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.</summary>
        public List<AttributeMapping> AttributeMappings { get; set; }
        /// <summary>When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Which flow types are enabled for this object mapping. Add creates new objects in the target directory, Update modifies existing objects, and Delete deprovisions existing users. The default is Add, Update, Delete.</summary>
        public ObjectFlowTypes? FlowTypes { get; set; }
        /// <summary>Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.</summary>
        public List<MetadataEntry> Metadata { get; set; }
        /// <summary>Human-friendly name of the object mapping.</summary>
        public string Name { get; set; }
        /// <summary>Defines a filter to be used when deciding whether a given object should be provisioned. For example, you might want to only provision users that are located in the US.</summary>
        public Filter Scope { get; set; }
        /// <summary>Name of the object in the source directory. Must match the object name from the source directory definition.</summary>
        public string SourceObjectName { get; set; }
        /// <summary>Name of the object in target directory. Must match the object name from the target directory definition.</summary>
        public string TargetObjectName { get; set; }
        /// <summary>
        /// Instantiates a new objectMapping and sets the default values.
        /// </summary>
        public ObjectMapping() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ObjectMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ObjectMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attributeMappings", (o,n) => { (o as ObjectMapping).AttributeMappings = n.GetCollectionOfObjectValues<AttributeMapping>(AttributeMapping.CreateFromDiscriminatorValue).ToList(); } },
                {"enabled", (o,n) => { (o as ObjectMapping).Enabled = n.GetBoolValue(); } },
                {"flowTypes", (o,n) => { (o as ObjectMapping).FlowTypes = n.GetEnumValue<ObjectFlowTypes>(); } },
                {"metadata", (o,n) => { (o as ObjectMapping).Metadata = n.GetCollectionOfObjectValues<MetadataEntry>(MetadataEntry.CreateFromDiscriminatorValue).ToList(); } },
                {"name", (o,n) => { (o as ObjectMapping).Name = n.GetStringValue(); } },
                {"scope", (o,n) => { (o as ObjectMapping).Scope = n.GetObjectValue<Filter>(Filter.CreateFromDiscriminatorValue); } },
                {"sourceObjectName", (o,n) => { (o as ObjectMapping).SourceObjectName = n.GetStringValue(); } },
                {"targetObjectName", (o,n) => { (o as ObjectMapping).TargetObjectName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AttributeMapping>("attributeMappings", AttributeMappings);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<ObjectFlowTypes>("flowTypes", FlowTypes);
            writer.WriteCollectionOfObjectValues<MetadataEntry>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Filter>("scope", Scope);
            writer.WriteStringValue("sourceObjectName", SourceObjectName);
            writer.WriteStringValue("targetObjectName", TargetObjectName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
