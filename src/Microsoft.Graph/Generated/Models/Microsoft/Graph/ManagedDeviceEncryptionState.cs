using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ManagedDeviceEncryptionState : Entity, IParsable {
        /// <summary>Advanced BitLocker State. Possible values are: success, noUserConsent, osVolumeUnprotected, osVolumeTpmRequired, osVolumeTpmOnlyRequired, osVolumeTpmPinRequired, osVolumeTpmStartupKeyRequired, osVolumeTpmPinStartupKeyRequired, osVolumeEncryptionMethodMismatch, recoveryKeyBackupFailed, fixedDriveNotEncrypted, fixedDriveEncryptionMethodMismatch, loggedOnUserNonAdmin, windowsRecoveryEnvironmentNotConfigured, tpmNotAvailable, tpmNotReady, networkError.</summary>
        public AdvancedBitLockerState? AdvancedBitLockerStates { get; set; }
        /// <summary>Device name</summary>
        public string DeviceName { get; set; }
        /// <summary>Platform of the device. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, blackberry, palm, unknown.</summary>
        public DeviceTypes? DeviceType { get; set; }
        /// <summary>Encryption policy setting state. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? EncryptionPolicySettingState { get; set; }
        /// <summary>Encryption readiness state. Possible values are: notReady, ready.</summary>
        public EncryptionReadinessState? EncryptionReadinessState { get; set; }
        /// <summary>Device encryption state. Possible values are: notEncrypted, encrypted.</summary>
        public EncryptionState? EncryptionState { get; set; }
        /// <summary>FileVault State. Possible values are: success, driveEncryptedByUser, userDeferredEncryption, escrowNotEnabled.</summary>
        public FileVaultState? FileVaultStates { get; set; }
        /// <summary>Operating system version of the device</summary>
        public string OsVersion { get; set; }
        /// <summary>Policy Details</summary>
        public List<EncryptionReportPolicyDetails> PolicyDetails { get; set; }
        /// <summary>Device TPM Version</summary>
        public string TpmSpecificationVersion { get; set; }
        /// <summary>User name</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"advancedBitLockerStates", (o,n) => { (o as ManagedDeviceEncryptionState).AdvancedBitLockerStates = n.GetEnumValue<AdvancedBitLockerState>(); } },
                {"deviceName", (o,n) => { (o as ManagedDeviceEncryptionState).DeviceName = n.GetStringValue(); } },
                {"deviceType", (o,n) => { (o as ManagedDeviceEncryptionState).DeviceType = n.GetEnumValue<DeviceTypes>(); } },
                {"encryptionPolicySettingState", (o,n) => { (o as ManagedDeviceEncryptionState).EncryptionPolicySettingState = n.GetEnumValue<ComplianceStatus>(); } },
                {"encryptionReadinessState", (o,n) => { (o as ManagedDeviceEncryptionState).EncryptionReadinessState = n.GetEnumValue<EncryptionReadinessState>(); } },
                {"encryptionState", (o,n) => { (o as ManagedDeviceEncryptionState).EncryptionState = n.GetEnumValue<EncryptionState>(); } },
                {"fileVaultStates", (o,n) => { (o as ManagedDeviceEncryptionState).FileVaultStates = n.GetEnumValue<FileVaultState>(); } },
                {"osVersion", (o,n) => { (o as ManagedDeviceEncryptionState).OsVersion = n.GetStringValue(); } },
                {"policyDetails", (o,n) => { (o as ManagedDeviceEncryptionState).PolicyDetails = n.GetCollectionOfObjectValues<EncryptionReportPolicyDetails>().ToList(); } },
                {"tpmSpecificationVersion", (o,n) => { (o as ManagedDeviceEncryptionState).TpmSpecificationVersion = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as ManagedDeviceEncryptionState).UserPrincipalName = n.GetStringValue(); } },
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
