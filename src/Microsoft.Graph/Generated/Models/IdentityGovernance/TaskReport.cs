using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class TaskReport : Entity, IParsable {
        /// <summary>The date time that the associated run completed. Value is null if the run has not completed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The number of users in the run execution for which the associated task failed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? FailedUsersCount {
            get { return BackingStore?.Get<int?>("failedUsersCount"); }
            set { BackingStore?.Set("failedUsersCount", value); }
        }
        /// <summary>The date and time that the task report was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The processingStatus property</summary>
        public LifecycleWorkflowProcessingStatus? ProcessingStatus {
            get { return BackingStore?.Get<LifecycleWorkflowProcessingStatus?>("processingStatus"); }
            set { BackingStore?.Set("processingStatus", value); }
        }
        /// <summary>The unique identifier of the associated run.</summary>
        public string RunId {
            get { return BackingStore?.Get<string>("runId"); }
            set { BackingStore?.Set("runId", value); }
        }
        /// <summary>The date time that the associated run started. Value is null if the run has not started.</summary>
        public DateTimeOffset? StartedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The number of users in the run execution for which the associated task succeeded.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? SuccessfulUsersCount {
            get { return BackingStore?.Get<int?>("successfulUsersCount"); }
            set { BackingStore?.Set("successfulUsersCount", value); }
        }
        /// <summary>The taskDefinition property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.TaskDefinition TaskDefinition {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskDefinition>("taskDefinition"); }
            set { BackingStore?.Set("taskDefinition", value); }
        }
        /// <summary>The task property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject TaskObject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>("task"); }
            set { BackingStore?.Set("task", value); }
        }
        /// <summary>The related lifecycle workflow taskProcessingResults.</summary>
        public List<TaskProcessingResult> TaskProcessingResults {
            get { return BackingStore?.Get<List<TaskProcessingResult>>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
        /// <summary>The total number of users in the run execution for which the associated task was scheduled to execute.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? TotalUsersCount {
            get { return BackingStore?.Get<int?>("totalUsersCount"); }
            set { BackingStore?.Set("totalUsersCount", value); }
        }
        /// <summary>The number of users in the run execution for which the associated task is queued, in progress, or canceled.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? UnprocessedUsersCount {
            get { return BackingStore?.Get<int?>("unprocessedUsersCount"); }
            set { BackingStore?.Set("unprocessedUsersCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TaskReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"failedUsersCount", n => { FailedUsersCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"processingStatus", n => { ProcessingStatus = n.GetEnumValue<LifecycleWorkflowProcessingStatus>(); } },
                {"runId", n => { RunId = n.GetStringValue(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"successfulUsersCount", n => { SuccessfulUsersCount = n.GetIntValue(); } },
                {"taskDefinition", n => { TaskDefinition = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskDefinition>(Microsoft.Graph.Beta.Models.IdentityGovernance.TaskDefinition.CreateFromDiscriminatorValue); } },
                {"task", n => { TaskObject = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>(Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject.CreateFromDiscriminatorValue); } },
                {"taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<TaskProcessingResult>(TaskProcessingResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totalUsersCount", n => { TotalUsersCount = n.GetIntValue(); } },
                {"unprocessedUsersCount", n => { UnprocessedUsersCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteIntValue("failedUsersCount", FailedUsersCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteEnumValue<LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteStringValue("runId", RunId);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteIntValue("successfulUsersCount", SuccessfulUsersCount);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskDefinition>("taskDefinition", TaskDefinition);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>("task", TaskObject);
            writer.WriteCollectionOfObjectValues<TaskProcessingResult>("taskProcessingResults", TaskProcessingResults);
            writer.WriteIntValue("totalUsersCount", TotalUsersCount);
            writer.WriteIntValue("unprocessedUsersCount", UnprocessedUsersCount);
        }
    }
}
