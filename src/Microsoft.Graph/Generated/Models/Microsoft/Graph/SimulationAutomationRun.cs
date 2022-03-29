using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SimulationAutomationRun : Entity, IParsable {
        /// <summary>Date and time when the run ends in an attack simulation automation.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Unique identifier for the attack simulation campaign initiated in the attack simulation automation run.</summary>
        public string SimulationId { get; set; }
        /// <summary>Date and time when the run starts in an attack simulation automation.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Status of the run of an attack simulation automation. The possible values are: unknown, running, succeeded, failed, skipped, unknownFutureValue.</summary>
        public SimulationAutomationRunStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SimulationAutomationRun CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationAutomationRun();
        }
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
