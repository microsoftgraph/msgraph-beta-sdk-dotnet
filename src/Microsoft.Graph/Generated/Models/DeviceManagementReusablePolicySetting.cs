using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementReusablePolicySetting : Entity, IParsable {
        /// <summary>reusable setting creation date and time. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>reusable setting description supplied by user.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>reusable setting display name supplied by user.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>date and time when reusable setting was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>configuration policies referencing the current reusable setting. This property is read-only.</summary>
        public List<DeviceManagementConfigurationPolicy> ReferencingConfigurationPolicies {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationPolicy>>("referencingConfigurationPolicies"); }
            set { BackingStore?.Set("referencingConfigurationPolicies", value); }
        }
        /// <summary>count of configuration policies referencing the current reusable setting. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? ReferencingConfigurationPolicyCount {
            get { return BackingStore?.Get<int?>("referencingConfigurationPolicyCount"); }
            set { BackingStore?.Set("referencingConfigurationPolicyCount", value); }
        }
        /// <summary>setting definition id associated with this reusable setting.</summary>
        public string SettingDefinitionId {
            get { return BackingStore?.Get<string>("settingDefinitionId"); }
            set { BackingStore?.Set("settingDefinitionId", value); }
        }
        /// <summary>reusable setting configuration instance</summary>
        public DeviceManagementConfigurationSettingInstance SettingInstance {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstance>("settingInstance"); }
            set { BackingStore?.Set("settingInstance", value); }
        }
        /// <summary>version number for reusable setting. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementReusablePolicySetting and sets the default values.
        /// </summary>
        public DeviceManagementReusablePolicySetting() : base() {
            OdataType = "#microsoft.graph.deviceManagementReusablePolicySetting";
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
                {"referencingConfigurationPolicies", n => { ReferencingConfigurationPolicies = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicy>(DeviceManagementConfigurationPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationPolicy>("referencingConfigurationPolicies", ReferencingConfigurationPolicies);
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstance>("settingInstance", SettingInstance);
        }
    }
}
