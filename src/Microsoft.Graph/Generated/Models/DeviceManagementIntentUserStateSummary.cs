using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity that represents user state summary for an intent</summary>
    public class DeviceManagementIntentUserStateSummary : Entity, IParsable {
        /// <summary>Number of users in conflict</summary>
        public int? ConflictCount {
            get { return BackingStore?.Get<int?>(nameof(ConflictCount)); }
            set { BackingStore?.Set(nameof(ConflictCount), value); }
        }
        /// <summary>Number of error users</summary>
        public int? ErrorCount {
            get { return BackingStore?.Get<int?>(nameof(ErrorCount)); }
            set { BackingStore?.Set(nameof(ErrorCount), value); }
        }
        /// <summary>Number of failed users</summary>
        public int? FailedCount {
            get { return BackingStore?.Get<int?>(nameof(FailedCount)); }
            set { BackingStore?.Set(nameof(FailedCount), value); }
        }
        /// <summary>Number of not applicable users</summary>
        public int? NotApplicableCount {
            get { return BackingStore?.Get<int?>(nameof(NotApplicableCount)); }
            set { BackingStore?.Set(nameof(NotApplicableCount), value); }
        }
        /// <summary>Number of succeeded users</summary>
        public int? SuccessCount {
            get { return BackingStore?.Get<int?>(nameof(SuccessCount)); }
            set { BackingStore?.Set(nameof(SuccessCount), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementIntentUserStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntentUserStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conflictCount", n => { ConflictCount = n.GetIntValue(); } },
                {"errorCount", n => { ErrorCount = n.GetIntValue(); } },
                {"failedCount", n => { FailedCount = n.GetIntValue(); } },
                {"notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                {"successCount", n => { SuccessCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("conflictCount", ConflictCount);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
