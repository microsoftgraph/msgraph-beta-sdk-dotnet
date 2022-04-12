using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the directory singleton.</summary>
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
        /// <summary>The impactedResources property</summary>
        public List<RecommendationResource> ImpactedResources { get; set; }
        /// <summary>The inboundSharedUserProfiles property</summary>
        public List<InboundSharedUserProfile> InboundSharedUserProfiles { get; set; }
        /// <summary>The outboundSharedUserProfiles property</summary>
        public List<OutboundSharedUserProfile> OutboundSharedUserProfiles { get; set; }
        /// <summary>The recommendations property</summary>
        public List<Recommendation> Recommendations { get; set; }
        /// <summary>The sharedEmailDomains property</summary>
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<AdministrativeUnit>(AdministrativeUnit.CreateFromDiscriminatorValue).ToList(); } },
                {"attributeSets", n => { AttributeSets = n.GetCollectionOfObjectValues<AttributeSet>(AttributeSet.CreateFromDiscriminatorValue).ToList(); } },
                {"customSecurityAttributeDefinitions", n => { CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<CustomSecurityAttributeDefinition>(CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue).ToList(); } },
                {"impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<RecommendationResource>(RecommendationResource.CreateFromDiscriminatorValue).ToList(); } },
                {"inboundSharedUserProfiles", n => { InboundSharedUserProfiles = n.GetCollectionOfObjectValues<InboundSharedUserProfile>(InboundSharedUserProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"outboundSharedUserProfiles", n => { OutboundSharedUserProfiles = n.GetCollectionOfObjectValues<OutboundSharedUserProfile>(OutboundSharedUserProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"recommendations", n => { Recommendations = n.GetCollectionOfObjectValues<Recommendation>(Recommendation.CreateFromDiscriminatorValue).ToList(); } },
                {"sharedEmailDomains", n => { SharedEmailDomains = n.GetCollectionOfObjectValues<SharedEmailDomain>(SharedEmailDomain.CreateFromDiscriminatorValue).ToList(); } },
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
