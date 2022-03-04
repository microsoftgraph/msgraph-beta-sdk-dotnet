using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PlannerTaskCreation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information about the publication process that created this task. null value indicates that the task was not created by a publication process.</summary>
        public PlannerTeamsPublicationInfo TeamsPublicationInfo { get; set; }
        /// <summary>
        /// Instantiates a new plannerTaskCreation and sets the default values.
        /// </summary>
        public PlannerTaskCreation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PlannerTaskCreation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskCreation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"teamsPublicationInfo", (o,n) => { (o as PlannerTaskCreation).TeamsPublicationInfo = n.GetObjectValue<PlannerTeamsPublicationInfo>(PlannerTeamsPublicationInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PlannerTeamsPublicationInfo>("teamsPublicationInfo", TeamsPublicationInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
