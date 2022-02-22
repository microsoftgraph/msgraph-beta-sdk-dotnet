using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementTemplate : Entity, IParsable {
        /// <summary>Collection of setting categories within the template</summary>
        public List<DeviceManagementTemplateSettingCategory> Categories { get; set; }
        /// <summary>The template's description</summary>
        public string Description { get; set; }
        /// <summary>The template's display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Number of Intents created from this template.</summary>
        public int? IntentCount { get; set; }
        /// <summary>The template is deprecated or not. Intents cannot be created from a deprecated template.</summary>
        public bool? IsDeprecated { get; set; }
        /// <summary>Collection of templates this template can migrate to</summary>
        public List<DeviceManagementTemplate> MigratableTo { get; set; }
        /// <summary>The template's platform. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, windows10XProfile, all.</summary>
        public PolicyPlatformType? PlatformType { get; set; }
        /// <summary>When the template was published</summary>
        public DateTimeOffset? PublishedDateTime { get; set; }
        /// <summary>Collection of all settings this template has</summary>
        public List<DeviceManagementSettingInstance> Settings { get; set; }
        /// <summary>The template's subtype. Possible values are: none, firewall, diskEncryption, attackSurfaceReduction, endpointDetectionReponse, accountProtection, antivirus, firewallSharedAppList, firewallSharedIpList, firewallSharedPortlist.</summary>
        public DeviceManagementTemplateSubtype? TemplateSubtype { get; set; }
        /// <summary>The template's type. Possible values are: securityBaseline, specializedDevices, advancedThreatProtectionSecurityBaseline, deviceConfiguration, custom, securityTemplate, microsoftEdgeSecurityBaseline, microsoftOffice365ProPlusSecurityBaseline, deviceCompliance, deviceConfigurationForOffice365, cloudPC, firewallSharedSettings.</summary>
        public DeviceManagementTemplateType? TemplateType { get; set; }
        /// <summary>The template's version information</summary>
        public string VersionInfo { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as DeviceManagementTemplate).Categories = n.GetCollectionOfObjectValues<DeviceManagementTemplateSettingCategory>().ToList(); } },
                {"description", (o,n) => { (o as DeviceManagementTemplate).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DeviceManagementTemplate).DisplayName = n.GetStringValue(); } },
                {"intentCount", (o,n) => { (o as DeviceManagementTemplate).IntentCount = n.GetIntValue(); } },
                {"isDeprecated", (o,n) => { (o as DeviceManagementTemplate).IsDeprecated = n.GetBoolValue(); } },
                {"migratableTo", (o,n) => { (o as DeviceManagementTemplate).MigratableTo = n.GetCollectionOfObjectValues<DeviceManagementTemplate>().ToList(); } },
                {"platformType", (o,n) => { (o as DeviceManagementTemplate).PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"publishedDateTime", (o,n) => { (o as DeviceManagementTemplate).PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"settings", (o,n) => { (o as DeviceManagementTemplate).Settings = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>().ToList(); } },
                {"templateSubtype", (o,n) => { (o as DeviceManagementTemplate).TemplateSubtype = n.GetEnumValue<DeviceManagementTemplateSubtype>(); } },
                {"templateType", (o,n) => { (o as DeviceManagementTemplate).TemplateType = n.GetEnumValue<DeviceManagementTemplateType>(); } },
                {"versionInfo", (o,n) => { (o as DeviceManagementTemplate).VersionInfo = n.GetStringValue(); } },
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
