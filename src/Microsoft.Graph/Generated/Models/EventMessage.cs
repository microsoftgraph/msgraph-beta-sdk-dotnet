using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EventMessage : Message, IParsable {
        /// <summary>The end time of the requested meeting.</summary>
        public DateTimeTimeZone EndDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(EndDateTime)); }
            set { BackingStore?.Set(nameof(EndDateTime), value); }
        }
        /// <summary>The event associated with the event message. The assumption for attendees or room resources is that the Calendar Attendant is set to automatically update the calendar with an event when meeting request event messages arrive. Navigation property.  Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Event Event {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Event>(nameof(Event)); }
            set { BackingStore?.Set(nameof(Event), value); }
        }
        /// <summary>The isAllDay property</summary>
        public bool? IsAllDay {
            get { return BackingStore?.Get<bool?>(nameof(IsAllDay)); }
            set { BackingStore?.Set(nameof(IsAllDay), value); }
        }
        /// <summary>The isDelegated property</summary>
        public bool? IsDelegated {
            get { return BackingStore?.Get<bool?>(nameof(IsDelegated)); }
            set { BackingStore?.Set(nameof(IsDelegated), value); }
        }
        /// <summary>The isOutOfDate property</summary>
        public bool? IsOutOfDate {
            get { return BackingStore?.Get<bool?>(nameof(IsOutOfDate)); }
            set { BackingStore?.Set(nameof(IsOutOfDate), value); }
        }
        /// <summary>The location property</summary>
        public Microsoft.Graph.Beta.Models.Location Location {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Location>(nameof(Location)); }
            set { BackingStore?.Set(nameof(Location), value); }
        }
        /// <summary>The meetingMessageType property</summary>
        public Microsoft.Graph.Beta.Models.MeetingMessageType? MeetingMessageType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MeetingMessageType?>(nameof(MeetingMessageType)); }
            set { BackingStore?.Set(nameof(MeetingMessageType), value); }
        }
        /// <summary>The recurrence property</summary>
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>(nameof(Recurrence)); }
            set { BackingStore?.Set(nameof(Recurrence), value); }
        }
        /// <summary>The startDateTime property</summary>
        public DateTimeTimeZone StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>The type property</summary>
        public EventType? Type {
            get { return BackingStore?.Get<EventType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EventMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.eventMessageRequest" => new EventMessageRequest(),
                "#microsoft.graph.eventMessageResponse" => new EventMessageResponse(),
                _ => new EventMessage(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endDateTime", n => { EndDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"event", n => { Event = n.GetObjectValue<Microsoft.Graph.Beta.Models.Event>(Microsoft.Graph.Beta.Models.Event.CreateFromDiscriminatorValue); } },
                {"isAllDay", n => { IsAllDay = n.GetBoolValue(); } },
                {"isDelegated", n => { IsDelegated = n.GetBoolValue(); } },
                {"isOutOfDate", n => { IsOutOfDate = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<Microsoft.Graph.Beta.Models.Location>(Microsoft.Graph.Beta.Models.Location.CreateFromDiscriminatorValue); } },
                {"meetingMessageType", n => { MeetingMessageType = n.GetEnumValue<MeetingMessageType>(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<EventType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Event>("event", Event);
            writer.WriteBoolValue("isAllDay", IsAllDay);
            writer.WriteBoolValue("isDelegated", IsDelegated);
            writer.WriteBoolValue("isOutOfDate", IsOutOfDate);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Location>("location", Location);
            writer.WriteEnumValue<MeetingMessageType>("meetingMessageType", MeetingMessageType);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<EventType>("type", Type);
        }
    }
}
