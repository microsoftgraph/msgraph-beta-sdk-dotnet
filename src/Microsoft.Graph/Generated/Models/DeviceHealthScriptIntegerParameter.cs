using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Properties of the  Integer script parameter.
    /// </summary>
    public class DeviceHealthScriptIntegerParameter : DeviceHealthScriptParameter, IParsable {
        /// <summary>The default value of Integer param. Valid values -2147483648 to 2147483647</summary>
        public int? DefaultValue {
            get { return BackingStore?.Get<int?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>
        /// Instantiates a new deviceHealthScriptIntegerParameter and sets the default values.
        /// </summary>
        public DeviceHealthScriptIntegerParameter() : base() {
            OdataType = "#microsoft.graph.deviceHealthScriptIntegerParameter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthScriptIntegerParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptIntegerParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("defaultValue", DefaultValue);
        }
    }
}
