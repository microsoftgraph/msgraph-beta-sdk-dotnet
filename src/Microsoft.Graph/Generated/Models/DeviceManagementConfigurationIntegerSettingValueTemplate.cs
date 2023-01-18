using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationIntegerSettingValueTemplate : DeviceManagementConfigurationSimpleSettingValueTemplate, IParsable {
        /// <summary>Integer Setting Value Default Template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceManagementConfigurationIntegerSettingValueDefaultTemplate? DefaultValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefaultTemplate?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#else
        public DeviceManagementConfigurationIntegerSettingValueDefaultTemplate DefaultValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefaultTemplate>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#endif
        /// <summary>Recommended value definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate? RecommendedValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate?>("recommendedValueDefinition"); }
            set { BackingStore?.Set("recommendedValueDefinition", value); }
        }
#else
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate RecommendedValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("recommendedValueDefinition"); }
            set { BackingStore?.Set("recommendedValueDefinition", value); }
        }
#endif
        /// <summary>Required value definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate? RequiredValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate?>("requiredValueDefinition"); }
            set { BackingStore?.Set("requiredValueDefinition", value); }
        }
#else
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate RequiredValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("requiredValueDefinition"); }
            set { BackingStore?.Set("requiredValueDefinition", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationIntegerSettingValueTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationIntegerSettingValueTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationIntegerSettingValueTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefaultTemplate>("defaultValue", DefaultValue);
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("recommendedValueDefinition", RecommendedValueDefinition);
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("requiredValueDefinition", RequiredValueDefinition);
        }
    }
}
