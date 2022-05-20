using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InvitationParticipantInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The type of the endpoint. Possible values are: default, voicemail.</summary>
        public Microsoft.Graph.Beta.Models.EndpointType? EndpointType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EndpointType?>(nameof(EndpointType)); }
            set { BackingStore?.Set(nameof(EndpointType), value); }
        }
        /// <summary>The hidden property</summary>
        public bool? Hidden {
            get { return BackingStore?.Get<bool?>(nameof(Hidden)); }
            set { BackingStore?.Set(nameof(Hidden), value); }
        }
        /// <summary>The identity property</summary>
        public IdentitySet Identity {
            get { return BackingStore?.Get<IdentitySet>(nameof(Identity)); }
            set { BackingStore?.Set(nameof(Identity), value); }
        }
        /// <summary>Optional. The ID of the target participant.</summary>
        public string ParticipantId {
            get { return BackingStore?.Get<string>(nameof(ParticipantId)); }
            set { BackingStore?.Set(nameof(ParticipantId), value); }
        }
        /// <summary>The removeFromDefaultAudioRoutingGroup property</summary>
        public bool? RemoveFromDefaultAudioRoutingGroup {
            get { return BackingStore?.Get<bool?>(nameof(RemoveFromDefaultAudioRoutingGroup)); }
            set { BackingStore?.Set(nameof(RemoveFromDefaultAudioRoutingGroup), value); }
        }
        /// <summary>Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.</summary>
        public string ReplacesCallId {
            get { return BackingStore?.Get<string>(nameof(ReplacesCallId)); }
            set { BackingStore?.Set(nameof(ReplacesCallId), value); }
        }
        /// <summary>
        /// Instantiates a new invitationParticipantInfo and sets the default values.
        /// </summary>
        public InvitationParticipantInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"identity", n => { Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"participantId", n => { ParticipantId = n.GetStringValue(); } },
                {"removeFromDefaultAudioRoutingGroup", n => { RemoveFromDefaultAudioRoutingGroup = n.GetBoolValue(); } },
                {"replacesCallId", n => { ReplacesCallId = n.GetStringValue(); } },
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
