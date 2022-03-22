using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MatchingDlpRule : IAdditionalDataHolder, IParsable {
        public List<DlpActionInfo> Actions { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? IsMostRestrictive { get; set; }
        public string PolicyId { get; set; }
        public string PolicyName { get; set; }
        public int? Priority { get; set; }
        public string RuleId { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RuleMode? RuleMode { get; set; }
        public string RuleName { get; set; }
        /// <summary>
        /// Instantiates a new matchingDlpRule and sets the default values.
        /// </summary>
        public MatchingDlpRule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MatchingDlpRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MatchingDlpRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actions", (o,n) => { (o as MatchingDlpRule).Actions = n.GetCollectionOfObjectValues<DlpActionInfo>(DlpActionInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"isMostRestrictive", (o,n) => { (o as MatchingDlpRule).IsMostRestrictive = n.GetBoolValue(); } },
                {"policyId", (o,n) => { (o as MatchingDlpRule).PolicyId = n.GetStringValue(); } },
                {"policyName", (o,n) => { (o as MatchingDlpRule).PolicyName = n.GetStringValue(); } },
                {"priority", (o,n) => { (o as MatchingDlpRule).Priority = n.GetIntValue(); } },
                {"ruleId", (o,n) => { (o as MatchingDlpRule).RuleId = n.GetStringValue(); } },
                {"ruleMode", (o,n) => { (o as MatchingDlpRule).RuleMode = n.GetEnumValue<RuleMode>(); } },
                {"ruleName", (o,n) => { (o as MatchingDlpRule).RuleName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DlpActionInfo>("actions", Actions);
            writer.WriteBoolValue("isMostRestrictive", IsMostRestrictive);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("ruleId", RuleId);
            writer.WriteEnumValue<RuleMode>("ruleMode", RuleMode);
            writer.WriteStringValue("ruleName", RuleName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
