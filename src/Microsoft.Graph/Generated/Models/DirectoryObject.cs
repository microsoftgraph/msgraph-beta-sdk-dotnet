using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DirectoryObject : Entity, IParsable {
        /// <summary>Conceptual container for user and group directory objects.</summary>
        public List<AdministrativeUnit> AdministrativeUnits {
            get { return BackingStore?.Get<List<AdministrativeUnit>>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
        /// <summary>Group of related custom security attribute definitions.</summary>
        public List<AttributeSet> AttributeSets {
            get { return BackingStore?.Get<List<AttributeSet>>("attributeSets"); }
            set { BackingStore?.Set("attributeSets", value); }
        }
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
        public List<CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions {
            get { return BackingStore?.Get<List<CustomSecurityAttributeDefinition>>("customSecurityAttributeDefinitions"); }
            set { BackingStore?.Set("customSecurityAttributeDefinitions", value); }
        }
        /// <summary>The deletedItems property</summary>
        public List<DirectoryObject> DeletedItems {
            get { return BackingStore?.Get<List<DirectoryObject>>("deletedItems"); }
            set { BackingStore?.Set("deletedItems", value); }
        }
        /// <summary>The featureRolloutPolicies property</summary>
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies {
            get { return BackingStore?.Get<List<FeatureRolloutPolicy>>("featureRolloutPolicies"); }
            set { BackingStore?.Set("featureRolloutPolicies", value); }
        }
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
        public List<IdentityProviderBase> FederationConfigurations {
            get { return BackingStore?.Get<List<IdentityProviderBase>>("federationConfigurations"); }
            set { BackingStore?.Set("federationConfigurations", value); }
        }
        /// <summary>The impactedResources property</summary>
        public List<RecommendationResource> ImpactedResources {
            get { return BackingStore?.Get<List<RecommendationResource>>("impactedResources"); }
            set { BackingStore?.Set("impactedResources", value); }
        }
        /// <summary>The inboundSharedUserProfiles property</summary>
        public List<InboundSharedUserProfile> InboundSharedUserProfiles {
            get { return BackingStore?.Get<List<InboundSharedUserProfile>>("inboundSharedUserProfiles"); }
            set { BackingStore?.Set("inboundSharedUserProfiles", value); }
        }
        /// <summary>A container for on-premises directory synchronization functionalities that are available for the organization.</summary>
        public List<OnPremisesDirectorySynchronization> OnPremisesSynchronization {
            get { return BackingStore?.Get<List<OnPremisesDirectorySynchronization>>("onPremisesSynchronization"); }
            set { BackingStore?.Set("onPremisesSynchronization", value); }
        }
        /// <summary>The outboundSharedUserProfiles property</summary>
        public List<OutboundSharedUserProfile> OutboundSharedUserProfiles {
            get { return BackingStore?.Get<List<OutboundSharedUserProfile>>("outboundSharedUserProfiles"); }
            set { BackingStore?.Set("outboundSharedUserProfiles", value); }
        }
        /// <summary>The recommendations property</summary>
        public List<Recommendation> Recommendations {
            get { return BackingStore?.Get<List<Recommendation>>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
        /// <summary>The sharedEmailDomains property</summary>
        public List<SharedEmailDomain> SharedEmailDomains {
            get { return BackingStore?.Get<List<SharedEmailDomain>>("sharedEmailDomains"); }
            set { BackingStore?.Set("sharedEmailDomains", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<AdministrativeUnit>(AdministrativeUnit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attributeSets", n => { AttributeSets = n.GetCollectionOfObjectValues<AttributeSet>(AttributeSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customSecurityAttributeDefinitions", n => { CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<CustomSecurityAttributeDefinition>(CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<RecommendationResource>(RecommendationResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"inboundSharedUserProfiles", n => { InboundSharedUserProfiles = n.GetCollectionOfObjectValues<InboundSharedUserProfile>(InboundSharedUserProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesSynchronization", n => { OnPremisesSynchronization = n.GetCollectionOfObjectValues<OnPremisesDirectorySynchronization>(OnPremisesDirectorySynchronization.CreateFromDiscriminatorValue)?.ToList(); } },
                {"outboundSharedUserProfiles", n => { OutboundSharedUserProfiles = n.GetCollectionOfObjectValues<OutboundSharedUserProfile>(OutboundSharedUserProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"recommendations", n => { Recommendations = n.GetCollectionOfObjectValues<Recommendation>(Recommendation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sharedEmailDomains", n => { SharedEmailDomains = n.GetCollectionOfObjectValues<SharedEmailDomain>(SharedEmailDomain.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
            writer.WriteCollectionOfObjectValues<OnPremisesDirectorySynchronization>("onPremisesSynchronization", OnPremisesSynchronization);
            writer.WriteCollectionOfObjectValues<OutboundSharedUserProfile>("outboundSharedUserProfiles", OutboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<Recommendation>("recommendations", Recommendations);
            writer.WriteCollectionOfObjectValues<SharedEmailDomain>("sharedEmailDomains", SharedEmailDomains);
        }
    }
}
