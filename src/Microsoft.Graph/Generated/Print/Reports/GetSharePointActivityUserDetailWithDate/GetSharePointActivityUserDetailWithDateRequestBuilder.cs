using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Print.Reports.GetSharePointActivityUserDetailWithDate {
    /// <summary>
    /// Provides operations to call the getSharePointActivityUserDetail method.
    /// </summary>
    public class GetSharePointActivityUserDetailWithDateRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetSharePointActivityUserDetailWithDateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetSharePointActivityUserDetailWithDateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, Date? date = default) : base(requestAdapter, "{+baseurl}/print/reports/getSharePointActivityUserDetail(date={date})", pathParameters) {
            if (date is not null) PathParameters.Add("date", date);
        }
        /// <summary>
        /// Instantiates a new GetSharePointActivityUserDetailWithDateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetSharePointActivityUserDetailWithDateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/reports/getSharePointActivityUserDetail(date={date})", rawUrl) {
        }
        /// <summary>
        /// Invoke function getSharePointActivityUserDetail
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<GetSharePointActivityUserDetailWithDateRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<GetSharePointActivityUserDetailWithDateRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function getSharePointActivityUserDetail
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetSharePointActivityUserDetailWithDateRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetSharePointActivityUserDetailWithDateRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new GetSharePointActivityUserDetailWithDateRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetSharePointActivityUserDetailWithDateRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new getSharePointActivityUserDetailWithDateRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetSharePointActivityUserDetailWithDateRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
