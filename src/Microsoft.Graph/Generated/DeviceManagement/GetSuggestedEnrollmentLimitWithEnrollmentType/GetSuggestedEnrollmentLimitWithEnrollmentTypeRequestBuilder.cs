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
namespace Microsoft.Graph.Beta.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType {
    /// <summary>
    /// Provides operations to call the getSuggestedEnrollmentLimit method.
    /// </summary>
    public class GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="enrollmentType">Usage: enrollmentType=&apos;{enrollmentType}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string enrollmentType = "") : base(requestAdapter, "{+baseurl}/deviceManagement/getSuggestedEnrollmentLimit(enrollmentType='{enrollmentType}')", pathParameters) {
            if (!string.IsNullOrWhiteSpace(enrollmentType)) PathParameters.Add("enrollmentType", enrollmentType);
        }
        /// <summary>
        /// Instantiates a new GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/getSuggestedEnrollmentLimit(enrollmentType='{enrollmentType}')", rawUrl) {
        }
        /// <summary>
        /// Invoke function getSuggestedEnrollmentLimit
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SuggestedEnrollmentLimit?> GetAsync(Action<GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SuggestedEnrollmentLimit> GetAsync(Action<GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SuggestedEnrollmentLimit>(requestInfo, SuggestedEnrollmentLimit.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function getSuggestedEnrollmentLimit
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new getSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
