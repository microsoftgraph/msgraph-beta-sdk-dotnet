using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionLatencyWithCloudPcId {
    /// <summary>
    /// Provides operations to call the getRealTimeRemoteConnectionLatency method.
    /// </summary>
    public class GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="cloudPcId">Usage: cloudPcId=&apos;{cloudPcId}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string cloudPcId = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/virtualEndpoint/reports/microsoft.graph.getRealTimeRemoteConnectionLatency(cloudPcId='{cloudPcId}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("cloudPcId", cloudPcId);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/virtualEndpoint/reports/microsoft.graph.getRealTimeRemoteConnectionLatency(cloudPcId='{cloudPcId}')";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getRealTimeRemoteConnectionLatency
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function getRealTimeRemoteConnectionLatency
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new getRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
