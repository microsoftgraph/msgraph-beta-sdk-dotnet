using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The Group Policy migration report.
    /// </summary>
    public class GroupPolicyMigrationReport : Entity, IParsable {
        /// <summary>The date and time at which the GroupPolicyMigrationReport was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The name of Group Policy Object from the GPO Xml Content</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was created.</summary>
        public DateTimeOffset? GroupPolicyCreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("groupPolicyCreatedDateTime"); }
            set { BackingStore?.Set("groupPolicyCreatedDateTime", value); }
        }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was last modified.</summary>
        public DateTimeOffset? GroupPolicyLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("groupPolicyLastModifiedDateTime"); }
            set { BackingStore?.Set("groupPolicyLastModifiedDateTime", value); }
        }
        /// <summary>The Group Policy Object GUID from GPO Xml content</summary>
        public Guid? GroupPolicyObjectId {
            get { return BackingStore?.Get<Guid?>("groupPolicyObjectId"); }
            set { BackingStore?.Set("groupPolicyObjectId", value); }
        }
        /// <summary>A list of group policy settings to MDM/Intune mappings.</summary>
        public List<GroupPolicySettingMapping> GroupPolicySettingMappings {
            get { return BackingStore?.Get<List<GroupPolicySettingMapping>>("groupPolicySettingMappings"); }
            set { BackingStore?.Set("groupPolicySettingMappings", value); }
        }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Indicates if the Group Policy Object file is covered and ready for Intune migration.</summary>
        public GroupPolicyMigrationReadiness? MigrationReadiness {
            get { return BackingStore?.Get<GroupPolicyMigrationReadiness?>("migrationReadiness"); }
            set { BackingStore?.Set("migrationReadiness", value); }
        }
        /// <summary>The distinguished name of the OU.</summary>
        public string OuDistinguishedName {
            get { return BackingStore?.Get<string>("ouDistinguishedName"); }
            set { BackingStore?.Set("ouDistinguishedName", value); }
        }
        /// <summary>The list of scope tags for the configuration.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>The number of Group Policy Settings supported by Intune.</summary>
        public int? SupportedSettingsCount {
            get { return BackingStore?.Get<int?>("supportedSettingsCount"); }
            set { BackingStore?.Set("supportedSettingsCount", value); }
        }
        /// <summary>The Percentage of Group Policy Settings supported by Intune.</summary>
        public int? SupportedSettingsPercent {
            get { return BackingStore?.Get<int?>("supportedSettingsPercent"); }
            set { BackingStore?.Set("supportedSettingsPercent", value); }
        }
        /// <summary>The Targeted in AD property from GPO Xml Content</summary>
        public bool? TargetedInActiveDirectory {
            get { return BackingStore?.Get<bool?>("targetedInActiveDirectory"); }
            set { BackingStore?.Set("targetedInActiveDirectory", value); }
        }
        /// <summary>The total number of Group Policy Settings from GPO file.</summary>
        public int? TotalSettingsCount {
            get { return BackingStore?.Get<int?>("totalSettingsCount"); }
            set { BackingStore?.Set("totalSettingsCount", value); }
        }
        /// <summary>A list of unsupported group policy extensions inside the Group Policy Object.</summary>
        public List<UnsupportedGroupPolicyExtension> UnsupportedGroupPolicyExtensions {
            get { return BackingStore?.Get<List<UnsupportedGroupPolicyExtension>>("unsupportedGroupPolicyExtensions"); }
            set { BackingStore?.Set("unsupportedGroupPolicyExtensions", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"groupPolicyObjectId", n => { GroupPolicyObjectId = n.GetGuidValue(); } },
                {"groupPolicySettingMappings", n => { GroupPolicySettingMappings = n.GetCollectionOfObjectValues<GroupPolicySettingMapping>(GroupPolicySettingMapping.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"migrationReadiness", n => { MigrationReadiness = n.GetEnumValue<GroupPolicyMigrationReadiness>(); } },
                {"ouDistinguishedName", n => { OuDistinguishedName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"supportedSettingsCount", n => { SupportedSettingsCount = n.GetIntValue(); } },
                {"supportedSettingsPercent", n => { SupportedSettingsPercent = n.GetIntValue(); } },
                {"targetedInActiveDirectory", n => { TargetedInActiveDirectory = n.GetBoolValue(); } },
                {"totalSettingsCount", n => { TotalSettingsCount = n.GetIntValue(); } },
                {"unsupportedGroupPolicyExtensions", n => { UnsupportedGroupPolicyExtensions = n.GetCollectionOfObjectValues<UnsupportedGroupPolicyExtension>(UnsupportedGroupPolicyExtension.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("groupPolicyCreatedDateTime", GroupPolicyCreatedDateTime);
            writer.WriteDateTimeOffsetValue("groupPolicyLastModifiedDateTime", GroupPolicyLastModifiedDateTime);
            writer.WriteGuidValue("groupPolicyObjectId", GroupPolicyObjectId);
            writer.WriteCollectionOfObjectValues<GroupPolicySettingMapping>("groupPolicySettingMappings", GroupPolicySettingMappings);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<GroupPolicyMigrationReadiness>("migrationReadiness", MigrationReadiness);
            writer.WriteStringValue("ouDistinguishedName", OuDistinguishedName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteIntValue("supportedSettingsCount", SupportedSettingsCount);
            writer.WriteIntValue("supportedSettingsPercent", SupportedSettingsPercent);
            writer.WriteBoolValue("targetedInActiveDirectory", TargetedInActiveDirectory);
            writer.WriteIntValue("totalSettingsCount", TotalSettingsCount);
            writer.WriteCollectionOfObjectValues<UnsupportedGroupPolicyExtension>("unsupportedGroupPolicyExtensions", UnsupportedGroupPolicyExtensions);
        }
    }
}
