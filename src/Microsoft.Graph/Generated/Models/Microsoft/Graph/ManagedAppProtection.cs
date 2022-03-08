using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class ManagedAppProtection : ManagedAppPolicy, IParsable {
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<ManagedAppDataIngestionLocation?> AllowedDataIngestionLocations { get; set; }
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<ManagedAppDataStorageLocation?> AllowedDataStorageLocations { get; set; }
        /// <summary>Sources from which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }
        /// <summary>Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of '0' means no exception is allowed.</summary>
        public int? AllowedOutboundClipboardSharingExceptionLength { get; set; }
        /// <summary>The level to which the clipboard may be shared between apps on the managed device. Possible values are: allApps, managedAppsWithPasteIn, managedApps, blocked.</summary>
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }
        /// <summary>Destinations to which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }
        /// <summary>Defines a managed app behavior, either block or wipe, when the device is either rooted or jailbroken, if DeviceComplianceRequired is set to true. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceComplianceRequired { get; set; }
        /// <summary>Defines a managed app behavior, either block or wipe, based on maximum number of incorrect pin retry attempts. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfMaximumPinRetriesExceeded { get; set; }
        /// <summary>If set, it will specify what action to take in the case where the user is unable to checkin because their authentication token is invalid. This happens when the user is deleted or disabled in AAD. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfUnableToAuthenticateUser { get; set; }
        /// <summary>Indicates whether a user can bring data into org documents.</summary>
        public bool? BlockDataIngestionIntoOrganizationDocuments { get; set; }
        /// <summary>Indicates whether contacts can be synced to the user's device.</summary>
        public bool? ContactSyncBlocked { get; set; }
        /// <summary>Indicates whether the backup of a managed app's data is blocked.</summary>
        public bool? DataBackupBlocked { get; set; }
        /// <summary>Indicates whether device compliance is required.</summary>
        public bool? DeviceComplianceRequired { get; set; }
        /// <summary>The classes of dialer apps that are allowed to click-to-open a phone number. Possible values are: allApps, managedApps, customApp, blocked.</summary>
        public ManagedAppPhoneNumberRedirectLevel? DialerRestrictionLevel { get; set; }
        /// <summary>Indicates whether use of the app pin is required if the device pin is set.</summary>
        public bool? DisableAppPinIfDevicePinIsSet { get; set; }
        /// <summary>Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FingerprintBlocked { get; set; }
        /// <summary>A grace period before blocking app access during off clock hours.</summary>
        public TimeSpan? GracePeriodToBlockAppsDuringOffClockHours { get; set; }
        /// <summary>Indicates in which managed browser(s) that internet links should be opened. When this property is configured, ManagedBrowserToOpenLinksRequired should be true. Possible values are: notConfigured, microsoftEdge.</summary>
        public ManagedBrowserType? ManagedBrowser { get; set; }
        /// <summary>Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)</summary>
        public bool? ManagedBrowserToOpenLinksRequired { get; set; }
        /// <summary>Maximum allowed device threat level, as reported by the MTD app. Possible values are: notConfigured, secured, low, medium, high.</summary>
        public ManagedAppDeviceThreatLevel? MaximumAllowedDeviceThreatLevel { get; set; }
        /// <summary>Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</summary>
        public int? MaximumPinRetries { get; set; }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumRequiredOsVersion { get; set; }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumWarningOsVersion { get; set; }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumWipeOsVersion { get; set; }
        /// <summary>Minimum pin length required for an app-level pin if PinRequired is set to True</summary>
        public int? MinimumPinLength { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredAppVersion { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredOsVersion { get; set; }
        /// <summary>Versions less than the specified version will result in warning message on the managed app.</summary>
        public string MinimumWarningAppVersion { get; set; }
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data.</summary>
        public string MinimumWarningOsVersion { get; set; }
        /// <summary>Versions less than or equal to the specified version will wipe the managed app and the associated company data.</summary>
        public string MinimumWipeAppVersion { get; set; }
        /// <summary>Versions less than or equal to the specified version will wipe the managed app and the associated company data.</summary>
        public string MinimumWipeOsVersion { get; set; }
        /// <summary>Determines what action to take if the mobile threat defense threat threshold isn't met. Warn isn't a supported value for this property. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? MobileThreatDefenseRemediationAction { get; set; }
        /// <summary>Specify app notification restriction. Possible values are: allow, blockOrganizationalData, block.</summary>
        public ManagedAppNotificationRestriction? NotificationRestriction { get; set; }
        /// <summary>Indicates whether organizational credentials are required for app use.</summary>
        public bool? OrganizationalCredentialsRequired { get; set; }
        /// <summary>TimePeriod before the all-level pin must be reset if PinRequired is set to True.</summary>
        public TimeSpan? PeriodBeforePinReset { get; set; }
        /// <summary>The period after which access is checked when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeAccessCheck { get; set; }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</summary>
        public TimeSpan? PeriodOfflineBeforeWipeIsEnforced { get; set; }
        /// <summary>The period after which access is checked when the device is connected to the internet.</summary>
        public TimeSpan? PeriodOnlineBeforeAccessCheck { get; set; }
        /// <summary>Character set which may be used for an app-level pin if PinRequired is set to True. Possible values are: numeric, alphanumericAndSymbol.</summary>
        public ManagedAppPinCharacterSet? PinCharacterSet { get; set; }
        /// <summary>Indicates whether an app-level pin is required.</summary>
        public bool? PinRequired { get; set; }
        /// <summary>Timeout in minutes for an app pin instead of non biometrics passcode</summary>
        public TimeSpan? PinRequiredInsteadOfBiometricTimeout { get; set; }
        /// <summary>Requires a pin to be unique from the number specified in this property.</summary>
        public int? PreviousPinBlockCount { get; set; }
        /// <summary>Indicates whether printing is allowed from managed apps.</summary>
        public bool? PrintBlocked { get; set; }
        /// <summary>Indicates whether users may use the 'Save As' menu item to save a copy of protected files.</summary>
        public bool? SaveAsBlocked { get; set; }
        /// <summary>Indicates whether simplePin is blocked.</summary>
        public bool? SimplePinBlocked { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowedDataIngestionLocations", (o,n) => { (o as ManagedAppProtection).AllowedDataIngestionLocations = n.GetCollectionOfEnumValues<ManagedAppDataIngestionLocation>().ToList(); } },
                {"allowedDataStorageLocations", (o,n) => { (o as ManagedAppProtection).AllowedDataStorageLocations = n.GetCollectionOfEnumValues<ManagedAppDataStorageLocation>().ToList(); } },
                {"allowedInboundDataTransferSources", (o,n) => { (o as ManagedAppProtection).AllowedInboundDataTransferSources = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"allowedOutboundClipboardSharingExceptionLength", (o,n) => { (o as ManagedAppProtection).AllowedOutboundClipboardSharingExceptionLength = n.GetIntValue(); } },
                {"allowedOutboundClipboardSharingLevel", (o,n) => { (o as ManagedAppProtection).AllowedOutboundClipboardSharingLevel = n.GetEnumValue<ManagedAppClipboardSharingLevel>(); } },
                {"allowedOutboundDataTransferDestinations", (o,n) => { (o as ManagedAppProtection).AllowedOutboundDataTransferDestinations = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"appActionIfDeviceComplianceRequired", (o,n) => { (o as ManagedAppProtection).AppActionIfDeviceComplianceRequired = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfMaximumPinRetriesExceeded", (o,n) => { (o as ManagedAppProtection).AppActionIfMaximumPinRetriesExceeded = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfUnableToAuthenticateUser", (o,n) => { (o as ManagedAppProtection).AppActionIfUnableToAuthenticateUser = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"blockDataIngestionIntoOrganizationDocuments", (o,n) => { (o as ManagedAppProtection).BlockDataIngestionIntoOrganizationDocuments = n.GetBoolValue(); } },
                {"contactSyncBlocked", (o,n) => { (o as ManagedAppProtection).ContactSyncBlocked = n.GetBoolValue(); } },
                {"dataBackupBlocked", (o,n) => { (o as ManagedAppProtection).DataBackupBlocked = n.GetBoolValue(); } },
                {"deviceComplianceRequired", (o,n) => { (o as ManagedAppProtection).DeviceComplianceRequired = n.GetBoolValue(); } },
                {"dialerRestrictionLevel", (o,n) => { (o as ManagedAppProtection).DialerRestrictionLevel = n.GetEnumValue<ManagedAppPhoneNumberRedirectLevel>(); } },
                {"disableAppPinIfDevicePinIsSet", (o,n) => { (o as ManagedAppProtection).DisableAppPinIfDevicePinIsSet = n.GetBoolValue(); } },
                {"fingerprintBlocked", (o,n) => { (o as ManagedAppProtection).FingerprintBlocked = n.GetBoolValue(); } },
                {"gracePeriodToBlockAppsDuringOffClockHours", (o,n) => { (o as ManagedAppProtection).GracePeriodToBlockAppsDuringOffClockHours = n.GetTimeSpanValue(); } },
                {"managedBrowser", (o,n) => { (o as ManagedAppProtection).ManagedBrowser = n.GetEnumValue<ManagedBrowserType>(); } },
                {"managedBrowserToOpenLinksRequired", (o,n) => { (o as ManagedAppProtection).ManagedBrowserToOpenLinksRequired = n.GetBoolValue(); } },
                {"maximumAllowedDeviceThreatLevel", (o,n) => { (o as ManagedAppProtection).MaximumAllowedDeviceThreatLevel = n.GetEnumValue<ManagedAppDeviceThreatLevel>(); } },
                {"maximumPinRetries", (o,n) => { (o as ManagedAppProtection).MaximumPinRetries = n.GetIntValue(); } },
                {"maximumRequiredOsVersion", (o,n) => { (o as ManagedAppProtection).MaximumRequiredOsVersion = n.GetStringValue(); } },
                {"maximumWarningOsVersion", (o,n) => { (o as ManagedAppProtection).MaximumWarningOsVersion = n.GetStringValue(); } },
                {"maximumWipeOsVersion", (o,n) => { (o as ManagedAppProtection).MaximumWipeOsVersion = n.GetStringValue(); } },
                {"minimumPinLength", (o,n) => { (o as ManagedAppProtection).MinimumPinLength = n.GetIntValue(); } },
                {"minimumRequiredAppVersion", (o,n) => { (o as ManagedAppProtection).MinimumRequiredAppVersion = n.GetStringValue(); } },
                {"minimumRequiredOsVersion", (o,n) => { (o as ManagedAppProtection).MinimumRequiredOsVersion = n.GetStringValue(); } },
                {"minimumWarningAppVersion", (o,n) => { (o as ManagedAppProtection).MinimumWarningAppVersion = n.GetStringValue(); } },
                {"minimumWarningOsVersion", (o,n) => { (o as ManagedAppProtection).MinimumWarningOsVersion = n.GetStringValue(); } },
                {"minimumWipeAppVersion", (o,n) => { (o as ManagedAppProtection).MinimumWipeAppVersion = n.GetStringValue(); } },
                {"minimumWipeOsVersion", (o,n) => { (o as ManagedAppProtection).MinimumWipeOsVersion = n.GetStringValue(); } },
                {"mobileThreatDefenseRemediationAction", (o,n) => { (o as ManagedAppProtection).MobileThreatDefenseRemediationAction = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"notificationRestriction", (o,n) => { (o as ManagedAppProtection).NotificationRestriction = n.GetEnumValue<ManagedAppNotificationRestriction>(); } },
                {"organizationalCredentialsRequired", (o,n) => { (o as ManagedAppProtection).OrganizationalCredentialsRequired = n.GetBoolValue(); } },
                {"periodBeforePinReset", (o,n) => { (o as ManagedAppProtection).PeriodBeforePinReset = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeAccessCheck", (o,n) => { (o as ManagedAppProtection).PeriodOfflineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeWipeIsEnforced", (o,n) => { (o as ManagedAppProtection).PeriodOfflineBeforeWipeIsEnforced = n.GetTimeSpanValue(); } },
                {"periodOnlineBeforeAccessCheck", (o,n) => { (o as ManagedAppProtection).PeriodOnlineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"pinCharacterSet", (o,n) => { (o as ManagedAppProtection).PinCharacterSet = n.GetEnumValue<ManagedAppPinCharacterSet>(); } },
                {"pinRequired", (o,n) => { (o as ManagedAppProtection).PinRequired = n.GetBoolValue(); } },
                {"pinRequiredInsteadOfBiometricTimeout", (o,n) => { (o as ManagedAppProtection).PinRequiredInsteadOfBiometricTimeout = n.GetTimeSpanValue(); } },
                {"previousPinBlockCount", (o,n) => { (o as ManagedAppProtection).PreviousPinBlockCount = n.GetIntValue(); } },
                {"printBlocked", (o,n) => { (o as ManagedAppProtection).PrintBlocked = n.GetBoolValue(); } },
                {"saveAsBlocked", (o,n) => { (o as ManagedAppProtection).SaveAsBlocked = n.GetBoolValue(); } },
                {"simplePinBlocked", (o,n) => { (o as ManagedAppProtection).SimplePinBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<ManagedAppDataIngestionLocation>("allowedDataIngestionLocations", AllowedDataIngestionLocations);
            writer.WriteCollectionOfEnumValues<ManagedAppDataStorageLocation>("allowedDataStorageLocations", AllowedDataStorageLocations);
            writer.WriteEnumValue<ManagedAppDataTransferLevel>("allowedInboundDataTransferSources", AllowedInboundDataTransferSources);
            writer.WriteIntValue("allowedOutboundClipboardSharingExceptionLength", AllowedOutboundClipboardSharingExceptionLength);
            writer.WriteEnumValue<ManagedAppClipboardSharingLevel>("allowedOutboundClipboardSharingLevel", AllowedOutboundClipboardSharingLevel);
            writer.WriteEnumValue<ManagedAppDataTransferLevel>("allowedOutboundDataTransferDestinations", AllowedOutboundDataTransferDestinations);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDeviceComplianceRequired", AppActionIfDeviceComplianceRequired);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfMaximumPinRetriesExceeded", AppActionIfMaximumPinRetriesExceeded);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfUnableToAuthenticateUser", AppActionIfUnableToAuthenticateUser);
            writer.WriteBoolValue("blockDataIngestionIntoOrganizationDocuments", BlockDataIngestionIntoOrganizationDocuments);
            writer.WriteBoolValue("contactSyncBlocked", ContactSyncBlocked);
            writer.WriteBoolValue("dataBackupBlocked", DataBackupBlocked);
            writer.WriteBoolValue("deviceComplianceRequired", DeviceComplianceRequired);
            writer.WriteEnumValue<ManagedAppPhoneNumberRedirectLevel>("dialerRestrictionLevel", DialerRestrictionLevel);
            writer.WriteBoolValue("disableAppPinIfDevicePinIsSet", DisableAppPinIfDevicePinIsSet);
            writer.WriteBoolValue("fingerprintBlocked", FingerprintBlocked);
            writer.WriteTimeSpanValue("gracePeriodToBlockAppsDuringOffClockHours", GracePeriodToBlockAppsDuringOffClockHours);
            writer.WriteEnumValue<ManagedBrowserType>("managedBrowser", ManagedBrowser);
            writer.WriteBoolValue("managedBrowserToOpenLinksRequired", ManagedBrowserToOpenLinksRequired);
            writer.WriteEnumValue<ManagedAppDeviceThreatLevel>("maximumAllowedDeviceThreatLevel", MaximumAllowedDeviceThreatLevel);
            writer.WriteIntValue("maximumPinRetries", MaximumPinRetries);
            writer.WriteStringValue("maximumRequiredOsVersion", MaximumRequiredOsVersion);
            writer.WriteStringValue("maximumWarningOsVersion", MaximumWarningOsVersion);
            writer.WriteStringValue("maximumWipeOsVersion", MaximumWipeOsVersion);
            writer.WriteIntValue("minimumPinLength", MinimumPinLength);
            writer.WriteStringValue("minimumRequiredAppVersion", MinimumRequiredAppVersion);
            writer.WriteStringValue("minimumRequiredOsVersion", MinimumRequiredOsVersion);
            writer.WriteStringValue("minimumWarningAppVersion", MinimumWarningAppVersion);
            writer.WriteStringValue("minimumWarningOsVersion", MinimumWarningOsVersion);
            writer.WriteStringValue("minimumWipeAppVersion", MinimumWipeAppVersion);
            writer.WriteStringValue("minimumWipeOsVersion", MinimumWipeOsVersion);
            writer.WriteEnumValue<ManagedAppRemediationAction>("mobileThreatDefenseRemediationAction", MobileThreatDefenseRemediationAction);
            writer.WriteEnumValue<ManagedAppNotificationRestriction>("notificationRestriction", NotificationRestriction);
            writer.WriteBoolValue("organizationalCredentialsRequired", OrganizationalCredentialsRequired);
            writer.WriteTimeSpanValue("periodBeforePinReset", PeriodBeforePinReset);
            writer.WriteTimeSpanValue("periodOfflineBeforeAccessCheck", PeriodOfflineBeforeAccessCheck);
            writer.WriteTimeSpanValue("periodOfflineBeforeWipeIsEnforced", PeriodOfflineBeforeWipeIsEnforced);
            writer.WriteTimeSpanValue("periodOnlineBeforeAccessCheck", PeriodOnlineBeforeAccessCheck);
            writer.WriteEnumValue<ManagedAppPinCharacterSet>("pinCharacterSet", PinCharacterSet);
            writer.WriteBoolValue("pinRequired", PinRequired);
            writer.WriteTimeSpanValue("pinRequiredInsteadOfBiometricTimeout", PinRequiredInsteadOfBiometricTimeout);
            writer.WriteIntValue("previousPinBlockCount", PreviousPinBlockCount);
            writer.WriteBoolValue("printBlocked", PrintBlocked);
            writer.WriteBoolValue("saveAsBlocked", SaveAsBlocked);
            writer.WriteBoolValue("simplePinBlocked", SimplePinBlocked);
        }
    }
}
