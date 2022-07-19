using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Property : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The aliases property</summary>
        public List<string> Aliases {
            get { return BackingStore?.Get<List<string>>("aliases"); }
            set { BackingStore?.Set("aliases", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The isQueryable property</summary>
        public bool? IsQueryable {
            get { return BackingStore?.Get<bool?>("isQueryable"); }
            set { BackingStore?.Set("isQueryable", value); }
        }
        /// <summary>The isRefinable property</summary>
        public bool? IsRefinable {
            get { return BackingStore?.Get<bool?>("isRefinable"); }
            set { BackingStore?.Set("isRefinable", value); }
        }
        /// <summary>The isRetrievable property</summary>
        public bool? IsRetrievable {
            get { return BackingStore?.Get<bool?>("isRetrievable"); }
            set { BackingStore?.Set("isRetrievable", value); }
        }
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable {
            get { return BackingStore?.Get<bool?>("isSearchable"); }
            set { BackingStore?.Set("isSearchable", value); }
        }
        /// <summary>The labels property</summary>
        public List<string> Labels {
            get { return BackingStore?.Get<List<string>>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The type property</summary>
        public PropertyType? Type {
            get { return BackingStore?.Get<PropertyType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new property and sets the default values.
        /// </summary>
        public Property() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.property";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Property CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Property();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aliases", n => { Aliases = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isQueryable", n => { IsQueryable = n.GetBoolValue(); } },
                {"isRefinable", n => { IsRefinable = n.GetBoolValue(); } },
                {"isRetrievable", n => { IsRetrievable = n.GetBoolValue(); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"labels", n => { Labels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<PropertyType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aliases", Aliases);
            writer.WriteBoolValue("isQueryable", IsQueryable);
            writer.WriteBoolValue("isRefinable", IsRefinable);
            writer.WriteBoolValue("isRetrievable", IsRetrievable);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteCollectionOfPrimitiveValues<string>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<PropertyType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
