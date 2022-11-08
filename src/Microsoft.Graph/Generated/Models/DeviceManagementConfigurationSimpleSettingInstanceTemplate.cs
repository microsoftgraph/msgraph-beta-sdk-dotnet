using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSimpleSettingInstanceTemplate : DeviceManagementConfigurationSettingInstanceTemplate, IParsable {
        /// <summary>Simple Setting Value Template</summary>
        public DeviceManagementConfigurationSimpleSettingValueTemplate SimpleSettingValueTemplate {
            get { return BackingStore?.Get<DeviceManagementConfigurationSimpleSettingValueTemplate>("simpleSettingValueTemplate"); }
            set { BackingStore?.Set("simpleSettingValueTemplate", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationSimpleSettingInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingInstanceTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSimpleSettingInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationSimpleSettingInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSimpleSettingInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"simpleSettingValueTemplate", n => { SimpleSettingValueTemplate = n.GetObjectValue<DeviceManagementConfigurationSimpleSettingValueTemplate>(DeviceManagementConfigurationSimpleSettingValueTemplate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationSimpleSettingValueTemplate>("simpleSettingValueTemplate", SimpleSettingValueTemplate);
        }
    }
}
