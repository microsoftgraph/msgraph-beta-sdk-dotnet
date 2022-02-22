using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SimulationEvent : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Count of occurence of the simulation event in an attack simulation and training campaign.</summary>
        public int? Count { get; set; }
        /// <summary>Name of the simulation event in an attack simulation and training campaign.</summary>
        public string EventName { get; set; }
        /// <summary>
        /// Instantiates a new simulationEvent and sets the default values.
        /// </summary>
        public SimulationEvent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"count", (o,n) => { (o as SimulationEvent).Count = n.GetIntValue(); } },
                {"eventName", (o,n) => { (o as SimulationEvent).EventName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("count", Count);
            writer.WriteStringValue("eventName", EventName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
