using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.TenantRelationships.DelegatedAdminCustomers;
using Microsoft.Graph.Beta.TenantRelationships.DelegatedAdminRelationships;
using Microsoft.Graph.Beta.TenantRelationships.FindTenantInformationByDomainNameWithDomainName;
using Microsoft.Graph.Beta.TenantRelationships.FindTenantInformationByTenantIdWithTenantId;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.TenantRelationships {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class TenantRelationshipsRequestBuilder {
        /// <summary>The delegatedAdminCustomers property</summary>
        public DelegatedAdminCustomersRequestBuilder DelegatedAdminCustomers { get =>
            new DelegatedAdminCustomersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The delegatedAdminRelationships property</summary>
        public DelegatedAdminRelationshipsRequestBuilder DelegatedAdminRelationships { get =>
            new DelegatedAdminRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedTenants property</summary>
        public ManagedTenantsRequestBuilder ManagedTenants { get =>
            new ManagedTenantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new TenantRelationshipsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public TenantRelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/tenantRelationships{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new TenantRelationshipsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public TenantRelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/tenantRelationships{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get tenantRelationships
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<TenantRelationshipsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new TenantRelationshipsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update tenantRelationships
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(TenantRelationship body, Action<TenantRelationshipsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new TenantRelationshipsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the findTenantInformationByDomainName method.
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
        /// </summary>
        public FindTenantInformationByDomainNameWithDomainNameRequestBuilder FindTenantInformationByDomainNameWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new FindTenantInformationByDomainNameWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>
        /// Provides operations to call the findTenantInformationByTenantId method.
        /// <param name="tenantId">Usage: tenantId=&apos;{tenantId}&apos;</param>
        /// </summary>
        public FindTenantInformationByTenantIdWithTenantIdRequestBuilder FindTenantInformationByTenantIdWithTenantId(string tenantId) {
            if(string.IsNullOrEmpty(tenantId)) throw new ArgumentNullException(nameof(tenantId));
            return new FindTenantInformationByTenantIdWithTenantIdRequestBuilder(PathParameters, RequestAdapter, tenantId);
        }
        /// <summary>
        /// Get tenantRelationships
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public async Task<TenantRelationship> GetAsync(Action<TenantRelationshipsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<TenantRelationship>(requestInfo, TenantRelationship.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update tenantRelationships
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public async Task<TenantRelationship> PatchAsync(TenantRelationship body, Action<TenantRelationshipsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<TenantRelationship>(requestInfo, TenantRelationship.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>Get tenantRelationships</summary>
        public class TenantRelationshipsRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class TenantRelationshipsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public TenantRelationshipsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new TenantRelationshipsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new tenantRelationshipsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public TenantRelationshipsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class TenantRelationshipsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new tenantRelationshipsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public TenantRelationshipsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
