using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Referred setting information about reusable setting</summary>
    public class DeviceManagementConfigurationReferredSettingInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Setting definition id that is being referred to a setting. Applicable for reusable setting</summary>
        public string SettingDefinitionId { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationReferredSettingInformation and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationReferredSettingInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationReferredSettingInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationReferredSettingInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"settingDefinitionId", (o,n) => { (o as DeviceManagementConfigurationReferredSettingInformation).SettingDefinitionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
