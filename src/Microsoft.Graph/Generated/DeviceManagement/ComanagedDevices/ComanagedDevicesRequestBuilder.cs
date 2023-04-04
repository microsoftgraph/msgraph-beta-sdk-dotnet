using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.AppDiagnosticsWithUpn;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkReprovisionCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkSetCloudPcReviewStatus;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Count;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.DownloadAppDiagnostics;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.ExecuteAction;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.MoveDevicesToOU;
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
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices {
    /// <summary>
    /// Provides operations to manage the comanagedDevices property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class ComanagedDevicesRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the bulkReprovisionCloudPc method.</summary>
        public BulkReprovisionCloudPcRequestBuilder BulkReprovisionCloudPc { get =>
            new BulkReprovisionCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the bulkRestoreCloudPc method.</summary>
        public BulkRestoreCloudPcRequestBuilder BulkRestoreCloudPc { get =>
            new BulkRestoreCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the bulkSetCloudPcReviewStatus method.</summary>
        public BulkSetCloudPcReviewStatusRequestBuilder BulkSetCloudPcReviewStatus { get =>
            new BulkSetCloudPcReviewStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the downloadAppDiagnostics method.</summary>
        public DownloadAppDiagnosticsRequestBuilder DownloadAppDiagnostics { get =>
            new DownloadAppDiagnosticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the executeAction method.</summary>
        public ExecuteActionRequestBuilder ExecuteAction { get =>
            new ExecuteActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the moveDevicesToOU method.</summary>
        public MoveDevicesToOURequestBuilder MoveDevicesToOU { get =>
            new MoveDevicesToOURequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the comanagedDevices property of the microsoft.graph.deviceManagement entity.</summary>
        public ManagedDeviceItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("managedDevice%2Did", position);
            return new ManagedDeviceItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Provides operations to call the appDiagnostics method.
        /// </summary>
        /// <param name="upn">Usage: upn=&apos;{upn}&apos;</param>
        public AppDiagnosticsWithUpnRequestBuilder AppDiagnosticsWithUpn(string upn) {
            if(string.IsNullOrEmpty(upn)) throw new ArgumentNullException(nameof(upn));
            return new AppDiagnosticsWithUpnRequestBuilder(PathParameters, RequestAdapter, upn);
        }
        /// <summary>
        /// Instantiates a new ComanagedDevicesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ComanagedDevicesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/comanagedDevices{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ComanagedDevicesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ComanagedDevicesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/comanagedDevices{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// The list of co-managed devices report
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ManagedDeviceCollectionResponse?> GetAsync(Action<ComanagedDevicesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ManagedDeviceCollectionResponse> GetAsync(Action<ComanagedDevicesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedDeviceCollectionResponse>(requestInfo, ManagedDeviceCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Create new navigation property to comanagedDevices for deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice?> PostAsync(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ComanagedDevicesRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice> PostAsync(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ComanagedDevicesRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ManagedDevice>(requestInfo, Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The list of co-managed devices report
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ComanagedDevicesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ComanagedDevicesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ComanagedDevicesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to comanagedDevices for deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ComanagedDevicesRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ComanagedDevicesRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ComanagedDevicesRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The list of co-managed devices report
        /// </summary>
        public class ComanagedDevicesRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ComanagedDevicesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ComanagedDevicesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ComanagedDevicesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new comanagedDevicesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ComanagedDevicesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ComanagedDevicesRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new comanagedDevicesRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ComanagedDevicesRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
