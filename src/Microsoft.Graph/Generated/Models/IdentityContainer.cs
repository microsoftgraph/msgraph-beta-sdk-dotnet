using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IdentityContainer : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Represents entry point for API connectors.</summary>
        public List<IdentityApiConnector> ApiConnectors {
            get { return BackingStore?.Get<List<IdentityApiConnector>>("apiConnectors"); }
            set { BackingStore?.Set("apiConnectors", value); }
        }
        /// <summary>The authenticationEventListeners property</summary>
        public List<AuthenticationEventListener> AuthenticationEventListeners {
            get { return BackingStore?.Get<List<AuthenticationEventListener>>("authenticationEventListeners"); }
            set { BackingStore?.Set("authenticationEventListeners", value); }
        }
        /// <summary>Represents entry point for B2C identity userflows.</summary>
        public List<B2cIdentityUserFlow> B2cUserFlows {
            get { return BackingStore?.Get<List<B2cIdentityUserFlow>>("b2cUserFlows"); }
            set { BackingStore?.Set("b2cUserFlows", value); }
        }
        /// <summary>Represents entry point for B2X and self-service sign-up identity userflows.</summary>
        public List<B2xIdentityUserFlow> B2xUserFlows {
            get { return BackingStore?.Get<List<B2xIdentityUserFlow>>("b2xUserFlows"); }
            set { BackingStore?.Set("b2xUserFlows", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>the entry point for the Conditional Access (CA) object model.</summary>
        public ConditionalAccessRoot ConditionalAccess {
            get { return BackingStore?.Get<ConditionalAccessRoot>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
        /// <summary>Represents entry point for continuous access evaluation policy.</summary>
        public Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy ContinuousAccessEvaluationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy"); }
            set { BackingStore?.Set("continuousAccessEvaluationPolicy", value); }
        }
        /// <summary>The customAuthenticationExtensions property</summary>
        public List<CustomAuthenticationExtension> CustomAuthenticationExtensions {
            get { return BackingStore?.Get<List<CustomAuthenticationExtension>>("customAuthenticationExtensions"); }
            set { BackingStore?.Set("customAuthenticationExtensions", value); }
        }
        /// <summary>Represents entry point for identity provider base.</summary>
        public List<IdentityProviderBase> IdentityProviders {
            get { return BackingStore?.Get<List<IdentityProviderBase>>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Represents entry point for identity userflow attributes.</summary>
        public List<IdentityUserFlowAttribute> UserFlowAttributes {
            get { return BackingStore?.Get<List<IdentityUserFlowAttribute>>("userFlowAttributes"); }
            set { BackingStore?.Set("userFlowAttributes", value); }
        }
        /// <summary>The userFlows property</summary>
        public List<IdentityUserFlow> UserFlows {
            get { return BackingStore?.Get<List<IdentityUserFlow>>("userFlows"); }
            set { BackingStore?.Set("userFlows", value); }
        }
        /// <summary>
        /// Instantiates a new IdentityContainer and sets the default values.
        /// </summary>
        public IdentityContainer() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.identityContainer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IdentityContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"apiConnectors", n => { ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationEventListeners", n => { AuthenticationEventListeners = n.GetCollectionOfObjectValues<AuthenticationEventListener>(AuthenticationEventListener.CreateFromDiscriminatorValue)?.ToList(); } },
                {"b2cUserFlows", n => { B2cUserFlows = n.GetCollectionOfObjectValues<B2cIdentityUserFlow>(B2cIdentityUserFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"b2xUserFlows", n => { B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccess", n => { ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(ConditionalAccessRoot.CreateFromDiscriminatorValue); } },
                {"continuousAccessEvaluationPolicy", n => { ContinuousAccessEvaluationPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>(Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy.CreateFromDiscriminatorValue); } },
                {"customAuthenticationExtensions", n => { CustomAuthenticationExtensions = n.GetCollectionOfObjectValues<CustomAuthenticationExtension>(CustomAuthenticationExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"userFlowAttributes", n => { UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userFlows", n => { UserFlows = n.GetCollectionOfObjectValues<IdentityUserFlow>(IdentityUserFlow.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<IdentityApiConnector>("apiConnectors", ApiConnectors);
            writer.WriteCollectionOfObjectValues<AuthenticationEventListener>("authenticationEventListeners", AuthenticationEventListeners);
            writer.WriteCollectionOfObjectValues<B2cIdentityUserFlow>("b2cUserFlows", B2cUserFlows);
            writer.WriteCollectionOfObjectValues<B2xIdentityUserFlow>("b2xUserFlows", B2xUserFlows);
            writer.WriteObjectValue<ConditionalAccessRoot>("conditionalAccess", ConditionalAccess);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy", ContinuousAccessEvaluationPolicy);
            writer.WriteCollectionOfObjectValues<CustomAuthenticationExtension>("customAuthenticationExtensions", CustomAuthenticationExtensions);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
            writer.WriteCollectionOfObjectValues<IdentityUserFlow>("userFlows", UserFlows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
