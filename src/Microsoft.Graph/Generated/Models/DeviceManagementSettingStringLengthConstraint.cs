using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettingStringLengthConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>The maximum permitted string length</summary>
        public int? MaximumLength {
            get { return BackingStore?.Get<int?>("maximumLength"); }
            set { BackingStore?.Set("maximumLength", value); }
        }
        /// <summary>The minimum permitted string length</summary>
        public int? MinimumLength {
            get { return BackingStore?.Get<int?>("minimumLength"); }
            set { BackingStore?.Set("minimumLength", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementSettingStringLengthConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingStringLengthConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingStringLengthConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementSettingStringLengthConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingStringLengthConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumLength", n => { MaximumLength = n.GetIntValue(); } },
                {"minimumLength", n => { MinimumLength = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumLength", MaximumLength);
            writer.WriteIntValue("minimumLength", MinimumLength);
        }
    }
}
