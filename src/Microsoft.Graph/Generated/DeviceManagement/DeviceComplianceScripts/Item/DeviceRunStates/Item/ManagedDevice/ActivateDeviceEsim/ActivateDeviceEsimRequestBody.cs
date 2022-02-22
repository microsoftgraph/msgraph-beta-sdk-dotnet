using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.DeviceComplianceScripts.Item.DeviceRunStates.Item.ManagedDevice.ActivateDeviceEsim {
    public class ActivateDeviceEsimRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CarrierUrl { get; set; }
        /// <summary>
        /// Instantiates a new activateDeviceEsimRequestBody and sets the default values.
        /// </summary>
        public ActivateDeviceEsimRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"carrierUrl", (o,n) => { (o as ActivateDeviceEsimRequestBody).CarrierUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("carrierUrl", CarrierUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
