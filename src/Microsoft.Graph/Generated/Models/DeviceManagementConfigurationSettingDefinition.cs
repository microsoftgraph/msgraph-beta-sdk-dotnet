using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSettingDefinition : Entity, IParsable {
        /// <summary>Read/write access mode of the setting. Possible values are: none, add, copy, delete, get, replace, execute.</summary>
        public DeviceManagementConfigurationSettingAccessTypes? AccessTypes { get; set; }
        /// <summary>Details which device setting is applicable on</summary>
        public DeviceManagementConfigurationSettingApplicability Applicability { get; set; }
        /// <summary>Base CSP Path</summary>
        public string BaseUri { get; set; }
        /// <summary>Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)</summary>
        public string CategoryId { get; set; }
        /// <summary>Description of the item</summary>
        public string Description { get; set; }
        /// <summary>Display name of the item</summary>
        public string DisplayName { get; set; }
        /// <summary>Help text of the item</summary>
        public string HelpText { get; set; }
        /// <summary>List of links more info for the setting can be found at</summary>
        public List<string> InfoUrls { get; set; }
        /// <summary>Tokens which to search settings on</summary>
        public List<string> Keywords { get; set; }
        /// <summary>Name of the item</summary>
        public string Name { get; set; }
        /// <summary>Indicates whether the setting is required or not</summary>
        public DeviceManagementConfigurationSettingOccurrence Occurrence { get; set; }
        /// <summary>Offset CSP Path from Base</summary>
        public string OffsetUri { get; set; }
        /// <summary>List of referred setting information.</summary>
        public List<DeviceManagementConfigurationReferredSettingInformation> ReferredSettingInformationList { get; set; }
        /// <summary>Root setting definition if the setting is a child setting.</summary>
        public string RootDefinitionId { get; set; }
        /// <summary>Setting type, for example, configuration and compliance. Possible values are: none, configuration, compliance.</summary>
        public DeviceManagementConfigurationSettingUsage? SettingUsage { get; set; }
        /// <summary>Setting control type representation in the UX. Possible values are: default, dropdown, smallTextBox, largeTextBox, toggle, multiheaderGrid, contextPane.</summary>
        public DeviceManagementConfigurationControlType? UxBehavior { get; set; }
        /// <summary>Item Version</summary>
        public string Version { get; set; }
        /// <summary>Setting visibility scope to UX. Possible values are: none, settingsCatalog, template.</summary>
        public DeviceManagementConfigurationSettingVisibility? Visibility { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessTypes", n => { AccessTypes = n.GetEnumValue<DeviceManagementConfigurationSettingAccessTypes>(); } },
                {"applicability", n => { Applicability = n.GetObjectValue<DeviceManagementConfigurationSettingApplicability>(DeviceManagementConfigurationSettingApplicability.CreateFromDiscriminatorValue); } },
                {"baseUri", n => { BaseUri = n.GetStringValue(); } },
                {"categoryId", n => { CategoryId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"helpText", n => { HelpText = n.GetStringValue(); } },
                {"infoUrls", n => { InfoUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"keywords", n => { Keywords = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"occurrence", n => { Occurrence = n.GetObjectValue<DeviceManagementConfigurationSettingOccurrence>(DeviceManagementConfigurationSettingOccurrence.CreateFromDiscriminatorValue); } },
                {"offsetUri", n => { OffsetUri = n.GetStringValue(); } },
                {"referredSettingInformationList", n => { ReferredSettingInformationList = n.GetCollectionOfObjectValues<DeviceManagementConfigurationReferredSettingInformation>(DeviceManagementConfigurationReferredSettingInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"rootDefinitionId", n => { RootDefinitionId = n.GetStringValue(); } },
                {"settingUsage", n => { SettingUsage = n.GetEnumValue<DeviceManagementConfigurationSettingUsage>(); } },
                {"uxBehavior", n => { UxBehavior = n.GetEnumValue<DeviceManagementConfigurationControlType>(); } },
                {"version", n => { Version = n.GetStringValue(); } },
                {"visibility", n => { Visibility = n.GetEnumValue<DeviceManagementConfigurationSettingVisibility>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingAccessTypes>("accessTypes", AccessTypes);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingApplicability>("applicability", Applicability);
            writer.WriteStringValue("baseUri", BaseUri);
            writer.WriteStringValue("categoryId", CategoryId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteCollectionOfPrimitiveValues<string>("infoUrls", InfoUrls);
            writer.WriteCollectionOfPrimitiveValues<string>("keywords", Keywords);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingOccurrence>("occurrence", Occurrence);
            writer.WriteStringValue("offsetUri", OffsetUri);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationReferredSettingInformation>("referredSettingInformationList", ReferredSettingInformationList);
            writer.WriteStringValue("rootDefinitionId", RootDefinitionId);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingUsage>("settingUsage", SettingUsage);
            writer.WriteEnumValue<DeviceManagementConfigurationControlType>("uxBehavior", UxBehavior);
            writer.WriteStringValue("version", Version);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingVisibility>("visibility", Visibility);
        }
    }
}
