using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work.</summary>
        public string AllowedAndroidDeviceManufacturers { get; set; }
        /// <summary>List of device models allowed, as a string, for the managed app to work.</summary>
        public List<string> AllowedAndroidDeviceModels { get; set; }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device manufacturer is not allowed. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed { get; set; }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device model is not allowed.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceModelNotAllowed { get; set; }
        /// <summary>Defines a managed app behavior, either warn or block, if the specified Android App Verification requirment fails. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed { get; set; }
        /// <summary>Defines a managed app behavior, either warn or block, if the specified Android SafetyNet Attestation requirment fails. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed { get; set; }
        /// <summary>Defines a managed app behavior, either warn, block or wipe, if the screen lock is required on android device but is not set.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceLockNotSet { get; set; }
        /// <summary>If Keyboard Restriction is enabled, only keyboards in this approved list will be allowed. A key should be Android package id for a keyboard and value should be a friendly name</summary>
        public List<KeyValuePair> ApprovedKeyboards { get; set; }
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? BiometricAuthenticationBlocked { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.</summary>
        public int? BlockAfterCompanyPortalUpdateDeferralInDays { get; set; }
        /// <summary>Whether the app should connect to the configured VPN on launch.</summary>
        public bool? ConnectToVpnOnLaunch { get; set; }
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
        public string CustomBrowserDisplayName { get; set; }
        /// <summary>Unique identifier of the preferred custom browser to open weblink on Android. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
        public string CustomBrowserPackageId { get; set; }
        /// <summary>Friendly name of a custom dialer app to click-to-open a phone number on Android.</summary>
        public string CustomDialerAppDisplayName { get; set; }
        /// <summary>PackageId of a custom dialer app to click-to-open a phone number on Android.</summary>
        public string CustomDialerAppPackageId { get; set; }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
        /// <summary>Defines if any kind of lock must be required on android device</summary>
        public bool? DeviceLockRequired { get; set; }
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
        /// <summary>Indicates whether application data for managed apps should be encrypted</summary>
        public bool? EncryptAppData { get; set; }
        /// <summary>App packages in this list will be exempt from the policy and will be able to receive data from managed apps.</summary>
        public List<KeyValuePair> ExemptedAppPackages { get; set; }
        /// <summary>Indicates if keyboard restriction is enabled. If enabled list of approved keyboards must be provided as well.</summary>
        public bool? KeyboardsRestricted { get; set; }
        /// <summary>Minimum version of the Company portal that must be installed on the device or app access will be blocked</summary>
        public string MinimumRequiredCompanyPortalVersion { get; set; }
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app.</summary>
        public string MinimumRequiredPatchVersion { get; set; }
        /// <summary>Minimum version of the Company portal that must be installed on the device or the user will receive a warning</summary>
        public string MinimumWarningCompanyPortalVersion { get; set; }
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app.</summary>
        public string MinimumWarningPatchVersion { get; set; }
        /// <summary>Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped</summary>
        public string MinimumWipeCompanyPortalVersion { get; set; }
        /// <summary>Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data.</summary>
        public string MinimumWipePatchVersion { get; set; }
        /// <summary>Defines the Android SafetyNet Apps Verification requirement for a managed app to work. Possible values are: none, enabled.</summary>
        public AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType { get; set; }
        /// <summary>Defines the Android SafetyNet Device Attestation requirement for a managed app to work. Possible values are: none, basicIntegrity, basicIntegrityAndDeviceCertification.</summary>
        public AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType { get; set; }
        /// <summary>Defines the Android SafetyNet evaluation type requirement for a managed app to work.</summary>
        public AndroidManagedAppSafetyNetEvaluationType? RequiredAndroidSafetyNetEvaluationType { get; set; }
        /// <summary>Indicates whether a managed user can take screen captures of managed apps</summary>
        public bool? ScreenCaptureBlocked { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning</summary>
        public int? WarnAfterCompanyPortalUpdateDeferralInDays { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped</summary>
        public int? WipeAfterCompanyPortalUpdateDeferralInDays { get; set; }
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
                {"keyboardsRestricted", n => { KeyboardsRestricted = n.GetBoolValue(); } },
                {"minimumRequiredCompanyPortalVersion", n => { MinimumRequiredCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumRequiredPatchVersion", n => { MinimumRequiredPatchVersion = n.GetStringValue(); } },
                {"minimumWarningCompanyPortalVersion", n => { MinimumWarningCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWarningPatchVersion", n => { MinimumWarningPatchVersion = n.GetStringValue(); } },
                {"minimumWipeCompanyPortalVersion", n => { MinimumWipeCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWipePatchVersion", n => { MinimumWipePatchVersion = n.GetStringValue(); } },
                {"requiredAndroidSafetyNetAppsVerificationType", n => { RequiredAndroidSafetyNetAppsVerificationType = n.GetEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>(); } },
                {"requiredAndroidSafetyNetDeviceAttestationType", n => { RequiredAndroidSafetyNetDeviceAttestationType = n.GetEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>(); } },
                {"requiredAndroidSafetyNetEvaluationType", n => { RequiredAndroidSafetyNetEvaluationType = n.GetEnumValue<AndroidManagedAppSafetyNetEvaluationType>(); } },
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
            writer.WriteBoolValue("keyboardsRestricted", KeyboardsRestricted);
            writer.WriteStringValue("minimumRequiredCompanyPortalVersion", MinimumRequiredCompanyPortalVersion);
            writer.WriteStringValue("minimumRequiredPatchVersion", MinimumRequiredPatchVersion);
            writer.WriteStringValue("minimumWarningCompanyPortalVersion", MinimumWarningCompanyPortalVersion);
            writer.WriteStringValue("minimumWarningPatchVersion", MinimumWarningPatchVersion);
            writer.WriteStringValue("minimumWipeCompanyPortalVersion", MinimumWipeCompanyPortalVersion);
            writer.WriteStringValue("minimumWipePatchVersion", MinimumWipePatchVersion);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>("requiredAndroidSafetyNetAppsVerificationType", RequiredAndroidSafetyNetAppsVerificationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>("requiredAndroidSafetyNetDeviceAttestationType", RequiredAndroidSafetyNetDeviceAttestationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetEvaluationType>("requiredAndroidSafetyNetEvaluationType", RequiredAndroidSafetyNetEvaluationType);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteIntValue("warnAfterCompanyPortalUpdateDeferralInDays", WarnAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteIntValue("wipeAfterCompanyPortalUpdateDeferralInDays", WipeAfterCompanyPortalUpdateDeferralInDays);
        }
    }
}
