using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SimulationAutomationRun : Entity, IParsable {
        public DateTimeOffset? EndDateTime { get; set; }
        public string SimulationId { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        public SimulationAutomationRunStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"endDateTime", (o,n) => { (o as SimulationAutomationRun).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"simulationId", (o,n) => { (o as SimulationAutomationRun).SimulationId = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as SimulationAutomationRun).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as SimulationAutomationRun).Status = n.GetEnumValue<SimulationAutomationRunStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("simulationId", SimulationId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<SimulationAutomationRunStatus>("status", Status);
        }
    }
}
