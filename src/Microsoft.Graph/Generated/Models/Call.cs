using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Call : Entity, IParsable {
        /// <summary>The list of active modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data. Read-only.</summary>
        public List<Modality?> ActiveModalities { get; set; }
        /// <summary>The participant that answered the call. Read-only.</summary>
        public ParticipantInfo AnsweredBy { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<AudioRoutingGroup> AudioRoutingGroups { get; set; }
        /// <summary>The callback URL on which callbacks will be delivered. Must be https.</summary>
        public string CallbackUri { get; set; }
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
        public string CallChainId { get; set; }
        /// <summary>The callOptions property</summary>
        public Microsoft.Graph.Beta.Models.CallOptions CallOptions { get; set; }
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
        public List<CallRoute> CallRoutes { get; set; }
        /// <summary>The chat information. Required information for joining a meeting.</summary>
        public Microsoft.Graph.Beta.Models.ChatInfo ChatInfo { get; set; }
        /// <summary>The contentSharingSessions property</summary>
        public List<ContentSharingSession> ContentSharingSessions { get; set; }
        /// <summary>The direction of the call. The possible value are incoming or outgoing. Read-only.</summary>
        public CallDirection? Direction { get; set; }
        /// <summary>The context associated with an incoming call. Read-only. Server generated.</summary>
        public Microsoft.Graph.Beta.Models.IncomingContext IncomingContext { get; set; }
        /// <summary>The media configuration. Required.</summary>
        public Microsoft.Graph.Beta.Models.MediaConfig MediaConfig { get; set; }
        /// <summary>Read-only. The call media state.</summary>
        public CallMediaState MediaState { get; set; }
        /// <summary>Contains the capabilities of a meeting. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.MeetingCapability MeetingCapability { get; set; }
        /// <summary>The meeting information that&apos;s required for joining a meeting.</summary>
        public Microsoft.Graph.Beta.Models.MeetingInfo MeetingInfo { get; set; }
        /// <summary>The myParticipantId property</summary>
        public string MyParticipantId { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<CommsOperation> Operations { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<Participant> Participants { get; set; }
        /// <summary>The requestedModalities property</summary>
        public List<Modality?> RequestedModalities { get; set; }
        /// <summary>The resultInfo property</summary>
        public Microsoft.Graph.Beta.Models.ResultInfo ResultInfo { get; set; }
        /// <summary>The ringingTimeoutInSeconds property</summary>
        public int? RingingTimeoutInSeconds { get; set; }
        /// <summary>The routingPolicies property</summary>
        public List<RoutingPolicy?> RoutingPolicies { get; set; }
        /// <summary>The source property</summary>
        public ParticipantInfo Source { get; set; }
        /// <summary>The state property</summary>
        public CallState? State { get; set; }
        /// <summary>The subject property</summary>
        public string Subject { get; set; }
        /// <summary>The targets property</summary>
        public List<InvitationParticipantInfo> Targets { get; set; }
        /// <summary>The tenantId property</summary>
        public string TenantId { get; set; }
        /// <summary>The terminationReason property</summary>
        public string TerminationReason { get; set; }
        /// <summary>The toneInfo property</summary>
        public Microsoft.Graph.Beta.Models.ToneInfo ToneInfo { get; set; }
        /// <summary>The transcription information for the call. Read-only.</summary>
        public CallTranscriptionInfo Transcription { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Call CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Call();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeModalities", n => { ActiveModalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"answeredBy", n => { AnsweredBy = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"audioRoutingGroups", n => { AudioRoutingGroups = n.GetCollectionOfObjectValues<AudioRoutingGroup>(AudioRoutingGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"callChainId", n => { CallChainId = n.GetStringValue(); } },
                {"callOptions", n => { CallOptions = n.GetObjectValue<Microsoft.Graph.Beta.Models.CallOptions>(Microsoft.Graph.Beta.Models.CallOptions.CreateFromDiscriminatorValue); } },
                {"callRoutes", n => { CallRoutes = n.GetCollectionOfObjectValues<CallRoute>(CallRoute.CreateFromDiscriminatorValue).ToList(); } },
                {"chatInfo", n => { ChatInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ChatInfo>(Microsoft.Graph.Beta.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                {"contentSharingSessions", n => { ContentSharingSessions = n.GetCollectionOfObjectValues<ContentSharingSession>(ContentSharingSession.CreateFromDiscriminatorValue).ToList(); } },
                {"direction", n => { Direction = n.GetEnumValue<CallDirection>(); } },
                {"incomingContext", n => { IncomingContext = n.GetObjectValue<Microsoft.Graph.Beta.Models.IncomingContext>(Microsoft.Graph.Beta.Models.IncomingContext.CreateFromDiscriminatorValue); } },
                {"mediaConfig", n => { MediaConfig = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaConfig>(Microsoft.Graph.Beta.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                {"mediaState", n => { MediaState = n.GetObjectValue<CallMediaState>(CallMediaState.CreateFromDiscriminatorValue); } },
                {"meetingCapability", n => { MeetingCapability = n.GetObjectValue<Microsoft.Graph.Beta.Models.MeetingCapability>(Microsoft.Graph.Beta.Models.MeetingCapability.CreateFromDiscriminatorValue); } },
                {"meetingInfo", n => { MeetingInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.MeetingInfo>(Microsoft.Graph.Beta.Models.MeetingInfo.CreateFromDiscriminatorValue); } },
                {"myParticipantId", n => { MyParticipantId = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CommsOperation>(CommsOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"participants", n => { Participants = n.GetCollectionOfObjectValues<Participant>(Participant.CreateFromDiscriminatorValue).ToList(); } },
                {"requestedModalities", n => { RequestedModalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"resultInfo", n => { ResultInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResultInfo>(Microsoft.Graph.Beta.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                {"ringingTimeoutInSeconds", n => { RingingTimeoutInSeconds = n.GetIntValue(); } },
                {"routingPolicies", n => { RoutingPolicies = n.GetCollectionOfEnumValues<RoutingPolicy>().ToList(); } },
                {"source", n => { Source = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<CallState>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"targets", n => { Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"terminationReason", n => { TerminationReason = n.GetStringValue(); } },
                {"toneInfo", n => { ToneInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ToneInfo>(Microsoft.Graph.Beta.Models.ToneInfo.CreateFromDiscriminatorValue); } },
                {"transcription", n => { Transcription = n.GetObjectValue<CallTranscriptionInfo>(CallTranscriptionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<Modality>("activeModalities", ActiveModalities);
            writer.WriteObjectValue<ParticipantInfo>("answeredBy", AnsweredBy);
            writer.WriteCollectionOfObjectValues<AudioRoutingGroup>("audioRoutingGroups", AudioRoutingGroups);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteStringValue("callChainId", CallChainId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CallOptions>("callOptions", CallOptions);
            writer.WriteCollectionOfObjectValues<CallRoute>("callRoutes", CallRoutes);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteCollectionOfObjectValues<ContentSharingSession>("contentSharingSessions", ContentSharingSessions);
            writer.WriteEnumValue<CallDirection>("direction", Direction);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IncomingContext>("incomingContext", IncomingContext);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteObjectValue<CallMediaState>("mediaState", MediaState);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MeetingCapability>("meetingCapability", MeetingCapability);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MeetingInfo>("meetingInfo", MeetingInfo);
            writer.WriteStringValue("myParticipantId", MyParticipantId);
            writer.WriteCollectionOfObjectValues<CommsOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Participant>("participants", Participants);
            writer.WriteCollectionOfEnumValues<Modality>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteIntValue("ringingTimeoutInSeconds", RingingTimeoutInSeconds);
            writer.WriteCollectionOfEnumValues<RoutingPolicy>("routingPolicies", RoutingPolicies);
            writer.WriteObjectValue<ParticipantInfo>("source", Source);
            writer.WriteEnumValue<CallState>("state", State);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("targets", Targets);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("terminationReason", TerminationReason);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ToneInfo>("toneInfo", ToneInfo);
            writer.WriteObjectValue<CallTranscriptionInfo>("transcription", Transcription);
        }
    }
}
