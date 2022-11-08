using Microsoft.Graph.Beta.DeviceManagement.Reports.CachedReportConfigurations;
using Microsoft.Graph.Beta.DeviceManagement.Reports.ExportJobs;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetActiveMalwareReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetActiveMalwareSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetAllCertificatesReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetAppsInstallSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetAppStatusOverviewReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetCachedReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetCertificatesReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetCompliancePoliciesReportForDevice;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetCompliancePolicyDevicesReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetCompliancePolicyDeviceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetCompliancePolicyNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetCompliancePolicyNonComplianceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetComplianceSettingDetailsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetComplianceSettingNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetComplianceSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigManagerDevicePolicyStatusReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationPoliciesReportForDevice;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationPolicyDevicesReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationPolicyDeviceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationPolicySettingsDeviceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationSettingDetailsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationSettingNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetConfigurationSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetDeviceConfigurationPolicySettingsSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetDeviceConfigurationPolicyStatusSummary;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetDeviceInstallStatusReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetDeviceManagementIntentPerSettingContributingProfiles;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetDeviceManagementIntentSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetDeviceNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetEncryptionReportForDevices;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetEnrollmentConfigurationPoliciesByDevice;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetFailedMobileAppsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetFailedMobileAppsSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetGroupPolicySettingsDeviceSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetHistoricalReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetMalwareSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetMobileApplicationManagementAppConfigurationReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetMobileApplicationManagementAppRegistrationSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetNoncompliantDevicesAndSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetPolicyNonComplianceMetadata;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetPolicyNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetQuietTimePolicyUsersReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetQuietTimePolicyUserSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetRelatedAppsStatusReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetRemoteAssistanceSessionsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetReportFilters;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetSettingNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetUnhealthyDefenderAgentsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetUnhealthyFirewallReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetUnhealthyFirewallSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetUserInstallStatusReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetWindowsQualityUpdateAlertSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetWindowsUpdateAlertsPerPolicyPerDeviceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetWindowsUpdateAlertSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetZebraFotaDeploymentReport;
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
namespace Microsoft.Graph.Beta.DeviceManagement.Reports {
    /// <summary>Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.</summary>
    public class ReportsRequestBuilder {
        /// <summary>Provides operations to manage the cachedReportConfigurations property of the microsoft.graph.deviceManagementReports entity.</summary>
        public CachedReportConfigurationsRequestBuilder CachedReportConfigurations { get =>
            new CachedReportConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exportJobs property of the microsoft.graph.deviceManagementReports entity.</summary>
        public ExportJobsRequestBuilder ExportJobs { get =>
            new ExportJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActiveMalwareReport method.</summary>
        public GetActiveMalwareReportRequestBuilder GetActiveMalwareReport { get =>
            new GetActiveMalwareReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActiveMalwareSummaryReport method.</summary>
        public GetActiveMalwareSummaryReportRequestBuilder GetActiveMalwareSummaryReport { get =>
            new GetActiveMalwareSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAllCertificatesReport method.</summary>
        public GetAllCertificatesReportRequestBuilder GetAllCertificatesReport { get =>
            new GetAllCertificatesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAppsInstallSummaryReport method.</summary>
        public GetAppsInstallSummaryReportRequestBuilder GetAppsInstallSummaryReport { get =>
            new GetAppsInstallSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAppStatusOverviewReport method.</summary>
        public GetAppStatusOverviewReportRequestBuilder GetAppStatusOverviewReport { get =>
            new GetAppStatusOverviewReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCachedReport method.</summary>
        public GetCachedReportRequestBuilder GetCachedReport { get =>
            new GetCachedReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCertificatesReport method.</summary>
        public GetCertificatesReportRequestBuilder GetCertificatesReport { get =>
            new GetCertificatesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePoliciesReportForDevice method.</summary>
        public GetCompliancePoliciesReportForDeviceRequestBuilder GetCompliancePoliciesReportForDevice { get =>
            new GetCompliancePoliciesReportForDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyDevicesReport method.</summary>
        public GetCompliancePolicyDevicesReportRequestBuilder GetCompliancePolicyDevicesReport { get =>
            new GetCompliancePolicyDevicesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyDeviceSummaryReport method.</summary>
        public GetCompliancePolicyDeviceSummaryReportRequestBuilder GetCompliancePolicyDeviceSummaryReport { get =>
            new GetCompliancePolicyDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyNonComplianceReport method.</summary>
        public GetCompliancePolicyNonComplianceReportRequestBuilder GetCompliancePolicyNonComplianceReport { get =>
            new GetCompliancePolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyNonComplianceSummaryReport method.</summary>
        public GetCompliancePolicyNonComplianceSummaryReportRequestBuilder GetCompliancePolicyNonComplianceSummaryReport { get =>
            new GetCompliancePolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getComplianceSettingDetailsReport method.</summary>
        public GetComplianceSettingDetailsReportRequestBuilder GetComplianceSettingDetailsReport { get =>
            new GetComplianceSettingDetailsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getComplianceSettingNonComplianceReport method.</summary>
        public GetComplianceSettingNonComplianceReportRequestBuilder GetComplianceSettingNonComplianceReport { get =>
            new GetComplianceSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getComplianceSettingsReport method.</summary>
        public GetComplianceSettingsReportRequestBuilder GetComplianceSettingsReport { get =>
            new GetComplianceSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigManagerDevicePolicyStatusReport method.</summary>
        public GetConfigManagerDevicePolicyStatusReportRequestBuilder GetConfigManagerDevicePolicyStatusReport { get =>
            new GetConfigManagerDevicePolicyStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPoliciesReportForDevice method.</summary>
        public GetConfigurationPoliciesReportForDeviceRequestBuilder GetConfigurationPoliciesReportForDevice { get =>
            new GetConfigurationPoliciesReportForDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyDevicesReport method.</summary>
        public GetConfigurationPolicyDevicesReportRequestBuilder GetConfigurationPolicyDevicesReport { get =>
            new GetConfigurationPolicyDevicesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyDeviceSummaryReport method.</summary>
        public GetConfigurationPolicyDeviceSummaryReportRequestBuilder GetConfigurationPolicyDeviceSummaryReport { get =>
            new GetConfigurationPolicyDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyNonComplianceReport method.</summary>
        public GetConfigurationPolicyNonComplianceReportRequestBuilder GetConfigurationPolicyNonComplianceReport { get =>
            new GetConfigurationPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyNonComplianceSummaryReport method.</summary>
        public GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder GetConfigurationPolicyNonComplianceSummaryReport { get =>
            new GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicySettingsDeviceSummaryReport method.</summary>
        public GetConfigurationPolicySettingsDeviceSummaryReportRequestBuilder GetConfigurationPolicySettingsDeviceSummaryReport { get =>
            new GetConfigurationPolicySettingsDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationSettingDetailsReport method.</summary>
        public GetConfigurationSettingDetailsReportRequestBuilder GetConfigurationSettingDetailsReport { get =>
            new GetConfigurationSettingDetailsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationSettingNonComplianceReport method.</summary>
        public GetConfigurationSettingNonComplianceReportRequestBuilder GetConfigurationSettingNonComplianceReport { get =>
            new GetConfigurationSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationSettingsReport method.</summary>
        public GetConfigurationSettingsReportRequestBuilder GetConfigurationSettingsReport { get =>
            new GetConfigurationSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceConfigurationPolicySettingsSummaryReport method.</summary>
        public GetDeviceConfigurationPolicySettingsSummaryReportRequestBuilder GetDeviceConfigurationPolicySettingsSummaryReport { get =>
            new GetDeviceConfigurationPolicySettingsSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceConfigurationPolicyStatusSummary method.</summary>
        public GetDeviceConfigurationPolicyStatusSummaryRequestBuilder GetDeviceConfigurationPolicyStatusSummary { get =>
            new GetDeviceConfigurationPolicyStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceInstallStatusReport method.</summary>
        public GetDeviceInstallStatusReportRequestBuilder GetDeviceInstallStatusReport { get =>
            new GetDeviceInstallStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceManagementIntentPerSettingContributingProfiles method.</summary>
        public GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder GetDeviceManagementIntentPerSettingContributingProfiles { get =>
            new GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceManagementIntentSettingsReport method.</summary>
        public GetDeviceManagementIntentSettingsReportRequestBuilder GetDeviceManagementIntentSettingsReport { get =>
            new GetDeviceManagementIntentSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceNonComplianceReport method.</summary>
        public GetDeviceNonComplianceReportRequestBuilder GetDeviceNonComplianceReport { get =>
            new GetDeviceNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getEncryptionReportForDevices method.</summary>
        public GetEncryptionReportForDevicesRequestBuilder GetEncryptionReportForDevices { get =>
            new GetEncryptionReportForDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getEnrollmentConfigurationPoliciesByDevice method.</summary>
        public GetEnrollmentConfigurationPoliciesByDeviceRequestBuilder GetEnrollmentConfigurationPoliciesByDevice { get =>
            new GetEnrollmentConfigurationPoliciesByDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getFailedMobileAppsReport method.</summary>
        public GetFailedMobileAppsReportRequestBuilder GetFailedMobileAppsReport { get =>
            new GetFailedMobileAppsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getFailedMobileAppsSummaryReport method.</summary>
        public GetFailedMobileAppsSummaryReportRequestBuilder GetFailedMobileAppsSummaryReport { get =>
            new GetFailedMobileAppsSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getGroupPolicySettingsDeviceSettingsReport method.</summary>
        public GetGroupPolicySettingsDeviceSettingsReportRequestBuilder GetGroupPolicySettingsDeviceSettingsReport { get =>
            new GetGroupPolicySettingsDeviceSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getHistoricalReport method.</summary>
        public GetHistoricalReportRequestBuilder GetHistoricalReport { get =>
            new GetHistoricalReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMalwareSummaryReport method.</summary>
        public GetMalwareSummaryReportRequestBuilder GetMalwareSummaryReport { get =>
            new GetMalwareSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMobileApplicationManagementAppConfigurationReport method.</summary>
        public GetMobileApplicationManagementAppConfigurationReportRequestBuilder GetMobileApplicationManagementAppConfigurationReport { get =>
            new GetMobileApplicationManagementAppConfigurationReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMobileApplicationManagementAppRegistrationSummaryReport method.</summary>
        public GetMobileApplicationManagementAppRegistrationSummaryReportRequestBuilder GetMobileApplicationManagementAppRegistrationSummaryReport { get =>
            new GetMobileApplicationManagementAppRegistrationSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getNoncompliantDevicesAndSettingsReport method.</summary>
        public GetNoncompliantDevicesAndSettingsReportRequestBuilder GetNoncompliantDevicesAndSettingsReport { get =>
            new GetNoncompliantDevicesAndSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceMetadata method.</summary>
        public GetPolicyNonComplianceMetadataRequestBuilder GetPolicyNonComplianceMetadata { get =>
            new GetPolicyNonComplianceMetadataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceReport method.</summary>
        public GetPolicyNonComplianceReportRequestBuilder GetPolicyNonComplianceReport { get =>
            new GetPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceSummaryReport method.</summary>
        public GetPolicyNonComplianceSummaryReportRequestBuilder GetPolicyNonComplianceSummaryReport { get =>
            new GetPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getQuietTimePolicyUsersReport method.</summary>
        public GetQuietTimePolicyUsersReportRequestBuilder GetQuietTimePolicyUsersReport { get =>
            new GetQuietTimePolicyUsersReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getQuietTimePolicyUserSummaryReport method.</summary>
        public GetQuietTimePolicyUserSummaryReportRequestBuilder GetQuietTimePolicyUserSummaryReport { get =>
            new GetQuietTimePolicyUserSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getRelatedAppsStatusReport method.</summary>
        public GetRelatedAppsStatusReportRequestBuilder GetRelatedAppsStatusReport { get =>
            new GetRelatedAppsStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getRemoteAssistanceSessionsReport method.</summary>
        public GetRemoteAssistanceSessionsReportRequestBuilder GetRemoteAssistanceSessionsReport { get =>
            new GetRemoteAssistanceSessionsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getReportFilters method.</summary>
        public GetReportFiltersRequestBuilder GetReportFilters { get =>
            new GetReportFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getSettingNonComplianceReport method.</summary>
        public GetSettingNonComplianceReportRequestBuilder GetSettingNonComplianceReport { get =>
            new GetSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUnhealthyDefenderAgentsReport method.</summary>
        public GetUnhealthyDefenderAgentsReportRequestBuilder GetUnhealthyDefenderAgentsReport { get =>
            new GetUnhealthyDefenderAgentsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUnhealthyFirewallReport method.</summary>
        public GetUnhealthyFirewallReportRequestBuilder GetUnhealthyFirewallReport { get =>
            new GetUnhealthyFirewallReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUnhealthyFirewallSummaryReport method.</summary>
        public GetUnhealthyFirewallSummaryReportRequestBuilder GetUnhealthyFirewallSummaryReport { get =>
            new GetUnhealthyFirewallSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUserInstallStatusReport method.</summary>
        public GetUserInstallStatusReportRequestBuilder GetUserInstallStatusReport { get =>
            new GetUserInstallStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getWindowsQualityUpdateAlertsPerPolicyPerDeviceReport method.</summary>
        public GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReportRequestBuilder GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReport { get =>
            new GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getWindowsQualityUpdateAlertSummaryReport method.</summary>
        public GetWindowsQualityUpdateAlertSummaryReportRequestBuilder GetWindowsQualityUpdateAlertSummaryReport { get =>
            new GetWindowsQualityUpdateAlertSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getWindowsUpdateAlertsPerPolicyPerDeviceReport method.</summary>
        public GetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder GetWindowsUpdateAlertsPerPolicyPerDeviceReport { get =>
            new GetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getWindowsUpdateAlertSummaryReport method.</summary>
        public GetWindowsUpdateAlertSummaryReportRequestBuilder GetWindowsUpdateAlertSummaryReport { get =>
            new GetWindowsUpdateAlertSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getZebraFotaDeploymentReport method.</summary>
        public GetZebraFotaDeploymentReportRequestBuilder GetZebraFotaDeploymentReport { get =>
            new GetZebraFotaDeploymentReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateDeleteRequestInformation(Action<ReportsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Reports singleton
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreatePatchRequestInformation(DeviceManagementReports body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task DeleteAsync(Action<ReportsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Reports singleton
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<DeviceManagementReports> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceManagementReports>(requestInfo, DeviceManagementReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<DeviceManagementReports> PatchAsync(DeviceManagementReports body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceManagementReports>(requestInfo, DeviceManagementReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ReportsRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Reports singleton</summary>
        public class ReportsRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ReportsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ReportsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ReportsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new reportsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ReportsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
