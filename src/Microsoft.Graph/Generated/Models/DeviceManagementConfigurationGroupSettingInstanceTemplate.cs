using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationGroupSettingInstanceTemplate : DeviceManagementConfigurationSettingInstanceTemplate, IParsable {
        /// <summary>Group Setting Value Template</summary>
        public DeviceManagementConfigurationGroupSettingValueTemplate GroupSettingValueTemplate {
            get { return BackingStore?.Get<DeviceManagementConfigurationGroupSettingValueTemplate>("groupSettingValueTemplate"); }
            set { BackingStore?.Set("groupSettingValueTemplate", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationGroupSettingInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationGroupSettingInstanceTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationGroupSettingInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationGroupSettingInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationGroupSettingInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"groupSettingValueTemplate", n => { GroupSettingValueTemplate = n.GetObjectValue<DeviceManagementConfigurationGroupSettingValueTemplate>(DeviceManagementConfigurationGroupSettingValueTemplate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationGroupSettingValueTemplate>("groupSettingValueTemplate", GroupSettingValueTemplate);
        }
    }
}
