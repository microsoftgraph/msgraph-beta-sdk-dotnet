using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class ItemAddress : ItemFacet, IParsable {
        public PhysicalAddress Detail { get; set; }
        /// <summary>Friendly name the user has assigned to this address.</summary>
        public string DisplayName { get; set; }
        /// <summary>The geocoordinates of the address.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.GeoCoordinates GeoCoordinates { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"detail", (o,n) => { (o as ItemAddress).Detail = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as ItemAddress).DisplayName = n.GetStringValue(); } },
                {"geoCoordinates", (o,n) => { (o as ItemAddress).GeoCoordinates = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.GeoCoordinates>(MicrosoftGraphSdk.Models.Microsoft.Graph.GeoCoordinates.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.GeoCoordinates>("geoCoordinates", GeoCoordinates);
        }
    }
}
