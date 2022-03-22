using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DefaultManagedAppProtection : ManagedAppProtection, IParsable {
        /// <summary>Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work. (Android only)</summary>
        public string AllowedAndroidDeviceManufacturers { get; set; }
        /// <summary>List of device models allowed, as a string, for the managed app to work. (Android Only)</summary>
        public List<string> AllowedAndroidDeviceModels { get; set; }
        /// <summary>Semicolon seperated list of device models allowed, as a string, for the managed app to work. (iOS Only)</summary>
        public string AllowedIosDeviceModels { get; set; }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device manufacturer is not allowed. (Android only). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed { get; set; }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device model is not allowed. (Android Only). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceModelNotAllowed { get; set; }
        /// <summary>Defines a managed app behavior, either warn or block, if the specified Android App Verification requirement fails. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed { get; set; }
        /// <summary>Defines a managed app behavior, either warn or block, if the specified Android SafetyNet Attestation requirement fails. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed { get; set; }
        /// <summary>Defines a managed app behavior, either warn, block or wipe, if the screen lock is required on device but is not set. (android only). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceLockNotSet { get; set; }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device model is not allowed. (iOS Only). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed { get; set; }
        /// <summary>Type of encryption which should be used for data in a managed app. (iOS Only). Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.</summary>
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True. (Android Only)</summary>
        public bool? BiometricAuthenticationBlocked { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.</summary>
        public int? BlockAfterCompanyPortalUpdateDeferralInDays { get; set; }
        /// <summary>Whether the app should connect to the configured VPN on launch (Android only).</summary>
        public bool? ConnectToVpnOnLaunch { get; set; }
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android. (Android only)</summary>
        public string CustomBrowserDisplayName { get; set; }
        /// <summary>Unique identifier of a custom browser to open weblink on Android. (Android only)</summary>
        public string CustomBrowserPackageId { get; set; }
        /// <summary>A custom browser protocol to open weblink on iOS. (iOS only)</summary>
        public string CustomBrowserProtocol { get; set; }
        /// <summary>Friendly name of a custom dialer app to click-to-open a phone number on Android.</summary>
        public string CustomDialerAppDisplayName { get; set; }
        /// <summary>PackageId of a custom dialer app to click-to-open a phone number on Android.</summary>
        public string CustomDialerAppPackageId { get; set; }
        /// <summary>Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.</summary>
        public string CustomDialerAppProtocol { get; set; }
        /// <summary>A set of string key and string value pairs to be sent to the affected users, unalterned by this service</summary>
        public List<KeyValuePair> CustomSettings { get; set; }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
        /// <summary>Defines if any kind of lock must be required on device. (android only)</summary>
        public bool? DeviceLockRequired { get; set; }
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled. (Android only)</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
        /// <summary>Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps. (iOS Only)</summary>
        public bool? DisableProtectionOfManagedOutboundOpenInData { get; set; }
        /// <summary>Indicates whether managed-app data should be encrypted. (Android only)</summary>
        public bool? EncryptAppData { get; set; }
        /// <summary>Android App packages in this list will be exempt from the policy and will be able to receive data from managed apps. (Android only)</summary>
        public List<KeyValuePair> ExemptedAppPackages { get; set; }
        /// <summary>iOS Apps in this list will be exempt from the policy and will be able to receive data from managed apps. (iOS Only)</summary>
        public List<KeyValuePair> ExemptedAppProtocols { get; set; }
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True. (iOS Only)</summary>
        public bool? FaceIdBlocked { get; set; }
        /// <summary>Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False. (iOS Only)</summary>
        public bool? FilterOpenInToOnlyManagedApps { get; set; }
        /// <summary>Minimum version of the Company portal that must be installed on the device or app access will be blocked</summary>
        public string MinimumRequiredCompanyPortalVersion { get; set; }
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app. (Android only)</summary>
        public string MinimumRequiredPatchVersion { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. (iOS Only)</summary>
        public string MinimumRequiredSdkVersion { get; set; }
        /// <summary>Minimum version of the Company portal that must be installed on the device or the user will receive a warning</summary>
        public string MinimumWarningCompanyPortalVersion { get; set; }
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app. (Android only)</summary>
        public string MinimumWarningPatchVersion { get; set; }
        /// <summary>Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped</summary>
        public string MinimumWipeCompanyPortalVersion { get; set; }
        /// <summary>Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data. (Android only)</summary>
        public string MinimumWipePatchVersion { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumWipeSdkVersion { get; set; }
        /// <summary>Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps. (iOS Only)</summary>
        public bool? ProtectInboundDataFromUnknownSources { get; set; }
        /// <summary>Defines the Android SafetyNet Apps Verification requirement for a managed app to work. Possible values are: none, enabled.</summary>
        public AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType { get; set; }
        /// <summary>Defines the Android SafetyNet Device Attestation requirement for a managed app to work. Possible values are: none, basicIntegrity, basicIntegrityAndDeviceCertification.</summary>
        public AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType { get; set; }
        /// <summary>Defines the Android SafetyNet evaluation type requirement for a managed app to work. (Android Only). Possible values are: basic, hardwareBacked.</summary>
        public AndroidManagedAppSafetyNetEvaluationType? RequiredAndroidSafetyNetEvaluationType { get; set; }
        /// <summary>Indicates whether screen capture is blocked. (Android only)</summary>
        public bool? ScreenCaptureBlocked { get; set; }
        /// <summary>Defines if third party keyboards are allowed while accessing a managed app. (iOS Only)</summary>
        public bool? ThirdPartyKeyboardsBlocked { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning</summary>
        public int? WarnAfterCompanyPortalUpdateDeferralInDays { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped</summary>
        public int? WipeAfterCompanyPortalUpdateDeferralInDays { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DefaultManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DefaultManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowedAndroidDeviceManufacturers", (o,n) => { (o as DefaultManagedAppProtection).AllowedAndroidDeviceManufacturers = n.GetStringValue(); } },
                {"allowedAndroidDeviceModels", (o,n) => { (o as DefaultManagedAppProtection).AllowedAndroidDeviceModels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedIosDeviceModels", (o,n) => { (o as DefaultManagedAppProtection).AllowedIosDeviceModels = n.GetStringValue(); } },
                {"appActionIfAndroidDeviceManufacturerNotAllowed", (o,n) => { (o as DefaultManagedAppProtection).AppActionIfAndroidDeviceManufacturerNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidDeviceModelNotAllowed", (o,n) => { (o as DefaultManagedAppProtection).AppActionIfAndroidDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidSafetyNetAppsVerificationFailed", (o,n) => { (o as DefaultManagedAppProtection).AppActionIfAndroidSafetyNetAppsVerificationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidSafetyNetDeviceAttestationFailed", (o,n) => { (o as DefaultManagedAppProtection).AppActionIfAndroidSafetyNetDeviceAttestationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDeviceLockNotSet", (o,n) => { (o as DefaultManagedAppProtection).AppActionIfDeviceLockNotSet = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfIosDeviceModelNotAllowed", (o,n) => { (o as DefaultManagedAppProtection).AppActionIfIosDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appDataEncryptionType", (o,n) => { (o as DefaultManagedAppProtection).AppDataEncryptionType = n.GetEnumValue<ManagedAppDataEncryptionType>(); } },
                {"apps", (o,n) => { (o as DefaultManagedAppProtection).Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"biometricAuthenticationBlocked", (o,n) => { (o as DefaultManagedAppProtection).BiometricAuthenticationBlocked = n.GetBoolValue(); } },
                {"blockAfterCompanyPortalUpdateDeferralInDays", (o,n) => { (o as DefaultManagedAppProtection).BlockAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                {"connectToVpnOnLaunch", (o,n) => { (o as DefaultManagedAppProtection).ConnectToVpnOnLaunch = n.GetBoolValue(); } },
                {"customBrowserDisplayName", (o,n) => { (o as DefaultManagedAppProtection).CustomBrowserDisplayName = n.GetStringValue(); } },
                {"customBrowserPackageId", (o,n) => { (o as DefaultManagedAppProtection).CustomBrowserPackageId = n.GetStringValue(); } },
                {"customBrowserProtocol", (o,n) => { (o as DefaultManagedAppProtection).CustomBrowserProtocol = n.GetStringValue(); } },
                {"customDialerAppDisplayName", (o,n) => { (o as DefaultManagedAppProtection).CustomDialerAppDisplayName = n.GetStringValue(); } },
                {"customDialerAppPackageId", (o,n) => { (o as DefaultManagedAppProtection).CustomDialerAppPackageId = n.GetStringValue(); } },
                {"customDialerAppProtocol", (o,n) => { (o as DefaultManagedAppProtection).CustomDialerAppProtocol = n.GetStringValue(); } },
                {"customSettings", (o,n) => { (o as DefaultManagedAppProtection).CustomSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"deployedAppCount", (o,n) => { (o as DefaultManagedAppProtection).DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", (o,n) => { (o as DefaultManagedAppProtection).DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"deviceLockRequired", (o,n) => { (o as DefaultManagedAppProtection).DeviceLockRequired = n.GetBoolValue(); } },
                {"disableAppEncryptionIfDeviceEncryptionIsEnabled", (o,n) => { (o as DefaultManagedAppProtection).DisableAppEncryptionIfDeviceEncryptionIsEnabled = n.GetBoolValue(); } },
                {"disableProtectionOfManagedOutboundOpenInData", (o,n) => { (o as DefaultManagedAppProtection).DisableProtectionOfManagedOutboundOpenInData = n.GetBoolValue(); } },
                {"encryptAppData", (o,n) => { (o as DefaultManagedAppProtection).EncryptAppData = n.GetBoolValue(); } },
                {"exemptedAppPackages", (o,n) => { (o as DefaultManagedAppProtection).ExemptedAppPackages = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"exemptedAppProtocols", (o,n) => { (o as DefaultManagedAppProtection).ExemptedAppProtocols = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"faceIdBlocked", (o,n) => { (o as DefaultManagedAppProtection).FaceIdBlocked = n.GetBoolValue(); } },
                {"filterOpenInToOnlyManagedApps", (o,n) => { (o as DefaultManagedAppProtection).FilterOpenInToOnlyManagedApps = n.GetBoolValue(); } },
                {"minimumRequiredCompanyPortalVersion", (o,n) => { (o as DefaultManagedAppProtection).MinimumRequiredCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumRequiredPatchVersion", (o,n) => { (o as DefaultManagedAppProtection).MinimumRequiredPatchVersion = n.GetStringValue(); } },
                {"minimumRequiredSdkVersion", (o,n) => { (o as DefaultManagedAppProtection).MinimumRequiredSdkVersion = n.GetStringValue(); } },
                {"minimumWarningCompanyPortalVersion", (o,n) => { (o as DefaultManagedAppProtection).MinimumWarningCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWarningPatchVersion", (o,n) => { (o as DefaultManagedAppProtection).MinimumWarningPatchVersion = n.GetStringValue(); } },
                {"minimumWipeCompanyPortalVersion", (o,n) => { (o as DefaultManagedAppProtection).MinimumWipeCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWipePatchVersion", (o,n) => { (o as DefaultManagedAppProtection).MinimumWipePatchVersion = n.GetStringValue(); } },
                {"minimumWipeSdkVersion", (o,n) => { (o as DefaultManagedAppProtection).MinimumWipeSdkVersion = n.GetStringValue(); } },
                {"protectInboundDataFromUnknownSources", (o,n) => { (o as DefaultManagedAppProtection).ProtectInboundDataFromUnknownSources = n.GetBoolValue(); } },
                {"requiredAndroidSafetyNetAppsVerificationType", (o,n) => { (o as DefaultManagedAppProtection).RequiredAndroidSafetyNetAppsVerificationType = n.GetEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>(); } },
                {"requiredAndroidSafetyNetDeviceAttestationType", (o,n) => { (o as DefaultManagedAppProtection).RequiredAndroidSafetyNetDeviceAttestationType = n.GetEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>(); } },
                {"requiredAndroidSafetyNetEvaluationType", (o,n) => { (o as DefaultManagedAppProtection).RequiredAndroidSafetyNetEvaluationType = n.GetEnumValue<AndroidManagedAppSafetyNetEvaluationType>(); } },
                {"screenCaptureBlocked", (o,n) => { (o as DefaultManagedAppProtection).ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"thirdPartyKeyboardsBlocked", (o,n) => { (o as DefaultManagedAppProtection).ThirdPartyKeyboardsBlocked = n.GetBoolValue(); } },
                {"warnAfterCompanyPortalUpdateDeferralInDays", (o,n) => { (o as DefaultManagedAppProtection).WarnAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                {"wipeAfterCompanyPortalUpdateDeferralInDays", (o,n) => { (o as DefaultManagedAppProtection).WipeAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
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
            writer.WriteStringValue("allowedIosDeviceModels", AllowedIosDeviceModels);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceManufacturerNotAllowed", AppActionIfAndroidDeviceManufacturerNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceModelNotAllowed", AppActionIfAndroidDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetAppsVerificationFailed", AppActionIfAndroidSafetyNetAppsVerificationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetDeviceAttestationFailed", AppActionIfAndroidSafetyNetDeviceAttestationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDeviceLockNotSet", AppActionIfDeviceLockNotSet);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfIosDeviceModelNotAllowed", AppActionIfIosDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppDataEncryptionType>("appDataEncryptionType", AppDataEncryptionType);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteBoolValue("biometricAuthenticationBlocked", BiometricAuthenticationBlocked);
            writer.WriteIntValue("blockAfterCompanyPortalUpdateDeferralInDays", BlockAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteBoolValue("connectToVpnOnLaunch", ConnectToVpnOnLaunch);
            writer.WriteStringValue("customBrowserDisplayName", CustomBrowserDisplayName);
            writer.WriteStringValue("customBrowserPackageId", CustomBrowserPackageId);
            writer.WriteStringValue("customBrowserProtocol", CustomBrowserProtocol);
            writer.WriteStringValue("customDialerAppDisplayName", CustomDialerAppDisplayName);
            writer.WriteStringValue("customDialerAppPackageId", CustomDialerAppPackageId);
            writer.WriteStringValue("customDialerAppProtocol", CustomDialerAppProtocol);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customSettings", CustomSettings);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("deviceLockRequired", DeviceLockRequired);
            writer.WriteBoolValue("disableAppEncryptionIfDeviceEncryptionIsEnabled", DisableAppEncryptionIfDeviceEncryptionIsEnabled);
            writer.WriteBoolValue("disableProtectionOfManagedOutboundOpenInData", DisableProtectionOfManagedOutboundOpenInData);
            writer.WriteBoolValue("encryptAppData", EncryptAppData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("exemptedAppPackages", ExemptedAppPackages);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("exemptedAppProtocols", ExemptedAppProtocols);
            writer.WriteBoolValue("faceIdBlocked", FaceIdBlocked);
            writer.WriteBoolValue("filterOpenInToOnlyManagedApps", FilterOpenInToOnlyManagedApps);
            writer.WriteStringValue("minimumRequiredCompanyPortalVersion", MinimumRequiredCompanyPortalVersion);
            writer.WriteStringValue("minimumRequiredPatchVersion", MinimumRequiredPatchVersion);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
            writer.WriteStringValue("minimumWarningCompanyPortalVersion", MinimumWarningCompanyPortalVersion);
            writer.WriteStringValue("minimumWarningPatchVersion", MinimumWarningPatchVersion);
            writer.WriteStringValue("minimumWipeCompanyPortalVersion", MinimumWipeCompanyPortalVersion);
            writer.WriteStringValue("minimumWipePatchVersion", MinimumWipePatchVersion);
            writer.WriteStringValue("minimumWipeSdkVersion", MinimumWipeSdkVersion);
            writer.WriteBoolValue("protectInboundDataFromUnknownSources", ProtectInboundDataFromUnknownSources);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>("requiredAndroidSafetyNetAppsVerificationType", RequiredAndroidSafetyNetAppsVerificationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>("requiredAndroidSafetyNetDeviceAttestationType", RequiredAndroidSafetyNetDeviceAttestationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetEvaluationType>("requiredAndroidSafetyNetEvaluationType", RequiredAndroidSafetyNetEvaluationType);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("thirdPartyKeyboardsBlocked", ThirdPartyKeyboardsBlocked);
            writer.WriteIntValue("warnAfterCompanyPortalUpdateDeferralInDays", WarnAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteIntValue("wipeAfterCompanyPortalUpdateDeferralInDays", WipeAfterCompanyPortalUpdateDeferralInDays);
        }
    }
}
