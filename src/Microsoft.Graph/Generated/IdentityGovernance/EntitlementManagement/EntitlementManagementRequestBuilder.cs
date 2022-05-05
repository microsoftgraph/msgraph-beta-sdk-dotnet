using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentPolicies;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentRequests;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentResourceRoles;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageResourceEnvironments;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageResourceRequests;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageResourceRoleScopes;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageResources;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackages;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.ConnectedOrganizations;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.Settings;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement {
    /// <summary>Provides operations to manage the entitlementManagement property of the microsoft.graph.identityGovernance entity.</summary>
    public class EntitlementManagementRequestBuilder {
        /// <summary>The accessPackageAssignmentApprovals property</summary>
        public AccessPackageAssignmentApprovalsRequestBuilder AccessPackageAssignmentApprovals { get =>
            new AccessPackageAssignmentApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageAssignmentPolicies property</summary>
        public AccessPackageAssignmentPoliciesRequestBuilder AccessPackageAssignmentPolicies { get =>
            new AccessPackageAssignmentPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageAssignmentRequests property</summary>
        public AccessPackageAssignmentRequestsRequestBuilder AccessPackageAssignmentRequests { get =>
            new AccessPackageAssignmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageAssignmentResourceRoles property</summary>
        public AccessPackageAssignmentResourceRolesRequestBuilder AccessPackageAssignmentResourceRoles { get =>
            new AccessPackageAssignmentResourceRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageAssignments property</summary>
        public AccessPackageAssignmentsRequestBuilder AccessPackageAssignments { get =>
            new AccessPackageAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageCatalogs property</summary>
        public AccessPackageCatalogsRequestBuilder AccessPackageCatalogs { get =>
            new AccessPackageCatalogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageResourceEnvironments property</summary>
        public AccessPackageResourceEnvironmentsRequestBuilder AccessPackageResourceEnvironments { get =>
            new AccessPackageResourceEnvironmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageResourceRequests property</summary>
        public AccessPackageResourceRequestsRequestBuilder AccessPackageResourceRequests { get =>
            new AccessPackageResourceRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageResourceRoleScopes property</summary>
        public AccessPackageResourceRoleScopesRequestBuilder AccessPackageResourceRoleScopes { get =>
            new AccessPackageResourceRoleScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageResources property</summary>
        public AccessPackageResourcesRequestBuilder AccessPackageResources { get =>
            new AccessPackageResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackages property</summary>
        public AccessPackagesRequestBuilder AccessPackages { get =>
            new AccessPackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The connectedOrganizations property</summary>
        public ConnectedOrganizationsRequestBuilder ConnectedOrganizations { get =>
            new ConnectedOrganizationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new EntitlementManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EntitlementManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/entitlementManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new EntitlementManagementRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EntitlementManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/entitlementManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for identityGovernance
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<EntitlementManagementRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new EntitlementManagementRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get entitlementManagement from identityGovernance
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<EntitlementManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new EntitlementManagementRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in identityGovernance
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.EntitlementManagement body, Action<EntitlementManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new EntitlementManagementRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for identityGovernance
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<EntitlementManagementRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get entitlementManagement from identityGovernance
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.EntitlementManagement> GetAsync(Action<EntitlementManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.EntitlementManagement>(requestInfo, Microsoft.Graph.Beta.Models.EntitlementManagement.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in identityGovernance
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Microsoft.Graph.Beta.Models.EntitlementManagement body, Action<EntitlementManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EntitlementManagementRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new entitlementManagementRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public EntitlementManagementRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Get entitlementManagement from identityGovernance</summary>
        public class EntitlementManagementRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EntitlementManagementRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EntitlementManagementRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EntitlementManagementRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new entitlementManagementRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EntitlementManagementRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EntitlementManagementRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new entitlementManagementRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public EntitlementManagementRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
