using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Directory : Entity, IParsable {
        /// <summary>Conceptual container for user and group directory objects.</summary>
        public List<AdministrativeUnit> AdministrativeUnits { get; set; }
        /// <summary>Group of related custom security attribute definitions.</summary>
        public List<AttributeSet> AttributeSets { get; set; }
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
        public List<CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions { get; set; }
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
        public List<DirectoryObject> DeletedItems { get; set; }
        /// <summary>Nullable.</summary>
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
        public List<IdentityProviderBase> FederationConfigurations { get; set; }
        public List<RecommendationResource> ImpactedResources { get; set; }
        public List<InboundSharedUserProfile> InboundSharedUserProfiles { get; set; }
        public List<OutboundSharedUserProfile> OutboundSharedUserProfiles { get; set; }
        public List<Recommendation> Recommendations { get; set; }
        public List<SharedEmailDomain> SharedEmailDomains { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Directory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Directory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"administrativeUnits", (o,n) => { (o as Directory).AdministrativeUnits = n.GetCollectionOfObjectValues<AdministrativeUnit>(AdministrativeUnit.CreateFromDiscriminatorValue).ToList(); } },
                {"attributeSets", (o,n) => { (o as Directory).AttributeSets = n.GetCollectionOfObjectValues<AttributeSet>(AttributeSet.CreateFromDiscriminatorValue).ToList(); } },
                {"customSecurityAttributeDefinitions", (o,n) => { (o as Directory).CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<CustomSecurityAttributeDefinition>(CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"deletedItems", (o,n) => { (o as Directory).DeletedItems = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"featureRolloutPolicies", (o,n) => { (o as Directory).FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"federationConfigurations", (o,n) => { (o as Directory).FederationConfigurations = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue).ToList(); } },
                {"impactedResources", (o,n) => { (o as Directory).ImpactedResources = n.GetCollectionOfObjectValues<RecommendationResource>(RecommendationResource.CreateFromDiscriminatorValue).ToList(); } },
                {"inboundSharedUserProfiles", (o,n) => { (o as Directory).InboundSharedUserProfiles = n.GetCollectionOfObjectValues<InboundSharedUserProfile>(InboundSharedUserProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"outboundSharedUserProfiles", (o,n) => { (o as Directory).OutboundSharedUserProfiles = n.GetCollectionOfObjectValues<OutboundSharedUserProfile>(OutboundSharedUserProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"recommendations", (o,n) => { (o as Directory).Recommendations = n.GetCollectionOfObjectValues<Recommendation>(Recommendation.CreateFromDiscriminatorValue).ToList(); } },
                {"sharedEmailDomains", (o,n) => { (o as Directory).SharedEmailDomains = n.GetCollectionOfObjectValues<SharedEmailDomain>(SharedEmailDomain.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<AttributeSet>("attributeSets", AttributeSets);
            writer.WriteCollectionOfObjectValues<CustomSecurityAttributeDefinition>("customSecurityAttributeDefinitions", CustomSecurityAttributeDefinitions);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("deletedItems", DeletedItems);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("federationConfigurations", FederationConfigurations);
            writer.WriteCollectionOfObjectValues<RecommendationResource>("impactedResources", ImpactedResources);
            writer.WriteCollectionOfObjectValues<InboundSharedUserProfile>("inboundSharedUserProfiles", InboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<OutboundSharedUserProfile>("outboundSharedUserProfiles", OutboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<Recommendation>("recommendations", Recommendations);
            writer.WriteCollectionOfObjectValues<SharedEmailDomain>("sharedEmailDomains", SharedEmailDomains);
        }
    }
}
