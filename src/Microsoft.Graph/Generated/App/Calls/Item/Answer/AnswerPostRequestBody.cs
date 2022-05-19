using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.App.Calls.Item.Answer {
    /// <summary>Provides operations to call the answer method.</summary>
    public class AnswerPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The acceptedModalities property</summary>
        public List<string> AcceptedModalities {
            get { return BackingStore?.Get<List<string>>(nameof(AcceptedModalities)); }
            set { BackingStore?.Set(nameof(AcceptedModalities), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The callbackUri property</summary>
        public string CallbackUri {
            get { return BackingStore?.Get<string>(nameof(CallbackUri)); }
            set { BackingStore?.Set(nameof(CallbackUri), value); }
        }
        /// <summary>The callOptions property</summary>
        public IncomingCallOptions CallOptions {
            get { return BackingStore?.Get<IncomingCallOptions>(nameof(CallOptions)); }
            set { BackingStore?.Set(nameof(CallOptions), value); }
        }
        /// <summary>The mediaConfig property</summary>
        public Microsoft.Graph.Beta.Models.MediaConfig MediaConfig {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaConfig>(nameof(MediaConfig)); }
            set { BackingStore?.Set(nameof(MediaConfig), value); }
        }
        /// <summary>The participantCapacity property</summary>
        public int? ParticipantCapacity {
            get { return BackingStore?.Get<int?>(nameof(ParticipantCapacity)); }
            set { BackingStore?.Set(nameof(ParticipantCapacity), value); }
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
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AnswerPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnswerPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acceptedModalities", n => { AcceptedModalities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"callOptions", n => { CallOptions = n.GetObjectValue<IncomingCallOptions>(IncomingCallOptions.CreateFromDiscriminatorValue); } },
                {"mediaConfig", n => { MediaConfig = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaConfig>(Microsoft.Graph.Beta.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                {"participantCapacity", n => { ParticipantCapacity = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("acceptedModalities", AcceptedModalities);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteObjectValue<IncomingCallOptions>("callOptions", CallOptions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteIntValue("participantCapacity", ParticipantCapacity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
