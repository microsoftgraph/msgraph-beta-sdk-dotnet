using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10EndpointProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Gets or sets whether applications inside Microsoft Defender Application Guard can access the device’s camera and microphone.</summary>
        public bool? ApplicationGuardAllowCameraMicrophoneRedirection {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowCameraMicrophoneRedirection)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowCameraMicrophoneRedirection), value); }
        }
        /// <summary>Allow users to download files from Edge in the application guard container and save them on the host file system</summary>
        public bool? ApplicationGuardAllowFileSaveOnHost {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowFileSaveOnHost)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowFileSaveOnHost), value); }
        }
        /// <summary>Allow persisting user generated data inside the App Guard Containter (favorites, cookies, web passwords, etc.)</summary>
        public bool? ApplicationGuardAllowPersistence {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPersistence)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPersistence), value); }
        }
        /// <summary>Allow printing to Local Printers from Container</summary>
        public bool? ApplicationGuardAllowPrintToLocalPrinters {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPrintToLocalPrinters)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPrintToLocalPrinters), value); }
        }
        /// <summary>Allow printing to Network Printers from Container</summary>
        public bool? ApplicationGuardAllowPrintToNetworkPrinters {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPrintToNetworkPrinters)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPrintToNetworkPrinters), value); }
        }
        /// <summary>Allow printing to PDF from Container</summary>
        public bool? ApplicationGuardAllowPrintToPDF {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPrintToPDF)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPrintToPDF), value); }
        }
        /// <summary>Allow printing to XPS from Container</summary>
        public bool? ApplicationGuardAllowPrintToXPS {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPrintToXPS)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPrintToXPS), value); }
        }
        /// <summary>Allow application guard to use virtual GPU</summary>
        public bool? ApplicationGuardAllowVirtualGPU {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowVirtualGPU)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowVirtualGPU), value); }
        }
        /// <summary>Block clipboard to share data from Host to Container, or from Container to Host, or both ways, or neither ways. Possible values are: notConfigured, blockBoth, blockHostToContainer, blockContainerToHost, blockNone.</summary>
        public ApplicationGuardBlockClipboardSharingType? ApplicationGuardBlockClipboardSharing {
            get { return BackingStore?.Get<ApplicationGuardBlockClipboardSharingType?>(nameof(ApplicationGuardBlockClipboardSharing)); }
            set { BackingStore?.Set(nameof(ApplicationGuardBlockClipboardSharing), value); }
        }
        /// <summary>Block clipboard to transfer image file, text file or neither of them. Possible values are: notConfigured, blockImageAndTextFile, blockImageFile, blockNone, blockTextFile.</summary>
        public ApplicationGuardBlockFileTransferType? ApplicationGuardBlockFileTransfer {
            get { return BackingStore?.Get<ApplicationGuardBlockFileTransferType?>(nameof(ApplicationGuardBlockFileTransfer)); }
            set { BackingStore?.Set(nameof(ApplicationGuardBlockFileTransfer), value); }
        }
        /// <summary>Block enterprise sites to load non-enterprise content, such as third party plug-ins</summary>
        public bool? ApplicationGuardBlockNonEnterpriseContent {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardBlockNonEnterpriseContent)); }
            set { BackingStore?.Set(nameof(ApplicationGuardBlockNonEnterpriseContent), value); }
        }
        /// <summary>Allows certain device level Root Certificates to be shared with the Microsoft Defender Application Guard container.</summary>
        public List<string> ApplicationGuardCertificateThumbprints {
            get { return BackingStore?.Get<List<string>>(nameof(ApplicationGuardCertificateThumbprints)); }
            set { BackingStore?.Set(nameof(ApplicationGuardCertificateThumbprints), value); }
        }
        /// <summary>Enable Windows Defender Application Guard</summary>
        public bool? ApplicationGuardEnabled {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardEnabled)); }
            set { BackingStore?.Set(nameof(ApplicationGuardEnabled), value); }
        }
        /// <summary>Enable Windows Defender Application Guard for newer Windows builds. Possible values are: notConfigured, enabledForEdge, enabledForOffice, enabledForEdgeAndOffice.</summary>
        public Microsoft.Graph.Beta.Models.ApplicationGuardEnabledOptions? ApplicationGuardEnabledOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ApplicationGuardEnabledOptions?>(nameof(ApplicationGuardEnabledOptions)); }
            set { BackingStore?.Set(nameof(ApplicationGuardEnabledOptions), value); }
        }
        /// <summary>Force auditing will persist Windows logs and events to meet security/compliance criteria (sample events are user login-logoff, use of privilege rights, software installation, system changes, etc.)</summary>
        public bool? ApplicationGuardForceAuditing {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardForceAuditing)); }
            set { BackingStore?.Set(nameof(ApplicationGuardForceAuditing), value); }
        }
        /// <summary>Enables the Admin to choose what types of app to allow on devices. Possible values are: notConfigured, enforceComponentsAndStoreApps, auditComponentsAndStoreApps, enforceComponentsStoreAppsAndSmartlocker, auditComponentsStoreAppsAndSmartlocker.</summary>
        public AppLockerApplicationControlType? AppLockerApplicationControl {
            get { return BackingStore?.Get<AppLockerApplicationControlType?>(nameof(AppLockerApplicationControl)); }
            set { BackingStore?.Set(nameof(AppLockerApplicationControl), value); }
        }
        /// <summary>Allows the admin to allow standard users to enable encrpytion during Azure AD Join.</summary>
        public bool? BitLockerAllowStandardUserEncryption {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerAllowStandardUserEncryption)); }
            set { BackingStore?.Set(nameof(BitLockerAllowStandardUserEncryption), value); }
        }
        /// <summary>Allows the Admin to disable the warning prompt for other disk encryption on the user machines.</summary>
        public bool? BitLockerDisableWarningForOtherDiskEncryption {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerDisableWarningForOtherDiskEncryption)); }
            set { BackingStore?.Set(nameof(BitLockerDisableWarningForOtherDiskEncryption), value); }
        }
        /// <summary>Allows the admin to require encryption to be turned on using BitLocker. This policy is valid only for a mobile SKU.</summary>
        public bool? BitLockerEnableStorageCardEncryptionOnMobile {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerEnableStorageCardEncryptionOnMobile)); }
            set { BackingStore?.Set(nameof(BitLockerEnableStorageCardEncryptionOnMobile), value); }
        }
        /// <summary>Allows the admin to require encryption to be turned on using BitLocker.</summary>
        public bool? BitLockerEncryptDevice {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerEncryptDevice)); }
            set { BackingStore?.Set(nameof(BitLockerEncryptDevice), value); }
        }
        /// <summary>BitLocker Fixed Drive Policy.</summary>
        public Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy BitLockerFixedDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy>(nameof(BitLockerFixedDrivePolicy)); }
            set { BackingStore?.Set(nameof(BitLockerFixedDrivePolicy), value); }
        }
        /// <summary>This setting initiates a client-driven recovery password rotation after an OS drive recovery (either by using bootmgr or WinRE). Possible values are: notConfigured, disabled, enabledForAzureAd, enabledForAzureAdAndHybrid.</summary>
        public BitLockerRecoveryPasswordRotationType? BitLockerRecoveryPasswordRotation {
            get { return BackingStore?.Get<BitLockerRecoveryPasswordRotationType?>(nameof(BitLockerRecoveryPasswordRotation)); }
            set { BackingStore?.Set(nameof(BitLockerRecoveryPasswordRotation), value); }
        }
        /// <summary>BitLocker Removable Drive Policy.</summary>
        public Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy BitLockerRemovableDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy>(nameof(BitLockerRemovableDrivePolicy)); }
            set { BackingStore?.Set(nameof(BitLockerRemovableDrivePolicy), value); }
        }
        /// <summary>BitLocker System Drive Policy.</summary>
        public Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy BitLockerSystemDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy>(nameof(BitLockerSystemDrivePolicy)); }
            set { BackingStore?.Set(nameof(BitLockerSystemDrivePolicy), value); }
        }
        /// <summary>List of folder paths to be added to the list of protected folders</summary>
        public List<string> DefenderAdditionalGuardedFolders {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderAdditionalGuardedFolders)); }
            set { BackingStore?.Set(nameof(DefenderAdditionalGuardedFolders), value); }
        }
        /// <summary>Value indicating the behavior of Adobe Reader from creating child processes. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderAdobeReaderLaunchChildProcess {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderAdobeReaderLaunchChildProcess)); }
            set { BackingStore?.Set(nameof(DefenderAdobeReaderLaunchChildProcess), value); }
        }
        /// <summary>Value indicating use of advanced protection against ransomeware. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderAdvancedRansomewareProtectionType {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderAdvancedRansomewareProtectionType)); }
            set { BackingStore?.Set(nameof(DefenderAdvancedRansomewareProtectionType), value); }
        }
        /// <summary>Allows or disallows Windows Defender Behavior Monitoring functionality.</summary>
        public bool? DefenderAllowBehaviorMonitoring {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowBehaviorMonitoring)); }
            set { BackingStore?.Set(nameof(DefenderAllowBehaviorMonitoring), value); }
        }
        /// <summary>To best protect your PC, Windows Defender will send information to Microsoft about any problems it finds. Microsoft will analyze that information, learn more about problems affecting you and other customers, and offer improved solutions.</summary>
        public bool? DefenderAllowCloudProtection {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowCloudProtection)); }
            set { BackingStore?.Set(nameof(DefenderAllowCloudProtection), value); }
        }
        /// <summary>Allows or disallows user access to the Windows Defender UI. If disallowed, all Windows Defender notifications will also be suppressed.</summary>
        public bool? DefenderAllowEndUserAccess {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowEndUserAccess)); }
            set { BackingStore?.Set(nameof(DefenderAllowEndUserAccess), value); }
        }
        /// <summary>Allows or disallows Windows Defender Intrusion Prevention functionality.</summary>
        public bool? DefenderAllowIntrusionPreventionSystem {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowIntrusionPreventionSystem)); }
            set { BackingStore?.Set(nameof(DefenderAllowIntrusionPreventionSystem), value); }
        }
        /// <summary>Allows or disallows Windows Defender On Access Protection functionality.</summary>
        public bool? DefenderAllowOnAccessProtection {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowOnAccessProtection)); }
            set { BackingStore?.Set(nameof(DefenderAllowOnAccessProtection), value); }
        }
        /// <summary>Allows or disallows Windows Defender Realtime Monitoring functionality.</summary>
        public bool? DefenderAllowRealTimeMonitoring {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowRealTimeMonitoring)); }
            set { BackingStore?.Set(nameof(DefenderAllowRealTimeMonitoring), value); }
        }
        /// <summary>Allows or disallows scanning of archives.</summary>
        public bool? DefenderAllowScanArchiveFiles {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowScanArchiveFiles)); }
            set { BackingStore?.Set(nameof(DefenderAllowScanArchiveFiles), value); }
        }
        /// <summary>Allows or disallows Windows Defender IOAVP Protection functionality.</summary>
        public bool? DefenderAllowScanDownloads {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowScanDownloads)); }
            set { BackingStore?.Set(nameof(DefenderAllowScanDownloads), value); }
        }
        /// <summary>Allows or disallows a scanning of network files.</summary>
        public bool? DefenderAllowScanNetworkFiles {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowScanNetworkFiles)); }
            set { BackingStore?.Set(nameof(DefenderAllowScanNetworkFiles), value); }
        }
        /// <summary>Allows or disallows a full scan of removable drives. During a quick scan, removable drives may still be scanned.</summary>
        public bool? DefenderAllowScanRemovableDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowScanRemovableDrivesDuringFullScan)); }
            set { BackingStore?.Set(nameof(DefenderAllowScanRemovableDrivesDuringFullScan), value); }
        }
        /// <summary>Allows or disallows Windows Defender Script Scanning functionality.</summary>
        public bool? DefenderAllowScanScriptsLoadedInInternetExplorer {
            get { return BackingStore?.Get<bool?>(nameof(DefenderAllowScanScriptsLoadedInInternetExplorer)); }
            set { BackingStore?.Set(nameof(DefenderAllowScanScriptsLoadedInInternetExplorer), value); }
        }
        /// <summary>List of exe files and folders to be excluded from attack surface reduction rules</summary>
        public List<string> DefenderAttackSurfaceReductionExcludedPaths {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderAttackSurfaceReductionExcludedPaths)); }
            set { BackingStore?.Set(nameof(DefenderAttackSurfaceReductionExcludedPaths), value); }
        }
        /// <summary>Allows or disallows user access to the Windows Defender UI. If disallowed, all Windows Defender notifications will also be suppressed.</summary>
        public bool? DefenderBlockEndUserAccess {
            get { return BackingStore?.Get<bool?>(nameof(DefenderBlockEndUserAccess)); }
            set { BackingStore?.Set(nameof(DefenderBlockEndUserAccess), value); }
        }
        /// <summary>Value indicating the behavior of Block persistence through WMI event subscription. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderBlockPersistenceThroughWmiType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderBlockPersistenceThroughWmiType)); }
            set { BackingStore?.Set(nameof(DefenderBlockPersistenceThroughWmiType), value); }
        }
        /// <summary>This policy setting allows you to manage whether a check for new virus and spyware definitions will occur before running a scan.</summary>
        public bool? DefenderCheckForSignaturesBeforeRunningScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderCheckForSignaturesBeforeRunningScan)); }
            set { BackingStore?.Set(nameof(DefenderCheckForSignaturesBeforeRunningScan), value); }
        }
        /// <summary>Added in Windows 10, version 1709. This policy setting determines how aggressive Windows Defender Antivirus will be in blocking and scanning suspicious files. Value type is integer. This feature requires the &apos;Join Microsoft MAPS&apos; setting enabled in order to function. Possible values are: notConfigured, high, highPlus, zeroTolerance.</summary>
        public DefenderCloudBlockLevelType? DefenderCloudBlockLevel {
            get { return BackingStore?.Get<DefenderCloudBlockLevelType?>(nameof(DefenderCloudBlockLevel)); }
            set { BackingStore?.Set(nameof(DefenderCloudBlockLevel), value); }
        }
        /// <summary>Added in Windows 10, version 1709. This feature allows Windows Defender Antivirus to block a suspicious file for up to 60 seconds, and scan it in the cloud to make sure it&apos;s safe. Value type is integer, range is 0 - 50. This feature depends on three other MAPS settings the must all be enabled- &apos;Configure the &apos;Block at First Sight&apos; feature; &apos;Join Microsoft MAPS&apos;; &apos;Send file samples when further analysis is required&apos;. Valid values 0 to 50</summary>
        public int? DefenderCloudExtendedTimeoutInSeconds {
            get { return BackingStore?.Get<int?>(nameof(DefenderCloudExtendedTimeoutInSeconds)); }
            set { BackingStore?.Set(nameof(DefenderCloudExtendedTimeoutInSeconds), value); }
        }
        /// <summary>Time period (in days) that quarantine items will be stored on the system. Valid values 0 to 90</summary>
        public int? DefenderDaysBeforeDeletingQuarantinedMalware {
            get { return BackingStore?.Get<int?>(nameof(DefenderDaysBeforeDeletingQuarantinedMalware)); }
            set { BackingStore?.Set(nameof(DefenderDaysBeforeDeletingQuarantinedMalware), value); }
        }
        /// <summary>Allows an administrator to specify any valid threat severity levels and the corresponding default action ID to take.</summary>
        public Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions DefenderDetectedMalwareActions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>(nameof(DefenderDetectedMalwareActions)); }
            set { BackingStore?.Set(nameof(DefenderDetectedMalwareActions), value); }
        }
        /// <summary>Allows or disallows Windows Defender Behavior Monitoring functionality.</summary>
        public bool? DefenderDisableBehaviorMonitoring {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableBehaviorMonitoring)); }
            set { BackingStore?.Set(nameof(DefenderDisableBehaviorMonitoring), value); }
        }
        /// <summary>This policy setting allows you to configure catch-up scans for scheduled full scans. A catch-up scan is a scan that is initiated because a regularly scheduled scan was missed. Usually these scheduled scans are missed because the computer was turned off at the scheduled time.</summary>
        public bool? DefenderDisableCatchupFullScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableCatchupFullScan)); }
            set { BackingStore?.Set(nameof(DefenderDisableCatchupFullScan), value); }
        }
        /// <summary>This policy setting allows you to configure catch-up scans for scheduled quick scans. A catch-up scan is a scan that is initiated because a regularly scheduled scan was missed. Usually these scheduled scans are missed because the computer was turned off at the scheduled time.</summary>
        public bool? DefenderDisableCatchupQuickScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableCatchupQuickScan)); }
            set { BackingStore?.Set(nameof(DefenderDisableCatchupQuickScan), value); }
        }
        /// <summary>To best protect your PC, Windows Defender will send information to Microsoft about any problems it finds. Microsoft will analyze that information, learn more about problems affecting you and other customers, and offer improved solutions.</summary>
        public bool? DefenderDisableCloudProtection {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableCloudProtection)); }
            set { BackingStore?.Set(nameof(DefenderDisableCloudProtection), value); }
        }
        /// <summary>Allows or disallows Windows Defender Intrusion Prevention functionality.</summary>
        public bool? DefenderDisableIntrusionPreventionSystem {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableIntrusionPreventionSystem)); }
            set { BackingStore?.Set(nameof(DefenderDisableIntrusionPreventionSystem), value); }
        }
        /// <summary>Allows or disallows Windows Defender On Access Protection functionality.</summary>
        public bool? DefenderDisableOnAccessProtection {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableOnAccessProtection)); }
            set { BackingStore?.Set(nameof(DefenderDisableOnAccessProtection), value); }
        }
        /// <summary>Allows or disallows Windows Defender Realtime Monitoring functionality.</summary>
        public bool? DefenderDisableRealTimeMonitoring {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableRealTimeMonitoring)); }
            set { BackingStore?.Set(nameof(DefenderDisableRealTimeMonitoring), value); }
        }
        /// <summary>Allows or disallows scanning of archives.</summary>
        public bool? DefenderDisableScanArchiveFiles {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableScanArchiveFiles)); }
            set { BackingStore?.Set(nameof(DefenderDisableScanArchiveFiles), value); }
        }
        /// <summary>Allows or disallows Windows Defender IOAVP Protection functionality.</summary>
        public bool? DefenderDisableScanDownloads {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableScanDownloads)); }
            set { BackingStore?.Set(nameof(DefenderDisableScanDownloads), value); }
        }
        /// <summary>Allows or disallows a scanning of network files.</summary>
        public bool? DefenderDisableScanNetworkFiles {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableScanNetworkFiles)); }
            set { BackingStore?.Set(nameof(DefenderDisableScanNetworkFiles), value); }
        }
        /// <summary>Allows or disallows a full scan of removable drives. During a quick scan, removable drives may still be scanned.</summary>
        public bool? DefenderDisableScanRemovableDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableScanRemovableDrivesDuringFullScan)); }
            set { BackingStore?.Set(nameof(DefenderDisableScanRemovableDrivesDuringFullScan), value); }
        }
        /// <summary>Allows or disallows Windows Defender Script Scanning functionality.</summary>
        public bool? DefenderDisableScanScriptsLoadedInInternetExplorer {
            get { return BackingStore?.Get<bool?>(nameof(DefenderDisableScanScriptsLoadedInInternetExplorer)); }
            set { BackingStore?.Set(nameof(DefenderDisableScanScriptsLoadedInInternetExplorer), value); }
        }
        /// <summary>Value indicating if execution of executable content (exe, dll, ps, js, vbs, etc) should be dropped from email (webmail/mail-client). Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderEmailContentExecution {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderEmailContentExecution)); }
            set { BackingStore?.Set(nameof(DefenderEmailContentExecution), value); }
        }
        /// <summary>Value indicating if execution of executable content (exe, dll, ps, js, vbs, etc) should be dropped from email (webmail/mail-client). Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderEmailContentExecutionType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderEmailContentExecutionType)); }
            set { BackingStore?.Set(nameof(DefenderEmailContentExecutionType), value); }
        }
        /// <summary>This policy setting allows you to enable or disable low CPU priority for scheduled scans.</summary>
        public bool? DefenderEnableLowCpuPriority {
            get { return BackingStore?.Get<bool?>(nameof(DefenderEnableLowCpuPriority)); }
            set { BackingStore?.Set(nameof(DefenderEnableLowCpuPriority), value); }
        }
        /// <summary>Allows or disallows scanning of email.</summary>
        public bool? DefenderEnableScanIncomingMail {
            get { return BackingStore?.Get<bool?>(nameof(DefenderEnableScanIncomingMail)); }
            set { BackingStore?.Set(nameof(DefenderEnableScanIncomingMail), value); }
        }
        /// <summary>Allows or disallows a full scan of mapped network drives.</summary>
        public bool? DefenderEnableScanMappedNetworkDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>(nameof(DefenderEnableScanMappedNetworkDrivesDuringFullScan)); }
            set { BackingStore?.Set(nameof(DefenderEnableScanMappedNetworkDrivesDuringFullScan), value); }
        }
        /// <summary>Xml content containing information regarding exploit protection details.</summary>
        public byte[] DefenderExploitProtectionXml {
            get { return BackingStore?.Get<byte[]>(nameof(DefenderExploitProtectionXml)); }
            set { BackingStore?.Set(nameof(DefenderExploitProtectionXml), value); }
        }
        /// <summary>Name of the file from which DefenderExploitProtectionXml was obtained.</summary>
        public string DefenderExploitProtectionXmlFileName {
            get { return BackingStore?.Get<string>(nameof(DefenderExploitProtectionXmlFileName)); }
            set { BackingStore?.Set(nameof(DefenderExploitProtectionXmlFileName), value); }
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
        /// <summary>List of paths to exe that are allowed to access protected folders</summary>
        public List<string> DefenderGuardedFoldersAllowedAppPaths {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderGuardedFoldersAllowedAppPaths)); }
            set { BackingStore?.Set(nameof(DefenderGuardedFoldersAllowedAppPaths), value); }
        }
        /// <summary>Value indicating the behavior of protected folders. Possible values are: userDefined, enable, auditMode, blockDiskModification, auditDiskModification.</summary>
        public FolderProtectionType? DefenderGuardMyFoldersType {
            get { return BackingStore?.Get<FolderProtectionType?>(nameof(DefenderGuardMyFoldersType)); }
            set { BackingStore?.Set(nameof(DefenderGuardMyFoldersType), value); }
        }
        /// <summary>Value indicating the behavior of NetworkProtection. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderNetworkProtectionType {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderNetworkProtectionType)); }
            set { BackingStore?.Set(nameof(DefenderNetworkProtectionType), value); }
        }
        /// <summary>Value indicating the behavior of Office applications/macros creating or launching executable content. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderOfficeAppsExecutableContentCreationOrLaunch {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderOfficeAppsExecutableContentCreationOrLaunch)); }
            set { BackingStore?.Set(nameof(DefenderOfficeAppsExecutableContentCreationOrLaunch), value); }
        }
        /// <summary>Value indicating the behavior of Office applications/macros creating or launching executable content. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderOfficeAppsExecutableContentCreationOrLaunchType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderOfficeAppsExecutableContentCreationOrLaunchType)); }
            set { BackingStore?.Set(nameof(DefenderOfficeAppsExecutableContentCreationOrLaunchType), value); }
        }
        /// <summary>Value indicating the behavior of Office application launching child processes. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderOfficeAppsLaunchChildProcess {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderOfficeAppsLaunchChildProcess)); }
            set { BackingStore?.Set(nameof(DefenderOfficeAppsLaunchChildProcess), value); }
        }
        /// <summary>Value indicating the behavior of Office application launching child processes. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderOfficeAppsLaunchChildProcessType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderOfficeAppsLaunchChildProcessType)); }
            set { BackingStore?.Set(nameof(DefenderOfficeAppsLaunchChildProcessType), value); }
        }
        /// <summary>Value indicating the behavior of  Office applications injecting into other processes. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderOfficeAppsOtherProcessInjection {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderOfficeAppsOtherProcessInjection)); }
            set { BackingStore?.Set(nameof(DefenderOfficeAppsOtherProcessInjection), value); }
        }
        /// <summary>Value indicating the behavior of Office applications injecting into other processes. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderOfficeAppsOtherProcessInjectionType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderOfficeAppsOtherProcessInjectionType)); }
            set { BackingStore?.Set(nameof(DefenderOfficeAppsOtherProcessInjectionType), value); }
        }
        /// <summary>Value indicating the behavior of Office communication applications, including Microsoft Outlook, from creating child processes. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderOfficeCommunicationAppsLaunchChildProcess {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderOfficeCommunicationAppsLaunchChildProcess)); }
            set { BackingStore?.Set(nameof(DefenderOfficeCommunicationAppsLaunchChildProcess), value); }
        }
        /// <summary>Value indicating the behavior of Win32 imports from Macro code in Office. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderOfficeMacroCodeAllowWin32Imports {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderOfficeMacroCodeAllowWin32Imports)); }
            set { BackingStore?.Set(nameof(DefenderOfficeMacroCodeAllowWin32Imports), value); }
        }
        /// <summary>Value indicating the behavior of Win32 imports from Macro code in Office. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderOfficeMacroCodeAllowWin32ImportsType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderOfficeMacroCodeAllowWin32ImportsType)); }
            set { BackingStore?.Set(nameof(DefenderOfficeMacroCodeAllowWin32ImportsType), value); }
        }
        /// <summary>Added in Windows 10, version 1607. Specifies the level of detection for potentially unwanted applications (PUAs). Windows Defender alerts you when potentially unwanted software is being downloaded or attempts to install itself on your computer. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderPotentiallyUnwantedAppAction {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderPotentiallyUnwantedAppAction)); }
            set { BackingStore?.Set(nameof(DefenderPotentiallyUnwantedAppAction), value); }
        }
        /// <summary>Value indicating if credential stealing from the Windows local security authority subsystem is permitted. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderPreventCredentialStealingType {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderPreventCredentialStealingType)); }
            set { BackingStore?.Set(nameof(DefenderPreventCredentialStealingType), value); }
        }
        /// <summary>Value indicating response to process creations originating from PSExec and WMI commands. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderProcessCreation {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderProcessCreation)); }
            set { BackingStore?.Set(nameof(DefenderProcessCreation), value); }
        }
        /// <summary>Value indicating response to process creations originating from PSExec and WMI commands. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderProcessCreationType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderProcessCreationType)); }
            set { BackingStore?.Set(nameof(DefenderProcessCreationType), value); }
        }
        /// <summary>Processes to exclude from scans and real time protection.</summary>
        public List<string> DefenderProcessesToExclude {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderProcessesToExclude)); }
            set { BackingStore?.Set(nameof(DefenderProcessesToExclude), value); }
        }
        /// <summary>Controls which sets of files should be monitored. Possible values are: monitorAllFiles, monitorIncomingFilesOnly, monitorOutgoingFilesOnly.</summary>
        public DefenderRealtimeScanDirection? DefenderScanDirection {
            get { return BackingStore?.Get<DefenderRealtimeScanDirection?>(nameof(DefenderScanDirection)); }
            set { BackingStore?.Set(nameof(DefenderScanDirection), value); }
        }
        /// <summary>Represents the average CPU load factor for the Windows Defender scan (in percent). The default value is 50. Valid values 0 to 100</summary>
        public int? DefenderScanMaxCpuPercentage {
            get { return BackingStore?.Get<int?>(nameof(DefenderScanMaxCpuPercentage)); }
            set { BackingStore?.Set(nameof(DefenderScanMaxCpuPercentage), value); }
        }
        /// <summary>Selects whether to perform a quick scan or full scan. Possible values are: userDefined, disabled, quick, full.</summary>
        public Microsoft.Graph.Beta.Models.DefenderScanType? DefenderScanType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderScanType?>(nameof(DefenderScanType)); }
            set { BackingStore?.Set(nameof(DefenderScanType), value); }
        }
        /// <summary>Selects the time of day that the Windows Defender quick scan should run. For example, a value of 0=12:00AM, a value of 60=1:00AM, a value of 120=2:00, and so on, up to a value of 1380=11:00PM. The default value is 120</summary>
        public Time? DefenderScheduledQuickScanTime {
            get { return BackingStore?.Get<Time?>(nameof(DefenderScheduledQuickScanTime)); }
            set { BackingStore?.Set(nameof(DefenderScheduledQuickScanTime), value); }
        }
        /// <summary>Selects the day that the Windows Defender scan should run. Possible values are: userDefined, everyday, sunday, monday, tuesday, wednesday, thursday, friday, saturday, noScheduledScan.</summary>
        public WeeklySchedule? DefenderScheduledScanDay {
            get { return BackingStore?.Get<WeeklySchedule?>(nameof(DefenderScheduledScanDay)); }
            set { BackingStore?.Set(nameof(DefenderScheduledScanDay), value); }
        }
        /// <summary>Selects the time of day that the Windows Defender scan should run.</summary>
        public Time? DefenderScheduledScanTime {
            get { return BackingStore?.Get<Time?>(nameof(DefenderScheduledScanTime)); }
            set { BackingStore?.Set(nameof(DefenderScheduledScanTime), value); }
        }
        /// <summary>Value indicating the behavior of js/vbs executing payload downloaded from Internet. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderScriptDownloadedPayloadExecution {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderScriptDownloadedPayloadExecution)); }
            set { BackingStore?.Set(nameof(DefenderScriptDownloadedPayloadExecution), value); }
        }
        /// <summary>Value indicating the behavior of js/vbs executing payload downloaded from Internet. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderScriptDownloadedPayloadExecutionType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderScriptDownloadedPayloadExecutionType)); }
            set { BackingStore?.Set(nameof(DefenderScriptDownloadedPayloadExecutionType), value); }
        }
        /// <summary>Value indicating the behavior of obfuscated js/vbs/ps/macro code. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderScriptObfuscatedMacroCode {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderScriptObfuscatedMacroCode)); }
            set { BackingStore?.Set(nameof(DefenderScriptObfuscatedMacroCode), value); }
        }
        /// <summary>Value indicating the behavior of obfuscated js/vbs/ps/macro code. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderScriptObfuscatedMacroCodeType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderScriptObfuscatedMacroCodeType)); }
            set { BackingStore?.Set(nameof(DefenderScriptObfuscatedMacroCodeType), value); }
        }
        /// <summary>Indicates whether or not to block user from overriding Exploit Protection settings.</summary>
        public bool? DefenderSecurityCenterBlockExploitProtectionOverride {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterBlockExploitProtectionOverride)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterBlockExploitProtectionOverride), value); }
        }
        /// <summary>Used to disable the display of the account protection area.</summary>
        public bool? DefenderSecurityCenterDisableAccountUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableAccountUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableAccountUI), value); }
        }
        /// <summary>Used to disable the display of the app and browser protection area.</summary>
        public bool? DefenderSecurityCenterDisableAppBrowserUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableAppBrowserUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableAppBrowserUI), value); }
        }
        /// <summary>Used to disable the display of the Clear TPM button.</summary>
        public bool? DefenderSecurityCenterDisableClearTpmUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableClearTpmUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableClearTpmUI), value); }
        }
        /// <summary>Used to disable the display of the family options area.</summary>
        public bool? DefenderSecurityCenterDisableFamilyUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableFamilyUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableFamilyUI), value); }
        }
        /// <summary>Used to disable the display of the hardware protection area.</summary>
        public bool? DefenderSecurityCenterDisableHardwareUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableHardwareUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableHardwareUI), value); }
        }
        /// <summary>Used to disable the display of the device performance and health area.</summary>
        public bool? DefenderSecurityCenterDisableHealthUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableHealthUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableHealthUI), value); }
        }
        /// <summary>Used to disable the display of the firewall and network protection area.</summary>
        public bool? DefenderSecurityCenterDisableNetworkUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableNetworkUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableNetworkUI), value); }
        }
        /// <summary>Used to disable the display of the notification area control. The user needs to either sign out and sign in or reboot the computer for this setting to take effect.</summary>
        public bool? DefenderSecurityCenterDisableNotificationAreaUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableNotificationAreaUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableNotificationAreaUI), value); }
        }
        /// <summary>Used to disable the display of the ransomware protection area.</summary>
        public bool? DefenderSecurityCenterDisableRansomwareUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableRansomwareUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableRansomwareUI), value); }
        }
        /// <summary>Used to disable the display of the secure boot area under Device security.</summary>
        public bool? DefenderSecurityCenterDisableSecureBootUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableSecureBootUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableSecureBootUI), value); }
        }
        /// <summary>Used to disable the display of the security process troubleshooting under Device security.</summary>
        public bool? DefenderSecurityCenterDisableTroubleshootingUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableTroubleshootingUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableTroubleshootingUI), value); }
        }
        /// <summary>Used to disable the display of the virus and threat protection area.</summary>
        public bool? DefenderSecurityCenterDisableVirusUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableVirusUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableVirusUI), value); }
        }
        /// <summary>Used to disable the display of update TPM Firmware when a vulnerable firmware is detected.</summary>
        public bool? DefenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI), value); }
        }
        /// <summary>The email address that is displayed to users.</summary>
        public string DefenderSecurityCenterHelpEmail {
            get { return BackingStore?.Get<string>(nameof(DefenderSecurityCenterHelpEmail)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterHelpEmail), value); }
        }
        /// <summary>The phone number or Skype ID that is displayed to users.</summary>
        public string DefenderSecurityCenterHelpPhone {
            get { return BackingStore?.Get<string>(nameof(DefenderSecurityCenterHelpPhone)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterHelpPhone), value); }
        }
        /// <summary>The help portal URL this is displayed to users.</summary>
        public string DefenderSecurityCenterHelpURL {
            get { return BackingStore?.Get<string>(nameof(DefenderSecurityCenterHelpURL)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterHelpURL), value); }
        }
        /// <summary>Configure where to display IT contact information to end users. Possible values are: notConfigured, displayInAppAndInNotifications, displayOnlyInApp, displayOnlyInNotifications.</summary>
        public DefenderSecurityCenterITContactDisplayType? DefenderSecurityCenterITContactDisplay {
            get { return BackingStore?.Get<DefenderSecurityCenterITContactDisplayType?>(nameof(DefenderSecurityCenterITContactDisplay)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterITContactDisplay), value); }
        }
        /// <summary>Notifications to show from the displayed areas of app. Possible values are: notConfigured, blockNoncriticalNotifications, blockAllNotifications.</summary>
        public DefenderSecurityCenterNotificationsFromAppType? DefenderSecurityCenterNotificationsFromApp {
            get { return BackingStore?.Get<DefenderSecurityCenterNotificationsFromAppType?>(nameof(DefenderSecurityCenterNotificationsFromApp)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterNotificationsFromApp), value); }
        }
        /// <summary>The company name that is displayed to the users.</summary>
        public string DefenderSecurityCenterOrganizationDisplayName {
            get { return BackingStore?.Get<string>(nameof(DefenderSecurityCenterOrganizationDisplayName)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterOrganizationDisplayName), value); }
        }
        /// <summary>Specifies the interval (in hours) that will be used to check for signatures, so instead of using the ScheduleDay and ScheduleTime the check for new signatures will be set according to the interval. Valid values 0 to 24</summary>
        public int? DefenderSignatureUpdateIntervalInHours {
            get { return BackingStore?.Get<int?>(nameof(DefenderSignatureUpdateIntervalInHours)); }
            set { BackingStore?.Set(nameof(DefenderSignatureUpdateIntervalInHours), value); }
        }
        /// <summary>Checks for the user consent level in Windows Defender to send data. Possible values are: sendSafeSamplesAutomatically, alwaysPrompt, neverSend, sendAllSamplesAutomatically.</summary>
        public Microsoft.Graph.Beta.Models.DefenderSubmitSamplesConsentType? DefenderSubmitSamplesConsentType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderSubmitSamplesConsentType?>(nameof(DefenderSubmitSamplesConsentType)); }
            set { BackingStore?.Set(nameof(DefenderSubmitSamplesConsentType), value); }
        }
        /// <summary>Value indicating response to executables that don&apos;t meet a prevalence, age, or trusted list criteria. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderUntrustedExecutable {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderUntrustedExecutable)); }
            set { BackingStore?.Set(nameof(DefenderUntrustedExecutable), value); }
        }
        /// <summary>Value indicating response to executables that don&apos;t meet a prevalence, age, or trusted list criteria. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderUntrustedExecutableType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderUntrustedExecutableType)); }
            set { BackingStore?.Set(nameof(DefenderUntrustedExecutableType), value); }
        }
        /// <summary>Value indicating response to untrusted and unsigned processes that run from USB. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderUntrustedUSBProcess {
            get { return BackingStore?.Get<DefenderProtectionType?>(nameof(DefenderUntrustedUSBProcess)); }
            set { BackingStore?.Set(nameof(DefenderUntrustedUSBProcess), value); }
        }
        /// <summary>Value indicating response to untrusted and unsigned processes that run from USB. Possible values are: userDefined, block, auditMode, warn, disable.</summary>
        public DefenderAttackSurfaceType? DefenderUntrustedUSBProcessType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>(nameof(DefenderUntrustedUSBProcessType)); }
            set { BackingStore?.Set(nameof(DefenderUntrustedUSBProcessType), value); }
        }
        /// <summary>This property will be deprecated in May 2019 and will be replaced with property DeviceGuardSecureBootWithDMA. Specifies whether Platform Security Level is enabled at next reboot.</summary>
        public bool? DeviceGuardEnableSecureBootWithDMA {
            get { return BackingStore?.Get<bool?>(nameof(DeviceGuardEnableSecureBootWithDMA)); }
            set { BackingStore?.Set(nameof(DeviceGuardEnableSecureBootWithDMA), value); }
        }
        /// <summary>Turns On Virtualization Based Security(VBS).</summary>
        public bool? DeviceGuardEnableVirtualizationBasedSecurity {
            get { return BackingStore?.Get<bool?>(nameof(DeviceGuardEnableVirtualizationBasedSecurity)); }
            set { BackingStore?.Set(nameof(DeviceGuardEnableVirtualizationBasedSecurity), value); }
        }
        /// <summary>Allows the IT admin to configure the launch of System Guard. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? DeviceGuardLaunchSystemGuard {
            get { return BackingStore?.Get<Enablement?>(nameof(DeviceGuardLaunchSystemGuard)); }
            set { BackingStore?.Set(nameof(DeviceGuardLaunchSystemGuard), value); }
        }
        /// <summary>Turn on Credential Guard when Platform Security Level with Secure Boot and Virtualization Based Security are both enabled. Possible values are: notConfigured, enableWithUEFILock, enableWithoutUEFILock, disable.</summary>
        public DeviceGuardLocalSystemAuthorityCredentialGuardType? DeviceGuardLocalSystemAuthorityCredentialGuardSettings {
            get { return BackingStore?.Get<DeviceGuardLocalSystemAuthorityCredentialGuardType?>(nameof(DeviceGuardLocalSystemAuthorityCredentialGuardSettings)); }
            set { BackingStore?.Set(nameof(DeviceGuardLocalSystemAuthorityCredentialGuardSettings), value); }
        }
        /// <summary>Specifies whether Platform Security Level is enabled at next reboot. Possible values are: notConfigured, withoutDMA, withDMA.</summary>
        public SecureBootWithDMAType? DeviceGuardSecureBootWithDMA {
            get { return BackingStore?.Get<SecureBootWithDMAType?>(nameof(DeviceGuardSecureBootWithDMA)); }
            set { BackingStore?.Set(nameof(DeviceGuardSecureBootWithDMA), value); }
        }
        /// <summary>This policy is intended to provide additional security against external DMA capable devices. It allows for more control over the enumeration of external DMA capable devices incompatible with DMA Remapping/device memory isolation and sandboxing. This policy only takes effect when Kernel DMA Protection is supported and enabled by the system firmware. Kernel DMA Protection is a platform feature that cannot be controlled via policy or by end user. It has to be supported by the system at the time of manufacturing. To check if the system supports Kernel DMA Protection, please check the Kernel DMA Protection field in the Summary page of MSINFO32.exe. Possible values are: deviceDefault, blockAll, allowAll.</summary>
        public DmaGuardDeviceEnumerationPolicyType? DmaGuardDeviceEnumerationPolicy {
            get { return BackingStore?.Get<DmaGuardDeviceEnumerationPolicyType?>(nameof(DmaGuardDeviceEnumerationPolicy)); }
            set { BackingStore?.Set(nameof(DmaGuardDeviceEnumerationPolicy), value); }
        }
        /// <summary>Blocks stateful FTP connections to the device</summary>
        public bool? FirewallBlockStatefulFTP {
            get { return BackingStore?.Get<bool?>(nameof(FirewallBlockStatefulFTP)); }
            set { BackingStore?.Set(nameof(FirewallBlockStatefulFTP), value); }
        }
        /// <summary>Specify how the certificate revocation list is to be enforced. Possible values are: deviceDefault, none, attempt, require.</summary>
        public FirewallCertificateRevocationListCheckMethodType? FirewallCertificateRevocationListCheckMethod {
            get { return BackingStore?.Get<FirewallCertificateRevocationListCheckMethodType?>(nameof(FirewallCertificateRevocationListCheckMethod)); }
            set { BackingStore?.Set(nameof(FirewallCertificateRevocationListCheckMethod), value); }
        }
        /// <summary>Configures the idle timeout for security associations, in seconds, from 300 to 3600 inclusive. This is the period after which security associations will expire and be deleted. Valid values 300 to 3600</summary>
        public int? FirewallIdleTimeoutForSecurityAssociationInSeconds {
            get { return BackingStore?.Get<int?>(nameof(FirewallIdleTimeoutForSecurityAssociationInSeconds)); }
            set { BackingStore?.Set(nameof(FirewallIdleTimeoutForSecurityAssociationInSeconds), value); }
        }
        /// <summary>Configures IPSec exemptions to allow both IPv4 and IPv6 DHCP traffic</summary>
        public bool? FirewallIPSecExemptionsAllowDHCP {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsAllowDHCP)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsAllowDHCP), value); }
        }
        /// <summary>Configures IPSec exemptions to allow ICMP</summary>
        public bool? FirewallIPSecExemptionsAllowICMP {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsAllowICMP)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsAllowICMP), value); }
        }
        /// <summary>Configures IPSec exemptions to allow neighbor discovery IPv6 ICMP type-codes</summary>
        public bool? FirewallIPSecExemptionsAllowNeighborDiscovery {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsAllowNeighborDiscovery)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsAllowNeighborDiscovery), value); }
        }
        /// <summary>Configures IPSec exemptions to allow router discovery IPv6 ICMP type-codes</summary>
        public bool? FirewallIPSecExemptionsAllowRouterDiscovery {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsAllowRouterDiscovery)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsAllowRouterDiscovery), value); }
        }
        /// <summary>Configures IPSec exemptions to no exemptions</summary>
        public bool? FirewallIPSecExemptionsNone {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsNone)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsNone), value); }
        }
        /// <summary>If an authentication set is not fully supported by a keying module, direct the module to ignore only unsupported authentication suites rather than the entire set</summary>
        public bool? FirewallMergeKeyingModuleSettings {
            get { return BackingStore?.Get<bool?>(nameof(FirewallMergeKeyingModuleSettings)); }
            set { BackingStore?.Set(nameof(FirewallMergeKeyingModuleSettings), value); }
        }
        /// <summary>Configures how packet queueing should be applied in the tunnel gateway scenario. Possible values are: deviceDefault, disabled, queueInbound, queueOutbound, queueBoth.</summary>
        public FirewallPacketQueueingMethodType? FirewallPacketQueueingMethod {
            get { return BackingStore?.Get<FirewallPacketQueueingMethodType?>(nameof(FirewallPacketQueueingMethod)); }
            set { BackingStore?.Set(nameof(FirewallPacketQueueingMethod), value); }
        }
        /// <summary>Select the preshared key encoding to be used. Possible values are: deviceDefault, none, utF8.</summary>
        public FirewallPreSharedKeyEncodingMethodType? FirewallPreSharedKeyEncodingMethod {
            get { return BackingStore?.Get<FirewallPreSharedKeyEncodingMethodType?>(nameof(FirewallPreSharedKeyEncodingMethod)); }
            set { BackingStore?.Set(nameof(FirewallPreSharedKeyEncodingMethod), value); }
        }
        /// <summary>Configures the firewall profile settings for domain networks</summary>
        public WindowsFirewallNetworkProfile FirewallProfileDomain {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>(nameof(FirewallProfileDomain)); }
            set { BackingStore?.Set(nameof(FirewallProfileDomain), value); }
        }
        /// <summary>Configures the firewall profile settings for private networks</summary>
        public WindowsFirewallNetworkProfile FirewallProfilePrivate {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>(nameof(FirewallProfilePrivate)); }
            set { BackingStore?.Set(nameof(FirewallProfilePrivate), value); }
        }
        /// <summary>Configures the firewall profile settings for public networks</summary>
        public WindowsFirewallNetworkProfile FirewallProfilePublic {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>(nameof(FirewallProfilePublic)); }
            set { BackingStore?.Set(nameof(FirewallProfilePublic), value); }
        }
        /// <summary>Configures the firewall rule settings. This collection can contain a maximum of 150 elements.</summary>
        public List<WindowsFirewallRule> FirewallRules {
            get { return BackingStore?.Get<List<WindowsFirewallRule>>(nameof(FirewallRules)); }
            set { BackingStore?.Set(nameof(FirewallRules), value); }
        }
        /// <summary>This security setting determines which challenge/response authentication protocol is used for network logons. Possible values are: lmAndNltm, lmNtlmAndNtlmV2, lmAndNtlmOnly, lmAndNtlmV2, lmNtlmV2AndNotLm, lmNtlmV2AndNotLmOrNtm.</summary>
        public Microsoft.Graph.Beta.Models.LanManagerAuthenticationLevel? LanManagerAuthenticationLevel {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LanManagerAuthenticationLevel?>(nameof(LanManagerAuthenticationLevel)); }
            set { BackingStore?.Set(nameof(LanManagerAuthenticationLevel), value); }
        }
        /// <summary>If enabled,the SMB client will allow insecure guest logons. If not configured, the SMB client will reject insecure guest logons.</summary>
        public bool? LanManagerWorkstationDisableInsecureGuestLogons {
            get { return BackingStore?.Get<bool?>(nameof(LanManagerWorkstationDisableInsecureGuestLogons)); }
            set { BackingStore?.Set(nameof(LanManagerWorkstationDisableInsecureGuestLogons), value); }
        }
        /// <summary>Define a different account name to be associated with the security identifier (SID) for the account &apos;Administrator&apos;.</summary>
        public string LocalSecurityOptionsAdministratorAccountName {
            get { return BackingStore?.Get<string>(nameof(LocalSecurityOptionsAdministratorAccountName)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAdministratorAccountName), value); }
        }
        /// <summary>Define the behavior of the elevation prompt for admins in Admin Approval Mode. Possible values are: notConfigured, elevateWithoutPrompting, promptForCredentialsOnTheSecureDesktop, promptForConsentOnTheSecureDesktop, promptForCredentials, promptForConsent, promptForConsentForNonWindowsBinaries.</summary>
        public LocalSecurityOptionsAdministratorElevationPromptBehaviorType? LocalSecurityOptionsAdministratorElevationPromptBehavior {
            get { return BackingStore?.Get<LocalSecurityOptionsAdministratorElevationPromptBehaviorType?>(nameof(LocalSecurityOptionsAdministratorElevationPromptBehavior)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAdministratorElevationPromptBehavior), value); }
        }
        /// <summary>This security setting determines whether to allows anonymous users to perform certain activities, such as enumerating the names of domain accounts and network shares.</summary>
        public bool? LocalSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares), value); }
        }
        /// <summary>Block PKU2U authentication requests to this device to use online identities.</summary>
        public bool? LocalSecurityOptionsAllowPKU2UAuthenticationRequests {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsAllowPKU2UAuthenticationRequests)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAllowPKU2UAuthenticationRequests), value); }
        }
        /// <summary>Edit the default Security Descriptor Definition Language string to allow or deny users and groups to make remote calls to the SAM.</summary>
        public string LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager {
            get { return BackingStore?.Get<string>(nameof(LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager), value); }
        }
        /// <summary>UI helper boolean for LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager entity</summary>
        public bool? LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool), value); }
        }
        /// <summary>This security setting determines whether a computer can be shut down without having to log on to Windows.</summary>
        public bool? LocalSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn), value); }
        }
        /// <summary>Allow UIAccess apps to prompt for elevation without using the secure desktop.</summary>
        public bool? LocalSecurityOptionsAllowUIAccessApplicationElevation {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsAllowUIAccessApplicationElevation)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAllowUIAccessApplicationElevation), value); }
        }
        /// <summary>Allow UIAccess apps to prompt for elevation without using the secure desktop.Default is enabled</summary>
        public bool? LocalSecurityOptionsAllowUIAccessApplicationsForSecureLocations {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsAllowUIAccessApplicationsForSecureLocations)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAllowUIAccessApplicationsForSecureLocations), value); }
        }
        /// <summary>Prevent a portable computer from being undocked without having to log in.</summary>
        public bool? LocalSecurityOptionsAllowUndockWithoutHavingToLogon {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsAllowUndockWithoutHavingToLogon)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsAllowUndockWithoutHavingToLogon), value); }
        }
        /// <summary>Prevent users from adding new Microsoft accounts to this computer.</summary>
        public bool? LocalSecurityOptionsBlockMicrosoftAccounts {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsBlockMicrosoftAccounts)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsBlockMicrosoftAccounts), value); }
        }
        /// <summary>Enable Local accounts that are not password protected to log on from locations other than the physical device.Default is enabled</summary>
        public bool? LocalSecurityOptionsBlockRemoteLogonWithBlankPassword {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsBlockRemoteLogonWithBlankPassword)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsBlockRemoteLogonWithBlankPassword), value); }
        }
        /// <summary>Enabling this settings allows only interactively logged on user to access CD-ROM media.</summary>
        public bool? LocalSecurityOptionsBlockRemoteOpticalDriveAccess {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsBlockRemoteOpticalDriveAccess)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsBlockRemoteOpticalDriveAccess), value); }
        }
        /// <summary>Restrict installing printer drivers as part of connecting to a shared printer to admins only.</summary>
        public bool? LocalSecurityOptionsBlockUsersInstallingPrinterDrivers {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsBlockUsersInstallingPrinterDrivers)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsBlockUsersInstallingPrinterDrivers), value); }
        }
        /// <summary>This security setting determines whether the virtual memory pagefile is cleared when the system is shut down.</summary>
        public bool? LocalSecurityOptionsClearVirtualMemoryPageFile {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsClearVirtualMemoryPageFile)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsClearVirtualMemoryPageFile), value); }
        }
        /// <summary>This security setting determines whether packet signing is required by the SMB client component.</summary>
        public bool? LocalSecurityOptionsClientDigitallySignCommunicationsAlways {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsClientDigitallySignCommunicationsAlways)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsClientDigitallySignCommunicationsAlways), value); }
        }
        /// <summary>If this security setting is enabled, the Server Message Block (SMB) redirector is allowed to send plaintext passwords to non-Microsoft SMB servers that do not support password encryption during authentication.</summary>
        public bool? LocalSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers), value); }
        }
        /// <summary>App installations requiring elevated privileges will prompt for admin credentials.Default is enabled</summary>
        public bool? LocalSecurityOptionsDetectApplicationInstallationsAndPromptForElevation {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDetectApplicationInstallationsAndPromptForElevation)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDetectApplicationInstallationsAndPromptForElevation), value); }
        }
        /// <summary>Determines whether the Local Administrator account is enabled or disabled.</summary>
        public bool? LocalSecurityOptionsDisableAdministratorAccount {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDisableAdministratorAccount)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDisableAdministratorAccount), value); }
        }
        /// <summary>This security setting determines whether the SMB client attempts to negotiate SMB packet signing.</summary>
        public bool? LocalSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees), value); }
        }
        /// <summary>Determines if the Guest account is enabled or disabled.</summary>
        public bool? LocalSecurityOptionsDisableGuestAccount {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDisableGuestAccount)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDisableGuestAccount), value); }
        }
        /// <summary>This security setting determines whether packet signing is required by the SMB server component.</summary>
        public bool? LocalSecurityOptionsDisableServerDigitallySignCommunicationsAlways {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDisableServerDigitallySignCommunicationsAlways)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDisableServerDigitallySignCommunicationsAlways), value); }
        }
        /// <summary>This security setting determines whether the SMB server will negotiate SMB packet signing with clients that request it.</summary>
        public bool? LocalSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees), value); }
        }
        /// <summary>This security setting determines what additional permissions will be granted for anonymous connections to the computer.</summary>
        public bool? LocalSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts), value); }
        }
        /// <summary>Require CTRL+ALT+DEL to be pressed before a user can log on.</summary>
        public bool? LocalSecurityOptionsDoNotRequireCtrlAltDel {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDoNotRequireCtrlAltDel)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDoNotRequireCtrlAltDel), value); }
        }
        /// <summary>This security setting determines if, at the next password change, the LAN Manager (LM) hash value for the new password is stored. It’s not stored by default.</summary>
        public bool? LocalSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange), value); }
        }
        /// <summary>Define who is allowed to format and eject removable NTFS media. Possible values are: notConfigured, administrators, administratorsAndPowerUsers, administratorsAndInteractiveUsers.</summary>
        public LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType? LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser {
            get { return BackingStore?.Get<LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType?>(nameof(LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser), value); }
        }
        /// <summary>Define a different account name to be associated with the security identifier (SID) for the account &apos;Guest&apos;.</summary>
        public string LocalSecurityOptionsGuestAccountName {
            get { return BackingStore?.Get<string>(nameof(LocalSecurityOptionsGuestAccountName)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsGuestAccountName), value); }
        }
        /// <summary>Do not display the username of the last person who signed in on this device.</summary>
        public bool? LocalSecurityOptionsHideLastSignedInUser {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsHideLastSignedInUser)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsHideLastSignedInUser), value); }
        }
        /// <summary>Do not display the username of the person signing in to this device after credentials are entered and before the device’s desktop is shown.</summary>
        public bool? LocalSecurityOptionsHideUsernameAtSignIn {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsHideUsernameAtSignIn)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsHideUsernameAtSignIn), value); }
        }
        /// <summary>Configure the user information that is displayed when the session is locked. If not configured, user display name, domain and username are shown. Possible values are: notConfigured, administrators, administratorsAndPowerUsers, administratorsAndInteractiveUsers.</summary>
        public LocalSecurityOptionsInformationDisplayedOnLockScreenType? LocalSecurityOptionsInformationDisplayedOnLockScreen {
            get { return BackingStore?.Get<LocalSecurityOptionsInformationDisplayedOnLockScreenType?>(nameof(LocalSecurityOptionsInformationDisplayedOnLockScreen)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsInformationDisplayedOnLockScreen), value); }
        }
        /// <summary>Configure the user information that is displayed when the session is locked. If not configured, user display name, domain and username are shown. Possible values are: notConfigured, userDisplayNameDomainUser, userDisplayNameOnly, doNotDisplayUser.</summary>
        public LocalSecurityOptionsInformationShownOnLockScreenType? LocalSecurityOptionsInformationShownOnLockScreen {
            get { return BackingStore?.Get<LocalSecurityOptionsInformationShownOnLockScreenType?>(nameof(LocalSecurityOptionsInformationShownOnLockScreen)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsInformationShownOnLockScreen), value); }
        }
        /// <summary>Set message text for users attempting to log in.</summary>
        public string LocalSecurityOptionsLogOnMessageText {
            get { return BackingStore?.Get<string>(nameof(LocalSecurityOptionsLogOnMessageText)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsLogOnMessageText), value); }
        }
        /// <summary>Set message title for users attempting to log in.</summary>
        public string LocalSecurityOptionsLogOnMessageTitle {
            get { return BackingStore?.Get<string>(nameof(LocalSecurityOptionsLogOnMessageTitle)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsLogOnMessageTitle), value); }
        }
        /// <summary>Define maximum minutes of inactivity on the interactive desktop’s login screen until the screen saver runs. Valid values 0 to 9999</summary>
        public int? LocalSecurityOptionsMachineInactivityLimit {
            get { return BackingStore?.Get<int?>(nameof(LocalSecurityOptionsMachineInactivityLimit)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsMachineInactivityLimit), value); }
        }
        /// <summary>Define maximum minutes of inactivity on the interactive desktop’s login screen until the screen saver runs. Valid values 0 to 9999</summary>
        public int? LocalSecurityOptionsMachineInactivityLimitInMinutes {
            get { return BackingStore?.Get<int?>(nameof(LocalSecurityOptionsMachineInactivityLimitInMinutes)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsMachineInactivityLimitInMinutes), value); }
        }
        /// <summary>This security setting allows a client to require the negotiation of 128-bit encryption and/or NTLMv2 session security. Possible values are: none, requireNtmlV2SessionSecurity, require128BitEncryption, ntlmV2And128BitEncryption.</summary>
        public LocalSecurityOptionsMinimumSessionSecurity? LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients {
            get { return BackingStore?.Get<LocalSecurityOptionsMinimumSessionSecurity?>(nameof(LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients), value); }
        }
        /// <summary>This security setting allows a server to require the negotiation of 128-bit encryption and/or NTLMv2 session security. Possible values are: none, requireNtmlV2SessionSecurity, require128BitEncryption, ntlmV2And128BitEncryption.</summary>
        public LocalSecurityOptionsMinimumSessionSecurity? LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers {
            get { return BackingStore?.Get<LocalSecurityOptionsMinimumSessionSecurity?>(nameof(LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers), value); }
        }
        /// <summary>Enforce PKI certification path validation for a given executable file before it is permitted to run.</summary>
        public bool? LocalSecurityOptionsOnlyElevateSignedExecutables {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsOnlyElevateSignedExecutables)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsOnlyElevateSignedExecutables), value); }
        }
        /// <summary>By default, this security setting restricts anonymous access to shares and pipes to the settings for named pipes that can be accessed anonymously and Shares that can be accessed anonymously</summary>
        public bool? LocalSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares), value); }
        }
        /// <summary>This security setting determines what happens when the smart card for a logged-on user is removed from the smart card reader. Possible values are: noAction, lockWorkstation, forceLogoff, disconnectRemoteDesktopSession.</summary>
        public LocalSecurityOptionsSmartCardRemovalBehaviorType? LocalSecurityOptionsSmartCardRemovalBehavior {
            get { return BackingStore?.Get<LocalSecurityOptionsSmartCardRemovalBehaviorType?>(nameof(LocalSecurityOptionsSmartCardRemovalBehavior)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsSmartCardRemovalBehavior), value); }
        }
        /// <summary>Define the behavior of the elevation prompt for standard users. Possible values are: notConfigured, automaticallyDenyElevationRequests, promptForCredentialsOnTheSecureDesktop, promptForCredentials.</summary>
        public LocalSecurityOptionsStandardUserElevationPromptBehaviorType? LocalSecurityOptionsStandardUserElevationPromptBehavior {
            get { return BackingStore?.Get<LocalSecurityOptionsStandardUserElevationPromptBehaviorType?>(nameof(LocalSecurityOptionsStandardUserElevationPromptBehavior)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsStandardUserElevationPromptBehavior), value); }
        }
        /// <summary>Enable all elevation requests to go to the interactive user&apos;s desktop rather than the secure desktop. Prompt behavior policy settings for admins and standard users are used.</summary>
        public bool? LocalSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation), value); }
        }
        /// <summary>Defines whether the built-in admin account uses Admin Approval Mode or runs all apps with full admin privileges.Default is enabled</summary>
        public bool? LocalSecurityOptionsUseAdminApprovalMode {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsUseAdminApprovalMode)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsUseAdminApprovalMode), value); }
        }
        /// <summary>Define whether Admin Approval Mode and all UAC policy settings are enabled, default is enabled</summary>
        public bool? LocalSecurityOptionsUseAdminApprovalModeForAdministrators {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsUseAdminApprovalModeForAdministrators)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsUseAdminApprovalModeForAdministrators), value); }
        }
        /// <summary>Virtualize file and registry write failures to per user locations</summary>
        public bool? LocalSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations {
            get { return BackingStore?.Get<bool?>(nameof(LocalSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations)); }
            set { BackingStore?.Set(nameof(LocalSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations), value); }
        }
        /// <summary>Allows IT Admins to control whether users can can ignore SmartScreen warnings and run malicious files.</summary>
        public bool? SmartScreenBlockOverrideForFiles {
            get { return BackingStore?.Get<bool?>(nameof(SmartScreenBlockOverrideForFiles)); }
            set { BackingStore?.Set(nameof(SmartScreenBlockOverrideForFiles), value); }
        }
        /// <summary>Allows IT Admins to configure SmartScreen for Windows.</summary>
        public bool? SmartScreenEnableInShell {
            get { return BackingStore?.Get<bool?>(nameof(SmartScreenEnableInShell)); }
            set { BackingStore?.Set(nameof(SmartScreenEnableInShell), value); }
        }
        /// <summary>This user right is used by Credential Manager during Backup/Restore. Users&apos; saved credentials might be compromised if this privilege is given to other entities. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsAccessCredentialManagerAsTrustedCaller {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsAccessCredentialManagerAsTrustedCaller)); }
            set { BackingStore?.Set(nameof(UserRightsAccessCredentialManagerAsTrustedCaller), value); }
        }
        /// <summary>This user right allows a process to impersonate any user without authentication. The process can therefore gain access to the same local resources as that user. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsActAsPartOfTheOperatingSystem {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsActAsPartOfTheOperatingSystem)); }
            set { BackingStore?.Set(nameof(UserRightsActAsPartOfTheOperatingSystem), value); }
        }
        /// <summary>This user right determines which users and groups are allowed to connect to the computer over the network. State Allowed is supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsAllowAccessFromNetwork {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsAllowAccessFromNetwork)); }
            set { BackingStore?.Set(nameof(UserRightsAllowAccessFromNetwork), value); }
        }
        /// <summary>This user right determines which users can bypass file, directory, registry, and other persistent objects permissions when backing up files and directories. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsBackupData {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsBackupData)); }
            set { BackingStore?.Set(nameof(UserRightsBackupData), value); }
        }
        /// <summary>This user right determines which users and groups are block from connecting to the computer over the network. State Block is supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsBlockAccessFromNetwork {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsBlockAccessFromNetwork)); }
            set { BackingStore?.Set(nameof(UserRightsBlockAccessFromNetwork), value); }
        }
        /// <summary>This user right determines which users and groups can change the time and date on the internal clock of the computer. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsChangeSystemTime {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsChangeSystemTime)); }
            set { BackingStore?.Set(nameof(UserRightsChangeSystemTime), value); }
        }
        /// <summary>This security setting determines whether users can create global objects that are available to all sessions. Users who can create global objects could affect processes that run under other users&apos; sessions, which could lead to application failure or data corruption. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsCreateGlobalObjects {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsCreateGlobalObjects)); }
            set { BackingStore?.Set(nameof(UserRightsCreateGlobalObjects), value); }
        }
        /// <summary>This user right determines which users and groups can call an internal API to create and change the size of a page file. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsCreatePageFile {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsCreatePageFile)); }
            set { BackingStore?.Set(nameof(UserRightsCreatePageFile), value); }
        }
        /// <summary>This user right determines which accounts can be used by processes to create a directory object using the object manager. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsCreatePermanentSharedObjects {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsCreatePermanentSharedObjects)); }
            set { BackingStore?.Set(nameof(UserRightsCreatePermanentSharedObjects), value); }
        }
        /// <summary>This user right determines if the user can create a symbolic link from the computer to which they are logged on. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsCreateSymbolicLinks {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsCreateSymbolicLinks)); }
            set { BackingStore?.Set(nameof(UserRightsCreateSymbolicLinks), value); }
        }
        /// <summary>This user right determines which users/groups can be used by processes to create a token that can then be used to get access to any local resources when the process uses an internal API to create an access token. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsCreateToken {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsCreateToken)); }
            set { BackingStore?.Set(nameof(UserRightsCreateToken), value); }
        }
        /// <summary>This user right determines which users can attach a debugger to any process or to the kernel. Only states NotConfigured and Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsDebugPrograms {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsDebugPrograms)); }
            set { BackingStore?.Set(nameof(UserRightsDebugPrograms), value); }
        }
        /// <summary>This user right determines which users can set the Trusted for Delegation setting on a user or computer object. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsDelegation {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsDelegation)); }
            set { BackingStore?.Set(nameof(UserRightsDelegation), value); }
        }
        /// <summary>This user right determines which users cannot log on to the computer. States NotConfigured, Blocked are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsDenyLocalLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsDenyLocalLogOn)); }
            set { BackingStore?.Set(nameof(UserRightsDenyLocalLogOn), value); }
        }
        /// <summary>This user right determines which accounts can be used by a process to add entries to the security log. The security log is used to trace unauthorized system access.  Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsGenerateSecurityAudits {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsGenerateSecurityAudits)); }
            set { BackingStore?.Set(nameof(UserRightsGenerateSecurityAudits), value); }
        }
        /// <summary>Assigning this user right to a user allows programs running on behalf of that user to impersonate a client. Requiring this user right for this kind of impersonation prevents an unauthorized user from convincing a client to connect to a service that they have created and then impersonating that client, which can elevate the unauthorized user&apos;s permissions to administrative or system levels. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsImpersonateClient {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsImpersonateClient)); }
            set { BackingStore?.Set(nameof(UserRightsImpersonateClient), value); }
        }
        /// <summary>This user right determines which accounts can use a process with Write Property access to another process to increase the execution priority assigned to the other process. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsIncreaseSchedulingPriority {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsIncreaseSchedulingPriority)); }
            set { BackingStore?.Set(nameof(UserRightsIncreaseSchedulingPriority), value); }
        }
        /// <summary>This user right determines which users can dynamically load and unload device drivers or other code in to kernel mode. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsLoadUnloadDrivers {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsLoadUnloadDrivers)); }
            set { BackingStore?.Set(nameof(UserRightsLoadUnloadDrivers), value); }
        }
        /// <summary>This user right determines which users can log on to the computer. States NotConfigured, Allowed are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsLocalLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsLocalLogOn)); }
            set { BackingStore?.Set(nameof(UserRightsLocalLogOn), value); }
        }
        /// <summary>This user right determines which accounts can use a process to keep data in physical memory, which prevents the system from paging the data to virtual memory on disk. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsLockMemory {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsLockMemory)); }
            set { BackingStore?.Set(nameof(UserRightsLockMemory), value); }
        }
        /// <summary>This user right determines which users can specify object access auditing options for individual resources, such as files, Active Directory objects, and registry keys. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsManageAuditingAndSecurityLogs {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsManageAuditingAndSecurityLogs)); }
            set { BackingStore?.Set(nameof(UserRightsManageAuditingAndSecurityLogs), value); }
        }
        /// <summary>This user right determines which users and groups can run maintenance tasks on a volume, such as remote defragmentation. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsManageVolumes {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsManageVolumes)); }
            set { BackingStore?.Set(nameof(UserRightsManageVolumes), value); }
        }
        /// <summary>This user right determines who can modify firmware environment values. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsModifyFirmwareEnvironment {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsModifyFirmwareEnvironment)); }
            set { BackingStore?.Set(nameof(UserRightsModifyFirmwareEnvironment), value); }
        }
        /// <summary>This user right determines which user accounts can modify the integrity label of objects, such as files, registry keys, or processes owned by other users. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsModifyObjectLabels {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsModifyObjectLabels)); }
            set { BackingStore?.Set(nameof(UserRightsModifyObjectLabels), value); }
        }
        /// <summary>This user right determines which users can use performance monitoring tools to monitor the performance of system processes. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsProfileSingleProcess {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsProfileSingleProcess)); }
            set { BackingStore?.Set(nameof(UserRightsProfileSingleProcess), value); }
        }
        /// <summary>This user right determines which users and groups are prohibited from logging on as a Remote Desktop Services client. Only states NotConfigured and Blocked are supported</summary>
        public DeviceManagementUserRightsSetting UserRightsRemoteDesktopServicesLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsRemoteDesktopServicesLogOn)); }
            set { BackingStore?.Set(nameof(UserRightsRemoteDesktopServicesLogOn), value); }
        }
        /// <summary>This user right determines which users are allowed to shut down a computer from a remote location on the network. Misuse of this user right can result in a denial of service. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsRemoteShutdown {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsRemoteShutdown)); }
            set { BackingStore?.Set(nameof(UserRightsRemoteShutdown), value); }
        }
        /// <summary>This user right determines which users can bypass file, directory, registry, and other persistent objects permissions when restoring backed up files and directories, and determines which users can set any valid security principal as the owner of an object. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsRestoreData {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsRestoreData)); }
            set { BackingStore?.Set(nameof(UserRightsRestoreData), value); }
        }
        /// <summary>This user right determines which users can take ownership of any securable object in the system, including Active Directory objects, files and folders, printers, registry keys, processes, and threads. Only states NotConfigured and Allowed are supported.</summary>
        public DeviceManagementUserRightsSetting UserRightsTakeOwnership {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>(nameof(UserRightsTakeOwnership)); }
            set { BackingStore?.Set(nameof(UserRightsTakeOwnership), value); }
        }
        /// <summary>Configure windows defender TamperProtection settings. Possible values are: notConfigured, enable, disable.</summary>
        public WindowsDefenderTamperProtectionOptions? WindowsDefenderTamperProtection {
            get { return BackingStore?.Get<WindowsDefenderTamperProtectionOptions?>(nameof(WindowsDefenderTamperProtection)); }
            set { BackingStore?.Set(nameof(WindowsDefenderTamperProtection), value); }
        }
        /// <summary>This setting determines whether the Accessory management service&apos;s start type is Automatic(2), Manual(3), Disabled(4). Default: Manual. Possible values are: manual, automatic, disabled.</summary>
        public ServiceStartType? XboxServicesAccessoryManagementServiceStartupMode {
            get { return BackingStore?.Get<ServiceStartType?>(nameof(XboxServicesAccessoryManagementServiceStartupMode)); }
            set { BackingStore?.Set(nameof(XboxServicesAccessoryManagementServiceStartupMode), value); }
        }
        /// <summary>This setting determines whether xbox game save is enabled (1) or disabled (0).</summary>
        public bool? XboxServicesEnableXboxGameSaveTask {
            get { return BackingStore?.Get<bool?>(nameof(XboxServicesEnableXboxGameSaveTask)); }
            set { BackingStore?.Set(nameof(XboxServicesEnableXboxGameSaveTask), value); }
        }
        /// <summary>This setting determines whether Live Auth Manager service&apos;s start type is Automatic(2), Manual(3), Disabled(4). Default: Manual. Possible values are: manual, automatic, disabled.</summary>
        public ServiceStartType? XboxServicesLiveAuthManagerServiceStartupMode {
            get { return BackingStore?.Get<ServiceStartType?>(nameof(XboxServicesLiveAuthManagerServiceStartupMode)); }
            set { BackingStore?.Set(nameof(XboxServicesLiveAuthManagerServiceStartupMode), value); }
        }
        /// <summary>This setting determines whether Live Game save service&apos;s start type is Automatic(2), Manual(3), Disabled(4). Default: Manual. Possible values are: manual, automatic, disabled.</summary>
        public ServiceStartType? XboxServicesLiveGameSaveServiceStartupMode {
            get { return BackingStore?.Get<ServiceStartType?>(nameof(XboxServicesLiveGameSaveServiceStartupMode)); }
            set { BackingStore?.Set(nameof(XboxServicesLiveGameSaveServiceStartupMode), value); }
        }
        /// <summary>This setting determines whether Networking service&apos;s start type is Automatic(2), Manual(3), Disabled(4). Default: Manual. Possible values are: manual, automatic, disabled.</summary>
        public ServiceStartType? XboxServicesLiveNetworkingServiceStartupMode {
            get { return BackingStore?.Get<ServiceStartType?>(nameof(XboxServicesLiveNetworkingServiceStartupMode)); }
            set { BackingStore?.Set(nameof(XboxServicesLiveNetworkingServiceStartupMode), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10EndpointProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EndpointProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationGuardAllowCameraMicrophoneRedirection", n => { ApplicationGuardAllowCameraMicrophoneRedirection = n.GetBoolValue(); } },
                {"applicationGuardAllowFileSaveOnHost", n => { ApplicationGuardAllowFileSaveOnHost = n.GetBoolValue(); } },
                {"applicationGuardAllowPersistence", n => { ApplicationGuardAllowPersistence = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToLocalPrinters", n => { ApplicationGuardAllowPrintToLocalPrinters = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToNetworkPrinters", n => { ApplicationGuardAllowPrintToNetworkPrinters = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToPDF", n => { ApplicationGuardAllowPrintToPDF = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToXPS", n => { ApplicationGuardAllowPrintToXPS = n.GetBoolValue(); } },
                {"applicationGuardAllowVirtualGPU", n => { ApplicationGuardAllowVirtualGPU = n.GetBoolValue(); } },
                {"applicationGuardBlockClipboardSharing", n => { ApplicationGuardBlockClipboardSharing = n.GetEnumValue<ApplicationGuardBlockClipboardSharingType>(); } },
                {"applicationGuardBlockFileTransfer", n => { ApplicationGuardBlockFileTransfer = n.GetEnumValue<ApplicationGuardBlockFileTransferType>(); } },
                {"applicationGuardBlockNonEnterpriseContent", n => { ApplicationGuardBlockNonEnterpriseContent = n.GetBoolValue(); } },
                {"applicationGuardCertificateThumbprints", n => { ApplicationGuardCertificateThumbprints = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"applicationGuardEnabled", n => { ApplicationGuardEnabled = n.GetBoolValue(); } },
                {"applicationGuardEnabledOptions", n => { ApplicationGuardEnabledOptions = n.GetEnumValue<ApplicationGuardEnabledOptions>(); } },
                {"applicationGuardForceAuditing", n => { ApplicationGuardForceAuditing = n.GetBoolValue(); } },
                {"appLockerApplicationControl", n => { AppLockerApplicationControl = n.GetEnumValue<AppLockerApplicationControlType>(); } },
                {"bitLockerAllowStandardUserEncryption", n => { BitLockerAllowStandardUserEncryption = n.GetBoolValue(); } },
                {"bitLockerDisableWarningForOtherDiskEncryption", n => { BitLockerDisableWarningForOtherDiskEncryption = n.GetBoolValue(); } },
                {"bitLockerEnableStorageCardEncryptionOnMobile", n => { BitLockerEnableStorageCardEncryptionOnMobile = n.GetBoolValue(); } },
                {"bitLockerEncryptDevice", n => { BitLockerEncryptDevice = n.GetBoolValue(); } },
                {"bitLockerFixedDrivePolicy", n => { BitLockerFixedDrivePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy>(Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy.CreateFromDiscriminatorValue); } },
                {"bitLockerRecoveryPasswordRotation", n => { BitLockerRecoveryPasswordRotation = n.GetEnumValue<BitLockerRecoveryPasswordRotationType>(); } },
                {"bitLockerRemovableDrivePolicy", n => { BitLockerRemovableDrivePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy>(Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy.CreateFromDiscriminatorValue); } },
                {"bitLockerSystemDrivePolicy", n => { BitLockerSystemDrivePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy>(Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy.CreateFromDiscriminatorValue); } },
                {"defenderAdditionalGuardedFolders", n => { DefenderAdditionalGuardedFolders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderAdobeReaderLaunchChildProcess", n => { DefenderAdobeReaderLaunchChildProcess = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderAdvancedRansomewareProtectionType", n => { DefenderAdvancedRansomewareProtectionType = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderAllowBehaviorMonitoring", n => { DefenderAllowBehaviorMonitoring = n.GetBoolValue(); } },
                {"defenderAllowCloudProtection", n => { DefenderAllowCloudProtection = n.GetBoolValue(); } },
                {"defenderAllowEndUserAccess", n => { DefenderAllowEndUserAccess = n.GetBoolValue(); } },
                {"defenderAllowIntrusionPreventionSystem", n => { DefenderAllowIntrusionPreventionSystem = n.GetBoolValue(); } },
                {"defenderAllowOnAccessProtection", n => { DefenderAllowOnAccessProtection = n.GetBoolValue(); } },
                {"defenderAllowRealTimeMonitoring", n => { DefenderAllowRealTimeMonitoring = n.GetBoolValue(); } },
                {"defenderAllowScanArchiveFiles", n => { DefenderAllowScanArchiveFiles = n.GetBoolValue(); } },
                {"defenderAllowScanDownloads", n => { DefenderAllowScanDownloads = n.GetBoolValue(); } },
                {"defenderAllowScanNetworkFiles", n => { DefenderAllowScanNetworkFiles = n.GetBoolValue(); } },
                {"defenderAllowScanRemovableDrivesDuringFullScan", n => { DefenderAllowScanRemovableDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderAllowScanScriptsLoadedInInternetExplorer", n => { DefenderAllowScanScriptsLoadedInInternetExplorer = n.GetBoolValue(); } },
                {"defenderAttackSurfaceReductionExcludedPaths", n => { DefenderAttackSurfaceReductionExcludedPaths = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderBlockEndUserAccess", n => { DefenderBlockEndUserAccess = n.GetBoolValue(); } },
                {"defenderBlockPersistenceThroughWmiType", n => { DefenderBlockPersistenceThroughWmiType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderCheckForSignaturesBeforeRunningScan", n => { DefenderCheckForSignaturesBeforeRunningScan = n.GetBoolValue(); } },
                {"defenderCloudBlockLevel", n => { DefenderCloudBlockLevel = n.GetEnumValue<DefenderCloudBlockLevelType>(); } },
                {"defenderCloudExtendedTimeoutInSeconds", n => { DefenderCloudExtendedTimeoutInSeconds = n.GetIntValue(); } },
                {"defenderDaysBeforeDeletingQuarantinedMalware", n => { DefenderDaysBeforeDeletingQuarantinedMalware = n.GetIntValue(); } },
                {"defenderDetectedMalwareActions", n => { DefenderDetectedMalwareActions = n.GetObjectValue<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>(Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions.CreateFromDiscriminatorValue); } },
                {"defenderDisableBehaviorMonitoring", n => { DefenderDisableBehaviorMonitoring = n.GetBoolValue(); } },
                {"defenderDisableCatchupFullScan", n => { DefenderDisableCatchupFullScan = n.GetBoolValue(); } },
                {"defenderDisableCatchupQuickScan", n => { DefenderDisableCatchupQuickScan = n.GetBoolValue(); } },
                {"defenderDisableCloudProtection", n => { DefenderDisableCloudProtection = n.GetBoolValue(); } },
                {"defenderDisableIntrusionPreventionSystem", n => { DefenderDisableIntrusionPreventionSystem = n.GetBoolValue(); } },
                {"defenderDisableOnAccessProtection", n => { DefenderDisableOnAccessProtection = n.GetBoolValue(); } },
                {"defenderDisableRealTimeMonitoring", n => { DefenderDisableRealTimeMonitoring = n.GetBoolValue(); } },
                {"defenderDisableScanArchiveFiles", n => { DefenderDisableScanArchiveFiles = n.GetBoolValue(); } },
                {"defenderDisableScanDownloads", n => { DefenderDisableScanDownloads = n.GetBoolValue(); } },
                {"defenderDisableScanNetworkFiles", n => { DefenderDisableScanNetworkFiles = n.GetBoolValue(); } },
                {"defenderDisableScanRemovableDrivesDuringFullScan", n => { DefenderDisableScanRemovableDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderDisableScanScriptsLoadedInInternetExplorer", n => { DefenderDisableScanScriptsLoadedInInternetExplorer = n.GetBoolValue(); } },
                {"defenderEmailContentExecution", n => { DefenderEmailContentExecution = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderEmailContentExecutionType", n => { DefenderEmailContentExecutionType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderEnableLowCpuPriority", n => { DefenderEnableLowCpuPriority = n.GetBoolValue(); } },
                {"defenderEnableScanIncomingMail", n => { DefenderEnableScanIncomingMail = n.GetBoolValue(); } },
                {"defenderEnableScanMappedNetworkDrivesDuringFullScan", n => { DefenderEnableScanMappedNetworkDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderExploitProtectionXml", n => { DefenderExploitProtectionXml = n.GetByteArrayValue(); } },
                {"defenderExploitProtectionXmlFileName", n => { DefenderExploitProtectionXmlFileName = n.GetStringValue(); } },
                {"defenderFileExtensionsToExclude", n => { DefenderFileExtensionsToExclude = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderFilesAndFoldersToExclude", n => { DefenderFilesAndFoldersToExclude = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderGuardedFoldersAllowedAppPaths", n => { DefenderGuardedFoldersAllowedAppPaths = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderGuardMyFoldersType", n => { DefenderGuardMyFoldersType = n.GetEnumValue<FolderProtectionType>(); } },
                {"defenderNetworkProtectionType", n => { DefenderNetworkProtectionType = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeAppsExecutableContentCreationOrLaunch", n => { DefenderOfficeAppsExecutableContentCreationOrLaunch = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeAppsExecutableContentCreationOrLaunchType", n => { DefenderOfficeAppsExecutableContentCreationOrLaunchType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderOfficeAppsLaunchChildProcess", n => { DefenderOfficeAppsLaunchChildProcess = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeAppsLaunchChildProcessType", n => { DefenderOfficeAppsLaunchChildProcessType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderOfficeAppsOtherProcessInjection", n => { DefenderOfficeAppsOtherProcessInjection = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeAppsOtherProcessInjectionType", n => { DefenderOfficeAppsOtherProcessInjectionType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderOfficeCommunicationAppsLaunchChildProcess", n => { DefenderOfficeCommunicationAppsLaunchChildProcess = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeMacroCodeAllowWin32Imports", n => { DefenderOfficeMacroCodeAllowWin32Imports = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeMacroCodeAllowWin32ImportsType", n => { DefenderOfficeMacroCodeAllowWin32ImportsType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderPotentiallyUnwantedAppAction", n => { DefenderPotentiallyUnwantedAppAction = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderPreventCredentialStealingType", n => { DefenderPreventCredentialStealingType = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderProcessCreation", n => { DefenderProcessCreation = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderProcessCreationType", n => { DefenderProcessCreationType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderProcessesToExclude", n => { DefenderProcessesToExclude = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderScanDirection", n => { DefenderScanDirection = n.GetEnumValue<DefenderRealtimeScanDirection>(); } },
                {"defenderScanMaxCpuPercentage", n => { DefenderScanMaxCpuPercentage = n.GetIntValue(); } },
                {"defenderScanType", n => { DefenderScanType = n.GetEnumValue<DefenderScanType>(); } },
                {"defenderScheduledQuickScanTime", n => { DefenderScheduledQuickScanTime = n.GetTimeValue(); } },
                {"defenderScheduledScanDay", n => { DefenderScheduledScanDay = n.GetEnumValue<WeeklySchedule>(); } },
                {"defenderScheduledScanTime", n => { DefenderScheduledScanTime = n.GetTimeValue(); } },
                {"defenderScriptDownloadedPayloadExecution", n => { DefenderScriptDownloadedPayloadExecution = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderScriptDownloadedPayloadExecutionType", n => { DefenderScriptDownloadedPayloadExecutionType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderScriptObfuscatedMacroCode", n => { DefenderScriptObfuscatedMacroCode = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderScriptObfuscatedMacroCodeType", n => { DefenderScriptObfuscatedMacroCodeType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderSecurityCenterBlockExploitProtectionOverride", n => { DefenderSecurityCenterBlockExploitProtectionOverride = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableAccountUI", n => { DefenderSecurityCenterDisableAccountUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableAppBrowserUI", n => { DefenderSecurityCenterDisableAppBrowserUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableClearTpmUI", n => { DefenderSecurityCenterDisableClearTpmUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableFamilyUI", n => { DefenderSecurityCenterDisableFamilyUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableHardwareUI", n => { DefenderSecurityCenterDisableHardwareUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableHealthUI", n => { DefenderSecurityCenterDisableHealthUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableNetworkUI", n => { DefenderSecurityCenterDisableNetworkUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableNotificationAreaUI", n => { DefenderSecurityCenterDisableNotificationAreaUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableRansomwareUI", n => { DefenderSecurityCenterDisableRansomwareUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableSecureBootUI", n => { DefenderSecurityCenterDisableSecureBootUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableTroubleshootingUI", n => { DefenderSecurityCenterDisableTroubleshootingUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableVirusUI", n => { DefenderSecurityCenterDisableVirusUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI", n => { DefenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterHelpEmail", n => { DefenderSecurityCenterHelpEmail = n.GetStringValue(); } },
                {"defenderSecurityCenterHelpPhone", n => { DefenderSecurityCenterHelpPhone = n.GetStringValue(); } },
                {"defenderSecurityCenterHelpURL", n => { DefenderSecurityCenterHelpURL = n.GetStringValue(); } },
                {"defenderSecurityCenterITContactDisplay", n => { DefenderSecurityCenterITContactDisplay = n.GetEnumValue<DefenderSecurityCenterITContactDisplayType>(); } },
                {"defenderSecurityCenterNotificationsFromApp", n => { DefenderSecurityCenterNotificationsFromApp = n.GetEnumValue<DefenderSecurityCenterNotificationsFromAppType>(); } },
                {"defenderSecurityCenterOrganizationDisplayName", n => { DefenderSecurityCenterOrganizationDisplayName = n.GetStringValue(); } },
                {"defenderSignatureUpdateIntervalInHours", n => { DefenderSignatureUpdateIntervalInHours = n.GetIntValue(); } },
                {"defenderSubmitSamplesConsentType", n => { DefenderSubmitSamplesConsentType = n.GetEnumValue<DefenderSubmitSamplesConsentType>(); } },
                {"defenderUntrustedExecutable", n => { DefenderUntrustedExecutable = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderUntrustedExecutableType", n => { DefenderUntrustedExecutableType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderUntrustedUSBProcess", n => { DefenderUntrustedUSBProcess = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderUntrustedUSBProcessType", n => { DefenderUntrustedUSBProcessType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"deviceGuardEnableSecureBootWithDMA", n => { DeviceGuardEnableSecureBootWithDMA = n.GetBoolValue(); } },
                {"deviceGuardEnableVirtualizationBasedSecurity", n => { DeviceGuardEnableVirtualizationBasedSecurity = n.GetBoolValue(); } },
                {"deviceGuardLaunchSystemGuard", n => { DeviceGuardLaunchSystemGuard = n.GetEnumValue<Enablement>(); } },
                {"deviceGuardLocalSystemAuthorityCredentialGuardSettings", n => { DeviceGuardLocalSystemAuthorityCredentialGuardSettings = n.GetEnumValue<DeviceGuardLocalSystemAuthorityCredentialGuardType>(); } },
                {"deviceGuardSecureBootWithDMA", n => { DeviceGuardSecureBootWithDMA = n.GetEnumValue<SecureBootWithDMAType>(); } },
                {"dmaGuardDeviceEnumerationPolicy", n => { DmaGuardDeviceEnumerationPolicy = n.GetEnumValue<DmaGuardDeviceEnumerationPolicyType>(); } },
                {"firewallBlockStatefulFTP", n => { FirewallBlockStatefulFTP = n.GetBoolValue(); } },
                {"firewallCertificateRevocationListCheckMethod", n => { FirewallCertificateRevocationListCheckMethod = n.GetEnumValue<FirewallCertificateRevocationListCheckMethodType>(); } },
                {"firewallIdleTimeoutForSecurityAssociationInSeconds", n => { FirewallIdleTimeoutForSecurityAssociationInSeconds = n.GetIntValue(); } },
                {"firewallIPSecExemptionsAllowDHCP", n => { FirewallIPSecExemptionsAllowDHCP = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowICMP", n => { FirewallIPSecExemptionsAllowICMP = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowNeighborDiscovery", n => { FirewallIPSecExemptionsAllowNeighborDiscovery = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowRouterDiscovery", n => { FirewallIPSecExemptionsAllowRouterDiscovery = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsNone", n => { FirewallIPSecExemptionsNone = n.GetBoolValue(); } },
                {"firewallMergeKeyingModuleSettings", n => { FirewallMergeKeyingModuleSettings = n.GetBoolValue(); } },
                {"firewallPacketQueueingMethod", n => { FirewallPacketQueueingMethod = n.GetEnumValue<FirewallPacketQueueingMethodType>(); } },
                {"firewallPreSharedKeyEncodingMethod", n => { FirewallPreSharedKeyEncodingMethod = n.GetEnumValue<FirewallPreSharedKeyEncodingMethodType>(); } },
                {"firewallProfileDomain", n => { FirewallProfileDomain = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallProfilePrivate", n => { FirewallProfilePrivate = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallProfilePublic", n => { FirewallProfilePublic = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallRules", n => { FirewallRules = n.GetCollectionOfObjectValues<WindowsFirewallRule>(WindowsFirewallRule.CreateFromDiscriminatorValue).ToList(); } },
                {"lanManagerAuthenticationLevel", n => { LanManagerAuthenticationLevel = n.GetEnumValue<LanManagerAuthenticationLevel>(); } },
                {"lanManagerWorkstationDisableInsecureGuestLogons", n => { LanManagerWorkstationDisableInsecureGuestLogons = n.GetBoolValue(); } },
                {"localSecurityOptionsAdministratorAccountName", n => { LocalSecurityOptionsAdministratorAccountName = n.GetStringValue(); } },
                {"localSecurityOptionsAdministratorElevationPromptBehavior", n => { LocalSecurityOptionsAdministratorElevationPromptBehavior = n.GetEnumValue<LocalSecurityOptionsAdministratorElevationPromptBehaviorType>(); } },
                {"localSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares", n => { LocalSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowPKU2UAuthenticationRequests", n => { LocalSecurityOptionsAllowPKU2UAuthenticationRequests = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowRemoteCallsToSecurityAccountsManager", n => { LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager = n.GetStringValue(); } },
                {"localSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool", n => { LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn", n => { LocalSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowUIAccessApplicationElevation", n => { LocalSecurityOptionsAllowUIAccessApplicationElevation = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowUIAccessApplicationsForSecureLocations", n => { LocalSecurityOptionsAllowUIAccessApplicationsForSecureLocations = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowUndockWithoutHavingToLogon", n => { LocalSecurityOptionsAllowUndockWithoutHavingToLogon = n.GetBoolValue(); } },
                {"localSecurityOptionsBlockMicrosoftAccounts", n => { LocalSecurityOptionsBlockMicrosoftAccounts = n.GetBoolValue(); } },
                {"localSecurityOptionsBlockRemoteLogonWithBlankPassword", n => { LocalSecurityOptionsBlockRemoteLogonWithBlankPassword = n.GetBoolValue(); } },
                {"localSecurityOptionsBlockRemoteOpticalDriveAccess", n => { LocalSecurityOptionsBlockRemoteOpticalDriveAccess = n.GetBoolValue(); } },
                {"localSecurityOptionsBlockUsersInstallingPrinterDrivers", n => { LocalSecurityOptionsBlockUsersInstallingPrinterDrivers = n.GetBoolValue(); } },
                {"localSecurityOptionsClearVirtualMemoryPageFile", n => { LocalSecurityOptionsClearVirtualMemoryPageFile = n.GetBoolValue(); } },
                {"localSecurityOptionsClientDigitallySignCommunicationsAlways", n => { LocalSecurityOptionsClientDigitallySignCommunicationsAlways = n.GetBoolValue(); } },
                {"localSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers", n => { LocalSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers = n.GetBoolValue(); } },
                {"localSecurityOptionsDetectApplicationInstallationsAndPromptForElevation", n => { LocalSecurityOptionsDetectApplicationInstallationsAndPromptForElevation = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableAdministratorAccount", n => { LocalSecurityOptionsDisableAdministratorAccount = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees", n => { LocalSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableGuestAccount", n => { LocalSecurityOptionsDisableGuestAccount = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableServerDigitallySignCommunicationsAlways", n => { LocalSecurityOptionsDisableServerDigitallySignCommunicationsAlways = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees", n => { LocalSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees = n.GetBoolValue(); } },
                {"localSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts", n => { LocalSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts = n.GetBoolValue(); } },
                {"localSecurityOptionsDoNotRequireCtrlAltDel", n => { LocalSecurityOptionsDoNotRequireCtrlAltDel = n.GetBoolValue(); } },
                {"localSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange", n => { LocalSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange = n.GetBoolValue(); } },
                {"localSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser", n => { LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser = n.GetEnumValue<LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType>(); } },
                {"localSecurityOptionsGuestAccountName", n => { LocalSecurityOptionsGuestAccountName = n.GetStringValue(); } },
                {"localSecurityOptionsHideLastSignedInUser", n => { LocalSecurityOptionsHideLastSignedInUser = n.GetBoolValue(); } },
                {"localSecurityOptionsHideUsernameAtSignIn", n => { LocalSecurityOptionsHideUsernameAtSignIn = n.GetBoolValue(); } },
                {"localSecurityOptionsInformationDisplayedOnLockScreen", n => { LocalSecurityOptionsInformationDisplayedOnLockScreen = n.GetEnumValue<LocalSecurityOptionsInformationDisplayedOnLockScreenType>(); } },
                {"localSecurityOptionsInformationShownOnLockScreen", n => { LocalSecurityOptionsInformationShownOnLockScreen = n.GetEnumValue<LocalSecurityOptionsInformationShownOnLockScreenType>(); } },
                {"localSecurityOptionsLogOnMessageText", n => { LocalSecurityOptionsLogOnMessageText = n.GetStringValue(); } },
                {"localSecurityOptionsLogOnMessageTitle", n => { LocalSecurityOptionsLogOnMessageTitle = n.GetStringValue(); } },
                {"localSecurityOptionsMachineInactivityLimit", n => { LocalSecurityOptionsMachineInactivityLimit = n.GetIntValue(); } },
                {"localSecurityOptionsMachineInactivityLimitInMinutes", n => { LocalSecurityOptionsMachineInactivityLimitInMinutes = n.GetIntValue(); } },
                {"localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients", n => { LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients = n.GetEnumValue<LocalSecurityOptionsMinimumSessionSecurity>(); } },
                {"localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers", n => { LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers = n.GetEnumValue<LocalSecurityOptionsMinimumSessionSecurity>(); } },
                {"localSecurityOptionsOnlyElevateSignedExecutables", n => { LocalSecurityOptionsOnlyElevateSignedExecutables = n.GetBoolValue(); } },
                {"localSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares", n => { LocalSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares = n.GetBoolValue(); } },
                {"localSecurityOptionsSmartCardRemovalBehavior", n => { LocalSecurityOptionsSmartCardRemovalBehavior = n.GetEnumValue<LocalSecurityOptionsSmartCardRemovalBehaviorType>(); } },
                {"localSecurityOptionsStandardUserElevationPromptBehavior", n => { LocalSecurityOptionsStandardUserElevationPromptBehavior = n.GetEnumValue<LocalSecurityOptionsStandardUserElevationPromptBehaviorType>(); } },
                {"localSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation", n => { LocalSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation = n.GetBoolValue(); } },
                {"localSecurityOptionsUseAdminApprovalMode", n => { LocalSecurityOptionsUseAdminApprovalMode = n.GetBoolValue(); } },
                {"localSecurityOptionsUseAdminApprovalModeForAdministrators", n => { LocalSecurityOptionsUseAdminApprovalModeForAdministrators = n.GetBoolValue(); } },
                {"localSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations", n => { LocalSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations = n.GetBoolValue(); } },
                {"smartScreenBlockOverrideForFiles", n => { SmartScreenBlockOverrideForFiles = n.GetBoolValue(); } },
                {"smartScreenEnableInShell", n => { SmartScreenEnableInShell = n.GetBoolValue(); } },
                {"userRightsAccessCredentialManagerAsTrustedCaller", n => { UserRightsAccessCredentialManagerAsTrustedCaller = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsActAsPartOfTheOperatingSystem", n => { UserRightsActAsPartOfTheOperatingSystem = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsAllowAccessFromNetwork", n => { UserRightsAllowAccessFromNetwork = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsBackupData", n => { UserRightsBackupData = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsBlockAccessFromNetwork", n => { UserRightsBlockAccessFromNetwork = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsChangeSystemTime", n => { UserRightsChangeSystemTime = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreateGlobalObjects", n => { UserRightsCreateGlobalObjects = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreatePageFile", n => { UserRightsCreatePageFile = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreatePermanentSharedObjects", n => { UserRightsCreatePermanentSharedObjects = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreateSymbolicLinks", n => { UserRightsCreateSymbolicLinks = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreateToken", n => { UserRightsCreateToken = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsDebugPrograms", n => { UserRightsDebugPrograms = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsDelegation", n => { UserRightsDelegation = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsDenyLocalLogOn", n => { UserRightsDenyLocalLogOn = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsGenerateSecurityAudits", n => { UserRightsGenerateSecurityAudits = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsImpersonateClient", n => { UserRightsImpersonateClient = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsIncreaseSchedulingPriority", n => { UserRightsIncreaseSchedulingPriority = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsLoadUnloadDrivers", n => { UserRightsLoadUnloadDrivers = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsLocalLogOn", n => { UserRightsLocalLogOn = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsLockMemory", n => { UserRightsLockMemory = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsManageAuditingAndSecurityLogs", n => { UserRightsManageAuditingAndSecurityLogs = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsManageVolumes", n => { UserRightsManageVolumes = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsModifyFirmwareEnvironment", n => { UserRightsModifyFirmwareEnvironment = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsModifyObjectLabels", n => { UserRightsModifyObjectLabels = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsProfileSingleProcess", n => { UserRightsProfileSingleProcess = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsRemoteDesktopServicesLogOn", n => { UserRightsRemoteDesktopServicesLogOn = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsRemoteShutdown", n => { UserRightsRemoteShutdown = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsRestoreData", n => { UserRightsRestoreData = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsTakeOwnership", n => { UserRightsTakeOwnership = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"windowsDefenderTamperProtection", n => { WindowsDefenderTamperProtection = n.GetEnumValue<WindowsDefenderTamperProtectionOptions>(); } },
                {"xboxServicesAccessoryManagementServiceStartupMode", n => { XboxServicesAccessoryManagementServiceStartupMode = n.GetEnumValue<ServiceStartType>(); } },
                {"xboxServicesEnableXboxGameSaveTask", n => { XboxServicesEnableXboxGameSaveTask = n.GetBoolValue(); } },
                {"xboxServicesLiveAuthManagerServiceStartupMode", n => { XboxServicesLiveAuthManagerServiceStartupMode = n.GetEnumValue<ServiceStartType>(); } },
                {"xboxServicesLiveGameSaveServiceStartupMode", n => { XboxServicesLiveGameSaveServiceStartupMode = n.GetEnumValue<ServiceStartType>(); } },
                {"xboxServicesLiveNetworkingServiceStartupMode", n => { XboxServicesLiveNetworkingServiceStartupMode = n.GetEnumValue<ServiceStartType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("applicationGuardAllowCameraMicrophoneRedirection", ApplicationGuardAllowCameraMicrophoneRedirection);
            writer.WriteBoolValue("applicationGuardAllowFileSaveOnHost", ApplicationGuardAllowFileSaveOnHost);
            writer.WriteBoolValue("applicationGuardAllowPersistence", ApplicationGuardAllowPersistence);
            writer.WriteBoolValue("applicationGuardAllowPrintToLocalPrinters", ApplicationGuardAllowPrintToLocalPrinters);
            writer.WriteBoolValue("applicationGuardAllowPrintToNetworkPrinters", ApplicationGuardAllowPrintToNetworkPrinters);
            writer.WriteBoolValue("applicationGuardAllowPrintToPDF", ApplicationGuardAllowPrintToPDF);
            writer.WriteBoolValue("applicationGuardAllowPrintToXPS", ApplicationGuardAllowPrintToXPS);
            writer.WriteBoolValue("applicationGuardAllowVirtualGPU", ApplicationGuardAllowVirtualGPU);
            writer.WriteEnumValue<ApplicationGuardBlockClipboardSharingType>("applicationGuardBlockClipboardSharing", ApplicationGuardBlockClipboardSharing);
            writer.WriteEnumValue<ApplicationGuardBlockFileTransferType>("applicationGuardBlockFileTransfer", ApplicationGuardBlockFileTransfer);
            writer.WriteBoolValue("applicationGuardBlockNonEnterpriseContent", ApplicationGuardBlockNonEnterpriseContent);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationGuardCertificateThumbprints", ApplicationGuardCertificateThumbprints);
            writer.WriteBoolValue("applicationGuardEnabled", ApplicationGuardEnabled);
            writer.WriteEnumValue<ApplicationGuardEnabledOptions>("applicationGuardEnabledOptions", ApplicationGuardEnabledOptions);
            writer.WriteBoolValue("applicationGuardForceAuditing", ApplicationGuardForceAuditing);
            writer.WriteEnumValue<AppLockerApplicationControlType>("appLockerApplicationControl", AppLockerApplicationControl);
            writer.WriteBoolValue("bitLockerAllowStandardUserEncryption", BitLockerAllowStandardUserEncryption);
            writer.WriteBoolValue("bitLockerDisableWarningForOtherDiskEncryption", BitLockerDisableWarningForOtherDiskEncryption);
            writer.WriteBoolValue("bitLockerEnableStorageCardEncryptionOnMobile", BitLockerEnableStorageCardEncryptionOnMobile);
            writer.WriteBoolValue("bitLockerEncryptDevice", BitLockerEncryptDevice);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy>("bitLockerFixedDrivePolicy", BitLockerFixedDrivePolicy);
            writer.WriteEnumValue<BitLockerRecoveryPasswordRotationType>("bitLockerRecoveryPasswordRotation", BitLockerRecoveryPasswordRotation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy>("bitLockerRemovableDrivePolicy", BitLockerRemovableDrivePolicy);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy>("bitLockerSystemDrivePolicy", BitLockerSystemDrivePolicy);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderAdditionalGuardedFolders", DefenderAdditionalGuardedFolders);
            writer.WriteEnumValue<DefenderProtectionType>("defenderAdobeReaderLaunchChildProcess", DefenderAdobeReaderLaunchChildProcess);
            writer.WriteEnumValue<DefenderProtectionType>("defenderAdvancedRansomewareProtectionType", DefenderAdvancedRansomewareProtectionType);
            writer.WriteBoolValue("defenderAllowBehaviorMonitoring", DefenderAllowBehaviorMonitoring);
            writer.WriteBoolValue("defenderAllowCloudProtection", DefenderAllowCloudProtection);
            writer.WriteBoolValue("defenderAllowEndUserAccess", DefenderAllowEndUserAccess);
            writer.WriteBoolValue("defenderAllowIntrusionPreventionSystem", DefenderAllowIntrusionPreventionSystem);
            writer.WriteBoolValue("defenderAllowOnAccessProtection", DefenderAllowOnAccessProtection);
            writer.WriteBoolValue("defenderAllowRealTimeMonitoring", DefenderAllowRealTimeMonitoring);
            writer.WriteBoolValue("defenderAllowScanArchiveFiles", DefenderAllowScanArchiveFiles);
            writer.WriteBoolValue("defenderAllowScanDownloads", DefenderAllowScanDownloads);
            writer.WriteBoolValue("defenderAllowScanNetworkFiles", DefenderAllowScanNetworkFiles);
            writer.WriteBoolValue("defenderAllowScanRemovableDrivesDuringFullScan", DefenderAllowScanRemovableDrivesDuringFullScan);
            writer.WriteBoolValue("defenderAllowScanScriptsLoadedInInternetExplorer", DefenderAllowScanScriptsLoadedInInternetExplorer);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderAttackSurfaceReductionExcludedPaths", DefenderAttackSurfaceReductionExcludedPaths);
            writer.WriteBoolValue("defenderBlockEndUserAccess", DefenderBlockEndUserAccess);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderBlockPersistenceThroughWmiType", DefenderBlockPersistenceThroughWmiType);
            writer.WriteBoolValue("defenderCheckForSignaturesBeforeRunningScan", DefenderCheckForSignaturesBeforeRunningScan);
            writer.WriteEnumValue<DefenderCloudBlockLevelType>("defenderCloudBlockLevel", DefenderCloudBlockLevel);
            writer.WriteIntValue("defenderCloudExtendedTimeoutInSeconds", DefenderCloudExtendedTimeoutInSeconds);
            writer.WriteIntValue("defenderDaysBeforeDeletingQuarantinedMalware", DefenderDaysBeforeDeletingQuarantinedMalware);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>("defenderDetectedMalwareActions", DefenderDetectedMalwareActions);
            writer.WriteBoolValue("defenderDisableBehaviorMonitoring", DefenderDisableBehaviorMonitoring);
            writer.WriteBoolValue("defenderDisableCatchupFullScan", DefenderDisableCatchupFullScan);
            writer.WriteBoolValue("defenderDisableCatchupQuickScan", DefenderDisableCatchupQuickScan);
            writer.WriteBoolValue("defenderDisableCloudProtection", DefenderDisableCloudProtection);
            writer.WriteBoolValue("defenderDisableIntrusionPreventionSystem", DefenderDisableIntrusionPreventionSystem);
            writer.WriteBoolValue("defenderDisableOnAccessProtection", DefenderDisableOnAccessProtection);
            writer.WriteBoolValue("defenderDisableRealTimeMonitoring", DefenderDisableRealTimeMonitoring);
            writer.WriteBoolValue("defenderDisableScanArchiveFiles", DefenderDisableScanArchiveFiles);
            writer.WriteBoolValue("defenderDisableScanDownloads", DefenderDisableScanDownloads);
            writer.WriteBoolValue("defenderDisableScanNetworkFiles", DefenderDisableScanNetworkFiles);
            writer.WriteBoolValue("defenderDisableScanRemovableDrivesDuringFullScan", DefenderDisableScanRemovableDrivesDuringFullScan);
            writer.WriteBoolValue("defenderDisableScanScriptsLoadedInInternetExplorer", DefenderDisableScanScriptsLoadedInInternetExplorer);
            writer.WriteEnumValue<DefenderProtectionType>("defenderEmailContentExecution", DefenderEmailContentExecution);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderEmailContentExecutionType", DefenderEmailContentExecutionType);
            writer.WriteBoolValue("defenderEnableLowCpuPriority", DefenderEnableLowCpuPriority);
            writer.WriteBoolValue("defenderEnableScanIncomingMail", DefenderEnableScanIncomingMail);
            writer.WriteBoolValue("defenderEnableScanMappedNetworkDrivesDuringFullScan", DefenderEnableScanMappedNetworkDrivesDuringFullScan);
            writer.WriteByteArrayValue("defenderExploitProtectionXml", DefenderExploitProtectionXml);
            writer.WriteStringValue("defenderExploitProtectionXmlFileName", DefenderExploitProtectionXmlFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderFileExtensionsToExclude", DefenderFileExtensionsToExclude);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderFilesAndFoldersToExclude", DefenderFilesAndFoldersToExclude);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderGuardedFoldersAllowedAppPaths", DefenderGuardedFoldersAllowedAppPaths);
            writer.WriteEnumValue<FolderProtectionType>("defenderGuardMyFoldersType", DefenderGuardMyFoldersType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderNetworkProtectionType", DefenderNetworkProtectionType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeAppsExecutableContentCreationOrLaunch", DefenderOfficeAppsExecutableContentCreationOrLaunch);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderOfficeAppsExecutableContentCreationOrLaunchType", DefenderOfficeAppsExecutableContentCreationOrLaunchType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeAppsLaunchChildProcess", DefenderOfficeAppsLaunchChildProcess);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderOfficeAppsLaunchChildProcessType", DefenderOfficeAppsLaunchChildProcessType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeAppsOtherProcessInjection", DefenderOfficeAppsOtherProcessInjection);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderOfficeAppsOtherProcessInjectionType", DefenderOfficeAppsOtherProcessInjectionType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeCommunicationAppsLaunchChildProcess", DefenderOfficeCommunicationAppsLaunchChildProcess);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeMacroCodeAllowWin32Imports", DefenderOfficeMacroCodeAllowWin32Imports);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderOfficeMacroCodeAllowWin32ImportsType", DefenderOfficeMacroCodeAllowWin32ImportsType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderPotentiallyUnwantedAppAction", DefenderPotentiallyUnwantedAppAction);
            writer.WriteEnumValue<DefenderProtectionType>("defenderPreventCredentialStealingType", DefenderPreventCredentialStealingType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderProcessCreation", DefenderProcessCreation);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderProcessCreationType", DefenderProcessCreationType);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderProcessesToExclude", DefenderProcessesToExclude);
            writer.WriteEnumValue<DefenderRealtimeScanDirection>("defenderScanDirection", DefenderScanDirection);
            writer.WriteIntValue("defenderScanMaxCpuPercentage", DefenderScanMaxCpuPercentage);
            writer.WriteEnumValue<DefenderScanType>("defenderScanType", DefenderScanType);
            writer.WriteTimeValue("defenderScheduledQuickScanTime", DefenderScheduledQuickScanTime);
            writer.WriteEnumValue<WeeklySchedule>("defenderScheduledScanDay", DefenderScheduledScanDay);
            writer.WriteTimeValue("defenderScheduledScanTime", DefenderScheduledScanTime);
            writer.WriteEnumValue<DefenderProtectionType>("defenderScriptDownloadedPayloadExecution", DefenderScriptDownloadedPayloadExecution);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderScriptDownloadedPayloadExecutionType", DefenderScriptDownloadedPayloadExecutionType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderScriptObfuscatedMacroCode", DefenderScriptObfuscatedMacroCode);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderScriptObfuscatedMacroCodeType", DefenderScriptObfuscatedMacroCodeType);
            writer.WriteBoolValue("defenderSecurityCenterBlockExploitProtectionOverride", DefenderSecurityCenterBlockExploitProtectionOverride);
            writer.WriteBoolValue("defenderSecurityCenterDisableAccountUI", DefenderSecurityCenterDisableAccountUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableAppBrowserUI", DefenderSecurityCenterDisableAppBrowserUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableClearTpmUI", DefenderSecurityCenterDisableClearTpmUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableFamilyUI", DefenderSecurityCenterDisableFamilyUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableHardwareUI", DefenderSecurityCenterDisableHardwareUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableHealthUI", DefenderSecurityCenterDisableHealthUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableNetworkUI", DefenderSecurityCenterDisableNetworkUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableNotificationAreaUI", DefenderSecurityCenterDisableNotificationAreaUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableRansomwareUI", DefenderSecurityCenterDisableRansomwareUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableSecureBootUI", DefenderSecurityCenterDisableSecureBootUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableTroubleshootingUI", DefenderSecurityCenterDisableTroubleshootingUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableVirusUI", DefenderSecurityCenterDisableVirusUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI", DefenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI);
            writer.WriteStringValue("defenderSecurityCenterHelpEmail", DefenderSecurityCenterHelpEmail);
            writer.WriteStringValue("defenderSecurityCenterHelpPhone", DefenderSecurityCenterHelpPhone);
            writer.WriteStringValue("defenderSecurityCenterHelpURL", DefenderSecurityCenterHelpURL);
            writer.WriteEnumValue<DefenderSecurityCenterITContactDisplayType>("defenderSecurityCenterITContactDisplay", DefenderSecurityCenterITContactDisplay);
            writer.WriteEnumValue<DefenderSecurityCenterNotificationsFromAppType>("defenderSecurityCenterNotificationsFromApp", DefenderSecurityCenterNotificationsFromApp);
            writer.WriteStringValue("defenderSecurityCenterOrganizationDisplayName", DefenderSecurityCenterOrganizationDisplayName);
            writer.WriteIntValue("defenderSignatureUpdateIntervalInHours", DefenderSignatureUpdateIntervalInHours);
            writer.WriteEnumValue<DefenderSubmitSamplesConsentType>("defenderSubmitSamplesConsentType", DefenderSubmitSamplesConsentType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderUntrustedExecutable", DefenderUntrustedExecutable);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderUntrustedExecutableType", DefenderUntrustedExecutableType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderUntrustedUSBProcess", DefenderUntrustedUSBProcess);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderUntrustedUSBProcessType", DefenderUntrustedUSBProcessType);
            writer.WriteBoolValue("deviceGuardEnableSecureBootWithDMA", DeviceGuardEnableSecureBootWithDMA);
            writer.WriteBoolValue("deviceGuardEnableVirtualizationBasedSecurity", DeviceGuardEnableVirtualizationBasedSecurity);
            writer.WriteEnumValue<Enablement>("deviceGuardLaunchSystemGuard", DeviceGuardLaunchSystemGuard);
            writer.WriteEnumValue<DeviceGuardLocalSystemAuthorityCredentialGuardType>("deviceGuardLocalSystemAuthorityCredentialGuardSettings", DeviceGuardLocalSystemAuthorityCredentialGuardSettings);
            writer.WriteEnumValue<SecureBootWithDMAType>("deviceGuardSecureBootWithDMA", DeviceGuardSecureBootWithDMA);
            writer.WriteEnumValue<DmaGuardDeviceEnumerationPolicyType>("dmaGuardDeviceEnumerationPolicy", DmaGuardDeviceEnumerationPolicy);
            writer.WriteBoolValue("firewallBlockStatefulFTP", FirewallBlockStatefulFTP);
            writer.WriteEnumValue<FirewallCertificateRevocationListCheckMethodType>("firewallCertificateRevocationListCheckMethod", FirewallCertificateRevocationListCheckMethod);
            writer.WriteIntValue("firewallIdleTimeoutForSecurityAssociationInSeconds", FirewallIdleTimeoutForSecurityAssociationInSeconds);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowDHCP", FirewallIPSecExemptionsAllowDHCP);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowICMP", FirewallIPSecExemptionsAllowICMP);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowNeighborDiscovery", FirewallIPSecExemptionsAllowNeighborDiscovery);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowRouterDiscovery", FirewallIPSecExemptionsAllowRouterDiscovery);
            writer.WriteBoolValue("firewallIPSecExemptionsNone", FirewallIPSecExemptionsNone);
            writer.WriteBoolValue("firewallMergeKeyingModuleSettings", FirewallMergeKeyingModuleSettings);
            writer.WriteEnumValue<FirewallPacketQueueingMethodType>("firewallPacketQueueingMethod", FirewallPacketQueueingMethod);
            writer.WriteEnumValue<FirewallPreSharedKeyEncodingMethodType>("firewallPreSharedKeyEncodingMethod", FirewallPreSharedKeyEncodingMethod);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfileDomain", FirewallProfileDomain);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfilePrivate", FirewallProfilePrivate);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfilePublic", FirewallProfilePublic);
            writer.WriteCollectionOfObjectValues<WindowsFirewallRule>("firewallRules", FirewallRules);
            writer.WriteEnumValue<LanManagerAuthenticationLevel>("lanManagerAuthenticationLevel", LanManagerAuthenticationLevel);
            writer.WriteBoolValue("lanManagerWorkstationDisableInsecureGuestLogons", LanManagerWorkstationDisableInsecureGuestLogons);
            writer.WriteStringValue("localSecurityOptionsAdministratorAccountName", LocalSecurityOptionsAdministratorAccountName);
            writer.WriteEnumValue<LocalSecurityOptionsAdministratorElevationPromptBehaviorType>("localSecurityOptionsAdministratorElevationPromptBehavior", LocalSecurityOptionsAdministratorElevationPromptBehavior);
            writer.WriteBoolValue("localSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares", LocalSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares);
            writer.WriteBoolValue("localSecurityOptionsAllowPKU2UAuthenticationRequests", LocalSecurityOptionsAllowPKU2UAuthenticationRequests);
            writer.WriteStringValue("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManager", LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager);
            writer.WriteBoolValue("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool", LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool);
            writer.WriteBoolValue("localSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn", LocalSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn);
            writer.WriteBoolValue("localSecurityOptionsAllowUIAccessApplicationElevation", LocalSecurityOptionsAllowUIAccessApplicationElevation);
            writer.WriteBoolValue("localSecurityOptionsAllowUIAccessApplicationsForSecureLocations", LocalSecurityOptionsAllowUIAccessApplicationsForSecureLocations);
            writer.WriteBoolValue("localSecurityOptionsAllowUndockWithoutHavingToLogon", LocalSecurityOptionsAllowUndockWithoutHavingToLogon);
            writer.WriteBoolValue("localSecurityOptionsBlockMicrosoftAccounts", LocalSecurityOptionsBlockMicrosoftAccounts);
            writer.WriteBoolValue("localSecurityOptionsBlockRemoteLogonWithBlankPassword", LocalSecurityOptionsBlockRemoteLogonWithBlankPassword);
            writer.WriteBoolValue("localSecurityOptionsBlockRemoteOpticalDriveAccess", LocalSecurityOptionsBlockRemoteOpticalDriveAccess);
            writer.WriteBoolValue("localSecurityOptionsBlockUsersInstallingPrinterDrivers", LocalSecurityOptionsBlockUsersInstallingPrinterDrivers);
            writer.WriteBoolValue("localSecurityOptionsClearVirtualMemoryPageFile", LocalSecurityOptionsClearVirtualMemoryPageFile);
            writer.WriteBoolValue("localSecurityOptionsClientDigitallySignCommunicationsAlways", LocalSecurityOptionsClientDigitallySignCommunicationsAlways);
            writer.WriteBoolValue("localSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers", LocalSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers);
            writer.WriteBoolValue("localSecurityOptionsDetectApplicationInstallationsAndPromptForElevation", LocalSecurityOptionsDetectApplicationInstallationsAndPromptForElevation);
            writer.WriteBoolValue("localSecurityOptionsDisableAdministratorAccount", LocalSecurityOptionsDisableAdministratorAccount);
            writer.WriteBoolValue("localSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees", LocalSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees);
            writer.WriteBoolValue("localSecurityOptionsDisableGuestAccount", LocalSecurityOptionsDisableGuestAccount);
            writer.WriteBoolValue("localSecurityOptionsDisableServerDigitallySignCommunicationsAlways", LocalSecurityOptionsDisableServerDigitallySignCommunicationsAlways);
            writer.WriteBoolValue("localSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees", LocalSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees);
            writer.WriteBoolValue("localSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts", LocalSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts);
            writer.WriteBoolValue("localSecurityOptionsDoNotRequireCtrlAltDel", LocalSecurityOptionsDoNotRequireCtrlAltDel);
            writer.WriteBoolValue("localSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange", LocalSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange);
            writer.WriteEnumValue<LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType>("localSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser", LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser);
            writer.WriteStringValue("localSecurityOptionsGuestAccountName", LocalSecurityOptionsGuestAccountName);
            writer.WriteBoolValue("localSecurityOptionsHideLastSignedInUser", LocalSecurityOptionsHideLastSignedInUser);
            writer.WriteBoolValue("localSecurityOptionsHideUsernameAtSignIn", LocalSecurityOptionsHideUsernameAtSignIn);
            writer.WriteEnumValue<LocalSecurityOptionsInformationDisplayedOnLockScreenType>("localSecurityOptionsInformationDisplayedOnLockScreen", LocalSecurityOptionsInformationDisplayedOnLockScreen);
            writer.WriteEnumValue<LocalSecurityOptionsInformationShownOnLockScreenType>("localSecurityOptionsInformationShownOnLockScreen", LocalSecurityOptionsInformationShownOnLockScreen);
            writer.WriteStringValue("localSecurityOptionsLogOnMessageText", LocalSecurityOptionsLogOnMessageText);
            writer.WriteStringValue("localSecurityOptionsLogOnMessageTitle", LocalSecurityOptionsLogOnMessageTitle);
            writer.WriteIntValue("localSecurityOptionsMachineInactivityLimit", LocalSecurityOptionsMachineInactivityLimit);
            writer.WriteIntValue("localSecurityOptionsMachineInactivityLimitInMinutes", LocalSecurityOptionsMachineInactivityLimitInMinutes);
            writer.WriteEnumValue<LocalSecurityOptionsMinimumSessionSecurity>("localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients", LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients);
            writer.WriteEnumValue<LocalSecurityOptionsMinimumSessionSecurity>("localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers", LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers);
            writer.WriteBoolValue("localSecurityOptionsOnlyElevateSignedExecutables", LocalSecurityOptionsOnlyElevateSignedExecutables);
            writer.WriteBoolValue("localSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares", LocalSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares);
            writer.WriteEnumValue<LocalSecurityOptionsSmartCardRemovalBehaviorType>("localSecurityOptionsSmartCardRemovalBehavior", LocalSecurityOptionsSmartCardRemovalBehavior);
            writer.WriteEnumValue<LocalSecurityOptionsStandardUserElevationPromptBehaviorType>("localSecurityOptionsStandardUserElevationPromptBehavior", LocalSecurityOptionsStandardUserElevationPromptBehavior);
            writer.WriteBoolValue("localSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation", LocalSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation);
            writer.WriteBoolValue("localSecurityOptionsUseAdminApprovalMode", LocalSecurityOptionsUseAdminApprovalMode);
            writer.WriteBoolValue("localSecurityOptionsUseAdminApprovalModeForAdministrators", LocalSecurityOptionsUseAdminApprovalModeForAdministrators);
            writer.WriteBoolValue("localSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations", LocalSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations);
            writer.WriteBoolValue("smartScreenBlockOverrideForFiles", SmartScreenBlockOverrideForFiles);
            writer.WriteBoolValue("smartScreenEnableInShell", SmartScreenEnableInShell);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsAccessCredentialManagerAsTrustedCaller", UserRightsAccessCredentialManagerAsTrustedCaller);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsActAsPartOfTheOperatingSystem", UserRightsActAsPartOfTheOperatingSystem);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsAllowAccessFromNetwork", UserRightsAllowAccessFromNetwork);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsBackupData", UserRightsBackupData);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsBlockAccessFromNetwork", UserRightsBlockAccessFromNetwork);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsChangeSystemTime", UserRightsChangeSystemTime);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreateGlobalObjects", UserRightsCreateGlobalObjects);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreatePageFile", UserRightsCreatePageFile);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreatePermanentSharedObjects", UserRightsCreatePermanentSharedObjects);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreateSymbolicLinks", UserRightsCreateSymbolicLinks);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreateToken", UserRightsCreateToken);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsDebugPrograms", UserRightsDebugPrograms);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsDelegation", UserRightsDelegation);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsDenyLocalLogOn", UserRightsDenyLocalLogOn);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsGenerateSecurityAudits", UserRightsGenerateSecurityAudits);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsImpersonateClient", UserRightsImpersonateClient);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsIncreaseSchedulingPriority", UserRightsIncreaseSchedulingPriority);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsLoadUnloadDrivers", UserRightsLoadUnloadDrivers);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsLocalLogOn", UserRightsLocalLogOn);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsLockMemory", UserRightsLockMemory);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsManageAuditingAndSecurityLogs", UserRightsManageAuditingAndSecurityLogs);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsManageVolumes", UserRightsManageVolumes);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsModifyFirmwareEnvironment", UserRightsModifyFirmwareEnvironment);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsModifyObjectLabels", UserRightsModifyObjectLabels);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsProfileSingleProcess", UserRightsProfileSingleProcess);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsRemoteDesktopServicesLogOn", UserRightsRemoteDesktopServicesLogOn);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsRemoteShutdown", UserRightsRemoteShutdown);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsRestoreData", UserRightsRestoreData);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsTakeOwnership", UserRightsTakeOwnership);
            writer.WriteEnumValue<WindowsDefenderTamperProtectionOptions>("windowsDefenderTamperProtection", WindowsDefenderTamperProtection);
            writer.WriteEnumValue<ServiceStartType>("xboxServicesAccessoryManagementServiceStartupMode", XboxServicesAccessoryManagementServiceStartupMode);
            writer.WriteBoolValue("xboxServicesEnableXboxGameSaveTask", XboxServicesEnableXboxGameSaveTask);
            writer.WriteEnumValue<ServiceStartType>("xboxServicesLiveAuthManagerServiceStartupMode", XboxServicesLiveAuthManagerServiceStartupMode);
            writer.WriteEnumValue<ServiceStartType>("xboxServicesLiveGameSaveServiceStartupMode", XboxServicesLiveGameSaveServiceStartupMode);
            writer.WriteEnumValue<ServiceStartType>("xboxServicesLiveNetworkingServiceStartupMode", XboxServicesLiveNetworkingServiceStartupMode);
        }
    }
}
