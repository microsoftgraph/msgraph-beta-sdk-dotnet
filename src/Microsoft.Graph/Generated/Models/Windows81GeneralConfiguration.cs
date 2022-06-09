using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows81GeneralConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to Block the user from adding email accounts to the device that are not associated with a Microsoft account.</summary>
        public bool? AccountsBlockAddingNonMicrosoftAccountEmail {
            get { return BackingStore?.Get<bool?>(nameof(AccountsBlockAddingNonMicrosoftAccountEmail)); }
            set { BackingStore?.Set(nameof(AccountsBlockAddingNonMicrosoftAccountEmail), value); }
        }
        /// <summary>Value indicating whether this policy only applies to Windows 8.1. This property is read-only.</summary>
        public bool? ApplyOnlyToWindows81 {
            get { return BackingStore?.Get<bool?>(nameof(ApplyOnlyToWindows81)); }
            set { BackingStore?.Set(nameof(ApplyOnlyToWindows81), value); }
        }
        /// <summary>Indicates whether or not to block auto fill.</summary>
        public bool? BrowserBlockAutofill {
            get { return BackingStore?.Get<bool?>(nameof(BrowserBlockAutofill)); }
            set { BackingStore?.Set(nameof(BrowserBlockAutofill), value); }
        }
        /// <summary>Indicates whether or not to block automatic detection of Intranet sites.</summary>
        public bool? BrowserBlockAutomaticDetectionOfIntranetSites {
            get { return BackingStore?.Get<bool?>(nameof(BrowserBlockAutomaticDetectionOfIntranetSites)); }
            set { BackingStore?.Set(nameof(BrowserBlockAutomaticDetectionOfIntranetSites), value); }
        }
        /// <summary>Indicates whether or not to block enterprise mode access.</summary>
        public bool? BrowserBlockEnterpriseModeAccess {
            get { return BackingStore?.Get<bool?>(nameof(BrowserBlockEnterpriseModeAccess)); }
            set { BackingStore?.Set(nameof(BrowserBlockEnterpriseModeAccess), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using JavaScript.</summary>
        public bool? BrowserBlockJavaScript {
            get { return BackingStore?.Get<bool?>(nameof(BrowserBlockJavaScript)); }
            set { BackingStore?.Set(nameof(BrowserBlockJavaScript), value); }
        }
        /// <summary>Indicates whether or not to block plug-ins.</summary>
        public bool? BrowserBlockPlugins {
            get { return BackingStore?.Get<bool?>(nameof(BrowserBlockPlugins)); }
            set { BackingStore?.Set(nameof(BrowserBlockPlugins), value); }
        }
        /// <summary>Indicates whether or not to block popups.</summary>
        public bool? BrowserBlockPopups {
            get { return BackingStore?.Get<bool?>(nameof(BrowserBlockPopups)); }
            set { BackingStore?.Set(nameof(BrowserBlockPopups), value); }
        }
        /// <summary>Indicates whether or not to Block the user from sending the do not track header.</summary>
        public bool? BrowserBlockSendingDoNotTrackHeader {
            get { return BackingStore?.Get<bool?>(nameof(BrowserBlockSendingDoNotTrackHeader)); }
            set { BackingStore?.Set(nameof(BrowserBlockSendingDoNotTrackHeader), value); }
        }
        /// <summary>Indicates whether or not to block a single word entry on Intranet sites.</summary>
        public bool? BrowserBlockSingleWordEntryOnIntranetSites {
            get { return BackingStore?.Get<bool?>(nameof(BrowserBlockSingleWordEntryOnIntranetSites)); }
            set { BackingStore?.Set(nameof(BrowserBlockSingleWordEntryOnIntranetSites), value); }
        }
        /// <summary>The enterprise mode site list location. Could be a local file, local network or http location.</summary>
        public string BrowserEnterpriseModeSiteListLocation {
            get { return BackingStore?.Get<string>(nameof(BrowserEnterpriseModeSiteListLocation)); }
            set { BackingStore?.Set(nameof(BrowserEnterpriseModeSiteListLocation), value); }
        }
        /// <summary>The internet security level. Possible values are: userDefined, medium, mediumHigh, high.</summary>
        public InternetSiteSecurityLevel? BrowserInternetSecurityLevel {
            get { return BackingStore?.Get<InternetSiteSecurityLevel?>(nameof(BrowserInternetSecurityLevel)); }
            set { BackingStore?.Set(nameof(BrowserInternetSecurityLevel), value); }
        }
        /// <summary>The Intranet security level. Possible values are: userDefined, low, mediumLow, medium, mediumHigh, high.</summary>
        public SiteSecurityLevel? BrowserIntranetSecurityLevel {
            get { return BackingStore?.Get<SiteSecurityLevel?>(nameof(BrowserIntranetSecurityLevel)); }
            set { BackingStore?.Set(nameof(BrowserIntranetSecurityLevel), value); }
        }
        /// <summary>The logging report location.</summary>
        public string BrowserLoggingReportLocation {
            get { return BackingStore?.Get<string>(nameof(BrowserLoggingReportLocation)); }
            set { BackingStore?.Set(nameof(BrowserLoggingReportLocation), value); }
        }
        /// <summary>Indicates whether or not to require a firewall.</summary>
        public bool? BrowserRequireFirewall {
            get { return BackingStore?.Get<bool?>(nameof(BrowserRequireFirewall)); }
            set { BackingStore?.Set(nameof(BrowserRequireFirewall), value); }
        }
        /// <summary>Indicates whether or not to require fraud warning.</summary>
        public bool? BrowserRequireFraudWarning {
            get { return BackingStore?.Get<bool?>(nameof(BrowserRequireFraudWarning)); }
            set { BackingStore?.Set(nameof(BrowserRequireFraudWarning), value); }
        }
        /// <summary>Indicates whether or not to require high security for restricted sites.</summary>
        public bool? BrowserRequireHighSecurityForRestrictedSites {
            get { return BackingStore?.Get<bool?>(nameof(BrowserRequireHighSecurityForRestrictedSites)); }
            set { BackingStore?.Set(nameof(BrowserRequireHighSecurityForRestrictedSites), value); }
        }
        /// <summary>Indicates whether or not to require the user to use the smart screen filter.</summary>
        public bool? BrowserRequireSmartScreen {
            get { return BackingStore?.Get<bool?>(nameof(BrowserRequireSmartScreen)); }
            set { BackingStore?.Set(nameof(BrowserRequireSmartScreen), value); }
        }
        /// <summary>The trusted sites security level. Possible values are: userDefined, low, mediumLow, medium, mediumHigh, high.</summary>
        public SiteSecurityLevel? BrowserTrustedSitesSecurityLevel {
            get { return BackingStore?.Get<SiteSecurityLevel?>(nameof(BrowserTrustedSitesSecurityLevel)); }
            set { BackingStore?.Set(nameof(BrowserTrustedSitesSecurityLevel), value); }
        }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockDataRoaming)); }
            set { BackingStore?.Set(nameof(CellularBlockDataRoaming), value); }
        }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticsBlockDataSubmission {
            get { return BackingStore?.Get<bool?>(nameof(DiagnosticsBlockDataSubmission)); }
            set { BackingStore?.Set(nameof(DiagnosticsBlockDataSubmission), value); }
        }
        /// <summary>The minimum update classification to install automatically. Possible values are: userDefined, recommendedAndImportant, important, none.</summary>
        public UpdateClassification? MinimumAutoInstallClassification {
            get { return BackingStore?.Get<UpdateClassification?>(nameof(MinimumAutoInstallClassification)); }
            set { BackingStore?.Set(nameof(MinimumAutoInstallClassification), value); }
        }
        /// <summary>Indicates whether or not to Block the user from using a pictures password and pin.</summary>
        public bool? PasswordBlockPicturePasswordAndPin {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockPicturePasswordAndPin)); }
            set { BackingStore?.Set(nameof(PasswordBlockPicturePasswordAndPin), value); }
        }
        /// <summary>Password expiration in days.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumCharacterSetCount)); }
            set { BackingStore?.Set(nameof(PasswordMinimumCharacterSetCount), value); }
        }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>The minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeScreenTimeout), value); }
        }
        /// <summary>The number of previous passwords to prevent re-use of. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>The required password type. Possible values are: deviceDefault, alphanumeric, numeric.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>The number of sign in failures before factory reset.</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(PasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(PasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>Indicates whether or not to require encryption on a mobile device.</summary>
        public bool? StorageRequireDeviceEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireDeviceEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireDeviceEncryption), value); }
        }
        /// <summary>The minimum update classification to install automatically. Possible values are: userDefined, recommendedAndImportant, important, none.</summary>
        public UpdateClassification? UpdatesMinimumAutoInstallClassification {
            get { return BackingStore?.Get<UpdateClassification?>(nameof(UpdatesMinimumAutoInstallClassification)); }
            set { BackingStore?.Set(nameof(UpdatesMinimumAutoInstallClassification), value); }
        }
        /// <summary>Indicates whether or not to require automatic updates.</summary>
        public bool? UpdatesRequireAutomaticUpdates {
            get { return BackingStore?.Get<bool?>(nameof(UpdatesRequireAutomaticUpdates)); }
            set { BackingStore?.Set(nameof(UpdatesRequireAutomaticUpdates), value); }
        }
        /// <summary>The user account control settings. Possible values are: userDefined, alwaysNotify, notifyOnAppChanges, notifyOnAppChangesWithoutDimming, neverNotify.</summary>
        public WindowsUserAccountControlSettings? UserAccountControlSettings {
            get { return BackingStore?.Get<WindowsUserAccountControlSettings?>(nameof(UserAccountControlSettings)); }
            set { BackingStore?.Set(nameof(UserAccountControlSettings), value); }
        }
        /// <summary>The work folders url.</summary>
        public string WorkFoldersUrl {
            get { return BackingStore?.Get<string>(nameof(WorkFoldersUrl)); }
            set { BackingStore?.Set(nameof(WorkFoldersUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows81GeneralConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows81GeneralConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountsBlockAddingNonMicrosoftAccountEmail", n => { AccountsBlockAddingNonMicrosoftAccountEmail = n.GetBoolValue(); } },
                {"applyOnlyToWindows81", n => { ApplyOnlyToWindows81 = n.GetBoolValue(); } },
                {"browserBlockAutofill", n => { BrowserBlockAutofill = n.GetBoolValue(); } },
                {"browserBlockAutomaticDetectionOfIntranetSites", n => { BrowserBlockAutomaticDetectionOfIntranetSites = n.GetBoolValue(); } },
                {"browserBlockEnterpriseModeAccess", n => { BrowserBlockEnterpriseModeAccess = n.GetBoolValue(); } },
                {"browserBlockJavaScript", n => { BrowserBlockJavaScript = n.GetBoolValue(); } },
                {"browserBlockPlugins", n => { BrowserBlockPlugins = n.GetBoolValue(); } },
                {"browserBlockPopups", n => { BrowserBlockPopups = n.GetBoolValue(); } },
                {"browserBlockSendingDoNotTrackHeader", n => { BrowserBlockSendingDoNotTrackHeader = n.GetBoolValue(); } },
                {"browserBlockSingleWordEntryOnIntranetSites", n => { BrowserBlockSingleWordEntryOnIntranetSites = n.GetBoolValue(); } },
                {"browserEnterpriseModeSiteListLocation", n => { BrowserEnterpriseModeSiteListLocation = n.GetStringValue(); } },
                {"browserInternetSecurityLevel", n => { BrowserInternetSecurityLevel = n.GetEnumValue<InternetSiteSecurityLevel>(); } },
                {"browserIntranetSecurityLevel", n => { BrowserIntranetSecurityLevel = n.GetEnumValue<SiteSecurityLevel>(); } },
                {"browserLoggingReportLocation", n => { BrowserLoggingReportLocation = n.GetStringValue(); } },
                {"browserRequireFirewall", n => { BrowserRequireFirewall = n.GetBoolValue(); } },
                {"browserRequireFraudWarning", n => { BrowserRequireFraudWarning = n.GetBoolValue(); } },
                {"browserRequireHighSecurityForRestrictedSites", n => { BrowserRequireHighSecurityForRestrictedSites = n.GetBoolValue(); } },
                {"browserRequireSmartScreen", n => { BrowserRequireSmartScreen = n.GetBoolValue(); } },
                {"browserTrustedSitesSecurityLevel", n => { BrowserTrustedSitesSecurityLevel = n.GetEnumValue<SiteSecurityLevel>(); } },
                {"cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                {"diagnosticsBlockDataSubmission", n => { DiagnosticsBlockDataSubmission = n.GetBoolValue(); } },
                {"minimumAutoInstallClassification", n => { MinimumAutoInstallClassification = n.GetEnumValue<UpdateClassification>(); } },
                {"passwordBlockPicturePasswordAndPin", n => { PasswordBlockPicturePasswordAndPin = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"storageRequireDeviceEncryption", n => { StorageRequireDeviceEncryption = n.GetBoolValue(); } },
                {"updatesMinimumAutoInstallClassification", n => { UpdatesMinimumAutoInstallClassification = n.GetEnumValue<UpdateClassification>(); } },
                {"updatesRequireAutomaticUpdates", n => { UpdatesRequireAutomaticUpdates = n.GetBoolValue(); } },
                {"userAccountControlSettings", n => { UserAccountControlSettings = n.GetEnumValue<WindowsUserAccountControlSettings>(); } },
                {"workFoldersUrl", n => { WorkFoldersUrl = n.GetStringValue(); } },
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
            writer.WriteBoolValue("applyOnlyToWindows81", ApplyOnlyToWindows81);
            writer.WriteBoolValue("browserBlockAutofill", BrowserBlockAutofill);
            writer.WriteBoolValue("browserBlockAutomaticDetectionOfIntranetSites", BrowserBlockAutomaticDetectionOfIntranetSites);
            writer.WriteBoolValue("browserBlockEnterpriseModeAccess", BrowserBlockEnterpriseModeAccess);
            writer.WriteBoolValue("browserBlockJavaScript", BrowserBlockJavaScript);
            writer.WriteBoolValue("browserBlockPlugins", BrowserBlockPlugins);
            writer.WriteBoolValue("browserBlockPopups", BrowserBlockPopups);
            writer.WriteBoolValue("browserBlockSendingDoNotTrackHeader", BrowserBlockSendingDoNotTrackHeader);
            writer.WriteBoolValue("browserBlockSingleWordEntryOnIntranetSites", BrowserBlockSingleWordEntryOnIntranetSites);
            writer.WriteStringValue("browserEnterpriseModeSiteListLocation", BrowserEnterpriseModeSiteListLocation);
            writer.WriteEnumValue<InternetSiteSecurityLevel>("browserInternetSecurityLevel", BrowserInternetSecurityLevel);
            writer.WriteEnumValue<SiteSecurityLevel>("browserIntranetSecurityLevel", BrowserIntranetSecurityLevel);
            writer.WriteStringValue("browserLoggingReportLocation", BrowserLoggingReportLocation);
            writer.WriteBoolValue("browserRequireFirewall", BrowserRequireFirewall);
            writer.WriteBoolValue("browserRequireFraudWarning", BrowserRequireFraudWarning);
            writer.WriteBoolValue("browserRequireHighSecurityForRestrictedSites", BrowserRequireHighSecurityForRestrictedSites);
            writer.WriteBoolValue("browserRequireSmartScreen", BrowserRequireSmartScreen);
            writer.WriteEnumValue<SiteSecurityLevel>("browserTrustedSitesSecurityLevel", BrowserTrustedSitesSecurityLevel);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("diagnosticsBlockDataSubmission", DiagnosticsBlockDataSubmission);
            writer.WriteEnumValue<UpdateClassification>("minimumAutoInstallClassification", MinimumAutoInstallClassification);
            writer.WriteBoolValue("passwordBlockPicturePasswordAndPin", PasswordBlockPicturePasswordAndPin);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("storageRequireDeviceEncryption", StorageRequireDeviceEncryption);
            writer.WriteEnumValue<UpdateClassification>("updatesMinimumAutoInstallClassification", UpdatesMinimumAutoInstallClassification);
            writer.WriteBoolValue("updatesRequireAutomaticUpdates", UpdatesRequireAutomaticUpdates);
            writer.WriteEnumValue<WindowsUserAccountControlSettings>("userAccountControlSettings", UserAccountControlSettings);
            writer.WriteStringValue("workFoldersUrl", WorkFoldersUrl);
        }
    }
}
