using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Event : OutlookItem, IParsable {
        /// <summary>true if the meeting organizer allows invitees to propose a new time when responding; otherwise false. Optional. Default is true.</summary>
        public bool? AllowNewTimeProposals {
            get { return BackingStore?.Get<bool?>("allowNewTimeProposals"); }
            set { BackingStore?.Set("allowNewTimeProposals", value); }
        }
        /// <summary>The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Attachment>? Attachments {
            get { return BackingStore?.Get<List<Attachment>?>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#nullable restore
#else
        public List<Attachment> Attachments {
            get { return BackingStore?.Get<List<Attachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#endif
        /// <summary>The collection of attendees for the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Attendee>? Attendees {
            get { return BackingStore?.Get<List<Attendee>?>("attendees"); }
            set { BackingStore?.Set("attendees", value); }
        }
#nullable restore
#else
        public List<Attendee> Attendees {
            get { return BackingStore?.Get<List<Attendee>>("attendees"); }
            set { BackingStore?.Set("attendees", value); }
        }
#endif
        /// <summary>The body of the message associated with the event. It can be in HTML or text format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Body {
            get { return BackingStore?.Get<ItemBody?>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#nullable restore
#else
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#endif
        /// <summary>The preview of the message associated with the event. It is in text format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyPreview {
            get { return BackingStore?.Get<string?>("bodyPreview"); }
            set { BackingStore?.Set("bodyPreview", value); }
        }
#nullable restore
#else
        public string BodyPreview {
            get { return BackingStore?.Get<string>("bodyPreview"); }
            set { BackingStore?.Set("bodyPreview", value); }
        }
#endif
        /// <summary>The calendar that contains the event. Navigation property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Calendar? Calendar {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Calendar?>("calendar"); }
            set { BackingStore?.Set("calendar", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Calendar Calendar {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Calendar>("calendar"); }
            set { BackingStore?.Set("calendar", value); }
        }
#endif
        /// <summary>Contains occurrenceId property values of cancelled instances in a recurring series, if the event is the series master. Instances in a recurring series that are cancelled are called cancelledOccurences.Returned only on $select in a Get operation which specifies the id of a series master event (that is, the seriesMasterId property value).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CancelledOccurrences {
            get { return BackingStore?.Get<List<string>?>("cancelledOccurrences"); }
            set { BackingStore?.Set("cancelledOccurrences", value); }
        }
#nullable restore
#else
        public List<string> CancelledOccurrences {
            get { return BackingStore?.Get<List<string>>("cancelledOccurrences"); }
            set { BackingStore?.Set("cancelledOccurrences", value); }
        }
#endif
        /// <summary>The date, time, and time zone that the event ends. By default, the end time is in UTC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? End {
            get { return BackingStore?.Get<DateTimeTimeZone?>("end"); }
            set { BackingStore?.Set("end", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone End {
            get { return BackingStore?.Get<DateTimeTimeZone>("end"); }
            set { BackingStore?.Set("end", value); }
        }
#endif
        /// <summary>The exceptionOccurrences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? ExceptionOccurrences {
            get { return BackingStore?.Get<List<Event>?>("exceptionOccurrences"); }
            set { BackingStore?.Set("exceptionOccurrences", value); }
        }
#nullable restore
#else
        public List<Event> ExceptionOccurrences {
            get { return BackingStore?.Get<List<Event>>("exceptionOccurrences"); }
            set { BackingStore?.Set("exceptionOccurrences", value); }
        }
#endif
        /// <summary>The collection of open extensions defined for the event. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions {
            get { return BackingStore?.Get<List<Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>Set to true if the event has attachments.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.</summary>
        public bool? HideAttendees {
            get { return BackingStore?.Get<bool?>("hideAttendees"); }
            set { BackingStore?.Set("hideAttendees", value); }
        }
        /// <summary>The importance property</summary>
        public Microsoft.Graph.Beta.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Importance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? Instances {
            get { return BackingStore?.Get<List<Event>?>("instances"); }
            set { BackingStore?.Set("instances", value); }
        }
#nullable restore
#else
        public List<Event> Instances {
            get { return BackingStore?.Get<List<Event>>("instances"); }
            set { BackingStore?.Set("instances", value); }
        }
#endif
        /// <summary>The isAllDay property</summary>
        public bool? IsAllDay {
            get { return BackingStore?.Get<bool?>("isAllDay"); }
            set { BackingStore?.Set("isAllDay", value); }
        }
        /// <summary>The isCancelled property</summary>
        public bool? IsCancelled {
            get { return BackingStore?.Get<bool?>("isCancelled"); }
            set { BackingStore?.Set("isCancelled", value); }
        }
        /// <summary>The isDraft property</summary>
        public bool? IsDraft {
            get { return BackingStore?.Get<bool?>("isDraft"); }
            set { BackingStore?.Set("isDraft", value); }
        }
        /// <summary>The isOnlineMeeting property</summary>
        public bool? IsOnlineMeeting {
            get { return BackingStore?.Get<bool?>("isOnlineMeeting"); }
            set { BackingStore?.Set("isOnlineMeeting", value); }
        }
        /// <summary>The isOrganizer property</summary>
        public bool? IsOrganizer {
            get { return BackingStore?.Get<bool?>("isOrganizer"); }
            set { BackingStore?.Set("isOrganizer", value); }
        }
        /// <summary>The isReminderOn property</summary>
        public bool? IsReminderOn {
            get { return BackingStore?.Get<bool?>("isReminderOn"); }
            set { BackingStore?.Set("isReminderOn", value); }
        }
        /// <summary>The location property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Location? Location {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Location?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Location Location {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Location>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>The locations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Location>? Locations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Location>?>("locations"); }
            set { BackingStore?.Set("locations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Location> Locations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Location>>("locations"); }
            set { BackingStore?.Set("locations", value); }
        }
#endif
        /// <summary>The collection of multi-value extended properties defined for the event. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>The occurrenceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OccurrenceId {
            get { return BackingStore?.Get<string?>("occurrenceId"); }
            set { BackingStore?.Set("occurrenceId", value); }
        }
#nullable restore
#else
        public string OccurrenceId {
            get { return BackingStore?.Get<string>("occurrenceId"); }
            set { BackingStore?.Set("occurrenceId", value); }
        }
#endif
        /// <summary>The onlineMeeting property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnlineMeetingInfo? OnlineMeeting {
            get { return BackingStore?.Get<OnlineMeetingInfo?>("onlineMeeting"); }
            set { BackingStore?.Set("onlineMeeting", value); }
        }
#nullable restore
#else
        public OnlineMeetingInfo OnlineMeeting {
            get { return BackingStore?.Get<OnlineMeetingInfo>("onlineMeeting"); }
            set { BackingStore?.Set("onlineMeeting", value); }
        }
#endif
        /// <summary>The onlineMeetingProvider property</summary>
        public OnlineMeetingProviderType? OnlineMeetingProvider {
            get { return BackingStore?.Get<OnlineMeetingProviderType?>("onlineMeetingProvider"); }
            set { BackingStore?.Set("onlineMeetingProvider", value); }
        }
        /// <summary>The onlineMeetingUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineMeetingUrl {
            get { return BackingStore?.Get<string?>("onlineMeetingUrl"); }
            set { BackingStore?.Set("onlineMeetingUrl", value); }
        }
#nullable restore
#else
        public string OnlineMeetingUrl {
            get { return BackingStore?.Get<string>("onlineMeetingUrl"); }
            set { BackingStore?.Set("onlineMeetingUrl", value); }
        }
#endif
        /// <summary>The organizer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Recipient? Organizer {
            get { return BackingStore?.Get<Recipient?>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#nullable restore
#else
        public Recipient Organizer {
            get { return BackingStore?.Get<Recipient>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#endif
        /// <summary>The originalEndTimeZone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalEndTimeZone {
            get { return BackingStore?.Get<string?>("originalEndTimeZone"); }
            set { BackingStore?.Set("originalEndTimeZone", value); }
        }
#nullable restore
#else
        public string OriginalEndTimeZone {
            get { return BackingStore?.Get<string>("originalEndTimeZone"); }
            set { BackingStore?.Set("originalEndTimeZone", value); }
        }
#endif
        /// <summary>The originalStart property</summary>
        public DateTimeOffset? OriginalStart {
            get { return BackingStore?.Get<DateTimeOffset?>("originalStart"); }
            set { BackingStore?.Set("originalStart", value); }
        }
        /// <summary>The originalStartTimeZone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalStartTimeZone {
            get { return BackingStore?.Get<string?>("originalStartTimeZone"); }
            set { BackingStore?.Set("originalStartTimeZone", value); }
        }
#nullable restore
#else
        public string OriginalStartTimeZone {
            get { return BackingStore?.Get<string>("originalStartTimeZone"); }
            set { BackingStore?.Set("originalStartTimeZone", value); }
        }
#endif
        /// <summary>The recurrence property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PatternedRecurrence? Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence?>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#nullable restore
#else
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#endif
        /// <summary>The reminderMinutesBeforeStart property</summary>
        public int? ReminderMinutesBeforeStart {
            get { return BackingStore?.Get<int?>("reminderMinutesBeforeStart"); }
            set { BackingStore?.Set("reminderMinutesBeforeStart", value); }
        }
        /// <summary>The responseRequested property</summary>
        public bool? ResponseRequested {
            get { return BackingStore?.Get<bool?>("responseRequested"); }
            set { BackingStore?.Set("responseRequested", value); }
        }
        /// <summary>The responseStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ResponseStatus? ResponseStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResponseStatus?>("responseStatus"); }
            set { BackingStore?.Set("responseStatus", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ResponseStatus ResponseStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResponseStatus>("responseStatus"); }
            set { BackingStore?.Set("responseStatus", value); }
        }
#endif
        /// <summary>The sensitivity property</summary>
        public Microsoft.Graph.Beta.Models.Sensitivity? Sensitivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Sensitivity?>("sensitivity"); }
            set { BackingStore?.Set("sensitivity", value); }
        }
        /// <summary>The seriesMasterId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SeriesMasterId {
            get { return BackingStore?.Get<string?>("seriesMasterId"); }
            set { BackingStore?.Set("seriesMasterId", value); }
        }
#nullable restore
#else
        public string SeriesMasterId {
            get { return BackingStore?.Get<string>("seriesMasterId"); }
            set { BackingStore?.Set("seriesMasterId", value); }
        }
#endif
        /// <summary>The showAs property</summary>
        public FreeBusyStatus? ShowAs {
            get { return BackingStore?.Get<FreeBusyStatus?>("showAs"); }
            set { BackingStore?.Set("showAs", value); }
        }
        /// <summary>The collection of single-value extended properties defined for the event. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>The start property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? Start {
            get { return BackingStore?.Get<DateTimeTimeZone?>("start"); }
            set { BackingStore?.Set("start", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone Start {
            get { return BackingStore?.Get<DateTimeTimeZone>("start"); }
            set { BackingStore?.Set("start", value); }
        }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The transactionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionId {
            get { return BackingStore?.Get<string?>("transactionId"); }
            set { BackingStore?.Set("transactionId", value); }
        }
#nullable restore
#else
        public string TransactionId {
            get { return BackingStore?.Get<string>("transactionId"); }
            set { BackingStore?.Set("transactionId", value); }
        }
#endif
        /// <summary>The type property</summary>
        public EventType? Type {
            get { return BackingStore?.Get<EventType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>The uid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uid {
            get { return BackingStore?.Get<string?>("uid"); }
            set { BackingStore?.Set("uid", value); }
        }
#nullable restore
#else
        public string Uid {
            get { return BackingStore?.Get<string>("uid"); }
            set { BackingStore?.Set("uid", value); }
        }
#endif
        /// <summary>The webLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebLink {
            get { return BackingStore?.Get<string?>("webLink"); }
            set { BackingStore?.Set("webLink", value); }
        }
#nullable restore
#else
        public string WebLink {
            get { return BackingStore?.Get<string>("webLink"); }
            set { BackingStore?.Set("webLink", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Event and sets the default values.
        /// </summary>
        public Event() : base() {
            OdataType = "#microsoft.graph.event";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attendees", n => { Attendees = n.GetCollectionOfObjectValues<Attendee>(Attendee.CreateFromDiscriminatorValue)?.ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", n => { BodyPreview = n.GetStringValue(); } },
                {"calendar", n => { Calendar = n.GetObjectValue<Microsoft.Graph.Beta.Models.Calendar>(Microsoft.Graph.Beta.Models.Calendar.CreateFromDiscriminatorValue); } },
                {"cancelledOccurrences", n => { CancelledOccurrences = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"end", n => { End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"exceptionOccurrences", n => { ExceptionOccurrences = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"hideAttendees", n => { HideAttendees = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"instances", n => { Instances = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isAllDay", n => { IsAllDay = n.GetBoolValue(); } },
                {"isCancelled", n => { IsCancelled = n.GetBoolValue(); } },
                {"isDraft", n => { IsDraft = n.GetBoolValue(); } },
                {"isOnlineMeeting", n => { IsOnlineMeeting = n.GetBoolValue(); } },
                {"isOrganizer", n => { IsOrganizer = n.GetBoolValue(); } },
                {"isReminderOn", n => { IsReminderOn = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<Microsoft.Graph.Beta.Models.Location>(Microsoft.Graph.Beta.Models.Location.CreateFromDiscriminatorValue); } },
                {"locations", n => { Locations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Location>(Microsoft.Graph.Beta.Models.Location.CreateFromDiscriminatorValue)?.ToList(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
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
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
