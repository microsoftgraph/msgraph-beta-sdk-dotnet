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
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementRequestBuilder {
        /// <summary>The advancedThreatProtectionOnboardingStateSummary property</summary>
        public AdvancedThreatProtectionOnboardingStateSummaryRequestBuilder AdvancedThreatProtectionOnboardingStateSummary { get =>
            new AdvancedThreatProtectionOnboardingStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The androidDeviceOwnerEnrollmentProfiles property</summary>
        public AndroidDeviceOwnerEnrollmentProfilesRequestBuilder AndroidDeviceOwnerEnrollmentProfiles { get =>
            new AndroidDeviceOwnerEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The androidForWorkAppConfigurationSchemas property</summary>
        public AndroidForWorkAppConfigurationSchemasRequestBuilder AndroidForWorkAppConfigurationSchemas { get =>
            new AndroidForWorkAppConfigurationSchemasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The androidForWorkEnrollmentProfiles property</summary>
        public AndroidForWorkEnrollmentProfilesRequestBuilder AndroidForWorkEnrollmentProfiles { get =>
            new AndroidForWorkEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The androidForWorkSettings property</summary>
        public AndroidForWorkSettingsRequestBuilder AndroidForWorkSettings { get =>
            new AndroidForWorkSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The androidManagedStoreAccountEnterpriseSettings property</summary>
        public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder AndroidManagedStoreAccountEnterpriseSettings { get =>
            new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The androidManagedStoreAppConfigurationSchemas property</summary>
        public AndroidManagedStoreAppConfigurationSchemasRequestBuilder AndroidManagedStoreAppConfigurationSchemas { get =>
            new AndroidManagedStoreAppConfigurationSchemasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The applePushNotificationCertificate property</summary>
        public ApplePushNotificationCertificateRequestBuilder ApplePushNotificationCertificate { get =>
            new ApplePushNotificationCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appleUserInitiatedEnrollmentProfiles property</summary>
        public AppleUserInitiatedEnrollmentProfilesRequestBuilder AppleUserInitiatedEnrollmentProfiles { get =>
            new AppleUserInitiatedEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignmentFilters property</summary>
        public AssignmentFiltersRequestBuilder AssignmentFilters { get =>
            new AssignmentFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The auditEvents property</summary>
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The autopilotEvents property</summary>
        public AutopilotEventsRequestBuilder AutopilotEvents { get =>
            new AutopilotEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cartToClassAssociations property</summary>
        public CartToClassAssociationsRequestBuilder CartToClassAssociations { get =>
            new CartToClassAssociationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The categories property</summary>
        public CategoriesRequestBuilder Categories { get =>
            new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The certificateConnectorDetails property</summary>
        public CertificateConnectorDetailsRequestBuilder CertificateConnectorDetails { get =>
            new CertificateConnectorDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The chromeOSOnboardingSettings property</summary>
        public ChromeOSOnboardingSettingsRequestBuilder ChromeOSOnboardingSettings { get =>
            new ChromeOSOnboardingSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cloudPCConnectivityIssues property</summary>
        public CloudPCConnectivityIssuesRequestBuilder CloudPCConnectivityIssues { get =>
            new CloudPCConnectivityIssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comanagedDevices property</summary>
        public ComanagedDevicesRequestBuilder ComanagedDevices { get =>
            new ComanagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comanagementEligibleDevices property</summary>
        public ComanagementEligibleDevicesRequestBuilder ComanagementEligibleDevices { get =>
            new ComanagementEligibleDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The complianceCategories property</summary>
        public ComplianceCategoriesRequestBuilder ComplianceCategories { get =>
            new ComplianceCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The complianceManagementPartners property</summary>
        public ComplianceManagementPartnersRequestBuilder ComplianceManagementPartners { get =>
            new ComplianceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The compliancePolicies property</summary>
        public CompliancePoliciesRequestBuilder CompliancePolicies { get =>
            new CompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The complianceSettings property</summary>
        public ComplianceSettingsRequestBuilder ComplianceSettings { get =>
            new ComplianceSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The conditionalAccessSettings property</summary>
        public ConditionalAccessSettingsRequestBuilder ConditionalAccessSettings { get =>
            new ConditionalAccessSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The configManagerCollections property</summary>
        public ConfigManagerCollectionsRequestBuilder ConfigManagerCollections { get =>
            new ConfigManagerCollectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The configurationCategories property</summary>
        public ConfigurationCategoriesRequestBuilder ConfigurationCategories { get =>
            new ConfigurationCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The configurationPolicies property</summary>
        public ConfigurationPoliciesRequestBuilder ConfigurationPolicies { get =>
            new ConfigurationPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The configurationPolicyTemplates property</summary>
        public ConfigurationPolicyTemplatesRequestBuilder ConfigurationPolicyTemplates { get =>
            new ConfigurationPolicyTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The configurationSettings property</summary>
        public ConfigurationSettingsRequestBuilder ConfigurationSettings { get =>
            new ConfigurationSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dataSharingConsents property</summary>
        public DataSharingConsentsRequestBuilder DataSharingConsents { get =>
            new DataSharingConsentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The depOnboardingSettings property</summary>
        public DepOnboardingSettingsRequestBuilder DepOnboardingSettings { get =>
            new DepOnboardingSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The derivedCredentials property</summary>
        public DerivedCredentialsRequestBuilder DerivedCredentials { get =>
            new DerivedCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The detectedApps property</summary>
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCategories property</summary>
        public DeviceCategoriesRequestBuilder DeviceCategories { get =>
            new DeviceCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCompliancePolicies property</summary>
        public DeviceCompliancePoliciesRequestBuilder DeviceCompliancePolicies { get =>
            new DeviceCompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCompliancePolicyDeviceStateSummary property</summary>
        public DeviceCompliancePolicyDeviceStateSummaryRequestBuilder DeviceCompliancePolicyDeviceStateSummary { get =>
            new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCompliancePolicySettingStateSummaries property</summary>
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceComplianceScripts property</summary>
        public DeviceComplianceScriptsRequestBuilder DeviceComplianceScripts { get =>
            new DeviceComplianceScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceConfigurationConflictSummary property</summary>
        public DeviceConfigurationConflictSummaryRequestBuilder DeviceConfigurationConflictSummary { get =>
            new DeviceConfigurationConflictSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceConfigurationDeviceStateSummaries property</summary>
        public DeviceConfigurationDeviceStateSummariesRequestBuilder DeviceConfigurationDeviceStateSummaries { get =>
            new DeviceConfigurationDeviceStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceConfigurationRestrictedAppsViolations property</summary>
        public DeviceConfigurationRestrictedAppsViolationsRequestBuilder DeviceConfigurationRestrictedAppsViolations { get =>
            new DeviceConfigurationRestrictedAppsViolationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceConfigurations property</summary>
        public DeviceConfigurationsRequestBuilder DeviceConfigurations { get =>
            new DeviceConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceConfigurationsAllManagedDeviceCertificateStates property</summary>
        public DeviceConfigurationsAllManagedDeviceCertificateStatesRequestBuilder DeviceConfigurationsAllManagedDeviceCertificateStates { get =>
            new DeviceConfigurationsAllManagedDeviceCertificateStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceConfigurationUserStateSummaries property</summary>
        public DeviceConfigurationUserStateSummariesRequestBuilder DeviceConfigurationUserStateSummaries { get =>
            new DeviceConfigurationUserStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCustomAttributeShellScripts property</summary>
        public DeviceCustomAttributeShellScriptsRequestBuilder DeviceCustomAttributeShellScripts { get =>
            new DeviceCustomAttributeShellScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceEnrollmentConfigurations property</summary>
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceHealthScripts property</summary>
        public DeviceHealthScriptsRequestBuilder DeviceHealthScripts { get =>
            new DeviceHealthScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceManagementPartners property</summary>
        public DeviceManagementPartnersRequestBuilder DeviceManagementPartners { get =>
            new DeviceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceManagementScripts property</summary>
        public DeviceManagementScriptsRequestBuilder DeviceManagementScripts { get =>
            new DeviceManagementScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceShellScripts property</summary>
        public DeviceShellScriptsRequestBuilder DeviceShellScripts { get =>
            new DeviceShellScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The domainJoinConnectors property</summary>
        public DomainJoinConnectorsRequestBuilder DomainJoinConnectors { get =>
            new DomainJoinConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The embeddedSIMActivationCodePools property</summary>
        public EmbeddedSIMActivationCodePoolsRequestBuilder EmbeddedSIMActivationCodePools { get =>
            new EmbeddedSIMActivationCodePoolsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enableAndroidDeviceAdministratorEnrollment property</summary>
        public EnableAndroidDeviceAdministratorEnrollmentRequestBuilder EnableAndroidDeviceAdministratorEnrollment { get =>
            new EnableAndroidDeviceAdministratorEnrollmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enableLegacyPcManagement property</summary>
        public EnableLegacyPcManagementRequestBuilder EnableLegacyPcManagement { get =>
            new EnableLegacyPcManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enableUnlicensedAdminstrators property</summary>
        public EnableUnlicensedAdminstratorsRequestBuilder EnableUnlicensedAdminstrators { get =>
            new EnableUnlicensedAdminstratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The evaluateAssignmentFilter property</summary>
        public EvaluateAssignmentFilterRequestBuilder EvaluateAssignmentFilter { get =>
            new EvaluateAssignmentFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The exchangeConnectors property</summary>
        public ExchangeConnectorsRequestBuilder ExchangeConnectors { get =>
            new ExchangeConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The exchangeOnPremisesPolicies property</summary>
        public ExchangeOnPremisesPoliciesRequestBuilder ExchangeOnPremisesPolicies { get =>
            new ExchangeOnPremisesPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The exchangeOnPremisesPolicy property</summary>
        public ExchangeOnPremisesPolicyRequestBuilder ExchangeOnPremisesPolicy { get =>
            new ExchangeOnPremisesPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getAssignmentFiltersStatusDetails property</summary>
        public GetAssignmentFiltersStatusDetailsRequestBuilder GetAssignmentFiltersStatusDetails { get =>
            new GetAssignmentFiltersStatusDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupPolicyCategories property</summary>
        public GroupPolicyCategoriesRequestBuilder GroupPolicyCategories { get =>
            new GroupPolicyCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupPolicyConfigurations property</summary>
        public GroupPolicyConfigurationsRequestBuilder GroupPolicyConfigurations { get =>
            new GroupPolicyConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupPolicyDefinitionFiles property</summary>
        public GroupPolicyDefinitionFilesRequestBuilder GroupPolicyDefinitionFiles { get =>
            new GroupPolicyDefinitionFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupPolicyDefinitions property</summary>
        public GroupPolicyDefinitionsRequestBuilder GroupPolicyDefinitions { get =>
            new GroupPolicyDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupPolicyMigrationReports property</summary>
        public GroupPolicyMigrationReportsRequestBuilder GroupPolicyMigrationReports { get =>
            new GroupPolicyMigrationReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupPolicyObjectFiles property</summary>
        public GroupPolicyObjectFilesRequestBuilder GroupPolicyObjectFiles { get =>
            new GroupPolicyObjectFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupPolicyUploadedDefinitionFiles property</summary>
        public GroupPolicyUploadedDefinitionFilesRequestBuilder GroupPolicyUploadedDefinitionFiles { get =>
            new GroupPolicyUploadedDefinitionFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The importedDeviceIdentities property</summary>
        public ImportedDeviceIdentitiesRequestBuilder ImportedDeviceIdentities { get =>
            new ImportedDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The importedWindowsAutopilotDeviceIdentities property</summary>
        public ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder ImportedWindowsAutopilotDeviceIdentities { get =>
            new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The intents property</summary>
        public IntentsRequestBuilder Intents { get =>
            new IntentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The intuneBrandingProfiles property</summary>
        public IntuneBrandingProfilesRequestBuilder IntuneBrandingProfiles { get =>
            new IntuneBrandingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The iosUpdateStatuses property</summary>
        public IosUpdateStatusesRequestBuilder IosUpdateStatuses { get =>
            new IosUpdateStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The macOSSoftwareUpdateAccountSummaries property</summary>
        public MacOSSoftwareUpdateAccountSummariesRequestBuilder MacOSSoftwareUpdateAccountSummaries { get =>
            new MacOSSoftwareUpdateAccountSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedDeviceEncryptionStates property</summary>
        public ManagedDeviceEncryptionStatesRequestBuilder ManagedDeviceEncryptionStates { get =>
            new ManagedDeviceEncryptionStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedDeviceOverview property</summary>
        public ManagedDeviceOverviewRequestBuilder ManagedDeviceOverview { get =>
            new ManagedDeviceOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedDevices property</summary>
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementConditions property</summary>
        public ManagementConditionsRequestBuilder ManagementConditions { get =>
            new ManagementConditionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managementConditionStatements property</summary>
        public ManagementConditionStatementsRequestBuilder ManagementConditionStatements { get =>
            new ManagementConditionStatementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The microsoftTunnelConfigurations property</summary>
        public MicrosoftTunnelConfigurationsRequestBuilder MicrosoftTunnelConfigurations { get =>
            new MicrosoftTunnelConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The microsoftTunnelHealthThresholds property</summary>
        public MicrosoftTunnelHealthThresholdsRequestBuilder MicrosoftTunnelHealthThresholds { get =>
            new MicrosoftTunnelHealthThresholdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The microsoftTunnelServerLogCollectionResponses property</summary>
        public MicrosoftTunnelServerLogCollectionResponsesRequestBuilder MicrosoftTunnelServerLogCollectionResponses { get =>
            new MicrosoftTunnelServerLogCollectionResponsesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The microsoftTunnelSites property</summary>
        public MicrosoftTunnelSitesRequestBuilder MicrosoftTunnelSites { get =>
            new MicrosoftTunnelSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileAppTroubleshootingEvents property</summary>
        public MobileAppTroubleshootingEventsRequestBuilder MobileAppTroubleshootingEvents { get =>
            new MobileAppTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileThreatDefenseConnectors property</summary>
        public MobileThreatDefenseConnectorsRequestBuilder MobileThreatDefenseConnectors { get =>
            new MobileThreatDefenseConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ndesConnectors property</summary>
        public NdesConnectorsRequestBuilder NdesConnectors { get =>
            new NdesConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notificationMessageTemplates property</summary>
        public NotificationMessageTemplatesRequestBuilder NotificationMessageTemplates { get =>
            new NotificationMessageTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oemWarrantyInformationOnboarding property</summary>
        public OemWarrantyInformationOnboardingRequestBuilder OemWarrantyInformationOnboarding { get =>
            new OemWarrantyInformationOnboardingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The remoteActionAudits property</summary>
        public RemoteActionAuditsRequestBuilder RemoteActionAudits { get =>
            new RemoteActionAuditsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The remoteAssistancePartners property</summary>
        public RemoteAssistancePartnersRequestBuilder RemoteAssistancePartners { get =>
            new RemoteAssistancePartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The remoteAssistanceSettings property</summary>
        public RemoteAssistanceSettingsRequestBuilder RemoteAssistanceSettings { get =>
            new RemoteAssistanceSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reports property</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The resourceAccessProfiles property</summary>
        public ResourceAccessProfilesRequestBuilder ResourceAccessProfiles { get =>
            new ResourceAccessProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resourceOperations property</summary>
        public ResourceOperationsRequestBuilder ResourceOperations { get =>
            new ResourceOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reusablePolicySettings property</summary>
        public ReusablePolicySettingsRequestBuilder ReusablePolicySettings { get =>
            new ReusablePolicySettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reusableSettings property</summary>
        public ReusableSettingsRequestBuilder ReusableSettings { get =>
            new ReusableSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleAssignments property</summary>
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleDefinitions property</summary>
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleScopeTags property</summary>
        public RoleScopeTagsRequestBuilder RoleScopeTags { get =>
            new RoleScopeTagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sendCustomNotificationToCompanyPortal property</summary>
        public SendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal { get =>
            new SendCustomNotificationToCompanyPortalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settingDefinitions property</summary>
        public SettingDefinitionsRequestBuilder SettingDefinitions { get =>
            new SettingDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The softwareUpdateStatusSummary property</summary>
        public SoftwareUpdateStatusSummaryRequestBuilder SoftwareUpdateStatusSummary { get =>
            new SoftwareUpdateStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The telecomExpenseManagementPartners property</summary>
        public TelecomExpenseManagementPartnersRequestBuilder TelecomExpenseManagementPartners { get =>
            new TelecomExpenseManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The templates property</summary>
        public TemplatesRequestBuilder Templates { get =>
            new TemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The templateSettings property</summary>
        public TemplateSettingsRequestBuilder TemplateSettings { get =>
            new TemplateSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The termsAndConditions property</summary>
        public TermsAndConditionsRequestBuilder TermsAndConditions { get =>
            new TermsAndConditionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The troubleshootingEvents property</summary>
        public TroubleshootingEventsRequestBuilder TroubleshootingEvents { get =>
            new TroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The userExperienceAnalyticsAppHealthApplicationPerformance property</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformance { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion property</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails property</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetailsRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId property</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion property</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthDeviceModelPerformance property</summary>
        public UserExperienceAnalyticsAppHealthDeviceModelPerformanceRequestBuilder UserExperienceAnalyticsAppHealthDeviceModelPerformance { get =>
            new UserExperienceAnalyticsAppHealthDeviceModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthDevicePerformance property</summary>
        public UserExperienceAnalyticsAppHealthDevicePerformanceRequestBuilder UserExperienceAnalyticsAppHealthDevicePerformance { get =>
            new UserExperienceAnalyticsAppHealthDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthDevicePerformanceDetails property</summary>
        public UserExperienceAnalyticsAppHealthDevicePerformanceDetailsRequestBuilder UserExperienceAnalyticsAppHealthDevicePerformanceDetails { get =>
            new UserExperienceAnalyticsAppHealthDevicePerformanceDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthOSVersionPerformance property</summary>
        public UserExperienceAnalyticsAppHealthOSVersionPerformanceRequestBuilder UserExperienceAnalyticsAppHealthOSVersionPerformance { get =>
            new UserExperienceAnalyticsAppHealthOSVersionPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsAppHealthOverview property</summary>
        public UserExperienceAnalyticsAppHealthOverviewRequestBuilder UserExperienceAnalyticsAppHealthOverview { get =>
            new UserExperienceAnalyticsAppHealthOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBaselines property</summary>
        public UserExperienceAnalyticsBaselinesRequestBuilder UserExperienceAnalyticsBaselines { get =>
            new UserExperienceAnalyticsBaselinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBatteryHealthAppImpact property</summary>
        public UserExperienceAnalyticsBatteryHealthAppImpactRequestBuilder UserExperienceAnalyticsBatteryHealthAppImpact { get =>
            new UserExperienceAnalyticsBatteryHealthAppImpactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBatteryHealthCapacityDetails property</summary>
        public UserExperienceAnalyticsBatteryHealthCapacityDetailsRequestBuilder UserExperienceAnalyticsBatteryHealthCapacityDetails { get =>
            new UserExperienceAnalyticsBatteryHealthCapacityDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBatteryHealthDeviceAppImpact property</summary>
        public UserExperienceAnalyticsBatteryHealthDeviceAppImpactRequestBuilder UserExperienceAnalyticsBatteryHealthDeviceAppImpact { get =>
            new UserExperienceAnalyticsBatteryHealthDeviceAppImpactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBatteryHealthDevicePerformance property</summary>
        public UserExperienceAnalyticsBatteryHealthDevicePerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthDevicePerformance { get =>
            new UserExperienceAnalyticsBatteryHealthDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory property</summary>
        public UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryRequestBuilder UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory { get =>
            new UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBatteryHealthModelPerformance property</summary>
        public UserExperienceAnalyticsBatteryHealthModelPerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthModelPerformance { get =>
            new UserExperienceAnalyticsBatteryHealthModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBatteryHealthOsPerformance property</summary>
        public UserExperienceAnalyticsBatteryHealthOsPerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthOsPerformance { get =>
            new UserExperienceAnalyticsBatteryHealthOsPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsBatteryHealthRuntimeDetails property</summary>
        public UserExperienceAnalyticsBatteryHealthRuntimeDetailsRequestBuilder UserExperienceAnalyticsBatteryHealthRuntimeDetails { get =>
            new UserExperienceAnalyticsBatteryHealthRuntimeDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsCategories property</summary>
        public UserExperienceAnalyticsCategoriesRequestBuilder UserExperienceAnalyticsCategories { get =>
            new UserExperienceAnalyticsCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsDeviceMetricHistory property</summary>
        public UserExperienceAnalyticsDeviceMetricHistoryRequestBuilder UserExperienceAnalyticsDeviceMetricHistory { get =>
            new UserExperienceAnalyticsDeviceMetricHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsDevicePerformance property</summary>
        public UserExperienceAnalyticsDevicePerformanceRequestBuilder UserExperienceAnalyticsDevicePerformance { get =>
            new UserExperienceAnalyticsDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsDeviceScores property</summary>
        public UserExperienceAnalyticsDeviceScoresRequestBuilder UserExperienceAnalyticsDeviceScores { get =>
            new UserExperienceAnalyticsDeviceScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsDeviceStartupHistory property</summary>
        public UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder UserExperienceAnalyticsDeviceStartupHistory { get =>
            new UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsDeviceStartupProcesses property</summary>
        public UserExperienceAnalyticsDeviceStartupProcessesRequestBuilder UserExperienceAnalyticsDeviceStartupProcesses { get =>
            new UserExperienceAnalyticsDeviceStartupProcessesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsDeviceStartupProcessPerformance property</summary>
        public UserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder UserExperienceAnalyticsDeviceStartupProcessPerformance { get =>
            new UserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsDevicesWithoutCloudIdentity property</summary>
        public UserExperienceAnalyticsDevicesWithoutCloudIdentityRequestBuilder UserExperienceAnalyticsDevicesWithoutCloudIdentity { get =>
            new UserExperienceAnalyticsDevicesWithoutCloudIdentityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsImpactingProcess property</summary>
        public UserExperienceAnalyticsImpactingProcessRequestBuilder UserExperienceAnalyticsImpactingProcess { get =>
            new UserExperienceAnalyticsImpactingProcessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsMetricHistory property</summary>
        public UserExperienceAnalyticsMetricHistoryRequestBuilder UserExperienceAnalyticsMetricHistory { get =>
            new UserExperienceAnalyticsMetricHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsModelScores property</summary>
        public UserExperienceAnalyticsModelScoresRequestBuilder UserExperienceAnalyticsModelScores { get =>
            new UserExperienceAnalyticsModelScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsNotAutopilotReadyDevice property</summary>
        public UserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder UserExperienceAnalyticsNotAutopilotReadyDevice { get =>
            new UserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsOverview property</summary>
        public UserExperienceAnalyticsOverviewRequestBuilder UserExperienceAnalyticsOverview { get =>
            new UserExperienceAnalyticsOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsRegressionSummary property</summary>
        public UserExperienceAnalyticsRegressionSummaryRequestBuilder UserExperienceAnalyticsRegressionSummary { get =>
            new UserExperienceAnalyticsRegressionSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsRemoteConnection property</summary>
        public UserExperienceAnalyticsRemoteConnectionRequestBuilder UserExperienceAnalyticsRemoteConnection { get =>
            new UserExperienceAnalyticsRemoteConnectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsResourcePerformance property</summary>
        public UserExperienceAnalyticsResourcePerformanceRequestBuilder UserExperienceAnalyticsResourcePerformance { get =>
            new UserExperienceAnalyticsResourcePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsScoreHistory property</summary>
        public UserExperienceAnalyticsScoreHistoryRequestBuilder UserExperienceAnalyticsScoreHistory { get =>
            new UserExperienceAnalyticsScoreHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric property</summary>
        public UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetricRequestBuilder UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric { get =>
            new UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetricRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsWorkFromAnywhereMetrics property</summary>
        public UserExperienceAnalyticsWorkFromAnywhereMetricsRequestBuilder UserExperienceAnalyticsWorkFromAnywhereMetrics { get =>
            new UserExperienceAnalyticsWorkFromAnywhereMetricsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userExperienceAnalyticsWorkFromAnywhereModelPerformance property</summary>
        public UserExperienceAnalyticsWorkFromAnywhereModelPerformanceRequestBuilder UserExperienceAnalyticsWorkFromAnywhereModelPerformance { get =>
            new UserExperienceAnalyticsWorkFromAnywhereModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userPfxCertificates property</summary>
        public UserPfxCertificatesRequestBuilder UserPfxCertificates { get =>
            new UserPfxCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The virtualEndpoint property</summary>
        public VirtualEndpointRequestBuilder VirtualEndpoint { get =>
            new VirtualEndpointRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsAutopilotDeploymentProfiles property</summary>
        public WindowsAutopilotDeploymentProfilesRequestBuilder WindowsAutopilotDeploymentProfiles { get =>
            new WindowsAutopilotDeploymentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsAutopilotDeviceIdentities property</summary>
        public WindowsAutopilotDeviceIdentitiesRequestBuilder WindowsAutopilotDeviceIdentities { get =>
            new WindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsAutopilotSettings property</summary>
        public WindowsAutopilotSettingsRequestBuilder WindowsAutopilotSettings { get =>
            new WindowsAutopilotSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsDriverUpdateProfiles property</summary>
        public WindowsDriverUpdateProfilesRequestBuilder WindowsDriverUpdateProfiles { get =>
            new WindowsDriverUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsFeatureUpdateProfiles property</summary>
        public WindowsFeatureUpdateProfilesRequestBuilder WindowsFeatureUpdateProfiles { get =>
            new WindowsFeatureUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionAppLearningSummaries property</summary>
        public WindowsInformationProtectionAppLearningSummariesRequestBuilder WindowsInformationProtectionAppLearningSummaries { get =>
            new WindowsInformationProtectionAppLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionNetworkLearningSummaries property</summary>
        public WindowsInformationProtectionNetworkLearningSummariesRequestBuilder WindowsInformationProtectionNetworkLearningSummaries { get =>
            new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsMalwareInformation property</summary>
        public WindowsMalwareInformationRequestBuilder WindowsMalwareInformation { get =>
            new WindowsMalwareInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsQualityUpdateProfiles property</summary>
        public WindowsQualityUpdateProfilesRequestBuilder WindowsQualityUpdateProfiles { get =>
            new WindowsQualityUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsUpdateCatalogItems property</summary>
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
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// Provides operations to call the getAssignedRoleDetails method.
        /// </summary>
        public GetAssignedRoleDetailsRequestBuilder GetAssignedRoleDetails() {
            return new GetAssignedRoleDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Get deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getComanagedDevicesSummary method.
        /// </summary>
        public GetComanagedDevicesSummaryRequestBuilder GetComanagedDevicesSummary() {
            return new GetComanagedDevicesSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getComanagementEligibleDevicesSummary method.
        /// </summary>
        public GetComanagementEligibleDevicesSummaryRequestBuilder GetComanagementEligibleDevicesSummary() {
            return new GetComanagementEligibleDevicesSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// </summary>
        public GetEffectivePermissionsRequestBuilder GetEffectivePermissions() {
            return new GetEffectivePermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// <param name="scope">Usage: scope=&apos;{scope}&apos;</param>
        /// </summary>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(PathParameters, RequestAdapter, scope);
        }
        /// <summary>
        /// Provides operations to call the getRoleScopeTagsByIds method.
        /// </summary>
        public GetRoleScopeTagsByIdsWithIdsRequestBuilder GetRoleScopeTagsByIdsWithIds() {
            return new GetRoleScopeTagsByIdsWithIdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getRoleScopeTagsByResource method.
        /// <param name="resource">Usage: resource=&apos;{resource}&apos;</param>
        /// </summary>
        public GetRoleScopeTagsByResourceWithResourceRequestBuilder GetRoleScopeTagsByResourceWithResource(string resource) {
            if(string.IsNullOrEmpty(resource)) throw new ArgumentNullException(nameof(resource));
            return new GetRoleScopeTagsByResourceWithResourceRequestBuilder(PathParameters, RequestAdapter, resource);
        }
        /// <summary>
        /// Provides operations to call the getSuggestedEnrollmentLimit method.
        /// <param name="enrollmentType">Usage: enrollmentType=&apos;{enrollmentType}&apos;</param>
        /// </summary>
        public GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder GetSuggestedEnrollmentLimitWithEnrollmentType(string enrollmentType) {
            if(string.IsNullOrEmpty(enrollmentType)) throw new ArgumentNullException(nameof(enrollmentType));
            return new GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(PathParameters, RequestAdapter, enrollmentType);
        }
        /// <summary>
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the scopedForResource method.
        /// <param name="resource">Usage: resource=&apos;{resource}&apos;</param>
        /// </summary>
        public ScopedForResourceWithResourceRequestBuilder ScopedForResourceWithResource(string resource) {
            if(string.IsNullOrEmpty(resource)) throw new ArgumentNullException(nameof(resource));
            return new ScopedForResourceWithResourceRequestBuilder(PathParameters, RequestAdapter, resource);
        }
        /// <summary>
        /// Provides operations to call the userExperienceAnalyticsSummarizeWorkFromAnywhereDevices method.
        /// </summary>
        public UserExperienceAnalyticsSummarizeWorkFromAnywhereDevicesRequestBuilder UserExperienceAnalyticsSummarizeWorkFromAnywhereDevices() {
            return new UserExperienceAnalyticsSummarizeWorkFromAnywhereDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the verifyWindowsEnrollmentAutoDiscovery method.
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
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
