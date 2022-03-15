using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.TrustFramework.KeySets.Item.GenerateKey {
    /// <summary>Provides operations to call the generateKey method.</summary>
    public class GenerateKeyRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? Exp { get; set; }
        public string Kty { get; set; }
        public int? Nbf { get; set; }
        public string Use { get; set; }
        /// <summary>
        /// Instantiates a new generateKeyRequestBody and sets the default values.
        /// </summary>
        public GenerateKeyRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GenerateKeyRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GenerateKeyRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"exp", (o,n) => { (o as GenerateKeyRequestBody).Exp = n.GetIntValue(); } },
                {"kty", (o,n) => { (o as GenerateKeyRequestBody).Kty = n.GetStringValue(); } },
                {"nbf", (o,n) => { (o as GenerateKeyRequestBody).Nbf = n.GetIntValue(); } },
                {"use", (o,n) => { (o as GenerateKeyRequestBody).Use = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("exp", Exp);
            writer.WriteStringValue("kty", Kty);
            writer.WriteIntValue("nbf", Nbf);
            writer.WriteStringValue("use", Use);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
