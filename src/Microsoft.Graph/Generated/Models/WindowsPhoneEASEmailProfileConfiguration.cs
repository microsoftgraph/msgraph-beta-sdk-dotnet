using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhoneEASEmailProfileConfiguration : EasEmailProfileConfigurationBase, IParsable {
        /// <summary>Account name.</summary>
        public string AccountName {
            get { return BackingStore?.Get<string>(nameof(AccountName)); }
            set { BackingStore?.Set(nameof(AccountName), value); }
        }
        /// <summary>Value indicating whether this policy only applies to Windows 8.1. This property is read-only.</summary>
        public bool? ApplyOnlyToWindowsPhone81 {
            get { return BackingStore?.Get<bool?>(nameof(ApplyOnlyToWindowsPhone81)); }
            set { BackingStore?.Set(nameof(ApplyOnlyToWindowsPhone81), value); }
        }
        /// <summary>Duration of email to sync. Possible values are: userDefined, oneDay, threeDays, oneWeek, twoWeeks, oneMonth, unlimited.</summary>
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
        /// <summary>Exchange location that (URL) that the native mail app connects to.</summary>
        public string HostName {
            get { return BackingStore?.Get<string>(nameof(HostName)); }
            set { BackingStore?.Set(nameof(HostName), value); }
        }
        /// <summary>Indicates whether or not to use SSL.</summary>
        public bool? RequireSsl {
            get { return BackingStore?.Get<bool?>(nameof(RequireSsl)); }
            set { BackingStore?.Set(nameof(RequireSsl), value); }
        }
        /// <summary>Whether or not to sync the calendar.</summary>
        public bool? SyncCalendar {
            get { return BackingStore?.Get<bool?>(nameof(SyncCalendar)); }
            set { BackingStore?.Set(nameof(SyncCalendar), value); }
        }
        /// <summary>Whether or not to sync contacts.</summary>
        public bool? SyncContacts {
            get { return BackingStore?.Get<bool?>(nameof(SyncContacts)); }
            set { BackingStore?.Set(nameof(SyncContacts), value); }
        }
        /// <summary>Whether or not to sync tasks.</summary>
        public bool? SyncTasks {
            get { return BackingStore?.Get<bool?>(nameof(SyncTasks)); }
            set { BackingStore?.Set(nameof(SyncTasks), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsPhoneEASEmailProfileConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhoneEASEmailProfileConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"applyOnlyToWindowsPhone81", n => { ApplyOnlyToWindowsPhone81 = n.GetBoolValue(); } },
                {"durationOfEmailToSync", n => { DurationOfEmailToSync = n.GetEnumValue<EmailSyncDuration>(); } },
                {"emailAddressSource", n => { EmailAddressSource = n.GetEnumValue<UserEmailSource>(); } },
                {"emailSyncSchedule", n => { EmailSyncSchedule = n.GetEnumValue<EmailSyncSchedule>(); } },
                {"hostName", n => { HostName = n.GetStringValue(); } },
                {"requireSsl", n => { RequireSsl = n.GetBoolValue(); } },
                {"syncCalendar", n => { SyncCalendar = n.GetBoolValue(); } },
                {"syncContacts", n => { SyncContacts = n.GetBoolValue(); } },
                {"syncTasks", n => { SyncTasks = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("applyOnlyToWindowsPhone81", ApplyOnlyToWindowsPhone81);
            writer.WriteEnumValue<EmailSyncDuration>("durationOfEmailToSync", DurationOfEmailToSync);
            writer.WriteEnumValue<UserEmailSource>("emailAddressSource", EmailAddressSource);
            writer.WriteEnumValue<EmailSyncSchedule>("emailSyncSchedule", EmailSyncSchedule);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteBoolValue("requireSsl", RequireSsl);
            writer.WriteBoolValue("syncCalendar", SyncCalendar);
            writer.WriteBoolValue("syncContacts", SyncContacts);
            writer.WriteBoolValue("syncTasks", SyncTasks);
        }
    }
}
