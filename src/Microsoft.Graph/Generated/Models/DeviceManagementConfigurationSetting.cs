using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSetting : Entity, IParsable {
        /// <summary>List of related Setting Definitions. This property is read-only.</summary>
        public List<DeviceManagementConfigurationSettingDefinition> SettingDefinitions { get; set; }
        /// <summary>Setting instance within policy</summary>
        public DeviceManagementConfigurationSettingInstance SettingInstance { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"settingDefinitions", (o,n) => { (o as DeviceManagementConfigurationSetting).SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>(DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"settingInstance", (o,n) => { (o as DeviceManagementConfigurationSetting).SettingInstance = n.GetObjectValue<DeviceManagementConfigurationSettingInstance>(DeviceManagementConfigurationSettingInstance.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>("settingDefinitions", SettingDefinitions);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstance>("settingInstance", SettingInstance);
        }
    }
}
