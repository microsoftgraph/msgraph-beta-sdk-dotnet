using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Applications.Item.AddKey {
    /// <summary>Provides operations to call the addKey method.</summary>
    public class KeyCredentialPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The keyCredential property</summary>
        public Microsoft.Graph.Beta.Models.KeyCredential KeyCredential {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KeyCredential>(nameof(KeyCredential)); }
            set { BackingStore?.Set(nameof(KeyCredential), value); }
        }
        /// <summary>The passwordCredential property</summary>
        public Microsoft.Graph.Beta.Models.PasswordCredential PasswordCredential {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PasswordCredential>(nameof(PasswordCredential)); }
            set { BackingStore?.Set(nameof(PasswordCredential), value); }
        }
        /// <summary>The proof property</summary>
        public string Proof {
            get { return BackingStore?.Get<string>(nameof(Proof)); }
            set { BackingStore?.Set(nameof(Proof), value); }
        }
        /// <summary>
        /// Instantiates a new KeyCredentialPostRequestBody and sets the default values.
        /// </summary>
        public KeyCredentialPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static KeyCredentialPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KeyCredentialPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"keyCredential", n => { KeyCredential = n.GetObjectValue<Microsoft.Graph.Beta.Models.KeyCredential>(Microsoft.Graph.Beta.Models.KeyCredential.CreateFromDiscriminatorValue); } },
                {"passwordCredential", n => { PasswordCredential = n.GetObjectValue<Microsoft.Graph.Beta.Models.PasswordCredential>(Microsoft.Graph.Beta.Models.PasswordCredential.CreateFromDiscriminatorValue); } },
                {"proof", n => { Proof = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.KeyCredential>("keyCredential", KeyCredential);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PasswordCredential>("passwordCredential", PasswordCredential);
            writer.WriteStringValue("proof", Proof);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
