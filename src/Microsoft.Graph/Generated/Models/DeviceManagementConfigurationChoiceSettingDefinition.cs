using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationChoiceSettingDefinition : DeviceManagementConfigurationSettingDefinition, IParsable {
        /// <summary>Default option for choice setting</summary>
        public string DefaultOptionId {
            get { return BackingStore?.Get<string>("defaultOptionId"); }
            set { BackingStore?.Set("defaultOptionId", value); }
        }
        /// <summary>Options for the setting that can be selected</summary>
        public List<DeviceManagementConfigurationOptionDefinition> Options {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationOptionDefinition>>("options"); }
            set { BackingStore?.Set("options", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationChoiceSettingDefinition and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingDefinition() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationChoiceSettingDefinition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationChoiceSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionDefinition" => new DeviceManagementConfigurationChoiceSettingCollectionDefinition(),
                _ => new DeviceManagementConfigurationChoiceSettingDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultOptionId", n => { DefaultOptionId = n.GetStringValue(); } },
                {"options", n => { Options = n.GetCollectionOfObjectValues<DeviceManagementConfigurationOptionDefinition>(DeviceManagementConfigurationOptionDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultOptionId", DefaultOptionId);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationOptionDefinition>("options", Options);
        }
    }
}
