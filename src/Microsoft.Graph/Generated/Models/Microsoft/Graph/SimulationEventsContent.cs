using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SimulationEventsContent : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Actual percentage of users who fell for the simulated attack in an attack simulation and training campaign.</summary>
        public double? CompromisedRate { get; set; }
        /// <summary>List of simulation events in an attack simulation and training campaign.</summary>
        public List<SimulationEvent> Events { get; set; }
        /// <summary>
        /// Instantiates a new simulationEventsContent and sets the default values.
        /// </summary>
        public SimulationEventsContent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"compromisedRate", (o,n) => { (o as SimulationEventsContent).CompromisedRate = n.GetDoubleValue(); } },
                {"events", (o,n) => { (o as SimulationEventsContent).Events = n.GetCollectionOfObjectValues<SimulationEvent>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("compromisedRate", CompromisedRate);
            writer.WriteCollectionOfObjectValues<SimulationEvent>("events", Events);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
