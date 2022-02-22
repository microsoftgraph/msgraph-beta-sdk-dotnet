using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TrainingEventsContent : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedTrainingsInfos", (o,n) => { (o as TrainingEventsContent).AssignedTrainingsInfos = n.GetCollectionOfObjectValues<AssignedTrainingInfo>().ToList(); } },
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
