using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.AuditEvents;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.CloudPCs;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.DeviceImages;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.GalleryImages;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.GetEffectivePermissions;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.OnPremisesConnections;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.OrganizationSettings;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.ProvisioningPolicies;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.ServicePlans;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.Snapshots;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.SupportedRegions;
using MicrosoftGraph.DeviceManagement.VirtualEndpoint.UserSettings;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.DeviceManagement.VirtualEndpoint {
    /// <summary>Builds and executes requests for operations under \deviceManagement\virtualEndpoint</summary>
    public class VirtualEndpointRequestBuilder {
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CloudPCsRequestBuilder CloudPCs { get =>
            new CloudPCsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceImagesRequestBuilder DeviceImages { get =>
            new DeviceImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GalleryImagesRequestBuilder GalleryImages { get =>
            new GalleryImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        public OnPremisesConnectionsRequestBuilder OnPremisesConnections { get =>
            new OnPremisesConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OrganizationSettingsRequestBuilder OrganizationSettings { get =>
            new OrganizationSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public ProvisioningPoliciesRequestBuilder ProvisioningPolicies { get =>
            new ProvisioningPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ServicePlansRequestBuilder ServicePlans { get =>
            new ServicePlansRequestBuilder(PathParameters, RequestAdapter);
        }
        public SnapshotsRequestBuilder Snapshots { get =>
            new SnapshotsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SupportedRegionsRequestBuilder SupportedRegions { get =>
            new SupportedRegionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
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
            UrlTemplate = "{+baseurl}/deviceManagement/virtualEndpoint{?select,expand}";
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
            UrlTemplate = "{+baseurl}/deviceManagement/virtualEndpoint{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property virtualEndpoint for deviceManagement
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
        /// Get virtualEndpoint from deviceManagement
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
        /// Update the navigation property virtualEndpoint in deviceManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraph.Models.Microsoft.Graph.VirtualEndpoint body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete navigation property virtualEndpoint for deviceManagement
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
        /// Get virtualEndpoint from deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraph.Models.Microsoft.Graph.VirtualEndpoint> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraph.Models.Microsoft.Graph.VirtualEndpoint>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\virtualEndpoint\microsoft.graph.getEffectivePermissions()
        /// </summary>
        public GetEffectivePermissionsRequestBuilder GetEffectivePermissions() {
            return new GetEffectivePermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update the navigation property virtualEndpoint in deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraph.Models.Microsoft.Graph.VirtualEndpoint body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>Get virtualEndpoint from deviceManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
