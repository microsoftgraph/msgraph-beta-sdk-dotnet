using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using MicrosoftGraph.ServicePrincipals.Item.AddTokenSigningCertificate;
using MicrosoftGraph.ServicePrincipals.Item.AppManagementPolicies;
using MicrosoftGraph.ServicePrincipals.Item.AppRoleAssignedTo;
using MicrosoftGraph.ServicePrincipals.Item.AppRoleAssignments;
using MicrosoftGraph.ServicePrincipals.Item.CheckMemberGroups;
using MicrosoftGraph.ServicePrincipals.Item.CheckMemberObjects;
using MicrosoftGraph.ServicePrincipals.Item.ClaimsMappingPolicies;
using MicrosoftGraph.ServicePrincipals.Item.CreatedObjects;
using MicrosoftGraph.ServicePrincipals.Item.CreatePasswordSingleSignOnCredentials;
using MicrosoftGraph.ServicePrincipals.Item.DelegatedPermissionClassifications;
using MicrosoftGraph.ServicePrincipals.Item.DeletePasswordSingleSignOnCredentials;
using MicrosoftGraph.ServicePrincipals.Item.Endpoints;
using MicrosoftGraph.ServicePrincipals.Item.FederatedIdentityCredentials;
using MicrosoftGraph.ServicePrincipals.Item.GetMemberGroups;
using MicrosoftGraph.ServicePrincipals.Item.GetMemberObjects;
using MicrosoftGraph.ServicePrincipals.Item.GetPasswordSingleSignOnCredentials;
using MicrosoftGraph.ServicePrincipals.Item.HomeRealmDiscoveryPolicies;
using MicrosoftGraph.ServicePrincipals.Item.LicenseDetails;
using MicrosoftGraph.ServicePrincipals.Item.MemberOf;
using MicrosoftGraph.ServicePrincipals.Item.Oauth2PermissionGrants;
using MicrosoftGraph.ServicePrincipals.Item.OwnedObjects;
using MicrosoftGraph.ServicePrincipals.Item.Owners;
using MicrosoftGraph.ServicePrincipals.Item.Restore;
using MicrosoftGraph.ServicePrincipals.Item.Synchronization;
using MicrosoftGraph.ServicePrincipals.Item.TokenIssuancePolicies;
using MicrosoftGraph.ServicePrincipals.Item.TokenLifetimePolicies;
using MicrosoftGraph.ServicePrincipals.Item.TransitiveMemberOf;
using MicrosoftGraph.ServicePrincipals.Item.UpdatePasswordSingleSignOnCredentials;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.ServicePrincipals.Item {
    /// <summary>Builds and executes requests for operations under \servicePrincipals\{servicePrincipal-id}</summary>
    public class ServicePrincipalRequestBuilder {
        public AddTokenSigningCertificateRequestBuilder AddTokenSigningCertificate { get =>
            new AddTokenSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppManagementPoliciesRequestBuilder AppManagementPolicies { get =>
            new AppManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppRoleAssignedToRequestBuilder AppRoleAssignedTo { get =>
            new AppRoleAssignedToRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ClaimsMappingPoliciesRequestBuilder ClaimsMappingPolicies { get =>
            new ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreatePasswordSingleSignOnCredentialsRequestBuilder CreatePasswordSingleSignOnCredentials { get =>
            new CreatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DelegatedPermissionClassificationsRequestBuilder DelegatedPermissionClassifications { get =>
            new DelegatedPermissionClassificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeletePasswordSingleSignOnCredentialsRequestBuilder DeletePasswordSingleSignOnCredentials { get =>
            new DeletePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        public EndpointsRequestBuilder Endpoints { get =>
            new EndpointsRequestBuilder(PathParameters, RequestAdapter);
        }
        public FederatedIdentityCredentialsRequestBuilder FederatedIdentityCredentials { get =>
            new FederatedIdentityCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetPasswordSingleSignOnCredentialsRequestBuilder GetPasswordSingleSignOnCredentials { get =>
            new GetPasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        public HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies { get =>
            new HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        public SynchronizationRequestBuilder Synchronization { get =>
            new SynchronizationRequestBuilder(PathParameters, RequestAdapter);
        }
        public TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies { get =>
            new TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies { get =>
            new TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public UpdatePasswordSingleSignOnCredentialsRequestBuilder UpdatePasswordSingleSignOnCredentials { get =>
            new UpdatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ServicePrincipalRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
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
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get entity from servicePrincipals by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update entity in servicePrincipals
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ServicePrincipal body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete entity from servicePrincipals
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Get entity from servicePrincipals by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ServicePrincipal> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ServicePrincipal>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Update entity in servicePrincipals
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ServicePrincipal body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
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
