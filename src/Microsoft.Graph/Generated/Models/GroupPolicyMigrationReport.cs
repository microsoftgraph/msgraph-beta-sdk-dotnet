using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Group Policy migration report.</summary>
    public class GroupPolicyMigrationReport : Entity, IParsable {
        /// <summary>The date and time at which the GroupPolicyMigrationReport was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The name of Group Policy Object from the GPO Xml Content</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was created.</summary>
        public DateTimeOffset? GroupPolicyCreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(GroupPolicyCreatedDateTime)); }
            set { BackingStore?.Set(nameof(GroupPolicyCreatedDateTime), value); }
        }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was last modified.</summary>
        public DateTimeOffset? GroupPolicyLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(GroupPolicyLastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(GroupPolicyLastModifiedDateTime), value); }
        }
        /// <summary>The Group Policy Object GUID from GPO Xml content</summary>
        public string GroupPolicyObjectId {
            get { return BackingStore?.Get<string>(nameof(GroupPolicyObjectId)); }
            set { BackingStore?.Set(nameof(GroupPolicyObjectId), value); }
        }
        /// <summary>A list of group policy settings to MDM/Intune mappings.</summary>
        public List<GroupPolicySettingMapping> GroupPolicySettingMappings {
            get { return BackingStore?.Get<List<GroupPolicySettingMapping>>(nameof(GroupPolicySettingMappings)); }
            set { BackingStore?.Set(nameof(GroupPolicySettingMappings), value); }
        }
        /// <summary>The date and time at which the GroupPolicyMigrationReport was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The Intune coverage for the associated Group Policy Object file. Possible values are: none, partial, complete, error, notApplicable.</summary>
        public GroupPolicyMigrationReadiness? MigrationReadiness {
            get { return BackingStore?.Get<GroupPolicyMigrationReadiness?>(nameof(MigrationReadiness)); }
            set { BackingStore?.Set(nameof(MigrationReadiness), value); }
        }
        /// <summary>The distinguished name of the OU.</summary>
        public string OuDistinguishedName {
            get { return BackingStore?.Get<string>(nameof(OuDistinguishedName)); }
            set { BackingStore?.Set(nameof(OuDistinguishedName), value); }
        }
        /// <summary>The number of Group Policy Settings supported by Intune.</summary>
        public int? SupportedSettingsCount {
            get { return BackingStore?.Get<int?>(nameof(SupportedSettingsCount)); }
            set { BackingStore?.Set(nameof(SupportedSettingsCount), value); }
        }
        /// <summary>The Percentage of Group Policy Settings supported by Intune.</summary>
        public int? SupportedSettingsPercent {
            get { return BackingStore?.Get<int?>(nameof(SupportedSettingsPercent)); }
            set { BackingStore?.Set(nameof(SupportedSettingsPercent), value); }
        }
        /// <summary>The Targeted in AD property from GPO Xml Content</summary>
        public bool? TargetedInActiveDirectory {
            get { return BackingStore?.Get<bool?>(nameof(TargetedInActiveDirectory)); }
            set { BackingStore?.Set(nameof(TargetedInActiveDirectory), value); }
        }
        /// <summary>The total number of Group Policy Settings from GPO file.</summary>
        public int? TotalSettingsCount {
            get { return BackingStore?.Get<int?>(nameof(TotalSettingsCount)); }
            set { BackingStore?.Set(nameof(TotalSettingsCount), value); }
        }
        /// <summary>A list of unsupported group policy extensions inside the Group Policy Object.</summary>
        public List<UnsupportedGroupPolicyExtension> UnsupportedGroupPolicyExtensions {
            get { return BackingStore?.Get<List<UnsupportedGroupPolicyExtension>>(nameof(UnsupportedGroupPolicyExtensions)); }
            set { BackingStore?.Set(nameof(UnsupportedGroupPolicyExtensions), value); }
        }
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
