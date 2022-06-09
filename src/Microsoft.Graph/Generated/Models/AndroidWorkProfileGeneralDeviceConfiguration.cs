using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidWorkProfileGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to block face unlock.</summary>
        public bool? PasswordBlockFaceUnlock {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockFaceUnlock)); }
            set { BackingStore?.Set(nameof(PasswordBlockFaceUnlock), value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasswordBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockFingerprintUnlock)); }
            set { BackingStore?.Set(nameof(PasswordBlockFingerprintUnlock), value); }
        }
        /// <summary>Indicates whether or not to block iris unlock.</summary>
        public bool? PasswordBlockIrisUnlock {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockIrisUnlock)); }
            set { BackingStore?.Set(nameof(PasswordBlockIrisUnlock), value); }
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
        /// <summary>Type of password that is required. Possible values are: deviceDefault, lowSecurityBiometric, required, atLeastNumeric, numericComplex, atLeastAlphabetic, atLeastAlphanumeric, alphanumericWithSymbols.</summary>
        public AndroidWorkProfileRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidWorkProfileRequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Number of sign in failures allowed before factory reset. Valid values 1 to 16</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(PasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(PasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps {
            get { return BackingStore?.Get<bool?>(nameof(SecurityRequireVerifyApps)); }
            set { BackingStore?.Set(nameof(SecurityRequireVerifyApps), value); }
        }
        /// <summary>Enable lockdown mode for always-on VPN.</summary>
        public string VpnAlwaysOnPackageIdentifier {
            get { return BackingStore?.Get<string>(nameof(VpnAlwaysOnPackageIdentifier)); }
            set { BackingStore?.Set(nameof(VpnAlwaysOnPackageIdentifier), value); }
        }
        /// <summary>Enable lockdown mode for always-on VPN.</summary>
        public bool? VpnEnableAlwaysOnLockdownMode {
            get { return BackingStore?.Get<bool?>(nameof(VpnEnableAlwaysOnLockdownMode)); }
            set { BackingStore?.Set(nameof(VpnEnableAlwaysOnLockdownMode), value); }
        }
        /// <summary>Indicates whether to allow installation of apps from unknown sources.</summary>
        public bool? WorkProfileAllowAppInstallsFromUnknownSources {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileAllowAppInstallsFromUnknownSources)); }
            set { BackingStore?.Set(nameof(WorkProfileAllowAppInstallsFromUnknownSources), value); }
        }
        /// <summary>Allow widgets from work profile apps.</summary>
        public bool? WorkProfileAllowWidgets {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileAllowWidgets)); }
            set { BackingStore?.Set(nameof(WorkProfileAllowWidgets), value); }
        }
        /// <summary>Block users from adding/removing accounts in work profile.</summary>
        public bool? WorkProfileBlockAddingAccounts {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBlockAddingAccounts)); }
            set { BackingStore?.Set(nameof(WorkProfileBlockAddingAccounts), value); }
        }
        /// <summary>Block work profile camera.</summary>
        public bool? WorkProfileBlockCamera {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBlockCamera)); }
            set { BackingStore?.Set(nameof(WorkProfileBlockCamera), value); }
        }
        /// <summary>Block display work profile caller ID in personal profile.</summary>
        public bool? WorkProfileBlockCrossProfileCallerId {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBlockCrossProfileCallerId)); }
            set { BackingStore?.Set(nameof(WorkProfileBlockCrossProfileCallerId), value); }
        }
        /// <summary>Block work profile contacts availability in personal profile.</summary>
        public bool? WorkProfileBlockCrossProfileContactsSearch {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBlockCrossProfileContactsSearch)); }
            set { BackingStore?.Set(nameof(WorkProfileBlockCrossProfileContactsSearch), value); }
        }
        /// <summary>Boolean that indicates if the setting disallow cross profile copy/paste is enabled.</summary>
        public bool? WorkProfileBlockCrossProfileCopyPaste {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBlockCrossProfileCopyPaste)); }
            set { BackingStore?.Set(nameof(WorkProfileBlockCrossProfileCopyPaste), value); }
        }
        /// <summary>Indicates whether or not to block notifications while device locked.</summary>
        public bool? WorkProfileBlockNotificationsWhileDeviceLocked {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBlockNotificationsWhileDeviceLocked)); }
            set { BackingStore?.Set(nameof(WorkProfileBlockNotificationsWhileDeviceLocked), value); }
        }
        /// <summary>Prevent app installations from unknown sources in the personal profile.</summary>
        public bool? WorkProfileBlockPersonalAppInstallsFromUnknownSources {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBlockPersonalAppInstallsFromUnknownSources)); }
            set { BackingStore?.Set(nameof(WorkProfileBlockPersonalAppInstallsFromUnknownSources), value); }
        }
        /// <summary>Block screen capture in work profile.</summary>
        public bool? WorkProfileBlockScreenCapture {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBlockScreenCapture)); }
            set { BackingStore?.Set(nameof(WorkProfileBlockScreenCapture), value); }
        }
        /// <summary>Allow bluetooth devices to access enterprise contacts.</summary>
        public bool? WorkProfileBluetoothEnableContactSharing {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileBluetoothEnableContactSharing)); }
            set { BackingStore?.Set(nameof(WorkProfileBluetoothEnableContactSharing), value); }
        }
        /// <summary>Type of data sharing that is allowed. Possible values are: deviceDefault, preventAny, allowPersonalToWork, noRestrictions.</summary>
        public AndroidWorkProfileCrossProfileDataSharingType? WorkProfileDataSharingType {
            get { return BackingStore?.Get<AndroidWorkProfileCrossProfileDataSharingType?>(nameof(WorkProfileDataSharingType)); }
            set { BackingStore?.Set(nameof(WorkProfileDataSharingType), value); }
        }
        /// <summary>Type of password that is required. Possible values are: deviceDefault, prompt, autoGrant, autoDeny.</summary>
        public AndroidWorkProfileDefaultAppPermissionPolicyType? WorkProfileDefaultAppPermissionPolicy {
            get { return BackingStore?.Get<AndroidWorkProfileDefaultAppPermissionPolicyType?>(nameof(WorkProfileDefaultAppPermissionPolicy)); }
            set { BackingStore?.Set(nameof(WorkProfileDefaultAppPermissionPolicy), value); }
        }
        /// <summary>Indicates whether or not to block face unlock for work profile.</summary>
        public bool? WorkProfilePasswordBlockFaceUnlock {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfilePasswordBlockFaceUnlock)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordBlockFaceUnlock), value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock for work profile.</summary>
        public bool? WorkProfilePasswordBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfilePasswordBlockFingerprintUnlock)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordBlockFingerprintUnlock), value); }
        }
        /// <summary>Indicates whether or not to block iris unlock for work profile.</summary>
        public bool? WorkProfilePasswordBlockIrisUnlock {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfilePasswordBlockIrisUnlock)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordBlockIrisUnlock), value); }
        }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents for work profile.</summary>
        public bool? WorkProfilePasswordBlockTrustAgents {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfilePasswordBlockTrustAgents)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordBlockTrustAgents), value); }
        }
        /// <summary>Number of days before the work profile password expires. Valid values 1 to 365</summary>
        public int? WorkProfilePasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordExpirationDays), value); }
        }
        /// <summary>Minimum length of work profile password. Valid values 4 to 16</summary>
        public int? WorkProfilePasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinimumLength), value); }
        }
        /// <summary>Minimum # of letter characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinLetterCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinLetterCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinLetterCharacters), value); }
        }
        /// <summary>Minimum # of lower-case characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinLowerCaseCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinLowerCaseCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinLowerCaseCharacters), value); }
        }
        /// <summary>Minimum # of non-letter characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinNonLetterCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinNonLetterCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinNonLetterCharacters), value); }
        }
        /// <summary>Minimum # of numeric characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinNumericCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinNumericCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinNumericCharacters), value); }
        }
        /// <summary>Minimum # of symbols required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinSymbolCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinSymbolCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinSymbolCharacters), value); }
        }
        /// <summary>Minimum # of upper-case characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinUpperCaseCharacters {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinUpperCaseCharacters)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinUpperCaseCharacters), value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout), value); }
        }
        /// <summary>Number of previous work profile passwords to block. Valid values 0 to 24</summary>
        public int? WorkProfilePasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>Type of work profile password that is required. Possible values are: deviceDefault, lowSecurityBiometric, required, atLeastNumeric, numericComplex, atLeastAlphabetic, atLeastAlphanumeric, alphanumericWithSymbols.</summary>
        public AndroidWorkProfileRequiredPasswordType? WorkProfilePasswordRequiredType {
            get { return BackingStore?.Get<AndroidWorkProfileRequiredPasswordType?>(nameof(WorkProfilePasswordRequiredType)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordRequiredType), value); }
        }
        /// <summary>Number of sign in failures allowed before work profile is removed and all corporate data deleted. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>(nameof(WorkProfilePasswordSignInFailureCountBeforeFactoryReset)); }
            set { BackingStore?.Set(nameof(WorkProfilePasswordSignInFailureCountBeforeFactoryReset), value); }
        }
        /// <summary>Password is required or not for work profile</summary>
        public bool? WorkProfileRequirePassword {
            get { return BackingStore?.Get<bool?>(nameof(WorkProfileRequirePassword)); }
            set { BackingStore?.Set(nameof(WorkProfileRequirePassword), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidWorkProfileGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidWorkProfileGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"passwordBlockFaceUnlock", n => { PasswordBlockFaceUnlock = n.GetBoolValue(); } },
                {"passwordBlockFingerprintUnlock", n => { PasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passwordBlockIrisUnlock", n => { PasswordBlockIrisUnlock = n.GetBoolValue(); } },
                {"passwordBlockTrustAgents", n => { PasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidWorkProfileRequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"vpnAlwaysOnPackageIdentifier", n => { VpnAlwaysOnPackageIdentifier = n.GetStringValue(); } },
                {"vpnEnableAlwaysOnLockdownMode", n => { VpnEnableAlwaysOnLockdownMode = n.GetBoolValue(); } },
                {"workProfileAllowAppInstallsFromUnknownSources", n => { WorkProfileAllowAppInstallsFromUnknownSources = n.GetBoolValue(); } },
                {"workProfileAllowWidgets", n => { WorkProfileAllowWidgets = n.GetBoolValue(); } },
                {"workProfileBlockAddingAccounts", n => { WorkProfileBlockAddingAccounts = n.GetBoolValue(); } },
                {"workProfileBlockCamera", n => { WorkProfileBlockCamera = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileCallerId", n => { WorkProfileBlockCrossProfileCallerId = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileContactsSearch", n => { WorkProfileBlockCrossProfileContactsSearch = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileCopyPaste", n => { WorkProfileBlockCrossProfileCopyPaste = n.GetBoolValue(); } },
                {"workProfileBlockNotificationsWhileDeviceLocked", n => { WorkProfileBlockNotificationsWhileDeviceLocked = n.GetBoolValue(); } },
                {"workProfileBlockPersonalAppInstallsFromUnknownSources", n => { WorkProfileBlockPersonalAppInstallsFromUnknownSources = n.GetBoolValue(); } },
                {"workProfileBlockScreenCapture", n => { WorkProfileBlockScreenCapture = n.GetBoolValue(); } },
                {"workProfileBluetoothEnableContactSharing", n => { WorkProfileBluetoothEnableContactSharing = n.GetBoolValue(); } },
                {"workProfileDataSharingType", n => { WorkProfileDataSharingType = n.GetEnumValue<AndroidWorkProfileCrossProfileDataSharingType>(); } },
                {"workProfileDefaultAppPermissionPolicy", n => { WorkProfileDefaultAppPermissionPolicy = n.GetEnumValue<AndroidWorkProfileDefaultAppPermissionPolicyType>(); } },
                {"workProfilePasswordBlockFaceUnlock", n => { WorkProfilePasswordBlockFaceUnlock = n.GetBoolValue(); } },
                {"workProfilePasswordBlockFingerprintUnlock", n => { WorkProfilePasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"workProfilePasswordBlockIrisUnlock", n => { WorkProfilePasswordBlockIrisUnlock = n.GetBoolValue(); } },
                {"workProfilePasswordBlockTrustAgents", n => { WorkProfilePasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"workProfilePasswordExpirationDays", n => { WorkProfilePasswordExpirationDays = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLength", n => { WorkProfilePasswordMinimumLength = n.GetIntValue(); } },
                {"workProfilePasswordMinLetterCharacters", n => { WorkProfilePasswordMinLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinLowerCaseCharacters", n => { WorkProfilePasswordMinLowerCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinNonLetterCharacters", n => { WorkProfilePasswordMinNonLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinNumericCharacters", n => { WorkProfilePasswordMinNumericCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinSymbolCharacters", n => { WorkProfilePasswordMinSymbolCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinUpperCaseCharacters", n => { WorkProfilePasswordMinUpperCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", n => { WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"workProfilePasswordPreviousPasswordBlockCount", n => { WorkProfilePasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"workProfilePasswordRequiredType", n => { WorkProfilePasswordRequiredType = n.GetEnumValue<AndroidWorkProfileRequiredPasswordType>(); } },
                {"workProfilePasswordSignInFailureCountBeforeFactoryReset", n => { WorkProfilePasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"workProfileRequirePassword", n => { WorkProfileRequirePassword = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("passwordBlockFaceUnlock", PasswordBlockFaceUnlock);
            writer.WriteBoolValue("passwordBlockFingerprintUnlock", PasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("passwordBlockIrisUnlock", PasswordBlockIrisUnlock);
            writer.WriteBoolValue("passwordBlockTrustAgents", PasswordBlockTrustAgents);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<AndroidWorkProfileRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteStringValue("vpnAlwaysOnPackageIdentifier", VpnAlwaysOnPackageIdentifier);
            writer.WriteBoolValue("vpnEnableAlwaysOnLockdownMode", VpnEnableAlwaysOnLockdownMode);
            writer.WriteBoolValue("workProfileAllowAppInstallsFromUnknownSources", WorkProfileAllowAppInstallsFromUnknownSources);
            writer.WriteBoolValue("workProfileAllowWidgets", WorkProfileAllowWidgets);
            writer.WriteBoolValue("workProfileBlockAddingAccounts", WorkProfileBlockAddingAccounts);
            writer.WriteBoolValue("workProfileBlockCamera", WorkProfileBlockCamera);
            writer.WriteBoolValue("workProfileBlockCrossProfileCallerId", WorkProfileBlockCrossProfileCallerId);
            writer.WriteBoolValue("workProfileBlockCrossProfileContactsSearch", WorkProfileBlockCrossProfileContactsSearch);
            writer.WriteBoolValue("workProfileBlockCrossProfileCopyPaste", WorkProfileBlockCrossProfileCopyPaste);
            writer.WriteBoolValue("workProfileBlockNotificationsWhileDeviceLocked", WorkProfileBlockNotificationsWhileDeviceLocked);
            writer.WriteBoolValue("workProfileBlockPersonalAppInstallsFromUnknownSources", WorkProfileBlockPersonalAppInstallsFromUnknownSources);
            writer.WriteBoolValue("workProfileBlockScreenCapture", WorkProfileBlockScreenCapture);
            writer.WriteBoolValue("workProfileBluetoothEnableContactSharing", WorkProfileBluetoothEnableContactSharing);
            writer.WriteEnumValue<AndroidWorkProfileCrossProfileDataSharingType>("workProfileDataSharingType", WorkProfileDataSharingType);
            writer.WriteEnumValue<AndroidWorkProfileDefaultAppPermissionPolicyType>("workProfileDefaultAppPermissionPolicy", WorkProfileDefaultAppPermissionPolicy);
            writer.WriteBoolValue("workProfilePasswordBlockFaceUnlock", WorkProfilePasswordBlockFaceUnlock);
            writer.WriteBoolValue("workProfilePasswordBlockFingerprintUnlock", WorkProfilePasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("workProfilePasswordBlockIrisUnlock", WorkProfilePasswordBlockIrisUnlock);
            writer.WriteBoolValue("workProfilePasswordBlockTrustAgents", WorkProfilePasswordBlockTrustAgents);
            writer.WriteIntValue("workProfilePasswordExpirationDays", WorkProfilePasswordExpirationDays);
            writer.WriteIntValue("workProfilePasswordMinimumLength", WorkProfilePasswordMinimumLength);
            writer.WriteIntValue("workProfilePasswordMinLetterCharacters", WorkProfilePasswordMinLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinLowerCaseCharacters", WorkProfilePasswordMinLowerCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinNonLetterCharacters", WorkProfilePasswordMinNonLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinNumericCharacters", WorkProfilePasswordMinNumericCharacters);
            writer.WriteIntValue("workProfilePasswordMinSymbolCharacters", WorkProfilePasswordMinSymbolCharacters);
            writer.WriteIntValue("workProfilePasswordMinUpperCaseCharacters", WorkProfilePasswordMinUpperCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("workProfilePasswordPreviousPasswordBlockCount", WorkProfilePasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<AndroidWorkProfileRequiredPasswordType>("workProfilePasswordRequiredType", WorkProfilePasswordRequiredType);
            writer.WriteIntValue("workProfilePasswordSignInFailureCountBeforeFactoryReset", WorkProfilePasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("workProfileRequirePassword", WorkProfileRequirePassword);
        }
    }
}
