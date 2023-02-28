using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.IdentityGovernanceActivate;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.IdentityGovernanceCreateNewVersion;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.IdentityGovernanceRestore;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Runs;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.TaskReports;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.UserProcessingResults;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions;
using Microsoft.Graph.Beta.Models.IdentityGovernance;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item {
    /// <summary>
    /// Provides operations to manage the workflows property of the microsoft.graph.deletedItemContainer entity.
    /// </summary>
    public class WorkflowItemRequestBuilder {
        /// <summary>Provides operations to manage the executionScope property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public ExecutionScopeRequestBuilder ExecutionScope { get =>
            new ExecutionScopeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the activate method.</summary>
        public IdentityGovernanceActivateRequestBuilder IdentityGovernanceActivate { get =>
            new IdentityGovernanceActivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createNewVersion method.</summary>
        public IdentityGovernanceCreateNewVersionRequestBuilder IdentityGovernanceCreateNewVersion { get =>
            new IdentityGovernanceCreateNewVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public IdentityGovernanceRestoreRequestBuilder IdentityGovernanceRestore { get =>
            new IdentityGovernanceRestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the runs property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public RunsRequestBuilder Runs { get =>
            new RunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taskReports property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public TaskReportsRequestBuilder TaskReports { get =>
            new TaskReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the userProcessingResults property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public UserProcessingResultsRequestBuilder UserProcessingResults { get =>
            new UserProcessingResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the versions property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public VersionsRequestBuilder Versions { get =>
            new VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WorkflowItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new WorkflowItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property workflows for identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<WorkflowItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<WorkflowItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Deleted workflows that end up in the deletedItemsContainer.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Workflow?> GetAsync(Action<WorkflowItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Workflow> GetAsync(Action<WorkflowItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Workflow>(requestInfo, Workflow.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property workflows for identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<WorkflowItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<WorkflowItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WorkflowItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Deleted workflows that end up in the deletedItemsContainer.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WorkflowItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WorkflowItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WorkflowItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WorkflowItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WorkflowItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public WorkflowItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Deleted workflows that end up in the deletedItemsContainer.
        /// </summary>
        public class WorkflowItemRequestBuilderGetQueryParameters {
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
        public class WorkflowItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WorkflowItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WorkflowItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WorkflowItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WorkflowItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
