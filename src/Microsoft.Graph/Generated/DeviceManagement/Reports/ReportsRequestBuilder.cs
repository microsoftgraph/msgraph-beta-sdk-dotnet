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
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetEnrollmentConfigurationPoliciesByDevice;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetFailedMobileAppsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetFailedMobileAppsSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetGroupPolicySettingsDeviceSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetHistoricalReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.GetMalwareSummaryReport;
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
        /// <summary>The cachedReportConfigurations property</summary>
        public CachedReportConfigurationsRequestBuilder CachedReportConfigurations { get =>
            new CachedReportConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The exportJobs property</summary>
        public ExportJobsRequestBuilder ExportJobs { get =>
            new ExportJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getActiveMalwareReport property</summary>
        public GetActiveMalwareReportRequestBuilder GetActiveMalwareReport { get =>
            new GetActiveMalwareReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getActiveMalwareSummaryReport property</summary>
        public GetActiveMalwareSummaryReportRequestBuilder GetActiveMalwareSummaryReport { get =>
            new GetActiveMalwareSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getAllCertificatesReport property</summary>
        public GetAllCertificatesReportRequestBuilder GetAllCertificatesReport { get =>
            new GetAllCertificatesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getAppsInstallSummaryReport property</summary>
        public GetAppsInstallSummaryReportRequestBuilder GetAppsInstallSummaryReport { get =>
            new GetAppsInstallSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getAppStatusOverviewReport property</summary>
        public GetAppStatusOverviewReportRequestBuilder GetAppStatusOverviewReport { get =>
            new GetAppStatusOverviewReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getCachedReport property</summary>
        public GetCachedReportRequestBuilder GetCachedReport { get =>
            new GetCachedReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getCertificatesReport property</summary>
        public GetCertificatesReportRequestBuilder GetCertificatesReport { get =>
            new GetCertificatesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getCompliancePoliciesReportForDevice property</summary>
        public GetCompliancePoliciesReportForDeviceRequestBuilder GetCompliancePoliciesReportForDevice { get =>
            new GetCompliancePoliciesReportForDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getCompliancePolicyDevicesReport property</summary>
        public GetCompliancePolicyDevicesReportRequestBuilder GetCompliancePolicyDevicesReport { get =>
            new GetCompliancePolicyDevicesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getCompliancePolicyDeviceSummaryReport property</summary>
        public GetCompliancePolicyDeviceSummaryReportRequestBuilder GetCompliancePolicyDeviceSummaryReport { get =>
            new GetCompliancePolicyDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getCompliancePolicyNonComplianceReport property</summary>
        public GetCompliancePolicyNonComplianceReportRequestBuilder GetCompliancePolicyNonComplianceReport { get =>
            new GetCompliancePolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getCompliancePolicyNonComplianceSummaryReport property</summary>
        public GetCompliancePolicyNonComplianceSummaryReportRequestBuilder GetCompliancePolicyNonComplianceSummaryReport { get =>
            new GetCompliancePolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getComplianceSettingDetailsReport property</summary>
        public GetComplianceSettingDetailsReportRequestBuilder GetComplianceSettingDetailsReport { get =>
            new GetComplianceSettingDetailsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getComplianceSettingNonComplianceReport property</summary>
        public GetComplianceSettingNonComplianceReportRequestBuilder GetComplianceSettingNonComplianceReport { get =>
            new GetComplianceSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getComplianceSettingsReport property</summary>
        public GetComplianceSettingsReportRequestBuilder GetComplianceSettingsReport { get =>
            new GetComplianceSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigManagerDevicePolicyStatusReport property</summary>
        public GetConfigManagerDevicePolicyStatusReportRequestBuilder GetConfigManagerDevicePolicyStatusReport { get =>
            new GetConfigManagerDevicePolicyStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationPoliciesReportForDevice property</summary>
        public GetConfigurationPoliciesReportForDeviceRequestBuilder GetConfigurationPoliciesReportForDevice { get =>
            new GetConfigurationPoliciesReportForDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationPolicyDevicesReport property</summary>
        public GetConfigurationPolicyDevicesReportRequestBuilder GetConfigurationPolicyDevicesReport { get =>
            new GetConfigurationPolicyDevicesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationPolicyDeviceSummaryReport property</summary>
        public GetConfigurationPolicyDeviceSummaryReportRequestBuilder GetConfigurationPolicyDeviceSummaryReport { get =>
            new GetConfigurationPolicyDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationPolicyNonComplianceReport property</summary>
        public GetConfigurationPolicyNonComplianceReportRequestBuilder GetConfigurationPolicyNonComplianceReport { get =>
            new GetConfigurationPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationPolicyNonComplianceSummaryReport property</summary>
        public GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder GetConfigurationPolicyNonComplianceSummaryReport { get =>
            new GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationPolicySettingsDeviceSummaryReport property</summary>
        public GetConfigurationPolicySettingsDeviceSummaryReportRequestBuilder GetConfigurationPolicySettingsDeviceSummaryReport { get =>
            new GetConfigurationPolicySettingsDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationSettingDetailsReport property</summary>
        public GetConfigurationSettingDetailsReportRequestBuilder GetConfigurationSettingDetailsReport { get =>
            new GetConfigurationSettingDetailsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationSettingNonComplianceReport property</summary>
        public GetConfigurationSettingNonComplianceReportRequestBuilder GetConfigurationSettingNonComplianceReport { get =>
            new GetConfigurationSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getConfigurationSettingsReport property</summary>
        public GetConfigurationSettingsReportRequestBuilder GetConfigurationSettingsReport { get =>
            new GetConfigurationSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getDeviceConfigurationPolicySettingsSummaryReport property</summary>
        public GetDeviceConfigurationPolicySettingsSummaryReportRequestBuilder GetDeviceConfigurationPolicySettingsSummaryReport { get =>
            new GetDeviceConfigurationPolicySettingsSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getDeviceConfigurationPolicyStatusSummary property</summary>
        public GetDeviceConfigurationPolicyStatusSummaryRequestBuilder GetDeviceConfigurationPolicyStatusSummary { get =>
            new GetDeviceConfigurationPolicyStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getDeviceInstallStatusReport property</summary>
        public GetDeviceInstallStatusReportRequestBuilder GetDeviceInstallStatusReport { get =>
            new GetDeviceInstallStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getDeviceManagementIntentPerSettingContributingProfiles property</summary>
        public GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder GetDeviceManagementIntentPerSettingContributingProfiles { get =>
            new GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getDeviceManagementIntentSettingsReport property</summary>
        public GetDeviceManagementIntentSettingsReportRequestBuilder GetDeviceManagementIntentSettingsReport { get =>
            new GetDeviceManagementIntentSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getDeviceNonComplianceReport property</summary>
        public GetDeviceNonComplianceReportRequestBuilder GetDeviceNonComplianceReport { get =>
            new GetDeviceNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getEnrollmentConfigurationPoliciesByDevice property</summary>
        public GetEnrollmentConfigurationPoliciesByDeviceRequestBuilder GetEnrollmentConfigurationPoliciesByDevice { get =>
            new GetEnrollmentConfigurationPoliciesByDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getFailedMobileAppsReport property</summary>
        public GetFailedMobileAppsReportRequestBuilder GetFailedMobileAppsReport { get =>
            new GetFailedMobileAppsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getFailedMobileAppsSummaryReport property</summary>
        public GetFailedMobileAppsSummaryReportRequestBuilder GetFailedMobileAppsSummaryReport { get =>
            new GetFailedMobileAppsSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getGroupPolicySettingsDeviceSettingsReport property</summary>
        public GetGroupPolicySettingsDeviceSettingsReportRequestBuilder GetGroupPolicySettingsDeviceSettingsReport { get =>
            new GetGroupPolicySettingsDeviceSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getHistoricalReport property</summary>
        public GetHistoricalReportRequestBuilder GetHistoricalReport { get =>
            new GetHistoricalReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getMalwareSummaryReport property</summary>
        public GetMalwareSummaryReportRequestBuilder GetMalwareSummaryReport { get =>
            new GetMalwareSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getPolicyNonComplianceMetadata property</summary>
        public GetPolicyNonComplianceMetadataRequestBuilder GetPolicyNonComplianceMetadata { get =>
            new GetPolicyNonComplianceMetadataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getPolicyNonComplianceReport property</summary>
        public GetPolicyNonComplianceReportRequestBuilder GetPolicyNonComplianceReport { get =>
            new GetPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getPolicyNonComplianceSummaryReport property</summary>
        public GetPolicyNonComplianceSummaryReportRequestBuilder GetPolicyNonComplianceSummaryReport { get =>
            new GetPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getQuietTimePolicyUsersReport property</summary>
        public GetQuietTimePolicyUsersReportRequestBuilder GetQuietTimePolicyUsersReport { get =>
            new GetQuietTimePolicyUsersReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getQuietTimePolicyUserSummaryReport property</summary>
        public GetQuietTimePolicyUserSummaryReportRequestBuilder GetQuietTimePolicyUserSummaryReport { get =>
            new GetQuietTimePolicyUserSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getRelatedAppsStatusReport property</summary>
        public GetRelatedAppsStatusReportRequestBuilder GetRelatedAppsStatusReport { get =>
            new GetRelatedAppsStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getRemoteAssistanceSessionsReport property</summary>
        public GetRemoteAssistanceSessionsReportRequestBuilder GetRemoteAssistanceSessionsReport { get =>
            new GetRemoteAssistanceSessionsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getReportFilters property</summary>
        public GetReportFiltersRequestBuilder GetReportFilters { get =>
            new GetReportFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getSettingNonComplianceReport property</summary>
        public GetSettingNonComplianceReportRequestBuilder GetSettingNonComplianceReport { get =>
            new GetSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getUnhealthyDefenderAgentsReport property</summary>
        public GetUnhealthyDefenderAgentsReportRequestBuilder GetUnhealthyDefenderAgentsReport { get =>
            new GetUnhealthyDefenderAgentsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getUnhealthyFirewallReport property</summary>
        public GetUnhealthyFirewallReportRequestBuilder GetUnhealthyFirewallReport { get =>
            new GetUnhealthyFirewallReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getUnhealthyFirewallSummaryReport property</summary>
        public GetUnhealthyFirewallSummaryReportRequestBuilder GetUnhealthyFirewallSummaryReport { get =>
            new GetUnhealthyFirewallSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getUserInstallStatusReport property</summary>
        public GetUserInstallStatusReportRequestBuilder GetUserInstallStatusReport { get =>
            new GetUserInstallStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getWindowsQualityUpdateAlertsPerPolicyPerDeviceReport property</summary>
        public GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReportRequestBuilder GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReport { get =>
            new GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getWindowsQualityUpdateAlertSummaryReport property</summary>
        public GetWindowsQualityUpdateAlertSummaryReportRequestBuilder GetWindowsQualityUpdateAlertSummaryReport { get =>
            new GetWindowsQualityUpdateAlertSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getWindowsUpdateAlertsPerPolicyPerDeviceReport property</summary>
        public GetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder GetWindowsUpdateAlertsPerPolicyPerDeviceReport { get =>
            new GetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getWindowsUpdateAlertSummaryReport property</summary>
        public GetWindowsUpdateAlertSummaryReportRequestBuilder GetWindowsUpdateAlertSummaryReport { get =>
            new GetWindowsUpdateAlertSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/reports{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/reports{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
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
        /// Reports singleton
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
        /// Update the navigation property reports in deviceManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceManagementReports body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// Delete navigation property reports for deviceManagement
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
        /// Reports singleton
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceManagementReports> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceManagementReports>(requestInfo, DeviceManagementReports.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DeviceManagementReports body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Reports singleton</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
