using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class TaskObject : Entity, IParsable {
        /// <summary>The arguments property</summary>
        public List<Microsoft.Graph.Beta.Models.KeyValuePair> Arguments {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValuePair>>("arguments"); }
            set { BackingStore?.Set("arguments", value); }
        }
        /// <summary>The category property</summary>
        public LifecycleTaskCategory? Category {
            get { return BackingStore?.Get<LifecycleTaskCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The continueOnError property</summary>
        public bool? ContinueOnError {
            get { return BackingStore?.Get<bool?>("continueOnError"); }
            set { BackingStore?.Set("continueOnError", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The executionSequence property</summary>
        public int? ExecutionSequence {
            get { return BackingStore?.Get<int?>("executionSequence"); }
            set { BackingStore?.Set("executionSequence", value); }
        }
        /// <summary>The isEnabled property</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>The taskDefinitionId property</summary>
        public string TaskDefinitionId {
            get { return BackingStore?.Get<string>("taskDefinitionId"); }
            set { BackingStore?.Set("taskDefinitionId", value); }
        }
        /// <summary>The taskProcessingResults property</summary>
        public List<TaskProcessingResult> TaskProcessingResults {
            get { return BackingStore?.Get<List<TaskProcessingResult>>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
        /// <summary>
        /// Instantiates a new TaskObject and sets the default values.
        /// </summary>
        public TaskObject() : base() {
            OdataType = "#microsoft.graph.identityGovernance.task";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TaskObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"arguments", n => { Arguments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>(Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"category", n => { Category = n.GetEnumValue<LifecycleTaskCategory>(); } },
                {"continueOnError", n => { ContinueOnError = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"executionSequence", n => { ExecutionSequence = n.GetIntValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"taskDefinitionId", n => { TaskDefinitionId = n.GetStringValue(); } },
                {"taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<TaskProcessingResult>(TaskProcessingResult.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
