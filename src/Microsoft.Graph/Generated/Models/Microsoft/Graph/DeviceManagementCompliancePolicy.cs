using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementCompliancePolicy : Entity, IParsable {
        /// <summary>Policy assignments</summary>
        public List<DeviceManagementConfigurationPolicyAssignment> Assignments { get; set; }
        /// <summary>Policy creation date and time. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Policy creation source</summary>
        public string CreationSource { get; set; }
        /// <summary>Policy description</summary>
        public string Description { get; set; }
        /// <summary>Policy assignment status. This property is read-only.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>Policy last modification date and time. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Policy name</summary>
        public string Name { get; set; }
        /// <summary>Platforms for this policy. Possible values are: none, android, iOS, macOS, windows10X, windows10, linux, unknownFutureValue.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>The list of scheduled action for this rule</summary>
        public List<DeviceManagementComplianceScheduledActionForRule> ScheduledActionsForRule { get; set; }
        /// <summary>Number of settings. This property is read-only.</summary>
        public int? SettingCount { get; set; }
        /// <summary>Policy settings</summary>
        public List<DeviceManagementConfigurationSetting> Settings { get; set; }
        /// <summary>Technologies for this policy. Possible values are: none, mdm, windows10XManagement, configManager, microsoftSense, exchangeOnline, linuxMdm, unknownFutureValue.</summary>
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceManagementCompliancePolicy).Assignments = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicyAssignment>(DeviceManagementConfigurationPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceManagementCompliancePolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationSource", (o,n) => { (o as DeviceManagementCompliancePolicy).CreationSource = n.GetStringValue(); } },
                {"description", (o,n) => { (o as DeviceManagementCompliancePolicy).Description = n.GetStringValue(); } },
                {"isAssigned", (o,n) => { (o as DeviceManagementCompliancePolicy).IsAssigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceManagementCompliancePolicy).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as DeviceManagementCompliancePolicy).Name = n.GetStringValue(); } },
                {"platforms", (o,n) => { (o as DeviceManagementCompliancePolicy).Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceManagementCompliancePolicy).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"scheduledActionsForRule", (o,n) => { (o as DeviceManagementCompliancePolicy).ScheduledActionsForRule = n.GetCollectionOfObjectValues<DeviceManagementComplianceScheduledActionForRule>(DeviceManagementComplianceScheduledActionForRule.CreateFromDiscriminatorValue).ToList(); } },
                {"settingCount", (o,n) => { (o as DeviceManagementCompliancePolicy).SettingCount = n.GetIntValue(); } },
                {"settings", (o,n) => { (o as DeviceManagementCompliancePolicy).Settings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSetting>(DeviceManagementConfigurationSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"technologies", (o,n) => { (o as DeviceManagementCompliancePolicy).Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationPolicyAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("creationSource", CreationSource);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platforms", Platforms);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<DeviceManagementComplianceScheduledActionForRule>("scheduledActionsForRule", ScheduledActionsForRule);
            writer.WriteIntValue("settingCount", SettingCount);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSetting>("settings", Settings);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
        }
    }
}
