using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AttackSimulationRoot : Entity, IParsable {
        /// <summary>Represents simulation automations created to run on a tenant.</summary>
        public List<SimulationAutomation> SimulationAutomations {
            get { return BackingStore?.Get<List<SimulationAutomation>>("simulationAutomations"); }
            set { BackingStore?.Set("simulationAutomations", value); }
        }
        /// <summary>Represents an attack simulation training campaign in a tenant.</summary>
        public List<Simulation> Simulations {
            get { return BackingStore?.Get<List<Simulation>>("simulations"); }
            set { BackingStore?.Set("simulations", value); }
        }
        /// <summary>
        /// Instantiates a new AttackSimulationRoot and sets the default values.
        /// </summary>
        public AttackSimulationRoot() : base() {
            OdataType = "#microsoft.graph.attackSimulationRoot";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AttackSimulationRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"simulationAutomations", n => { SimulationAutomations = n.GetCollectionOfObjectValues<SimulationAutomation>(SimulationAutomation.CreateFromDiscriminatorValue).ToList(); } },
                {"simulations", n => { Simulations = n.GetCollectionOfObjectValues<Simulation>(Simulation.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SimulationAutomation>("simulationAutomations", SimulationAutomations);
            writer.WriteCollectionOfObjectValues<Simulation>("simulations", Simulations);
        }
    }
}
