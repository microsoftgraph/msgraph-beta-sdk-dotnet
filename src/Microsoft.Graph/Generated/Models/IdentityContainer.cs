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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Represents entry point for API connectors.</summary>
        public List<IdentityApiConnector> ApiConnectors {
            get { return BackingStore?.Get<List<IdentityApiConnector>>(nameof(ApiConnectors)); }
            set { BackingStore?.Set(nameof(ApiConnectors), value); }
        }
        /// <summary>Represents entry point for B2C identity userflows.</summary>
        public List<B2cIdentityUserFlow> B2cUserFlows {
            get { return BackingStore?.Get<List<B2cIdentityUserFlow>>(nameof(B2cUserFlows)); }
            set { BackingStore?.Set(nameof(B2cUserFlows), value); }
        }
        /// <summary>Represents entry point for B2X and self-service sign-up identity userflows.</summary>
        public List<B2xIdentityUserFlow> B2xUserFlows {
            get { return BackingStore?.Get<List<B2xIdentityUserFlow>>(nameof(B2xUserFlows)); }
            set { BackingStore?.Set(nameof(B2xUserFlows), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>the entry point for the Conditional Access (CA) object model.</summary>
        public ConditionalAccessRoot ConditionalAccess {
            get { return BackingStore?.Get<ConditionalAccessRoot>(nameof(ConditionalAccess)); }
            set { BackingStore?.Set(nameof(ConditionalAccess), value); }
        }
        /// <summary>Represents entry point for continuous access evaluation policy.</summary>
        public Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy ContinuousAccessEvaluationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>(nameof(ContinuousAccessEvaluationPolicy)); }
            set { BackingStore?.Set(nameof(ContinuousAccessEvaluationPolicy), value); }
        }
        /// <summary>Represents entry point for identity provider base.</summary>
        public List<IdentityProviderBase> IdentityProviders {
            get { return BackingStore?.Get<List<IdentityProviderBase>>(nameof(IdentityProviders)); }
            set { BackingStore?.Set(nameof(IdentityProviders), value); }
        }
        /// <summary>Represents entry point for identity userflow attributes.</summary>
        public List<IdentityUserFlowAttribute> UserFlowAttributes {
            get { return BackingStore?.Get<List<IdentityUserFlowAttribute>>(nameof(UserFlowAttributes)); }
            set { BackingStore?.Set(nameof(UserFlowAttributes), value); }
        }
        /// <summary>The userFlows property</summary>
        public List<IdentityUserFlow> UserFlows {
            get { return BackingStore?.Get<List<IdentityUserFlow>>(nameof(UserFlows)); }
            set { BackingStore?.Set(nameof(UserFlows), value); }
        }
        /// <summary>
        /// Instantiates a new IdentityContainer and sets the default values.
        /// </summary>
        public IdentityContainer() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
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
                {"apiConnectors", n => { ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"b2cUserFlows", n => { B2cUserFlows = n.GetCollectionOfObjectValues<B2cIdentityUserFlow>(B2cIdentityUserFlow.CreateFromDiscriminatorValue).ToList(); } },
                {"b2xUserFlows", n => { B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccess", n => { ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(ConditionalAccessRoot.CreateFromDiscriminatorValue); } },
                {"continuousAccessEvaluationPolicy", n => { ContinuousAccessEvaluationPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>(Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy.CreateFromDiscriminatorValue); } },
                {"identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue).ToList(); } },
                {"userFlowAttributes", n => { UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue).ToList(); } },
                {"userFlows", n => { UserFlows = n.GetCollectionOfObjectValues<IdentityUserFlow>(IdentityUserFlow.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<IdentityApiConnector>("apiConnectors", ApiConnectors);
            writer.WriteCollectionOfObjectValues<B2cIdentityUserFlow>("b2cUserFlows", B2cUserFlows);
            writer.WriteCollectionOfObjectValues<B2xIdentityUserFlow>("b2xUserFlows", B2xUserFlows);
            writer.WriteObjectValue<ConditionalAccessRoot>("conditionalAccess", ConditionalAccess);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy", ContinuousAccessEvaluationPolicy);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
            writer.WriteCollectionOfObjectValues<IdentityUserFlow>("userFlows", UserFlows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
