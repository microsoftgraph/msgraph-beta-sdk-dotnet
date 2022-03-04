using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OemWarranty : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of additional warranty offers. This collection can contain a maximum of 100 elements.</summary>
        public List<WarrantyOffer> AdditionalWarranties { get; set; }
        /// <summary>List of base warranty offers. This collection can contain a maximum of 100 elements.</summary>
        public List<WarrantyOffer> BaseWarranties { get; set; }
        /// <summary>Device configuration page URL</summary>
        public string DeviceConfigurationUrl { get; set; }
        /// <summary>Device warranty page URL</summary>
        public string DeviceWarrantyUrl { get; set; }
        /// <summary>
        /// Instantiates a new oemWarranty and sets the default values.
        /// </summary>
        public OemWarranty() {
            AdditionalData = new Dictionary<string, object>();
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"additionalWarranties", (o,n) => { (o as OemWarranty).AdditionalWarranties = n.GetCollectionOfObjectValues<WarrantyOffer>(WarrantyOffer.CreateFromDiscriminatorValue).ToList(); } },
                {"baseWarranties", (o,n) => { (o as OemWarranty).BaseWarranties = n.GetCollectionOfObjectValues<WarrantyOffer>(WarrantyOffer.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationUrl", (o,n) => { (o as OemWarranty).DeviceConfigurationUrl = n.GetStringValue(); } },
                {"deviceWarrantyUrl", (o,n) => { (o as OemWarranty).DeviceWarrantyUrl = n.GetStringValue(); } },
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
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
