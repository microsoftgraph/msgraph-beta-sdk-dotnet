using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnlineMeeting : Entity, IParsable {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        public bool? AllowAttendeeToEnableCamera { get; set; }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        public bool? AllowAttendeeToEnableMic { get; set; }
        /// <summary>Specifies who can be a presenter in a meeting.</summary>
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
        /// <summary>Specifies the mode of meeting chat.</summary>
        public MeetingChatMode? AllowMeetingChat { get; set; }
        /// <summary>Indicates if Teams reactions are enabled for the meeting.</summary>
        public bool? AllowTeamworkReactions { get; set; }
        /// <summary>The content stream of the alternative recording of a Microsoft Teams live event. Read-only.</summary>
        public byte[] AlternativeRecording { get; set; }
        /// <summary>The attendance reports of an online meeting. Read-only.</summary>
        public List<Microsoft.Graph.Beta.Models.MeetingAttendanceReport> AttendanceReports { get; set; }
        /// <summary>The content stream of the attendee report of a Teams live event. Read-only.</summary>
        public byte[] AttendeeReport { get; set; }
        /// <summary>The phone access (dial-in) information for an online meeting. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.AudioConferencing AudioConferencing { get; set; }
        /// <summary>Settings related to a live event.</summary>
        public BroadcastMeetingSettings BroadcastSettings { get; set; }
        /// <summary>The capabilities property</summary>
        public List<MeetingCapabilities?> Capabilities { get; set; }
        /// <summary>The chat information associated with this online meeting.</summary>
        public Microsoft.Graph.Beta.Models.ChatInfo ChatInfo { get; set; }
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The external ID. A custom ID. Optional.</summary>
        public string ExternalId { get; set; }
        /// <summary>Indicates whether this is a Teams live event.</summary>
        public bool? IsBroadcast { get; set; }
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        public bool? IsEntryExitAnnounced { get; set; }
        /// <summary>The join information in the language and locale variant specified in &apos;Accept-Language&apos; request HTTP header. Read-only.</summary>
        public ItemBody JoinInformation { get; set; }
        /// <summary>The joinMeetingIdSettings property</summary>
        public Microsoft.Graph.Beta.Models.JoinMeetingIdSettings JoinMeetingIdSettings { get; set; }
        /// <summary>The joinUrl property</summary>
        public string JoinUrl { get; set; }
        /// <summary>The join URL of the online meeting. Read-only.</summary>
        public string JoinWebUrl { get; set; }
        /// <summary>Specifies which participants can bypass the meeting lobby.</summary>
        public Microsoft.Graph.Beta.Models.LobbyBypassSettings LobbyBypassSettings { get; set; }
        /// <summary>The meetingAttendanceReport property</summary>
        public Microsoft.Graph.Beta.Models.MeetingAttendanceReport MeetingAttendanceReport { get; set; }
        /// <summary>The participants associated with the online meeting. This includes the organizer and the attendees.</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OnlineMeeting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnlineMeeting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAttendeeToEnableCamera", n => { AllowAttendeeToEnableCamera = n.GetBoolValue(); } },
                {"allowAttendeeToEnableMic", n => { AllowAttendeeToEnableMic = n.GetBoolValue(); } },
                {"allowedPresenters", n => { AllowedPresenters = n.GetEnumValue<OnlineMeetingPresenters>(); } },
                {"allowMeetingChat", n => { AllowMeetingChat = n.GetEnumValue<MeetingChatMode>(); } },
                {"allowTeamworkReactions", n => { AllowTeamworkReactions = n.GetBoolValue(); } },
                {"alternativeRecording", n => { AlternativeRecording = n.GetByteArrayValue(); } },
                {"attendanceReports", n => { AttendanceReports = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MeetingAttendanceReport>(Microsoft.Graph.Beta.Models.MeetingAttendanceReport.CreateFromDiscriminatorValue).ToList(); } },
                {"attendeeReport", n => { AttendeeReport = n.GetByteArrayValue(); } },
                {"audioConferencing", n => { AudioConferencing = n.GetObjectValue<Microsoft.Graph.Beta.Models.AudioConferencing>(Microsoft.Graph.Beta.Models.AudioConferencing.CreateFromDiscriminatorValue); } },
                {"broadcastSettings", n => { BroadcastSettings = n.GetObjectValue<BroadcastMeetingSettings>(BroadcastMeetingSettings.CreateFromDiscriminatorValue); } },
                {"capabilities", n => { Capabilities = n.GetCollectionOfEnumValues<MeetingCapabilities>().ToList(); } },
                {"chatInfo", n => { ChatInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ChatInfo>(Microsoft.Graph.Beta.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"isBroadcast", n => { IsBroadcast = n.GetBoolValue(); } },
                {"isEntryExitAnnounced", n => { IsEntryExitAnnounced = n.GetBoolValue(); } },
                {"joinInformation", n => { JoinInformation = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"joinMeetingIdSettings", n => { JoinMeetingIdSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.JoinMeetingIdSettings>(Microsoft.Graph.Beta.Models.JoinMeetingIdSettings.CreateFromDiscriminatorValue); } },
                {"joinUrl", n => { JoinUrl = n.GetStringValue(); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"lobbyBypassSettings", n => { LobbyBypassSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.LobbyBypassSettings>(Microsoft.Graph.Beta.Models.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
                {"meetingAttendanceReport", n => { MeetingAttendanceReport = n.GetObjectValue<Microsoft.Graph.Beta.Models.MeetingAttendanceReport>(Microsoft.Graph.Beta.Models.MeetingAttendanceReport.CreateFromDiscriminatorValue); } },
                {"participants", n => { Participants = n.GetObjectValue<MeetingParticipants>(MeetingParticipants.CreateFromDiscriminatorValue); } },
                {"recordAutomatically", n => { RecordAutomatically = n.GetBoolValue(); } },
                {"recording", n => { Recording = n.GetByteArrayValue(); } },
                {"registration", n => { Registration = n.GetObjectValue<MeetingRegistration>(MeetingRegistration.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"videoTeleconferenceId", n => { VideoTeleconferenceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAttendeeToEnableCamera", AllowAttendeeToEnableCamera);
            writer.WriteBoolValue("allowAttendeeToEnableMic", AllowAttendeeToEnableMic);
            writer.WriteEnumValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteEnumValue<MeetingChatMode>("allowMeetingChat", AllowMeetingChat);
            writer.WriteBoolValue("allowTeamworkReactions", AllowTeamworkReactions);
            writer.WriteByteArrayValue("alternativeRecording", AlternativeRecording);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MeetingAttendanceReport>("attendanceReports", AttendanceReports);
            writer.WriteByteArrayValue("attendeeReport", AttendeeReport);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AudioConferencing>("audioConferencing", AudioConferencing);
            writer.WriteObjectValue<BroadcastMeetingSettings>("broadcastSettings", BroadcastSettings);
            writer.WriteCollectionOfEnumValues<MeetingCapabilities>("capabilities", Capabilities);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteBoolValue("isBroadcast", IsBroadcast);
            writer.WriteBoolValue("isEntryExitAnnounced", IsEntryExitAnnounced);
            writer.WriteObjectValue<ItemBody>("joinInformation", JoinInformation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.JoinMeetingIdSettings>("joinMeetingIdSettings", JoinMeetingIdSettings);
            writer.WriteStringValue("joinUrl", JoinUrl);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MeetingAttendanceReport>("meetingAttendanceReport", MeetingAttendanceReport);
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
