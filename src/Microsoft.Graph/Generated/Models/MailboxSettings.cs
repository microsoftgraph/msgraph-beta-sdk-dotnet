using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MailboxSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Folder ID of an archive folder for the user. Read only.</summary>
        public string ArchiveFolder {
            get { return BackingStore?.Get<string>(nameof(ArchiveFolder)); }
            set { BackingStore?.Set(nameof(ArchiveFolder), value); }
        }
        /// <summary>Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user.</summary>
        public Microsoft.Graph.Beta.Models.AutomaticRepliesSetting AutomaticRepliesSetting {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutomaticRepliesSetting>(nameof(AutomaticRepliesSetting)); }
            set { BackingStore?.Set(nameof(AutomaticRepliesSetting), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date format for the user&apos;s mailbox.</summary>
        public string DateFormat {
            get { return BackingStore?.Get<string>(nameof(DateFormat)); }
            set { BackingStore?.Set(nameof(DateFormat), value); }
        }
        /// <summary>If the user has a calendar delegate, this specifies whether the delegate, mailbox owner, or both receive meeting messages and meeting responses. Possible values are: sendToDelegateAndInformationToPrincipal, sendToDelegateAndPrincipal, sendToDelegateOnly. The default is sendToDelegateOnly.</summary>
        public Microsoft.Graph.Beta.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DelegateMeetingMessageDeliveryOptions?>(nameof(DelegateMeetingMessageDeliveryOptions)); }
            set { BackingStore?.Set(nameof(DelegateMeetingMessageDeliveryOptions), value); }
        }
        /// <summary>The locale information for the user, including the preferred language and country/region.</summary>
        public LocaleInfo Language {
            get { return BackingStore?.Get<LocaleInfo>(nameof(Language)); }
            set { BackingStore?.Set(nameof(Language), value); }
        }
        /// <summary>The time format for the user&apos;s mailbox.</summary>
        public string TimeFormat {
            get { return BackingStore?.Get<string>(nameof(TimeFormat)); }
            set { BackingStore?.Set(nameof(TimeFormat), value); }
        }
        /// <summary>The default time zone for the user&apos;s mailbox.</summary>
        public string TimeZone {
            get { return BackingStore?.Get<string>(nameof(TimeZone)); }
            set { BackingStore?.Set(nameof(TimeZone), value); }
        }
        /// <summary>The purpose of the mailbox. Used to differentiate a mailbox for a single user from a shared mailbox and equipment mailbox in Exchange Online. Read only.</summary>
        public Microsoft.Graph.Beta.Models.UserPurpose? UserPurpose {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserPurpose?>(nameof(UserPurpose)); }
            set { BackingStore?.Set(nameof(UserPurpose), value); }
        }
        /// <summary>The userPurposeV2 property</summary>
        public MailboxRecipientType? UserPurposeV2 {
            get { return BackingStore?.Get<MailboxRecipientType?>(nameof(UserPurposeV2)); }
            set { BackingStore?.Set(nameof(UserPurposeV2), value); }
        }
        /// <summary>The days of the week and hours in a specific time zone that the user works.</summary>
        public Microsoft.Graph.Beta.Models.WorkingHours WorkingHours {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkingHours>(nameof(WorkingHours)); }
            set { BackingStore?.Set(nameof(WorkingHours), value); }
        }
        /// <summary>
        /// Instantiates a new mailboxSettings and sets the default values.
        /// </summary>
        public MailboxSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MailboxSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailboxSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archiveFolder", n => { ArchiveFolder = n.GetStringValue(); } },
                {"automaticRepliesSetting", n => { AutomaticRepliesSetting = n.GetObjectValue<Microsoft.Graph.Beta.Models.AutomaticRepliesSetting>(Microsoft.Graph.Beta.Models.AutomaticRepliesSetting.CreateFromDiscriminatorValue); } },
                {"dateFormat", n => { DateFormat = n.GetStringValue(); } },
                {"delegateMeetingMessageDeliveryOptions", n => { DelegateMeetingMessageDeliveryOptions = n.GetEnumValue<DelegateMeetingMessageDeliveryOptions>(); } },
                {"language", n => { Language = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"timeFormat", n => { TimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"userPurpose", n => { UserPurpose = n.GetEnumValue<UserPurpose>(); } },
                {"userPurposeV2", n => { UserPurposeV2 = n.GetEnumValue<MailboxRecipientType>(); } },
                {"workingHours", n => { WorkingHours = n.GetObjectValue<Microsoft.Graph.Beta.Models.WorkingHours>(Microsoft.Graph.Beta.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("archiveFolder", ArchiveFolder);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AutomaticRepliesSetting>("automaticRepliesSetting", AutomaticRepliesSetting);
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteEnumValue<DelegateMeetingMessageDeliveryOptions>("delegateMeetingMessageDeliveryOptions", DelegateMeetingMessageDeliveryOptions);
            writer.WriteObjectValue<LocaleInfo>("language", Language);
            writer.WriteStringValue("timeFormat", TimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteEnumValue<UserPurpose>("userPurpose", UserPurpose);
            writer.WriteEnumValue<MailboxRecipientType>("userPurposeV2", UserPurposeV2);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
