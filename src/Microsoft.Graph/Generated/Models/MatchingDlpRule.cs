using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MatchingDlpRule : IAdditionalDataHolder, IParsable {
        /// <summary>The actions property</summary>
        public List<DlpActionInfo> Actions { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The isMostRestrictive property</summary>
        public bool? IsMostRestrictive { get; set; }
        /// <summary>The policyId property</summary>
        public string PolicyId { get; set; }
        /// <summary>The policyName property</summary>
        public string PolicyName { get; set; }
        /// <summary>The priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The ruleId property</summary>
        public string RuleId { get; set; }
        /// <summary>The ruleMode property</summary>
        public Microsoft.Graph.Beta.Models.RuleMode? RuleMode { get; set; }
        /// <summary>The ruleName property</summary>
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actions", n => { Actions = n.GetCollectionOfObjectValues<DlpActionInfo>(DlpActionInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"isMostRestrictive", n => { IsMostRestrictive = n.GetBoolValue(); } },
                {"policyId", n => { PolicyId = n.GetStringValue(); } },
                {"policyName", n => { PolicyName = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"ruleId", n => { RuleId = n.GetStringValue(); } },
                {"ruleMode", n => { RuleMode = n.GetEnumValue<RuleMode>(); } },
                {"ruleName", n => { RuleName = n.GetStringValue(); } },
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
