using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SimulationEventsContent : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SimulationEventsContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationEventsContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"compromisedRate", n => { CompromisedRate = n.GetDoubleValue(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<SimulationEvent>(SimulationEvent.CreateFromDiscriminatorValue).ToList(); } },
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
