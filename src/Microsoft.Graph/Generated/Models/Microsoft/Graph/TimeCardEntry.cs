using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TimeCardEntry : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of breaks associated with the timeCard.</summary>
        public List<TimeCardBreak> Breaks { get; set; }
        /// <summary>The clock-in event of the timeCard.</summary>
        public TimeCardEvent ClockInEvent { get; set; }
        /// <summary>The clock-out event of the timeCard.</summary>
        public TimeCardEvent ClockOutEvent { get; set; }
        /// <summary>
        /// Instantiates a new timeCardEntry and sets the default values.
        /// </summary>
        public TimeCardEntry() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TimeCardEntry CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeCardEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"breaks", (o,n) => { (o as TimeCardEntry).Breaks = n.GetCollectionOfObjectValues<TimeCardBreak>(TimeCardBreak.CreateFromDiscriminatorValue).ToList(); } },
                {"clockInEvent", (o,n) => { (o as TimeCardEntry).ClockInEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"clockOutEvent", (o,n) => { (o as TimeCardEntry).ClockOutEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TimeCardBreak>("breaks", Breaks);
            writer.WriteObjectValue<TimeCardEvent>("clockInEvent", ClockInEvent);
            writer.WriteObjectValue<TimeCardEvent>("clockOutEvent", ClockOutEvent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
