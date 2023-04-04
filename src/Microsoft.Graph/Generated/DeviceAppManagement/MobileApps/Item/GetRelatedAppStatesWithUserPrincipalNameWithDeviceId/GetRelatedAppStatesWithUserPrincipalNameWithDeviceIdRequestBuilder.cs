using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GetRelatedAppStatesWithUserPrincipalNameWithDeviceId {
    /// <summary>
    /// Provides operations to call the getRelatedAppStates method.
    /// </summary>
    public class GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="deviceId">Usage: deviceId=&apos;{deviceId}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="userPrincipalName">Usage: userPrincipalName=&apos;{userPrincipalName}&apos;</param>
        public GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string deviceId = "", string userPrincipalName = "") : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/getRelatedAppStates(userPrincipalName='{userPrincipalName}',deviceId='{deviceId}'){?%24top,%24skip,%24search,%24filter,%24count}", pathParameters) {
            if (!string.IsNullOrWhiteSpace(deviceId)) PathParameters.Add("deviceId", deviceId);
            if (!string.IsNullOrWhiteSpace(userPrincipalName)) PathParameters.Add("userPrincipalName", userPrincipalName);
        }
        /// <summary>
        /// Instantiates a new GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/getRelatedAppStates(userPrincipalName='{userPrincipalName}',deviceId='{deviceId}'){?%24top,%24skip,%24search,%24filter,%24count}", rawUrl) {
        }
        /// <summary>
        /// Invoke function getRelatedAppStates
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse?> GetAsync(Action<GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse> GetAsync(Action<GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse>(requestInfo, GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function getRelatedAppStates
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Invoke function getRelatedAppStates
        /// </summary>
        public class GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
        public class GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new getRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
