using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class OutlookTask : OutlookItem, IParsable {
        /// <summary>The name of the person who has been assigned the task in Outlook. Read-only.</summary>
        public string AssignedTo { get; set; }
        /// <summary>The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.  Read-only. Nullable.</summary>
        public List<Attachment> Attachments { get; set; }
        /// <summary>The task body that typically contains information about the task. Note that only HTML type is supported.</summary>
        public ItemBody Body { get; set; }
        /// <summary>The date in the specified time zone that the task was finished.</summary>
        public DateTimeTimeZone CompletedDateTime { get; set; }
        /// <summary>The date in the specified time zone that the task is to be finished.</summary>
        public DateTimeTimeZone DueDateTime { get; set; }
        /// <summary>Set to true if the task has attachments.</summary>
        public bool? HasAttachments { get; set; }
        public Importance? Importance { get; set; }
        public bool? IsReminderOn { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the task. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        public string Owner { get; set; }
        public string ParentFolderId { get; set; }
        public PatternedRecurrence Recurrence { get; set; }
        public DateTimeTimeZone ReminderDateTime { get; set; }
        public Sensitivity? Sensitivity { get; set; }
        /// <summary>The collection of single-value extended properties defined for the task. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        public DateTimeTimeZone StartDateTime { get; set; }
        public TaskStatus? Status { get; set; }
        public string Subject { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignedTo", (o,n) => { (o as OutlookTask).AssignedTo = n.GetStringValue(); } },
                {"attachments", (o,n) => { (o as OutlookTask).Attachments = n.GetCollectionOfObjectValues<Attachment>().ToList(); } },
                {"body", (o,n) => { (o as OutlookTask).Body = n.GetObjectValue<ItemBody>(); } },
                {"completedDateTime", (o,n) => { (o as OutlookTask).CompletedDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"dueDateTime", (o,n) => { (o as OutlookTask).DueDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"hasAttachments", (o,n) => { (o as OutlookTask).HasAttachments = n.GetBoolValue(); } },
                {"importance", (o,n) => { (o as OutlookTask).Importance = n.GetEnumValue<Importance>(); } },
                {"isReminderOn", (o,n) => { (o as OutlookTask).IsReminderOn = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as OutlookTask).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>().ToList(); } },
                {"owner", (o,n) => { (o as OutlookTask).Owner = n.GetStringValue(); } },
                {"parentFolderId", (o,n) => { (o as OutlookTask).ParentFolderId = n.GetStringValue(); } },
                {"recurrence", (o,n) => { (o as OutlookTask).Recurrence = n.GetObjectValue<PatternedRecurrence>(); } },
                {"reminderDateTime", (o,n) => { (o as OutlookTask).ReminderDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"sensitivity", (o,n) => { (o as OutlookTask).Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as OutlookTask).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>().ToList(); } },
                {"startDateTime", (o,n) => { (o as OutlookTask).StartDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"status", (o,n) => { (o as OutlookTask).Status = n.GetEnumValue<TaskStatus>(); } },
                {"subject", (o,n) => { (o as OutlookTask).Subject = n.GetStringValue(); } },
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
