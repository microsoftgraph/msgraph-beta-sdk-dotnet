using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Device Management Configuration Policy
    /// </summary>
    public class DeviceManagementConfigurationCategory : Entity, IParsable {
        /// <summary>Description of the category header</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? CategoryDescription {
            get { return BackingStore?.Get<string?>("categoryDescription"); }
            set { BackingStore?.Set("categoryDescription", value); }
        }
#else
        public string CategoryDescription {
            get { return BackingStore?.Get<string>("categoryDescription"); }
            set { BackingStore?.Set("categoryDescription", value); }
        }
#endif
        /// <summary>List of child ids of the category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? ChildCategoryIds {
            get { return BackingStore?.Get<List<string>?>("childCategoryIds"); }
            set { BackingStore?.Set("childCategoryIds", value); }
        }
#else
        public List<string> ChildCategoryIds {
            get { return BackingStore?.Get<List<string>>("childCategoryIds"); }
            set { BackingStore?.Set("childCategoryIds", value); }
        }
#endif
        /// <summary>Description of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Display name of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Help text of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? HelpText {
            get { return BackingStore?.Get<string?>("helpText"); }
            set { BackingStore?.Set("helpText", value); }
        }
#else
        public string HelpText {
            get { return BackingStore?.Get<string>("helpText"); }
            set { BackingStore?.Set("helpText", value); }
        }
#endif
        /// <summary>Name of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Parent id of the category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ParentCategoryId {
            get { return BackingStore?.Get<string?>("parentCategoryId"); }
            set { BackingStore?.Set("parentCategoryId", value); }
        }
#else
        public string ParentCategoryId {
            get { return BackingStore?.Get<string>("parentCategoryId"); }
            set { BackingStore?.Set("parentCategoryId", value); }
        }
#endif
        /// <summary>Supported platform types.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms {
            get { return BackingStore?.Get<DeviceManagementConfigurationPlatforms?>("platforms"); }
            set { BackingStore?.Set("platforms", value); }
        }
        /// <summary>Root id of the category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? RootCategoryId {
            get { return BackingStore?.Get<string?>("rootCategoryId"); }
            set { BackingStore?.Set("rootCategoryId", value); }
        }
#else
        public string RootCategoryId {
            get { return BackingStore?.Get<string>("rootCategoryId"); }
            set { BackingStore?.Set("rootCategoryId", value); }
        }
#endif
        /// <summary>Supported setting types</summary>
        public DeviceManagementConfigurationSettingUsage? SettingUsage {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingUsage?>("settingUsage"); }
            set { BackingStore?.Set("settingUsage", value); }
        }
        /// <summary>Describes which technology this setting can be deployed with</summary>
        public DeviceManagementConfigurationTechnologies? Technologies {
            get { return BackingStore?.Get<DeviceManagementConfigurationTechnologies?>("technologies"); }
            set { BackingStore?.Set("technologies", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationCategory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categoryDescription", n => { CategoryDescription = n.GetStringValue(); } },
                {"childCategoryIds", n => { ChildCategoryIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"helpText", n => { HelpText = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parentCategoryId", n => { ParentCategoryId = n.GetStringValue(); } },
                {"platforms", n => { Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"rootCategoryId", n => { RootCategoryId = n.GetStringValue(); } },
                {"settingUsage", n => { SettingUsage = n.GetEnumValue<DeviceManagementConfigurationSettingUsage>(); } },
                {"technologies", n => { Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("categoryDescription", CategoryDescription);
            writer.WriteCollectionOfPrimitiveValues<string>("childCategoryIds", ChildCategoryIds);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("parentCategoryId", ParentCategoryId);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platforms", Platforms);
            writer.WriteStringValue("rootCategoryId", RootCategoryId);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingUsage>("settingUsage", SettingUsage);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
        }
    }
}
