using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyMigrationReport : Entity, IParsable {
        /// <summary>The date and time at which the GroupPolicyMigrationReport was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The name of Group Policy Object from the GPO Xml Content</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was created.</summary>
        public DateTimeOffset? GroupPolicyCreatedDateTime { get; set; }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was last modified.</summary>
        public DateTimeOffset? GroupPolicyLastModifiedDateTime { get; set; }
        /// <summary>The Group Policy Object GUID from GPO Xml content</summary>
        public string GroupPolicyObjectId { get; set; }
        /// <summary>A list of group policy settings to MDM/Intune mappings.</summary>
        public List<GroupPolicySettingMapping> GroupPolicySettingMappings { get; set; }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The Intune coverage for the associated Group Policy Object file. Possible values are: none, partial, complete, error, notApplicable.</summary>
        public GroupPolicyMigrationReadiness? MigrationReadiness { get; set; }
        /// <summary>The distinguished name of the OU.</summary>
        public string OuDistinguishedName { get; set; }
        /// <summary>The number of Group Policy Settings supported by Intune.</summary>
        public int? SupportedSettingsCount { get; set; }
        /// <summary>The Percentage of Group Policy Settings supported by Intune.</summary>
        public int? SupportedSettingsPercent { get; set; }
        /// <summary>The Targeted in AD property from GPO Xml Content</summary>
        public bool? TargetedInActiveDirectory { get; set; }
        /// <summary>The total number of Group Policy Settings from GPO file.</summary>
        public int? TotalSettingsCount { get; set; }
        /// <summary>A list of unsupported group policy extensions inside the Group Policy Object.</summary>
        public List<UnsupportedGroupPolicyExtension> UnsupportedGroupPolicyExtensions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyMigrationReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyMigrationReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"groupPolicyCreatedDateTime", n => { GroupPolicyCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupPolicyLastModifiedDateTime", n => { GroupPolicyLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupPolicyObjectId", n => { GroupPolicyObjectId = n.GetStringValue(); } },
                {"groupPolicySettingMappings", n => { GroupPolicySettingMappings = n.GetCollectionOfObjectValues<GroupPolicySettingMapping>(GroupPolicySettingMapping.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"migrationReadiness", n => { MigrationReadiness = n.GetEnumValue<GroupPolicyMigrationReadiness>(); } },
                {"ouDistinguishedName", n => { OuDistinguishedName = n.GetStringValue(); } },
                {"supportedSettingsCount", n => { SupportedSettingsCount = n.GetIntValue(); } },
                {"supportedSettingsPercent", n => { SupportedSettingsPercent = n.GetIntValue(); } },
                {"targetedInActiveDirectory", n => { TargetedInActiveDirectory = n.GetBoolValue(); } },
                {"totalSettingsCount", n => { TotalSettingsCount = n.GetIntValue(); } },
                {"unsupportedGroupPolicyExtensions", n => { UnsupportedGroupPolicyExtensions = n.GetCollectionOfObjectValues<UnsupportedGroupPolicyExtension>(UnsupportedGroupPolicyExtension.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("groupPolicyCreatedDateTime", GroupPolicyCreatedDateTime);
            writer.WriteDateTimeOffsetValue("groupPolicyLastModifiedDateTime", GroupPolicyLastModifiedDateTime);
            writer.WriteStringValue("groupPolicyObjectId", GroupPolicyObjectId);
            writer.WriteCollectionOfObjectValues<GroupPolicySettingMapping>("groupPolicySettingMappings", GroupPolicySettingMappings);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<GroupPolicyMigrationReadiness>("migrationReadiness", MigrationReadiness);
            writer.WriteStringValue("ouDistinguishedName", OuDistinguishedName);
            writer.WriteIntValue("supportedSettingsCount", SupportedSettingsCount);
            writer.WriteIntValue("supportedSettingsPercent", SupportedSettingsPercent);
            writer.WriteBoolValue("targetedInActiveDirectory", TargetedInActiveDirectory);
            writer.WriteIntValue("totalSettingsCount", TotalSettingsCount);
            writer.WriteCollectionOfObjectValues<UnsupportedGroupPolicyExtension>("unsupportedGroupPolicyExtensions", UnsupportedGroupPolicyExtensions);
        }
    }
}
