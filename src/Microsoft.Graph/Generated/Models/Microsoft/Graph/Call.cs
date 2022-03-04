using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
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
        public MicrosoftGraphSdk.Models.Microsoft.Graph.CallOptions CallOptions { get; set; }
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
        public List<CallRoute> CallRoutes { get; set; }
        /// <summary>The chat information. Required information for joining a meeting.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ChatInfo ChatInfo { get; set; }
        /// <summary>The direction of the call. The possible value are incoming or outgoing. Read-only.</summary>
        public CallDirection? Direction { get; set; }
        /// <summary>The context associated with an incoming call. Read-only. Server generated.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.IncomingContext IncomingContext { get; set; }
        /// <summary>The media configuration. Required.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.MediaConfig MediaConfig { get; set; }
        /// <summary>Read-only. The call media state.</summary>
        public CallMediaState MediaState { get; set; }
        /// <summary>Contains the capabilities of a meeting. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.MeetingCapability MeetingCapability { get; set; }
        /// <summary>The meeting information that's required for joining a meeting.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.MeetingInfo MeetingInfo { get; set; }
        public string MyParticipantId { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<CommsOperation> Operations { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<Participant> Participants { get; set; }
        public List<Modality?> RequestedModalities { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ResultInfo ResultInfo { get; set; }
        public int? RingingTimeoutInSeconds { get; set; }
        public List<RoutingPolicy?> RoutingPolicies { get; set; }
        public ParticipantInfo Source { get; set; }
        public CallState? State { get; set; }
        public string Subject { get; set; }
        public List<InvitationParticipantInfo> Targets { get; set; }
        public string TenantId { get; set; }
        public string TerminationReason { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ToneInfo ToneInfo { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeModalities", (o,n) => { (o as Call).ActiveModalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"answeredBy", (o,n) => { (o as Call).AnsweredBy = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"audioRoutingGroups", (o,n) => { (o as Call).AudioRoutingGroups = n.GetCollectionOfObjectValues<AudioRoutingGroup>(AudioRoutingGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"callbackUri", (o,n) => { (o as Call).CallbackUri = n.GetStringValue(); } },
                {"callChainId", (o,n) => { (o as Call).CallChainId = n.GetStringValue(); } },
                {"callOptions", (o,n) => { (o as Call).CallOptions = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.CallOptions>(MicrosoftGraphSdk.Models.Microsoft.Graph.CallOptions.CreateFromDiscriminatorValue); } },
                {"callRoutes", (o,n) => { (o as Call).CallRoutes = n.GetCollectionOfObjectValues<CallRoute>(CallRoute.CreateFromDiscriminatorValue).ToList(); } },
                {"chatInfo", (o,n) => { (o as Call).ChatInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ChatInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ChatInfo.CreateFromDiscriminatorValue); } },
                {"direction", (o,n) => { (o as Call).Direction = n.GetEnumValue<CallDirection>(); } },
                {"incomingContext", (o,n) => { (o as Call).IncomingContext = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.IncomingContext>(MicrosoftGraphSdk.Models.Microsoft.Graph.IncomingContext.CreateFromDiscriminatorValue); } },
                {"mediaConfig", (o,n) => { (o as Call).MediaConfig = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MediaConfig>(MicrosoftGraphSdk.Models.Microsoft.Graph.MediaConfig.CreateFromDiscriminatorValue); } },
                {"mediaState", (o,n) => { (o as Call).MediaState = n.GetObjectValue<CallMediaState>(CallMediaState.CreateFromDiscriminatorValue); } },
                {"meetingCapability", (o,n) => { (o as Call).MeetingCapability = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MeetingCapability>(MicrosoftGraphSdk.Models.Microsoft.Graph.MeetingCapability.CreateFromDiscriminatorValue); } },
                {"meetingInfo", (o,n) => { (o as Call).MeetingInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MeetingInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.MeetingInfo.CreateFromDiscriminatorValue); } },
                {"myParticipantId", (o,n) => { (o as Call).MyParticipantId = n.GetStringValue(); } },
                {"operations", (o,n) => { (o as Call).Operations = n.GetCollectionOfObjectValues<CommsOperation>(CommsOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"participants", (o,n) => { (o as Call).Participants = n.GetCollectionOfObjectValues<Participant>(Participant.CreateFromDiscriminatorValue).ToList(); } },
                {"requestedModalities", (o,n) => { (o as Call).RequestedModalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"resultInfo", (o,n) => { (o as Call).ResultInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ResultInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ResultInfo.CreateFromDiscriminatorValue); } },
                {"ringingTimeoutInSeconds", (o,n) => { (o as Call).RingingTimeoutInSeconds = n.GetIntValue(); } },
                {"routingPolicies", (o,n) => { (o as Call).RoutingPolicies = n.GetCollectionOfEnumValues<RoutingPolicy>().ToList(); } },
                {"source", (o,n) => { (o as Call).Source = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"state", (o,n) => { (o as Call).State = n.GetEnumValue<CallState>(); } },
                {"subject", (o,n) => { (o as Call).Subject = n.GetStringValue(); } },
                {"targets", (o,n) => { (o as Call).Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantId", (o,n) => { (o as Call).TenantId = n.GetStringValue(); } },
                {"terminationReason", (o,n) => { (o as Call).TerminationReason = n.GetStringValue(); } },
                {"toneInfo", (o,n) => { (o as Call).ToneInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ToneInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ToneInfo.CreateFromDiscriminatorValue); } },
                {"transcription", (o,n) => { (o as Call).Transcription = n.GetObjectValue<CallTranscriptionInfo>(CallTranscriptionInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.CallOptions>("callOptions", CallOptions);
            writer.WriteCollectionOfObjectValues<CallRoute>("callRoutes", CallRoutes);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteEnumValue<CallDirection>("direction", Direction);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.IncomingContext>("incomingContext", IncomingContext);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteObjectValue<CallMediaState>("mediaState", MediaState);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MeetingCapability>("meetingCapability", MeetingCapability);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MeetingInfo>("meetingInfo", MeetingInfo);
            writer.WriteStringValue("myParticipantId", MyParticipantId);
            writer.WriteCollectionOfObjectValues<CommsOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Participant>("participants", Participants);
            writer.WriteCollectionOfEnumValues<Modality>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteIntValue("ringingTimeoutInSeconds", RingingTimeoutInSeconds);
            writer.WriteCollectionOfEnumValues<RoutingPolicy>("routingPolicies", RoutingPolicies);
            writer.WriteObjectValue<ParticipantInfo>("source", Source);
            writer.WriteEnumValue<CallState>("state", State);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("targets", Targets);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("terminationReason", TerminationReason);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ToneInfo>("toneInfo", ToneInfo);
            writer.WriteObjectValue<CallTranscriptionInfo>("transcription", Transcription);
        }
    }
}
