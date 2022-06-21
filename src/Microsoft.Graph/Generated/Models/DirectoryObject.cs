using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the directory singleton.</summary>
    public class DirectoryObject : Entity, IParsable {
        /// <summary>Conceptual container for user and group directory objects.</summary>
        public List<AdministrativeUnit> AdministrativeUnits {
            get { return BackingStore?.Get<List<AdministrativeUnit>>(nameof(AdministrativeUnits)); }
            set { BackingStore?.Set(nameof(AdministrativeUnits), value); }
        }
        /// <summary>Group of related custom security attribute definitions.</summary>
        public List<AttributeSet> AttributeSets {
            get { return BackingStore?.Get<List<AttributeSet>>(nameof(AttributeSets)); }
            set { BackingStore?.Set(nameof(AttributeSets), value); }
        }
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
        public List<CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions {
            get { return BackingStore?.Get<List<CustomSecurityAttributeDefinition>>(nameof(CustomSecurityAttributeDefinitions)); }
            set { BackingStore?.Set(nameof(CustomSecurityAttributeDefinitions), value); }
        }
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
        public List<DirectoryObject> DeletedItems {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(DeletedItems)); }
            set { BackingStore?.Set(nameof(DeletedItems), value); }
        }
        /// <summary>The featureRolloutPolicies property</summary>
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies {
            get { return BackingStore?.Get<List<FeatureRolloutPolicy>>(nameof(FeatureRolloutPolicies)); }
            set { BackingStore?.Set(nameof(FeatureRolloutPolicies), value); }
        }
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
        public List<IdentityProviderBase> FederationConfigurations {
            get { return BackingStore?.Get<List<IdentityProviderBase>>(nameof(FederationConfigurations)); }
            set { BackingStore?.Set(nameof(FederationConfigurations), value); }
        }
        /// <summary>The impactedResources property</summary>
        public List<RecommendationResource> ImpactedResources {
            get { return BackingStore?.Get<List<RecommendationResource>>(nameof(ImpactedResources)); }
            set { BackingStore?.Set(nameof(ImpactedResources), value); }
        }
        /// <summary>The inboundSharedUserProfiles property</summary>
        public List<InboundSharedUserProfile> InboundSharedUserProfiles {
            get { return BackingStore?.Get<List<InboundSharedUserProfile>>(nameof(InboundSharedUserProfiles)); }
            set { BackingStore?.Set(nameof(InboundSharedUserProfiles), value); }
        }
        /// <summary>The outboundSharedUserProfiles property</summary>
        public List<OutboundSharedUserProfile> OutboundSharedUserProfiles {
            get { return BackingStore?.Get<List<OutboundSharedUserProfile>>(nameof(OutboundSharedUserProfiles)); }
            set { BackingStore?.Set(nameof(OutboundSharedUserProfiles), value); }
        }
        /// <summary>The recommendations property</summary>
        public List<Recommendation> Recommendations {
            get { return BackingStore?.Get<List<Recommendation>>(nameof(Recommendations)); }
            set { BackingStore?.Set(nameof(Recommendations), value); }
        }
        /// <summary>The sharedEmailDomains property</summary>
        public List<SharedEmailDomain> SharedEmailDomains {
            get { return BackingStore?.Get<List<SharedEmailDomain>>(nameof(SharedEmailDomains)); }
            set { BackingStore?.Set(nameof(SharedEmailDomains), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DirectoryObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryObject();
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
