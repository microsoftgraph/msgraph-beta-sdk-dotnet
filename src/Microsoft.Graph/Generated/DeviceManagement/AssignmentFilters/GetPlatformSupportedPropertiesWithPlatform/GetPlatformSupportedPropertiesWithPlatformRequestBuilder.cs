using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement.AssignmentFilters.GetPlatformSupportedPropertiesWithPlatform {
    /// <summary>Provides operations to call the getPlatformSupportedProperties method.</summary>
    public class GetPlatformSupportedPropertiesWithPlatformRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new GetPlatformSupportedPropertiesWithPlatformRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="platform">Usage: platform='{platform}'</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetPlatformSupportedPropertiesWithPlatformRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string platform = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/assignmentFilters/microsoft.graph.getPlatformSupportedProperties(platform='{platform}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("platform", platform);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetPlatformSupportedPropertiesWithPlatformRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetPlatformSupportedPropertiesWithPlatformRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/assignmentFilters/microsoft.graph.getPlatformSupportedProperties(platform='{platform}')";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getPlatformSupportedProperties
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function getPlatformSupportedProperties
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<GetPlatformSupportedPropertiesWithPlatformResponse> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendAsync<GetPlatformSupportedPropertiesWithPlatformResponse>(requestInfo, GetPlatformSupportedPropertiesWithPlatformResponse.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
    }
}
