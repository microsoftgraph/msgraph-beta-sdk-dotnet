using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Group Policy setting to MDM/Intune mapping.</summary>
    public class GroupPolicySettingMapping : Entity, IParsable {
        /// <summary>Admx Group Policy Id</summary>
        public string AdmxSettingDefinitionId {
            get { return BackingStore?.Get<string>(nameof(AdmxSettingDefinitionId)); }
            set { BackingStore?.Set(nameof(AdmxSettingDefinitionId), value); }
        }
        /// <summary>List of Child Ids of the group policy setting.</summary>
        public List<string> ChildIdList {
            get { return BackingStore?.Get<List<string>>(nameof(ChildIdList)); }
            set { BackingStore?.Set(nameof(ChildIdList), value); }
        }
        /// <summary>The Intune Setting Definition Id</summary>
        public string IntuneSettingDefinitionId {
            get { return BackingStore?.Get<string>(nameof(IntuneSettingDefinitionId)); }
            set { BackingStore?.Set(nameof(IntuneSettingDefinitionId), value); }
        }
        /// <summary>The list of Intune Setting URIs this group policy setting maps to</summary>
        public List<string> IntuneSettingUriList {
            get { return BackingStore?.Get<List<string>>(nameof(IntuneSettingUriList)); }
            set { BackingStore?.Set(nameof(IntuneSettingUriList), value); }
        }
        /// <summary>Indicates if the setting is supported by Intune or not</summary>
        public bool? IsMdmSupported {
            get { return BackingStore?.Get<bool?>(nameof(IsMdmSupported)); }
            set { BackingStore?.Set(nameof(IsMdmSupported), value); }
        }
        /// <summary>The CSP name this group policy setting maps to.</summary>
        public string MdmCspName {
            get { return BackingStore?.Get<string>(nameof(MdmCspName)); }
            set { BackingStore?.Set(nameof(MdmCspName), value); }
        }
        /// <summary>The minimum OS version this mdm setting supports.</summary>
        public int? MdmMinimumOSVersion {
            get { return BackingStore?.Get<int?>(nameof(MdmMinimumOSVersion)); }
            set { BackingStore?.Set(nameof(MdmMinimumOSVersion), value); }
        }
        /// <summary>The MDM CSP URI this group policy setting maps to.</summary>
        public string MdmSettingUri {
            get { return BackingStore?.Get<string>(nameof(MdmSettingUri)); }
            set { BackingStore?.Set(nameof(MdmSettingUri), value); }
        }
        /// <summary>Indicates if the setting is supported in Mdm or not. Possible values are: unknown, supported, unsupported, deprecated.</summary>
        public Microsoft.Graph.Beta.Models.MdmSupportedState? MdmSupportedState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MdmSupportedState?>(nameof(MdmSupportedState)); }
            set { BackingStore?.Set(nameof(MdmSupportedState), value); }
        }
        /// <summary>Parent Id of the group policy setting.</summary>
        public string ParentId {
            get { return BackingStore?.Get<string>(nameof(ParentId)); }
            set { BackingStore?.Set(nameof(ParentId), value); }
        }
        /// <summary>The category the group policy setting is in.</summary>
        public string SettingCategory {
            get { return BackingStore?.Get<string>(nameof(SettingCategory)); }
            set { BackingStore?.Set(nameof(SettingCategory), value); }
        }
        /// <summary>The display name of this group policy setting.</summary>
        public string SettingDisplayName {
            get { return BackingStore?.Get<string>(nameof(SettingDisplayName)); }
            set { BackingStore?.Set(nameof(SettingDisplayName), value); }
        }
        /// <summary>The display value of this group policy setting.</summary>
        public string SettingDisplayValue {
            get { return BackingStore?.Get<string>(nameof(SettingDisplayValue)); }
            set { BackingStore?.Set(nameof(SettingDisplayValue), value); }
        }
        /// <summary>The display value type of this group policy setting.</summary>
        public string SettingDisplayValueType {
            get { return BackingStore?.Get<string>(nameof(SettingDisplayValueType)); }
            set { BackingStore?.Set(nameof(SettingDisplayValueType), value); }
        }
        /// <summary>The name of this group policy setting.</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>(nameof(SettingName)); }
            set { BackingStore?.Set(nameof(SettingName), value); }
        }
        /// <summary>The scope of the setting. Possible values are: unknown, device, user.</summary>
        public GroupPolicySettingScope? SettingScope {
            get { return BackingStore?.Get<GroupPolicySettingScope?>(nameof(SettingScope)); }
            set { BackingStore?.Set(nameof(SettingScope), value); }
        }
        /// <summary>The setting type (security or admx) of the Group Policy. Possible values are: unknown, policy, account, securityOptions, userRightsAssignment, auditSetting, windowsFirewallSettings, appLockerRuleCollection, dataSourcesSettings, devicesSettings, driveMapSettings, environmentVariables, filesSettings, folderOptions, folders, iniFiles, internetOptions, localUsersAndGroups, networkOptions, networkShares, ntServices, powerOptions, printers, regionalOptionsSettings, registrySettings, scheduledTasks, shortcutSettings, startMenuSettings.</summary>
        public GroupPolicySettingType? SettingType {
            get { return BackingStore?.Get<GroupPolicySettingType?>(nameof(SettingType)); }
            set { BackingStore?.Set(nameof(SettingType), value); }
        }
        /// <summary>The value of this group policy setting.</summary>
        public string SettingValue {
            get { return BackingStore?.Get<string>(nameof(SettingValue)); }
            set { BackingStore?.Set(nameof(SettingValue), value); }
        }
        /// <summary>The display units of this group policy setting value</summary>
        public string SettingValueDisplayUnits {
            get { return BackingStore?.Get<string>(nameof(SettingValueDisplayUnits)); }
            set { BackingStore?.Set(nameof(SettingValueDisplayUnits), value); }
        }
        /// <summary>The value type of this group policy setting.</summary>
        public string SettingValueType {
            get { return BackingStore?.Get<string>(nameof(SettingValueType)); }
            set { BackingStore?.Set(nameof(SettingValueType), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"admxSettingDefinitionId", n => { AdmxSettingDefinitionId = n.GetStringValue(); } },
                {"childIdList", n => { ChildIdList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"intuneSettingDefinitionId", n => { IntuneSettingDefinitionId = n.GetStringValue(); } },
                {"intuneSettingUriList", n => { IntuneSettingUriList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isMdmSupported", n => { IsMdmSupported = n.GetBoolValue(); } },
                {"mdmCspName", n => { MdmCspName = n.GetStringValue(); } },
                {"mdmMinimumOSVersion", n => { MdmMinimumOSVersion = n.GetIntValue(); } },
                {"mdmSettingUri", n => { MdmSettingUri = n.GetStringValue(); } },
                {"mdmSupportedState", n => { MdmSupportedState = n.GetEnumValue<MdmSupportedState>(); } },
                {"parentId", n => { ParentId = n.GetStringValue(); } },
                {"settingCategory", n => { SettingCategory = n.GetStringValue(); } },
                {"settingDisplayName", n => { SettingDisplayName = n.GetStringValue(); } },
                {"settingDisplayValue", n => { SettingDisplayValue = n.GetStringValue(); } },
                {"settingDisplayValueType", n => { SettingDisplayValueType = n.GetStringValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"settingScope", n => { SettingScope = n.GetEnumValue<GroupPolicySettingScope>(); } },
                {"settingType", n => { SettingType = n.GetEnumValue<GroupPolicySettingType>(); } },
                {"settingValue", n => { SettingValue = n.GetStringValue(); } },
                {"settingValueDisplayUnits", n => { SettingValueDisplayUnits = n.GetStringValue(); } },
                {"settingValueType", n => { SettingValueType = n.GetStringValue(); } },
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
