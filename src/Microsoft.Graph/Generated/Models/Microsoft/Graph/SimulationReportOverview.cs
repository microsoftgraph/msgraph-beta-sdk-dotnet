using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the attackSimulation property of the microsoft.graph.security entity.</summary>
    public class SimulationReportOverview : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of recommended actions for a tenant to improve its security posture based on the attack simulation and training campaign attack type.</summary>
        public List<RecommendedAction> RecommendedActions { get; set; }
        /// <summary>Number of valid users in the attack simulation and training campaign.</summary>
        public int? ResolvedTargetsCount { get; set; }
        /// <summary>Summary of simulation events in the attack simulation and training campaign.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SimulationEventsContent SimulationEventsContent { get; set; }
        /// <summary>Summary of assigned trainings in the attack simulation and training campaign.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TrainingEventsContent TrainingEventsContent { get; set; }
        /// <summary>
        /// Instantiates a new simulationReportOverview and sets the default values.
        /// </summary>
        public SimulationReportOverview() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SimulationReportOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationReportOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"recommendedActions", (o,n) => { (o as SimulationReportOverview).RecommendedActions = n.GetCollectionOfObjectValues<RecommendedAction>(RecommendedAction.CreateFromDiscriminatorValue).ToList(); } },
                {"resolvedTargetsCount", (o,n) => { (o as SimulationReportOverview).ResolvedTargetsCount = n.GetIntValue(); } },
                {"simulationEventsContent", (o,n) => { (o as SimulationReportOverview).SimulationEventsContent = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SimulationEventsContent>(MicrosoftGraphSdk.Models.Microsoft.Graph.SimulationEventsContent.CreateFromDiscriminatorValue); } },
                {"trainingEventsContent", (o,n) => { (o as SimulationReportOverview).TrainingEventsContent = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.TrainingEventsContent>(MicrosoftGraphSdk.Models.Microsoft.Graph.TrainingEventsContent.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SimulationEventsContent>("simulationEventsContent", SimulationEventsContent);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.TrainingEventsContent>("trainingEventsContent", TrainingEventsContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
