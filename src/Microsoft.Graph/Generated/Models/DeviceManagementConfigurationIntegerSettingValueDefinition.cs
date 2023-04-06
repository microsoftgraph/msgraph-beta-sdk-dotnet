using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationIntegerSettingValueDefinition : DeviceManagementConfigurationSettingValueDefinition, IParsable {
        /// <summary>Maximum allowed value of the integer</summary>
        public long? MaximumValue {
            get { return BackingStore?.Get<long?>("maximumValue"); }
            set { BackingStore?.Set("maximumValue", value); }
        }
        /// <summary>Minimum allowed value of the integer</summary>
        public long? MinimumValue {
            get { return BackingStore?.Get<long?>("minimumValue"); }
            set { BackingStore?.Set("minimumValue", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationIntegerSettingValueDefinition and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationIntegerSettingValueDefinition() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationIntegerSettingValueDefinition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationIntegerSettingValueDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationIntegerSettingValueDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumValue", n => { MaximumValue = n.GetLongValue(); } },
                {"minimumValue", n => { MinimumValue = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("maximumValue", MaximumValue);
            writer.WriteLongValue("minimumValue", MinimumValue);
        }
    }
}
