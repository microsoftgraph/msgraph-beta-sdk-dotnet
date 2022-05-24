using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class PlannerTask : PlannerDelta, IParsable {
        /// <summary>Number of checklist items with value set to false, representing incomplete items.</summary>
        public int? ActiveChecklistItemCount {
            get { return BackingStore?.Get<int?>(nameof(ActiveChecklistItemCount)); }
            set { BackingStore?.Set(nameof(ActiveChecklistItemCount), value); }
        }
        /// <summary>The categories to which the task has been applied. See applied Categories for possible values.</summary>
        public PlannerAppliedCategories AppliedCategories {
            get { return BackingStore?.Get<PlannerAppliedCategories>(nameof(AppliedCategories)); }
            set { BackingStore?.Set(nameof(AppliedCategories), value); }
        }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.</summary>
        public PlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat {
            get { return BackingStore?.Get<PlannerAssignedToTaskBoardTaskFormat>(nameof(AssignedToTaskBoardFormat)); }
            set { BackingStore?.Set(nameof(AssignedToTaskBoardFormat), value); }
        }
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
        public string AssigneePriority {
            get { return BackingStore?.Get<string>(nameof(AssigneePriority)); }
            set { BackingStore?.Set(nameof(AssigneePriority), value); }
        }
        /// <summary>The set of assignees the task is assigned to.</summary>
        public PlannerAssignments Assignments {
            get { return BackingStore?.Get<PlannerAssignments>(nameof(Assignments)); }
            set { BackingStore?.Set(nameof(Assignments), value); }
        }
        /// <summary>Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.</summary>
        public string BucketId {
            get { return BackingStore?.Get<string>(nameof(BucketId)); }
            set { BackingStore?.Set(nameof(BucketId), value); }
        }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by bucket.</summary>
        public PlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat {
            get { return BackingStore?.Get<PlannerBucketTaskBoardTaskFormat>(nameof(BucketTaskBoardFormat)); }
            set { BackingStore?.Set(nameof(BucketTaskBoardFormat), value); }
        }
        /// <summary>Number of checklist items that are present on the task.</summary>
        public int? ChecklistItemCount {
            get { return BackingStore?.Get<int?>(nameof(ChecklistItemCount)); }
            set { BackingStore?.Set(nameof(ChecklistItemCount), value); }
        }
        /// <summary>Identity of the user that completed the task.</summary>
        public IdentitySet CompletedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CompletedBy)); }
            set { BackingStore?.Set(nameof(CompletedBy), value); }
        }
        /// <summary>Read-only. Date and time at which the &apos;percentComplete&apos; of the task is set to &apos;100&apos;. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CompletedDateTime)); }
            set { BackingStore?.Set(nameof(CompletedDateTime), value); }
        }
        /// <summary>Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.</summary>
        public string ConversationThreadId {
            get { return BackingStore?.Get<string>(nameof(ConversationThreadId)); }
            set { BackingStore?.Set(nameof(ConversationThreadId), value); }
        }
        /// <summary>Identity of the user that created the task.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Contains information about the origin of the task.</summary>
        public PlannerTaskCreation CreationSource {
            get { return BackingStore?.Get<PlannerTaskCreation>(nameof(CreationSource)); }
            set { BackingStore?.Set(nameof(CreationSource), value); }
        }
        /// <summary>Read-only. Nullable. Additional details about the task.</summary>
        public PlannerTaskDetails Details {
            get { return BackingStore?.Get<PlannerTaskDetails>(nameof(Details)); }
            set { BackingStore?.Set(nameof(Details), value); }
        }
        /// <summary>Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DueDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DueDateTime)); }
            set { BackingStore?.Set(nameof(DueDateTime), value); }
        }
        /// <summary>Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.</summary>
        public bool? HasDescription {
            get { return BackingStore?.Get<bool?>(nameof(HasDescription)); }
            set { BackingStore?.Set(nameof(HasDescription), value); }
        }
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
        public string OrderHint {
            get { return BackingStore?.Get<string>(nameof(OrderHint)); }
            set { BackingStore?.Set(nameof(OrderHint), value); }
        }
        /// <summary>Percentage of task completion. When set to 100, the task is considered completed.</summary>
        public int? PercentComplete {
            get { return BackingStore?.Get<int?>(nameof(PercentComplete)); }
            set { BackingStore?.Set(nameof(PercentComplete), value); }
        }
        /// <summary>Plan ID to which the task belongs.</summary>
        public string PlanId {
            get { return BackingStore?.Get<string>(nameof(PlanId)); }
            set { BackingStore?.Set(nameof(PlanId), value); }
        }
        /// <summary>This sets the type of preview that shows up on the task. Possible values are: automatic, noPreview, checklist, description, reference.</summary>
        public PlannerPreviewType? PreviewType {
            get { return BackingStore?.Get<PlannerPreviewType?>(nameof(PreviewType)); }
            set { BackingStore?.Set(nameof(PreviewType), value); }
        }
        /// <summary>Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as &apos;urgent&apos;, 2 and 3 and 4 as &apos;important&apos;, 5, 6, and 7 as &apos;medium&apos;, and 8, 9, and 10 as &apos;low&apos;.  Currently, Planner sets the value 1 for &apos;urgent&apos;, 3 for &apos;important&apos;, 5 for &apos;medium&apos;, and 9 for &apos;low&apos;.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>(nameof(Priority)); }
            set { BackingStore?.Set(nameof(Priority), value); }
        }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by progress.</summary>
        public PlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat {
            get { return BackingStore?.Get<PlannerProgressTaskBoardTaskFormat>(nameof(ProgressTaskBoardFormat)); }
            set { BackingStore?.Set(nameof(ProgressTaskBoardFormat), value); }
        }
        /// <summary>Number of external references that exist on the task.</summary>
        public int? ReferenceCount {
            get { return BackingStore?.Get<int?>(nameof(ReferenceCount)); }
            set { BackingStore?.Set(nameof(ReferenceCount), value); }
        }
        /// <summary>Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>Title of the task.</summary>
        public string Title {
            get { return BackingStore?.Get<string>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PlannerTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeChecklistItemCount", n => { ActiveChecklistItemCount = n.GetIntValue(); } },
                {"appliedCategories", n => { AppliedCategories = n.GetObjectValue<PlannerAppliedCategories>(PlannerAppliedCategories.CreateFromDiscriminatorValue); } },
                {"assignedToTaskBoardFormat", n => { AssignedToTaskBoardFormat = n.GetObjectValue<PlannerAssignedToTaskBoardTaskFormat>(PlannerAssignedToTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                {"assigneePriority", n => { AssigneePriority = n.GetStringValue(); } },
                {"assignments", n => { Assignments = n.GetObjectValue<PlannerAssignments>(PlannerAssignments.CreateFromDiscriminatorValue); } },
                {"bucketId", n => { BucketId = n.GetStringValue(); } },
                {"bucketTaskBoardFormat", n => { BucketTaskBoardFormat = n.GetObjectValue<PlannerBucketTaskBoardTaskFormat>(PlannerBucketTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                {"checklistItemCount", n => { ChecklistItemCount = n.GetIntValue(); } },
                {"completedBy", n => { CompletedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"conversationThreadId", n => { ConversationThreadId = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationSource", n => { CreationSource = n.GetObjectValue<PlannerTaskCreation>(PlannerTaskCreation.CreateFromDiscriminatorValue); } },
                {"details", n => { Details = n.GetObjectValue<PlannerTaskDetails>(PlannerTaskDetails.CreateFromDiscriminatorValue); } },
                {"dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                {"hasDescription", n => { HasDescription = n.GetBoolValue(); } },
                {"orderHint", n => { OrderHint = n.GetStringValue(); } },
                {"percentComplete", n => { PercentComplete = n.GetIntValue(); } },
                {"planId", n => { PlanId = n.GetStringValue(); } },
                {"previewType", n => { PreviewType = n.GetEnumValue<PlannerPreviewType>(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"progressTaskBoardFormat", n => { ProgressTaskBoardFormat = n.GetObjectValue<PlannerProgressTaskBoardTaskFormat>(PlannerProgressTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                {"referenceCount", n => { ReferenceCount = n.GetIntValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeChecklistItemCount", ActiveChecklistItemCount);
            writer.WriteObjectValue<PlannerAppliedCategories>("appliedCategories", AppliedCategories);
            writer.WriteObjectValue<PlannerAssignedToTaskBoardTaskFormat>("assignedToTaskBoardFormat", AssignedToTaskBoardFormat);
            writer.WriteStringValue("assigneePriority", AssigneePriority);
            writer.WriteObjectValue<PlannerAssignments>("assignments", Assignments);
            writer.WriteStringValue("bucketId", BucketId);
            writer.WriteObjectValue<PlannerBucketTaskBoardTaskFormat>("bucketTaskBoardFormat", BucketTaskBoardFormat);
            writer.WriteIntValue("checklistItemCount", ChecklistItemCount);
            writer.WriteObjectValue<IdentitySet>("completedBy", CompletedBy);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<PlannerTaskCreation>("creationSource", CreationSource);
            writer.WriteObjectValue<PlannerTaskDetails>("details", Details);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteBoolValue("hasDescription", HasDescription);
            writer.WriteStringValue("orderHint", OrderHint);
            writer.WriteIntValue("percentComplete", PercentComplete);
            writer.WriteStringValue("planId", PlanId);
            writer.WriteEnumValue<PlannerPreviewType>("previewType", PreviewType);
            writer.WriteIntValue("priority", Priority);
            writer.WriteObjectValue<PlannerProgressTaskBoardTaskFormat>("progressTaskBoardFormat", ProgressTaskBoardFormat);
            writer.WriteIntValue("referenceCount", ReferenceCount);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("title", Title);
        }
    }
}
