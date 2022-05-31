using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class Post : OutlookItem, IParsable {
        /// <summary>The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post. Read-only. Nullable. Supports $expand.</summary>
        public List<Attachment> Attachments {
            get { return BackingStore?.Get<List<Attachment>>(nameof(Attachments)); }
            set { BackingStore?.Set(nameof(Attachments), value); }
        }
        /// <summary>The contents of the post. This is a default property. This property can be null.</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>(nameof(Body)); }
            set { BackingStore?.Set(nameof(Body), value); }
        }
        /// <summary>Unique ID of the conversation. Read-only.</summary>
        public string ConversationId {
            get { return BackingStore?.Get<string>(nameof(ConversationId)); }
            set { BackingStore?.Set(nameof(ConversationId), value); }
        }
        /// <summary>Unique ID of the conversation thread. Read-only.</summary>
        public string ConversationThreadId {
            get { return BackingStore?.Get<string>(nameof(ConversationThreadId)); }
            set { BackingStore?.Set(nameof(ConversationThreadId), value); }
        }
        /// <summary>The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>The from property</summary>
        public Recipient From {
            get { return BackingStore?.Get<Recipient>(nameof(From)); }
            set { BackingStore?.Set(nameof(From), value); }
        }
        /// <summary>Indicates whether the post has at least one attachment. This is a default property.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>(nameof(HasAttachments)); }
            set { BackingStore?.Set(nameof(HasAttachments), value); }
        }
        /// <summary>The importance of a group post: low, normal, high.</summary>
        public Microsoft.Graph.Beta.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Importance?>(nameof(Importance)); }
            set { BackingStore?.Set(nameof(Importance), value); }
        }
        /// <summary>The earlier post that this post is replying to in the conversationThread. Read-only. Supports $expand.</summary>
        public Post InReplyTo {
            get { return BackingStore?.Get<Post>(nameof(InReplyTo)); }
            set { BackingStore?.Set(nameof(InReplyTo), value); }
        }
        /// <summary>The mentions property</summary>
        public List<Mention> Mentions {
            get { return BackingStore?.Get<List<Mention>>(nameof(Mentions)); }
            set { BackingStore?.Set(nameof(Mentions), value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the post. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>(nameof(MultiValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(MultiValueExtendedProperties), value); }
        }
        /// <summary>Conversation participants that were added to the thread as part of this post.</summary>
        public List<Recipient> NewParticipants {
            get { return BackingStore?.Get<List<Recipient>>(nameof(NewParticipants)); }
            set { BackingStore?.Set(nameof(NewParticipants), value); }
        }
        /// <summary>Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReceivedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ReceivedDateTime)); }
            set { BackingStore?.Set(nameof(ReceivedDateTime), value); }
        }
        /// <summary>Contains the address of the sender. The value of Sender is assumed to be the address of the authenticated user in the case when Sender is not specified. This is a default property.</summary>
        public Recipient Sender {
            get { return BackingStore?.Get<Recipient>(nameof(Sender)); }
            set { BackingStore?.Set(nameof(Sender), value); }
        }
        /// <summary>The collection of single-value extended properties defined for the post. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>(nameof(SingleValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(SingleValueExtendedProperties), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Post CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Post();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue).ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"conversationId", n => { ConversationId = n.GetStringValue(); } },
                {"conversationThreadId", n => { ConversationThreadId = n.GetStringValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"from", n => { From = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"inReplyTo", n => { InReplyTo = n.GetObjectValue<Post>(Post.CreateFromDiscriminatorValue); } },
                {"mentions", n => { Mentions = n.GetCollectionOfObjectValues<Mention>(Mention.CreateFromDiscriminatorValue).ToList(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"newParticipants", n => { NewParticipants = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sender", n => { Sender = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteObjectValue<Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteObjectValue<Post>("inReplyTo", InReplyTo);
            writer.WriteCollectionOfObjectValues<Mention>("mentions", Mentions);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<Recipient>("newParticipants", NewParticipants);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteObjectValue<Recipient>("sender", Sender);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
