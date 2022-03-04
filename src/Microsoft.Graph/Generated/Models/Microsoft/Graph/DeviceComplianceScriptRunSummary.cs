using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceComplianceScriptRunSummary : Entity, IParsable {
        /// <summary>Number of devices on which the detection script execution encountered an error and did not complete. Valid values -2147483648 to 2147483647</summary>
        public int? DetectionScriptErrorDeviceCount { get; set; }
        /// <summary>Number of devices which have not yet run the latest version of the device compliance script. Valid values -2147483648 to 2147483647</summary>
        public int? DetectionScriptPendingDeviceCount { get; set; }
        /// <summary>Number of devices for which the detection script found an issue. Valid values -2147483648 to 2147483647</summary>
        public int? IssueDetectedDeviceCount { get; set; }
        /// <summary>Last run time for the script across all devices</summary>
        public DateTimeOffset? LastScriptRunDateTime { get; set; }
        /// <summary>Number of devices for which the detection script did not find an issue and the device is healthy. Valid values -2147483648 to 2147483647</summary>
        public int? NoIssueDetectedDeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceComplianceScriptRunSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptRunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"detectionScriptErrorDeviceCount", (o,n) => { (o as DeviceComplianceScriptRunSummary).DetectionScriptErrorDeviceCount = n.GetIntValue(); } },
                {"detectionScriptPendingDeviceCount", (o,n) => { (o as DeviceComplianceScriptRunSummary).DetectionScriptPendingDeviceCount = n.GetIntValue(); } },
                {"issueDetectedDeviceCount", (o,n) => { (o as DeviceComplianceScriptRunSummary).IssueDetectedDeviceCount = n.GetIntValue(); } },
                {"lastScriptRunDateTime", (o,n) => { (o as DeviceComplianceScriptRunSummary).LastScriptRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"noIssueDetectedDeviceCount", (o,n) => { (o as DeviceComplianceScriptRunSummary).NoIssueDetectedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("detectionScriptErrorDeviceCount", DetectionScriptErrorDeviceCount);
            writer.WriteIntValue("detectionScriptPendingDeviceCount", DetectionScriptPendingDeviceCount);
            writer.WriteIntValue("issueDetectedDeviceCount", IssueDetectedDeviceCount);
            writer.WriteDateTimeOffsetValue("lastScriptRunDateTime", LastScriptRunDateTime);
            writer.WriteIntValue("noIssueDetectedDeviceCount", NoIssueDetectedDeviceCount);
        }
    }
}
