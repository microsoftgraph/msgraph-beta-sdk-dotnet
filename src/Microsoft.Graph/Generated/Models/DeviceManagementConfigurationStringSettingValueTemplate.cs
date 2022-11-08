using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationStringSettingValueTemplate : DeviceManagementConfigurationSimpleSettingValueTemplate, IParsable {
        /// <summary>String Setting Value Default Template.</summary>
        public DeviceManagementConfigurationStringSettingValueDefaultTemplate DefaultValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationStringSettingValueDefaultTemplate>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationStringSettingValueTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationStringSettingValueTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationStringSettingValueTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationStringSettingValueTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationStringSettingValueTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetObjectValue<DeviceManagementConfigurationStringSettingValueDefaultTemplate>(DeviceManagementConfigurationStringSettingValueDefaultTemplate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationStringSettingValueDefaultTemplate>("defaultValue", DefaultValue);
        }
    }
}
