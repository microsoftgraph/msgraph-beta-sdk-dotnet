using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AudioConferencing : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The conference id of the online meeting.</summary>
        public string ConferenceId {
            get { return BackingStore?.Get<string>(nameof(ConferenceId)); }
            set { BackingStore?.Set(nameof(ConferenceId), value); }
        }
        /// <summary>A URL to the externally-accessible web page that contains dial-in information.</summary>
        public string DialinUrl {
            get { return BackingStore?.Get<string>(nameof(DialinUrl)); }
            set { BackingStore?.Set(nameof(DialinUrl), value); }
        }
        /// <summary>The tollFreeNumber property</summary>
        public string TollFreeNumber {
            get { return BackingStore?.Get<string>(nameof(TollFreeNumber)); }
            set { BackingStore?.Set(nameof(TollFreeNumber), value); }
        }
        /// <summary>List of toll-free numbers that are displayed in the meeting invite.</summary>
        public List<string> TollFreeNumbers {
            get { return BackingStore?.Get<List<string>>(nameof(TollFreeNumbers)); }
            set { BackingStore?.Set(nameof(TollFreeNumbers), value); }
        }
        /// <summary>The tollNumber property</summary>
        public string TollNumber {
            get { return BackingStore?.Get<string>(nameof(TollNumber)); }
            set { BackingStore?.Set(nameof(TollNumber), value); }
        }
        /// <summary>List of toll numbers that are displayed in the meeting invite.</summary>
        public List<string> TollNumbers {
            get { return BackingStore?.Get<List<string>>(nameof(TollNumbers)); }
            set { BackingStore?.Set(nameof(TollNumbers), value); }
        }
        /// <summary>
        /// Instantiates a new audioConferencing and sets the default values.
        /// </summary>
        public AudioConferencing() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AudioConferencing CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AudioConferencing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"conferenceId", n => { ConferenceId = n.GetStringValue(); } },
                {"dialinUrl", n => { DialinUrl = n.GetStringValue(); } },
                {"tollFreeNumber", n => { TollFreeNumber = n.GetStringValue(); } },
                {"tollFreeNumbers", n => { TollFreeNumbers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tollNumber", n => { TollNumber = n.GetStringValue(); } },
                {"tollNumbers", n => { TollNumbers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("conferenceId", ConferenceId);
            writer.WriteStringValue("dialinUrl", DialinUrl);
            writer.WriteStringValue("tollFreeNumber", TollFreeNumber);
            writer.WriteCollectionOfPrimitiveValues<string>("tollFreeNumbers", TollFreeNumbers);
            writer.WriteStringValue("tollNumber", TollNumber);
            writer.WriteCollectionOfPrimitiveValues<string>("tollNumbers", TollNumbers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
