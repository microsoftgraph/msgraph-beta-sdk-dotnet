using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.TrustFramework.KeySets.Item.GenerateKey {
    public class GenerateKeyRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public long? Exp { get; set; }
        public string Kty { get; set; }
        public long? Nbf { get; set; }
        public string Use { get; set; }
        /// <summary>
        /// Instantiates a new generateKeyRequestBody and sets the default values.
        /// </summary>
        public GenerateKeyRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"exp", (o,n) => { (o as GenerateKeyRequestBody).Exp = n.GetLongValue(); } },
                {"kty", (o,n) => { (o as GenerateKeyRequestBody).Kty = n.GetStringValue(); } },
                {"nbf", (o,n) => { (o as GenerateKeyRequestBody).Nbf = n.GetLongValue(); } },
                {"use", (o,n) => { (o as GenerateKeyRequestBody).Use = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("exp", Exp);
            writer.WriteStringValue("kty", Kty);
            writer.WriteLongValue("nbf", Nbf);
            writer.WriteStringValue("use", Use);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
