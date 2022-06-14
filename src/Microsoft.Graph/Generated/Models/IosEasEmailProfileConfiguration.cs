using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosEasEmailProfileConfiguration : EasEmailProfileConfigurationBase, IParsable {
        /// <summary>Account name.</summary>
        public string AccountName {
            get { return BackingStore?.Get<string>(nameof(AccountName)); }
            set { BackingStore?.Set(nameof(AccountName), value); }
        }
        /// <summary>Authentication method for this Email profile. Possible values are: usernameAndPassword, certificate, derivedCredential.</summary>
        public EasAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<EasAuthenticationMethod?>(nameof(AuthenticationMethod)); }
            set { BackingStore?.Set(nameof(AuthenticationMethod), value); }
        }
        /// <summary>Indicates whether or not to block moving messages to other email accounts.</summary>
        public bool? BlockMovingMessagesToOtherEmailAccounts {
            get { return BackingStore?.Get<bool?>(nameof(BlockMovingMessagesToOtherEmailAccounts)); }
            set { BackingStore?.Set(nameof(BlockMovingMessagesToOtherEmailAccounts), value); }
        }
        /// <summary>Indicates whether or not to block sending email from third party apps.</summary>
        public bool? BlockSendingEmailFromThirdPartyApps {
            get { return BackingStore?.Get<bool?>(nameof(BlockSendingEmailFromThirdPartyApps)); }
            set { BackingStore?.Set(nameof(BlockSendingEmailFromThirdPartyApps), value); }
        }
        /// <summary>Indicates whether or not to block syncing recently used email addresses, for instance - when composing new email.</summary>
        public bool? BlockSyncingRecentlyUsedEmailAddresses {
            get { return BackingStore?.Get<bool?>(nameof(BlockSyncingRecentlyUsedEmailAddresses)); }
            set { BackingStore?.Set(nameof(BlockSyncingRecentlyUsedEmailAddresses), value); }
        }
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings>(nameof(DerivedCredentialSettings)); }
            set { BackingStore?.Set(nameof(DerivedCredentialSettings), value); }
        }
        /// <summary>Duration of time email should be synced back to. . Possible values are: userDefined, oneDay, threeDays, oneWeek, twoWeeks, oneMonth, unlimited.</summary>
        public EmailSyncDuration? DurationOfEmailToSync {
            get { return BackingStore?.Get<EmailSyncDuration?>(nameof(DurationOfEmailToSync)); }
            set { BackingStore?.Set(nameof(DurationOfEmailToSync), value); }
        }
        /// <summary>Exchange data to sync. Possible values are: none, calendars, contacts, email, notes, reminders.</summary>
        public Microsoft.Graph.Beta.Models.EasServices? EasServices {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EasServices?>(nameof(EasServices)); }
            set { BackingStore?.Set(nameof(EasServices), value); }
        }
        /// <summary>Allow users to change sync settings.</summary>
        public bool? EasServicesUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>(nameof(EasServicesUserOverrideEnabled)); }
            set { BackingStore?.Set(nameof(EasServicesUserOverrideEnabled), value); }
        }
        /// <summary>Email attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: userPrincipalName, primarySmtpAddress.</summary>
        public UserEmailSource? EmailAddressSource {
            get { return BackingStore?.Get<UserEmailSource?>(nameof(EmailAddressSource)); }
            set { BackingStore?.Set(nameof(EmailAddressSource), value); }
        }
        /// <summary>Encryption Certificate type for this Email profile. Possible values are: none, certificate, derivedCredential.</summary>
        public EmailCertificateType? EncryptionCertificateType {
            get { return BackingStore?.Get<EmailCertificateType?>(nameof(EncryptionCertificateType)); }
            set { BackingStore?.Set(nameof(EncryptionCertificateType), value); }
        }
        /// <summary>Exchange location that (URL) that the native mail app connects to.</summary>
        public string HostName {
            get { return BackingStore?.Get<string>(nameof(HostName)); }
            set { BackingStore?.Set(nameof(HostName), value); }
        }
        /// <summary>Identity certificate.</summary>
        public IosCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<IosCertificateProfileBase>(nameof(IdentityCertificate)); }
            set { BackingStore?.Set(nameof(IdentityCertificate), value); }
        }
        /// <summary>Profile ID of the Per-App VPN policy to be used to access emails from the native Mail client</summary>
        public string PerAppVPNProfileId {
            get { return BackingStore?.Get<string>(nameof(PerAppVPNProfileId)); }
            set { BackingStore?.Set(nameof(PerAppVPNProfileId), value); }
        }
        /// <summary>Indicates whether or not to use S/MIME certificate.</summary>
        public bool? RequireSmime {
            get { return BackingStore?.Get<bool?>(nameof(RequireSmime)); }
            set { BackingStore?.Set(nameof(RequireSmime), value); }
        }
        /// <summary>Indicates whether or not to use SSL.</summary>
        public bool? RequireSsl {
            get { return BackingStore?.Get<bool?>(nameof(RequireSsl)); }
            set { BackingStore?.Set(nameof(RequireSsl), value); }
        }
        /// <summary>Signing Certificate type for this Email profile. Possible values are: none, certificate, derivedCredential.</summary>
        public EmailCertificateType? SigningCertificateType {
            get { return BackingStore?.Get<EmailCertificateType?>(nameof(SigningCertificateType)); }
            set { BackingStore?.Set(nameof(SigningCertificateType), value); }
        }
        /// <summary>Indicates whether or not to allow unencrypted emails.</summary>
        public bool? SmimeEnablePerMessageSwitch {
            get { return BackingStore?.Get<bool?>(nameof(SmimeEnablePerMessageSwitch)); }
            set { BackingStore?.Set(nameof(SmimeEnablePerMessageSwitch), value); }
        }
        /// <summary>If set to true S/MIME encryption is enabled by default.</summary>
        public bool? SmimeEncryptByDefaultEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SmimeEncryptByDefaultEnabled)); }
            set { BackingStore?.Set(nameof(SmimeEncryptByDefaultEnabled), value); }
        }
        /// <summary>If set to true, the user can toggle the encryption by default setting.</summary>
        public bool? SmimeEncryptByDefaultUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SmimeEncryptByDefaultUserOverrideEnabled)); }
            set { BackingStore?.Set(nameof(SmimeEncryptByDefaultUserOverrideEnabled), value); }
        }
        /// <summary>S/MIME encryption certificate.</summary>
        public IosCertificateProfile SmimeEncryptionCertificate {
            get { return BackingStore?.Get<IosCertificateProfile>(nameof(SmimeEncryptionCertificate)); }
            set { BackingStore?.Set(nameof(SmimeEncryptionCertificate), value); }
        }
        /// <summary>If set to true the user can select the S/MIME encryption identity.</summary>
        public bool? SmimeEncryptionCertificateUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SmimeEncryptionCertificateUserOverrideEnabled)); }
            set { BackingStore?.Set(nameof(SmimeEncryptionCertificateUserOverrideEnabled), value); }
        }
        /// <summary>S/MIME signing certificate.</summary>
        public IosCertificateProfile SmimeSigningCertificate {
            get { return BackingStore?.Get<IosCertificateProfile>(nameof(SmimeSigningCertificate)); }
            set { BackingStore?.Set(nameof(SmimeSigningCertificate), value); }
        }
        /// <summary>If set to true, the user can select the signing identity.</summary>
        public bool? SmimeSigningCertificateUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SmimeSigningCertificateUserOverrideEnabled)); }
            set { BackingStore?.Set(nameof(SmimeSigningCertificateUserOverrideEnabled), value); }
        }
        /// <summary>If set to true S/MIME signing is enabled for this account</summary>
        public bool? SmimeSigningEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SmimeSigningEnabled)); }
            set { BackingStore?.Set(nameof(SmimeSigningEnabled), value); }
        }
        /// <summary>If set to true, the user can toggle S/MIME signing on or off.</summary>
        public bool? SmimeSigningUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SmimeSigningUserOverrideEnabled)); }
            set { BackingStore?.Set(nameof(SmimeSigningUserOverrideEnabled), value); }
        }
        /// <summary>Specifies whether the connection should use OAuth for authentication.</summary>
        public bool? UseOAuth {
            get { return BackingStore?.Get<bool?>(nameof(UseOAuth)); }
            set { BackingStore?.Set(nameof(UseOAuth), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosEasEmailProfileConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosEasEmailProfileConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<EasAuthenticationMethod>(); } },
                {"blockMovingMessagesToOtherEmailAccounts", n => { BlockMovingMessagesToOtherEmailAccounts = n.GetBoolValue(); } },
                {"blockSendingEmailFromThirdPartyApps", n => { BlockSendingEmailFromThirdPartyApps = n.GetBoolValue(); } },
                {"blockSyncingRecentlyUsedEmailAddresses", n => { BlockSyncingRecentlyUsedEmailAddresses = n.GetBoolValue(); } },
                {"derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                {"durationOfEmailToSync", n => { DurationOfEmailToSync = n.GetEnumValue<EmailSyncDuration>(); } },
                {"easServices", n => { EasServices = n.GetEnumValue<EasServices>(); } },
                {"easServicesUserOverrideEnabled", n => { EasServicesUserOverrideEnabled = n.GetBoolValue(); } },
                {"emailAddressSource", n => { EmailAddressSource = n.GetEnumValue<UserEmailSource>(); } },
                {"encryptionCertificateType", n => { EncryptionCertificateType = n.GetEnumValue<EmailCertificateType>(); } },
                {"hostName", n => { HostName = n.GetStringValue(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<IosCertificateProfileBase>(IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"perAppVPNProfileId", n => { PerAppVPNProfileId = n.GetStringValue(); } },
                {"requireSmime", n => { RequireSmime = n.GetBoolValue(); } },
                {"requireSsl", n => { RequireSsl = n.GetBoolValue(); } },
                {"signingCertificateType", n => { SigningCertificateType = n.GetEnumValue<EmailCertificateType>(); } },
                {"smimeEnablePerMessageSwitch", n => { SmimeEnablePerMessageSwitch = n.GetBoolValue(); } },
                {"smimeEncryptByDefaultEnabled", n => { SmimeEncryptByDefaultEnabled = n.GetBoolValue(); } },
                {"smimeEncryptByDefaultUserOverrideEnabled", n => { SmimeEncryptByDefaultUserOverrideEnabled = n.GetBoolValue(); } },
                {"smimeEncryptionCertificate", n => { SmimeEncryptionCertificate = n.GetObjectValue<IosCertificateProfile>(IosCertificateProfile.CreateFromDiscriminatorValue); } },
                {"smimeEncryptionCertificateUserOverrideEnabled", n => { SmimeEncryptionCertificateUserOverrideEnabled = n.GetBoolValue(); } },
                {"smimeSigningCertificate", n => { SmimeSigningCertificate = n.GetObjectValue<IosCertificateProfile>(IosCertificateProfile.CreateFromDiscriminatorValue); } },
                {"smimeSigningCertificateUserOverrideEnabled", n => { SmimeSigningCertificateUserOverrideEnabled = n.GetBoolValue(); } },
                {"smimeSigningEnabled", n => { SmimeSigningEnabled = n.GetBoolValue(); } },
                {"smimeSigningUserOverrideEnabled", n => { SmimeSigningUserOverrideEnabled = n.GetBoolValue(); } },
                {"useOAuth", n => { UseOAuth = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteEnumValue<EasAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteBoolValue("blockMovingMessagesToOtherEmailAccounts", BlockMovingMessagesToOtherEmailAccounts);
            writer.WriteBoolValue("blockSendingEmailFromThirdPartyApps", BlockSendingEmailFromThirdPartyApps);
            writer.WriteBoolValue("blockSyncingRecentlyUsedEmailAddresses", BlockSyncingRecentlyUsedEmailAddresses);
            writer.WriteObjectValue<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteEnumValue<EmailSyncDuration>("durationOfEmailToSync", DurationOfEmailToSync);
            writer.WriteEnumValue<EasServices>("easServices", EasServices);
            writer.WriteBoolValue("easServicesUserOverrideEnabled", EasServicesUserOverrideEnabled);
            writer.WriteEnumValue<UserEmailSource>("emailAddressSource", EmailAddressSource);
            writer.WriteEnumValue<EmailCertificateType>("encryptionCertificateType", EncryptionCertificateType);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteObjectValue<IosCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("perAppVPNProfileId", PerAppVPNProfileId);
            writer.WriteBoolValue("requireSmime", RequireSmime);
            writer.WriteBoolValue("requireSsl", RequireSsl);
            writer.WriteEnumValue<EmailCertificateType>("signingCertificateType", SigningCertificateType);
            writer.WriteBoolValue("smimeEnablePerMessageSwitch", SmimeEnablePerMessageSwitch);
            writer.WriteBoolValue("smimeEncryptByDefaultEnabled", SmimeEncryptByDefaultEnabled);
            writer.WriteBoolValue("smimeEncryptByDefaultUserOverrideEnabled", SmimeEncryptByDefaultUserOverrideEnabled);
            writer.WriteObjectValue<IosCertificateProfile>("smimeEncryptionCertificate", SmimeEncryptionCertificate);
            writer.WriteBoolValue("smimeEncryptionCertificateUserOverrideEnabled", SmimeEncryptionCertificateUserOverrideEnabled);
            writer.WriteObjectValue<IosCertificateProfile>("smimeSigningCertificate", SmimeSigningCertificate);
            writer.WriteBoolValue("smimeSigningCertificateUserOverrideEnabled", SmimeSigningCertificateUserOverrideEnabled);
            writer.WriteBoolValue("smimeSigningEnabled", SmimeSigningEnabled);
            writer.WriteBoolValue("smimeSigningUserOverrideEnabled", SmimeSigningUserOverrideEnabled);
            writer.WriteBoolValue("useOAuth", UseOAuth);
        }
    }
}
