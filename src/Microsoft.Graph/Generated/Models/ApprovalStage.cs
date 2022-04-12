using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ApprovalStage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days that a request can be pending a response before it is automatically denied.</summary>
        public int? ApprovalStageTimeOutInDays { get; set; }
        /// <summary>If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.  When creating or updating a policy, if there are no escalation approvers, or escalation approvers are not required for the stage, the value of this property should be an empty collection.</summary>
        public List<UserSet> EscalationApprovers { get; set; }
        /// <summary>If escalation is required, the time a request can be pending a response from a primary approver.</summary>
        public int? EscalationTimeInMinutes { get; set; }
        /// <summary>Indicates whether the approver is required to provide a justification for approving a request.</summary>
        public bool? IsApproverJustificationRequired { get; set; }
        /// <summary>If true, then one or more escalation approvers are configured in this approval stage.</summary>
        public bool? IsEscalationEnabled { get; set; }
        /// <summary>The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors. When creating or updating a policy, include at least one userSet in this collection.</summary>
        public List<UserSet> PrimaryApprovers { get; set; }
        /// <summary>
        /// Instantiates a new approvalStage and sets the default values.
        /// </summary>
        public ApprovalStage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApprovalStage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApprovalStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"approvalStageTimeOutInDays", n => { ApprovalStageTimeOutInDays = n.GetIntValue(); } },
                {"escalationApprovers", n => { EscalationApprovers = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue).ToList(); } },
                {"escalationTimeInMinutes", n => { EscalationTimeInMinutes = n.GetIntValue(); } },
                {"isApproverJustificationRequired", n => { IsApproverJustificationRequired = n.GetBoolValue(); } },
                {"isEscalationEnabled", n => { IsEscalationEnabled = n.GetBoolValue(); } },
                {"primaryApprovers", n => { PrimaryApprovers = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("approvalStageTimeOutInDays", ApprovalStageTimeOutInDays);
            writer.WriteCollectionOfObjectValues<UserSet>("escalationApprovers", EscalationApprovers);
            writer.WriteIntValue("escalationTimeInMinutes", EscalationTimeInMinutes);
            writer.WriteBoolValue("isApproverJustificationRequired", IsApproverJustificationRequired);
            writer.WriteBoolValue("isEscalationEnabled", IsEscalationEnabled);
            writer.WriteCollectionOfObjectValues<UserSet>("primaryApprovers", PrimaryApprovers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
