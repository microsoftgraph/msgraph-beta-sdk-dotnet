using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagement : Entity, IParsable {
        /// <summary>The date & time when tenant data moved between scaleunits.</summary>
        public DateTimeOffset? AccountMoveCompletionDateTime { get; set; }
        /// <summary>Admin consent information.</summary>
        public AdminConsent AdminConsent { get; set; }
        /// <summary>The summary state of ATP onboarding state for this account.</summary>
        public AdvancedThreatProtectionOnboardingStateSummary AdvancedThreatProtectionOnboardingStateSummary { get; set; }
        /// <summary>Android device owner enrollment profile entities.</summary>
        public List<AndroidDeviceOwnerEnrollmentProfile> AndroidDeviceOwnerEnrollmentProfiles { get; set; }
        /// <summary>Android for Work app configuration schema entities.</summary>
        public List<AndroidForWorkAppConfigurationSchema> AndroidForWorkAppConfigurationSchemas { get; set; }
        /// <summary>Android for Work enrollment profile entities.</summary>
        public List<AndroidForWorkEnrollmentProfile> AndroidForWorkEnrollmentProfiles { get; set; }
        /// <summary>The singleton Android for Work settings entity.</summary>
        public AndroidForWorkSettings AndroidForWorkSettings { get; set; }
        /// <summary>The singleton Android managed store account enterprise settings entity.</summary>
        public AndroidManagedStoreAccountEnterpriseSettings AndroidManagedStoreAccountEnterpriseSettings { get; set; }
        /// <summary>Android Enterprise app configuration schema entities.</summary>
        public List<AndroidManagedStoreAppConfigurationSchema> AndroidManagedStoreAppConfigurationSchemas { get; set; }
        /// <summary>Apple push notification certificate.</summary>
        public ApplePushNotificationCertificate ApplePushNotificationCertificate { get; set; }
        /// <summary>Apple user initiated enrollment profiles</summary>
        public List<AppleUserInitiatedEnrollmentProfile> AppleUserInitiatedEnrollmentProfiles { get; set; }
        /// <summary>The list of assignment filters</summary>
        public List<DeviceAndAppManagementAssignmentFilter> AssignmentFilters { get; set; }
        /// <summary>The Audit Events</summary>
        public List<AuditEvent> AuditEvents { get; set; }
        /// <summary>The list of autopilot events for the tenant.</summary>
        public List<DeviceManagementAutopilotEvent> AutopilotEvents { get; set; }
        /// <summary>The Cart To Class Associations.</summary>
        public List<CartToClassAssociation> CartToClassAssociations { get; set; }
        /// <summary>The available categories</summary>
        public List<DeviceManagementSettingCategory> Categories { get; set; }
        /// <summary>Collection of certificate connector details, each associated with a corresponding Intune Certificate Connector.</summary>
        public List<CertificateConnectorDetails> CertificateConnectorDetails { get; set; }
        /// <summary>Collection of ChromeOSOnboardingSettings settings associated with account.</summary>
        public List<ChromeOSOnboardingSettings> ChromeOSOnboardingSettings { get; set; }
        /// <summary>The list of CloudPC Connectivity Issue.</summary>
        public List<CloudPCConnectivityIssue> CloudPCConnectivityIssues { get; set; }
        /// <summary>The list of co-managed devices report</summary>
        public List<ManagedDevice> ComanagedDevices { get; set; }
        /// <summary>The list of co-management eligible devices report</summary>
        public List<ComanagementEligibleDevice> ComanagementEligibleDevices { get; set; }
        /// <summary>List of all compliance categories</summary>
        public List<DeviceManagementConfigurationCategory> ComplianceCategories { get; set; }
        /// <summary>The list of Compliance Management Partners configured by the tenant.</summary>
        public List<ComplianceManagementPartner> ComplianceManagementPartners { get; set; }
        /// <summary>List of all compliance policies</summary>
        public List<DeviceManagementCompliancePolicy> CompliancePolicies { get; set; }
        /// <summary>List of all ComplianceSettings</summary>
        public List<DeviceManagementConfigurationSettingDefinition> ComplianceSettings { get; set; }
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
        /// <summary>A list of ConfigManagerCollection</summary>
        public List<ConfigManagerCollection> ConfigManagerCollections { get; set; }
        /// <summary>List of all Configuration Categories</summary>
        public List<DeviceManagementConfigurationCategory> ConfigurationCategories { get; set; }
        /// <summary>List of all Configuration policies</summary>
        public List<DeviceManagementConfigurationPolicy> ConfigurationPolicies { get; set; }
        /// <summary>List of all templates</summary>
        public List<DeviceManagementConfigurationPolicyTemplate> ConfigurationPolicyTemplates { get; set; }
        /// <summary>List of all ConfigurationSettings</summary>
        public List<DeviceManagementConfigurationSettingDefinition> ConfigurationSettings { get; set; }
        /// <summary>Data sharing consents.</summary>
        public List<DataSharingConsent> DataSharingConsents { get; set; }
        /// <summary>This collections of multiple DEP tokens per-tenant.</summary>
        public List<DepOnboardingSetting> DepOnboardingSettings { get; set; }
        /// <summary>Collection of Derived credential settings associated with account.</summary>
        public List<DeviceManagementDerivedCredentialSettings> DerivedCredentials { get; set; }
        /// <summary>The list of detected apps associated with a device.</summary>
        public List<DetectedApp> DetectedApps { get; set; }
        /// <summary>The list of device categories with the tenant.</summary>
        public List<DeviceCategory> DeviceCategories { get; set; }
        /// <summary>The device compliance policies.</summary>
        public List<DeviceCompliancePolicy> DeviceCompliancePolicies { get; set; }
        /// <summary>The device compliance state summary for this account.</summary>
        public DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary { get; set; }
        /// <summary>The summary states of compliance policy settings for this account.</summary>
        public List<DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries { get; set; }
        /// <summary>The last requested time of device compliance reporting for this account. This property is read-only.</summary>
        public DateTimeOffset? DeviceComplianceReportSummarizationDateTime { get; set; }
        /// <summary>The list of device compliance scripts associated with the tenant.</summary>
        public List<DeviceComplianceScript> DeviceComplianceScripts { get; set; }
        /// <summary>Summary of policies in conflict state for this account.</summary>
        public List<DeviceConfigurationConflictSummary> DeviceConfigurationConflictSummary { get; set; }
        /// <summary>The device configuration device state summary for this account.</summary>
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries { get; set; }
        /// <summary>Restricted apps violations for this account.</summary>
        public List<RestrictedAppsViolation> DeviceConfigurationRestrictedAppsViolations { get; set; }
        /// <summary>The device configurations.</summary>
        public List<DeviceConfiguration> DeviceConfigurations { get; set; }
        /// <summary>Summary of all certificates for all devices.</summary>
        public List<ManagedAllDeviceCertificateState> DeviceConfigurationsAllManagedDeviceCertificateStates { get; set; }
        /// <summary>The device configuration user state summary for this account.</summary>
        public DeviceConfigurationUserStateSummary DeviceConfigurationUserStateSummaries { get; set; }
        /// <summary>The list of device custom attribute shell scripts associated with the tenant.</summary>
        public List<DeviceCustomAttributeShellScript> DeviceCustomAttributeShellScripts { get; set; }
        /// <summary>The list of device enrollment configurations</summary>
        public List<DeviceEnrollmentConfiguration> DeviceEnrollmentConfigurations { get; set; }
        /// <summary>The list of device health scripts associated with the tenant.</summary>
        public List<DeviceHealthScript> DeviceHealthScripts { get; set; }
        /// <summary>The list of Device Management Partners configured by the tenant.</summary>
        public List<DeviceManagementPartner> DeviceManagementPartners { get; set; }
        /// <summary>The list of device management scripts associated with the tenant.</summary>
        public List<DeviceManagementScript> DeviceManagementScripts { get; set; }
        /// <summary>Device protection overview.</summary>
        public DeviceProtectionOverview DeviceProtectionOverview { get; set; }
        /// <summary>The list of device shell scripts associated with the tenant.</summary>
        public List<DeviceShellScript> DeviceShellScripts { get; set; }
        /// <summary>A list of connector objects.</summary>
        public List<DeviceManagementDomainJoinConnector> DomainJoinConnectors { get; set; }
        /// <summary>The embedded SIM activation code pools created by this account.</summary>
        public List<EmbeddedSIMActivationCodePool> EmbeddedSIMActivationCodePools { get; set; }
        /// <summary>The list of Exchange Connectors configured by the tenant.</summary>
        public List<DeviceManagementExchangeConnector> ExchangeConnectors { get; set; }
        /// <summary>The list of Exchange On Premisis policies configured by the tenant.</summary>
        public List<DeviceManagementExchangeOnPremisesPolicy> ExchangeOnPremisesPolicies { get; set; }
        /// <summary>The policy which controls mobile device access to Exchange On Premises</summary>
        public DeviceManagementExchangeOnPremisesPolicy ExchangeOnPremisesPolicy { get; set; }
        /// <summary>The available group policy categories for this account.</summary>
        public List<GroupPolicyCategory> GroupPolicyCategories { get; set; }
        /// <summary>The group policy configurations created by this account.</summary>
        public List<GroupPolicyConfiguration> GroupPolicyConfigurations { get; set; }
        /// <summary>The available group policy definition files for this account.</summary>
        public List<GroupPolicyDefinitionFile> GroupPolicyDefinitionFiles { get; set; }
        /// <summary>The available group policy definitions for this account.</summary>
        public List<GroupPolicyDefinition> GroupPolicyDefinitions { get; set; }
        /// <summary>A list of Group Policy migration reports.</summary>
        public List<GroupPolicyMigrationReport> GroupPolicyMigrationReports { get; set; }
        /// <summary>A list of Group Policy Object files uploaded.</summary>
        public List<GroupPolicyObjectFile> GroupPolicyObjectFiles { get; set; }
        /// <summary>The available group policy uploaded definition files for this account.</summary>
        public List<GroupPolicyUploadedDefinitionFile> GroupPolicyUploadedDefinitionFiles { get; set; }
        /// <summary>The imported device identities.</summary>
        public List<ImportedDeviceIdentity> ImportedDeviceIdentities { get; set; }
        /// <summary>Collection of imported Windows autopilot devices.</summary>
        public List<ImportedWindowsAutopilotDeviceIdentity> ImportedWindowsAutopilotDeviceIdentities { get; set; }
        /// <summary>The device management intents</summary>
        public List<DeviceManagementIntent> Intents { get; set; }
        /// <summary>Intune Account Id for given tenant</summary>
        public string IntuneAccountId { get; set; }
        /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
        public IntuneBrand IntuneBrand { get; set; }
        /// <summary>Intune branding profiles targeted to AAD groups</summary>
        public List<IntuneBrandingProfile> IntuneBrandingProfiles { get; set; }
        /// <summary>The IOS software update installation statuses for this account.</summary>
        public List<IosUpdateDeviceStatus> IosUpdateStatuses { get; set; }
        /// <summary>The last modified time of reporting for this account. This property is read-only.</summary>
        public DateTimeOffset? LastReportAggregationDateTime { get; set; }
        /// <summary>The property to enable Non-MDM managed legacy PC management for this account. This property is read-only.</summary>
        public bool? LegacyPcManangementEnabled { get; set; }
        /// <summary>The MacOS software update account summaries for this account.</summary>
        public List<MacOSSoftwareUpdateAccountSummary> MacOSSoftwareUpdateAccountSummaries { get; set; }
        /// <summary>Device cleanup rule</summary>
        public ManagedDeviceCleanupSettings ManagedDeviceCleanupSettings { get; set; }
        /// <summary>Encryption report for devices in this account</summary>
        public List<ManagedDeviceEncryptionState> ManagedDeviceEncryptionStates { get; set; }
        /// <summary>Device overview</summary>
        public ManagedDeviceOverview ManagedDeviceOverview { get; set; }
        /// <summary>The list of managed devices.</summary>
        public List<ManagedDevice> ManagedDevices { get; set; }
        /// <summary>The management conditions associated with device management of the company.</summary>
        public List<ManagementCondition> ManagementConditions { get; set; }
        /// <summary>The management condition statements associated with device management of the company.</summary>
        public List<ManagementConditionStatement> ManagementConditionStatements { get; set; }
        /// <summary>Maximum number of DEP tokens allowed per-tenant.</summary>
        public int? MaximumDepTokens { get; set; }
        /// <summary>Collection of MicrosoftTunnelConfiguration settings associated with account.</summary>
        public List<MicrosoftTunnelConfiguration> MicrosoftTunnelConfigurations { get; set; }
        /// <summary>Collection of MicrosoftTunnelHealthThreshold settings associated with account.</summary>
        public List<MicrosoftTunnelHealthThreshold> MicrosoftTunnelHealthThresholds { get; set; }
        /// <summary>Collection of MicrosoftTunnelServerLogCollectionResponse settings associated with account.</summary>
        public List<MicrosoftTunnelServerLogCollectionResponse> MicrosoftTunnelServerLogCollectionResponses { get; set; }
        /// <summary>Collection of MicrosoftTunnelSite settings associated with account.</summary>
        public List<MicrosoftTunnelSite> MicrosoftTunnelSites { get; set; }
        /// <summary>The collection property of MobileAppTroubleshootingEvent.</summary>
        public List<MobileAppTroubleshootingEvent> MobileAppTroubleshootingEvents { get; set; }
        /// <summary>The list of Mobile threat Defense connectors configured by the tenant.</summary>
        public List<MobileThreatDefenseConnector> MobileThreatDefenseConnectors { get; set; }
        /// <summary>The collection of Ndes connectors for this account.</summary>
        public List<NdesConnector> NdesConnectors { get; set; }
        /// <summary>The Notification Message Templates.</summary>
        public List<NotificationMessageTemplate> NotificationMessageTemplates { get; set; }
        /// <summary>List of OEM Warranty Statuses</summary>
        public List<OemWarrantyInformationOnboarding> OemWarrantyInformationOnboarding { get; set; }
        /// <summary>The list of device remote action audits with the tenant.</summary>
        public List<RemoteActionAudit> RemoteActionAudits { get; set; }
        /// <summary>The remote assist partners.</summary>
        public List<RemoteAssistancePartner> RemoteAssistancePartners { get; set; }
        /// <summary>The remote assistance settings singleton</summary>
        public RemoteAssistanceSettings RemoteAssistanceSettings { get; set; }
        /// <summary>Reports singleton</summary>
        public DeviceManagementReports Reports { get; set; }
        /// <summary>Collection of resource access settings associated with account.</summary>
        public List<DeviceManagementResourceAccessProfileBase> ResourceAccessProfiles { get; set; }
        /// <summary>The Resource Operations.</summary>
        public List<ResourceOperation> ResourceOperations { get; set; }
        /// <summary>List of all reusable settings that can be referred in a policy</summary>
        public List<DeviceManagementReusablePolicySetting> ReusablePolicySettings { get; set; }
        /// <summary>List of all reusable settings</summary>
        public List<DeviceManagementConfigurationSettingDefinition> ReusableSettings { get; set; }
        /// <summary>The Role Assignments.</summary>
        public List<DeviceAndAppManagementRoleAssignment> RoleAssignments { get; set; }
        /// <summary>The Role Definitions.</summary>
        public List<RoleDefinition> RoleDefinitions { get; set; }
        /// <summary>The Role Scope Tags.</summary>
        public List<RoleScopeTag> RoleScopeTags { get; set; }
        /// <summary>The device management intent setting definitions</summary>
        public List<DeviceManagementSettingDefinition> SettingDefinitions { get; set; }
        /// <summary>Account level settings.</summary>
        public DeviceManagementSettings Settings { get; set; }
        /// <summary>The software update status summary.</summary>
        public SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary { get; set; }
        /// <summary>Tenant's Subscription. Possible values are: none, intune, office365, intunePremium, intune_EDU, intune_SMB.</summary>
        public DeviceManagementSubscriptions? Subscriptions { get; set; }
        /// <summary>Tenant mobile device management subscription state. Possible values are: pending, active, warning, disabled, deleted, blocked, lockedOut.</summary>
        public DeviceManagementSubscriptionState? SubscriptionState { get; set; }
        /// <summary>The telecom expense management partners.</summary>
        public List<TelecomExpenseManagementPartner> TelecomExpenseManagementPartners { get; set; }
        /// <summary>The available templates</summary>
        public List<DeviceManagementTemplate> Templates { get; set; }
        /// <summary>List of all TemplateSettings</summary>
        public List<DeviceManagementConfigurationSettingTemplate> TemplateSettings { get; set; }
        /// <summary>The terms and conditions associated with device management of the company.</summary>
        public List<TermsAndConditions> TermsAndConditions { get; set; }
        /// <summary>The list of troubleshooting events for the tenant.</summary>
        public List<DeviceManagementTroubleshootingEvent> TroubleshootingEvents { get; set; }
        /// <summary>When enabled, users assigned as administrators via Role Assignment Memberships do not require an assigned Intune license. Prior to this, only Intune licensed users were granted permissions with an Intune role unless they were assigned a role via Azure Active Directory. You are limited to 350 unlicensed direct members for each AAD security group in a role assignment, but you can assign multiple AAD security groups to a role if you need to support more than 350 unlicensed administrators. Licensed administrators are unaffected, do not have to be direct members, nor does the 350 member limit apply. This property is read-only.</summary>
        public bool? UnlicensedAdminstratorsEnabled { get; set; }
        /// <summary>User experience analytics appHealth Application Performance</summary>
        public List<UserExperienceAnalyticsAppHealthApplicationPerformance> UserExperienceAnalyticsAppHealthApplicationPerformance { get; set; }
        /// <summary>User experience analytics appHealth Application Performance by App Version</summary>
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion { get; set; }
        /// <summary>User experience analytics appHealth Application Performance by App Version details</summary>
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails { get; set; }
        /// <summary>User experience analytics appHealth Application Performance by App Version Device Id</summary>
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId { get; set; }
        /// <summary>User experience analytics appHealth Application Performance by OS Version</summary>
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion> UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion { get; set; }
        /// <summary>User experience analytics appHealth Model Performance</summary>
        public List<UserExperienceAnalyticsAppHealthDeviceModelPerformance> UserExperienceAnalyticsAppHealthDeviceModelPerformance { get; set; }
        /// <summary>User experience analytics appHealth Device Performance</summary>
        public List<UserExperienceAnalyticsAppHealthDevicePerformance> UserExperienceAnalyticsAppHealthDevicePerformance { get; set; }
        /// <summary>User experience analytics device performance details</summary>
        public List<UserExperienceAnalyticsAppHealthDevicePerformanceDetails> UserExperienceAnalyticsAppHealthDevicePerformanceDetails { get; set; }
        /// <summary>User experience analytics appHealth OS version Performance</summary>
        public List<UserExperienceAnalyticsAppHealthOSVersionPerformance> UserExperienceAnalyticsAppHealthOSVersionPerformance { get; set; }
        /// <summary>User experience analytics appHealth overview</summary>
        public UserExperienceAnalyticsCategory UserExperienceAnalyticsAppHealthOverview { get; set; }
        /// <summary>User experience analytics baselines</summary>
        public List<UserExperienceAnalyticsBaseline> UserExperienceAnalyticsBaselines { get; set; }
        /// <summary>User Experience Analytics Battery Health App Impact</summary>
        public List<UserExperienceAnalyticsBatteryHealthAppImpact> UserExperienceAnalyticsBatteryHealthAppImpact { get; set; }
        /// <summary>User Experience Analytics Battery Health Capacity Details</summary>
        public UserExperienceAnalyticsBatteryHealthCapacityDetails UserExperienceAnalyticsBatteryHealthCapacityDetails { get; set; }
        /// <summary>User Experience Analytics Battery Health Device App Impact</summary>
        public List<UserExperienceAnalyticsBatteryHealthDeviceAppImpact> UserExperienceAnalyticsBatteryHealthDeviceAppImpact { get; set; }
        /// <summary>User Experience Analytics Battery Health Device Performance</summary>
        public List<UserExperienceAnalyticsBatteryHealthDevicePerformance> UserExperienceAnalyticsBatteryHealthDevicePerformance { get; set; }
        /// <summary>User Experience Analytics Battery Health Device Runtime History</summary>
        public List<UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory> UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory { get; set; }
        /// <summary>User Experience Analytics Battery Health Model Performance</summary>
        public List<UserExperienceAnalyticsBatteryHealthModelPerformance> UserExperienceAnalyticsBatteryHealthModelPerformance { get; set; }
        /// <summary>User Experience Analytics Battery Health Os Performance</summary>
        public List<UserExperienceAnalyticsBatteryHealthOsPerformance> UserExperienceAnalyticsBatteryHealthOsPerformance { get; set; }
        /// <summary>User Experience Analytics Battery Health Runtime Details</summary>
        public UserExperienceAnalyticsBatteryHealthRuntimeDetails UserExperienceAnalyticsBatteryHealthRuntimeDetails { get; set; }
        /// <summary>User experience analytics categories</summary>
        public List<UserExperienceAnalyticsCategory> UserExperienceAnalyticsCategories { get; set; }
        /// <summary>User experience analytics device metric history</summary>
        public List<UserExperienceAnalyticsMetricHistory> UserExperienceAnalyticsDeviceMetricHistory { get; set; }
        /// <summary>User experience analytics device performance</summary>
        public List<UserExperienceAnalyticsDevicePerformance> UserExperienceAnalyticsDevicePerformance { get; set; }
        /// <summary>User experience analytics device scores</summary>
        public List<UserExperienceAnalyticsDeviceScores> UserExperienceAnalyticsDeviceScores { get; set; }
        /// <summary>User experience analytics device Startup History</summary>
        public List<UserExperienceAnalyticsDeviceStartupHistory> UserExperienceAnalyticsDeviceStartupHistory { get; set; }
        /// <summary>User experience analytics device Startup Processes</summary>
        public List<UserExperienceAnalyticsDeviceStartupProcess> UserExperienceAnalyticsDeviceStartupProcesses { get; set; }
        /// <summary>User experience analytics device Startup Process Performance</summary>
        public List<UserExperienceAnalyticsDeviceStartupProcessPerformance> UserExperienceAnalyticsDeviceStartupProcessPerformance { get; set; }
        /// <summary>User experience analytics devices without cloud identity.</summary>
        public List<UserExperienceAnalyticsDeviceWithoutCloudIdentity> UserExperienceAnalyticsDevicesWithoutCloudIdentity { get; set; }
        /// <summary>User experience analytics impacting process</summary>
        public List<UserExperienceAnalyticsImpactingProcess> UserExperienceAnalyticsImpactingProcess { get; set; }
        /// <summary>User experience analytics metric history</summary>
        public List<UserExperienceAnalyticsMetricHistory> UserExperienceAnalyticsMetricHistory { get; set; }
        /// <summary>User experience analytics model scores</summary>
        public List<UserExperienceAnalyticsModelScores> UserExperienceAnalyticsModelScores { get; set; }
        /// <summary>User experience analytics devices not Windows Autopilot ready.</summary>
        public List<UserExperienceAnalyticsNotAutopilotReadyDevice> UserExperienceAnalyticsNotAutopilotReadyDevice { get; set; }
        /// <summary>User experience analytics overview</summary>
        public UserExperienceAnalyticsOverview UserExperienceAnalyticsOverview { get; set; }
        /// <summary>User experience analytics regression summary</summary>
        public UserExperienceAnalyticsRegressionSummary UserExperienceAnalyticsRegressionSummary { get; set; }
        /// <summary>User experience analytics remote connection</summary>
        public List<UserExperienceAnalyticsRemoteConnection> UserExperienceAnalyticsRemoteConnection { get; set; }
        /// <summary>User experience analytics resource performance</summary>
        public List<UserExperienceAnalyticsResourcePerformance> UserExperienceAnalyticsResourcePerformance { get; set; }
        /// <summary>User experience analytics device Startup Score History</summary>
        public List<UserExperienceAnalyticsScoreHistory> UserExperienceAnalyticsScoreHistory { get; set; }
        /// <summary>User experience analytics device settings</summary>
        public UserExperienceAnalyticsSettings UserExperienceAnalyticsSettings { get; set; }
        /// <summary>User experience analytics work from anywhere hardware readiness metrics.</summary>
        public UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric { get; set; }
        /// <summary>User experience analytics work from anywhere metrics.</summary>
        public List<UserExperienceAnalyticsWorkFromAnywhereMetric> UserExperienceAnalyticsWorkFromAnywhereMetrics { get; set; }
        /// <summary>The user experience analytics work from anywhere model performance</summary>
        public List<UserExperienceAnalyticsWorkFromAnywhereModelPerformance> UserExperienceAnalyticsWorkFromAnywhereModelPerformance { get; set; }
        /// <summary>Collection of PFX certificates associated with a user.</summary>
        public List<UserPFXCertificate> UserPfxCertificates { get; set; }
        public VirtualEndpoint VirtualEndpoint { get; set; }
        /// <summary>Windows auto pilot deployment profiles</summary>
        public List<WindowsAutopilotDeploymentProfile> WindowsAutopilotDeploymentProfiles { get; set; }
        /// <summary>The Windows autopilot device identities contained collection.</summary>
        public List<WindowsAutopilotDeviceIdentity> WindowsAutopilotDeviceIdentities { get; set; }
        /// <summary>The Windows autopilot account settings.</summary>
        public WindowsAutopilotSettings WindowsAutopilotSettings { get; set; }
        /// <summary>A collection of windows driver update profiles</summary>
        public List<WindowsDriverUpdateProfile> WindowsDriverUpdateProfiles { get; set; }
        /// <summary>A collection of windows feature update profiles</summary>
        public List<WindowsFeatureUpdateProfile> WindowsFeatureUpdateProfiles { get; set; }
        /// <summary>The windows information protection app learning summaries.</summary>
        public List<WindowsInformationProtectionAppLearningSummary> WindowsInformationProtectionAppLearningSummaries { get; set; }
        /// <summary>The windows information protection network learning summaries.</summary>
        public List<WindowsInformationProtectionNetworkLearningSummary> WindowsInformationProtectionNetworkLearningSummaries { get; set; }
        /// <summary>The list of affected malware in the tenant.</summary>
        public List<WindowsMalwareInformation> WindowsMalwareInformation { get; set; }
        /// <summary>Malware overview for windows devices.</summary>
        public WindowsMalwareOverview WindowsMalwareOverview { get; set; }
        /// <summary>A collection of windows quality update profiles</summary>
        public List<WindowsQualityUpdateProfile> WindowsQualityUpdateProfiles { get; set; }
        /// <summary>A collection of windows update catalog items (fetaure updates item , quality updates item)</summary>
        public List<WindowsUpdateCatalogItem> WindowsUpdateCatalogItems { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accountMoveCompletionDateTime", (o,n) => { (o as DeviceManagement).AccountMoveCompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"adminConsent", (o,n) => { (o as DeviceManagement).AdminConsent = n.GetObjectValue<AdminConsent>(); } },
                {"advancedThreatProtectionOnboardingStateSummary", (o,n) => { (o as DeviceManagement).AdvancedThreatProtectionOnboardingStateSummary = n.GetObjectValue<AdvancedThreatProtectionOnboardingStateSummary>(); } },
                {"androidDeviceOwnerEnrollmentProfiles", (o,n) => { (o as DeviceManagement).AndroidDeviceOwnerEnrollmentProfiles = n.GetCollectionOfObjectValues<AndroidDeviceOwnerEnrollmentProfile>().ToList(); } },
                {"androidForWorkAppConfigurationSchemas", (o,n) => { (o as DeviceManagement).AndroidForWorkAppConfigurationSchemas = n.GetCollectionOfObjectValues<AndroidForWorkAppConfigurationSchema>().ToList(); } },
                {"androidForWorkEnrollmentProfiles", (o,n) => { (o as DeviceManagement).AndroidForWorkEnrollmentProfiles = n.GetCollectionOfObjectValues<AndroidForWorkEnrollmentProfile>().ToList(); } },
                {"androidForWorkSettings", (o,n) => { (o as DeviceManagement).AndroidForWorkSettings = n.GetObjectValue<AndroidForWorkSettings>(); } },
                {"androidManagedStoreAccountEnterpriseSettings", (o,n) => { (o as DeviceManagement).AndroidManagedStoreAccountEnterpriseSettings = n.GetObjectValue<AndroidManagedStoreAccountEnterpriseSettings>(); } },
                {"androidManagedStoreAppConfigurationSchemas", (o,n) => { (o as DeviceManagement).AndroidManagedStoreAppConfigurationSchemas = n.GetCollectionOfObjectValues<AndroidManagedStoreAppConfigurationSchema>().ToList(); } },
                {"applePushNotificationCertificate", (o,n) => { (o as DeviceManagement).ApplePushNotificationCertificate = n.GetObjectValue<ApplePushNotificationCertificate>(); } },
                {"appleUserInitiatedEnrollmentProfiles", (o,n) => { (o as DeviceManagement).AppleUserInitiatedEnrollmentProfiles = n.GetCollectionOfObjectValues<AppleUserInitiatedEnrollmentProfile>().ToList(); } },
                {"assignmentFilters", (o,n) => { (o as DeviceManagement).AssignmentFilters = n.GetCollectionOfObjectValues<DeviceAndAppManagementAssignmentFilter>().ToList(); } },
                {"auditEvents", (o,n) => { (o as DeviceManagement).AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>().ToList(); } },
                {"autopilotEvents", (o,n) => { (o as DeviceManagement).AutopilotEvents = n.GetCollectionOfObjectValues<DeviceManagementAutopilotEvent>().ToList(); } },
                {"cartToClassAssociations", (o,n) => { (o as DeviceManagement).CartToClassAssociations = n.GetCollectionOfObjectValues<CartToClassAssociation>().ToList(); } },
                {"categories", (o,n) => { (o as DeviceManagement).Categories = n.GetCollectionOfObjectValues<DeviceManagementSettingCategory>().ToList(); } },
                {"certificateConnectorDetails", (o,n) => { (o as DeviceManagement).CertificateConnectorDetails = n.GetCollectionOfObjectValues<CertificateConnectorDetails>().ToList(); } },
                {"chromeOSOnboardingSettings", (o,n) => { (o as DeviceManagement).ChromeOSOnboardingSettings = n.GetCollectionOfObjectValues<ChromeOSOnboardingSettings>().ToList(); } },
                {"cloudPCConnectivityIssues", (o,n) => { (o as DeviceManagement).CloudPCConnectivityIssues = n.GetCollectionOfObjectValues<CloudPCConnectivityIssue>().ToList(); } },
                {"comanagedDevices", (o,n) => { (o as DeviceManagement).ComanagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>().ToList(); } },
                {"comanagementEligibleDevices", (o,n) => { (o as DeviceManagement).ComanagementEligibleDevices = n.GetCollectionOfObjectValues<ComanagementEligibleDevice>().ToList(); } },
                {"complianceCategories", (o,n) => { (o as DeviceManagement).ComplianceCategories = n.GetCollectionOfObjectValues<DeviceManagementConfigurationCategory>().ToList(); } },
                {"complianceManagementPartners", (o,n) => { (o as DeviceManagement).ComplianceManagementPartners = n.GetCollectionOfObjectValues<ComplianceManagementPartner>().ToList(); } },
                {"compliancePolicies", (o,n) => { (o as DeviceManagement).CompliancePolicies = n.GetCollectionOfObjectValues<DeviceManagementCompliancePolicy>().ToList(); } },
                {"complianceSettings", (o,n) => { (o as DeviceManagement).ComplianceSettings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>().ToList(); } },
                {"conditionalAccessSettings", (o,n) => { (o as DeviceManagement).ConditionalAccessSettings = n.GetObjectValue<OnPremisesConditionalAccessSettings>(); } },
                {"configManagerCollections", (o,n) => { (o as DeviceManagement).ConfigManagerCollections = n.GetCollectionOfObjectValues<ConfigManagerCollection>().ToList(); } },
                {"configurationCategories", (o,n) => { (o as DeviceManagement).ConfigurationCategories = n.GetCollectionOfObjectValues<DeviceManagementConfigurationCategory>().ToList(); } },
                {"configurationPolicies", (o,n) => { (o as DeviceManagement).ConfigurationPolicies = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicy>().ToList(); } },
                {"configurationPolicyTemplates", (o,n) => { (o as DeviceManagement).ConfigurationPolicyTemplates = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicyTemplate>().ToList(); } },
                {"configurationSettings", (o,n) => { (o as DeviceManagement).ConfigurationSettings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>().ToList(); } },
                {"dataSharingConsents", (o,n) => { (o as DeviceManagement).DataSharingConsents = n.GetCollectionOfObjectValues<DataSharingConsent>().ToList(); } },
                {"depOnboardingSettings", (o,n) => { (o as DeviceManagement).DepOnboardingSettings = n.GetCollectionOfObjectValues<DepOnboardingSetting>().ToList(); } },
                {"derivedCredentials", (o,n) => { (o as DeviceManagement).DerivedCredentials = n.GetCollectionOfObjectValues<DeviceManagementDerivedCredentialSettings>().ToList(); } },
                {"detectedApps", (o,n) => { (o as DeviceManagement).DetectedApps = n.GetCollectionOfObjectValues<DetectedApp>().ToList(); } },
                {"deviceCategories", (o,n) => { (o as DeviceManagement).DeviceCategories = n.GetCollectionOfObjectValues<DeviceCategory>().ToList(); } },
                {"deviceCompliancePolicies", (o,n) => { (o as DeviceManagement).DeviceCompliancePolicies = n.GetCollectionOfObjectValues<DeviceCompliancePolicy>().ToList(); } },
                {"deviceCompliancePolicyDeviceStateSummary", (o,n) => { (o as DeviceManagement).DeviceCompliancePolicyDeviceStateSummary = n.GetObjectValue<DeviceCompliancePolicyDeviceStateSummary>(); } },
                {"deviceCompliancePolicySettingStateSummaries", (o,n) => { (o as DeviceManagement).DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>().ToList(); } },
                {"deviceComplianceReportSummarizationDateTime", (o,n) => { (o as DeviceManagement).DeviceComplianceReportSummarizationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceComplianceScripts", (o,n) => { (o as DeviceManagement).DeviceComplianceScripts = n.GetCollectionOfObjectValues<DeviceComplianceScript>().ToList(); } },
                {"deviceConfigurationConflictSummary", (o,n) => { (o as DeviceManagement).DeviceConfigurationConflictSummary = n.GetCollectionOfObjectValues<DeviceConfigurationConflictSummary>().ToList(); } },
                {"deviceConfigurationDeviceStateSummaries", (o,n) => { (o as DeviceManagement).DeviceConfigurationDeviceStateSummaries = n.GetObjectValue<DeviceConfigurationDeviceStateSummary>(); } },
                {"deviceConfigurationRestrictedAppsViolations", (o,n) => { (o as DeviceManagement).DeviceConfigurationRestrictedAppsViolations = n.GetCollectionOfObjectValues<RestrictedAppsViolation>().ToList(); } },
                {"deviceConfigurations", (o,n) => { (o as DeviceManagement).DeviceConfigurations = n.GetCollectionOfObjectValues<DeviceConfiguration>().ToList(); } },
                {"deviceConfigurationsAllManagedDeviceCertificateStates", (o,n) => { (o as DeviceManagement).DeviceConfigurationsAllManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedAllDeviceCertificateState>().ToList(); } },
                {"deviceConfigurationUserStateSummaries", (o,n) => { (o as DeviceManagement).DeviceConfigurationUserStateSummaries = n.GetObjectValue<DeviceConfigurationUserStateSummary>(); } },
                {"deviceCustomAttributeShellScripts", (o,n) => { (o as DeviceManagement).DeviceCustomAttributeShellScripts = n.GetCollectionOfObjectValues<DeviceCustomAttributeShellScript>().ToList(); } },
                {"deviceEnrollmentConfigurations", (o,n) => { (o as DeviceManagement).DeviceEnrollmentConfigurations = n.GetCollectionOfObjectValues<DeviceEnrollmentConfiguration>().ToList(); } },
                {"deviceHealthScripts", (o,n) => { (o as DeviceManagement).DeviceHealthScripts = n.GetCollectionOfObjectValues<DeviceHealthScript>().ToList(); } },
                {"deviceManagementPartners", (o,n) => { (o as DeviceManagement).DeviceManagementPartners = n.GetCollectionOfObjectValues<DeviceManagementPartner>().ToList(); } },
                {"deviceManagementScripts", (o,n) => { (o as DeviceManagement).DeviceManagementScripts = n.GetCollectionOfObjectValues<DeviceManagementScript>().ToList(); } },
                {"deviceProtectionOverview", (o,n) => { (o as DeviceManagement).DeviceProtectionOverview = n.GetObjectValue<DeviceProtectionOverview>(); } },
                {"deviceShellScripts", (o,n) => { (o as DeviceManagement).DeviceShellScripts = n.GetCollectionOfObjectValues<DeviceShellScript>().ToList(); } },
                {"domainJoinConnectors", (o,n) => { (o as DeviceManagement).DomainJoinConnectors = n.GetCollectionOfObjectValues<DeviceManagementDomainJoinConnector>().ToList(); } },
                {"embeddedSIMActivationCodePools", (o,n) => { (o as DeviceManagement).EmbeddedSIMActivationCodePools = n.GetCollectionOfObjectValues<EmbeddedSIMActivationCodePool>().ToList(); } },
                {"exchangeConnectors", (o,n) => { (o as DeviceManagement).ExchangeConnectors = n.GetCollectionOfObjectValues<DeviceManagementExchangeConnector>().ToList(); } },
                {"exchangeOnPremisesPolicies", (o,n) => { (o as DeviceManagement).ExchangeOnPremisesPolicies = n.GetCollectionOfObjectValues<DeviceManagementExchangeOnPremisesPolicy>().ToList(); } },
                {"exchangeOnPremisesPolicy", (o,n) => { (o as DeviceManagement).ExchangeOnPremisesPolicy = n.GetObjectValue<DeviceManagementExchangeOnPremisesPolicy>(); } },
                {"groupPolicyCategories", (o,n) => { (o as DeviceManagement).GroupPolicyCategories = n.GetCollectionOfObjectValues<GroupPolicyCategory>().ToList(); } },
                {"groupPolicyConfigurations", (o,n) => { (o as DeviceManagement).GroupPolicyConfigurations = n.GetCollectionOfObjectValues<GroupPolicyConfiguration>().ToList(); } },
                {"groupPolicyDefinitionFiles", (o,n) => { (o as DeviceManagement).GroupPolicyDefinitionFiles = n.GetCollectionOfObjectValues<GroupPolicyDefinitionFile>().ToList(); } },
                {"groupPolicyDefinitions", (o,n) => { (o as DeviceManagement).GroupPolicyDefinitions = n.GetCollectionOfObjectValues<GroupPolicyDefinition>().ToList(); } },
                {"groupPolicyMigrationReports", (o,n) => { (o as DeviceManagement).GroupPolicyMigrationReports = n.GetCollectionOfObjectValues<GroupPolicyMigrationReport>().ToList(); } },
                {"groupPolicyObjectFiles", (o,n) => { (o as DeviceManagement).GroupPolicyObjectFiles = n.GetCollectionOfObjectValues<GroupPolicyObjectFile>().ToList(); } },
                {"groupPolicyUploadedDefinitionFiles", (o,n) => { (o as DeviceManagement).GroupPolicyUploadedDefinitionFiles = n.GetCollectionOfObjectValues<GroupPolicyUploadedDefinitionFile>().ToList(); } },
                {"importedDeviceIdentities", (o,n) => { (o as DeviceManagement).ImportedDeviceIdentities = n.GetCollectionOfObjectValues<ImportedDeviceIdentity>().ToList(); } },
                {"importedWindowsAutopilotDeviceIdentities", (o,n) => { (o as DeviceManagement).ImportedWindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>().ToList(); } },
                {"intents", (o,n) => { (o as DeviceManagement).Intents = n.GetCollectionOfObjectValues<DeviceManagementIntent>().ToList(); } },
                {"intuneAccountId", (o,n) => { (o as DeviceManagement).IntuneAccountId = n.GetStringValue(); } },
                {"intuneBrand", (o,n) => { (o as DeviceManagement).IntuneBrand = n.GetObjectValue<IntuneBrand>(); } },
                {"intuneBrandingProfiles", (o,n) => { (o as DeviceManagement).IntuneBrandingProfiles = n.GetCollectionOfObjectValues<IntuneBrandingProfile>().ToList(); } },
                {"iosUpdateStatuses", (o,n) => { (o as DeviceManagement).IosUpdateStatuses = n.GetCollectionOfObjectValues<IosUpdateDeviceStatus>().ToList(); } },
                {"lastReportAggregationDateTime", (o,n) => { (o as DeviceManagement).LastReportAggregationDateTime = n.GetDateTimeOffsetValue(); } },
                {"legacyPcManangementEnabled", (o,n) => { (o as DeviceManagement).LegacyPcManangementEnabled = n.GetBoolValue(); } },
                {"macOSSoftwareUpdateAccountSummaries", (o,n) => { (o as DeviceManagement).MacOSSoftwareUpdateAccountSummaries = n.GetCollectionOfObjectValues<MacOSSoftwareUpdateAccountSummary>().ToList(); } },
                {"managedDeviceCleanupSettings", (o,n) => { (o as DeviceManagement).ManagedDeviceCleanupSettings = n.GetObjectValue<ManagedDeviceCleanupSettings>(); } },
                {"managedDeviceEncryptionStates", (o,n) => { (o as DeviceManagement).ManagedDeviceEncryptionStates = n.GetCollectionOfObjectValues<ManagedDeviceEncryptionState>().ToList(); } },
                {"managedDeviceOverview", (o,n) => { (o as DeviceManagement).ManagedDeviceOverview = n.GetObjectValue<ManagedDeviceOverview>(); } },
                {"managedDevices", (o,n) => { (o as DeviceManagement).ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>().ToList(); } },
                {"managementConditions", (o,n) => { (o as DeviceManagement).ManagementConditions = n.GetCollectionOfObjectValues<ManagementCondition>().ToList(); } },
                {"managementConditionStatements", (o,n) => { (o as DeviceManagement).ManagementConditionStatements = n.GetCollectionOfObjectValues<ManagementConditionStatement>().ToList(); } },
                {"maximumDepTokens", (o,n) => { (o as DeviceManagement).MaximumDepTokens = n.GetIntValue(); } },
                {"microsoftTunnelConfigurations", (o,n) => { (o as DeviceManagement).MicrosoftTunnelConfigurations = n.GetCollectionOfObjectValues<MicrosoftTunnelConfiguration>().ToList(); } },
                {"microsoftTunnelHealthThresholds", (o,n) => { (o as DeviceManagement).MicrosoftTunnelHealthThresholds = n.GetCollectionOfObjectValues<MicrosoftTunnelHealthThreshold>().ToList(); } },
                {"microsoftTunnelServerLogCollectionResponses", (o,n) => { (o as DeviceManagement).MicrosoftTunnelServerLogCollectionResponses = n.GetCollectionOfObjectValues<MicrosoftTunnelServerLogCollectionResponse>().ToList(); } },
                {"microsoftTunnelSites", (o,n) => { (o as DeviceManagement).MicrosoftTunnelSites = n.GetCollectionOfObjectValues<MicrosoftTunnelSite>().ToList(); } },
                {"mobileAppTroubleshootingEvents", (o,n) => { (o as DeviceManagement).MobileAppTroubleshootingEvents = n.GetCollectionOfObjectValues<MobileAppTroubleshootingEvent>().ToList(); } },
                {"mobileThreatDefenseConnectors", (o,n) => { (o as DeviceManagement).MobileThreatDefenseConnectors = n.GetCollectionOfObjectValues<MobileThreatDefenseConnector>().ToList(); } },
                {"ndesConnectors", (o,n) => { (o as DeviceManagement).NdesConnectors = n.GetCollectionOfObjectValues<NdesConnector>().ToList(); } },
                {"notificationMessageTemplates", (o,n) => { (o as DeviceManagement).NotificationMessageTemplates = n.GetCollectionOfObjectValues<NotificationMessageTemplate>().ToList(); } },
                {"oemWarrantyInformationOnboarding", (o,n) => { (o as DeviceManagement).OemWarrantyInformationOnboarding = n.GetCollectionOfObjectValues<OemWarrantyInformationOnboarding>().ToList(); } },
                {"remoteActionAudits", (o,n) => { (o as DeviceManagement).RemoteActionAudits = n.GetCollectionOfObjectValues<RemoteActionAudit>().ToList(); } },
                {"remoteAssistancePartners", (o,n) => { (o as DeviceManagement).RemoteAssistancePartners = n.GetCollectionOfObjectValues<RemoteAssistancePartner>().ToList(); } },
                {"remoteAssistanceSettings", (o,n) => { (o as DeviceManagement).RemoteAssistanceSettings = n.GetObjectValue<RemoteAssistanceSettings>(); } },
                {"reports", (o,n) => { (o as DeviceManagement).Reports = n.GetObjectValue<DeviceManagementReports>(); } },
                {"resourceAccessProfiles", (o,n) => { (o as DeviceManagement).ResourceAccessProfiles = n.GetCollectionOfObjectValues<DeviceManagementResourceAccessProfileBase>().ToList(); } },
                {"resourceOperations", (o,n) => { (o as DeviceManagement).ResourceOperations = n.GetCollectionOfObjectValues<ResourceOperation>().ToList(); } },
                {"reusablePolicySettings", (o,n) => { (o as DeviceManagement).ReusablePolicySettings = n.GetCollectionOfObjectValues<DeviceManagementReusablePolicySetting>().ToList(); } },
                {"reusableSettings", (o,n) => { (o as DeviceManagement).ReusableSettings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>().ToList(); } },
                {"roleAssignments", (o,n) => { (o as DeviceManagement).RoleAssignments = n.GetCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>().ToList(); } },
                {"roleDefinitions", (o,n) => { (o as DeviceManagement).RoleDefinitions = n.GetCollectionOfObjectValues<RoleDefinition>().ToList(); } },
                {"roleScopeTags", (o,n) => { (o as DeviceManagement).RoleScopeTags = n.GetCollectionOfObjectValues<RoleScopeTag>().ToList(); } },
                {"settingDefinitions", (o,n) => { (o as DeviceManagement).SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementSettingDefinition>().ToList(); } },
                {"settings", (o,n) => { (o as DeviceManagement).Settings = n.GetObjectValue<DeviceManagementSettings>(); } },
                {"softwareUpdateStatusSummary", (o,n) => { (o as DeviceManagement).SoftwareUpdateStatusSummary = n.GetObjectValue<SoftwareUpdateStatusSummary>(); } },
                {"subscriptions", (o,n) => { (o as DeviceManagement).Subscriptions = n.GetEnumValue<DeviceManagementSubscriptions>(); } },
                {"subscriptionState", (o,n) => { (o as DeviceManagement).SubscriptionState = n.GetEnumValue<DeviceManagementSubscriptionState>(); } },
                {"telecomExpenseManagementPartners", (o,n) => { (o as DeviceManagement).TelecomExpenseManagementPartners = n.GetCollectionOfObjectValues<TelecomExpenseManagementPartner>().ToList(); } },
                {"templates", (o,n) => { (o as DeviceManagement).Templates = n.GetCollectionOfObjectValues<DeviceManagementTemplate>().ToList(); } },
                {"templateSettings", (o,n) => { (o as DeviceManagement).TemplateSettings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingTemplate>().ToList(); } },
                {"termsAndConditions", (o,n) => { (o as DeviceManagement).TermsAndConditions = n.GetCollectionOfObjectValues<TermsAndConditions>().ToList(); } },
                {"troubleshootingEvents", (o,n) => { (o as DeviceManagement).TroubleshootingEvents = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>().ToList(); } },
                {"unlicensedAdminstratorsEnabled", (o,n) => { (o as DeviceManagement).UnlicensedAdminstratorsEnabled = n.GetBoolValue(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthApplicationPerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthApplicationPerformance>().ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>().ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>().ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>().ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>().ToList(); } },
                {"userExperienceAnalyticsAppHealthDeviceModelPerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthDeviceModelPerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthDeviceModelPerformance>().ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthDevicePerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthDevicePerformance>().ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformanceDetails", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthDevicePerformanceDetails = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthDevicePerformanceDetails>().ToList(); } },
                {"userExperienceAnalyticsAppHealthOSVersionPerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthOSVersionPerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthOSVersionPerformance>().ToList(); } },
                {"userExperienceAnalyticsAppHealthOverview", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsAppHealthOverview = n.GetObjectValue<UserExperienceAnalyticsCategory>(); } },
                {"userExperienceAnalyticsBaselines", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBaselines = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBaseline>().ToList(); } },
                {"userExperienceAnalyticsBatteryHealthAppImpact", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBatteryHealthAppImpact = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthAppImpact>().ToList(); } },
                {"userExperienceAnalyticsBatteryHealthCapacityDetails", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBatteryHealthCapacityDetails = n.GetObjectValue<UserExperienceAnalyticsBatteryHealthCapacityDetails>(); } },
                {"userExperienceAnalyticsBatteryHealthDeviceAppImpact", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBatteryHealthDeviceAppImpact = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthDeviceAppImpact>().ToList(); } },
                {"userExperienceAnalyticsBatteryHealthDevicePerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBatteryHealthDevicePerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthDevicePerformance>().ToList(); } },
                {"userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory>().ToList(); } },
                {"userExperienceAnalyticsBatteryHealthModelPerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBatteryHealthModelPerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthModelPerformance>().ToList(); } },
                {"userExperienceAnalyticsBatteryHealthOsPerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBatteryHealthOsPerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthOsPerformance>().ToList(); } },
                {"userExperienceAnalyticsBatteryHealthRuntimeDetails", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsBatteryHealthRuntimeDetails = n.GetObjectValue<UserExperienceAnalyticsBatteryHealthRuntimeDetails>(); } },
                {"userExperienceAnalyticsCategories", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsCategories = n.GetCollectionOfObjectValues<UserExperienceAnalyticsCategory>().ToList(); } },
                {"userExperienceAnalyticsDeviceMetricHistory", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsDeviceMetricHistory = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetricHistory>().ToList(); } },
                {"userExperienceAnalyticsDevicePerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsDevicePerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDevicePerformance>().ToList(); } },
                {"userExperienceAnalyticsDeviceScores", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsDeviceScores = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceScores>().ToList(); } },
                {"userExperienceAnalyticsDeviceStartupHistory", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsDeviceStartupHistory = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupHistory>().ToList(); } },
                {"userExperienceAnalyticsDeviceStartupProcesses", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsDeviceStartupProcesses = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcess>().ToList(); } },
                {"userExperienceAnalyticsDeviceStartupProcessPerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsDeviceStartupProcessPerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcessPerformance>().ToList(); } },
                {"userExperienceAnalyticsDevicesWithoutCloudIdentity", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsDevicesWithoutCloudIdentity = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceWithoutCloudIdentity>().ToList(); } },
                {"userExperienceAnalyticsImpactingProcess", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsImpactingProcess = n.GetCollectionOfObjectValues<UserExperienceAnalyticsImpactingProcess>().ToList(); } },
                {"userExperienceAnalyticsMetricHistory", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsMetricHistory = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetricHistory>().ToList(); } },
                {"userExperienceAnalyticsModelScores", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsModelScores = n.GetCollectionOfObjectValues<UserExperienceAnalyticsModelScores>().ToList(); } },
                {"userExperienceAnalyticsNotAutopilotReadyDevice", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsNotAutopilotReadyDevice = n.GetCollectionOfObjectValues<UserExperienceAnalyticsNotAutopilotReadyDevice>().ToList(); } },
                {"userExperienceAnalyticsOverview", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsOverview = n.GetObjectValue<UserExperienceAnalyticsOverview>(); } },
                {"userExperienceAnalyticsRegressionSummary", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsRegressionSummary = n.GetObjectValue<UserExperienceAnalyticsRegressionSummary>(); } },
                {"userExperienceAnalyticsRemoteConnection", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsRemoteConnection = n.GetCollectionOfObjectValues<UserExperienceAnalyticsRemoteConnection>().ToList(); } },
                {"userExperienceAnalyticsResourcePerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsResourcePerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsResourcePerformance>().ToList(); } },
                {"userExperienceAnalyticsScoreHistory", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsScoreHistory = n.GetCollectionOfObjectValues<UserExperienceAnalyticsScoreHistory>().ToList(); } },
                {"userExperienceAnalyticsSettings", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsSettings = n.GetObjectValue<UserExperienceAnalyticsSettings>(); } },
                {"userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric = n.GetObjectValue<UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>(); } },
                {"userExperienceAnalyticsWorkFromAnywhereMetrics", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsWorkFromAnywhereMetrics = n.GetCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereMetric>().ToList(); } },
                {"userExperienceAnalyticsWorkFromAnywhereModelPerformance", (o,n) => { (o as DeviceManagement).UserExperienceAnalyticsWorkFromAnywhereModelPerformance = n.GetCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereModelPerformance>().ToList(); } },
                {"userPfxCertificates", (o,n) => { (o as DeviceManagement).UserPfxCertificates = n.GetCollectionOfObjectValues<UserPFXCertificate>().ToList(); } },
                {"virtualEndpoint", (o,n) => { (o as DeviceManagement).VirtualEndpoint = n.GetObjectValue<VirtualEndpoint>(); } },
                {"windowsAutopilotDeploymentProfiles", (o,n) => { (o as DeviceManagement).WindowsAutopilotDeploymentProfiles = n.GetCollectionOfObjectValues<WindowsAutopilotDeploymentProfile>().ToList(); } },
                {"windowsAutopilotDeviceIdentities", (o,n) => { (o as DeviceManagement).WindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>().ToList(); } },
                {"windowsAutopilotSettings", (o,n) => { (o as DeviceManagement).WindowsAutopilotSettings = n.GetObjectValue<WindowsAutopilotSettings>(); } },
                {"windowsDriverUpdateProfiles", (o,n) => { (o as DeviceManagement).WindowsDriverUpdateProfiles = n.GetCollectionOfObjectValues<WindowsDriverUpdateProfile>().ToList(); } },
                {"windowsFeatureUpdateProfiles", (o,n) => { (o as DeviceManagement).WindowsFeatureUpdateProfiles = n.GetCollectionOfObjectValues<WindowsFeatureUpdateProfile>().ToList(); } },
                {"windowsInformationProtectionAppLearningSummaries", (o,n) => { (o as DeviceManagement).WindowsInformationProtectionAppLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>().ToList(); } },
                {"windowsInformationProtectionNetworkLearningSummaries", (o,n) => { (o as DeviceManagement).WindowsInformationProtectionNetworkLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>().ToList(); } },
                {"windowsMalwareInformation", (o,n) => { (o as DeviceManagement).WindowsMalwareInformation = n.GetCollectionOfObjectValues<WindowsMalwareInformation>().ToList(); } },
                {"windowsMalwareOverview", (o,n) => { (o as DeviceManagement).WindowsMalwareOverview = n.GetObjectValue<WindowsMalwareOverview>(); } },
                {"windowsQualityUpdateProfiles", (o,n) => { (o as DeviceManagement).WindowsQualityUpdateProfiles = n.GetCollectionOfObjectValues<WindowsQualityUpdateProfile>().ToList(); } },
                {"windowsUpdateCatalogItems", (o,n) => { (o as DeviceManagement).WindowsUpdateCatalogItems = n.GetCollectionOfObjectValues<WindowsUpdateCatalogItem>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("accountMoveCompletionDateTime", AccountMoveCompletionDateTime);
            writer.WriteObjectValue<AdminConsent>("adminConsent", AdminConsent);
            writer.WriteObjectValue<AdvancedThreatProtectionOnboardingStateSummary>("advancedThreatProtectionOnboardingStateSummary", AdvancedThreatProtectionOnboardingStateSummary);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerEnrollmentProfile>("androidDeviceOwnerEnrollmentProfiles", AndroidDeviceOwnerEnrollmentProfiles);
            writer.WriteCollectionOfObjectValues<AndroidForWorkAppConfigurationSchema>("androidForWorkAppConfigurationSchemas", AndroidForWorkAppConfigurationSchemas);
            writer.WriteCollectionOfObjectValues<AndroidForWorkEnrollmentProfile>("androidForWorkEnrollmentProfiles", AndroidForWorkEnrollmentProfiles);
            writer.WriteObjectValue<AndroidForWorkSettings>("androidForWorkSettings", AndroidForWorkSettings);
            writer.WriteObjectValue<AndroidManagedStoreAccountEnterpriseSettings>("androidManagedStoreAccountEnterpriseSettings", AndroidManagedStoreAccountEnterpriseSettings);
            writer.WriteCollectionOfObjectValues<AndroidManagedStoreAppConfigurationSchema>("androidManagedStoreAppConfigurationSchemas", AndroidManagedStoreAppConfigurationSchemas);
            writer.WriteObjectValue<ApplePushNotificationCertificate>("applePushNotificationCertificate", ApplePushNotificationCertificate);
            writer.WriteCollectionOfObjectValues<AppleUserInitiatedEnrollmentProfile>("appleUserInitiatedEnrollmentProfiles", AppleUserInitiatedEnrollmentProfiles);
            writer.WriteCollectionOfObjectValues<DeviceAndAppManagementAssignmentFilter>("assignmentFilters", AssignmentFilters);
            writer.WriteCollectionOfObjectValues<AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<DeviceManagementAutopilotEvent>("autopilotEvents", AutopilotEvents);
            writer.WriteCollectionOfObjectValues<CartToClassAssociation>("cartToClassAssociations", CartToClassAssociations);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingCategory>("categories", Categories);
            writer.WriteCollectionOfObjectValues<CertificateConnectorDetails>("certificateConnectorDetails", CertificateConnectorDetails);
            writer.WriteCollectionOfObjectValues<ChromeOSOnboardingSettings>("chromeOSOnboardingSettings", ChromeOSOnboardingSettings);
            writer.WriteCollectionOfObjectValues<CloudPCConnectivityIssue>("cloudPCConnectivityIssues", CloudPCConnectivityIssues);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("comanagedDevices", ComanagedDevices);
            writer.WriteCollectionOfObjectValues<ComanagementEligibleDevice>("comanagementEligibleDevices", ComanagementEligibleDevices);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationCategory>("complianceCategories", ComplianceCategories);
            writer.WriteCollectionOfObjectValues<ComplianceManagementPartner>("complianceManagementPartners", ComplianceManagementPartners);
            writer.WriteCollectionOfObjectValues<DeviceManagementCompliancePolicy>("compliancePolicies", CompliancePolicies);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>("complianceSettings", ComplianceSettings);
            writer.WriteObjectValue<OnPremisesConditionalAccessSettings>("conditionalAccessSettings", ConditionalAccessSettings);
            writer.WriteCollectionOfObjectValues<ConfigManagerCollection>("configManagerCollections", ConfigManagerCollections);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationCategory>("configurationCategories", ConfigurationCategories);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationPolicy>("configurationPolicies", ConfigurationPolicies);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationPolicyTemplate>("configurationPolicyTemplates", ConfigurationPolicyTemplates);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>("configurationSettings", ConfigurationSettings);
            writer.WriteCollectionOfObjectValues<DataSharingConsent>("dataSharingConsents", DataSharingConsents);
            writer.WriteCollectionOfObjectValues<DepOnboardingSetting>("depOnboardingSettings", DepOnboardingSettings);
            writer.WriteCollectionOfObjectValues<DeviceManagementDerivedCredentialSettings>("derivedCredentials", DerivedCredentials);
            writer.WriteCollectionOfObjectValues<DetectedApp>("detectedApps", DetectedApps);
            writer.WriteCollectionOfObjectValues<DeviceCategory>("deviceCategories", DeviceCategories);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicy>("deviceCompliancePolicies", DeviceCompliancePolicies);
            writer.WriteObjectValue<DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary", DeviceCompliancePolicyDeviceStateSummary);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteDateTimeOffsetValue("deviceComplianceReportSummarizationDateTime", DeviceComplianceReportSummarizationDateTime);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScript>("deviceComplianceScripts", DeviceComplianceScripts);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationConflictSummary>("deviceConfigurationConflictSummary", DeviceConfigurationConflictSummary);
            writer.WriteObjectValue<DeviceConfigurationDeviceStateSummary>("deviceConfigurationDeviceStateSummaries", DeviceConfigurationDeviceStateSummaries);
            writer.WriteCollectionOfObjectValues<RestrictedAppsViolation>("deviceConfigurationRestrictedAppsViolations", DeviceConfigurationRestrictedAppsViolations);
            writer.WriteCollectionOfObjectValues<DeviceConfiguration>("deviceConfigurations", DeviceConfigurations);
            writer.WriteCollectionOfObjectValues<ManagedAllDeviceCertificateState>("deviceConfigurationsAllManagedDeviceCertificateStates", DeviceConfigurationsAllManagedDeviceCertificateStates);
            writer.WriteObjectValue<DeviceConfigurationUserStateSummary>("deviceConfigurationUserStateSummaries", DeviceConfigurationUserStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceCustomAttributeShellScript>("deviceCustomAttributeShellScripts", DeviceCustomAttributeShellScripts);
            writer.WriteCollectionOfObjectValues<DeviceEnrollmentConfiguration>("deviceEnrollmentConfigurations", DeviceEnrollmentConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceHealthScript>("deviceHealthScripts", DeviceHealthScripts);
            writer.WriteCollectionOfObjectValues<DeviceManagementPartner>("deviceManagementPartners", DeviceManagementPartners);
            writer.WriteCollectionOfObjectValues<DeviceManagementScript>("deviceManagementScripts", DeviceManagementScripts);
            writer.WriteObjectValue<DeviceProtectionOverview>("deviceProtectionOverview", DeviceProtectionOverview);
            writer.WriteCollectionOfObjectValues<DeviceShellScript>("deviceShellScripts", DeviceShellScripts);
            writer.WriteCollectionOfObjectValues<DeviceManagementDomainJoinConnector>("domainJoinConnectors", DomainJoinConnectors);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMActivationCodePool>("embeddedSIMActivationCodePools", EmbeddedSIMActivationCodePools);
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeConnector>("exchangeConnectors", ExchangeConnectors);
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeOnPremisesPolicy>("exchangeOnPremisesPolicies", ExchangeOnPremisesPolicies);
            writer.WriteObjectValue<DeviceManagementExchangeOnPremisesPolicy>("exchangeOnPremisesPolicy", ExchangeOnPremisesPolicy);
            writer.WriteCollectionOfObjectValues<GroupPolicyCategory>("groupPolicyCategories", GroupPolicyCategories);
            writer.WriteCollectionOfObjectValues<GroupPolicyConfiguration>("groupPolicyConfigurations", GroupPolicyConfigurations);
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinitionFile>("groupPolicyDefinitionFiles", GroupPolicyDefinitionFiles);
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinition>("groupPolicyDefinitions", GroupPolicyDefinitions);
            writer.WriteCollectionOfObjectValues<GroupPolicyMigrationReport>("groupPolicyMigrationReports", GroupPolicyMigrationReports);
            writer.WriteCollectionOfObjectValues<GroupPolicyObjectFile>("groupPolicyObjectFiles", GroupPolicyObjectFiles);
            writer.WriteCollectionOfObjectValues<GroupPolicyUploadedDefinitionFile>("groupPolicyUploadedDefinitionFiles", GroupPolicyUploadedDefinitionFiles);
            writer.WriteCollectionOfObjectValues<ImportedDeviceIdentity>("importedDeviceIdentities", ImportedDeviceIdentities);
            writer.WriteCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>("importedWindowsAutopilotDeviceIdentities", ImportedWindowsAutopilotDeviceIdentities);
            writer.WriteCollectionOfObjectValues<DeviceManagementIntent>("intents", Intents);
            writer.WriteStringValue("intuneAccountId", IntuneAccountId);
            writer.WriteObjectValue<IntuneBrand>("intuneBrand", IntuneBrand);
            writer.WriteCollectionOfObjectValues<IntuneBrandingProfile>("intuneBrandingProfiles", IntuneBrandingProfiles);
            writer.WriteCollectionOfObjectValues<IosUpdateDeviceStatus>("iosUpdateStatuses", IosUpdateStatuses);
            writer.WriteDateTimeOffsetValue("lastReportAggregationDateTime", LastReportAggregationDateTime);
            writer.WriteBoolValue("legacyPcManangementEnabled", LegacyPcManangementEnabled);
            writer.WriteCollectionOfObjectValues<MacOSSoftwareUpdateAccountSummary>("macOSSoftwareUpdateAccountSummaries", MacOSSoftwareUpdateAccountSummaries);
            writer.WriteObjectValue<ManagedDeviceCleanupSettings>("managedDeviceCleanupSettings", ManagedDeviceCleanupSettings);
            writer.WriteCollectionOfObjectValues<ManagedDeviceEncryptionState>("managedDeviceEncryptionStates", ManagedDeviceEncryptionStates);
            writer.WriteObjectValue<ManagedDeviceOverview>("managedDeviceOverview", ManagedDeviceOverview);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteCollectionOfObjectValues<ManagementCondition>("managementConditions", ManagementConditions);
            writer.WriteCollectionOfObjectValues<ManagementConditionStatement>("managementConditionStatements", ManagementConditionStatements);
            writer.WriteIntValue("maximumDepTokens", MaximumDepTokens);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelConfiguration>("microsoftTunnelConfigurations", MicrosoftTunnelConfigurations);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelHealthThreshold>("microsoftTunnelHealthThresholds", MicrosoftTunnelHealthThresholds);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelServerLogCollectionResponse>("microsoftTunnelServerLogCollectionResponses", MicrosoftTunnelServerLogCollectionResponses);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelSite>("microsoftTunnelSites", MicrosoftTunnelSites);
            writer.WriteCollectionOfObjectValues<MobileAppTroubleshootingEvent>("mobileAppTroubleshootingEvents", MobileAppTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<MobileThreatDefenseConnector>("mobileThreatDefenseConnectors", MobileThreatDefenseConnectors);
            writer.WriteCollectionOfObjectValues<NdesConnector>("ndesConnectors", NdesConnectors);
            writer.WriteCollectionOfObjectValues<NotificationMessageTemplate>("notificationMessageTemplates", NotificationMessageTemplates);
            writer.WriteCollectionOfObjectValues<OemWarrantyInformationOnboarding>("oemWarrantyInformationOnboarding", OemWarrantyInformationOnboarding);
            writer.WriteCollectionOfObjectValues<RemoteActionAudit>("remoteActionAudits", RemoteActionAudits);
            writer.WriteCollectionOfObjectValues<RemoteAssistancePartner>("remoteAssistancePartners", RemoteAssistancePartners);
            writer.WriteObjectValue<RemoteAssistanceSettings>("remoteAssistanceSettings", RemoteAssistanceSettings);
            writer.WriteObjectValue<DeviceManagementReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<DeviceManagementResourceAccessProfileBase>("resourceAccessProfiles", ResourceAccessProfiles);
            writer.WriteCollectionOfObjectValues<ResourceOperation>("resourceOperations", ResourceOperations);
            writer.WriteCollectionOfObjectValues<DeviceManagementReusablePolicySetting>("reusablePolicySettings", ReusablePolicySettings);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>("reusableSettings", ReusableSettings);
            writer.WriteCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<RoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<RoleScopeTag>("roleScopeTags", RoleScopeTags);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingDefinition>("settingDefinitions", SettingDefinitions);
            writer.WriteObjectValue<DeviceManagementSettings>("settings", Settings);
            writer.WriteObjectValue<SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary", SoftwareUpdateStatusSummary);
            writer.WriteEnumValue<DeviceManagementSubscriptions>("subscriptions", Subscriptions);
            writer.WriteEnumValue<DeviceManagementSubscriptionState>("subscriptionState", SubscriptionState);
            writer.WriteCollectionOfObjectValues<TelecomExpenseManagementPartner>("telecomExpenseManagementPartners", TelecomExpenseManagementPartners);
            writer.WriteCollectionOfObjectValues<DeviceManagementTemplate>("templates", Templates);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingTemplate>("templateSettings", TemplateSettings);
            writer.WriteCollectionOfObjectValues<TermsAndConditions>("termsAndConditions", TermsAndConditions);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>("troubleshootingEvents", TroubleshootingEvents);
            writer.WriteBoolValue("unlicensedAdminstratorsEnabled", UnlicensedAdminstratorsEnabled);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthApplicationPerformance>("userExperienceAnalyticsAppHealthApplicationPerformance", UserExperienceAnalyticsAppHealthApplicationPerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthDeviceModelPerformance>("userExperienceAnalyticsAppHealthDeviceModelPerformance", UserExperienceAnalyticsAppHealthDeviceModelPerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthDevicePerformance>("userExperienceAnalyticsAppHealthDevicePerformance", UserExperienceAnalyticsAppHealthDevicePerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthDevicePerformanceDetails>("userExperienceAnalyticsAppHealthDevicePerformanceDetails", UserExperienceAnalyticsAppHealthDevicePerformanceDetails);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthOSVersionPerformance>("userExperienceAnalyticsAppHealthOSVersionPerformance", UserExperienceAnalyticsAppHealthOSVersionPerformance);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("userExperienceAnalyticsAppHealthOverview", UserExperienceAnalyticsAppHealthOverview);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBaseline>("userExperienceAnalyticsBaselines", UserExperienceAnalyticsBaselines);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthAppImpact>("userExperienceAnalyticsBatteryHealthAppImpact", UserExperienceAnalyticsBatteryHealthAppImpact);
            writer.WriteObjectValue<UserExperienceAnalyticsBatteryHealthCapacityDetails>("userExperienceAnalyticsBatteryHealthCapacityDetails", UserExperienceAnalyticsBatteryHealthCapacityDetails);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthDeviceAppImpact>("userExperienceAnalyticsBatteryHealthDeviceAppImpact", UserExperienceAnalyticsBatteryHealthDeviceAppImpact);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthDevicePerformance>("userExperienceAnalyticsBatteryHealthDevicePerformance", UserExperienceAnalyticsBatteryHealthDevicePerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory>("userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory", UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthModelPerformance>("userExperienceAnalyticsBatteryHealthModelPerformance", UserExperienceAnalyticsBatteryHealthModelPerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthOsPerformance>("userExperienceAnalyticsBatteryHealthOsPerformance", UserExperienceAnalyticsBatteryHealthOsPerformance);
            writer.WriteObjectValue<UserExperienceAnalyticsBatteryHealthRuntimeDetails>("userExperienceAnalyticsBatteryHealthRuntimeDetails", UserExperienceAnalyticsBatteryHealthRuntimeDetails);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsCategory>("userExperienceAnalyticsCategories", UserExperienceAnalyticsCategories);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsMetricHistory>("userExperienceAnalyticsDeviceMetricHistory", UserExperienceAnalyticsDeviceMetricHistory);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDevicePerformance>("userExperienceAnalyticsDevicePerformance", UserExperienceAnalyticsDevicePerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceScores>("userExperienceAnalyticsDeviceScores", UserExperienceAnalyticsDeviceScores);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupHistory>("userExperienceAnalyticsDeviceStartupHistory", UserExperienceAnalyticsDeviceStartupHistory);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcess>("userExperienceAnalyticsDeviceStartupProcesses", UserExperienceAnalyticsDeviceStartupProcesses);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcessPerformance>("userExperienceAnalyticsDeviceStartupProcessPerformance", UserExperienceAnalyticsDeviceStartupProcessPerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceWithoutCloudIdentity>("userExperienceAnalyticsDevicesWithoutCloudIdentity", UserExperienceAnalyticsDevicesWithoutCloudIdentity);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsImpactingProcess>("userExperienceAnalyticsImpactingProcess", UserExperienceAnalyticsImpactingProcess);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsMetricHistory>("userExperienceAnalyticsMetricHistory", UserExperienceAnalyticsMetricHistory);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsModelScores>("userExperienceAnalyticsModelScores", UserExperienceAnalyticsModelScores);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsNotAutopilotReadyDevice>("userExperienceAnalyticsNotAutopilotReadyDevice", UserExperienceAnalyticsNotAutopilotReadyDevice);
            writer.WriteObjectValue<UserExperienceAnalyticsOverview>("userExperienceAnalyticsOverview", UserExperienceAnalyticsOverview);
            writer.WriteObjectValue<UserExperienceAnalyticsRegressionSummary>("userExperienceAnalyticsRegressionSummary", UserExperienceAnalyticsRegressionSummary);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsRemoteConnection>("userExperienceAnalyticsRemoteConnection", UserExperienceAnalyticsRemoteConnection);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsResourcePerformance>("userExperienceAnalyticsResourcePerformance", UserExperienceAnalyticsResourcePerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsScoreHistory>("userExperienceAnalyticsScoreHistory", UserExperienceAnalyticsScoreHistory);
            writer.WriteObjectValue<UserExperienceAnalyticsSettings>("userExperienceAnalyticsSettings", UserExperienceAnalyticsSettings);
            writer.WriteObjectValue<UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereMetric>("userExperienceAnalyticsWorkFromAnywhereMetrics", UserExperienceAnalyticsWorkFromAnywhereMetrics);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereModelPerformance>("userExperienceAnalyticsWorkFromAnywhereModelPerformance", UserExperienceAnalyticsWorkFromAnywhereModelPerformance);
            writer.WriteCollectionOfObjectValues<UserPFXCertificate>("userPfxCertificates", UserPfxCertificates);
            writer.WriteObjectValue<VirtualEndpoint>("virtualEndpoint", VirtualEndpoint);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeploymentProfile>("windowsAutopilotDeploymentProfiles", WindowsAutopilotDeploymentProfiles);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>("windowsAutopilotDeviceIdentities", WindowsAutopilotDeviceIdentities);
            writer.WriteObjectValue<WindowsAutopilotSettings>("windowsAutopilotSettings", WindowsAutopilotSettings);
            writer.WriteCollectionOfObjectValues<WindowsDriverUpdateProfile>("windowsDriverUpdateProfiles", WindowsDriverUpdateProfiles);
            writer.WriteCollectionOfObjectValues<WindowsFeatureUpdateProfile>("windowsFeatureUpdateProfiles", WindowsFeatureUpdateProfiles);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>("windowsInformationProtectionAppLearningSummaries", WindowsInformationProtectionAppLearningSummaries);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>("windowsInformationProtectionNetworkLearningSummaries", WindowsInformationProtectionNetworkLearningSummaries);
            writer.WriteCollectionOfObjectValues<WindowsMalwareInformation>("windowsMalwareInformation", WindowsMalwareInformation);
            writer.WriteObjectValue<WindowsMalwareOverview>("windowsMalwareOverview", WindowsMalwareOverview);
            writer.WriteCollectionOfObjectValues<WindowsQualityUpdateProfile>("windowsQualityUpdateProfiles", WindowsQualityUpdateProfiles);
            writer.WriteCollectionOfObjectValues<WindowsUpdateCatalogItem>("windowsUpdateCatalogItems", WindowsUpdateCatalogItems);
        }
    }
}
