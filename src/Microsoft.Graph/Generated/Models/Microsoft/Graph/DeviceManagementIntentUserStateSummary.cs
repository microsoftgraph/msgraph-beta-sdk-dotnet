using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementIntentUserStateSummary : Entity, IParsable {
        /// <summary>Number of users in conflict</summary>
        public int? ConflictCount { get; set; }
        /// <summary>Number of error users</summary>
        public int? ErrorCount { get; set; }
        /// <summary>Number of failed users</summary>
        public int? FailedCount { get; set; }
        /// <summary>Number of not applicable users</summary>
        public int? NotApplicableCount { get; set; }
        /// <summary>Number of succeeded users</summary>
        public int? SuccessCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"conflictCount", (o,n) => { (o as DeviceManagementIntentUserStateSummary).ConflictCount = n.GetIntValue(); } },
                {"errorCount", (o,n) => { (o as DeviceManagementIntentUserStateSummary).ErrorCount = n.GetIntValue(); } },
                {"failedCount", (o,n) => { (o as DeviceManagementIntentUserStateSummary).FailedCount = n.GetIntValue(); } },
                {"notApplicableCount", (o,n) => { (o as DeviceManagementIntentUserStateSummary).NotApplicableCount = n.GetIntValue(); } },
                {"successCount", (o,n) => { (o as DeviceManagementIntentUserStateSummary).SuccessCount = n.GetIntValue(); } },
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
