using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RecordOperation : CommsOperation, IParsable {
        /// <summary>Possible values are: operationCanceled, stopToneDetected, maxRecordDurationReached, initialSilenceTimeout, maxSilenceTimeout, playPromptFailed, playBeepFailed, mediaReceiveTimeout, unspecifiedError, none.</summary>
        public RecordCompletionReason? CompletionReason {
            get { return BackingStore?.Get<RecordCompletionReason?>(nameof(CompletionReason)); }
            set { BackingStore?.Set(nameof(CompletionReason), value); }
        }
        /// <summary>The access token required to retrieve the recording.</summary>
        public string RecordingAccessToken {
            get { return BackingStore?.Get<string>(nameof(RecordingAccessToken)); }
            set { BackingStore?.Set(nameof(RecordingAccessToken), value); }
        }
        /// <summary>The location where the recording is located.</summary>
        public string RecordingLocation {
            get { return BackingStore?.Get<string>(nameof(RecordingLocation)); }
            set { BackingStore?.Set(nameof(RecordingLocation), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RecordOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecordOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completionReason", n => { CompletionReason = n.GetEnumValue<RecordCompletionReason>(); } },
                {"recordingAccessToken", n => { RecordingAccessToken = n.GetStringValue(); } },
                {"recordingLocation", n => { RecordingLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<RecordCompletionReason>("completionReason", CompletionReason);
            writer.WriteStringValue("recordingAccessToken", RecordingAccessToken);
            writer.WriteStringValue("recordingLocation", RecordingLocation);
        }
    }
}
