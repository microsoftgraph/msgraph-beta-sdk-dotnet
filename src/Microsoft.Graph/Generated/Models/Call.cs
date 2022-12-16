using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class Call : Entity, IParsable {
        /// <summary>The list of active modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data. Read-only.</summary>
        public List<Modality?> ActiveModalities {
            get { return BackingStore?.Get<List<Modality?>>("activeModalities"); }
            set { BackingStore?.Set("activeModalities", value); }
        }
        /// <summary>The participant that answered the call. Read-only.</summary>
        public ParticipantInfo AnsweredBy {
            get { return BackingStore?.Get<ParticipantInfo>("answeredBy"); }
            set { BackingStore?.Set("answeredBy", value); }
        }
        /// <summary>The audioRoutingGroups property</summary>
        public List<AudioRoutingGroup> AudioRoutingGroups {
            get { return BackingStore?.Get<List<AudioRoutingGroup>>("audioRoutingGroups"); }
            set { BackingStore?.Set("audioRoutingGroups", value); }
        }
        /// <summary>The callback URL on which callbacks will be delivered. Must be https.</summary>
        public string CallbackUri {
            get { return BackingStore?.Get<string>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
        public string CallChainId {
            get { return BackingStore?.Get<string>("callChainId"); }
            set { BackingStore?.Set("callChainId", value); }
        }
        /// <summary>Contains the optional features for the call.</summary>
        public Microsoft.Graph.Beta.Models.CallOptions CallOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallOptions>("callOptions"); }
            set { BackingStore?.Set("callOptions", value); }
        }
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
        public List<CallRoute> CallRoutes {
            get { return BackingStore?.Get<List<CallRoute>>("callRoutes"); }
            set { BackingStore?.Set("callRoutes", value); }
        }
        /// <summary>The chat information. Required information for meeting scenarios.</summary>
        public Microsoft.Graph.Beta.Models.ChatInfo ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ChatInfo>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
        /// <summary>The contentSharingSessions property</summary>
        public List<ContentSharingSession> ContentSharingSessions {
            get { return BackingStore?.Get<List<ContentSharingSession>>("contentSharingSessions"); }
            set { BackingStore?.Set("contentSharingSessions", value); }
        }
        /// <summary>The direction of the call. The possible value are incoming or outgoing. Read-only.</summary>
        public CallDirection? Direction {
            get { return BackingStore?.Get<CallDirection?>("direction"); }
            set { BackingStore?.Set("direction", value); }
        }
        /// <summary>The context associated with an incoming call. Read-only. Server generated.</summary>
        public Microsoft.Graph.Beta.Models.IncomingContext IncomingContext {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IncomingContext>("incomingContext"); }
            set { BackingStore?.Set("incomingContext", value); }
        }
        /// <summary>The media configuration. Required information for creating peer to peer calls or joining meetings.</summary>
        public Microsoft.Graph.Beta.Models.MediaConfig MediaConfig {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaConfig>("mediaConfig"); }
            set { BackingStore?.Set("mediaConfig", value); }
        }
        /// <summary>Read-only. The call media state.</summary>
        public CallMediaState MediaState {
            get { return BackingStore?.Get<CallMediaState>("mediaState"); }
            set { BackingStore?.Set("mediaState", value); }
        }
        /// <summary>Contains the capabilities of a meeting. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.MeetingCapability MeetingCapability {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MeetingCapability>("meetingCapability"); }
            set { BackingStore?.Set("meetingCapability", value); }
        }
        /// <summary>The meeting information. Required information for meeting scenarios.</summary>
        public Microsoft.Graph.Beta.Models.MeetingInfo MeetingInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MeetingInfo>("meetingInfo"); }
            set { BackingStore?.Set("meetingInfo", value); }
        }
        /// <summary>The myParticipantId property</summary>
        public string MyParticipantId {
            get { return BackingStore?.Get<string>("myParticipantId"); }
            set { BackingStore?.Set("myParticipantId", value); }
        }
        /// <summary>The operations property</summary>
        public List<CommsOperation> Operations {
            get { return BackingStore?.Get<List<CommsOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
        /// <summary>The participants property</summary>
        public List<Participant> Participants {
            get { return BackingStore?.Get<List<Participant>>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
        /// <summary>The requestedModalities property</summary>
        public List<Modality?> RequestedModalities {
            get { return BackingStore?.Get<List<Modality?>>("requestedModalities"); }
            set { BackingStore?.Set("requestedModalities", value); }
        }
        /// <summary>The resultInfo property</summary>
        public Microsoft.Graph.Beta.Models.ResultInfo ResultInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResultInfo>("resultInfo"); }
            set { BackingStore?.Set("resultInfo", value); }
        }
        /// <summary>The ringingTimeoutInSeconds property</summary>
        public int? RingingTimeoutInSeconds {
            get { return BackingStore?.Get<int?>("ringingTimeoutInSeconds"); }
            set { BackingStore?.Set("ringingTimeoutInSeconds", value); }
        }
        /// <summary>The routingPolicies property</summary>
        public List<RoutingPolicy?> RoutingPolicies {
            get { return BackingStore?.Get<List<RoutingPolicy?>>("routingPolicies"); }
            set { BackingStore?.Set("routingPolicies", value); }
        }
        /// <summary>The source property</summary>
        public ParticipantInfo Source {
            get { return BackingStore?.Get<ParticipantInfo>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>The state property</summary>
        public CallState? State {
            get { return BackingStore?.Get<CallState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
        /// <summary>The targets property</summary>
        public List<InvitationParticipantInfo> Targets {
            get { return BackingStore?.Get<List<InvitationParticipantInfo>>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>The terminationReason property</summary>
        public string TerminationReason {
            get { return BackingStore?.Get<string>("terminationReason"); }
            set { BackingStore?.Set("terminationReason", value); }
        }
        /// <summary>The toneInfo property</summary>
        public Microsoft.Graph.Beta.Models.ToneInfo ToneInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ToneInfo>("toneInfo"); }
            set { BackingStore?.Set("toneInfo", value); }
        }
        /// <summary>The transcription information for the call. Read-only.</summary>
        public CallTranscriptionInfo Transcription {
            get { return BackingStore?.Get<CallTranscriptionInfo>("transcription"); }
            set { BackingStore?.Set("transcription", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Call CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Call();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeModalities", n => { ActiveModalities = n.GetCollectionOfEnumValues<Modality>()?.ToList(); } },
                {"answeredBy", n => { AnsweredBy = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"audioRoutingGroups", n => { AudioRoutingGroups = n.GetCollectionOfObjectValues<AudioRoutingGroup>(AudioRoutingGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"callChainId", n => { CallChainId = n.GetStringValue(); } },
                {"callOptions", n => { CallOptions = n.GetObjectValue<Microsoft.Graph.Beta.Models.CallOptions>(Microsoft.Graph.Beta.Models.CallOptions.CreateFromDiscriminatorValue); } },
                {"callRoutes", n => { CallRoutes = n.GetCollectionOfObjectValues<CallRoute>(CallRoute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"chatInfo", n => { ChatInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ChatInfo>(Microsoft.Graph.Beta.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                {"contentSharingSessions", n => { ContentSharingSessions = n.GetCollectionOfObjectValues<ContentSharingSession>(ContentSharingSession.CreateFromDiscriminatorValue)?.ToList(); } },
                {"direction", n => { Direction = n.GetEnumValue<CallDirection>(); } },
                {"incomingContext", n => { IncomingContext = n.GetObjectValue<Microsoft.Graph.Beta.Models.IncomingContext>(Microsoft.Graph.Beta.Models.IncomingContext.CreateFromDiscriminatorValue); } },
                {"mediaConfig", n => { MediaConfig = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaConfig>(Microsoft.Graph.Beta.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                {"mediaState", n => { MediaState = n.GetObjectValue<CallMediaState>(CallMediaState.CreateFromDiscriminatorValue); } },
                {"meetingCapability", n => { MeetingCapability = n.GetObjectValue<Microsoft.Graph.Beta.Models.MeetingCapability>(Microsoft.Graph.Beta.Models.MeetingCapability.CreateFromDiscriminatorValue); } },
                {"meetingInfo", n => { MeetingInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.MeetingInfo>(Microsoft.Graph.Beta.Models.MeetingInfo.CreateFromDiscriminatorValue); } },
                {"myParticipantId", n => { MyParticipantId = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CommsOperation>(CommsOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"participants", n => { Participants = n.GetCollectionOfObjectValues<Participant>(Participant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requestedModalities", n => { RequestedModalities = n.GetCollectionOfEnumValues<Modality>()?.ToList(); } },
                {"resultInfo", n => { ResultInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResultInfo>(Microsoft.Graph.Beta.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                {"ringingTimeoutInSeconds", n => { RingingTimeoutInSeconds = n.GetIntValue(); } },
                {"routingPolicies", n => { RoutingPolicies = n.GetCollectionOfEnumValues<RoutingPolicy>()?.ToList(); } },
                {"source", n => { Source = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<CallState>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"targets", n => { Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"terminationReason", n => { TerminationReason = n.GetStringValue(); } },
                {"toneInfo", n => { ToneInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ToneInfo>(Microsoft.Graph.Beta.Models.ToneInfo.CreateFromDiscriminatorValue); } },
                {"transcription", n => { Transcription = n.GetObjectValue<CallTranscriptionInfo>(CallTranscriptionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
