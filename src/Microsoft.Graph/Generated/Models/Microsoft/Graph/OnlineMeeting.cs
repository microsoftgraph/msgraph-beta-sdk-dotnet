using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OnlineMeeting : Entity, IParsable {
        public AccessLevel? AccessLevel { get; set; }
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        public bool? AllowAttendeeToEnableCamera { get; set; }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        public bool? AllowAttendeeToEnableMic { get; set; }
        /// <summary>Specifies who can be a presenter in a meeting. Possible values are listed in the following table.</summary>
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
        /// <summary>Specifies the mode of meeting chat.</summary>
        public MeetingChatMode? AllowMeetingChat { get; set; }
        /// <summary>Indicates whether Teams reactions are enabled for the meeting.</summary>
        public bool? AllowTeamworkReactions { get; set; }
        /// <summary>The content stream of the alternative recording of a Microsoft Teams live event. Read-only.</summary>
        public byte[] AlternativeRecording { get; set; }
        /// <summary>The attendance reports of an online meeting. Read-only.</summary>
        public List<MeetingAttendanceReport> AttendanceReports { get; set; }
        /// <summary>The content stream of the attendee report of a Microsoft Teams live event. Read-only.</summary>
        public byte[] AttendeeReport { get; set; }
        /// <summary>The phone access (dial-in) information for an online meeting. Read-only.</summary>
        public AudioConferencing AudioConferencing { get; set; }
        /// <summary>Settings related to a live event.</summary>
        public BroadcastMeetingSettings BroadcastSettings { get; set; }
        public DateTimeOffset? CanceledDateTime { get; set; }
        public List<MeetingCapabilities?> Capabilities { get; set; }
        /// <summary>The chat information associated with this online meeting.</summary>
        public ChatInfo ChatInfo { get; set; }
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        public bool? EntryExitAnnouncement { get; set; }
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The external ID. A custom ID. Optional.</summary>
        public string ExternalId { get; set; }
        /// <summary>Indicates if this is a Teams live event.</summary>
        public bool? IsBroadcast { get; set; }
        public bool? IsCancelled { get; set; }
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        public bool? IsEntryExitAnnounced { get; set; }
        /// <summary>The join information in the language and locale variant specified in the Accept-Language request HTTP header. Read-only.</summary>
        public ItemBody JoinInformation { get; set; }
        public JoinMeetingIdSettings JoinMeetingIdSettings { get; set; }
        public string JoinUrl { get; set; }
        /// <summary>Specifies which participants can bypass the meeting   lobby.</summary>
        public LobbyBypassSettings LobbyBypassSettings { get; set; }
        public MeetingAttendanceReport MeetingAttendanceReport { get; set; }
        /// <summary>The participants associated with the online meeting.  This includes the organizer and the attendees.</summary>
        public MeetingParticipants Participants { get; set; }
        /// <summary>Indicates whether to record the meeting automatically.</summary>
        public bool? RecordAutomatically { get; set; }
        /// <summary>The content stream of the recording of a Teams live event. Read-only.</summary>
        public byte[] Recording { get; set; }
        /// <summary>The registration that has been enabled for an online meeting. One online meeting can only have one registration enabled.</summary>
        public MeetingRegistration Registration { get; set; }
        /// <summary>The meeting start time in UTC.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The subject of the online meeting.</summary>
        public string Subject { get; set; }
        /// <summary>The video teleconferencing ID. Read-only.</summary>
        public string VideoTeleconferenceId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessLevel", (o,n) => { (o as OnlineMeeting).AccessLevel = n.GetEnumValue<AccessLevel>(); } },
                {"allowAttendeeToEnableCamera", (o,n) => { (o as OnlineMeeting).AllowAttendeeToEnableCamera = n.GetBoolValue(); } },
                {"allowAttendeeToEnableMic", (o,n) => { (o as OnlineMeeting).AllowAttendeeToEnableMic = n.GetBoolValue(); } },
                {"allowedPresenters", (o,n) => { (o as OnlineMeeting).AllowedPresenters = n.GetEnumValue<OnlineMeetingPresenters>(); } },
                {"allowMeetingChat", (o,n) => { (o as OnlineMeeting).AllowMeetingChat = n.GetEnumValue<MeetingChatMode>(); } },
                {"allowTeamworkReactions", (o,n) => { (o as OnlineMeeting).AllowTeamworkReactions = n.GetBoolValue(); } },
                {"alternativeRecording", (o,n) => { (o as OnlineMeeting).AlternativeRecording = n.GetByteArrayValue(); } },
                {"attendanceReports", (o,n) => { (o as OnlineMeeting).AttendanceReports = n.GetCollectionOfObjectValues<MeetingAttendanceReport>().ToList(); } },
                {"attendeeReport", (o,n) => { (o as OnlineMeeting).AttendeeReport = n.GetByteArrayValue(); } },
                {"audioConferencing", (o,n) => { (o as OnlineMeeting).AudioConferencing = n.GetObjectValue<AudioConferencing>(); } },
                {"broadcastSettings", (o,n) => { (o as OnlineMeeting).BroadcastSettings = n.GetObjectValue<BroadcastMeetingSettings>(); } },
                {"canceledDateTime", (o,n) => { (o as OnlineMeeting).CanceledDateTime = n.GetDateTimeOffsetValue(); } },
                {"capabilities", (o,n) => { (o as OnlineMeeting).Capabilities = n.GetCollectionOfEnumValues<MeetingCapabilities>().ToList(); } },
                {"chatInfo", (o,n) => { (o as OnlineMeeting).ChatInfo = n.GetObjectValue<ChatInfo>(); } },
                {"creationDateTime", (o,n) => { (o as OnlineMeeting).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", (o,n) => { (o as OnlineMeeting).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"entryExitAnnouncement", (o,n) => { (o as OnlineMeeting).EntryExitAnnouncement = n.GetBoolValue(); } },
                {"expirationDateTime", (o,n) => { (o as OnlineMeeting).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", (o,n) => { (o as OnlineMeeting).ExternalId = n.GetStringValue(); } },
                {"isBroadcast", (o,n) => { (o as OnlineMeeting).IsBroadcast = n.GetBoolValue(); } },
                {"isCancelled", (o,n) => { (o as OnlineMeeting).IsCancelled = n.GetBoolValue(); } },
                {"isEntryExitAnnounced", (o,n) => { (o as OnlineMeeting).IsEntryExitAnnounced = n.GetBoolValue(); } },
                {"joinInformation", (o,n) => { (o as OnlineMeeting).JoinInformation = n.GetObjectValue<ItemBody>(); } },
                {"joinMeetingIdSettings", (o,n) => { (o as OnlineMeeting).JoinMeetingIdSettings = n.GetObjectValue<JoinMeetingIdSettings>(); } },
                {"joinUrl", (o,n) => { (o as OnlineMeeting).JoinUrl = n.GetStringValue(); } },
                {"lobbyBypassSettings", (o,n) => { (o as OnlineMeeting).LobbyBypassSettings = n.GetObjectValue<LobbyBypassSettings>(); } },
                {"meetingAttendanceReport", (o,n) => { (o as OnlineMeeting).MeetingAttendanceReport = n.GetObjectValue<MeetingAttendanceReport>(); } },
                {"participants", (o,n) => { (o as OnlineMeeting).Participants = n.GetObjectValue<MeetingParticipants>(); } },
                {"recordAutomatically", (o,n) => { (o as OnlineMeeting).RecordAutomatically = n.GetBoolValue(); } },
                {"recording", (o,n) => { (o as OnlineMeeting).Recording = n.GetByteArrayValue(); } },
                {"registration", (o,n) => { (o as OnlineMeeting).Registration = n.GetObjectValue<MeetingRegistration>(); } },
                {"startDateTime", (o,n) => { (o as OnlineMeeting).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", (o,n) => { (o as OnlineMeeting).Subject = n.GetStringValue(); } },
                {"videoTeleconferenceId", (o,n) => { (o as OnlineMeeting).VideoTeleconferenceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AccessLevel>("accessLevel", AccessLevel);
            writer.WriteBoolValue("allowAttendeeToEnableCamera", AllowAttendeeToEnableCamera);
            writer.WriteBoolValue("allowAttendeeToEnableMic", AllowAttendeeToEnableMic);
            writer.WriteEnumValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteEnumValue<MeetingChatMode>("allowMeetingChat", AllowMeetingChat);
            writer.WriteBoolValue("allowTeamworkReactions", AllowTeamworkReactions);
            writer.WriteByteArrayValue("alternativeRecording", AlternativeRecording);
            writer.WriteCollectionOfObjectValues<MeetingAttendanceReport>("attendanceReports", AttendanceReports);
            writer.WriteByteArrayValue("attendeeReport", AttendeeReport);
            writer.WriteObjectValue<AudioConferencing>("audioConferencing", AudioConferencing);
            writer.WriteObjectValue<BroadcastMeetingSettings>("broadcastSettings", BroadcastSettings);
            writer.WriteDateTimeOffsetValue("canceledDateTime", CanceledDateTime);
            writer.WriteCollectionOfEnumValues<MeetingCapabilities>("capabilities", Capabilities);
            writer.WriteObjectValue<ChatInfo>("chatInfo", ChatInfo);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteBoolValue("entryExitAnnouncement", EntryExitAnnouncement);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteBoolValue("isBroadcast", IsBroadcast);
            writer.WriteBoolValue("isCancelled", IsCancelled);
            writer.WriteBoolValue("isEntryExitAnnounced", IsEntryExitAnnounced);
            writer.WriteObjectValue<ItemBody>("joinInformation", JoinInformation);
            writer.WriteObjectValue<JoinMeetingIdSettings>("joinMeetingIdSettings", JoinMeetingIdSettings);
            writer.WriteStringValue("joinUrl", JoinUrl);
            writer.WriteObjectValue<LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
            writer.WriteObjectValue<MeetingAttendanceReport>("meetingAttendanceReport", MeetingAttendanceReport);
            writer.WriteObjectValue<MeetingParticipants>("participants", Participants);
            writer.WriteBoolValue("recordAutomatically", RecordAutomatically);
            writer.WriteByteArrayValue("recording", Recording);
            writer.WriteObjectValue<MeetingRegistration>("registration", Registration);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("videoTeleconferenceId", VideoTeleconferenceId);
        }
    }
}
