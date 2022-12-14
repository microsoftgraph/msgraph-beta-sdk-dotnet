using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class TaskObject : Entity, IParsable {
        /// <summary>Arguments included within the task.  For guidance to configure this property, see Configure the arguments for built-in Lifecycle Workflow tasks. Required.</summary>
        public List<Microsoft.Graph.Beta.Models.KeyValuePair> Arguments {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValuePair>>("arguments"); }
            set { BackingStore?.Set("arguments", value); }
        }
        /// <summary>The category property</summary>
        public LifecycleTaskCategory? Category {
            get { return BackingStore?.Get<LifecycleTaskCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>A boolean value that specifies whether, if this task fails, the workflow will stop, and subsequent tasks will not run. Optional.</summary>
        public bool? ContinueOnError {
            get { return BackingStore?.Get<bool?>("continueOnError"); }
            set { BackingStore?.Set("continueOnError", value); }
        }
        /// <summary>A string that describes the purpose of the task for administrative use. Optional.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>A unique string that identifies the task. Required.Supports $filter(eq, ne) and orderBy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>An integer that states in what order the task will run in a workflow.Supports $orderby.</summary>
        public int? ExecutionSequence {
            get { return BackingStore?.Get<int?>("executionSequence"); }
            set { BackingStore?.Set("executionSequence", value); }
        }
        /// <summary>A boolean value that denotes whether the task is set to run or not. Optional.Supports $filter(eq, ne) and orderBy.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>A unique template identifier for the task. For more information about the tasks that Lifecycle Workflows currently supports and their unique identifiers, see supported tasks. Required.Supports $filter(eq, ne).</summary>
        public string TaskDefinitionId {
            get { return BackingStore?.Get<string>("taskDefinitionId"); }
            set { BackingStore?.Set("taskDefinitionId", value); }
        }
        /// <summary>The result of processing the task.</summary>
        public List<TaskProcessingResult> TaskProcessingResults {
            get { return BackingStore?.Get<List<TaskProcessingResult>>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TaskObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"arguments", n => { Arguments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>(Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"category", n => { Category = n.GetEnumValue<LifecycleTaskCategory>(); } },
                {"continueOnError", n => { ContinueOnError = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"executionSequence", n => { ExecutionSequence = n.GetIntValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"taskDefinitionId", n => { TaskDefinitionId = n.GetStringValue(); } },
                {"taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<TaskProcessingResult>(TaskProcessingResult.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>("arguments", Arguments);
            writer.WriteEnumValue<LifecycleTaskCategory>("category", Category);
            writer.WriteBoolValue("continueOnError", ContinueOnError);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("executionSequence", ExecutionSequence);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("taskDefinitionId", TaskDefinitionId);
            writer.WriteCollectionOfObjectValues<TaskProcessingResult>("taskProcessingResults", TaskProcessingResults);
        }
    }
}
