using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Setting Instance Template
    /// </summary>
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
        /// <summary>Setting Instance Template Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingInstanceTemplateId {
            get { return BackingStore?.Get<string?>("settingInstanceTemplateId"); }
            set { BackingStore?.Set("settingInstanceTemplateId", value); }
        }
#nullable restore
#else
        public string SettingInstanceTemplateId {
            get { return BackingStore?.Get<string>("settingInstanceTemplateId"); }
            set { BackingStore?.Set("settingInstanceTemplateId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingInstanceTemplate() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementConfigurationSettingInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingInstanceTemplate();
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
