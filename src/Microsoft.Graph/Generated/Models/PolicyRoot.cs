using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PolicyRoot : IAdditionalDataHolder, IParsable {
        /// <summary>The policy that contains directory-level access review settings.</summary>
        public Microsoft.Graph.Beta.Models.AccessReviewPolicy AccessReviewPolicy { get; set; }
        /// <summary>The policy that controls the idle time out for web sessions for applications.</summary>
        public List<ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The policy by which consent requests are created and managed for the entire tenant.</summary>
        public Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy AdminConsentRequestPolicy { get; set; }
        /// <summary>The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.</summary>
        public List<AppManagementPolicy> AppManagementPolicies { get; set; }
        /// <summary>The policy configuration of the self-service sign-up experience of external users.</summary>
        public Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy AuthenticationFlowsPolicy { get; set; }
        /// <summary>The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).</summary>
        public Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy AuthenticationMethodsPolicy { get; set; }
        /// <summary>The policy that controls Azure AD authorization settings.</summary>
        public List<Microsoft.Graph.Beta.Models.AuthorizationPolicy> AuthorizationPolicy { get; set; }
        /// <summary>The Azure AD B2C policies that define how end users register via local accounts.</summary>
        public Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy B2cAuthenticationMethodsPolicy { get; set; }
        /// <summary>The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.</summary>
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies { get; set; }
        /// <summary>The custom rules that define an access scenario.</summary>
        public List<ConditionalAccessPolicy> ConditionalAccessPolicies { get; set; }
        /// <summary>The custom rules that define an access scenario when interacting with external Azure AD tenants.</summary>
        public Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy CrossTenantAccessPolicy { get; set; }
        /// <summary>The tenant-wide policy that enforces app management restrictions for all applications and service principals.</summary>
        public TenantAppManagementPolicy DefaultAppManagementPolicy { get; set; }
        /// <summary>The directoryRoleAccessReviewPolicy property</summary>
        public Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy DirectoryRoleAccessReviewPolicy { get; set; }
        /// <summary>The externalIdentitiesPolicy property</summary>
        public Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy ExternalIdentitiesPolicy { get; set; }
        /// <summary>The feature rollout policy associated with a directory object.</summary>
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
        /// <summary>The policy to control Azure AD authentication behavior for federated users.</summary>
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
        /// <summary>The policy that represents the security defaults that protect against common attacks.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy { get; set; }
        /// <summary>The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.</summary>
        public List<MobilityManagementPolicy> MobileAppManagementPolicies { get; set; }
        /// <summary>The mobileDeviceManagementPolicies property</summary>
        public List<MobilityManagementPolicy> MobileDeviceManagementPolicies { get; set; }
        /// <summary>The policy that specifies the conditions under which consent can be granted.</summary>
        public List<PermissionGrantPolicy> PermissionGrantPolicies { get; set; }
        /// <summary>Represents the role management policies.</summary>
        public List<UnifiedRoleManagementPolicy> RoleManagementPolicies { get; set; }
        /// <summary>Represents the role management policy assignments.</summary>
        public List<UnifiedRoleManagementPolicyAssignment> RoleManagementPolicyAssignments { get; set; }
        /// <summary>The servicePrincipalCreationPolicies property</summary>
        public List<ServicePrincipalCreationPolicy> ServicePrincipalCreationPolicies { get; set; }
        /// <summary>The policy that specifies the characteristics of SAML tokens issued by Azure AD.</summary>
        public List<TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
        /// <summary>The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.</summary>
        public List<TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
        /// <summary>
        /// Instantiates a new PolicyRoot and sets the default values.
        /// </summary>
        public PolicyRoot() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PolicyRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessReviewPolicy", (o,n) => { (o as PolicyRoot).AccessReviewPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessReviewPolicy>(Microsoft.Graph.Beta.Models.AccessReviewPolicy.CreateFromDiscriminatorValue); } },
                {"activityBasedTimeoutPolicies", (o,n) => { (o as PolicyRoot).ActivityBasedTimeoutPolicies = n.GetCollectionOfObjectValues<ActivityBasedTimeoutPolicy>(ActivityBasedTimeoutPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"adminConsentRequestPolicy", (o,n) => { (o as PolicyRoot).AdminConsentRequestPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy>(Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy.CreateFromDiscriminatorValue); } },
                {"appManagementPolicies", (o,n) => { (o as PolicyRoot).AppManagementPolicies = n.GetCollectionOfObjectValues<AppManagementPolicy>(AppManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationFlowsPolicy", (o,n) => { (o as PolicyRoot).AuthenticationFlowsPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy>(Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy.CreateFromDiscriminatorValue); } },
                {"authenticationMethodsPolicy", (o,n) => { (o as PolicyRoot).AuthenticationMethodsPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy>(Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy.CreateFromDiscriminatorValue); } },
                {"authorizationPolicy", (o,n) => { (o as PolicyRoot).AuthorizationPolicy = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthorizationPolicy>(Microsoft.Graph.Beta.Models.AuthorizationPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"b2cAuthenticationMethodsPolicy", (o,n) => { (o as PolicyRoot).B2cAuthenticationMethodsPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy>(Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy.CreateFromDiscriminatorValue); } },
                {"claimsMappingPolicies", (o,n) => { (o as PolicyRoot).ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>(ClaimsMappingPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccessPolicies", (o,n) => { (o as PolicyRoot).ConditionalAccessPolicies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>(ConditionalAccessPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"crossTenantAccessPolicy", (o,n) => { (o as PolicyRoot).CrossTenantAccessPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy>(Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy.CreateFromDiscriminatorValue); } },
                {"defaultAppManagementPolicy", (o,n) => { (o as PolicyRoot).DefaultAppManagementPolicy = n.GetObjectValue<TenantAppManagementPolicy>(TenantAppManagementPolicy.CreateFromDiscriminatorValue); } },
                {"directoryRoleAccessReviewPolicy", (o,n) => { (o as PolicyRoot).DirectoryRoleAccessReviewPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy>(Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy.CreateFromDiscriminatorValue); } },
                {"externalIdentitiesPolicy", (o,n) => { (o as PolicyRoot).ExternalIdentitiesPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy>(Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy.CreateFromDiscriminatorValue); } },
                {"featureRolloutPolicies", (o,n) => { (o as PolicyRoot).FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"homeRealmDiscoveryPolicies", (o,n) => { (o as PolicyRoot).HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"identitySecurityDefaultsEnforcementPolicy", (o,n) => { (o as PolicyRoot).IdentitySecurityDefaultsEnforcementPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy>(Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy.CreateFromDiscriminatorValue); } },
                {"mobileAppManagementPolicies", (o,n) => { (o as PolicyRoot).MobileAppManagementPolicies = n.GetCollectionOfObjectValues<MobilityManagementPolicy>(MobilityManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileDeviceManagementPolicies", (o,n) => { (o as PolicyRoot).MobileDeviceManagementPolicies = n.GetCollectionOfObjectValues<MobilityManagementPolicy>(MobilityManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"permissionGrantPolicies", (o,n) => { (o as PolicyRoot).PermissionGrantPolicies = n.GetCollectionOfObjectValues<PermissionGrantPolicy>(PermissionGrantPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"roleManagementPolicies", (o,n) => { (o as PolicyRoot).RoleManagementPolicies = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicy>(UnifiedRoleManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"roleManagementPolicyAssignments", (o,n) => { (o as PolicyRoot).RoleManagementPolicyAssignments = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyAssignment>(UnifiedRoleManagementPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"servicePrincipalCreationPolicies", (o,n) => { (o as PolicyRoot).ServicePrincipalCreationPolicies = n.GetCollectionOfObjectValues<ServicePrincipalCreationPolicy>(ServicePrincipalCreationPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"tokenIssuancePolicies", (o,n) => { (o as PolicyRoot).TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"tokenLifetimePolicies", (o,n) => { (o as PolicyRoot).TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessReviewPolicy>("accessReviewPolicy", AccessReviewPolicy);
            writer.WriteCollectionOfObjectValues<ActivityBasedTimeoutPolicy>("activityBasedTimeoutPolicies", ActivityBasedTimeoutPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy>("adminConsentRequestPolicy", AdminConsentRequestPolicy);
            writer.WriteCollectionOfObjectValues<AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy>("authenticationFlowsPolicy", AuthenticationFlowsPolicy);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy>("authenticationMethodsPolicy", AuthenticationMethodsPolicy);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthorizationPolicy>("authorizationPolicy", AuthorizationPolicy);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy>("b2cAuthenticationMethodsPolicy", B2cAuthenticationMethodsPolicy);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("conditionalAccessPolicies", ConditionalAccessPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy>("crossTenantAccessPolicy", CrossTenantAccessPolicy);
            writer.WriteObjectValue<TenantAppManagementPolicy>("defaultAppManagementPolicy", DefaultAppManagementPolicy);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy>("directoryRoleAccessReviewPolicy", DirectoryRoleAccessReviewPolicy);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy>("externalIdentitiesPolicy", ExternalIdentitiesPolicy);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy", IdentitySecurityDefaultsEnforcementPolicy);
            writer.WriteCollectionOfObjectValues<MobilityManagementPolicy>("mobileAppManagementPolicies", MobileAppManagementPolicies);
            writer.WriteCollectionOfObjectValues<MobilityManagementPolicy>("mobileDeviceManagementPolicies", MobileDeviceManagementPolicies);
            writer.WriteCollectionOfObjectValues<PermissionGrantPolicy>("permissionGrantPolicies", PermissionGrantPolicies);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicy>("roleManagementPolicies", RoleManagementPolicies);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyAssignment>("roleManagementPolicyAssignments", RoleManagementPolicyAssignments);
            writer.WriteCollectionOfObjectValues<ServicePrincipalCreationPolicy>("servicePrincipalCreationPolicies", ServicePrincipalCreationPolicies);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
