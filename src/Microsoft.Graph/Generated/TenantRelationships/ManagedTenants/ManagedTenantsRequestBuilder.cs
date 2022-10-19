using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.AggregatedPolicyCompliances;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.AuditEvents;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.CloudPcConnections;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.CloudPcDevices;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.CloudPcsOverview;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ConditionalAccessPolicyCoverages;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.CredentialUserRegistrationsSummaries;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.DeviceCompliancePolicySettingStateSummaries;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedDeviceCompliances;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedDeviceComplianceTrends;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementActions;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementActionTenantDeploymentStatuses;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementIntents;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateCollections;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplates;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateSteps;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateStepVersions;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.MyRoles;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.TenantGroups;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.Tenants;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.TenantsCustomizedInformation;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.TenantsDetailedInformation;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.TenantTags;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.WindowsDeviceMalwareStates;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.WindowsProtectionStates;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.TenantRelationships.ManagedTenants {
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
        /// <summary>The myRoles property</summary>
        public MyRolesRequestBuilder MyRoles { get =>
            new MyRolesRequestBuilder(PathParameters, RequestAdapter);
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
            UrlTemplate = "{+baseurl}/tenantRelationships/managedTenants{?%24select,%24expand}";
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
            UrlTemplate = "{+baseurl}/tenantRelationships/managedTenants{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property managedTenants for tenantRelationships
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<ManagedTenantsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ManagedTenantsRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The operations available to interact with the multi-tenant management platform.
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<ManagedTenantsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ManagedTenantsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property managedTenants in tenantRelationships
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ManagedTenant body, Action<ManagedTenantsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ManagedTenantsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property managedTenants for tenantRelationships
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public async Task DeleteAsync(Action<ManagedTenantsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The operations available to interact with the multi-tenant management platform.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public async Task<ManagedTenant> GetAsync(Action<ManagedTenantsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedTenant>(requestInfo, ManagedTenant.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property managedTenants in tenantRelationships
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public async Task<ManagedTenant> PatchAsync(ManagedTenant body, Action<ManagedTenantsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedTenant>(requestInfo, ManagedTenant.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ManagedTenantsRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new managedTenantsRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedTenantsRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>The operations available to interact with the multi-tenant management platform.</summary>
        public class ManagedTenantsRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ManagedTenantsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ManagedTenantsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ManagedTenantsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new managedTenantsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedTenantsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ManagedTenantsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new managedTenantsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedTenantsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
