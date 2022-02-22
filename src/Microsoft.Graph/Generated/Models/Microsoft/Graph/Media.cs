using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Media : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If a file has a transcript, this setting controls if the closed captions / transcription for the media file should be shown to people during viewing. Read-Write.</summary>
        public bool? IsTranscriptionShown { get; set; }
        /// <summary>Information about the source of media. Read-only.</summary>
        public MediaSource MediaSource { get; set; }
        /// <summary>
        /// Instantiates a new media and sets the default values.
        /// </summary>
        public Media() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isTranscriptionShown", (o,n) => { (o as Media).IsTranscriptionShown = n.GetBoolValue(); } },
                {"mediaSource", (o,n) => { (o as Media).MediaSource = n.GetObjectValue<MediaSource>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isTranscriptionShown", IsTranscriptionShown);
            writer.WriteObjectValue<MediaSource>("mediaSource", MediaSource);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
