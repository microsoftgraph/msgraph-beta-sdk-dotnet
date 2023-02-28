using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceHealthScriptBooleanParameter : DeviceHealthScriptParameter, IParsable {
        /// <summary>The default value of boolean param</summary>
        public bool? DefaultValue {
            get { return BackingStore?.Get<bool?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceHealthScriptBooleanParameter and sets the default values.
        /// </summary>
        public DeviceHealthScriptBooleanParameter() : base() {
            OdataType = "#microsoft.graph.deviceHealthScriptBooleanParameter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthScriptBooleanParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptBooleanParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("defaultValue", DefaultValue);
        }
    }
}
