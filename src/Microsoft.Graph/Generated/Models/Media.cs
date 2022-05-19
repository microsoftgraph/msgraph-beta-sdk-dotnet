using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Media : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>If a file has a transcript, this setting controls if the closed captions / transcription for the media file should be shown to people during viewing. Read-Write.</summary>
        public bool? IsTranscriptionShown {
            get { return BackingStore?.Get<bool?>(nameof(IsTranscriptionShown)); }
            set { BackingStore?.Set(nameof(IsTranscriptionShown), value); }
        }
        /// <summary>Information about the source of media. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.MediaSource MediaSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaSource>(nameof(MediaSource)); }
            set { BackingStore?.Set(nameof(MediaSource), value); }
        }
        /// <summary>
        /// Instantiates a new media and sets the default values.
        /// </summary>
        public Media() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isTranscriptionShown", n => { IsTranscriptionShown = n.GetBoolValue(); } },
                {"mediaSource", n => { MediaSource = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaSource>(Microsoft.Graph.Beta.Models.MediaSource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isTranscriptionShown", IsTranscriptionShown);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaSource>("mediaSource", MediaSource);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
