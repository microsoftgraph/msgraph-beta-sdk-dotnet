using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceShellScript : Entity, IParsable {
        /// <summary>The list of group assignments for the device management script.</summary>
        public List<DeviceManagementScriptAssignment> Assignments { get; set; }
        /// <summary>Does not notify the user a script is being executed</summary>
        public bool? BlockExecutionNotifications { get; set; }
        /// <summary>The date and time the device management script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Optional description for the device management script.</summary>
        public string Description { get; set; }
        /// <summary>List of run states for this script across all devices.</summary>
        public List<DeviceManagementScriptDeviceState> DeviceRunStates { get; set; }
        /// <summary>Name of the device management script.</summary>
        public string DisplayName { get; set; }
        /// <summary>The interval for script to run. If not defined the script will run once</summary>
        public TimeSpan? ExecutionFrequency { get; set; }
        /// <summary>Script file name.</summary>
        public string FileName { get; set; }
        /// <summary>The list of group assignments for the device management script.</summary>
        public List<DeviceManagementScriptGroupAssignment> GroupAssignments { get; set; }
        /// <summary>The date and time the device management script was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Number of times for the script to be retried if it fails</summary>
        public int? RetryCount { get; set; }
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceShellScript CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceShellScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceShellScript).Assignments = n.GetCollectionOfObjectValues<DeviceManagementScriptAssignment>(DeviceManagementScriptAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"blockExecutionNotifications", (o,n) => { (o as DeviceShellScript).BlockExecutionNotifications = n.GetBoolValue(); } },
                {"createdDateTime", (o,n) => { (o as DeviceShellScript).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceShellScript).Description = n.GetStringValue(); } },
                {"deviceRunStates", (o,n) => { (o as DeviceShellScript).DeviceRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptDeviceState>(DeviceManagementScriptDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as DeviceShellScript).DisplayName = n.GetStringValue(); } },
                {"executionFrequency", (o,n) => { (o as DeviceShellScript).ExecutionFrequency = n.GetTimeSpanValue(); } },
                {"fileName", (o,n) => { (o as DeviceShellScript).FileName = n.GetStringValue(); } },
                {"groupAssignments", (o,n) => { (o as DeviceShellScript).GroupAssignments = n.GetCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>(DeviceManagementScriptGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceShellScript).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"retryCount", (o,n) => { (o as DeviceShellScript).RetryCount = n.GetIntValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceShellScript).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"runAsAccount", (o,n) => { (o as DeviceShellScript).RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", (o,n) => { (o as DeviceShellScript).RunSummary = n.GetObjectValue<DeviceManagementScriptRunSummary>(DeviceManagementScriptRunSummary.CreateFromDiscriminatorValue); } },
                {"scriptContent", (o,n) => { (o as DeviceShellScript).ScriptContent = n.GetByteArrayValue(); } },
                {"userRunStates", (o,n) => { (o as DeviceShellScript).UserRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptUserState>(DeviceManagementScriptUserState.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteBoolValue("blockExecutionNotifications", BlockExecutionNotifications);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteTimeSpanValue("executionFrequency", ExecutionFrequency);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("retryCount", RetryCount);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceManagementScriptRunSummary>("runSummary", RunSummary);
            writer.WriteByteArrayValue("scriptContent", ScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptUserState>("userRunStates", UserRunStates);
        }
    }
}
