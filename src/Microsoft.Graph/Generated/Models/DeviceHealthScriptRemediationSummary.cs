using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The number of device health scripts deployed and the number of devices the scripts remediated.</summary>
    public class DeviceHealthScriptRemediationSummary : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceHealthScriptRemediationSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptRemediationSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
                {"scriptCount", n => { ScriptCount = n.GetIntValue(); } },
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
