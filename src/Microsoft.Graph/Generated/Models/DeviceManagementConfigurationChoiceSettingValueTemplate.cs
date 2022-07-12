using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Choice Setting Value Template</summary>
    public class DeviceManagementConfigurationChoiceSettingValueTemplate : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Choice Setting Value Default Template.</summary>
        public DeviceManagementConfigurationChoiceSettingValueDefaultTemplate DefaultValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationChoiceSettingValueDefaultTemplate>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>Recommended definition override.</summary>
        public DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate RecommendedValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>("recommendedValueDefinition"); }
            set { BackingStore?.Set("recommendedValueDefinition", value); }
        }
        /// <summary>Required definition override.</summary>
        public DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate RequiredValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>("requiredValueDefinition"); }
            set { BackingStore?.Set("requiredValueDefinition", value); }
        }
        /// <summary>Setting Value Template Id</summary>
        public string SettingValueTemplateId {
            get { return BackingStore?.Get<string>("settingValueTemplateId"); }
            set { BackingStore?.Set("settingValueTemplateId", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationChoiceSettingValueTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingValueTemplate() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationChoiceSettingValueTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationChoiceSettingValueTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultValue", n => { DefaultValue = n.GetObjectValue<DeviceManagementConfigurationChoiceSettingValueDefaultTemplate>(DeviceManagementConfigurationChoiceSettingValueDefaultTemplate.CreateFromDiscriminatorValue); } },
                {"recommendedValueDefinition", n => { RecommendedValueDefinition = n.GetObjectValue<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>(DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate.CreateFromDiscriminatorValue); } },
                {"requiredValueDefinition", n => { RequiredValueDefinition = n.GetObjectValue<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>(DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate.CreateFromDiscriminatorValue); } },
                {"settingValueTemplateId", n => { SettingValueTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceManagementConfigurationChoiceSettingValueDefaultTemplate>("defaultValue", DefaultValue);
            writer.WriteObjectValue<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>("recommendedValueDefinition", RecommendedValueDefinition);
            writer.WriteObjectValue<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>("requiredValueDefinition", RequiredValueDefinition);
            writer.WriteStringValue("settingValueTemplateId", SettingValueTemplateId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
