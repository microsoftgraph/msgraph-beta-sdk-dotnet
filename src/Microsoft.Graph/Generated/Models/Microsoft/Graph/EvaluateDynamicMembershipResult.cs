using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the evaluateDynamicMembership method.</summary>
    public class EvaluateDynamicMembershipResult : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If a group ID is provided, the value is the membership rule for the group. If a group ID is not provided, the value is the membership rule that was provided as a parameter. For more information, see Dynamic membership rules for groups in Azure Active Directory.</summary>
        public string MembershipRule { get; set; }
        /// <summary>Provides a detailed anaylsis of the membership evaluation result.</summary>
        public ExpressionEvaluationDetails MembershipRuleEvaluationDetails { get; set; }
        /// <summary>The value is true if the user or device is a member of the group. The value can also be true if a membership rule was provided and the user or device passes the rule evaluation; otherwise false.</summary>
        public bool? MembershipRuleEvaluationResult { get; set; }
        /// <summary>
        /// Instantiates a new evaluateDynamicMembershipResult and sets the default values.
        /// </summary>
        public EvaluateDynamicMembershipResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateDynamicMembershipResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateDynamicMembershipResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"membershipRule", (o,n) => { (o as EvaluateDynamicMembershipResult).MembershipRule = n.GetStringValue(); } },
                {"membershipRuleEvaluationDetails", (o,n) => { (o as EvaluateDynamicMembershipResult).MembershipRuleEvaluationDetails = n.GetObjectValue<ExpressionEvaluationDetails>(ExpressionEvaluationDetails.CreateFromDiscriminatorValue); } },
                {"membershipRuleEvaluationResult", (o,n) => { (o as EvaluateDynamicMembershipResult).MembershipRuleEvaluationResult = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("membershipRule", MembershipRule);
            writer.WriteObjectValue<ExpressionEvaluationDetails>("membershipRuleEvaluationDetails", MembershipRuleEvaluationDetails);
            writer.WriteBoolValue("membershipRuleEvaluationResult", MembershipRuleEvaluationResult);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
