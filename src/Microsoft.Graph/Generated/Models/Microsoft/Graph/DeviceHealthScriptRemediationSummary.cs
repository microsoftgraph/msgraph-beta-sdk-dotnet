using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceHealthScriptRemediationSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of devices remediated by device health scripts.</summary>
        public int? RemediatedDeviceCount { get; set; }
        /// <summary>The number of device health scripts deployed.</summary>
        public int? ScriptCount { get; set; }
        /// <summary>
        /// Instantiates a new deviceHealthScriptRemediationSummary and sets the default values.
        /// </summary>
        public DeviceHealthScriptRemediationSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"remediatedDeviceCount", (o,n) => { (o as DeviceHealthScriptRemediationSummary).RemediatedDeviceCount = n.GetIntValue(); } },
                {"scriptCount", (o,n) => { (o as DeviceHealthScriptRemediationSummary).ScriptCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteIntValue("scriptCount", ScriptCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
