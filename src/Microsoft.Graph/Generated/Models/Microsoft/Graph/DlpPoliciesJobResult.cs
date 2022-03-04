using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DlpPoliciesJobResult : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string AuditCorrelationId { get; set; }
        public DateTimeOffset? EvaluationDateTime { get; set; }
        public List<MatchingDlpRule> MatchingRules { get; set; }
        /// <summary>
        /// Instantiates a new dlpPoliciesJobResult and sets the default values.
        /// </summary>
        public DlpPoliciesJobResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DlpPoliciesJobResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DlpPoliciesJobResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"auditCorrelationId", (o,n) => { (o as DlpPoliciesJobResult).AuditCorrelationId = n.GetStringValue(); } },
                {"evaluationDateTime", (o,n) => { (o as DlpPoliciesJobResult).EvaluationDateTime = n.GetDateTimeOffsetValue(); } },
                {"matchingRules", (o,n) => { (o as DlpPoliciesJobResult).MatchingRules = n.GetCollectionOfObjectValues<MatchingDlpRule>(MatchingDlpRule.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("auditCorrelationId", AuditCorrelationId);
            writer.WriteDateTimeOffsetValue("evaluationDateTime", EvaluationDateTime);
            writer.WriteCollectionOfObjectValues<MatchingDlpRule>("matchingRules", MatchingRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
