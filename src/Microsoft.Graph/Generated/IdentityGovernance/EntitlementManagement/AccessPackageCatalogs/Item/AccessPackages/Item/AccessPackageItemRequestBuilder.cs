using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item.AccessPackageAssignmentPolicies;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item.AccessPackageCatalog;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item.AccessPackageResourceRoleScopes;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item.AccessPackagesIncompatibleWith;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item.GetApplicablePolicyRequirements;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item.IncompatibleAccessPackages;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item.IncompatibleGroups;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item.MoveToCatalog;
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
namespace Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackages.Item {
    /// <summary>Provides operations to manage the accessPackages property of the microsoft.graph.accessPackageCatalog entity.</summary>
    public class AccessPackageItemRequestBuilder {
        /// <summary>The accessPackageAssignmentPolicies property</summary>
        public AccessPackageAssignmentPoliciesRequestBuilder AccessPackageAssignmentPolicies { get =>
            new AccessPackageAssignmentPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageCatalog property</summary>
        public AccessPackageCatalogRequestBuilder AccessPackageCatalog { get =>
            new AccessPackageCatalogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackageResourceRoleScopes property</summary>
        public AccessPackageResourceRoleScopesRequestBuilder AccessPackageResourceRoleScopes { get =>
            new AccessPackageResourceRoleScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessPackagesIncompatibleWith property</summary>
        public AccessPackagesIncompatibleWithRequestBuilder AccessPackagesIncompatibleWith { get =>
            new AccessPackagesIncompatibleWithRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getApplicablePolicyRequirements property</summary>
        public GetApplicablePolicyRequirementsRequestBuilder GetApplicablePolicyRequirements { get =>
            new GetApplicablePolicyRequirementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The incompatibleAccessPackages property</summary>
        public IncompatibleAccessPackagesRequestBuilder IncompatibleAccessPackages { get =>
            new IncompatibleAccessPackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The incompatibleGroups property</summary>
        public IncompatibleGroupsRequestBuilder IncompatibleGroups { get =>
            new IncompatibleGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The moveToCatalog property</summary>
        public MoveToCatalogRequestBuilder MoveToCatalog { get =>
            new MoveToCatalogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new AccessPackageItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AccessPackageItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/accessPackages/{accessPackage%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AccessPackageItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AccessPackageItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/accessPackages/{accessPackage%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property accessPackages for identityGovernance
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<AccessPackageItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AccessPackageItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The access packages in this catalog. Read-only. Nullable. Supports $expand.
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<AccessPackageItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AccessPackageItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property accessPackages in identityGovernance
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.AccessPackage body, Action<AccessPackageItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new AccessPackageItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property accessPackages for identityGovernance
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<AccessPackageItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The access packages in this catalog. Read-only. Nullable. Supports $expand.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.AccessPackage> GetAsync(Action<AccessPackageItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AccessPackage>(requestInfo, Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property accessPackages in identityGovernance
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.AccessPackage> PatchAsync(Microsoft.Graph.Beta.Models.AccessPackage body, Action<AccessPackageItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AccessPackage>(requestInfo, Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AccessPackageItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AccessPackageItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AccessPackageItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>The access packages in this catalog. Read-only. Nullable. Supports $expand.</summary>
        public class AccessPackageItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AccessPackageItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AccessPackageItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AccessPackageItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new AccessPackageItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AccessPackageItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AccessPackageItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AccessPackageItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AccessPackageItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
