// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MessageRulePredicates : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents the strings that should appear in the body of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BodyContains
        {
            get { return BackingStore?.Get<List<string>?>("bodyContains"); }
            set { BackingStore?.Set("bodyContains", value); }
        }
#nullable restore
#else
        public List<string> BodyContains
        {
            get { return BackingStore?.Get<List<string>>("bodyContains"); }
            set { BackingStore?.Set("bodyContains", value); }
        }
#endif
        /// <summary>Represents the strings that should appear in the body or subject of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BodyOrSubjectContains
        {
            get { return BackingStore?.Get<List<string>?>("bodyOrSubjectContains"); }
            set { BackingStore?.Set("bodyOrSubjectContains", value); }
        }
#nullable restore
#else
        public List<string> BodyOrSubjectContains
        {
            get { return BackingStore?.Get<List<string>>("bodyOrSubjectContains"); }
            set { BackingStore?.Set("bodyOrSubjectContains", value); }
        }
#endif
        /// <summary>Represents the categories that an incoming message should be labeled with in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories
        {
            get { return BackingStore?.Get<List<string>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<string> Categories
        {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>Represents the specific sender email addresses of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Recipient>? FromAddresses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Recipient>?>("fromAddresses"); }
            set { BackingStore?.Set("fromAddresses", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Recipient> FromAddresses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Recipient>>("fromAddresses"); }
            set { BackingStore?.Set("fromAddresses", value); }
        }
#endif
        /// <summary>Indicates whether an incoming message must have attachments in order for the condition or exception to apply.</summary>
        public bool? HasAttachments
        {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>Represents the strings that appear in the headers of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? HeaderContains
        {
            get { return BackingStore?.Get<List<string>?>("headerContains"); }
            set { BackingStore?.Set("headerContains", value); }
        }
#nullable restore
#else
        public List<string> HeaderContains
        {
            get { return BackingStore?.Get<List<string>>("headerContains"); }
            set { BackingStore?.Set("headerContains", value); }
        }
#endif
        /// <summary>The importance that is stamped on an incoming message in order for the condition or exception to apply: low, normal, high.</summary>
        public global::Microsoft.Graph.Beta.Models.Importance? Importance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Importance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>Indicates whether an incoming message must be an approval request in order for the condition or exception to apply.</summary>
        public bool? IsApprovalRequest
        {
            get { return BackingStore?.Get<bool?>("isApprovalRequest"); }
            set { BackingStore?.Set("isApprovalRequest", value); }
        }
        /// <summary>Indicates whether an incoming message must be automatically forwarded in order for the condition or exception to apply.</summary>
        public bool? IsAutomaticForward
        {
            get { return BackingStore?.Get<bool?>("isAutomaticForward"); }
            set { BackingStore?.Set("isAutomaticForward", value); }
        }
        /// <summary>Indicates whether an incoming message must be an auto reply in order for the condition or exception to apply.</summary>
        public bool? IsAutomaticReply
        {
            get { return BackingStore?.Get<bool?>("isAutomaticReply"); }
            set { BackingStore?.Set("isAutomaticReply", value); }
        }
        /// <summary>Indicates whether an incoming message must be encrypted in order for the condition or exception to apply.</summary>
        public bool? IsEncrypted
        {
            get { return BackingStore?.Get<bool?>("isEncrypted"); }
            set { BackingStore?.Set("isEncrypted", value); }
        }
        /// <summary>Indicates whether an incoming message must be a meeting request in order for the condition or exception to apply.</summary>
        public bool? IsMeetingRequest
        {
            get { return BackingStore?.Get<bool?>("isMeetingRequest"); }
            set { BackingStore?.Set("isMeetingRequest", value); }
        }
        /// <summary>Indicates whether an incoming message must be a meeting response in order for the condition or exception to apply.</summary>
        public bool? IsMeetingResponse
        {
            get { return BackingStore?.Get<bool?>("isMeetingResponse"); }
            set { BackingStore?.Set("isMeetingResponse", value); }
        }
        /// <summary>Indicates whether an incoming message must be a non-delivery report in order for the condition or exception to apply.</summary>
        public bool? IsNonDeliveryReport
        {
            get { return BackingStore?.Get<bool?>("isNonDeliveryReport"); }
            set { BackingStore?.Set("isNonDeliveryReport", value); }
        }
        /// <summary>Indicates whether an incoming message must be permission controlled (RMS-protected) in order for the condition or exception to apply.</summary>
        public bool? IsPermissionControlled
        {
            get { return BackingStore?.Get<bool?>("isPermissionControlled"); }
            set { BackingStore?.Set("isPermissionControlled", value); }
        }
        /// <summary>Indicates whether an incoming message must be a read receipt in order for the condition or exception to apply.</summary>
        public bool? IsReadReceipt
        {
            get { return BackingStore?.Get<bool?>("isReadReceipt"); }
            set { BackingStore?.Set("isReadReceipt", value); }
        }
        /// <summary>Indicates whether an incoming message must be S/MIME-signed in order for the condition or exception to apply.</summary>
        public bool? IsSigned
        {
            get { return BackingStore?.Get<bool?>("isSigned"); }
            set { BackingStore?.Set("isSigned", value); }
        }
        /// <summary>Indicates whether an incoming message must be a voice mail in order for the condition or exception to apply.</summary>
        public bool? IsVoicemail
        {
            get { return BackingStore?.Get<bool?>("isVoicemail"); }
            set { BackingStore?.Set("isVoicemail", value); }
        }
        /// <summary>Represents the flag-for-action value that appears on an incoming message in order for the condition or exception to apply. The possible values are: any, call, doNotForward, followUp, fyi, forward, noResponseNecessary, read, reply, replyToAll, review.</summary>
        public global::Microsoft.Graph.Beta.Models.MessageActionFlag? MessageActionFlag
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MessageActionFlag?>("messageActionFlag"); }
            set { BackingStore?.Set("messageActionFlag", value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must not be a recipient of an incoming message in order for the condition or exception to apply.</summary>
        public bool? NotSentToMe
        {
            get { return BackingStore?.Get<bool?>("notSentToMe"); }
            set { BackingStore?.Set("notSentToMe", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Represents the strings that appear in either the toRecipients or ccRecipients properties of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RecipientContains
        {
            get { return BackingStore?.Get<List<string>?>("recipientContains"); }
            set { BackingStore?.Set("recipientContains", value); }
        }
#nullable restore
#else
        public List<string> RecipientContains
        {
            get { return BackingStore?.Get<List<string>>("recipientContains"); }
            set { BackingStore?.Set("recipientContains", value); }
        }
#endif
        /// <summary>Represents the strings that appear in the from property of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SenderContains
        {
            get { return BackingStore?.Get<List<string>?>("senderContains"); }
            set { BackingStore?.Set("senderContains", value); }
        }
#nullable restore
#else
        public List<string> SenderContains
        {
            get { return BackingStore?.Get<List<string>>("senderContains"); }
            set { BackingStore?.Set("senderContains", value); }
        }
#endif
        /// <summary>Represents the sensitivity level that must be stamped on an incoming message in order for the condition or exception to apply. The possible values are: normal, personal, private, confidential.</summary>
        public global::Microsoft.Graph.Beta.Models.Sensitivity? Sensitivity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Sensitivity?>("sensitivity"); }
            set { BackingStore?.Set("sensitivity", value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must be in the ccRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentCcMe
        {
            get { return BackingStore?.Get<bool?>("sentCcMe"); }
            set { BackingStore?.Set("sentCcMe", value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must be the only recipient in an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentOnlyToMe
        {
            get { return BackingStore?.Get<bool?>("sentOnlyToMe"); }
            set { BackingStore?.Set("sentOnlyToMe", value); }
        }
        /// <summary>Represents the email addresses that an incoming message must have been sent to in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Recipient>? SentToAddresses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Recipient>?>("sentToAddresses"); }
            set { BackingStore?.Set("sentToAddresses", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Recipient> SentToAddresses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Recipient>>("sentToAddresses"); }
            set { BackingStore?.Set("sentToAddresses", value); }
        }
#endif
        /// <summary>Indicates whether the owner of the mailbox must be in the toRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentToMe
        {
            get { return BackingStore?.Get<bool?>("sentToMe"); }
            set { BackingStore?.Set("sentToMe", value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must be in either a toRecipients or ccRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentToOrCcMe
        {
            get { return BackingStore?.Get<bool?>("sentToOrCcMe"); }
            set { BackingStore?.Set("sentToOrCcMe", value); }
        }
        /// <summary>Represents the strings that appear in the subject of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SubjectContains
        {
            get { return BackingStore?.Get<List<string>?>("subjectContains"); }
            set { BackingStore?.Set("subjectContains", value); }
        }
#nullable restore
#else
        public List<string> SubjectContains
        {
            get { return BackingStore?.Get<List<string>>("subjectContains"); }
            set { BackingStore?.Set("subjectContains", value); }
        }
#endif
        /// <summary>Represents the minimum and maximum sizes (in kilobytes) that an incoming message must fall in between in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SizeRange? WithinSizeRange
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SizeRange?>("withinSizeRange"); }
            set { BackingStore?.Set("withinSizeRange", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SizeRange WithinSizeRange
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SizeRange>("withinSizeRange"); }
            set { BackingStore?.Set("withinSizeRange", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MessageRulePredicates"/> and sets the default values.
        /// </summary>
        public MessageRulePredicates()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MessageRulePredicates"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.MessageRulePredicates CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MessageRulePredicates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bodyContains", n => { BodyContains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "bodyOrSubjectContains", n => { BodyOrSubjectContains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "fromAddresses", n => { FromAddresses = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Recipient>(global::Microsoft.Graph.Beta.Models.Recipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                { "headerContains", n => { HeaderContains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "importance", n => { Importance = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Importance>(); } },
                { "isApprovalRequest", n => { IsApprovalRequest = n.GetBoolValue(); } },
                { "isAutomaticForward", n => { IsAutomaticForward = n.GetBoolValue(); } },
                { "isAutomaticReply", n => { IsAutomaticReply = n.GetBoolValue(); } },
                { "isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                { "isMeetingRequest", n => { IsMeetingRequest = n.GetBoolValue(); } },
                { "isMeetingResponse", n => { IsMeetingResponse = n.GetBoolValue(); } },
                { "isNonDeliveryReport", n => { IsNonDeliveryReport = n.GetBoolValue(); } },
                { "isPermissionControlled", n => { IsPermissionControlled = n.GetBoolValue(); } },
                { "isReadReceipt", n => { IsReadReceipt = n.GetBoolValue(); } },
                { "isSigned", n => { IsSigned = n.GetBoolValue(); } },
                { "isVoicemail", n => { IsVoicemail = n.GetBoolValue(); } },
                { "messageActionFlag", n => { MessageActionFlag = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MessageActionFlag>(); } },
                { "notSentToMe", n => { NotSentToMe = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "recipientContains", n => { RecipientContains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "senderContains", n => { SenderContains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "sensitivity", n => { Sensitivity = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Sensitivity>(); } },
                { "sentCcMe", n => { SentCcMe = n.GetBoolValue(); } },
                { "sentOnlyToMe", n => { SentOnlyToMe = n.GetBoolValue(); } },
                { "sentToAddresses", n => { SentToAddresses = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Recipient>(global::Microsoft.Graph.Beta.Models.Recipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sentToMe", n => { SentToMe = n.GetBoolValue(); } },
                { "sentToOrCcMe", n => { SentToOrCcMe = n.GetBoolValue(); } },
                { "subjectContains", n => { SubjectContains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "withinSizeRange", n => { WithinSizeRange = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SizeRange>(global::Microsoft.Graph.Beta.Models.SizeRange.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("bodyContains", BodyContains);
            writer.WriteCollectionOfPrimitiveValues<string>("bodyOrSubjectContains", BodyOrSubjectContains);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Recipient>("fromAddresses", FromAddresses);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteCollectionOfPrimitiveValues<string>("headerContains", HeaderContains);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Importance>("importance", Importance);
            writer.WriteBoolValue("isApprovalRequest", IsApprovalRequest);
            writer.WriteBoolValue("isAutomaticForward", IsAutomaticForward);
            writer.WriteBoolValue("isAutomaticReply", IsAutomaticReply);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteBoolValue("isMeetingRequest", IsMeetingRequest);
            writer.WriteBoolValue("isMeetingResponse", IsMeetingResponse);
            writer.WriteBoolValue("isNonDeliveryReport", IsNonDeliveryReport);
            writer.WriteBoolValue("isPermissionControlled", IsPermissionControlled);
            writer.WriteBoolValue("isReadReceipt", IsReadReceipt);
            writer.WriteBoolValue("isSigned", IsSigned);
            writer.WriteBoolValue("isVoicemail", IsVoicemail);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MessageActionFlag>("messageActionFlag", MessageActionFlag);
            writer.WriteBoolValue("notSentToMe", NotSentToMe);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("recipientContains", RecipientContains);
            writer.WriteCollectionOfPrimitiveValues<string>("senderContains", SenderContains);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Sensitivity>("sensitivity", Sensitivity);
            writer.WriteBoolValue("sentCcMe", SentCcMe);
            writer.WriteBoolValue("sentOnlyToMe", SentOnlyToMe);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Recipient>("sentToAddresses", SentToAddresses);
            writer.WriteBoolValue("sentToMe", SentToMe);
            writer.WriteBoolValue("sentToOrCcMe", SentToOrCcMe);
            writer.WriteCollectionOfPrimitiveValues<string>("subjectContains", SubjectContains);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SizeRange>("withinSizeRange", WithinSizeRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
