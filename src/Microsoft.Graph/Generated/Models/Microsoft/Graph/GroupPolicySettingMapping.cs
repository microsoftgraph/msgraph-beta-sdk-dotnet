using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class GroupPolicySettingMapping : Entity, IParsable {
        /// <summary>Admx Group Policy Id</summary>
        public string AdmxSettingDefinitionId { get; set; }
        /// <summary>List of Child Ids of the group policy setting.</summary>
        public List<string> ChildIdList { get; set; }
        /// <summary>The Intune Setting Definition Id</summary>
        public string IntuneSettingDefinitionId { get; set; }
        /// <summary>The list of Intune Setting URIs this group policy setting maps to</summary>
        public List<string> IntuneSettingUriList { get; set; }
        /// <summary>Indicates if the setting is supported by Intune or not</summary>
        public bool? IsMdmSupported { get; set; }
        /// <summary>The CSP name this group policy setting maps to.</summary>
        public string MdmCspName { get; set; }
        /// <summary>The minimum OS version this mdm setting supports.</summary>
        public int? MdmMinimumOSVersion { get; set; }
        /// <summary>The MDM CSP URI this group policy setting maps to.</summary>
        public string MdmSettingUri { get; set; }
        /// <summary>Indicates if the setting is supported in Mdm or not. Possible values are: unknown, supported, unsupported, deprecated.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.MdmSupportedState? MdmSupportedState { get; set; }
        /// <summary>Parent Id of the group policy setting.</summary>
        public string ParentId { get; set; }
        /// <summary>The category the group policy setting is in.</summary>
        public string SettingCategory { get; set; }
        /// <summary>The display name of this group policy setting.</summary>
        public string SettingDisplayName { get; set; }
        /// <summary>The display value of this group policy setting.</summary>
        public string SettingDisplayValue { get; set; }
        /// <summary>The display value type of this group policy setting.</summary>
        public string SettingDisplayValueType { get; set; }
        /// <summary>The name of this group policy setting.</summary>
        public string SettingName { get; set; }
        /// <summary>The scope of the setting. Possible values are: unknown, device, user.</summary>
        public GroupPolicySettingScope? SettingScope { get; set; }
        /// <summary>The setting type (security or admx) of the Group Policy. Possible values are: unknown, policy, account, securityOptions, userRightsAssignment, auditSetting, windowsFirewallSettings, appLockerRuleCollection, dataSourcesSettings, devicesSettings, driveMapSettings, environmentVariables, filesSettings, folderOptions, folders, iniFiles, internetOptions, localUsersAndGroups, networkOptions, networkShares, ntServices, powerOptions, printers, regionalOptionsSettings, registrySettings, scheduledTasks, shortcutSettings, startMenuSettings.</summary>
        public GroupPolicySettingType? SettingType { get; set; }
        /// <summary>The value of this group policy setting.</summary>
        public string SettingValue { get; set; }
        /// <summary>The display units of this group policy setting value</summary>
        public string SettingValueDisplayUnits { get; set; }
        /// <summary>The value type of this group policy setting.</summary>
        public string SettingValueType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicySettingMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicySettingMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"admxSettingDefinitionId", (o,n) => { (o as GroupPolicySettingMapping).AdmxSettingDefinitionId = n.GetStringValue(); } },
                {"childIdList", (o,n) => { (o as GroupPolicySettingMapping).ChildIdList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"intuneSettingDefinitionId", (o,n) => { (o as GroupPolicySettingMapping).IntuneSettingDefinitionId = n.GetStringValue(); } },
                {"intuneSettingUriList", (o,n) => { (o as GroupPolicySettingMapping).IntuneSettingUriList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isMdmSupported", (o,n) => { (o as GroupPolicySettingMapping).IsMdmSupported = n.GetBoolValue(); } },
                {"mdmCspName", (o,n) => { (o as GroupPolicySettingMapping).MdmCspName = n.GetStringValue(); } },
                {"mdmMinimumOSVersion", (o,n) => { (o as GroupPolicySettingMapping).MdmMinimumOSVersion = n.GetIntValue(); } },
                {"mdmSettingUri", (o,n) => { (o as GroupPolicySettingMapping).MdmSettingUri = n.GetStringValue(); } },
                {"mdmSupportedState", (o,n) => { (o as GroupPolicySettingMapping).MdmSupportedState = n.GetEnumValue<MdmSupportedState>(); } },
                {"parentId", (o,n) => { (o as GroupPolicySettingMapping).ParentId = n.GetStringValue(); } },
                {"settingCategory", (o,n) => { (o as GroupPolicySettingMapping).SettingCategory = n.GetStringValue(); } },
                {"settingDisplayName", (o,n) => { (o as GroupPolicySettingMapping).SettingDisplayName = n.GetStringValue(); } },
                {"settingDisplayValue", (o,n) => { (o as GroupPolicySettingMapping).SettingDisplayValue = n.GetStringValue(); } },
                {"settingDisplayValueType", (o,n) => { (o as GroupPolicySettingMapping).SettingDisplayValueType = n.GetStringValue(); } },
                {"settingName", (o,n) => { (o as GroupPolicySettingMapping).SettingName = n.GetStringValue(); } },
                {"settingScope", (o,n) => { (o as GroupPolicySettingMapping).SettingScope = n.GetEnumValue<GroupPolicySettingScope>(); } },
                {"settingType", (o,n) => { (o as GroupPolicySettingMapping).SettingType = n.GetEnumValue<GroupPolicySettingType>(); } },
                {"settingValue", (o,n) => { (o as GroupPolicySettingMapping).SettingValue = n.GetStringValue(); } },
                {"settingValueDisplayUnits", (o,n) => { (o as GroupPolicySettingMapping).SettingValueDisplayUnits = n.GetStringValue(); } },
                {"settingValueType", (o,n) => { (o as GroupPolicySettingMapping).SettingValueType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("admxSettingDefinitionId", AdmxSettingDefinitionId);
            writer.WriteCollectionOfPrimitiveValues<string>("childIdList", ChildIdList);
            writer.WriteStringValue("intuneSettingDefinitionId", IntuneSettingDefinitionId);
            writer.WriteCollectionOfPrimitiveValues<string>("intuneSettingUriList", IntuneSettingUriList);
            writer.WriteBoolValue("isMdmSupported", IsMdmSupported);
            writer.WriteStringValue("mdmCspName", MdmCspName);
            writer.WriteIntValue("mdmMinimumOSVersion", MdmMinimumOSVersion);
            writer.WriteStringValue("mdmSettingUri", MdmSettingUri);
            writer.WriteEnumValue<MdmSupportedState>("mdmSupportedState", MdmSupportedState);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteStringValue("settingCategory", SettingCategory);
            writer.WriteStringValue("settingDisplayName", SettingDisplayName);
            writer.WriteStringValue("settingDisplayValue", SettingDisplayValue);
            writer.WriteStringValue("settingDisplayValueType", SettingDisplayValueType);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteEnumValue<GroupPolicySettingScope>("settingScope", SettingScope);
            writer.WriteEnumValue<GroupPolicySettingType>("settingType", SettingType);
            writer.WriteStringValue("settingValue", SettingValue);
            writer.WriteStringValue("settingValueDisplayUnits", SettingValueDisplayUnits);
            writer.WriteStringValue("settingValueType", SettingValueType);
        }
    }
}
