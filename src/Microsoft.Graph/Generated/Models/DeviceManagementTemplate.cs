using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity that represents a defined collection of device settings</summary>
    public class DeviceManagementTemplate : Entity, IParsable {
        /// <summary>Collection of setting categories within the template</summary>
        public List<DeviceManagementTemplateSettingCategory> Categories {
            get { return BackingStore?.Get<List<DeviceManagementTemplateSettingCategory>>(nameof(Categories)); }
            set { BackingStore?.Set(nameof(Categories), value); }
        }
        /// <summary>The template&apos;s description</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The template&apos;s display name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Number of Intents created from this template.</summary>
        public int? IntentCount {
            get { return BackingStore?.Get<int?>(nameof(IntentCount)); }
            set { BackingStore?.Set(nameof(IntentCount), value); }
        }
        /// <summary>The template is deprecated or not. Intents cannot be created from a deprecated template.</summary>
        public bool? IsDeprecated {
            get { return BackingStore?.Get<bool?>(nameof(IsDeprecated)); }
            set { BackingStore?.Set(nameof(IsDeprecated), value); }
        }
        /// <summary>Collection of templates this template can migrate to</summary>
        public List<DeviceManagementTemplate> MigratableTo {
            get { return BackingStore?.Get<List<DeviceManagementTemplate>>(nameof(MigratableTo)); }
            set { BackingStore?.Set(nameof(MigratableTo), value); }
        }
        /// <summary>The template&apos;s platform. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, windows10XProfile, all.</summary>
        public PolicyPlatformType? PlatformType {
            get { return BackingStore?.Get<PolicyPlatformType?>(nameof(PlatformType)); }
            set { BackingStore?.Set(nameof(PlatformType), value); }
        }
        /// <summary>When the template was published</summary>
        public DateTimeOffset? PublishedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(PublishedDateTime)); }
            set { BackingStore?.Set(nameof(PublishedDateTime), value); }
        }
        /// <summary>Collection of all settings this template has</summary>
        public List<DeviceManagementSettingInstance> Settings {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>The template&apos;s subtype. Possible values are: none, firewall, diskEncryption, attackSurfaceReduction, endpointDetectionReponse, accountProtection, antivirus, firewallSharedAppList, firewallSharedIpList, firewallSharedPortlist.</summary>
        public DeviceManagementTemplateSubtype? TemplateSubtype {
            get { return BackingStore?.Get<DeviceManagementTemplateSubtype?>(nameof(TemplateSubtype)); }
            set { BackingStore?.Set(nameof(TemplateSubtype), value); }
        }
        /// <summary>The template&apos;s type. Possible values are: securityBaseline, specializedDevices, advancedThreatProtectionSecurityBaseline, deviceConfiguration, custom, securityTemplate, microsoftEdgeSecurityBaseline, microsoftOffice365ProPlusSecurityBaseline, deviceCompliance, deviceConfigurationForOffice365, cloudPC, firewallSharedSettings.</summary>
        public DeviceManagementTemplateType? TemplateType {
            get { return BackingStore?.Get<DeviceManagementTemplateType?>(nameof(TemplateType)); }
            set { BackingStore?.Set(nameof(TemplateType), value); }
        }
        /// <summary>The template&apos;s version information</summary>
        public string VersionInfo {
            get { return BackingStore?.Get<string>(nameof(VersionInfo)); }
            set { BackingStore?.Set(nameof(VersionInfo), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementTemplate" => new DeviceManagementTemplate(),
                _ => new DeviceManagementTemplate(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<DeviceManagementTemplateSettingCategory>(DeviceManagementTemplateSettingCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"intentCount", n => { IntentCount = n.GetIntValue(); } },
                {"isDeprecated", n => { IsDeprecated = n.GetBoolValue(); } },
                {"migratableTo", n => { MigratableTo = n.GetCollectionOfObjectValues<DeviceManagementTemplate>(DeviceManagementTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>(DeviceManagementSettingInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"templateSubtype", n => { TemplateSubtype = n.GetEnumValue<DeviceManagementTemplateSubtype>(); } },
                {"templateType", n => { TemplateType = n.GetEnumValue<DeviceManagementTemplateType>(); } },
                {"versionInfo", n => { VersionInfo = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementTemplateSettingCategory>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("intentCount", IntentCount);
            writer.WriteBoolValue("isDeprecated", IsDeprecated);
            writer.WriteCollectionOfObjectValues<DeviceManagementTemplate>("migratableTo", MigratableTo);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingInstance>("settings", Settings);
            writer.WriteEnumValue<DeviceManagementTemplateSubtype>("templateSubtype", TemplateSubtype);
            writer.WriteEnumValue<DeviceManagementTemplateType>("templateType", TemplateType);
            writer.WriteStringValue("versionInfo", VersionInfo);
        }
    }
}
