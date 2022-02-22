using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.DeviceCompliancePolicies.ValidateComplianceScript {
    public class ValidateComplianceScriptRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DeviceCompliancePolicyScript DeviceCompliancePolicyScript { get; set; }
        /// <summary>
        /// Instantiates a new validateComplianceScriptRequestBody and sets the default values.
        /// </summary>
        public ValidateComplianceScriptRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceCompliancePolicyScript", (o,n) => { (o as ValidateComplianceScriptRequestBody).DeviceCompliancePolicyScript = n.GetObjectValue<DeviceCompliancePolicyScript>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceCompliancePolicyScript>("deviceCompliancePolicyScript", DeviceCompliancePolicyScript);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
