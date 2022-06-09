using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Setting value template reference information</summary>
    public class DeviceManagementConfigurationSettingValueTemplateReference : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Setting value template id</summary>
        public string SettingValueTemplateId {
            get { return BackingStore?.Get<string>(nameof(SettingValueTemplateId)); }
            set { BackingStore?.Set(nameof(SettingValueTemplateId), value); }
        }
        /// <summary>Indicates whether to update policy setting value to match template setting default value</summary>
        public bool? UseTemplateDefault {
            get { return BackingStore?.Get<bool?>(nameof(UseTemplateDefault)); }
            set { BackingStore?.Set(nameof(UseTemplateDefault), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingValueTemplateReference and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingValueTemplateReference() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingValueTemplateReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingValueTemplateReference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"settingValueTemplateId", n => { SettingValueTemplateId = n.GetStringValue(); } },
                {"useTemplateDefault", n => { UseTemplateDefault = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("settingValueTemplateId", SettingValueTemplateId);
            writer.WriteBoolValue("useTemplateDefault", UseTemplateDefault);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
