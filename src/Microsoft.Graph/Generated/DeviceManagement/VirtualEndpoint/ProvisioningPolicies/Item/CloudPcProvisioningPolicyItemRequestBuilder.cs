using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies.Item.Apply;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies.Item.Assign;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies.Item.Assignments;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies.Item {
    /// <summary>
    /// Provides operations to manage the provisioningPolicies property of the microsoft.graph.virtualEndpoint entity.
    /// </summary>
    public class CloudPcProvisioningPolicyItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the apply method.</summary>
        public ApplyRequestBuilder Apply { get =>
            new ApplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the assign method.</summary>
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.cloudPcProvisioningPolicy entity.</summary>
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CloudPcProvisioningPolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CloudPcProvisioningPolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/provisioningPolicies/{cloudPcProvisioningPolicy%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CloudPcProvisioningPolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CloudPcProvisioningPolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/provisioningPolicies/{cloudPcProvisioningPolicy%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete a cloudPcProvisioningPolicy object. You can’t delete a policy that’s in use.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/cloudpcprovisioningpolicy-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(CancellationToken cancellationToken = default, Action<CloudPcProvisioningPolicyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public async Task DeleteAsync(CancellationToken cancellationToken = default, Action<CloudPcProvisioningPolicyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Read the properties and relationships of a cloudPcProvisioningPolicy object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/cloudpcprovisioningpolicy-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CloudPcProvisioningPolicy?> GetAsync(CancellationToken cancellationToken = default, Action<CloudPcProvisioningPolicyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public async Task<CloudPcProvisioningPolicy> GetAsync(CancellationToken cancellationToken = default, Action<CloudPcProvisioningPolicyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CloudPcProvisioningPolicy>(requestInfo, CloudPcProvisioningPolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the properties of a cloudPcProvisioningPolicy object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/cloudpcprovisioningpolicy-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CloudPcProvisioningPolicy?> PatchAsync(CloudPcProvisioningPolicy body, CancellationToken cancellationToken = default, Action<CloudPcProvisioningPolicyItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public async Task<CloudPcProvisioningPolicy> PatchAsync(CloudPcProvisioningPolicy body, CancellationToken cancellationToken = default, Action<CloudPcProvisioningPolicyItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CloudPcProvisioningPolicy>(requestInfo, CloudPcProvisioningPolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete a cloudPcProvisioningPolicy object. You can’t delete a policy that’s in use.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<CloudPcProvisioningPolicyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<CloudPcProvisioningPolicyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CloudPcProvisioningPolicyItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a cloudPcProvisioningPolicy object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CloudPcProvisioningPolicyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CloudPcProvisioningPolicyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new CloudPcProvisioningPolicyItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a cloudPcProvisioningPolicy object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(CloudPcProvisioningPolicy body, Action<CloudPcProvisioningPolicyItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(CloudPcProvisioningPolicy body, Action<CloudPcProvisioningPolicyItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new CloudPcProvisioningPolicyItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CloudPcProvisioningPolicyItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CloudPcProvisioningPolicyItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public CloudPcProvisioningPolicyItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Read the properties and relationships of a cloudPcProvisioningPolicy object.
        /// </summary>
        public class CloudPcProvisioningPolicyItemRequestBuilderGetQueryParameters {
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
        public class CloudPcProvisioningPolicyItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CloudPcProvisioningPolicyItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CloudPcProvisioningPolicyItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new CloudPcProvisioningPolicyItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CloudPcProvisioningPolicyItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CloudPcProvisioningPolicyItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CloudPcProvisioningPolicyItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public CloudPcProvisioningPolicyItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
