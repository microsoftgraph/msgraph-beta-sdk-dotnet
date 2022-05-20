using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PolicyRoot : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The policy that contains directory-level access review settings.</summary>
        public Microsoft.Graph.Beta.Models.AccessReviewPolicy AccessReviewPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewPolicy>(nameof(AccessReviewPolicy)); }
            set { BackingStore?.Set(nameof(AccessReviewPolicy), value); }
        }
        /// <summary>The policy that controls the idle time out for web sessions for applications.</summary>
        public List<ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies {
            get { return BackingStore?.Get<List<ActivityBasedTimeoutPolicy>>(nameof(ActivityBasedTimeoutPolicies)); }
            set { BackingStore?.Set(nameof(ActivityBasedTimeoutPolicies), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The policy by which consent requests are created and managed for the entire tenant.</summary>
        public Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy AdminConsentRequestPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy>(nameof(AdminConsentRequestPolicy)); }
            set { BackingStore?.Set(nameof(AdminConsentRequestPolicy), value); }
        }
        /// <summary>The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.</summary>
        public List<AppManagementPolicy> AppManagementPolicies {
            get { return BackingStore?.Get<List<AppManagementPolicy>>(nameof(AppManagementPolicies)); }
            set { BackingStore?.Set(nameof(AppManagementPolicies), value); }
        }
        /// <summary>The policy configuration of the self-service sign-up experience of external users.</summary>
        public Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy AuthenticationFlowsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy>(nameof(AuthenticationFlowsPolicy)); }
            set { BackingStore?.Set(nameof(AuthenticationFlowsPolicy), value); }
        }
        /// <summary>The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).</summary>
        public Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy AuthenticationMethodsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy>(nameof(AuthenticationMethodsPolicy)); }
            set { BackingStore?.Set(nameof(AuthenticationMethodsPolicy), value); }
        }
        /// <summary>The policy that controls Azure AD authorization settings.</summary>
        public List<Microsoft.Graph.Beta.Models.AuthorizationPolicy> AuthorizationPolicy {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AuthorizationPolicy>>(nameof(AuthorizationPolicy)); }
            set { BackingStore?.Set(nameof(AuthorizationPolicy), value); }
        }
        /// <summary>The Azure AD B2C policies that define how end users register via local accounts.</summary>
        public Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy B2cAuthenticationMethodsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy>(nameof(B2cAuthenticationMethodsPolicy)); }
            set { BackingStore?.Set(nameof(B2cAuthenticationMethodsPolicy), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.</summary>
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies {
            get { return BackingStore?.Get<List<ClaimsMappingPolicy>>(nameof(ClaimsMappingPolicies)); }
            set { BackingStore?.Set(nameof(ClaimsMappingPolicies), value); }
        }
        /// <summary>The custom rules that define an access scenario.</summary>
        public List<ConditionalAccessPolicy> ConditionalAccessPolicies {
            get { return BackingStore?.Get<List<ConditionalAccessPolicy>>(nameof(ConditionalAccessPolicies)); }
            set { BackingStore?.Set(nameof(ConditionalAccessPolicies), value); }
        }
        /// <summary>The custom rules that define an access scenario when interacting with external Azure AD tenants.</summary>
        public Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy CrossTenantAccessPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy>(nameof(CrossTenantAccessPolicy)); }
            set { BackingStore?.Set(nameof(CrossTenantAccessPolicy), value); }
        }
        /// <summary>The tenant-wide policy that enforces app management restrictions for all applications and service principals.</summary>
        public TenantAppManagementPolicy DefaultAppManagementPolicy {
            get { return BackingStore?.Get<TenantAppManagementPolicy>(nameof(DefaultAppManagementPolicy)); }
            set { BackingStore?.Set(nameof(DefaultAppManagementPolicy), value); }
        }
        /// <summary>The deviceRegistrationPolicy property</summary>
        public Microsoft.Graph.Beta.Models.DeviceRegistrationPolicy DeviceRegistrationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceRegistrationPolicy>(nameof(DeviceRegistrationPolicy)); }
            set { BackingStore?.Set(nameof(DeviceRegistrationPolicy), value); }
        }
        /// <summary>The directoryRoleAccessReviewPolicy property</summary>
        public Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy DirectoryRoleAccessReviewPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy>(nameof(DirectoryRoleAccessReviewPolicy)); }
            set { BackingStore?.Set(nameof(DirectoryRoleAccessReviewPolicy), value); }
        }
        /// <summary>The externalIdentitiesPolicy property</summary>
        public Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy ExternalIdentitiesPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy>(nameof(ExternalIdentitiesPolicy)); }
            set { BackingStore?.Set(nameof(ExternalIdentitiesPolicy), value); }
        }
        /// <summary>The feature rollout policy associated with a directory object.</summary>
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies {
            get { return BackingStore?.Get<List<FeatureRolloutPolicy>>(nameof(FeatureRolloutPolicies)); }
            set { BackingStore?.Set(nameof(FeatureRolloutPolicies), value); }
        }
        /// <summary>The policy to control Azure AD authentication behavior for federated users.</summary>
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies {
            get { return BackingStore?.Get<List<HomeRealmDiscoveryPolicy>>(nameof(HomeRealmDiscoveryPolicies)); }
            set { BackingStore?.Set(nameof(HomeRealmDiscoveryPolicies), value); }
        }
        /// <summary>The policy that represents the security defaults that protect against common attacks.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy>(nameof(IdentitySecurityDefaultsEnforcementPolicy)); }
            set { BackingStore?.Set(nameof(IdentitySecurityDefaultsEnforcementPolicy), value); }
        }
        /// <summary>The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.</summary>
        public List<MobilityManagementPolicy> MobileAppManagementPolicies {
            get { return BackingStore?.Get<List<MobilityManagementPolicy>>(nameof(MobileAppManagementPolicies)); }
            set { BackingStore?.Set(nameof(MobileAppManagementPolicies), value); }
        }
        /// <summary>The mobileDeviceManagementPolicies property</summary>
        public List<MobilityManagementPolicy> MobileDeviceManagementPolicies {
            get { return BackingStore?.Get<List<MobilityManagementPolicy>>(nameof(MobileDeviceManagementPolicies)); }
            set { BackingStore?.Set(nameof(MobileDeviceManagementPolicies), value); }
        }
        /// <summary>The policy that specifies the conditions under which consent can be granted.</summary>
        public List<PermissionGrantPolicy> PermissionGrantPolicies {
            get { return BackingStore?.Get<List<PermissionGrantPolicy>>(nameof(PermissionGrantPolicies)); }
            set { BackingStore?.Set(nameof(PermissionGrantPolicies), value); }
        }
        /// <summary>Represents the role management policies.</summary>
        public List<UnifiedRoleManagementPolicy> RoleManagementPolicies {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicy>>(nameof(RoleManagementPolicies)); }
            set { BackingStore?.Set(nameof(RoleManagementPolicies), value); }
        }
        /// <summary>Represents the role management policy assignments.</summary>
        public List<UnifiedRoleManagementPolicyAssignment> RoleManagementPolicyAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyAssignment>>(nameof(RoleManagementPolicyAssignments)); }
            set { BackingStore?.Set(nameof(RoleManagementPolicyAssignments), value); }
        }
        /// <summary>The servicePrincipalCreationPolicies property</summary>
        public List<ServicePrincipalCreationPolicy> ServicePrincipalCreationPolicies {
            get { return BackingStore?.Get<List<ServicePrincipalCreationPolicy>>(nameof(ServicePrincipalCreationPolicies)); }
            set { BackingStore?.Set(nameof(ServicePrincipalCreationPolicies), value); }
        }
        /// <summary>The policy that specifies the characteristics of SAML tokens issued by Azure AD.</summary>
        public List<TokenIssuancePolicy> TokenIssuancePolicies {
            get { return BackingStore?.Get<List<TokenIssuancePolicy>>(nameof(TokenIssuancePolicies)); }
            set { BackingStore?.Set(nameof(TokenIssuancePolicies), value); }
        }
        /// <summary>The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.</summary>
        public List<TokenLifetimePolicy> TokenLifetimePolicies {
            get { return BackingStore?.Get<List<TokenLifetimePolicy>>(nameof(TokenLifetimePolicies)); }
            set { BackingStore?.Set(nameof(TokenLifetimePolicies), value); }
        }
        /// <summary>
        /// Instantiates a new PolicyRoot and sets the default values.
        /// </summary>
        public PolicyRoot() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessReviewPolicy", n => { AccessReviewPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessReviewPolicy>(Microsoft.Graph.Beta.Models.AccessReviewPolicy.CreateFromDiscriminatorValue); } },
                {"activityBasedTimeoutPolicies", n => { ActivityBasedTimeoutPolicies = n.GetCollectionOfObjectValues<ActivityBasedTimeoutPolicy>(ActivityBasedTimeoutPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"adminConsentRequestPolicy", n => { AdminConsentRequestPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy>(Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy.CreateFromDiscriminatorValue); } },
                {"appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<AppManagementPolicy>(AppManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationFlowsPolicy", n => { AuthenticationFlowsPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy>(Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy.CreateFromDiscriminatorValue); } },
                {"authenticationMethodsPolicy", n => { AuthenticationMethodsPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy>(Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy.CreateFromDiscriminatorValue); } },
                {"authorizationPolicy", n => { AuthorizationPolicy = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthorizationPolicy>(Microsoft.Graph.Beta.Models.AuthorizationPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"b2cAuthenticationMethodsPolicy", n => { B2cAuthenticationMethodsPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy>(Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy.CreateFromDiscriminatorValue); } },
                {"claimsMappingPolicies", n => { ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>(ClaimsMappingPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccessPolicies", n => { ConditionalAccessPolicies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>(ConditionalAccessPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"crossTenantAccessPolicy", n => { CrossTenantAccessPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy>(Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy.CreateFromDiscriminatorValue); } },
                {"defaultAppManagementPolicy", n => { DefaultAppManagementPolicy = n.GetObjectValue<TenantAppManagementPolicy>(TenantAppManagementPolicy.CreateFromDiscriminatorValue); } },
                {"deviceRegistrationPolicy", n => { DeviceRegistrationPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceRegistrationPolicy>(Microsoft.Graph.Beta.Models.DeviceRegistrationPolicy.CreateFromDiscriminatorValue); } },
                {"directoryRoleAccessReviewPolicy", n => { DirectoryRoleAccessReviewPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy>(Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy.CreateFromDiscriminatorValue); } },
                {"externalIdentitiesPolicy", n => { ExternalIdentitiesPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy>(Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy.CreateFromDiscriminatorValue); } },
                {"featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"identitySecurityDefaultsEnforcementPolicy", n => { IdentitySecurityDefaultsEnforcementPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy>(Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy.CreateFromDiscriminatorValue); } },
                {"mobileAppManagementPolicies", n => { MobileAppManagementPolicies = n.GetCollectionOfObjectValues<MobilityManagementPolicy>(MobilityManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileDeviceManagementPolicies", n => { MobileDeviceManagementPolicies = n.GetCollectionOfObjectValues<MobilityManagementPolicy>(MobilityManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"permissionGrantPolicies", n => { PermissionGrantPolicies = n.GetCollectionOfObjectValues<PermissionGrantPolicy>(PermissionGrantPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"roleManagementPolicies", n => { RoleManagementPolicies = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicy>(UnifiedRoleManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"roleManagementPolicyAssignments", n => { RoleManagementPolicyAssignments = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyAssignment>(UnifiedRoleManagementPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"servicePrincipalCreationPolicies", n => { ServicePrincipalCreationPolicies = n.GetCollectionOfObjectValues<ServicePrincipalCreationPolicy>(ServicePrincipalCreationPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceRegistrationPolicy>("deviceRegistrationPolicy", DeviceRegistrationPolicy);
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
