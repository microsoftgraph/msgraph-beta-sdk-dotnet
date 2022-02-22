using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AzureADFeatureUsage : Entity, IParsable {
        public string FeatureName { get; set; }
        public DateTimeOffset? SnapshotDateTime { get; set; }
        public int? Usage { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"featureName", (o,n) => { (o as AzureADFeatureUsage).FeatureName = n.GetStringValue(); } },
                {"snapshotDateTime", (o,n) => { (o as AzureADFeatureUsage).SnapshotDateTime = n.GetDateTimeOffsetValue(); } },
                {"usage", (o,n) => { (o as AzureADFeatureUsage).Usage = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("featureName", FeatureName);
            writer.WriteDateTimeOffsetValue("snapshotDateTime", SnapshotDateTime);
            writer.WriteIntValue("usage", Usage);
        }
    }
}
