using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class RichLongRunningOperation : LongRunningOperation, IParsable {
        /// <summary>Error due to which the operation failed.</summary>
        public PublicError Error { get; set; }
        /// <summary>A value between 0 and 100 that indicates the progress of the operation.</summary>
        public int? PercentageComplete { get; set; }
        /// <summary>A unique identifier for the result.</summary>
        public string ResourceId { get; set; }
        /// <summary>Type of the operation.</summary>
        public string Type { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"error", (o,n) => { (o as RichLongRunningOperation).Error = n.GetObjectValue<PublicError>(); } },
                {"percentageComplete", (o,n) => { (o as RichLongRunningOperation).PercentageComplete = n.GetIntValue(); } },
                {"resourceId", (o,n) => { (o as RichLongRunningOperation).ResourceId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as RichLongRunningOperation).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteIntValue("percentageComplete", PercentageComplete);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("type", Type);
        }
    }
}
