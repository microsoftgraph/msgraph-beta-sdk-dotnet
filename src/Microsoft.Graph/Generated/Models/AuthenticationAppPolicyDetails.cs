using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationAppPolicyDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The adminConfiguration property</summary>
        public AuthenticationAppAdminConfiguration? AdminConfiguration {
            get { return BackingStore?.Get<AuthenticationAppAdminConfiguration?>("adminConfiguration"); }
            set { BackingStore?.Set("adminConfiguration", value); }
        }
        /// <summary>The authenticationEvaluation property</summary>
        public AuthenticationAppEvaluation? AuthenticationEvaluation {
            get { return BackingStore?.Get<AuthenticationAppEvaluation?>("authenticationEvaluation"); }
            set { BackingStore?.Set("authenticationEvaluation", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The policyName property</summary>
        public string PolicyName {
            get { return BackingStore?.Get<string>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
        /// <summary>The status property</summary>
        public AuthenticationAppPolicyStatus? Status {
            get { return BackingStore?.Get<AuthenticationAppPolicyStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new authenticationAppPolicyDetails and sets the default values.
        /// </summary>
        public AuthenticationAppPolicyDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.authenticationAppPolicyDetails";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationAppPolicyDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationAppPolicyDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"adminConfiguration", n => { AdminConfiguration = n.GetEnumValue<AuthenticationAppAdminConfiguration>(); } },
                {"authenticationEvaluation", n => { AuthenticationEvaluation = n.GetEnumValue<AuthenticationAppEvaluation>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"policyName", n => { PolicyName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<AuthenticationAppPolicyStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AuthenticationAppAdminConfiguration>("adminConfiguration", AdminConfiguration);
            writer.WriteEnumValue<AuthenticationAppEvaluation>("authenticationEvaluation", AuthenticationEvaluation);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteEnumValue<AuthenticationAppPolicyStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
