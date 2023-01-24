using Microsoft.Graph.Beta.Contacts.Item.CheckMemberGroups;
using Microsoft.Graph.Beta.Contacts.Item.CheckMemberObjects;
using Microsoft.Graph.Beta.Contacts.Item.DirectReports;
using Microsoft.Graph.Beta.Contacts.Item.GetMemberGroups;
using Microsoft.Graph.Beta.Contacts.Item.GetMemberObjects;
using Microsoft.Graph.Beta.Contacts.Item.Manager;
using Microsoft.Graph.Beta.Contacts.Item.MemberOf;
using Microsoft.Graph.Beta.Contacts.Item.Restore;
using Microsoft.Graph.Beta.Contacts.Item.TransitiveMemberOf;
using Microsoft.Graph.Beta.Contacts.Item.TransitiveReports;
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
namespace Microsoft.Graph.Beta.Contacts.Item {
    /// <summary>
    /// Provides operations to manage the collection of orgContact entities.
    /// </summary>
    public class OrgContactItemRequestBuilder {
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the directReports property of the microsoft.graph.orgContact entity.</summary>
        public DirectReportsRequestBuilder DirectReports { get =>
            new DirectReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the manager property of the microsoft.graph.orgContact entity.</summary>
        public ManagerRequestBuilder Manager { get =>
            new ManagerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the memberOf property of the microsoft.graph.orgContact entity.</summary>
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to call the restore method.</summary>
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.orgContact entity.</summary>
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveReports property of the microsoft.graph.orgContact entity.</summary>
        public TransitiveReportsRequestBuilder TransitiveReports { get =>
            new TransitiveReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new OrgContactItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrgContactItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/contacts/{orgContact%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new OrgContactItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrgContactItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/contacts/{orgContact%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from contacts by key (id)
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<OrgContactItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<OrgContactItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get the properties and relationships of an organizational contact object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/orgcontact-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.OrgContact?> GetAsync(Action<OrgContactItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.OrgContact> GetAsync(Action<OrgContactItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.OrgContact>(requestInfo, Microsoft.Graph.Beta.Models.OrgContact.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update entity in contacts by key (id)
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.OrgContact?> PatchAsync(Microsoft.Graph.Beta.Models.OrgContact body, Action<OrgContactItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.OrgContact> PatchAsync(Microsoft.Graph.Beta.Models.OrgContact body, Action<OrgContactItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.OrgContact>(requestInfo, Microsoft.Graph.Beta.Models.OrgContact.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete entity from contacts by key (id)
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<OrgContactItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<OrgContactItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new OrgContactItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get the properties and relationships of an organizational contact object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<OrgContactItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<OrgContactItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new OrgContactItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update entity in contacts by key (id)
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.OrgContact body, Action<OrgContactItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.OrgContact body, Action<OrgContactItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new OrgContactItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OrgContactItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new OrgContactItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public OrgContactItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get the properties and relationships of an organizational contact object.
        /// </summary>
        public class OrgContactItemRequestBuilderGetQueryParameters {
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
        public class OrgContactItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public OrgContactItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new OrgContactItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new OrgContactItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public OrgContactItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OrgContactItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new OrgContactItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public OrgContactItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
