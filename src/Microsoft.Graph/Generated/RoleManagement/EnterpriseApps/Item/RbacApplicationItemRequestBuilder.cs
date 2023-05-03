using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.ResourceNamespaces;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleAssignmentApprovals;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleInstances;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleAssignmentSchedules;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleAssignments;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleDefinitions;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleEligibilityScheduleInstances;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleEligibilityScheduleRequests;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleEligibilitySchedules;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId;
using Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item.TransitiveRoleAssignments;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.RoleManagement.EnterpriseApps.Item {
    /// <summary>
    /// Provides operations to manage the enterpriseApps property of the microsoft.graph.roleManagement entity.
    /// </summary>
    public class RbacApplicationItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the resourceNamespaces property of the microsoft.graph.rbacApplication entity.</summary>
        public ResourceNamespacesRequestBuilder ResourceNamespaces { get =>
            new ResourceNamespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentApprovals property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentApprovalsRequestBuilder RoleAssignmentApprovals { get =>
            new RoleAssignmentApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignments property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentScheduleInstances property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentScheduleInstancesRequestBuilder RoleAssignmentScheduleInstances { get =>
            new RoleAssignmentScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentScheduleRequestsRequestBuilder RoleAssignmentScheduleRequests { get =>
            new RoleAssignmentScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentSchedules property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentSchedulesRequestBuilder RoleAssignmentSchedules { get =>
            new RoleAssignmentSchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleDefinitions property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleInstances property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleEligibilityScheduleInstancesRequestBuilder RoleEligibilityScheduleInstances { get =>
            new RoleEligibilityScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleEligibilityScheduleRequestsRequestBuilder RoleEligibilityScheduleRequests { get =>
            new RoleEligibilityScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilitySchedules property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleEligibilitySchedulesRequestBuilder RoleEligibilitySchedules { get =>
            new RoleEligibilitySchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the roleScheduleInstances method.</summary>
        public RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId { get =>
            new RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the roleSchedules method.</summary>
        public RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId { get =>
            new RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveRoleAssignments property of the microsoft.graph.rbacApplication entity.</summary>
        public TransitiveRoleAssignmentsRequestBuilder TransitiveRoleAssignments { get =>
            new TransitiveRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new RbacApplicationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RbacApplicationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/enterpriseApps/{rbacApplication%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RbacApplicationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RbacApplicationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/enterpriseApps/{rbacApplication%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property enterpriseApps for roleManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RbacApplicationItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RbacApplicationItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get enterpriseApps from roleManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RbacApplication?> GetAsync(Action<RbacApplicationItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RbacApplication> GetAsync(Action<RbacApplicationItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RbacApplication>(requestInfo, RbacApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property enterpriseApps in roleManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RbacApplication?> PatchAsync(RbacApplication body, Action<RbacApplicationItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RbacApplication> PatchAsync(RbacApplication body, Action<RbacApplicationItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RbacApplication>(requestInfo, RbacApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property enterpriseApps for roleManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RbacApplicationItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RbacApplicationItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RbacApplicationItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get enterpriseApps from roleManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RbacApplicationItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RbacApplicationItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RbacApplicationItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property enterpriseApps in roleManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(RbacApplication body, Action<RbacApplicationItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(RbacApplication body, Action<RbacApplicationItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new RbacApplicationItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class RbacApplicationItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new RbacApplicationItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public RbacApplicationItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get enterpriseApps from roleManagement
        /// </summary>
        public class RbacApplicationItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class RbacApplicationItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public RbacApplicationItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new RbacApplicationItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new RbacApplicationItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public RbacApplicationItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class RbacApplicationItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new RbacApplicationItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public RbacApplicationItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
