using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementScript : Entity, IParsable {
        /// <summary>The list of group assignments for the device management script.</summary>
        public List<DeviceManagementScriptAssignment> Assignments { get; set; }
        /// <summary>The date and time the device management script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Optional description for the device management script.</summary>
        public string Description { get; set; }
        /// <summary>List of run states for this script across all devices.</summary>
        public List<DeviceManagementScriptDeviceState> DeviceRunStates { get; set; }
        /// <summary>Name of the device management script.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicate whether the script signature needs be checked.</summary>
        public bool? EnforceSignatureCheck { get; set; }
        /// <summary>Script file name.</summary>
        public string FileName { get; set; }
        /// <summary>The list of group assignments for the device management script.</summary>
        public List<DeviceManagementScriptGroupAssignment> GroupAssignments { get; set; }
        /// <summary>The date and time the device management script was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>List of Scope Tag IDs for this PowerShellScript instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>A value indicating whether the PowerShell script should run as 32-bit</summary>
        public bool? RunAs32Bit { get; set; }
        /// <summary>Indicates the type of execution context. Possible values are: system, user.</summary>
        public RunAsAccountType? RunAsAccount { get; set; }
        /// <summary>Run summary for device management script.</summary>
        public DeviceManagementScriptRunSummary RunSummary { get; set; }
        /// <summary>The script content.</summary>
        public byte[] ScriptContent { get; set; }
        /// <summary>List of run states for this script across all users.</summary>
        public List<DeviceManagementScriptUserState> UserRunStates { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceManagementScript).Assignments = n.GetCollectionOfObjectValues<DeviceManagementScriptAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceManagementScript).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceManagementScript).Description = n.GetStringValue(); } },
                {"deviceRunStates", (o,n) => { (o as DeviceManagementScript).DeviceRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptDeviceState>().ToList(); } },
                {"displayName", (o,n) => { (o as DeviceManagementScript).DisplayName = n.GetStringValue(); } },
                {"enforceSignatureCheck", (o,n) => { (o as DeviceManagementScript).EnforceSignatureCheck = n.GetBoolValue(); } },
                {"fileName", (o,n) => { (o as DeviceManagementScript).FileName = n.GetStringValue(); } },
                {"groupAssignments", (o,n) => { (o as DeviceManagementScript).GroupAssignments = n.GetCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>().ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceManagementScript).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceManagementScript).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"runAs32Bit", (o,n) => { (o as DeviceManagementScript).RunAs32Bit = n.GetBoolValue(); } },
                {"runAsAccount", (o,n) => { (o as DeviceManagementScript).RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", (o,n) => { (o as DeviceManagementScript).RunSummary = n.GetObjectValue<DeviceManagementScriptRunSummary>(); } },
                {"scriptContent", (o,n) => { (o as DeviceManagementScript).ScriptContent = n.GetByteArrayValue(); } },
                {"userRunStates", (o,n) => { (o as DeviceManagementScript).UserRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptUserState>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceManagementScriptRunSummary>("runSummary", RunSummary);
            writer.WriteByteArrayValue("scriptContent", ScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptUserState>("userRunStates", UserRunStates);
        }
    }
}
