using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ActivateDeviceEsimActionResult : DeviceActionResult, IParsable {
        /// <summary>Carrier Url to activate the device eSIM</summary>
        public string CarrierUrl {
            get { return BackingStore?.Get<string>("carrierUrl"); }
            set { BackingStore?.Set("carrierUrl", value); }
        }
        /// <summary>
        /// Instantiates a new ActivateDeviceEsimActionResult and sets the default values.
        /// </summary>
        public ActivateDeviceEsimActionResult() : base() {
            OdataType = "#microsoft.graph.activateDeviceEsimActionResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ActivateDeviceEsimActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActivateDeviceEsimActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"carrierUrl", n => { CarrierUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("carrierUrl", CarrierUrl);
        }
    }
}
