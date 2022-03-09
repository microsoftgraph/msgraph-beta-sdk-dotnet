using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the attackSimulation property of the microsoft.graph.security entity.</summary>
    public class TrainingEventsContent : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of assigned trainings and their information in an attack simulation and training campaign.</summary>
        public List<AssignedTrainingInfo> AssignedTrainingsInfos { get; set; }
        /// <summary>Number of users who were assigned trainings in an attack simulation and training campaign.</summary>
        public int? TrainingsAssignedUserCount { get; set; }
        /// <summary>
        /// Instantiates a new trainingEventsContent and sets the default values.
        /// </summary>
        public TrainingEventsContent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TrainingEventsContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrainingEventsContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedTrainingsInfos", (o,n) => { (o as TrainingEventsContent).AssignedTrainingsInfos = n.GetCollectionOfObjectValues<AssignedTrainingInfo>(AssignedTrainingInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"trainingsAssignedUserCount", (o,n) => { (o as TrainingEventsContent).TrainingsAssignedUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AssignedTrainingInfo>("assignedTrainingsInfos", AssignedTrainingsInfos);
            writer.WriteIntValue("trainingsAssignedUserCount", TrainingsAssignedUserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
