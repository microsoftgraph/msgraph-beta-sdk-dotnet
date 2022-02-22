using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.DeviceManagement.Reports.CachedReportConfigurations;
using MicrosoftGraph.DeviceManagement.Reports.ExportJobs;
using MicrosoftGraph.DeviceManagement.Reports.GetActiveMalwareReport;
using MicrosoftGraph.DeviceManagement.Reports.GetActiveMalwareSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetAllCertificatesReport;
using MicrosoftGraph.DeviceManagement.Reports.GetAppsInstallSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetAppStatusOverviewReport;
using MicrosoftGraph.DeviceManagement.Reports.GetCachedReport;
using MicrosoftGraph.DeviceManagement.Reports.GetCertificatesReport;
using MicrosoftGraph.DeviceManagement.Reports.GetCompliancePoliciesReportForDevice;
using MicrosoftGraph.DeviceManagement.Reports.GetCompliancePolicyDevicesReport;
using MicrosoftGraph.DeviceManagement.Reports.GetCompliancePolicyDeviceSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetCompliancePolicyNonComplianceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetCompliancePolicyNonComplianceSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetComplianceSettingDetailsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetComplianceSettingNonComplianceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetComplianceSettingsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigManagerDevicePolicyStatusReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationPoliciesReportForDevice;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationPolicyDevicesReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationPolicyDeviceSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationPolicySettingsDeviceSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationSettingDetailsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationSettingNonComplianceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetConfigurationSettingsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetDeviceConfigurationPolicySettingsSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetDeviceConfigurationPolicyStatusSummary;
using MicrosoftGraph.DeviceManagement.Reports.GetDeviceInstallStatusReport;
using MicrosoftGraph.DeviceManagement.Reports.GetDeviceManagementIntentPerSettingContributingProfiles;
using MicrosoftGraph.DeviceManagement.Reports.GetDeviceManagementIntentSettingsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetDeviceNonComplianceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetEnrollmentConfigurationPoliciesByDevice;
using MicrosoftGraph.DeviceManagement.Reports.GetFailedMobileAppsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetFailedMobileAppsSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetGroupPolicySettingsDeviceSettingsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetHistoricalReport;
using MicrosoftGraph.DeviceManagement.Reports.GetMalwareSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetPolicyNonComplianceMetadata;
using MicrosoftGraph.DeviceManagement.Reports.GetPolicyNonComplianceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetQuietTimePolicyUsersReport;
using MicrosoftGraph.DeviceManagement.Reports.GetQuietTimePolicyUserSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetRelatedAppsStatusReport;
using MicrosoftGraph.DeviceManagement.Reports.GetRemoteAssistanceSessionsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetReportFilters;
using MicrosoftGraph.DeviceManagement.Reports.GetSettingNonComplianceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetUnhealthyDefenderAgentsReport;
using MicrosoftGraph.DeviceManagement.Reports.GetUnhealthyFirewallReport;
using MicrosoftGraph.DeviceManagement.Reports.GetUnhealthyFirewallSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetUserInstallStatusReport;
using MicrosoftGraph.DeviceManagement.Reports.GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetWindowsQualityUpdateAlertSummaryReport;
using MicrosoftGraph.DeviceManagement.Reports.GetWindowsUpdateAlertsPerPolicyPerDeviceReport;
using MicrosoftGraph.DeviceManagement.Reports.GetWindowsUpdateAlertSummaryReport;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.DeviceManagement.Reports {
    /// <summary>Builds and executes requests for operations under \deviceManagement\reports</summary>
    public class ReportsRequestBuilder {
        public CachedReportConfigurationsRequestBuilder CachedReportConfigurations { get =>
            new CachedReportConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExportJobsRequestBuilder ExportJobs { get =>
            new ExportJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetActiveMalwareReportRequestBuilder GetActiveMalwareReport { get =>
            new GetActiveMalwareReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetActiveMalwareSummaryReportRequestBuilder GetActiveMalwareSummaryReport { get =>
            new GetActiveMalwareSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetAllCertificatesReportRequestBuilder GetAllCertificatesReport { get =>
            new GetAllCertificatesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetAppsInstallSummaryReportRequestBuilder GetAppsInstallSummaryReport { get =>
            new GetAppsInstallSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetAppStatusOverviewReportRequestBuilder GetAppStatusOverviewReport { get =>
            new GetAppStatusOverviewReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetCachedReportRequestBuilder GetCachedReport { get =>
            new GetCachedReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetCertificatesReportRequestBuilder GetCertificatesReport { get =>
            new GetCertificatesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetCompliancePoliciesReportForDeviceRequestBuilder GetCompliancePoliciesReportForDevice { get =>
            new GetCompliancePoliciesReportForDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetCompliancePolicyDevicesReportRequestBuilder GetCompliancePolicyDevicesReport { get =>
            new GetCompliancePolicyDevicesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetCompliancePolicyDeviceSummaryReportRequestBuilder GetCompliancePolicyDeviceSummaryReport { get =>
            new GetCompliancePolicyDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetCompliancePolicyNonComplianceReportRequestBuilder GetCompliancePolicyNonComplianceReport { get =>
            new GetCompliancePolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetCompliancePolicyNonComplianceSummaryReportRequestBuilder GetCompliancePolicyNonComplianceSummaryReport { get =>
            new GetCompliancePolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetComplianceSettingDetailsReportRequestBuilder GetComplianceSettingDetailsReport { get =>
            new GetComplianceSettingDetailsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetComplianceSettingNonComplianceReportRequestBuilder GetComplianceSettingNonComplianceReport { get =>
            new GetComplianceSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetComplianceSettingsReportRequestBuilder GetComplianceSettingsReport { get =>
            new GetComplianceSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigManagerDevicePolicyStatusReportRequestBuilder GetConfigManagerDevicePolicyStatusReport { get =>
            new GetConfigManagerDevicePolicyStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationPoliciesReportForDeviceRequestBuilder GetConfigurationPoliciesReportForDevice { get =>
            new GetConfigurationPoliciesReportForDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationPolicyDevicesReportRequestBuilder GetConfigurationPolicyDevicesReport { get =>
            new GetConfigurationPolicyDevicesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationPolicyDeviceSummaryReportRequestBuilder GetConfigurationPolicyDeviceSummaryReport { get =>
            new GetConfigurationPolicyDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationPolicyNonComplianceReportRequestBuilder GetConfigurationPolicyNonComplianceReport { get =>
            new GetConfigurationPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder GetConfigurationPolicyNonComplianceSummaryReport { get =>
            new GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationPolicySettingsDeviceSummaryReportRequestBuilder GetConfigurationPolicySettingsDeviceSummaryReport { get =>
            new GetConfigurationPolicySettingsDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationSettingDetailsReportRequestBuilder GetConfigurationSettingDetailsReport { get =>
            new GetConfigurationSettingDetailsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationSettingNonComplianceReportRequestBuilder GetConfigurationSettingNonComplianceReport { get =>
            new GetConfigurationSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetConfigurationSettingsReportRequestBuilder GetConfigurationSettingsReport { get =>
            new GetConfigurationSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetDeviceConfigurationPolicySettingsSummaryReportRequestBuilder GetDeviceConfigurationPolicySettingsSummaryReport { get =>
            new GetDeviceConfigurationPolicySettingsSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetDeviceConfigurationPolicyStatusSummaryRequestBuilder GetDeviceConfigurationPolicyStatusSummary { get =>
            new GetDeviceConfigurationPolicyStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetDeviceInstallStatusReportRequestBuilder GetDeviceInstallStatusReport { get =>
            new GetDeviceInstallStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder GetDeviceManagementIntentPerSettingContributingProfiles { get =>
            new GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetDeviceManagementIntentSettingsReportRequestBuilder GetDeviceManagementIntentSettingsReport { get =>
            new GetDeviceManagementIntentSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetDeviceNonComplianceReportRequestBuilder GetDeviceNonComplianceReport { get =>
            new GetDeviceNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetEnrollmentConfigurationPoliciesByDeviceRequestBuilder GetEnrollmentConfigurationPoliciesByDevice { get =>
            new GetEnrollmentConfigurationPoliciesByDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetFailedMobileAppsReportRequestBuilder GetFailedMobileAppsReport { get =>
            new GetFailedMobileAppsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetFailedMobileAppsSummaryReportRequestBuilder GetFailedMobileAppsSummaryReport { get =>
            new GetFailedMobileAppsSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetGroupPolicySettingsDeviceSettingsReportRequestBuilder GetGroupPolicySettingsDeviceSettingsReport { get =>
            new GetGroupPolicySettingsDeviceSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetHistoricalReportRequestBuilder GetHistoricalReport { get =>
            new GetHistoricalReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMalwareSummaryReportRequestBuilder GetMalwareSummaryReport { get =>
            new GetMalwareSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetPolicyNonComplianceMetadataRequestBuilder GetPolicyNonComplianceMetadata { get =>
            new GetPolicyNonComplianceMetadataRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetPolicyNonComplianceReportRequestBuilder GetPolicyNonComplianceReport { get =>
            new GetPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetPolicyNonComplianceSummaryReportRequestBuilder GetPolicyNonComplianceSummaryReport { get =>
            new GetPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetQuietTimePolicyUsersReportRequestBuilder GetQuietTimePolicyUsersReport { get =>
            new GetQuietTimePolicyUsersReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetQuietTimePolicyUserSummaryReportRequestBuilder GetQuietTimePolicyUserSummaryReport { get =>
            new GetQuietTimePolicyUserSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetRelatedAppsStatusReportRequestBuilder GetRelatedAppsStatusReport { get =>
            new GetRelatedAppsStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetRemoteAssistanceSessionsReportRequestBuilder GetRemoteAssistanceSessionsReport { get =>
            new GetRemoteAssistanceSessionsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetReportFiltersRequestBuilder GetReportFilters { get =>
            new GetReportFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetSettingNonComplianceReportRequestBuilder GetSettingNonComplianceReport { get =>
            new GetSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetUnhealthyDefenderAgentsReportRequestBuilder GetUnhealthyDefenderAgentsReport { get =>
            new GetUnhealthyDefenderAgentsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetUnhealthyFirewallReportRequestBuilder GetUnhealthyFirewallReport { get =>
            new GetUnhealthyFirewallReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetUnhealthyFirewallSummaryReportRequestBuilder GetUnhealthyFirewallSummaryReport { get =>
            new GetUnhealthyFirewallSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetUserInstallStatusReportRequestBuilder GetUserInstallStatusReport { get =>
            new GetUserInstallStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReportRequestBuilder GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReport { get =>
            new GetWindowsQualityUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetWindowsQualityUpdateAlertSummaryReportRequestBuilder GetWindowsQualityUpdateAlertSummaryReport { get =>
            new GetWindowsQualityUpdateAlertSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder GetWindowsUpdateAlertsPerPolicyPerDeviceReport { get =>
            new GetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(PathParameters, RequestAdapter);
        }
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
        /// Reports singleton
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
        /// Reports singleton
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
        /// Reports singleton
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceManagementReports body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Reports singleton
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
        /// Reports singleton
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceManagementReports> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<DeviceManagementReports>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Reports singleton
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DeviceManagementReports body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
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
