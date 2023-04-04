using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ObjectDefinition : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttributeDefinition>? Attributes {
            get { return BackingStore?.Get<List<AttributeDefinition>?>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
#nullable restore
#else
        public List<AttributeDefinition> Attributes {
            get { return BackingStore?.Get<List<AttributeDefinition>>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MetadataEntry>? Metadata {
            get { return BackingStore?.Get<List<MetadataEntry>?>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#nullable restore
#else
        public List<MetadataEntry> Metadata {
            get { return BackingStore?.Get<List<MetadataEntry>>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The supportedApis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedApis {
            get { return BackingStore?.Get<List<string>?>("supportedApis"); }
            set { BackingStore?.Set("supportedApis", value); }
        }
#nullable restore
#else
        public List<string> SupportedApis {
            get { return BackingStore?.Get<List<string>>("supportedApis"); }
            set { BackingStore?.Set("supportedApis", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new objectDefinition and sets the default values.
        /// </summary>
        public ObjectDefinition() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ObjectDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ObjectDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attributes", n => { Attributes = n.GetCollectionOfObjectValues<AttributeDefinition>(AttributeDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<MetadataEntry>(MetadataEntry.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"supportedApis", n => { SupportedApis = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AttributeDefinition>("attributes", Attributes);
            writer.WriteCollectionOfObjectValues<MetadataEntry>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedApis", SupportedApis);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
