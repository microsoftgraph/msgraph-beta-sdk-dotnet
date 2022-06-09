using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>BitLocker Recovery Options.</summary>
    public class BitLockerRecoveryOptions : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether to block certificate-based data recovery agent.</summary>
        public bool? BlockDataRecoveryAgent {
            get { return BackingStore?.Get<bool?>(nameof(BlockDataRecoveryAgent)); }
            set { BackingStore?.Set(nameof(BlockDataRecoveryAgent), value); }
        }
        /// <summary>Indicates whether or not to enable BitLocker until recovery information is stored in AD DS.</summary>
        public bool? EnableBitLockerAfterRecoveryInformationToStore {
            get { return BackingStore?.Get<bool?>(nameof(EnableBitLockerAfterRecoveryInformationToStore)); }
            set { BackingStore?.Set(nameof(EnableBitLockerAfterRecoveryInformationToStore), value); }
        }
        /// <summary>Indicates whether or not to allow BitLocker recovery information to store in AD DS.</summary>
        public bool? EnableRecoveryInformationSaveToStore {
            get { return BackingStore?.Get<bool?>(nameof(EnableRecoveryInformationSaveToStore)); }
            set { BackingStore?.Set(nameof(EnableRecoveryInformationSaveToStore), value); }
        }
        /// <summary>Indicates whether or not to allow showing recovery options in BitLocker Setup Wizard for fixed or system disk.</summary>
        public bool? HideRecoveryOptions {
            get { return BackingStore?.Get<bool?>(nameof(HideRecoveryOptions)); }
            set { BackingStore?.Set(nameof(HideRecoveryOptions), value); }
        }
        /// <summary>Configure what pieces of BitLocker recovery information are stored to AD DS. Possible values are: passwordAndKey, passwordOnly.</summary>
        public BitLockerRecoveryInformationType? RecoveryInformationToStore {
            get { return BackingStore?.Get<BitLockerRecoveryInformationType?>(nameof(RecoveryInformationToStore)); }
            set { BackingStore?.Set(nameof(RecoveryInformationToStore), value); }
        }
        /// <summary>Indicates whether users are allowed or required to generate a 256-bit recovery key for fixed or system disk. Possible values are: blocked, required, allowed, notConfigured.</summary>
        public ConfigurationUsage? RecoveryKeyUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>(nameof(RecoveryKeyUsage)); }
            set { BackingStore?.Set(nameof(RecoveryKeyUsage), value); }
        }
        /// <summary>Indicates whether users are allowed or required to generate a 48-digit recovery password for fixed or system disk. Possible values are: blocked, required, allowed, notConfigured.</summary>
        public ConfigurationUsage? RecoveryPasswordUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>(nameof(RecoveryPasswordUsage)); }
            set { BackingStore?.Set(nameof(RecoveryPasswordUsage), value); }
        }
        /// <summary>
        /// Instantiates a new bitLockerRecoveryOptions and sets the default values.
        /// </summary>
        public BitLockerRecoveryOptions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BitLockerRecoveryOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BitLockerRecoveryOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"blockDataRecoveryAgent", n => { BlockDataRecoveryAgent = n.GetBoolValue(); } },
                {"enableBitLockerAfterRecoveryInformationToStore", n => { EnableBitLockerAfterRecoveryInformationToStore = n.GetBoolValue(); } },
                {"enableRecoveryInformationSaveToStore", n => { EnableRecoveryInformationSaveToStore = n.GetBoolValue(); } },
                {"hideRecoveryOptions", n => { HideRecoveryOptions = n.GetBoolValue(); } },
                {"recoveryInformationToStore", n => { RecoveryInformationToStore = n.GetEnumValue<BitLockerRecoveryInformationType>(); } },
                {"recoveryKeyUsage", n => { RecoveryKeyUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"recoveryPasswordUsage", n => { RecoveryPasswordUsage = n.GetEnumValue<ConfigurationUsage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("blockDataRecoveryAgent", BlockDataRecoveryAgent);
            writer.WriteBoolValue("enableBitLockerAfterRecoveryInformationToStore", EnableBitLockerAfterRecoveryInformationToStore);
            writer.WriteBoolValue("enableRecoveryInformationSaveToStore", EnableRecoveryInformationSaveToStore);
            writer.WriteBoolValue("hideRecoveryOptions", HideRecoveryOptions);
            writer.WriteEnumValue<BitLockerRecoveryInformationType>("recoveryInformationToStore", RecoveryInformationToStore);
            writer.WriteEnumValue<ConfigurationUsage>("recoveryKeyUsage", RecoveryKeyUsage);
            writer.WriteEnumValue<ConfigurationUsage>("recoveryPasswordUsage", RecoveryPasswordUsage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
