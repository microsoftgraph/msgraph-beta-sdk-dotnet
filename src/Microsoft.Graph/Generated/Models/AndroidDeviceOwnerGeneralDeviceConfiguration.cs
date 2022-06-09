using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not adding or removing accounts is disabled.</summary>
        public bool? AccountsBlockModification {
            get { return BackingStore?.Get<bool?>(nameof(AccountsBlockModification)); }
            set { BackingStore?.Set(nameof(AccountsBlockModification), value); }
        }
        /// <summary>Indicates whether or not the user is allowed to enable to unknown sources setting.</summary>
        public bool? AppsAllowInstallFromUnknownSources {
            get { return BackingStore?.Get<bool?>(nameof(AppsAllowInstallFromUnknownSources)); }
            set { BackingStore?.Set(nameof(AppsAllowInstallFromUnknownSources), value); }
        }
        /// <summary>Indicates the value of the app auto update policy. Possible values are: notConfigured, userChoice, never, wiFiOnly, always.</summary>
        public AndroidDeviceOwnerAppAutoUpdatePolicyType? AppsAutoUpdatePolicy {
            get { return BackingStore?.Get<AndroidDeviceOwnerAppAutoUpdatePolicyType?>(nameof(AppsAutoUpdatePolicy)); }
            set { BackingStore?.Set(nameof(AppsAutoUpdatePolicy), value); }
        }
        /// <summary>Indicates the permission policy for requests for runtime permissions if one is not defined for the app specifically. Possible values are: deviceDefault, prompt, autoGrant, autoDeny.</summary>
        public AndroidDeviceOwnerDefaultAppPermissionPolicyType? AppsDefaultPermissionPolicy {
            get { return BackingStore?.Get<AndroidDeviceOwnerDefaultAppPermissionPolicyType?>(nameof(AppsDefaultPermissionPolicy)); }
            set { BackingStore?.Set(nameof(AppsDefaultPermissionPolicy), value); }
        }
        /// <summary>Whether or not to recommend all apps skip any first-time-use hints they may have added.</summary>
        public bool? AppsRecommendSkippingFirstUseHints {
            get { return BackingStore?.Get<bool?>(nameof(AppsRecommendSkippingFirstUseHints)); }
            set { BackingStore?.Set(nameof(AppsRecommendSkippingFirstUseHints), value); }
        }
        /// <summary>A list of managed apps that will have their data cleared during a global sign-out in AAD shared device mode. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AzureAdSharedDeviceDataClearApps {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(AzureAdSharedDeviceDataClearApps)); }
            set { BackingStore?.Set(nameof(AzureAdSharedDeviceDataClearApps), value); }
        }
        /// <summary>Indicates whether or not to block a user from configuring bluetooth.</summary>
        public bool? BluetoothBlockConfiguration {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlockConfiguration)); }
            set { BackingStore?.Set(nameof(BluetoothBlockConfiguration), value); }
        }
        /// <summary>Indicates whether or not to block a user from sharing contacts via bluetooth.</summary>
        public bool? BluetoothBlockContactSharing {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlockContactSharing)); }
            set { BackingStore?.Set(nameof(BluetoothBlockContactSharing), value); }
        }
        /// <summary>Indicates whether or not to disable the use of the camera.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>(nameof(CameraBlocked)); }
            set { BackingStore?.Set(nameof(CameraBlocked), value); }
        }
        /// <summary>Indicates whether or not to block Wi-Fi tethering.</summary>
        public bool? CellularBlockWiFiTethering {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockWiFiTethering)); }
            set { BackingStore?.Set(nameof(CellularBlockWiFiTethering), value); }
        }
        /// <summary>Indicates whether or not to block users from any certificate credential configuration.</summary>
        public bool? CertificateCredentialConfigurationDisabled {
            get { return BackingStore?.Get<bool?>(nameof(CertificateCredentialConfigurationDisabled)); }
            set { BackingStore?.Set(nameof(CertificateCredentialConfigurationDisabled), value); }
        }
        /// <summary>Indicates whether or not text copied from one profile (personal or work) can be pasted in the other.</summary>
        public bool? CrossProfilePoliciesAllowCopyPaste {
            get { return BackingStore?.Get<bool?>(nameof(CrossProfilePoliciesAllowCopyPaste)); }
            set { BackingStore?.Set(nameof(CrossProfilePoliciesAllowCopyPaste), value); }
        }
        /// <summary>Indicates whether data from one profile (personal or work) can be shared with apps in the other profile. Possible values are: notConfigured, crossProfileDataSharingBlocked, dataSharingFromWorkToPersonalBlocked, crossProfileDataSharingAllowed, unkownFutureValue.</summary>
        public AndroidDeviceOwnerCrossProfileDataSharing? CrossProfilePoliciesAllowDataSharing {
            get { return BackingStore?.Get<AndroidDeviceOwnerCrossProfileDataSharing?>(nameof(CrossProfilePoliciesAllowDataSharing)); }
            set { BackingStore?.Set(nameof(CrossProfilePoliciesAllowDataSharing), value); }
        }
        /// <summary>Indicates whether or not contacts stored in work profile are shown in personal profile contact searches/incoming calls.</summary>
        public bool? CrossProfilePoliciesShowWorkContactsInPersonalProfile {
            get { return BackingStore?.Get<bool?>(nameof(CrossProfilePoliciesShowWorkContactsInPersonalProfile)); }
            set { BackingStore?.Set(nameof(CrossProfilePoliciesShowWorkContactsInPersonalProfile), value); }
        }
        /// <summary>Indicates whether or not to block a user from data roaming.</summary>
        public bool? DataRoamingBlocked {
            get { return BackingStore?.Get<bool?>(nameof(DataRoamingBlocked)); }
            set { BackingStore?.Set(nameof(DataRoamingBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from manually changing the date or time on the device</summary>
        public bool? DateTimeConfigurationBlocked {
            get { return BackingStore?.Get<bool?>(nameof(DateTimeConfigurationBlocked)); }
            set { BackingStore?.Set(nameof(DateTimeConfigurationBlocked), value); }
        }
        /// <summary>Represents the customized detailed help text provided to users when they attempt to modify managed settings on their device.</summary>
        public AndroidDeviceOwnerUserFacingMessage DetailedHelpText {
            get { return BackingStore?.Get<AndroidDeviceOwnerUserFacingMessage>(nameof(DetailedHelpText)); }
            set { BackingStore?.Set(nameof(DetailedHelpText), value); }
        }
        /// <summary>Indicates which enrollment profile you want to configure. Possible values are: notConfigured, dedicatedDevice, fullyManaged.</summary>
        public AndroidDeviceOwnerEnrollmentProfileType? EnrollmentProfile {
            get { return BackingStore?.Get<AndroidDeviceOwnerEnrollmentProfileType?>(nameof(EnrollmentProfile)); }
            set { BackingStore?.Set(nameof(EnrollmentProfile), value); }
        }
        /// <summary>Indicates whether or not the factory reset option in settings is disabled.</summary>
        public bool? FactoryResetBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FactoryResetBlocked)); }
            set { BackingStore?.Set(nameof(FactoryResetBlocked), value); }
        }
        /// <summary>List of Google account emails that will be required to authenticate after a device is factory reset before it can be set up.</summary>
        public List<string> FactoryResetDeviceAdministratorEmails {
            get { return BackingStore?.Get<List<string>>(nameof(FactoryResetDeviceAdministratorEmails)); }
            set { BackingStore?.Set(nameof(FactoryResetDeviceAdministratorEmails), value); }
        }
        /// <summary>Proxy is set up directly with host, port and excluded hosts.</summary>
        public AndroidDeviceOwnerGlobalProxy GlobalProxy {
            get { return BackingStore?.Get<AndroidDeviceOwnerGlobalProxy>(nameof(GlobalProxy)); }
            set { BackingStore?.Set(nameof(GlobalProxy), value); }
        }
        /// <summary>Indicates whether or not google accounts will be blocked.</summary>
        public bool? GoogleAccountsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(GoogleAccountsBlocked)); }
            set { BackingStore?.Set(nameof(GoogleAccountsBlocked), value); }
        }
        /// <summary>Indicates whether a user can access the device&apos;s Settings app while in Kiosk Mode.</summary>
        public bool? KioskCustomizationDeviceSettingsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(KioskCustomizationDeviceSettingsBlocked)); }
            set { BackingStore?.Set(nameof(KioskCustomizationDeviceSettingsBlocked), value); }
        }
        /// <summary>Whether the power menu is shown when a user long presses the Power button of a device in Kiosk Mode.</summary>
        public bool? KioskCustomizationPowerButtonActionsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(KioskCustomizationPowerButtonActionsBlocked)); }
            set { BackingStore?.Set(nameof(KioskCustomizationPowerButtonActionsBlocked), value); }
        }
        /// <summary>Indicates whether system info and notifications are disabled in Kiosk Mode. Possible values are: notConfigured, notificationsAndSystemInfoEnabled, systemInfoOnly.</summary>
        public AndroidDeviceOwnerKioskCustomizationStatusBar? KioskCustomizationStatusBar {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskCustomizationStatusBar?>(nameof(KioskCustomizationStatusBar)); }
            set { BackingStore?.Set(nameof(KioskCustomizationStatusBar), value); }
        }
        /// <summary>Indicates whether system error dialogs for crashed or unresponsive apps are shown in Kiosk Mode.</summary>
        public bool? KioskCustomizationSystemErrorWarnings {
            get { return BackingStore?.Get<bool?>(nameof(KioskCustomizationSystemErrorWarnings)); }
            set { BackingStore?.Set(nameof(KioskCustomizationSystemErrorWarnings), value); }
        }
        /// <summary>Indicates which navigation features are enabled in Kiosk Mode. Possible values are: notConfigured, navigationEnabled, homeButtonOnly.</summary>
        public AndroidDeviceOwnerKioskCustomizationSystemNavigation? KioskCustomizationSystemNavigation {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskCustomizationSystemNavigation?>(nameof(KioskCustomizationSystemNavigation)); }
            set { BackingStore?.Set(nameof(KioskCustomizationSystemNavigation), value); }
        }
        /// <summary>Whether or not to enable app ordering in Kiosk Mode.</summary>
        public bool? KioskModeAppOrderEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAppOrderEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeAppOrderEnabled), value); }
        }
        /// <summary>The ordering of items on Kiosk Mode Managed Home Screen. This collection can contain a maximum of 500 elements.</summary>
        public List<AndroidDeviceOwnerKioskModeAppPositionItem> KioskModeAppPositions {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeAppPositionItem>>(nameof(KioskModeAppPositions)); }
            set { BackingStore?.Set(nameof(KioskModeAppPositions), value); }
        }
        /// <summary>A list of managed apps that will be shown when the device is in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> KioskModeApps {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(KioskModeApps)); }
            set { BackingStore?.Set(nameof(KioskModeApps), value); }
        }
        /// <summary>Whether or not to alphabetize applications within a folder in Kiosk Mode.</summary>
        public bool? KioskModeAppsInFolderOrderedByName {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAppsInFolderOrderedByName)); }
            set { BackingStore?.Set(nameof(KioskModeAppsInFolderOrderedByName), value); }
        }
        /// <summary>Whether or not to allow a user to configure Bluetooth settings in Kiosk Mode.</summary>
        public bool? KioskModeBluetoothConfigurationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeBluetoothConfigurationEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeBluetoothConfigurationEnabled), value); }
        }
        /// <summary>Whether or not to allow a user to easy access to the debug menu in Kiosk Mode.</summary>
        public bool? KioskModeDebugMenuEasyAccessEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeDebugMenuEasyAccessEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeDebugMenuEasyAccessEnabled), value); }
        }
        /// <summary>Exit code to allow a user to escape from Kiosk Mode when the device is in Kiosk Mode.</summary>
        public string KioskModeExitCode {
            get { return BackingStore?.Get<string>(nameof(KioskModeExitCode)); }
            set { BackingStore?.Set(nameof(KioskModeExitCode), value); }
        }
        /// <summary>Whether or not to allow a user to use the flashlight in Kiosk Mode.</summary>
        public bool? KioskModeFlashlightConfigurationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeFlashlightConfigurationEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeFlashlightConfigurationEnabled), value); }
        }
        /// <summary>Folder icon configuration for managed home screen in Kiosk Mode. Possible values are: notConfigured, darkSquare, darkCircle, lightSquare, lightCircle.</summary>
        public AndroidDeviceOwnerKioskModeFolderIcon? KioskModeFolderIcon {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskModeFolderIcon?>(nameof(KioskModeFolderIcon)); }
            set { BackingStore?.Set(nameof(KioskModeFolderIcon), value); }
        }
        /// <summary>Number of rows for Managed Home Screen grid with app ordering enabled in Kiosk Mode. Valid values 1 to 9999999</summary>
        public int? KioskModeGridHeight {
            get { return BackingStore?.Get<int?>(nameof(KioskModeGridHeight)); }
            set { BackingStore?.Set(nameof(KioskModeGridHeight), value); }
        }
        /// <summary>Number of columns for Managed Home Screen grid with app ordering enabled in Kiosk Mode. Valid values 1 to 9999999</summary>
        public int? KioskModeGridWidth {
            get { return BackingStore?.Get<int?>(nameof(KioskModeGridWidth)); }
            set { BackingStore?.Set(nameof(KioskModeGridWidth), value); }
        }
        /// <summary>Icon size configuration for managed home screen in Kiosk Mode. Possible values are: notConfigured, smallest, small, regular, large, largest.</summary>
        public AndroidDeviceOwnerKioskModeIconSize? KioskModeIconSize {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskModeIconSize?>(nameof(KioskModeIconSize)); }
            set { BackingStore?.Set(nameof(KioskModeIconSize), value); }
        }
        /// <summary>Whether or not to lock home screen to the end user in Kiosk Mode.</summary>
        public bool? KioskModeLockHomeScreen {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeLockHomeScreen)); }
            set { BackingStore?.Set(nameof(KioskModeLockHomeScreen), value); }
        }
        /// <summary>A list of managed folders for a device in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
        public List<AndroidDeviceOwnerKioskModeManagedFolder> KioskModeManagedFolders {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeManagedFolder>>(nameof(KioskModeManagedFolders)); }
            set { BackingStore?.Set(nameof(KioskModeManagedFolders), value); }
        }
        /// <summary>Whether or not to automatically sign-out of MHS and Shared device mode applications after inactive for Managed Home Screen.</summary>
        public bool? KioskModeManagedHomeScreenAutoSignout {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeManagedHomeScreenAutoSignout)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenAutoSignout), value); }
        }
        /// <summary>Number of seconds to give user notice before automatically signing them out for Managed Home Screen. Valid values 0 to 9999999</summary>
        public int? KioskModeManagedHomeScreenInactiveSignOutDelayInSeconds {
            get { return BackingStore?.Get<int?>(nameof(KioskModeManagedHomeScreenInactiveSignOutDelayInSeconds)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenInactiveSignOutDelayInSeconds), value); }
        }
        /// <summary>Number of seconds device is inactive before automatically signing user out for Managed Home Screen. Valid values 0 to 9999999</summary>
        public int? KioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds {
            get { return BackingStore?.Get<int?>(nameof(KioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds), value); }
        }
        /// <summary>Complexity of PIN for sign-in session for Managed Home Screen. Possible values are: notConfigured, simple, complex.</summary>
        public Microsoft.Graph.Beta.Models.KioskModeManagedHomeScreenPinComplexity? KioskModeManagedHomeScreenPinComplexity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KioskModeManagedHomeScreenPinComplexity?>(nameof(KioskModeManagedHomeScreenPinComplexity)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenPinComplexity), value); }
        }
        /// <summary>Whether or not require user to set a PIN for sign-in session for Managed Home Screen.</summary>
        public bool? KioskModeManagedHomeScreenPinRequired {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeManagedHomeScreenPinRequired)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenPinRequired), value); }
        }
        /// <summary>Whether or not required user to enter session PIN if screensaver has appeared for Managed Home Screen.</summary>
        public bool? KioskModeManagedHomeScreenPinRequiredToResume {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeManagedHomeScreenPinRequiredToResume)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenPinRequiredToResume), value); }
        }
        /// <summary>Custom URL background for sign-in screen for Managed Home Screen.</summary>
        public string KioskModeManagedHomeScreenSignInBackground {
            get { return BackingStore?.Get<string>(nameof(KioskModeManagedHomeScreenSignInBackground)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenSignInBackground), value); }
        }
        /// <summary>Custom URL branding logo for sign-in screen and session pin page for Managed Home Screen.</summary>
        public string KioskModeManagedHomeScreenSignInBrandingLogo {
            get { return BackingStore?.Get<string>(nameof(KioskModeManagedHomeScreenSignInBrandingLogo)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenSignInBrandingLogo), value); }
        }
        /// <summary>Whether or not show sign-in screen for Managed Home Screen.</summary>
        public bool? KioskModeManagedHomeScreenSignInEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeManagedHomeScreenSignInEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeManagedHomeScreenSignInEnabled), value); }
        }
        /// <summary>Whether or not to display the Managed Settings entry point on the managed home screen in Kiosk Mode.</summary>
        public bool? KioskModeManagedSettingsEntryDisabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeManagedSettingsEntryDisabled)); }
            set { BackingStore?.Set(nameof(KioskModeManagedSettingsEntryDisabled), value); }
        }
        /// <summary>Whether or not to allow a user to change the media volume in Kiosk Mode.</summary>
        public bool? KioskModeMediaVolumeConfigurationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeMediaVolumeConfigurationEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeMediaVolumeConfigurationEnabled), value); }
        }
        /// <summary>Screen orientation configuration for managed home screen in Kiosk Mode. Possible values are: notConfigured, portrait, landscape, autoRotate.</summary>
        public AndroidDeviceOwnerKioskModeScreenOrientation? KioskModeScreenOrientation {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskModeScreenOrientation?>(nameof(KioskModeScreenOrientation)); }
            set { BackingStore?.Set(nameof(KioskModeScreenOrientation), value); }
        }
        /// <summary>Whether or not to enable screen saver mode or not in Kiosk Mode.</summary>
        public bool? KioskModeScreenSaverConfigurationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeScreenSaverConfigurationEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeScreenSaverConfigurationEnabled), value); }
        }
        /// <summary>Whether or not the device screen should show the screen saver if audio/video is playing in Kiosk Mode.</summary>
        public bool? KioskModeScreenSaverDetectMediaDisabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeScreenSaverDetectMediaDisabled)); }
            set { BackingStore?.Set(nameof(KioskModeScreenSaverDetectMediaDisabled), value); }
        }
        /// <summary>The number of seconds that the device will display the screen saver for in Kiosk Mode. Valid values 0 to 9999999</summary>
        public int? KioskModeScreenSaverDisplayTimeInSeconds {
            get { return BackingStore?.Get<int?>(nameof(KioskModeScreenSaverDisplayTimeInSeconds)); }
            set { BackingStore?.Set(nameof(KioskModeScreenSaverDisplayTimeInSeconds), value); }
        }
        /// <summary>URL for an image that will be the device&apos;s screen saver in Kiosk Mode.</summary>
        public string KioskModeScreenSaverImageUrl {
            get { return BackingStore?.Get<string>(nameof(KioskModeScreenSaverImageUrl)); }
            set { BackingStore?.Set(nameof(KioskModeScreenSaverImageUrl), value); }
        }
        /// <summary>The number of seconds the device needs to be inactive for before the screen saver is shown in Kiosk Mode. Valid values 1 to 9999999</summary>
        public int? KioskModeScreenSaverStartDelayInSeconds {
            get { return BackingStore?.Get<int?>(nameof(KioskModeScreenSaverStartDelayInSeconds)); }
            set { BackingStore?.Set(nameof(KioskModeScreenSaverStartDelayInSeconds), value); }
        }
        /// <summary>Whether or not to display application notification badges in Kiosk Mode.</summary>
        public bool? KioskModeShowAppNotificationBadge {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeShowAppNotificationBadge)); }
            set { BackingStore?.Set(nameof(KioskModeShowAppNotificationBadge), value); }
        }
        /// <summary>Whether or not to allow a user to access basic device information.</summary>
        public bool? KioskModeShowDeviceInfo {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeShowDeviceInfo)); }
            set { BackingStore?.Set(nameof(KioskModeShowDeviceInfo), value); }
        }
        /// <summary>Whether or not to use single app kiosk mode or multi-app kiosk mode. Possible values are: notConfigured, singleAppMode, multiAppMode.</summary>
        public KioskModeType? KioskModeUseManagedHomeScreenApp {
            get { return BackingStore?.Get<KioskModeType?>(nameof(KioskModeUseManagedHomeScreenApp)); }
            set { BackingStore?.Set(nameof(KioskModeUseManagedHomeScreenApp), value); }
        }
        /// <summary>Whether or not to display a virtual home button when the device is in Kiosk Mode.</summary>
        public bool? KioskModeVirtualHomeButtonEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeVirtualHomeButtonEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeVirtualHomeButtonEnabled), value); }
        }
        /// <summary>Indicates whether the virtual home button is a swipe up home button or a floating home button. Possible values are: notConfigured, swipeUp, floating.</summary>
        public AndroidDeviceOwnerVirtualHomeButtonType? KioskModeVirtualHomeButtonType {
            get { return BackingStore?.Get<AndroidDeviceOwnerVirtualHomeButtonType?>(nameof(KioskModeVirtualHomeButtonType)); }
            set { BackingStore?.Set(nameof(KioskModeVirtualHomeButtonType), value); }
        }
        /// <summary>URL to a publicly accessible image to use for the wallpaper when the device is in Kiosk Mode.</summary>
        public string KioskModeWallpaperUrl {
            get { return BackingStore?.Get<string>(nameof(KioskModeWallpaperUrl)); }
            set { BackingStore?.Set(nameof(KioskModeWallpaperUrl), value); }
        }
        /// <summary>The restricted set of WIFI SSIDs available for the user to configure in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
        public List<string> KioskModeWifiAllowedSsids {
            get { return BackingStore?.Get<List<string>>(nameof(KioskModeWifiAllowedSsids)); }
            set { BackingStore?.Set(nameof(KioskModeWifiAllowedSsids), value); }
        }
        /// <summary>Whether or not to allow a user to configure Wi-Fi settings in Kiosk Mode.</summary>
        public bool? KioskModeWiFiConfigurationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeWiFiConfigurationEnabled)); }
            set { BackingStore?.Set(nameof(KioskModeWiFiConfigurationEnabled), value); }
        }
        /// <summary>Indicates whether or not to block unmuting the microphone on the device.</summary>
        public bool? MicrophoneForceMute {
            get { return BackingStore?.Get<bool?>(nameof(MicrophoneForceMute)); }
            set { BackingStore?.Set(nameof(MicrophoneForceMute), value); }
        }
        /// <summary>Indicates whether or not to you want configure Microsoft Launcher.</summary>
        public bool? MicrosoftLauncherConfigurationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftLauncherConfigurationEnabled)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherConfigurationEnabled), value); }
        }
        /// <summary>Indicates whether or not the user can modify the wallpaper to personalize their device.</summary>
        public bool? MicrosoftLauncherCustomWallpaperAllowUserModification {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftLauncherCustomWallpaperAllowUserModification)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherCustomWallpaperAllowUserModification), value); }
        }
        /// <summary>Indicates whether or not to configure the wallpaper on the targeted devices.</summary>
        public bool? MicrosoftLauncherCustomWallpaperEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftLauncherCustomWallpaperEnabled)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherCustomWallpaperEnabled), value); }
        }
        /// <summary>Indicates the URL for the image file to use as the wallpaper on the targeted devices.</summary>
        public string MicrosoftLauncherCustomWallpaperImageUrl {
            get { return BackingStore?.Get<string>(nameof(MicrosoftLauncherCustomWallpaperImageUrl)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherCustomWallpaperImageUrl), value); }
        }
        /// <summary>Indicates whether or not the user can modify the device dock configuration on the device.</summary>
        public bool? MicrosoftLauncherDockPresenceAllowUserModification {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftLauncherDockPresenceAllowUserModification)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherDockPresenceAllowUserModification), value); }
        }
        /// <summary>Indicates whether or not you want to configure the device dock. Possible values are: notConfigured, show, hide, disabled.</summary>
        public MicrosoftLauncherDockPresence? MicrosoftLauncherDockPresenceConfiguration {
            get { return BackingStore?.Get<MicrosoftLauncherDockPresence?>(nameof(MicrosoftLauncherDockPresenceConfiguration)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherDockPresenceConfiguration), value); }
        }
        /// <summary>Indicates whether or not the user can modify the launcher feed on the device.</summary>
        public bool? MicrosoftLauncherFeedAllowUserModification {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftLauncherFeedAllowUserModification)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherFeedAllowUserModification), value); }
        }
        /// <summary>Indicates whether or not you want to enable the launcher feed on the device.</summary>
        public bool? MicrosoftLauncherFeedEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftLauncherFeedEnabled)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherFeedEnabled), value); }
        }
        /// <summary>Indicates the search bar placement configuration on the device. Possible values are: notConfigured, top, bottom, hide.</summary>
        public MicrosoftLauncherSearchBarPlacement? MicrosoftLauncherSearchBarPlacementConfiguration {
            get { return BackingStore?.Get<MicrosoftLauncherSearchBarPlacement?>(nameof(MicrosoftLauncherSearchBarPlacementConfiguration)); }
            set { BackingStore?.Set(nameof(MicrosoftLauncherSearchBarPlacementConfiguration), value); }
        }
        /// <summary>Indicates whether or not the device will allow connecting to a temporary network connection at boot time.</summary>
        public bool? NetworkEscapeHatchAllowed {
            get { return BackingStore?.Get<bool?>(nameof(NetworkEscapeHatchAllowed)); }
            set { BackingStore?.Set(nameof(NetworkEscapeHatchAllowed), value); }
        }
        /// <summary>Indicates whether or not to block NFC outgoing beam.</summary>
        public bool? NfcBlockOutgoingBeam {
            get { return BackingStore?.Get<bool?>(nameof(NfcBlockOutgoingBeam)); }
            set { BackingStore?.Set(nameof(NfcBlockOutgoingBeam), value); }
        }
        /// <summary>Indicates whether or not the keyguard is disabled.</summary>
        public bool? PasswordBlockKeyguard {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockKeyguard)); }
            set { BackingStore?.Set(nameof(PasswordBlockKeyguard), value); }
        }
        /// <summary>List of device keyguard features to block. This collection can contain a maximum of 7 elements.</summary>
        public List<string> PasswordBlockKeyguardFeatures {
            get { return BackingStore?.Get<List<string>>(nameof(PasswordBlockKeyguardFeatures)); }
            set { BackingStore?.Set(nameof(PasswordBlockKeyguardFeatures), value); }
        }
        /// <summary>Indicates the amount of time that a password can be set for before it expires and a new password will be required. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>Indicates the minimum length of the password required on the device. Valid values 4 to 16</summary>
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
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout), value); }
        }
        /// <summary>Indicates the length of password history, where the user will not be able to enter a new password that is the same as any password in the history. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordCountToBlock {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordCountToBlock)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordCountToBlock), value); }
        }
        /// <summary>Indicates the minimum password quality required on the device. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Indicates the timeout period after which a device must be unlocked using a form of strong authentication. Possible values are: deviceDefault, daily, unkownFutureValue.</summary>
        public AndroidDeviceOwnerRequiredPasswordUnlock? PasswordRequireUnlock {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordUnlock?>(nameof(PasswordRequireUnlock)); }
            set { BackingStore?.Set(nameof(PasswordRequireUnlock), value); }
        }
        /// <summary>Indicates the number of times a user can enter an incorrect password before the device is wiped. Valid values 4 to 11</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(PasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(PasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>Indicates whether the user can install apps from unknown sources on the personal profile.</summary>
        public bool? PersonalProfileAppsAllowInstallFromUnknownSources {
            get { return BackingStore?.Get<bool?>(nameof(PersonalProfileAppsAllowInstallFromUnknownSources)); }
            set { BackingStore?.Set(nameof(PersonalProfileAppsAllowInstallFromUnknownSources), value); }
        }
        /// <summary>Indicates whether to disable the use of the camera on the personal profile.</summary>
        public bool? PersonalProfileCameraBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PersonalProfileCameraBlocked)); }
            set { BackingStore?.Set(nameof(PersonalProfileCameraBlocked), value); }
        }
        /// <summary>Policy applied to applications in the personal profile. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> PersonalProfilePersonalApplications {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(PersonalProfilePersonalApplications)); }
            set { BackingStore?.Set(nameof(PersonalProfilePersonalApplications), value); }
        }
        /// <summary>Used together with PersonalProfilePersonalApplications to control how apps in the personal profile are allowed or blocked. Possible values are: notConfigured, blockedApps, allowedApps.</summary>
        public PersonalProfilePersonalPlayStoreMode? PersonalProfilePlayStoreMode {
            get { return BackingStore?.Get<PersonalProfilePersonalPlayStoreMode?>(nameof(PersonalProfilePlayStoreMode)); }
            set { BackingStore?.Set(nameof(PersonalProfilePlayStoreMode), value); }
        }
        /// <summary>Indicates whether to disable the capability to take screenshots on the personal profile.</summary>
        public bool? PersonalProfileScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PersonalProfileScreenCaptureBlocked)); }
            set { BackingStore?.Set(nameof(PersonalProfileScreenCaptureBlocked), value); }
        }
        /// <summary>Indicates the Play Store mode of the device. Possible values are: notConfigured, allowList, blockList.</summary>
        public AndroidDeviceOwnerPlayStoreMode? PlayStoreMode {
            get { return BackingStore?.Get<AndroidDeviceOwnerPlayStoreMode?>(nameof(PlayStoreMode)); }
            set { BackingStore?.Set(nameof(PlayStoreMode), value); }
        }
        /// <summary>Indicates whether or not to disable the capability to take screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ScreenCaptureBlocked)); }
            set { BackingStore?.Set(nameof(ScreenCaptureBlocked), value); }
        }
        /// <summary>Indicates whether or not the user is allowed to access developer settings like developer options and safe boot on the device.</summary>
        public bool? SecurityDeveloperSettingsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SecurityDeveloperSettingsEnabled)); }
            set { BackingStore?.Set(nameof(SecurityDeveloperSettingsEnabled), value); }
        }
        /// <summary>Indicates whether or not verify apps is required.</summary>
        public bool? SecurityRequireVerifyApps {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireVerifyApps)); }
            set { BackingStore?.Set(nameof(SecurityRequireVerifyApps), value); }
        }
        /// <summary>Represents the customized short help text provided to users when they attempt to modify managed settings on their device.</summary>
        public AndroidDeviceOwnerUserFacingMessage ShortHelpText {
            get { return BackingStore?.Get<AndroidDeviceOwnerUserFacingMessage>(nameof(ShortHelpText)); }
            set { BackingStore?.Set(nameof(ShortHelpText), value); }
        }
        /// <summary>Indicates whether or the status bar is disabled, including notifications, quick settings and other screen overlays.</summary>
        public bool? StatusBarBlocked {
            get { return BackingStore?.Get<bool?>(nameof(StatusBarBlocked)); }
            set { BackingStore?.Set(nameof(StatusBarBlocked), value); }
        }
        /// <summary>List of modes in which the device&apos;s display will stay powered-on. This collection can contain a maximum of 4 elements.</summary>
        public List<string> StayOnModes {
            get { return BackingStore?.Get<List<string>>(nameof(StayOnModes)); }
            set { BackingStore?.Set(nameof(StayOnModes), value); }
        }
        /// <summary>Indicates whether or not to allow USB mass storage.</summary>
        public bool? StorageAllowUsb {
            get { return BackingStore?.Get<bool?>(nameof(StorageAllowUsb)); }
            set { BackingStore?.Set(nameof(StorageAllowUsb), value); }
        }
        /// <summary>Indicates whether or not to block external media.</summary>
        public bool? StorageBlockExternalMedia {
            get { return BackingStore?.Get<bool?>(nameof(StorageBlockExternalMedia)); }
            set { BackingStore?.Set(nameof(StorageBlockExternalMedia), value); }
        }
        /// <summary>Indicates whether or not to block USB file transfer.</summary>
        public bool? StorageBlockUsbFileTransfer {
            get { return BackingStore?.Get<bool?>(nameof(StorageBlockUsbFileTransfer)); }
            set { BackingStore?.Set(nameof(StorageBlockUsbFileTransfer), value); }
        }
        /// <summary>Indicates the annually repeating time periods during which system updates are postponed. This collection can contain a maximum of 500 elements.</summary>
        public List<AndroidDeviceOwnerSystemUpdateFreezePeriod> SystemUpdateFreezePeriods {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerSystemUpdateFreezePeriod>>(nameof(SystemUpdateFreezePeriods)); }
            set { BackingStore?.Set(nameof(SystemUpdateFreezePeriods), value); }
        }
        /// <summary>The type of system update configuration. Possible values are: deviceDefault, postpone, windowed, automatic.</summary>
        public AndroidDeviceOwnerSystemUpdateInstallType? SystemUpdateInstallType {
            get { return BackingStore?.Get<AndroidDeviceOwnerSystemUpdateInstallType?>(nameof(SystemUpdateInstallType)); }
            set { BackingStore?.Set(nameof(SystemUpdateInstallType), value); }
        }
        /// <summary>Indicates the number of minutes after midnight that the system update window ends. Valid values 0 to 1440</summary>
        public int? SystemUpdateWindowEndMinutesAfterMidnight {
            get { return BackingStore?.Get<int?>(nameof(SystemUpdateWindowEndMinutesAfterMidnight)); }
            set { BackingStore?.Set(nameof(SystemUpdateWindowEndMinutesAfterMidnight), value); }
        }
        /// <summary>Indicates the number of minutes after midnight that the system update window starts. Valid values 0 to 1440</summary>
        public int? SystemUpdateWindowStartMinutesAfterMidnight {
            get { return BackingStore?.Get<int?>(nameof(SystemUpdateWindowStartMinutesAfterMidnight)); }
            set { BackingStore?.Set(nameof(SystemUpdateWindowStartMinutesAfterMidnight), value); }
        }
        /// <summary>Whether or not to block Android system prompt windows, like toasts, phone activities, and system alerts.</summary>
        public bool? SystemWindowsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(SystemWindowsBlocked)); }
            set { BackingStore?.Set(nameof(SystemWindowsBlocked), value); }
        }
        /// <summary>Indicates whether or not adding users and profiles is disabled.</summary>
        public bool? UsersBlockAdd {
            get { return BackingStore?.Get<bool?>(nameof(UsersBlockAdd)); }
            set { BackingStore?.Set(nameof(UsersBlockAdd), value); }
        }
        /// <summary>Indicates whether or not to disable removing other users from the device.</summary>
        public bool? UsersBlockRemove {
            get { return BackingStore?.Get<bool?>(nameof(UsersBlockRemove)); }
            set { BackingStore?.Set(nameof(UsersBlockRemove), value); }
        }
        /// <summary>Indicates whether or not adjusting the master volume is disabled.</summary>
        public bool? VolumeBlockAdjustment {
            get { return BackingStore?.Get<bool?>(nameof(VolumeBlockAdjustment)); }
            set { BackingStore?.Set(nameof(VolumeBlockAdjustment), value); }
        }
        /// <summary>If an always on VPN package name is specified, whether or not to lock network traffic when that VPN is disconnected.</summary>
        public bool? VpnAlwaysOnLockdownMode {
            get { return BackingStore?.Get<bool?>(nameof(VpnAlwaysOnLockdownMode)); }
            set { BackingStore?.Set(nameof(VpnAlwaysOnLockdownMode), value); }
        }
        /// <summary>Android app package name for app that will handle an always-on VPN connection.</summary>
        public string VpnAlwaysOnPackageIdentifier {
            get { return BackingStore?.Get<string>(nameof(VpnAlwaysOnPackageIdentifier)); }
            set { BackingStore?.Set(nameof(VpnAlwaysOnPackageIdentifier), value); }
        }
        /// <summary>Indicates whether or not to block the user from editing the wifi connection settings.</summary>
        public bool? WifiBlockEditConfigurations {
            get { return BackingStore?.Get<bool?>(nameof(WifiBlockEditConfigurations)); }
            set { BackingStore?.Set(nameof(WifiBlockEditConfigurations), value); }
        }
        /// <summary>Indicates whether or not to block the user from editing just the networks defined by the policy.</summary>
        public bool? WifiBlockEditPolicyDefinedConfigurations {
            get { return BackingStore?.Get<bool?>(nameof(WifiBlockEditPolicyDefinedConfigurations)); }
            set { BackingStore?.Set(nameof(WifiBlockEditPolicyDefinedConfigurations), value); }
        }
        /// <summary>Indicates the number of days that a work profile password can be set before it expires and a new password will be required. Valid values 1 to 365</summary>
        public int? WorkProfilePasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordExpirationDays), value); }
        }
        /// <summary>Indicates the minimum length of the work profile password. Valid values 4 to 16</summary>
        public int? WorkProfilePasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinimumLength), value); }
        }
        /// <summary>Indicates the minimum number of letter characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumLetterCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinimumLetterCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinimumLetterCharacters), value); }
        }
        /// <summary>Indicates the minimum number of lower-case characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumLowerCaseCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinimumLowerCaseCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinimumLowerCaseCharacters), value); }
        }
        /// <summary>Indicates the minimum number of non-letter characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumNonLetterCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinimumNonLetterCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinimumNonLetterCharacters), value); }
        }
        /// <summary>Indicates the minimum number of numeric characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumNumericCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinimumNumericCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinimumNumericCharacters), value); }
        }
        /// <summary>Indicates the minimum number of symbol characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumSymbolCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinimumSymbolCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinimumSymbolCharacters), value); }
        }
        /// <summary>Indicates the minimum number of upper-case letter characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumUpperCaseCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinimumUpperCaseCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinimumUpperCaseCharacters), value); }
        }
        /// <summary>Indicates the length of the work profile password history, where the user will not be able to enter a new password that is the same as any password in the history. Valid values 0 to 24</summary>
        public int? WorkProfilePasswordPreviousPasswordCountToBlock {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordPreviousPasswordCountToBlock)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordPreviousPasswordCountToBlock), value); }
        }
        /// <summary>Indicates the minimum password quality required on the work profile password. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? WorkProfilePasswordRequiredType {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordType?>(nameof(WorkProfilePasswordRequiredType)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordRequiredType), value); }
        }
        /// <summary>Indicates the timeout period after which a work profile must be unlocked using a form of strong authentication. Possible values are: deviceDefault, daily, unkownFutureValue.</summary>
        public AndroidDeviceOwnerRequiredPasswordUnlock? WorkProfilePasswordRequireUnlock {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordUnlock?>(nameof(WorkProfilePasswordRequireUnlock)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordRequireUnlock), value); }
        }
        /// <summary>Indicates the number of times a user can enter an incorrect work profile password before the device is wiped. Valid values 4 to 11</summary>
        public int? WorkProfilePasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceOwnerGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountsBlockModification", n => { AccountsBlockModification = n.GetBoolValue(); } },
                {"appsAllowInstallFromUnknownSources", n => { AppsAllowInstallFromUnknownSources = n.GetBoolValue(); } },
                {"appsAutoUpdatePolicy", n => { AppsAutoUpdatePolicy = n.GetEnumValue<AndroidDeviceOwnerAppAutoUpdatePolicyType>(); } },
                {"appsDefaultPermissionPolicy", n => { AppsDefaultPermissionPolicy = n.GetEnumValue<AndroidDeviceOwnerDefaultAppPermissionPolicyType>(); } },
                {"appsRecommendSkippingFirstUseHints", n => { AppsRecommendSkippingFirstUseHints = n.GetBoolValue(); } },
                {"azureAdSharedDeviceDataClearApps", n => { AzureAdSharedDeviceDataClearApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"bluetoothBlockConfiguration", n => { BluetoothBlockConfiguration = n.GetBoolValue(); } },
                {"bluetoothBlockContactSharing", n => { BluetoothBlockContactSharing = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockWiFiTethering", n => { CellularBlockWiFiTethering = n.GetBoolValue(); } },
                {"certificateCredentialConfigurationDisabled", n => { CertificateCredentialConfigurationDisabled = n.GetBoolValue(); } },
                {"crossProfilePoliciesAllowCopyPaste", n => { CrossProfilePoliciesAllowCopyPaste = n.GetBoolValue(); } },
                {"crossProfilePoliciesAllowDataSharing", n => { CrossProfilePoliciesAllowDataSharing = n.GetEnumValue<AndroidDeviceOwnerCrossProfileDataSharing>(); } },
                {"crossProfilePoliciesShowWorkContactsInPersonalProfile", n => { CrossProfilePoliciesShowWorkContactsInPersonalProfile = n.GetBoolValue(); } },
                {"dataRoamingBlocked", n => { DataRoamingBlocked = n.GetBoolValue(); } },
                {"dateTimeConfigurationBlocked", n => { DateTimeConfigurationBlocked = n.GetBoolValue(); } },
                {"detailedHelpText", n => { DetailedHelpText = n.GetObjectValue<AndroidDeviceOwnerUserFacingMessage>(AndroidDeviceOwnerUserFacingMessage.CreateFromDiscriminatorValue); } },
                {"enrollmentProfile", n => { EnrollmentProfile = n.GetEnumValue<AndroidDeviceOwnerEnrollmentProfileType>(); } },
                {"factoryResetBlocked", n => { FactoryResetBlocked = n.GetBoolValue(); } },
                {"factoryResetDeviceAdministratorEmails", n => { FactoryResetDeviceAdministratorEmails = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"globalProxy", n => { GlobalProxy = n.GetObjectValue<AndroidDeviceOwnerGlobalProxy>(AndroidDeviceOwnerGlobalProxy.CreateFromDiscriminatorValue); } },
                {"googleAccountsBlocked", n => { GoogleAccountsBlocked = n.GetBoolValue(); } },
                {"kioskCustomizationDeviceSettingsBlocked", n => { KioskCustomizationDeviceSettingsBlocked = n.GetBoolValue(); } },
                {"kioskCustomizationPowerButtonActionsBlocked", n => { KioskCustomizationPowerButtonActionsBlocked = n.GetBoolValue(); } },
                {"kioskCustomizationStatusBar", n => { KioskCustomizationStatusBar = n.GetEnumValue<AndroidDeviceOwnerKioskCustomizationStatusBar>(); } },
                {"kioskCustomizationSystemErrorWarnings", n => { KioskCustomizationSystemErrorWarnings = n.GetBoolValue(); } },
                {"kioskCustomizationSystemNavigation", n => { KioskCustomizationSystemNavigation = n.GetEnumValue<AndroidDeviceOwnerKioskCustomizationSystemNavigation>(); } },
                {"kioskModeAppOrderEnabled", n => { KioskModeAppOrderEnabled = n.GetBoolValue(); } },
                {"kioskModeAppPositions", n => { KioskModeAppPositions = n.GetCollectionOfObjectValues<AndroidDeviceOwnerKioskModeAppPositionItem>(AndroidDeviceOwnerKioskModeAppPositionItem.CreateFromDiscriminatorValue).ToList(); } },
                {"kioskModeApps", n => { KioskModeApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"kioskModeAppsInFolderOrderedByName", n => { KioskModeAppsInFolderOrderedByName = n.GetBoolValue(); } },
                {"kioskModeBluetoothConfigurationEnabled", n => { KioskModeBluetoothConfigurationEnabled = n.GetBoolValue(); } },
                {"kioskModeDebugMenuEasyAccessEnabled", n => { KioskModeDebugMenuEasyAccessEnabled = n.GetBoolValue(); } },
                {"kioskModeExitCode", n => { KioskModeExitCode = n.GetStringValue(); } },
                {"kioskModeFlashlightConfigurationEnabled", n => { KioskModeFlashlightConfigurationEnabled = n.GetBoolValue(); } },
                {"kioskModeFolderIcon", n => { KioskModeFolderIcon = n.GetEnumValue<AndroidDeviceOwnerKioskModeFolderIcon>(); } },
                {"kioskModeGridHeight", n => { KioskModeGridHeight = n.GetIntValue(); } },
                {"kioskModeGridWidth", n => { KioskModeGridWidth = n.GetIntValue(); } },
                {"kioskModeIconSize", n => { KioskModeIconSize = n.GetEnumValue<AndroidDeviceOwnerKioskModeIconSize>(); } },
                {"kioskModeLockHomeScreen", n => { KioskModeLockHomeScreen = n.GetBoolValue(); } },
                {"kioskModeManagedFolders", n => { KioskModeManagedFolders = n.GetCollectionOfObjectValues<AndroidDeviceOwnerKioskModeManagedFolder>(AndroidDeviceOwnerKioskModeManagedFolder.CreateFromDiscriminatorValue).ToList(); } },
                {"kioskModeManagedHomeScreenAutoSignout", n => { KioskModeManagedHomeScreenAutoSignout = n.GetBoolValue(); } },
                {"kioskModeManagedHomeScreenInactiveSignOutDelayInSeconds", n => { KioskModeManagedHomeScreenInactiveSignOutDelayInSeconds = n.GetIntValue(); } },
                {"kioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds", n => { KioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds = n.GetIntValue(); } },
                {"kioskModeManagedHomeScreenPinComplexity", n => { KioskModeManagedHomeScreenPinComplexity = n.GetEnumValue<KioskModeManagedHomeScreenPinComplexity>(); } },
                {"kioskModeManagedHomeScreenPinRequired", n => { KioskModeManagedHomeScreenPinRequired = n.GetBoolValue(); } },
                {"kioskModeManagedHomeScreenPinRequiredToResume", n => { KioskModeManagedHomeScreenPinRequiredToResume = n.GetBoolValue(); } },
                {"kioskModeManagedHomeScreenSignInBackground", n => { KioskModeManagedHomeScreenSignInBackground = n.GetStringValue(); } },
                {"kioskModeManagedHomeScreenSignInBrandingLogo", n => { KioskModeManagedHomeScreenSignInBrandingLogo = n.GetStringValue(); } },
                {"kioskModeManagedHomeScreenSignInEnabled", n => { KioskModeManagedHomeScreenSignInEnabled = n.GetBoolValue(); } },
                {"kioskModeManagedSettingsEntryDisabled", n => { KioskModeManagedSettingsEntryDisabled = n.GetBoolValue(); } },
                {"kioskModeMediaVolumeConfigurationEnabled", n => { KioskModeMediaVolumeConfigurationEnabled = n.GetBoolValue(); } },
                {"kioskModeScreenOrientation", n => { KioskModeScreenOrientation = n.GetEnumValue<AndroidDeviceOwnerKioskModeScreenOrientation>(); } },
                {"kioskModeScreenSaverConfigurationEnabled", n => { KioskModeScreenSaverConfigurationEnabled = n.GetBoolValue(); } },
                {"kioskModeScreenSaverDetectMediaDisabled", n => { KioskModeScreenSaverDetectMediaDisabled = n.GetBoolValue(); } },
                {"kioskModeScreenSaverDisplayTimeInSeconds", n => { KioskModeScreenSaverDisplayTimeInSeconds = n.GetIntValue(); } },
                {"kioskModeScreenSaverImageUrl", n => { KioskModeScreenSaverImageUrl = n.GetStringValue(); } },
                {"kioskModeScreenSaverStartDelayInSeconds", n => { KioskModeScreenSaverStartDelayInSeconds = n.GetIntValue(); } },
                {"kioskModeShowAppNotificationBadge", n => { KioskModeShowAppNotificationBadge = n.GetBoolValue(); } },
                {"kioskModeShowDeviceInfo", n => { KioskModeShowDeviceInfo = n.GetBoolValue(); } },
                {"kioskModeUseManagedHomeScreenApp", n => { KioskModeUseManagedHomeScreenApp = n.GetEnumValue<KioskModeType>(); } },
                {"kioskModeVirtualHomeButtonEnabled", n => { KioskModeVirtualHomeButtonEnabled = n.GetBoolValue(); } },
                {"kioskModeVirtualHomeButtonType", n => { KioskModeVirtualHomeButtonType = n.GetEnumValue<AndroidDeviceOwnerVirtualHomeButtonType>(); } },
                {"kioskModeWallpaperUrl", n => { KioskModeWallpaperUrl = n.GetStringValue(); } },
                {"kioskModeWifiAllowedSsids", n => { KioskModeWifiAllowedSsids = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"kioskModeWiFiConfigurationEnabled", n => { KioskModeWiFiConfigurationEnabled = n.GetBoolValue(); } },
                {"microphoneForceMute", n => { MicrophoneForceMute = n.GetBoolValue(); } },
                {"microsoftLauncherConfigurationEnabled", n => { MicrosoftLauncherConfigurationEnabled = n.GetBoolValue(); } },
                {"microsoftLauncherCustomWallpaperAllowUserModification", n => { MicrosoftLauncherCustomWallpaperAllowUserModification = n.GetBoolValue(); } },
                {"microsoftLauncherCustomWallpaperEnabled", n => { MicrosoftLauncherCustomWallpaperEnabled = n.GetBoolValue(); } },
                {"microsoftLauncherCustomWallpaperImageUrl", n => { MicrosoftLauncherCustomWallpaperImageUrl = n.GetStringValue(); } },
                {"microsoftLauncherDockPresenceAllowUserModification", n => { MicrosoftLauncherDockPresenceAllowUserModification = n.GetBoolValue(); } },
                {"microsoftLauncherDockPresenceConfiguration", n => { MicrosoftLauncherDockPresenceConfiguration = n.GetEnumValue<MicrosoftLauncherDockPresence>(); } },
                {"microsoftLauncherFeedAllowUserModification", n => { MicrosoftLauncherFeedAllowUserModification = n.GetBoolValue(); } },
                {"microsoftLauncherFeedEnabled", n => { MicrosoftLauncherFeedEnabled = n.GetBoolValue(); } },
                {"microsoftLauncherSearchBarPlacementConfiguration", n => { MicrosoftLauncherSearchBarPlacementConfiguration = n.GetEnumValue<MicrosoftLauncherSearchBarPlacement>(); } },
                {"networkEscapeHatchAllowed", n => { NetworkEscapeHatchAllowed = n.GetBoolValue(); } },
                {"nfcBlockOutgoingBeam", n => { NfcBlockOutgoingBeam = n.GetBoolValue(); } },
                {"passwordBlockKeyguard", n => { PasswordBlockKeyguard = n.GetBoolValue(); } },
                {"passwordBlockKeyguardFeatures", n => { PasswordBlockKeyguardFeatures = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinimumLetterCharacters", n => { PasswordMinimumLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumLowerCaseCharacters", n => { PasswordMinimumLowerCaseCharacters = n.GetIntValue(); } },
                {"passwordMinimumNonLetterCharacters", n => { PasswordMinimumNonLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumNumericCharacters", n => { PasswordMinimumNumericCharacters = n.GetIntValue(); } },
                {"passwordMinimumSymbolCharacters", n => { PasswordMinimumSymbolCharacters = n.GetIntValue(); } },
                {"passwordMinimumUpperCaseCharacters", n => { PasswordMinimumUpperCaseCharacters = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordCountToBlock", n => { PasswordPreviousPasswordCountToBlock = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"passwordRequireUnlock", n => { PasswordRequireUnlock = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordUnlock>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"personalProfileAppsAllowInstallFromUnknownSources", n => { PersonalProfileAppsAllowInstallFromUnknownSources = n.GetBoolValue(); } },
                {"personalProfileCameraBlocked", n => { PersonalProfileCameraBlocked = n.GetBoolValue(); } },
                {"personalProfilePersonalApplications", n => { PersonalProfilePersonalApplications = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"personalProfilePlayStoreMode", n => { PersonalProfilePlayStoreMode = n.GetEnumValue<PersonalProfilePersonalPlayStoreMode>(); } },
                {"personalProfileScreenCaptureBlocked", n => { PersonalProfileScreenCaptureBlocked = n.GetBoolValue(); } },
                {"playStoreMode", n => { PlayStoreMode = n.GetEnumValue<AndroidDeviceOwnerPlayStoreMode>(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"securityDeveloperSettingsEnabled", n => { SecurityDeveloperSettingsEnabled = n.GetBoolValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"shortHelpText", n => { ShortHelpText = n.GetObjectValue<AndroidDeviceOwnerUserFacingMessage>(AndroidDeviceOwnerUserFacingMessage.CreateFromDiscriminatorValue); } },
                {"statusBarBlocked", n => { StatusBarBlocked = n.GetBoolValue(); } },
                {"stayOnModes", n => { StayOnModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"storageAllowUsb", n => { StorageAllowUsb = n.GetBoolValue(); } },
                {"storageBlockExternalMedia", n => { StorageBlockExternalMedia = n.GetBoolValue(); } },
                {"storageBlockUsbFileTransfer", n => { StorageBlockUsbFileTransfer = n.GetBoolValue(); } },
                {"systemUpdateFreezePeriods", n => { SystemUpdateFreezePeriods = n.GetCollectionOfObjectValues<AndroidDeviceOwnerSystemUpdateFreezePeriod>(AndroidDeviceOwnerSystemUpdateFreezePeriod.CreateFromDiscriminatorValue).ToList(); } },
                {"systemUpdateInstallType", n => { SystemUpdateInstallType = n.GetEnumValue<AndroidDeviceOwnerSystemUpdateInstallType>(); } },
                {"systemUpdateWindowEndMinutesAfterMidnight", n => { SystemUpdateWindowEndMinutesAfterMidnight = n.GetIntValue(); } },
                {"systemUpdateWindowStartMinutesAfterMidnight", n => { SystemUpdateWindowStartMinutesAfterMidnight = n.GetIntValue(); } },
                {"systemWindowsBlocked", n => { SystemWindowsBlocked = n.GetBoolValue(); } },
                {"usersBlockAdd", n => { UsersBlockAdd = n.GetBoolValue(); } },
                {"usersBlockRemove", n => { UsersBlockRemove = n.GetBoolValue(); } },
                {"volumeBlockAdjustment", n => { VolumeBlockAdjustment = n.GetBoolValue(); } },
                {"vpnAlwaysOnLockdownMode", n => { VpnAlwaysOnLockdownMode = n.GetBoolValue(); } },
                {"vpnAlwaysOnPackageIdentifier", n => { VpnAlwaysOnPackageIdentifier = n.GetStringValue(); } },
                {"wifiBlockEditConfigurations", n => { WifiBlockEditConfigurations = n.GetBoolValue(); } },
                {"wifiBlockEditPolicyDefinedConfigurations", n => { WifiBlockEditPolicyDefinedConfigurations = n.GetBoolValue(); } },
                {"workProfilePasswordExpirationDays", n => { WorkProfilePasswordExpirationDays = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLength", n => { WorkProfilePasswordMinimumLength = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLetterCharacters", n => { WorkProfilePasswordMinimumLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLowerCaseCharacters", n => { WorkProfilePasswordMinimumLowerCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumNonLetterCharacters", n => { WorkProfilePasswordMinimumNonLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumNumericCharacters", n => { WorkProfilePasswordMinimumNumericCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumSymbolCharacters", n => { WorkProfilePasswordMinimumSymbolCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumUpperCaseCharacters", n => { WorkProfilePasswordMinimumUpperCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordPreviousPasswordCountToBlock", n => { WorkProfilePasswordPreviousPasswordCountToBlock = n.GetIntValue(); } },
                {"workProfilePasswordRequiredType", n => { WorkProfilePasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"workProfilePasswordRequireUnlock", n => { WorkProfilePasswordRequireUnlock = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordUnlock>(); } },
                {"workProfilePasswordSignInFailureCountBeforeFactoryReset", n => { WorkProfilePasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountsBlockModification", AccountsBlockModification);
            writer.WriteBoolValue("appsAllowInstallFromUnknownSources", AppsAllowInstallFromUnknownSources);
            writer.WriteEnumValue<AndroidDeviceOwnerAppAutoUpdatePolicyType>("appsAutoUpdatePolicy", AppsAutoUpdatePolicy);
            writer.WriteEnumValue<AndroidDeviceOwnerDefaultAppPermissionPolicyType>("appsDefaultPermissionPolicy", AppsDefaultPermissionPolicy);
            writer.WriteBoolValue("appsRecommendSkippingFirstUseHints", AppsRecommendSkippingFirstUseHints);
            writer.WriteCollectionOfObjectValues<AppListItem>("azureAdSharedDeviceDataClearApps", AzureAdSharedDeviceDataClearApps);
            writer.WriteBoolValue("bluetoothBlockConfiguration", BluetoothBlockConfiguration);
            writer.WriteBoolValue("bluetoothBlockContactSharing", BluetoothBlockContactSharing);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockWiFiTethering", CellularBlockWiFiTethering);
            writer.WriteBoolValue("certificateCredentialConfigurationDisabled", CertificateCredentialConfigurationDisabled);
            writer.WriteBoolValue("crossProfilePoliciesAllowCopyPaste", CrossProfilePoliciesAllowCopyPaste);
            writer.WriteEnumValue<AndroidDeviceOwnerCrossProfileDataSharing>("crossProfilePoliciesAllowDataSharing", CrossProfilePoliciesAllowDataSharing);
            writer.WriteBoolValue("crossProfilePoliciesShowWorkContactsInPersonalProfile", CrossProfilePoliciesShowWorkContactsInPersonalProfile);
            writer.WriteBoolValue("dataRoamingBlocked", DataRoamingBlocked);
            writer.WriteBoolValue("dateTimeConfigurationBlocked", DateTimeConfigurationBlocked);
            writer.WriteObjectValue<AndroidDeviceOwnerUserFacingMessage>("detailedHelpText", DetailedHelpText);
            writer.WriteEnumValue<AndroidDeviceOwnerEnrollmentProfileType>("enrollmentProfile", EnrollmentProfile);
            writer.WriteBoolValue("factoryResetBlocked", FactoryResetBlocked);
            writer.WriteCollectionOfPrimitiveValues<string>("factoryResetDeviceAdministratorEmails", FactoryResetDeviceAdministratorEmails);
            writer.WriteObjectValue<AndroidDeviceOwnerGlobalProxy>("globalProxy", GlobalProxy);
            writer.WriteBoolValue("googleAccountsBlocked", GoogleAccountsBlocked);
            writer.WriteBoolValue("kioskCustomizationDeviceSettingsBlocked", KioskCustomizationDeviceSettingsBlocked);
            writer.WriteBoolValue("kioskCustomizationPowerButtonActionsBlocked", KioskCustomizationPowerButtonActionsBlocked);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskCustomizationStatusBar>("kioskCustomizationStatusBar", KioskCustomizationStatusBar);
            writer.WriteBoolValue("kioskCustomizationSystemErrorWarnings", KioskCustomizationSystemErrorWarnings);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskCustomizationSystemNavigation>("kioskCustomizationSystemNavigation", KioskCustomizationSystemNavigation);
            writer.WriteBoolValue("kioskModeAppOrderEnabled", KioskModeAppOrderEnabled);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerKioskModeAppPositionItem>("kioskModeAppPositions", KioskModeAppPositions);
            writer.WriteCollectionOfObjectValues<AppListItem>("kioskModeApps", KioskModeApps);
            writer.WriteBoolValue("kioskModeAppsInFolderOrderedByName", KioskModeAppsInFolderOrderedByName);
            writer.WriteBoolValue("kioskModeBluetoothConfigurationEnabled", KioskModeBluetoothConfigurationEnabled);
            writer.WriteBoolValue("kioskModeDebugMenuEasyAccessEnabled", KioskModeDebugMenuEasyAccessEnabled);
            writer.WriteStringValue("kioskModeExitCode", KioskModeExitCode);
            writer.WriteBoolValue("kioskModeFlashlightConfigurationEnabled", KioskModeFlashlightConfigurationEnabled);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskModeFolderIcon>("kioskModeFolderIcon", KioskModeFolderIcon);
            writer.WriteIntValue("kioskModeGridHeight", KioskModeGridHeight);
            writer.WriteIntValue("kioskModeGridWidth", KioskModeGridWidth);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskModeIconSize>("kioskModeIconSize", KioskModeIconSize);
            writer.WriteBoolValue("kioskModeLockHomeScreen", KioskModeLockHomeScreen);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerKioskModeManagedFolder>("kioskModeManagedFolders", KioskModeManagedFolders);
            writer.WriteBoolValue("kioskModeManagedHomeScreenAutoSignout", KioskModeManagedHomeScreenAutoSignout);
            writer.WriteIntValue("kioskModeManagedHomeScreenInactiveSignOutDelayInSeconds", KioskModeManagedHomeScreenInactiveSignOutDelayInSeconds);
            writer.WriteIntValue("kioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds", KioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds);
            writer.WriteEnumValue<KioskModeManagedHomeScreenPinComplexity>("kioskModeManagedHomeScreenPinComplexity", KioskModeManagedHomeScreenPinComplexity);
            writer.WriteBoolValue("kioskModeManagedHomeScreenPinRequired", KioskModeManagedHomeScreenPinRequired);
            writer.WriteBoolValue("kioskModeManagedHomeScreenPinRequiredToResume", KioskModeManagedHomeScreenPinRequiredToResume);
            writer.WriteStringValue("kioskModeManagedHomeScreenSignInBackground", KioskModeManagedHomeScreenSignInBackground);
            writer.WriteStringValue("kioskModeManagedHomeScreenSignInBrandingLogo", KioskModeManagedHomeScreenSignInBrandingLogo);
            writer.WriteBoolValue("kioskModeManagedHomeScreenSignInEnabled", KioskModeManagedHomeScreenSignInEnabled);
            writer.WriteBoolValue("kioskModeManagedSettingsEntryDisabled", KioskModeManagedSettingsEntryDisabled);
            writer.WriteBoolValue("kioskModeMediaVolumeConfigurationEnabled", KioskModeMediaVolumeConfigurationEnabled);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskModeScreenOrientation>("kioskModeScreenOrientation", KioskModeScreenOrientation);
            writer.WriteBoolValue("kioskModeScreenSaverConfigurationEnabled", KioskModeScreenSaverConfigurationEnabled);
            writer.WriteBoolValue("kioskModeScreenSaverDetectMediaDisabled", KioskModeScreenSaverDetectMediaDisabled);
            writer.WriteIntValue("kioskModeScreenSaverDisplayTimeInSeconds", KioskModeScreenSaverDisplayTimeInSeconds);
            writer.WriteStringValue("kioskModeScreenSaverImageUrl", KioskModeScreenSaverImageUrl);
            writer.WriteIntValue("kioskModeScreenSaverStartDelayInSeconds", KioskModeScreenSaverStartDelayInSeconds);
            writer.WriteBoolValue("kioskModeShowAppNotificationBadge", KioskModeShowAppNotificationBadge);
            writer.WriteBoolValue("kioskModeShowDeviceInfo", KioskModeShowDeviceInfo);
            writer.WriteEnumValue<KioskModeType>("kioskModeUseManagedHomeScreenApp", KioskModeUseManagedHomeScreenApp);
            writer.WriteBoolValue("kioskModeVirtualHomeButtonEnabled", KioskModeVirtualHomeButtonEnabled);
            writer.WriteEnumValue<AndroidDeviceOwnerVirtualHomeButtonType>("kioskModeVirtualHomeButtonType", KioskModeVirtualHomeButtonType);
            writer.WriteStringValue("kioskModeWallpaperUrl", KioskModeWallpaperUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("kioskModeWifiAllowedSsids", KioskModeWifiAllowedSsids);
            writer.WriteBoolValue("kioskModeWiFiConfigurationEnabled", KioskModeWiFiConfigurationEnabled);
            writer.WriteBoolValue("microphoneForceMute", MicrophoneForceMute);
            writer.WriteBoolValue("microsoftLauncherConfigurationEnabled", MicrosoftLauncherConfigurationEnabled);
            writer.WriteBoolValue("microsoftLauncherCustomWallpaperAllowUserModification", MicrosoftLauncherCustomWallpaperAllowUserModification);
            writer.WriteBoolValue("microsoftLauncherCustomWallpaperEnabled", MicrosoftLauncherCustomWallpaperEnabled);
            writer.WriteStringValue("microsoftLauncherCustomWallpaperImageUrl", MicrosoftLauncherCustomWallpaperImageUrl);
            writer.WriteBoolValue("microsoftLauncherDockPresenceAllowUserModification", MicrosoftLauncherDockPresenceAllowUserModification);
            writer.WriteEnumValue<MicrosoftLauncherDockPresence>("microsoftLauncherDockPresenceConfiguration", MicrosoftLauncherDockPresenceConfiguration);
            writer.WriteBoolValue("microsoftLauncherFeedAllowUserModification", MicrosoftLauncherFeedAllowUserModification);
            writer.WriteBoolValue("microsoftLauncherFeedEnabled", MicrosoftLauncherFeedEnabled);
            writer.WriteEnumValue<MicrosoftLauncherSearchBarPlacement>("microsoftLauncherSearchBarPlacementConfiguration", MicrosoftLauncherSearchBarPlacementConfiguration);
            writer.WriteBoolValue("networkEscapeHatchAllowed", NetworkEscapeHatchAllowed);
            writer.WriteBoolValue("nfcBlockOutgoingBeam", NfcBlockOutgoingBeam);
            writer.WriteBoolValue("passwordBlockKeyguard", PasswordBlockKeyguard);
            writer.WriteCollectionOfPrimitiveValues<string>("passwordBlockKeyguardFeatures", PasswordBlockKeyguardFeatures);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinimumLetterCharacters", PasswordMinimumLetterCharacters);
            writer.WriteIntValue("passwordMinimumLowerCaseCharacters", PasswordMinimumLowerCaseCharacters);
            writer.WriteIntValue("passwordMinimumNonLetterCharacters", PasswordMinimumNonLetterCharacters);
            writer.WriteIntValue("passwordMinimumNumericCharacters", PasswordMinimumNumericCharacters);
            writer.WriteIntValue("passwordMinimumSymbolCharacters", PasswordMinimumSymbolCharacters);
            writer.WriteIntValue("passwordMinimumUpperCaseCharacters", PasswordMinimumUpperCaseCharacters);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordCountToBlock", PasswordPreviousPasswordCountToBlock);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordUnlock>("passwordRequireUnlock", PasswordRequireUnlock);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("personalProfileAppsAllowInstallFromUnknownSources", PersonalProfileAppsAllowInstallFromUnknownSources);
            writer.WriteBoolValue("personalProfileCameraBlocked", PersonalProfileCameraBlocked);
            writer.WriteCollectionOfObjectValues<AppListItem>("personalProfilePersonalApplications", PersonalProfilePersonalApplications);
            writer.WriteEnumValue<PersonalProfilePersonalPlayStoreMode>("personalProfilePlayStoreMode", PersonalProfilePlayStoreMode);
            writer.WriteBoolValue("personalProfileScreenCaptureBlocked", PersonalProfileScreenCaptureBlocked);
            writer.WriteEnumValue<AndroidDeviceOwnerPlayStoreMode>("playStoreMode", PlayStoreMode);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("securityDeveloperSettingsEnabled", SecurityDeveloperSettingsEnabled);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteObjectValue<AndroidDeviceOwnerUserFacingMessage>("shortHelpText", ShortHelpText);
            writer.WriteBoolValue("statusBarBlocked", StatusBarBlocked);
            writer.WriteCollectionOfPrimitiveValues<string>("stayOnModes", StayOnModes);
            writer.WriteBoolValue("storageAllowUsb", StorageAllowUsb);
            writer.WriteBoolValue("storageBlockExternalMedia", StorageBlockExternalMedia);
            writer.WriteBoolValue("storageBlockUsbFileTransfer", StorageBlockUsbFileTransfer);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerSystemUpdateFreezePeriod>("systemUpdateFreezePeriods", SystemUpdateFreezePeriods);
            writer.WriteEnumValue<AndroidDeviceOwnerSystemUpdateInstallType>("systemUpdateInstallType", SystemUpdateInstallType);
            writer.WriteIntValue("systemUpdateWindowEndMinutesAfterMidnight", SystemUpdateWindowEndMinutesAfterMidnight);
            writer.WriteIntValue("systemUpdateWindowStartMinutesAfterMidnight", SystemUpdateWindowStartMinutesAfterMidnight);
            writer.WriteBoolValue("systemWindowsBlocked", SystemWindowsBlocked);
            writer.WriteBoolValue("usersBlockAdd", UsersBlockAdd);
            writer.WriteBoolValue("usersBlockRemove", UsersBlockRemove);
            writer.WriteBoolValue("volumeBlockAdjustment", VolumeBlockAdjustment);
            writer.WriteBoolValue("vpnAlwaysOnLockdownMode", VpnAlwaysOnLockdownMode);
            writer.WriteStringValue("vpnAlwaysOnPackageIdentifier", VpnAlwaysOnPackageIdentifier);
            writer.WriteBoolValue("wifiBlockEditConfigurations", WifiBlockEditConfigurations);
            writer.WriteBoolValue("wifiBlockEditPolicyDefinedConfigurations", WifiBlockEditPolicyDefinedConfigurations);
            writer.WriteIntValue("workProfilePasswordExpirationDays", WorkProfilePasswordExpirationDays);
            writer.WriteIntValue("workProfilePasswordMinimumLength", WorkProfilePasswordMinimumLength);
            writer.WriteIntValue("workProfilePasswordMinimumLetterCharacters", WorkProfilePasswordMinimumLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumLowerCaseCharacters", WorkProfilePasswordMinimumLowerCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumNonLetterCharacters", WorkProfilePasswordMinimumNonLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumNumericCharacters", WorkProfilePasswordMinimumNumericCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumSymbolCharacters", WorkProfilePasswordMinimumSymbolCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumUpperCaseCharacters", WorkProfilePasswordMinimumUpperCaseCharacters);
            writer.WriteIntValue("workProfilePasswordPreviousPasswordCountToBlock", WorkProfilePasswordPreviousPasswordCountToBlock);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("workProfilePasswordRequiredType", WorkProfilePasswordRequiredType);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordUnlock>("workProfilePasswordRequireUnlock", WorkProfilePasswordRequireUnlock);
            writer.WriteIntValue("workProfilePasswordSignInFailureCountBeforeFactoryReset", WorkProfilePasswordSignInFailureCountBeforeFactoryReset);
        }
    }
}
