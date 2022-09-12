using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains the localized text to be displayed for a given variant</summary>
    public class OrganizationalMessageVariant : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The list of localized texts for this variant</summary>
        public List<OrganizationalMessageLocalizedText> LocalizedTexts {
            get { return BackingStore?.Get<List<OrganizationalMessageLocalizedText>>("localizedTexts"); }
            set { BackingStore?.Set("localizedTexts", value); }
        }
        /// <summary>The name of the variant</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>A unique identifier for this variant</summary>
        public string VariantId {
            get { return BackingStore?.Get<string>("variantId"); }
            set { BackingStore?.Set("variantId", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageVariant and sets the default values.
        /// </summary>
        public OrganizationalMessageVariant() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessageVariant";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessageVariant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageVariant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"localizedTexts", n => { LocalizedTexts = n.GetCollectionOfObjectValues<OrganizationalMessageLocalizedText>(OrganizationalMessageLocalizedText.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"variantId", n => { VariantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<OrganizationalMessageLocalizedText>("localizedTexts", LocalizedTexts);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("variantId", VariantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
