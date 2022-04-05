using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Setting instance within policy</summary>
    public class DeviceManagementConfigurationSettingInstance : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"settingDefinitionId", (o,n) => { (o as DeviceManagementConfigurationSettingInstance).SettingDefinitionId = n.GetStringValue(); } },
                {"settingInstanceTemplateReference", (o,n) => { (o as DeviceManagementConfigurationSettingInstance).SettingInstanceTemplateReference = n.GetObjectValue<DeviceManagementConfigurationSettingInstanceTemplateReference>(DeviceManagementConfigurationSettingInstanceTemplateReference.CreateFromDiscriminatorValue); } },
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
