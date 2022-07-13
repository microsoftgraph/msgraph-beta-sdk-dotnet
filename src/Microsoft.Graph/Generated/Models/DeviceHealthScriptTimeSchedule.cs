using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceHealthScriptTimeSchedule : DeviceHealthScriptRunSchedule, IParsable {
        /// <summary>At what time the script is scheduled to run. This collection can contain a maximum of 20 elements.</summary>
        public Time? Time {
            get { return BackingStore?.Get<Time?>("time"); }
            set { BackingStore?.Set("time", value); }
        }
        /// <summary>Indicate if the time is Utc or client local time.</summary>
        public bool? UseUtc {
            get { return BackingStore?.Get<bool?>("useUtc"); }
            set { BackingStore?.Set("useUtc", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceHealthScriptTimeSchedule and sets the default values.
        /// </summary>
        public DeviceHealthScriptTimeSchedule() : base() {
            Type = "#microsoft.graph.deviceHealthScriptTimeSchedule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceHealthScriptTimeSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceHealthScriptDailySchedule" => new DeviceHealthScriptDailySchedule(),
                "#microsoft.graph.deviceHealthScriptRunOnceSchedule" => new DeviceHealthScriptRunOnceSchedule(),
                _ => new DeviceHealthScriptTimeSchedule(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"time", n => { Time = n.GetTimeValue(); } },
                {"useUtc", n => { UseUtc = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeValue("time", Time);
            writer.WriteBoolValue("useUtc", UseUtc);
        }
    }
}
