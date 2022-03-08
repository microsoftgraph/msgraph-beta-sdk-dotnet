using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the attackSimulation property of the microsoft.graph.security entity.</summary>
    public class AssignedTrainingInfo : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of users who were assigned the training in an attack simulation and training campaign.</summary>
        public int? AssignedUserCount { get; set; }
        /// <summary>Number of users who completed the training in an attack simulation and training campaign.</summary>
        public int? CompletedUserCount { get; set; }
        /// <summary>Display name of the training in an attack simulation and training campaign.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Instantiates a new assignedTrainingInfo and sets the default values.
        /// </summary>
        public AssignedTrainingInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignedTrainingInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignedTrainingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedUserCount", (o,n) => { (o as AssignedTrainingInfo).AssignedUserCount = n.GetIntValue(); } },
                {"completedUserCount", (o,n) => { (o as AssignedTrainingInfo).CompletedUserCount = n.GetIntValue(); } },
                {"displayName", (o,n) => { (o as AssignedTrainingInfo).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("assignedUserCount", AssignedUserCount);
            writer.WriteIntValue("completedUserCount", CompletedUserCount);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
