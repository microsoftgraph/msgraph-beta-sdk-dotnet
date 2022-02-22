using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementConfigurationSettingTemplate : Entity, IParsable {
        /// <summary>List of related Setting Definitions</summary>
        public List<DeviceManagementConfigurationSettingDefinition> SettingDefinitions { get; set; }
        /// <summary>Setting Instance Template</summary>
        public DeviceManagementConfigurationSettingInstanceTemplate SettingInstanceTemplate { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"settingDefinitions", (o,n) => { (o as DeviceManagementConfigurationSettingTemplate).SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>().ToList(); } },
                {"settingInstanceTemplate", (o,n) => { (o as DeviceManagementConfigurationSettingTemplate).SettingInstanceTemplate = n.GetObjectValue<DeviceManagementConfigurationSettingInstanceTemplate>(); } },
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
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstanceTemplate>("settingInstanceTemplate", SettingInstanceTemplate);
        }
    }
}
