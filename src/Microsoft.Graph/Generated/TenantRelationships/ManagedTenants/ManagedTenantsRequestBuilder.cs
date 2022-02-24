using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.AggregatedPolicyCompliances;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.AuditEvents;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.CloudPcConnections;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.CloudPcDevices;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.CloudPcsOverview;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ConditionalAccessPolicyCoverages;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.CredentialUserRegistrationsSummaries;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.DeviceCompliancePolicySettingStateSummaries;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagedDeviceCompliances;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagedDeviceComplianceTrends;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementActions;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementActionTenantDeploymentStatuses;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementIntents;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementTemplateCollections;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementTemplates;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementTemplateSteps;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.ManagementTemplateStepVersions;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.TenantGroups;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.Tenants;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.TenantsCustomizedInformation;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.TenantsDetailedInformation;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.TenantTags;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.WindowsDeviceMalwareStates;
using MicrosoftGraphSdk.TenantRelationships.ManagedTenants.WindowsProtectionStates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.TenantRelationships.ManagedTenants {
    /// <summary>Builds and executes requests for operations under \tenantRelationships\managedTenants</summary>
    public class ManagedTenantsRequestBuilder {
        public AggregatedPolicyCompliancesRequestBuilder AggregatedPolicyCompliances { get =>
            new AggregatedPolicyCompliancesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CloudPcConnectionsRequestBuilder CloudPcConnections { get =>
            new CloudPcConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CloudPcDevicesRequestBuilder CloudPcDevices { get =>
            new CloudPcDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public CloudPcsOverviewRequestBuilder CloudPcsOverview { get =>
            new CloudPcsOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConditionalAccessPolicyCoveragesRequestBuilder ConditionalAccessPolicyCoverages { get =>
            new ConditionalAccessPolicyCoveragesRequestBuilder(PathParameters, RequestAdapter);
        }
        public CredentialUserRegistrationsSummariesRequestBuilder CredentialUserRegistrationsSummaries { get =>
            new CredentialUserRegistrationsSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDeviceCompliancesRequestBuilder ManagedDeviceCompliances { get =>
            new ManagedDeviceCompliancesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDeviceComplianceTrendsRequestBuilder ManagedDeviceComplianceTrends { get =>
            new ManagedDeviceComplianceTrendsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementActionsRequestBuilder ManagementActions { get =>
            new ManagementActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementActionTenantDeploymentStatusesRequestBuilder ManagementActionTenantDeploymentStatuses { get =>
            new ManagementActionTenantDeploymentStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementIntentsRequestBuilder ManagementIntents { get =>
            new ManagementIntentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementTemplateCollectionsRequestBuilder ManagementTemplateCollections { get =>
            new ManagementTemplateCollectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementTemplatesRequestBuilder ManagementTemplates { get =>
            new ManagementTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementTemplateStepsRequestBuilder ManagementTemplateSteps { get =>
            new ManagementTemplateStepsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementTemplateStepVersionsRequestBuilder ManagementTemplateStepVersions { get =>
            new ManagementTemplateStepVersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public TenantGroupsRequestBuilder TenantGroups { get =>
            new TenantGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TenantsRequestBuilder Tenants { get =>
            new TenantsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TenantsCustomizedInformationRequestBuilder TenantsCustomizedInformation { get =>
            new TenantsCustomizedInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        public TenantsDetailedInformationRequestBuilder TenantsDetailedInformation { get =>
            new TenantsDetailedInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        public TenantTagsRequestBuilder TenantTags { get =>
            new TenantTagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public WindowsDeviceMalwareStatesRequestBuilder WindowsDeviceMalwareStates { get =>
            new WindowsDeviceMalwareStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsProtectionStatesRequestBuilder WindowsProtectionStates { get =>
            new WindowsProtectionStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ManagedTenantsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedTenantsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/tenantRelationships/managedTenants{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ManagedTenantsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedTenantsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/tenantRelationships/managedTenants{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The operations available to interact with the multi-tenant management platform.
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
        /// The operations available to interact with the multi-tenant management platform.
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
        /// The operations available to interact with the multi-tenant management platform.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ManagedTenant body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The operations available to interact with the multi-tenant management platform.
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
        /// The operations available to interact with the multi-tenant management platform.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ManagedTenant> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ManagedTenant>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// The operations available to interact with the multi-tenant management platform.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ManagedTenant body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>The operations available to interact with the multi-tenant management platform.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
