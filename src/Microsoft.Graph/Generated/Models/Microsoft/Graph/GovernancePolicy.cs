using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class GovernancePolicy : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<GovernanceCriteria> DecisionMakerCriteria { get; set; }
        public GovernanceNotificationPolicy NotificationPolicy { get; set; }
        /// <summary>
        /// Instantiates a new governancePolicy and sets the default values.
        /// </summary>
        public GovernancePolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"decisionMakerCriteria", (o,n) => { (o as GovernancePolicy).DecisionMakerCriteria = n.GetCollectionOfObjectValues<GovernanceCriteria>().ToList(); } },
                {"notificationPolicy", (o,n) => { (o as GovernancePolicy).NotificationPolicy = n.GetObjectValue<GovernanceNotificationPolicy>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<GovernanceCriteria>("decisionMakerCriteria", DecisionMakerCriteria);
            writer.WriteObjectValue<GovernanceNotificationPolicy>("notificationPolicy", NotificationPolicy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
