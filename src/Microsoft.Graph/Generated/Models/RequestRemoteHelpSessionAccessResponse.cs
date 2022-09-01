using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Remote help - response we provide back to the helper after getting response from pubSub</summary>
    public class RequestRemoteHelpSessionAccessResponse : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>AES encryption Initialization Vector for encrypting client messages sent to PubSub</summary>
        public string PubSubEncryption {
            get { return BackingStore?.Get<string>("pubSubEncryption"); }
            set { BackingStore?.Set("pubSubEncryption", value); }
        }
        /// <summary>The unique identifier for encrypting client messages sent to PubSub</summary>
        public string PubSubEncryptionKey {
            get { return BackingStore?.Get<string>("pubSubEncryptionKey"); }
            set { BackingStore?.Set("pubSubEncryptionKey", value); }
        }
        /// <summary>The unique identifier for a session</summary>
        public string SessionKey {
            get { return BackingStore?.Get<string>("sessionKey"); }
            set { BackingStore?.Set("sessionKey", value); }
        }
        /// <summary>
        /// Instantiates a new requestRemoteHelpSessionAccessResponse and sets the default values.
        /// </summary>
        public RequestRemoteHelpSessionAccessResponse() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.requestRemoteHelpSessionAccessResponse";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RequestRemoteHelpSessionAccessResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RequestRemoteHelpSessionAccessResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"pubSubEncryption", n => { PubSubEncryption = n.GetStringValue(); } },
                {"pubSubEncryptionKey", n => { PubSubEncryptionKey = n.GetStringValue(); } },
                {"sessionKey", n => { SessionKey = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("pubSubEncryption", PubSubEncryption);
            writer.WriteStringValue("pubSubEncryptionKey", PubSubEncryptionKey);
            writer.WriteStringValue("sessionKey", SessionKey);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
