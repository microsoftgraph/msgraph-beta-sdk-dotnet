using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationPolicyTemplate : Entity, IParsable {
        /// <summary>Allow unmanaged setting templates</summary>
        public bool? AllowUnmanagedSettings {
            get { return BackingStore?.Get<bool?>("allowUnmanagedSettings"); }
            set { BackingStore?.Set("allowUnmanagedSettings", value); }
        }
        /// <summary>Template base identifier</summary>
        public string BaseId {
            get { return BackingStore?.Get<string>("baseId"); }
            set { BackingStore?.Set("baseId", value); }
        }
        /// <summary>Template description</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Template display name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Description of template version</summary>
        public string DisplayVersion {
            get { return BackingStore?.Get<string>("displayVersion"); }
            set { BackingStore?.Set("displayVersion", value); }
        }
        /// <summary>Describes current lifecycle state of a template</summary>
        public DeviceManagementTemplateLifecycleState? LifecycleState {
            get { return BackingStore?.Get<DeviceManagementTemplateLifecycleState?>("lifecycleState"); }
            set { BackingStore?.Set("lifecycleState", value); }
        }
        /// <summary>Supported platform types.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms {
            get { return BackingStore?.Get<DeviceManagementConfigurationPlatforms?>("platforms"); }
            set { BackingStore?.Set("platforms", value); }
        }
        /// <summary>Number of setting templates. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? SettingTemplateCount {
            get { return BackingStore?.Get<int?>("settingTemplateCount"); }
            set { BackingStore?.Set("settingTemplateCount", value); }
        }
        /// <summary>Setting templates</summary>
        public List<DeviceManagementConfigurationSettingTemplate> SettingTemplates {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingTemplate>>("settingTemplates"); }
            set { BackingStore?.Set("settingTemplates", value); }
        }
        /// <summary>Describes which technology this setting can be deployed with</summary>
        public DeviceManagementConfigurationTechnologies? Technologies {
            get { return BackingStore?.Get<DeviceManagementConfigurationTechnologies?>("technologies"); }
            set { BackingStore?.Set("technologies", value); }
        }
        /// <summary>Describes the TemplateFamily for the Template entity</summary>
        public DeviceManagementConfigurationTemplateFamily? TemplateFamily {
            get { return BackingStore?.Get<DeviceManagementConfigurationTemplateFamily?>("templateFamily"); }
            set { BackingStore?.Set("templateFamily", value); }
        }
        /// <summary>Template version. Valid values 1 to 2147483647. This property is read-only.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationPolicyTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationPolicyTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationPolicyTemplate";
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
