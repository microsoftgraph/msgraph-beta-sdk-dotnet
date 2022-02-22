using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CloudPcSnapshot : Entity, IParsable {
        /// <summary>The unique identifier for the Cloud PC.</summary>
        public string CloudPcId { get; set; }
        /// <summary>The date and time at which the snapshot was taken. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The date and time at which the snapshot was last used to restore the Cloud PC device. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastRestoredDateTime { get; set; }
        /// <summary>The status of the Cloud PC snapshot. The possible values are: ready, unknownFutureValue.</summary>
        public CloudPcSnapshotStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"cloudPcId", (o,n) => { (o as CloudPcSnapshot).CloudPcId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as CloudPcSnapshot).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRestoredDateTime", (o,n) => { (o as CloudPcSnapshot).LastRestoredDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as CloudPcSnapshot).Status = n.GetEnumValue<CloudPcSnapshotStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("cloudPcId", CloudPcId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastRestoredDateTime", LastRestoredDateTime);
            writer.WriteEnumValue<CloudPcSnapshotStatus>("status", Status);
        }
    }
}
