using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementConfigurationPolicyTemplate : Entity, IParsable {
        /// <summary>Allow unmanaged setting templates</summary>
        public bool? AllowUnmanagedSettings { get; set; }
        /// <summary>Template base identifier</summary>
        public string BaseId { get; set; }
        /// <summary>Template description</summary>
        public string Description { get; set; }
        /// <summary>Template display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Description of template version</summary>
        public string DisplayVersion { get; set; }
        /// <summary>Indicate current lifecycle state of template. Possible values are: invalid, draft, active, superseded, deprecated, retired.</summary>
        public DeviceManagementTemplateLifecycleState? LifecycleState { get; set; }
        /// <summary>Platforms for this template. Possible values are: none, android, iOS, macOS, windows10X, windows10, linux, unknownFutureValue.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms { get; set; }
        /// <summary>Number of setting templates. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? SettingTemplateCount { get; set; }
        /// <summary>Setting templates</summary>
        public List<DeviceManagementConfigurationSettingTemplate> SettingTemplates { get; set; }
        /// <summary>Technologies for this template. Possible values are: none, mdm, windows10XManagement, configManager, microsoftSense, exchangeOnline, linuxMdm, unknownFutureValue.</summary>
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
        /// <summary>TemplateFamily for this template. Possible values are: none, endpointSecurityAntivirus, endpointSecurityDiskEncryption, endpointSecurityFirewall, endpointSecurityEndpointDetectionAndResponse, endpointSecurityAttackSurfaceReduction, endpointSecurityAccountProtection, endpointSecurityApplicationControl, baseline.</summary>
        public DeviceManagementConfigurationTemplateFamily? TemplateFamily { get; set; }
        /// <summary>Template version. Valid values 1 to 2147483647. This property is read-only.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationPolicyTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationPolicyTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowUnmanagedSettings", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).AllowUnmanagedSettings = n.GetBoolValue(); } },
                {"baseId", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).BaseId = n.GetStringValue(); } },
                {"description", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).DisplayName = n.GetStringValue(); } },
                {"displayVersion", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).DisplayVersion = n.GetStringValue(); } },
                {"lifecycleState", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).LifecycleState = n.GetEnumValue<DeviceManagementTemplateLifecycleState>(); } },
                {"platforms", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"settingTemplateCount", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).SettingTemplateCount = n.GetIntValue(); } },
                {"settingTemplates", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).SettingTemplates = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingTemplate>(DeviceManagementConfigurationSettingTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"technologies", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
                {"templateFamily", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).TemplateFamily = n.GetEnumValue<DeviceManagementConfigurationTemplateFamily>(); } },
                {"version", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplate).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowUnmanagedSettings", AllowUnmanagedSettings);
            writer.WriteStringValue("baseId", BaseId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("displayVersion", DisplayVersion);
            writer.WriteEnumValue<DeviceManagementTemplateLifecycleState>("lifecycleState", LifecycleState);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platforms", Platforms);
            writer.WriteIntValue("settingTemplateCount", SettingTemplateCount);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingTemplate>("settingTemplates", SettingTemplates);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
            writer.WriteEnumValue<DeviceManagementConfigurationTemplateFamily>("templateFamily", TemplateFamily);
            writer.WriteIntValue("version", Version);
        }
    }
}
