using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.AuditEvents;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CrossCloudGovernmentOrganizationMapping;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.DeviceImages;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ExternalPartnerSettings;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GalleryImages;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GetEffectivePermissions;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.OnPremisesConnections;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.OrganizationSettings;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ServicePlans;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.SharedUseServicePlans;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Snapshots;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.SupportedRegions;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.UserSettings;
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
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint {
    /// <summary>
    /// Provides operations to manage the virtualEndpoint property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class VirtualEndpointRequestBuilder {
        /// <summary>Provides operations to manage the auditEvents property of the microsoft.graph.virtualEndpoint entity.</summary>
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudPCs property of the microsoft.graph.virtualEndpoint entity.</summary>
        public CloudPCsRequestBuilder CloudPCs { get =>
            new CloudPCsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the crossCloudGovernmentOrganizationMapping property of the microsoft.graph.virtualEndpoint entity.</summary>
        public CrossCloudGovernmentOrganizationMappingRequestBuilder CrossCloudGovernmentOrganizationMapping { get =>
            new CrossCloudGovernmentOrganizationMappingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceImages property of the microsoft.graph.virtualEndpoint entity.</summary>
        public DeviceImagesRequestBuilder DeviceImages { get =>
            new DeviceImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalPartnerSettings property of the microsoft.graph.virtualEndpoint entity.</summary>
        public ExternalPartnerSettingsRequestBuilder ExternalPartnerSettings { get =>
            new ExternalPartnerSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the galleryImages property of the microsoft.graph.virtualEndpoint entity.</summary>
        public GalleryImagesRequestBuilder GalleryImages { get =>
            new GalleryImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onPremisesConnections property of the microsoft.graph.virtualEndpoint entity.</summary>
        public OnPremisesConnectionsRequestBuilder OnPremisesConnections { get =>
            new OnPremisesConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the organizationSettings property of the microsoft.graph.virtualEndpoint entity.</summary>
        public OrganizationSettingsRequestBuilder OrganizationSettings { get =>
            new OrganizationSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to manage the provisioningPolicies property of the microsoft.graph.virtualEndpoint entity.</summary>
        public ProvisioningPoliciesRequestBuilder ProvisioningPolicies { get =>
            new ProvisioningPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reports property of the microsoft.graph.virtualEndpoint entity.</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the servicePlans property of the microsoft.graph.virtualEndpoint entity.</summary>
        public ServicePlansRequestBuilder ServicePlans { get =>
            new ServicePlansRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sharedUseServicePlans property of the microsoft.graph.virtualEndpoint entity.</summary>
        public SharedUseServicePlansRequestBuilder SharedUseServicePlans { get =>
            new SharedUseServicePlansRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the snapshots property of the microsoft.graph.virtualEndpoint entity.</summary>
        public SnapshotsRequestBuilder Snapshots { get =>
            new SnapshotsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the supportedRegions property of the microsoft.graph.virtualEndpoint entity.</summary>
        public SupportedRegionsRequestBuilder SupportedRegions { get =>
            new SupportedRegionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the userSettings property of the microsoft.graph.virtualEndpoint entity.</summary>
        public UserSettingsRequestBuilder UserSettings { get =>
            new UserSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new VirtualEndpointRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VirtualEndpointRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/virtualEndpoint{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new VirtualEndpointRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VirtualEndpointRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/virtualEndpoint{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property virtualEndpoint for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<VirtualEndpointRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<VirtualEndpointRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get virtualEndpoint from deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint?> GetAsync(Action<VirtualEndpointRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint> GetAsync(Action<VirtualEndpointRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.VirtualEndpoint>(requestInfo, Microsoft.Graph.Beta.Models.VirtualEndpoint.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// </summary>
        public GetEffectivePermissionsRequestBuilder GetEffectivePermissions() {
            return new GetEffectivePermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update the navigation property virtualEndpoint in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint?> PatchAsync(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<VirtualEndpointRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint> PatchAsync(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<VirtualEndpointRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.VirtualEndpoint>(requestInfo, Microsoft.Graph.Beta.Models.VirtualEndpoint.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property virtualEndpoint for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<VirtualEndpointRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<VirtualEndpointRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new VirtualEndpointRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get virtualEndpoint from deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<VirtualEndpointRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<VirtualEndpointRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new VirtualEndpointRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property virtualEndpoint in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<VirtualEndpointRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<VirtualEndpointRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new VirtualEndpointRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class VirtualEndpointRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new virtualEndpointRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEndpointRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get virtualEndpoint from deviceManagement
        /// </summary>
        public class VirtualEndpointRequestBuilderGetQueryParameters {
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
        public class VirtualEndpointRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public VirtualEndpointRequestBuilderGetQueryParameters QueryParameters { get; set; } = new VirtualEndpointRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new virtualEndpointRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEndpointRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class VirtualEndpointRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new virtualEndpointRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEndpointRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
