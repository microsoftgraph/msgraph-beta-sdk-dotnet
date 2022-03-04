using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementConfigurationSettingInstanceTemplate : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates if a policy must specify this setting.</summary>
        public bool? IsRequired { get; set; }
        /// <summary>Setting Definition Id</summary>
        public string SettingDefinitionId { get; set; }
        /// <summary>Setting Instance Template Id</summary>
        public string SettingInstanceTemplateId { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingInstanceTemplate() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isRequired", (o,n) => { (o as DeviceManagementConfigurationSettingInstanceTemplate).IsRequired = n.GetBoolValue(); } },
                {"settingDefinitionId", (o,n) => { (o as DeviceManagementConfigurationSettingInstanceTemplate).SettingDefinitionId = n.GetStringValue(); } },
                {"settingInstanceTemplateId", (o,n) => { (o as DeviceManagementConfigurationSettingInstanceTemplate).SettingInstanceTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteStringValue("settingInstanceTemplateId", SettingInstanceTemplateId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
