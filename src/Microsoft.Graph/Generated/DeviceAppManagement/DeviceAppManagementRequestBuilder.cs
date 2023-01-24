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
    /// <summary>
    /// Provides operations to manage the deviceAppManagement singleton.
    /// </summary>
    public class DeviceAppManagementRequestBuilder {
        /// <summary>Provides operations to manage the androidManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.</summary>
        public AndroidManagedAppProtectionsRequestBuilder AndroidManagedAppProtections { get =>
            new AndroidManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the defaultManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.</summary>
        public DefaultManagedAppProtectionsRequestBuilder DefaultManagedAppProtections { get =>
            new DefaultManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceAppManagementTasks property of the microsoft.graph.deviceAppManagement entity.</summary>
        public DeviceAppManagementTasksRequestBuilder DeviceAppManagementTasks { get =>
            new DeviceAppManagementTasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the enterpriseCodeSigningCertificates property of the microsoft.graph.deviceAppManagement entity.</summary>
        public EnterpriseCodeSigningCertificatesRequestBuilder EnterpriseCodeSigningCertificates { get =>
            new EnterpriseCodeSigningCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the iosLobAppProvisioningConfigurations property of the microsoft.graph.deviceAppManagement entity.</summary>
        public IosLobAppProvisioningConfigurationsRequestBuilder IosLobAppProvisioningConfigurations { get =>
            new IosLobAppProvisioningConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the iosManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.</summary>
        public IosManagedAppProtectionsRequestBuilder IosManagedAppProtections { get =>
            new IosManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedAppPolicies property of the microsoft.graph.deviceAppManagement entity.</summary>
        public ManagedAppPoliciesRequestBuilder ManagedAppPolicies { get =>
            new ManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedAppRegistrations property of the microsoft.graph.deviceAppManagement entity.</summary>
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedAppStatuses property of the microsoft.graph.deviceAppManagement entity.</summary>
        public ManagedAppStatusesRequestBuilder ManagedAppStatuses { get =>
            new ManagedAppStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedEBookCategories property of the microsoft.graph.deviceAppManagement entity.</summary>
        public ManagedEBookCategoriesRequestBuilder ManagedEBookCategories { get =>
            new ManagedEBookCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedEBooks property of the microsoft.graph.deviceAppManagement entity.</summary>
        public ManagedEBooksRequestBuilder ManagedEBooks { get =>
            new ManagedEBooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mdmWindowsInformationProtectionPolicies property of the microsoft.graph.deviceAppManagement entity.</summary>
        public MdmWindowsInformationProtectionPoliciesRequestBuilder MdmWindowsInformationProtectionPolicies { get =>
            new MdmWindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileAppCategories property of the microsoft.graph.deviceAppManagement entity.</summary>
        public MobileAppCategoriesRequestBuilder MobileAppCategories { get =>
            new MobileAppCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileAppConfigurations property of the microsoft.graph.deviceAppManagement entity.</summary>
        public MobileAppConfigurationsRequestBuilder MobileAppConfigurations { get =>
            new MobileAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.</summary>
        public MobileAppsRequestBuilder MobileApps { get =>
            new MobileAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to manage the policySets property of the microsoft.graph.deviceAppManagement entity.</summary>
        public PolicySetsRequestBuilder PolicySets { get =>
            new PolicySetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the symantecCodeSigningCertificate property of the microsoft.graph.deviceAppManagement entity.</summary>
        public SymantecCodeSigningCertificateRequestBuilder SymantecCodeSigningCertificate { get =>
            new SymantecCodeSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the syncMicrosoftStoreForBusinessApps method.</summary>
        public SyncMicrosoftStoreForBusinessAppsRequestBuilder SyncMicrosoftStoreForBusinessApps { get =>
            new SyncMicrosoftStoreForBusinessAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the targetedManagedAppConfigurations property of the microsoft.graph.deviceAppManagement entity.</summary>
        public TargetedManagedAppConfigurationsRequestBuilder TargetedManagedAppConfigurations { get =>
            new TargetedManagedAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the vppTokens property of the microsoft.graph.deviceAppManagement entity.</summary>
        public VppTokensRequestBuilder VppTokens { get =>
            new VppTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the wdacSupplementalPolicies property of the microsoft.graph.deviceAppManagement entity.</summary>
        public WdacSupplementalPoliciesRequestBuilder WdacSupplementalPolicies { get =>
            new WdacSupplementalPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsInformationProtectionDeviceRegistrations property of the microsoft.graph.deviceAppManagement entity.</summary>
        public WindowsInformationProtectionDeviceRegistrationsRequestBuilder WindowsInformationProtectionDeviceRegistrations { get =>
            new WindowsInformationProtectionDeviceRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsInformationProtectionPolicies property of the microsoft.graph.deviceAppManagement entity.</summary>
        public WindowsInformationProtectionPoliciesRequestBuilder WindowsInformationProtectionPolicies { get =>
            new WindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsInformationProtectionWipeActions property of the microsoft.graph.deviceAppManagement entity.</summary>
        public WindowsInformationProtectionWipeActionsRequestBuilder WindowsInformationProtectionWipeActions { get =>
            new WindowsInformationProtectionWipeActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsManagedAppProtections property of the microsoft.graph.deviceAppManagement entity.</summary>
        public WindowsManagedAppProtectionsRequestBuilder WindowsManagedAppProtections { get =>
            new WindowsManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsManagementApp property of the microsoft.graph.deviceAppManagement entity.</summary>
        public WindowsManagementAppRequestBuilder WindowsManagementApp { get =>
            new WindowsManagementAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
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
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
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
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.DeviceAppManagement?> GetAsync(Action<DeviceAppManagementRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.DeviceAppManagement> GetAsync(Action<DeviceAppManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DeviceAppManagement>(requestInfo, Microsoft.Graph.Beta.Models.DeviceAppManagement.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update deviceAppManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.DeviceAppManagement?> PatchAsync(Microsoft.Graph.Beta.Models.DeviceAppManagement body, Action<DeviceAppManagementRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.DeviceAppManagement> PatchAsync(Microsoft.Graph.Beta.Models.DeviceAppManagement body, Action<DeviceAppManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DeviceAppManagement>(requestInfo, Microsoft.Graph.Beta.Models.DeviceAppManagement.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get deviceAppManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DeviceAppManagementRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DeviceAppManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
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
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.DeviceAppManagement body, Action<DeviceAppManagementRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.DeviceAppManagement body, Action<DeviceAppManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
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
        /// </summary>
        public class DeviceAppManagementRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceAppManagementRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceAppManagementRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceAppManagementRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new deviceAppManagementRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceAppManagementRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceAppManagementRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deviceAppManagementRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceAppManagementRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
