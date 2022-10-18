using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.ApproveApps;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CompleteSignup;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CreateGooglePlayWebToken;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.RequestSignupUrl;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.SetAndroidDeviceOwnerFullyManagedEnrollmentState;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.SyncApps;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.Unbind;
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
namespace Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings {
    /// <summary>Provides operations to manage the androidManagedStoreAccountEnterpriseSettings property of the microsoft.graph.deviceManagement entity.</summary>
    public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder {
        /// <summary>The approveApps property</summary>
        public ApproveAppsRequestBuilder ApproveApps { get =>
            new ApproveAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The completeSignup property</summary>
        public CompleteSignupRequestBuilder CompleteSignup { get =>
            new CompleteSignupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createGooglePlayWebToken property</summary>
        public CreateGooglePlayWebTokenRequestBuilder CreateGooglePlayWebToken { get =>
            new CreateGooglePlayWebTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The requestSignupUrl property</summary>
        public RequestSignupUrlRequestBuilder RequestSignupUrl { get =>
            new RequestSignupUrlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The setAndroidDeviceOwnerFullyManagedEnrollmentState property</summary>
        public SetAndroidDeviceOwnerFullyManagedEnrollmentStateRequestBuilder SetAndroidDeviceOwnerFullyManagedEnrollmentState { get =>
            new SetAndroidDeviceOwnerFullyManagedEnrollmentStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The syncApps property</summary>
        public SyncAppsRequestBuilder SyncApps { get =>
            new SyncAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The unbind property</summary>
        public UnbindRequestBuilder Unbind { get =>
            new UnbindRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/androidManagedStoreAccountEnterpriseSettings{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/androidManagedStoreAccountEnterpriseSettings{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property androidManagedStoreAccountEnterpriseSettings for deviceManagement
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The singleton Android managed store account enterprise settings entity.
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property androidManagedStoreAccountEnterpriseSettings in deviceManagement
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings body, Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property androidManagedStoreAccountEnterpriseSettings for deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public async Task DeleteAsync(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The singleton Android managed store account enterprise settings entity.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings> GetAsync(Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>(requestInfo, Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property androidManagedStoreAccountEnterpriseSettings in deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings> PatchAsync(Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings body, Action<AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>(requestInfo, Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new androidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>The singleton Android managed store account enterprise settings entity.</summary>
        public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new androidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new androidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
