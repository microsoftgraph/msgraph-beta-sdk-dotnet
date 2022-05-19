using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the commsApplication singleton.</summary>
    public class Call : Entity, IParsable {
        /// <summary>The list of active modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data. Read-only.</summary>
        public List<string> ActiveModalities {
            get { return BackingStore?.Get<List<string>>(nameof(ActiveModalities)); }
            set { BackingStore?.Set(nameof(ActiveModalities), value); }
        }
        /// <summary>The participant that answered the call. Read-only.</summary>
        public ParticipantInfo AnsweredBy {
            get { return BackingStore?.Get<ParticipantInfo>(nameof(AnsweredBy)); }
            set { BackingStore?.Set(nameof(AnsweredBy), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public List<AudioRoutingGroup> AudioRoutingGroups {
            get { return BackingStore?.Get<List<AudioRoutingGroup>>(nameof(AudioRoutingGroups)); }
            set { BackingStore?.Set(nameof(AudioRoutingGroups), value); }
        }
        /// <summary>The callback URL on which callbacks will be delivered. Must be https.</summary>
        public string CallbackUri {
            get { return BackingStore?.Get<string>(nameof(CallbackUri)); }
            set { BackingStore?.Set(nameof(CallbackUri), value); }
        }
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
        public string CallChainId {
            get { return BackingStore?.Get<string>(nameof(CallChainId)); }
            set { BackingStore?.Set(nameof(CallChainId), value); }
        }
        /// <summary>Contains the optional features for the call.</summary>
        public Microsoft.Graph.Beta.Models.CallOptions CallOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallOptions>(nameof(CallOptions)); }
            set { BackingStore?.Set(nameof(CallOptions), value); }
        }
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
        public List<CallRoute> CallRoutes {
            get { return BackingStore?.Get<List<CallRoute>>(nameof(CallRoutes)); }
            set { BackingStore?.Set(nameof(CallRoutes), value); }
        }
        /// <summary>The chat information. Required information for meeting scenarios.</summary>
        public Microsoft.Graph.Beta.Models.ChatInfo ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ChatInfo>(nameof(ChatInfo)); }
            set { BackingStore?.Set(nameof(ChatInfo), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public List<ContentSharingSession> ContentSharingSessions {
            get { return BackingStore?.Get<List<ContentSharingSession>>(nameof(ContentSharingSessions)); }
            set { BackingStore?.Set(nameof(ContentSharingSessions), value); }
        }
        /// <summary>The direction of the call. The possible value are incoming or outgoing. Read-only.</summary>
        public CallDirection? Direction {
            get { return BackingStore?.Get<CallDirection?>(nameof(Direction)); }
            set { BackingStore?.Set(nameof(Direction), value); }
        }
        /// <summary>The context associated with an incoming call. Read-only. Server generated.</summary>
        public Microsoft.Graph.Beta.Models.IncomingContext IncomingContext {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IncomingContext>(nameof(IncomingContext)); }
            set { BackingStore?.Set(nameof(IncomingContext), value); }
        }
        /// <summary>The media configuration. Required information for creating peer to peer calls or joining meetings.</summary>
        public Microsoft.Graph.Beta.Models.MediaConfig MediaConfig {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaConfig>(nameof(MediaConfig)); }
            set { BackingStore?.Set(nameof(MediaConfig), value); }
        }
        /// <summary>Read-only. The call media state.</summary>
        public CallMediaState MediaState {
            get { return BackingStore?.Get<CallMediaState>(nameof(MediaState)); }
            set { BackingStore?.Set(nameof(MediaState), value); }
        }
        /// <summary>Contains the capabilities of a meeting. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.MeetingCapability MeetingCapability {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MeetingCapability>(nameof(MeetingCapability)); }
            set { BackingStore?.Set(nameof(MeetingCapability), value); }
        }
        /// <summary>The meeting information. Required information for meeting scenarios.</summary>
        public Microsoft.Graph.Beta.Models.MeetingInfo MeetingInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MeetingInfo>(nameof(MeetingInfo)); }
            set { BackingStore?.Set(nameof(MeetingInfo), value); }
        }
        /// <summary>The myParticipantId property</summary>
        public string MyParticipantId {
            get { return BackingStore?.Get<string>(nameof(MyParticipantId)); }
            set { BackingStore?.Set(nameof(MyParticipantId), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public List<CommsOperation> Operations {
            get { return BackingStore?.Get<List<CommsOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public List<Participant> Participants {
            get { return BackingStore?.Get<List<Participant>>(nameof(Participants)); }
            set { BackingStore?.Set(nameof(Participants), value); }
        }
        /// <summary>The requestedModalities property</summary>
        public List<string> RequestedModalities {
            get { return BackingStore?.Get<List<string>>(nameof(RequestedModalities)); }
            set { BackingStore?.Set(nameof(RequestedModalities), value); }
        }
        /// <summary>The resultInfo property</summary>
        public Microsoft.Graph.Beta.Models.ResultInfo ResultInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResultInfo>(nameof(ResultInfo)); }
            set { BackingStore?.Set(nameof(ResultInfo), value); }
        }
        /// <summary>The ringingTimeoutInSeconds property</summary>
        public int? RingingTimeoutInSeconds {
            get { return BackingStore?.Get<int?>(nameof(RingingTimeoutInSeconds)); }
            set { BackingStore?.Set(nameof(RingingTimeoutInSeconds), value); }
        }
        /// <summary>The routingPolicies property</summary>
        public List<string> RoutingPolicies {
            get { return BackingStore?.Get<List<string>>(nameof(RoutingPolicies)); }
            set { BackingStore?.Set(nameof(RoutingPolicies), value); }
        }
        /// <summary>The source property</summary>
        public ParticipantInfo Source {
            get { return BackingStore?.Get<ParticipantInfo>(nameof(Source)); }
            set { BackingStore?.Set(nameof(Source), value); }
        }
        /// <summary>The state property</summary>
        public CallState? State {
            get { return BackingStore?.Get<CallState?>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>(nameof(Subject)); }
            set { BackingStore?.Set(nameof(Subject), value); }
        }
        /// <summary>The targets property</summary>
        public List<InvitationParticipantInfo> Targets {
            get { return BackingStore?.Get<List<InvitationParticipantInfo>>(nameof(Targets)); }
            set { BackingStore?.Set(nameof(Targets), value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>The terminationReason property</summary>
        public string TerminationReason {
            get { return BackingStore?.Get<string>(nameof(TerminationReason)); }
            set { BackingStore?.Set(nameof(TerminationReason), value); }
        }
        /// <summary>The toneInfo property</summary>
        public Microsoft.Graph.Beta.Models.ToneInfo ToneInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ToneInfo>(nameof(ToneInfo)); }
            set { BackingStore?.Set(nameof(ToneInfo), value); }
        }
        /// <summary>The transcription information for the call. Read-only.</summary>
        public CallTranscriptionInfo Transcription {
            get { return BackingStore?.Get<CallTranscriptionInfo>(nameof(Transcription)); }
            set { BackingStore?.Set(nameof(Transcription), value); }
        }
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
                {"activeModalities", n => { ActiveModalities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
                {"requestedModalities", n => { RequestedModalities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"resultInfo", n => { ResultInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResultInfo>(Microsoft.Graph.Beta.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                {"ringingTimeoutInSeconds", n => { RingingTimeoutInSeconds = n.GetIntValue(); } },
                {"routingPolicies", n => { RoutingPolicies = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("activeModalities", ActiveModalities);
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
            writer.WriteCollectionOfPrimitiveValues<string>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteIntValue("ringingTimeoutInSeconds", RingingTimeoutInSeconds);
            writer.WriteCollectionOfPrimitiveValues<string>("routingPolicies", RoutingPolicies);
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
