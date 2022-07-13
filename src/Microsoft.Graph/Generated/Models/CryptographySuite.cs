using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN Security Association Parameters</summary>
    public class CryptographySuite : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Authentication Transform Constants. Possible values are: md5_96, sha1_96, sha_256_128, aes128Gcm, aes192Gcm, aes256Gcm.</summary>
        public AuthenticationTransformConstant? AuthenticationTransformConstants {
            get { return BackingStore?.Get<AuthenticationTransformConstant?>("authenticationTransformConstants"); }
            set { BackingStore?.Set("authenticationTransformConstants", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Cipher Transform Constants. Possible values are: aes256, des, tripleDes, aes128, aes128Gcm, aes256Gcm, aes192, aes192Gcm, chaCha20Poly1305.</summary>
        public VpnEncryptionAlgorithmType? CipherTransformConstants {
            get { return BackingStore?.Get<VpnEncryptionAlgorithmType?>("cipherTransformConstants"); }
            set { BackingStore?.Set("cipherTransformConstants", value); }
        }
        /// <summary>Diffie Hellman Group. Possible values are: group1, group2, group14, ecp256, ecp384, group24.</summary>
        public DiffieHellmanGroup? DhGroup {
            get { return BackingStore?.Get<DiffieHellmanGroup?>("dhGroup"); }
            set { BackingStore?.Set("dhGroup", value); }
        }
        /// <summary>Encryption Method. Possible values are: aes256, des, tripleDes, aes128, aes128Gcm, aes256Gcm, aes192, aes192Gcm, chaCha20Poly1305.</summary>
        public VpnEncryptionAlgorithmType? EncryptionMethod {
            get { return BackingStore?.Get<VpnEncryptionAlgorithmType?>("encryptionMethod"); }
            set { BackingStore?.Set("encryptionMethod", value); }
        }
        /// <summary>Integrity Check Method. Possible values are: sha2_256, sha1_96, sha1_160, sha2_384, sha2_512, md5.</summary>
        public VpnIntegrityAlgorithmType? IntegrityCheckMethod {
            get { return BackingStore?.Get<VpnIntegrityAlgorithmType?>("integrityCheckMethod"); }
            set { BackingStore?.Set("integrityCheckMethod", value); }
        }
        /// <summary>Perfect Forward Secrecy Group. Possible values are: pfs1, pfs2, pfs2048, ecp256, ecp384, pfsMM, pfs24.</summary>
        public PerfectForwardSecrecyGroup? PfsGroup {
            get { return BackingStore?.Get<PerfectForwardSecrecyGroup?>("pfsGroup"); }
            set { BackingStore?.Set("pfsGroup", value); }
        }
        /// <summary>
        /// Instantiates a new cryptographySuite and sets the default values.
        /// </summary>
        public CryptographySuite() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CryptographySuite CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CryptographySuite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authenticationTransformConstants", n => { AuthenticationTransformConstants = n.GetEnumValue<AuthenticationTransformConstant>(); } },
                {"cipherTransformConstants", n => { CipherTransformConstants = n.GetEnumValue<VpnEncryptionAlgorithmType>(); } },
                {"dhGroup", n => { DhGroup = n.GetEnumValue<DiffieHellmanGroup>(); } },
                {"encryptionMethod", n => { EncryptionMethod = n.GetEnumValue<VpnEncryptionAlgorithmType>(); } },
                {"integrityCheckMethod", n => { IntegrityCheckMethod = n.GetEnumValue<VpnIntegrityAlgorithmType>(); } },
                {"pfsGroup", n => { PfsGroup = n.GetEnumValue<PerfectForwardSecrecyGroup>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AuthenticationTransformConstant>("authenticationTransformConstants", AuthenticationTransformConstants);
            writer.WriteEnumValue<VpnEncryptionAlgorithmType>("cipherTransformConstants", CipherTransformConstants);
            writer.WriteEnumValue<DiffieHellmanGroup>("dhGroup", DhGroup);
            writer.WriteEnumValue<VpnEncryptionAlgorithmType>("encryptionMethod", EncryptionMethod);
            writer.WriteEnumValue<VpnIntegrityAlgorithmType>("integrityCheckMethod", IntegrityCheckMethod);
            writer.WriteEnumValue<PerfectForwardSecrecyGroup>("pfsGroup", PfsGroup);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
