using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceCustomAttributeShellScript : Entity, IParsable {
        /// <summary>The list of group assignments for the device management script.</summary>
        public List<DeviceManagementScriptAssignment> Assignments { get; set; }
        /// <summary>The date and time the device management script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The name of the custom attribute.</summary>
        public string CustomAttributeName { get; set; }
        /// <summary>The expected type of the custom attribute's value. Possible values are: integer, string, dateTime.</summary>
        public DeviceCustomAttributeValueType? CustomAttributeType { get; set; }
        /// <summary>Optional description for the device management script.</summary>
        public string Description { get; set; }
        /// <summary>List of run states for this script across all devices.</summary>
        public List<DeviceManagementScriptDeviceState> DeviceRunStates { get; set; }
        /// <summary>Name of the device management script.</summary>
        public string DisplayName { get; set; }
        /// <summary>Script file name.</summary>
        public string FileName { get; set; }
        /// <summary>The list of group assignments for the device management script.</summary>
        public List<DeviceManagementScriptGroupAssignment> GroupAssignments { get; set; }
        /// <summary>The date and time the device management script was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>List of Scope Tag IDs for this PowerShellScript instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
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
                {"assignments", (o,n) => { (o as DeviceCustomAttributeShellScript).Assignments = n.GetCollectionOfObjectValues<DeviceManagementScriptAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceCustomAttributeShellScript).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customAttributeName", (o,n) => { (o as DeviceCustomAttributeShellScript).CustomAttributeName = n.GetStringValue(); } },
                {"customAttributeType", (o,n) => { (o as DeviceCustomAttributeShellScript).CustomAttributeType = n.GetEnumValue<DeviceCustomAttributeValueType>(); } },
                {"description", (o,n) => { (o as DeviceCustomAttributeShellScript).Description = n.GetStringValue(); } },
                {"deviceRunStates", (o,n) => { (o as DeviceCustomAttributeShellScript).DeviceRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptDeviceState>().ToList(); } },
                {"displayName", (o,n) => { (o as DeviceCustomAttributeShellScript).DisplayName = n.GetStringValue(); } },
                {"fileName", (o,n) => { (o as DeviceCustomAttributeShellScript).FileName = n.GetStringValue(); } },
                {"groupAssignments", (o,n) => { (o as DeviceCustomAttributeShellScript).GroupAssignments = n.GetCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>().ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceCustomAttributeShellScript).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceCustomAttributeShellScript).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"runAsAccount", (o,n) => { (o as DeviceCustomAttributeShellScript).RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", (o,n) => { (o as DeviceCustomAttributeShellScript).RunSummary = n.GetObjectValue<DeviceManagementScriptRunSummary>(); } },
                {"scriptContent", (o,n) => { (o as DeviceCustomAttributeShellScript).ScriptContent = n.GetByteArrayValue(); } },
                {"userRunStates", (o,n) => { (o as DeviceCustomAttributeShellScript).UserRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptUserState>().ToList(); } },
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
            writer.WriteStringValue("customAttributeName", CustomAttributeName);
            writer.WriteEnumValue<DeviceCustomAttributeValueType>("customAttributeType", CustomAttributeType);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceManagementScriptRunSummary>("runSummary", RunSummary);
            writer.WriteByteArrayValue("scriptContent", ScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptUserState>("userRunStates", UserRunStates);
        }
    }
}
