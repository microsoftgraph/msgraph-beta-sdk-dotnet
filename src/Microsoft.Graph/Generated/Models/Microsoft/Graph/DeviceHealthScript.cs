using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceHealthScript : Entity, IParsable {
        /// <summary>The list of group assignments for the device health script</summary>
        public List<DeviceHealthScriptAssignment> Assignments { get; set; }
        /// <summary>The timestamp of when the device health script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the device health script</summary>
        public string Description { get; set; }
        /// <summary>The entire content of the detection powershell script</summary>
        public byte[] DetectionScriptContent { get; set; }
        /// <summary>List of ComplexType DetectionScriptParameters objects.</summary>
        public List<DeviceHealthScriptParameter> DetectionScriptParameters { get; set; }
        /// <summary>List of run states for the device health script across all devices</summary>
        public List<DeviceHealthScriptDeviceState> DeviceRunStates { get; set; }
        /// <summary>Name of the device health script</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicate whether the script signature needs be checked</summary>
        public bool? EnforceSignatureCheck { get; set; }
        /// <summary>Highest available version for a Microsoft Proprietary script</summary>
        public string HighestAvailableVersion { get; set; }
        /// <summary>Determines if this is Microsoft Proprietary Script. Proprietary scripts are read-only</summary>
        public bool? IsGlobalScript { get; set; }
        /// <summary>The timestamp of when the device health script was modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Name of the device health script publisher</summary>
        public string Publisher { get; set; }
        /// <summary>The entire content of the remediation powershell script</summary>
        public byte[] RemediationScriptContent { get; set; }
        /// <summary>List of ComplexType RemediationScriptParameters objects.</summary>
        public List<DeviceHealthScriptParameter> RemediationScriptParameters { get; set; }
        /// <summary>List of Scope Tag IDs for the device health script</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Indicate whether PowerShell script(s) should run as 32-bit</summary>
        public bool? RunAs32Bit { get; set; }
        /// <summary>Indicates the type of execution context. Possible values are: system, user.</summary>
        public RunAsAccountType? RunAsAccount { get; set; }
        /// <summary>High level run summary for device health script.</summary>
        public DeviceHealthScriptRunSummary RunSummary { get; set; }
        /// <summary>Version of the device health script</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceHealthScript CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceHealthScript).Assignments = n.GetCollectionOfObjectValues<DeviceHealthScriptAssignment>(DeviceHealthScriptAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceHealthScript).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceHealthScript).Description = n.GetStringValue(); } },
                {"detectionScriptContent", (o,n) => { (o as DeviceHealthScript).DetectionScriptContent = n.GetByteArrayValue(); } },
                {"detectionScriptParameters", (o,n) => { (o as DeviceHealthScript).DetectionScriptParameters = n.GetCollectionOfObjectValues<DeviceHealthScriptParameter>(DeviceHealthScriptParameter.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceRunStates", (o,n) => { (o as DeviceHealthScript).DeviceRunStates = n.GetCollectionOfObjectValues<DeviceHealthScriptDeviceState>(DeviceHealthScriptDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as DeviceHealthScript).DisplayName = n.GetStringValue(); } },
                {"enforceSignatureCheck", (o,n) => { (o as DeviceHealthScript).EnforceSignatureCheck = n.GetBoolValue(); } },
                {"highestAvailableVersion", (o,n) => { (o as DeviceHealthScript).HighestAvailableVersion = n.GetStringValue(); } },
                {"isGlobalScript", (o,n) => { (o as DeviceHealthScript).IsGlobalScript = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceHealthScript).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publisher", (o,n) => { (o as DeviceHealthScript).Publisher = n.GetStringValue(); } },
                {"remediationScriptContent", (o,n) => { (o as DeviceHealthScript).RemediationScriptContent = n.GetByteArrayValue(); } },
                {"remediationScriptParameters", (o,n) => { (o as DeviceHealthScript).RemediationScriptParameters = n.GetCollectionOfObjectValues<DeviceHealthScriptParameter>(DeviceHealthScriptParameter.CreateFromDiscriminatorValue).ToList(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceHealthScript).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"runAs32Bit", (o,n) => { (o as DeviceHealthScript).RunAs32Bit = n.GetBoolValue(); } },
                {"runAsAccount", (o,n) => { (o as DeviceHealthScript).RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", (o,n) => { (o as DeviceHealthScript).RunSummary = n.GetObjectValue<DeviceHealthScriptRunSummary>(DeviceHealthScriptRunSummary.CreateFromDiscriminatorValue); } },
                {"version", (o,n) => { (o as DeviceHealthScript).Version = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptParameter>("detectionScriptParameters", DetectionScriptParameters);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteStringValue("highestAvailableVersion", HighestAvailableVersion);
            writer.WriteBoolValue("isGlobalScript", IsGlobalScript);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteByteArrayValue("remediationScriptContent", RemediationScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptParameter>("remediationScriptParameters", RemediationScriptParameters);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceHealthScriptRunSummary>("runSummary", RunSummary);
            writer.WriteStringValue("version", Version);
        }
    }
}
