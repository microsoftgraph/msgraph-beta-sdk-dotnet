using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>OEM Warranty information for a given device</summary>
    public class OemWarranty : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>List of additional warranty offers. This collection can contain a maximum of 100 elements.</summary>
        public List<WarrantyOffer> AdditionalWarranties {
            get { return BackingStore?.Get<List<WarrantyOffer>>("additionalWarranties"); }
            set { BackingStore?.Set("additionalWarranties", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of base warranty offers. This collection can contain a maximum of 100 elements.</summary>
        public List<WarrantyOffer> BaseWarranties {
            get { return BackingStore?.Get<List<WarrantyOffer>>("baseWarranties"); }
            set { BackingStore?.Set("baseWarranties", value); }
        }
        /// <summary>Device configuration page URL</summary>
        public string DeviceConfigurationUrl {
            get { return BackingStore?.Get<string>("deviceConfigurationUrl"); }
            set { BackingStore?.Set("deviceConfigurationUrl", value); }
        }
        /// <summary>Device warranty page URL</summary>
        public string DeviceWarrantyUrl {
            get { return BackingStore?.Get<string>("deviceWarrantyUrl"); }
            set { BackingStore?.Set("deviceWarrantyUrl", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new oemWarranty and sets the default values.
        /// </summary>
        public OemWarranty() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.oemWarranty";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OemWarranty CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OemWarranty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalWarranties", n => { AdditionalWarranties = n.GetCollectionOfObjectValues<WarrantyOffer>(WarrantyOffer.CreateFromDiscriminatorValue).ToList(); } },
                {"baseWarranties", n => { BaseWarranties = n.GetCollectionOfObjectValues<WarrantyOffer>(WarrantyOffer.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationUrl", n => { DeviceConfigurationUrl = n.GetStringValue(); } },
                {"deviceWarrantyUrl", n => { DeviceWarrantyUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<WarrantyOffer>("additionalWarranties", AdditionalWarranties);
            writer.WriteCollectionOfObjectValues<WarrantyOffer>("baseWarranties", BaseWarranties);
            writer.WriteStringValue("deviceConfigurationUrl", DeviceConfigurationUrl);
            writer.WriteStringValue("deviceWarrantyUrl", DeviceWarrantyUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
