using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class LongRunningOperation : Entity, IParsable {
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DateTimeOffset? LastActionDateTime { get; set; }
        public string ResourceLocation { get; set; }
        public LongRunningOperationStatus? Status { get; set; }
        public string StatusDetail { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as LongRunningOperation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastActionDateTime", (o,n) => { (o as LongRunningOperation).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"resourceLocation", (o,n) => { (o as LongRunningOperation).ResourceLocation = n.GetStringValue(); } },
                {"status", (o,n) => { (o as LongRunningOperation).Status = n.GetEnumValue<LongRunningOperationStatus>(); } },
                {"statusDetail", (o,n) => { (o as LongRunningOperation).StatusDetail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
            writer.WriteEnumValue<LongRunningOperationStatus>("status", Status);
            writer.WriteStringValue("statusDetail", StatusDetail);
        }
    }
}
