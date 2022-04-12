using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementIntentDeviceSettingStateSummary : Entity, IParsable {
        /// <summary>Number of compliant devices</summary>
        public int? CompliantCount { get; set; }
        /// <summary>Number of devices in conflict</summary>
        public int? ConflictCount { get; set; }
        /// <summary>Number of error devices</summary>
        public int? ErrorCount { get; set; }
        /// <summary>Number of non compliant devices</summary>
        public int? NonCompliantCount { get; set; }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableCount { get; set; }
        /// <summary>Number of remediated devices</summary>
        public int? RemediatedCount { get; set; }
        /// <summary>Name of a setting</summary>
        public string SettingName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementIntentDeviceSettingStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntentDeviceSettingStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantCount", n => { CompliantCount = n.GetIntValue(); } },
                {"conflictCount", n => { ConflictCount = n.GetIntValue(); } },
                {"errorCount", n => { ErrorCount = n.GetIntValue(); } },
                {"nonCompliantCount", n => { NonCompliantCount = n.GetIntValue(); } },
                {"notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                {"remediatedCount", n => { RemediatedCount = n.GetIntValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantCount", CompliantCount);
            writer.WriteIntValue("conflictCount", ConflictCount);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("nonCompliantCount", NonCompliantCount);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("remediatedCount", RemediatedCount);
            writer.WriteStringValue("settingName", SettingName);
        }
    }
}
