using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ManagedAppProtection : ManagedAppPolicy, IParsable {
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<string> AllowedDataIngestionLocations {
            get { return BackingStore?.Get<List<string>>("allowedDataIngestionLocations"); }
            set { BackingStore?.Set("allowedDataIngestionLocations", value); }
        }
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<string> AllowedDataStorageLocations {
            get { return BackingStore?.Get<List<string>>("allowedDataStorageLocations"); }
            set { BackingStore?.Set("allowedDataStorageLocations", value); }
        }
        /// <summary>Data can be transferred from/to these classes of apps</summary>
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources {
            get { return BackingStore?.Get<ManagedAppDataTransferLevel?>("allowedInboundDataTransferSources"); }
            set { BackingStore?.Set("allowedInboundDataTransferSources", value); }
        }
        /// <summary>Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of &apos;0&apos; means no exception is allowed.</summary>
        public int? AllowedOutboundClipboardSharingExceptionLength {
            get { return BackingStore?.Get<int?>("allowedOutboundClipboardSharingExceptionLength"); }
            set { BackingStore?.Set("allowedOutboundClipboardSharingExceptionLength", value); }
        }
        /// <summary>Represents the level to which the device&apos;s clipboard may be shared between apps</summary>
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel {
            get { return BackingStore?.Get<ManagedAppClipboardSharingLevel?>("allowedOutboundClipboardSharingLevel"); }
            set { BackingStore?.Set("allowedOutboundClipboardSharingLevel", value); }
        }
        /// <summary>Data can be transferred from/to these classes of apps</summary>
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations {
            get { return BackingStore?.Get<ManagedAppDataTransferLevel?>("allowedOutboundDataTransferDestinations"); }
            set { BackingStore?.Set("allowedOutboundDataTransferDestinations", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceComplianceRequired {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDeviceComplianceRequired"); }
            set { BackingStore?.Set("appActionIfDeviceComplianceRequired", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfMaximumPinRetriesExceeded {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfMaximumPinRetriesExceeded"); }
            set { BackingStore?.Set("appActionIfMaximumPinRetriesExceeded", value); }
        }
        /// <summary>If set, it will specify what action to take in the case where the user is unable to checkin because their authentication token is invalid. This happens when the user is deleted or disabled in AAD. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfUnableToAuthenticateUser {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfUnableToAuthenticateUser"); }
            set { BackingStore?.Set("appActionIfUnableToAuthenticateUser", value); }
        }
        /// <summary>Indicates whether a user can bring data into org documents.</summary>
        public bool? BlockDataIngestionIntoOrganizationDocuments {
            get { return BackingStore?.Get<bool?>("blockDataIngestionIntoOrganizationDocuments"); }
            set { BackingStore?.Set("blockDataIngestionIntoOrganizationDocuments", value); }
        }
        /// <summary>Indicates whether contacts can be synced to the user&apos;s device.</summary>
        public bool? ContactSyncBlocked {
            get { return BackingStore?.Get<bool?>("contactSyncBlocked"); }
            set { BackingStore?.Set("contactSyncBlocked", value); }
        }
        /// <summary>Indicates whether the backup of a managed app&apos;s data is blocked.</summary>
        public bool? DataBackupBlocked {
            get { return BackingStore?.Get<bool?>("dataBackupBlocked"); }
            set { BackingStore?.Set("dataBackupBlocked", value); }
        }
        /// <summary>Indicates whether device compliance is required.</summary>
        public bool? DeviceComplianceRequired {
            get { return BackingStore?.Get<bool?>("deviceComplianceRequired"); }
            set { BackingStore?.Set("deviceComplianceRequired", value); }
        }
        /// <summary>The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.</summary>
        public ManagedAppPhoneNumberRedirectLevel? DialerRestrictionLevel {
            get { return BackingStore?.Get<ManagedAppPhoneNumberRedirectLevel?>("dialerRestrictionLevel"); }
            set { BackingStore?.Set("dialerRestrictionLevel", value); }
        }
        /// <summary>Indicates whether use of the app pin is required if the device pin is set.</summary>
        public bool? DisableAppPinIfDevicePinIsSet {
            get { return BackingStore?.Get<bool?>("disableAppPinIfDevicePinIsSet"); }
            set { BackingStore?.Set("disableAppPinIfDevicePinIsSet", value); }
        }
        /// <summary>Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FingerprintBlocked {
            get { return BackingStore?.Get<bool?>("fingerprintBlocked"); }
            set { BackingStore?.Set("fingerprintBlocked", value); }
        }
        /// <summary>A grace period before blocking app access during off clock hours.</summary>
        public TimeSpan? GracePeriodToBlockAppsDuringOffClockHours {
            get { return BackingStore?.Get<TimeSpan?>("gracePeriodToBlockAppsDuringOffClockHours"); }
            set { BackingStore?.Set("gracePeriodToBlockAppsDuringOffClockHours", value); }
        }
        /// <summary>Type of managed browser</summary>
        public ManagedBrowserType? ManagedBrowser {
            get { return BackingStore?.Get<ManagedBrowserType?>("managedBrowser"); }
            set { BackingStore?.Set("managedBrowser", value); }
        }
        /// <summary>Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)</summary>
        public bool? ManagedBrowserToOpenLinksRequired {
            get { return BackingStore?.Get<bool?>("managedBrowserToOpenLinksRequired"); }
            set { BackingStore?.Set("managedBrowserToOpenLinksRequired", value); }
        }
        /// <summary>The maxium threat level allowed for an app to be compliant.</summary>
        public ManagedAppDeviceThreatLevel? MaximumAllowedDeviceThreatLevel {
            get { return BackingStore?.Get<ManagedAppDeviceThreatLevel?>("maximumAllowedDeviceThreatLevel"); }
            set { BackingStore?.Set("maximumAllowedDeviceThreatLevel", value); }
        }
        /// <summary>Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</summary>
        public int? MaximumPinRetries {
            get { return BackingStore?.Get<int?>("maximumPinRetries"); }
            set { BackingStore?.Set("maximumPinRetries", value); }
        }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumRequiredOsVersion {
            get { return BackingStore?.Get<string>("maximumRequiredOsVersion"); }
            set { BackingStore?.Set("maximumRequiredOsVersion", value); }
        }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumWarningOsVersion {
            get { return BackingStore?.Get<string>("maximumWarningOsVersion"); }
            set { BackingStore?.Set("maximumWarningOsVersion", value); }
        }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data.</summary>
        public string MaximumWipeOsVersion {
            get { return BackingStore?.Get<string>("maximumWipeOsVersion"); }
            set { BackingStore?.Set("maximumWipeOsVersion", value); }
        }
        /// <summary>Minimum pin length required for an app-level pin if PinRequired is set to True</summary>
        public int? MinimumPinLength {
            get { return BackingStore?.Get<int?>("minimumPinLength"); }
            set { BackingStore?.Set("minimumPinLength", value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredAppVersion {
            get { return BackingStore?.Get<string>("minimumRequiredAppVersion"); }
            set { BackingStore?.Set("minimumRequiredAppVersion", value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredOsVersion {
            get { return BackingStore?.Get<string>("minimumRequiredOsVersion"); }
            set { BackingStore?.Set("minimumRequiredOsVersion", value); }
        }
        /// <summary>Versions less than the specified version will result in warning message on the managed app.</summary>
        public string MinimumWarningAppVersion {
            get { return BackingStore?.Get<string>("minimumWarningAppVersion"); }
            set { BackingStore?.Set("minimumWarningAppVersion", value); }
        }
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data.</summary>
        public string MinimumWarningOsVersion {
            get { return BackingStore?.Get<string>("minimumWarningOsVersion"); }
            set { BackingStore?.Set("minimumWarningOsVersion", value); }
        }
        /// <summary>Versions less than or equal to the specified version will wipe the managed app and the associated company data.</summary>
        public string MinimumWipeAppVersion {
            get { return BackingStore?.Get<string>("minimumWipeAppVersion"); }
            set { BackingStore?.Set("minimumWipeAppVersion", value); }
        }
        /// <summary>Versions less than or equal to the specified version will wipe the managed app and the associated company data.</summary>
        public string MinimumWipeOsVersion {
            get { return BackingStore?.Get<string>("minimumWipeOsVersion"); }
            set { BackingStore?.Set("minimumWipeOsVersion", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? MobileThreatDefenseRemediationAction {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("mobileThreatDefenseRemediationAction"); }
            set { BackingStore?.Set("mobileThreatDefenseRemediationAction", value); }
        }
        /// <summary>Restrict managed app notification</summary>
        public ManagedAppNotificationRestriction? NotificationRestriction {
            get { return BackingStore?.Get<ManagedAppNotificationRestriction?>("notificationRestriction"); }
            set { BackingStore?.Set("notificationRestriction", value); }
        }
        /// <summary>Indicates whether organizational credentials are required for app use.</summary>
        public bool? OrganizationalCredentialsRequired {
            get { return BackingStore?.Get<bool?>("organizationalCredentialsRequired"); }
            set { BackingStore?.Set("organizationalCredentialsRequired", value); }
        }
        /// <summary>TimePeriod before the all-level pin must be reset if PinRequired is set to True.</summary>
        public TimeSpan? PeriodBeforePinReset {
            get { return BackingStore?.Get<TimeSpan?>("periodBeforePinReset"); }
            set { BackingStore?.Set("periodBeforePinReset", value); }
        }
        /// <summary>The period after which access is checked when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeAccessCheck {
            get { return BackingStore?.Get<TimeSpan?>("periodOfflineBeforeAccessCheck"); }
            set { BackingStore?.Set("periodOfflineBeforeAccessCheck", value); }
        }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</summary>
        public TimeSpan? PeriodOfflineBeforeWipeIsEnforced {
            get { return BackingStore?.Get<TimeSpan?>("periodOfflineBeforeWipeIsEnforced"); }
            set { BackingStore?.Set("periodOfflineBeforeWipeIsEnforced", value); }
        }
        /// <summary>The period after which access is checked when the device is connected to the internet.</summary>
        public TimeSpan? PeriodOnlineBeforeAccessCheck {
            get { return BackingStore?.Get<TimeSpan?>("periodOnlineBeforeAccessCheck"); }
            set { BackingStore?.Set("periodOnlineBeforeAccessCheck", value); }
        }
        /// <summary>Character set which is to be used for a user&apos;s app PIN</summary>
        public ManagedAppPinCharacterSet? PinCharacterSet {
            get { return BackingStore?.Get<ManagedAppPinCharacterSet?>("pinCharacterSet"); }
            set { BackingStore?.Set("pinCharacterSet", value); }
        }
        /// <summary>Indicates whether an app-level pin is required.</summary>
        public bool? PinRequired {
            get { return BackingStore?.Get<bool?>("pinRequired"); }
            set { BackingStore?.Set("pinRequired", value); }
        }
        /// <summary>Timeout in minutes for an app pin instead of non biometrics passcode</summary>
        public TimeSpan? PinRequiredInsteadOfBiometricTimeout {
            get { return BackingStore?.Get<TimeSpan?>("pinRequiredInsteadOfBiometricTimeout"); }
            set { BackingStore?.Set("pinRequiredInsteadOfBiometricTimeout", value); }
        }
        /// <summary>Requires a pin to be unique from the number specified in this property.</summary>
        public int? PreviousPinBlockCount {
            get { return BackingStore?.Get<int?>("previousPinBlockCount"); }
            set { BackingStore?.Set("previousPinBlockCount", value); }
        }
        /// <summary>Indicates whether printing is allowed from managed apps.</summary>
        public bool? PrintBlocked {
            get { return BackingStore?.Get<bool?>("printBlocked"); }
            set { BackingStore?.Set("printBlocked", value); }
        }
        /// <summary>Indicates whether users may use the &apos;Save As&apos; menu item to save a copy of protected files.</summary>
        public bool? SaveAsBlocked {
            get { return BackingStore?.Get<bool?>("saveAsBlocked"); }
            set { BackingStore?.Set("saveAsBlocked", value); }
        }
        /// <summary>Indicates whether simplePin is blocked.</summary>
        public bool? SimplePinBlocked {
            get { return BackingStore?.Get<bool?>("simplePinBlocked"); }
            set { BackingStore?.Set("simplePinBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new ManagedAppProtection and sets the default values.
        /// </summary>
        public ManagedAppProtection() : base() {
            OdataType = "#microsoft.graph.managedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidManagedAppProtection" => new AndroidManagedAppProtection(),
                "#microsoft.graph.defaultManagedAppProtection" => new DefaultManagedAppProtection(),
                "#microsoft.graph.iosManagedAppProtection" => new IosManagedAppProtection(),
                "#microsoft.graph.targetedManagedAppProtection" => new TargetedManagedAppProtection(),
                _ => new ManagedAppProtection(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedDataIngestionLocations", n => { AllowedDataIngestionLocations = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"allowedDataStorageLocations", n => { AllowedDataStorageLocations = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
