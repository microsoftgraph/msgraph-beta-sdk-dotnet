using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class BaseTask : Entity, IParsable {
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.</summary>
        public DateTimeOffset? BodyLastModifiedDateTime { get; set; }
        /// <summary>A collection of checklistItems linked to a task.</summary>
        public List<ChecklistItem> ChecklistItems { get; set; }
        /// <summary>The date when the task was finished.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>The date and time when the task was created. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The name of the task.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date in the specified time zone that the task is to be finished.</summary>
        public DateTimeTimeZone DueDateTime { get; set; }
        /// <summary>The collection of open extensions defined for the task .</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>The importance of the task. Possible values are: low, normal, high.  The possible values are: low, normal, high.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Importance? Importance { get; set; }
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>A collection of resources linked to the task.</summary>
        public List<LinkedResource_v2> LinkedResources { get; set; }
        /// <summary>The list which contains the task.</summary>
        public BaseTaskList ParentList { get; set; }
        /// <summary>The recurrence pattern for the task.</summary>
        public PatternedRecurrence Recurrence { get; set; }
        /// <summary>The date in the specified time zone when the task is to begin.</summary>
        public DateTimeTimeZone StartDateTime { get; set; }
        /// <summary>Indicates the state or progress of the task. Possible values are: notStarted, inProgress, completed,unknownFutureValue.</summary>
        public TaskStatus_v2? Status { get; set; }
        /// <summary>The task body in text format that typically contains information about the task.</summary>
        public string TextBody { get; set; }
        public TaskViewpoint Viewpoint { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BaseTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BaseTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bodyLastModifiedDateTime", (o,n) => { (o as BaseTask).BodyLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"checklistItems", (o,n) => { (o as BaseTask).ChecklistItems = n.GetCollectionOfObjectValues<ChecklistItem>(ChecklistItem.CreateFromDiscriminatorValue).ToList(); } },
                {"completedDateTime", (o,n) => { (o as BaseTask).CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", (o,n) => { (o as BaseTask).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as BaseTask).DisplayName = n.GetStringValue(); } },
                {"dueDateTime", (o,n) => { (o as BaseTask).DueDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"extensions", (o,n) => { (o as BaseTask).Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"importance", (o,n) => { (o as BaseTask).Importance = n.GetEnumValue<Importance>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as BaseTask).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"linkedResources", (o,n) => { (o as BaseTask).LinkedResources = n.GetCollectionOfObjectValues<LinkedResource_v2>(LinkedResource_v2.CreateFromDiscriminatorValue).ToList(); } },
                {"parentList", (o,n) => { (o as BaseTask).ParentList = n.GetObjectValue<BaseTaskList>(BaseTaskList.CreateFromDiscriminatorValue); } },
                {"recurrence", (o,n) => { (o as BaseTask).Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"startDateTime", (o,n) => { (o as BaseTask).StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as BaseTask).Status = n.GetEnumValue<TaskStatus_v2>(); } },
                {"textBody", (o,n) => { (o as BaseTask).TextBody = n.GetStringValue(); } },
                {"viewpoint", (o,n) => { (o as BaseTask).Viewpoint = n.GetObjectValue<TaskViewpoint>(TaskViewpoint.CreateFromDiscriminatorValue); } },
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
