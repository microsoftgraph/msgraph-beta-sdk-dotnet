using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the record method.</summary>
    public class RecordOperation : CommsOperation, IParsable {
        /// <summary>Possible values are: operationCanceled, stopToneDetected, maxRecordDurationReached, initialSilenceTimeout, maxSilenceTimeout, playPromptFailed, playBeepFailed, mediaReceiveTimeout, unspecifiedError, none.</summary>
        public RecordCompletionReason? CompletionReason { get; set; }
        /// <summary>The access token required to retrieve the recording.</summary>
        public string RecordingAccessToken { get; set; }
        /// <summary>The location where the recording is located.</summary>
        public string RecordingLocation { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"completionReason", (o,n) => { (o as RecordOperation).CompletionReason = n.GetEnumValue<RecordCompletionReason>(); } },
                {"recordingAccessToken", (o,n) => { (o as RecordOperation).RecordingAccessToken = n.GetStringValue(); } },
                {"recordingLocation", (o,n) => { (o as RecordOperation).RecordingLocation = n.GetStringValue(); } },
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
