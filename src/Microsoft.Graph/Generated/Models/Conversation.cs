using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class Conversation : Entity, IParsable {
        /// <summary>Indicates whether any of the posts within this Conversation has at least one attachment. Supports $filter (eq, ne) and $search.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>(nameof(HasAttachments)); }
            set { BackingStore?.Set(nameof(HasAttachments), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ne, le, ge).</summary>
        public DateTimeOffset? LastDeliveredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastDeliveredDateTime)); }
            set { BackingStore?.Set(nameof(LastDeliveredDateTime), value); }
        }
        /// <summary>A short summary from the body of the latest post in this conversation.</summary>
        public string Preview {
            get { return BackingStore?.Get<string>(nameof(Preview)); }
            set { BackingStore?.Set(nameof(Preview), value); }
        }
        /// <summary>A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.</summary>
        public List<ConversationThread> Threads {
            get { return BackingStore?.Get<List<ConversationThread>>(nameof(Threads)); }
            set { BackingStore?.Set(nameof(Threads), value); }
        }
        /// <summary>The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.</summary>
        public string Topic {
            get { return BackingStore?.Get<string>(nameof(Topic)); }
            set { BackingStore?.Set(nameof(Topic), value); }
        }
        /// <summary>All the users that sent a message to this Conversation.</summary>
        public List<string> UniqueSenders {
            get { return BackingStore?.Get<List<string>>(nameof(UniqueSenders)); }
            set { BackingStore?.Set(nameof(UniqueSenders), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Conversation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Conversation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"lastDeliveredDateTime", n => { LastDeliveredDateTime = n.GetDateTimeOffsetValue(); } },
                {"preview", n => { Preview = n.GetStringValue(); } },
                {"threads", n => { Threads = n.GetCollectionOfObjectValues<ConversationThread>(ConversationThread.CreateFromDiscriminatorValue).ToList(); } },
                {"topic", n => { Topic = n.GetStringValue(); } },
                {"uniqueSenders", n => { UniqueSenders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteDateTimeOffsetValue("lastDeliveredDateTime", LastDeliveredDateTime);
            writer.WriteStringValue("preview", Preview);
            writer.WriteCollectionOfObjectValues<ConversationThread>("threads", Threads);
            writer.WriteStringValue("topic", Topic);
            writer.WriteCollectionOfPrimitiveValues<string>("uniqueSenders", UniqueSenders);
        }
    }
}
