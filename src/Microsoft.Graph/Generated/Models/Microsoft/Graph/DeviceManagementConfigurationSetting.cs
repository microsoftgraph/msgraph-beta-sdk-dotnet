using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementConfigurationSetting : Entity, IParsable {
        /// <summary>List of related Setting Definitions. This property is read-only.</summary>
        public List<DeviceManagementConfigurationSettingDefinition> SettingDefinitions { get; set; }
        /// <summary>Setting instance within policy</summary>
        public DeviceManagementConfigurationSettingInstance SettingInstance { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"settingDefinitions", (o,n) => { (o as DeviceManagementConfigurationSetting).SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>().ToList(); } },
                {"settingInstance", (o,n) => { (o as DeviceManagementConfigurationSetting).SettingInstance = n.GetObjectValue<DeviceManagementConfigurationSettingInstance>(); } },
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
