using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SigningCertificateUpdateStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CertificateUpdateResult { get; set; }
        public DateTimeOffset? LastRunDateTime { get; set; }
        /// <summary>
        /// Instantiates a new signingCertificateUpdateStatus and sets the default values.
        /// </summary>
        public SigningCertificateUpdateStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"certificateUpdateResult", (o,n) => { (o as SigningCertificateUpdateStatus).CertificateUpdateResult = n.GetStringValue(); } },
                {"lastRunDateTime", (o,n) => { (o as SigningCertificateUpdateStatus).LastRunDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("certificateUpdateResult", CertificateUpdateResult);
            writer.WriteDateTimeOffsetValue("lastRunDateTime", LastRunDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
