using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.ValidateComplianceScript {
    /// <summary>Provides operations to call the validateComplianceScript method.</summary>
    public class ValidateComplianceScriptRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deviceCompliancePolicyScript property</summary>
        public Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript DeviceCompliancePolicyScript { get; set; }
        /// <summary>
        /// Instantiates a new validateComplianceScriptRequestBody and sets the default values.
        /// </summary>
        public ValidateComplianceScriptRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ValidateComplianceScriptRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidateComplianceScriptRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceCompliancePolicyScript", (o,n) => { (o as ValidateComplianceScriptRequestBody).DeviceCompliancePolicyScript = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript>(Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript>("deviceCompliancePolicyScript", DeviceCompliancePolicyScript);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
