using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Setting Instance Template</summary>
    public class DeviceManagementConfigurationSettingInstanceTemplate : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates if a policy must specify this setting.</summary>
        public bool? IsRequired {
            get { return BackingStore?.Get<bool?>("isRequired"); }
            set { BackingStore?.Set("isRequired", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Setting Definition Id</summary>
        public string SettingDefinitionId {
            get { return BackingStore?.Get<string>("settingDefinitionId"); }
            set { BackingStore?.Set("settingDefinitionId", value); }
        }
        /// <summary>Setting Instance Template Id</summary>
        public string SettingInstanceTemplateId {
            get { return BackingStore?.Get<string>("settingInstanceTemplateId"); }
            set { BackingStore?.Set("settingInstanceTemplateId", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingInstanceTemplate() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.deviceManagementConfigurationSettingInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionInstanceTemplate" => new DeviceManagementConfigurationChoiceSettingCollectionInstanceTemplate(),
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingInstanceTemplate" => new DeviceManagementConfigurationChoiceSettingInstanceTemplate(),
                "#microsoft.graph.deviceManagementConfigurationGroupSettingCollectionInstanceTemplate" => new DeviceManagementConfigurationGroupSettingCollectionInstanceTemplate(),
                "#microsoft.graph.deviceManagementConfigurationGroupSettingInstanceTemplate" => new DeviceManagementConfigurationGroupSettingInstanceTemplate(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionInstanceTemplate" => new DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingInstanceTemplate" => new DeviceManagementConfigurationSimpleSettingInstanceTemplate(),
                _ => new DeviceManagementConfigurationSettingInstanceTemplate(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isRequired", n => { IsRequired = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"settingDefinitionId", n => { SettingDefinitionId = n.GetStringValue(); } },
                {"settingInstanceTemplateId", n => { SettingInstanceTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteStringValue("settingInstanceTemplateId", SettingInstanceTemplateId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
