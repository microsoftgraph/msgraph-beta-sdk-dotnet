using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
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
    /// <summary>Provides operations to manage the managedTenants property of the microsoft.graph.tenantRelationship entity.</summary>
    public class ManagedTenantsRequestBuilder {
        /// <summary>The aggregatedPolicyCompliances property</summary>
        public AggregatedPolicyCompliancesRequestBuilder AggregatedPolicyCompliances { get =>
            new AggregatedPolicyCompliancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The auditEvents property</summary>
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cloudPcConnections property</summary>
        public CloudPcConnectionsRequestBuilder CloudPcConnections { get =>
            new CloudPcConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cloudPcDevices property</summary>
        public CloudPcDevicesRequestBuilder CloudPcDevices { get =>
            new CloudPcDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cloudPcsOverview property</summary>
        public CloudPcsOverviewRequestBuilder CloudPcsOverview { get =>
            new CloudPcsOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The conditionalAccessPolicyCoverages property</summary>
        public ConditionalAccessPolicyCoveragesRequestBuilder ConditionalAccessPolicyCoverages { get =>
            new ConditionalAccessPolicyCoveragesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The credentialUserRegistrationsSummaries property</summary>
        public CredentialUserRegistrationsSummariesRequestBuilder CredentialUserRegistrationsSummaries { get =>
            new CredentialUserRegistrationsSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCompliancePolicySettingStateSummaries property</summary>
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedDeviceCompliances property</summary>
        public ManagedDeviceCompliancesRequestBuilder ManagedDeviceCompliances { get =>
            new ManagedDeviceCompliancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedDeviceComplianceTrends property</summary>
        public ManagedDeviceComplianceTrendsRequestBuilder ManagedDeviceComplianceTrends { get =>
            new ManagedDeviceComplianceTrendsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementActions property</summary>
        public ManagementActionsRequestBuilder ManagementActions { get =>
            new ManagementActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementActionTenantDeploymentStatuses property</summary>
        public ManagementActionTenantDeploymentStatusesRequestBuilder ManagementActionTenantDeploymentStatuses { get =>
            new ManagementActionTenantDeploymentStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementIntents property</summary>
        public ManagementIntentsRequestBuilder ManagementIntents { get =>
            new ManagementIntentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementTemplateCollections property</summary>
        public ManagementTemplateCollectionsRequestBuilder ManagementTemplateCollections { get =>
            new ManagementTemplateCollectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementTemplates property</summary>
        public ManagementTemplatesRequestBuilder ManagementTemplates { get =>
            new ManagementTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementTemplateSteps property</summary>
        public ManagementTemplateStepsRequestBuilder ManagementTemplateSteps { get =>
            new ManagementTemplateStepsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementTemplateStepVersions property</summary>
        public ManagementTemplateStepVersionsRequestBuilder ManagementTemplateStepVersions { get =>
            new ManagementTemplateStepVersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The tenantGroups property</summary>
        public TenantGroupsRequestBuilder TenantGroups { get =>
            new TenantGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tenants property</summary>
        public TenantsRequestBuilder Tenants { get =>
            new TenantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tenantsCustomizedInformation property</summary>
        public TenantsCustomizedInformationRequestBuilder TenantsCustomizedInformation { get =>
            new TenantsCustomizedInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tenantsDetailedInformation property</summary>
        public TenantsDetailedInformationRequestBuilder TenantsDetailedInformation { get =>
            new TenantsDetailedInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tenantTags property</summary>
        public TenantTagsRequestBuilder TenantTags { get =>
            new TenantTagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The windowsDeviceMalwareStates property</summary>
        public WindowsDeviceMalwareStatesRequestBuilder WindowsDeviceMalwareStates { get =>
            new WindowsDeviceMalwareStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsProtectionStates property</summary>
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
        /// Delete navigation property managedTenants for tenantRelationships
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The operations available to interact with the multi-tenant management platform.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property managedTenants in tenantRelationships
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ManagedTenant body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property managedTenants for tenantRelationships
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The operations available to interact with the multi-tenant management platform.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ManagedTenant> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedTenant>(requestInfo, ManagedTenant.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property managedTenants in tenantRelationships
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ManagedTenant body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
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
