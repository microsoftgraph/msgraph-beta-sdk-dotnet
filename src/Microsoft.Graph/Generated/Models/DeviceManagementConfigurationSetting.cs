using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Setting instance within policy
    /// </summary>
    public class DeviceManagementConfigurationSetting : Entity, IParsable {
        /// <summary>List of related Setting Definitions. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementConfigurationSettingDefinition>? SettingDefinitions {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDefinition>?>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
#else
        public List<DeviceManagementConfigurationSettingDefinition> SettingDefinitions {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDefinition>>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
#endif
        /// <summary>Setting instance within policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceManagementConfigurationSettingInstance? SettingInstance {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstance?>("settingInstance"); }
            set { BackingStore?.Set("settingInstance", value); }
        }
#else
        public DeviceManagementConfigurationSettingInstance SettingInstance {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstance>("settingInstance"); }
            set { BackingStore?.Set("settingInstance", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"settingDefinitions", n => { SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>(DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settingInstance", n => { SettingInstance = n.GetObjectValue<DeviceManagementConfigurationSettingInstance>(DeviceManagementConfigurationSettingInstance.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>("settingDefinitions", SettingDefinitions);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstance>("settingInstance", SettingInstance);
        }
    }
}
