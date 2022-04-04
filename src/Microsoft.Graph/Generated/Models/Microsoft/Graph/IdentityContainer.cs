using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class IdentityContainer : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents entry point for API connectors.</summary>
        public List<IdentityApiConnector> ApiConnectors { get; set; }
        /// <summary>Represents entry point for B2C identity userflows.</summary>
        public List<B2cIdentityUserFlow> B2cUserFlows { get; set; }
        /// <summary>Represents entry point for B2X/self-service sign-up identity userflows.</summary>
        public List<B2xIdentityUserFlow> B2xUserFlows { get; set; }
        /// <summary>the entry point for the Conditional Access (CA) object model.</summary>
        public ConditionalAccessRoot ConditionalAccess { get; set; }
        /// <summary>Represents entry point for continuous access evaluation policy.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ContinuousAccessEvaluationPolicy ContinuousAccessEvaluationPolicy { get; set; }
        /// <summary>Represents entry point for identity provider base.</summary>
        public List<IdentityProviderBase> IdentityProviders { get; set; }
        /// <summary>Represents entry point for identity userflow attributes.</summary>
        public List<IdentityUserFlowAttribute> UserFlowAttributes { get; set; }
        /// <summary>The userFlows property</summary>
        public List<IdentityUserFlow> UserFlows { get; set; }
        /// <summary>
        /// Instantiates a new IdentityContainer and sets the default values.
        /// </summary>
        public IdentityContainer() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"apiConnectors", (o,n) => { (o as IdentityContainer).ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"b2cUserFlows", (o,n) => { (o as IdentityContainer).B2cUserFlows = n.GetCollectionOfObjectValues<B2cIdentityUserFlow>(B2cIdentityUserFlow.CreateFromDiscriminatorValue).ToList(); } },
                {"b2xUserFlows", (o,n) => { (o as IdentityContainer).B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccess", (o,n) => { (o as IdentityContainer).ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(ConditionalAccessRoot.CreateFromDiscriminatorValue); } },
                {"continuousAccessEvaluationPolicy", (o,n) => { (o as IdentityContainer).ContinuousAccessEvaluationPolicy = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ContinuousAccessEvaluationPolicy>(MicrosoftGraphSdk.Models.Microsoft.Graph.ContinuousAccessEvaluationPolicy.CreateFromDiscriminatorValue); } },
                {"identityProviders", (o,n) => { (o as IdentityContainer).IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue).ToList(); } },
                {"userFlowAttributes", (o,n) => { (o as IdentityContainer).UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue).ToList(); } },
                {"userFlows", (o,n) => { (o as IdentityContainer).UserFlows = n.GetCollectionOfObjectValues<IdentityUserFlow>(IdentityUserFlow.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy", ContinuousAccessEvaluationPolicy);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
            writer.WriteCollectionOfObjectValues<IdentityUserFlow>("userFlows", UserFlows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
