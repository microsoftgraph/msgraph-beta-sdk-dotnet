using Microsoft.Graph.Beta.DeviceManagement.Reports.CachedReportConfigurations;
using Microsoft.Graph.Beta.DeviceManagement.Reports.ExportJobs;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetActiveMalwareReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetActiveMalwareSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetAllCertificatesReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetAppsInstallSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetAppStatusOverviewReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetCachedReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetCertificatesReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetCompliancePoliciesReportForDevice;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetCompliancePolicyDevicesReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetCompliancePolicyDeviceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetCompliancePolicyNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetCompliancePolicyNonComplianceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetComplianceSettingDetailsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetComplianceSettingNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetComplianceSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigManagerDevicePolicyStatusReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationPoliciesReportForDevice;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationPolicyDevicesReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationPolicyDeviceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationPolicyNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationPolicyNonComplianceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationPolicySettingsDeviceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationSettingDetailsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationSettingNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetConfigurationSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetDeviceConfigurationPolicySettingsSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetDeviceConfigurationPolicyStatusSummary;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetDeviceInstallStatusReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetDeviceManagementIntentPerSettingContributingProfiles;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetDeviceManagementIntentSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetDeviceNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetDevicesWithoutCompliancePolicyReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetEncryptionReportForDevices;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetEnrollmentConfigurationPoliciesByDevice;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetFailedMobileAppsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetFailedMobileAppsSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetGroupPolicySettingsDeviceSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetHistoricalReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetMalwareSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetMobileApplicationManagementAppConfigurationReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetMobileApplicationManagementAppRegistrationSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetNoncompliantDevicesAndSettingsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetPolicyNonComplianceMetadata;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetPolicyNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetPolicyNonComplianceSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetQuietTimePolicyUsersReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetQuietTimePolicyUserSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetRelatedAppsStatusReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetRemoteAssistanceSessionsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetReportFilters;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetSettingNonComplianceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetUnhealthyDefenderAgentsReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetUnhealthyFirewallReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetUnhealthyFirewallSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetUserInstallStatusReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetWindowsQualityUpdateAlertsPerPolicyPerDeviceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetWindowsQualityUpdateAlertSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetWindowsUpdateAlertsPerPolicyPerDeviceReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetWindowsUpdateAlertSummaryReport;
using Microsoft.Graph.Beta.DeviceManagement.Reports.MicrosoftGraphGetZebraFotaDeploymentReport;
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
    /// <summary>
    /// Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.
    /// </summary>
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
        public MicrosoftGraphGetActiveMalwareReportRequestBuilder MicrosoftGraphGetActiveMalwareReport { get =>
            new MicrosoftGraphGetActiveMalwareReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActiveMalwareSummaryReport method.</summary>
        public MicrosoftGraphGetActiveMalwareSummaryReportRequestBuilder MicrosoftGraphGetActiveMalwareSummaryReport { get =>
            new MicrosoftGraphGetActiveMalwareSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAllCertificatesReport method.</summary>
        public MicrosoftGraphGetAllCertificatesReportRequestBuilder MicrosoftGraphGetAllCertificatesReport { get =>
            new MicrosoftGraphGetAllCertificatesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAppsInstallSummaryReport method.</summary>
        public MicrosoftGraphGetAppsInstallSummaryReportRequestBuilder MicrosoftGraphGetAppsInstallSummaryReport { get =>
            new MicrosoftGraphGetAppsInstallSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAppStatusOverviewReport method.</summary>
        public MicrosoftGraphGetAppStatusOverviewReportRequestBuilder MicrosoftGraphGetAppStatusOverviewReport { get =>
            new MicrosoftGraphGetAppStatusOverviewReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCachedReport method.</summary>
        public MicrosoftGraphGetCachedReportRequestBuilder MicrosoftGraphGetCachedReport { get =>
            new MicrosoftGraphGetCachedReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCertificatesReport method.</summary>
        public MicrosoftGraphGetCertificatesReportRequestBuilder MicrosoftGraphGetCertificatesReport { get =>
            new MicrosoftGraphGetCertificatesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePoliciesReportForDevice method.</summary>
        public MicrosoftGraphGetCompliancePoliciesReportForDeviceRequestBuilder MicrosoftGraphGetCompliancePoliciesReportForDevice { get =>
            new MicrosoftGraphGetCompliancePoliciesReportForDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyDevicesReport method.</summary>
        public MicrosoftGraphGetCompliancePolicyDevicesReportRequestBuilder MicrosoftGraphGetCompliancePolicyDevicesReport { get =>
            new MicrosoftGraphGetCompliancePolicyDevicesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyDeviceSummaryReport method.</summary>
        public MicrosoftGraphGetCompliancePolicyDeviceSummaryReportRequestBuilder MicrosoftGraphGetCompliancePolicyDeviceSummaryReport { get =>
            new MicrosoftGraphGetCompliancePolicyDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyNonComplianceReport method.</summary>
        public MicrosoftGraphGetCompliancePolicyNonComplianceReportRequestBuilder MicrosoftGraphGetCompliancePolicyNonComplianceReport { get =>
            new MicrosoftGraphGetCompliancePolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyNonComplianceSummaryReport method.</summary>
        public MicrosoftGraphGetCompliancePolicyNonComplianceSummaryReportRequestBuilder MicrosoftGraphGetCompliancePolicyNonComplianceSummaryReport { get =>
            new MicrosoftGraphGetCompliancePolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getComplianceSettingDetailsReport method.</summary>
        public MicrosoftGraphGetComplianceSettingDetailsReportRequestBuilder MicrosoftGraphGetComplianceSettingDetailsReport { get =>
            new MicrosoftGraphGetComplianceSettingDetailsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getComplianceSettingNonComplianceReport method.</summary>
        public MicrosoftGraphGetComplianceSettingNonComplianceReportRequestBuilder MicrosoftGraphGetComplianceSettingNonComplianceReport { get =>
            new MicrosoftGraphGetComplianceSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getComplianceSettingsReport method.</summary>
        public MicrosoftGraphGetComplianceSettingsReportRequestBuilder MicrosoftGraphGetComplianceSettingsReport { get =>
            new MicrosoftGraphGetComplianceSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigManagerDevicePolicyStatusReport method.</summary>
        public MicrosoftGraphGetConfigManagerDevicePolicyStatusReportRequestBuilder MicrosoftGraphGetConfigManagerDevicePolicyStatusReport { get =>
            new MicrosoftGraphGetConfigManagerDevicePolicyStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPoliciesReportForDevice method.</summary>
        public MicrosoftGraphGetConfigurationPoliciesReportForDeviceRequestBuilder MicrosoftGraphGetConfigurationPoliciesReportForDevice { get =>
            new MicrosoftGraphGetConfigurationPoliciesReportForDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyDevicesReport method.</summary>
        public MicrosoftGraphGetConfigurationPolicyDevicesReportRequestBuilder MicrosoftGraphGetConfigurationPolicyDevicesReport { get =>
            new MicrosoftGraphGetConfigurationPolicyDevicesReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyDeviceSummaryReport method.</summary>
        public MicrosoftGraphGetConfigurationPolicyDeviceSummaryReportRequestBuilder MicrosoftGraphGetConfigurationPolicyDeviceSummaryReport { get =>
            new MicrosoftGraphGetConfigurationPolicyDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyNonComplianceReport method.</summary>
        public MicrosoftGraphGetConfigurationPolicyNonComplianceReportRequestBuilder MicrosoftGraphGetConfigurationPolicyNonComplianceReport { get =>
            new MicrosoftGraphGetConfigurationPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyNonComplianceSummaryReport method.</summary>
        public MicrosoftGraphGetConfigurationPolicyNonComplianceSummaryReportRequestBuilder MicrosoftGraphGetConfigurationPolicyNonComplianceSummaryReport { get =>
            new MicrosoftGraphGetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicySettingsDeviceSummaryReport method.</summary>
        public MicrosoftGraphGetConfigurationPolicySettingsDeviceSummaryReportRequestBuilder MicrosoftGraphGetConfigurationPolicySettingsDeviceSummaryReport { get =>
            new MicrosoftGraphGetConfigurationPolicySettingsDeviceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationSettingDetailsReport method.</summary>
        public MicrosoftGraphGetConfigurationSettingDetailsReportRequestBuilder MicrosoftGraphGetConfigurationSettingDetailsReport { get =>
            new MicrosoftGraphGetConfigurationSettingDetailsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationSettingNonComplianceReport method.</summary>
        public MicrosoftGraphGetConfigurationSettingNonComplianceReportRequestBuilder MicrosoftGraphGetConfigurationSettingNonComplianceReport { get =>
            new MicrosoftGraphGetConfigurationSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationSettingsReport method.</summary>
        public MicrosoftGraphGetConfigurationSettingsReportRequestBuilder MicrosoftGraphGetConfigurationSettingsReport { get =>
            new MicrosoftGraphGetConfigurationSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceConfigurationPolicySettingsSummaryReport method.</summary>
        public MicrosoftGraphGetDeviceConfigurationPolicySettingsSummaryReportRequestBuilder MicrosoftGraphGetDeviceConfigurationPolicySettingsSummaryReport { get =>
            new MicrosoftGraphGetDeviceConfigurationPolicySettingsSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceConfigurationPolicyStatusSummary method.</summary>
        public MicrosoftGraphGetDeviceConfigurationPolicyStatusSummaryRequestBuilder MicrosoftGraphGetDeviceConfigurationPolicyStatusSummary { get =>
            new MicrosoftGraphGetDeviceConfigurationPolicyStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceInstallStatusReport method.</summary>
        public MicrosoftGraphGetDeviceInstallStatusReportRequestBuilder MicrosoftGraphGetDeviceInstallStatusReport { get =>
            new MicrosoftGraphGetDeviceInstallStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceManagementIntentPerSettingContributingProfiles method.</summary>
        public MicrosoftGraphGetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder MicrosoftGraphGetDeviceManagementIntentPerSettingContributingProfiles { get =>
            new MicrosoftGraphGetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceManagementIntentSettingsReport method.</summary>
        public MicrosoftGraphGetDeviceManagementIntentSettingsReportRequestBuilder MicrosoftGraphGetDeviceManagementIntentSettingsReport { get =>
            new MicrosoftGraphGetDeviceManagementIntentSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceNonComplianceReport method.</summary>
        public MicrosoftGraphGetDeviceNonComplianceReportRequestBuilder MicrosoftGraphGetDeviceNonComplianceReport { get =>
            new MicrosoftGraphGetDeviceNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDevicesWithoutCompliancePolicyReport method.</summary>
        public MicrosoftGraphGetDevicesWithoutCompliancePolicyReportRequestBuilder MicrosoftGraphGetDevicesWithoutCompliancePolicyReport { get =>
            new MicrosoftGraphGetDevicesWithoutCompliancePolicyReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getEncryptionReportForDevices method.</summary>
        public MicrosoftGraphGetEncryptionReportForDevicesRequestBuilder MicrosoftGraphGetEncryptionReportForDevices { get =>
            new MicrosoftGraphGetEncryptionReportForDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getEnrollmentConfigurationPoliciesByDevice method.</summary>
        public MicrosoftGraphGetEnrollmentConfigurationPoliciesByDeviceRequestBuilder MicrosoftGraphGetEnrollmentConfigurationPoliciesByDevice { get =>
            new MicrosoftGraphGetEnrollmentConfigurationPoliciesByDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getFailedMobileAppsReport method.</summary>
        public MicrosoftGraphGetFailedMobileAppsReportRequestBuilder MicrosoftGraphGetFailedMobileAppsReport { get =>
            new MicrosoftGraphGetFailedMobileAppsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getFailedMobileAppsSummaryReport method.</summary>
        public MicrosoftGraphGetFailedMobileAppsSummaryReportRequestBuilder MicrosoftGraphGetFailedMobileAppsSummaryReport { get =>
            new MicrosoftGraphGetFailedMobileAppsSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getGroupPolicySettingsDeviceSettingsReport method.</summary>
        public MicrosoftGraphGetGroupPolicySettingsDeviceSettingsReportRequestBuilder MicrosoftGraphGetGroupPolicySettingsDeviceSettingsReport { get =>
            new MicrosoftGraphGetGroupPolicySettingsDeviceSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getHistoricalReport method.</summary>
        public MicrosoftGraphGetHistoricalReportRequestBuilder MicrosoftGraphGetHistoricalReport { get =>
            new MicrosoftGraphGetHistoricalReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMalwareSummaryReport method.</summary>
        public MicrosoftGraphGetMalwareSummaryReportRequestBuilder MicrosoftGraphGetMalwareSummaryReport { get =>
            new MicrosoftGraphGetMalwareSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMobileApplicationManagementAppConfigurationReport method.</summary>
        public MicrosoftGraphGetMobileApplicationManagementAppConfigurationReportRequestBuilder MicrosoftGraphGetMobileApplicationManagementAppConfigurationReport { get =>
            new MicrosoftGraphGetMobileApplicationManagementAppConfigurationReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMobileApplicationManagementAppRegistrationSummaryReport method.</summary>
        public MicrosoftGraphGetMobileApplicationManagementAppRegistrationSummaryReportRequestBuilder MicrosoftGraphGetMobileApplicationManagementAppRegistrationSummaryReport { get =>
            new MicrosoftGraphGetMobileApplicationManagementAppRegistrationSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getNoncompliantDevicesAndSettingsReport method.</summary>
        public MicrosoftGraphGetNoncompliantDevicesAndSettingsReportRequestBuilder MicrosoftGraphGetNoncompliantDevicesAndSettingsReport { get =>
            new MicrosoftGraphGetNoncompliantDevicesAndSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceMetadata method.</summary>
        public MicrosoftGraphGetPolicyNonComplianceMetadataRequestBuilder MicrosoftGraphGetPolicyNonComplianceMetadata { get =>
            new MicrosoftGraphGetPolicyNonComplianceMetadataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceReport method.</summary>
        public MicrosoftGraphGetPolicyNonComplianceReportRequestBuilder MicrosoftGraphGetPolicyNonComplianceReport { get =>
            new MicrosoftGraphGetPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceSummaryReport method.</summary>
        public MicrosoftGraphGetPolicyNonComplianceSummaryReportRequestBuilder MicrosoftGraphGetPolicyNonComplianceSummaryReport { get =>
            new MicrosoftGraphGetPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getQuietTimePolicyUsersReport method.</summary>
        public MicrosoftGraphGetQuietTimePolicyUsersReportRequestBuilder MicrosoftGraphGetQuietTimePolicyUsersReport { get =>
            new MicrosoftGraphGetQuietTimePolicyUsersReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getQuietTimePolicyUserSummaryReport method.</summary>
        public MicrosoftGraphGetQuietTimePolicyUserSummaryReportRequestBuilder MicrosoftGraphGetQuietTimePolicyUserSummaryReport { get =>
            new MicrosoftGraphGetQuietTimePolicyUserSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getRelatedAppsStatusReport method.</summary>
        public MicrosoftGraphGetRelatedAppsStatusReportRequestBuilder MicrosoftGraphGetRelatedAppsStatusReport { get =>
            new MicrosoftGraphGetRelatedAppsStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getRemoteAssistanceSessionsReport method.</summary>
        public MicrosoftGraphGetRemoteAssistanceSessionsReportRequestBuilder MicrosoftGraphGetRemoteAssistanceSessionsReport { get =>
            new MicrosoftGraphGetRemoteAssistanceSessionsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getReportFilters method.</summary>
        public MicrosoftGraphGetReportFiltersRequestBuilder MicrosoftGraphGetReportFilters { get =>
            new MicrosoftGraphGetReportFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getSettingNonComplianceReport method.</summary>
        public MicrosoftGraphGetSettingNonComplianceReportRequestBuilder MicrosoftGraphGetSettingNonComplianceReport { get =>
            new MicrosoftGraphGetSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUnhealthyDefenderAgentsReport method.</summary>
        public MicrosoftGraphGetUnhealthyDefenderAgentsReportRequestBuilder MicrosoftGraphGetUnhealthyDefenderAgentsReport { get =>
            new MicrosoftGraphGetUnhealthyDefenderAgentsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUnhealthyFirewallReport method.</summary>
        public MicrosoftGraphGetUnhealthyFirewallReportRequestBuilder MicrosoftGraphGetUnhealthyFirewallReport { get =>
            new MicrosoftGraphGetUnhealthyFirewallReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUnhealthyFirewallSummaryReport method.</summary>
        public MicrosoftGraphGetUnhealthyFirewallSummaryReportRequestBuilder MicrosoftGraphGetUnhealthyFirewallSummaryReport { get =>
            new MicrosoftGraphGetUnhealthyFirewallSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getUserInstallStatusReport method.</summary>
        public MicrosoftGraphGetUserInstallStatusReportRequestBuilder MicrosoftGraphGetUserInstallStatusReport { get =>
            new MicrosoftGraphGetUserInstallStatusReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getWindowsQualityUpdateAlertsPerPolicyPerDeviceReport method.</summary>
        public MicrosoftGraphGetWindowsQualityUpdateAlertsPerPolicyPerDeviceReportRequestBuilder MicrosoftGraphGetWindowsQualityUpdateAlertsPerPolicyPerDeviceReport { get =>
            new MicrosoftGraphGetWindowsQualityUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getWindowsQualityUpdateAlertSummaryReport method.</summary>
        public MicrosoftGraphGetWindowsQualityUpdateAlertSummaryReportRequestBuilder MicrosoftGraphGetWindowsQualityUpdateAlertSummaryReport { get =>
            new MicrosoftGraphGetWindowsQualityUpdateAlertSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getWindowsUpdateAlertsPerPolicyPerDeviceReport method.</summary>
        public MicrosoftGraphGetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder MicrosoftGraphGetWindowsUpdateAlertsPerPolicyPerDeviceReport { get =>
            new MicrosoftGraphGetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getWindowsUpdateAlertSummaryReport method.</summary>
        public MicrosoftGraphGetWindowsUpdateAlertSummaryReportRequestBuilder MicrosoftGraphGetWindowsUpdateAlertSummaryReport { get =>
            new MicrosoftGraphGetWindowsUpdateAlertSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getZebraFotaDeploymentReport method.</summary>
        public MicrosoftGraphGetZebraFotaDeploymentReportRequestBuilder MicrosoftGraphGetZebraFotaDeploymentReport { get =>
            new MicrosoftGraphGetZebraFotaDeploymentReportRequestBuilder(PathParameters, RequestAdapter);
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
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<ReportsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<ReportsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DeviceManagementReports?> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DeviceManagementReports> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceManagementReports>(requestInfo, DeviceManagementReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DeviceManagementReports?> PatchAsync(DeviceManagementReports body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DeviceManagementReports> PatchAsync(DeviceManagementReports body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceManagementReports>(requestInfo, DeviceManagementReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ReportsRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ReportsRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
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
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DeviceManagementReports body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DeviceManagementReports body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new ReportsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Reports singleton
        /// </summary>
        public class ReportsRequestBuilderGetQueryParameters {
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
        public class ReportsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ReportsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ReportsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new reportsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
