using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MfaDetail : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the MFA auth detail for the corresponding Sign-in activity when the MFA Required is 'Yes'.</summary>
        public string AuthDetail { get; set; }
        /// <summary>Indicates the MFA Auth methods (SMS, Phone, Authenticator App are some of the value) for the corresponding sign-in activity when the MFA Required field is 'Yes'.</summary>
        public string AuthMethod { get; set; }
        /// <summary>
        /// Instantiates a new mfaDetail and sets the default values.
        /// </summary>
        public MfaDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"authDetail", (o,n) => { (o as MfaDetail).AuthDetail = n.GetStringValue(); } },
                {"authMethod", (o,n) => { (o as MfaDetail).AuthMethod = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authDetail", AuthDetail);
            writer.WriteStringValue("authMethod", AuthMethod);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
