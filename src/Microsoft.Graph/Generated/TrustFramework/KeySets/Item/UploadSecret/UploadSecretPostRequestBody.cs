using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.TrustFramework.KeySets.Item.UploadSecret {
    public class UploadSecretPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The exp property</summary>
        public long? Exp {
            get { return BackingStore?.Get<long?>("exp"); }
            set { BackingStore?.Set("exp", value); }
        }
        /// <summary>The k property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? K {
            get { return BackingStore?.Get<string?>("k"); }
            set { BackingStore?.Set("k", value); }
        }
#nullable restore
#else
        public string K {
            get { return BackingStore?.Get<string>("k"); }
            set { BackingStore?.Set("k", value); }
        }
#endif
        /// <summary>The nbf property</summary>
        public long? Nbf {
            get { return BackingStore?.Get<long?>("nbf"); }
            set { BackingStore?.Set("nbf", value); }
        }
        /// <summary>The use property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Use {
            get { return BackingStore?.Get<string?>("use"); }
            set { BackingStore?.Set("use", value); }
        }
#nullable restore
#else
        public string Use {
            get { return BackingStore?.Get<string>("use"); }
            set { BackingStore?.Set("use", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new uploadSecretPostRequestBody and sets the default values.
        /// </summary>
        public UploadSecretPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UploadSecretPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UploadSecretPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"exp", n => { Exp = n.GetLongValue(); } },
                {"k", n => { K = n.GetStringValue(); } },
                {"nbf", n => { Nbf = n.GetLongValue(); } },
                {"use", n => { Use = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
