using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Setting value template reference information
    /// </summary>
    public class DeviceManagementConfigurationSettingValueTemplateReference : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Setting value template id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SettingValueTemplateId {
            get { return BackingStore?.Get<string?>("settingValueTemplateId"); }
            set { BackingStore?.Set("settingValueTemplateId", value); }
        }
#else
        public string SettingValueTemplateId {
            get { return BackingStore?.Get<string>("settingValueTemplateId"); }
            set { BackingStore?.Set("settingValueTemplateId", value); }
        }
#endif
        /// <summary>Indicates whether to update policy setting value to match template setting default value</summary>
        public bool? UseTemplateDefault {
            get { return BackingStore?.Get<bool?>("useTemplateDefault"); }
            set { BackingStore?.Set("useTemplateDefault", value); }
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
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementConfigurationSettingValueTemplateReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingValueTemplateReference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"settingValueTemplateId", n => { SettingValueTemplateId = n.GetStringValue(); } },
                {"useTemplateDefault", n => { UseTemplateDefault = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("settingValueTemplateId", SettingValueTemplateId);
            writer.WriteBoolValue("useTemplateDefault", UseTemplateDefault);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
