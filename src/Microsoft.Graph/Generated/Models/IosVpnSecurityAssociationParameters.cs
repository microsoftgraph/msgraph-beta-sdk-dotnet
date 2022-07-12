using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN Security Association Parameters</summary>
    public class IosVpnSecurityAssociationParameters : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Lifetime (minutes)</summary>
        public int? LifetimeInMinutes {
            get { return BackingStore?.Get<int?>("lifetimeInMinutes"); }
            set { BackingStore?.Set("lifetimeInMinutes", value); }
        }
        /// <summary>Diffie-Hellman Group</summary>
        public int? SecurityDiffieHellmanGroup {
            get { return BackingStore?.Get<int?>("securityDiffieHellmanGroup"); }
            set { BackingStore?.Set("securityDiffieHellmanGroup", value); }
        }
        /// <summary>Encryption algorithm. Possible values are: aes256, des, tripleDes, aes128, aes128Gcm, aes256Gcm, aes192, aes192Gcm, chaCha20Poly1305.</summary>
        public VpnEncryptionAlgorithmType? SecurityEncryptionAlgorithm {
            get { return BackingStore?.Get<VpnEncryptionAlgorithmType?>("securityEncryptionAlgorithm"); }
            set { BackingStore?.Set("securityEncryptionAlgorithm", value); }
        }
        /// <summary>Integrity algorithm. Possible values are: sha2_256, sha1_96, sha1_160, sha2_384, sha2_512, md5.</summary>
        public VpnIntegrityAlgorithmType? SecurityIntegrityAlgorithm {
            get { return BackingStore?.Get<VpnIntegrityAlgorithmType?>("securityIntegrityAlgorithm"); }
            set { BackingStore?.Set("securityIntegrityAlgorithm", value); }
        }
        /// <summary>
        /// Instantiates a new iosVpnSecurityAssociationParameters and sets the default values.
        /// </summary>
        public IosVpnSecurityAssociationParameters() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosVpnSecurityAssociationParameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVpnSecurityAssociationParameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lifetimeInMinutes", n => { LifetimeInMinutes = n.GetIntValue(); } },
                {"securityDiffieHellmanGroup", n => { SecurityDiffieHellmanGroup = n.GetIntValue(); } },
                {"securityEncryptionAlgorithm", n => { SecurityEncryptionAlgorithm = n.GetEnumValue<VpnEncryptionAlgorithmType>(); } },
                {"securityIntegrityAlgorithm", n => { SecurityIntegrityAlgorithm = n.GetEnumValue<VpnIntegrityAlgorithmType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("lifetimeInMinutes", LifetimeInMinutes);
            writer.WriteIntValue("securityDiffieHellmanGroup", SecurityDiffieHellmanGroup);
            writer.WriteEnumValue<VpnEncryptionAlgorithmType>("securityEncryptionAlgorithm", SecurityEncryptionAlgorithm);
            writer.WriteEnumValue<VpnIntegrityAlgorithmType>("securityIntegrityAlgorithm", SecurityIntegrityAlgorithm);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
