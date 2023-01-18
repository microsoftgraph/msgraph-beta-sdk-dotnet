using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AttackSimulationRoot : Entity, IParsable {
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AttackSimulationOperation>? Operations {
            get { return BackingStore?.Get<List<AttackSimulationOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#else
        public List<AttackSimulationOperation> Operations {
            get { return BackingStore?.Get<List<AttackSimulationOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The payloads property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Payload>? Payloads {
            get { return BackingStore?.Get<List<Payload>?>("payloads"); }
            set { BackingStore?.Set("payloads", value); }
        }
#else
        public List<Payload> Payloads {
            get { return BackingStore?.Get<List<Payload>>("payloads"); }
            set { BackingStore?.Set("payloads", value); }
        }
#endif
        /// <summary>Represents simulation automation created to run on a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SimulationAutomation>? SimulationAutomations {
            get { return BackingStore?.Get<List<SimulationAutomation>?>("simulationAutomations"); }
            set { BackingStore?.Set("simulationAutomations", value); }
        }
#else
        public List<SimulationAutomation> SimulationAutomations {
            get { return BackingStore?.Get<List<SimulationAutomation>>("simulationAutomations"); }
            set { BackingStore?.Set("simulationAutomations", value); }
        }
#endif
        /// <summary>Represents an attack simulation training campaign in a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Simulation>? Simulations {
            get { return BackingStore?.Get<List<Simulation>?>("simulations"); }
            set { BackingStore?.Set("simulations", value); }
        }
#else
        public List<Simulation> Simulations {
            get { return BackingStore?.Get<List<Simulation>>("simulations"); }
            set { BackingStore?.Set("simulations", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AttackSimulationRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<AttackSimulationOperation>(AttackSimulationOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"payloads", n => { Payloads = n.GetCollectionOfObjectValues<Payload>(Payload.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulationAutomations", n => { SimulationAutomations = n.GetCollectionOfObjectValues<SimulationAutomation>(SimulationAutomation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulations", n => { Simulations = n.GetCollectionOfObjectValues<Simulation>(Simulation.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttackSimulationOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Payload>("payloads", Payloads);
            writer.WriteCollectionOfObjectValues<SimulationAutomation>("simulationAutomations", SimulationAutomations);
            writer.WriteCollectionOfObjectValues<Simulation>("simulations", Simulations);
        }
    }
}
