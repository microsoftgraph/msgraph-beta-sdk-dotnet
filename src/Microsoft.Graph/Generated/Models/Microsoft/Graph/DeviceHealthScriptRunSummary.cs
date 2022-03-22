using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceHealthScriptRunSummary : Entity, IParsable {
        /// <summary>Number of devices on which the detection script execution encountered an error and did not complete</summary>
        public int? DetectionScriptErrorDeviceCount { get; set; }
        /// <summary>Number of devices for which the detection script was not applicable</summary>
        public int? DetectionScriptNotApplicableDeviceCount { get; set; }
        /// <summary>Number of devices which have not yet run the latest version of the device health script</summary>
        public int? DetectionScriptPendingDeviceCount { get; set; }
        /// <summary>Number of devices for which the detection script found an issue</summary>
        public int? IssueDetectedDeviceCount { get; set; }
        /// <summary>Number of devices that were remediated over the last 30 days</summary>
        public int? IssueRemediatedCumulativeDeviceCount { get; set; }
        /// <summary>Number of devices for which the remediation script was able to resolve the detected issue</summary>
        public int? IssueRemediatedDeviceCount { get; set; }
        /// <summary>Number of devices for which the remediation script executed successfully but failed to resolve the detected issue</summary>
        public int? IssueReoccurredDeviceCount { get; set; }
        /// <summary>Last run time for the script across all devices</summary>
        public DateTimeOffset? LastScriptRunDateTime { get; set; }
        /// <summary>Number of devices for which the detection script did not find an issue and the device is healthy</summary>
        public int? NoIssueDetectedDeviceCount { get; set; }
        /// <summary>Number of devices for which the remediation script execution encountered an error and did not complete</summary>
        public int? RemediationScriptErrorDeviceCount { get; set; }
        /// <summary>Number of devices for which remediation was skipped</summary>
        public int? RemediationSkippedDeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceHealthScriptRunSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptRunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"detectionScriptErrorDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).DetectionScriptErrorDeviceCount = n.GetIntValue(); } },
                {"detectionScriptNotApplicableDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).DetectionScriptNotApplicableDeviceCount = n.GetIntValue(); } },
                {"detectionScriptPendingDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).DetectionScriptPendingDeviceCount = n.GetIntValue(); } },
                {"issueDetectedDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).IssueDetectedDeviceCount = n.GetIntValue(); } },
                {"issueRemediatedCumulativeDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).IssueRemediatedCumulativeDeviceCount = n.GetIntValue(); } },
                {"issueRemediatedDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).IssueRemediatedDeviceCount = n.GetIntValue(); } },
                {"issueReoccurredDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).IssueReoccurredDeviceCount = n.GetIntValue(); } },
                {"lastScriptRunDateTime", (o,n) => { (o as DeviceHealthScriptRunSummary).LastScriptRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"noIssueDetectedDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).NoIssueDetectedDeviceCount = n.GetIntValue(); } },
                {"remediationScriptErrorDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).RemediationScriptErrorDeviceCount = n.GetIntValue(); } },
                {"remediationSkippedDeviceCount", (o,n) => { (o as DeviceHealthScriptRunSummary).RemediationSkippedDeviceCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("detectionScriptNotApplicableDeviceCount", DetectionScriptNotApplicableDeviceCount);
            writer.WriteIntValue("detectionScriptPendingDeviceCount", DetectionScriptPendingDeviceCount);
            writer.WriteIntValue("issueDetectedDeviceCount", IssueDetectedDeviceCount);
            writer.WriteIntValue("issueRemediatedCumulativeDeviceCount", IssueRemediatedCumulativeDeviceCount);
            writer.WriteIntValue("issueRemediatedDeviceCount", IssueRemediatedDeviceCount);
            writer.WriteIntValue("issueReoccurredDeviceCount", IssueReoccurredDeviceCount);
            writer.WriteDateTimeOffsetValue("lastScriptRunDateTime", LastScriptRunDateTime);
            writer.WriteIntValue("noIssueDetectedDeviceCount", NoIssueDetectedDeviceCount);
            writer.WriteIntValue("remediationScriptErrorDeviceCount", RemediationScriptErrorDeviceCount);
            writer.WriteIntValue("remediationSkippedDeviceCount", RemediationSkippedDeviceCount);
        }
    }
}
