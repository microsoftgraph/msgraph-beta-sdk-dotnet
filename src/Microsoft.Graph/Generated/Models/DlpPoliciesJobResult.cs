using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DlpPoliciesJobResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The auditCorrelationId property</summary>
        public string AuditCorrelationId {
            get { return BackingStore?.Get<string>("auditCorrelationId"); }
            set { BackingStore?.Set("auditCorrelationId", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The evaluationDateTime property</summary>
        public DateTimeOffset? EvaluationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("evaluationDateTime"); }
            set { BackingStore?.Set("evaluationDateTime", value); }
        }
        /// <summary>The matchingRules property</summary>
        public List<MatchingDlpRule> MatchingRules {
            get { return BackingStore?.Get<List<MatchingDlpRule>>("matchingRules"); }
            set { BackingStore?.Set("matchingRules", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new dlpPoliciesJobResult and sets the default values.
        /// </summary>
        public DlpPoliciesJobResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.dlpPoliciesJobResult";
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"auditCorrelationId", n => { AuditCorrelationId = n.GetStringValue(); } },
                {"evaluationDateTime", n => { EvaluationDateTime = n.GetDateTimeOffsetValue(); } },
                {"matchingRules", n => { MatchingRules = n.GetCollectionOfObjectValues<MatchingDlpRule>(MatchingDlpRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
