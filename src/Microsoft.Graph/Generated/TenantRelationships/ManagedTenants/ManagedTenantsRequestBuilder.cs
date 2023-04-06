using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.AggregatedPolicyCompliances;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.AppPerformances;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.AuditEvents;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.CloudPcConnections;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.CloudPcDevices;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.CloudPcsOverview;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ConditionalAccessPolicyCoverages;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.CredentialUserRegistrationsSummaries;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.DeviceAppPerformances;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.DeviceCompliancePolicySettingStateSummaries;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.DeviceHealthStatuses;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedDeviceComplianceTrends;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedDeviceCompliances;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedTenantAlertLogs;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedTenantAlertRuleDefinitions;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedTenantAlertRules;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedTenantAlerts;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedTenantApiNotifications;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedTenantEmailNotifications;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedTenantTicketingEndpoints;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementActionTenantDeploymentStatuses;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementActions;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementIntents;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateCollectionTenantSummaries;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateCollections;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateStepTenantSummaries;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateStepVersions;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplateSteps;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementTemplates;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.MyRoles;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.TenantGroups;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.TenantTags;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.Tenants;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.TenantsCustomizedInformation;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.TenantsDetailedInformation;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.WindowsDeviceMalwareStates;
using Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.WindowsProtectionStates;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.TenantRelationships.ManagedTenants {
    /// <summary>
    /// Provides operations to manage the managedTenants property of the microsoft.graph.tenantRelationship entity.
    /// </summary>
    public class ManagedTenantsRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the aggregatedPolicyCompliances property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public AggregatedPolicyCompliancesRequestBuilder AggregatedPolicyCompliances { get =>
            new AggregatedPolicyCompliancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appPerformances property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public AppPerformancesRequestBuilder AppPerformances { get =>
            new AppPerformancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the auditEvents property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudPcConnections property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public CloudPcConnectionsRequestBuilder CloudPcConnections { get =>
            new CloudPcConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudPcDevices property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public CloudPcDevicesRequestBuilder CloudPcDevices { get =>
            new CloudPcDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudPcsOverview property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public CloudPcsOverviewRequestBuilder CloudPcsOverview { get =>
            new CloudPcsOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the conditionalAccessPolicyCoverages property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ConditionalAccessPolicyCoveragesRequestBuilder ConditionalAccessPolicyCoverages { get =>
            new ConditionalAccessPolicyCoveragesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the credentialUserRegistrationsSummaries property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public CredentialUserRegistrationsSummariesRequestBuilder CredentialUserRegistrationsSummaries { get =>
            new CredentialUserRegistrationsSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceAppPerformances property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public DeviceAppPerformancesRequestBuilder DeviceAppPerformances { get =>
            new DeviceAppPerformancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicySettingStateSummaries property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceHealthStatuses property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public DeviceHealthStatusesRequestBuilder DeviceHealthStatuses { get =>
            new DeviceHealthStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDeviceCompliances property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedDeviceCompliancesRequestBuilder ManagedDeviceCompliances { get =>
            new ManagedDeviceCompliancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDeviceComplianceTrends property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedDeviceComplianceTrendsRequestBuilder ManagedDeviceComplianceTrends { get =>
            new ManagedDeviceComplianceTrendsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedTenantAlertLogs property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedTenantAlertLogsRequestBuilder ManagedTenantAlertLogs { get =>
            new ManagedTenantAlertLogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedTenantAlertRuleDefinitions property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedTenantAlertRuleDefinitionsRequestBuilder ManagedTenantAlertRuleDefinitions { get =>
            new ManagedTenantAlertRuleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedTenantAlertRules property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedTenantAlertRulesRequestBuilder ManagedTenantAlertRules { get =>
            new ManagedTenantAlertRulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedTenantAlerts property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedTenantAlertsRequestBuilder ManagedTenantAlerts { get =>
            new ManagedTenantAlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedTenantApiNotifications property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedTenantApiNotificationsRequestBuilder ManagedTenantApiNotifications { get =>
            new ManagedTenantApiNotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedTenantEmailNotifications property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedTenantEmailNotificationsRequestBuilder ManagedTenantEmailNotifications { get =>
            new ManagedTenantEmailNotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedTenantTicketingEndpoints property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagedTenantTicketingEndpointsRequestBuilder ManagedTenantTicketingEndpoints { get =>
            new ManagedTenantTicketingEndpointsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementActions property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementActionsRequestBuilder ManagementActions { get =>
            new ManagementActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementActionTenantDeploymentStatuses property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementActionTenantDeploymentStatusesRequestBuilder ManagementActionTenantDeploymentStatuses { get =>
            new ManagementActionTenantDeploymentStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementIntents property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementIntentsRequestBuilder ManagementIntents { get =>
            new ManagementIntentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementTemplateCollections property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementTemplateCollectionsRequestBuilder ManagementTemplateCollections { get =>
            new ManagementTemplateCollectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementTemplateCollectionTenantSummaries property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementTemplateCollectionTenantSummariesRequestBuilder ManagementTemplateCollectionTenantSummaries { get =>
            new ManagementTemplateCollectionTenantSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementTemplates property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementTemplatesRequestBuilder ManagementTemplates { get =>
            new ManagementTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementTemplateSteps property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementTemplateStepsRequestBuilder ManagementTemplateSteps { get =>
            new ManagementTemplateStepsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementTemplateStepTenantSummaries property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementTemplateStepTenantSummariesRequestBuilder ManagementTemplateStepTenantSummaries { get =>
            new ManagementTemplateStepTenantSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managementTemplateStepVersions property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public ManagementTemplateStepVersionsRequestBuilder ManagementTemplateStepVersions { get =>
            new ManagementTemplateStepVersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the myRoles property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public MyRolesRequestBuilder MyRoles { get =>
            new MyRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tenantGroups property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public TenantGroupsRequestBuilder TenantGroups { get =>
            new TenantGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tenants property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public TenantsRequestBuilder Tenants { get =>
            new TenantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tenantsCustomizedInformation property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public TenantsCustomizedInformationRequestBuilder TenantsCustomizedInformation { get =>
            new TenantsCustomizedInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tenantsDetailedInformation property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public TenantsDetailedInformationRequestBuilder TenantsDetailedInformation { get =>
            new TenantsDetailedInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tenantTags property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public TenantTagsRequestBuilder TenantTags { get =>
            new TenantTagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsDeviceMalwareStates property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public WindowsDeviceMalwareStatesRequestBuilder WindowsDeviceMalwareStates { get =>
            new WindowsDeviceMalwareStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsProtectionStates property of the microsoft.graph.managedTenants.managedTenant entity.</summary>
        public WindowsProtectionStatesRequestBuilder WindowsProtectionStates { get =>
            new WindowsProtectionStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ManagedTenantsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedTenantsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/managedTenants{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ManagedTenantsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedTenantsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/managedTenants{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property managedTenants for tenantRelationships
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<ManagedTenantsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<ManagedTenantsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The operations available to interact with the multi-tenant management platform.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ManagedTenant?> GetAsync(Action<ManagedTenantsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ManagedTenant> GetAsync(Action<ManagedTenantsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedTenant>(requestInfo, ManagedTenant.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property managedTenants in tenantRelationships
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ManagedTenant?> PatchAsync(ManagedTenant body, Action<ManagedTenantsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ManagedTenant> PatchAsync(ManagedTenant body, Action<ManagedTenantsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedTenant>(requestInfo, ManagedTenant.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property managedTenants for tenantRelationships
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ManagedTenantsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ManagedTenantsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
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
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ManagedTenantsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ManagedTenantsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
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
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ManagedTenant body, Action<ManagedTenantsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ManagedTenant body, Action<ManagedTenantsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new ManagedTenantsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedTenantsRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new managedTenantsRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedTenantsRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The operations available to interact with the multi-tenant management platform.
        /// </summary>
        public class ManagedTenantsRequestBuilderGetQueryParameters {
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
        public class ManagedTenantsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ManagedTenantsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ManagedTenantsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new managedTenantsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedTenantsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedTenantsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new managedTenantsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedTenantsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
