using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>MDATP Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>(nameof(AdvancedThreatProtectionRequiredSecurityLevel)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionRequiredSecurityLevel), value); }
        }
        /// <summary>Condition statement id.</summary>
        public string ConditionStatementId {
            get { return BackingStore?.Get<string>(nameof(ConditionStatementId)); }
            set { BackingStore?.Set(nameof(ConditionStatementId), value); }
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
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 1 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>Require a password to unlock device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequired)); }
            set { BackingStore?.Set(nameof(PasswordRequired), value); }
        }
        /// <summary>Type of characters in password. Possible values are: deviceDefault, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, numeric, numericComplex, any.</summary>
        public AndroidRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidRequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Number of sign-in failures allowed before factory reset. Valid values 1 to 16</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(PasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(PasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>Indicates the required password complexity on Android. One of: NONE, LOW, MEDIUM, HIGH. This is a new API targeted to Android 11+. Possible values are: none, low, medium, high.</summary>
        public AndroidRequiredPasswordComplexity? RequiredPasswordComplexity {
            get { return BackingStore?.Get<AndroidRequiredPasswordComplexity?>(nameof(RequiredPasswordComplexity)); }
            set { BackingStore?.Set(nameof(RequiredPasswordComplexity), value); }
        }
        /// <summary>Require the device to not have the specified apps installed. This collection can contain a maximum of 100 elements.</summary>
        public List<AppListItem> RestrictedApps {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(RestrictedApps)); }
            set { BackingStore?.Set(nameof(RestrictedApps), value); }
        }
        /// <summary>Block device administrator managed devices.</summary>
        public bool? SecurityBlockDeviceAdministratorManagedDevices {
            get { return BackingStore?.Get<bool?>(nameof(SecurityBlockDeviceAdministratorManagedDevices)); }
            set { BackingStore?.Set(nameof(SecurityBlockDeviceAdministratorManagedDevices), value); }
        }
        /// <summary>Devices must not be jailbroken or rooted.</summary>
        public bool? SecurityBlockJailbrokenDevices {
            get { return BackingStore?.Get<bool?>(nameof(SecurityBlockJailbrokenDevices)); }
            set { BackingStore?.Set(nameof(SecurityBlockJailbrokenDevices), value); }
        }
        /// <summary>Disable USB debugging on Android devices.</summary>
        public bool? SecurityDisableUsbDebugging {
            get { return BackingStore?.Get<bool?>(nameof(SecurityDisableUsbDebugging)); }
            set { BackingStore?.Set(nameof(SecurityDisableUsbDebugging), value); }
        }
        /// <summary>Require that devices disallow installation of apps from unknown sources.</summary>
        public bool? SecurityPreventInstallAppsFromUnknownSources {
            get { return BackingStore?.Get<bool?>(nameof(SecurityPreventInstallAppsFromUnknownSources)); }
            set { BackingStore?.Set(nameof(SecurityPreventInstallAppsFromUnknownSources), value); }
        }
        /// <summary>Require the device to pass the Company Portal client app runtime integrity check.</summary>
        public bool? SecurityRequireCompanyPortalAppIntegrity {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireCompanyPortalAppIntegrity)); }
            set { BackingStore?.Set(nameof(SecurityRequireCompanyPortalAppIntegrity), value); }
        }
        /// <summary>Require Google Play Services to be installed and enabled on the device.</summary>
        public bool? SecurityRequireGooglePlayServices {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireGooglePlayServices)); }
            set { BackingStore?.Set(nameof(SecurityRequireGooglePlayServices), value); }
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
        /// <summary>Require the device to have up to date security providers. The device will require Google Play Services to be enabled and up to date.</summary>
        public bool? SecurityRequireUpToDateSecurityProviders {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireUpToDateSecurityProviders)); }
            set { BackingStore?.Set(nameof(SecurityRequireUpToDateSecurityProviders), value); }
        }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireVerifyApps)); }
            set { BackingStore?.Set(nameof(SecurityRequireVerifyApps), value); }
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
        public static new AndroidCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedThreatProtectionRequiredSecurityLevel", n => { AdvancedThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"conditionStatementId", n => { ConditionStatementId = n.GetStringValue(); } },
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"minAndroidSecurityPatchLevel", n => { MinAndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidRequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"requiredPasswordComplexity", n => { RequiredPasswordComplexity = n.GetEnumValue<AndroidRequiredPasswordComplexity>(); } },
                {"restrictedApps", n => { RestrictedApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"securityBlockDeviceAdministratorManagedDevices", n => { SecurityBlockDeviceAdministratorManagedDevices = n.GetBoolValue(); } },
                {"securityBlockJailbrokenDevices", n => { SecurityBlockJailbrokenDevices = n.GetBoolValue(); } },
                {"securityDisableUsbDebugging", n => { SecurityDisableUsbDebugging = n.GetBoolValue(); } },
                {"securityPreventInstallAppsFromUnknownSources", n => { SecurityPreventInstallAppsFromUnknownSources = n.GetBoolValue(); } },
                {"securityRequireCompanyPortalAppIntegrity", n => { SecurityRequireCompanyPortalAppIntegrity = n.GetBoolValue(); } },
                {"securityRequireGooglePlayServices", n => { SecurityRequireGooglePlayServices = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationBasicIntegrity", n => { SecurityRequireSafetyNetAttestationBasicIntegrity = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationCertifiedDevice", n => { SecurityRequireSafetyNetAttestationCertifiedDevice = n.GetBoolValue(); } },
                {"securityRequireUpToDateSecurityProviders", n => { SecurityRequireUpToDateSecurityProviders = n.GetBoolValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
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
            writer.WriteStringValue("conditionStatementId", ConditionStatementId);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteStringValue("minAndroidSecurityPatchLevel", MinAndroidSecurityPatchLevel);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteEnumValue<AndroidRequiredPasswordComplexity>("requiredPasswordComplexity", RequiredPasswordComplexity);
            writer.WriteCollectionOfObjectValues<AppListItem>("restrictedApps", RestrictedApps);
            writer.WriteBoolValue("securityBlockDeviceAdministratorManagedDevices", SecurityBlockDeviceAdministratorManagedDevices);
            writer.WriteBoolValue("securityBlockJailbrokenDevices", SecurityBlockJailbrokenDevices);
            writer.WriteBoolValue("securityDisableUsbDebugging", SecurityDisableUsbDebugging);
            writer.WriteBoolValue("securityPreventInstallAppsFromUnknownSources", SecurityPreventInstallAppsFromUnknownSources);
            writer.WriteBoolValue("securityRequireCompanyPortalAppIntegrity", SecurityRequireCompanyPortalAppIntegrity);
            writer.WriteBoolValue("securityRequireGooglePlayServices", SecurityRequireGooglePlayServices);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationBasicIntegrity", SecurityRequireSafetyNetAttestationBasicIntegrity);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationCertifiedDevice", SecurityRequireSafetyNetAttestationCertifiedDevice);
            writer.WriteBoolValue("securityRequireUpToDateSecurityProviders", SecurityRequireUpToDateSecurityProviders);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}
