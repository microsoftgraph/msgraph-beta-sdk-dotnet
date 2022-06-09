using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10CompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Require active firewall on Windows devices.</summary>
        public bool? ActiveFirewallRequired {
            get { return BackingStore?.Get<bool?>(nameof(ActiveFirewallRequired)); }
            set { BackingStore?.Set(nameof(ActiveFirewallRequired), value); }
        }
        /// <summary>Require any AntiSpyware solution registered with Windows Decurity Center to be on and monitoring (e.g. Symantec, Windows Defender).</summary>
        public bool? AntiSpywareRequired {
            get { return BackingStore?.Get<bool?>(nameof(AntiSpywareRequired)); }
            set { BackingStore?.Set(nameof(AntiSpywareRequired), value); }
        }
        /// <summary>Require any Antivirus solution registered with Windows Decurity Center to be on and monitoring (e.g. Symantec, Windows Defender).</summary>
        public bool? AntivirusRequired {
            get { return BackingStore?.Get<bool?>(nameof(AntivirusRequired)); }
            set { BackingStore?.Set(nameof(AntivirusRequired), value); }
        }
        /// <summary>Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled</summary>
        public bool? BitLockerEnabled {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerEnabled)); }
            set { BackingStore?.Set(nameof(BitLockerEnabled), value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? CodeIntegrityEnabled {
            get { return BackingStore?.Get<bool?>(nameof(CodeIntegrityEnabled)); }
            set { BackingStore?.Set(nameof(CodeIntegrityEnabled), value); }
        }
        /// <summary>Require to consider SCCM Compliance state into consideration for Intune Compliance State.</summary>
        public bool? ConfigurationManagerComplianceRequired {
            get { return BackingStore?.Get<bool?>(nameof(ConfigurationManagerComplianceRequired)); }
            set { BackingStore?.Set(nameof(ConfigurationManagerComplianceRequired), value); }
        }
        /// <summary>Require Windows Defender Antimalware on Windows devices.</summary>
        public bool? DefenderEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DefenderEnabled)); }
            set { BackingStore?.Set(nameof(DefenderEnabled), value); }
        }
        /// <summary>Require Windows Defender Antimalware minimum version on Windows devices.</summary>
        public string DefenderVersion {
            get { return BackingStore?.Get<string>(nameof(DefenderVersion)); }
            set { BackingStore?.Set(nameof(DefenderVersion), value); }
        }
        /// <summary>Not yet documented</summary>
        public Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript DeviceCompliancePolicyScript {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript>(nameof(DeviceCompliancePolicyScript)); }
            set { BackingStore?.Set(nameof(DeviceCompliancePolicyScript), value); }
        }
        /// <summary>Require that devices have enabled device threat protection.</summary>
        public bool? DeviceThreatProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DeviceThreatProtectionEnabled)); }
            set { BackingStore?.Set(nameof(DeviceThreatProtectionEnabled), value); }
        }
        /// <summary>Require Device Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>(nameof(DeviceThreatProtectionRequiredSecurityLevel)); }
            set { BackingStore?.Set(nameof(DeviceThreatProtectionRequiredSecurityLevel), value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.</summary>
        public bool? EarlyLaunchAntiMalwareDriverEnabled {
            get { return BackingStore?.Get<bool?>(nameof(EarlyLaunchAntiMalwareDriverEnabled)); }
            set { BackingStore?.Set(nameof(EarlyLaunchAntiMalwareDriverEnabled), value); }
        }
        /// <summary>Maximum Windows Phone version.</summary>
        public string MobileOsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(MobileOsMaximumVersion)); }
            set { BackingStore?.Set(nameof(MobileOsMaximumVersion), value); }
        }
        /// <summary>Minimum Windows Phone version.</summary>
        public string MobileOsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(MobileOsMinimumVersion)); }
            set { BackingStore?.Set(nameof(MobileOsMinimumVersion), value); }
        }
        /// <summary>Maximum Windows 10 version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumVersion), value); }
        }
        /// <summary>Minimum Windows 10 version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumVersion), value); }
        }
        /// <summary>Indicates whether or not to block simple password.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockSimple)); }
            set { BackingStore?.Set(nameof(PasswordBlockSimple), value); }
        }
        /// <summary>The password expiration in days.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumCharacterSetCount)); }
            set { BackingStore?.Set(nameof(PasswordMinimumCharacterSetCount), value); }
        }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>The number of previous passwords to prevent re-use of.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>Require a password to unlock Windows device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequired)); }
            set { BackingStore?.Set(nameof(PasswordRequired), value); }
        }
        /// <summary>Require a password to unlock an idle device.</summary>
        public bool? PasswordRequiredToUnlockFromIdle {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequiredToUnlockFromIdle)); }
            set { BackingStore?.Set(nameof(PasswordRequiredToUnlockFromIdle), value); }
        }
        /// <summary>The required password type. Possible values are: deviceDefault, alphanumeric, numeric.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? RequireHealthyDeviceReport {
            get { return BackingStore?.Get<bool?>(nameof(RequireHealthyDeviceReport)); }
            set { BackingStore?.Set(nameof(RequireHealthyDeviceReport), value); }
        }
        /// <summary>Require Windows Defender Antimalware Real-Time Protection on Windows devices.</summary>
        public bool? RtpEnabled {
            get { return BackingStore?.Get<bool?>(nameof(RtpEnabled)); }
            set { BackingStore?.Set(nameof(RtpEnabled), value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.</summary>
        public bool? SecureBootEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SecureBootEnabled)); }
            set { BackingStore?.Set(nameof(SecureBootEnabled), value); }
        }
        /// <summary>Require Windows Defender Antimalware Signature to be up to date on Windows devices.</summary>
        public bool? SignatureOutOfDate {
            get { return BackingStore?.Get<bool?>(nameof(SignatureOutOfDate)); }
            set { BackingStore?.Set(nameof(SignatureOutOfDate), value); }
        }
        /// <summary>Require encryption on windows devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireEncryption), value); }
        }
        /// <summary>Require Trusted Platform Module(TPM) to be present.</summary>
        public bool? TpmRequired {
            get { return BackingStore?.Get<bool?>(nameof(TpmRequired)); }
            set { BackingStore?.Set(nameof(TpmRequired), value); }
        }
        /// <summary>The valid operating system build ranges on Windows devices. This collection can contain a maximum of 10000 elements.</summary>
        public List<OperatingSystemVersionRange> ValidOperatingSystemBuildRanges {
            get { return BackingStore?.Get<List<OperatingSystemVersionRange>>(nameof(ValidOperatingSystemBuildRanges)); }
            set { BackingStore?.Set(nameof(ValidOperatingSystemBuildRanges), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10CompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10CompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeFirewallRequired", n => { ActiveFirewallRequired = n.GetBoolValue(); } },
                {"antiSpywareRequired", n => { AntiSpywareRequired = n.GetBoolValue(); } },
                {"antivirusRequired", n => { AntivirusRequired = n.GetBoolValue(); } },
                {"bitLockerEnabled", n => { BitLockerEnabled = n.GetBoolValue(); } },
                {"codeIntegrityEnabled", n => { CodeIntegrityEnabled = n.GetBoolValue(); } },
                {"configurationManagerComplianceRequired", n => { ConfigurationManagerComplianceRequired = n.GetBoolValue(); } },
                {"defenderEnabled", n => { DefenderEnabled = n.GetBoolValue(); } },
                {"defenderVersion", n => { DefenderVersion = n.GetStringValue(); } },
                {"deviceCompliancePolicyScript", n => { DeviceCompliancePolicyScript = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript>(Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript.CreateFromDiscriminatorValue); } },
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"earlyLaunchAntiMalwareDriverEnabled", n => { EarlyLaunchAntiMalwareDriverEnabled = n.GetBoolValue(); } },
                {"mobileOsMaximumVersion", n => { MobileOsMaximumVersion = n.GetStringValue(); } },
                {"mobileOsMinimumVersion", n => { MobileOsMinimumVersion = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredToUnlockFromIdle", n => { PasswordRequiredToUnlockFromIdle = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"requireHealthyDeviceReport", n => { RequireHealthyDeviceReport = n.GetBoolValue(); } },
                {"rtpEnabled", n => { RtpEnabled = n.GetBoolValue(); } },
                {"secureBootEnabled", n => { SecureBootEnabled = n.GetBoolValue(); } },
                {"signatureOutOfDate", n => { SignatureOutOfDate = n.GetBoolValue(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
                {"tpmRequired", n => { TpmRequired = n.GetBoolValue(); } },
                {"validOperatingSystemBuildRanges", n => { ValidOperatingSystemBuildRanges = n.GetCollectionOfObjectValues<OperatingSystemVersionRange>(OperatingSystemVersionRange.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("activeFirewallRequired", ActiveFirewallRequired);
            writer.WriteBoolValue("antiSpywareRequired", AntiSpywareRequired);
            writer.WriteBoolValue("antivirusRequired", AntivirusRequired);
            writer.WriteBoolValue("bitLockerEnabled", BitLockerEnabled);
            writer.WriteBoolValue("codeIntegrityEnabled", CodeIntegrityEnabled);
            writer.WriteBoolValue("configurationManagerComplianceRequired", ConfigurationManagerComplianceRequired);
            writer.WriteBoolValue("defenderEnabled", DefenderEnabled);
            writer.WriteStringValue("defenderVersion", DefenderVersion);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript>("deviceCompliancePolicyScript", DeviceCompliancePolicyScript);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("earlyLaunchAntiMalwareDriverEnabled", EarlyLaunchAntiMalwareDriverEnabled);
            writer.WriteStringValue("mobileOsMaximumVersion", MobileOsMaximumVersion);
            writer.WriteStringValue("mobileOsMinimumVersion", MobileOsMinimumVersion);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteBoolValue("passwordRequiredToUnlockFromIdle", PasswordRequiredToUnlockFromIdle);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("requireHealthyDeviceReport", RequireHealthyDeviceReport);
            writer.WriteBoolValue("rtpEnabled", RtpEnabled);
            writer.WriteBoolValue("secureBootEnabled", SecureBootEnabled);
            writer.WriteBoolValue("signatureOutOfDate", SignatureOutOfDate);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
            writer.WriteBoolValue("tpmRequired", TpmRequired);
            writer.WriteCollectionOfObjectValues<OperatingSystemVersionRange>("validOperatingSystemBuildRanges", ValidOperatingSystemBuildRanges);
        }
    }
}
