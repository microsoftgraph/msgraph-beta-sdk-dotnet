using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class TimeCard : ChangeTrackedEntity, IParsable {
        /// <summary>The list of breaks associated with the timeCard.</summary>
        public List<TimeCardBreak> Breaks {
            get { return BackingStore?.Get<List<TimeCardBreak>>(nameof(Breaks)); }
            set { BackingStore?.Set(nameof(Breaks), value); }
        }
        /// <summary>The clock-in event of the timeCard.</summary>
        public TimeCardEvent ClockInEvent {
            get { return BackingStore?.Get<TimeCardEvent>(nameof(ClockInEvent)); }
            set { BackingStore?.Set(nameof(ClockInEvent), value); }
        }
        /// <summary>The clock-out event of the timeCard.</summary>
        public TimeCardEvent ClockOutEvent {
            get { return BackingStore?.Get<TimeCardEvent>(nameof(ClockOutEvent)); }
            set { BackingStore?.Set(nameof(ClockOutEvent), value); }
        }
        /// <summary>Indicate if this timeCard entry is confirmed. Possible values are none, user, manager, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.ConfirmedBy? ConfirmedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConfirmedBy?>(nameof(ConfirmedBy)); }
            set { BackingStore?.Set(nameof(ConfirmedBy), value); }
        }
        /// <summary>Notes about the timeCard.</summary>
        public ItemBody Notes {
            get { return BackingStore?.Get<ItemBody>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>The original timeCardEntry of the timeCard, before user edits.</summary>
        public TimeCardEntry OriginalEntry {
            get { return BackingStore?.Get<TimeCardEntry>(nameof(OriginalEntry)); }
            set { BackingStore?.Set(nameof(OriginalEntry), value); }
        }
        /// <summary>The current state of the timeCard during its life cycle.Possible values are: clockedIn, onBreak, clockedOut, unknownFutureValue.</summary>
        public TimeCardState? State {
            get { return BackingStore?.Get<TimeCardState?>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>User ID to which  the timeCard belongs.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TimeCard CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeCard();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"breaks", n => { Breaks = n.GetCollectionOfObjectValues<TimeCardBreak>(TimeCardBreak.CreateFromDiscriminatorValue).ToList(); } },
                {"clockInEvent", n => { ClockInEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"clockOutEvent", n => { ClockOutEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"confirmedBy", n => { ConfirmedBy = n.GetEnumValue<ConfirmedBy>(); } },
                {"notes", n => { Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"originalEntry", n => { OriginalEntry = n.GetObjectValue<TimeCardEntry>(TimeCardEntry.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<TimeCardState>(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TimeCardBreak>("breaks", Breaks);
            writer.WriteObjectValue<TimeCardEvent>("clockInEvent", ClockInEvent);
            writer.WriteObjectValue<TimeCardEvent>("clockOutEvent", ClockOutEvent);
            writer.WriteEnumValue<ConfirmedBy>("confirmedBy", ConfirmedBy);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteObjectValue<TimeCardEntry>("originalEntry", OriginalEntry);
            writer.WriteEnumValue<TimeCardState>("state", State);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
