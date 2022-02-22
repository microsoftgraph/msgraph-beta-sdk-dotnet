using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TimeCardBreak : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ID of the timeCardBreak.</summary>
        public string BreakId { get; set; }
        /// <summary>The start event of the timeCardBreak.</summary>
        public TimeCardEvent End { get; set; }
        /// <summary>Notes about the timeCardBreak.</summary>
        public ItemBody Notes { get; set; }
        public TimeCardEvent Start { get; set; }
        /// <summary>
        /// Instantiates a new timeCardBreak and sets the default values.
        /// </summary>
        public TimeCardBreak() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"breakId", (o,n) => { (o as TimeCardBreak).BreakId = n.GetStringValue(); } },
                {"end", (o,n) => { (o as TimeCardBreak).End = n.GetObjectValue<TimeCardEvent>(); } },
                {"notes", (o,n) => { (o as TimeCardBreak).Notes = n.GetObjectValue<ItemBody>(); } },
                {"start", (o,n) => { (o as TimeCardBreak).Start = n.GetObjectValue<TimeCardEvent>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("breakId", BreakId);
            writer.WriteObjectValue<TimeCardEvent>("end", End);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteObjectValue<TimeCardEvent>("start", Start);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
