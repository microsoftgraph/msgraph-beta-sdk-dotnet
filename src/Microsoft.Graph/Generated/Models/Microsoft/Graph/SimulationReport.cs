using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SimulationReport : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Overview of an attack simulation and training campaign.</summary>
        public SimulationReportOverview Overview { get; set; }
        /// <summary>Represents users of a tenant and their online actions in an attack simulation and training campaign.</summary>
        public List<UserSimulationDetails> SimulationUsers { get; set; }
        /// <summary>
        /// Instantiates a new simulationReport and sets the default values.
        /// </summary>
        public SimulationReport() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SimulationReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"overview", (o,n) => { (o as SimulationReport).Overview = n.GetObjectValue<SimulationReportOverview>(SimulationReportOverview.CreateFromDiscriminatorValue); } },
                {"simulationUsers", (o,n) => { (o as SimulationReport).SimulationUsers = n.GetCollectionOfObjectValues<UserSimulationDetails>(UserSimulationDetails.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SimulationReportOverview>("overview", Overview);
            writer.WriteCollectionOfObjectValues<UserSimulationDetails>("simulationUsers", SimulationUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
