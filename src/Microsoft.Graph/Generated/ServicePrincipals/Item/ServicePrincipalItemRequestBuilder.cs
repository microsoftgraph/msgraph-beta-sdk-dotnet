using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppManagementPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignedTo;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignments;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CheckMemberGroups;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CheckMemberObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.ClaimsMappingPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CreatedObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CreatePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.DelegatedPermissionClassifications;
using Microsoft.Graph.Beta.ServicePrincipals.Item.DeletePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Endpoints;
using Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.GetMemberGroups;
using Microsoft.Graph.Beta.ServicePrincipals.Item.GetMemberObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.GetPasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.HomeRealmDiscoveryPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.LicenseDetails;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Oauth2PermissionGrants;
using Microsoft.Graph.Beta.ServicePrincipals.Item.OwnedObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Owners;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Restore;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TokenIssuancePolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TokenLifetimePolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf;
using Microsoft.Graph.Beta.ServicePrincipals.Item.UpdatePasswordSingleSignOnCredentials;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item {
    /// <summary>Provides operations to manage the collection of servicePrincipal entities.</summary>
    public class ServicePrincipalItemRequestBuilder {
        /// <summary>The addTokenSigningCertificate property</summary>
        public AddTokenSigningCertificateRequestBuilder AddTokenSigningCertificate { get =>
            new AddTokenSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appManagementPolicies property</summary>
        public AppManagementPoliciesRequestBuilder AppManagementPolicies { get =>
            new AppManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appRoleAssignedTo property</summary>
        public AppRoleAssignedToRequestBuilder AppRoleAssignedTo { get =>
            new AppRoleAssignedToRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appRoleAssignments property</summary>
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkMemberGroups property</summary>
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkMemberObjects property</summary>
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The claimsMappingPolicies property</summary>
        public ClaimsMappingPoliciesRequestBuilder ClaimsMappingPolicies { get =>
            new ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createdObjects property</summary>
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createPasswordSingleSignOnCredentials property</summary>
        public CreatePasswordSingleSignOnCredentialsRequestBuilder CreatePasswordSingleSignOnCredentials { get =>
            new CreatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The delegatedPermissionClassifications property</summary>
        public DelegatedPermissionClassificationsRequestBuilder DelegatedPermissionClassifications { get =>
            new DelegatedPermissionClassificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deletePasswordSingleSignOnCredentials property</summary>
        public DeletePasswordSingleSignOnCredentialsRequestBuilder DeletePasswordSingleSignOnCredentials { get =>
            new DeletePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The endpoints property</summary>
        public EndpointsRequestBuilder Endpoints { get =>
            new EndpointsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The federatedIdentityCredentials property</summary>
        public FederatedIdentityCredentialsRequestBuilder FederatedIdentityCredentials { get =>
            new FederatedIdentityCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getMemberGroups property</summary>
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getMemberObjects property</summary>
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getPasswordSingleSignOnCredentials property</summary>
        public GetPasswordSingleSignOnCredentialsRequestBuilder GetPasswordSingleSignOnCredentials { get =>
            new GetPasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The homeRealmDiscoveryPolicies property</summary>
        public HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies { get =>
            new HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The licenseDetails property</summary>
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memberOf property</summary>
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oauth2PermissionGrants property</summary>
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ownedObjects property</summary>
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The owners property</summary>
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The restore property</summary>
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The synchronization property</summary>
        public SynchronizationRequestBuilder Synchronization { get =>
            new SynchronizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tokenIssuancePolicies property</summary>
        public TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies { get =>
            new TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tokenLifetimePolicies property</summary>
        public TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies { get =>
            new TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transitiveMemberOf property</summary>
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The updatePasswordSingleSignOnCredentials property</summary>
        public UpdatePasswordSingleSignOnCredentialsRequestBuilder UpdatePasswordSingleSignOnCredentials { get =>
            new UpdatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ServicePrincipalItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from servicePrincipals
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get entity from servicePrincipals by key
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update entity in servicePrincipals
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ServicePrincipal body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete entity from servicePrincipals
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get entity from servicePrincipals by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ServicePrincipal> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ServicePrincipal>(requestInfo, ServicePrincipal.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update entity in servicePrincipals
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ServicePrincipal body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get entity from servicePrincipals by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
