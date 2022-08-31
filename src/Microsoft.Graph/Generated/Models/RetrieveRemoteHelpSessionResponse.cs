using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Remote help - response we provide back to the helper on retrieve session API call</summary>
    public class RetrieveRemoteHelpSessionResponse : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>ACS Group Id</summary>
        public string AcsGroupId {
            get { return BackingStore?.Get<string>("acsGroupId"); }
            set { BackingStore?.Set("acsGroupId", value); }
        }
        /// <summary>Helper ACS User Id</summary>
        public string AcsHelperUserId {
            get { return BackingStore?.Get<string>("acsHelperUserId"); }
            set { BackingStore?.Set("acsHelperUserId", value); }
        }
        /// <summary>Helper ACS User Token</summary>
        public string AcsHelperUserToken {
            get { return BackingStore?.Get<string>("acsHelperUserToken"); }
            set { BackingStore?.Set("acsHelperUserToken", value); }
        }
        /// <summary>Sharer ACS User Id</summary>
        public string AcsSharerUserId {
            get { return BackingStore?.Get<string>("acsSharerUserId"); }
            set { BackingStore?.Set("acsSharerUserId", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Android Device Name</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Azure Pubsub Group Id</summary>
        public string PubSubGroupId {
            get { return BackingStore?.Get<string>("pubSubGroupId"); }
            set { BackingStore?.Set("pubSubGroupId", value); }
        }
        /// <summary>Azure Pubsub Group Id</summary>
        public string PubSubHelperAccessUri {
            get { return BackingStore?.Get<string>("pubSubHelperAccessUri"); }
            set { BackingStore?.Set("pubSubHelperAccessUri", value); }
        }
        /// <summary>Azure Pubsub Session Expiration Date Time.</summary>
        public DateTimeOffset? SessionExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("sessionExpirationDateTime"); }
            set { BackingStore?.Set("sessionExpirationDateTime", value); }
        }
        /// <summary>The unique identifier for a session</summary>
        public string SessionKey {
            get { return BackingStore?.Get<string>("sessionKey"); }
            set { BackingStore?.Set("sessionKey", value); }
        }
        /// <summary>
        /// Instantiates a new retrieveRemoteHelpSessionResponse and sets the default values.
        /// </summary>
        public RetrieveRemoteHelpSessionResponse() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.retrieveRemoteHelpSessionResponse";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RetrieveRemoteHelpSessionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetrieveRemoteHelpSessionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acsGroupId", n => { AcsGroupId = n.GetStringValue(); } },
                {"acsHelperUserId", n => { AcsHelperUserId = n.GetStringValue(); } },
                {"acsHelperUserToken", n => { AcsHelperUserToken = n.GetStringValue(); } },
                {"acsSharerUserId", n => { AcsSharerUserId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"pubSubGroupId", n => { PubSubGroupId = n.GetStringValue(); } },
                {"pubSubHelperAccessUri", n => { PubSubHelperAccessUri = n.GetStringValue(); } },
                {"sessionExpirationDateTime", n => { SessionExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"sessionKey", n => { SessionKey = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("acsGroupId", AcsGroupId);
            writer.WriteStringValue("acsHelperUserId", AcsHelperUserId);
            writer.WriteStringValue("acsHelperUserToken", AcsHelperUserToken);
            writer.WriteStringValue("acsSharerUserId", AcsSharerUserId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("pubSubGroupId", PubSubGroupId);
            writer.WriteStringValue("pubSubHelperAccessUri", PubSubHelperAccessUri);
            writer.WriteDateTimeOffsetValue("sessionExpirationDateTime", SessionExpirationDateTime);
            writer.WriteStringValue("sessionKey", SessionKey);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
