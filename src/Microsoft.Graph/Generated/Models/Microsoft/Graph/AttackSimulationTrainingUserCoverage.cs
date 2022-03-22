using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AttackSimulationTrainingUserCoverage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>User in an attack simulation and training campaign.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser AttackSimulationUser { get; set; }
        /// <summary>List of assigned trainings' and their statuses for the user.</summary>
        public List<UserTrainingStatusInfo> UserTrainings { get; set; }
        /// <summary>
        /// Instantiates a new attackSimulationTrainingUserCoverage and sets the default values.
        /// </summary>
        public AttackSimulationTrainingUserCoverage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttackSimulationTrainingUserCoverage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationTrainingUserCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attackSimulationUser", (o,n) => { (o as AttackSimulationTrainingUserCoverage).AttackSimulationUser = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser>(MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"userTrainings", (o,n) => { (o as AttackSimulationTrainingUserCoverage).UserTrainings = n.GetCollectionOfObjectValues<UserTrainingStatusInfo>(UserTrainingStatusInfo.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteCollectionOfObjectValues<UserTrainingStatusInfo>("userTrainings", UserTrainings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
