using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.RoleManagement.Directory.ResourceNamespaces;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleAssignmentApprovals;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleAssignments;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleAssignmentScheduleInstances;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleAssignmentScheduleRequests;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleAssignmentSchedules;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleDefinitions;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleEligibilityScheduleInstances;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleEligibilityScheduleRequests;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleEligibilitySchedules;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleScheduleInstancesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionId;
using MicrosoftGraphSdk.RoleManagement.Directory.RoleSchedulesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionId;
using MicrosoftGraphSdk.RoleManagement.Directory.TransitiveRoleAssignments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.RoleManagement.Directory {
    /// <summary>Builds and executes requests for operations under \roleManagement\directory</summary>
    public class DirectoryRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ResourceNamespacesRequestBuilder ResourceNamespaces { get =>
            new ResourceNamespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleAssignmentApprovalsRequestBuilder RoleAssignmentApprovals { get =>
            new RoleAssignmentApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleAssignmentScheduleInstancesRequestBuilder RoleAssignmentScheduleInstances { get =>
            new RoleAssignmentScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleAssignmentScheduleRequestsRequestBuilder RoleAssignmentScheduleRequests { get =>
            new RoleAssignmentScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleAssignmentSchedulesRequestBuilder RoleAssignmentSchedules { get =>
            new RoleAssignmentSchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleEligibilityScheduleInstancesRequestBuilder RoleEligibilityScheduleInstances { get =>
            new RoleEligibilityScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleEligibilityScheduleRequestsRequestBuilder RoleEligibilityScheduleRequests { get =>
            new RoleEligibilityScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleEligibilitySchedulesRequestBuilder RoleEligibilitySchedules { get =>
            new RoleEligibilitySchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        public TransitiveRoleAssignmentsRequestBuilder TransitiveRoleAssignments { get =>
            new TransitiveRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DirectoryRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DirectoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/roleManagement/directory{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DirectoryRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DirectoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/roleManagement/directory{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Read-only. Nullable.
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
        /// Read-only. Nullable.
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
        /// Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(RbacApplication body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Read-only. Nullable.
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
        /// Read-only. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<RbacApplication> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<RbacApplication>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(RbacApplication body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \roleManagement\directory\microsoft.graph.roleScheduleInstances(directoryScopeId='{directoryScopeId}',appScopeId='{appScopeId}',principalId='{principalId}',roleDefinitionId='{roleDefinitionId}')
        /// <param name="appScopeId">Usage: appScopeId={appScopeId}</param>
        /// <param name="directoryScopeId">Usage: directoryScopeId={directoryScopeId}</param>
        /// <param name="principalId">Usage: principalId={principalId}</param>
        /// <param name="roleDefinitionId">Usage: roleDefinitionId={roleDefinitionId}</param>
        /// </summary>
        public RoleScheduleInstancesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionIdRequestBuilder RoleScheduleInstancesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionId(string directoryScopeId, string appScopeId, string principalId, string roleDefinitionId) {
            if(string.IsNullOrEmpty(appScopeId)) throw new ArgumentNullException(nameof(appScopeId));
            if(string.IsNullOrEmpty(directoryScopeId)) throw new ArgumentNullException(nameof(directoryScopeId));
            if(string.IsNullOrEmpty(principalId)) throw new ArgumentNullException(nameof(principalId));
            if(string.IsNullOrEmpty(roleDefinitionId)) throw new ArgumentNullException(nameof(roleDefinitionId));
            return new RoleScheduleInstancesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter, directoryScopeId, appScopeId, principalId, roleDefinitionId);
        }
        /// <summary>
        /// Builds and executes requests for operations under \roleManagement\directory\microsoft.graph.roleSchedules(directoryScopeId='{directoryScopeId}',appScopeId='{appScopeId}',principalId='{principalId}',roleDefinitionId='{roleDefinitionId}')
        /// <param name="appScopeId">Usage: appScopeId={appScopeId}</param>
        /// <param name="directoryScopeId">Usage: directoryScopeId={directoryScopeId}</param>
        /// <param name="principalId">Usage: principalId={principalId}</param>
        /// <param name="roleDefinitionId">Usage: roleDefinitionId={roleDefinitionId}</param>
        /// </summary>
        public RoleSchedulesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionIdRequestBuilder RoleSchedulesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionId(string directoryScopeId, string appScopeId, string principalId, string roleDefinitionId) {
            if(string.IsNullOrEmpty(appScopeId)) throw new ArgumentNullException(nameof(appScopeId));
            if(string.IsNullOrEmpty(directoryScopeId)) throw new ArgumentNullException(nameof(directoryScopeId));
            if(string.IsNullOrEmpty(principalId)) throw new ArgumentNullException(nameof(principalId));
            if(string.IsNullOrEmpty(roleDefinitionId)) throw new ArgumentNullException(nameof(roleDefinitionId));
            return new RoleSchedulesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter, directoryScopeId, appScopeId, principalId, roleDefinitionId);
        }
        /// <summary>Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
