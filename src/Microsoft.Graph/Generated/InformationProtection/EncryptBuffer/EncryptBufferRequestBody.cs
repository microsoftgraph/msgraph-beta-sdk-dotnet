using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.InformationProtection.EncryptBuffer {
    /// <summary>Provides operations to call the encryptBuffer method.</summary>
    public class EncryptBufferRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public byte[] Buffer { get; set; }
        public string LabelId { get; set; }
        /// <summary>
        /// Instantiates a new encryptBufferRequestBody and sets the default values.
        /// </summary>
        public EncryptBufferRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EncryptBufferRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EncryptBufferRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"buffer", (o,n) => { (o as EncryptBufferRequestBody).Buffer = n.GetByteArrayValue(); } },
                {"labelId", (o,n) => { (o as EncryptBufferRequestBody).LabelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("buffer", Buffer);
            writer.WriteStringValue("labelId", LabelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
