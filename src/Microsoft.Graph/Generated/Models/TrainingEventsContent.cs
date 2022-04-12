using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TrainingEventsContent : IAdditionalDataHolder, IParsable {
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedTrainingsInfos", n => { AssignedTrainingsInfos = n.GetCollectionOfObjectValues<AssignedTrainingInfo>(AssignedTrainingInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"trainingsAssignedUserCount", n => { TrainingsAssignedUserCount = n.GetIntValue(); } },
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
