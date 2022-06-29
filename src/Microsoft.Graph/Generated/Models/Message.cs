using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Message : OutlookItem, IParsable {
        /// <summary>The fileAttachment and itemAttachment attachments for the message.</summary>
        public List<Attachment> Attachments {
            get { return BackingStore?.Get<List<Attachment>>(nameof(Attachments)); }
            set { BackingStore?.Set(nameof(Attachments), value); }
        }
        /// <summary>The Bcc: recipients for the message.</summary>
        public List<Recipient> BccRecipients {
            get { return BackingStore?.Get<List<Recipient>>(nameof(BccRecipients)); }
            set { BackingStore?.Set(nameof(BccRecipients), value); }
        }
        /// <summary>The body of the message. It can be in HTML or text format. Find out about safe HTML in a message body.</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>(nameof(Body)); }
            set { BackingStore?.Set(nameof(Body), value); }
        }
        /// <summary>The first 255 characters of the message body. It is in text format. If the message contains instances of mention, this property would contain a concatenation of these mentions as well.</summary>
        public string BodyPreview {
            get { return BackingStore?.Get<string>(nameof(BodyPreview)); }
            set { BackingStore?.Set(nameof(BodyPreview), value); }
        }
        /// <summary>The Cc: recipients for the message.</summary>
        public List<Recipient> CcRecipients {
            get { return BackingStore?.Get<List<Recipient>>(nameof(CcRecipients)); }
            set { BackingStore?.Set(nameof(CcRecipients), value); }
        }
        /// <summary>The ID of the conversation the email belongs to.</summary>
        public string ConversationId {
            get { return BackingStore?.Get<string>(nameof(ConversationId)); }
            set { BackingStore?.Set(nameof(ConversationId), value); }
        }
        /// <summary>Indicates the position of the message within the conversation.</summary>
        public byte[] ConversationIndex {
            get { return BackingStore?.Get<byte[]>(nameof(ConversationIndex)); }
            set { BackingStore?.Set(nameof(ConversationIndex), value); }
        }
        /// <summary>The collection of open extensions defined for the message. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>The flag value that indicates the status, start date, due date, or completion date for the message.</summary>
        public FollowupFlag Flag {
            get { return BackingStore?.Get<FollowupFlag>(nameof(Flag)); }
            set { BackingStore?.Set(nameof(Flag), value); }
        }
        /// <summary>The owner of the mailbox from which the message is sent. In most cases, this value is the same as the sender property, except for sharing or delegation scenarios. The value must correspond to the actual mailbox used. Find out more about setting the from and sender properties of a message.</summary>
        public Recipient From {
            get { return BackingStore?.Get<Recipient>(nameof(From)); }
            set { BackingStore?.Set(nameof(From), value); }
        }
        /// <summary>Indicates whether the message has attachments. This property doesn&apos;t include inline attachments, so if a message contains only inline attachments, this property is false. To verify the existence of inline attachments, parse the body property to look for a src attribute, such as &lt;IMG src=&apos;cid:image001.jpg@01D26CD8.6C05F070&apos;&gt;.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>(nameof(HasAttachments)); }
            set { BackingStore?.Set(nameof(HasAttachments), value); }
        }
        /// <summary>The importance property</summary>
        public Microsoft.Graph.Beta.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Importance?>(nameof(Importance)); }
            set { BackingStore?.Set(nameof(Importance), value); }
        }
        /// <summary>The inferenceClassification property</summary>
        public InferenceClassificationType? InferenceClassification {
            get { return BackingStore?.Get<InferenceClassificationType?>(nameof(InferenceClassification)); }
            set { BackingStore?.Set(nameof(InferenceClassification), value); }
        }
        /// <summary>The internetMessageHeaders property</summary>
        public List<InternetMessageHeader> InternetMessageHeaders {
            get { return BackingStore?.Get<List<InternetMessageHeader>>(nameof(InternetMessageHeaders)); }
            set { BackingStore?.Set(nameof(InternetMessageHeaders), value); }
        }
        /// <summary>The internetMessageId property</summary>
        public string InternetMessageId {
            get { return BackingStore?.Get<string>(nameof(InternetMessageId)); }
            set { BackingStore?.Set(nameof(InternetMessageId), value); }
        }
        /// <summary>The isDeliveryReceiptRequested property</summary>
        public bool? IsDeliveryReceiptRequested {
            get { return BackingStore?.Get<bool?>(nameof(IsDeliveryReceiptRequested)); }
            set { BackingStore?.Set(nameof(IsDeliveryReceiptRequested), value); }
        }
        /// <summary>The isDraft property</summary>
        public bool? IsDraft {
            get { return BackingStore?.Get<bool?>(nameof(IsDraft)); }
            set { BackingStore?.Set(nameof(IsDraft), value); }
        }
        /// <summary>The isRead property</summary>
        public bool? IsRead {
            get { return BackingStore?.Get<bool?>(nameof(IsRead)); }
            set { BackingStore?.Set(nameof(IsRead), value); }
        }
        /// <summary>The isReadReceiptRequested property</summary>
        public bool? IsReadReceiptRequested {
            get { return BackingStore?.Get<bool?>(nameof(IsReadReceiptRequested)); }
            set { BackingStore?.Set(nameof(IsReadReceiptRequested), value); }
        }
        /// <summary>A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest. By default, a GET /messages does not return this property unless you apply $expand on the property.</summary>
        public List<Mention> Mentions {
            get { return BackingStore?.Get<List<Mention>>(nameof(Mentions)); }
            set { BackingStore?.Set(nameof(Mentions), value); }
        }
        /// <summary>The mentionsPreview property</summary>
        public Microsoft.Graph.Beta.Models.MentionsPreview MentionsPreview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MentionsPreview>(nameof(MentionsPreview)); }
            set { BackingStore?.Set(nameof(MentionsPreview), value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the message. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>(nameof(MultiValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(MultiValueExtendedProperties), value); }
        }
        /// <summary>The parentFolderId property</summary>
        public string ParentFolderId {
            get { return BackingStore?.Get<string>(nameof(ParentFolderId)); }
            set { BackingStore?.Set(nameof(ParentFolderId), value); }
        }
        /// <summary>The receivedDateTime property</summary>
        public DateTimeOffset? ReceivedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ReceivedDateTime)); }
            set { BackingStore?.Set(nameof(ReceivedDateTime), value); }
        }
        /// <summary>The replyTo property</summary>
        public List<Recipient> ReplyTo {
            get { return BackingStore?.Get<List<Recipient>>(nameof(ReplyTo)); }
            set { BackingStore?.Set(nameof(ReplyTo), value); }
        }
        /// <summary>The sender property</summary>
        public Recipient Sender {
            get { return BackingStore?.Get<Recipient>(nameof(Sender)); }
            set { BackingStore?.Set(nameof(Sender), value); }
        }
        /// <summary>The sentDateTime property</summary>
        public DateTimeOffset? SentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(SentDateTime)); }
            set { BackingStore?.Set(nameof(SentDateTime), value); }
        }
        /// <summary>The collection of single-value extended properties defined for the message. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>(nameof(SingleValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(SingleValueExtendedProperties), value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>(nameof(Subject)); }
            set { BackingStore?.Set(nameof(Subject), value); }
        }
        /// <summary>The toRecipients property</summary>
        public List<Recipient> ToRecipients {
            get { return BackingStore?.Get<List<Recipient>>(nameof(ToRecipients)); }
            set { BackingStore?.Set(nameof(ToRecipients), value); }
        }
        /// <summary>The uniqueBody property</summary>
        public ItemBody UniqueBody {
            get { return BackingStore?.Get<ItemBody>(nameof(UniqueBody)); }
            set { BackingStore?.Set(nameof(UniqueBody), value); }
        }
        /// <summary>The unsubscribeData property</summary>
        public List<string> UnsubscribeData {
            get { return BackingStore?.Get<List<string>>(nameof(UnsubscribeData)); }
            set { BackingStore?.Set(nameof(UnsubscribeData), value); }
        }
        /// <summary>The unsubscribeEnabled property</summary>
        public bool? UnsubscribeEnabled {
            get { return BackingStore?.Get<bool?>(nameof(UnsubscribeEnabled)); }
            set { BackingStore?.Set(nameof(UnsubscribeEnabled), value); }
        }
        /// <summary>The webLink property</summary>
        public string WebLink {
            get { return BackingStore?.Get<string>(nameof(WebLink)); }
            set { BackingStore?.Set(nameof(WebLink), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Message CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.calendarSharingMessage" => new CalendarSharingMessage(),
                "#microsoft.graph.eventMessage" => new EventMessage(),
                _ => new Message(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue).ToList(); } },
                {"bccRecipients", n => { BccRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", n => { BodyPreview = n.GetStringValue(); } },
                {"ccRecipients", n => { CcRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"conversationId", n => { ConversationId = n.GetStringValue(); } },
                {"conversationIndex", n => { ConversationIndex = n.GetByteArrayValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"flag", n => { Flag = n.GetObjectValue<FollowupFlag>(FollowupFlag.CreateFromDiscriminatorValue); } },
                {"from", n => { From = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"inferenceClassification", n => { InferenceClassification = n.GetEnumValue<InferenceClassificationType>(); } },
                {"internetMessageHeaders", n => { InternetMessageHeaders = n.GetCollectionOfObjectValues<InternetMessageHeader>(InternetMessageHeader.CreateFromDiscriminatorValue).ToList(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"isDeliveryReceiptRequested", n => { IsDeliveryReceiptRequested = n.GetBoolValue(); } },
                {"isDraft", n => { IsDraft = n.GetBoolValue(); } },
                {"isRead", n => { IsRead = n.GetBoolValue(); } },
                {"isReadReceiptRequested", n => { IsReadReceiptRequested = n.GetBoolValue(); } },
                {"mentions", n => { Mentions = n.GetCollectionOfObjectValues<Mention>(Mention.CreateFromDiscriminatorValue).ToList(); } },
                {"mentionsPreview", n => { MentionsPreview = n.GetObjectValue<Microsoft.Graph.Beta.Models.MentionsPreview>(Microsoft.Graph.Beta.Models.MentionsPreview.CreateFromDiscriminatorValue); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"replyTo", n => { ReplyTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"sender", n => { Sender = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"sentDateTime", n => { SentDateTime = n.GetDateTimeOffsetValue(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"toRecipients", n => { ToRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"uniqueBody", n => { UniqueBody = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"unsubscribeData", n => { UnsubscribeData = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"unsubscribeEnabled", n => { UnsubscribeEnabled = n.GetBoolValue(); } },
                {"webLink", n => { WebLink = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<Recipient>("bccRecipients", BccRecipients);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("bodyPreview", BodyPreview);
            writer.WriteCollectionOfObjectValues<Recipient>("ccRecipients", CcRecipients);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteByteArrayValue("conversationIndex", ConversationIndex);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteObjectValue<FollowupFlag>("flag", Flag);
            writer.WriteObjectValue<Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteEnumValue<InferenceClassificationType>("inferenceClassification", InferenceClassification);
            writer.WriteCollectionOfObjectValues<InternetMessageHeader>("internetMessageHeaders", InternetMessageHeaders);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteBoolValue("isDeliveryReceiptRequested", IsDeliveryReceiptRequested);
            writer.WriteBoolValue("isDraft", IsDraft);
            writer.WriteBoolValue("isRead", IsRead);
            writer.WriteBoolValue("isReadReceiptRequested", IsReadReceiptRequested);
            writer.WriteCollectionOfObjectValues<Mention>("mentions", Mentions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MentionsPreview>("mentionsPreview", MentionsPreview);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteCollectionOfObjectValues<Recipient>("replyTo", ReplyTo);
            writer.WriteObjectValue<Recipient>("sender", Sender);
            writer.WriteDateTimeOffsetValue("sentDateTime", SentDateTime);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteObjectValue<ItemBody>("uniqueBody", UniqueBody);
            writer.WriteCollectionOfPrimitiveValues<string>("unsubscribeData", UnsubscribeData);
            writer.WriteBoolValue("unsubscribeEnabled", UnsubscribeEnabled);
            writer.WriteStringValue("webLink", WebLink);
        }
    }
}
