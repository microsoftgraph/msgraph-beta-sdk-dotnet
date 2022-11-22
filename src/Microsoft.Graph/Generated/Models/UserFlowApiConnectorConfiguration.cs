using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserFlowApiConnectorConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>The postAttributeCollection property</summary>
        public IdentityApiConnector PostAttributeCollection {
            get { return BackingStore?.Get<IdentityApiConnector>("postAttributeCollection"); }
            set { BackingStore?.Set("postAttributeCollection", value); }
        }
        /// <summary>The postFederationSignup property</summary>
        public IdentityApiConnector PostFederationSignup {
            get { return BackingStore?.Get<IdentityApiConnector>("postFederationSignup"); }
            set { BackingStore?.Set("postFederationSignup", value); }
        }
        /// <summary>The preTokenIssuance property</summary>
        public IdentityApiConnector PreTokenIssuance {
            get { return BackingStore?.Get<IdentityApiConnector>("preTokenIssuance"); }
            set { BackingStore?.Set("preTokenIssuance", value); }
        }
        /// <summary>
        /// Instantiates a new userFlowApiConnectorConfiguration and sets the default values.
        /// </summary>
        public UserFlowApiConnectorConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserFlowApiConnectorConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserFlowApiConnectorConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"postAttributeCollection", n => { PostAttributeCollection = n.GetObjectValue<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue); } },
                {"postFederationSignup", n => { PostFederationSignup = n.GetObjectValue<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue); } },
                {"preTokenIssuance", n => { PreTokenIssuance = n.GetObjectValue<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<IdentityApiConnector>("postAttributeCollection", PostAttributeCollection);
            writer.WriteObjectValue<IdentityApiConnector>("postFederationSignup", PostFederationSignup);
            writer.WriteObjectValue<IdentityApiConnector>("preTokenIssuance", PreTokenIssuance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
