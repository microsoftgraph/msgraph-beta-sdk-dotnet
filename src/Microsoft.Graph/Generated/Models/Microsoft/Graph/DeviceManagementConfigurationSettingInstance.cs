using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementConfigurationSettingInstance : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Setting Definition Id</summary>
        public string SettingDefinitionId { get; set; }
        /// <summary>Setting Instance Template Reference</summary>
        public DeviceManagementConfigurationSettingInstanceTemplateReference SettingInstanceTemplateReference { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingInstance() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"settingDefinitionId", (o,n) => { (o as DeviceManagementConfigurationSettingInstance).SettingDefinitionId = n.GetStringValue(); } },
                {"settingInstanceTemplateReference", (o,n) => { (o as DeviceManagementConfigurationSettingInstance).SettingInstanceTemplateReference = n.GetObjectValue<DeviceManagementConfigurationSettingInstanceTemplateReference>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstanceTemplateReference>("settingInstanceTemplateReference", SettingInstanceTemplateReference);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
