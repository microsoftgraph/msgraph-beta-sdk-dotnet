using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Class in Exchange.</summary>
    public class DeviceManagementExchangeDeviceClass : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the device class which will be impacted by this rule.</summary>
        public string Name { get; set; }
        /// <summary>Type of device which is impacted by this rule e.g. Model, Family. Possible values are: family, model.</summary>
        public DeviceManagementExchangeAccessRuleType? Type { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementExchangeDeviceClass and sets the default values.
        /// </summary>
        public DeviceManagementExchangeDeviceClass() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementExchangeDeviceClass CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementExchangeDeviceClass();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"name", n => { Name = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<DeviceManagementExchangeAccessRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<DeviceManagementExchangeAccessRuleType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
