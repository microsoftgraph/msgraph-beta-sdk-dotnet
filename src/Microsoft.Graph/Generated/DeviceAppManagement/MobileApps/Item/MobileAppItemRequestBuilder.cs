using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.Assign;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.Assignments;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.Categories;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.DeviceStatuses;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GetRelatedAppStatesWithUserPrincipalNameWithDeviceId;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.InstallSummary;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.ManagedMobileLobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.MobileLobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.Relationships;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.UpdateRelationships;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.UserStatuses;
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
namespace Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item {
    /// <summary>
    /// Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.
    /// </summary>
    public class MobileAppItemRequestBuilder {
        /// <summary>Provides operations to call the assign method.</summary>
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.mobileApp entity.</summary>
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the categories property of the microsoft.graph.mobileApp entity.</summary>
        public CategoriesRequestBuilder Categories { get =>
            new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceStatuses property of the microsoft.graph.mobileApp entity.</summary>
        public DeviceStatusesRequestBuilder DeviceStatuses { get =>
            new DeviceStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the installSummary property of the microsoft.graph.mobileApp entity.</summary>
        public InstallSummaryRequestBuilder InstallSummary { get =>
            new InstallSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedMobileLobApp.</summary>
        public ManagedMobileLobAppRequestBuilder ManagedMobileLobApp { get =>
            new ManagedMobileLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to mobileLobApp.</summary>
        public MobileLobAppRequestBuilder MobileLobApp { get =>
            new MobileLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to manage the relationships property of the microsoft.graph.mobileApp entity.</summary>
        public RelationshipsRequestBuilder Relationships { get =>
            new RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to call the updateRelationships method.</summary>
        public UpdateRelationshipsRequestBuilder UpdateRelationships { get =>
            new UpdateRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the userStatuses property of the microsoft.graph.mobileApp entity.</summary>
        public UserStatusesRequestBuilder UserStatuses { get =>
            new UserStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new MobileAppItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new MobileAppItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property mobileApps for deviceAppManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<MobileAppItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<MobileAppItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The mobile apps.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<MobileApp?> GetAsync(Action<MobileAppItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<MobileApp> GetAsync(Action<MobileAppItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MobileApp>(requestInfo, MobileApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getRelatedAppStates method.
        /// </summary>
        /// <param name="deviceId">Usage: deviceId=&apos;{deviceId}&apos;</param>
        /// <param name="userPrincipalName">Usage: userPrincipalName=&apos;{userPrincipalName}&apos;</param>
        public GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder GetRelatedAppStatesWithUserPrincipalNameWithDeviceId(string deviceId, string userPrincipalName) {
            if(string.IsNullOrEmpty(deviceId)) throw new ArgumentNullException(nameof(deviceId));
            if(string.IsNullOrEmpty(userPrincipalName)) throw new ArgumentNullException(nameof(userPrincipalName));
            return new GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder(PathParameters, RequestAdapter, deviceId, userPrincipalName);
        }
        /// <summary>
        /// Update the navigation property mobileApps in deviceAppManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<MobileApp?> PatchAsync(MobileApp body, Action<MobileAppItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<MobileApp> PatchAsync(MobileApp body, Action<MobileAppItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MobileApp>(requestInfo, MobileApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property mobileApps for deviceAppManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<MobileAppItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<MobileAppItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MobileAppItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The mobile apps.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MobileAppItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MobileAppItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MobileAppItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property mobileApps in deviceAppManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(MobileApp body, Action<MobileAppItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(MobileApp body, Action<MobileAppItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new MobileAppItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MobileAppItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new MobileAppItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public MobileAppItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The mobile apps.
        /// </summary>
        public class MobileAppItemRequestBuilderGetQueryParameters {
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
        public class MobileAppItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MobileAppItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MobileAppItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new MobileAppItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MobileAppItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MobileAppItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new MobileAppItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public MobileAppItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
