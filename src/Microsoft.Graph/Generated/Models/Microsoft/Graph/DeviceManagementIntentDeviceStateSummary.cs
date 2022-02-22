using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementIntentDeviceStateSummary : Entity, IParsable {
        /// <summary>Number of devices in conflict</summary>
        public int? ConflictCount { get; set; }
        /// <summary>Number of error devices</summary>
        public int? ErrorCount { get; set; }
        /// <summary>Number of failed devices</summary>
        public int? FailedCount { get; set; }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableCount { get; set; }
        /// <summary>Number of not applicable devices due to mismatch platform and policy</summary>
        public int? NotApplicablePlatformCount { get; set; }
        /// <summary>Number of succeeded devices</summary>
        public int? SuccessCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"conflictCount", (o,n) => { (o as DeviceManagementIntentDeviceStateSummary).ConflictCount = n.GetIntValue(); } },
                {"errorCount", (o,n) => { (o as DeviceManagementIntentDeviceStateSummary).ErrorCount = n.GetIntValue(); } },
                {"failedCount", (o,n) => { (o as DeviceManagementIntentDeviceStateSummary).FailedCount = n.GetIntValue(); } },
                {"notApplicableCount", (o,n) => { (o as DeviceManagementIntentDeviceStateSummary).NotApplicableCount = n.GetIntValue(); } },
                {"notApplicablePlatformCount", (o,n) => { (o as DeviceManagementIntentDeviceStateSummary).NotApplicablePlatformCount = n.GetIntValue(); } },
                {"successCount", (o,n) => { (o as DeviceManagementIntentDeviceStateSummary).SuccessCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("notApplicablePlatformCount", NotApplicablePlatformCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
