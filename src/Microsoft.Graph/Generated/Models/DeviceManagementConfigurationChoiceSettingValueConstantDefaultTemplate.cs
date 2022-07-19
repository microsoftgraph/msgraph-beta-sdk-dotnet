using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate : DeviceManagementConfigurationChoiceSettingValueDefaultTemplate, IParsable {
        /// <summary>Option Children</summary>
        public List<DeviceManagementConfigurationSettingInstanceTemplate> Children {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingInstanceTemplate>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
        /// <summary>Default Constant Value</summary>
        public string SettingDefinitionOptionId {
            get { return BackingStore?.Get<string>("settingDefinitionOptionId"); }
            set { BackingStore?.Set("settingDefinitionOptionId", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"children", n => { Children = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingInstanceTemplate>(DeviceManagementConfigurationSettingInstanceTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"settingDefinitionOptionId", n => { SettingDefinitionOptionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingInstanceTemplate>("children", Children);
            writer.WriteStringValue("settingDefinitionOptionId", SettingDefinitionOptionId);
        }
    }
}
