using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class IdentityContainer : IParsable {
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
        public MicrosoftGraph.Models.Microsoft.Graph.ContinuousAccessEvaluationPolicy ContinuousAccessEvaluationPolicy { get; set; }
        /// <summary>Represents entry point for identity provider base.</summary>
        public List<IdentityProviderBase> IdentityProviders { get; set; }
        /// <summary>Represents entry point for identity userflow attributes.</summary>
        public List<IdentityUserFlowAttribute> UserFlowAttributes { get; set; }
        public List<IdentityUserFlow> UserFlows { get; set; }
        /// <summary>
        /// Instantiates a new IdentityContainer and sets the default values.
        /// </summary>
        public IdentityContainer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"apiConnectors", (o,n) => { (o as IdentityContainer).ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>().ToList(); } },
                {"b2cUserFlows", (o,n) => { (o as IdentityContainer).B2cUserFlows = n.GetCollectionOfObjectValues<B2cIdentityUserFlow>().ToList(); } },
                {"b2xUserFlows", (o,n) => { (o as IdentityContainer).B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>().ToList(); } },
                {"conditionalAccess", (o,n) => { (o as IdentityContainer).ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(); } },
                {"continuousAccessEvaluationPolicy", (o,n) => { (o as IdentityContainer).ContinuousAccessEvaluationPolicy = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ContinuousAccessEvaluationPolicy>(); } },
                {"identityProviders", (o,n) => { (o as IdentityContainer).IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>().ToList(); } },
                {"userFlowAttributes", (o,n) => { (o as IdentityContainer).UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>().ToList(); } },
                {"userFlows", (o,n) => { (o as IdentityContainer).UserFlows = n.GetCollectionOfObjectValues<IdentityUserFlow>().ToList(); } },
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
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy", ContinuousAccessEvaluationPolicy);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
            writer.WriteCollectionOfObjectValues<IdentityUserFlow>("userFlows", UserFlows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
