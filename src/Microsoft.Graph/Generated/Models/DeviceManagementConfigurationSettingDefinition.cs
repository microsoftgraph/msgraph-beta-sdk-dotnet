using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementConfigurationSettingDefinition : Entity, IParsable {
        /// <summary>Read/write access mode of the setting. Possible values are: none, add, copy, delete, get, replace, execute.</summary>
        public DeviceManagementConfigurationSettingAccessTypes? AccessTypes {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingAccessTypes?>(nameof(AccessTypes)); }
            set { BackingStore?.Set(nameof(AccessTypes), value); }
        }
        /// <summary>Details which device setting is applicable on</summary>
        public DeviceManagementConfigurationSettingApplicability Applicability {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingApplicability>(nameof(Applicability)); }
            set { BackingStore?.Set(nameof(Applicability), value); }
        }
        /// <summary>Base CSP Path</summary>
        public string BaseUri {
            get { return BackingStore?.Get<string>(nameof(BaseUri)); }
            set { BackingStore?.Set(nameof(BaseUri), value); }
        }
        /// <summary>Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)</summary>
        public string CategoryId {
            get { return BackingStore?.Get<string>(nameof(CategoryId)); }
            set { BackingStore?.Set(nameof(CategoryId), value); }
        }
        /// <summary>Description of the item</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Display name of the item</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Help text of the item</summary>
        public string HelpText {
            get { return BackingStore?.Get<string>(nameof(HelpText)); }
            set { BackingStore?.Set(nameof(HelpText), value); }
        }
        /// <summary>List of links more info for the setting can be found at</summary>
        public List<string> InfoUrls {
            get { return BackingStore?.Get<List<string>>(nameof(InfoUrls)); }
            set { BackingStore?.Set(nameof(InfoUrls), value); }
        }
        /// <summary>Tokens which to search settings on</summary>
        public List<string> Keywords {
            get { return BackingStore?.Get<List<string>>(nameof(Keywords)); }
            set { BackingStore?.Set(nameof(Keywords), value); }
        }
        /// <summary>Name of the item</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Indicates whether the setting is required or not</summary>
        public DeviceManagementConfigurationSettingOccurrence Occurrence {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingOccurrence>(nameof(Occurrence)); }
            set { BackingStore?.Set(nameof(Occurrence), value); }
        }
        /// <summary>Offset CSP Path from Base</summary>
        public string OffsetUri {
            get { return BackingStore?.Get<string>(nameof(OffsetUri)); }
            set { BackingStore?.Set(nameof(OffsetUri), value); }
        }
        /// <summary>List of referred setting information.</summary>
        public List<DeviceManagementConfigurationReferredSettingInformation> ReferredSettingInformationList {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationReferredSettingInformation>>(nameof(ReferredSettingInformationList)); }
            set { BackingStore?.Set(nameof(ReferredSettingInformationList), value); }
        }
        /// <summary>Root setting definition if the setting is a child setting.</summary>
        public string RootDefinitionId {
            get { return BackingStore?.Get<string>(nameof(RootDefinitionId)); }
            set { BackingStore?.Set(nameof(RootDefinitionId), value); }
        }
        /// <summary>Setting type, for example, configuration and compliance. Possible values are: none, configuration, compliance.</summary>
        public DeviceManagementConfigurationSettingUsage? SettingUsage {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingUsage?>(nameof(SettingUsage)); }
            set { BackingStore?.Set(nameof(SettingUsage), value); }
        }
        /// <summary>Setting control type representation in the UX. Possible values are: default, dropdown, smallTextBox, largeTextBox, toggle, multiheaderGrid, contextPane.</summary>
        public DeviceManagementConfigurationControlType? UxBehavior {
            get { return BackingStore?.Get<DeviceManagementConfigurationControlType?>(nameof(UxBehavior)); }
            set { BackingStore?.Set(nameof(UxBehavior), value); }
        }
        /// <summary>Item Version</summary>
        public string Version {
            get { return BackingStore?.Get<string>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>Setting visibility scope to UX. Possible values are: none, settingsCatalog, template.</summary>
        public DeviceManagementConfigurationSettingVisibility? Visibility {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingVisibility?>(nameof(Visibility)); }
            set { BackingStore?.Set(nameof(Visibility), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationSettingDefinition" => new DeviceManagementConfigurationSettingDefinition(),
                _ => new DeviceManagementConfigurationSettingDefinition(),
            };
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
