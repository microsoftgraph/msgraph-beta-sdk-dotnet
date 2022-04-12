using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceHealthScriptAssignment>(DeviceHealthScriptAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"detectionScriptContent", n => { DetectionScriptContent = n.GetByteArrayValue(); } },
                {"deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<DeviceComplianceScriptDeviceState>(DeviceComplianceScriptDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", n => { RunSummary = n.GetObjectValue<DeviceComplianceScriptRunSummary>(DeviceComplianceScriptRunSummary.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetStringValue(); } },
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
