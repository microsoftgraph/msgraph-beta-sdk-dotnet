using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Graph model for a reusable setting</summary>
    public class DeviceManagementReusablePolicySetting : Entity, IParsable {
        /// <summary>reusable setting creation date and time. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>reusable setting description supplied by user.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>reusable setting display name supplied by user.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>date and time when reusable setting was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>configuration policies referencing the current reusable setting. This property is read-only.</summary>
        public List<DeviceManagementConfigurationPolicy> ReferencingConfigurationPolicies {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationPolicy>>(nameof(ReferencingConfigurationPolicies)); }
            set { BackingStore?.Set(nameof(ReferencingConfigurationPolicies), value); }
        }
        /// <summary>count of configuration policies referencing the current reusable setting. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? ReferencingConfigurationPolicyCount {
            get { return BackingStore?.Get<int?>(nameof(ReferencingConfigurationPolicyCount)); }
            set { BackingStore?.Set(nameof(ReferencingConfigurationPolicyCount), value); }
        }
        /// <summary>setting definition id associated with this reusable setting.</summary>
        public string SettingDefinitionId {
            get { return BackingStore?.Get<string>(nameof(SettingDefinitionId)); }
            set { BackingStore?.Set(nameof(SettingDefinitionId), value); }
        }
        /// <summary>reusable setting configuration instance</summary>
        public DeviceManagementConfigurationSettingInstance SettingInstance {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstance>(nameof(SettingInstance)); }
            set { BackingStore?.Set(nameof(SettingInstance), value); }
        }
        /// <summary>version number for reusable setting. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementReusablePolicySetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementReusablePolicySetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"referencingConfigurationPolicies", n => { ReferencingConfigurationPolicies = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicy>(DeviceManagementConfigurationPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"referencingConfigurationPolicyCount", n => { ReferencingConfigurationPolicyCount = n.GetIntValue(); } },
                {"settingDefinitionId", n => { SettingDefinitionId = n.GetStringValue(); } },
                {"settingInstance", n => { SettingInstance = n.GetObjectValue<DeviceManagementConfigurationSettingInstance>(DeviceManagementConfigurationSettingInstance.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetIntValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationPolicy>("referencingConfigurationPolicies", ReferencingConfigurationPolicies);
            writer.WriteIntValue("referencingConfigurationPolicyCount", ReferencingConfigurationPolicyCount);
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstance>("settingInstance", SettingInstance);
            writer.WriteIntValue("version", Version);
        }
    }
}
