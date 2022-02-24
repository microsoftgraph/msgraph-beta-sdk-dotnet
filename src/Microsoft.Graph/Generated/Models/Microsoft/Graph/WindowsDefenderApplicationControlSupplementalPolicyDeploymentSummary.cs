using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary : Entity, IParsable {
        /// <summary>Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.</summary>
        public int? DeployedDeviceCount { get; set; }
        /// <summary>Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deployedDeviceCount", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary).DeployedDeviceCount = n.GetIntValue(); } },
                {"failedDeviceCount", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary).FailedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("deployedDeviceCount", DeployedDeviceCount);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
        }
    }
}
