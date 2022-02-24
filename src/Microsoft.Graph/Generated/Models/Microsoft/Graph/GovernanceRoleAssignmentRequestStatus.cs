using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GovernanceRoleAssignmentRequestStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Status { get; set; }
        public List<KeyValue> StatusDetails { get; set; }
        public string SubStatus { get; set; }
        /// <summary>
        /// Instantiates a new governanceRoleAssignmentRequestStatus and sets the default values.
        /// </summary>
        public GovernanceRoleAssignmentRequestStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"status", (o,n) => { (o as GovernanceRoleAssignmentRequestStatus).Status = n.GetStringValue(); } },
                {"statusDetails", (o,n) => { (o as GovernanceRoleAssignmentRequestStatus).StatusDetails = n.GetCollectionOfObjectValues<KeyValue>().ToList(); } },
                {"subStatus", (o,n) => { (o as GovernanceRoleAssignmentRequestStatus).SubStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("status", Status);
            writer.WriteCollectionOfObjectValues<KeyValue>("statusDetails", StatusDetails);
            writer.WriteStringValue("subStatus", SubStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
