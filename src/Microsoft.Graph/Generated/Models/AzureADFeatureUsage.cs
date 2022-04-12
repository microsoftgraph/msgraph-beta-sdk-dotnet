using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AzureADFeatureUsage : Entity, IParsable {
        /// <summary>The featureName property</summary>
        public string FeatureName { get; set; }
        /// <summary>The snapshotDateTime property</summary>
        public DateTimeOffset? SnapshotDateTime { get; set; }
        /// <summary>The usage property</summary>
        public int? Usage { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AzureADFeatureUsage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureADFeatureUsage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"featureName", n => { FeatureName = n.GetStringValue(); } },
                {"snapshotDateTime", n => { SnapshotDateTime = n.GetDateTimeOffsetValue(); } },
                {"usage", n => { Usage = n.GetIntValue(); } },
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
