using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class BaseTask : Entity, IParsable {
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? BodyLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("bodyLastModifiedDateTime"); }
            set { BackingStore?.Set("bodyLastModifiedDateTime", value); }
        }
        /// <summary>A collection of smaller subtasks linked to the more complex parent task.</summary>
        public List<ChecklistItem> ChecklistItems {
            get { return BackingStore?.Get<List<ChecklistItem>>("checklistItems"); }
            set { BackingStore?.Set("checklistItems", value); }
        }
        /// <summary>The date when the task was finished.</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The date and time when the task was created. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The name of the task.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The date in the specified time zone that the task is to be finished.</summary>
        public DateTimeTimeZone DueDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
        /// <summary>The collection of open extensions defined for the task .</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
        /// <summary>The importance property</summary>
        public Microsoft.Graph.Beta.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Importance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>A collection of resources linked to the task.</summary>
        public List<LinkedResource_v2> LinkedResources {
            get { return BackingStore?.Get<List<LinkedResource_v2>>("linkedResources"); }
            set { BackingStore?.Set("linkedResources", value); }
        }
        /// <summary>The list which contains the task.</summary>
        public BaseTaskList ParentList {
            get { return BackingStore?.Get<BaseTaskList>("parentList"); }
            set { BackingStore?.Set("parentList", value); }
        }
        /// <summary>The recurrence pattern for the task.</summary>
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
        /// <summary>The date in the specified time zone when the task is to begin.</summary>
        public DateTimeTimeZone StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The status property</summary>
        public TaskStatus_v2? Status {
            get { return BackingStore?.Get<TaskStatus_v2?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The task body in text format that typically contains information about the task.</summary>
        public string TextBody {
            get { return BackingStore?.Get<string>("textBody"); }
            set { BackingStore?.Set("textBody", value); }
        }
        /// <summary>The viewpoint property</summary>
        public TaskViewpoint Viewpoint {
            get { return BackingStore?.Get<TaskViewpoint>("viewpoint"); }
            set { BackingStore?.Set("viewpoint", value); }
        }
        /// <summary>
        /// Instantiates a new baseTask and sets the default values.
        /// </summary>
        public BaseTask() : base() {
            OdataType = "#microsoft.graph.baseTask";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BaseTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.task" => new TaskObject(),
                _ => new BaseTask(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bodyLastModifiedDateTime", n => { BodyLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"checklistItems", n => { ChecklistItems = n.GetCollectionOfObjectValues<ChecklistItem>(ChecklistItem.CreateFromDiscriminatorValue).ToList(); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"dueDateTime", n => { DueDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"linkedResources", n => { LinkedResources = n.GetCollectionOfObjectValues<LinkedResource_v2>(LinkedResource_v2.CreateFromDiscriminatorValue).ToList(); } },
                {"parentList", n => { ParentList = n.GetObjectValue<BaseTaskList>(BaseTaskList.CreateFromDiscriminatorValue); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<TaskStatus_v2>(); } },
                {"textBody", n => { TextBody = n.GetStringValue(); } },
                {"viewpoint", n => { Viewpoint = n.GetObjectValue<TaskViewpoint>(TaskViewpoint.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("bodyLastModifiedDateTime", BodyLastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<ChecklistItem>("checklistItems", ChecklistItems);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LinkedResource_v2>("linkedResources", LinkedResources);
            writer.WriteObjectValue<BaseTaskList>("parentList", ParentList);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<TaskStatus_v2>("status", Status);
            writer.WriteStringValue("textBody", TextBody);
            writer.WriteObjectValue<TaskViewpoint>("viewpoint", Viewpoint);
        }
    }
}
