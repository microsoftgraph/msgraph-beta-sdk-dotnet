using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>BitLocker Encryption Base Policies.</summary>
    public class BitLockerSystemDrivePolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Select the encryption method for operating system drives. Possible values are: aesCbc128, aesCbc256, xtsAes128, xtsAes256.</summary>
        public BitLockerEncryptionMethod? EncryptionMethod {
            get { return BackingStore?.Get<BitLockerEncryptionMethod?>("encryptionMethod"); }
            set { BackingStore?.Set("encryptionMethod", value); }
        }
        /// <summary>Indicates the minimum length of startup pin. Valid values 4 to 20</summary>
        public int? MinimumPinLength {
            get { return BackingStore?.Get<int?>("minimumPinLength"); }
            set { BackingStore?.Set("minimumPinLength", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Enable pre-boot recovery message and Url. If requireStartupAuthentication is false, this value does not affect.</summary>
        public bool? PrebootRecoveryEnableMessageAndUrl {
            get { return BackingStore?.Get<bool?>("prebootRecoveryEnableMessageAndUrl"); }
            set { BackingStore?.Set("prebootRecoveryEnableMessageAndUrl", value); }
        }
        /// <summary>Defines a custom recovery message.</summary>
        public string PrebootRecoveryMessage {
            get { return BackingStore?.Get<string>("prebootRecoveryMessage"); }
            set { BackingStore?.Set("prebootRecoveryMessage", value); }
        }
        /// <summary>Defines a custom recovery URL.</summary>
        public string PrebootRecoveryUrl {
            get { return BackingStore?.Get<string>("prebootRecoveryUrl"); }
            set { BackingStore?.Set("prebootRecoveryUrl", value); }
        }
        /// <summary>Allows to recover BitLocker encrypted operating system drives in the absence of the required startup key information. This policy setting is applied when you turn on BitLocker.</summary>
        public BitLockerRecoveryOptions RecoveryOptions {
            get { return BackingStore?.Get<BitLockerRecoveryOptions>("recoveryOptions"); }
            set { BackingStore?.Set("recoveryOptions", value); }
        }
        /// <summary>Indicates whether to allow BitLocker without a compatible TPM (requires a password or a startup key on a USB flash drive).</summary>
        public bool? StartupAuthenticationBlockWithoutTpmChip {
            get { return BackingStore?.Get<bool?>("startupAuthenticationBlockWithoutTpmChip"); }
            set { BackingStore?.Set("startupAuthenticationBlockWithoutTpmChip", value); }
        }
        /// <summary>Require additional authentication at startup.</summary>
        public bool? StartupAuthenticationRequired {
            get { return BackingStore?.Get<bool?>("startupAuthenticationRequired"); }
            set { BackingStore?.Set("startupAuthenticationRequired", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public ConfigurationUsage? StartupAuthenticationTpmKeyUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>("startupAuthenticationTpmKeyUsage"); }
            set { BackingStore?.Set("startupAuthenticationTpmKeyUsage", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public ConfigurationUsage? StartupAuthenticationTpmPinAndKeyUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>("startupAuthenticationTpmPinAndKeyUsage"); }
            set { BackingStore?.Set("startupAuthenticationTpmPinAndKeyUsage", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public ConfigurationUsage? StartupAuthenticationTpmPinUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>("startupAuthenticationTpmPinUsage"); }
            set { BackingStore?.Set("startupAuthenticationTpmPinUsage", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public ConfigurationUsage? StartupAuthenticationTpmUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>("startupAuthenticationTpmUsage"); }
            set { BackingStore?.Set("startupAuthenticationTpmUsage", value); }
        }
        /// <summary>
        /// Instantiates a new bitLockerSystemDrivePolicy and sets the default values.
        /// </summary>
        public BitLockerSystemDrivePolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.bitLockerSystemDrivePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BitLockerSystemDrivePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BitLockerSystemDrivePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"encryptionMethod", n => { EncryptionMethod = n.GetEnumValue<BitLockerEncryptionMethod>(); } },
                {"minimumPinLength", n => { MinimumPinLength = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"prebootRecoveryEnableMessageAndUrl", n => { PrebootRecoveryEnableMessageAndUrl = n.GetBoolValue(); } },
                {"prebootRecoveryMessage", n => { PrebootRecoveryMessage = n.GetStringValue(); } },
                {"prebootRecoveryUrl", n => { PrebootRecoveryUrl = n.GetStringValue(); } },
                {"recoveryOptions", n => { RecoveryOptions = n.GetObjectValue<BitLockerRecoveryOptions>(BitLockerRecoveryOptions.CreateFromDiscriminatorValue); } },
                {"startupAuthenticationBlockWithoutTpmChip", n => { StartupAuthenticationBlockWithoutTpmChip = n.GetBoolValue(); } },
                {"startupAuthenticationRequired", n => { StartupAuthenticationRequired = n.GetBoolValue(); } },
                {"startupAuthenticationTpmKeyUsage", n => { StartupAuthenticationTpmKeyUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"startupAuthenticationTpmPinAndKeyUsage", n => { StartupAuthenticationTpmPinAndKeyUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"startupAuthenticationTpmPinUsage", n => { StartupAuthenticationTpmPinUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"startupAuthenticationTpmUsage", n => { StartupAuthenticationTpmUsage = n.GetEnumValue<ConfigurationUsage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BitLockerEncryptionMethod>("encryptionMethod", EncryptionMethod);
            writer.WriteIntValue("minimumPinLength", MinimumPinLength);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("prebootRecoveryEnableMessageAndUrl", PrebootRecoveryEnableMessageAndUrl);
            writer.WriteStringValue("prebootRecoveryMessage", PrebootRecoveryMessage);
            writer.WriteStringValue("prebootRecoveryUrl", PrebootRecoveryUrl);
            writer.WriteObjectValue<BitLockerRecoveryOptions>("recoveryOptions", RecoveryOptions);
            writer.WriteBoolValue("startupAuthenticationBlockWithoutTpmChip", StartupAuthenticationBlockWithoutTpmChip);
            writer.WriteBoolValue("startupAuthenticationRequired", StartupAuthenticationRequired);
            writer.WriteEnumValue<ConfigurationUsage>("startupAuthenticationTpmKeyUsage", StartupAuthenticationTpmKeyUsage);
            writer.WriteEnumValue<ConfigurationUsage>("startupAuthenticationTpmPinAndKeyUsage", StartupAuthenticationTpmPinAndKeyUsage);
            writer.WriteEnumValue<ConfigurationUsage>("startupAuthenticationTpmPinUsage", StartupAuthenticationTpmPinUsage);
            writer.WriteEnumValue<ConfigurationUsage>("startupAuthenticationTpmUsage", StartupAuthenticationTpmUsage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
