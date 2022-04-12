using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceManagementScriptAssignment>(DeviceManagementScriptAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"blockExecutionNotifications", n => { BlockExecutionNotifications = n.GetBoolValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptDeviceState>(DeviceManagementScriptDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"executionFrequency", n => { ExecutionFrequency = n.GetTimeSpanValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"groupAssignments", n => { GroupAssignments = n.GetCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>(DeviceManagementScriptGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"retryCount", n => { RetryCount = n.GetIntValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", n => { RunSummary = n.GetObjectValue<DeviceManagementScriptRunSummary>(DeviceManagementScriptRunSummary.CreateFromDiscriminatorValue); } },
                {"scriptContent", n => { ScriptContent = n.GetByteArrayValue(); } },
                {"userRunStates", n => { UserRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptUserState>(DeviceManagementScriptUserState.CreateFromDiscriminatorValue).ToList(); } },
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
