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
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RetrieveRemoteHelpSessionWithSessionKey {
    /// <summary>
    /// Provides operations to call the retrieveRemoteHelpSession method.
    /// </summary>
    public class RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="sessionKey">Usage: sessionKey=&apos;{sessionKey}&apos;</param>
        public RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string sessionKey = "") : base(requestAdapter, "{+baseurl}/deviceManagement/comanagedDevices/{managedDevice%2Did}/retrieveRemoteHelpSession(sessionKey='{sessionKey}')", pathParameters) {
            if (!string.IsNullOrWhiteSpace(sessionKey)) PathParameters.Add("sessionKey", sessionKey);
        }
        /// <summary>
        /// Instantiates a new RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/comanagedDevices/{managedDevice%2Did}/retrieveRemoteHelpSession(sessionKey='{sessionKey}')", rawUrl) {
        }
        /// <summary>
        /// Invoke function retrieveRemoteHelpSession
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RetrieveRemoteHelpSessionResponse?> GetAsync(Action<RetrieveRemoteHelpSessionWithSessionKeyRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RetrieveRemoteHelpSessionResponse> GetAsync(Action<RetrieveRemoteHelpSessionWithSessionKeyRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RetrieveRemoteHelpSessionResponse>(requestInfo, RetrieveRemoteHelpSessionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function retrieveRemoteHelpSession
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RetrieveRemoteHelpSessionWithSessionKeyRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RetrieveRemoteHelpSessionWithSessionKeyRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RetrieveRemoteHelpSessionWithSessionKeyRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class RetrieveRemoteHelpSessionWithSessionKeyRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new retrieveRemoteHelpSessionWithSessionKeyRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public RetrieveRemoteHelpSessionWithSessionKeyRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
