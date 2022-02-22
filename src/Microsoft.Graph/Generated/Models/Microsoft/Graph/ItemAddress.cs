using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ItemAddress : ItemFacet, IParsable {
        public PhysicalAddress Detail { get; set; }
        /// <summary>Friendly name the user has assigned to this address.</summary>
        public string DisplayName { get; set; }
        /// <summary>The geocoordinates of the address.</summary>
        public GeoCoordinates GeoCoordinates { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"detail", (o,n) => { (o as ItemAddress).Detail = n.GetObjectValue<PhysicalAddress>(); } },
                {"displayName", (o,n) => { (o as ItemAddress).DisplayName = n.GetStringValue(); } },
                {"geoCoordinates", (o,n) => { (o as ItemAddress).GeoCoordinates = n.GetObjectValue<GeoCoordinates>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalAddress>("detail", Detail);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<GeoCoordinates>("geoCoordinates", GeoCoordinates);
        }
    }
}
