using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Setting instance within policy
    /// </summary>
    public class DeviceManagementConfigurationSettingInstance : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Setting Definition Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingDefinitionId {
            get { return BackingStore?.Get<string?>("settingDefinitionId"); }
            set { BackingStore?.Set("settingDefinitionId", value); }
        }
#nullable restore
#else
        public string SettingDefinitionId {
            get { return BackingStore?.Get<string>("settingDefinitionId"); }
            set { BackingStore?.Set("settingDefinitionId", value); }
        }
#endif
        /// <summary>Setting Instance Template Reference</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationSettingInstanceTemplateReference? SettingInstanceTemplateReference {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstanceTemplateReference?>("settingInstanceTemplateReference"); }
            set { BackingStore?.Set("settingInstanceTemplateReference", value); }
        }
#nullable restore
#else
        public DeviceManagementConfigurationSettingInstanceTemplateReference SettingInstanceTemplateReference {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstanceTemplateReference>("settingInstanceTemplateReference"); }
            set { BackingStore?.Set("settingInstanceTemplateReference", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingInstance() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementConfigurationSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"settingDefinitionId", n => { SettingDefinitionId = n.GetStringValue(); } },
                {"settingInstanceTemplateReference", n => { SettingInstanceTemplateReference = n.GetObjectValue<DeviceManagementConfigurationSettingInstanceTemplateReference>(DeviceManagementConfigurationSettingInstanceTemplateReference.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstanceTemplateReference>("settingInstanceTemplateReference", SettingInstanceTemplateReference);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
