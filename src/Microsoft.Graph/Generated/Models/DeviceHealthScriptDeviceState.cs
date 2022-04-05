using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceHealthScriptDeviceState : Entity, IParsable {
        /// <summary>A list of the assignment filter ids used for health script applicability evaluation</summary>
        public List<string> AssignmentFilterIds { get; set; }
        /// <summary>Detection state from the lastest device health script execution. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.</summary>
        public RunState? DetectionState { get; set; }
        /// <summary>The next timestamp of when the device health script is expected to execute</summary>
        public DateTimeOffset? ExpectedStateUpdateDateTime { get; set; }
        /// <summary>The last timestamp of when the device health script executed</summary>
        public DateTimeOffset? LastStateUpdateDateTime { get; set; }
        /// <summary>The last time that Intune Managment Extension synced with Intune</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>The managed device on which the device health script executed</summary>
        public Microsoft.Graph.Beta.Models.ManagedDevice ManagedDevice { get; set; }
        /// <summary>Error from the detection script after remediation</summary>
        public string PostRemediationDetectionScriptError { get; set; }
        /// <summary>Detection script output after remediation</summary>
        public string PostRemediationDetectionScriptOutput { get; set; }
        /// <summary>Error from the detection script before remediation</summary>
        public string PreRemediationDetectionScriptError { get; set; }
        /// <summary>Output of the detection script before remediation</summary>
        public string PreRemediationDetectionScriptOutput { get; set; }
        /// <summary>Error output of the remediation script</summary>
        public string RemediationScriptError { get; set; }
        /// <summary>Remediation state from the lastest device health script execution. Possible values are: unknown, skipped, success, remediationFailed, scriptError.</summary>
        public Microsoft.Graph.Beta.Models.RemediationState? RemediationState { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceHealthScriptDeviceState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignmentFilterIds", (o,n) => { (o as DeviceHealthScriptDeviceState).AssignmentFilterIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"detectionState", (o,n) => { (o as DeviceHealthScriptDeviceState).DetectionState = n.GetEnumValue<RunState>(); } },
                {"expectedStateUpdateDateTime", (o,n) => { (o as DeviceHealthScriptDeviceState).ExpectedStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastStateUpdateDateTime", (o,n) => { (o as DeviceHealthScriptDeviceState).LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as DeviceHealthScriptDeviceState).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDevice", (o,n) => { (o as DeviceHealthScriptDeviceState).ManagedDevice = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDevice>(Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue); } },
                {"postRemediationDetectionScriptError", (o,n) => { (o as DeviceHealthScriptDeviceState).PostRemediationDetectionScriptError = n.GetStringValue(); } },
                {"postRemediationDetectionScriptOutput", (o,n) => { (o as DeviceHealthScriptDeviceState).PostRemediationDetectionScriptOutput = n.GetStringValue(); } },
                {"preRemediationDetectionScriptError", (o,n) => { (o as DeviceHealthScriptDeviceState).PreRemediationDetectionScriptError = n.GetStringValue(); } },
                {"preRemediationDetectionScriptOutput", (o,n) => { (o as DeviceHealthScriptDeviceState).PreRemediationDetectionScriptOutput = n.GetStringValue(); } },
                {"remediationScriptError", (o,n) => { (o as DeviceHealthScriptDeviceState).RemediationScriptError = n.GetStringValue(); } },
                {"remediationState", (o,n) => { (o as DeviceHealthScriptDeviceState).RemediationState = n.GetEnumValue<RemediationState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("assignmentFilterIds", AssignmentFilterIds);
            writer.WriteEnumValue<RunState>("detectionState", DetectionState);
            writer.WriteDateTimeOffsetValue("expectedStateUpdateDateTime", ExpectedStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevice", ManagedDevice);
            writer.WriteStringValue("postRemediationDetectionScriptError", PostRemediationDetectionScriptError);
            writer.WriteStringValue("postRemediationDetectionScriptOutput", PostRemediationDetectionScriptOutput);
            writer.WriteStringValue("preRemediationDetectionScriptError", PreRemediationDetectionScriptError);
            writer.WriteStringValue("preRemediationDetectionScriptOutput", PreRemediationDetectionScriptOutput);
            writer.WriteStringValue("remediationScriptError", RemediationScriptError);
            writer.WriteEnumValue<RemediationState>("remediationState", RemediationState);
        }
    }
}
