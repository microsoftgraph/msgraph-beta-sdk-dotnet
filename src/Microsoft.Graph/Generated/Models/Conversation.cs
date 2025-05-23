// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Conversation : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether any of the posts within this Conversation has at least one attachment. Supports $filter (eq, ne) and $search.</summary>
        public bool? HasAttachments
        {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ne, le, ge).</summary>
        public DateTimeOffset? LastDeliveredDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastDeliveredDateTime"); }
            set { BackingStore?.Set("lastDeliveredDateTime", value); }
        }
        /// <summary>A short summary from the body of the latest post in this conversation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Preview
        {
            get { return BackingStore?.Get<string?>("preview"); }
            set { BackingStore?.Set("preview", value); }
        }
#nullable restore
#else
        public string Preview
        {
            get { return BackingStore?.Get<string>("preview"); }
            set { BackingStore?.Set("preview", value); }
        }
#endif
        /// <summary>A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ConversationThread>? Threads
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ConversationThread>?>("threads"); }
            set { BackingStore?.Set("threads", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ConversationThread> Threads
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ConversationThread>>("threads"); }
            set { BackingStore?.Set("threads", value); }
        }
#endif
        /// <summary>The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Topic
        {
            get { return BackingStore?.Get<string?>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
#nullable restore
#else
        public string Topic
        {
            get { return BackingStore?.Get<string>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
#endif
        /// <summary>All the users that sent a message to this Conversation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UniqueSenders
        {
            get { return BackingStore?.Get<List<string>?>("uniqueSenders"); }
            set { BackingStore?.Set("uniqueSenders", value); }
        }
#nullable restore
#else
        public List<string> UniqueSenders
        {
            get { return BackingStore?.Get<List<string>>("uniqueSenders"); }
            set { BackingStore?.Set("uniqueSenders", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Conversation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Conversation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Conversation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                { "lastDeliveredDateTime", n => { LastDeliveredDateTime = n.GetDateTimeOffsetValue(); } },
                { "preview", n => { Preview = n.GetStringValue(); } },
                { "threads", n => { Threads = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ConversationThread>(global::Microsoft.Graph.Beta.Models.ConversationThread.CreateFromDiscriminatorValue)?.AsList(); } },
                { "topic", n => { Topic = n.GetStringValue(); } },
                { "uniqueSenders", n => { UniqueSenders = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteDateTimeOffsetValue("lastDeliveredDateTime", LastDeliveredDateTime);
            writer.WriteStringValue("preview", Preview);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ConversationThread>("threads", Threads);
            writer.WriteStringValue("topic", Topic);
            writer.WriteCollectionOfPrimitiveValues<string>("uniqueSenders", UniqueSenders);
        }
    }
}
#pragma warning restore CS0618
