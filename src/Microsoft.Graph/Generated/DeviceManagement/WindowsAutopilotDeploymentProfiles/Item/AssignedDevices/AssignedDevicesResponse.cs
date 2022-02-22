using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.WindowsAutopilotDeploymentProfiles.Item.AssignedDevices {
    public class AssignedDevicesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<WindowsAutopilotDeviceIdentity> Value { get; set; }
        /// <summary>
        /// Instantiates a new assignedDevicesResponse and sets the default values.
        /// </summary>
        public AssignedDevicesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as AssignedDevicesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as AssignedDevicesResponse).Value = n.GetCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
