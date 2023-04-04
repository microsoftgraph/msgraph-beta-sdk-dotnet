using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UserSimulationDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Number of trainings assigned to a user in an attack simulation and training campaign.</summary>
        public int? AssignedTrainingsCount {
            get { return BackingStore?.Get<int?>("assignedTrainingsCount"); }
            set { BackingStore?.Set("assignedTrainingsCount", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of trainings completed by a user in an attack simulation and training campaign.</summary>
        public int? CompletedTrainingsCount {
            get { return BackingStore?.Get<int?>("completedTrainingsCount"); }
            set { BackingStore?.Set("completedTrainingsCount", value); }
        }
        /// <summary>Date and time of the compromising online action by a user in an attack simulation and training campaign.</summary>
        public DateTimeOffset? CompromisedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("compromisedDateTime"); }
            set { BackingStore?.Set("compromisedDateTime", value); }
        }
        /// <summary>Number of trainings in progress by a user in an attack simulation and training campaign.</summary>
        public int? InProgressTrainingsCount {
            get { return BackingStore?.Get<int?>("inProgressTrainingsCount"); }
            set { BackingStore?.Set("inProgressTrainingsCount", value); }
        }
        /// <summary>Indicates whether a user was compromised in an attack simulation and training campaign.</summary>
        public bool? IsCompromised {
            get { return BackingStore?.Get<bool?>("isCompromised"); }
            set { BackingStore?.Set("isCompromised", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Date and time when a user reported the delivered payload as phishing in the attack simulation and training campaign.</summary>
        public DateTimeOffset? ReportedPhishDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("reportedPhishDateTime"); }
            set { BackingStore?.Set("reportedPhishDateTime", value); }
        }
        /// <summary>List of simulation events of a user in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSimulationEventInfo>? SimulationEvents {
            get { return BackingStore?.Get<List<UserSimulationEventInfo>?>("simulationEvents"); }
            set { BackingStore?.Set("simulationEvents", value); }
        }
#nullable restore
#else
        public List<UserSimulationEventInfo> SimulationEvents {
            get { return BackingStore?.Get<List<UserSimulationEventInfo>>("simulationEvents"); }
            set { BackingStore?.Set("simulationEvents", value); }
        }
#endif
        /// <summary>The user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AttackSimulationUser? SimulationUser {
            get { return BackingStore?.Get<AttackSimulationUser?>("simulationUser"); }
            set { BackingStore?.Set("simulationUser", value); }
        }
#nullable restore
#else
        public AttackSimulationUser SimulationUser {
            get { return BackingStore?.Get<AttackSimulationUser>("simulationUser"); }
            set { BackingStore?.Set("simulationUser", value); }
        }
#endif
        /// <summary>List of training events of a user in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserTrainingEventInfo>? TrainingEvents {
            get { return BackingStore?.Get<List<UserTrainingEventInfo>?>("trainingEvents"); }
            set { BackingStore?.Set("trainingEvents", value); }
        }
#nullable restore
#else
        public List<UserTrainingEventInfo> TrainingEvents {
            get { return BackingStore?.Get<List<UserTrainingEventInfo>>("trainingEvents"); }
            set { BackingStore?.Set("trainingEvents", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new userSimulationDetails and sets the default values.
        /// </summary>
        public UserSimulationDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserSimulationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSimulationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedTrainingsCount", n => { AssignedTrainingsCount = n.GetIntValue(); } },
                {"completedTrainingsCount", n => { CompletedTrainingsCount = n.GetIntValue(); } },
                {"compromisedDateTime", n => { CompromisedDateTime = n.GetDateTimeOffsetValue(); } },
                {"inProgressTrainingsCount", n => { InProgressTrainingsCount = n.GetIntValue(); } },
                {"isCompromised", n => { IsCompromised = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reportedPhishDateTime", n => { ReportedPhishDateTime = n.GetDateTimeOffsetValue(); } },
                {"simulationEvents", n => { SimulationEvents = n.GetCollectionOfObjectValues<UserSimulationEventInfo>(UserSimulationEventInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulationUser", n => { SimulationUser = n.GetObjectValue<AttackSimulationUser>(AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"trainingEvents", n => { TrainingEvents = n.GetCollectionOfObjectValues<UserTrainingEventInfo>(UserTrainingEventInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("assignedTrainingsCount", AssignedTrainingsCount);
            writer.WriteIntValue("completedTrainingsCount", CompletedTrainingsCount);
            writer.WriteDateTimeOffsetValue("compromisedDateTime", CompromisedDateTime);
            writer.WriteIntValue("inProgressTrainingsCount", InProgressTrainingsCount);
            writer.WriteBoolValue("isCompromised", IsCompromised);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("reportedPhishDateTime", ReportedPhishDateTime);
            writer.WriteCollectionOfObjectValues<UserSimulationEventInfo>("simulationEvents", SimulationEvents);
            writer.WriteObjectValue<AttackSimulationUser>("simulationUser", SimulationUser);
            writer.WriteCollectionOfObjectValues<UserTrainingEventInfo>("trainingEvents", TrainingEvents);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
