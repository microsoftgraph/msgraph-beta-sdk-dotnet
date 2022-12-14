using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.InformationProtection.DecryptBuffer {
    /// <summary>
    /// Provides operations to call the decryptBuffer method.
    /// </summary>
    public class DecryptBufferPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The encryptedBuffer property</summary>
        public byte[] EncryptedBuffer {
            get { return BackingStore?.Get<byte[]>("encryptedBuffer"); }
            set { BackingStore?.Set("encryptedBuffer", value); }
        }
        /// <summary>The publishingLicense property</summary>
        public byte[] PublishingLicense {
            get { return BackingStore?.Get<byte[]>("publishingLicense"); }
            set { BackingStore?.Set("publishingLicense", value); }
        }
        /// <summary>
        /// Instantiates a new decryptBufferPostRequestBody and sets the default values.
        /// </summary>
        public DecryptBufferPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DecryptBufferPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DecryptBufferPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"encryptedBuffer", n => { EncryptedBuffer = n.GetByteArrayValue(); } },
                {"publishingLicense", n => { PublishingLicense = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("encryptedBuffer", EncryptedBuffer);
            writer.WriteByteArrayValue("publishingLicense", PublishingLicense);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
