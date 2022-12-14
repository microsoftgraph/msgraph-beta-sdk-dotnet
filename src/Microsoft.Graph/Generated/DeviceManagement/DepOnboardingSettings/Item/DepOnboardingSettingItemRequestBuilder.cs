using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.DefaultIosEnrollmentProfile;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.DefaultMacOsEnrollmentProfile;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.EnrollmentProfiles;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.GenerateEncryptionPublicKey;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.GetEncryptionPublicKey;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.ShareForSchoolDataSyncService;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.SyncWithAppleDeviceEnrollmentProgram;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.UnshareForSchoolDataSyncService;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.UploadDepToken;
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
namespace Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item {
    /// <summary>
    /// Provides operations to manage the depOnboardingSettings property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class DepOnboardingSettingItemRequestBuilder {
        /// <summary>Provides operations to manage the defaultIosEnrollmentProfile property of the microsoft.graph.depOnboardingSetting entity.</summary>
        public DefaultIosEnrollmentProfileRequestBuilder DefaultIosEnrollmentProfile { get =>
            new DefaultIosEnrollmentProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the defaultMacOsEnrollmentProfile property of the microsoft.graph.depOnboardingSetting entity.</summary>
        public DefaultMacOsEnrollmentProfileRequestBuilder DefaultMacOsEnrollmentProfile { get =>
            new DefaultMacOsEnrollmentProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the enrollmentProfiles property of the microsoft.graph.depOnboardingSetting entity.</summary>
        public EnrollmentProfilesRequestBuilder EnrollmentProfiles { get =>
            new EnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the generateEncryptionPublicKey method.</summary>
        public GenerateEncryptionPublicKeyRequestBuilder GenerateEncryptionPublicKey { get =>
            new GenerateEncryptionPublicKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the importedAppleDeviceIdentities property of the microsoft.graph.depOnboardingSetting entity.</summary>
        public ImportedAppleDeviceIdentitiesRequestBuilder ImportedAppleDeviceIdentities { get =>
            new ImportedAppleDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to call the shareForSchoolDataSyncService method.</summary>
        public ShareForSchoolDataSyncServiceRequestBuilder ShareForSchoolDataSyncService { get =>
            new ShareForSchoolDataSyncServiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the syncWithAppleDeviceEnrollmentProgram method.</summary>
        public SyncWithAppleDeviceEnrollmentProgramRequestBuilder SyncWithAppleDeviceEnrollmentProgram { get =>
            new SyncWithAppleDeviceEnrollmentProgramRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unshareForSchoolDataSyncService method.</summary>
        public UnshareForSchoolDataSyncServiceRequestBuilder UnshareForSchoolDataSyncService { get =>
            new UnshareForSchoolDataSyncServiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the uploadDepToken method.</summary>
        public UploadDepTokenRequestBuilder UploadDepToken { get =>
            new UploadDepTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DepOnboardingSettingItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DepOnboardingSettingItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DepOnboardingSettingItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DepOnboardingSettingItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property depOnboardingSettings for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateDeleteRequestInformation(Action<DepOnboardingSettingItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DepOnboardingSettingItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateGetRequestInformation(Action<DepOnboardingSettingItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DepOnboardingSettingItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property depOnboardingSettings in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreatePatchRequestInformation(DepOnboardingSetting body, Action<DepOnboardingSettingItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new DepOnboardingSettingItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property depOnboardingSettings for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task DeleteAsync(Action<DepOnboardingSettingItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<DepOnboardingSetting> GetAsync(Action<DepOnboardingSettingItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DepOnboardingSetting>(requestInfo, DepOnboardingSetting.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getEncryptionPublicKey method.
        /// </summary>
        public GetEncryptionPublicKeyRequestBuilder GetEncryptionPublicKey() {
            return new GetEncryptionPublicKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update the navigation property depOnboardingSettings in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<DepOnboardingSetting> PatchAsync(DepOnboardingSetting body, Action<DepOnboardingSettingItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DepOnboardingSetting>(requestInfo, DepOnboardingSetting.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DepOnboardingSettingItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new DepOnboardingSettingItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public DepOnboardingSettingItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        public class DepOnboardingSettingItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DepOnboardingSettingItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DepOnboardingSettingItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DepOnboardingSettingItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new DepOnboardingSettingItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DepOnboardingSettingItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DepOnboardingSettingItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new DepOnboardingSettingItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DepOnboardingSettingItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
