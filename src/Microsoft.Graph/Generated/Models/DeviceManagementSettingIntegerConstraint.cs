using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettingIntegerConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>The maximum permitted value</summary>
        public int? MaximumValue {
            get { return BackingStore?.Get<int?>("maximumValue"); }
            set { BackingStore?.Set("maximumValue", value); }
        }
        /// <summary>The minimum permitted value</summary>
        public int? MinimumValue {
            get { return BackingStore?.Get<int?>("minimumValue"); }
            set { BackingStore?.Set("minimumValue", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementSettingIntegerConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingIntegerConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingIntegerConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementSettingIntegerConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingIntegerConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumValue", n => { MaximumValue = n.GetIntValue(); } },
                {"minimumValue", n => { MinimumValue = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumValue", MaximumValue);
            writer.WriteIntValue("minimumValue", MinimumValue);
        }
    }
}
