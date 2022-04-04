using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.InformationProtection.VerifySignature {
    /// <summary>Provides operations to call the verifySignature method.</summary>
    public class VerifySignatureRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The digest property</summary>
        public byte[] Digest { get; set; }
        /// <summary>The signature property</summary>
        public byte[] Signature { get; set; }
        /// <summary>The signingKeyId property</summary>
        public string SigningKeyId { get; set; }
        /// <summary>
        /// Instantiates a new verifySignatureRequestBody and sets the default values.
        /// </summary>
        public VerifySignatureRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VerifySignatureRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifySignatureRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"digest", (o,n) => { (o as VerifySignatureRequestBody).Digest = n.GetByteArrayValue(); } },
                {"signature", (o,n) => { (o as VerifySignatureRequestBody).Signature = n.GetByteArrayValue(); } },
                {"signingKeyId", (o,n) => { (o as VerifySignatureRequestBody).SigningKeyId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("digest", Digest);
            writer.WriteByteArrayValue("signature", Signature);
            writer.WriteStringValue("signingKeyId", SigningKeyId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
