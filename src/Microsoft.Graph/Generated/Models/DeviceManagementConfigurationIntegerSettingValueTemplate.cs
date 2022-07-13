using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationIntegerSettingValueTemplate : DeviceManagementConfigurationSimpleSettingValueTemplate, IParsable {
        /// <summary>Integer Setting Value Default Template.</summary>
        public DeviceManagementConfigurationIntegerSettingValueDefaultTemplate DefaultValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefaultTemplate>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>Recommended value definition.</summary>
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate RecommendedValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("recommendedValueDefinition"); }
            set { BackingStore?.Set("recommendedValueDefinition", value); }
        }
        /// <summary>Required value definition.</summary>
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate RequiredValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("requiredValueDefinition"); }
            set { BackingStore?.Set("requiredValueDefinition", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationIntegerSettingValueTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationIntegerSettingValueTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetObjectValue<DeviceManagementConfigurationIntegerSettingValueDefaultTemplate>(DeviceManagementConfigurationIntegerSettingValueDefaultTemplate.CreateFromDiscriminatorValue); } },
                {"recommendedValueDefinition", n => { RecommendedValueDefinition = n.GetObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>(DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate.CreateFromDiscriminatorValue); } },
                {"requiredValueDefinition", n => { RequiredValueDefinition = n.GetObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>(DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefaultTemplate>("defaultValue", DefaultValue);
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("recommendedValueDefinition", RecommendedValueDefinition);
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("requiredValueDefinition", RequiredValueDefinition);
        }
    }
}
