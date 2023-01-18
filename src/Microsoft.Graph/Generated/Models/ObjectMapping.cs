using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ObjectMapping : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AttributeMapping>? AttributeMappings {
            get { return BackingStore?.Get<List<AttributeMapping>?>("attributeMappings"); }
            set { BackingStore?.Set("attributeMappings", value); }
        }
#else
        public List<AttributeMapping> AttributeMappings {
            get { return BackingStore?.Get<List<AttributeMapping>>("attributeMappings"); }
            set { BackingStore?.Set("attributeMappings", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>The flowTypes property</summary>
        public ObjectFlowTypes? FlowTypes {
            get { return BackingStore?.Get<ObjectFlowTypes?>("flowTypes"); }
            set { BackingStore?.Set("flowTypes", value); }
        }
        /// <summary>Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MetadataEntry>? Metadata {
            get { return BackingStore?.Get<List<MetadataEntry>?>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#else
        public List<MetadataEntry> Metadata {
            get { return BackingStore?.Get<List<MetadataEntry>>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#endif
        /// <summary>Human-friendly name of the object mapping.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Defines a filter to be used when deciding whether a given object should be provisioned. For example, you might want to only provision users that are located in the US.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Filter? Scope {
            get { return BackingStore?.Get<Filter?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#else
        public Filter Scope {
            get { return BackingStore?.Get<Filter>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>Name of the object in the source directory. Must match the object name from the source directory definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SourceObjectName {
            get { return BackingStore?.Get<string?>("sourceObjectName"); }
            set { BackingStore?.Set("sourceObjectName", value); }
        }
#else
        public string SourceObjectName {
            get { return BackingStore?.Get<string>("sourceObjectName"); }
            set { BackingStore?.Set("sourceObjectName", value); }
        }
#endif
        /// <summary>Name of the object in target directory. Must match the object name from the target directory definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TargetObjectName {
            get { return BackingStore?.Get<string?>("targetObjectName"); }
            set { BackingStore?.Set("targetObjectName", value); }
        }
#else
        public string TargetObjectName {
            get { return BackingStore?.Get<string>("targetObjectName"); }
            set { BackingStore?.Set("targetObjectName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new objectMapping and sets the default values.
        /// </summary>
        public ObjectMapping() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ObjectMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ObjectMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attributeMappings", n => { AttributeMappings = n.GetCollectionOfObjectValues<AttributeMapping>(AttributeMapping.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"flowTypes", n => { FlowTypes = n.GetEnumValue<ObjectFlowTypes>(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<MetadataEntry>(MetadataEntry.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetObjectValue<Filter>(Filter.CreateFromDiscriminatorValue); } },
                {"sourceObjectName", n => { SourceObjectName = n.GetStringValue(); } },
                {"targetObjectName", n => { TargetObjectName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AttributeMapping>("attributeMappings", AttributeMappings);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<ObjectFlowTypes>("flowTypes", FlowTypes);
            writer.WriteCollectionOfObjectValues<MetadataEntry>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Filter>("scope", Scope);
            writer.WriteStringValue("sourceObjectName", SourceObjectName);
            writer.WriteStringValue("targetObjectName", TargetObjectName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
