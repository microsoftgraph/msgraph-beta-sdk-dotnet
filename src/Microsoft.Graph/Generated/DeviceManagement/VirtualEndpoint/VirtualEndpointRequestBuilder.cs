using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.AuditEvents;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.DeviceImages;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ExternalPartnerSettings;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GalleryImages;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GetEffectivePermissions;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.OnPremisesConnections;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.OrganizationSettings;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ProvisioningPolicies;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.ServicePlans;
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
    /// <summary>Provides operations to manage the virtualEndpoint property of the microsoft.graph.deviceManagement entity.</summary>
    public class VirtualEndpointRequestBuilder {
        /// <summary>The auditEvents property</summary>
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cloudPCs property</summary>
        public CloudPCsRequestBuilder CloudPCs { get =>
            new CloudPCsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceImages property</summary>
        public DeviceImagesRequestBuilder DeviceImages { get =>
            new DeviceImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The externalPartnerSettings property</summary>
        public ExternalPartnerSettingsRequestBuilder ExternalPartnerSettings { get =>
            new ExternalPartnerSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The galleryImages property</summary>
        public GalleryImagesRequestBuilder GalleryImages { get =>
            new GalleryImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The onPremisesConnections property</summary>
        public OnPremisesConnectionsRequestBuilder OnPremisesConnections { get =>
            new OnPremisesConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizationSettings property</summary>
        public OrganizationSettingsRequestBuilder OrganizationSettings { get =>
            new OrganizationSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The provisioningPolicies property</summary>
        public ProvisioningPoliciesRequestBuilder ProvisioningPolicies { get =>
            new ProvisioningPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reports property</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The servicePlans property</summary>
        public ServicePlansRequestBuilder ServicePlans { get =>
            new ServicePlansRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The snapshots property</summary>
        public SnapshotsRequestBuilder Snapshots { get =>
            new SnapshotsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The supportedRegions property</summary>
        public SupportedRegionsRequestBuilder SupportedRegions { get =>
            new SupportedRegionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The userSettings property</summary>
        public UserSettingsRequestBuilder UserSettings { get =>
            new UserSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new VirtualEndpointRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
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
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
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
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<VirtualEndpointRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
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
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<VirtualEndpointRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
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
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<VirtualEndpointRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
        /// Delete navigation property virtualEndpoint for deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<VirtualEndpointRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get virtualEndpoint from deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint> GetAsync(Action<VirtualEndpointRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.VirtualEndpoint>(requestInfo, Microsoft.Graph.Beta.Models.VirtualEndpoint.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// </summary>
        public GetEffectivePermissionsRequestBuilder GetEffectivePermissions() {
            return new GetEffectivePermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update the navigation property virtualEndpoint in deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.VirtualEndpoint> PatchAsync(Microsoft.Graph.Beta.Models.VirtualEndpoint body, Action<VirtualEndpointRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.VirtualEndpoint>(requestInfo, Microsoft.Graph.Beta.Models.VirtualEndpoint.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class VirtualEndpointRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new virtualEndpointRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEndpointRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Get virtualEndpoint from deviceManagement</summary>
        public class VirtualEndpointRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class VirtualEndpointRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public VirtualEndpointRequestBuilderGetQueryParameters QueryParameters { get; set; } = new VirtualEndpointRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new virtualEndpointRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEndpointRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class VirtualEndpointRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new virtualEndpointRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEndpointRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
