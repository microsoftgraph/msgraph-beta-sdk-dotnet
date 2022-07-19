using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OutlookTask : OutlookItem, IParsable {
        /// <summary>The name of the person who has been assigned the task in Outlook. Read-only.</summary>
        public string AssignedTo {
            get { return BackingStore?.Get<string>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
        /// <summary>The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.  Read-only. Nullable.</summary>
        public List<Attachment> Attachments {
            get { return BackingStore?.Get<List<Attachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
        /// <summary>The task body that typically contains information about the task. Note that only HTML type is supported.</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
        /// <summary>The date in the specified time zone that the task was finished.</summary>
        public DateTimeTimeZone CompletedDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The date in the specified time zone that the task is to be finished.</summary>
        public DateTimeTimeZone DueDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
        /// <summary>Set to true if the task has attachments.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>The importance property</summary>
        public Microsoft.Graph.Beta.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Importance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>The isReminderOn property</summary>
        public bool? IsReminderOn {
            get { return BackingStore?.Get<bool?>("isReminderOn"); }
            set { BackingStore?.Set("isReminderOn", value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the task. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
        /// <summary>The owner property</summary>
        public string Owner {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
        /// <summary>The parentFolderId property</summary>
        public string ParentFolderId {
            get { return BackingStore?.Get<string>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
        /// <summary>The recurrence property</summary>
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
        /// <summary>The reminderDateTime property</summary>
        public DateTimeTimeZone ReminderDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("reminderDateTime"); }
            set { BackingStore?.Set("reminderDateTime", value); }
        }
        /// <summary>The sensitivity property</summary>
        public Microsoft.Graph.Beta.Models.Sensitivity? Sensitivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Sensitivity?>("sensitivity"); }
            set { BackingStore?.Set("sensitivity", value); }
        }
        /// <summary>The collection of single-value extended properties defined for the task. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
        /// <summary>The startDateTime property</summary>
        public DateTimeTimeZone StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The status property</summary>
        public TaskStatus? Status {
            get { return BackingStore?.Get<TaskStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
        /// <summary>
        /// Instantiates a new OutlookTask and sets the default values.
        /// </summary>
        public OutlookTask() : base() {
            OdataType = "#microsoft.graph.outlookTask";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OutlookTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutlookTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue).ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"dueDateTime", n => { DueDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"isReminderOn", n => { IsReminderOn = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderDateTime", n => { ReminderDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"sensitivity", n => { Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<TaskStatus>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteObjectValue<DateTimeTimeZone>("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteObjectValue<DateTimeTimeZone>("reminderDateTime", ReminderDateTime);
            writer.WriteEnumValue<Sensitivity>("sensitivity", Sensitivity);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<TaskStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
