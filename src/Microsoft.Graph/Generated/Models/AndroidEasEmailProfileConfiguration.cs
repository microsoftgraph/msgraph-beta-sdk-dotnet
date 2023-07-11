using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// By providing configurations in this profile you can instruct the native email client on KNOX devices to communicate with an Exchange server and get email, contacts, calendar, tasks, and notes. Furthermore, you can also specify how much email to sync and how often the device should sync.
    /// </summary>
    public class AndroidEasEmailProfileConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Exchange ActiveSync account name, displayed to users as name of EAS (this) profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName {
            get { return BackingStore?.Get<string?>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#nullable restore
#else
        public string AccountName {
            get { return BackingStore?.Get<string>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#endif
        /// <summary>Exchange Active Sync authentication method.</summary>
        public EasAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<EasAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Custom domain name value used while generating an email profile before installing on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDomainName {
            get { return BackingStore?.Get<string?>("customDomainName"); }
            set { BackingStore?.Set("customDomainName", value); }
        }
#nullable restore
#else
        public string CustomDomainName {
            get { return BackingStore?.Get<string>("customDomainName"); }
            set { BackingStore?.Set("customDomainName", value); }
        }
#endif
        /// <summary>Possible values for email sync duration.</summary>
        public EmailSyncDuration? DurationOfEmailToSync {
            get { return BackingStore?.Get<EmailSyncDuration?>("durationOfEmailToSync"); }
            set { BackingStore?.Set("durationOfEmailToSync", value); }
        }
        /// <summary>Possible values for username source or email source.</summary>
        public UserEmailSource? EmailAddressSource {
            get { return BackingStore?.Get<UserEmailSource?>("emailAddressSource"); }
            set { BackingStore?.Set("emailAddressSource", value); }
        }
        /// <summary>Possible values for email sync schedule.</summary>
        public Microsoft.Graph.Beta.Models.EmailSyncSchedule? EmailSyncSchedule {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailSyncSchedule?>("emailSyncSchedule"); }
            set { BackingStore?.Set("emailSyncSchedule", value); }
        }
        /// <summary>Exchange location (URL) that the native mail app connects to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostName {
            get { return BackingStore?.Get<string?>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
#nullable restore
#else
        public string HostName {
            get { return BackingStore?.Get<string>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
#endif
        /// <summary>Identity certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidCertificateProfileBase? IdentityCertificate {
            get { return BackingStore?.Get<AndroidCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public AndroidCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Indicates whether or not to use S/MIME certificate.</summary>
        public bool? RequireSmime {
            get { return BackingStore?.Get<bool?>("requireSmime"); }
            set { BackingStore?.Set("requireSmime", value); }
        }
        /// <summary>Indicates whether or not to use SSL.</summary>
        public bool? RequireSsl {
            get { return BackingStore?.Get<bool?>("requireSsl"); }
            set { BackingStore?.Set("requireSsl", value); }
        }
        /// <summary>S/MIME signing certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidCertificateProfileBase? SmimeSigningCertificate {
            get { return BackingStore?.Get<AndroidCertificateProfileBase?>("smimeSigningCertificate"); }
            set { BackingStore?.Set("smimeSigningCertificate", value); }
        }
#nullable restore
#else
        public AndroidCertificateProfileBase SmimeSigningCertificate {
            get { return BackingStore?.Get<AndroidCertificateProfileBase>("smimeSigningCertificate"); }
            set { BackingStore?.Set("smimeSigningCertificate", value); }
        }
#endif
        /// <summary>Toggles syncing the calendar. If set to false calendar is turned off on the device.</summary>
        public bool? SyncCalendar {
            get { return BackingStore?.Get<bool?>("syncCalendar"); }
            set { BackingStore?.Set("syncCalendar", value); }
        }
        /// <summary>Toggles syncing contacts. If set to false contacts are turned off on the device.</summary>
        public bool? SyncContacts {
            get { return BackingStore?.Get<bool?>("syncContacts"); }
            set { BackingStore?.Set("syncContacts", value); }
        }
        /// <summary>Toggles syncing notes. If set to false notes are turned off on the device.</summary>
        public bool? SyncNotes {
            get { return BackingStore?.Get<bool?>("syncNotes"); }
            set { BackingStore?.Set("syncNotes", value); }
        }
        /// <summary>Toggles syncing tasks. If set to false tasks are turned off on the device.</summary>
        public bool? SyncTasks {
            get { return BackingStore?.Get<bool?>("syncTasks"); }
            set { BackingStore?.Set("syncTasks", value); }
        }
        /// <summary>UserDomainname attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: fullDomainName, netBiosDomainName.</summary>
        public DomainNameSource? UserDomainNameSource {
            get { return BackingStore?.Get<DomainNameSource?>("userDomainNameSource"); }
            set { BackingStore?.Set("userDomainNameSource", value); }
        }
        /// <summary>Android username source.</summary>
        public AndroidUsernameSource? UsernameSource {
            get { return BackingStore?.Get<AndroidUsernameSource?>("usernameSource"); }
            set { BackingStore?.Set("usernameSource", value); }
        }
        /// <summary>
        /// Instantiates a new androidEasEmailProfileConfiguration and sets the default values.
        /// </summary>
        public AndroidEasEmailProfileConfiguration() : base() {
            OdataType = "#microsoft.graph.androidEasEmailProfileConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
