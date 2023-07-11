using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Base entity for a constraint
    /// </summary>
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
        /// Instantiates a new deviceManagementSettingIntegerConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingIntegerConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingIntegerConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumValue", MaximumValue);
            writer.WriteIntValue("minimumValue", MinimumValue);
        }
    }
}
