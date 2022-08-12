using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains the text to be displayed for a given locale</summary>
    public class OrganizationalMessageLocalizedText : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The locale for this text</summary>
        public string Locale {
            get { return BackingStore?.Get<string>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The text that will be displayed to a user from this specific locale</summary>
        public OrganizationalMessageText Text {
            get { return BackingStore?.Get<OrganizationalMessageText>("text"); }
            set { BackingStore?.Set("text", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageLocalizedText and sets the default values.
        /// </summary>
        public OrganizationalMessageLocalizedText() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessageLocalizedText";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessageLocalizedText CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageLocalizedText();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"locale", n => { Locale = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"text", n => { Text = n.GetObjectValue<OrganizationalMessageText>(OrganizationalMessageText.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("locale", Locale);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<OrganizationalMessageText>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
