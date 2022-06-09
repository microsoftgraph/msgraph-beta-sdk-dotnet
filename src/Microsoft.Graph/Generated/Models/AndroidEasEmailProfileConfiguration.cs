using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidEasEmailProfileConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Exchange ActiveSync account name, displayed to users as name of EAS (this) profile.</summary>
        public string AccountName {
            get { return BackingStore?.Get<string>(nameof(AccountName)); }
            set { BackingStore?.Set(nameof(AccountName), value); }
        }
        /// <summary>Authentication method for Exchange ActiveSync. Possible values are: usernameAndPassword, certificate, derivedCredential.</summary>
        public EasAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<EasAuthenticationMethod?>(nameof(AuthenticationMethod)); }
            set { BackingStore?.Set(nameof(AuthenticationMethod), value); }
        }
        /// <summary>Custom domain name value used while generating an email profile before installing on the device.</summary>
        public string CustomDomainName {
            get { return BackingStore?.Get<string>(nameof(CustomDomainName)); }
            set { BackingStore?.Set(nameof(CustomDomainName), value); }
        }
        /// <summary>Duration of time email should be synced to. Possible values are: userDefined, oneDay, threeDays, oneWeek, twoWeeks, oneMonth, unlimited.</summary>
        public EmailSyncDuration? DurationOfEmailToSync {
            get { return BackingStore?.Get<EmailSyncDuration?>(nameof(DurationOfEmailToSync)); }
            set { BackingStore?.Set(nameof(DurationOfEmailToSync), value); }
        }
        /// <summary>Email attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: userPrincipalName, primarySmtpAddress.</summary>
        public UserEmailSource? EmailAddressSource {
            get { return BackingStore?.Get<UserEmailSource?>(nameof(EmailAddressSource)); }
            set { BackingStore?.Set(nameof(EmailAddressSource), value); }
        }
        /// <summary>Email sync schedule. Possible values are: userDefined, asMessagesArrive, manual, fifteenMinutes, thirtyMinutes, sixtyMinutes, basedOnMyUsage.</summary>
        public Microsoft.Graph.Beta.Models.EmailSyncSchedule? EmailSyncSchedule {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailSyncSchedule?>(nameof(EmailSyncSchedule)); }
            set { BackingStore?.Set(nameof(EmailSyncSchedule), value); }
        }
        /// <summary>Exchange location (URL) that the native mail app connects to.</summary>
        public string HostName {
            get { return BackingStore?.Get<string>(nameof(HostName)); }
            set { BackingStore?.Set(nameof(HostName), value); }
        }
        /// <summary>Identity certificate.</summary>
        public AndroidCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidCertificateProfileBase>(nameof(IdentityCertificate)); }
            set { BackingStore?.Set(nameof(IdentityCertificate), value); }
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
        /// <summary>S/MIME signing certificate.</summary>
        public AndroidCertificateProfileBase SmimeSigningCertificate {
            get { return BackingStore?.Get<AndroidCertificateProfileBase>(nameof(SmimeSigningCertificate)); }
            set { BackingStore?.Set(nameof(SmimeSigningCertificate), value); }
        }
        /// <summary>Toggles syncing the calendar. If set to false calendar is turned off on the device.</summary>
        public bool? SyncCalendar {
            get { return BackingStore?.Get<bool?>(nameof(SyncCalendar)); }
            set { BackingStore?.Set(nameof(SyncCalendar), value); }
        }
        /// <summary>Toggles syncing contacts. If set to false contacts are turned off on the device.</summary>
        public bool? SyncContacts {
            get { return BackingStore?.Get<bool?>(nameof(SyncContacts)); }
            set { BackingStore?.Set(nameof(SyncContacts), value); }
        }
        /// <summary>Toggles syncing notes. If set to false notes are turned off on the device.</summary>
        public bool? SyncNotes {
            get { return BackingStore?.Get<bool?>(nameof(SyncNotes)); }
            set { BackingStore?.Set(nameof(SyncNotes), value); }
        }
        /// <summary>Toggles syncing tasks. If set to false tasks are turned off on the device.</summary>
        public bool? SyncTasks {
            get { return BackingStore?.Get<bool?>(nameof(SyncTasks)); }
            set { BackingStore?.Set(nameof(SyncTasks), value); }
        }
        /// <summary>UserDomainname attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: fullDomainName, netBiosDomainName.</summary>
        public DomainNameSource? UserDomainNameSource {
            get { return BackingStore?.Get<DomainNameSource?>(nameof(UserDomainNameSource)); }
            set { BackingStore?.Set(nameof(UserDomainNameSource), value); }
        }
        /// <summary>Username attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: username, userPrincipalName, samAccountName, primarySmtpAddress.</summary>
        public AndroidUsernameSource? UsernameSource {
            get { return BackingStore?.Get<AndroidUsernameSource?>(nameof(UsernameSource)); }
            set { BackingStore?.Set(nameof(UsernameSource), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidEasEmailProfileConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidEasEmailProfileConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<EasAuthenticationMethod>(); } },
                {"customDomainName", n => { CustomDomainName = n.GetStringValue(); } },
                {"durationOfEmailToSync", n => { DurationOfEmailToSync = n.GetEnumValue<EmailSyncDuration>(); } },
                {"emailAddressSource", n => { EmailAddressSource = n.GetEnumValue<UserEmailSource>(); } },
                {"emailSyncSchedule", n => { EmailSyncSchedule = n.GetEnumValue<EmailSyncSchedule>(); } },
                {"hostName", n => { HostName = n.GetStringValue(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidCertificateProfileBase>(AndroidCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"requireSmime", n => { RequireSmime = n.GetBoolValue(); } },
                {"requireSsl", n => { RequireSsl = n.GetBoolValue(); } },
                {"smimeSigningCertificate", n => { SmimeSigningCertificate = n.GetObjectValue<AndroidCertificateProfileBase>(AndroidCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"syncCalendar", n => { SyncCalendar = n.GetBoolValue(); } },
                {"syncContacts", n => { SyncContacts = n.GetBoolValue(); } },
                {"syncNotes", n => { SyncNotes = n.GetBoolValue(); } },
                {"syncTasks", n => { SyncTasks = n.GetBoolValue(); } },
                {"userDomainNameSource", n => { UserDomainNameSource = n.GetEnumValue<DomainNameSource>(); } },
                {"usernameSource", n => { UsernameSource = n.GetEnumValue<AndroidUsernameSource>(); } },
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
            writer.WriteStringValue("customDomainName", CustomDomainName);
            writer.WriteEnumValue<EmailSyncDuration>("durationOfEmailToSync", DurationOfEmailToSync);
            writer.WriteEnumValue<UserEmailSource>("emailAddressSource", EmailAddressSource);
            writer.WriteEnumValue<EmailSyncSchedule>("emailSyncSchedule", EmailSyncSchedule);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteObjectValue<AndroidCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteBoolValue("requireSmime", RequireSmime);
            writer.WriteBoolValue("requireSsl", RequireSsl);
            writer.WriteObjectValue<AndroidCertificateProfileBase>("smimeSigningCertificate", SmimeSigningCertificate);
            writer.WriteBoolValue("syncCalendar", SyncCalendar);
            writer.WriteBoolValue("syncContacts", SyncContacts);
            writer.WriteBoolValue("syncNotes", SyncNotes);
            writer.WriteBoolValue("syncTasks", SyncTasks);
            writer.WriteEnumValue<DomainNameSource>("userDomainNameSource", UserDomainNameSource);
            writer.WriteEnumValue<AndroidUsernameSource>("usernameSource", UsernameSource);
        }
    }
}
