using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Policy used to configure detailed management settings for a specified set of apps for all users not targeted by a TargetedManagedAppProtection Policy</summary>
    public class DefaultManagedAppProtection : ManagedAppProtection, IParsable {
        /// <summary>Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work. (Android only)</summary>
        public string AllowedAndroidDeviceManufacturers {
            get { return BackingStore?.Get<string>(nameof(AllowedAndroidDeviceManufacturers)); }
            set { BackingStore?.Set(nameof(AllowedAndroidDeviceManufacturers), value); }
        }
        /// <summary>List of device models allowed, as a string, for the managed app to work. (Android Only)</summary>
        public List<string> AllowedAndroidDeviceModels {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedAndroidDeviceModels)); }
            set { BackingStore?.Set(nameof(AllowedAndroidDeviceModels), value); }
        }
        /// <summary>Semicolon seperated list of device models allowed, as a string, for the managed app to work. (iOS Only)</summary>
        public string AllowedIosDeviceModels {
            get { return BackingStore?.Get<string>(nameof(AllowedIosDeviceModels)); }
            set { BackingStore?.Set(nameof(AllowedIosDeviceModels), value); }
        }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device manufacturer is not allowed. (Android only). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfAndroidDeviceManufacturerNotAllowed)); }
            set { BackingStore?.Set(nameof(AppActionIfAndroidDeviceManufacturerNotAllowed), value); }
        }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device model is not allowed. (Android Only). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceModelNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfAndroidDeviceModelNotAllowed)); }
            set { BackingStore?.Set(nameof(AppActionIfAndroidDeviceModelNotAllowed), value); }
        }
        /// <summary>Defines a managed app behavior, either warn or block, if the specified Android App Verification requirement fails. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfAndroidSafetyNetAppsVerificationFailed)); }
            set { BackingStore?.Set(nameof(AppActionIfAndroidSafetyNetAppsVerificationFailed), value); }
        }
        /// <summary>Defines a managed app behavior, either warn or block, if the specified Android SafetyNet Attestation requirement fails. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfAndroidSafetyNetDeviceAttestationFailed)); }
            set { BackingStore?.Set(nameof(AppActionIfAndroidSafetyNetDeviceAttestationFailed), value); }
        }
        /// <summary>Defines a managed app behavior, either warn, block or wipe, if the screen lock is required on device but is not set. (android only). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceLockNotSet {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfDeviceLockNotSet)); }
            set { BackingStore?.Set(nameof(AppActionIfDeviceLockNotSet), value); }
        }
        /// <summary>If the device does not have a passcode of high complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanHigh {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfDevicePasscodeComplexityLessThanHigh)); }
            set { BackingStore?.Set(nameof(AppActionIfDevicePasscodeComplexityLessThanHigh), value); }
        }
        /// <summary>If the device does not have a passcode of low complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanLow {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfDevicePasscodeComplexityLessThanLow)); }
            set { BackingStore?.Set(nameof(AppActionIfDevicePasscodeComplexityLessThanLow), value); }
        }
        /// <summary>If the device does not have a passcode of medium complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanMedium {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfDevicePasscodeComplexityLessThanMedium)); }
            set { BackingStore?.Set(nameof(AppActionIfDevicePasscodeComplexityLessThanMedium), value); }
        }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device model is not allowed. (iOS Only). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfIosDeviceModelNotAllowed)); }
            set { BackingStore?.Set(nameof(AppActionIfIosDeviceModelNotAllowed), value); }
        }
        /// <summary>Type of encryption which should be used for data in a managed app. (iOS Only). Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.</summary>
        public ManagedAppDataEncryptionType? AppDataEncryptionType {
            get { return BackingStore?.Get<ManagedAppDataEncryptionType?>(nameof(AppDataEncryptionType)); }
            set { BackingStore?.Set(nameof(AppDataEncryptionType), value); }
        }
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>>(nameof(Apps)); }
            set { BackingStore?.Set(nameof(Apps), value); }
        }
        /// <summary>Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True. (Android Only)</summary>
        public bool? BiometricAuthenticationBlocked {
            get { return BackingStore?.Get<bool?>(nameof(BiometricAuthenticationBlocked)); }
            set { BackingStore?.Set(nameof(BiometricAuthenticationBlocked), value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.</summary>
        public int? BlockAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>(nameof(BlockAfterCompanyPortalUpdateDeferralInDays)); }
            set { BackingStore?.Set(nameof(BlockAfterCompanyPortalUpdateDeferralInDays), value); }
        }
        /// <summary>Whether the app should connect to the configured VPN on launch (Android only).</summary>
        public bool? ConnectToVpnOnLaunch {
            get { return BackingStore?.Get<bool?>(nameof(ConnectToVpnOnLaunch)); }
            set { BackingStore?.Set(nameof(ConnectToVpnOnLaunch), value); }
        }
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android. (Android only)</summary>
        public string CustomBrowserDisplayName {
            get { return BackingStore?.Get<string>(nameof(CustomBrowserDisplayName)); }
            set { BackingStore?.Set(nameof(CustomBrowserDisplayName), value); }
        }
        /// <summary>Unique identifier of a custom browser to open weblink on Android. (Android only)</summary>
        public string CustomBrowserPackageId {
            get { return BackingStore?.Get<string>(nameof(CustomBrowserPackageId)); }
            set { BackingStore?.Set(nameof(CustomBrowserPackageId), value); }
        }
        /// <summary>A custom browser protocol to open weblink on iOS. (iOS only)</summary>
        public string CustomBrowserProtocol {
            get { return BackingStore?.Get<string>(nameof(CustomBrowserProtocol)); }
            set { BackingStore?.Set(nameof(CustomBrowserProtocol), value); }
        }
        /// <summary>Friendly name of a custom dialer app to click-to-open a phone number on Android.</summary>
        public string CustomDialerAppDisplayName {
            get { return BackingStore?.Get<string>(nameof(CustomDialerAppDisplayName)); }
            set { BackingStore?.Set(nameof(CustomDialerAppDisplayName), value); }
        }
        /// <summary>PackageId of a custom dialer app to click-to-open a phone number on Android.</summary>
        public string CustomDialerAppPackageId {
            get { return BackingStore?.Get<string>(nameof(CustomDialerAppPackageId)); }
            set { BackingStore?.Set(nameof(CustomDialerAppPackageId), value); }
        }
        /// <summary>Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.</summary>
        public string CustomDialerAppProtocol {
            get { return BackingStore?.Get<string>(nameof(CustomDialerAppProtocol)); }
            set { BackingStore?.Set(nameof(CustomDialerAppProtocol), value); }
        }
        /// <summary>A set of string key and string value pairs to be sent to the affected users, unalterned by this service</summary>
        public List<KeyValuePair> CustomSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(CustomSettings)); }
            set { BackingStore?.Set(nameof(CustomSettings), value); }
        }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount {
            get { return BackingStore?.Get<int?>(nameof(DeployedAppCount)); }
            set { BackingStore?.Set(nameof(DeployedAppCount), value); }
        }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary {
            get { return BackingStore?.Get<ManagedAppPolicyDeploymentSummary>(nameof(DeploymentSummary)); }
            set { BackingStore?.Set(nameof(DeploymentSummary), value); }
        }
        /// <summary>Defines if any kind of lock must be required on device. (android only)</summary>
        public bool? DeviceLockRequired {
            get { return BackingStore?.Get<bool?>(nameof(DeviceLockRequired)); }
            set { BackingStore?.Set(nameof(DeviceLockRequired), value); }
        }
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled. (Android only)</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DisableAppEncryptionIfDeviceEncryptionIsEnabled)); }
            set { BackingStore?.Set(nameof(DisableAppEncryptionIfDeviceEncryptionIsEnabled), value); }
        }
        /// <summary>Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps. (iOS Only)</summary>
        public bool? DisableProtectionOfManagedOutboundOpenInData {
            get { return BackingStore?.Get<bool?>(nameof(DisableProtectionOfManagedOutboundOpenInData)); }
            set { BackingStore?.Set(nameof(DisableProtectionOfManagedOutboundOpenInData), value); }
        }
        /// <summary>Indicates whether managed-app data should be encrypted. (Android only)</summary>
        public bool? EncryptAppData {
            get { return BackingStore?.Get<bool?>(nameof(EncryptAppData)); }
            set { BackingStore?.Set(nameof(EncryptAppData), value); }
        }
        /// <summary>Android App packages in this list will be exempt from the policy and will be able to receive data from managed apps. (Android only)</summary>
        public List<KeyValuePair> ExemptedAppPackages {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(ExemptedAppPackages)); }
            set { BackingStore?.Set(nameof(ExemptedAppPackages), value); }
        }
        /// <summary>iOS Apps in this list will be exempt from the policy and will be able to receive data from managed apps. (iOS Only)</summary>
        public List<KeyValuePair> ExemptedAppProtocols {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(ExemptedAppProtocols)); }
            set { BackingStore?.Set(nameof(ExemptedAppProtocols), value); }
        }
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True. (iOS Only)</summary>
        public bool? FaceIdBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FaceIdBlocked)); }
            set { BackingStore?.Set(nameof(FaceIdBlocked), value); }
        }
        /// <summary>Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False. (iOS Only)</summary>
        public bool? FilterOpenInToOnlyManagedApps {
            get { return BackingStore?.Get<bool?>(nameof(FilterOpenInToOnlyManagedApps)); }
            set { BackingStore?.Set(nameof(FilterOpenInToOnlyManagedApps), value); }
        }
        /// <summary>Minimum version of the Company portal that must be installed on the device or app access will be blocked</summary>
        public string MinimumRequiredCompanyPortalVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredCompanyPortalVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredCompanyPortalVersion), value); }
        }
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app. (Android only)</summary>
        public string MinimumRequiredPatchVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredPatchVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredPatchVersion), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. (iOS Only)</summary>
        public string MinimumRequiredSdkVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredSdkVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredSdkVersion), value); }
        }
        /// <summary>Minimum version of the Company portal that must be installed on the device or the user will receive a warning</summary>
        public string MinimumWarningCompanyPortalVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningCompanyPortalVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningCompanyPortalVersion), value); }
        }
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app. (Android only)</summary>
        public string MinimumWarningPatchVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningPatchVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningPatchVersion), value); }
        }
        /// <summary>Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped</summary>
        public string MinimumWipeCompanyPortalVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipeCompanyPortalVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipeCompanyPortalVersion), value); }
        }
        /// <summary>Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data. (Android only)</summary>
        public string MinimumWipePatchVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipePatchVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipePatchVersion), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumWipeSdkVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipeSdkVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipeSdkVersion), value); }
        }
        /// <summary>Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps. (iOS Only)</summary>
        public bool? ProtectInboundDataFromUnknownSources {
            get { return BackingStore?.Get<bool?>(nameof(ProtectInboundDataFromUnknownSources)); }
            set { BackingStore?.Set(nameof(ProtectInboundDataFromUnknownSources), value); }
        }
        /// <summary>Defines the Android SafetyNet Apps Verification requirement for a managed app to work. Possible values are: none, enabled.</summary>
        public AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetAppsVerificationType?>(nameof(RequiredAndroidSafetyNetAppsVerificationType)); }
            set { BackingStore?.Set(nameof(RequiredAndroidSafetyNetAppsVerificationType), value); }
        }
        /// <summary>Defines the Android SafetyNet Device Attestation requirement for a managed app to work. Possible values are: none, basicIntegrity, basicIntegrityAndDeviceCertification.</summary>
        public AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetDeviceAttestationType?>(nameof(RequiredAndroidSafetyNetDeviceAttestationType)); }
            set { BackingStore?.Set(nameof(RequiredAndroidSafetyNetDeviceAttestationType), value); }
        }
        /// <summary>Defines the Android SafetyNet evaluation type requirement for a managed app to work. (Android Only). Possible values are: basic, hardwareBacked.</summary>
        public AndroidManagedAppSafetyNetEvaluationType? RequiredAndroidSafetyNetEvaluationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetEvaluationType?>(nameof(RequiredAndroidSafetyNetEvaluationType)); }
            set { BackingStore?.Set(nameof(RequiredAndroidSafetyNetEvaluationType), value); }
        }
        /// <summary>Indicates whether screen capture is blocked. (Android only)</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ScreenCaptureBlocked)); }
            set { BackingStore?.Set(nameof(ScreenCaptureBlocked), value); }
        }
        /// <summary>Defines if third party keyboards are allowed while accessing a managed app. (iOS Only)</summary>
        public bool? ThirdPartyKeyboardsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ThirdPartyKeyboardsBlocked)); }
            set { BackingStore?.Set(nameof(ThirdPartyKeyboardsBlocked), value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning</summary>
        public int? WarnAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>(nameof(WarnAfterCompanyPortalUpdateDeferralInDays)); }
            set { BackingStore?.Set(nameof(WarnAfterCompanyPortalUpdateDeferralInDays), value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped</summary>
        public int? WipeAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>(nameof(WipeAfterCompanyPortalUpdateDeferralInDays)); }
            set { BackingStore?.Set(nameof(WipeAfterCompanyPortalUpdateDeferralInDays), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedAndroidDeviceManufacturers", n => { AllowedAndroidDeviceManufacturers = n.GetStringValue(); } },
                {"allowedAndroidDeviceModels", n => { AllowedAndroidDeviceModels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedIosDeviceModels", n => { AllowedIosDeviceModels = n.GetStringValue(); } },
                {"appActionIfAndroidDeviceManufacturerNotAllowed", n => { AppActionIfAndroidDeviceManufacturerNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidDeviceModelNotAllowed", n => { AppActionIfAndroidDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidSafetyNetAppsVerificationFailed", n => { AppActionIfAndroidSafetyNetAppsVerificationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidSafetyNetDeviceAttestationFailed", n => { AppActionIfAndroidSafetyNetDeviceAttestationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDeviceLockNotSet", n => { AppActionIfDeviceLockNotSet = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanHigh", n => { AppActionIfDevicePasscodeComplexityLessThanHigh = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanLow", n => { AppActionIfDevicePasscodeComplexityLessThanLow = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanMedium", n => { AppActionIfDevicePasscodeComplexityLessThanMedium = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfIosDeviceModelNotAllowed", n => { AppActionIfIosDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appDataEncryptionType", n => { AppDataEncryptionType = n.GetEnumValue<ManagedAppDataEncryptionType>(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"biometricAuthenticationBlocked", n => { BiometricAuthenticationBlocked = n.GetBoolValue(); } },
                {"blockAfterCompanyPortalUpdateDeferralInDays", n => { BlockAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                {"connectToVpnOnLaunch", n => { ConnectToVpnOnLaunch = n.GetBoolValue(); } },
                {"customBrowserDisplayName", n => { CustomBrowserDisplayName = n.GetStringValue(); } },
                {"customBrowserPackageId", n => { CustomBrowserPackageId = n.GetStringValue(); } },
                {"customBrowserProtocol", n => { CustomBrowserProtocol = n.GetStringValue(); } },
                {"customDialerAppDisplayName", n => { CustomDialerAppDisplayName = n.GetStringValue(); } },
                {"customDialerAppPackageId", n => { CustomDialerAppPackageId = n.GetStringValue(); } },
                {"customDialerAppProtocol", n => { CustomDialerAppProtocol = n.GetStringValue(); } },
                {"customSettings", n => { CustomSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"deviceLockRequired", n => { DeviceLockRequired = n.GetBoolValue(); } },
                {"disableAppEncryptionIfDeviceEncryptionIsEnabled", n => { DisableAppEncryptionIfDeviceEncryptionIsEnabled = n.GetBoolValue(); } },
                {"disableProtectionOfManagedOutboundOpenInData", n => { DisableProtectionOfManagedOutboundOpenInData = n.GetBoolValue(); } },
                {"encryptAppData", n => { EncryptAppData = n.GetBoolValue(); } },
                {"exemptedAppPackages", n => { ExemptedAppPackages = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"exemptedAppProtocols", n => { ExemptedAppProtocols = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"faceIdBlocked", n => { FaceIdBlocked = n.GetBoolValue(); } },
                {"filterOpenInToOnlyManagedApps", n => { FilterOpenInToOnlyManagedApps = n.GetBoolValue(); } },
                {"minimumRequiredCompanyPortalVersion", n => { MinimumRequiredCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumRequiredPatchVersion", n => { MinimumRequiredPatchVersion = n.GetStringValue(); } },
                {"minimumRequiredSdkVersion", n => { MinimumRequiredSdkVersion = n.GetStringValue(); } },
                {"minimumWarningCompanyPortalVersion", n => { MinimumWarningCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWarningPatchVersion", n => { MinimumWarningPatchVersion = n.GetStringValue(); } },
                {"minimumWipeCompanyPortalVersion", n => { MinimumWipeCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWipePatchVersion", n => { MinimumWipePatchVersion = n.GetStringValue(); } },
                {"minimumWipeSdkVersion", n => { MinimumWipeSdkVersion = n.GetStringValue(); } },
                {"protectInboundDataFromUnknownSources", n => { ProtectInboundDataFromUnknownSources = n.GetBoolValue(); } },
                {"requiredAndroidSafetyNetAppsVerificationType", n => { RequiredAndroidSafetyNetAppsVerificationType = n.GetEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>(); } },
                {"requiredAndroidSafetyNetDeviceAttestationType", n => { RequiredAndroidSafetyNetDeviceAttestationType = n.GetEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>(); } },
                {"requiredAndroidSafetyNetEvaluationType", n => { RequiredAndroidSafetyNetEvaluationType = n.GetEnumValue<AndroidManagedAppSafetyNetEvaluationType>(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"thirdPartyKeyboardsBlocked", n => { ThirdPartyKeyboardsBlocked = n.GetBoolValue(); } },
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
            writer.WriteStringValue("allowedIosDeviceModels", AllowedIosDeviceModels);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceManufacturerNotAllowed", AppActionIfAndroidDeviceManufacturerNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceModelNotAllowed", AppActionIfAndroidDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetAppsVerificationFailed", AppActionIfAndroidSafetyNetAppsVerificationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetDeviceAttestationFailed", AppActionIfAndroidSafetyNetDeviceAttestationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDeviceLockNotSet", AppActionIfDeviceLockNotSet);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanHigh", AppActionIfDevicePasscodeComplexityLessThanHigh);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanLow", AppActionIfDevicePasscodeComplexityLessThanLow);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanMedium", AppActionIfDevicePasscodeComplexityLessThanMedium);
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
