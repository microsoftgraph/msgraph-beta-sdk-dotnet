using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ApprovalWorkflowProvider : Entity, IParsable {
        public List<BusinessFlow> BusinessFlows { get; set; }
        public List<BusinessFlow> BusinessFlowsWithRequestsAwaitingMyDecision { get; set; }
        public string DisplayName { get; set; }
        public List<GovernancePolicyTemplate> PolicyTemplates { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"businessFlows", (o,n) => { (o as ApprovalWorkflowProvider).BusinessFlows = n.GetCollectionOfObjectValues<BusinessFlow>().ToList(); } },
                {"businessFlowsWithRequestsAwaitingMyDecision", (o,n) => { (o as ApprovalWorkflowProvider).BusinessFlowsWithRequestsAwaitingMyDecision = n.GetCollectionOfObjectValues<BusinessFlow>().ToList(); } },
                {"displayName", (o,n) => { (o as ApprovalWorkflowProvider).DisplayName = n.GetStringValue(); } },
                {"policyTemplates", (o,n) => { (o as ApprovalWorkflowProvider).PolicyTemplates = n.GetCollectionOfObjectValues<GovernancePolicyTemplate>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<BusinessFlow>("businessFlows", BusinessFlows);
            writer.WriteCollectionOfObjectValues<BusinessFlow>("businessFlowsWithRequestsAwaitingMyDecision", BusinessFlowsWithRequestsAwaitingMyDecision);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<GovernancePolicyTemplate>("policyTemplates", PolicyTemplates);
        }
    }
}
