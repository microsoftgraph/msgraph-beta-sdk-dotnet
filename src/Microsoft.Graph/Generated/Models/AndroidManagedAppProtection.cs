using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work.</summary>
        public string AllowedAndroidDeviceManufacturers {
            get { return BackingStore?.Get<string>("allowedAndroidDeviceManufacturers"); }
            set { BackingStore?.Set("allowedAndroidDeviceManufacturers", value); }
        }
        /// <summary>List of device models allowed, as a string, for the managed app to work.</summary>
        public List<string> AllowedAndroidDeviceModels {
            get { return BackingStore?.Get<List<string>>("allowedAndroidDeviceModels"); }
            set { BackingStore?.Set("allowedAndroidDeviceModels", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAndroidDeviceManufacturerNotAllowed"); }
            set { BackingStore?.Set("appActionIfAndroidDeviceManufacturerNotAllowed", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceModelNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAndroidDeviceModelNotAllowed"); }
            set { BackingStore?.Set("appActionIfAndroidDeviceModelNotAllowed", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAndroidSafetyNetAppsVerificationFailed"); }
            set { BackingStore?.Set("appActionIfAndroidSafetyNetAppsVerificationFailed", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAndroidSafetyNetDeviceAttestationFailed"); }
            set { BackingStore?.Set("appActionIfAndroidSafetyNetDeviceAttestationFailed", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceLockNotSet {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDeviceLockNotSet"); }
            set { BackingStore?.Set("appActionIfDeviceLockNotSet", value); }
        }
        /// <summary>If the device does not have a passcode of high complexity or higher, trigger the stored action.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanHigh {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDevicePasscodeComplexityLessThanHigh"); }
            set { BackingStore?.Set("appActionIfDevicePasscodeComplexityLessThanHigh", value); }
        }
        /// <summary>If the device does not have a passcode of low complexity or higher, trigger the stored action.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanLow {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDevicePasscodeComplexityLessThanLow"); }
            set { BackingStore?.Set("appActionIfDevicePasscodeComplexityLessThanLow", value); }
        }
        /// <summary>If the device does not have a passcode of medium complexity or higher, trigger the stored action.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanMedium {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDevicePasscodeComplexityLessThanMedium"); }
            set { BackingStore?.Set("appActionIfDevicePasscodeComplexityLessThanMedium", value); }
        }
        /// <summary>If Keyboard Restriction is enabled, only keyboards in this approved list will be allowed. A key should be Android package id for a keyboard and value should be a friendly name</summary>
        public List<KeyValuePair> ApprovedKeyboards {
            get { return BackingStore?.Get<List<KeyValuePair>>("approvedKeyboards"); }
            set { BackingStore?.Set("approvedKeyboards", value); }
        }
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
        /// <summary>Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? BiometricAuthenticationBlocked {
            get { return BackingStore?.Get<bool?>("biometricAuthenticationBlocked"); }
            set { BackingStore?.Set("biometricAuthenticationBlocked", value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.</summary>
        public int? BlockAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>("blockAfterCompanyPortalUpdateDeferralInDays"); }
            set { BackingStore?.Set("blockAfterCompanyPortalUpdateDeferralInDays", value); }
        }
        /// <summary>Whether the app should connect to the configured VPN on launch.</summary>
        public bool? ConnectToVpnOnLaunch {
            get { return BackingStore?.Get<bool?>("connectToVpnOnLaunch"); }
            set { BackingStore?.Set("connectToVpnOnLaunch", value); }
        }
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android.</summary>
        public string CustomBrowserDisplayName {
            get { return BackingStore?.Get<string>("customBrowserDisplayName"); }
            set { BackingStore?.Set("customBrowserDisplayName", value); }
        }
        /// <summary>Unique identifier of a custom browser to open weblink on Android.</summary>
        public string CustomBrowserPackageId {
            get { return BackingStore?.Get<string>("customBrowserPackageId"); }
            set { BackingStore?.Set("customBrowserPackageId", value); }
        }
        /// <summary>Friendly name of a custom dialer app to click-to-open a phone number on Android.</summary>
        public string CustomDialerAppDisplayName {
            get { return BackingStore?.Get<string>("customDialerAppDisplayName"); }
            set { BackingStore?.Set("customDialerAppDisplayName", value); }
        }
        /// <summary>PackageId of a custom dialer app to click-to-open a phone number on Android.</summary>
        public string CustomDialerAppPackageId {
            get { return BackingStore?.Get<string>("customDialerAppPackageId"); }
            set { BackingStore?.Set("customDialerAppPackageId", value); }
        }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount {
            get { return BackingStore?.Get<int?>("deployedAppCount"); }
            set { BackingStore?.Set("deployedAppCount", value); }
        }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary {
            get { return BackingStore?.Get<ManagedAppPolicyDeploymentSummary>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
        /// <summary>Defines if any kind of lock must be required on android device</summary>
        public bool? DeviceLockRequired {
            get { return BackingStore?.Get<bool?>("deviceLockRequired"); }
            set { BackingStore?.Set("deviceLockRequired", value); }
        }
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled {
            get { return BackingStore?.Get<bool?>("disableAppEncryptionIfDeviceEncryptionIsEnabled"); }
            set { BackingStore?.Set("disableAppEncryptionIfDeviceEncryptionIsEnabled", value); }
        }
        /// <summary>Indicates whether application data for managed apps should be encrypted</summary>
        public bool? EncryptAppData {
            get { return BackingStore?.Get<bool?>("encryptAppData"); }
            set { BackingStore?.Set("encryptAppData", value); }
        }
        /// <summary>App packages in this list will be exempt from the policy and will be able to receive data from managed apps.</summary>
        public List<KeyValuePair> ExemptedAppPackages {
            get { return BackingStore?.Get<List<KeyValuePair>>("exemptedAppPackages"); }
            set { BackingStore?.Set("exemptedAppPackages", value); }
        }
        /// <summary>If null, this setting will be ignored. If false both fingerprints and biometrics will not be enabled. If true, both fingerprints and biometrics will be enabled.</summary>
        public bool? FingerprintAndBiometricEnabled {
            get { return BackingStore?.Get<bool?>("fingerprintAndBiometricEnabled"); }
            set { BackingStore?.Set("fingerprintAndBiometricEnabled", value); }
        }
        /// <summary>Indicates if keyboard restriction is enabled. If enabled list of approved keyboards must be provided as well.</summary>
        public bool? KeyboardsRestricted {
            get { return BackingStore?.Get<bool?>("keyboardsRestricted"); }
            set { BackingStore?.Set("keyboardsRestricted", value); }
        }
        /// <summary>Minimum version of the Company portal that must be installed on the device or app access will be blocked</summary>
        public string MinimumRequiredCompanyPortalVersion {
            get { return BackingStore?.Get<string>("minimumRequiredCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumRequiredCompanyPortalVersion", value); }
        }
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app.</summary>
        public string MinimumRequiredPatchVersion {
            get { return BackingStore?.Get<string>("minimumRequiredPatchVersion"); }
            set { BackingStore?.Set("minimumRequiredPatchVersion", value); }
        }
        /// <summary>Minimum version of the Company portal that must be installed on the device or the user will receive a warning</summary>
        public string MinimumWarningCompanyPortalVersion {
            get { return BackingStore?.Get<string>("minimumWarningCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumWarningCompanyPortalVersion", value); }
        }
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app.</summary>
        public string MinimumWarningPatchVersion {
            get { return BackingStore?.Get<string>("minimumWarningPatchVersion"); }
            set { BackingStore?.Set("minimumWarningPatchVersion", value); }
        }
        /// <summary>Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped</summary>
        public string MinimumWipeCompanyPortalVersion {
            get { return BackingStore?.Get<string>("minimumWipeCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumWipeCompanyPortalVersion", value); }
        }
        /// <summary>Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data.</summary>
        public string MinimumWipePatchVersion {
            get { return BackingStore?.Get<string>("minimumWipePatchVersion"); }
            set { BackingStore?.Set("minimumWipePatchVersion", value); }
        }
        /// <summary>Require user to apply Class 3 Biometrics on their Android device.</summary>
        public bool? RequireClass3Biometrics {
            get { return BackingStore?.Get<bool?>("requireClass3Biometrics"); }
            set { BackingStore?.Set("requireClass3Biometrics", value); }
        }
        /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetAppsVerificationType?>("requiredAndroidSafetyNetAppsVerificationType"); }
            set { BackingStore?.Set("requiredAndroidSafetyNetAppsVerificationType", value); }
        }
        /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetDeviceAttestationType?>("requiredAndroidSafetyNetDeviceAttestationType"); }
            set { BackingStore?.Set("requiredAndroidSafetyNetDeviceAttestationType", value); }
        }
        /// <summary>An admin enforced Android SafetyNet evaluation type requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetEvaluationType? RequiredAndroidSafetyNetEvaluationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetEvaluationType?>("requiredAndroidSafetyNetEvaluationType"); }
            set { BackingStore?.Set("requiredAndroidSafetyNetEvaluationType", value); }
        }
        /// <summary>A PIN prompt will override biometric prompts if class 3 biometrics are updated on the device.</summary>
        public bool? RequirePinAfterBiometricChange {
            get { return BackingStore?.Get<bool?>("requirePinAfterBiometricChange"); }
            set { BackingStore?.Set("requirePinAfterBiometricChange", value); }
        }
        /// <summary>Indicates whether a managed user can take screen captures of managed apps</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>("screenCaptureBlocked"); }
            set { BackingStore?.Set("screenCaptureBlocked", value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning</summary>
        public int? WarnAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>("warnAfterCompanyPortalUpdateDeferralInDays"); }
            set { BackingStore?.Set("warnAfterCompanyPortalUpdateDeferralInDays", value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped</summary>
        public int? WipeAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>("wipeAfterCompanyPortalUpdateDeferralInDays"); }
            set { BackingStore?.Set("wipeAfterCompanyPortalUpdateDeferralInDays", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedAndroidDeviceManufacturers", n => { AllowedAndroidDeviceManufacturers = n.GetStringValue(); } },
                {"allowedAndroidDeviceModels", n => { AllowedAndroidDeviceModels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"appActionIfAndroidDeviceManufacturerNotAllowed", n => { AppActionIfAndroidDeviceManufacturerNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidDeviceModelNotAllowed", n => { AppActionIfAndroidDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidSafetyNetAppsVerificationFailed", n => { AppActionIfAndroidSafetyNetAppsVerificationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidSafetyNetDeviceAttestationFailed", n => { AppActionIfAndroidSafetyNetDeviceAttestationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDeviceLockNotSet", n => { AppActionIfDeviceLockNotSet = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanHigh", n => { AppActionIfDevicePasscodeComplexityLessThanHigh = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanLow", n => { AppActionIfDevicePasscodeComplexityLessThanLow = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanMedium", n => { AppActionIfDevicePasscodeComplexityLessThanMedium = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"approvedKeyboards", n => { ApprovedKeyboards = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"biometricAuthenticationBlocked", n => { BiometricAuthenticationBlocked = n.GetBoolValue(); } },
                {"blockAfterCompanyPortalUpdateDeferralInDays", n => { BlockAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                {"connectToVpnOnLaunch", n => { ConnectToVpnOnLaunch = n.GetBoolValue(); } },
                {"customBrowserDisplayName", n => { CustomBrowserDisplayName = n.GetStringValue(); } },
                {"customBrowserPackageId", n => { CustomBrowserPackageId = n.GetStringValue(); } },
                {"customDialerAppDisplayName", n => { CustomDialerAppDisplayName = n.GetStringValue(); } },
                {"customDialerAppPackageId", n => { CustomDialerAppPackageId = n.GetStringValue(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"deviceLockRequired", n => { DeviceLockRequired = n.GetBoolValue(); } },
                {"disableAppEncryptionIfDeviceEncryptionIsEnabled", n => { DisableAppEncryptionIfDeviceEncryptionIsEnabled = n.GetBoolValue(); } },
                {"encryptAppData", n => { EncryptAppData = n.GetBoolValue(); } },
                {"exemptedAppPackages", n => { ExemptedAppPackages = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"fingerprintAndBiometricEnabled", n => { FingerprintAndBiometricEnabled = n.GetBoolValue(); } },
                {"keyboardsRestricted", n => { KeyboardsRestricted = n.GetBoolValue(); } },
                {"minimumRequiredCompanyPortalVersion", n => { MinimumRequiredCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumRequiredPatchVersion", n => { MinimumRequiredPatchVersion = n.GetStringValue(); } },
                {"minimumWarningCompanyPortalVersion", n => { MinimumWarningCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWarningPatchVersion", n => { MinimumWarningPatchVersion = n.GetStringValue(); } },
                {"minimumWipeCompanyPortalVersion", n => { MinimumWipeCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWipePatchVersion", n => { MinimumWipePatchVersion = n.GetStringValue(); } },
                {"requireClass3Biometrics", n => { RequireClass3Biometrics = n.GetBoolValue(); } },
                {"requiredAndroidSafetyNetAppsVerificationType", n => { RequiredAndroidSafetyNetAppsVerificationType = n.GetEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>(); } },
                {"requiredAndroidSafetyNetDeviceAttestationType", n => { RequiredAndroidSafetyNetDeviceAttestationType = n.GetEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>(); } },
                {"requiredAndroidSafetyNetEvaluationType", n => { RequiredAndroidSafetyNetEvaluationType = n.GetEnumValue<AndroidManagedAppSafetyNetEvaluationType>(); } },
                {"requirePinAfterBiometricChange", n => { RequirePinAfterBiometricChange = n.GetBoolValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"warnAfterCompanyPortalUpdateDeferralInDays", n => { WarnAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                {"wipeAfterCompanyPortalUpdateDeferralInDays", n => { WipeAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("allowedAndroidDeviceManufacturers", AllowedAndroidDeviceManufacturers);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedAndroidDeviceModels", AllowedAndroidDeviceModels);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceManufacturerNotAllowed", AppActionIfAndroidDeviceManufacturerNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceModelNotAllowed", AppActionIfAndroidDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetAppsVerificationFailed", AppActionIfAndroidSafetyNetAppsVerificationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetDeviceAttestationFailed", AppActionIfAndroidSafetyNetDeviceAttestationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDeviceLockNotSet", AppActionIfDeviceLockNotSet);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanHigh", AppActionIfDevicePasscodeComplexityLessThanHigh);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanLow", AppActionIfDevicePasscodeComplexityLessThanLow);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanMedium", AppActionIfDevicePasscodeComplexityLessThanMedium);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("approvedKeyboards", ApprovedKeyboards);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteBoolValue("biometricAuthenticationBlocked", BiometricAuthenticationBlocked);
            writer.WriteIntValue("blockAfterCompanyPortalUpdateDeferralInDays", BlockAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteBoolValue("connectToVpnOnLaunch", ConnectToVpnOnLaunch);
            writer.WriteStringValue("customBrowserDisplayName", CustomBrowserDisplayName);
            writer.WriteStringValue("customBrowserPackageId", CustomBrowserPackageId);
            writer.WriteStringValue("customDialerAppDisplayName", CustomDialerAppDisplayName);
            writer.WriteStringValue("customDialerAppPackageId", CustomDialerAppPackageId);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("deviceLockRequired", DeviceLockRequired);
            writer.WriteBoolValue("disableAppEncryptionIfDeviceEncryptionIsEnabled", DisableAppEncryptionIfDeviceEncryptionIsEnabled);
            writer.WriteBoolValue("encryptAppData", EncryptAppData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("exemptedAppPackages", ExemptedAppPackages);
            writer.WriteBoolValue("fingerprintAndBiometricEnabled", FingerprintAndBiometricEnabled);
            writer.WriteBoolValue("keyboardsRestricted", KeyboardsRestricted);
            writer.WriteStringValue("minimumRequiredCompanyPortalVersion", MinimumRequiredCompanyPortalVersion);
            writer.WriteStringValue("minimumRequiredPatchVersion", MinimumRequiredPatchVersion);
            writer.WriteStringValue("minimumWarningCompanyPortalVersion", MinimumWarningCompanyPortalVersion);
            writer.WriteStringValue("minimumWarningPatchVersion", MinimumWarningPatchVersion);
            writer.WriteStringValue("minimumWipeCompanyPortalVersion", MinimumWipeCompanyPortalVersion);
            writer.WriteStringValue("minimumWipePatchVersion", MinimumWipePatchVersion);
            writer.WriteBoolValue("requireClass3Biometrics", RequireClass3Biometrics);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>("requiredAndroidSafetyNetAppsVerificationType", RequiredAndroidSafetyNetAppsVerificationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>("requiredAndroidSafetyNetDeviceAttestationType", RequiredAndroidSafetyNetDeviceAttestationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetEvaluationType>("requiredAndroidSafetyNetEvaluationType", RequiredAndroidSafetyNetEvaluationType);
            writer.WriteBoolValue("requirePinAfterBiometricChange", RequirePinAfterBiometricChange);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteIntValue("warnAfterCompanyPortalUpdateDeferralInDays", WarnAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteIntValue("wipeAfterCompanyPortalUpdateDeferralInDays", WipeAfterCompanyPortalUpdateDeferralInDays);
        }
    }
}
