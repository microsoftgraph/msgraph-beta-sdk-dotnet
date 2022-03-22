using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Policy template reference information</summary>
    public class DeviceManagementConfigurationPolicyTemplateReference : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Template Display Name of the referenced template. This property is read-only.</summary>
        public string TemplateDisplayName { get; set; }
        /// <summary>Template Display Version of the referenced Template. This property is read-only.</summary>
        public string TemplateDisplayVersion { get; set; }
        /// <summary>Template Family of the referenced Template. This property is read-only. Possible values are: none, endpointSecurityAntivirus, endpointSecurityDiskEncryption, endpointSecurityFirewall, endpointSecurityEndpointDetectionAndResponse, endpointSecurityAttackSurfaceReduction, endpointSecurityAccountProtection, endpointSecurityApplicationControl, baseline.</summary>
        public DeviceManagementConfigurationTemplateFamily? TemplateFamily { get; set; }
        /// <summary>Template id</summary>
        public string TemplateId { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationPolicyTemplateReference and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationPolicyTemplateReference() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"templateDisplayName", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplateReference).TemplateDisplayName = n.GetStringValue(); } },
                {"templateDisplayVersion", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplateReference).TemplateDisplayVersion = n.GetStringValue(); } },
                {"templateFamily", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplateReference).TemplateFamily = n.GetEnumValue<DeviceManagementConfigurationTemplateFamily>(); } },
                {"templateId", (o,n) => { (o as DeviceManagementConfigurationPolicyTemplateReference).TemplateId = n.GetStringValue(); } },
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
