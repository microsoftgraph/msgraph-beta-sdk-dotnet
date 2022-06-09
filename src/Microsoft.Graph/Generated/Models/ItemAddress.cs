using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ItemAddress : ItemFacet, IParsable {
        /// <summary>The detail property</summary>
        public PhysicalAddress Detail {
            get { return BackingStore?.Get<PhysicalAddress>(nameof(Detail)); }
            set { BackingStore?.Set(nameof(Detail), value); }
        }
        /// <summary>Friendly name the user has assigned to this address.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The geocoordinates of the address.</summary>
        public Microsoft.Graph.Beta.Models.GeoCoordinates GeoCoordinates {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GeoCoordinates>(nameof(GeoCoordinates)); }
            set { BackingStore?.Set(nameof(GeoCoordinates), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detail", n => { Detail = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"geoCoordinates", n => { GeoCoordinates = n.GetObjectValue<Microsoft.Graph.Beta.Models.GeoCoordinates>(Microsoft.Graph.Beta.Models.GeoCoordinates.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.GeoCoordinates>("geoCoordinates", GeoCoordinates);
        }
    }
}
