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
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewPolicy>("accessReviewPolicy"); }
            set { BackingStore?.Set("accessReviewPolicy", value); }
        }
        /// <summary>The policy that controls the idle time out for web sessions for applications.</summary>
        public List<ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies {
            get { return BackingStore?.Get<List<ActivityBasedTimeoutPolicy>>("activityBasedTimeoutPolicies"); }
            set { BackingStore?.Set("activityBasedTimeoutPolicies", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The policy by which consent requests are created and managed for the entire tenant.</summary>
        public Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy AdminConsentRequestPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdminConsentRequestPolicy>("adminConsentRequestPolicy"); }
            set { BackingStore?.Set("adminConsentRequestPolicy", value); }
        }
        /// <summary>The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.</summary>
        public List<AppManagementPolicy> AppManagementPolicies {
            get { return BackingStore?.Get<List<AppManagementPolicy>>("appManagementPolicies"); }
            set { BackingStore?.Set("appManagementPolicies", value); }
        }
        /// <summary>The policy configuration of the self-service sign-up experience of external users.</summary>
        public Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy AuthenticationFlowsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationFlowsPolicy>("authenticationFlowsPolicy"); }
            set { BackingStore?.Set("authenticationFlowsPolicy", value); }
        }
        /// <summary>The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).</summary>
        public Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy AuthenticationMethodsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationMethodsPolicy>("authenticationMethodsPolicy"); }
            set { BackingStore?.Set("authenticationMethodsPolicy", value); }
        }
        /// <summary>The authenticationStrengthPolicies property</summary>
        public List<AuthenticationStrengthPolicy> AuthenticationStrengthPolicies {
            get { return BackingStore?.Get<List<AuthenticationStrengthPolicy>>("authenticationStrengthPolicies"); }
            set { BackingStore?.Set("authenticationStrengthPolicies", value); }
        }
        /// <summary>The policy that controls Azure AD authorization settings.</summary>
        public List<Microsoft.Graph.Beta.Models.AuthorizationPolicy> AuthorizationPolicy {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AuthorizationPolicy>>("authorizationPolicy"); }
            set { BackingStore?.Set("authorizationPolicy", value); }
        }
        /// <summary>The Azure AD B2C policies that define how end users register via local accounts.</summary>
        public Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy B2cAuthenticationMethodsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.B2cAuthenticationMethodsPolicy>("b2cAuthenticationMethodsPolicy"); }
            set { BackingStore?.Set("b2cAuthenticationMethodsPolicy", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.</summary>
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies {
            get { return BackingStore?.Get<List<ClaimsMappingPolicy>>("claimsMappingPolicies"); }
            set { BackingStore?.Set("claimsMappingPolicies", value); }
        }
        /// <summary>The custom rules that define an access scenario.</summary>
        public List<ConditionalAccessPolicy> ConditionalAccessPolicies {
            get { return BackingStore?.Get<List<ConditionalAccessPolicy>>("conditionalAccessPolicies"); }
            set { BackingStore?.Set("conditionalAccessPolicies", value); }
        }
        /// <summary>The custom rules that define an access scenario when interacting with external Azure AD tenants.</summary>
        public Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy CrossTenantAccessPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CrossTenantAccessPolicy>("crossTenantAccessPolicy"); }
            set { BackingStore?.Set("crossTenantAccessPolicy", value); }
        }
        /// <summary>The tenant-wide policy that enforces app management restrictions for all applications and service principals.</summary>
        public TenantAppManagementPolicy DefaultAppManagementPolicy {
            get { return BackingStore?.Get<TenantAppManagementPolicy>("defaultAppManagementPolicy"); }
            set { BackingStore?.Set("defaultAppManagementPolicy", value); }
        }
        /// <summary>The deviceRegistrationPolicy property</summary>
        public Microsoft.Graph.Beta.Models.DeviceRegistrationPolicy DeviceRegistrationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceRegistrationPolicy>("deviceRegistrationPolicy"); }
            set { BackingStore?.Set("deviceRegistrationPolicy", value); }
        }
        /// <summary>The directoryRoleAccessReviewPolicy property</summary>
        public Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy DirectoryRoleAccessReviewPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DirectoryRoleAccessReviewPolicy>("directoryRoleAccessReviewPolicy"); }
            set { BackingStore?.Set("directoryRoleAccessReviewPolicy", value); }
        }
        /// <summary>Represents the tenant-wide policy that controls whether external users can leave an Azure AD tenant via self-service controls.</summary>
        public Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy ExternalIdentitiesPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalIdentitiesPolicy>("externalIdentitiesPolicy"); }
            set { BackingStore?.Set("externalIdentitiesPolicy", value); }
        }
        /// <summary>The feature rollout policy associated with a directory object.</summary>
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies {
            get { return BackingStore?.Get<List<FeatureRolloutPolicy>>("featureRolloutPolicies"); }
            set { BackingStore?.Set("featureRolloutPolicies", value); }
        }
        /// <summary>The policy to control Azure AD authentication behavior for federated users.</summary>
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies {
            get { return BackingStore?.Get<List<HomeRealmDiscoveryPolicy>>("homeRealmDiscoveryPolicies"); }
            set { BackingStore?.Set("homeRealmDiscoveryPolicies", value); }
        }
        /// <summary>The policy that represents the security defaults that protect against common attacks.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy"); }
            set { BackingStore?.Set("identitySecurityDefaultsEnforcementPolicy", value); }
        }
        /// <summary>The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.</summary>
        public List<MobilityManagementPolicy> MobileAppManagementPolicies {
            get { return BackingStore?.Get<List<MobilityManagementPolicy>>("mobileAppManagementPolicies"); }
            set { BackingStore?.Set("mobileAppManagementPolicies", value); }
        }
        /// <summary>The mobileDeviceManagementPolicies property</summary>
        public List<MobilityManagementPolicy> MobileDeviceManagementPolicies {
            get { return BackingStore?.Get<List<MobilityManagementPolicy>>("mobileDeviceManagementPolicies"); }
            set { BackingStore?.Set("mobileDeviceManagementPolicies", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The policy that specifies the conditions under which consent can be granted.</summary>
        public List<PermissionGrantPolicy> PermissionGrantPolicies {
            get { return BackingStore?.Get<List<PermissionGrantPolicy>>("permissionGrantPolicies"); }
            set { BackingStore?.Set("permissionGrantPolicies", value); }
        }
        /// <summary>Represents the role management policies.</summary>
        public List<UnifiedRoleManagementPolicy> RoleManagementPolicies {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicy>>("roleManagementPolicies"); }
            set { BackingStore?.Set("roleManagementPolicies", value); }
        }
        /// <summary>Represents the role management policy assignments.</summary>
        public List<UnifiedRoleManagementPolicyAssignment> RoleManagementPolicyAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyAssignment>>("roleManagementPolicyAssignments"); }
            set { BackingStore?.Set("roleManagementPolicyAssignments", value); }
        }
        /// <summary>The servicePrincipalCreationPolicies property</summary>
        public List<ServicePrincipalCreationPolicy> ServicePrincipalCreationPolicies {
            get { return BackingStore?.Get<List<ServicePrincipalCreationPolicy>>("servicePrincipalCreationPolicies"); }
            set { BackingStore?.Set("servicePrincipalCreationPolicies", value); }
        }
        /// <summary>The policy that specifies the characteristics of SAML tokens issued by Azure AD.</summary>
        public List<TokenIssuancePolicy> TokenIssuancePolicies {
            get { return BackingStore?.Get<List<TokenIssuancePolicy>>("tokenIssuancePolicies"); }
            set { BackingStore?.Set("tokenIssuancePolicies", value); }
        }
        /// <summary>The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.</summary>
        public List<TokenLifetimePolicy> TokenLifetimePolicies {
            get { return BackingStore?.Get<List<TokenLifetimePolicy>>("tokenLifetimePolicies"); }
            set { BackingStore?.Set("tokenLifetimePolicies", value); }
        }
        /// <summary>
        /// Instantiates a new PolicyRoot and sets the default values.
        /// </summary>
        public PolicyRoot() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.policyRoot";
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
                {"authenticationStrengthPolicies", n => { AuthenticationStrengthPolicies = n.GetCollectionOfObjectValues<AuthenticationStrengthPolicy>(AuthenticationStrengthPolicy.CreateFromDiscriminatorValue).ToList(); } },
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<AuthenticationStrengthPolicy>("authenticationStrengthPolicies", AuthenticationStrengthPolicies);
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
            writer.WriteStringValue("@odata.type", OdataType);
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
