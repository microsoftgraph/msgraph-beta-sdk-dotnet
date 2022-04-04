using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class InvitationParticipantInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of endpoint. Possible values are: default, voicemail.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.EndpointType? EndpointType { get; set; }
        /// <summary>The hidden property</summary>
        public bool? Hidden { get; set; }
        /// <summary>The identity property</summary>
        public IdentitySet Identity { get; set; }
        /// <summary>The participantId property</summary>
        public string ParticipantId { get; set; }
        /// <summary>The removeFromDefaultAudioRoutingGroup property</summary>
        public bool? RemoveFromDefaultAudioRoutingGroup { get; set; }
        /// <summary>Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.</summary>
        public string ReplacesCallId { get; set; }
        /// <summary>
        /// Instantiates a new invitationParticipantInfo and sets the default values.
        /// </summary>
        public InvitationParticipantInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static InvitationParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvitationParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endpointType", (o,n) => { (o as InvitationParticipantInfo).EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"hidden", (o,n) => { (o as InvitationParticipantInfo).Hidden = n.GetBoolValue(); } },
                {"identity", (o,n) => { (o as InvitationParticipantInfo).Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"participantId", (o,n) => { (o as InvitationParticipantInfo).ParticipantId = n.GetStringValue(); } },
                {"removeFromDefaultAudioRoutingGroup", (o,n) => { (o as InvitationParticipantInfo).RemoveFromDefaultAudioRoutingGroup = n.GetBoolValue(); } },
                {"replacesCallId", (o,n) => { (o as InvitationParticipantInfo).ReplacesCallId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteBoolValue("removeFromDefaultAudioRoutingGroup", RemoveFromDefaultAudioRoutingGroup);
            writer.WriteStringValue("replacesCallId", ReplacesCallId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
