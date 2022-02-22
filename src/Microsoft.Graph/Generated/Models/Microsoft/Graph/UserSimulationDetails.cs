using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserSimulationDetails : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of trainings assigned to a user in an attack simulation and training campaign.</summary>
        public int? AssignedTrainingsCount { get; set; }
        /// <summary>Number of trainings completed by a user in an attack simulation and training campaign.</summary>
        public int? CompletedTrainingsCount { get; set; }
        /// <summary>Date and time of the compromising online action by a user in an attack simulation and training campaign.</summary>
        public DateTimeOffset? CompromisedDateTime { get; set; }
        /// <summary>Number of trainings in progress by a user in an attack simulation and training campaign.</summary>
        public int? InProgressTrainingsCount { get; set; }
        /// <summary>Flag representing if user was compromised in an attack simulation and training campaign.</summary>
        public bool? IsCompromised { get; set; }
        /// <summary>Date and time when user reported delivered payload as phish in the attack simulation and training campaign.</summary>
        public DateTimeOffset? ReportedPhishDateTime { get; set; }
        /// <summary>List of simulation events of a user in the attack simulation and training campaign.</summary>
        public List<UserSimulationEventInfo> SimulationEvents { get; set; }
        /// <summary>User in an attack simulation and training campaign.</summary>
        public AttackSimulationUser SimulationUser { get; set; }
        /// <summary>List of training events of a user in the attack simulation and training campaign.</summary>
        public List<UserTrainingEventInfo> TrainingEvents { get; set; }
        /// <summary>
        /// Instantiates a new userSimulationDetails and sets the default values.
        /// </summary>
        public UserSimulationDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedTrainingsCount", (o,n) => { (o as UserSimulationDetails).AssignedTrainingsCount = n.GetIntValue(); } },
                {"completedTrainingsCount", (o,n) => { (o as UserSimulationDetails).CompletedTrainingsCount = n.GetIntValue(); } },
                {"compromisedDateTime", (o,n) => { (o as UserSimulationDetails).CompromisedDateTime = n.GetDateTimeOffsetValue(); } },
                {"inProgressTrainingsCount", (o,n) => { (o as UserSimulationDetails).InProgressTrainingsCount = n.GetIntValue(); } },
                {"isCompromised", (o,n) => { (o as UserSimulationDetails).IsCompromised = n.GetBoolValue(); } },
                {"reportedPhishDateTime", (o,n) => { (o as UserSimulationDetails).ReportedPhishDateTime = n.GetDateTimeOffsetValue(); } },
                {"simulationEvents", (o,n) => { (o as UserSimulationDetails).SimulationEvents = n.GetCollectionOfObjectValues<UserSimulationEventInfo>().ToList(); } },
                {"simulationUser", (o,n) => { (o as UserSimulationDetails).SimulationUser = n.GetObjectValue<AttackSimulationUser>(); } },
                {"trainingEvents", (o,n) => { (o as UserSimulationDetails).TrainingEvents = n.GetCollectionOfObjectValues<UserTrainingEventInfo>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("assignedTrainingsCount", AssignedTrainingsCount);
            writer.WriteIntValue("completedTrainingsCount", CompletedTrainingsCount);
            writer.WriteDateTimeOffsetValue("compromisedDateTime", CompromisedDateTime);
            writer.WriteIntValue("inProgressTrainingsCount", InProgressTrainingsCount);
            writer.WriteBoolValue("isCompromised", IsCompromised);
            writer.WriteDateTimeOffsetValue("reportedPhishDateTime", ReportedPhishDateTime);
            writer.WriteCollectionOfObjectValues<UserSimulationEventInfo>("simulationEvents", SimulationEvents);
            writer.WriteObjectValue<AttackSimulationUser>("simulationUser", SimulationUser);
            writer.WriteCollectionOfObjectValues<UserTrainingEventInfo>("trainingEvents", TrainingEvents);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
