using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.RecordAllDecisions {
    public class RecordAllDecisionsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Decision { get; set; }
        public string Justification { get; set; }
        public string PrincipalId { get; set; }
        public string ResourceId { get; set; }
        /// <summary>
        /// Instantiates a new recordAllDecisionsRequestBody and sets the default values.
        /// </summary>
        public RecordAllDecisionsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"decision", (o,n) => { (o as RecordAllDecisionsRequestBody).Decision = n.GetStringValue(); } },
                {"justification", (o,n) => { (o as RecordAllDecisionsRequestBody).Justification = n.GetStringValue(); } },
                {"principalId", (o,n) => { (o as RecordAllDecisionsRequestBody).PrincipalId = n.GetStringValue(); } },
                {"resourceId", (o,n) => { (o as RecordAllDecisionsRequestBody).ResourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("decision", Decision);
            writer.WriteStringValue("justification", Justification);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
