using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class TodoTask : Entity, IParsable {
        /// <summary>The attachments property</summary>
        public List<AttachmentBase> Attachments {
            get { return BackingStore?.Get<List<AttachmentBase>>(nameof(Attachments)); }
            set { BackingStore?.Set(nameof(Attachments), value); }
        }
        /// <summary>The attachmentSessions property</summary>
        public List<AttachmentSession> AttachmentSessions {
            get { return BackingStore?.Get<List<AttachmentSession>>(nameof(AttachmentSessions)); }
            set { BackingStore?.Set(nameof(AttachmentSessions), value); }
        }
        /// <summary>The task body that typically contains information about the task.</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>(nameof(Body)); }
            set { BackingStore?.Set(nameof(Body), value); }
        }
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? BodyLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(BodyLastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(BodyLastModifiedDateTime), value); }
        }
        /// <summary>The categories associated with the task. Each category corresponds to the displayName property of an outlookCategory that the user has defined.</summary>
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>(nameof(Categories)); }
            set { BackingStore?.Set(nameof(Categories), value); }
        }
        /// <summary>A collection of smaller subtasks linked to the more complex parent task.</summary>
        public List<ChecklistItem> ChecklistItems {
            get { return BackingStore?.Get<List<ChecklistItem>>(nameof(ChecklistItems)); }
            set { BackingStore?.Set(nameof(ChecklistItems), value); }
        }
        /// <summary>The date in the specified time zone that the task was finished.</summary>
        public DateTimeTimeZone CompletedDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(CompletedDateTime)); }
            set { BackingStore?.Set(nameof(CompletedDateTime), value); }
        }
        /// <summary>The date and time when the task was created. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The date in the specified time zone that the task is to be finished.</summary>
        public DateTimeTimeZone DueDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(DueDateTime)); }
            set { BackingStore?.Set(nameof(DueDateTime), value); }
        }
        /// <summary>The collection of open extensions defined for the task. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>The hasAttachments property</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>(nameof(HasAttachments)); }
            set { BackingStore?.Set(nameof(HasAttachments), value); }
        }
        /// <summary>The importance of the task. Possible values are: low, normal, high.</summary>
        public Microsoft.Graph.Beta.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Importance?>(nameof(Importance)); }
            set { BackingStore?.Set(nameof(Importance), value); }
        }
        /// <summary>Set to true if an alert is set to remind the user of the task.</summary>
        public bool? IsReminderOn {
            get { return BackingStore?.Get<bool?>(nameof(IsReminderOn)); }
            set { BackingStore?.Set(nameof(IsReminderOn), value); }
        }
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>A collection of resources linked to the task.</summary>
        public List<LinkedResource> LinkedResources {
            get { return BackingStore?.Get<List<LinkedResource>>(nameof(LinkedResources)); }
            set { BackingStore?.Set(nameof(LinkedResources), value); }
        }
        /// <summary>The recurrence pattern for the task.</summary>
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>(nameof(Recurrence)); }
            set { BackingStore?.Set(nameof(Recurrence), value); }
        }
        /// <summary>The date and time for a reminder alert of the task to occur.</summary>
        public DateTimeTimeZone ReminderDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(ReminderDateTime)); }
            set { BackingStore?.Set(nameof(ReminderDateTime), value); }
        }
        /// <summary>The startDateTime property</summary>
        public DateTimeTimeZone StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>Indicates the state or progress of the task. Possible values are: notStarted, inProgress, completed, waitingOnOthers, deferred.</summary>
        public TaskStatus? Status {
            get { return BackingStore?.Get<TaskStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>A brief description of the task.</summary>
        public string Title {
            get { return BackingStore?.Get<string>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TodoTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TodoTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<AttachmentBase>(AttachmentBase.CreateFromDiscriminatorValue).ToList(); } },
                {"attachmentSessions", n => { AttachmentSessions = n.GetCollectionOfObjectValues<AttachmentSession>(AttachmentSession.CreateFromDiscriminatorValue).ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyLastModifiedDateTime", n => { BodyLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"checklistItems", n => { ChecklistItems = n.GetCollectionOfObjectValues<ChecklistItem>(ChecklistItem.CreateFromDiscriminatorValue).ToList(); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dueDateTime", n => { DueDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"isReminderOn", n => { IsReminderOn = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"linkedResources", n => { LinkedResources = n.GetCollectionOfObjectValues<LinkedResource>(LinkedResource.CreateFromDiscriminatorValue).ToList(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderDateTime", n => { ReminderDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<TaskStatus>(); } },
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
            writer.WriteCollectionOfObjectValues<AttachmentBase>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<AttachmentSession>("attachmentSessions", AttachmentSessions);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteDateTimeOffsetValue("bodyLastModifiedDateTime", BodyLastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfObjectValues<ChecklistItem>("checklistItems", ChecklistItems);
            writer.WriteObjectValue<DateTimeTimeZone>("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LinkedResource>("linkedResources", LinkedResources);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteObjectValue<DateTimeTimeZone>("reminderDateTime", ReminderDateTime);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<TaskStatus>("status", Status);
            writer.WriteStringValue("title", Title);
        }
    }
}
