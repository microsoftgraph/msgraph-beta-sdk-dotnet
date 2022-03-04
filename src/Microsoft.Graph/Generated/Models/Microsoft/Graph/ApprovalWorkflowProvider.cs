using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ApprovalWorkflowProvider : Entity, IParsable {
        public List<BusinessFlow> BusinessFlows { get; set; }
        public List<BusinessFlow> BusinessFlowsWithRequestsAwaitingMyDecision { get; set; }
        public string DisplayName { get; set; }
        public List<GovernancePolicyTemplate> PolicyTemplates { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApprovalWorkflowProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApprovalWorkflowProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"businessFlows", (o,n) => { (o as ApprovalWorkflowProvider).BusinessFlows = n.GetCollectionOfObjectValues<BusinessFlow>(BusinessFlow.CreateFromDiscriminatorValue).ToList(); } },
                {"businessFlowsWithRequestsAwaitingMyDecision", (o,n) => { (o as ApprovalWorkflowProvider).BusinessFlowsWithRequestsAwaitingMyDecision = n.GetCollectionOfObjectValues<BusinessFlow>(BusinessFlow.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as ApprovalWorkflowProvider).DisplayName = n.GetStringValue(); } },
                {"policyTemplates", (o,n) => { (o as ApprovalWorkflowProvider).PolicyTemplates = n.GetCollectionOfObjectValues<GovernancePolicyTemplate>(GovernancePolicyTemplate.CreateFromDiscriminatorValue).ToList(); } },
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
