using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ExportJobs;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetDailyAggregatedRemoteConnectionReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionLatencyWithCloudPcId;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRemoteConnectionHistoricalReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetSharedUseLicenseUsageReport;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetTotalAggregatedRemoteConnectionReports;
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
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports {
    /// <summary>
    /// Provides operations to manage the reports property of the microsoft.graph.virtualEndpoint entity.
    /// </summary>
    public class ReportsRequestBuilder {
        /// <summary>Provides operations to manage the exportJobs property of the microsoft.graph.cloudPcReports entity.</summary>
        public ExportJobsRequestBuilder ExportJobs { get =>
            new ExportJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDailyAggregatedRemoteConnectionReports method.</summary>
        public GetDailyAggregatedRemoteConnectionReportsRequestBuilder GetDailyAggregatedRemoteConnectionReports { get =>
            new GetDailyAggregatedRemoteConnectionReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getRemoteConnectionHistoricalReports method.</summary>
        public GetRemoteConnectionHistoricalReportsRequestBuilder GetRemoteConnectionHistoricalReports { get =>
            new GetRemoteConnectionHistoricalReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getSharedUseLicenseUsageReport method.</summary>
        public GetSharedUseLicenseUsageReportRequestBuilder GetSharedUseLicenseUsageReport { get =>
            new GetSharedUseLicenseUsageReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getTotalAggregatedRemoteConnectionReports method.</summary>
        public GetTotalAggregatedRemoteConnectionReportsRequestBuilder GetTotalAggregatedRemoteConnectionReports { get =>
            new GetTotalAggregatedRemoteConnectionReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/virtualEndpoint/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/virtualEndpoint/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<ReportsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<ReportsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Cloud PC related reports.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CloudPcReports?> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CloudPcReports> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CloudPcReports>(requestInfo, CloudPcReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getRealTimeRemoteConnectionLatency method.
        /// </summary>
        /// <param name="cloudPcId">Usage: cloudPcId=&apos;{cloudPcId}&apos;</param>
        public GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder GetRealTimeRemoteConnectionLatencyWithCloudPcId(string cloudPcId) {
            if(string.IsNullOrEmpty(cloudPcId)) throw new ArgumentNullException(nameof(cloudPcId));
            return new GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder(PathParameters, RequestAdapter, cloudPcId);
        }
        /// <summary>
        /// Provides operations to call the getRealTimeRemoteConnectionStatus method.
        /// </summary>
        /// <param name="cloudPcId">Usage: cloudPcId=&apos;{cloudPcId}&apos;</param>
        public GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder GetRealTimeRemoteConnectionStatusWithCloudPcId(string cloudPcId) {
            if(string.IsNullOrEmpty(cloudPcId)) throw new ArgumentNullException(nameof(cloudPcId));
            return new GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder(PathParameters, RequestAdapter, cloudPcId);
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CloudPcReports?> PatchAsync(CloudPcReports body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CloudPcReports> PatchAsync(CloudPcReports body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CloudPcReports>(requestInfo, CloudPcReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ReportsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ReportsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Cloud PC related reports.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(CloudPcReports body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(CloudPcReports body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new ReportsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Cloud PC related reports.
        /// </summary>
        public class ReportsRequestBuilderGetQueryParameters {
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
        public class ReportsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ReportsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ReportsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new reportsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
