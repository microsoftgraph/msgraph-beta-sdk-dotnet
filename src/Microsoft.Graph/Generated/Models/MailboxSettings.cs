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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Folder ID of an archive folder for the user. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ArchiveFolder {
            get { return BackingStore?.Get<string?>("archiveFolder"); }
            set { BackingStore?.Set("archiveFolder", value); }
        }
#else
        public string ArchiveFolder {
            get { return BackingStore?.Get<string>("archiveFolder"); }
            set { BackingStore?.Set("archiveFolder", value); }
        }
#endif
        /// <summary>Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.AutomaticRepliesSetting? AutomaticRepliesSetting {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutomaticRepliesSetting?>("automaticRepliesSetting"); }
            set { BackingStore?.Set("automaticRepliesSetting", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.AutomaticRepliesSetting AutomaticRepliesSetting {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutomaticRepliesSetting>("automaticRepliesSetting"); }
            set { BackingStore?.Set("automaticRepliesSetting", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date format for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DateFormat {
            get { return BackingStore?.Get<string?>("dateFormat"); }
            set { BackingStore?.Set("dateFormat", value); }
        }
#else
        public string DateFormat {
            get { return BackingStore?.Get<string>("dateFormat"); }
            set { BackingStore?.Set("dateFormat", value); }
        }
#endif
        /// <summary>If the user has a calendar delegate, this specifies whether the delegate, mailbox owner, or both receive meeting messages and meeting responses. Possible values are: sendToDelegateAndInformationToPrincipal, sendToDelegateAndPrincipal, sendToDelegateOnly. The default is sendToDelegateOnly.</summary>
        public Microsoft.Graph.Beta.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DelegateMeetingMessageDeliveryOptions?>("delegateMeetingMessageDeliveryOptions"); }
            set { BackingStore?.Set("delegateMeetingMessageDeliveryOptions", value); }
        }
        /// <summary>The locale information for the user, including the preferred language and country/region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public LocaleInfo? Language {
            get { return BackingStore?.Get<LocaleInfo?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#else
        public LocaleInfo Language {
            get { return BackingStore?.Get<LocaleInfo>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The time format for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TimeFormat {
            get { return BackingStore?.Get<string?>("timeFormat"); }
            set { BackingStore?.Set("timeFormat", value); }
        }
#else
        public string TimeFormat {
            get { return BackingStore?.Get<string>("timeFormat"); }
            set { BackingStore?.Set("timeFormat", value); }
        }
#endif
        /// <summary>The default time zone for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TimeZone {
            get { return BackingStore?.Get<string?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#else
        public string TimeZone {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>The purpose of the mailbox. Used to differentiate a mailbox for a single user from a shared mailbox and equipment mailbox in Exchange Online. Read only.</summary>
        public Microsoft.Graph.Beta.Models.UserPurpose? UserPurpose {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserPurpose?>("userPurpose"); }
            set { BackingStore?.Set("userPurpose", value); }
        }
        /// <summary>The userPurposeV2 property</summary>
        public MailboxRecipientType? UserPurposeV2 {
            get { return BackingStore?.Get<MailboxRecipientType?>("userPurposeV2"); }
            set { BackingStore?.Set("userPurposeV2", value); }
        }
        /// <summary>The days of the week and hours in a specific time zone that the user works.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.WorkingHours? WorkingHours {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkingHours?>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.WorkingHours WorkingHours {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkingHours>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new mailboxSettings and sets the default values.
        /// </summary>
        public MailboxSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"timeFormat", n => { TimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"userPurpose", n => { UserPurpose = n.GetEnumValue<UserPurpose>(); } },
                {"userPurposeV2", n => { UserPurposeV2 = n.GetEnumValue<MailboxRecipientType>(); } },
                {"workingHours", n => { WorkingHours = n.GetObjectValue<Microsoft.Graph.Beta.Models.WorkingHours>(Microsoft.Graph.Beta.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("archiveFolder", ArchiveFolder);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AutomaticRepliesSetting>("automaticRepliesSetting", AutomaticRepliesSetting);
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteEnumValue<DelegateMeetingMessageDeliveryOptions>("delegateMeetingMessageDeliveryOptions", DelegateMeetingMessageDeliveryOptions);
            writer.WriteObjectValue<LocaleInfo>("language", Language);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("timeFormat", TimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteEnumValue<UserPurpose>("userPurpose", UserPurpose);
            writer.WriteEnumValue<MailboxRecipientType>("userPurposeV2", UserPurposeV2);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
