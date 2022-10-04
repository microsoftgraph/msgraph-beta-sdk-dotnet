using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkPeripheral : Entity, IParsable {
        /// <summary>Display name for the peripheral.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The product ID of the device. Each product from a vendor has its own ID.</summary>
        public string ProductId {
            get { return BackingStore?.Get<string>("productId"); }
            set { BackingStore?.Set("productId", value); }
        }
        /// <summary>The unique identifier for the vendor of the device. Each vendor has a unique ID.</summary>
        public string VendorId {
            get { return BackingStore?.Get<string>("vendorId"); }
            set { BackingStore?.Set("vendorId", value); }
        }
        /// <summary>
        /// Instantiates a new TeamworkPeripheral and sets the default values.
        /// </summary>
        public TeamworkPeripheral() : base() {
            OdataType = "#microsoft.graph.teamworkPeripheral";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamworkPeripheral CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkPeripheral();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"productId", n => { ProductId = n.GetStringValue(); } },
                {"vendorId", n => { VendorId = n.GetStringValue(); } },
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
