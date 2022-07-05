using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the commsApplication singleton.</summary>
    public class Participant : Entity, IParsable {
        /// <summary>The info property</summary>
        public ParticipantInfo Info {
            get { return BackingStore?.Get<ParticipantInfo>(nameof(Info)); }
            set { BackingStore?.Set(nameof(Info), value); }
        }
        /// <summary>The isIdentityAnonymized property</summary>
        public bool? IsIdentityAnonymized {
            get { return BackingStore?.Get<bool?>(nameof(IsIdentityAnonymized)); }
            set { BackingStore?.Set(nameof(IsIdentityAnonymized), value); }
        }
        /// <summary>true if the participant is in lobby.</summary>
        public bool? IsInLobby {
            get { return BackingStore?.Get<bool?>(nameof(IsInLobby)); }
            set { BackingStore?.Set(nameof(IsInLobby), value); }
        }
        /// <summary>true if the participant is muted (client or server muted).</summary>
        public bool? IsMuted {
            get { return BackingStore?.Get<bool?>(nameof(IsMuted)); }
            set { BackingStore?.Set(nameof(IsMuted), value); }
        }
        /// <summary>The list of media streams.</summary>
        public List<MediaStream> MediaStreams {
            get { return BackingStore?.Get<List<MediaStream>>(nameof(MediaStreams)); }
            set { BackingStore?.Set(nameof(MediaStreams), value); }
        }
        /// <summary>A blob of data provided by the participant in the roster.</summary>
        public string Metadata {
            get { return BackingStore?.Get<string>(nameof(Metadata)); }
            set { BackingStore?.Set(nameof(Metadata), value); }
        }
        /// <summary>Information on whether the participant has recording capability.</summary>
        public Microsoft.Graph.Beta.Models.RecordingInfo RecordingInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RecordingInfo>(nameof(RecordingInfo)); }
            set { BackingStore?.Set(nameof(RecordingInfo), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Participant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Participant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"info", n => { Info = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"isIdentityAnonymized", n => { IsIdentityAnonymized = n.GetBoolValue(); } },
                {"isInLobby", n => { IsInLobby = n.GetBoolValue(); } },
                {"isMuted", n => { IsMuted = n.GetBoolValue(); } },
                {"mediaStreams", n => { MediaStreams = n.GetCollectionOfObjectValues<MediaStream>(MediaStream.CreateFromDiscriminatorValue).ToList(); } },
                {"metadata", n => { Metadata = n.GetStringValue(); } },
                {"recordingInfo", n => { RecordingInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.RecordingInfo>(Microsoft.Graph.Beta.Models.RecordingInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ParticipantInfo>("info", Info);
            writer.WriteBoolValue("isIdentityAnonymized", IsIdentityAnonymized);
            writer.WriteBoolValue("isInLobby", IsInLobby);
            writer.WriteBoolValue("isMuted", IsMuted);
            writer.WriteCollectionOfObjectValues<MediaStream>("mediaStreams", MediaStreams);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RecordingInfo>("recordingInfo", RecordingInfo);
        }
    }
}
