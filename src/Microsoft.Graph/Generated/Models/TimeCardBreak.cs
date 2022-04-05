using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TimeCardBreak : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ID of the timeCardBreak.</summary>
        public string BreakId { get; set; }
        /// <summary>The start event of the timeCardBreak.</summary>
        public TimeCardEvent End { get; set; }
        /// <summary>Notes about the timeCardBreak.</summary>
        public ItemBody Notes { get; set; }
        /// <summary>The start property</summary>
        public TimeCardEvent Start { get; set; }
        /// <summary>
        /// Instantiates a new timeCardBreak and sets the default values.
        /// </summary>
        public TimeCardBreak() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TimeCardBreak CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeCardBreak();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"breakId", (o,n) => { (o as TimeCardBreak).BreakId = n.GetStringValue(); } },
                {"end", (o,n) => { (o as TimeCardBreak).End = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"notes", (o,n) => { (o as TimeCardBreak).Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"start", (o,n) => { (o as TimeCardBreak).Start = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
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
