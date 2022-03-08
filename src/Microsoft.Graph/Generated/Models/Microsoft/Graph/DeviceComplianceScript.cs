using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceComplianceScript : Entity, IParsable {
        /// <summary>The list of group assignments for the device compliance script</summary>
        public List<DeviceHealthScriptAssignment> Assignments { get; set; }
        /// <summary>The timestamp of when the device compliance script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the device compliance script</summary>
        public string Description { get; set; }
        /// <summary>The entire content of the detection powershell script</summary>
        public byte[] DetectionScriptContent { get; set; }
        /// <summary>List of run states for the device compliance script across all devices</summary>
        public List<DeviceComplianceScriptDeviceState> DeviceRunStates { get; set; }
        /// <summary>Name of the device compliance script</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicate whether the script signature needs be checked</summary>
        public bool? EnforceSignatureCheck { get; set; }
        /// <summary>The timestamp of when the device compliance script was modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Name of the device compliance script publisher</summary>
        public string Publisher { get; set; }
        /// <summary>List of Scope Tag IDs for the device compliance script</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Indicate whether PowerShell script(s) should run as 32-bit</summary>
        public bool? RunAs32Bit { get; set; }
        /// <summary>Indicates the type of execution context. Possible values are: system, user.</summary>
        public RunAsAccountType? RunAsAccount { get; set; }
        /// <summary>High level run summary for device compliance script.</summary>
        public DeviceComplianceScriptRunSummary RunSummary { get; set; }
        /// <summary>Version of the device compliance script</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceComplianceScript CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceComplianceScript).Assignments = n.GetCollectionOfObjectValues<DeviceHealthScriptAssignment>(DeviceHealthScriptAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceComplianceScript).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceComplianceScript).Description = n.GetStringValue(); } },
                {"detectionScriptContent", (o,n) => { (o as DeviceComplianceScript).DetectionScriptContent = n.GetByteArrayValue(); } },
                {"deviceRunStates", (o,n) => { (o as DeviceComplianceScript).DeviceRunStates = n.GetCollectionOfObjectValues<DeviceComplianceScriptDeviceState>(DeviceComplianceScriptDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as DeviceComplianceScript).DisplayName = n.GetStringValue(); } },
                {"enforceSignatureCheck", (o,n) => { (o as DeviceComplianceScript).EnforceSignatureCheck = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceComplianceScript).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publisher", (o,n) => { (o as DeviceComplianceScript).Publisher = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceComplianceScript).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"runAs32Bit", (o,n) => { (o as DeviceComplianceScript).RunAs32Bit = n.GetBoolValue(); } },
                {"runAsAccount", (o,n) => { (o as DeviceComplianceScript).RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", (o,n) => { (o as DeviceComplianceScript).RunSummary = n.GetObjectValue<DeviceComplianceScriptRunSummary>(DeviceComplianceScriptRunSummary.CreateFromDiscriminatorValue); } },
                {"version", (o,n) => { (o as DeviceComplianceScript).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteByteArrayValue("detectionScriptContent", DetectionScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceComplianceScriptRunSummary>("runSummary", RunSummary);
            writer.WriteStringValue("version", Version);
        }
    }
}
