using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.Bitlocker;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.DataLossPreventionPolicies;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.DecryptBuffer;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.EncryptBuffer;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.Policy;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.SensitivityLabels;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.SensitivityPolicySettings;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.SignDigest;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.ThreatAssessmentRequests;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection.VerifySignature;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Sites.Item.InformationProtection {
    /// <summary>
    /// Provides operations to manage the informationProtection property of the microsoft.graph.site entity.
    /// </summary>
    public class InformationProtectionRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the bitlocker property of the microsoft.graph.informationProtection entity.</summary>
        public BitlockerRequestBuilder Bitlocker { get =>
            new BitlockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dataLossPreventionPolicies property of the microsoft.graph.informationProtection entity.</summary>
        public DataLossPreventionPoliciesRequestBuilder DataLossPreventionPolicies { get =>
            new DataLossPreventionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the decryptBuffer method.</summary>
        public DecryptBufferRequestBuilder DecryptBuffer { get =>
            new DecryptBufferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the encryptBuffer method.</summary>
        public EncryptBufferRequestBuilder EncryptBuffer { get =>
            new EncryptBufferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the policy property of the microsoft.graph.informationProtection entity.</summary>
        public PolicyRequestBuilder Policy { get =>
            new PolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sensitivityLabels property of the microsoft.graph.informationProtection entity.</summary>
        public SensitivityLabelsRequestBuilder SensitivityLabels { get =>
            new SensitivityLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sensitivityPolicySettings property of the microsoft.graph.informationProtection entity.</summary>
        public SensitivityPolicySettingsRequestBuilder SensitivityPolicySettings { get =>
            new SensitivityPolicySettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the signDigest method.</summary>
        public SignDigestRequestBuilder SignDigest { get =>
            new SignDigestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the threatAssessmentRequests property of the microsoft.graph.informationProtection entity.</summary>
        public ThreatAssessmentRequestsRequestBuilder ThreatAssessmentRequests { get =>
            new ThreatAssessmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the verifySignature method.</summary>
        public VerifySignatureRequestBuilder VerifySignature { get =>
            new VerifySignatureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new InformationProtectionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InformationProtectionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/informationProtection{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new InformationProtectionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InformationProtectionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/informationProtection{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property informationProtection for sites
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> DeleteAsync(Action<InformationProtectionRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> DeleteAsync(Action<InformationProtectionRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get informationProtection from sites
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.InformationProtection?> GetAsync(Action<InformationProtectionRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.InformationProtection> GetAsync(Action<InformationProtectionRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.InformationProtection>(requestInfo, Microsoft.Graph.Beta.Models.InformationProtection.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property informationProtection in sites
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.InformationProtection?> PatchAsync(Microsoft.Graph.Beta.Models.InformationProtection body, Action<InformationProtectionRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.InformationProtection> PatchAsync(Microsoft.Graph.Beta.Models.InformationProtection body, Action<InformationProtectionRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.InformationProtection>(requestInfo, Microsoft.Graph.Beta.Models.InformationProtection.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property informationProtection for sites
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<InformationProtectionRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<InformationProtectionRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new InformationProtectionRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get informationProtection from sites
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<InformationProtectionRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<InformationProtectionRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new InformationProtectionRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property informationProtection in sites
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.InformationProtection body, Action<InformationProtectionRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.InformationProtection body, Action<InformationProtectionRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new InformationProtectionRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class InformationProtectionRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new informationProtectionRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public InformationProtectionRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get informationProtection from sites
        /// </summary>
        public class InformationProtectionRequestBuilderGetQueryParameters {
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
        public class InformationProtectionRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public InformationProtectionRequestBuilderGetQueryParameters QueryParameters { get; set; } = new InformationProtectionRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new informationProtectionRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public InformationProtectionRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class InformationProtectionRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new informationProtectionRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public InformationProtectionRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
