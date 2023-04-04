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
namespace Microsoft.Graph.Beta.PrivilegedRoles.Item.SelfDeactivate {
    /// <summary>
    /// Provides operations to call the selfDeactivate method.
    /// </summary>
    public class SelfDeactivateRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new SelfDeactivateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SelfDeactivateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/privilegedRoles/{privilegedRole%2Did}/selfDeactivate", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SelfDeactivateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SelfDeactivateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/privilegedRoles/{privilegedRole%2Did}/selfDeactivate", rawUrl) {
        }
        /// <summary>
        /// Deactivate the role that is assigned to the requestor.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/privilegedrole-selfdeactivate?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PrivilegedRoleAssignment?> PostAsync(Action<SelfDeactivateRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PrivilegedRoleAssignment> PostAsync(Action<SelfDeactivateRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PrivilegedRoleAssignment>(requestInfo, PrivilegedRoleAssignment.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Deactivate the role that is assigned to the requestor.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<SelfDeactivateRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<SelfDeactivateRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SelfDeactivateRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SelfDeactivateRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new selfDeactivateRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public SelfDeactivateRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
