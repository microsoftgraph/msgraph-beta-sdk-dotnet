using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Management Configuration Policy Template</summary>
    public class DeviceManagementConfigurationPolicyTemplate : Entity, IParsable {
        /// <summary>Allow unmanaged setting templates</summary>
        public bool? AllowUnmanagedSettings {
            get { return BackingStore?.Get<bool?>(nameof(AllowUnmanagedSettings)); }
            set { BackingStore?.Set(nameof(AllowUnmanagedSettings), value); }
        }
        /// <summary>Template base identifier</summary>
        public string BaseId {
            get { return BackingStore?.Get<string>(nameof(BaseId)); }
            set { BackingStore?.Set(nameof(BaseId), value); }
        }
        /// <summary>Template description</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Template display name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Description of template version</summary>
        public string DisplayVersion {
            get { return BackingStore?.Get<string>(nameof(DisplayVersion)); }
            set { BackingStore?.Set(nameof(DisplayVersion), value); }
        }
        /// <summary>Indicate current lifecycle state of template. Possible values are: invalid, draft, active, superseded, deprecated, retired.</summary>
        public DeviceManagementTemplateLifecycleState? LifecycleState {
            get { return BackingStore?.Get<DeviceManagementTemplateLifecycleState?>(nameof(LifecycleState)); }
            set { BackingStore?.Set(nameof(LifecycleState), value); }
        }
        /// <summary>Platforms for this template. Possible values are: none, android, iOS, macOS, windows10X, windows10, linux, unknownFutureValue.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms {
            get { return BackingStore?.Get<DeviceManagementConfigurationPlatforms?>(nameof(Platforms)); }
            set { BackingStore?.Set(nameof(Platforms), value); }
        }
        /// <summary>Number of setting templates. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? SettingTemplateCount {
            get { return BackingStore?.Get<int?>(nameof(SettingTemplateCount)); }
            set { BackingStore?.Set(nameof(SettingTemplateCount), value); }
        }
        /// <summary>Setting templates</summary>
        public List<DeviceManagementConfigurationSettingTemplate> SettingTemplates {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingTemplate>>(nameof(SettingTemplates)); }
            set { BackingStore?.Set(nameof(SettingTemplates), value); }
        }
        /// <summary>Technologies for this template. Possible values are: none, mdm, windows10XManagement, configManager, appleRemoteManagement, microsoftSense, exchangeOnline, linuxMdm, unknownFutureValue.</summary>
        public DeviceManagementConfigurationTechnologies? Technologies {
            get { return BackingStore?.Get<DeviceManagementConfigurationTechnologies?>(nameof(Technologies)); }
            set { BackingStore?.Set(nameof(Technologies), value); }
        }
        /// <summary>TemplateFamily for this template. Possible values are: none, endpointSecurityAntivirus, endpointSecurityDiskEncryption, endpointSecurityFirewall, endpointSecurityEndpointDetectionAndResponse, endpointSecurityAttackSurfaceReduction, endpointSecurityAccountProtection, endpointSecurityApplicationControl, baseline.</summary>
        public DeviceManagementConfigurationTemplateFamily? TemplateFamily {
            get { return BackingStore?.Get<DeviceManagementConfigurationTemplateFamily?>(nameof(TemplateFamily)); }
            set { BackingStore?.Set(nameof(TemplateFamily), value); }
        }
        /// <summary>Template version. Valid values 1 to 2147483647. This property is read-only.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowUnmanagedSettings", n => { AllowUnmanagedSettings = n.GetBoolValue(); } },
                {"baseId", n => { BaseId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"displayVersion", n => { DisplayVersion = n.GetStringValue(); } },
                {"lifecycleState", n => { LifecycleState = n.GetEnumValue<DeviceManagementTemplateLifecycleState>(); } },
                {"platforms", n => { Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"settingTemplateCount", n => { SettingTemplateCount = n.GetIntValue(); } },
                {"settingTemplates", n => { SettingTemplates = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingTemplate>(DeviceManagementConfigurationSettingTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"technologies", n => { Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
                {"templateFamily", n => { TemplateFamily = n.GetEnumValue<DeviceManagementConfigurationTemplateFamily>(); } },
                {"version", n => { Version = n.GetIntValue(); } },
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
