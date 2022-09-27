using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceComplianceScriptDeviceStateCollectionResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
        public List<DeviceComplianceScriptDeviceState> Value {
            get { return BackingStore?.Get<List<DeviceComplianceScriptDeviceState>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceComplianceScriptDeviceStateCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptDeviceStateCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetCollectionOfObjectValues<DeviceComplianceScriptDeviceState>(DeviceComplianceScriptDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScriptDeviceState>("value", Value);
        }
    }
}
