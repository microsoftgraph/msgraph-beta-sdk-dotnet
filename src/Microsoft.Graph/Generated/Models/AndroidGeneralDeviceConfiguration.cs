using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to block clipboard sharing to copy and paste between applications.</summary>
        public bool? AppsBlockClipboardSharing {
            get { return BackingStore?.Get<bool?>(nameof(AppsBlockClipboardSharing)); }
            set { BackingStore?.Set(nameof(AppsBlockClipboardSharing), value); }
        }
        /// <summary>Indicates whether or not to block copy and paste within applications.</summary>
        public bool? AppsBlockCopyPaste {
            get { return BackingStore?.Get<bool?>(nameof(AppsBlockCopyPaste)); }
            set { BackingStore?.Set(nameof(AppsBlockCopyPaste), value); }
        }
        /// <summary>Indicates whether or not to block the YouTube app.</summary>
        public bool? AppsBlockYouTube {
            get { return BackingStore?.Get<bool?>(nameof(AppsBlockYouTube)); }
            set { BackingStore?.Set(nameof(AppsBlockYouTube), value); }
        }
        /// <summary>List of apps to be hidden on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsHideList {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(AppsHideList)); }
            set { BackingStore?.Set(nameof(AppsHideList), value); }
        }
        /// <summary>List of apps which can be installed on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsInstallAllowList {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(AppsInstallAllowList)); }
            set { BackingStore?.Set(nameof(AppsInstallAllowList), value); }
        }
        /// <summary>List of apps which are blocked from being launched on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsLaunchBlockList {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(AppsLaunchBlockList)); }
            set { BackingStore?.Set(nameof(AppsLaunchBlockList), value); }
        }
        /// <summary>Indicates whether or not to block Bluetooth.</summary>
        public bool? BluetoothBlocked {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlocked)); }
            set { BackingStore?.Set(nameof(BluetoothBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the use of the camera.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>(nameof(CameraBlocked)); }
            set { BackingStore?.Set(nameof(CameraBlocked), value); }
        }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockDataRoaming)); }
            set { BackingStore?.Set(nameof(CellularBlockDataRoaming), value); }
        }
        /// <summary>Indicates whether or not to block SMS/MMS messaging.</summary>
        public bool? CellularBlockMessaging {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockMessaging)); }
            set { BackingStore?.Set(nameof(CellularBlockMessaging), value); }
        }
        /// <summary>Indicates whether or not to block voice roaming.</summary>
        public bool? CellularBlockVoiceRoaming {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockVoiceRoaming)); }
            set { BackingStore?.Set(nameof(CellularBlockVoiceRoaming), value); }
        }
        /// <summary>Indicates whether or not to block syncing Wi-Fi tethering.</summary>
        public bool? CellularBlockWiFiTethering {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockWiFiTethering)); }
            set { BackingStore?.Set(nameof(CellularBlockWiFiTethering), value); }
        }
        /// <summary>Type of list that is in the CompliantAppsList. Possible values are: none, appsInListCompliant, appsNotInListCompliant.</summary>
        public AppListType? CompliantAppListType {
            get { return BackingStore?.Get<AppListType?>(nameof(CompliantAppListType)); }
            set { BackingStore?.Set(nameof(CompliantAppListType), value); }
        }
        /// <summary>List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.</summary>
        public List<AppListItem> CompliantAppsList {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(CompliantAppsList)); }
            set { BackingStore?.Set(nameof(CompliantAppsList), value); }
        }
        /// <summary>Indicates whether or not to block changing date and time while in KNOX Mode.</summary>
        public bool? DateAndTimeBlockChanges {
            get { return BackingStore?.Get<bool?>(nameof(DateAndTimeBlockChanges)); }
            set { BackingStore?.Set(nameof(DateAndTimeBlockChanges), value); }
        }
        /// <summary>Indicates whether or not to allow device sharing mode.</summary>
        public bool? DeviceSharingAllowed {
            get { return BackingStore?.Get<bool?>(nameof(DeviceSharingAllowed)); }
            set { BackingStore?.Set(nameof(DeviceSharingAllowed), value); }
        }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticDataBlockSubmission {
            get { return BackingStore?.Get<bool?>(nameof(DiagnosticDataBlockSubmission)); }
            set { BackingStore?.Set(nameof(DiagnosticDataBlockSubmission), value); }
        }
        /// <summary>Indicates whether or not to block user performing a factory reset.</summary>
        public bool? FactoryResetBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FactoryResetBlocked)); }
            set { BackingStore?.Set(nameof(FactoryResetBlocked), value); }
        }
        /// <summary>Indicates whether or not to block Google account auto sync.</summary>
        public bool? GoogleAccountBlockAutoSync {
            get { return BackingStore?.Get<bool?>(nameof(GoogleAccountBlockAutoSync)); }
            set { BackingStore?.Set(nameof(GoogleAccountBlockAutoSync), value); }
        }
        /// <summary>Indicates whether or not to block the Google Play store.</summary>
        public bool? GooglePlayStoreBlocked {
            get { return BackingStore?.Get<bool?>(nameof(GooglePlayStoreBlocked)); }
            set { BackingStore?.Set(nameof(GooglePlayStoreBlocked), value); }
        }
        /// <summary>A list of apps that will be allowed to run when the device is in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> KioskModeApps {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(KioskModeApps)); }
            set { BackingStore?.Set(nameof(KioskModeApps), value); }
        }
        /// <summary>Indicates whether or not to block the screen sleep button while in Kiosk Mode.</summary>
        public bool? KioskModeBlockSleepButton {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeBlockSleepButton)); }
            set { BackingStore?.Set(nameof(KioskModeBlockSleepButton), value); }
        }
        /// <summary>Indicates whether or not to block the volume buttons while in Kiosk Mode.</summary>
        public bool? KioskModeBlockVolumeButtons {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeBlockVolumeButtons)); }
            set { BackingStore?.Set(nameof(KioskModeBlockVolumeButtons), value); }
        }
        /// <summary>Indicates whether or not to block location services.</summary>
        public bool? LocationServicesBlocked {
            get { return BackingStore?.Get<bool?>(nameof(LocationServicesBlocked)); }
            set { BackingStore?.Set(nameof(LocationServicesBlocked), value); }
        }
        /// <summary>Indicates whether or not to block Near-Field Communication.</summary>
        public bool? NfcBlocked {
            get { return BackingStore?.Get<bool?>(nameof(NfcBlocked)); }
            set { BackingStore?.Set(nameof(NfcBlocked), value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasswordBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockFingerprintUnlock)); }
            set { BackingStore?.Set(nameof(PasswordBlockFingerprintUnlock), value); }
        }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents.</summary>
        public bool? PasswordBlockTrustAgents {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockTrustAgents)); }
            set { BackingStore?.Set(nameof(PasswordBlockTrustAgents), value); }
        }
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>Minimum length of passwords. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout), value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>Indicates whether or not to require a password.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequired)); }
            set { BackingStore?.Set(nameof(PasswordRequired), value); }
        }
        /// <summary>Type of password that is required. Possible values are: deviceDefault, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, numeric, numericComplex, any.</summary>
        public AndroidRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidRequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Number of sign in failures allowed before factory reset. Valid values 1 to 16</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(PasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(PasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>Indicates whether or not to block powering off the device.</summary>
        public bool? PowerOffBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PowerOffBlocked)); }
            set { BackingStore?.Set(nameof(PowerOffBlocked), value); }
        }
        /// <summary>Indicates the required password complexity on Android. One of: NONE, LOW, MEDIUM, HIGH. This is an API targeted to Android 11+. Possible values are: none, low, medium, high.</summary>
        public AndroidRequiredPasswordComplexity? RequiredPasswordComplexity {
            get { return BackingStore?.Get<AndroidRequiredPasswordComplexity?>(nameof(RequiredPasswordComplexity)); }
            set { BackingStore?.Set(nameof(RequiredPasswordComplexity), value); }
        }
        /// <summary>Indicates whether or not to block screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ScreenCaptureBlocked)); }
            set { BackingStore?.Set(nameof(ScreenCaptureBlocked), value); }
        }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireVerifyApps)); }
            set { BackingStore?.Set(nameof(SecurityRequireVerifyApps), value); }
        }
        /// <summary>Indicates whether or not to block Google Backup.</summary>
        public bool? StorageBlockGoogleBackup {
            get { return BackingStore?.Get<bool?>(nameof(StorageBlockGoogleBackup)); }
            set { BackingStore?.Set(nameof(StorageBlockGoogleBackup), value); }
        }
        /// <summary>Indicates whether or not to block removable storage usage.</summary>
        public bool? StorageBlockRemovableStorage {
            get { return BackingStore?.Get<bool?>(nameof(StorageBlockRemovableStorage)); }
            set { BackingStore?.Set(nameof(StorageBlockRemovableStorage), value); }
        }
        /// <summary>Indicates whether or not to require device encryption.</summary>
        public bool? StorageRequireDeviceEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireDeviceEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireDeviceEncryption), value); }
        }
        /// <summary>Indicates whether or not to require removable storage encryption.</summary>
        public bool? StorageRequireRemovableStorageEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireRemovableStorageEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireRemovableStorageEncryption), value); }
        }
        /// <summary>Indicates whether or not to block the use of the Voice Assistant.</summary>
        public bool? VoiceAssistantBlocked {
            get { return BackingStore?.Get<bool?>(nameof(VoiceAssistantBlocked)); }
            set { BackingStore?.Set(nameof(VoiceAssistantBlocked), value); }
        }
        /// <summary>Indicates whether or not to block voice dialing.</summary>
        public bool? VoiceDialingBlocked {
            get { return BackingStore?.Get<bool?>(nameof(VoiceDialingBlocked)); }
            set { BackingStore?.Set(nameof(VoiceDialingBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the web browser&apos;s auto fill feature.</summary>
        public bool? WebBrowserBlockAutofill {
            get { return BackingStore?.Get<bool?>(nameof(WebBrowserBlockAutofill)); }
            set { BackingStore?.Set(nameof(WebBrowserBlockAutofill), value); }
        }
        /// <summary>Indicates whether or not to block the web browser.</summary>
        public bool? WebBrowserBlocked {
            get { return BackingStore?.Get<bool?>(nameof(WebBrowserBlocked)); }
            set { BackingStore?.Set(nameof(WebBrowserBlocked), value); }
        }
        /// <summary>Indicates whether or not to block JavaScript within the web browser.</summary>
        public bool? WebBrowserBlockJavaScript {
            get { return BackingStore?.Get<bool?>(nameof(WebBrowserBlockJavaScript)); }
            set { BackingStore?.Set(nameof(WebBrowserBlockJavaScript), value); }
        }
        /// <summary>Indicates whether or not to block popups within the web browser.</summary>
        public bool? WebBrowserBlockPopups {
            get { return BackingStore?.Get<bool?>(nameof(WebBrowserBlockPopups)); }
            set { BackingStore?.Set(nameof(WebBrowserBlockPopups), value); }
        }
        /// <summary>Cookie settings within the web browser. Possible values are: browserDefault, blockAlways, allowCurrentWebSite, allowFromWebsitesVisited, allowAlways.</summary>
        public Microsoft.Graph.Beta.Models.WebBrowserCookieSettings? WebBrowserCookieSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WebBrowserCookieSettings?>(nameof(WebBrowserCookieSettings)); }
            set { BackingStore?.Set(nameof(WebBrowserCookieSettings), value); }
        }
        /// <summary>Indicates whether or not to block syncing Wi-Fi.</summary>
        public bool? WiFiBlocked {
            get { return BackingStore?.Get<bool?>(nameof(WiFiBlocked)); }
            set { BackingStore?.Set(nameof(WiFiBlocked), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appsBlockClipboardSharing", n => { AppsBlockClipboardSharing = n.GetBoolValue(); } },
                {"appsBlockCopyPaste", n => { AppsBlockCopyPaste = n.GetBoolValue(); } },
                {"appsBlockYouTube", n => { AppsBlockYouTube = n.GetBoolValue(); } },
                {"appsHideList", n => { AppsHideList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"appsInstallAllowList", n => { AppsInstallAllowList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"appsLaunchBlockList", n => { AppsLaunchBlockList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"bluetoothBlocked", n => { BluetoothBlocked = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                {"cellularBlockMessaging", n => { CellularBlockMessaging = n.GetBoolValue(); } },
                {"cellularBlockVoiceRoaming", n => { CellularBlockVoiceRoaming = n.GetBoolValue(); } },
                {"cellularBlockWiFiTethering", n => { CellularBlockWiFiTethering = n.GetBoolValue(); } },
                {"compliantAppListType", n => { CompliantAppListType = n.GetEnumValue<AppListType>(); } },
                {"compliantAppsList", n => { CompliantAppsList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"dateAndTimeBlockChanges", n => { DateAndTimeBlockChanges = n.GetBoolValue(); } },
                {"deviceSharingAllowed", n => { DeviceSharingAllowed = n.GetBoolValue(); } },
                {"diagnosticDataBlockSubmission", n => { DiagnosticDataBlockSubmission = n.GetBoolValue(); } },
                {"factoryResetBlocked", n => { FactoryResetBlocked = n.GetBoolValue(); } },
                {"googleAccountBlockAutoSync", n => { GoogleAccountBlockAutoSync = n.GetBoolValue(); } },
                {"googlePlayStoreBlocked", n => { GooglePlayStoreBlocked = n.GetBoolValue(); } },
                {"kioskModeApps", n => { KioskModeApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"kioskModeBlockSleepButton", n => { KioskModeBlockSleepButton = n.GetBoolValue(); } },
                {"kioskModeBlockVolumeButtons", n => { KioskModeBlockVolumeButtons = n.GetBoolValue(); } },
                {"locationServicesBlocked", n => { LocationServicesBlocked = n.GetBoolValue(); } },
                {"nfcBlocked", n => { NfcBlocked = n.GetBoolValue(); } },
                {"passwordBlockFingerprintUnlock", n => { PasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passwordBlockTrustAgents", n => { PasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidRequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"powerOffBlocked", n => { PowerOffBlocked = n.GetBoolValue(); } },
                {"requiredPasswordComplexity", n => { RequiredPasswordComplexity = n.GetEnumValue<AndroidRequiredPasswordComplexity>(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"storageBlockGoogleBackup", n => { StorageBlockGoogleBackup = n.GetBoolValue(); } },
                {"storageBlockRemovableStorage", n => { StorageBlockRemovableStorage = n.GetBoolValue(); } },
                {"storageRequireDeviceEncryption", n => { StorageRequireDeviceEncryption = n.GetBoolValue(); } },
                {"storageRequireRemovableStorageEncryption", n => { StorageRequireRemovableStorageEncryption = n.GetBoolValue(); } },
                {"voiceAssistantBlocked", n => { VoiceAssistantBlocked = n.GetBoolValue(); } },
                {"voiceDialingBlocked", n => { VoiceDialingBlocked = n.GetBoolValue(); } },
                {"webBrowserBlockAutofill", n => { WebBrowserBlockAutofill = n.GetBoolValue(); } },
                {"webBrowserBlocked", n => { WebBrowserBlocked = n.GetBoolValue(); } },
                {"webBrowserBlockJavaScript", n => { WebBrowserBlockJavaScript = n.GetBoolValue(); } },
                {"webBrowserBlockPopups", n => { WebBrowserBlockPopups = n.GetBoolValue(); } },
                {"webBrowserCookieSettings", n => { WebBrowserCookieSettings = n.GetEnumValue<WebBrowserCookieSettings>(); } },
                {"wiFiBlocked", n => { WiFiBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appsBlockClipboardSharing", AppsBlockClipboardSharing);
            writer.WriteBoolValue("appsBlockCopyPaste", AppsBlockCopyPaste);
            writer.WriteBoolValue("appsBlockYouTube", AppsBlockYouTube);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsHideList", AppsHideList);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsInstallAllowList", AppsInstallAllowList);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsLaunchBlockList", AppsLaunchBlockList);
            writer.WriteBoolValue("bluetoothBlocked", BluetoothBlocked);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("cellularBlockMessaging", CellularBlockMessaging);
            writer.WriteBoolValue("cellularBlockVoiceRoaming", CellularBlockVoiceRoaming);
            writer.WriteBoolValue("cellularBlockWiFiTethering", CellularBlockWiFiTethering);
            writer.WriteEnumValue<AppListType>("compliantAppListType", CompliantAppListType);
            writer.WriteCollectionOfObjectValues<AppListItem>("compliantAppsList", CompliantAppsList);
            writer.WriteBoolValue("dateAndTimeBlockChanges", DateAndTimeBlockChanges);
            writer.WriteBoolValue("deviceSharingAllowed", DeviceSharingAllowed);
            writer.WriteBoolValue("diagnosticDataBlockSubmission", DiagnosticDataBlockSubmission);
            writer.WriteBoolValue("factoryResetBlocked", FactoryResetBlocked);
            writer.WriteBoolValue("googleAccountBlockAutoSync", GoogleAccountBlockAutoSync);
            writer.WriteBoolValue("googlePlayStoreBlocked", GooglePlayStoreBlocked);
            writer.WriteCollectionOfObjectValues<AppListItem>("kioskModeApps", KioskModeApps);
            writer.WriteBoolValue("kioskModeBlockSleepButton", KioskModeBlockSleepButton);
            writer.WriteBoolValue("kioskModeBlockVolumeButtons", KioskModeBlockVolumeButtons);
            writer.WriteBoolValue("locationServicesBlocked", LocationServicesBlocked);
            writer.WriteBoolValue("nfcBlocked", NfcBlocked);
            writer.WriteBoolValue("passwordBlockFingerprintUnlock", PasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("passwordBlockTrustAgents", PasswordBlockTrustAgents);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("powerOffBlocked", PowerOffBlocked);
            writer.WriteEnumValue<AndroidRequiredPasswordComplexity>("requiredPasswordComplexity", RequiredPasswordComplexity);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteBoolValue("storageBlockGoogleBackup", StorageBlockGoogleBackup);
            writer.WriteBoolValue("storageBlockRemovableStorage", StorageBlockRemovableStorage);
            writer.WriteBoolValue("storageRequireDeviceEncryption", StorageRequireDeviceEncryption);
            writer.WriteBoolValue("storageRequireRemovableStorageEncryption", StorageRequireRemovableStorageEncryption);
            writer.WriteBoolValue("voiceAssistantBlocked", VoiceAssistantBlocked);
            writer.WriteBoolValue("voiceDialingBlocked", VoiceDialingBlocked);
            writer.WriteBoolValue("webBrowserBlockAutofill", WebBrowserBlockAutofill);
            writer.WriteBoolValue("webBrowserBlocked", WebBrowserBlocked);
            writer.WriteBoolValue("webBrowserBlockJavaScript", WebBrowserBlockJavaScript);
            writer.WriteBoolValue("webBrowserBlockPopups", WebBrowserBlockPopups);
            writer.WriteEnumValue<WebBrowserCookieSettings>("webBrowserCookieSettings", WebBrowserCookieSettings);
            writer.WriteBoolValue("wiFiBlocked", WiFiBlocked);
        }
    }
}
