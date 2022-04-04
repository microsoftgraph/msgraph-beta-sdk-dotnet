using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Event : OutlookItem, IParsable {
        /// <summary>true if the meeting organizer allows invitees to propose a new time when responding; otherwise, false. Optional. Default is true.</summary>
        public bool? AllowNewTimeProposals { get; set; }
        /// <summary>The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.</summary>
        public List<Attachment> Attachments { get; set; }
        /// <summary>The collection of attendees for the event.</summary>
        public List<Attendee> Attendees { get; set; }
        /// <summary>The body of the message associated with the event. It can be in HTML or text format.</summary>
        public ItemBody Body { get; set; }
        /// <summary>The preview of the message associated with the event. It is in text format.</summary>
        public string BodyPreview { get; set; }
        /// <summary>The calendar that contains the event. Navigation property. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Calendar Calendar { get; set; }
        /// <summary>Contains occurrenceId property values of cancelled instances in a recurring series, if the event is the series master. Instances in a recurring series that are cancelled are called cancelledOccurences.Returned only on $select in a Get operation which specifies the id of a series master event (that is, the seriesMasterId property value).</summary>
        public List<string> CancelledOccurrences { get; set; }
        /// <summary>The date, time, and time zone that the event ends. By default, the end time is in UTC.</summary>
        public DateTimeTimeZone End { get; set; }
        /// <summary>The exceptionOccurrences property</summary>
        public List<Event> ExceptionOccurrences { get; set; }
        /// <summary>The collection of open extensions defined for the event. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>Set to true if the event has attachments.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.</summary>
        public bool? HideAttendees { get; set; }
        /// <summary>The importance property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Importance? Importance { get; set; }
        /// <summary>The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.</summary>
        public List<Event> Instances { get; set; }
        /// <summary>The isAllDay property</summary>
        public bool? IsAllDay { get; set; }
        /// <summary>The isCancelled property</summary>
        public bool? IsCancelled { get; set; }
        /// <summary>The isDraft property</summary>
        public bool? IsDraft { get; set; }
        /// <summary>The isOnlineMeeting property</summary>
        public bool? IsOnlineMeeting { get; set; }
        /// <summary>The isOrganizer property</summary>
        public bool? IsOrganizer { get; set; }
        /// <summary>The isReminderOn property</summary>
        public bool? IsReminderOn { get; set; }
        /// <summary>The location property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Location Location { get; set; }
        /// <summary>The locations property</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.Location> Locations { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The occurrenceId property</summary>
        public string OccurrenceId { get; set; }
        /// <summary>The onlineMeeting property</summary>
        public OnlineMeetingInfo OnlineMeeting { get; set; }
        /// <summary>The onlineMeetingProvider property</summary>
        public OnlineMeetingProviderType? OnlineMeetingProvider { get; set; }
        /// <summary>The onlineMeetingUrl property</summary>
        public string OnlineMeetingUrl { get; set; }
        /// <summary>The organizer property</summary>
        public Recipient Organizer { get; set; }
        /// <summary>The originalEndTimeZone property</summary>
        public string OriginalEndTimeZone { get; set; }
        /// <summary>The originalStart property</summary>
        public DateTimeOffset? OriginalStart { get; set; }
        /// <summary>The originalStartTimeZone property</summary>
        public string OriginalStartTimeZone { get; set; }
        /// <summary>The recurrence property</summary>
        public PatternedRecurrence Recurrence { get; set; }
        /// <summary>The reminderMinutesBeforeStart property</summary>
        public int? ReminderMinutesBeforeStart { get; set; }
        /// <summary>The responseRequested property</summary>
        public bool? ResponseRequested { get; set; }
        /// <summary>The responseStatus property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ResponseStatus ResponseStatus { get; set; }
        /// <summary>The sensitivity property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Sensitivity? Sensitivity { get; set; }
        /// <summary>The seriesMasterId property</summary>
        public string SeriesMasterId { get; set; }
        /// <summary>The showAs property</summary>
        public FreeBusyStatus? ShowAs { get; set; }
        /// <summary>The collection of single-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>The start property</summary>
        public DateTimeTimeZone Start { get; set; }
        /// <summary>The subject property</summary>
        public string Subject { get; set; }
        /// <summary>The transactionId property</summary>
        public string TransactionId { get; set; }
        /// <summary>The type property</summary>
        public EventType? Type { get; set; }
        /// <summary>The uid property</summary>
        public string Uid { get; set; }
        /// <summary>The webLink property</summary>
        public string WebLink { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Event CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Event();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowNewTimeProposals", (o,n) => { (o as Event).AllowNewTimeProposals = n.GetBoolValue(); } },
                {"attachments", (o,n) => { (o as Event).Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue).ToList(); } },
                {"attendees", (o,n) => { (o as Event).Attendees = n.GetCollectionOfObjectValues<Attendee>(Attendee.CreateFromDiscriminatorValue).ToList(); } },
                {"body", (o,n) => { (o as Event).Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", (o,n) => { (o as Event).BodyPreview = n.GetStringValue(); } },
                {"calendar", (o,n) => { (o as Event).Calendar = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Calendar>(MicrosoftGraphSdk.Models.Microsoft.Graph.Calendar.CreateFromDiscriminatorValue); } },
                {"cancelledOccurrences", (o,n) => { (o as Event).CancelledOccurrences = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"end", (o,n) => { (o as Event).End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"exceptionOccurrences", (o,n) => { (o as Event).ExceptionOccurrences = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"extensions", (o,n) => { (o as Event).Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"hasAttachments", (o,n) => { (o as Event).HasAttachments = n.GetBoolValue(); } },
                {"hideAttendees", (o,n) => { (o as Event).HideAttendees = n.GetBoolValue(); } },
                {"importance", (o,n) => { (o as Event).Importance = n.GetEnumValue<Importance>(); } },
                {"instances", (o,n) => { (o as Event).Instances = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"isAllDay", (o,n) => { (o as Event).IsAllDay = n.GetBoolValue(); } },
                {"isCancelled", (o,n) => { (o as Event).IsCancelled = n.GetBoolValue(); } },
                {"isDraft", (o,n) => { (o as Event).IsDraft = n.GetBoolValue(); } },
                {"isOnlineMeeting", (o,n) => { (o as Event).IsOnlineMeeting = n.GetBoolValue(); } },
                {"isOrganizer", (o,n) => { (o as Event).IsOrganizer = n.GetBoolValue(); } },
                {"isReminderOn", (o,n) => { (o as Event).IsReminderOn = n.GetBoolValue(); } },
                {"location", (o,n) => { (o as Event).Location = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Location>(MicrosoftGraphSdk.Models.Microsoft.Graph.Location.CreateFromDiscriminatorValue); } },
                {"locations", (o,n) => { (o as Event).Locations = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Location>(MicrosoftGraphSdk.Models.Microsoft.Graph.Location.CreateFromDiscriminatorValue).ToList(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Event).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"occurrenceId", (o,n) => { (o as Event).OccurrenceId = n.GetStringValue(); } },
                {"onlineMeeting", (o,n) => { (o as Event).OnlineMeeting = n.GetObjectValue<OnlineMeetingInfo>(OnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                {"onlineMeetingProvider", (o,n) => { (o as Event).OnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"onlineMeetingUrl", (o,n) => { (o as Event).OnlineMeetingUrl = n.GetStringValue(); } },
                {"organizer", (o,n) => { (o as Event).Organizer = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"originalEndTimeZone", (o,n) => { (o as Event).OriginalEndTimeZone = n.GetStringValue(); } },
                {"originalStart", (o,n) => { (o as Event).OriginalStart = n.GetDateTimeOffsetValue(); } },
                {"originalStartTimeZone", (o,n) => { (o as Event).OriginalStartTimeZone = n.GetStringValue(); } },
                {"recurrence", (o,n) => { (o as Event).Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderMinutesBeforeStart", (o,n) => { (o as Event).ReminderMinutesBeforeStart = n.GetIntValue(); } },
                {"responseRequested", (o,n) => { (o as Event).ResponseRequested = n.GetBoolValue(); } },
                {"responseStatus", (o,n) => { (o as Event).ResponseStatus = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ResponseStatus>(MicrosoftGraphSdk.Models.Microsoft.Graph.ResponseStatus.CreateFromDiscriminatorValue); } },
                {"sensitivity", (o,n) => { (o as Event).Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"seriesMasterId", (o,n) => { (o as Event).SeriesMasterId = n.GetStringValue(); } },
                {"showAs", (o,n) => { (o as Event).ShowAs = n.GetEnumValue<FreeBusyStatus>(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Event).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"start", (o,n) => { (o as Event).Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"subject", (o,n) => { (o as Event).Subject = n.GetStringValue(); } },
                {"transactionId", (o,n) => { (o as Event).TransactionId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Event).Type = n.GetEnumValue<EventType>(); } },
                {"uid", (o,n) => { (o as Event).Uid = n.GetStringValue(); } },
                {"webLink", (o,n) => { (o as Event).WebLink = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowNewTimeProposals", AllowNewTimeProposals);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<Attendee>("attendees", Attendees);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("bodyPreview", BodyPreview);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Calendar>("calendar", Calendar);
            writer.WriteCollectionOfPrimitiveValues<string>("cancelledOccurrences", CancelledOccurrences);
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteCollectionOfObjectValues<Event>("exceptionOccurrences", ExceptionOccurrences);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("hideAttendees", HideAttendees);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteCollectionOfObjectValues<Event>("instances", Instances);
            writer.WriteBoolValue("isAllDay", IsAllDay);
            writer.WriteBoolValue("isCancelled", IsCancelled);
            writer.WriteBoolValue("isDraft", IsDraft);
            writer.WriteBoolValue("isOnlineMeeting", IsOnlineMeeting);
            writer.WriteBoolValue("isOrganizer", IsOrganizer);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Location>("location", Location);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Location>("locations", Locations);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("occurrenceId", OccurrenceId);
            writer.WriteObjectValue<OnlineMeetingInfo>("onlineMeeting", OnlineMeeting);
            writer.WriteEnumValue<OnlineMeetingProviderType>("onlineMeetingProvider", OnlineMeetingProvider);
            writer.WriteStringValue("onlineMeetingUrl", OnlineMeetingUrl);
            writer.WriteObjectValue<Recipient>("organizer", Organizer);
            writer.WriteStringValue("originalEndTimeZone", OriginalEndTimeZone);
            writer.WriteDateTimeOffsetValue("originalStart", OriginalStart);
            writer.WriteStringValue("originalStartTimeZone", OriginalStartTimeZone);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteIntValue("reminderMinutesBeforeStart", ReminderMinutesBeforeStart);
            writer.WriteBoolValue("responseRequested", ResponseRequested);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ResponseStatus>("responseStatus", ResponseStatus);
            writer.WriteEnumValue<Sensitivity>("sensitivity", Sensitivity);
            writer.WriteStringValue("seriesMasterId", SeriesMasterId);
            writer.WriteEnumValue<FreeBusyStatus>("showAs", ShowAs);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("transactionId", TransactionId);
            writer.WriteEnumValue<EventType>("type", Type);
            writer.WriteStringValue("uid", Uid);
            writer.WriteStringValue("webLink", WebLink);
        }
    }
}
