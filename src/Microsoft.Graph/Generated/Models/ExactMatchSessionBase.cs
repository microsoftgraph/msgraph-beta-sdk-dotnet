using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the dataClassificationService singleton.</summary>
    public class ExactMatchSessionBase : ExactMatchJobBase, IParsable {
        /// <summary>The dataStoreId property</summary>
        public string DataStoreId {
            get { return BackingStore?.Get<string>(nameof(DataStoreId)); }
            set { BackingStore?.Set(nameof(DataStoreId), value); }
        }
        /// <summary>The processingCompletionDateTime property</summary>
        public DateTimeOffset? ProcessingCompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ProcessingCompletionDateTime)); }
            set { BackingStore?.Set(nameof(ProcessingCompletionDateTime), value); }
        }
        /// <summary>The remainingBlockCount property</summary>
        public int? RemainingBlockCount {
            get { return BackingStore?.Get<int?>(nameof(RemainingBlockCount)); }
            set { BackingStore?.Set(nameof(RemainingBlockCount), value); }
        }
        /// <summary>The remainingJobCount property</summary>
        public int? RemainingJobCount {
            get { return BackingStore?.Get<int?>(nameof(RemainingJobCount)); }
            set { BackingStore?.Set(nameof(RemainingJobCount), value); }
        }
        /// <summary>The state property</summary>
        public string State {
            get { return BackingStore?.Get<string>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>The totalBlockCount property</summary>
        public int? TotalBlockCount {
            get { return BackingStore?.Get<int?>(nameof(TotalBlockCount)); }
            set { BackingStore?.Set(nameof(TotalBlockCount), value); }
        }
        /// <summary>The totalJobCount property</summary>
        public int? TotalJobCount {
            get { return BackingStore?.Get<int?>(nameof(TotalJobCount)); }
            set { BackingStore?.Set(nameof(TotalJobCount), value); }
        }
        /// <summary>The uploadCompletionDateTime property</summary>
        public DateTimeOffset? UploadCompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(UploadCompletionDateTime)); }
            set { BackingStore?.Set(nameof(UploadCompletionDateTime), value); }
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
                "#microsoft.graph.exactMatchSessionBase" => new ExactMatchSessionBase(),
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
