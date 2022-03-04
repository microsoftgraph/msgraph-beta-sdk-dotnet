using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TimeCard : ChangeTrackedEntity, IParsable {
        /// <summary>The list of breaks associated with the timeCard.</summary>
        public List<TimeCardBreak> Breaks { get; set; }
        /// <summary>The clock-in event of the timeCard.</summary>
        public TimeCardEvent ClockInEvent { get; set; }
        /// <summary>The clock-out event of the timeCard.</summary>
        public TimeCardEvent ClockOutEvent { get; set; }
        /// <summary>Indicate if this timeCard entry is confirmed. Possible values are none, user, manager, unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ConfirmedBy? ConfirmedBy { get; set; }
        /// <summary>Notes about the timeCard.</summary>
        public ItemBody Notes { get; set; }
        /// <summary>The original timeCardEntry of the timeCard, before user edits.</summary>
        public TimeCardEntry OriginalEntry { get; set; }
        /// <summary>The current state of the timeCard during its life cycle.Possible values are: clockedIn, onBreak, clockedOut, unknownFutureValue.</summary>
        public TimeCardState? State { get; set; }
        /// <summary>User ID to which  the timeCard belongs.</summary>
        public string UserId { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"breaks", (o,n) => { (o as TimeCard).Breaks = n.GetCollectionOfObjectValues<TimeCardBreak>(TimeCardBreak.CreateFromDiscriminatorValue).ToList(); } },
                {"clockInEvent", (o,n) => { (o as TimeCard).ClockInEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"clockOutEvent", (o,n) => { (o as TimeCard).ClockOutEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"confirmedBy", (o,n) => { (o as TimeCard).ConfirmedBy = n.GetEnumValue<ConfirmedBy>(); } },
                {"notes", (o,n) => { (o as TimeCard).Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"originalEntry", (o,n) => { (o as TimeCard).OriginalEntry = n.GetObjectValue<TimeCardEntry>(TimeCardEntry.CreateFromDiscriminatorValue); } },
                {"state", (o,n) => { (o as TimeCard).State = n.GetEnumValue<TimeCardState>(); } },
                {"userId", (o,n) => { (o as TimeCard).UserId = n.GetStringValue(); } },
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
