using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Encryption report per device</summary>
    public class ManagedDeviceEncryptionState : Entity, IParsable {
        /// <summary>Advanced BitLocker State. Possible values are: success, noUserConsent, osVolumeUnprotected, osVolumeTpmRequired, osVolumeTpmOnlyRequired, osVolumeTpmPinRequired, osVolumeTpmStartupKeyRequired, osVolumeTpmPinStartupKeyRequired, osVolumeEncryptionMethodMismatch, recoveryKeyBackupFailed, fixedDriveNotEncrypted, fixedDriveEncryptionMethodMismatch, loggedOnUserNonAdmin, windowsRecoveryEnvironmentNotConfigured, tpmNotAvailable, tpmNotReady, networkError.</summary>
        public AdvancedBitLockerState? AdvancedBitLockerStates {
            get { return BackingStore?.Get<AdvancedBitLockerState?>(nameof(AdvancedBitLockerStates)); }
            set { BackingStore?.Set(nameof(AdvancedBitLockerStates), value); }
        }
        /// <summary>Device name</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>Platform of the device. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, blackberry, palm, unknown.</summary>
        public DeviceTypes? DeviceType {
            get { return BackingStore?.Get<DeviceTypes?>(nameof(DeviceType)); }
            set { BackingStore?.Set(nameof(DeviceType), value); }
        }
        /// <summary>Encryption policy setting state. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? EncryptionPolicySettingState {
            get { return BackingStore?.Get<ComplianceStatus?>(nameof(EncryptionPolicySettingState)); }
            set { BackingStore?.Set(nameof(EncryptionPolicySettingState), value); }
        }
        /// <summary>Encryption readiness state. Possible values are: notReady, ready.</summary>
        public Microsoft.Graph.Beta.Models.EncryptionReadinessState? EncryptionReadinessState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EncryptionReadinessState?>(nameof(EncryptionReadinessState)); }
            set { BackingStore?.Set(nameof(EncryptionReadinessState), value); }
        }
        /// <summary>Device encryption state. Possible values are: notEncrypted, encrypted.</summary>
        public Microsoft.Graph.Beta.Models.EncryptionState? EncryptionState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EncryptionState?>(nameof(EncryptionState)); }
            set { BackingStore?.Set(nameof(EncryptionState), value); }
        }
        /// <summary>FileVault State. Possible values are: success, driveEncryptedByUser, userDeferredEncryption, escrowNotEnabled.</summary>
        public FileVaultState? FileVaultStates {
            get { return BackingStore?.Get<FileVaultState?>(nameof(FileVaultStates)); }
            set { BackingStore?.Set(nameof(FileVaultStates), value); }
        }
        /// <summary>Operating system version of the device</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>Policy Details</summary>
        public List<EncryptionReportPolicyDetails> PolicyDetails {
            get { return BackingStore?.Get<List<EncryptionReportPolicyDetails>>(nameof(PolicyDetails)); }
            set { BackingStore?.Set(nameof(PolicyDetails), value); }
        }
        /// <summary>Device TPM Version</summary>
        public string TpmSpecificationVersion {
            get { return BackingStore?.Get<string>(nameof(TpmSpecificationVersion)); }
            set { BackingStore?.Set(nameof(TpmSpecificationVersion), value); }
        }
        /// <summary>User name</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDeviceEncryptionState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceEncryptionState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedBitLockerStates", n => { AdvancedBitLockerStates = n.GetEnumValue<AdvancedBitLockerState>(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<DeviceTypes>(); } },
                {"encryptionPolicySettingState", n => { EncryptionPolicySettingState = n.GetEnumValue<ComplianceStatus>(); } },
                {"encryptionReadinessState", n => { EncryptionReadinessState = n.GetEnumValue<EncryptionReadinessState>(); } },
                {"encryptionState", n => { EncryptionState = n.GetEnumValue<EncryptionState>(); } },
                {"fileVaultStates", n => { FileVaultStates = n.GetEnumValue<FileVaultState>(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"policyDetails", n => { PolicyDetails = n.GetCollectionOfObjectValues<EncryptionReportPolicyDetails>(EncryptionReportPolicyDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"tpmSpecificationVersion", n => { TpmSpecificationVersion = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AdvancedBitLockerState>("advancedBitLockerStates", AdvancedBitLockerStates);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DeviceTypes>("deviceType", DeviceType);
            writer.WriteEnumValue<ComplianceStatus>("encryptionPolicySettingState", EncryptionPolicySettingState);
            writer.WriteEnumValue<EncryptionReadinessState>("encryptionReadinessState", EncryptionReadinessState);
            writer.WriteEnumValue<EncryptionState>("encryptionState", EncryptionState);
            writer.WriteEnumValue<FileVaultState>("fileVaultStates", FileVaultStates);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteCollectionOfObjectValues<EncryptionReportPolicyDetails>("policyDetails", PolicyDetails);
            writer.WriteStringValue("tpmSpecificationVersion", TpmSpecificationVersion);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
