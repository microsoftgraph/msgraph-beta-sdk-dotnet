using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementSettingCategory : Entity, IParsable {
        /// <summary>The category name</summary>
        public string DisplayName { get; set; }
        /// <summary>The category contains top level required setting</summary>
        public bool? HasRequiredSetting { get; set; }
        /// <summary>The setting definitions this category contains</summary>
        public List<DeviceManagementSettingDefinition> SettingDefinitions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as DeviceManagementSettingCategory).DisplayName = n.GetStringValue(); } },
                {"hasRequiredSetting", (o,n) => { (o as DeviceManagementSettingCategory).HasRequiredSetting = n.GetBoolValue(); } },
                {"settingDefinitions", (o,n) => { (o as DeviceManagementSettingCategory).SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementSettingDefinition>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hasRequiredSetting", HasRequiredSetting);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingDefinition>("settingDefinitions", SettingDefinitions);
        }
    }
}
