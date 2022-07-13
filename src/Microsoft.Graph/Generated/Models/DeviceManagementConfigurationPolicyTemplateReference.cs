using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Policy template reference information</summary>
    public class DeviceManagementConfigurationPolicyTemplateReference : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Template Display Name of the referenced template. This property is read-only.</summary>
        public string TemplateDisplayName {
            get { return BackingStore?.Get<string>("templateDisplayName"); }
            set { BackingStore?.Set("templateDisplayName", value); }
        }
        /// <summary>Template Display Version of the referenced Template. This property is read-only.</summary>
        public string TemplateDisplayVersion {
            get { return BackingStore?.Get<string>("templateDisplayVersion"); }
            set { BackingStore?.Set("templateDisplayVersion", value); }
        }
        /// <summary>Describes the TemplateFamily for the Template entity</summary>
        public DeviceManagementConfigurationTemplateFamily? TemplateFamily {
            get { return BackingStore?.Get<DeviceManagementConfigurationTemplateFamily?>("templateFamily"); }
            set { BackingStore?.Set("templateFamily", value); }
        }
        /// <summary>Template id</summary>
        public string TemplateId {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationPolicyTemplateReference and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationPolicyTemplateReference() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationPolicyTemplateReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationPolicyTemplateReference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"templateDisplayName", n => { TemplateDisplayName = n.GetStringValue(); } },
                {"templateDisplayVersion", n => { TemplateDisplayVersion = n.GetStringValue(); } },
                {"templateFamily", n => { TemplateFamily = n.GetEnumValue<DeviceManagementConfigurationTemplateFamily>(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("templateDisplayName", TemplateDisplayName);
            writer.WriteStringValue("templateDisplayVersion", TemplateDisplayVersion);
            writer.WriteEnumValue<DeviceManagementConfigurationTemplateFamily>("templateFamily", TemplateFamily);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
