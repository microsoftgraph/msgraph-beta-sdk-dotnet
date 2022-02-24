using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceManagement.AdvancedThreatProtectionOnboardingStateSummary;
using MicrosoftGraphSdk.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles;
using MicrosoftGraphSdk.DeviceManagement.AndroidForWorkAppConfigurationSchemas;
using MicrosoftGraphSdk.DeviceManagement.AndroidForWorkEnrollmentProfiles;
using MicrosoftGraphSdk.DeviceManagement.AndroidForWorkSettings;
using MicrosoftGraphSdk.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings;
using MicrosoftGraphSdk.DeviceManagement.AndroidManagedStoreAppConfigurationSchemas;
using MicrosoftGraphSdk.DeviceManagement.ApplePushNotificationCertificate;
using MicrosoftGraphSdk.DeviceManagement.AppleUserInitiatedEnrollmentProfiles;
using MicrosoftGraphSdk.DeviceManagement.AssignmentFilters;
using MicrosoftGraphSdk.DeviceManagement.AuditEvents;
using MicrosoftGraphSdk.DeviceManagement.AutopilotEvents;
using MicrosoftGraphSdk.DeviceManagement.CartToClassAssociations;
using MicrosoftGraphSdk.DeviceManagement.Categories;
using MicrosoftGraphSdk.DeviceManagement.CertificateConnectorDetails;
using MicrosoftGraphSdk.DeviceManagement.ChromeOSOnboardingSettings;
using MicrosoftGraphSdk.DeviceManagement.CloudPCConnectivityIssues;
using MicrosoftGraphSdk.DeviceManagement.ComanagedDevices;
using MicrosoftGraphSdk.DeviceManagement.ComanagementEligibleDevices;
using MicrosoftGraphSdk.DeviceManagement.ComplianceCategories;
using MicrosoftGraphSdk.DeviceManagement.ComplianceManagementPartners;
using MicrosoftGraphSdk.DeviceManagement.CompliancePolicies;
using MicrosoftGraphSdk.DeviceManagement.ComplianceSettings;
using MicrosoftGraphSdk.DeviceManagement.ConditionalAccessSettings;
using MicrosoftGraphSdk.DeviceManagement.ConfigManagerCollections;
using MicrosoftGraphSdk.DeviceManagement.ConfigurationCategories;
using MicrosoftGraphSdk.DeviceManagement.ConfigurationPolicies;
using MicrosoftGraphSdk.DeviceManagement.ConfigurationPolicyTemplates;
using MicrosoftGraphSdk.DeviceManagement.ConfigurationSettings;
using MicrosoftGraphSdk.DeviceManagement.DataSharingConsents;
using MicrosoftGraphSdk.DeviceManagement.DepOnboardingSettings;
using MicrosoftGraphSdk.DeviceManagement.DerivedCredentials;
using MicrosoftGraphSdk.DeviceManagement.DetectedApps;
using MicrosoftGraphSdk.DeviceManagement.DeviceCategories;
using MicrosoftGraphSdk.DeviceManagement.DeviceCompliancePolicies;
using MicrosoftGraphSdk.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary;
using MicrosoftGraphSdk.DeviceManagement.DeviceCompliancePolicySettingStateSummaries;
using MicrosoftGraphSdk.DeviceManagement.DeviceComplianceScripts;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurationConflictSummary;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurationDeviceStateSummaries;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurationRestrictedAppsViolations;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurationsAllManagedDeviceCertificateStates;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurationUserStateSummaries;
using MicrosoftGraphSdk.DeviceManagement.DeviceCustomAttributeShellScripts;
using MicrosoftGraphSdk.DeviceManagement.DeviceEnrollmentConfigurations;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts;
using MicrosoftGraphSdk.DeviceManagement.DeviceManagementPartners;
using MicrosoftGraphSdk.DeviceManagement.DeviceManagementScripts;
using MicrosoftGraphSdk.DeviceManagement.DeviceShellScripts;
using MicrosoftGraphSdk.DeviceManagement.DomainJoinConnectors;
using MicrosoftGraphSdk.DeviceManagement.EmbeddedSIMActivationCodePools;
using MicrosoftGraphSdk.DeviceManagement.EnableAndroidDeviceAdministratorEnrollment;
using MicrosoftGraphSdk.DeviceManagement.EnableLegacyPcManagement;
using MicrosoftGraphSdk.DeviceManagement.EnableUnlicensedAdminstrators;
using MicrosoftGraphSdk.DeviceManagement.EvaluateAssignmentFilter;
using MicrosoftGraphSdk.DeviceManagement.ExchangeConnectors;
using MicrosoftGraphSdk.DeviceManagement.ExchangeOnPremisesPolicies;
using MicrosoftGraphSdk.DeviceManagement.ExchangeOnPremisesPolicy;
using MicrosoftGraphSdk.DeviceManagement.GetAssignedRoleDetails;
using MicrosoftGraphSdk.DeviceManagement.GetAssignmentFiltersStatusDetails;
using MicrosoftGraphSdk.DeviceManagement.GetComanagedDevicesSummary;
using MicrosoftGraphSdk.DeviceManagement.GetComanagementEligibleDevicesSummary;
using MicrosoftGraphSdk.DeviceManagement.GetEffectivePermissions;
using MicrosoftGraphSdk.DeviceManagement.GetEffectivePermissionsWithScope;
using MicrosoftGraphSdk.DeviceManagement.GetRoleScopeTagsByIdsWithIds;
using MicrosoftGraphSdk.DeviceManagement.GetRoleScopeTagsByResourceWithResource;
using MicrosoftGraphSdk.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType;
using MicrosoftGraphSdk.DeviceManagement.GroupPolicyCategories;
using MicrosoftGraphSdk.DeviceManagement.GroupPolicyConfigurations;
using MicrosoftGraphSdk.DeviceManagement.GroupPolicyDefinitionFiles;
using MicrosoftGraphSdk.DeviceManagement.GroupPolicyDefinitions;
using MicrosoftGraphSdk.DeviceManagement.GroupPolicyMigrationReports;
using MicrosoftGraphSdk.DeviceManagement.GroupPolicyObjectFiles;
using MicrosoftGraphSdk.DeviceManagement.GroupPolicyUploadedDefinitionFiles;
using MicrosoftGraphSdk.DeviceManagement.ImportedDeviceIdentities;
using MicrosoftGraphSdk.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities;
using MicrosoftGraphSdk.DeviceManagement.Intents;
using MicrosoftGraphSdk.DeviceManagement.IntuneBrandingProfiles;
using MicrosoftGraphSdk.DeviceManagement.IosUpdateStatuses;
using MicrosoftGraphSdk.DeviceManagement.MacOSSoftwareUpdateAccountSummaries;
using MicrosoftGraphSdk.DeviceManagement.ManagedDeviceEncryptionStates;
using MicrosoftGraphSdk.DeviceManagement.ManagedDeviceOverview;
using MicrosoftGraphSdk.DeviceManagement.ManagedDevices;
using MicrosoftGraphSdk.DeviceManagement.ManagementConditions;
using MicrosoftGraphSdk.DeviceManagement.ManagementConditionStatements;
using MicrosoftGraphSdk.DeviceManagement.MicrosoftTunnelConfigurations;
using MicrosoftGraphSdk.DeviceManagement.MicrosoftTunnelHealthThresholds;
using MicrosoftGraphSdk.DeviceManagement.MicrosoftTunnelServerLogCollectionResponses;
using MicrosoftGraphSdk.DeviceManagement.MicrosoftTunnelSites;
using MicrosoftGraphSdk.DeviceManagement.MobileAppTroubleshootingEvents;
using MicrosoftGraphSdk.DeviceManagement.MobileThreatDefenseConnectors;
using MicrosoftGraphSdk.DeviceManagement.NdesConnectors;
using MicrosoftGraphSdk.DeviceManagement.NotificationMessageTemplates;
using MicrosoftGraphSdk.DeviceManagement.OemWarrantyInformationOnboarding;
using MicrosoftGraphSdk.DeviceManagement.RemoteActionAudits;
using MicrosoftGraphSdk.DeviceManagement.RemoteAssistancePartners;
using MicrosoftGraphSdk.DeviceManagement.RemoteAssistanceSettings;
using MicrosoftGraphSdk.DeviceManagement.Reports;
using MicrosoftGraphSdk.DeviceManagement.ResourceAccessProfiles;
using MicrosoftGraphSdk.DeviceManagement.ResourceOperations;
using MicrosoftGraphSdk.DeviceManagement.ReusablePolicySettings;
using MicrosoftGraphSdk.DeviceManagement.ReusableSettings;
using MicrosoftGraphSdk.DeviceManagement.RoleAssignments;
using MicrosoftGraphSdk.DeviceManagement.RoleDefinitions;
using MicrosoftGraphSdk.DeviceManagement.RoleScopeTags;
using MicrosoftGraphSdk.DeviceManagement.ScopedForResourceWithResource;
using MicrosoftGraphSdk.DeviceManagement.SendCustomNotificationToCompanyPortal;
using MicrosoftGraphSdk.DeviceManagement.SettingDefinitions;
using MicrosoftGraphSdk.DeviceManagement.SoftwareUpdateStatusSummary;
using MicrosoftGraphSdk.DeviceManagement.TelecomExpenseManagementPartners;
using MicrosoftGraphSdk.DeviceManagement.Templates;
using MicrosoftGraphSdk.DeviceManagement.TemplateSettings;
using MicrosoftGraphSdk.DeviceManagement.TermsAndConditions;
using MicrosoftGraphSdk.DeviceManagement.TroubleshootingEvents;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthDeviceModelPerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthDevicePerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthDevicePerformanceDetails;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthOSVersionPerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthOverview;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBaselines;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBatteryHealthAppImpact;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBatteryHealthCapacityDetails;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBatteryHealthDeviceAppImpact;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBatteryHealthDevicePerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBatteryHealthModelPerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBatteryHealthOsPerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsBatteryHealthRuntimeDetails;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsCategories;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsDeviceMetricHistory;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsDevicePerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsDeviceScores;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsDeviceStartupHistory;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsDeviceStartupProcesses;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsDeviceStartupProcessPerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsDevicesWithoutCloudIdentity;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsImpactingProcess;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsMetricHistory;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsModelScores;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsNotAutopilotReadyDevice;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsOverview;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsRegressionSummary;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsRemoteConnection;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsResourcePerformance;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsScoreHistory;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsSummarizeWorkFromAnywhereDevices;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereMetrics;
using MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereModelPerformance;
using MicrosoftGraphSdk.DeviceManagement.UserPfxCertificates;
using MicrosoftGraphSdk.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName;
using MicrosoftGraphSdk.DeviceManagement.VirtualEndpoint;
using MicrosoftGraphSdk.DeviceManagement.WindowsAutopilotDeploymentProfiles;
using MicrosoftGraphSdk.DeviceManagement.WindowsAutopilotDeviceIdentities;
using MicrosoftGraphSdk.DeviceManagement.WindowsAutopilotSettings;
using MicrosoftGraphSdk.DeviceManagement.WindowsDriverUpdateProfiles;
using MicrosoftGraphSdk.DeviceManagement.WindowsFeatureUpdateProfiles;
using MicrosoftGraphSdk.DeviceManagement.WindowsInformationProtectionAppLearningSummaries;
using MicrosoftGraphSdk.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
using MicrosoftGraphSdk.DeviceManagement.WindowsMalwareInformation;
using MicrosoftGraphSdk.DeviceManagement.WindowsQualityUpdateProfiles;
using MicrosoftGraphSdk.DeviceManagement.WindowsUpdateCatalogItems;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement {
    /// <summary>Builds and executes requests for operations under \deviceManagement</summary>
    public class DeviceManagementRequestBuilder {
        public AdvancedThreatProtectionOnboardingStateSummaryRequestBuilder AdvancedThreatProtectionOnboardingStateSummary { get =>
            new AdvancedThreatProtectionOnboardingStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public AndroidDeviceOwnerEnrollmentProfilesRequestBuilder AndroidDeviceOwnerEnrollmentProfiles { get =>
            new AndroidDeviceOwnerEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AndroidForWorkAppConfigurationSchemasRequestBuilder AndroidForWorkAppConfigurationSchemas { get =>
            new AndroidForWorkAppConfigurationSchemasRequestBuilder(PathParameters, RequestAdapter);
        }
        public AndroidForWorkEnrollmentProfilesRequestBuilder AndroidForWorkEnrollmentProfiles { get =>
            new AndroidForWorkEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AndroidForWorkSettingsRequestBuilder AndroidForWorkSettings { get =>
            new AndroidForWorkSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder AndroidManagedStoreAccountEnterpriseSettings { get =>
            new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AndroidManagedStoreAppConfigurationSchemasRequestBuilder AndroidManagedStoreAppConfigurationSchemas { get =>
            new AndroidManagedStoreAppConfigurationSchemasRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplePushNotificationCertificateRequestBuilder ApplePushNotificationCertificate { get =>
            new ApplePushNotificationCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppleUserInitiatedEnrollmentProfilesRequestBuilder AppleUserInitiatedEnrollmentProfiles { get =>
            new AppleUserInitiatedEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignmentFiltersRequestBuilder AssignmentFilters { get =>
            new AssignmentFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AutopilotEventsRequestBuilder AutopilotEvents { get =>
            new AutopilotEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CartToClassAssociationsRequestBuilder CartToClassAssociations { get =>
            new CartToClassAssociationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CategoriesRequestBuilder Categories { get =>
            new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public CertificateConnectorDetailsRequestBuilder CertificateConnectorDetails { get =>
            new CertificateConnectorDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChromeOSOnboardingSettingsRequestBuilder ChromeOSOnboardingSettings { get =>
            new ChromeOSOnboardingSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CloudPCConnectivityIssuesRequestBuilder CloudPCConnectivityIssues { get =>
            new CloudPCConnectivityIssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ComanagedDevicesRequestBuilder ComanagedDevices { get =>
            new ComanagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ComanagementEligibleDevicesRequestBuilder ComanagementEligibleDevices { get =>
            new ComanagementEligibleDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ComplianceCategoriesRequestBuilder ComplianceCategories { get =>
            new ComplianceCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ComplianceManagementPartnersRequestBuilder ComplianceManagementPartners { get =>
            new ComplianceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        public CompliancePoliciesRequestBuilder CompliancePolicies { get =>
            new CompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ComplianceSettingsRequestBuilder ComplianceSettings { get =>
            new ComplianceSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConditionalAccessSettingsRequestBuilder ConditionalAccessSettings { get =>
            new ConditionalAccessSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConfigManagerCollectionsRequestBuilder ConfigManagerCollections { get =>
            new ConfigManagerCollectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConfigurationCategoriesRequestBuilder ConfigurationCategories { get =>
            new ConfigurationCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConfigurationPoliciesRequestBuilder ConfigurationPolicies { get =>
            new ConfigurationPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConfigurationPolicyTemplatesRequestBuilder ConfigurationPolicyTemplates { get =>
            new ConfigurationPolicyTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConfigurationSettingsRequestBuilder ConfigurationSettings { get =>
            new ConfigurationSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DataSharingConsentsRequestBuilder DataSharingConsents { get =>
            new DataSharingConsentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DepOnboardingSettingsRequestBuilder DepOnboardingSettings { get =>
            new DepOnboardingSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DerivedCredentialsRequestBuilder DerivedCredentials { get =>
            new DerivedCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCategoriesRequestBuilder DeviceCategories { get =>
            new DeviceCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCompliancePoliciesRequestBuilder DeviceCompliancePolicies { get =>
            new DeviceCompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCompliancePolicyDeviceStateSummaryRequestBuilder DeviceCompliancePolicyDeviceStateSummary { get =>
            new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceComplianceScriptsRequestBuilder DeviceComplianceScripts { get =>
            new DeviceComplianceScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationConflictSummaryRequestBuilder DeviceConfigurationConflictSummary { get =>
            new DeviceConfigurationConflictSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationDeviceStateSummariesRequestBuilder DeviceConfigurationDeviceStateSummaries { get =>
            new DeviceConfigurationDeviceStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationRestrictedAppsViolationsRequestBuilder DeviceConfigurationRestrictedAppsViolations { get =>
            new DeviceConfigurationRestrictedAppsViolationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationsRequestBuilder DeviceConfigurations { get =>
            new DeviceConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationsAllManagedDeviceCertificateStatesRequestBuilder DeviceConfigurationsAllManagedDeviceCertificateStates { get =>
            new DeviceConfigurationsAllManagedDeviceCertificateStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationUserStateSummariesRequestBuilder DeviceConfigurationUserStateSummaries { get =>
            new DeviceConfigurationUserStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCustomAttributeShellScriptsRequestBuilder DeviceCustomAttributeShellScripts { get =>
            new DeviceCustomAttributeShellScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceHealthScriptsRequestBuilder DeviceHealthScripts { get =>
            new DeviceHealthScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceManagementPartnersRequestBuilder DeviceManagementPartners { get =>
            new DeviceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceManagementScriptsRequestBuilder DeviceManagementScripts { get =>
            new DeviceManagementScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceShellScriptsRequestBuilder DeviceShellScripts { get =>
            new DeviceShellScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DomainJoinConnectorsRequestBuilder DomainJoinConnectors { get =>
            new DomainJoinConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public EmbeddedSIMActivationCodePoolsRequestBuilder EmbeddedSIMActivationCodePools { get =>
            new EmbeddedSIMActivationCodePoolsRequestBuilder(PathParameters, RequestAdapter);
        }
        public EnableAndroidDeviceAdministratorEnrollmentRequestBuilder EnableAndroidDeviceAdministratorEnrollment { get =>
            new EnableAndroidDeviceAdministratorEnrollmentRequestBuilder(PathParameters, RequestAdapter);
        }
        public EnableLegacyPcManagementRequestBuilder EnableLegacyPcManagement { get =>
            new EnableLegacyPcManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        public EnableUnlicensedAdminstratorsRequestBuilder EnableUnlicensedAdminstrators { get =>
            new EnableUnlicensedAdminstratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public EvaluateAssignmentFilterRequestBuilder EvaluateAssignmentFilter { get =>
            new EvaluateAssignmentFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExchangeConnectorsRequestBuilder ExchangeConnectors { get =>
            new ExchangeConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExchangeOnPremisesPoliciesRequestBuilder ExchangeOnPremisesPolicies { get =>
            new ExchangeOnPremisesPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExchangeOnPremisesPolicyRequestBuilder ExchangeOnPremisesPolicy { get =>
            new ExchangeOnPremisesPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetAssignmentFiltersStatusDetailsRequestBuilder GetAssignmentFiltersStatusDetails { get =>
            new GetAssignmentFiltersStatusDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupPolicyCategoriesRequestBuilder GroupPolicyCategories { get =>
            new GroupPolicyCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupPolicyConfigurationsRequestBuilder GroupPolicyConfigurations { get =>
            new GroupPolicyConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupPolicyDefinitionFilesRequestBuilder GroupPolicyDefinitionFiles { get =>
            new GroupPolicyDefinitionFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupPolicyDefinitionsRequestBuilder GroupPolicyDefinitions { get =>
            new GroupPolicyDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupPolicyMigrationReportsRequestBuilder GroupPolicyMigrationReports { get =>
            new GroupPolicyMigrationReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupPolicyObjectFilesRequestBuilder GroupPolicyObjectFiles { get =>
            new GroupPolicyObjectFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupPolicyUploadedDefinitionFilesRequestBuilder GroupPolicyUploadedDefinitionFiles { get =>
            new GroupPolicyUploadedDefinitionFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImportedDeviceIdentitiesRequestBuilder ImportedDeviceIdentities { get =>
            new ImportedDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder ImportedWindowsAutopilotDeviceIdentities { get =>
            new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public IntentsRequestBuilder Intents { get =>
            new IntentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public IntuneBrandingProfilesRequestBuilder IntuneBrandingProfiles { get =>
            new IntuneBrandingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public IosUpdateStatusesRequestBuilder IosUpdateStatuses { get =>
            new IosUpdateStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MacOSSoftwareUpdateAccountSummariesRequestBuilder MacOSSoftwareUpdateAccountSummaries { get =>
            new MacOSSoftwareUpdateAccountSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDeviceEncryptionStatesRequestBuilder ManagedDeviceEncryptionStates { get =>
            new ManagedDeviceEncryptionStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDeviceOverviewRequestBuilder ManagedDeviceOverview { get =>
            new ManagedDeviceOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementConditionsRequestBuilder ManagementConditions { get =>
            new ManagementConditionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagementConditionStatementsRequestBuilder ManagementConditionStatements { get =>
            new ManagementConditionStatementsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MicrosoftTunnelConfigurationsRequestBuilder MicrosoftTunnelConfigurations { get =>
            new MicrosoftTunnelConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MicrosoftTunnelHealthThresholdsRequestBuilder MicrosoftTunnelHealthThresholds { get =>
            new MicrosoftTunnelHealthThresholdsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MicrosoftTunnelServerLogCollectionResponsesRequestBuilder MicrosoftTunnelServerLogCollectionResponses { get =>
            new MicrosoftTunnelServerLogCollectionResponsesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MicrosoftTunnelSitesRequestBuilder MicrosoftTunnelSites { get =>
            new MicrosoftTunnelSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileAppTroubleshootingEventsRequestBuilder MobileAppTroubleshootingEvents { get =>
            new MobileAppTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileThreatDefenseConnectorsRequestBuilder MobileThreatDefenseConnectors { get =>
            new MobileThreatDefenseConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public NdesConnectorsRequestBuilder NdesConnectors { get =>
            new NdesConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public NotificationMessageTemplatesRequestBuilder NotificationMessageTemplates { get =>
            new NotificationMessageTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public OemWarrantyInformationOnboardingRequestBuilder OemWarrantyInformationOnboarding { get =>
            new OemWarrantyInformationOnboardingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public RemoteActionAuditsRequestBuilder RemoteActionAudits { get =>
            new RemoteActionAuditsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RemoteAssistancePartnersRequestBuilder RemoteAssistancePartners { get =>
            new RemoteAssistancePartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        public RemoteAssistanceSettingsRequestBuilder RemoteAssistanceSettings { get =>
            new RemoteAssistanceSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ResourceAccessProfilesRequestBuilder ResourceAccessProfiles { get =>
            new ResourceAccessProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ResourceOperationsRequestBuilder ResourceOperations { get =>
            new ResourceOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReusablePolicySettingsRequestBuilder ReusablePolicySettings { get =>
            new ReusablePolicySettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReusableSettingsRequestBuilder ReusableSettings { get =>
            new ReusableSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleScopeTagsRequestBuilder RoleScopeTags { get =>
            new RoleScopeTagsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal { get =>
            new SendCustomNotificationToCompanyPortalRequestBuilder(PathParameters, RequestAdapter);
        }
        public SettingDefinitionsRequestBuilder SettingDefinitions { get =>
            new SettingDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SoftwareUpdateStatusSummaryRequestBuilder SoftwareUpdateStatusSummary { get =>
            new SoftwareUpdateStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public TelecomExpenseManagementPartnersRequestBuilder TelecomExpenseManagementPartners { get =>
            new TelecomExpenseManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        public TemplatesRequestBuilder Templates { get =>
            new TemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public TemplateSettingsRequestBuilder TemplateSettings { get =>
            new TemplateSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TermsAndConditionsRequestBuilder TermsAndConditions { get =>
            new TermsAndConditionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TroubleshootingEventsRequestBuilder TroubleshootingEvents { get =>
            new TroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UserExperienceAnalyticsAppHealthApplicationPerformanceRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformance { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetailsRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthDeviceModelPerformanceRequestBuilder UserExperienceAnalyticsAppHealthDeviceModelPerformance { get =>
            new UserExperienceAnalyticsAppHealthDeviceModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthDevicePerformanceRequestBuilder UserExperienceAnalyticsAppHealthDevicePerformance { get =>
            new UserExperienceAnalyticsAppHealthDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthDevicePerformanceDetailsRequestBuilder UserExperienceAnalyticsAppHealthDevicePerformanceDetails { get =>
            new UserExperienceAnalyticsAppHealthDevicePerformanceDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthOSVersionPerformanceRequestBuilder UserExperienceAnalyticsAppHealthOSVersionPerformance { get =>
            new UserExperienceAnalyticsAppHealthOSVersionPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsAppHealthOverviewRequestBuilder UserExperienceAnalyticsAppHealthOverview { get =>
            new UserExperienceAnalyticsAppHealthOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBaselinesRequestBuilder UserExperienceAnalyticsBaselines { get =>
            new UserExperienceAnalyticsBaselinesRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBatteryHealthAppImpactRequestBuilder UserExperienceAnalyticsBatteryHealthAppImpact { get =>
            new UserExperienceAnalyticsBatteryHealthAppImpactRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBatteryHealthCapacityDetailsRequestBuilder UserExperienceAnalyticsBatteryHealthCapacityDetails { get =>
            new UserExperienceAnalyticsBatteryHealthCapacityDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBatteryHealthDeviceAppImpactRequestBuilder UserExperienceAnalyticsBatteryHealthDeviceAppImpact { get =>
            new UserExperienceAnalyticsBatteryHealthDeviceAppImpactRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBatteryHealthDevicePerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthDevicePerformance { get =>
            new UserExperienceAnalyticsBatteryHealthDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryRequestBuilder UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory { get =>
            new UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBatteryHealthModelPerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthModelPerformance { get =>
            new UserExperienceAnalyticsBatteryHealthModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBatteryHealthOsPerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthOsPerformance { get =>
            new UserExperienceAnalyticsBatteryHealthOsPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsBatteryHealthRuntimeDetailsRequestBuilder UserExperienceAnalyticsBatteryHealthRuntimeDetails { get =>
            new UserExperienceAnalyticsBatteryHealthRuntimeDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsCategoriesRequestBuilder UserExperienceAnalyticsCategories { get =>
            new UserExperienceAnalyticsCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsDeviceMetricHistoryRequestBuilder UserExperienceAnalyticsDeviceMetricHistory { get =>
            new UserExperienceAnalyticsDeviceMetricHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsDevicePerformanceRequestBuilder UserExperienceAnalyticsDevicePerformance { get =>
            new UserExperienceAnalyticsDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsDeviceScoresRequestBuilder UserExperienceAnalyticsDeviceScores { get =>
            new UserExperienceAnalyticsDeviceScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder UserExperienceAnalyticsDeviceStartupHistory { get =>
            new UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsDeviceStartupProcessesRequestBuilder UserExperienceAnalyticsDeviceStartupProcesses { get =>
            new UserExperienceAnalyticsDeviceStartupProcessesRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder UserExperienceAnalyticsDeviceStartupProcessPerformance { get =>
            new UserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsDevicesWithoutCloudIdentityRequestBuilder UserExperienceAnalyticsDevicesWithoutCloudIdentity { get =>
            new UserExperienceAnalyticsDevicesWithoutCloudIdentityRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsImpactingProcessRequestBuilder UserExperienceAnalyticsImpactingProcess { get =>
            new UserExperienceAnalyticsImpactingProcessRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsMetricHistoryRequestBuilder UserExperienceAnalyticsMetricHistory { get =>
            new UserExperienceAnalyticsMetricHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsModelScoresRequestBuilder UserExperienceAnalyticsModelScores { get =>
            new UserExperienceAnalyticsModelScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder UserExperienceAnalyticsNotAutopilotReadyDevice { get =>
            new UserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsOverviewRequestBuilder UserExperienceAnalyticsOverview { get =>
            new UserExperienceAnalyticsOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsRegressionSummaryRequestBuilder UserExperienceAnalyticsRegressionSummary { get =>
            new UserExperienceAnalyticsRegressionSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsRemoteConnectionRequestBuilder UserExperienceAnalyticsRemoteConnection { get =>
            new UserExperienceAnalyticsRemoteConnectionRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsResourcePerformanceRequestBuilder UserExperienceAnalyticsResourcePerformance { get =>
            new UserExperienceAnalyticsResourcePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsScoreHistoryRequestBuilder UserExperienceAnalyticsScoreHistory { get =>
            new UserExperienceAnalyticsScoreHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetricRequestBuilder UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric { get =>
            new UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetricRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsWorkFromAnywhereMetricsRequestBuilder UserExperienceAnalyticsWorkFromAnywhereMetrics { get =>
            new UserExperienceAnalyticsWorkFromAnywhereMetricsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserExperienceAnalyticsWorkFromAnywhereModelPerformanceRequestBuilder UserExperienceAnalyticsWorkFromAnywhereModelPerformance { get =>
            new UserExperienceAnalyticsWorkFromAnywhereModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserPfxCertificatesRequestBuilder UserPfxCertificates { get =>
            new UserPfxCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public VirtualEndpointRequestBuilder VirtualEndpoint { get =>
            new VirtualEndpointRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsAutopilotDeploymentProfilesRequestBuilder WindowsAutopilotDeploymentProfiles { get =>
            new WindowsAutopilotDeploymentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsAutopilotDeviceIdentitiesRequestBuilder WindowsAutopilotDeviceIdentities { get =>
            new WindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsAutopilotSettingsRequestBuilder WindowsAutopilotSettings { get =>
            new WindowsAutopilotSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsDriverUpdateProfilesRequestBuilder WindowsDriverUpdateProfiles { get =>
            new WindowsDriverUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsFeatureUpdateProfilesRequestBuilder WindowsFeatureUpdateProfiles { get =>
            new WindowsFeatureUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsInformationProtectionAppLearningSummariesRequestBuilder WindowsInformationProtectionAppLearningSummaries { get =>
            new WindowsInformationProtectionAppLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsInformationProtectionNetworkLearningSummariesRequestBuilder WindowsInformationProtectionNetworkLearningSummaries { get =>
            new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsMalwareInformationRequestBuilder WindowsMalwareInformation { get =>
            new WindowsMalwareInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsQualityUpdateProfilesRequestBuilder WindowsQualityUpdateProfiles { get =>
            new WindowsQualityUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsUpdateCatalogItemsRequestBuilder WindowsUpdateCatalogItems { get =>
            new WindowsUpdateCatalogItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get deviceManagement
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
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getAssignedRoleDetails()
        /// </summary>
        public GetAssignedRoleDetailsRequestBuilder GetAssignedRoleDetails() {
            return new GetAssignedRoleDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Get deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getComanagedDevicesSummary()
        /// </summary>
        public GetComanagedDevicesSummaryRequestBuilder GetComanagedDevicesSummary() {
            return new GetComanagedDevicesSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getComanagementEligibleDevicesSummary()
        /// </summary>
        public GetComanagementEligibleDevicesSummaryRequestBuilder GetComanagementEligibleDevicesSummary() {
            return new GetComanagementEligibleDevicesSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getEffectivePermissions()
        /// </summary>
        public GetEffectivePermissionsRequestBuilder GetEffectivePermissions() {
            return new GetEffectivePermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getEffectivePermissions(scope='{scope}')
        /// <param name="scope">Usage: scope={scope}</param>
        /// </summary>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(PathParameters, RequestAdapter, scope);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getRoleScopeTagsByIds(ids=@ids)
        /// </summary>
        public GetRoleScopeTagsByIdsWithIdsRequestBuilder GetRoleScopeTagsByIdsWithIds() {
            return new GetRoleScopeTagsByIdsWithIdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getRoleScopeTagsByResource(resource='{resource}')
        /// <param name="resource">Usage: resource={resource}</param>
        /// </summary>
        public GetRoleScopeTagsByResourceWithResourceRequestBuilder GetRoleScopeTagsByResourceWithResource(string resource) {
            if(string.IsNullOrEmpty(resource)) throw new ArgumentNullException(nameof(resource));
            return new GetRoleScopeTagsByResourceWithResourceRequestBuilder(PathParameters, RequestAdapter, resource);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getSuggestedEnrollmentLimit(enrollmentType='{enrollmentType}')
        /// <param name="enrollmentType">Usage: enrollmentType={enrollmentType}</param>
        /// </summary>
        public GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder GetSuggestedEnrollmentLimitWithEnrollmentType(string enrollmentType) {
            if(string.IsNullOrEmpty(enrollmentType)) throw new ArgumentNullException(nameof(enrollmentType));
            return new GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(PathParameters, RequestAdapter, enrollmentType);
        }
        /// <summary>
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.scopedForResource(resource='{resource}')
        /// <param name="resource">Usage: resource={resource}</param>
        /// </summary>
        public ScopedForResourceWithResourceRequestBuilder ScopedForResourceWithResource(string resource) {
            if(string.IsNullOrEmpty(resource)) throw new ArgumentNullException(nameof(resource));
            return new ScopedForResourceWithResourceRequestBuilder(PathParameters, RequestAdapter, resource);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.userExperienceAnalyticsSummarizeWorkFromAnywhereDevices()
        /// </summary>
        public UserExperienceAnalyticsSummarizeWorkFromAnywhereDevicesRequestBuilder UserExperienceAnalyticsSummarizeWorkFromAnywhereDevices() {
            return new UserExperienceAnalyticsSummarizeWorkFromAnywhereDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.verifyWindowsEnrollmentAutoDiscovery(domainName='{domainName}')
        /// <param name="domainName">Usage: domainName={domainName}</param>
        /// </summary>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder VerifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>Get deviceManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
