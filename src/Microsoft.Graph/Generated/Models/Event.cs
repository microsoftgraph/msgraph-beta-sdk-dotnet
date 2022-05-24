using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class Event : OutlookItem, IParsable {
        /// <summary>true if the meeting organizer allows invitees to propose a new time when responding; otherwise false. Optional. Default is true.</summary>
        public bool? AllowNewTimeProposals {
            get { return BackingStore?.Get<bool?>(nameof(AllowNewTimeProposals)); }
            set { BackingStore?.Set(nameof(AllowNewTimeProposals), value); }
        }
        /// <summary>The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.</summary>
        public List<Attachment> Attachments {
            get { return BackingStore?.Get<List<Attachment>>(nameof(Attachments)); }
            set { BackingStore?.Set(nameof(Attachments), value); }
        }
        /// <summary>The collection of attendees for the event.</summary>
        public List<Attendee> Attendees {
            get { return BackingStore?.Get<List<Attendee>>(nameof(Attendees)); }
            set { BackingStore?.Set(nameof(Attendees), value); }
        }
        /// <summary>The body of the message associated with the event. It can be in HTML or text format.</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>(nameof(Body)); }
            set { BackingStore?.Set(nameof(Body), value); }
        }
        /// <summary>The preview of the message associated with the event. It is in text format.</summary>
        public string BodyPreview {
            get { return BackingStore?.Get<string>(nameof(BodyPreview)); }
            set { BackingStore?.Set(nameof(BodyPreview), value); }
        }
        /// <summary>The calendar that contains the event. Navigation property. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Calendar Calendar {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Calendar>(nameof(Calendar)); }
            set { BackingStore?.Set(nameof(Calendar), value); }
        }
        /// <summary>Contains occurrenceId property values of cancelled instances in a recurring series, if the event is the series master. Instances in a recurring series that are cancelled are called cancelledOccurences.Returned only on $select in a Get operation which specifies the id of a series master event (that is, the seriesMasterId property value).</summary>
        public List<string> CancelledOccurrences {
            get { return BackingStore?.Get<List<string>>(nameof(CancelledOccurrences)); }
            set { BackingStore?.Set(nameof(CancelledOccurrences), value); }
        }
        /// <summary>The date, time, and time zone that the event ends. By default, the end time is in UTC.</summary>
        public DateTimeTimeZone End {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(End)); }
            set { BackingStore?.Set(nameof(End), value); }
        }
        /// <summary>The exceptionOccurrences property</summary>
        public List<Event> ExceptionOccurrences {
            get { return BackingStore?.Get<List<Event>>(nameof(ExceptionOccurrences)); }
            set { BackingStore?.Set(nameof(ExceptionOccurrences), value); }
        }
        /// <summary>The collection of open extensions defined for the event. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>Set to true if the event has attachments.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>(nameof(HasAttachments)); }
            set { BackingStore?.Set(nameof(HasAttachments), value); }
        }
        /// <summary>When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.</summary>
        public bool? HideAttendees {
            get { return BackingStore?.Get<bool?>(nameof(HideAttendees)); }
            set { BackingStore?.Set(nameof(HideAttendees), value); }
        }
        /// <summary>The importance property</summary>
        public Microsoft.Graph.Beta.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Importance?>(nameof(Importance)); }
            set { BackingStore?.Set(nameof(Importance), value); }
        }
        /// <summary>The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.</summary>
        public List<Event> Instances {
            get { return BackingStore?.Get<List<Event>>(nameof(Instances)); }
            set { BackingStore?.Set(nameof(Instances), value); }
        }
        /// <summary>The isAllDay property</summary>
        public bool? IsAllDay {
            get { return BackingStore?.Get<bool?>(nameof(IsAllDay)); }
            set { BackingStore?.Set(nameof(IsAllDay), value); }
        }
        /// <summary>The isCancelled property</summary>
        public bool? IsCancelled {
            get { return BackingStore?.Get<bool?>(nameof(IsCancelled)); }
            set { BackingStore?.Set(nameof(IsCancelled), value); }
        }
        /// <summary>The isDraft property</summary>
        public bool? IsDraft {
            get { return BackingStore?.Get<bool?>(nameof(IsDraft)); }
            set { BackingStore?.Set(nameof(IsDraft), value); }
        }
        /// <summary>The isOnlineMeeting property</summary>
        public bool? IsOnlineMeeting {
            get { return BackingStore?.Get<bool?>(nameof(IsOnlineMeeting)); }
            set { BackingStore?.Set(nameof(IsOnlineMeeting), value); }
        }
        /// <summary>The isOrganizer property</summary>
        public bool? IsOrganizer {
            get { return BackingStore?.Get<bool?>(nameof(IsOrganizer)); }
            set { BackingStore?.Set(nameof(IsOrganizer), value); }
        }
        /// <summary>The isReminderOn property</summary>
        public bool? IsReminderOn {
            get { return BackingStore?.Get<bool?>(nameof(IsReminderOn)); }
            set { BackingStore?.Set(nameof(IsReminderOn), value); }
        }
        /// <summary>The location property</summary>
        public Microsoft.Graph.Beta.Models.Location Location {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Location>(nameof(Location)); }
            set { BackingStore?.Set(nameof(Location), value); }
        }
        /// <summary>The locations property</summary>
        public List<Microsoft.Graph.Beta.Models.Location> Locations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Location>>(nameof(Locations)); }
            set { BackingStore?.Set(nameof(Locations), value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>(nameof(MultiValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(MultiValueExtendedProperties), value); }
        }
        /// <summary>The occurrenceId property</summary>
        public string OccurrenceId {
            get { return BackingStore?.Get<string>(nameof(OccurrenceId)); }
            set { BackingStore?.Set(nameof(OccurrenceId), value); }
        }
        /// <summary>The onlineMeeting property</summary>
        public OnlineMeetingInfo OnlineMeeting {
            get { return BackingStore?.Get<OnlineMeetingInfo>(nameof(OnlineMeeting)); }
            set { BackingStore?.Set(nameof(OnlineMeeting), value); }
        }
        /// <summary>The onlineMeetingProvider property</summary>
        public OnlineMeetingProviderType? OnlineMeetingProvider {
            get { return BackingStore?.Get<OnlineMeetingProviderType?>(nameof(OnlineMeetingProvider)); }
            set { BackingStore?.Set(nameof(OnlineMeetingProvider), value); }
        }
        /// <summary>The onlineMeetingUrl property</summary>
        public string OnlineMeetingUrl {
            get { return BackingStore?.Get<string>(nameof(OnlineMeetingUrl)); }
            set { BackingStore?.Set(nameof(OnlineMeetingUrl), value); }
        }
        /// <summary>The organizer property</summary>
        public Recipient Organizer {
            get { return BackingStore?.Get<Recipient>(nameof(Organizer)); }
            set { BackingStore?.Set(nameof(Organizer), value); }
        }
        /// <summary>The originalEndTimeZone property</summary>
        public string OriginalEndTimeZone {
            get { return BackingStore?.Get<string>(nameof(OriginalEndTimeZone)); }
            set { BackingStore?.Set(nameof(OriginalEndTimeZone), value); }
        }
        /// <summary>The originalStart property</summary>
        public DateTimeOffset? OriginalStart {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(OriginalStart)); }
            set { BackingStore?.Set(nameof(OriginalStart), value); }
        }
        /// <summary>The originalStartTimeZone property</summary>
        public string OriginalStartTimeZone {
            get { return BackingStore?.Get<string>(nameof(OriginalStartTimeZone)); }
            set { BackingStore?.Set(nameof(OriginalStartTimeZone), value); }
        }
        /// <summary>The recurrence property</summary>
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>(nameof(Recurrence)); }
            set { BackingStore?.Set(nameof(Recurrence), value); }
        }
        /// <summary>The reminderMinutesBeforeStart property</summary>
        public int? ReminderMinutesBeforeStart {
            get { return BackingStore?.Get<int?>(nameof(ReminderMinutesBeforeStart)); }
            set { BackingStore?.Set(nameof(ReminderMinutesBeforeStart), value); }
        }
        /// <summary>The responseRequested property</summary>
        public bool? ResponseRequested {
            get { return BackingStore?.Get<bool?>(nameof(ResponseRequested)); }
            set { BackingStore?.Set(nameof(ResponseRequested), value); }
        }
        /// <summary>The responseStatus property</summary>
        public Microsoft.Graph.Beta.Models.ResponseStatus ResponseStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResponseStatus>(nameof(ResponseStatus)); }
            set { BackingStore?.Set(nameof(ResponseStatus), value); }
        }
        /// <summary>The sensitivity property</summary>
        public Microsoft.Graph.Beta.Models.Sensitivity? Sensitivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Sensitivity?>(nameof(Sensitivity)); }
            set { BackingStore?.Set(nameof(Sensitivity), value); }
        }
        /// <summary>The seriesMasterId property</summary>
        public string SeriesMasterId {
            get { return BackingStore?.Get<string>(nameof(SeriesMasterId)); }
            set { BackingStore?.Set(nameof(SeriesMasterId), value); }
        }
        /// <summary>The showAs property</summary>
        public FreeBusyStatus? ShowAs {
            get { return BackingStore?.Get<FreeBusyStatus?>(nameof(ShowAs)); }
            set { BackingStore?.Set(nameof(ShowAs), value); }
        }
        /// <summary>The collection of single-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>(nameof(SingleValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(SingleValueExtendedProperties), value); }
        }
        /// <summary>The start property</summary>
        public DateTimeTimeZone Start {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(Start)); }
            set { BackingStore?.Set(nameof(Start), value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>(nameof(Subject)); }
            set { BackingStore?.Set(nameof(Subject), value); }
        }
        /// <summary>The transactionId property</summary>
        public string TransactionId {
            get { return BackingStore?.Get<string>(nameof(TransactionId)); }
            set { BackingStore?.Set(nameof(TransactionId), value); }
        }
        /// <summary>The type property</summary>
        public EventType? Type {
            get { return BackingStore?.Get<EventType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>The uid property</summary>
        public string Uid {
            get { return BackingStore?.Get<string>(nameof(Uid)); }
            set { BackingStore?.Set(nameof(Uid), value); }
        }
        /// <summary>The webLink property</summary>
        public string WebLink {
            get { return BackingStore?.Get<string>(nameof(WebLink)); }
            set { BackingStore?.Set(nameof(WebLink), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowNewTimeProposals", n => { AllowNewTimeProposals = n.GetBoolValue(); } },
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue).ToList(); } },
                {"attendees", n => { Attendees = n.GetCollectionOfObjectValues<Attendee>(Attendee.CreateFromDiscriminatorValue).ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", n => { BodyPreview = n.GetStringValue(); } },
                {"calendar", n => { Calendar = n.GetObjectValue<Microsoft.Graph.Beta.Models.Calendar>(Microsoft.Graph.Beta.Models.Calendar.CreateFromDiscriminatorValue); } },
                {"cancelledOccurrences", n => { CancelledOccurrences = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"end", n => { End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"exceptionOccurrences", n => { ExceptionOccurrences = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"hideAttendees", n => { HideAttendees = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"instances", n => { Instances = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"isAllDay", n => { IsAllDay = n.GetBoolValue(); } },
                {"isCancelled", n => { IsCancelled = n.GetBoolValue(); } },
                {"isDraft", n => { IsDraft = n.GetBoolValue(); } },
                {"isOnlineMeeting", n => { IsOnlineMeeting = n.GetBoolValue(); } },
                {"isOrganizer", n => { IsOrganizer = n.GetBoolValue(); } },
                {"isReminderOn", n => { IsReminderOn = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<Microsoft.Graph.Beta.Models.Location>(Microsoft.Graph.Beta.Models.Location.CreateFromDiscriminatorValue); } },
                {"locations", n => { Locations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Location>(Microsoft.Graph.Beta.Models.Location.CreateFromDiscriminatorValue).ToList(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"occurrenceId", n => { OccurrenceId = n.GetStringValue(); } },
                {"onlineMeeting", n => { OnlineMeeting = n.GetObjectValue<OnlineMeetingInfo>(OnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                {"onlineMeetingProvider", n => { OnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"onlineMeetingUrl", n => { OnlineMeetingUrl = n.GetStringValue(); } },
                {"organizer", n => { Organizer = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"originalEndTimeZone", n => { OriginalEndTimeZone = n.GetStringValue(); } },
                {"originalStart", n => { OriginalStart = n.GetDateTimeOffsetValue(); } },
                {"originalStartTimeZone", n => { OriginalStartTimeZone = n.GetStringValue(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderMinutesBeforeStart", n => { ReminderMinutesBeforeStart = n.GetIntValue(); } },
                {"responseRequested", n => { ResponseRequested = n.GetBoolValue(); } },
                {"responseStatus", n => { ResponseStatus = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResponseStatus>(Microsoft.Graph.Beta.Models.ResponseStatus.CreateFromDiscriminatorValue); } },
                {"sensitivity", n => { Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"seriesMasterId", n => { SeriesMasterId = n.GetStringValue(); } },
                {"showAs", n => { ShowAs = n.GetEnumValue<FreeBusyStatus>(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"start", n => { Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"transactionId", n => { TransactionId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<EventType>(); } },
                {"uid", n => { Uid = n.GetStringValue(); } },
                {"webLink", n => { WebLink = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Calendar>("calendar", Calendar);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Location>("location", Location);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Location>("locations", Locations);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ResponseStatus>("responseStatus", ResponseStatus);
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
