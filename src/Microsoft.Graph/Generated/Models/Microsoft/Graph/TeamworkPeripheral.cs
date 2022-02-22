using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamworkPeripheral : Entity, IParsable {
        /// <summary>Display name for the peripheral.</summary>
        public string DisplayName { get; set; }
        /// <summary>The product ID of the device. Each product from a vendor has its own ID.</summary>
        public string ProductId { get; set; }
        /// <summary>The unique identifier for the vendor of the device. Each vendor has a unique ID.</summary>
        public string VendorId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as TeamworkPeripheral).DisplayName = n.GetStringValue(); } },
                {"productId", (o,n) => { (o as TeamworkPeripheral).ProductId = n.GetStringValue(); } },
                {"vendorId", (o,n) => { (o as TeamworkPeripheral).VendorId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("productId", ProductId);
            writer.WriteStringValue("vendorId", VendorId);
        }
    }
}
