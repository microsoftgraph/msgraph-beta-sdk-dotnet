using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SimulationReportOverview : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of recommended actions for a tenant to improve its security posture based on the attack simulation and training campaign attack type.</summary>
        public List<RecommendedAction> RecommendedActions { get; set; }
        /// <summary>Number of valid users in the attack simulation and training campaign.</summary>
        public int? ResolvedTargetsCount { get; set; }
        /// <summary>Summary of simulation events in the attack simulation and training campaign.</summary>
        public SimulationEventsContent SimulationEventsContent { get; set; }
        /// <summary>Summary of assigned trainings in the attack simulation and training campaign.</summary>
        public TrainingEventsContent TrainingEventsContent { get; set; }
        /// <summary>
        /// Instantiates a new simulationReportOverview and sets the default values.
        /// </summary>
        public SimulationReportOverview() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"recommendedActions", (o,n) => { (o as SimulationReportOverview).RecommendedActions = n.GetCollectionOfObjectValues<RecommendedAction>().ToList(); } },
                {"resolvedTargetsCount", (o,n) => { (o as SimulationReportOverview).ResolvedTargetsCount = n.GetIntValue(); } },
                {"simulationEventsContent", (o,n) => { (o as SimulationReportOverview).SimulationEventsContent = n.GetObjectValue<SimulationEventsContent>(); } },
                {"trainingEventsContent", (o,n) => { (o as SimulationReportOverview).TrainingEventsContent = n.GetObjectValue<TrainingEventsContent>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<RecommendedAction>("recommendedActions", RecommendedActions);
            writer.WriteIntValue("resolvedTargetsCount", ResolvedTargetsCount);
            writer.WriteObjectValue<SimulationEventsContent>("simulationEventsContent", SimulationEventsContent);
            writer.WriteObjectValue<TrainingEventsContent>("trainingEventsContent", TrainingEventsContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
