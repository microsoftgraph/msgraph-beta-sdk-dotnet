using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.ManagedDevices.Item.RequestRemoteHelpSessionAccess {
    public class RequestRemoteHelpSessionAccessPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The pubSubConnectionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PubSubConnectionId {
            get { return BackingStore?.Get<string?>("pubSubConnectionId"); }
            set { BackingStore?.Set("pubSubConnectionId", value); }
        }
#nullable restore
#else
        public string PubSubConnectionId {
            get { return BackingStore?.Get<string>("pubSubConnectionId"); }
            set { BackingStore?.Set("pubSubConnectionId", value); }
        }
#endif
        /// <summary>The sessionKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionKey {
            get { return BackingStore?.Get<string?>("sessionKey"); }
            set { BackingStore?.Set("sessionKey", value); }
        }
#nullable restore
#else
        public string SessionKey {
            get { return BackingStore?.Get<string>("sessionKey"); }
            set { BackingStore?.Set("sessionKey", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new requestRemoteHelpSessionAccessPostRequestBody and sets the default values.
        /// </summary>
        public RequestRemoteHelpSessionAccessPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RequestRemoteHelpSessionAccessPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RequestRemoteHelpSessionAccessPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"pubSubConnectionId", n => { PubSubConnectionId = n.GetStringValue(); } },
                {"sessionKey", n => { SessionKey = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("pubSubConnectionId", PubSubConnectionId);
            writer.WriteStringValue("sessionKey", SessionKey);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
