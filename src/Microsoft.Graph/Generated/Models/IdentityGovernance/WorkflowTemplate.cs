using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class WorkflowTemplate : Entity, IParsable {
        /// <summary>The category property</summary>
        public LifecycleWorkflowCategory? Category {
            get { return BackingStore?.Get<LifecycleWorkflowCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The description of the workflowTemplate.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name of the workflowTemplate. Supports  orderby.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Conditions describing when to execute the workflow and the criteria to identify in-scope subject set.</summary>
        public WorkflowExecutionConditions ExecutionConditions {
            get { return BackingStore?.Get<WorkflowExecutionConditions>("executionConditions"); }
            set { BackingStore?.Set("executionConditions", value); }
        }
        /// <summary>Represents the configured tasks to execute and their execution sequence within a workflow. This relationship is expanded by default.</summary>
        public List<TaskObject> Tasks {
            get { return BackingStore?.Get<List<TaskObject>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
        /// <summary>
        /// Instantiates a new workflowTemplate and sets the default values.
        /// </summary>
        public WorkflowTemplate() : base() {
            OdataType = "#microsoft.graph.identityGovernance.workflowTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkflowTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetEnumValue<LifecycleWorkflowCategory>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"executionConditions", n => { ExecutionConditions = n.GetObjectValue<WorkflowExecutionConditions>(WorkflowExecutionConditions.CreateFromDiscriminatorValue); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<TaskObject>(TaskObject.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<LifecycleWorkflowCategory>("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<WorkflowExecutionConditions>("executionConditions", ExecutionConditions);
            writer.WriteCollectionOfObjectValues<TaskObject>("tasks", Tasks);
        }
    }
}
