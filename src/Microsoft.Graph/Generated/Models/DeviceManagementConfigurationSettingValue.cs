using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Setting value</summary>
    public class DeviceManagementConfigurationSettingValue : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Setting value template reference</summary>
        public DeviceManagementConfigurationSettingValueTemplateReference SettingValueTemplateReference {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingValueTemplateReference>("settingValueTemplateReference"); }
            set { BackingStore?.Set("settingValueTemplateReference", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingValue and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingValue() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.deviceManagementConfigurationSettingValue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingValue" => new DeviceManagementConfigurationChoiceSettingValue(),
                "#microsoft.graph.deviceManagementConfigurationGroupSettingValue" => new DeviceManagementConfigurationGroupSettingValue(),
                "#microsoft.graph.deviceManagementConfigurationIntegerSettingValue" => new DeviceManagementConfigurationIntegerSettingValue(),
                "#microsoft.graph.deviceManagementConfigurationReferenceSettingValue" => new DeviceManagementConfigurationReferenceSettingValue(),
                "#microsoft.graph.deviceManagementConfigurationSecretSettingValue" => new DeviceManagementConfigurationSecretSettingValue(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingValue" => new DeviceManagementConfigurationSimpleSettingValue(),
                "#microsoft.graph.deviceManagementConfigurationStringSettingValue" => new DeviceManagementConfigurationStringSettingValue(),
                _ => new DeviceManagementConfigurationSettingValue(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"settingValueTemplateReference", n => { SettingValueTemplateReference = n.GetObjectValue<DeviceManagementConfigurationSettingValueTemplateReference>(DeviceManagementConfigurationSettingValueTemplateReference.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingValueTemplateReference>("settingValueTemplateReference", SettingValueTemplateReference);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
