using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of approvalWorkflowProvider entities.</summary>
    public class ApprovalWorkflowProvider : Entity, IParsable {
        /// <summary>The businessFlows property</summary>
        public List<BusinessFlow> BusinessFlows {
            get { return BackingStore?.Get<List<BusinessFlow>>("businessFlows"); }
            set { BackingStore?.Set("businessFlows", value); }
        }
        /// <summary>The businessFlowsWithRequestsAwaitingMyDecision property</summary>
        public List<BusinessFlow> BusinessFlowsWithRequestsAwaitingMyDecision {
            get { return BackingStore?.Get<List<BusinessFlow>>("businessFlowsWithRequestsAwaitingMyDecision"); }
            set { BackingStore?.Set("businessFlowsWithRequestsAwaitingMyDecision", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The policyTemplates property</summary>
        public List<GovernancePolicyTemplate> PolicyTemplates {
            get { return BackingStore?.Get<List<GovernancePolicyTemplate>>("policyTemplates"); }
            set { BackingStore?.Set("policyTemplates", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ApprovalWorkflowProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApprovalWorkflowProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"businessFlows", n => { BusinessFlows = n.GetCollectionOfObjectValues<BusinessFlow>(BusinessFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"businessFlowsWithRequestsAwaitingMyDecision", n => { BusinessFlowsWithRequestsAwaitingMyDecision = n.GetCollectionOfObjectValues<BusinessFlow>(BusinessFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"policyTemplates", n => { PolicyTemplates = n.GetCollectionOfObjectValues<GovernancePolicyTemplate>(GovernancePolicyTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
