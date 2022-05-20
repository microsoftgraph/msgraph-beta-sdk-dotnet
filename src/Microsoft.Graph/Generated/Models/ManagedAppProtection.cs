using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Policy used to configure detailed management settings for a specified set of apps</summary>
    public class ManagedAppProtection : ManagedAppPolicy, IParsable {
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<string> AllowedDataIngestionLocations {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedDataIngestionLocations)); }
            set { BackingStore?.Set(nameof(AllowedDataIngestionLocations), value); }
        }
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<string> AllowedDataStorageLocations {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedDataStorageLocations)); }
            set { BackingStore?.Set(nameof(AllowedDataStorageLocations), value); }
        }
        /// <summary>Sources from which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources {
            get { return BackingStore?.Get<ManagedAppDataTransferLevel?>(nameof(AllowedInboundDataTransferSources)); }
            set { BackingStore?.Set(nameof(AllowedInboundDataTransferSources), value); }
        }
        /// <summary>Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of &apos;0&apos; means no exception is allowed.</summary>
        public int? AllowedOutboundClipboardSharingExceptionLength {
            get { return BackingStore?.Get<int?>(nameof(AllowedOutboundClipboardSharingExceptionLength)); }
            set { BackingStore?.Set(nameof(AllowedOutboundClipboardSharingExceptionLength), value); }
        }
        /// <summary>The level to which the clipboard may be shared between apps on the managed device. Possible values are: allApps, managedAppsWithPasteIn, managedApps, blocked.</summary>
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel {
            get { return BackingStore?.Get<ManagedAppClipboardSharingLevel?>(nameof(AllowedOutboundClipboardSharingLevel)); }
            set { BackingStore?.Set(nameof(AllowedOutboundClipboardSharingLevel), value); }
        }
        /// <summary>Destinations to which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations {
            get { return BackingStore?.Get<ManagedAppDataTransferLevel?>(nameof(AllowedOutboundDataTransferDestinations)); }
            set { BackingStore?.Set(nameof(AllowedOutboundDataTransferDestinations), value); }
        }
        /// <summary>Defines a managed app behavior, either block or wipe, when the device is either rooted or jailbroken, if DeviceComplianceRequired is set to true. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceComplianceRequired {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfDeviceComplianceRequired)); }
            set { BackingStore?.Set(nameof(AppActionIfDeviceComplianceRequired), value); }
        }
        /// <summary>Defines a managed app behavior, either block or wipe, based on maximum number of incorrect pin retry attempts. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfMaximumPinRetriesExceeded {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfMaximumPinRetriesExceeded)); }
            set { BackingStore?.Set(nameof(AppActionIfMaximumPinRetriesExceeded), value); }
        }
        /// <summary>If set, it will specify what action to take in the case where the user is unable to checkin because their authentication token is invalid. This happens when the user is deleted or disabled in AAD. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfUnableToAuthenticateUser {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfUnableToAuthenticateUser)); }
            set { BackingStore?.Set(nameof(AppActionIfUnableToAuthenticateUser), value); }
        }
        /// <summary>Indicates whether a user can bring data into org documents.</summary>
        public bool? BlockDataIngestionIntoOrganizationDocuments {
            get { return BackingStore?.Get<bool?>(nameof(BlockDataIngestionIntoOrganizationDocuments)); }
            set { BackingStore?.Set(nameof(BlockDataIngestionIntoOrganizationDocuments), value); }
        }
        /// <summary>Indicates whether contacts can be synced to the user&apos;s device.</summary>
        public bool? ContactSyncBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ContactSyncBlocked)); }
            set { BackingStore?.Set(nameof(ContactSyncBlocked), value); }
        }
        /// <summary>Indicates whether the backup of a managed app&apos;s data is blocked.</summary>
        public bool? DataBackupBlocked {
            get { return BackingStore?.Get<bool?>(nameof(DataBackupBlocked)); }
            set { BackingStore?.Set(nameof(DataBackupBlocked), value); }
        }
        /// <summary>Indicates whether device compliance is required.</summary>
        public bool? DeviceComplianceRequired {
            get { return BackingStore?.Get<bool?>(nameof(DeviceComplianceRequired)); }
            set { BackingStore?.Set(nameof(DeviceComplianceRequired), value); }
        }
        /// <summary>The classes of dialer apps that are allowed to click-to-open a phone number. Possible values are: allApps, managedApps, customApp, blocked.</summary>
        public ManagedAppPhoneNumberRedirectLevel? DialerRestrictionLevel {
            get { return BackingStore?.Get<ManagedAppPhoneNumberRedirectLevel?>(nameof(DialerRestrictionLevel)); }
            set { BackingStore?.Set(nameof(DialerRestrictionLevel), value); }
        }
        /// <summary>Indicates whether use of the app pin is required if the device pin is set.</summary>
        public bool? DisableAppPinIfDevicePinIsSet {
            get { return BackingStore?.Get<bool?>(nameof(DisableAppPinIfDevicePinIsSet)); }
            set { BackingStore?.Set(nameof(DisableAppPinIfDevicePinIsSet), value); }
        }
        /// <summary>Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FingerprintBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FingerprintBlocked)); }
            set { BackingStore?.Set(nameof(FingerprintBlocked), value); }
        }
        /// <summary>A grace period before blocking app access during off clock hours.</summary>
        public TimeSpan? GracePeriodToBlockAppsDuringOffClockHours {
            get { return BackingStore?.Get<TimeSpan?>(nameof(GracePeriodToBlockAppsDuringOffClockHours)); }
            set { BackingStore?.Set(nameof(GracePeriodToBlockAppsDuringOffClockHours), value); }
        }
        /// <summary>Indicates in which managed browser(s) that internet links should be opened. When this property is configured, ManagedBrowserToOpenLinksRequired should be true. Possible values are: notConfigured, microsoftEdge.</summary>
        public ManagedBrowserType? ManagedBrowser {
            get { return BackingStore?.Get<ManagedBrowserType?>(nameof(ManagedBrowser)); }
            set { BackingStore?.Set(nameof(ManagedBrowser), value); }
        }
        /// <summary>Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)</summary>
        public bool? ManagedBrowserToOpenLinksRequired {
            get { return BackingStore?.Get<bool?>(nameof(ManagedBrowserToOpenLinksRequired)); }
            set { BackingStore?.Set(nameof(ManagedBrowserToOpenLinksRequired), value); }
        }
        /// <summary>Maximum allowed device threat level, as reported by the MTD app. Possible values are: notConfigured, secured, low, medium, high.</summary>
        public ManagedAppDeviceThreatLevel? MaximumAllowedDeviceThreatLevel {
            get { return BackingStore?.Get<ManagedAppDeviceThreatLevel?>(nameof(MaximumAllowedDeviceThreatLevel)); }
            set { BackingStore?.Set(nameof(MaximumAllowedDeviceThreatLevel), value); }
        }
        /// <summary>Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</summary>
        public int? MaximumPinRetries {
            get { return BackingStore?.Get<int?>(nameof(MaximumPinRetries)); }
            set { BackingStore?.Set(nameof(MaximumPinRetries), value); }
        }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumRequiredOsVersion {
            get { return BackingStore?.Get<string>(nameof(MaximumRequiredOsVersion)); }
            set { BackingStore?.Set(nameof(MaximumRequiredOsVersion), value); }
        }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumWarningOsVersion {
            get { return BackingStore?.Get<string>(nameof(MaximumWarningOsVersion)); }
            set { BackingStore?.Set(nameof(MaximumWarningOsVersion), value); }
        }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumWipeOsVersion {
            get { return BackingStore?.Get<string>(nameof(MaximumWipeOsVersion)); }
            set { BackingStore?.Set(nameof(MaximumWipeOsVersion), value); }
        }
        /// <summary>Minimum pin length required for an app-level pin if PinRequired is set to True</summary>
        public int? MinimumPinLength {
            get { return BackingStore?.Get<int?>(nameof(MinimumPinLength)); }
            set { BackingStore?.Set(nameof(MinimumPinLength), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredAppVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredAppVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredAppVersion), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredOsVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredOsVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredOsVersion), value); }
        }
        /// <summary>Versions less than the specified version will result in warning message on the managed app.</summary>
        public string MinimumWarningAppVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningAppVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningAppVersion), value); }
        }
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data.</summary>
        public string MinimumWarningOsVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningOsVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningOsVersion), value); }
        }
        /// <summary>Versions less than or equal to the specified version will wipe the managed app and the associated company data.</summary>
        public string MinimumWipeAppVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipeAppVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipeAppVersion), value); }
        }
        /// <summary>Versions less than or equal to the specified version will wipe the managed app and the associated company data.</summary>
        public string MinimumWipeOsVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipeOsVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipeOsVersion), value); }
        }
        /// <summary>Determines what action to take if the mobile threat defense threat threshold isn&apos;t met. Warn isn&apos;t a supported value for this property. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? MobileThreatDefenseRemediationAction {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(MobileThreatDefenseRemediationAction)); }
            set { BackingStore?.Set(nameof(MobileThreatDefenseRemediationAction), value); }
        }
        /// <summary>Specify app notification restriction. Possible values are: allow, blockOrganizationalData, block.</summary>
        public ManagedAppNotificationRestriction? NotificationRestriction {
            get { return BackingStore?.Get<ManagedAppNotificationRestriction?>(nameof(NotificationRestriction)); }
            set { BackingStore?.Set(nameof(NotificationRestriction), value); }
        }
        /// <summary>Indicates whether organizational credentials are required for app use.</summary>
        public bool? OrganizationalCredentialsRequired {
            get { return BackingStore?.Get<bool?>(nameof(OrganizationalCredentialsRequired)); }
            set { BackingStore?.Set(nameof(OrganizationalCredentialsRequired), value); }
        }
        /// <summary>TimePeriod before the all-level pin must be reset if PinRequired is set to True.</summary>
        public TimeSpan? PeriodBeforePinReset {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodBeforePinReset)); }
            set { BackingStore?.Set(nameof(PeriodBeforePinReset), value); }
        }
        /// <summary>The period after which access is checked when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeAccessCheck {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodOfflineBeforeAccessCheck)); }
            set { BackingStore?.Set(nameof(PeriodOfflineBeforeAccessCheck), value); }
        }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</summary>
        public TimeSpan? PeriodOfflineBeforeWipeIsEnforced {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodOfflineBeforeWipeIsEnforced)); }
            set { BackingStore?.Set(nameof(PeriodOfflineBeforeWipeIsEnforced), value); }
        }
        /// <summary>The period after which access is checked when the device is connected to the internet.</summary>
        public TimeSpan? PeriodOnlineBeforeAccessCheck {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodOnlineBeforeAccessCheck)); }
            set { BackingStore?.Set(nameof(PeriodOnlineBeforeAccessCheck), value); }
        }
        /// <summary>Character set which may be used for an app-level pin if PinRequired is set to True. Possible values are: numeric, alphanumericAndSymbol.</summary>
        public ManagedAppPinCharacterSet? PinCharacterSet {
            get { return BackingStore?.Get<ManagedAppPinCharacterSet?>(nameof(PinCharacterSet)); }
            set { BackingStore?.Set(nameof(PinCharacterSet), value); }
        }
        /// <summary>Indicates whether an app-level pin is required.</summary>
        public bool? PinRequired {
            get { return BackingStore?.Get<bool?>(nameof(PinRequired)); }
            set { BackingStore?.Set(nameof(PinRequired), value); }
        }
        /// <summary>Timeout in minutes for an app pin instead of non biometrics passcode</summary>
        public TimeSpan? PinRequiredInsteadOfBiometricTimeout {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PinRequiredInsteadOfBiometricTimeout)); }
            set { BackingStore?.Set(nameof(PinRequiredInsteadOfBiometricTimeout), value); }
        }
        /// <summary>Requires a pin to be unique from the number specified in this property.</summary>
        public int? PreviousPinBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PreviousPinBlockCount)); }
            set { BackingStore?.Set(nameof(PreviousPinBlockCount), value); }
        }
        /// <summary>Indicates whether printing is allowed from managed apps.</summary>
        public bool? PrintBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PrintBlocked)); }
            set { BackingStore?.Set(nameof(PrintBlocked), value); }
        }
        /// <summary>Indicates whether users may use the &apos;Save As&apos; menu item to save a copy of protected files.</summary>
        public bool? SaveAsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(SaveAsBlocked)); }
            set { BackingStore?.Set(nameof(SaveAsBlocked), value); }
        }
        /// <summary>Indicates whether simplePin is blocked.</summary>
        public bool? SimplePinBlocked {
            get { return BackingStore?.Get<bool?>(nameof(SimplePinBlocked)); }
            set { BackingStore?.Set(nameof(SimplePinBlocked), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.managedAppProtection" => new ManagedAppProtection(),
                _ => new ManagedAppProtection(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedDataIngestionLocations", n => { AllowedDataIngestionLocations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedDataStorageLocations", n => { AllowedDataStorageLocations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedInboundDataTransferSources", n => { AllowedInboundDataTransferSources = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"allowedOutboundClipboardSharingExceptionLength", n => { AllowedOutboundClipboardSharingExceptionLength = n.GetIntValue(); } },
                {"allowedOutboundClipboardSharingLevel", n => { AllowedOutboundClipboardSharingLevel = n.GetEnumValue<ManagedAppClipboardSharingLevel>(); } },
                {"allowedOutboundDataTransferDestinations", n => { AllowedOutboundDataTransferDestinations = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"appActionIfDeviceComplianceRequired", n => { AppActionIfDeviceComplianceRequired = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfMaximumPinRetriesExceeded", n => { AppActionIfMaximumPinRetriesExceeded = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfUnableToAuthenticateUser", n => { AppActionIfUnableToAuthenticateUser = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"blockDataIngestionIntoOrganizationDocuments", n => { BlockDataIngestionIntoOrganizationDocuments = n.GetBoolValue(); } },
                {"contactSyncBlocked", n => { ContactSyncBlocked = n.GetBoolValue(); } },
                {"dataBackupBlocked", n => { DataBackupBlocked = n.GetBoolValue(); } },
                {"deviceComplianceRequired", n => { DeviceComplianceRequired = n.GetBoolValue(); } },
                {"dialerRestrictionLevel", n => { DialerRestrictionLevel = n.GetEnumValue<ManagedAppPhoneNumberRedirectLevel>(); } },
                {"disableAppPinIfDevicePinIsSet", n => { DisableAppPinIfDevicePinIsSet = n.GetBoolValue(); } },
                {"fingerprintBlocked", n => { FingerprintBlocked = n.GetBoolValue(); } },
                {"gracePeriodToBlockAppsDuringOffClockHours", n => { GracePeriodToBlockAppsDuringOffClockHours = n.GetTimeSpanValue(); } },
                {"managedBrowser", n => { ManagedBrowser = n.GetEnumValue<ManagedBrowserType>(); } },
                {"managedBrowserToOpenLinksRequired", n => { ManagedBrowserToOpenLinksRequired = n.GetBoolValue(); } },
                {"maximumAllowedDeviceThreatLevel", n => { MaximumAllowedDeviceThreatLevel = n.GetEnumValue<ManagedAppDeviceThreatLevel>(); } },
                {"maximumPinRetries", n => { MaximumPinRetries = n.GetIntValue(); } },
                {"maximumRequiredOsVersion", n => { MaximumRequiredOsVersion = n.GetStringValue(); } },
                {"maximumWarningOsVersion", n => { MaximumWarningOsVersion = n.GetStringValue(); } },
                {"maximumWipeOsVersion", n => { MaximumWipeOsVersion = n.GetStringValue(); } },
                {"minimumPinLength", n => { MinimumPinLength = n.GetIntValue(); } },
                {"minimumRequiredAppVersion", n => { MinimumRequiredAppVersion = n.GetStringValue(); } },
                {"minimumRequiredOsVersion", n => { MinimumRequiredOsVersion = n.GetStringValue(); } },
                {"minimumWarningAppVersion", n => { MinimumWarningAppVersion = n.GetStringValue(); } },
                {"minimumWarningOsVersion", n => { MinimumWarningOsVersion = n.GetStringValue(); } },
                {"minimumWipeAppVersion", n => { MinimumWipeAppVersion = n.GetStringValue(); } },
                {"minimumWipeOsVersion", n => { MinimumWipeOsVersion = n.GetStringValue(); } },
                {"mobileThreatDefenseRemediationAction", n => { MobileThreatDefenseRemediationAction = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"notificationRestriction", n => { NotificationRestriction = n.GetEnumValue<ManagedAppNotificationRestriction>(); } },
                {"organizationalCredentialsRequired", n => { OrganizationalCredentialsRequired = n.GetBoolValue(); } },
                {"periodBeforePinReset", n => { PeriodBeforePinReset = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeAccessCheck", n => { PeriodOfflineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeWipeIsEnforced", n => { PeriodOfflineBeforeWipeIsEnforced = n.GetTimeSpanValue(); } },
                {"periodOnlineBeforeAccessCheck", n => { PeriodOnlineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"pinCharacterSet", n => { PinCharacterSet = n.GetEnumValue<ManagedAppPinCharacterSet>(); } },
                {"pinRequired", n => { PinRequired = n.GetBoolValue(); } },
                {"pinRequiredInsteadOfBiometricTimeout", n => { PinRequiredInsteadOfBiometricTimeout = n.GetTimeSpanValue(); } },
                {"previousPinBlockCount", n => { PreviousPinBlockCount = n.GetIntValue(); } },
                {"printBlocked", n => { PrintBlocked = n.GetBoolValue(); } },
                {"saveAsBlocked", n => { SaveAsBlocked = n.GetBoolValue(); } },
                {"simplePinBlocked", n => { SimplePinBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedDataIngestionLocations", AllowedDataIngestionLocations);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedDataStorageLocations", AllowedDataStorageLocations);
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
