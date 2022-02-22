using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementConfigurationPolicy : Entity, IParsable {
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
        /// <summary>Number of settings. This property is read-only.</summary>
        public int? SettingCount { get; set; }
        /// <summary>Policy settings</summary>
        public List<DeviceManagementConfigurationSetting> Settings { get; set; }
        /// <summary>Technologies for this policy. Possible values are: none, mdm, windows10XManagement, configManager, microsoftSense, exchangeOnline, linuxMdm, unknownFutureValue.</summary>
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
        /// <summary>Template reference information</summary>
        public DeviceManagementConfigurationPolicyTemplateReference TemplateReference { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceManagementConfigurationPolicy).Assignments = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicyAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceManagementConfigurationPolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationSource", (o,n) => { (o as DeviceManagementConfigurationPolicy).CreationSource = n.GetStringValue(); } },
                {"description", (o,n) => { (o as DeviceManagementConfigurationPolicy).Description = n.GetStringValue(); } },
                {"isAssigned", (o,n) => { (o as DeviceManagementConfigurationPolicy).IsAssigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceManagementConfigurationPolicy).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as DeviceManagementConfigurationPolicy).Name = n.GetStringValue(); } },
                {"platforms", (o,n) => { (o as DeviceManagementConfigurationPolicy).Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceManagementConfigurationPolicy).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"settingCount", (o,n) => { (o as DeviceManagementConfigurationPolicy).SettingCount = n.GetIntValue(); } },
                {"settings", (o,n) => { (o as DeviceManagementConfigurationPolicy).Settings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSetting>().ToList(); } },
                {"technologies", (o,n) => { (o as DeviceManagementConfigurationPolicy).Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
                {"templateReference", (o,n) => { (o as DeviceManagementConfigurationPolicy).TemplateReference = n.GetObjectValue<DeviceManagementConfigurationPolicyTemplateReference>(); } },
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
            writer.WriteIntValue("settingCount", SettingCount);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSetting>("settings", Settings);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
            writer.WriteObjectValue<DeviceManagementConfigurationPolicyTemplateReference>("templateReference", TemplateReference);
        }
    }
}
