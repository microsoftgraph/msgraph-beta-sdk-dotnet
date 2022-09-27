using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Policies.AccessReviewPolicy;
using Microsoft.Graph.Beta.Policies.ActivityBasedTimeoutPolicies;
using Microsoft.Graph.Beta.Policies.AdminConsentRequestPolicy;
using Microsoft.Graph.Beta.Policies.AppManagementPolicies;
using Microsoft.Graph.Beta.Policies.AuthenticationFlowsPolicy;
using Microsoft.Graph.Beta.Policies.AuthenticationMethodsPolicy;
using Microsoft.Graph.Beta.Policies.AuthenticationStrengthPolicies;
using Microsoft.Graph.Beta.Policies.AuthorizationPolicy;
using Microsoft.Graph.Beta.Policies.B2cAuthenticationMethodsPolicy;
using Microsoft.Graph.Beta.Policies.ClaimsMappingPolicies;
using Microsoft.Graph.Beta.Policies.ConditionalAccessPolicies;
using Microsoft.Graph.Beta.Policies.CrossTenantAccessPolicy;
using Microsoft.Graph.Beta.Policies.DefaultAppManagementPolicy;
using Microsoft.Graph.Beta.Policies.DeviceRegistrationPolicy;
using Microsoft.Graph.Beta.Policies.DirectoryRoleAccessReviewPolicy;
using Microsoft.Graph.Beta.Policies.ExternalIdentitiesPolicy;
using Microsoft.Graph.Beta.Policies.FeatureRolloutPolicies;
using Microsoft.Graph.Beta.Policies.HomeRealmDiscoveryPolicies;
using Microsoft.Graph.Beta.Policies.IdentitySecurityDefaultsEnforcementPolicy;
using Microsoft.Graph.Beta.Policies.MobileAppManagementPolicies;
using Microsoft.Graph.Beta.Policies.MobileDeviceManagementPolicies;
using Microsoft.Graph.Beta.Policies.PermissionGrantPolicies;
using Microsoft.Graph.Beta.Policies.RoleManagementPolicies;
using Microsoft.Graph.Beta.Policies.RoleManagementPolicyAssignments;
using Microsoft.Graph.Beta.Policies.ServicePrincipalCreationPolicies;
using Microsoft.Graph.Beta.Policies.TokenIssuancePolicies;
using Microsoft.Graph.Beta.Policies.TokenLifetimePolicies;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Policies {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public class PoliciesRequestBuilder {
        /// <summary>The accessReviewPolicy property</summary>
        public AccessReviewPolicyRequestBuilder AccessReviewPolicy { get =>
            new AccessReviewPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The activityBasedTimeoutPolicies property</summary>
        public ActivityBasedTimeoutPoliciesRequestBuilder ActivityBasedTimeoutPolicies { get =>
            new ActivityBasedTimeoutPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The adminConsentRequestPolicy property</summary>
        public AdminConsentRequestPolicyRequestBuilder AdminConsentRequestPolicy { get =>
            new AdminConsentRequestPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appManagementPolicies property</summary>
        public AppManagementPoliciesRequestBuilder AppManagementPolicies { get =>
            new AppManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationFlowsPolicy property</summary>
        public AuthenticationFlowsPolicyRequestBuilder AuthenticationFlowsPolicy { get =>
            new AuthenticationFlowsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationMethodsPolicy property</summary>
        public AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get =>
            new AuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationStrengthPolicies property</summary>
        public AuthenticationStrengthPoliciesRequestBuilder AuthenticationStrengthPolicies { get =>
            new AuthenticationStrengthPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authorizationPolicy property</summary>
        public AuthorizationPolicyRequestBuilder AuthorizationPolicy { get =>
            new AuthorizationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The b2cAuthenticationMethodsPolicy property</summary>
        public B2cAuthenticationMethodsPolicyRequestBuilder B2cAuthenticationMethodsPolicy { get =>
            new B2cAuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The claimsMappingPolicies property</summary>
        public ClaimsMappingPoliciesRequestBuilder ClaimsMappingPolicies { get =>
            new ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The conditionalAccessPolicies property</summary>
        public ConditionalAccessPoliciesRequestBuilder ConditionalAccessPolicies { get =>
            new ConditionalAccessPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The crossTenantAccessPolicy property</summary>
        public CrossTenantAccessPolicyRequestBuilder CrossTenantAccessPolicy { get =>
            new CrossTenantAccessPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultAppManagementPolicy property</summary>
        public DefaultAppManagementPolicyRequestBuilder DefaultAppManagementPolicy { get =>
            new DefaultAppManagementPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceRegistrationPolicy property</summary>
        public DeviceRegistrationPolicyRequestBuilder DeviceRegistrationPolicy { get =>
            new DeviceRegistrationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directoryRoleAccessReviewPolicy property</summary>
        public DirectoryRoleAccessReviewPolicyRequestBuilder DirectoryRoleAccessReviewPolicy { get =>
            new DirectoryRoleAccessReviewPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The externalIdentitiesPolicy property</summary>
        public ExternalIdentitiesPolicyRequestBuilder ExternalIdentitiesPolicy { get =>
            new ExternalIdentitiesPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The featureRolloutPolicies property</summary>
        public FeatureRolloutPoliciesRequestBuilder FeatureRolloutPolicies { get =>
            new FeatureRolloutPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The homeRealmDiscoveryPolicies property</summary>
        public HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies { get =>
            new HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identitySecurityDefaultsEnforcementPolicy property</summary>
        public IdentitySecurityDefaultsEnforcementPolicyRequestBuilder IdentitySecurityDefaultsEnforcementPolicy { get =>
            new IdentitySecurityDefaultsEnforcementPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileAppManagementPolicies property</summary>
        public MobileAppManagementPoliciesRequestBuilder MobileAppManagementPolicies { get =>
            new MobileAppManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileDeviceManagementPolicies property</summary>
        public MobileDeviceManagementPoliciesRequestBuilder MobileDeviceManagementPolicies { get =>
            new MobileDeviceManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The permissionGrantPolicies property</summary>
        public PermissionGrantPoliciesRequestBuilder PermissionGrantPolicies { get =>
            new PermissionGrantPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The roleManagementPolicies property</summary>
        public RoleManagementPoliciesRequestBuilder RoleManagementPolicies { get =>
            new RoleManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleManagementPolicyAssignments property</summary>
        public RoleManagementPolicyAssignmentsRequestBuilder RoleManagementPolicyAssignments { get =>
            new RoleManagementPolicyAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The servicePrincipalCreationPolicies property</summary>
        public ServicePrincipalCreationPoliciesRequestBuilder ServicePrincipalCreationPolicies { get =>
            new ServicePrincipalCreationPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tokenIssuancePolicies property</summary>
        public TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies { get =>
            new TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tokenLifetimePolicies property</summary>
        public TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies { get =>
            new TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new PoliciesRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PoliciesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/policies{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new PoliciesRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PoliciesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/policies{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get policies
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<PoliciesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new PoliciesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update policies
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(PolicyRoot body, Action<PoliciesRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new PoliciesRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get policies
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<PolicyRoot> GetAsync(Action<PoliciesRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PolicyRoot>(requestInfo, PolicyRoot.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update policies
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<PolicyRoot> PatchAsync(PolicyRoot body, Action<PoliciesRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PolicyRoot>(requestInfo, PolicyRoot.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get policies</summary>
        public class PoliciesRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class PoliciesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public PoliciesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new PoliciesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new policiesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public PoliciesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class PoliciesRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new policiesRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public PoliciesRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
