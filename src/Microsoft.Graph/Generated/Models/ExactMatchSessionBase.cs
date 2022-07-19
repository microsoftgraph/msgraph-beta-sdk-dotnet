using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExactMatchSessionBase : ExactMatchJobBase, IParsable {
        /// <summary>The dataStoreId property</summary>
        public string DataStoreId {
            get { return BackingStore?.Get<string>("dataStoreId"); }
            set { BackingStore?.Set("dataStoreId", value); }
        }
        /// <summary>The processingCompletionDateTime property</summary>
        public DateTimeOffset? ProcessingCompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("processingCompletionDateTime"); }
            set { BackingStore?.Set("processingCompletionDateTime", value); }
        }
        /// <summary>The remainingBlockCount property</summary>
        public int? RemainingBlockCount {
            get { return BackingStore?.Get<int?>("remainingBlockCount"); }
            set { BackingStore?.Set("remainingBlockCount", value); }
        }
        /// <summary>The remainingJobCount property</summary>
        public int? RemainingJobCount {
            get { return BackingStore?.Get<int?>("remainingJobCount"); }
            set { BackingStore?.Set("remainingJobCount", value); }
        }
        /// <summary>The state property</summary>
        public string State {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The totalBlockCount property</summary>
        public int? TotalBlockCount {
            get { return BackingStore?.Get<int?>("totalBlockCount"); }
            set { BackingStore?.Set("totalBlockCount", value); }
        }
        /// <summary>The totalJobCount property</summary>
        public int? TotalJobCount {
            get { return BackingStore?.Get<int?>("totalJobCount"); }
            set { BackingStore?.Set("totalJobCount", value); }
        }
        /// <summary>The uploadCompletionDateTime property</summary>
        public DateTimeOffset? UploadCompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("uploadCompletionDateTime"); }
            set { BackingStore?.Set("uploadCompletionDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new ExactMatchSessionBase and sets the default values.
        /// </summary>
        public ExactMatchSessionBase() : base() {
            OdataType = "#microsoft.graph.exactMatchSessionBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExactMatchSessionBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.exactMatchSession" => new ExactMatchSession(),
                _ => new ExactMatchSessionBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dataStoreId", n => { DataStoreId = n.GetStringValue(); } },
                {"processingCompletionDateTime", n => { ProcessingCompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"remainingBlockCount", n => { RemainingBlockCount = n.GetIntValue(); } },
                {"remainingJobCount", n => { RemainingJobCount = n.GetIntValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"totalBlockCount", n => { TotalBlockCount = n.GetIntValue(); } },
                {"totalJobCount", n => { TotalJobCount = n.GetIntValue(); } },
                {"uploadCompletionDateTime", n => { UploadCompletionDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("dataStoreId", DataStoreId);
            writer.WriteDateTimeOffsetValue("processingCompletionDateTime", ProcessingCompletionDateTime);
            writer.WriteIntValue("remainingBlockCount", RemainingBlockCount);
            writer.WriteIntValue("remainingJobCount", RemainingJobCount);
            writer.WriteStringValue("state", State);
            writer.WriteIntValue("totalBlockCount", TotalBlockCount);
            writer.WriteIntValue("totalJobCount", TotalJobCount);
            writer.WriteDateTimeOffsetValue("uploadCompletionDateTime", UploadCompletionDateTime);
        }
    }
}
