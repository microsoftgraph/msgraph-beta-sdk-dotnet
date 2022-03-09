using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.InformationProtection.DecryptBuffer {
    /// <summary>Provides operations to call the decryptBuffer method.</summary>
    public class DecryptBufferRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public byte[] EncryptedBuffer { get; set; }
        public byte[] PublishingLicense { get; set; }
        /// <summary>
        /// Instantiates a new decryptBufferRequestBody and sets the default values.
        /// </summary>
        public DecryptBufferRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DecryptBufferRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DecryptBufferRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"encryptedBuffer", (o,n) => { (o as DecryptBufferRequestBody).EncryptedBuffer = n.GetByteArrayValue(); } },
                {"publishingLicense", (o,n) => { (o as DecryptBufferRequestBody).PublishingLicense = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("encryptedBuffer", EncryptedBuffer);
            writer.WriteByteArrayValue("publishingLicense", PublishingLicense);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
