using Microsoft.Graph.Beta.DeviceAppManagement.AndroidManagedAppProtections;
using Microsoft.Graph.Beta.DeviceAppManagement.DefaultManagedAppProtections;
using Microsoft.Graph.Beta.DeviceAppManagement.DeviceAppManagementTasks;
using Microsoft.Graph.Beta.DeviceAppManagement.EnterpriseCodeSigningCertificates;
using Microsoft.Graph.Beta.DeviceAppManagement.IosLobAppProvisioningConfigurations;
using Microsoft.Graph.Beta.DeviceAppManagement.IosManagedAppProtections;
using Microsoft.Graph.Beta.DeviceAppManagement.ManagedAppPolicies;
using Microsoft.Graph.Beta.DeviceAppManagement.ManagedAppRegistrations;
using Microsoft.Graph.Beta.DeviceAppManagement.ManagedAppStatuses;
using Microsoft.Graph.Beta.DeviceAppManagement.ManagedEBookCategories;
using Microsoft.Graph.Beta.DeviceAppManagement.ManagedEBooks;
using Microsoft.Graph.Beta.DeviceAppManagement.MdmWindowsInformationProtectionPolicies;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileAppCategories;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileAppConfigurations;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps;
using Microsoft.Graph.Beta.DeviceAppManagement.PolicySets;
using Microsoft.Graph.Beta.DeviceAppManagement.SideLoadingKeys;
using Microsoft.Graph.Beta.DeviceAppManagement.SymantecCodeSigningCertificate;
using Microsoft.Graph.Beta.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps;
using Microsoft.Graph.Beta.DeviceAppManagement.TargetedManagedAppConfigurations;
using Microsoft.Graph.Beta.DeviceAppManagement.VppTokens;
using Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies;
using Microsoft.Graph.Beta.DeviceAppManagement.WindowsInformationProtectionDeviceRegistrations;
using Microsoft.Graph.Beta.DeviceAppManagement.WindowsInformationProtectionPolicies;
using Microsoft.Graph.Beta.DeviceAppManagement.WindowsInformationProtectionWipeActions;
using Microsoft.Graph.Beta.DeviceAppManagement.WindowsManagedAppProtections;
using Microsoft.Graph.Beta.DeviceAppManagement.WindowsManagementApp;
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
namespace Microsoft.Graph.Beta.DeviceAppManagement {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class DeviceAppManagementRequestBuilder {
        /// <summary>The androidManagedAppProtections property</summary>
        public AndroidManagedAppProtectionsRequestBuilder AndroidManagedAppProtections { get =>
            new AndroidManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultManagedAppProtections property</summary>
        public DefaultManagedAppProtectionsRequestBuilder DefaultManagedAppProtections { get =>
            new DefaultManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceAppManagementTasks property</summary>
        public DeviceAppManagementTasksRequestBuilder DeviceAppManagementTasks { get =>
            new DeviceAppManagementTasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enterpriseCodeSigningCertificates property</summary>
        public EnterpriseCodeSigningCertificatesRequestBuilder EnterpriseCodeSigningCertificates { get =>
            new EnterpriseCodeSigningCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The iosLobAppProvisioningConfigurations property</summary>
        public IosLobAppProvisioningConfigurationsRequestBuilder IosLobAppProvisioningConfigurations { get =>
            new IosLobAppProvisioningConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The iosManagedAppProtections property</summary>
        public IosManagedAppProtectionsRequestBuilder IosManagedAppProtections { get =>
            new IosManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedAppPolicies property</summary>
        public ManagedAppPoliciesRequestBuilder ManagedAppPolicies { get =>
            new ManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedAppRegistrations property</summary>
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedAppStatuses property</summary>
        public ManagedAppStatusesRequestBuilder ManagedAppStatuses { get =>
            new ManagedAppStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedEBookCategories property</summary>
        public ManagedEBookCategoriesRequestBuilder ManagedEBookCategories { get =>
            new ManagedEBookCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedEBooks property</summary>
        public ManagedEBooksRequestBuilder ManagedEBooks { get =>
            new ManagedEBooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mdmWindowsInformationProtectionPolicies property</summary>
        public MdmWindowsInformationProtectionPoliciesRequestBuilder MdmWindowsInformationProtectionPolicies { get =>
            new MdmWindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileAppCategories property</summary>
        public MobileAppCategoriesRequestBuilder MobileAppCategories { get =>
            new MobileAppCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileAppConfigurations property</summary>
        public MobileAppConfigurationsRequestBuilder MobileAppConfigurations { get =>
            new MobileAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileApps property</summary>
        public MobileAppsRequestBuilder MobileApps { get =>
            new MobileAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The policySets property</summary>
        public PolicySetsRequestBuilder PolicySets { get =>
            new PolicySetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The sideLoadingKeys property</summary>
        public SideLoadingKeysRequestBuilder SideLoadingKeys { get =>
            new SideLoadingKeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The symantecCodeSigningCertificate property</summary>
        public SymantecCodeSigningCertificateRequestBuilder SymantecCodeSigningCertificate { get =>
            new SymantecCodeSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The syncMicrosoftStoreForBusinessApps property</summary>
        public SyncMicrosoftStoreForBusinessAppsRequestBuilder SyncMicrosoftStoreForBusinessApps { get =>
            new SyncMicrosoftStoreForBusinessAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The targetedManagedAppConfigurations property</summary>
        public TargetedManagedAppConfigurationsRequestBuilder TargetedManagedAppConfigurations { get =>
            new TargetedManagedAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The vppTokens property</summary>
        public VppTokensRequestBuilder VppTokens { get =>
            new VppTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wdacSupplementalPolicies property</summary>
        public WdacSupplementalPoliciesRequestBuilder WdacSupplementalPolicies { get =>
            new WdacSupplementalPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionDeviceRegistrations property</summary>
        public WindowsInformationProtectionDeviceRegistrationsRequestBuilder WindowsInformationProtectionDeviceRegistrations { get =>
            new WindowsInformationProtectionDeviceRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionPolicies property</summary>
        public WindowsInformationProtectionPoliciesRequestBuilder WindowsInformationProtectionPolicies { get =>
            new WindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionWipeActions property</summary>
        public WindowsInformationProtectionWipeActionsRequestBuilder WindowsInformationProtectionWipeActions { get =>
            new WindowsInformationProtectionWipeActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsManagedAppProtections property</summary>
        public WindowsManagedAppProtectionsRequestBuilder WindowsManagedAppProtections { get =>
            new WindowsManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsManagementApp property</summary>
        public WindowsManagementAppRequestBuilder WindowsManagementApp { get =>
            new WindowsManagementAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get deviceAppManagement
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<DeviceAppManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DeviceAppManagementRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.DeviceAppManagement body, Action<DeviceAppManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new DeviceAppManagementRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get deviceAppManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.DeviceAppManagement> GetAsync(CancellationToken cancellationToken = default, Action<DeviceAppManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DeviceAppManagement>(requestInfo, Microsoft.Graph.Beta.Models.DeviceAppManagement.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Microsoft.Graph.Beta.Models.DeviceAppManagement body, CancellationToken cancellationToken = default, Action<DeviceAppManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get deviceAppManagement</summary>
        public class DeviceAppManagementRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class DeviceAppManagementRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceAppManagementRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceAppManagementRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new deviceAppManagementRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceAppManagementRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class DeviceAppManagementRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deviceAppManagementRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceAppManagementRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
