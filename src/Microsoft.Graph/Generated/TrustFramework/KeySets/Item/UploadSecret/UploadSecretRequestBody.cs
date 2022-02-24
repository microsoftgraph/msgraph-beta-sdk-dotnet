using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.TrustFramework.KeySets.Item.UploadSecret {
    public class UploadSecretRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public long? Exp { get; set; }
        public string K { get; set; }
        public long? Nbf { get; set; }
        public string Use { get; set; }
        /// <summary>
        /// Instantiates a new uploadSecretRequestBody and sets the default values.
        /// </summary>
        public UploadSecretRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"exp", (o,n) => { (o as UploadSecretRequestBody).Exp = n.GetLongValue(); } },
                {"k", (o,n) => { (o as UploadSecretRequestBody).K = n.GetStringValue(); } },
                {"nbf", (o,n) => { (o as UploadSecretRequestBody).Nbf = n.GetLongValue(); } },
                {"use", (o,n) => { (o as UploadSecretRequestBody).Use = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("exp", Exp);
            writer.WriteStringValue("k", K);
            writer.WriteLongValue("nbf", Nbf);
            writer.WriteStringValue("use", Use);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
