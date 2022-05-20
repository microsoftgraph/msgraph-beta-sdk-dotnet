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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Template Display Name of the referenced template. This property is read-only.</summary>
        public string TemplateDisplayName {
            get { return BackingStore?.Get<string>(nameof(TemplateDisplayName)); }
            set { BackingStore?.Set(nameof(TemplateDisplayName), value); }
        }
        /// <summary>Template Display Version of the referenced Template. This property is read-only.</summary>
        public string TemplateDisplayVersion {
            get { return BackingStore?.Get<string>(nameof(TemplateDisplayVersion)); }
            set { BackingStore?.Set(nameof(TemplateDisplayVersion), value); }
        }
        /// <summary>Template Family of the referenced Template. This property is read-only. Possible values are: none, endpointSecurityAntivirus, endpointSecurityDiskEncryption, endpointSecurityFirewall, endpointSecurityEndpointDetectionAndResponse, endpointSecurityAttackSurfaceReduction, endpointSecurityAccountProtection, endpointSecurityApplicationControl, baseline.</summary>
        public DeviceManagementConfigurationTemplateFamily? TemplateFamily {
            get { return BackingStore?.Get<DeviceManagementConfigurationTemplateFamily?>(nameof(TemplateFamily)); }
            set { BackingStore?.Set(nameof(TemplateFamily), value); }
        }
        /// <summary>Template id</summary>
        public string TemplateId {
            get { return BackingStore?.Get<string>(nameof(TemplateId)); }
            set { BackingStore?.Set(nameof(TemplateId), value); }
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
