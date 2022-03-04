using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.DefaultIosEnrollmentProfile;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.DefaultMacOsEnrollmentProfile;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.EnrollmentProfiles;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.GenerateEncryptionPublicKey;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.GetEncryptionPublicKey;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.ShareForSchoolDataSyncService;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.SyncWithAppleDeviceEnrollmentProgram;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.UnshareForSchoolDataSyncService;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item.UploadDepToken;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\depOnboardingSettings\{depOnboardingSetting-id}</summary>
    public class DepOnboardingSettingItemRequestBuilder {
        public DefaultIosEnrollmentProfileRequestBuilder DefaultIosEnrollmentProfile { get =>
            new DefaultIosEnrollmentProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        public DefaultMacOsEnrollmentProfileRequestBuilder DefaultMacOsEnrollmentProfile { get =>
            new DefaultMacOsEnrollmentProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        public EnrollmentProfilesRequestBuilder EnrollmentProfiles { get =>
            new EnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GenerateEncryptionPublicKeyRequestBuilder GenerateEncryptionPublicKey { get =>
            new GenerateEncryptionPublicKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImportedAppleDeviceIdentitiesRequestBuilder ImportedAppleDeviceIdentities { get =>
            new ImportedAppleDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ShareForSchoolDataSyncServiceRequestBuilder ShareForSchoolDataSyncService { get =>
            new ShareForSchoolDataSyncServiceRequestBuilder(PathParameters, RequestAdapter);
        }
        public SyncWithAppleDeviceEnrollmentProgramRequestBuilder SyncWithAppleDeviceEnrollmentProgram { get =>
            new SyncWithAppleDeviceEnrollmentProgramRequestBuilder(PathParameters, RequestAdapter);
        }
        public UnshareForSchoolDataSyncServiceRequestBuilder UnshareForSchoolDataSyncService { get =>
            new UnshareForSchoolDataSyncServiceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UploadDepTokenRequestBuilder UploadDepToken { get =>
            new UploadDepTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DepOnboardingSettingItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DepOnboardingSettingItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DepOnboardingSettingItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DepOnboardingSettingItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DepOnboardingSetting body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DepOnboardingSetting> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<DepOnboardingSetting>(requestInfo, DepOnboardingSetting.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\depOnboardingSettings\{depOnboardingSetting-id}\microsoft.graph.getEncryptionPublicKey()
        /// </summary>
        public GetEncryptionPublicKeyRequestBuilder GetEncryptionPublicKey() {
            return new GetEncryptionPublicKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DepOnboardingSetting body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>This collections of multiple DEP tokens per-tenant.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
