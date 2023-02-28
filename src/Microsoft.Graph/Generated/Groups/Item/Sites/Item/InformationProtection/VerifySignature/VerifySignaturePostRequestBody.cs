using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Groups.Item.Sites.Item.InformationProtection.VerifySignature {
    public class VerifySignaturePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The digest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Digest {
            get { return BackingStore?.Get<byte[]?>("digest"); }
            set { BackingStore?.Set("digest", value); }
        }
#nullable restore
#else
        public byte[] Digest {
            get { return BackingStore?.Get<byte[]>("digest"); }
            set { BackingStore?.Set("digest", value); }
        }
#endif
        /// <summary>The signature property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Signature {
            get { return BackingStore?.Get<byte[]?>("signature"); }
            set { BackingStore?.Set("signature", value); }
        }
#nullable restore
#else
        public byte[] Signature {
            get { return BackingStore?.Get<byte[]>("signature"); }
            set { BackingStore?.Set("signature", value); }
        }
#endif
        /// <summary>The signingKeyId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SigningKeyId {
            get { return BackingStore?.Get<string?>("signingKeyId"); }
            set { BackingStore?.Set("signingKeyId", value); }
        }
#nullable restore
#else
        public string SigningKeyId {
            get { return BackingStore?.Get<string>("signingKeyId"); }
            set { BackingStore?.Set("signingKeyId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new verifySignaturePostRequestBody and sets the default values.
        /// </summary>
        public VerifySignaturePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VerifySignaturePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifySignaturePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"digest", n => { Digest = n.GetByteArrayValue(); } },
                {"signature", n => { Signature = n.GetByteArrayValue(); } },
                {"signingKeyId", n => { SigningKeyId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("digest", Digest);
            writer.WriteByteArrayValue("signature", Signature);
            writer.WriteStringValue("signingKeyId", SigningKeyId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
