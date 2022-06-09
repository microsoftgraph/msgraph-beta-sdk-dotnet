using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10GeneralConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to Block the user from adding email accounts to the device that are not associated with a Microsoft account.</summary>
        public bool? AccountsBlockAddingNonMicrosoftAccountEmail {
            get { return BackingStore?.Get<bool?>(nameof(AccountsBlockAddingNonMicrosoftAccountEmail)); }
            set { BackingStore?.Set(nameof(AccountsBlockAddingNonMicrosoftAccountEmail), value); }
        }
        /// <summary>Specifies if Windows apps can be activated by voice. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? ActivateAppsWithVoice {
            get { return BackingStore?.Get<Enablement?>(nameof(ActivateAppsWithVoice)); }
            set { BackingStore?.Set(nameof(ActivateAppsWithVoice), value); }
        }
        /// <summary>Indicates whether or not to block the user from selecting an AntiTheft mode preference (Windows 10 Mobile only).</summary>
        public bool? AntiTheftModeBlocked {
            get { return BackingStore?.Get<bool?>(nameof(AntiTheftModeBlocked)); }
            set { BackingStore?.Set(nameof(AntiTheftModeBlocked), value); }
        }
        /// <summary>This policy setting permits users to change installation options that typically are available only to system administrators.</summary>
        public bool? AppManagementMSIAllowUserControlOverInstall {
            get { return BackingStore?.Get<bool?>(nameof(AppManagementMSIAllowUserControlOverInstall)); }
            set { BackingStore?.Set(nameof(AppManagementMSIAllowUserControlOverInstall), value); }
        }
        /// <summary>This policy setting directs Windows Installer to use elevated permissions when it installs any program on the system.</summary>
        public bool? AppManagementMSIAlwaysInstallWithElevatedPrivileges {
            get { return BackingStore?.Get<bool?>(nameof(AppManagementMSIAlwaysInstallWithElevatedPrivileges)); }
            set { BackingStore?.Set(nameof(AppManagementMSIAlwaysInstallWithElevatedPrivileges), value); }
        }
        /// <summary>List of semi-colon delimited Package Family Names of Windows apps. Listed Windows apps are to be launched after logon.​</summary>
        public List<string> AppManagementPackageFamilyNamesToLaunchAfterLogOn {
            get { return BackingStore?.Get<List<string>>(nameof(AppManagementPackageFamilyNamesToLaunchAfterLogOn)); }
            set { BackingStore?.Set(nameof(AppManagementPackageFamilyNamesToLaunchAfterLogOn), value); }
        }
        /// <summary>Indicates whether apps from AppX packages signed with a trusted certificate can be side loaded. Possible values are: notConfigured, blocked, allowed.</summary>
        public StateManagementSetting? AppsAllowTrustedAppsSideloading {
            get { return BackingStore?.Get<StateManagementSetting?>(nameof(AppsAllowTrustedAppsSideloading)); }
            set { BackingStore?.Set(nameof(AppsAllowTrustedAppsSideloading), value); }
        }
        /// <summary>Indicates whether or not to disable the launch of all apps from Windows Store that came pre-installed or were downloaded.</summary>
        public bool? AppsBlockWindowsStoreOriginatedApps {
            get { return BackingStore?.Get<bool?>(nameof(AppsBlockWindowsStoreOriginatedApps)); }
            set { BackingStore?.Set(nameof(AppsBlockWindowsStoreOriginatedApps), value); }
        }
        /// <summary>Allows secondary authentication devices to work with Windows.</summary>
        public bool? AuthenticationAllowSecondaryDevice {
            get { return BackingStore?.Get<bool?>(nameof(AuthenticationAllowSecondaryDevice)); }
            set { BackingStore?.Set(nameof(AuthenticationAllowSecondaryDevice), value); }
        }
        /// <summary>Specifies the preferred domain among available domains in the Azure AD tenant.</summary>
        public string AuthenticationPreferredAzureADTenantDomainName {
            get { return BackingStore?.Get<string>(nameof(AuthenticationPreferredAzureADTenantDomainName)); }
            set { BackingStore?.Set(nameof(AuthenticationPreferredAzureADTenantDomainName), value); }
        }
        /// <summary>Indicates whether or not Web Credential Provider will be enabled. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? AuthenticationWebSignIn {
            get { return BackingStore?.Get<Enablement?>(nameof(AuthenticationWebSignIn)); }
            set { BackingStore?.Set(nameof(AuthenticationWebSignIn), value); }
        }
        /// <summary>Specify a list of allowed Bluetooth services and profiles in hex formatted strings.</summary>
        public List<string> BluetoothAllowedServices {
            get { return BackingStore?.Get<List<string>>(nameof(BluetoothAllowedServices)); }
            set { BackingStore?.Set(nameof(BluetoothAllowedServices), value); }
        }
        /// <summary>Whether or not to Block the user from using bluetooth advertising.</summary>
        public bool? BluetoothBlockAdvertising {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlockAdvertising)); }
            set { BackingStore?.Set(nameof(BluetoothBlockAdvertising), value); }
        }
        /// <summary>Whether or not to Block the user from using bluetooth discoverable mode.</summary>
        public bool? BluetoothBlockDiscoverableMode {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlockDiscoverableMode)); }
            set { BackingStore?.Set(nameof(BluetoothBlockDiscoverableMode), value); }
        }
        /// <summary>Whether or not to Block the user from using bluetooth.</summary>
        public bool? BluetoothBlocked {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlocked)); }
            set { BackingStore?.Set(nameof(BluetoothBlocked), value); }
        }
        /// <summary>Whether or not to block specific bundled Bluetooth peripherals to automatically pair with the host device.</summary>
        public bool? BluetoothBlockPrePairing {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlockPrePairing)); }
            set { BackingStore?.Set(nameof(BluetoothBlockPrePairing), value); }
        }
        /// <summary>Whether or not to block the users from using Swift Pair and other proximity based scenarios.</summary>
        public bool? BluetoothBlockPromptedProximalConnections {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlockPromptedProximalConnections)); }
            set { BackingStore?.Set(nameof(BluetoothBlockPromptedProximalConnections), value); }
        }
        /// <summary>Whether or not to Block the user from accessing the camera of the device.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>(nameof(CameraBlocked)); }
            set { BackingStore?.Set(nameof(CameraBlocked), value); }
        }
        /// <summary>Whether or not to Block the user from using data over cellular while roaming.</summary>
        public bool? CellularBlockDataWhenRoaming {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockDataWhenRoaming)); }
            set { BackingStore?.Set(nameof(CellularBlockDataWhenRoaming), value); }
        }
        /// <summary>Whether or not to Block the user from using VPN over cellular.</summary>
        public bool? CellularBlockVpn {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockVpn)); }
            set { BackingStore?.Set(nameof(CellularBlockVpn), value); }
        }
        /// <summary>Whether or not to Block the user from using VPN when roaming over cellular.</summary>
        public bool? CellularBlockVpnWhenRoaming {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockVpnWhenRoaming)); }
            set { BackingStore?.Set(nameof(CellularBlockVpnWhenRoaming), value); }
        }
        /// <summary>Whether or not to allow the cellular data channel on the device. If not configured, the cellular data channel is allowed and the user can turn it off. Possible values are: blocked, required, allowed, notConfigured.</summary>
        public ConfigurationUsage? CellularData {
            get { return BackingStore?.Get<ConfigurationUsage?>(nameof(CellularData)); }
            set { BackingStore?.Set(nameof(CellularData), value); }
        }
        /// <summary>Whether or not to Block the user from doing manual root certificate installation.</summary>
        public bool? CertificatesBlockManualRootCertificateInstallation {
            get { return BackingStore?.Get<bool?>(nameof(CertificatesBlockManualRootCertificateInstallation)); }
            set { BackingStore?.Set(nameof(CertificatesBlockManualRootCertificateInstallation), value); }
        }
        /// <summary>Specifies the time zone to be applied to the device. This is the standard Windows name for the target time zone.</summary>
        public string ConfigureTimeZone {
            get { return BackingStore?.Get<string>(nameof(ConfigureTimeZone)); }
            set { BackingStore?.Set(nameof(ConfigureTimeZone), value); }
        }
        /// <summary>Whether or not to block Connected Devices Service which enables discovery and connection to other devices, remote messaging, remote app sessions and other cross-device experiences.</summary>
        public bool? ConnectedDevicesServiceBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ConnectedDevicesServiceBlocked)); }
            set { BackingStore?.Set(nameof(ConnectedDevicesServiceBlocked), value); }
        }
        /// <summary>Whether or not to Block the user from using copy paste.</summary>
        public bool? CopyPasteBlocked {
            get { return BackingStore?.Get<bool?>(nameof(CopyPasteBlocked)); }
            set { BackingStore?.Set(nameof(CopyPasteBlocked), value); }
        }
        /// <summary>Whether or not to Block the user from using Cortana.</summary>
        public bool? CortanaBlocked {
            get { return BackingStore?.Get<bool?>(nameof(CortanaBlocked)); }
            set { BackingStore?.Set(nameof(CortanaBlocked), value); }
        }
        /// <summary>Specify whether to allow or disallow the Federal Information Processing Standard (FIPS) policy.</summary>
        public bool? CryptographyAllowFipsAlgorithmPolicy {
            get { return BackingStore?.Get<bool?>(nameof(CryptographyAllowFipsAlgorithmPolicy)); }
            set { BackingStore?.Set(nameof(CryptographyAllowFipsAlgorithmPolicy), value); }
        }
        /// <summary>This policy setting allows you to block direct memory access (DMA) for all hot pluggable PCI downstream ports until a user logs into Windows.</summary>
        public bool? DataProtectionBlockDirectMemoryAccess {
            get { return BackingStore?.Get<bool?>(nameof(DataProtectionBlockDirectMemoryAccess)); }
            set { BackingStore?.Set(nameof(DataProtectionBlockDirectMemoryAccess), value); }
        }
        /// <summary>Whether or not to block end user access to Defender.</summary>
        public bool? DefenderBlockEndUserAccess {
            get { return BackingStore?.Get<bool?>(nameof(DefenderBlockEndUserAccess)); }
            set { BackingStore?.Set(nameof(DefenderBlockEndUserAccess), value); }
        }
        /// <summary>Allows or disallows Windows Defender On Access Protection functionality.</summary>
        public bool? DefenderBlockOnAccessProtection {
            get { return BackingStore?.Get<bool?>(nameof(DefenderBlockOnAccessProtection)); }
            set { BackingStore?.Set(nameof(DefenderBlockOnAccessProtection), value); }
        }
        /// <summary>Specifies the level of cloud-delivered protection. Possible values are: notConfigured, high, highPlus, zeroTolerance.</summary>
        public DefenderCloudBlockLevelType? DefenderCloudBlockLevel {
            get { return BackingStore?.Get<DefenderCloudBlockLevelType?>(nameof(DefenderCloudBlockLevel)); }
            set { BackingStore?.Set(nameof(DefenderCloudBlockLevel), value); }
        }
        /// <summary>Timeout extension for file scanning by the cloud. Valid values 0 to 50</summary>
        public int? DefenderCloudExtendedTimeout {
            get { return BackingStore?.Get<int?>(nameof(DefenderCloudExtendedTimeout)); }
            set { BackingStore?.Set(nameof(DefenderCloudExtendedTimeout), value); }
        }
        /// <summary>Timeout extension for file scanning by the cloud. Valid values 0 to 50</summary>
        public int? DefenderCloudExtendedTimeoutInSeconds {
            get { return BackingStore?.Get<int?>(nameof(DefenderCloudExtendedTimeoutInSeconds)); }
            set { BackingStore?.Set(nameof(DefenderCloudExtendedTimeoutInSeconds), value); }
        }
        /// <summary>Number of days before deleting quarantined malware. Valid values 0 to 90</summary>
        public int? DefenderDaysBeforeDeletingQuarantinedMalware {
            get { return BackingStore?.Get<int?>(nameof(DefenderDaysBeforeDeletingQuarantinedMalware)); }
            set { BackingStore?.Set(nameof(DefenderDaysBeforeDeletingQuarantinedMalware), value); }
        }
        /// <summary>Gets or sets Defender’s actions to take on detected Malware per threat level.</summary>
        public Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions DefenderDetectedMalwareActions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>(nameof(DefenderDetectedMalwareActions)); }
            set { BackingStore?.Set(nameof(DefenderDetectedMalwareActions), value); }
        }
        /// <summary>When blocked, catch-up scans for scheduled full scans will be turned off.</summary>
        public bool? DefenderDisableCatchupFullScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableCatchupFullScan)); }
            set { BackingStore?.Set(nameof(DefenderDisableCatchupFullScan), value); }
        }
        /// <summary>When blocked, catch-up scans for scheduled quick scans will be turned off.</summary>
        public bool? DefenderDisableCatchupQuickScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableCatchupQuickScan)); }
            set { BackingStore?.Set(nameof(DefenderDisableCatchupQuickScan), value); }
        }
        /// <summary>File extensions to exclude from scans and real time protection.</summary>
        public List<string> DefenderFileExtensionsToExclude {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderFileExtensionsToExclude)); }
            set { BackingStore?.Set(nameof(DefenderFileExtensionsToExclude), value); }
        }
        /// <summary>Files and folder to exclude from scans and real time protection.</summary>
        public List<string> DefenderFilesAndFoldersToExclude {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderFilesAndFoldersToExclude)); }
            set { BackingStore?.Set(nameof(DefenderFilesAndFoldersToExclude), value); }
        }
        /// <summary>Value for monitoring file activity. Possible values are: userDefined, disable, monitorAllFiles, monitorIncomingFilesOnly, monitorOutgoingFilesOnly.</summary>
        public Microsoft.Graph.Beta.Models.DefenderMonitorFileActivity? DefenderMonitorFileActivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderMonitorFileActivity?>(nameof(DefenderMonitorFileActivity)); }
            set { BackingStore?.Set(nameof(DefenderMonitorFileActivity), value); }
        }
        /// <summary>Gets or sets Defender’s action to take on Potentially Unwanted Application (PUA), which includes software with behaviors of ad-injection, software bundling, persistent solicitation for payment or subscription, etc. Defender alerts user when PUA is being downloaded or attempts to install itself. Added in Windows 10 for desktop. Possible values are: deviceDefault, block, audit.</summary>
        public Microsoft.Graph.Beta.Models.DefenderPotentiallyUnwantedAppAction? DefenderPotentiallyUnwantedAppAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderPotentiallyUnwantedAppAction?>(nameof(DefenderPotentiallyUnwantedAppAction)); }
            set { BackingStore?.Set(nameof(DefenderPotentiallyUnwantedAppAction), value); }
        }
        /// <summary>Gets or sets Defender’s action to take on Potentially Unwanted Application (PUA), which includes software with behaviors of ad-injection, software bundling, persistent solicitation for payment or subscription, etc. Defender alerts user when PUA is being downloaded or attempts to install itself. Added in Windows 10 for desktop. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderPotentiallyUnwantedAppActionSetting {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderPotentiallyUnwantedAppActionSetting)); }
            set { BackingStore?.Set(nameof(DefenderPotentiallyUnwantedAppActionSetting), value); }
        }
        /// <summary>Processes to exclude from scans and real time protection.</summary>
        public List<string> DefenderProcessesToExclude {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderProcessesToExclude)); }
            set { BackingStore?.Set(nameof(DefenderProcessesToExclude), value); }
        }
        /// <summary>The configuration for how to prompt user for sample submission. Possible values are: userDefined, alwaysPrompt, promptBeforeSendingPersonalData, neverSendData, sendAllDataWithoutPrompting.</summary>
        public Microsoft.Graph.Beta.Models.DefenderPromptForSampleSubmission? DefenderPromptForSampleSubmission {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderPromptForSampleSubmission?>(nameof(DefenderPromptForSampleSubmission)); }
            set { BackingStore?.Set(nameof(DefenderPromptForSampleSubmission), value); }
        }
        /// <summary>Indicates whether or not to require behavior monitoring.</summary>
        public bool? DefenderRequireBehaviorMonitoring {
            get { return BackingStore?.Get<bool?>(nameof(DefenderRequireBehaviorMonitoring)); }
            set { BackingStore?.Set(nameof(DefenderRequireBehaviorMonitoring), value); }
        }
        /// <summary>Indicates whether or not to require cloud protection.</summary>
        public bool? DefenderRequireCloudProtection {
            get { return BackingStore?.Get<bool?>(nameof(DefenderRequireCloudProtection)); }
            set { BackingStore?.Set(nameof(DefenderRequireCloudProtection), value); }
        }
        /// <summary>Indicates whether or not to require network inspection system.</summary>
        public bool? DefenderRequireNetworkInspectionSystem {
            get { return BackingStore?.Get<bool?>(nameof(DefenderRequireNetworkInspectionSystem)); }
            set { BackingStore?.Set(nameof(DefenderRequireNetworkInspectionSystem), value); }
        }
        /// <summary>Indicates whether or not to require real time monitoring.</summary>
        public bool? DefenderRequireRealTimeMonitoring {
            get { return BackingStore?.Get<bool?>(nameof(DefenderRequireRealTimeMonitoring)); }
            set { BackingStore?.Set(nameof(DefenderRequireRealTimeMonitoring), value); }
        }
        /// <summary>Indicates whether or not to scan archive files.</summary>
        public bool? DefenderScanArchiveFiles {
            get { return BackingStore?.Get<bool?>(nameof(DefenderScanArchiveFiles)); }
            set { BackingStore?.Set(nameof(DefenderScanArchiveFiles), value); }
        }
        /// <summary>Indicates whether or not to scan downloads.</summary>
        public bool? DefenderScanDownloads {
            get { return BackingStore?.Get<bool?>(nameof(DefenderScanDownloads)); }
            set { BackingStore?.Set(nameof(DefenderScanDownloads), value); }
        }
        /// <summary>Indicates whether or not to scan incoming mail messages.</summary>
        public bool? DefenderScanIncomingMail {
            get { return BackingStore?.Get<bool?>(nameof(DefenderScanIncomingMail)); }
            set { BackingStore?.Set(nameof(DefenderScanIncomingMail), value); }
        }
        /// <summary>Indicates whether or not to scan mapped network drives during full scan.</summary>
        public bool? DefenderScanMappedNetworkDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderScanMappedNetworkDrivesDuringFullScan)); }
            set { BackingStore?.Set(nameof(DefenderScanMappedNetworkDrivesDuringFullScan), value); }
        }
        /// <summary>Max CPU usage percentage during scan. Valid values 0 to 100</summary>
        public int? DefenderScanMaxCpu {
            get { return BackingStore?.Get<int?>(nameof(DefenderScanMaxCpu)); }
            set { BackingStore?.Set(nameof(DefenderScanMaxCpu), value); }
        }
        /// <summary>Indicates whether or not to scan files opened from a network folder.</summary>
        public bool? DefenderScanNetworkFiles {
            get { return BackingStore?.Get<bool?>(nameof(DefenderScanNetworkFiles)); }
            set { BackingStore?.Set(nameof(DefenderScanNetworkFiles), value); }
        }
        /// <summary>Indicates whether or not to scan removable drives during full scan.</summary>
        public bool? DefenderScanRemovableDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderScanRemovableDrivesDuringFullScan)); }
            set { BackingStore?.Set(nameof(DefenderScanRemovableDrivesDuringFullScan), value); }
        }
        /// <summary>Indicates whether or not to scan scripts loaded in Internet Explorer browser.</summary>
        public bool? DefenderScanScriptsLoadedInInternetExplorer {
            get { return BackingStore?.Get<bool?>(nameof(DefenderScanScriptsLoadedInInternetExplorer)); }
            set { BackingStore?.Set(nameof(DefenderScanScriptsLoadedInInternetExplorer), value); }
        }
        /// <summary>The defender system scan type. Possible values are: userDefined, disabled, quick, full.</summary>
        public Microsoft.Graph.Beta.Models.DefenderScanType? DefenderScanType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderScanType?>(nameof(DefenderScanType)); }
            set { BackingStore?.Set(nameof(DefenderScanType), value); }
        }
        /// <summary>The time to perform a daily quick scan.</summary>
        public Time? DefenderScheduledQuickScanTime {
            get { return BackingStore?.Get<Time?>(nameof(DefenderScheduledQuickScanTime)); }
            set { BackingStore?.Set(nameof(DefenderScheduledQuickScanTime), value); }
        }
        /// <summary>The defender time for the system scan.</summary>
        public Time? DefenderScheduledScanTime {
            get { return BackingStore?.Get<Time?>(nameof(DefenderScheduledScanTime)); }
            set { BackingStore?.Set(nameof(DefenderScheduledScanTime), value); }
        }
        /// <summary>When enabled, low CPU priority will be used during scheduled scans.</summary>
        public bool? DefenderScheduleScanEnableLowCpuPriority {
            get { return BackingStore?.Get<bool?>(nameof(DefenderScheduleScanEnableLowCpuPriority)); }
            set { BackingStore?.Set(nameof(DefenderScheduleScanEnableLowCpuPriority), value); }
        }
        /// <summary>The signature update interval in hours. Specify 0 not to check. Valid values 0 to 24</summary>
        public int? DefenderSignatureUpdateIntervalInHours {
            get { return BackingStore?.Get<int?>(nameof(DefenderSignatureUpdateIntervalInHours)); }
            set { BackingStore?.Set(nameof(DefenderSignatureUpdateIntervalInHours), value); }
        }
        /// <summary>Checks for the user consent level in Windows Defender to send data. Possible values are: sendSafeSamplesAutomatically, alwaysPrompt, neverSend, sendAllSamplesAutomatically.</summary>
        public Microsoft.Graph.Beta.Models.DefenderSubmitSamplesConsentType? DefenderSubmitSamplesConsentType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderSubmitSamplesConsentType?>(nameof(DefenderSubmitSamplesConsentType)); }
            set { BackingStore?.Set(nameof(DefenderSubmitSamplesConsentType), value); }
        }
        /// <summary>Defender day of the week for the system scan. Possible values are: userDefined, everyday, sunday, monday, tuesday, wednesday, thursday, friday, saturday, noScheduledScan.</summary>
        public WeeklySchedule? DefenderSystemScanSchedule {
            get { return BackingStore?.Get<WeeklySchedule?>(nameof(DefenderSystemScanSchedule)); }
            set { BackingStore?.Set(nameof(DefenderSystemScanSchedule), value); }
        }
        /// <summary>Indicates whether or not to allow developer unlock. Possible values are: notConfigured, blocked, allowed.</summary>
        public StateManagementSetting? DeveloperUnlockSetting {
            get { return BackingStore?.Get<StateManagementSetting?>(nameof(DeveloperUnlockSetting)); }
            set { BackingStore?.Set(nameof(DeveloperUnlockSetting), value); }
        }
        /// <summary>Indicates whether or not to Block the user from resetting their phone.</summary>
        public bool? DeviceManagementBlockFactoryResetOnMobile {
            get { return BackingStore?.Get<bool?>(nameof(DeviceManagementBlockFactoryResetOnMobile)); }
            set { BackingStore?.Set(nameof(DeviceManagementBlockFactoryResetOnMobile), value); }
        }
        /// <summary>Indicates whether or not to Block the user from doing manual un-enrollment from device management.</summary>
        public bool? DeviceManagementBlockManualUnenroll {
            get { return BackingStore?.Get<bool?>(nameof(DeviceManagementBlockManualUnenroll)); }
            set { BackingStore?.Set(nameof(DeviceManagementBlockManualUnenroll), value); }
        }
        /// <summary>Gets or sets a value allowing the device to send diagnostic and usage telemetry data, such as Watson. Possible values are: userDefined, none, basic, enhanced, full.</summary>
        public DiagnosticDataSubmissionMode? DiagnosticsDataSubmissionMode {
            get { return BackingStore?.Get<DiagnosticDataSubmissionMode?>(nameof(DiagnosticsDataSubmissionMode)); }
            set { BackingStore?.Set(nameof(DiagnosticsDataSubmissionMode), value); }
        }
        /// <summary>List of legacy applications that have GDI DPI Scaling turned off.</summary>
        public List<string> DisplayAppListWithGdiDPIScalingTurnedOff {
            get { return BackingStore?.Get<List<string>>(nameof(DisplayAppListWithGdiDPIScalingTurnedOff)); }
            set { BackingStore?.Set(nameof(DisplayAppListWithGdiDPIScalingTurnedOff), value); }
        }
        /// <summary>List of legacy applications that have GDI DPI Scaling turned on.</summary>
        public List<string> DisplayAppListWithGdiDPIScalingTurnedOn {
            get { return BackingStore?.Get<List<string>>(nameof(DisplayAppListWithGdiDPIScalingTurnedOn)); }
            set { BackingStore?.Set(nameof(DisplayAppListWithGdiDPIScalingTurnedOn), value); }
        }
        /// <summary>Allow users to change Start pages on Edge. Use the EdgeHomepageUrls to specify the Start pages that the user would see by default when they open Edge.</summary>
        public bool? EdgeAllowStartPagesModification {
            get { return BackingStore?.Get<bool?>(nameof(EdgeAllowStartPagesModification)); }
            set { BackingStore?.Set(nameof(EdgeAllowStartPagesModification), value); }
        }
        /// <summary>Indicates whether or not to prevent access to about flags on Edge browser.</summary>
        public bool? EdgeBlockAccessToAboutFlags {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockAccessToAboutFlags)); }
            set { BackingStore?.Set(nameof(EdgeBlockAccessToAboutFlags), value); }
        }
        /// <summary>Block the address bar dropdown functionality in Microsoft Edge. Disable this settings to minimize network connections from Microsoft Edge to Microsoft services.</summary>
        public bool? EdgeBlockAddressBarDropdown {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockAddressBarDropdown)); }
            set { BackingStore?.Set(nameof(EdgeBlockAddressBarDropdown), value); }
        }
        /// <summary>Indicates whether or not to block auto fill.</summary>
        public bool? EdgeBlockAutofill {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockAutofill)); }
            set { BackingStore?.Set(nameof(EdgeBlockAutofill), value); }
        }
        /// <summary>Block Microsoft compatibility list in Microsoft Edge. This list from Microsoft helps Edge properly display sites with known compatibility issues.</summary>
        public bool? EdgeBlockCompatibilityList {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockCompatibilityList)); }
            set { BackingStore?.Set(nameof(EdgeBlockCompatibilityList), value); }
        }
        /// <summary>Indicates whether or not to block developer tools in the Edge browser.</summary>
        public bool? EdgeBlockDeveloperTools {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockDeveloperTools)); }
            set { BackingStore?.Set(nameof(EdgeBlockDeveloperTools), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using the Edge browser.</summary>
        public bool? EdgeBlocked {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlocked)); }
            set { BackingStore?.Set(nameof(EdgeBlocked), value); }
        }
        /// <summary>Indicates whether or not to Block the user from making changes to Favorites.</summary>
        public bool? EdgeBlockEditFavorites {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockEditFavorites)); }
            set { BackingStore?.Set(nameof(EdgeBlockEditFavorites), value); }
        }
        /// <summary>Indicates whether or not to block extensions in the Edge browser.</summary>
        public bool? EdgeBlockExtensions {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockExtensions)); }
            set { BackingStore?.Set(nameof(EdgeBlockExtensions), value); }
        }
        /// <summary>Allow or prevent Edge from entering the full screen mode.</summary>
        public bool? EdgeBlockFullScreenMode {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockFullScreenMode)); }
            set { BackingStore?.Set(nameof(EdgeBlockFullScreenMode), value); }
        }
        /// <summary>Indicates whether or not to block InPrivate browsing on corporate networks, in the Edge browser.</summary>
        public bool? EdgeBlockInPrivateBrowsing {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockInPrivateBrowsing)); }
            set { BackingStore?.Set(nameof(EdgeBlockInPrivateBrowsing), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using JavaScript.</summary>
        public bool? EdgeBlockJavaScript {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockJavaScript)); }
            set { BackingStore?.Set(nameof(EdgeBlockJavaScript), value); }
        }
        /// <summary>Block the collection of information by Microsoft for live tile creation when users pin a site to Start from Microsoft Edge.</summary>
        public bool? EdgeBlockLiveTileDataCollection {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockLiveTileDataCollection)); }
            set { BackingStore?.Set(nameof(EdgeBlockLiveTileDataCollection), value); }
        }
        /// <summary>Indicates whether or not to Block password manager.</summary>
        public bool? EdgeBlockPasswordManager {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockPasswordManager)); }
            set { BackingStore?.Set(nameof(EdgeBlockPasswordManager), value); }
        }
        /// <summary>Indicates whether or not to block popups.</summary>
        public bool? EdgeBlockPopups {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockPopups)); }
            set { BackingStore?.Set(nameof(EdgeBlockPopups), value); }
        }
        /// <summary>Decide whether Microsoft Edge is prelaunched at Windows startup.</summary>
        public bool? EdgeBlockPrelaunch {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockPrelaunch)); }
            set { BackingStore?.Set(nameof(EdgeBlockPrelaunch), value); }
        }
        /// <summary>Configure Edge to allow or block printing.</summary>
        public bool? EdgeBlockPrinting {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockPrinting)); }
            set { BackingStore?.Set(nameof(EdgeBlockPrinting), value); }
        }
        /// <summary>Configure Edge to allow browsing history to be saved or to never save browsing history.</summary>
        public bool? EdgeBlockSavingHistory {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockSavingHistory)); }
            set { BackingStore?.Set(nameof(EdgeBlockSavingHistory), value); }
        }
        /// <summary>Indicates whether or not to block the user from adding new search engine or changing the default search engine.</summary>
        public bool? EdgeBlockSearchEngineCustomization {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockSearchEngineCustomization)); }
            set { BackingStore?.Set(nameof(EdgeBlockSearchEngineCustomization), value); }
        }
        /// <summary>Indicates whether or not to block the user from using the search suggestions in the address bar.</summary>
        public bool? EdgeBlockSearchSuggestions {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockSearchSuggestions)); }
            set { BackingStore?.Set(nameof(EdgeBlockSearchSuggestions), value); }
        }
        /// <summary>Indicates whether or not to Block the user from sending the do not track header.</summary>
        public bool? EdgeBlockSendingDoNotTrackHeader {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockSendingDoNotTrackHeader)); }
            set { BackingStore?.Set(nameof(EdgeBlockSendingDoNotTrackHeader), value); }
        }
        /// <summary>Indicates whether or not to switch the intranet traffic from Edge to Internet Explorer. Note: the name of this property is misleading; the property is obsolete, use EdgeSendIntranetTrafficToInternetExplorer instead.</summary>
        public bool? EdgeBlockSendingIntranetTrafficToInternetExplorer {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockSendingIntranetTrafficToInternetExplorer)); }
            set { BackingStore?.Set(nameof(EdgeBlockSendingIntranetTrafficToInternetExplorer), value); }
        }
        /// <summary>Indicates whether the user can sideload extensions.</summary>
        public bool? EdgeBlockSideloadingExtensions {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockSideloadingExtensions)); }
            set { BackingStore?.Set(nameof(EdgeBlockSideloadingExtensions), value); }
        }
        /// <summary>Configure whether Edge preloads the new tab page at Windows startup.</summary>
        public bool? EdgeBlockTabPreloading {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockTabPreloading)); }
            set { BackingStore?.Set(nameof(EdgeBlockTabPreloading), value); }
        }
        /// <summary>Configure to load a blank page in Edge instead of the default New tab page and prevent users from changing it.</summary>
        public bool? EdgeBlockWebContentOnNewTabPage {
            get { return BackingStore?.Get<bool?>(nameof(EdgeBlockWebContentOnNewTabPage)); }
            set { BackingStore?.Set(nameof(EdgeBlockWebContentOnNewTabPage), value); }
        }
        /// <summary>Clear browsing data on exiting Microsoft Edge.</summary>
        public bool? EdgeClearBrowsingDataOnExit {
            get { return BackingStore?.Get<bool?>(nameof(EdgeClearBrowsingDataOnExit)); }
            set { BackingStore?.Set(nameof(EdgeClearBrowsingDataOnExit), value); }
        }
        /// <summary>Indicates which cookies to block in the Edge browser. Possible values are: userDefined, allow, blockThirdParty, blockAll.</summary>
        public Microsoft.Graph.Beta.Models.EdgeCookiePolicy? EdgeCookiePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EdgeCookiePolicy?>(nameof(EdgeCookiePolicy)); }
            set { BackingStore?.Set(nameof(EdgeCookiePolicy), value); }
        }
        /// <summary>Block the Microsoft web page that opens on the first use of Microsoft Edge. This policy allows enterprises, like those enrolled in zero emissions configurations, to block this page.</summary>
        public bool? EdgeDisableFirstRunPage {
            get { return BackingStore?.Get<bool?>(nameof(EdgeDisableFirstRunPage)); }
            set { BackingStore?.Set(nameof(EdgeDisableFirstRunPage), value); }
        }
        /// <summary>Indicates the enterprise mode site list location. Could be a local file, local network or http location.</summary>
        public string EdgeEnterpriseModeSiteListLocation {
            get { return BackingStore?.Get<string>(nameof(EdgeEnterpriseModeSiteListLocation)); }
            set { BackingStore?.Set(nameof(EdgeEnterpriseModeSiteListLocation), value); }
        }
        /// <summary>Get or set a value that specifies whether to set the favorites bar to always be visible or hidden on any page. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? EdgeFavoritesBarVisibility {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(EdgeFavoritesBarVisibility)); }
            set { BackingStore?.Set(nameof(EdgeFavoritesBarVisibility), value); }
        }
        /// <summary>The location of the favorites list to provision. Could be a local file, local network or http location.</summary>
        public string EdgeFavoritesListLocation {
            get { return BackingStore?.Get<string>(nameof(EdgeFavoritesListLocation)); }
            set { BackingStore?.Set(nameof(EdgeFavoritesListLocation), value); }
        }
        /// <summary>The first run URL for when Edge browser is opened for the first time.</summary>
        public string EdgeFirstRunUrl {
            get { return BackingStore?.Get<string>(nameof(EdgeFirstRunUrl)); }
            set { BackingStore?.Set(nameof(EdgeFirstRunUrl), value); }
        }
        /// <summary>Causes the Home button to either hide, load the default Start page, load a New tab page, or a custom URL</summary>
        public Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration EdgeHomeButtonConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration>(nameof(EdgeHomeButtonConfiguration)); }
            set { BackingStore?.Set(nameof(EdgeHomeButtonConfiguration), value); }
        }
        /// <summary>Enable the Home button configuration.</summary>
        public bool? EdgeHomeButtonConfigurationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(EdgeHomeButtonConfigurationEnabled)); }
            set { BackingStore?.Set(nameof(EdgeHomeButtonConfigurationEnabled), value); }
        }
        /// <summary>The list of URLs for homepages shodwn on MDM-enrolled devices on Edge browser.</summary>
        public List<string> EdgeHomepageUrls {
            get { return BackingStore?.Get<List<string>>(nameof(EdgeHomepageUrls)); }
            set { BackingStore?.Set(nameof(EdgeHomepageUrls), value); }
        }
        /// <summary>Controls how the Microsoft Edge settings are restricted based on the configure kiosk mode. Possible values are: notConfigured, digitalSignage, normalMode, publicBrowsingSingleApp, publicBrowsingMultiApp.</summary>
        public EdgeKioskModeRestrictionType? EdgeKioskModeRestriction {
            get { return BackingStore?.Get<EdgeKioskModeRestrictionType?>(nameof(EdgeKioskModeRestriction)); }
            set { BackingStore?.Set(nameof(EdgeKioskModeRestriction), value); }
        }
        /// <summary>Specifies the time in minutes from the last user activity before Microsoft Edge kiosk resets.  Valid values are 0-1440. The default is 5. 0 indicates no reset. Valid values 0 to 1440</summary>
        public int? EdgeKioskResetAfterIdleTimeInMinutes {
            get { return BackingStore?.Get<int?>(nameof(EdgeKioskResetAfterIdleTimeInMinutes)); }
            set { BackingStore?.Set(nameof(EdgeKioskResetAfterIdleTimeInMinutes), value); }
        }
        /// <summary>Specify the page opened when new tabs are created.</summary>
        public string EdgeNewTabPageURL {
            get { return BackingStore?.Get<string>(nameof(EdgeNewTabPageURL)); }
            set { BackingStore?.Set(nameof(EdgeNewTabPageURL), value); }
        }
        /// <summary>Specify what kind of pages are open at start. Possible values are: notConfigured, startPage, newTabPage, previousPages, specificPages.</summary>
        public EdgeOpenOptions? EdgeOpensWith {
            get { return BackingStore?.Get<EdgeOpenOptions?>(nameof(EdgeOpensWith)); }
            set { BackingStore?.Set(nameof(EdgeOpensWith), value); }
        }
        /// <summary>Allow or prevent users from overriding certificate errors.</summary>
        public bool? EdgePreventCertificateErrorOverride {
            get { return BackingStore?.Get<bool?>(nameof(EdgePreventCertificateErrorOverride)); }
            set { BackingStore?.Set(nameof(EdgePreventCertificateErrorOverride), value); }
        }
        /// <summary>Specify the list of package family names of browser extensions that are required and cannot be turned off by the user.</summary>
        public List<string> EdgeRequiredExtensionPackageFamilyNames {
            get { return BackingStore?.Get<List<string>>(nameof(EdgeRequiredExtensionPackageFamilyNames)); }
            set { BackingStore?.Set(nameof(EdgeRequiredExtensionPackageFamilyNames), value); }
        }
        /// <summary>Indicates whether or not to Require the user to use the smart screen filter.</summary>
        public bool? EdgeRequireSmartScreen {
            get { return BackingStore?.Get<bool?>(nameof(EdgeRequireSmartScreen)); }
            set { BackingStore?.Set(nameof(EdgeRequireSmartScreen), value); }
        }
        /// <summary>Allows IT admins to set a default search engine for MDM-Controlled devices. Users can override this and change their default search engine provided the AllowSearchEngineCustomization policy is not set.</summary>
        public EdgeSearchEngineBase EdgeSearchEngine {
            get { return BackingStore?.Get<EdgeSearchEngineBase>(nameof(EdgeSearchEngine)); }
            set { BackingStore?.Set(nameof(EdgeSearchEngine), value); }
        }
        /// <summary>Indicates whether or not to switch the intranet traffic from Edge to Internet Explorer.</summary>
        public bool? EdgeSendIntranetTrafficToInternetExplorer {
            get { return BackingStore?.Get<bool?>(nameof(EdgeSendIntranetTrafficToInternetExplorer)); }
            set { BackingStore?.Set(nameof(EdgeSendIntranetTrafficToInternetExplorer), value); }
        }
        /// <summary>Controls the message displayed by Edge before switching to Internet Explorer. Possible values are: notConfigured, disabled, enabled, keepGoing.</summary>
        public InternetExplorerMessageSetting? EdgeShowMessageWhenOpeningInternetExplorerSites {
            get { return BackingStore?.Get<InternetExplorerMessageSetting?>(nameof(EdgeShowMessageWhenOpeningInternetExplorerSites)); }
            set { BackingStore?.Set(nameof(EdgeShowMessageWhenOpeningInternetExplorerSites), value); }
        }
        /// <summary>Enable favorites sync between Internet Explorer and Microsoft Edge. Additions, deletions, modifications and order changes to favorites are shared between browsers.</summary>
        public bool? EdgeSyncFavoritesWithInternetExplorer {
            get { return BackingStore?.Get<bool?>(nameof(EdgeSyncFavoritesWithInternetExplorer)); }
            set { BackingStore?.Set(nameof(EdgeSyncFavoritesWithInternetExplorer), value); }
        }
        /// <summary>Specifies what type of telemetry data (none, intranet, internet, both) is sent to Microsoft 365 Analytics. Possible values are: notConfigured, intranet, internet, intranetAndInternet.</summary>
        public EdgeTelemetryMode? EdgeTelemetryForMicrosoft365Analytics {
            get { return BackingStore?.Get<EdgeTelemetryMode?>(nameof(EdgeTelemetryForMicrosoft365Analytics)); }
            set { BackingStore?.Set(nameof(EdgeTelemetryForMicrosoft365Analytics), value); }
        }
        /// <summary>Allow users with administrative rights to delete all user data and settings using CTRL + Win + R at the device lock screen so that the device can be automatically re-configured and re-enrolled into management.</summary>
        public bool? EnableAutomaticRedeployment {
            get { return BackingStore?.Get<bool?>(nameof(EnableAutomaticRedeployment)); }
            set { BackingStore?.Set(nameof(EnableAutomaticRedeployment), value); }
        }
        /// <summary>This setting allows you to specify battery charge level at which Energy Saver is turned on. While on battery, Energy Saver is automatically turned on at (and below) the specified battery charge level. Valid input range (0-100). Valid values 0 to 100</summary>
        public int? EnergySaverOnBatteryThresholdPercentage {
            get { return BackingStore?.Get<int?>(nameof(EnergySaverOnBatteryThresholdPercentage)); }
            set { BackingStore?.Set(nameof(EnergySaverOnBatteryThresholdPercentage), value); }
        }
        /// <summary>This setting allows you to specify battery charge level at which Energy Saver is turned on. While plugged in, Energy Saver is automatically turned on at (and below) the specified battery charge level. Valid input range (0-100). Valid values 0 to 100</summary>
        public int? EnergySaverPluggedInThresholdPercentage {
            get { return BackingStore?.Get<int?>(nameof(EnergySaverPluggedInThresholdPercentage)); }
            set { BackingStore?.Set(nameof(EnergySaverPluggedInThresholdPercentage), value); }
        }
        /// <summary>Endpoint for discovering cloud printers.</summary>
        public string EnterpriseCloudPrintDiscoveryEndPoint {
            get { return BackingStore?.Get<string>(nameof(EnterpriseCloudPrintDiscoveryEndPoint)); }
            set { BackingStore?.Set(nameof(EnterpriseCloudPrintDiscoveryEndPoint), value); }
        }
        /// <summary>Maximum number of printers that should be queried from a discovery endpoint. This is a mobile only setting. Valid values 1 to 65535</summary>
        public int? EnterpriseCloudPrintDiscoveryMaxLimit {
            get { return BackingStore?.Get<int?>(nameof(EnterpriseCloudPrintDiscoveryMaxLimit)); }
            set { BackingStore?.Set(nameof(EnterpriseCloudPrintDiscoveryMaxLimit), value); }
        }
        /// <summary>OAuth resource URI for printer discovery service as configured in Azure portal.</summary>
        public string EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier {
            get { return BackingStore?.Get<string>(nameof(EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier)); }
            set { BackingStore?.Set(nameof(EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier), value); }
        }
        /// <summary>Authentication endpoint for acquiring OAuth tokens.</summary>
        public string EnterpriseCloudPrintOAuthAuthority {
            get { return BackingStore?.Get<string>(nameof(EnterpriseCloudPrintOAuthAuthority)); }
            set { BackingStore?.Set(nameof(EnterpriseCloudPrintOAuthAuthority), value); }
        }
        /// <summary>GUID of a client application authorized to retrieve OAuth tokens from the OAuth Authority.</summary>
        public string EnterpriseCloudPrintOAuthClientIdentifier {
            get { return BackingStore?.Get<string>(nameof(EnterpriseCloudPrintOAuthClientIdentifier)); }
            set { BackingStore?.Set(nameof(EnterpriseCloudPrintOAuthClientIdentifier), value); }
        }
        /// <summary>OAuth resource URI for print service as configured in the Azure portal.</summary>
        public string EnterpriseCloudPrintResourceIdentifier {
            get { return BackingStore?.Get<string>(nameof(EnterpriseCloudPrintResourceIdentifier)); }
            set { BackingStore?.Set(nameof(EnterpriseCloudPrintResourceIdentifier), value); }
        }
        /// <summary>Indicates whether or not to enable device discovery UX.</summary>
        public bool? ExperienceBlockDeviceDiscovery {
            get { return BackingStore?.Get<bool?>(nameof(ExperienceBlockDeviceDiscovery)); }
            set { BackingStore?.Set(nameof(ExperienceBlockDeviceDiscovery), value); }
        }
        /// <summary>Indicates whether or not to allow the error dialog from displaying if no SIM card is detected.</summary>
        public bool? ExperienceBlockErrorDialogWhenNoSIM {
            get { return BackingStore?.Get<bool?>(nameof(ExperienceBlockErrorDialogWhenNoSIM)); }
            set { BackingStore?.Set(nameof(ExperienceBlockErrorDialogWhenNoSIM), value); }
        }
        /// <summary>Indicates whether or not to enable task switching on the device.</summary>
        public bool? ExperienceBlockTaskSwitcher {
            get { return BackingStore?.Get<bool?>(nameof(ExperienceBlockTaskSwitcher)); }
            set { BackingStore?.Set(nameof(ExperienceBlockTaskSwitcher), value); }
        }
        /// <summary>Allow or prevent the syncing of Microsoft Edge Browser settings. Option for IT admins to prevent syncing across devices, but allow user override. Possible values are: notConfigured, blockedWithUserOverride, blocked.</summary>
        public BrowserSyncSetting? ExperienceDoNotSyncBrowserSettings {
            get { return BackingStore?.Get<BrowserSyncSetting?>(nameof(ExperienceDoNotSyncBrowserSettings)); }
            set { BackingStore?.Set(nameof(ExperienceDoNotSyncBrowserSettings), value); }
        }
        /// <summary>Controls if the user can configure search to Find My Files mode, which searches files in secondary hard drives and also outside of the user profile. Find My Files does not allow users to search files or locations to which they do not have access. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? FindMyFiles {
            get { return BackingStore?.Get<Enablement?>(nameof(FindMyFiles)); }
            set { BackingStore?.Set(nameof(FindMyFiles), value); }
        }
        /// <summary>Indicates whether or not to block DVR and broadcasting.</summary>
        public bool? GameDvrBlocked {
            get { return BackingStore?.Get<bool?>(nameof(GameDvrBlocked)); }
            set { BackingStore?.Set(nameof(GameDvrBlocked), value); }
        }
        /// <summary>Controls the user access to the ink workspace, from the desktop and from above the lock screen. Possible values are: notConfigured, enabled, disabled.</summary>
        public InkAccessSetting? InkWorkspaceAccess {
            get { return BackingStore?.Get<InkAccessSetting?>(nameof(InkWorkspaceAccess)); }
            set { BackingStore?.Set(nameof(InkWorkspaceAccess), value); }
        }
        /// <summary>Controls the user access to the ink workspace, from the desktop and from above the lock screen. Possible values are: notConfigured, blocked, allowed.</summary>
        public StateManagementSetting? InkWorkspaceAccessState {
            get { return BackingStore?.Get<StateManagementSetting?>(nameof(InkWorkspaceAccessState)); }
            set { BackingStore?.Set(nameof(InkWorkspaceAccessState), value); }
        }
        /// <summary>Specify whether to show recommended app suggestions in the ink workspace.</summary>
        public bool? InkWorkspaceBlockSuggestedApps {
            get { return BackingStore?.Get<bool?>(nameof(InkWorkspaceBlockSuggestedApps)); }
            set { BackingStore?.Set(nameof(InkWorkspaceBlockSuggestedApps), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using internet sharing.</summary>
        public bool? InternetSharingBlocked {
            get { return BackingStore?.Get<bool?>(nameof(InternetSharingBlocked)); }
            set { BackingStore?.Set(nameof(InternetSharingBlocked), value); }
        }
        /// <summary>Indicates whether or not to Block the user from location services.</summary>
        public bool? LocationServicesBlocked {
            get { return BackingStore?.Get<bool?>(nameof(LocationServicesBlocked)); }
            set { BackingStore?.Set(nameof(LocationServicesBlocked), value); }
        }
        /// <summary>This policy setting specifies whether Windows apps can be activated by voice while the system is locked. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? LockScreenActivateAppsWithVoice {
            get { return BackingStore?.Get<Enablement?>(nameof(LockScreenActivateAppsWithVoice)); }
            set { BackingStore?.Set(nameof(LockScreenActivateAppsWithVoice), value); }
        }
        /// <summary>Specify whether to show a user-configurable setting to control the screen timeout while on the lock screen of Windows 10 Mobile devices. If this policy is set to Allow, the value set by lockScreenTimeoutInSeconds is ignored.</summary>
        public bool? LockScreenAllowTimeoutConfiguration {
            get { return BackingStore?.Get<bool?>(nameof(LockScreenAllowTimeoutConfiguration)); }
            set { BackingStore?.Set(nameof(LockScreenAllowTimeoutConfiguration), value); }
        }
        /// <summary>Indicates whether or not to block action center notifications over lock screen.</summary>
        public bool? LockScreenBlockActionCenterNotifications {
            get { return BackingStore?.Get<bool?>(nameof(LockScreenBlockActionCenterNotifications)); }
            set { BackingStore?.Set(nameof(LockScreenBlockActionCenterNotifications), value); }
        }
        /// <summary>Indicates whether or not the user can interact with Cortana using speech while the system is locked.</summary>
        public bool? LockScreenBlockCortana {
            get { return BackingStore?.Get<bool?>(nameof(LockScreenBlockCortana)); }
            set { BackingStore?.Set(nameof(LockScreenBlockCortana), value); }
        }
        /// <summary>Indicates whether to allow toast notifications above the device lock screen.</summary>
        public bool? LockScreenBlockToastNotifications {
            get { return BackingStore?.Get<bool?>(nameof(LockScreenBlockToastNotifications)); }
            set { BackingStore?.Set(nameof(LockScreenBlockToastNotifications), value); }
        }
        /// <summary>Set the duration (in seconds) from the screen locking to the screen turning off for Windows 10 Mobile devices. Supported values are 11-1800. Valid values 11 to 1800</summary>
        public int? LockScreenTimeoutInSeconds {
            get { return BackingStore?.Get<int?>(nameof(LockScreenTimeoutInSeconds)); }
            set { BackingStore?.Set(nameof(LockScreenTimeoutInSeconds), value); }
        }
        /// <summary>Disables the ability to quickly switch between users that are logged on simultaneously without logging off.</summary>
        public bool? LogonBlockFastUserSwitching {
            get { return BackingStore?.Get<bool?>(nameof(LogonBlockFastUserSwitching)); }
            set { BackingStore?.Set(nameof(LogonBlockFastUserSwitching), value); }
        }
        /// <summary>Indicates whether or not to block the MMS send/receive functionality on the device.</summary>
        public bool? MessagingBlockMMS {
            get { return BackingStore?.Get<bool?>(nameof(MessagingBlockMMS)); }
            set { BackingStore?.Set(nameof(MessagingBlockMMS), value); }
        }
        /// <summary>Indicates whether or not to block the RCS send/receive functionality on the device.</summary>
        public bool? MessagingBlockRichCommunicationServices {
            get { return BackingStore?.Get<bool?>(nameof(MessagingBlockRichCommunicationServices)); }
            set { BackingStore?.Set(nameof(MessagingBlockRichCommunicationServices), value); }
        }
        /// <summary>Indicates whether or not to block text message back up and restore and Messaging Everywhere.</summary>
        public bool? MessagingBlockSync {
            get { return BackingStore?.Get<bool?>(nameof(MessagingBlockSync)); }
            set { BackingStore?.Set(nameof(MessagingBlockSync), value); }
        }
        /// <summary>Indicates whether or not to Block a Microsoft account.</summary>
        public bool? MicrosoftAccountBlocked {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftAccountBlocked)); }
            set { BackingStore?.Set(nameof(MicrosoftAccountBlocked), value); }
        }
        /// <summary>Indicates whether or not to Block Microsoft account settings sync.</summary>
        public bool? MicrosoftAccountBlockSettingsSync {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftAccountBlockSettingsSync)); }
            set { BackingStore?.Set(nameof(MicrosoftAccountBlockSettingsSync), value); }
        }
        /// <summary>Controls the Microsoft Account Sign-In Assistant (wlidsvc) NT service. Possible values are: notConfigured, disabled.</summary>
        public SignInAssistantOptions? MicrosoftAccountSignInAssistantSettings {
            get { return BackingStore?.Get<SignInAssistantOptions?>(nameof(MicrosoftAccountSignInAssistantSettings)); }
            set { BackingStore?.Set(nameof(MicrosoftAccountSignInAssistantSettings), value); }
        }
        /// <summary>If set, proxy settings will be applied to all processes and accounts in the device. Otherwise, it will be applied to the user account that’s enrolled into MDM.</summary>
        public bool? NetworkProxyApplySettingsDeviceWide {
            get { return BackingStore?.Get<bool?>(nameof(NetworkProxyApplySettingsDeviceWide)); }
            set { BackingStore?.Set(nameof(NetworkProxyApplySettingsDeviceWide), value); }
        }
        /// <summary>Address to the proxy auto-config (PAC) script you want to use.</summary>
        public string NetworkProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string>(nameof(NetworkProxyAutomaticConfigurationUrl)); }
            set { BackingStore?.Set(nameof(NetworkProxyAutomaticConfigurationUrl), value); }
        }
        /// <summary>Disable automatic detection of settings. If enabled, the system will try to find the path to a proxy auto-config (PAC) script.</summary>
        public bool? NetworkProxyDisableAutoDetect {
            get { return BackingStore?.Get<bool?>(nameof(NetworkProxyDisableAutoDetect)); }
            set { BackingStore?.Set(nameof(NetworkProxyDisableAutoDetect), value); }
        }
        /// <summary>Specifies manual proxy server settings.</summary>
        public Windows10NetworkProxyServer NetworkProxyServer {
            get { return BackingStore?.Get<Windows10NetworkProxyServer>(nameof(NetworkProxyServer)); }
            set { BackingStore?.Set(nameof(NetworkProxyServer), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using near field communication.</summary>
        public bool? NfcBlocked {
            get { return BackingStore?.Get<bool?>(nameof(NfcBlocked)); }
            set { BackingStore?.Set(nameof(NfcBlocked), value); }
        }
        /// <summary>Gets or sets a value allowing IT admins to prevent apps and features from working with files on OneDrive.</summary>
        public bool? OneDriveDisableFileSync {
            get { return BackingStore?.Get<bool?>(nameof(OneDriveDisableFileSync)); }
            set { BackingStore?.Set(nameof(OneDriveDisableFileSync), value); }
        }
        /// <summary>Specify whether PINs or passwords such as &apos;1111&apos; or &apos;1234&apos; are allowed. For Windows 10 desktops, it also controls the use of picture passwords.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockSimple)); }
            set { BackingStore?.Set(nameof(PasswordBlockSimple), value); }
        }
        /// <summary>The password expiration in days. Valid values 0 to 730</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>This security setting determines the period of time (in days) that a password must be used before the user can change it. Valid values 0 to 998</summary>
        public int? PasswordMinimumAgeInDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumAgeInDays)); }
            set { BackingStore?.Set(nameof(PasswordMinimumAgeInDays), value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumCharacterSetCount)); }
            set { BackingStore?.Set(nameof(PasswordMinimumCharacterSetCount), value); }
        }
        /// <summary>The minimum password length. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>The minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout), value); }
        }
        /// <summary>The number of previous passwords to prevent reuse of. Valid values 0 to 50</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>Indicates whether or not to require the user to have a password.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequired)); }
            set { BackingStore?.Set(nameof(PasswordRequired), value); }
        }
        /// <summary>The required password type. Possible values are: deviceDefault, alphanumeric, numeric.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Indicates whether or not to require a password upon resuming from an idle state.</summary>
        public bool? PasswordRequireWhenResumeFromIdleState {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequireWhenResumeFromIdleState)); }
            set { BackingStore?.Set(nameof(PasswordRequireWhenResumeFromIdleState), value); }
        }
        /// <summary>The number of sign in failures before factory reset. Valid values 0 to 999</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(PasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(PasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>A http or https Url to a jpg, jpeg or png image that needs to be downloaded and used as the Desktop Image or a file Url to a local image on the file system that needs to used as the Desktop Image.</summary>
        public string PersonalizationDesktopImageUrl {
            get { return BackingStore?.Get<string>(nameof(PersonalizationDesktopImageUrl)); }
            set { BackingStore?.Set(nameof(PersonalizationDesktopImageUrl), value); }
        }
        /// <summary>A http or https Url to a jpg, jpeg or png image that neeeds to be downloaded and used as the Lock Screen Image or a file Url to a local image on the file system that needs to be used as the Lock Screen Image.</summary>
        public string PersonalizationLockScreenImageUrl {
            get { return BackingStore?.Get<string>(nameof(PersonalizationLockScreenImageUrl)); }
            set { BackingStore?.Set(nameof(PersonalizationLockScreenImageUrl), value); }
        }
        /// <summary>This setting specifies the action that Windows takes when a user presses the Power button while on battery. Possible values are: notConfigured, noAction, sleep, hibernate, shutdown.</summary>
        public PowerActionType? PowerButtonActionOnBattery {
            get { return BackingStore?.Get<PowerActionType?>(nameof(PowerButtonActionOnBattery)); }
            set { BackingStore?.Set(nameof(PowerButtonActionOnBattery), value); }
        }
        /// <summary>This setting specifies the action that Windows takes when a user presses the Power button while plugged in. Possible values are: notConfigured, noAction, sleep, hibernate, shutdown.</summary>
        public PowerActionType? PowerButtonActionPluggedIn {
            get { return BackingStore?.Get<PowerActionType?>(nameof(PowerButtonActionPluggedIn)); }
            set { BackingStore?.Set(nameof(PowerButtonActionPluggedIn), value); }
        }
        /// <summary>This setting allows you to turn off hybrid sleep while on battery. If you set this setting to disable, a hiberfile is not generated when the system transitions to sleep (Stand By). If you set this setting to enable or do not configure this policy setting, users control this setting. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? PowerHybridSleepOnBattery {
            get { return BackingStore?.Get<Enablement?>(nameof(PowerHybridSleepOnBattery)); }
            set { BackingStore?.Set(nameof(PowerHybridSleepOnBattery), value); }
        }
        /// <summary>This setting allows you to turn off hybrid sleep while plugged in. If you set this setting to disable, a hiberfile is not generated when the system transitions to sleep (Stand By). If you set this setting to enable or do not configure this policy setting, users control this setting. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? PowerHybridSleepPluggedIn {
            get { return BackingStore?.Get<Enablement?>(nameof(PowerHybridSleepPluggedIn)); }
            set { BackingStore?.Set(nameof(PowerHybridSleepPluggedIn), value); }
        }
        /// <summary>This setting specifies the action that Windows takes when a user closes the lid on a mobile PC while on battery. Possible values are: notConfigured, noAction, sleep, hibernate, shutdown.</summary>
        public PowerActionType? PowerLidCloseActionOnBattery {
            get { return BackingStore?.Get<PowerActionType?>(nameof(PowerLidCloseActionOnBattery)); }
            set { BackingStore?.Set(nameof(PowerLidCloseActionOnBattery), value); }
        }
        /// <summary>This setting specifies the action that Windows takes when a user closes the lid on a mobile PC while plugged in. Possible values are: notConfigured, noAction, sleep, hibernate, shutdown.</summary>
        public PowerActionType? PowerLidCloseActionPluggedIn {
            get { return BackingStore?.Get<PowerActionType?>(nameof(PowerLidCloseActionPluggedIn)); }
            set { BackingStore?.Set(nameof(PowerLidCloseActionPluggedIn), value); }
        }
        /// <summary>This setting specifies the action that Windows takes when a user presses the Sleep button while on battery. Possible values are: notConfigured, noAction, sleep, hibernate, shutdown.</summary>
        public PowerActionType? PowerSleepButtonActionOnBattery {
            get { return BackingStore?.Get<PowerActionType?>(nameof(PowerSleepButtonActionOnBattery)); }
            set { BackingStore?.Set(nameof(PowerSleepButtonActionOnBattery), value); }
        }
        /// <summary>This setting specifies the action that Windows takes when a user presses the Sleep button while plugged in. Possible values are: notConfigured, noAction, sleep, hibernate, shutdown.</summary>
        public PowerActionType? PowerSleepButtonActionPluggedIn {
            get { return BackingStore?.Get<PowerActionType?>(nameof(PowerSleepButtonActionPluggedIn)); }
            set { BackingStore?.Set(nameof(PowerSleepButtonActionPluggedIn), value); }
        }
        /// <summary>Prevent user installation of additional printers from printers settings.</summary>
        public bool? PrinterBlockAddition {
            get { return BackingStore?.Get<bool?>(nameof(PrinterBlockAddition)); }
            set { BackingStore?.Set(nameof(PrinterBlockAddition), value); }
        }
        /// <summary>Name (network host name) of an installed printer.</summary>
        public string PrinterDefaultName {
            get { return BackingStore?.Get<string>(nameof(PrinterDefaultName)); }
            set { BackingStore?.Set(nameof(PrinterDefaultName), value); }
        }
        /// <summary>Automatically provision printers based on their names (network host names).</summary>
        public List<string> PrinterNames {
            get { return BackingStore?.Get<List<string>>(nameof(PrinterNames)); }
            set { BackingStore?.Set(nameof(PrinterNames), value); }
        }
        /// <summary>Indicates a list of applications with their access control levels over privacy data categories, and/or the default access levels per category. This collection can contain a maximum of 500 elements.</summary>
        public List<WindowsPrivacyDataAccessControlItem> PrivacyAccessControls {
            get { return BackingStore?.Get<List<WindowsPrivacyDataAccessControlItem>>(nameof(PrivacyAccessControls)); }
            set { BackingStore?.Set(nameof(PrivacyAccessControls), value); }
        }
        /// <summary>Enables or disables the use of advertising ID. Added in Windows 10, version 1607. Possible values are: notConfigured, blocked, allowed.</summary>
        public StateManagementSetting? PrivacyAdvertisingId {
            get { return BackingStore?.Get<StateManagementSetting?>(nameof(PrivacyAdvertisingId)); }
            set { BackingStore?.Set(nameof(PrivacyAdvertisingId), value); }
        }
        /// <summary>Indicates whether or not to allow the automatic acceptance of the pairing and privacy user consent dialog when launching apps.</summary>
        public bool? PrivacyAutoAcceptPairingAndConsentPrompts {
            get { return BackingStore?.Get<bool?>(nameof(PrivacyAutoAcceptPairingAndConsentPrompts)); }
            set { BackingStore?.Set(nameof(PrivacyAutoAcceptPairingAndConsentPrompts), value); }
        }
        /// <summary>Blocks the usage of cloud based speech services for Cortana, Dictation, or Store applications.</summary>
        public bool? PrivacyBlockActivityFeed {
            get { return BackingStore?.Get<bool?>(nameof(PrivacyBlockActivityFeed)); }
            set { BackingStore?.Set(nameof(PrivacyBlockActivityFeed), value); }
        }
        /// <summary>Indicates whether or not to block the usage of cloud based speech services for Cortana, Dictation, or Store applications.</summary>
        public bool? PrivacyBlockInputPersonalization {
            get { return BackingStore?.Get<bool?>(nameof(PrivacyBlockInputPersonalization)); }
            set { BackingStore?.Set(nameof(PrivacyBlockInputPersonalization), value); }
        }
        /// <summary>Blocks the shared experiences/discovery of recently used resources in task switcher etc.</summary>
        public bool? PrivacyBlockPublishUserActivities {
            get { return BackingStore?.Get<bool?>(nameof(PrivacyBlockPublishUserActivities)); }
            set { BackingStore?.Set(nameof(PrivacyBlockPublishUserActivities), value); }
        }
        /// <summary>This policy prevents the privacy experience from launching during user logon for new and upgraded users.​</summary>
        public bool? PrivacyDisableLaunchExperience {
            get { return BackingStore?.Get<bool?>(nameof(PrivacyDisableLaunchExperience)); }
            set { BackingStore?.Set(nameof(PrivacyDisableLaunchExperience), value); }
        }
        /// <summary>Indicates whether or not to Block the user from reset protection mode.</summary>
        public bool? ResetProtectionModeBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ResetProtectionModeBlocked)); }
            set { BackingStore?.Set(nameof(ResetProtectionModeBlocked), value); }
        }
        /// <summary>Specifies what filter level of safe search is required. Possible values are: userDefined, strict, moderate.</summary>
        public SafeSearchFilterType? SafeSearchFilter {
            get { return BackingStore?.Get<SafeSearchFilterType?>(nameof(SafeSearchFilter)); }
            set { BackingStore?.Set(nameof(SafeSearchFilter), value); }
        }
        /// <summary>Indicates whether or not to Block the user from taking Screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ScreenCaptureBlocked)); }
            set { BackingStore?.Set(nameof(ScreenCaptureBlocked), value); }
        }
        /// <summary>Specifies if search can use diacritics.</summary>
        public bool? SearchBlockDiacritics {
            get { return BackingStore?.Get<bool?>(nameof(SearchBlockDiacritics)); }
            set { BackingStore?.Set(nameof(SearchBlockDiacritics), value); }
        }
        /// <summary>Indicates whether or not to block the web search.</summary>
        public bool? SearchBlockWebResults {
            get { return BackingStore?.Get<bool?>(nameof(SearchBlockWebResults)); }
            set { BackingStore?.Set(nameof(SearchBlockWebResults), value); }
        }
        /// <summary>Specifies whether to use automatic language detection when indexing content and properties.</summary>
        public bool? SearchDisableAutoLanguageDetection {
            get { return BackingStore?.Get<bool?>(nameof(SearchDisableAutoLanguageDetection)); }
            set { BackingStore?.Set(nameof(SearchDisableAutoLanguageDetection), value); }
        }
        /// <summary>Indicates whether or not to disable the search indexer backoff feature.</summary>
        public bool? SearchDisableIndexerBackoff {
            get { return BackingStore?.Get<bool?>(nameof(SearchDisableIndexerBackoff)); }
            set { BackingStore?.Set(nameof(SearchDisableIndexerBackoff), value); }
        }
        /// <summary>Indicates whether or not to block indexing of WIP-protected items to prevent them from appearing in search results for Cortana or Explorer.</summary>
        public bool? SearchDisableIndexingEncryptedItems {
            get { return BackingStore?.Get<bool?>(nameof(SearchDisableIndexingEncryptedItems)); }
            set { BackingStore?.Set(nameof(SearchDisableIndexingEncryptedItems), value); }
        }
        /// <summary>Indicates whether or not to allow users to add locations on removable drives to libraries and to be indexed.</summary>
        public bool? SearchDisableIndexingRemovableDrive {
            get { return BackingStore?.Get<bool?>(nameof(SearchDisableIndexingRemovableDrive)); }
            set { BackingStore?.Set(nameof(SearchDisableIndexingRemovableDrive), value); }
        }
        /// <summary>Specifies if search can use location information.</summary>
        public bool? SearchDisableLocation {
            get { return BackingStore?.Get<bool?>(nameof(SearchDisableLocation)); }
            set { BackingStore?.Set(nameof(SearchDisableLocation), value); }
        }
        /// <summary>Specifies if search can use location information.</summary>
        public bool? SearchDisableUseLocation {
            get { return BackingStore?.Get<bool?>(nameof(SearchDisableUseLocation)); }
            set { BackingStore?.Set(nameof(SearchDisableUseLocation), value); }
        }
        /// <summary>Specifies minimum amount of hard drive space on the same drive as the index location before indexing stops.</summary>
        public bool? SearchEnableAutomaticIndexSizeManangement {
            get { return BackingStore?.Get<bool?>(nameof(SearchEnableAutomaticIndexSizeManangement)); }
            set { BackingStore?.Set(nameof(SearchEnableAutomaticIndexSizeManangement), value); }
        }
        /// <summary>Indicates whether or not to block remote queries of this computer’s index.</summary>
        public bool? SearchEnableRemoteQueries {
            get { return BackingStore?.Get<bool?>(nameof(SearchEnableRemoteQueries)); }
            set { BackingStore?.Set(nameof(SearchEnableRemoteQueries), value); }
        }
        /// <summary>Specify whether to allow automatic device encryption during OOBE when the device is Azure AD joined (desktop only).</summary>
        public bool? SecurityBlockAzureADJoinedDevicesAutoEncryption {
            get { return BackingStore?.Get<bool?>(nameof(SecurityBlockAzureADJoinedDevicesAutoEncryption)); }
            set { BackingStore?.Set(nameof(SecurityBlockAzureADJoinedDevicesAutoEncryption), value); }
        }
        /// <summary>Indicates whether or not to block access to Accounts in Settings app.</summary>
        public bool? SettingsBlockAccountsPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockAccountsPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockAccountsPage), value); }
        }
        /// <summary>Indicates whether or not to block the user from installing provisioning packages.</summary>
        public bool? SettingsBlockAddProvisioningPackage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockAddProvisioningPackage)); }
            set { BackingStore?.Set(nameof(SettingsBlockAddProvisioningPackage), value); }
        }
        /// <summary>Indicates whether or not to block access to Apps in Settings app.</summary>
        public bool? SettingsBlockAppsPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockAppsPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockAppsPage), value); }
        }
        /// <summary>Indicates whether or not to block the user from changing the language settings.</summary>
        public bool? SettingsBlockChangeLanguage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockChangeLanguage)); }
            set { BackingStore?.Set(nameof(SettingsBlockChangeLanguage), value); }
        }
        /// <summary>Indicates whether or not to block the user from changing power and sleep settings.</summary>
        public bool? SettingsBlockChangePowerSleep {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockChangePowerSleep)); }
            set { BackingStore?.Set(nameof(SettingsBlockChangePowerSleep), value); }
        }
        /// <summary>Indicates whether or not to block the user from changing the region settings.</summary>
        public bool? SettingsBlockChangeRegion {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockChangeRegion)); }
            set { BackingStore?.Set(nameof(SettingsBlockChangeRegion), value); }
        }
        /// <summary>Indicates whether or not to block the user from changing date and time settings.</summary>
        public bool? SettingsBlockChangeSystemTime {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockChangeSystemTime)); }
            set { BackingStore?.Set(nameof(SettingsBlockChangeSystemTime), value); }
        }
        /// <summary>Indicates whether or not to block access to Devices in Settings app.</summary>
        public bool? SettingsBlockDevicesPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockDevicesPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockDevicesPage), value); }
        }
        /// <summary>Indicates whether or not to block access to Ease of Access in Settings app.</summary>
        public bool? SettingsBlockEaseOfAccessPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockEaseOfAccessPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockEaseOfAccessPage), value); }
        }
        /// <summary>Indicates whether or not to block the user from editing the device name.</summary>
        public bool? SettingsBlockEditDeviceName {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockEditDeviceName)); }
            set { BackingStore?.Set(nameof(SettingsBlockEditDeviceName), value); }
        }
        /// <summary>Indicates whether or not to block access to Gaming in Settings app.</summary>
        public bool? SettingsBlockGamingPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockGamingPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockGamingPage), value); }
        }
        /// <summary>Indicates whether or not to block access to Network &amp; Internet in Settings app.</summary>
        public bool? SettingsBlockNetworkInternetPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockNetworkInternetPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockNetworkInternetPage), value); }
        }
        /// <summary>Indicates whether or not to block access to Personalization in Settings app.</summary>
        public bool? SettingsBlockPersonalizationPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockPersonalizationPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockPersonalizationPage), value); }
        }
        /// <summary>Indicates whether or not to block access to Privacy in Settings app.</summary>
        public bool? SettingsBlockPrivacyPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockPrivacyPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockPrivacyPage), value); }
        }
        /// <summary>Indicates whether or not to block the runtime configuration agent from removing provisioning packages.</summary>
        public bool? SettingsBlockRemoveProvisioningPackage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockRemoveProvisioningPackage)); }
            set { BackingStore?.Set(nameof(SettingsBlockRemoveProvisioningPackage), value); }
        }
        /// <summary>Indicates whether or not to block access to Settings app.</summary>
        public bool? SettingsBlockSettingsApp {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockSettingsApp)); }
            set { BackingStore?.Set(nameof(SettingsBlockSettingsApp), value); }
        }
        /// <summary>Indicates whether or not to block access to System in Settings app.</summary>
        public bool? SettingsBlockSystemPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockSystemPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockSystemPage), value); }
        }
        /// <summary>Indicates whether or not to block access to Time &amp; Language in Settings app.</summary>
        public bool? SettingsBlockTimeLanguagePage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockTimeLanguagePage)); }
            set { BackingStore?.Set(nameof(SettingsBlockTimeLanguagePage), value); }
        }
        /// <summary>Indicates whether or not to block access to Update &amp; Security in Settings app.</summary>
        public bool? SettingsBlockUpdateSecurityPage {
            get { return BackingStore?.Get<bool?>(nameof(SettingsBlockUpdateSecurityPage)); }
            set { BackingStore?.Set(nameof(SettingsBlockUpdateSecurityPage), value); }
        }
        /// <summary>Indicates whether or not to block multiple users of the same app to share data.</summary>
        public bool? SharedUserAppDataAllowed {
            get { return BackingStore?.Get<bool?>(nameof(SharedUserAppDataAllowed)); }
            set { BackingStore?.Set(nameof(SharedUserAppDataAllowed), value); }
        }
        /// <summary>Added in Windows 10, version 1703. Allows IT Admins to control whether users are allowed to install apps from places other than the Store. Possible values are: notConfigured, anywhere, storeOnly, recommendations, preferStore.</summary>
        public AppInstallControlType? SmartScreenAppInstallControl {
            get { return BackingStore?.Get<AppInstallControlType?>(nameof(SmartScreenAppInstallControl)); }
            set { BackingStore?.Set(nameof(SmartScreenAppInstallControl), value); }
        }
        /// <summary>Indicates whether or not users can override SmartScreen Filter warnings about potentially malicious websites.</summary>
        public bool? SmartScreenBlockPromptOverride {
            get { return BackingStore?.Get<bool?>(nameof(SmartScreenBlockPromptOverride)); }
            set { BackingStore?.Set(nameof(SmartScreenBlockPromptOverride), value); }
        }
        /// <summary>Indicates whether or not users can override the SmartScreen Filter warnings about downloading unverified files</summary>
        public bool? SmartScreenBlockPromptOverrideForFiles {
            get { return BackingStore?.Get<bool?>(nameof(SmartScreenBlockPromptOverrideForFiles)); }
            set { BackingStore?.Set(nameof(SmartScreenBlockPromptOverrideForFiles), value); }
        }
        /// <summary>This property will be deprecated in July 2019 and will be replaced by property SmartScreenAppInstallControl. Allows IT Admins to control whether users are allowed to install apps from places other than the Store.</summary>
        public bool? SmartScreenEnableAppInstallControl {
            get { return BackingStore?.Get<bool?>(nameof(SmartScreenEnableAppInstallControl)); }
            set { BackingStore?.Set(nameof(SmartScreenEnableAppInstallControl), value); }
        }
        /// <summary>Indicates whether or not to block the user from unpinning apps from taskbar.</summary>
        public bool? StartBlockUnpinningAppsFromTaskbar {
            get { return BackingStore?.Get<bool?>(nameof(StartBlockUnpinningAppsFromTaskbar)); }
            set { BackingStore?.Set(nameof(StartBlockUnpinningAppsFromTaskbar), value); }
        }
        /// <summary>Setting the value of this collapses the app list, removes the app list entirely, or disables the corresponding toggle in the Settings app. Possible values are: userDefined, collapse, remove, disableSettingsApp.</summary>
        public WindowsStartMenuAppListVisibilityType? StartMenuAppListVisibility {
            get { return BackingStore?.Get<WindowsStartMenuAppListVisibilityType?>(nameof(StartMenuAppListVisibility)); }
            set { BackingStore?.Set(nameof(StartMenuAppListVisibility), value); }
        }
        /// <summary>Enabling this policy hides the change account setting from appearing in the user tile in the start menu.</summary>
        public bool? StartMenuHideChangeAccountSettings {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideChangeAccountSettings)); }
            set { BackingStore?.Set(nameof(StartMenuHideChangeAccountSettings), value); }
        }
        /// <summary>Enabling this policy hides the most used apps from appearing on the start menu and disables the corresponding toggle in the Settings app.</summary>
        public bool? StartMenuHideFrequentlyUsedApps {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideFrequentlyUsedApps)); }
            set { BackingStore?.Set(nameof(StartMenuHideFrequentlyUsedApps), value); }
        }
        /// <summary>Enabling this policy hides hibernate from appearing in the power button in the start menu.</summary>
        public bool? StartMenuHideHibernate {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideHibernate)); }
            set { BackingStore?.Set(nameof(StartMenuHideHibernate), value); }
        }
        /// <summary>Enabling this policy hides lock from appearing in the user tile in the start menu.</summary>
        public bool? StartMenuHideLock {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideLock)); }
            set { BackingStore?.Set(nameof(StartMenuHideLock), value); }
        }
        /// <summary>Enabling this policy hides the power button from appearing in the start menu.</summary>
        public bool? StartMenuHidePowerButton {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHidePowerButton)); }
            set { BackingStore?.Set(nameof(StartMenuHidePowerButton), value); }
        }
        /// <summary>Enabling this policy hides recent jump lists from appearing on the start menu/taskbar and disables the corresponding toggle in the Settings app.</summary>
        public bool? StartMenuHideRecentJumpLists {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideRecentJumpLists)); }
            set { BackingStore?.Set(nameof(StartMenuHideRecentJumpLists), value); }
        }
        /// <summary>Enabling this policy hides recently added apps from appearing on the start menu and disables the corresponding toggle in the Settings app.</summary>
        public bool? StartMenuHideRecentlyAddedApps {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideRecentlyAddedApps)); }
            set { BackingStore?.Set(nameof(StartMenuHideRecentlyAddedApps), value); }
        }
        /// <summary>Enabling this policy hides &apos;Restart/Update and Restart&apos; from appearing in the power button in the start menu.</summary>
        public bool? StartMenuHideRestartOptions {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideRestartOptions)); }
            set { BackingStore?.Set(nameof(StartMenuHideRestartOptions), value); }
        }
        /// <summary>Enabling this policy hides shut down/update and shut down from appearing in the power button in the start menu.</summary>
        public bool? StartMenuHideShutDown {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideShutDown)); }
            set { BackingStore?.Set(nameof(StartMenuHideShutDown), value); }
        }
        /// <summary>Enabling this policy hides sign out from appearing in the user tile in the start menu.</summary>
        public bool? StartMenuHideSignOut {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideSignOut)); }
            set { BackingStore?.Set(nameof(StartMenuHideSignOut), value); }
        }
        /// <summary>Enabling this policy hides sleep from appearing in the power button in the start menu.</summary>
        public bool? StartMenuHideSleep {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideSleep)); }
            set { BackingStore?.Set(nameof(StartMenuHideSleep), value); }
        }
        /// <summary>Enabling this policy hides switch account from appearing in the user tile in the start menu.</summary>
        public bool? StartMenuHideSwitchAccount {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideSwitchAccount)); }
            set { BackingStore?.Set(nameof(StartMenuHideSwitchAccount), value); }
        }
        /// <summary>Enabling this policy hides the user tile from appearing in the start menu.</summary>
        public bool? StartMenuHideUserTile {
            get { return BackingStore?.Get<bool?>(nameof(StartMenuHideUserTile)); }
            set { BackingStore?.Set(nameof(StartMenuHideUserTile), value); }
        }
        /// <summary>This policy setting allows you to import Edge assets to be used with startMenuLayoutXml policy. Start layout can contain secondary tile from Edge app which looks for Edge local asset file. Edge local asset would not exist and cause Edge secondary tile to appear empty in this case. This policy only gets applied when startMenuLayoutXml policy is modified. The value should be a UTF-8 Base64 encoded byte array.</summary>
        public byte[] StartMenuLayoutEdgeAssetsXml {
            get { return BackingStore?.Get<byte[]>(nameof(StartMenuLayoutEdgeAssetsXml)); }
            set { BackingStore?.Set(nameof(StartMenuLayoutEdgeAssetsXml), value); }
        }
        /// <summary>Allows admins to override the default Start menu layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in a UTF8 encoded byte array format.</summary>
        public byte[] StartMenuLayoutXml {
            get { return BackingStore?.Get<byte[]>(nameof(StartMenuLayoutXml)); }
            set { BackingStore?.Set(nameof(StartMenuLayoutXml), value); }
        }
        /// <summary>Allows admins to decide how the Start menu is displayed. Possible values are: userDefined, fullScreen, nonFullScreen.</summary>
        public WindowsStartMenuModeType? StartMenuMode {
            get { return BackingStore?.Get<WindowsStartMenuModeType?>(nameof(StartMenuMode)); }
            set { BackingStore?.Set(nameof(StartMenuMode), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the Documents folder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderDocuments {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderDocuments)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderDocuments), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the Downloads folder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderDownloads {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderDownloads)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderDownloads), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the FileExplorer shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderFileExplorer {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderFileExplorer)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderFileExplorer), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the HomeGroup folder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderHomeGroup {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderHomeGroup)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderHomeGroup), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the Music folder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderMusic {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderMusic)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderMusic), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the Network folder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderNetwork {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderNetwork)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderNetwork), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the PersonalFolder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderPersonalFolder {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderPersonalFolder)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderPersonalFolder), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the Pictures folder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderPictures {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderPictures)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderPictures), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the Settings folder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderSettings {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderSettings)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderSettings), value); }
        }
        /// <summary>Enforces the visibility (Show/Hide) of the Videos folder shortcut on the Start menu. Possible values are: notConfigured, hide, show.</summary>
        public VisibilitySetting? StartMenuPinnedFolderVideos {
            get { return BackingStore?.Get<VisibilitySetting?>(nameof(StartMenuPinnedFolderVideos)); }
            set { BackingStore?.Set(nameof(StartMenuPinnedFolderVideos), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using removable storage.</summary>
        public bool? StorageBlockRemovableStorage {
            get { return BackingStore?.Get<bool?>(nameof(StorageBlockRemovableStorage)); }
            set { BackingStore?.Set(nameof(StorageBlockRemovableStorage), value); }
        }
        /// <summary>Indicating whether or not to require encryption on a mobile device.</summary>
        public bool? StorageRequireMobileDeviceEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireMobileDeviceEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireMobileDeviceEncryption), value); }
        }
        /// <summary>Indicates whether application data is restricted to the system drive.</summary>
        public bool? StorageRestrictAppDataToSystemVolume {
            get { return BackingStore?.Get<bool?>(nameof(StorageRestrictAppDataToSystemVolume)); }
            set { BackingStore?.Set(nameof(StorageRestrictAppDataToSystemVolume), value); }
        }
        /// <summary>Indicates whether the installation of applications is restricted to the system drive.</summary>
        public bool? StorageRestrictAppInstallToSystemVolume {
            get { return BackingStore?.Get<bool?>(nameof(StorageRestrictAppInstallToSystemVolume)); }
            set { BackingStore?.Set(nameof(StorageRestrictAppInstallToSystemVolume), value); }
        }
        /// <summary>Gets or sets the fully qualified domain name (FQDN) or IP address of a proxy server to forward Connected User Experiences and Telemetry requests.</summary>
        public string SystemTelemetryProxyServer {
            get { return BackingStore?.Get<string>(nameof(SystemTelemetryProxyServer)); }
            set { BackingStore?.Set(nameof(SystemTelemetryProxyServer), value); }
        }
        /// <summary>Specify whether non-administrators can use Task Manager to end tasks.</summary>
        public bool? TaskManagerBlockEndTask {
            get { return BackingStore?.Get<bool?>(nameof(TaskManagerBlockEndTask)); }
            set { BackingStore?.Set(nameof(TaskManagerBlockEndTask), value); }
        }
        /// <summary>Whether the device is required to connect to the network.</summary>
        public bool? TenantLockdownRequireNetworkDuringOutOfBoxExperience {
            get { return BackingStore?.Get<bool?>(nameof(TenantLockdownRequireNetworkDuringOutOfBoxExperience)); }
            set { BackingStore?.Set(nameof(TenantLockdownRequireNetworkDuringOutOfBoxExperience), value); }
        }
        /// <summary>Indicates whether or not to uninstall a fixed list of built-in Windows apps.</summary>
        public bool? UninstallBuiltInApps {
            get { return BackingStore?.Get<bool?>(nameof(UninstallBuiltInApps)); }
            set { BackingStore?.Set(nameof(UninstallBuiltInApps), value); }
        }
        /// <summary>Indicates whether or not to Block the user from USB connection.</summary>
        public bool? UsbBlocked {
            get { return BackingStore?.Get<bool?>(nameof(UsbBlocked)); }
            set { BackingStore?.Set(nameof(UsbBlocked), value); }
        }
        /// <summary>Indicates whether or not to Block the user from voice recording.</summary>
        public bool? VoiceRecordingBlocked {
            get { return BackingStore?.Get<bool?>(nameof(VoiceRecordingBlocked)); }
            set { BackingStore?.Set(nameof(VoiceRecordingBlocked), value); }
        }
        /// <summary>Indicates whether or not user&apos;s localhost IP address is displayed while making phone calls using the WebRTC</summary>
        public bool? WebRtcBlockLocalhostIpAddress {
            get { return BackingStore?.Get<bool?>(nameof(WebRtcBlockLocalhostIpAddress)); }
            set { BackingStore?.Set(nameof(WebRtcBlockLocalhostIpAddress), value); }
        }
        /// <summary>Indicating whether or not to block automatically connecting to Wi-Fi hotspots. Has no impact if Wi-Fi is blocked.</summary>
        public bool? WiFiBlockAutomaticConnectHotspots {
            get { return BackingStore?.Get<bool?>(nameof(WiFiBlockAutomaticConnectHotspots)); }
            set { BackingStore?.Set(nameof(WiFiBlockAutomaticConnectHotspots), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using Wi-Fi.</summary>
        public bool? WiFiBlocked {
            get { return BackingStore?.Get<bool?>(nameof(WiFiBlocked)); }
            set { BackingStore?.Set(nameof(WiFiBlocked), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using Wi-Fi manual configuration.</summary>
        public bool? WiFiBlockManualConfiguration {
            get { return BackingStore?.Get<bool?>(nameof(WiFiBlockManualConfiguration)); }
            set { BackingStore?.Set(nameof(WiFiBlockManualConfiguration), value); }
        }
        /// <summary>Specify how often devices scan for Wi-Fi networks. Supported values are 1-500, where 100 = default, and 500 = low frequency. Valid values 1 to 500</summary>
        public int? WiFiScanInterval {
            get { return BackingStore?.Get<int?>(nameof(WiFiScanInterval)); }
            set { BackingStore?.Set(nameof(WiFiScanInterval), value); }
        }
        /// <summary>Windows 10 force update schedule for Apps.</summary>
        public Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule Windows10AppsForceUpdateSchedule {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule>(nameof(Windows10AppsForceUpdateSchedule)); }
            set { BackingStore?.Set(nameof(Windows10AppsForceUpdateSchedule), value); }
        }
        /// <summary>Allows IT admins to block experiences that are typically for consumers only, such as Start suggestions, Membership notifications, Post-OOBE app install and redirect tiles.</summary>
        public bool? WindowsSpotlightBlockConsumerSpecificFeatures {
            get { return BackingStore?.Get<bool?>(nameof(WindowsSpotlightBlockConsumerSpecificFeatures)); }
            set { BackingStore?.Set(nameof(WindowsSpotlightBlockConsumerSpecificFeatures), value); }
        }
        /// <summary>Allows IT admins to turn off all Windows Spotlight features</summary>
        public bool? WindowsSpotlightBlocked {
            get { return BackingStore?.Get<bool?>(nameof(WindowsSpotlightBlocked)); }
            set { BackingStore?.Set(nameof(WindowsSpotlightBlocked), value); }
        }
        /// <summary>Block suggestions from Microsoft that show after each OS clean install, upgrade or in an on-going basis to introduce users to what is new or changed</summary>
        public bool? WindowsSpotlightBlockOnActionCenter {
            get { return BackingStore?.Get<bool?>(nameof(WindowsSpotlightBlockOnActionCenter)); }
            set { BackingStore?.Set(nameof(WindowsSpotlightBlockOnActionCenter), value); }
        }
        /// <summary>Block personalized content in Windows spotlight based on user’s device usage.</summary>
        public bool? WindowsSpotlightBlockTailoredExperiences {
            get { return BackingStore?.Get<bool?>(nameof(WindowsSpotlightBlockTailoredExperiences)); }
            set { BackingStore?.Set(nameof(WindowsSpotlightBlockTailoredExperiences), value); }
        }
        /// <summary>Block third party content delivered via Windows Spotlight</summary>
        public bool? WindowsSpotlightBlockThirdPartyNotifications {
            get { return BackingStore?.Get<bool?>(nameof(WindowsSpotlightBlockThirdPartyNotifications)); }
            set { BackingStore?.Set(nameof(WindowsSpotlightBlockThirdPartyNotifications), value); }
        }
        /// <summary>Block Windows Spotlight Windows welcome experience</summary>
        public bool? WindowsSpotlightBlockWelcomeExperience {
            get { return BackingStore?.Get<bool?>(nameof(WindowsSpotlightBlockWelcomeExperience)); }
            set { BackingStore?.Set(nameof(WindowsSpotlightBlockWelcomeExperience), value); }
        }
        /// <summary>Allows IT admins to turn off the popup of Windows Tips.</summary>
        public bool? WindowsSpotlightBlockWindowsTips {
            get { return BackingStore?.Get<bool?>(nameof(WindowsSpotlightBlockWindowsTips)); }
            set { BackingStore?.Set(nameof(WindowsSpotlightBlockWindowsTips), value); }
        }
        /// <summary>Specifies the type of Spotlight. Possible values are: notConfigured, disabled, enabled.</summary>
        public WindowsSpotlightEnablementSettings? WindowsSpotlightConfigureOnLockScreen {
            get { return BackingStore?.Get<WindowsSpotlightEnablementSettings?>(nameof(WindowsSpotlightConfigureOnLockScreen)); }
            set { BackingStore?.Set(nameof(WindowsSpotlightConfigureOnLockScreen), value); }
        }
        /// <summary>Indicates whether or not to block automatic update of apps from Windows Store.</summary>
        public bool? WindowsStoreBlockAutoUpdate {
            get { return BackingStore?.Get<bool?>(nameof(WindowsStoreBlockAutoUpdate)); }
            set { BackingStore?.Set(nameof(WindowsStoreBlockAutoUpdate), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using the Windows store.</summary>
        public bool? WindowsStoreBlocked {
            get { return BackingStore?.Get<bool?>(nameof(WindowsStoreBlocked)); }
            set { BackingStore?.Set(nameof(WindowsStoreBlocked), value); }
        }
        /// <summary>Indicates whether or not to enable Private Store Only.</summary>
        public bool? WindowsStoreEnablePrivateStoreOnly {
            get { return BackingStore?.Get<bool?>(nameof(WindowsStoreEnablePrivateStoreOnly)); }
            set { BackingStore?.Set(nameof(WindowsStoreEnablePrivateStoreOnly), value); }
        }
        /// <summary>Indicates whether or not to allow other devices from discovering this PC for projection.</summary>
        public bool? WirelessDisplayBlockProjectionToThisDevice {
            get { return BackingStore?.Get<bool?>(nameof(WirelessDisplayBlockProjectionToThisDevice)); }
            set { BackingStore?.Set(nameof(WirelessDisplayBlockProjectionToThisDevice), value); }
        }
        /// <summary>Indicates whether or not to allow user input from wireless display receiver.</summary>
        public bool? WirelessDisplayBlockUserInputFromReceiver {
            get { return BackingStore?.Get<bool?>(nameof(WirelessDisplayBlockUserInputFromReceiver)); }
            set { BackingStore?.Set(nameof(WirelessDisplayBlockUserInputFromReceiver), value); }
        }
        /// <summary>Indicates whether or not to require a PIN for new devices to initiate pairing.</summary>
        public bool? WirelessDisplayRequirePinForPairing {
            get { return BackingStore?.Get<bool?>(nameof(WirelessDisplayRequirePinForPairing)); }
            set { BackingStore?.Set(nameof(WirelessDisplayRequirePinForPairing), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10GeneralConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10GeneralConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountsBlockAddingNonMicrosoftAccountEmail", n => { AccountsBlockAddingNonMicrosoftAccountEmail = n.GetBoolValue(); } },
                {"activateAppsWithVoice", n => { ActivateAppsWithVoice = n.GetEnumValue<Enablement>(); } },
                {"antiTheftModeBlocked", n => { AntiTheftModeBlocked = n.GetBoolValue(); } },
                {"appManagementMSIAllowUserControlOverInstall", n => { AppManagementMSIAllowUserControlOverInstall = n.GetBoolValue(); } },
                {"appManagementMSIAlwaysInstallWithElevatedPrivileges", n => { AppManagementMSIAlwaysInstallWithElevatedPrivileges = n.GetBoolValue(); } },
                {"appManagementPackageFamilyNamesToLaunchAfterLogOn", n => { AppManagementPackageFamilyNamesToLaunchAfterLogOn = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"appsAllowTrustedAppsSideloading", n => { AppsAllowTrustedAppsSideloading = n.GetEnumValue<StateManagementSetting>(); } },
                {"appsBlockWindowsStoreOriginatedApps", n => { AppsBlockWindowsStoreOriginatedApps = n.GetBoolValue(); } },
                {"authenticationAllowSecondaryDevice", n => { AuthenticationAllowSecondaryDevice = n.GetBoolValue(); } },
                {"authenticationPreferredAzureADTenantDomainName", n => { AuthenticationPreferredAzureADTenantDomainName = n.GetStringValue(); } },
                {"authenticationWebSignIn", n => { AuthenticationWebSignIn = n.GetEnumValue<Enablement>(); } },
                {"bluetoothAllowedServices", n => { BluetoothAllowedServices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"bluetoothBlockAdvertising", n => { BluetoothBlockAdvertising = n.GetBoolValue(); } },
                {"bluetoothBlockDiscoverableMode", n => { BluetoothBlockDiscoverableMode = n.GetBoolValue(); } },
                {"bluetoothBlocked", n => { BluetoothBlocked = n.GetBoolValue(); } },
                {"bluetoothBlockPrePairing", n => { BluetoothBlockPrePairing = n.GetBoolValue(); } },
                {"bluetoothBlockPromptedProximalConnections", n => { BluetoothBlockPromptedProximalConnections = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockDataWhenRoaming", n => { CellularBlockDataWhenRoaming = n.GetBoolValue(); } },
                {"cellularBlockVpn", n => { CellularBlockVpn = n.GetBoolValue(); } },
                {"cellularBlockVpnWhenRoaming", n => { CellularBlockVpnWhenRoaming = n.GetBoolValue(); } },
                {"cellularData", n => { CellularData = n.GetEnumValue<ConfigurationUsage>(); } },
                {"certificatesBlockManualRootCertificateInstallation", n => { CertificatesBlockManualRootCertificateInstallation = n.GetBoolValue(); } },
                {"configureTimeZone", n => { ConfigureTimeZone = n.GetStringValue(); } },
                {"connectedDevicesServiceBlocked", n => { ConnectedDevicesServiceBlocked = n.GetBoolValue(); } },
                {"copyPasteBlocked", n => { CopyPasteBlocked = n.GetBoolValue(); } },
                {"cortanaBlocked", n => { CortanaBlocked = n.GetBoolValue(); } },
                {"cryptographyAllowFipsAlgorithmPolicy", n => { CryptographyAllowFipsAlgorithmPolicy = n.GetBoolValue(); } },
                {"dataProtectionBlockDirectMemoryAccess", n => { DataProtectionBlockDirectMemoryAccess = n.GetBoolValue(); } },
                {"defenderBlockEndUserAccess", n => { DefenderBlockEndUserAccess = n.GetBoolValue(); } },
                {"defenderBlockOnAccessProtection", n => { DefenderBlockOnAccessProtection = n.GetBoolValue(); } },
                {"defenderCloudBlockLevel", n => { DefenderCloudBlockLevel = n.GetEnumValue<DefenderCloudBlockLevelType>(); } },
                {"defenderCloudExtendedTimeout", n => { DefenderCloudExtendedTimeout = n.GetIntValue(); } },
                {"defenderCloudExtendedTimeoutInSeconds", n => { DefenderCloudExtendedTimeoutInSeconds = n.GetIntValue(); } },
                {"defenderDaysBeforeDeletingQuarantinedMalware", n => { DefenderDaysBeforeDeletingQuarantinedMalware = n.GetIntValue(); } },
                {"defenderDetectedMalwareActions", n => { DefenderDetectedMalwareActions = n.GetObjectValue<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>(Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions.CreateFromDiscriminatorValue); } },
                {"defenderDisableCatchupFullScan", n => { DefenderDisableCatchupFullScan = n.GetBoolValue(); } },
                {"defenderDisableCatchupQuickScan", n => { DefenderDisableCatchupQuickScan = n.GetBoolValue(); } },
                {"defenderFileExtensionsToExclude", n => { DefenderFileExtensionsToExclude = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderFilesAndFoldersToExclude", n => { DefenderFilesAndFoldersToExclude = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderMonitorFileActivity", n => { DefenderMonitorFileActivity = n.GetEnumValue<DefenderMonitorFileActivity>(); } },
                {"defenderPotentiallyUnwantedAppAction", n => { DefenderPotentiallyUnwantedAppAction = n.GetEnumValue<DefenderPotentiallyUnwantedAppAction>(); } },
                {"defenderPotentiallyUnwantedAppActionSetting", n => { DefenderPotentiallyUnwantedAppActionSetting = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderProcessesToExclude", n => { DefenderProcessesToExclude = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderPromptForSampleSubmission", n => { DefenderPromptForSampleSubmission = n.GetEnumValue<DefenderPromptForSampleSubmission>(); } },
                {"defenderRequireBehaviorMonitoring", n => { DefenderRequireBehaviorMonitoring = n.GetBoolValue(); } },
                {"defenderRequireCloudProtection", n => { DefenderRequireCloudProtection = n.GetBoolValue(); } },
                {"defenderRequireNetworkInspectionSystem", n => { DefenderRequireNetworkInspectionSystem = n.GetBoolValue(); } },
                {"defenderRequireRealTimeMonitoring", n => { DefenderRequireRealTimeMonitoring = n.GetBoolValue(); } },
                {"defenderScanArchiveFiles", n => { DefenderScanArchiveFiles = n.GetBoolValue(); } },
                {"defenderScanDownloads", n => { DefenderScanDownloads = n.GetBoolValue(); } },
                {"defenderScanIncomingMail", n => { DefenderScanIncomingMail = n.GetBoolValue(); } },
                {"defenderScanMappedNetworkDrivesDuringFullScan", n => { DefenderScanMappedNetworkDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderScanMaxCpu", n => { DefenderScanMaxCpu = n.GetIntValue(); } },
                {"defenderScanNetworkFiles", n => { DefenderScanNetworkFiles = n.GetBoolValue(); } },
                {"defenderScanRemovableDrivesDuringFullScan", n => { DefenderScanRemovableDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderScanScriptsLoadedInInternetExplorer", n => { DefenderScanScriptsLoadedInInternetExplorer = n.GetBoolValue(); } },
                {"defenderScanType", n => { DefenderScanType = n.GetEnumValue<DefenderScanType>(); } },
                {"defenderScheduledQuickScanTime", n => { DefenderScheduledQuickScanTime = n.GetTimeValue(); } },
                {"defenderScheduledScanTime", n => { DefenderScheduledScanTime = n.GetTimeValue(); } },
                {"defenderScheduleScanEnableLowCpuPriority", n => { DefenderScheduleScanEnableLowCpuPriority = n.GetBoolValue(); } },
                {"defenderSignatureUpdateIntervalInHours", n => { DefenderSignatureUpdateIntervalInHours = n.GetIntValue(); } },
                {"defenderSubmitSamplesConsentType", n => { DefenderSubmitSamplesConsentType = n.GetEnumValue<DefenderSubmitSamplesConsentType>(); } },
                {"defenderSystemScanSchedule", n => { DefenderSystemScanSchedule = n.GetEnumValue<WeeklySchedule>(); } },
                {"developerUnlockSetting", n => { DeveloperUnlockSetting = n.GetEnumValue<StateManagementSetting>(); } },
                {"deviceManagementBlockFactoryResetOnMobile", n => { DeviceManagementBlockFactoryResetOnMobile = n.GetBoolValue(); } },
                {"deviceManagementBlockManualUnenroll", n => { DeviceManagementBlockManualUnenroll = n.GetBoolValue(); } },
                {"diagnosticsDataSubmissionMode", n => { DiagnosticsDataSubmissionMode = n.GetEnumValue<DiagnosticDataSubmissionMode>(); } },
                {"displayAppListWithGdiDPIScalingTurnedOff", n => { DisplayAppListWithGdiDPIScalingTurnedOff = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"displayAppListWithGdiDPIScalingTurnedOn", n => { DisplayAppListWithGdiDPIScalingTurnedOn = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"edgeAllowStartPagesModification", n => { EdgeAllowStartPagesModification = n.GetBoolValue(); } },
                {"edgeBlockAccessToAboutFlags", n => { EdgeBlockAccessToAboutFlags = n.GetBoolValue(); } },
                {"edgeBlockAddressBarDropdown", n => { EdgeBlockAddressBarDropdown = n.GetBoolValue(); } },
                {"edgeBlockAutofill", n => { EdgeBlockAutofill = n.GetBoolValue(); } },
                {"edgeBlockCompatibilityList", n => { EdgeBlockCompatibilityList = n.GetBoolValue(); } },
                {"edgeBlockDeveloperTools", n => { EdgeBlockDeveloperTools = n.GetBoolValue(); } },
                {"edgeBlocked", n => { EdgeBlocked = n.GetBoolValue(); } },
                {"edgeBlockEditFavorites", n => { EdgeBlockEditFavorites = n.GetBoolValue(); } },
                {"edgeBlockExtensions", n => { EdgeBlockExtensions = n.GetBoolValue(); } },
                {"edgeBlockFullScreenMode", n => { EdgeBlockFullScreenMode = n.GetBoolValue(); } },
                {"edgeBlockInPrivateBrowsing", n => { EdgeBlockInPrivateBrowsing = n.GetBoolValue(); } },
                {"edgeBlockJavaScript", n => { EdgeBlockJavaScript = n.GetBoolValue(); } },
                {"edgeBlockLiveTileDataCollection", n => { EdgeBlockLiveTileDataCollection = n.GetBoolValue(); } },
                {"edgeBlockPasswordManager", n => { EdgeBlockPasswordManager = n.GetBoolValue(); } },
                {"edgeBlockPopups", n => { EdgeBlockPopups = n.GetBoolValue(); } },
                {"edgeBlockPrelaunch", n => { EdgeBlockPrelaunch = n.GetBoolValue(); } },
                {"edgeBlockPrinting", n => { EdgeBlockPrinting = n.GetBoolValue(); } },
                {"edgeBlockSavingHistory", n => { EdgeBlockSavingHistory = n.GetBoolValue(); } },
                {"edgeBlockSearchEngineCustomization", n => { EdgeBlockSearchEngineCustomization = n.GetBoolValue(); } },
                {"edgeBlockSearchSuggestions", n => { EdgeBlockSearchSuggestions = n.GetBoolValue(); } },
                {"edgeBlockSendingDoNotTrackHeader", n => { EdgeBlockSendingDoNotTrackHeader = n.GetBoolValue(); } },
                {"edgeBlockSendingIntranetTrafficToInternetExplorer", n => { EdgeBlockSendingIntranetTrafficToInternetExplorer = n.GetBoolValue(); } },
                {"edgeBlockSideloadingExtensions", n => { EdgeBlockSideloadingExtensions = n.GetBoolValue(); } },
                {"edgeBlockTabPreloading", n => { EdgeBlockTabPreloading = n.GetBoolValue(); } },
                {"edgeBlockWebContentOnNewTabPage", n => { EdgeBlockWebContentOnNewTabPage = n.GetBoolValue(); } },
                {"edgeClearBrowsingDataOnExit", n => { EdgeClearBrowsingDataOnExit = n.GetBoolValue(); } },
                {"edgeCookiePolicy", n => { EdgeCookiePolicy = n.GetEnumValue<EdgeCookiePolicy>(); } },
                {"edgeDisableFirstRunPage", n => { EdgeDisableFirstRunPage = n.GetBoolValue(); } },
                {"edgeEnterpriseModeSiteListLocation", n => { EdgeEnterpriseModeSiteListLocation = n.GetStringValue(); } },
                {"edgeFavoritesBarVisibility", n => { EdgeFavoritesBarVisibility = n.GetEnumValue<VisibilitySetting>(); } },
                {"edgeFavoritesListLocation", n => { EdgeFavoritesListLocation = n.GetStringValue(); } },
                {"edgeFirstRunUrl", n => { EdgeFirstRunUrl = n.GetStringValue(); } },
                {"edgeHomeButtonConfiguration", n => { EdgeHomeButtonConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration>(Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration.CreateFromDiscriminatorValue); } },
                {"edgeHomeButtonConfigurationEnabled", n => { EdgeHomeButtonConfigurationEnabled = n.GetBoolValue(); } },
                {"edgeHomepageUrls", n => { EdgeHomepageUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"edgeKioskModeRestriction", n => { EdgeKioskModeRestriction = n.GetEnumValue<EdgeKioskModeRestrictionType>(); } },
                {"edgeKioskResetAfterIdleTimeInMinutes", n => { EdgeKioskResetAfterIdleTimeInMinutes = n.GetIntValue(); } },
                {"edgeNewTabPageURL", n => { EdgeNewTabPageURL = n.GetStringValue(); } },
                {"edgeOpensWith", n => { EdgeOpensWith = n.GetEnumValue<EdgeOpenOptions>(); } },
                {"edgePreventCertificateErrorOverride", n => { EdgePreventCertificateErrorOverride = n.GetBoolValue(); } },
                {"edgeRequiredExtensionPackageFamilyNames", n => { EdgeRequiredExtensionPackageFamilyNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"edgeRequireSmartScreen", n => { EdgeRequireSmartScreen = n.GetBoolValue(); } },
                {"edgeSearchEngine", n => { EdgeSearchEngine = n.GetObjectValue<EdgeSearchEngineBase>(EdgeSearchEngineBase.CreateFromDiscriminatorValue); } },
                {"edgeSendIntranetTrafficToInternetExplorer", n => { EdgeSendIntranetTrafficToInternetExplorer = n.GetBoolValue(); } },
                {"edgeShowMessageWhenOpeningInternetExplorerSites", n => { EdgeShowMessageWhenOpeningInternetExplorerSites = n.GetEnumValue<InternetExplorerMessageSetting>(); } },
                {"edgeSyncFavoritesWithInternetExplorer", n => { EdgeSyncFavoritesWithInternetExplorer = n.GetBoolValue(); } },
                {"edgeTelemetryForMicrosoft365Analytics", n => { EdgeTelemetryForMicrosoft365Analytics = n.GetEnumValue<EdgeTelemetryMode>(); } },
                {"enableAutomaticRedeployment", n => { EnableAutomaticRedeployment = n.GetBoolValue(); } },
                {"energySaverOnBatteryThresholdPercentage", n => { EnergySaverOnBatteryThresholdPercentage = n.GetIntValue(); } },
                {"energySaverPluggedInThresholdPercentage", n => { EnergySaverPluggedInThresholdPercentage = n.GetIntValue(); } },
                {"enterpriseCloudPrintDiscoveryEndPoint", n => { EnterpriseCloudPrintDiscoveryEndPoint = n.GetStringValue(); } },
                {"enterpriseCloudPrintDiscoveryMaxLimit", n => { EnterpriseCloudPrintDiscoveryMaxLimit = n.GetIntValue(); } },
                {"enterpriseCloudPrintMopriaDiscoveryResourceIdentifier", n => { EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier = n.GetStringValue(); } },
                {"enterpriseCloudPrintOAuthAuthority", n => { EnterpriseCloudPrintOAuthAuthority = n.GetStringValue(); } },
                {"enterpriseCloudPrintOAuthClientIdentifier", n => { EnterpriseCloudPrintOAuthClientIdentifier = n.GetStringValue(); } },
                {"enterpriseCloudPrintResourceIdentifier", n => { EnterpriseCloudPrintResourceIdentifier = n.GetStringValue(); } },
                {"experienceBlockDeviceDiscovery", n => { ExperienceBlockDeviceDiscovery = n.GetBoolValue(); } },
                {"experienceBlockErrorDialogWhenNoSIM", n => { ExperienceBlockErrorDialogWhenNoSIM = n.GetBoolValue(); } },
                {"experienceBlockTaskSwitcher", n => { ExperienceBlockTaskSwitcher = n.GetBoolValue(); } },
                {"experienceDoNotSyncBrowserSettings", n => { ExperienceDoNotSyncBrowserSettings = n.GetEnumValue<BrowserSyncSetting>(); } },
                {"findMyFiles", n => { FindMyFiles = n.GetEnumValue<Enablement>(); } },
                {"gameDvrBlocked", n => { GameDvrBlocked = n.GetBoolValue(); } },
                {"inkWorkspaceAccess", n => { InkWorkspaceAccess = n.GetEnumValue<InkAccessSetting>(); } },
                {"inkWorkspaceAccessState", n => { InkWorkspaceAccessState = n.GetEnumValue<StateManagementSetting>(); } },
                {"inkWorkspaceBlockSuggestedApps", n => { InkWorkspaceBlockSuggestedApps = n.GetBoolValue(); } },
                {"internetSharingBlocked", n => { InternetSharingBlocked = n.GetBoolValue(); } },
                {"locationServicesBlocked", n => { LocationServicesBlocked = n.GetBoolValue(); } },
                {"lockScreenActivateAppsWithVoice", n => { LockScreenActivateAppsWithVoice = n.GetEnumValue<Enablement>(); } },
                {"lockScreenAllowTimeoutConfiguration", n => { LockScreenAllowTimeoutConfiguration = n.GetBoolValue(); } },
                {"lockScreenBlockActionCenterNotifications", n => { LockScreenBlockActionCenterNotifications = n.GetBoolValue(); } },
                {"lockScreenBlockCortana", n => { LockScreenBlockCortana = n.GetBoolValue(); } },
                {"lockScreenBlockToastNotifications", n => { LockScreenBlockToastNotifications = n.GetBoolValue(); } },
                {"lockScreenTimeoutInSeconds", n => { LockScreenTimeoutInSeconds = n.GetIntValue(); } },
                {"logonBlockFastUserSwitching", n => { LogonBlockFastUserSwitching = n.GetBoolValue(); } },
                {"messagingBlockMMS", n => { MessagingBlockMMS = n.GetBoolValue(); } },
                {"messagingBlockRichCommunicationServices", n => { MessagingBlockRichCommunicationServices = n.GetBoolValue(); } },
                {"messagingBlockSync", n => { MessagingBlockSync = n.GetBoolValue(); } },
                {"microsoftAccountBlocked", n => { MicrosoftAccountBlocked = n.GetBoolValue(); } },
                {"microsoftAccountBlockSettingsSync", n => { MicrosoftAccountBlockSettingsSync = n.GetBoolValue(); } },
                {"microsoftAccountSignInAssistantSettings", n => { MicrosoftAccountSignInAssistantSettings = n.GetEnumValue<SignInAssistantOptions>(); } },
                {"networkProxyApplySettingsDeviceWide", n => { NetworkProxyApplySettingsDeviceWide = n.GetBoolValue(); } },
                {"networkProxyAutomaticConfigurationUrl", n => { NetworkProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                {"networkProxyDisableAutoDetect", n => { NetworkProxyDisableAutoDetect = n.GetBoolValue(); } },
                {"networkProxyServer", n => { NetworkProxyServer = n.GetObjectValue<Windows10NetworkProxyServer>(Windows10NetworkProxyServer.CreateFromDiscriminatorValue); } },
                {"nfcBlocked", n => { NfcBlocked = n.GetBoolValue(); } },
                {"oneDriveDisableFileSync", n => { OneDriveDisableFileSync = n.GetBoolValue(); } },
                {"passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumAgeInDays", n => { PasswordMinimumAgeInDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"passwordRequireWhenResumeFromIdleState", n => { PasswordRequireWhenResumeFromIdleState = n.GetBoolValue(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"personalizationDesktopImageUrl", n => { PersonalizationDesktopImageUrl = n.GetStringValue(); } },
                {"personalizationLockScreenImageUrl", n => { PersonalizationLockScreenImageUrl = n.GetStringValue(); } },
                {"powerButtonActionOnBattery", n => { PowerButtonActionOnBattery = n.GetEnumValue<PowerActionType>(); } },
                {"powerButtonActionPluggedIn", n => { PowerButtonActionPluggedIn = n.GetEnumValue<PowerActionType>(); } },
                {"powerHybridSleepOnBattery", n => { PowerHybridSleepOnBattery = n.GetEnumValue<Enablement>(); } },
                {"powerHybridSleepPluggedIn", n => { PowerHybridSleepPluggedIn = n.GetEnumValue<Enablement>(); } },
                {"powerLidCloseActionOnBattery", n => { PowerLidCloseActionOnBattery = n.GetEnumValue<PowerActionType>(); } },
                {"powerLidCloseActionPluggedIn", n => { PowerLidCloseActionPluggedIn = n.GetEnumValue<PowerActionType>(); } },
                {"powerSleepButtonActionOnBattery", n => { PowerSleepButtonActionOnBattery = n.GetEnumValue<PowerActionType>(); } },
                {"powerSleepButtonActionPluggedIn", n => { PowerSleepButtonActionPluggedIn = n.GetEnumValue<PowerActionType>(); } },
                {"printerBlockAddition", n => { PrinterBlockAddition = n.GetBoolValue(); } },
                {"printerDefaultName", n => { PrinterDefaultName = n.GetStringValue(); } },
                {"printerNames", n => { PrinterNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"privacyAccessControls", n => { PrivacyAccessControls = n.GetCollectionOfObjectValues<WindowsPrivacyDataAccessControlItem>(WindowsPrivacyDataAccessControlItem.CreateFromDiscriminatorValue).ToList(); } },
                {"privacyAdvertisingId", n => { PrivacyAdvertisingId = n.GetEnumValue<StateManagementSetting>(); } },
                {"privacyAutoAcceptPairingAndConsentPrompts", n => { PrivacyAutoAcceptPairingAndConsentPrompts = n.GetBoolValue(); } },
                {"privacyBlockActivityFeed", n => { PrivacyBlockActivityFeed = n.GetBoolValue(); } },
                {"privacyBlockInputPersonalization", n => { PrivacyBlockInputPersonalization = n.GetBoolValue(); } },
                {"privacyBlockPublishUserActivities", n => { PrivacyBlockPublishUserActivities = n.GetBoolValue(); } },
                {"privacyDisableLaunchExperience", n => { PrivacyDisableLaunchExperience = n.GetBoolValue(); } },
                {"resetProtectionModeBlocked", n => { ResetProtectionModeBlocked = n.GetBoolValue(); } },
                {"safeSearchFilter", n => { SafeSearchFilter = n.GetEnumValue<SafeSearchFilterType>(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"searchBlockDiacritics", n => { SearchBlockDiacritics = n.GetBoolValue(); } },
                {"searchBlockWebResults", n => { SearchBlockWebResults = n.GetBoolValue(); } },
                {"searchDisableAutoLanguageDetection", n => { SearchDisableAutoLanguageDetection = n.GetBoolValue(); } },
                {"searchDisableIndexerBackoff", n => { SearchDisableIndexerBackoff = n.GetBoolValue(); } },
                {"searchDisableIndexingEncryptedItems", n => { SearchDisableIndexingEncryptedItems = n.GetBoolValue(); } },
                {"searchDisableIndexingRemovableDrive", n => { SearchDisableIndexingRemovableDrive = n.GetBoolValue(); } },
                {"searchDisableLocation", n => { SearchDisableLocation = n.GetBoolValue(); } },
                {"searchDisableUseLocation", n => { SearchDisableUseLocation = n.GetBoolValue(); } },
                {"searchEnableAutomaticIndexSizeManangement", n => { SearchEnableAutomaticIndexSizeManangement = n.GetBoolValue(); } },
                {"searchEnableRemoteQueries", n => { SearchEnableRemoteQueries = n.GetBoolValue(); } },
                {"securityBlockAzureADJoinedDevicesAutoEncryption", n => { SecurityBlockAzureADJoinedDevicesAutoEncryption = n.GetBoolValue(); } },
                {"settingsBlockAccountsPage", n => { SettingsBlockAccountsPage = n.GetBoolValue(); } },
                {"settingsBlockAddProvisioningPackage", n => { SettingsBlockAddProvisioningPackage = n.GetBoolValue(); } },
                {"settingsBlockAppsPage", n => { SettingsBlockAppsPage = n.GetBoolValue(); } },
                {"settingsBlockChangeLanguage", n => { SettingsBlockChangeLanguage = n.GetBoolValue(); } },
                {"settingsBlockChangePowerSleep", n => { SettingsBlockChangePowerSleep = n.GetBoolValue(); } },
                {"settingsBlockChangeRegion", n => { SettingsBlockChangeRegion = n.GetBoolValue(); } },
                {"settingsBlockChangeSystemTime", n => { SettingsBlockChangeSystemTime = n.GetBoolValue(); } },
                {"settingsBlockDevicesPage", n => { SettingsBlockDevicesPage = n.GetBoolValue(); } },
                {"settingsBlockEaseOfAccessPage", n => { SettingsBlockEaseOfAccessPage = n.GetBoolValue(); } },
                {"settingsBlockEditDeviceName", n => { SettingsBlockEditDeviceName = n.GetBoolValue(); } },
                {"settingsBlockGamingPage", n => { SettingsBlockGamingPage = n.GetBoolValue(); } },
                {"settingsBlockNetworkInternetPage", n => { SettingsBlockNetworkInternetPage = n.GetBoolValue(); } },
                {"settingsBlockPersonalizationPage", n => { SettingsBlockPersonalizationPage = n.GetBoolValue(); } },
                {"settingsBlockPrivacyPage", n => { SettingsBlockPrivacyPage = n.GetBoolValue(); } },
                {"settingsBlockRemoveProvisioningPackage", n => { SettingsBlockRemoveProvisioningPackage = n.GetBoolValue(); } },
                {"settingsBlockSettingsApp", n => { SettingsBlockSettingsApp = n.GetBoolValue(); } },
                {"settingsBlockSystemPage", n => { SettingsBlockSystemPage = n.GetBoolValue(); } },
                {"settingsBlockTimeLanguagePage", n => { SettingsBlockTimeLanguagePage = n.GetBoolValue(); } },
                {"settingsBlockUpdateSecurityPage", n => { SettingsBlockUpdateSecurityPage = n.GetBoolValue(); } },
                {"sharedUserAppDataAllowed", n => { SharedUserAppDataAllowed = n.GetBoolValue(); } },
                {"smartScreenAppInstallControl", n => { SmartScreenAppInstallControl = n.GetEnumValue<AppInstallControlType>(); } },
                {"smartScreenBlockPromptOverride", n => { SmartScreenBlockPromptOverride = n.GetBoolValue(); } },
                {"smartScreenBlockPromptOverrideForFiles", n => { SmartScreenBlockPromptOverrideForFiles = n.GetBoolValue(); } },
                {"smartScreenEnableAppInstallControl", n => { SmartScreenEnableAppInstallControl = n.GetBoolValue(); } },
                {"startBlockUnpinningAppsFromTaskbar", n => { StartBlockUnpinningAppsFromTaskbar = n.GetBoolValue(); } },
                {"startMenuAppListVisibility", n => { StartMenuAppListVisibility = n.GetEnumValue<WindowsStartMenuAppListVisibilityType>(); } },
                {"startMenuHideChangeAccountSettings", n => { StartMenuHideChangeAccountSettings = n.GetBoolValue(); } },
                {"startMenuHideFrequentlyUsedApps", n => { StartMenuHideFrequentlyUsedApps = n.GetBoolValue(); } },
                {"startMenuHideHibernate", n => { StartMenuHideHibernate = n.GetBoolValue(); } },
                {"startMenuHideLock", n => { StartMenuHideLock = n.GetBoolValue(); } },
                {"startMenuHidePowerButton", n => { StartMenuHidePowerButton = n.GetBoolValue(); } },
                {"startMenuHideRecentJumpLists", n => { StartMenuHideRecentJumpLists = n.GetBoolValue(); } },
                {"startMenuHideRecentlyAddedApps", n => { StartMenuHideRecentlyAddedApps = n.GetBoolValue(); } },
                {"startMenuHideRestartOptions", n => { StartMenuHideRestartOptions = n.GetBoolValue(); } },
                {"startMenuHideShutDown", n => { StartMenuHideShutDown = n.GetBoolValue(); } },
                {"startMenuHideSignOut", n => { StartMenuHideSignOut = n.GetBoolValue(); } },
                {"startMenuHideSleep", n => { StartMenuHideSleep = n.GetBoolValue(); } },
                {"startMenuHideSwitchAccount", n => { StartMenuHideSwitchAccount = n.GetBoolValue(); } },
                {"startMenuHideUserTile", n => { StartMenuHideUserTile = n.GetBoolValue(); } },
                {"startMenuLayoutEdgeAssetsXml", n => { StartMenuLayoutEdgeAssetsXml = n.GetByteArrayValue(); } },
                {"startMenuLayoutXml", n => { StartMenuLayoutXml = n.GetByteArrayValue(); } },
                {"startMenuMode", n => { StartMenuMode = n.GetEnumValue<WindowsStartMenuModeType>(); } },
                {"startMenuPinnedFolderDocuments", n => { StartMenuPinnedFolderDocuments = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderDownloads", n => { StartMenuPinnedFolderDownloads = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderFileExplorer", n => { StartMenuPinnedFolderFileExplorer = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderHomeGroup", n => { StartMenuPinnedFolderHomeGroup = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderMusic", n => { StartMenuPinnedFolderMusic = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderNetwork", n => { StartMenuPinnedFolderNetwork = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderPersonalFolder", n => { StartMenuPinnedFolderPersonalFolder = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderPictures", n => { StartMenuPinnedFolderPictures = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderSettings", n => { StartMenuPinnedFolderSettings = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderVideos", n => { StartMenuPinnedFolderVideos = n.GetEnumValue<VisibilitySetting>(); } },
                {"storageBlockRemovableStorage", n => { StorageBlockRemovableStorage = n.GetBoolValue(); } },
                {"storageRequireMobileDeviceEncryption", n => { StorageRequireMobileDeviceEncryption = n.GetBoolValue(); } },
                {"storageRestrictAppDataToSystemVolume", n => { StorageRestrictAppDataToSystemVolume = n.GetBoolValue(); } },
                {"storageRestrictAppInstallToSystemVolume", n => { StorageRestrictAppInstallToSystemVolume = n.GetBoolValue(); } },
                {"systemTelemetryProxyServer", n => { SystemTelemetryProxyServer = n.GetStringValue(); } },
                {"taskManagerBlockEndTask", n => { TaskManagerBlockEndTask = n.GetBoolValue(); } },
                {"tenantLockdownRequireNetworkDuringOutOfBoxExperience", n => { TenantLockdownRequireNetworkDuringOutOfBoxExperience = n.GetBoolValue(); } },
                {"uninstallBuiltInApps", n => { UninstallBuiltInApps = n.GetBoolValue(); } },
                {"usbBlocked", n => { UsbBlocked = n.GetBoolValue(); } },
                {"voiceRecordingBlocked", n => { VoiceRecordingBlocked = n.GetBoolValue(); } },
                {"webRtcBlockLocalhostIpAddress", n => { WebRtcBlockLocalhostIpAddress = n.GetBoolValue(); } },
                {"wiFiBlockAutomaticConnectHotspots", n => { WiFiBlockAutomaticConnectHotspots = n.GetBoolValue(); } },
                {"wiFiBlocked", n => { WiFiBlocked = n.GetBoolValue(); } },
                {"wiFiBlockManualConfiguration", n => { WiFiBlockManualConfiguration = n.GetBoolValue(); } },
                {"wiFiScanInterval", n => { WiFiScanInterval = n.GetIntValue(); } },
                {"windows10AppsForceUpdateSchedule", n => { Windows10AppsForceUpdateSchedule = n.GetObjectValue<Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule>(Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule.CreateFromDiscriminatorValue); } },
                {"windowsSpotlightBlockConsumerSpecificFeatures", n => { WindowsSpotlightBlockConsumerSpecificFeatures = n.GetBoolValue(); } },
                {"windowsSpotlightBlocked", n => { WindowsSpotlightBlocked = n.GetBoolValue(); } },
                {"windowsSpotlightBlockOnActionCenter", n => { WindowsSpotlightBlockOnActionCenter = n.GetBoolValue(); } },
                {"windowsSpotlightBlockTailoredExperiences", n => { WindowsSpotlightBlockTailoredExperiences = n.GetBoolValue(); } },
                {"windowsSpotlightBlockThirdPartyNotifications", n => { WindowsSpotlightBlockThirdPartyNotifications = n.GetBoolValue(); } },
                {"windowsSpotlightBlockWelcomeExperience", n => { WindowsSpotlightBlockWelcomeExperience = n.GetBoolValue(); } },
                {"windowsSpotlightBlockWindowsTips", n => { WindowsSpotlightBlockWindowsTips = n.GetBoolValue(); } },
                {"windowsSpotlightConfigureOnLockScreen", n => { WindowsSpotlightConfigureOnLockScreen = n.GetEnumValue<WindowsSpotlightEnablementSettings>(); } },
                {"windowsStoreBlockAutoUpdate", n => { WindowsStoreBlockAutoUpdate = n.GetBoolValue(); } },
                {"windowsStoreBlocked", n => { WindowsStoreBlocked = n.GetBoolValue(); } },
                {"windowsStoreEnablePrivateStoreOnly", n => { WindowsStoreEnablePrivateStoreOnly = n.GetBoolValue(); } },
                {"wirelessDisplayBlockProjectionToThisDevice", n => { WirelessDisplayBlockProjectionToThisDevice = n.GetBoolValue(); } },
                {"wirelessDisplayBlockUserInputFromReceiver", n => { WirelessDisplayBlockUserInputFromReceiver = n.GetBoolValue(); } },
                {"wirelessDisplayRequirePinForPairing", n => { WirelessDisplayRequirePinForPairing = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountsBlockAddingNonMicrosoftAccountEmail", AccountsBlockAddingNonMicrosoftAccountEmail);
            writer.WriteEnumValue<Enablement>("activateAppsWithVoice", ActivateAppsWithVoice);
            writer.WriteBoolValue("antiTheftModeBlocked", AntiTheftModeBlocked);
            writer.WriteBoolValue("appManagementMSIAllowUserControlOverInstall", AppManagementMSIAllowUserControlOverInstall);
            writer.WriteBoolValue("appManagementMSIAlwaysInstallWithElevatedPrivileges", AppManagementMSIAlwaysInstallWithElevatedPrivileges);
            writer.WriteCollectionOfPrimitiveValues<string>("appManagementPackageFamilyNamesToLaunchAfterLogOn", AppManagementPackageFamilyNamesToLaunchAfterLogOn);
            writer.WriteEnumValue<StateManagementSetting>("appsAllowTrustedAppsSideloading", AppsAllowTrustedAppsSideloading);
            writer.WriteBoolValue("appsBlockWindowsStoreOriginatedApps", AppsBlockWindowsStoreOriginatedApps);
            writer.WriteBoolValue("authenticationAllowSecondaryDevice", AuthenticationAllowSecondaryDevice);
            writer.WriteStringValue("authenticationPreferredAzureADTenantDomainName", AuthenticationPreferredAzureADTenantDomainName);
            writer.WriteEnumValue<Enablement>("authenticationWebSignIn", AuthenticationWebSignIn);
            writer.WriteCollectionOfPrimitiveValues<string>("bluetoothAllowedServices", BluetoothAllowedServices);
            writer.WriteBoolValue("bluetoothBlockAdvertising", BluetoothBlockAdvertising);
            writer.WriteBoolValue("bluetoothBlockDiscoverableMode", BluetoothBlockDiscoverableMode);
            writer.WriteBoolValue("bluetoothBlocked", BluetoothBlocked);
            writer.WriteBoolValue("bluetoothBlockPrePairing", BluetoothBlockPrePairing);
            writer.WriteBoolValue("bluetoothBlockPromptedProximalConnections", BluetoothBlockPromptedProximalConnections);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockDataWhenRoaming", CellularBlockDataWhenRoaming);
            writer.WriteBoolValue("cellularBlockVpn", CellularBlockVpn);
            writer.WriteBoolValue("cellularBlockVpnWhenRoaming", CellularBlockVpnWhenRoaming);
            writer.WriteEnumValue<ConfigurationUsage>("cellularData", CellularData);
            writer.WriteBoolValue("certificatesBlockManualRootCertificateInstallation", CertificatesBlockManualRootCertificateInstallation);
            writer.WriteStringValue("configureTimeZone", ConfigureTimeZone);
            writer.WriteBoolValue("connectedDevicesServiceBlocked", ConnectedDevicesServiceBlocked);
            writer.WriteBoolValue("copyPasteBlocked", CopyPasteBlocked);
            writer.WriteBoolValue("cortanaBlocked", CortanaBlocked);
            writer.WriteBoolValue("cryptographyAllowFipsAlgorithmPolicy", CryptographyAllowFipsAlgorithmPolicy);
            writer.WriteBoolValue("dataProtectionBlockDirectMemoryAccess", DataProtectionBlockDirectMemoryAccess);
            writer.WriteBoolValue("defenderBlockEndUserAccess", DefenderBlockEndUserAccess);
            writer.WriteBoolValue("defenderBlockOnAccessProtection", DefenderBlockOnAccessProtection);
            writer.WriteEnumValue<DefenderCloudBlockLevelType>("defenderCloudBlockLevel", DefenderCloudBlockLevel);
            writer.WriteIntValue("defenderCloudExtendedTimeout", DefenderCloudExtendedTimeout);
            writer.WriteIntValue("defenderCloudExtendedTimeoutInSeconds", DefenderCloudExtendedTimeoutInSeconds);
            writer.WriteIntValue("defenderDaysBeforeDeletingQuarantinedMalware", DefenderDaysBeforeDeletingQuarantinedMalware);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>("defenderDetectedMalwareActions", DefenderDetectedMalwareActions);
            writer.WriteBoolValue("defenderDisableCatchupFullScan", DefenderDisableCatchupFullScan);
            writer.WriteBoolValue("defenderDisableCatchupQuickScan", DefenderDisableCatchupQuickScan);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderFileExtensionsToExclude", DefenderFileExtensionsToExclude);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderFilesAndFoldersToExclude", DefenderFilesAndFoldersToExclude);
            writer.WriteEnumValue<DefenderMonitorFileActivity>("defenderMonitorFileActivity", DefenderMonitorFileActivity);
            writer.WriteEnumValue<DefenderPotentiallyUnwantedAppAction>("defenderPotentiallyUnwantedAppAction", DefenderPotentiallyUnwantedAppAction);
            writer.WriteEnumValue<DefenderProtectionType>("defenderPotentiallyUnwantedAppActionSetting", DefenderPotentiallyUnwantedAppActionSetting);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderProcessesToExclude", DefenderProcessesToExclude);
            writer.WriteEnumValue<DefenderPromptForSampleSubmission>("defenderPromptForSampleSubmission", DefenderPromptForSampleSubmission);
            writer.WriteBoolValue("defenderRequireBehaviorMonitoring", DefenderRequireBehaviorMonitoring);
            writer.WriteBoolValue("defenderRequireCloudProtection", DefenderRequireCloudProtection);
            writer.WriteBoolValue("defenderRequireNetworkInspectionSystem", DefenderRequireNetworkInspectionSystem);
            writer.WriteBoolValue("defenderRequireRealTimeMonitoring", DefenderRequireRealTimeMonitoring);
            writer.WriteBoolValue("defenderScanArchiveFiles", DefenderScanArchiveFiles);
            writer.WriteBoolValue("defenderScanDownloads", DefenderScanDownloads);
            writer.WriteBoolValue("defenderScanIncomingMail", DefenderScanIncomingMail);
            writer.WriteBoolValue("defenderScanMappedNetworkDrivesDuringFullScan", DefenderScanMappedNetworkDrivesDuringFullScan);
            writer.WriteIntValue("defenderScanMaxCpu", DefenderScanMaxCpu);
            writer.WriteBoolValue("defenderScanNetworkFiles", DefenderScanNetworkFiles);
            writer.WriteBoolValue("defenderScanRemovableDrivesDuringFullScan", DefenderScanRemovableDrivesDuringFullScan);
            writer.WriteBoolValue("defenderScanScriptsLoadedInInternetExplorer", DefenderScanScriptsLoadedInInternetExplorer);
            writer.WriteEnumValue<DefenderScanType>("defenderScanType", DefenderScanType);
            writer.WriteTimeValue("defenderScheduledQuickScanTime", DefenderScheduledQuickScanTime);
            writer.WriteTimeValue("defenderScheduledScanTime", DefenderScheduledScanTime);
            writer.WriteBoolValue("defenderScheduleScanEnableLowCpuPriority", DefenderScheduleScanEnableLowCpuPriority);
            writer.WriteIntValue("defenderSignatureUpdateIntervalInHours", DefenderSignatureUpdateIntervalInHours);
            writer.WriteEnumValue<DefenderSubmitSamplesConsentType>("defenderSubmitSamplesConsentType", DefenderSubmitSamplesConsentType);
            writer.WriteEnumValue<WeeklySchedule>("defenderSystemScanSchedule", DefenderSystemScanSchedule);
            writer.WriteEnumValue<StateManagementSetting>("developerUnlockSetting", DeveloperUnlockSetting);
            writer.WriteBoolValue("deviceManagementBlockFactoryResetOnMobile", DeviceManagementBlockFactoryResetOnMobile);
            writer.WriteBoolValue("deviceManagementBlockManualUnenroll", DeviceManagementBlockManualUnenroll);
            writer.WriteEnumValue<DiagnosticDataSubmissionMode>("diagnosticsDataSubmissionMode", DiagnosticsDataSubmissionMode);
            writer.WriteCollectionOfPrimitiveValues<string>("displayAppListWithGdiDPIScalingTurnedOff", DisplayAppListWithGdiDPIScalingTurnedOff);
            writer.WriteCollectionOfPrimitiveValues<string>("displayAppListWithGdiDPIScalingTurnedOn", DisplayAppListWithGdiDPIScalingTurnedOn);
            writer.WriteBoolValue("edgeAllowStartPagesModification", EdgeAllowStartPagesModification);
            writer.WriteBoolValue("edgeBlockAccessToAboutFlags", EdgeBlockAccessToAboutFlags);
            writer.WriteBoolValue("edgeBlockAddressBarDropdown", EdgeBlockAddressBarDropdown);
            writer.WriteBoolValue("edgeBlockAutofill", EdgeBlockAutofill);
            writer.WriteBoolValue("edgeBlockCompatibilityList", EdgeBlockCompatibilityList);
            writer.WriteBoolValue("edgeBlockDeveloperTools", EdgeBlockDeveloperTools);
            writer.WriteBoolValue("edgeBlocked", EdgeBlocked);
            writer.WriteBoolValue("edgeBlockEditFavorites", EdgeBlockEditFavorites);
            writer.WriteBoolValue("edgeBlockExtensions", EdgeBlockExtensions);
            writer.WriteBoolValue("edgeBlockFullScreenMode", EdgeBlockFullScreenMode);
            writer.WriteBoolValue("edgeBlockInPrivateBrowsing", EdgeBlockInPrivateBrowsing);
            writer.WriteBoolValue("edgeBlockJavaScript", EdgeBlockJavaScript);
            writer.WriteBoolValue("edgeBlockLiveTileDataCollection", EdgeBlockLiveTileDataCollection);
            writer.WriteBoolValue("edgeBlockPasswordManager", EdgeBlockPasswordManager);
            writer.WriteBoolValue("edgeBlockPopups", EdgeBlockPopups);
            writer.WriteBoolValue("edgeBlockPrelaunch", EdgeBlockPrelaunch);
            writer.WriteBoolValue("edgeBlockPrinting", EdgeBlockPrinting);
            writer.WriteBoolValue("edgeBlockSavingHistory", EdgeBlockSavingHistory);
            writer.WriteBoolValue("edgeBlockSearchEngineCustomization", EdgeBlockSearchEngineCustomization);
            writer.WriteBoolValue("edgeBlockSearchSuggestions", EdgeBlockSearchSuggestions);
            writer.WriteBoolValue("edgeBlockSendingDoNotTrackHeader", EdgeBlockSendingDoNotTrackHeader);
            writer.WriteBoolValue("edgeBlockSendingIntranetTrafficToInternetExplorer", EdgeBlockSendingIntranetTrafficToInternetExplorer);
            writer.WriteBoolValue("edgeBlockSideloadingExtensions", EdgeBlockSideloadingExtensions);
            writer.WriteBoolValue("edgeBlockTabPreloading", EdgeBlockTabPreloading);
            writer.WriteBoolValue("edgeBlockWebContentOnNewTabPage", EdgeBlockWebContentOnNewTabPage);
            writer.WriteBoolValue("edgeClearBrowsingDataOnExit", EdgeClearBrowsingDataOnExit);
            writer.WriteEnumValue<EdgeCookiePolicy>("edgeCookiePolicy", EdgeCookiePolicy);
            writer.WriteBoolValue("edgeDisableFirstRunPage", EdgeDisableFirstRunPage);
            writer.WriteStringValue("edgeEnterpriseModeSiteListLocation", EdgeEnterpriseModeSiteListLocation);
            writer.WriteEnumValue<VisibilitySetting>("edgeFavoritesBarVisibility", EdgeFavoritesBarVisibility);
            writer.WriteStringValue("edgeFavoritesListLocation", EdgeFavoritesListLocation);
            writer.WriteStringValue("edgeFirstRunUrl", EdgeFirstRunUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration>("edgeHomeButtonConfiguration", EdgeHomeButtonConfiguration);
            writer.WriteBoolValue("edgeHomeButtonConfigurationEnabled", EdgeHomeButtonConfigurationEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("edgeHomepageUrls", EdgeHomepageUrls);
            writer.WriteEnumValue<EdgeKioskModeRestrictionType>("edgeKioskModeRestriction", EdgeKioskModeRestriction);
            writer.WriteIntValue("edgeKioskResetAfterIdleTimeInMinutes", EdgeKioskResetAfterIdleTimeInMinutes);
            writer.WriteStringValue("edgeNewTabPageURL", EdgeNewTabPageURL);
            writer.WriteEnumValue<EdgeOpenOptions>("edgeOpensWith", EdgeOpensWith);
            writer.WriteBoolValue("edgePreventCertificateErrorOverride", EdgePreventCertificateErrorOverride);
            writer.WriteCollectionOfPrimitiveValues<string>("edgeRequiredExtensionPackageFamilyNames", EdgeRequiredExtensionPackageFamilyNames);
            writer.WriteBoolValue("edgeRequireSmartScreen", EdgeRequireSmartScreen);
            writer.WriteObjectValue<EdgeSearchEngineBase>("edgeSearchEngine", EdgeSearchEngine);
            writer.WriteBoolValue("edgeSendIntranetTrafficToInternetExplorer", EdgeSendIntranetTrafficToInternetExplorer);
            writer.WriteEnumValue<InternetExplorerMessageSetting>("edgeShowMessageWhenOpeningInternetExplorerSites", EdgeShowMessageWhenOpeningInternetExplorerSites);
            writer.WriteBoolValue("edgeSyncFavoritesWithInternetExplorer", EdgeSyncFavoritesWithInternetExplorer);
            writer.WriteEnumValue<EdgeTelemetryMode>("edgeTelemetryForMicrosoft365Analytics", EdgeTelemetryForMicrosoft365Analytics);
            writer.WriteBoolValue("enableAutomaticRedeployment", EnableAutomaticRedeployment);
            writer.WriteIntValue("energySaverOnBatteryThresholdPercentage", EnergySaverOnBatteryThresholdPercentage);
            writer.WriteIntValue("energySaverPluggedInThresholdPercentage", EnergySaverPluggedInThresholdPercentage);
            writer.WriteStringValue("enterpriseCloudPrintDiscoveryEndPoint", EnterpriseCloudPrintDiscoveryEndPoint);
            writer.WriteIntValue("enterpriseCloudPrintDiscoveryMaxLimit", EnterpriseCloudPrintDiscoveryMaxLimit);
            writer.WriteStringValue("enterpriseCloudPrintMopriaDiscoveryResourceIdentifier", EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier);
            writer.WriteStringValue("enterpriseCloudPrintOAuthAuthority", EnterpriseCloudPrintOAuthAuthority);
            writer.WriteStringValue("enterpriseCloudPrintOAuthClientIdentifier", EnterpriseCloudPrintOAuthClientIdentifier);
            writer.WriteStringValue("enterpriseCloudPrintResourceIdentifier", EnterpriseCloudPrintResourceIdentifier);
            writer.WriteBoolValue("experienceBlockDeviceDiscovery", ExperienceBlockDeviceDiscovery);
            writer.WriteBoolValue("experienceBlockErrorDialogWhenNoSIM", ExperienceBlockErrorDialogWhenNoSIM);
            writer.WriteBoolValue("experienceBlockTaskSwitcher", ExperienceBlockTaskSwitcher);
            writer.WriteEnumValue<BrowserSyncSetting>("experienceDoNotSyncBrowserSettings", ExperienceDoNotSyncBrowserSettings);
            writer.WriteEnumValue<Enablement>("findMyFiles", FindMyFiles);
            writer.WriteBoolValue("gameDvrBlocked", GameDvrBlocked);
            writer.WriteEnumValue<InkAccessSetting>("inkWorkspaceAccess", InkWorkspaceAccess);
            writer.WriteEnumValue<StateManagementSetting>("inkWorkspaceAccessState", InkWorkspaceAccessState);
            writer.WriteBoolValue("inkWorkspaceBlockSuggestedApps", InkWorkspaceBlockSuggestedApps);
            writer.WriteBoolValue("internetSharingBlocked", InternetSharingBlocked);
            writer.WriteBoolValue("locationServicesBlocked", LocationServicesBlocked);
            writer.WriteEnumValue<Enablement>("lockScreenActivateAppsWithVoice", LockScreenActivateAppsWithVoice);
            writer.WriteBoolValue("lockScreenAllowTimeoutConfiguration", LockScreenAllowTimeoutConfiguration);
            writer.WriteBoolValue("lockScreenBlockActionCenterNotifications", LockScreenBlockActionCenterNotifications);
            writer.WriteBoolValue("lockScreenBlockCortana", LockScreenBlockCortana);
            writer.WriteBoolValue("lockScreenBlockToastNotifications", LockScreenBlockToastNotifications);
            writer.WriteIntValue("lockScreenTimeoutInSeconds", LockScreenTimeoutInSeconds);
            writer.WriteBoolValue("logonBlockFastUserSwitching", LogonBlockFastUserSwitching);
            writer.WriteBoolValue("messagingBlockMMS", MessagingBlockMMS);
            writer.WriteBoolValue("messagingBlockRichCommunicationServices", MessagingBlockRichCommunicationServices);
            writer.WriteBoolValue("messagingBlockSync", MessagingBlockSync);
            writer.WriteBoolValue("microsoftAccountBlocked", MicrosoftAccountBlocked);
            writer.WriteBoolValue("microsoftAccountBlockSettingsSync", MicrosoftAccountBlockSettingsSync);
            writer.WriteEnumValue<SignInAssistantOptions>("microsoftAccountSignInAssistantSettings", MicrosoftAccountSignInAssistantSettings);
            writer.WriteBoolValue("networkProxyApplySettingsDeviceWide", NetworkProxyApplySettingsDeviceWide);
            writer.WriteStringValue("networkProxyAutomaticConfigurationUrl", NetworkProxyAutomaticConfigurationUrl);
            writer.WriteBoolValue("networkProxyDisableAutoDetect", NetworkProxyDisableAutoDetect);
            writer.WriteObjectValue<Windows10NetworkProxyServer>("networkProxyServer", NetworkProxyServer);
            writer.WriteBoolValue("nfcBlocked", NfcBlocked);
            writer.WriteBoolValue("oneDriveDisableFileSync", OneDriveDisableFileSync);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumAgeInDays", PasswordMinimumAgeInDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("passwordRequireWhenResumeFromIdleState", PasswordRequireWhenResumeFromIdleState);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteStringValue("personalizationDesktopImageUrl", PersonalizationDesktopImageUrl);
            writer.WriteStringValue("personalizationLockScreenImageUrl", PersonalizationLockScreenImageUrl);
            writer.WriteEnumValue<PowerActionType>("powerButtonActionOnBattery", PowerButtonActionOnBattery);
            writer.WriteEnumValue<PowerActionType>("powerButtonActionPluggedIn", PowerButtonActionPluggedIn);
            writer.WriteEnumValue<Enablement>("powerHybridSleepOnBattery", PowerHybridSleepOnBattery);
            writer.WriteEnumValue<Enablement>("powerHybridSleepPluggedIn", PowerHybridSleepPluggedIn);
            writer.WriteEnumValue<PowerActionType>("powerLidCloseActionOnBattery", PowerLidCloseActionOnBattery);
            writer.WriteEnumValue<PowerActionType>("powerLidCloseActionPluggedIn", PowerLidCloseActionPluggedIn);
            writer.WriteEnumValue<PowerActionType>("powerSleepButtonActionOnBattery", PowerSleepButtonActionOnBattery);
            writer.WriteEnumValue<PowerActionType>("powerSleepButtonActionPluggedIn", PowerSleepButtonActionPluggedIn);
            writer.WriteBoolValue("printerBlockAddition", PrinterBlockAddition);
            writer.WriteStringValue("printerDefaultName", PrinterDefaultName);
            writer.WriteCollectionOfPrimitiveValues<string>("printerNames", PrinterNames);
            writer.WriteCollectionOfObjectValues<WindowsPrivacyDataAccessControlItem>("privacyAccessControls", PrivacyAccessControls);
            writer.WriteEnumValue<StateManagementSetting>("privacyAdvertisingId", PrivacyAdvertisingId);
            writer.WriteBoolValue("privacyAutoAcceptPairingAndConsentPrompts", PrivacyAutoAcceptPairingAndConsentPrompts);
            writer.WriteBoolValue("privacyBlockActivityFeed", PrivacyBlockActivityFeed);
            writer.WriteBoolValue("privacyBlockInputPersonalization", PrivacyBlockInputPersonalization);
            writer.WriteBoolValue("privacyBlockPublishUserActivities", PrivacyBlockPublishUserActivities);
            writer.WriteBoolValue("privacyDisableLaunchExperience", PrivacyDisableLaunchExperience);
            writer.WriteBoolValue("resetProtectionModeBlocked", ResetProtectionModeBlocked);
            writer.WriteEnumValue<SafeSearchFilterType>("safeSearchFilter", SafeSearchFilter);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("searchBlockDiacritics", SearchBlockDiacritics);
            writer.WriteBoolValue("searchBlockWebResults", SearchBlockWebResults);
            writer.WriteBoolValue("searchDisableAutoLanguageDetection", SearchDisableAutoLanguageDetection);
            writer.WriteBoolValue("searchDisableIndexerBackoff", SearchDisableIndexerBackoff);
            writer.WriteBoolValue("searchDisableIndexingEncryptedItems", SearchDisableIndexingEncryptedItems);
            writer.WriteBoolValue("searchDisableIndexingRemovableDrive", SearchDisableIndexingRemovableDrive);
            writer.WriteBoolValue("searchDisableLocation", SearchDisableLocation);
            writer.WriteBoolValue("searchDisableUseLocation", SearchDisableUseLocation);
            writer.WriteBoolValue("searchEnableAutomaticIndexSizeManangement", SearchEnableAutomaticIndexSizeManangement);
            writer.WriteBoolValue("searchEnableRemoteQueries", SearchEnableRemoteQueries);
            writer.WriteBoolValue("securityBlockAzureADJoinedDevicesAutoEncryption", SecurityBlockAzureADJoinedDevicesAutoEncryption);
            writer.WriteBoolValue("settingsBlockAccountsPage", SettingsBlockAccountsPage);
            writer.WriteBoolValue("settingsBlockAddProvisioningPackage", SettingsBlockAddProvisioningPackage);
            writer.WriteBoolValue("settingsBlockAppsPage", SettingsBlockAppsPage);
            writer.WriteBoolValue("settingsBlockChangeLanguage", SettingsBlockChangeLanguage);
            writer.WriteBoolValue("settingsBlockChangePowerSleep", SettingsBlockChangePowerSleep);
            writer.WriteBoolValue("settingsBlockChangeRegion", SettingsBlockChangeRegion);
            writer.WriteBoolValue("settingsBlockChangeSystemTime", SettingsBlockChangeSystemTime);
            writer.WriteBoolValue("settingsBlockDevicesPage", SettingsBlockDevicesPage);
            writer.WriteBoolValue("settingsBlockEaseOfAccessPage", SettingsBlockEaseOfAccessPage);
            writer.WriteBoolValue("settingsBlockEditDeviceName", SettingsBlockEditDeviceName);
            writer.WriteBoolValue("settingsBlockGamingPage", SettingsBlockGamingPage);
            writer.WriteBoolValue("settingsBlockNetworkInternetPage", SettingsBlockNetworkInternetPage);
            writer.WriteBoolValue("settingsBlockPersonalizationPage", SettingsBlockPersonalizationPage);
            writer.WriteBoolValue("settingsBlockPrivacyPage", SettingsBlockPrivacyPage);
            writer.WriteBoolValue("settingsBlockRemoveProvisioningPackage", SettingsBlockRemoveProvisioningPackage);
            writer.WriteBoolValue("settingsBlockSettingsApp", SettingsBlockSettingsApp);
            writer.WriteBoolValue("settingsBlockSystemPage", SettingsBlockSystemPage);
            writer.WriteBoolValue("settingsBlockTimeLanguagePage", SettingsBlockTimeLanguagePage);
            writer.WriteBoolValue("settingsBlockUpdateSecurityPage", SettingsBlockUpdateSecurityPage);
            writer.WriteBoolValue("sharedUserAppDataAllowed", SharedUserAppDataAllowed);
            writer.WriteEnumValue<AppInstallControlType>("smartScreenAppInstallControl", SmartScreenAppInstallControl);
            writer.WriteBoolValue("smartScreenBlockPromptOverride", SmartScreenBlockPromptOverride);
            writer.WriteBoolValue("smartScreenBlockPromptOverrideForFiles", SmartScreenBlockPromptOverrideForFiles);
            writer.WriteBoolValue("smartScreenEnableAppInstallControl", SmartScreenEnableAppInstallControl);
            writer.WriteBoolValue("startBlockUnpinningAppsFromTaskbar", StartBlockUnpinningAppsFromTaskbar);
            writer.WriteEnumValue<WindowsStartMenuAppListVisibilityType>("startMenuAppListVisibility", StartMenuAppListVisibility);
            writer.WriteBoolValue("startMenuHideChangeAccountSettings", StartMenuHideChangeAccountSettings);
            writer.WriteBoolValue("startMenuHideFrequentlyUsedApps", StartMenuHideFrequentlyUsedApps);
            writer.WriteBoolValue("startMenuHideHibernate", StartMenuHideHibernate);
            writer.WriteBoolValue("startMenuHideLock", StartMenuHideLock);
            writer.WriteBoolValue("startMenuHidePowerButton", StartMenuHidePowerButton);
            writer.WriteBoolValue("startMenuHideRecentJumpLists", StartMenuHideRecentJumpLists);
            writer.WriteBoolValue("startMenuHideRecentlyAddedApps", StartMenuHideRecentlyAddedApps);
            writer.WriteBoolValue("startMenuHideRestartOptions", StartMenuHideRestartOptions);
            writer.WriteBoolValue("startMenuHideShutDown", StartMenuHideShutDown);
            writer.WriteBoolValue("startMenuHideSignOut", StartMenuHideSignOut);
            writer.WriteBoolValue("startMenuHideSleep", StartMenuHideSleep);
            writer.WriteBoolValue("startMenuHideSwitchAccount", StartMenuHideSwitchAccount);
            writer.WriteBoolValue("startMenuHideUserTile", StartMenuHideUserTile);
            writer.WriteByteArrayValue("startMenuLayoutEdgeAssetsXml", StartMenuLayoutEdgeAssetsXml);
            writer.WriteByteArrayValue("startMenuLayoutXml", StartMenuLayoutXml);
            writer.WriteEnumValue<WindowsStartMenuModeType>("startMenuMode", StartMenuMode);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderDocuments", StartMenuPinnedFolderDocuments);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderDownloads", StartMenuPinnedFolderDownloads);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderFileExplorer", StartMenuPinnedFolderFileExplorer);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderHomeGroup", StartMenuPinnedFolderHomeGroup);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderMusic", StartMenuPinnedFolderMusic);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderNetwork", StartMenuPinnedFolderNetwork);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderPersonalFolder", StartMenuPinnedFolderPersonalFolder);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderPictures", StartMenuPinnedFolderPictures);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderSettings", StartMenuPinnedFolderSettings);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderVideos", StartMenuPinnedFolderVideos);
            writer.WriteBoolValue("storageBlockRemovableStorage", StorageBlockRemovableStorage);
            writer.WriteBoolValue("storageRequireMobileDeviceEncryption", StorageRequireMobileDeviceEncryption);
            writer.WriteBoolValue("storageRestrictAppDataToSystemVolume", StorageRestrictAppDataToSystemVolume);
            writer.WriteBoolValue("storageRestrictAppInstallToSystemVolume", StorageRestrictAppInstallToSystemVolume);
            writer.WriteStringValue("systemTelemetryProxyServer", SystemTelemetryProxyServer);
            writer.WriteBoolValue("taskManagerBlockEndTask", TaskManagerBlockEndTask);
            writer.WriteBoolValue("tenantLockdownRequireNetworkDuringOutOfBoxExperience", TenantLockdownRequireNetworkDuringOutOfBoxExperience);
            writer.WriteBoolValue("uninstallBuiltInApps", UninstallBuiltInApps);
            writer.WriteBoolValue("usbBlocked", UsbBlocked);
            writer.WriteBoolValue("voiceRecordingBlocked", VoiceRecordingBlocked);
            writer.WriteBoolValue("webRtcBlockLocalhostIpAddress", WebRtcBlockLocalhostIpAddress);
            writer.WriteBoolValue("wiFiBlockAutomaticConnectHotspots", WiFiBlockAutomaticConnectHotspots);
            writer.WriteBoolValue("wiFiBlocked", WiFiBlocked);
            writer.WriteBoolValue("wiFiBlockManualConfiguration", WiFiBlockManualConfiguration);
            writer.WriteIntValue("wiFiScanInterval", WiFiScanInterval);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule>("windows10AppsForceUpdateSchedule", Windows10AppsForceUpdateSchedule);
            writer.WriteBoolValue("windowsSpotlightBlockConsumerSpecificFeatures", WindowsSpotlightBlockConsumerSpecificFeatures);
            writer.WriteBoolValue("windowsSpotlightBlocked", WindowsSpotlightBlocked);
            writer.WriteBoolValue("windowsSpotlightBlockOnActionCenter", WindowsSpotlightBlockOnActionCenter);
            writer.WriteBoolValue("windowsSpotlightBlockTailoredExperiences", WindowsSpotlightBlockTailoredExperiences);
            writer.WriteBoolValue("windowsSpotlightBlockThirdPartyNotifications", WindowsSpotlightBlockThirdPartyNotifications);
            writer.WriteBoolValue("windowsSpotlightBlockWelcomeExperience", WindowsSpotlightBlockWelcomeExperience);
            writer.WriteBoolValue("windowsSpotlightBlockWindowsTips", WindowsSpotlightBlockWindowsTips);
            writer.WriteEnumValue<WindowsSpotlightEnablementSettings>("windowsSpotlightConfigureOnLockScreen", WindowsSpotlightConfigureOnLockScreen);
            writer.WriteBoolValue("windowsStoreBlockAutoUpdate", WindowsStoreBlockAutoUpdate);
            writer.WriteBoolValue("windowsStoreBlocked", WindowsStoreBlocked);
            writer.WriteBoolValue("windowsStoreEnablePrivateStoreOnly", WindowsStoreEnablePrivateStoreOnly);
            writer.WriteBoolValue("wirelessDisplayBlockProjectionToThisDevice", WirelessDisplayBlockProjectionToThisDevice);
            writer.WriteBoolValue("wirelessDisplayBlockUserInputFromReceiver", WirelessDisplayBlockUserInputFromReceiver);
            writer.WriteBoolValue("wirelessDisplayRequirePinForPairing", WirelessDisplayRequirePinForPairing);
        }
    }
}
