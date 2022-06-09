using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>MDATP Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>(nameof(AdvancedThreatProtectionRequiredSecurityLevel)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionRequiredSecurityLevel), value); }
        }
        /// <summary>Require that devices have enabled device threat protection.</summary>
        public bool? DeviceThreatProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DeviceThreatProtectionEnabled)); }
            set { BackingStore?.Set(nameof(DeviceThreatProtectionEnabled), value); }
        }
        /// <summary>Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>(nameof(DeviceThreatProtectionRequiredSecurityLevel)); }
            set { BackingStore?.Set(nameof(DeviceThreatProtectionRequiredSecurityLevel), value); }
        }
        /// <summary>Minimum Android security patch level.</summary>
        public string MinAndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string>(nameof(MinAndroidSecurityPatchLevel)); }
            set { BackingStore?.Set(nameof(MinAndroidSecurityPatchLevel), value); }
        }
        /// <summary>Maximum Android version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumVersion), value); }
        }
        /// <summary>Minimum Android version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumVersion), value); }
        }
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>Minimum password length. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Indicates the minimum number of letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumLetterCharacters {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLetterCharacters)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLetterCharacters), value); }
        }
        /// <summary>Indicates the minimum number of lower case characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumLowerCaseCharacters {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLowerCaseCharacters)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLowerCaseCharacters), value); }
        }
        /// <summary>Indicates the minimum number of non-letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumNonLetterCharacters {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumNonLetterCharacters)); }
            set { BackingStore?.Set(nameof(PasswordMinimumNonLetterCharacters), value); }
        }
        /// <summary>Indicates the minimum number of numeric characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumNumericCharacters {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumNumericCharacters)); }
            set { BackingStore?.Set(nameof(PasswordMinimumNumericCharacters), value); }
        }
        /// <summary>Indicates the minimum number of symbol characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumSymbolCharacters {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumSymbolCharacters)); }
            set { BackingStore?.Set(nameof(PasswordMinimumSymbolCharacters), value); }
        }
        /// <summary>Indicates the minimum number of upper case letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumUpperCaseCharacters {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumUpperCaseCharacters)); }
            set { BackingStore?.Set(nameof(PasswordMinimumUpperCaseCharacters), value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 1 to 24</summary>
        public int? PasswordPreviousPasswordCountToBlock {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordCountToBlock)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordCountToBlock), value); }
        }
        /// <summary>Require a password to unlock device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequired)); }
            set { BackingStore?.Set(nameof(PasswordRequired), value); }
        }
        /// <summary>Type of characters in password. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>If setting is set to true, checks that the Intune app installed on fully managed, dedicated, or corporate-owned work profile Android Enterprise enrolled devices, is the one provided by Microsoft from the Managed Google Playstore. If the check fails, the device will be reported as non-compliant.</summary>
        public bool? SecurityRequireIntuneAppIntegrity {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireIntuneAppIntegrity)); }
            set { BackingStore?.Set(nameof(SecurityRequireIntuneAppIntegrity), value); }
        }
        /// <summary>Require the device to pass the SafetyNet basic integrity check.</summary>
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireSafetyNetAttestationBasicIntegrity)); }
            set { BackingStore?.Set(nameof(SecurityRequireSafetyNetAttestationBasicIntegrity), value); }
        }
        /// <summary>Require the device to pass the SafetyNet certified device check.</summary>
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireSafetyNetAttestationCertifiedDevice)); }
            set { BackingStore?.Set(nameof(SecurityRequireSafetyNetAttestationCertifiedDevice), value); }
        }
        /// <summary>Require encryption on Android devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireEncryption), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceOwnerCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedThreatProtectionRequiredSecurityLevel", n => { AdvancedThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"minAndroidSecurityPatchLevel", n => { MinAndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinimumLetterCharacters", n => { PasswordMinimumLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumLowerCaseCharacters", n => { PasswordMinimumLowerCaseCharacters = n.GetIntValue(); } },
                {"passwordMinimumNonLetterCharacters", n => { PasswordMinimumNonLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumNumericCharacters", n => { PasswordMinimumNumericCharacters = n.GetIntValue(); } },
                {"passwordMinimumSymbolCharacters", n => { PasswordMinimumSymbolCharacters = n.GetIntValue(); } },
                {"passwordMinimumUpperCaseCharacters", n => { PasswordMinimumUpperCaseCharacters = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordCountToBlock", n => { PasswordPreviousPasswordCountToBlock = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"securityRequireIntuneAppIntegrity", n => { SecurityRequireIntuneAppIntegrity = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationBasicIntegrity", n => { SecurityRequireSafetyNetAttestationBasicIntegrity = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationCertifiedDevice", n => { SecurityRequireSafetyNetAttestationCertifiedDevice = n.GetBoolValue(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("advancedThreatProtectionRequiredSecurityLevel", AdvancedThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteStringValue("minAndroidSecurityPatchLevel", MinAndroidSecurityPatchLevel);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinimumLetterCharacters", PasswordMinimumLetterCharacters);
            writer.WriteIntValue("passwordMinimumLowerCaseCharacters", PasswordMinimumLowerCaseCharacters);
            writer.WriteIntValue("passwordMinimumNonLetterCharacters", PasswordMinimumNonLetterCharacters);
            writer.WriteIntValue("passwordMinimumNumericCharacters", PasswordMinimumNumericCharacters);
            writer.WriteIntValue("passwordMinimumSymbolCharacters", PasswordMinimumSymbolCharacters);
            writer.WriteIntValue("passwordMinimumUpperCaseCharacters", PasswordMinimumUpperCaseCharacters);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordCountToBlock", PasswordPreviousPasswordCountToBlock);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("securityRequireIntuneAppIntegrity", SecurityRequireIntuneAppIntegrity);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationBasicIntegrity", SecurityRequireSafetyNetAttestationBasicIntegrity);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationCertifiedDevice", SecurityRequireSafetyNetAttestationCertifiedDevice);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}
