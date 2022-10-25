using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class TaskProcessingResult : Entity, IParsable {
        /// <summary>The date time when taskProcessingResult execution ended. Value is null if task execution is still in progress.</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The date time when the taskProcessingResult was created. Supports $filter(lt, gt) and orderBy.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Describes why the taskProcessingResult has failed.</summary>
        public string FailureReason {
            get { return BackingStore?.Get<string>("failureReason"); }
            set { BackingStore?.Set("failureReason", value); }
        }
        /// <summary>The processingStatus property</summary>
        public LifecycleWorkflowProcessingStatus? ProcessingStatus {
            get { return BackingStore?.Get<LifecycleWorkflowProcessingStatus?>("processingStatus"); }
            set { BackingStore?.Set("processingStatus", value); }
        }
        /// <summary>The date time when taskProcessingResult execution started. Value is null if task execution has not yet started. Supports $filter(lt, gt) and orderBy.</summary>
        public DateTimeOffset? StartedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The subject property</summary>
        public Microsoft.Graph.Beta.Models.User Subject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.User>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
        /// <summary>The task property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject TaskObject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>("task"); }
            set { BackingStore?.Set("task", value); }
        }
        /// <summary>
        /// Instantiates a new taskProcessingResult and sets the default values.
        /// </summary>
        public TaskProcessingResult() : base() {
            OdataType = "#microsoft.graph.identityGovernance.taskProcessingResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TaskProcessingResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskProcessingResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"failureReason", n => { FailureReason = n.GetStringValue(); } },
                {"processingStatus", n => { ProcessingStatus = n.GetEnumValue<LifecycleWorkflowProcessingStatus>(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", n => { Subject = n.GetObjectValue<Microsoft.Graph.Beta.Models.User>(Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue); } },
                {"task", n => { TaskObject = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>(Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("failureReason", FailureReason);
            writer.WriteEnumValue<LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.User>("subject", Subject);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>("task", TaskObject);
        }
    }
}
