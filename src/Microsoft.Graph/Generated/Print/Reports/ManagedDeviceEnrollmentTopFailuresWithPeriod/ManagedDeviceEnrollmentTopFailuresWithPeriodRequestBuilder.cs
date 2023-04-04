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
namespace Microsoft.Graph.Beta.Print.Reports.ManagedDeviceEnrollmentTopFailuresWithPeriod {
    /// <summary>
    /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
    /// </summary>
    public class ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string period = "") : base(requestAdapter, "{+baseurl}/print/reports/managedDeviceEnrollmentTopFailures(period='{period}')", pathParameters) {
            if (!string.IsNullOrWhiteSpace(period)) PathParameters.Add("period", period);
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/reports/managedDeviceEnrollmentTopFailures(period='{period}')", rawUrl) {
        }
        /// <summary>
        /// Invoke function managedDeviceEnrollmentTopFailures
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Report?> GetAsync(Action<ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Report> GetAsync(Action<ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Report>(requestInfo, Report.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function managedDeviceEnrollmentTopFailures
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new managedDeviceEnrollmentTopFailuresWithPeriodRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
