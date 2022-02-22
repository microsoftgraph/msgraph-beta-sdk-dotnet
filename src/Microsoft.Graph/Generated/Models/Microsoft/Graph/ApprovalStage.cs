using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ApprovalStage : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days that a request can be pending a response before it is automatically denied.</summary>
        public int? ApprovalStageTimeOutInDays { get; set; }
        /// <summary>If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.</summary>
        public List<UserSet> EscalationApprovers { get; set; }
        /// <summary>If escalation is required, the time a request can be pending a response from a primary approver.</summary>
        public int? EscalationTimeInMinutes { get; set; }
        /// <summary>Indicates whether the approver is required to provide a justification for approving a request.</summary>
        public bool? IsApproverJustificationRequired { get; set; }
        /// <summary>If true, then one or more escalation approvers are configured in this approval stage.</summary>
        public bool? IsEscalationEnabled { get; set; }
        /// <summary>The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.</summary>
        public List<UserSet> PrimaryApprovers { get; set; }
        /// <summary>
        /// Instantiates a new approvalStage and sets the default values.
        /// </summary>
        public ApprovalStage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"approvalStageTimeOutInDays", (o,n) => { (o as ApprovalStage).ApprovalStageTimeOutInDays = n.GetIntValue(); } },
                {"escalationApprovers", (o,n) => { (o as ApprovalStage).EscalationApprovers = n.GetCollectionOfObjectValues<UserSet>().ToList(); } },
                {"escalationTimeInMinutes", (o,n) => { (o as ApprovalStage).EscalationTimeInMinutes = n.GetIntValue(); } },
                {"isApproverJustificationRequired", (o,n) => { (o as ApprovalStage).IsApproverJustificationRequired = n.GetBoolValue(); } },
                {"isEscalationEnabled", (o,n) => { (o as ApprovalStage).IsEscalationEnabled = n.GetBoolValue(); } },
                {"primaryApprovers", (o,n) => { (o as ApprovalStage).PrimaryApprovers = n.GetCollectionOfObjectValues<UserSet>().ToList(); } },
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
