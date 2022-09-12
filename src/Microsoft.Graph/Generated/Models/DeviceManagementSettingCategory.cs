using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity representing a setting category</summary>
    public class DeviceManagementSettingCategory : Entity, IParsable {
        /// <summary>The category name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The category contains top level required setting</summary>
        public bool? HasRequiredSetting {
            get { return BackingStore?.Get<bool?>("hasRequiredSetting"); }
            set { BackingStore?.Set("hasRequiredSetting", value); }
        }
        /// <summary>The setting definitions this category contains</summary>
        public List<DeviceManagementSettingDefinition> SettingDefinitions {
            get { return BackingStore?.Get<List<DeviceManagementSettingDefinition>>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementSettingCategory and sets the default values.
        /// </summary>
        public DeviceManagementSettingCategory() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingCategory";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementSettingCategory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementIntentSettingCategory" => new DeviceManagementIntentSettingCategory(),
                "#microsoft.graph.deviceManagementTemplateSettingCategory" => new DeviceManagementTemplateSettingCategory(),
                _ => new DeviceManagementSettingCategory(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"hasRequiredSetting", n => { HasRequiredSetting = n.GetBoolValue(); } },
                {"settingDefinitions", n => { SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementSettingDefinition>(DeviceManagementSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
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
