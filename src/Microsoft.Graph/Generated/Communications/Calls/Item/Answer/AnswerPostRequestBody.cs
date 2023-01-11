using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Communications.Calls.Item.Answer {
    public class AnswerPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The acceptedModalities property</summary>
        public List<Modality?> AcceptedModalities {
            get { return BackingStore?.Get<List<Modality?>>("acceptedModalities"); }
            set { BackingStore?.Set("acceptedModalities", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The callbackUri property</summary>
        public string CallbackUri {
            get { return BackingStore?.Get<string>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
        /// <summary>The callOptions property</summary>
        public IncomingCallOptions CallOptions {
            get { return BackingStore?.Get<IncomingCallOptions>("callOptions"); }
            set { BackingStore?.Set("callOptions", value); }
        }
        /// <summary>The mediaConfig property</summary>
        public Microsoft.Graph.Beta.Models.MediaConfig MediaConfig {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaConfig>("mediaConfig"); }
            set { BackingStore?.Set("mediaConfig", value); }
        }
        /// <summary>The participantCapacity property</summary>
        public int? ParticipantCapacity {
            get { return BackingStore?.Get<int?>("participantCapacity"); }
            set { BackingStore?.Set("participantCapacity", value); }
        }
        /// <summary>
        /// Instantiates a new answerPostRequestBody and sets the default values.
        /// </summary>
        public AnswerPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AnswerPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnswerPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acceptedModalities", n => { AcceptedModalities = n.GetCollectionOfEnumValues<Modality>()?.ToList(); } },
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"callOptions", n => { CallOptions = n.GetObjectValue<IncomingCallOptions>(IncomingCallOptions.CreateFromDiscriminatorValue); } },
                {"mediaConfig", n => { MediaConfig = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaConfig>(Microsoft.Graph.Beta.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                {"participantCapacity", n => { ParticipantCapacity = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<Modality>("acceptedModalities", AcceptedModalities);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteObjectValue<IncomingCallOptions>("callOptions", CallOptions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteIntValue("participantCapacity", ParticipantCapacity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
