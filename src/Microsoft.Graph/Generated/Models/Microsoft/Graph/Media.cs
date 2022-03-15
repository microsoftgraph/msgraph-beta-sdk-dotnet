using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class Media : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If a file has a transcript, this setting controls if the closed captions / transcription for the media file should be shown to people during viewing. Read-Write.</summary>
        public bool? IsTranscriptionShown { get; set; }
        /// <summary>Information about the source of media. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.MediaSource MediaSource { get; set; }
        /// <summary>
        /// Instantiates a new media and sets the default values.
        /// </summary>
        public Media() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Media CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Media();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isTranscriptionShown", (o,n) => { (o as Media).IsTranscriptionShown = n.GetBoolValue(); } },
                {"mediaSource", (o,n) => { (o as Media).MediaSource = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MediaSource>(MicrosoftGraphSdk.Models.Microsoft.Graph.MediaSource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isTranscriptionShown", IsTranscriptionShown);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MediaSource>("mediaSource", MediaSource);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
