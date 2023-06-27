using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies.Item.Assignments.Item.AssignedUsers.Item.MailboxSettings;
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
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies.Item.Assignments.Item.AssignedUsers.Item {
    /// <summary>
    /// Provides operations to manage the assignedUsers property of the microsoft.graph.cloudPcProvisioningPolicyAssignment entity.
    /// </summary>
    public class UserItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The mailboxSettings property</summary>
        [Obsolete("The onPremisesConnectionId property is deprecated and will stop returning on July 30, 2023. as of 2023-03/onPremisesConnectionId on 2023-03-16 and will be removed 2023-07-30")]
        public MailboxSettingsRequestBuilder MailboxSettings { get =>
            new MailboxSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/provisioningPolicies/{cloudPcProvisioningPolicy%2Did}/assignments/{cloudPcProvisioningPolicyAssignment%2Did}/assignedUsers/{user%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/provisioningPolicies/{cloudPcProvisioningPolicy%2Did}/assignments/{cloudPcProvisioningPolicyAssignment%2Did}/assignedUsers/{user%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// The assignment targeted users for the provisioning policy. This list of users is computed based on assignments, licenses, group memberships, and policies. This property is read-only. Supports$expand.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The onPremisesConnectionId property is deprecated and will stop returning on July 30, 2023. as of 2023-03/onPremisesConnectionId on 2023-03-16 and will be removed 2023-07-30")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.User?> GetAsync(Action<UserItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.User> GetAsync(Action<UserItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.User>(requestInfo, Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The assignment targeted users for the provisioning policy. This list of users is computed based on assignments, licenses, group memberships, and policies. This property is read-only. Supports$expand.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The onPremisesConnectionId property is deprecated and will stop returning on July 30, 2023. as of 2023-03/onPremisesConnectionId on 2023-03-16 and will be removed 2023-07-30")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<UserItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<UserItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new UserItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The assignment targeted users for the provisioning policy. This list of users is computed based on assignments, licenses, group memberships, and policies. This property is read-only. Supports$expand.
        /// </summary>
        public class UserItemRequestBuilderGetQueryParameters {
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
        public class UserItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UserItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UserItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new UserItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UserItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
