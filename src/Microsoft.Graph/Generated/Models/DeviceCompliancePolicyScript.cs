using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceCompliancePolicyScript : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device compliance script Id.</summary>
        public string DeviceComplianceScriptId { get; set; }
        /// <summary>Json of the rules.</summary>
        public byte[] RulesContent { get; set; }
        /// <summary>
        /// Instantiates a new deviceCompliancePolicyScript and sets the default values.
        /// </summary>
        public DeviceCompliancePolicyScript() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceCompliancePolicyScript CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceCompliancePolicyScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceComplianceScriptId", (o,n) => { (o as DeviceCompliancePolicyScript).DeviceComplianceScriptId = n.GetStringValue(); } },
                {"rulesContent", (o,n) => { (o as DeviceCompliancePolicyScript).RulesContent = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceComplianceScriptId", DeviceComplianceScriptId);
            writer.WriteByteArrayValue("rulesContent", RulesContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
