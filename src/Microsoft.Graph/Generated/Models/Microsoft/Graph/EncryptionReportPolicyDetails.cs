using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class EncryptionReportPolicyDetails : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Policy Id for Encryption Report</summary>
        public string PolicyId { get; set; }
        /// <summary>Policy Name for Encryption Report</summary>
        public string PolicyName { get; set; }
        /// <summary>
        /// Instantiates a new encryptionReportPolicyDetails and sets the default values.
        /// </summary>
        public EncryptionReportPolicyDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"policyId", (o,n) => { (o as EncryptionReportPolicyDetails).PolicyId = n.GetStringValue(); } },
                {"policyName", (o,n) => { (o as EncryptionReportPolicyDetails).PolicyName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
