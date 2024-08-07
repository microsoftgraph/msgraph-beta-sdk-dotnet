// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class Post : Microsoft.Graph.Beta.Models.OutlookItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Attachment>? Attachments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Attachment>?>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Attachment> Attachments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Attachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#endif
        /// <summary>The contents of the post. This is a default property. This property can be null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ItemBody? Body
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ItemBody?>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ItemBody Body
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#endif
        /// <summary>Unique ID of the conversation. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationId
        {
            get { return BackingStore?.Get<string?>("conversationId"); }
            set { BackingStore?.Set("conversationId", value); }
        }
#nullable restore
#else
        public string ConversationId
        {
            get { return BackingStore?.Get<string>("conversationId"); }
            set { BackingStore?.Set("conversationId", value); }
        }
#endif
        /// <summary>Unique ID of the conversation thread. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationThreadId
        {
            get { return BackingStore?.Get<string?>("conversationThreadId"); }
            set { BackingStore?.Set("conversationThreadId", value); }
        }
#nullable restore
#else
        public string ConversationThreadId
        {
            get { return BackingStore?.Get<string>("conversationThreadId"); }
            set { BackingStore?.Set("conversationThreadId", value); }
        }
#endif
        /// <summary>The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Extension>? Extensions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Extension> Extensions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>The from property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Recipient? From
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Recipient?>("from"); }
            set { BackingStore?.Set("from", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Recipient From
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Recipient>("from"); }
            set { BackingStore?.Set("from", value); }
        }
#endif
        /// <summary>Indicates whether the post has at least one attachment. This is a default property.</summary>
        public bool? HasAttachments
        {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>The importance of a group post: low, normal, high.</summary>
        public Microsoft.Graph.Beta.Models.Importance? Importance
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Importance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>The earlier post that this post is replying to in the conversationThread. Read-only. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Post? InReplyTo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Post?>("inReplyTo"); }
            set { BackingStore?.Set("inReplyTo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Post InReplyTo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Post>("inReplyTo"); }
            set { BackingStore?.Set("inReplyTo", value); }
        }
#endif
        /// <summary>The mentions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Mention>? Mentions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Mention>?>("mentions"); }
            set { BackingStore?.Set("mentions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Mention> Mentions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Mention>>("mentions"); }
            set { BackingStore?.Set("mentions", value); }
        }
#endif
        /// <summary>The collection of multi-value extended properties defined for the post. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>Conversation participants that were added to the thread as part of this post.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Recipient>? NewParticipants
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Recipient>?>("newParticipants"); }
            set { BackingStore?.Set("newParticipants", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Recipient> NewParticipants
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Recipient>>("newParticipants"); }
            set { BackingStore?.Set("newParticipants", value); }
        }
#endif
        /// <summary>Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReceivedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTime"); }
            set { BackingStore?.Set("receivedDateTime", value); }
        }
        /// <summary>Contains the address of the sender. The value of Sender is assumed to be the address of the authenticated user in the case when Sender is not specified. This is a default property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Recipient? Sender
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Recipient?>("sender"); }
            set { BackingStore?.Set("sender", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Recipient Sender
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Recipient>("sender"); }
            set { BackingStore?.Set("sender", value); }
        }
#endif
        /// <summary>The collection of single-value extended properties defined for the post. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Post"/> and sets the default values.
        /// </summary>
        public Post() : base()
        {
            OdataType = "#microsoft.graph.post";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Post"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Post CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Post();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "attachments", n => { Attachments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Attachment>(Microsoft.Graph.Beta.Models.Attachment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "body", n => { Body = n.GetObjectValue<Microsoft.Graph.Beta.Models.ItemBody>(Microsoft.Graph.Beta.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "conversationId", n => { ConversationId = n.GetStringValue(); } },
                { "conversationThreadId", n => { ConversationThreadId = n.GetStringValue(); } },
                { "extensions", n => { Extensions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Extension>(Microsoft.Graph.Beta.Models.Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                { "from", n => { From = n.GetObjectValue<Microsoft.Graph.Beta.Models.Recipient>(Microsoft.Graph.Beta.Models.Recipient.CreateFromDiscriminatorValue); } },
                { "hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                { "importance", n => { Importance = n.GetEnumValue<Microsoft.Graph.Beta.Models.Importance>(); } },
                { "inReplyTo", n => { InReplyTo = n.GetObjectValue<Microsoft.Graph.Beta.Models.Post>(Microsoft.Graph.Beta.Models.Post.CreateFromDiscriminatorValue); } },
                { "mentions", n => { Mentions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Mention>(Microsoft.Graph.Beta.Models.Mention.CreateFromDiscriminatorValue)?.ToList(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>(Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                { "newParticipants", n => { NewParticipants = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Recipient>(Microsoft.Graph.Beta.Models.Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                { "receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                { "sender", n => { Sender = n.GetObjectValue<Microsoft.Graph.Beta.Models.Recipient>(Microsoft.Graph.Beta.Models.Recipient.CreateFromDiscriminatorValue); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>(Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Attachment>("attachments", Attachments);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ItemBody>("body", Body);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Extension>("extensions", Extensions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Importance>("importance", Importance);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Post>("inReplyTo", InReplyTo);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Mention>("mentions", Mentions);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Recipient>("newParticipants", NewParticipants);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Recipient>("sender", Sender);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
