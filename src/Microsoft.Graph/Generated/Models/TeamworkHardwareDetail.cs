using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkHardwareDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>MAC address.</summary>
        public List<string> MacAddresses { get; set; }
        /// <summary>Device manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>Devie model.</summary>
        public string Model { get; set; }
        /// <summary>Device serial number.</summary>
        public string SerialNumber { get; set; }
        /// <summary>The unique identifier for the device.</summary>
        public string UniqueId { get; set; }
        /// <summary>
        /// Instantiates a new teamworkHardwareDetail and sets the default values.
        /// </summary>
        public TeamworkHardwareDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkHardwareDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkHardwareDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"macAddresses", n => { MacAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"uniqueId", n => { UniqueId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("macAddresses", MacAddresses);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("uniqueId", UniqueId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
