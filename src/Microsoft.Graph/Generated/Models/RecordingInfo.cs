using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RecordingInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The participant who initiated the recording.</summary>
        public ParticipantInfo InitiatedBy {
            get { return BackingStore?.Get<ParticipantInfo>(nameof(InitiatedBy)); }
            set { BackingStore?.Set(nameof(InitiatedBy), value); }
        }
        /// <summary>The identities of recording initiator.</summary>
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>(nameof(Initiator)); }
            set { BackingStore?.Set(nameof(Initiator), value); }
        }
        /// <summary>Possible values are: unknown, notRecording, recording, or failed.</summary>
        public Microsoft.Graph.Beta.Models.RecordingStatus? RecordingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RecordingStatus?>(nameof(RecordingStatus)); }
            set { BackingStore?.Set(nameof(RecordingStatus), value); }
        }
        /// <summary>
        /// Instantiates a new recordingInfo and sets the default values.
        /// </summary>
        public RecordingInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RecordingInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecordingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"initiatedBy", n => { InitiatedBy = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"recordingStatus", n => { RecordingStatus = n.GetEnumValue<RecordingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ParticipantInfo>("initiatedBy", InitiatedBy);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteEnumValue<RecordingStatus>("recordingStatus", RecordingStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
