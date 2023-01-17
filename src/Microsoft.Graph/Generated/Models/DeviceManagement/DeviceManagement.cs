using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public class DeviceManagement : Entity, IParsable {
        /// <summary>The date &amp; time when tenant data moved between scaleunits.</summary>
        public DateTimeOffset? AccountMoveCompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("accountMoveCompletionDateTime"); }
            set { BackingStore?.Set("accountMoveCompletionDateTime", value); }
        }
        /// <summary>Admin consent information.</summary>
        public Microsoft.Graph.Beta.Models.AdminConsent AdminConsent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdminConsent>("adminConsent"); }
            set { BackingStore?.Set("adminConsent", value); }
        }
        /// <summary>The summary state of ATP onboarding state for this account.</summary>
        public Microsoft.Graph.Beta.Models.AdvancedThreatProtectionOnboardingStateSummary AdvancedThreatProtectionOnboardingStateSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdvancedThreatProtectionOnboardingStateSummary>("advancedThreatProtectionOnboardingStateSummary"); }
            set { BackingStore?.Set("advancedThreatProtectionOnboardingStateSummary", value); }
        }
        /// <summary>Android device owner enrollment profile entities.</summary>
        public List<Microsoft.Graph.Beta.Models.AndroidDeviceOwnerEnrollmentProfile> AndroidDeviceOwnerEnrollmentProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AndroidDeviceOwnerEnrollmentProfile>>("androidDeviceOwnerEnrollmentProfiles"); }
            set { BackingStore?.Set("androidDeviceOwnerEnrollmentProfiles", value); }
        }
        /// <summary>Android for Work app configuration schema entities.</summary>
        public List<Microsoft.Graph.Beta.Models.AndroidForWorkAppConfigurationSchema> AndroidForWorkAppConfigurationSchemas {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AndroidForWorkAppConfigurationSchema>>("androidForWorkAppConfigurationSchemas"); }
            set { BackingStore?.Set("androidForWorkAppConfigurationSchemas", value); }
        }
        /// <summary>Android for Work enrollment profile entities.</summary>
        public List<Microsoft.Graph.Beta.Models.AndroidForWorkEnrollmentProfile> AndroidForWorkEnrollmentProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AndroidForWorkEnrollmentProfile>>("androidForWorkEnrollmentProfiles"); }
            set { BackingStore?.Set("androidForWorkEnrollmentProfiles", value); }
        }
        /// <summary>The singleton Android for Work settings entity.</summary>
        public Microsoft.Graph.Beta.Models.AndroidForWorkSettings AndroidForWorkSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AndroidForWorkSettings>("androidForWorkSettings"); }
            set { BackingStore?.Set("androidForWorkSettings", value); }
        }
        /// <summary>The singleton Android managed store account enterprise settings entity.</summary>
        public Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings AndroidManagedStoreAccountEnterpriseSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>("androidManagedStoreAccountEnterpriseSettings"); }
            set { BackingStore?.Set("androidManagedStoreAccountEnterpriseSettings", value); }
        }
        /// <summary>Android Enterprise app configuration schema entities.</summary>
        public List<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppConfigurationSchema> AndroidManagedStoreAppConfigurationSchemas {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppConfigurationSchema>>("androidManagedStoreAppConfigurationSchemas"); }
            set { BackingStore?.Set("androidManagedStoreAppConfigurationSchemas", value); }
        }
        /// <summary>Apple push notification certificate.</summary>
        public Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate ApplePushNotificationCertificate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate>("applePushNotificationCertificate"); }
            set { BackingStore?.Set("applePushNotificationCertificate", value); }
        }
        /// <summary>Apple user initiated enrollment profiles</summary>
        public List<Microsoft.Graph.Beta.Models.AppleUserInitiatedEnrollmentProfile> AppleUserInitiatedEnrollmentProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AppleUserInitiatedEnrollmentProfile>>("appleUserInitiatedEnrollmentProfiles"); }
            set { BackingStore?.Set("appleUserInitiatedEnrollmentProfiles", value); }
        }
        /// <summary>The list of assignment filters</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter> AssignmentFilters {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter>>("assignmentFilters"); }
            set { BackingStore?.Set("assignmentFilters", value); }
        }
        /// <summary>The Audit Events</summary>
        public List<Microsoft.Graph.Beta.Models.AuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AuditEvent>>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
        /// <summary>The list of autopilot events for the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementAutopilotEvent> AutopilotEvents {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementAutopilotEvent>>("autopilotEvents"); }
            set { BackingStore?.Set("autopilotEvents", value); }
        }
        /// <summary>The Cart To Class Associations.</summary>
        public List<Microsoft.Graph.Beta.Models.CartToClassAssociation> CartToClassAssociations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CartToClassAssociation>>("cartToClassAssociations"); }
            set { BackingStore?.Set("cartToClassAssociations", value); }
        }
        /// <summary>The available categories</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementSettingCategory> Categories {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementSettingCategory>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
        /// <summary>Collection of certificate connector details, each associated with a corresponding Intune Certificate Connector.</summary>
        public List<Microsoft.Graph.Beta.Models.CertificateConnectorDetails> CertificateConnectorDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CertificateConnectorDetails>>("certificateConnectorDetails"); }
            set { BackingStore?.Set("certificateConnectorDetails", value); }
        }
        /// <summary>Collection of ChromeOSOnboardingSettings settings associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings> ChromeOSOnboardingSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings>>("chromeOSOnboardingSettings"); }
            set { BackingStore?.Set("chromeOSOnboardingSettings", value); }
        }
        /// <summary>The list of CloudPC Connectivity Issue.</summary>
        public List<Microsoft.Graph.Beta.Models.CloudPCConnectivityIssue> CloudPCConnectivityIssues {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CloudPCConnectivityIssue>>("cloudPCConnectivityIssues"); }
            set { BackingStore?.Set("cloudPCConnectivityIssues", value); }
        }
        /// <summary>The list of co-managed devices report</summary>
        public List<Microsoft.Graph.Beta.Models.ManagedDevice> ComanagedDevices {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ManagedDevice>>("comanagedDevices"); }
            set { BackingStore?.Set("comanagedDevices", value); }
        }
        /// <summary>The list of co-management eligible devices report</summary>
        public List<Microsoft.Graph.Beta.Models.ComanagementEligibleDevice> ComanagementEligibleDevices {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ComanagementEligibleDevice>>("comanagementEligibleDevices"); }
            set { BackingStore?.Set("comanagementEligibleDevices", value); }
        }
        /// <summary>List of all compliance categories</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory> ComplianceCategories {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory>>("complianceCategories"); }
            set { BackingStore?.Set("complianceCategories", value); }
        }
        /// <summary>The list of Compliance Management Partners configured by the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.ComplianceManagementPartner> ComplianceManagementPartners {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ComplianceManagementPartner>>("complianceManagementPartners"); }
            set { BackingStore?.Set("complianceManagementPartners", value); }
        }
        /// <summary>List of all compliance policies</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy> CompliancePolicies {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy>>("compliancePolicies"); }
            set { BackingStore?.Set("compliancePolicies", value); }
        }
        /// <summary>List of all ComplianceSettings</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition> ComplianceSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>>("complianceSettings"); }
            set { BackingStore?.Set("complianceSettings", value); }
        }
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
        public Microsoft.Graph.Beta.Models.OnPremisesConditionalAccessSettings ConditionalAccessSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OnPremisesConditionalAccessSettings>("conditionalAccessSettings"); }
            set { BackingStore?.Set("conditionalAccessSettings", value); }
        }
        /// <summary>A list of ConfigManagerCollection</summary>
        public List<Microsoft.Graph.Beta.Models.ConfigManagerCollection> ConfigManagerCollections {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConfigManagerCollection>>("configManagerCollections"); }
            set { BackingStore?.Set("configManagerCollections", value); }
        }
        /// <summary>List of all Configuration Categories</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory> ConfigurationCategories {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory>>("configurationCategories"); }
            set { BackingStore?.Set("configurationCategories", value); }
        }
        /// <summary>List of all Configuration policies</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicy> ConfigurationPolicies {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicy>>("configurationPolicies"); }
            set { BackingStore?.Set("configurationPolicies", value); }
        }
        /// <summary>List of all templates</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicyTemplate> ConfigurationPolicyTemplates {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicyTemplate>>("configurationPolicyTemplates"); }
            set { BackingStore?.Set("configurationPolicyTemplates", value); }
        }
        /// <summary>List of all ConfigurationSettings</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition> ConfigurationSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>>("configurationSettings"); }
            set { BackingStore?.Set("configurationSettings", value); }
        }
        /// <summary>A configuration entity for MEM features that utilize Data Processor Service for Windows (DPSW) data.</summary>
        public Microsoft.Graph.Beta.Models.DataProcessorServiceForWindowsFeaturesOnboarding DataProcessorServiceForWindowsFeaturesOnboarding {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DataProcessorServiceForWindowsFeaturesOnboarding>("dataProcessorServiceForWindowsFeaturesOnboarding"); }
            set { BackingStore?.Set("dataProcessorServiceForWindowsFeaturesOnboarding", value); }
        }
        /// <summary>Data sharing consents.</summary>
        public List<Microsoft.Graph.Beta.Models.DataSharingConsent> DataSharingConsents {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DataSharingConsent>>("dataSharingConsents"); }
            set { BackingStore?.Set("dataSharingConsents", value); }
        }
        /// <summary>This collections of multiple DEP tokens per-tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DepOnboardingSetting> DepOnboardingSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DepOnboardingSetting>>("depOnboardingSettings"); }
            set { BackingStore?.Set("depOnboardingSettings", value); }
        }
        /// <summary>Collection of Derived credential settings associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings> DerivedCredentials {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>>("derivedCredentials"); }
            set { BackingStore?.Set("derivedCredentials", value); }
        }
        /// <summary>The list of detected apps associated with a device.</summary>
        public List<Microsoft.Graph.Beta.Models.DetectedApp> DetectedApps {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DetectedApp>>("detectedApps"); }
            set { BackingStore?.Set("detectedApps", value); }
        }
        /// <summary>The list of device categories with the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceCategory> DeviceCategories {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceCategory>>("deviceCategories"); }
            set { BackingStore?.Set("deviceCategories", value); }
        }
        /// <summary>The device compliance policies.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceCompliancePolicy> DeviceCompliancePolicies {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceCompliancePolicy>>("deviceCompliancePolicies"); }
            set { BackingStore?.Set("deviceCompliancePolicies", value); }
        }
        /// <summary>The device compliance state summary for this account.</summary>
        public Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary"); }
            set { BackingStore?.Set("deviceCompliancePolicyDeviceStateSummary", value); }
        }
        /// <summary>The summary states of compliance policy settings for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceCompliancePolicySettingStateSummary>>("deviceCompliancePolicySettingStateSummaries"); }
            set { BackingStore?.Set("deviceCompliancePolicySettingStateSummaries", value); }
        }
        /// <summary>The last requested time of device compliance reporting for this account. This property is read-only.</summary>
        public DateTimeOffset? DeviceComplianceReportSummarizationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deviceComplianceReportSummarizationDateTime"); }
            set { BackingStore?.Set("deviceComplianceReportSummarizationDateTime", value); }
        }
        /// <summary>The list of device compliance scripts associated with the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceComplianceScript> DeviceComplianceScripts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceComplianceScript>>("deviceComplianceScripts"); }
            set { BackingStore?.Set("deviceComplianceScripts", value); }
        }
        /// <summary>Summary of policies in conflict state for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary> DeviceConfigurationConflictSummary {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary>>("deviceConfigurationConflictSummary"); }
            set { BackingStore?.Set("deviceConfigurationConflictSummary", value); }
        }
        /// <summary>The device configuration device state summary for this account.</summary>
        public Microsoft.Graph.Beta.Models.DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceConfigurationDeviceStateSummary>("deviceConfigurationDeviceStateSummaries"); }
            set { BackingStore?.Set("deviceConfigurationDeviceStateSummaries", value); }
        }
        /// <summary>Restricted apps violations for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.RestrictedAppsViolation> DeviceConfigurationRestrictedAppsViolations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RestrictedAppsViolation>>("deviceConfigurationRestrictedAppsViolations"); }
            set { BackingStore?.Set("deviceConfigurationRestrictedAppsViolations", value); }
        }
        /// <summary>The device configurations.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceConfiguration> DeviceConfigurations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceConfiguration>>("deviceConfigurations"); }
            set { BackingStore?.Set("deviceConfigurations", value); }
        }
        /// <summary>Summary of all certificates for all devices.</summary>
        public List<Microsoft.Graph.Beta.Models.ManagedAllDeviceCertificateState> DeviceConfigurationsAllManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ManagedAllDeviceCertificateState>>("deviceConfigurationsAllManagedDeviceCertificateStates"); }
            set { BackingStore?.Set("deviceConfigurationsAllManagedDeviceCertificateStates", value); }
        }
        /// <summary>The device configuration user state summary for this account.</summary>
        public Microsoft.Graph.Beta.Models.DeviceConfigurationUserStateSummary DeviceConfigurationUserStateSummaries {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceConfigurationUserStateSummary>("deviceConfigurationUserStateSummaries"); }
            set { BackingStore?.Set("deviceConfigurationUserStateSummaries", value); }
        }
        /// <summary>The list of device custom attribute shell scripts associated with the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceCustomAttributeShellScript> DeviceCustomAttributeShellScripts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceCustomAttributeShellScript>>("deviceCustomAttributeShellScripts"); }
            set { BackingStore?.Set("deviceCustomAttributeShellScripts", value); }
        }
        /// <summary>The list of device enrollment configurations</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceEnrollmentConfiguration> DeviceEnrollmentConfigurations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceEnrollmentConfiguration>>("deviceEnrollmentConfigurations"); }
            set { BackingStore?.Set("deviceEnrollmentConfigurations", value); }
        }
        /// <summary>The list of device health scripts associated with the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceHealthScript> DeviceHealthScripts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceHealthScript>>("deviceHealthScripts"); }
            set { BackingStore?.Set("deviceHealthScripts", value); }
        }
        /// <summary>The list of Device Management Partners configured by the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementPartner> DeviceManagementPartners {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementPartner>>("deviceManagementPartners"); }
            set { BackingStore?.Set("deviceManagementPartners", value); }
        }
        /// <summary>The list of device management scripts associated with the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementScript> DeviceManagementScripts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementScript>>("deviceManagementScripts"); }
            set { BackingStore?.Set("deviceManagementScripts", value); }
        }
        /// <summary>Device protection overview.</summary>
        public Microsoft.Graph.Beta.Models.DeviceProtectionOverview DeviceProtectionOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceProtectionOverview>("deviceProtectionOverview"); }
            set { BackingStore?.Set("deviceProtectionOverview", value); }
        }
        /// <summary>The list of device shell scripts associated with the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceShellScript> DeviceShellScripts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceShellScript>>("deviceShellScripts"); }
            set { BackingStore?.Set("deviceShellScripts", value); }
        }
        /// <summary>A list of connector objects.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementDomainJoinConnector> DomainJoinConnectors {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementDomainJoinConnector>>("domainJoinConnectors"); }
            set { BackingStore?.Set("domainJoinConnectors", value); }
        }
        /// <summary>The embedded SIM activation code pools created by this account.</summary>
        public List<Microsoft.Graph.Beta.Models.EmbeddedSIMActivationCodePool> EmbeddedSIMActivationCodePools {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.EmbeddedSIMActivationCodePool>>("embeddedSIMActivationCodePools"); }
            set { BackingStore?.Set("embeddedSIMActivationCodePools", value); }
        }
        /// <summary>The list of Exchange Connectors configured by the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnector> ExchangeConnectors {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnector>>("exchangeConnectors"); }
            set { BackingStore?.Set("exchangeConnectors", value); }
        }
        /// <summary>The list of Exchange On Premisis policies configured by the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy> ExchangeOnPremisesPolicies {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy>>("exchangeOnPremisesPolicies"); }
            set { BackingStore?.Set("exchangeOnPremisesPolicies", value); }
        }
        /// <summary>The policy which controls mobile device access to Exchange On Premises</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy ExchangeOnPremisesPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy>("exchangeOnPremisesPolicy"); }
            set { BackingStore?.Set("exchangeOnPremisesPolicy", value); }
        }
        /// <summary>The available group policy categories for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.GroupPolicyCategory> GroupPolicyCategories {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GroupPolicyCategory>>("groupPolicyCategories"); }
            set { BackingStore?.Set("groupPolicyCategories", value); }
        }
        /// <summary>The group policy configurations created by this account.</summary>
        public List<Microsoft.Graph.Beta.Models.GroupPolicyConfiguration> GroupPolicyConfigurations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GroupPolicyConfiguration>>("groupPolicyConfigurations"); }
            set { BackingStore?.Set("groupPolicyConfigurations", value); }
        }
        /// <summary>The available group policy definition files for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile> GroupPolicyDefinitionFiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile>>("groupPolicyDefinitionFiles"); }
            set { BackingStore?.Set("groupPolicyDefinitionFiles", value); }
        }
        /// <summary>The available group policy definitions for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.GroupPolicyDefinition> GroupPolicyDefinitions {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GroupPolicyDefinition>>("groupPolicyDefinitions"); }
            set { BackingStore?.Set("groupPolicyDefinitions", value); }
        }
        /// <summary>A list of Group Policy migration reports.</summary>
        public List<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport> GroupPolicyMigrationReports {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport>>("groupPolicyMigrationReports"); }
            set { BackingStore?.Set("groupPolicyMigrationReports", value); }
        }
        /// <summary>A list of Group Policy Object files uploaded.</summary>
        public List<Microsoft.Graph.Beta.Models.GroupPolicyObjectFile> GroupPolicyObjectFiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GroupPolicyObjectFile>>("groupPolicyObjectFiles"); }
            set { BackingStore?.Set("groupPolicyObjectFiles", value); }
        }
        /// <summary>The available group policy uploaded definition files for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.GroupPolicyUploadedDefinitionFile> GroupPolicyUploadedDefinitionFiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GroupPolicyUploadedDefinitionFile>>("groupPolicyUploadedDefinitionFiles"); }
            set { BackingStore?.Set("groupPolicyUploadedDefinitionFiles", value); }
        }
        /// <summary>The imported device identities.</summary>
        public List<Microsoft.Graph.Beta.Models.ImportedDeviceIdentity> ImportedDeviceIdentities {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ImportedDeviceIdentity>>("importedDeviceIdentities"); }
            set { BackingStore?.Set("importedDeviceIdentities", value); }
        }
        /// <summary>Collection of imported Windows autopilot devices.</summary>
        public List<Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentity> ImportedWindowsAutopilotDeviceIdentities {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentity>>("importedWindowsAutopilotDeviceIdentities"); }
            set { BackingStore?.Set("importedWindowsAutopilotDeviceIdentities", value); }
        }
        /// <summary>The device management intents</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntent> Intents {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntent>>("intents"); }
            set { BackingStore?.Set("intents", value); }
        }
        /// <summary>Intune Account ID for given tenant</summary>
        public Guid? IntuneAccountId {
            get { return BackingStore?.Get<Guid?>("intuneAccountId"); }
            set { BackingStore?.Set("intuneAccountId", value); }
        }
        /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
        public Microsoft.Graph.Beta.Models.IntuneBrand IntuneBrand {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IntuneBrand>("intuneBrand"); }
            set { BackingStore?.Set("intuneBrand", value); }
        }
        /// <summary>Intune branding profiles targeted to AAD groups</summary>
        public List<Microsoft.Graph.Beta.Models.IntuneBrandingProfile> IntuneBrandingProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IntuneBrandingProfile>>("intuneBrandingProfiles"); }
            set { BackingStore?.Set("intuneBrandingProfiles", value); }
        }
        /// <summary>The IOS software update installation statuses for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.IosUpdateDeviceStatus> IosUpdateStatuses {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IosUpdateDeviceStatus>>("iosUpdateStatuses"); }
            set { BackingStore?.Set("iosUpdateStatuses", value); }
        }
        /// <summary>The last modified time of reporting for this account. This property is read-only.</summary>
        public DateTimeOffset? LastReportAggregationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastReportAggregationDateTime"); }
            set { BackingStore?.Set("lastReportAggregationDateTime", value); }
        }
        /// <summary>The property to enable Non-MDM managed legacy PC management for this account. This property is read-only.</summary>
        public bool? LegacyPcManangementEnabled {
            get { return BackingStore?.Get<bool?>("legacyPcManangementEnabled"); }
            set { BackingStore?.Set("legacyPcManangementEnabled", value); }
        }
        /// <summary>The MacOS software update account summaries for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateAccountSummary> MacOSSoftwareUpdateAccountSummaries {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateAccountSummary>>("macOSSoftwareUpdateAccountSummaries"); }
            set { BackingStore?.Set("macOSSoftwareUpdateAccountSummaries", value); }
        }
        /// <summary>Device cleanup rule</summary>
        public Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings ManagedDeviceCleanupSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings>("managedDeviceCleanupSettings"); }
            set { BackingStore?.Set("managedDeviceCleanupSettings", value); }
        }
        /// <summary>Encryption report for devices in this account</summary>
        public List<Microsoft.Graph.Beta.Models.ManagedDeviceEncryptionState> ManagedDeviceEncryptionStates {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ManagedDeviceEncryptionState>>("managedDeviceEncryptionStates"); }
            set { BackingStore?.Set("managedDeviceEncryptionStates", value); }
        }
        /// <summary>Device overview</summary>
        public Microsoft.Graph.Beta.Models.ManagedDeviceOverview ManagedDeviceOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDeviceOverview>("managedDeviceOverview"); }
            set { BackingStore?.Set("managedDeviceOverview", value); }
        }
        /// <summary>The list of managed devices.</summary>
        public List<Microsoft.Graph.Beta.Models.ManagedDevice> ManagedDevices {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ManagedDevice>>("managedDevices"); }
            set { BackingStore?.Set("managedDevices", value); }
        }
        /// <summary>Maximum number of DEP tokens allowed per-tenant.</summary>
        public int? MaximumDepTokens {
            get { return BackingStore?.Get<int?>("maximumDepTokens"); }
            set { BackingStore?.Set("maximumDepTokens", value); }
        }
        /// <summary>Collection of MicrosoftTunnelConfiguration settings associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration> MicrosoftTunnelConfigurations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>>("microsoftTunnelConfigurations"); }
            set { BackingStore?.Set("microsoftTunnelConfigurations", value); }
        }
        /// <summary>Collection of MicrosoftTunnelHealthThreshold settings associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.MicrosoftTunnelHealthThreshold> MicrosoftTunnelHealthThresholds {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MicrosoftTunnelHealthThreshold>>("microsoftTunnelHealthThresholds"); }
            set { BackingStore?.Set("microsoftTunnelHealthThresholds", value); }
        }
        /// <summary>Collection of MicrosoftTunnelServerLogCollectionResponse settings associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.MicrosoftTunnelServerLogCollectionResponse> MicrosoftTunnelServerLogCollectionResponses {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MicrosoftTunnelServerLogCollectionResponse>>("microsoftTunnelServerLogCollectionResponses"); }
            set { BackingStore?.Set("microsoftTunnelServerLogCollectionResponses", value); }
        }
        /// <summary>Collection of MicrosoftTunnelSite settings associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.MicrosoftTunnelSite> MicrosoftTunnelSites {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MicrosoftTunnelSite>>("microsoftTunnelSites"); }
            set { BackingStore?.Set("microsoftTunnelSites", value); }
        }
        /// <summary>The collection property of MobileAppTroubleshootingEvent.</summary>
        public List<Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent> MobileAppTroubleshootingEvents {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent>>("mobileAppTroubleshootingEvents"); }
            set { BackingStore?.Set("mobileAppTroubleshootingEvents", value); }
        }
        /// <summary>The list of Mobile threat Defense connectors configured by the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.MobileThreatDefenseConnector> MobileThreatDefenseConnectors {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MobileThreatDefenseConnector>>("mobileThreatDefenseConnectors"); }
            set { BackingStore?.Set("mobileThreatDefenseConnectors", value); }
        }
        /// <summary>The monitoring property</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.Monitoring Monitoring {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.Monitoring>("monitoring"); }
            set { BackingStore?.Set("monitoring", value); }
        }
        /// <summary>The collection of Ndes connectors for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.NdesConnector> NdesConnectors {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.NdesConnector>>("ndesConnectors"); }
            set { BackingStore?.Set("ndesConnectors", value); }
        }
        /// <summary>The Notification Message Templates.</summary>
        public List<Microsoft.Graph.Beta.Models.NotificationMessageTemplate> NotificationMessageTemplates {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.NotificationMessageTemplate>>("notificationMessageTemplates"); }
            set { BackingStore?.Set("notificationMessageTemplates", value); }
        }
        /// <summary>List of OEM Warranty Statuses</summary>
        public List<Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding> OemWarrantyInformationOnboarding {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding>>("oemWarrantyInformationOnboarding"); }
            set { BackingStore?.Set("oemWarrantyInformationOnboarding", value); }
        }
        /// <summary>The list of device remote action audits with the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.RemoteActionAudit> RemoteActionAudits {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RemoteActionAudit>>("remoteActionAudits"); }
            set { BackingStore?.Set("remoteActionAudits", value); }
        }
        /// <summary>The remote assist partners.</summary>
        public List<Microsoft.Graph.Beta.Models.RemoteAssistancePartner> RemoteAssistancePartners {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RemoteAssistancePartner>>("remoteAssistancePartners"); }
            set { BackingStore?.Set("remoteAssistancePartners", value); }
        }
        /// <summary>The remote assistance settings singleton</summary>
        public Microsoft.Graph.Beta.Models.RemoteAssistanceSettings RemoteAssistanceSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RemoteAssistanceSettings>("remoteAssistanceSettings"); }
            set { BackingStore?.Set("remoteAssistanceSettings", value); }
        }
        /// <summary>Reports singleton</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementReports Reports {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementReports>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
        /// <summary>Collection of resource access settings associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementResourceAccessProfileBase> ResourceAccessProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementResourceAccessProfileBase>>("resourceAccessProfiles"); }
            set { BackingStore?.Set("resourceAccessProfiles", value); }
        }
        /// <summary>The Resource Operations.</summary>
        public List<Microsoft.Graph.Beta.Models.ResourceOperation> ResourceOperations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ResourceOperation>>("resourceOperations"); }
            set { BackingStore?.Set("resourceOperations", value); }
        }
        /// <summary>List of all reusable settings that can be referred in a policy</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementReusablePolicySetting> ReusablePolicySettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementReusablePolicySetting>>("reusablePolicySettings"); }
            set { BackingStore?.Set("reusablePolicySettings", value); }
        }
        /// <summary>List of all reusable settings</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition> ReusableSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>>("reusableSettings"); }
            set { BackingStore?.Set("reusableSettings", value); }
        }
        /// <summary>The Role Assignments.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceAndAppManagementRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceAndAppManagementRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
        /// <summary>The Role Definitions.</summary>
        public List<Microsoft.Graph.Beta.Models.RoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
        /// <summary>The Role Scope Tags.</summary>
        public List<Microsoft.Graph.Beta.Models.RoleScopeTag> RoleScopeTags {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RoleScopeTag>>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
        /// <summary>The device management intent setting definitions</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition> SettingDefinitions {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition>>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
        /// <summary>Account level settings.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementSettings Settings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
        /// <summary>The software update status summary.</summary>
        public Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary"); }
            set { BackingStore?.Set("softwareUpdateStatusSummary", value); }
        }
        /// <summary>Tenant mobile device management subscriptions.</summary>
        public DeviceManagementSubscriptions? Subscriptions {
            get { return BackingStore?.Get<DeviceManagementSubscriptions?>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
        /// <summary>Tenant mobile device management subscription state.</summary>
        public DeviceManagementSubscriptionState? SubscriptionState {
            get { return BackingStore?.Get<DeviceManagementSubscriptionState?>("subscriptionState"); }
            set { BackingStore?.Set("subscriptionState", value); }
        }
        /// <summary>The telecom expense management partners.</summary>
        public List<Microsoft.Graph.Beta.Models.TelecomExpenseManagementPartner> TelecomExpenseManagementPartners {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TelecomExpenseManagementPartner>>("telecomExpenseManagementPartners"); }
            set { BackingStore?.Set("telecomExpenseManagementPartners", value); }
        }
        /// <summary>The available templates</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementTemplate> Templates {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementTemplate>>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
        /// <summary>List of all TemplateSettings</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingTemplate> TemplateSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingTemplate>>("templateSettings"); }
            set { BackingStore?.Set("templateSettings", value); }
        }
        /// <summary>TenantAttach RBAC Enablement</summary>
        public Microsoft.Graph.Beta.Models.TenantAttachRBAC TenantAttachRBAC {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAttachRBAC>("tenantAttachRBAC"); }
            set { BackingStore?.Set("tenantAttachRBAC", value); }
        }
        /// <summary>The terms and conditions associated with device management of the company.</summary>
        public List<Microsoft.Graph.Beta.Models.TermsAndConditions> TermsAndConditions {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TermsAndConditions>>("termsAndConditions"); }
            set { BackingStore?.Set("termsAndConditions", value); }
        }
        /// <summary>The list of troubleshooting events for the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent> TroubleshootingEvents {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent>>("troubleshootingEvents"); }
            set { BackingStore?.Set("troubleshootingEvents", value); }
        }
        /// <summary>When enabled, users assigned as administrators via Role Assignment Memberships do not require an assigned Intune license. Prior to this, only Intune licensed users were granted permissions with an Intune role unless they were assigned a role via Azure Active Directory. You are limited to 350 unlicensed direct members for each AAD security group in a role assignment, but you can assign multiple AAD security groups to a role if you need to support more than 350 unlicensed administrators. Licensed administrators are unaffected, do not have to be direct members, nor does the 350 member limit apply. This property is read-only.</summary>
        public bool? UnlicensedAdminstratorsEnabled {
            get { return BackingStore?.Get<bool?>("unlicensedAdminstratorsEnabled"); }
            set { BackingStore?.Set("unlicensedAdminstratorsEnabled", value); }
        }
        /// <summary>The user experience analytics anomaly entity contains anomaly details.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomaly> UserExperienceAnalyticsAnomaly {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomaly>>("userExperienceAnalyticsAnomaly"); }
            set { BackingStore?.Set("userExperienceAnalyticsAnomaly", value); }
        }
        /// <summary>The user experience analytics anomaly entity contains device details.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyDevice> UserExperienceAnalyticsAnomalyDevice {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyDevice>>("userExperienceAnalyticsAnomalyDevice"); }
            set { BackingStore?.Set("userExperienceAnalyticsAnomalyDevice", value); }
        }
        /// <summary>The user experience analytics anomaly severity overview entity contains the count information for each severity of anomaly.</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalySeverityOverview UserExperienceAnalyticsAnomalySeverityOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalySeverityOverview>("userExperienceAnalyticsAnomalySeverityOverview"); }
            set { BackingStore?.Set("userExperienceAnalyticsAnomalySeverityOverview", value); }
        }
        /// <summary>User experience analytics appHealth Application Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance> UserExperienceAnalyticsAppHealthApplicationPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>>("userExperienceAnalyticsAppHealthApplicationPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformance", value); }
        }
        /// <summary>User experience analytics appHealth Application Performance by App Version</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion", value); }
        }
        /// <summary>User experience analytics appHealth Application Performance by App Version details</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", value); }
        }
        /// <summary>User experience analytics appHealth Application Performance by App Version Device Id</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", value); }
        }
        /// <summary>User experience analytics appHealth Application Performance by OS Version</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion> UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>>("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", value); }
        }
        /// <summary>User experience analytics appHealth Model Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance> UserExperienceAnalyticsAppHealthDeviceModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>>("userExperienceAnalyticsAppHealthDeviceModelPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDeviceModelPerformance", value); }
        }
        /// <summary>User experience analytics appHealth Device Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance> UserExperienceAnalyticsAppHealthDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance>>("userExperienceAnalyticsAppHealthDevicePerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDevicePerformance", value); }
        }
        /// <summary>User experience analytics device performance details</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails> UserExperienceAnalyticsAppHealthDevicePerformanceDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>>("userExperienceAnalyticsAppHealthDevicePerformanceDetails"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDevicePerformanceDetails", value); }
        }
        /// <summary>User experience analytics appHealth OS version Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance> UserExperienceAnalyticsAppHealthOSVersionPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>>("userExperienceAnalyticsAppHealthOSVersionPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthOSVersionPerformance", value); }
        }
        /// <summary>User experience analytics appHealth overview</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory UserExperienceAnalyticsAppHealthOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory>("userExperienceAnalyticsAppHealthOverview"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthOverview", value); }
        }
        /// <summary>User experience analytics baselines</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBaseline> UserExperienceAnalyticsBaselines {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBaseline>>("userExperienceAnalyticsBaselines"); }
            set { BackingStore?.Set("userExperienceAnalyticsBaselines", value); }
        }
        /// <summary>User Experience Analytics Battery Health App Impact</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact> UserExperienceAnalyticsBatteryHealthAppImpact {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact>>("userExperienceAnalyticsBatteryHealthAppImpact"); }
            set { BackingStore?.Set("userExperienceAnalyticsBatteryHealthAppImpact", value); }
        }
        /// <summary>User Experience Analytics Battery Health Capacity Details</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails UserExperienceAnalyticsBatteryHealthCapacityDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails>("userExperienceAnalyticsBatteryHealthCapacityDetails"); }
            set { BackingStore?.Set("userExperienceAnalyticsBatteryHealthCapacityDetails", value); }
        }
        /// <summary>User Experience Analytics Battery Health Device App Impact</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact> UserExperienceAnalyticsBatteryHealthDeviceAppImpact {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact>>("userExperienceAnalyticsBatteryHealthDeviceAppImpact"); }
            set { BackingStore?.Set("userExperienceAnalyticsBatteryHealthDeviceAppImpact", value); }
        }
        /// <summary>User Experience Analytics Battery Health Device Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance> UserExperienceAnalyticsBatteryHealthDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance>>("userExperienceAnalyticsBatteryHealthDevicePerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsBatteryHealthDevicePerformance", value); }
        }
        /// <summary>User Experience Analytics Battery Health Device Runtime History</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory> UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory>>("userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory", value); }
        }
        /// <summary>User Experience Analytics Battery Health Model Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance> UserExperienceAnalyticsBatteryHealthModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance>>("userExperienceAnalyticsBatteryHealthModelPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsBatteryHealthModelPerformance", value); }
        }
        /// <summary>User Experience Analytics Battery Health Os Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance> UserExperienceAnalyticsBatteryHealthOsPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance>>("userExperienceAnalyticsBatteryHealthOsPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsBatteryHealthOsPerformance", value); }
        }
        /// <summary>User Experience Analytics Battery Health Runtime Details</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails UserExperienceAnalyticsBatteryHealthRuntimeDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails>("userExperienceAnalyticsBatteryHealthRuntimeDetails"); }
            set { BackingStore?.Set("userExperienceAnalyticsBatteryHealthRuntimeDetails", value); }
        }
        /// <summary>User experience analytics categories</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory> UserExperienceAnalyticsCategories {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory>>("userExperienceAnalyticsCategories"); }
            set { BackingStore?.Set("userExperienceAnalyticsCategories", value); }
        }
        /// <summary>User experience analytics device metric history</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory> UserExperienceAnalyticsDeviceMetricHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>>("userExperienceAnalyticsDeviceMetricHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceMetricHistory", value); }
        }
        /// <summary>User experience analytics device performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance> UserExperienceAnalyticsDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance>>("userExperienceAnalyticsDevicePerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsDevicePerformance", value); }
        }
        /// <summary>The user experience analytics device scope entity endpoint to trigger on the service to either START or STOP computing metrics data based on a device scope configuration.</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope UserExperienceAnalyticsDeviceScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>("userExperienceAnalyticsDeviceScope"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceScope", value); }
        }
        /// <summary>The user experience analytics device scope entity contains device scope configuration use to apply filtering on the endpoint analytics reports.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope> UserExperienceAnalyticsDeviceScopes {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>>("userExperienceAnalyticsDeviceScopes"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceScopes", value); }
        }
        /// <summary>User experience analytics device scores</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores> UserExperienceAnalyticsDeviceScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores>>("userExperienceAnalyticsDeviceScores"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceScores", value); }
        }
        /// <summary>User experience analytics device Startup History</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory> UserExperienceAnalyticsDeviceStartupHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory>>("userExperienceAnalyticsDeviceStartupHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceStartupHistory", value); }
        }
        /// <summary>User experience analytics device Startup Processes</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcess> UserExperienceAnalyticsDeviceStartupProcesses {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcess>>("userExperienceAnalyticsDeviceStartupProcesses"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceStartupProcesses", value); }
        }
        /// <summary>User experience analytics device Startup Process Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance> UserExperienceAnalyticsDeviceStartupProcessPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance>>("userExperienceAnalyticsDeviceStartupProcessPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceStartupProcessPerformance", value); }
        }
        /// <summary>User experience analytics devices without cloud identity.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceWithoutCloudIdentity> UserExperienceAnalyticsDevicesWithoutCloudIdentity {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceWithoutCloudIdentity>>("userExperienceAnalyticsDevicesWithoutCloudIdentity"); }
            set { BackingStore?.Set("userExperienceAnalyticsDevicesWithoutCloudIdentity", value); }
        }
        /// <summary>The user experience analytics device events entity contains NRT device timeline events details.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceTimelineEvents> UserExperienceAnalyticsDeviceTimelineEvents {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceTimelineEvents>>("userExperienceAnalyticsDeviceTimelineEvents"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceTimelineEvents", value); }
        }
        /// <summary>User experience analytics impacting process</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess> UserExperienceAnalyticsImpactingProcess {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess>>("userExperienceAnalyticsImpactingProcess"); }
            set { BackingStore?.Set("userExperienceAnalyticsImpactingProcess", value); }
        }
        /// <summary>User experience analytics metric history</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory> UserExperienceAnalyticsMetricHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>>("userExperienceAnalyticsMetricHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsMetricHistory", value); }
        }
        /// <summary>User experience analytics model scores</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores> UserExperienceAnalyticsModelScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores>>("userExperienceAnalyticsModelScores"); }
            set { BackingStore?.Set("userExperienceAnalyticsModelScores", value); }
        }
        /// <summary>User experience analytics devices not Windows Autopilot ready.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice> UserExperienceAnalyticsNotAutopilotReadyDevice {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice>>("userExperienceAnalyticsNotAutopilotReadyDevice"); }
            set { BackingStore?.Set("userExperienceAnalyticsNotAutopilotReadyDevice", value); }
        }
        /// <summary>User experience analytics overview</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview UserExperienceAnalyticsOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview>("userExperienceAnalyticsOverview"); }
            set { BackingStore?.Set("userExperienceAnalyticsOverview", value); }
        }
        /// <summary>User experience analytics remote connection</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection> UserExperienceAnalyticsRemoteConnection {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection>>("userExperienceAnalyticsRemoteConnection"); }
            set { BackingStore?.Set("userExperienceAnalyticsRemoteConnection", value); }
        }
        /// <summary>User experience analytics resource performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance> UserExperienceAnalyticsResourcePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance>>("userExperienceAnalyticsResourcePerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsResourcePerformance", value); }
        }
        /// <summary>User experience analytics device Startup Score History</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory> UserExperienceAnalyticsScoreHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory>>("userExperienceAnalyticsScoreHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsScoreHistory", value); }
        }
        /// <summary>User experience analytics device settings</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings UserExperienceAnalyticsSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings>("userExperienceAnalyticsSettings"); }
            set { BackingStore?.Set("userExperienceAnalyticsSettings", value); }
        }
        /// <summary>User experience analytics work from anywhere hardware readiness metrics.</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", value); }
        }
        /// <summary>User experience analytics work from anywhere metrics.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereMetric> UserExperienceAnalyticsWorkFromAnywhereMetrics {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereMetric>>("userExperienceAnalyticsWorkFromAnywhereMetrics"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereMetrics", value); }
        }
        /// <summary>The user experience analytics work from anywhere model performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance> UserExperienceAnalyticsWorkFromAnywhereModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>>("userExperienceAnalyticsWorkFromAnywhereModelPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereModelPerformance", value); }
        }
        /// <summary>Collection of PFX certificates associated with a user.</summary>
        public List<Microsoft.Graph.Beta.Models.UserPFXCertificate> UserPfxCertificates {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserPFXCertificate>>("userPfxCertificates"); }
            set { BackingStore?.Set("userPfxCertificates", value); }
        }
        /// <summary>The virtualEndpoint property</summary>
        public Microsoft.Graph.Beta.Models.VirtualEndpoint VirtualEndpoint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VirtualEndpoint>("virtualEndpoint"); }
            set { BackingStore?.Set("virtualEndpoint", value); }
        }
        /// <summary>Windows auto pilot deployment profiles</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile> WindowsAutopilotDeploymentProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>>("windowsAutopilotDeploymentProfiles"); }
            set { BackingStore?.Set("windowsAutopilotDeploymentProfiles", value); }
        }
        /// <summary>The Windows autopilot device identities contained collection.</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity> WindowsAutopilotDeviceIdentities {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity>>("windowsAutopilotDeviceIdentities"); }
            set { BackingStore?.Set("windowsAutopilotDeviceIdentities", value); }
        }
        /// <summary>The Windows autopilot account settings.</summary>
        public Microsoft.Graph.Beta.Models.WindowsAutopilotSettings WindowsAutopilotSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotSettings>("windowsAutopilotSettings"); }
            set { BackingStore?.Set("windowsAutopilotSettings", value); }
        }
        /// <summary>A collection of windows driver update profiles</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsDriverUpdateProfile> WindowsDriverUpdateProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsDriverUpdateProfile>>("windowsDriverUpdateProfiles"); }
            set { BackingStore?.Set("windowsDriverUpdateProfiles", value); }
        }
        /// <summary>A collection of windows feature update profiles</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsFeatureUpdateProfile> WindowsFeatureUpdateProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsFeatureUpdateProfile>>("windowsFeatureUpdateProfiles"); }
            set { BackingStore?.Set("windowsFeatureUpdateProfiles", value); }
        }
        /// <summary>The windows information protection app learning summaries.</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsInformationProtectionAppLearningSummary> WindowsInformationProtectionAppLearningSummaries {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsInformationProtectionAppLearningSummary>>("windowsInformationProtectionAppLearningSummaries"); }
            set { BackingStore?.Set("windowsInformationProtectionAppLearningSummaries", value); }
        }
        /// <summary>The windows information protection network learning summaries.</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsInformationProtectionNetworkLearningSummary> WindowsInformationProtectionNetworkLearningSummaries {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsInformationProtectionNetworkLearningSummary>>("windowsInformationProtectionNetworkLearningSummaries"); }
            set { BackingStore?.Set("windowsInformationProtectionNetworkLearningSummaries", value); }
        }
        /// <summary>The list of affected malware in the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsMalwareInformation> WindowsMalwareInformation {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsMalwareInformation>>("windowsMalwareInformation"); }
            set { BackingStore?.Set("windowsMalwareInformation", value); }
        }
        /// <summary>Malware overview for windows devices.</summary>
        public Microsoft.Graph.Beta.Models.WindowsMalwareOverview WindowsMalwareOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsMalwareOverview>("windowsMalwareOverview"); }
            set { BackingStore?.Set("windowsMalwareOverview", value); }
        }
        /// <summary>A collection of windows quality update profiles</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsQualityUpdateProfile> WindowsQualityUpdateProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsQualityUpdateProfile>>("windowsQualityUpdateProfiles"); }
            set { BackingStore?.Set("windowsQualityUpdateProfiles", value); }
        }
        /// <summary>A collection of windows update catalog items (fetaure updates item , quality updates item)</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsUpdateCatalogItem> WindowsUpdateCatalogItems {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdateCatalogItem>>("windowsUpdateCatalogItems"); }
            set { BackingStore?.Set("windowsUpdateCatalogItems", value); }
        }
        /// <summary>The Collection of ZebraFotaArtifacts.</summary>
        public List<Microsoft.Graph.Beta.Models.ZebraFotaArtifact> ZebraFotaArtifacts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ZebraFotaArtifact>>("zebraFotaArtifacts"); }
            set { BackingStore?.Set("zebraFotaArtifacts", value); }
        }
        /// <summary>The singleton ZebraFotaConnector associated with account.</summary>
        public Microsoft.Graph.Beta.Models.ZebraFotaConnector ZebraFotaConnector {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ZebraFotaConnector>("zebraFotaConnector"); }
            set { BackingStore?.Set("zebraFotaConnector", value); }
        }
        /// <summary>Collection of ZebraFotaDeployments associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.ZebraFotaDeployment> ZebraFotaDeployments {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ZebraFotaDeployment>>("zebraFotaDeployments"); }
            set { BackingStore?.Set("zebraFotaDeployments", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountMoveCompletionDateTime", n => { AccountMoveCompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"adminConsent", n => { AdminConsent = n.GetObjectValue<Microsoft.Graph.Beta.Models.AdminConsent>(Microsoft.Graph.Beta.Models.AdminConsent.CreateFromDiscriminatorValue); } },
                {"advancedThreatProtectionOnboardingStateSummary", n => { AdvancedThreatProtectionOnboardingStateSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.AdvancedThreatProtectionOnboardingStateSummary>(Microsoft.Graph.Beta.Models.AdvancedThreatProtectionOnboardingStateSummary.CreateFromDiscriminatorValue); } },
                {"androidDeviceOwnerEnrollmentProfiles", n => { AndroidDeviceOwnerEnrollmentProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidDeviceOwnerEnrollmentProfile>(Microsoft.Graph.Beta.Models.AndroidDeviceOwnerEnrollmentProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"androidForWorkAppConfigurationSchemas", n => { AndroidForWorkAppConfigurationSchemas = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidForWorkAppConfigurationSchema>(Microsoft.Graph.Beta.Models.AndroidForWorkAppConfigurationSchema.CreateFromDiscriminatorValue)?.ToList(); } },
                {"androidForWorkEnrollmentProfiles", n => { AndroidForWorkEnrollmentProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidForWorkEnrollmentProfile>(Microsoft.Graph.Beta.Models.AndroidForWorkEnrollmentProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"androidForWorkSettings", n => { AndroidForWorkSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.AndroidForWorkSettings>(Microsoft.Graph.Beta.Models.AndroidForWorkSettings.CreateFromDiscriminatorValue); } },
                {"androidManagedStoreAccountEnterpriseSettings", n => { AndroidManagedStoreAccountEnterpriseSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>(Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings.CreateFromDiscriminatorValue); } },
                {"androidManagedStoreAppConfigurationSchemas", n => { AndroidManagedStoreAppConfigurationSchemas = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppConfigurationSchema>(Microsoft.Graph.Beta.Models.AndroidManagedStoreAppConfigurationSchema.CreateFromDiscriminatorValue)?.ToList(); } },
                {"applePushNotificationCertificate", n => { ApplePushNotificationCertificate = n.GetObjectValue<Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate>(Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate.CreateFromDiscriminatorValue); } },
                {"appleUserInitiatedEnrollmentProfiles", n => { AppleUserInitiatedEnrollmentProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AppleUserInitiatedEnrollmentProfile>(Microsoft.Graph.Beta.Models.AppleUserInitiatedEnrollmentProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentFilters", n => { AssignmentFilters = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter>(Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuditEvent>(Microsoft.Graph.Beta.Models.AuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"autopilotEvents", n => { AutopilotEvents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementAutopilotEvent>(Microsoft.Graph.Beta.Models.DeviceManagementAutopilotEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cartToClassAssociations", n => { CartToClassAssociations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CartToClassAssociation>(Microsoft.Graph.Beta.Models.CartToClassAssociation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementSettingCategory>(Microsoft.Graph.Beta.Models.DeviceManagementSettingCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"certificateConnectorDetails", n => { CertificateConnectorDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CertificateConnectorDetails>(Microsoft.Graph.Beta.Models.CertificateConnectorDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"chromeOSOnboardingSettings", n => { ChromeOSOnboardingSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings>(Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPCConnectivityIssues", n => { CloudPCConnectivityIssues = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CloudPCConnectivityIssue>(Microsoft.Graph.Beta.Models.CloudPCConnectivityIssue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"comanagedDevices", n => { ComanagedDevices = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedDevice>(Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"comanagementEligibleDevices", n => { ComanagementEligibleDevices = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ComanagementEligibleDevice>(Microsoft.Graph.Beta.Models.ComanagementEligibleDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"complianceCategories", n => { ComplianceCategories = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"complianceManagementPartners", n => { ComplianceManagementPartners = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ComplianceManagementPartner>(Microsoft.Graph.Beta.Models.ComplianceManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"compliancePolicies", n => { CompliancePolicies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy>(Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"complianceSettings", n => { ComplianceSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccessSettings", n => { ConditionalAccessSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.OnPremisesConditionalAccessSettings>(Microsoft.Graph.Beta.Models.OnPremisesConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                {"configManagerCollections", n => { ConfigManagerCollections = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConfigManagerCollection>(Microsoft.Graph.Beta.Models.ConfigManagerCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"configurationCategories", n => { ConfigurationCategories = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"configurationPolicies", n => { ConfigurationPolicies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicy>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"configurationPolicyTemplates", n => { ConfigurationPolicyTemplates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicyTemplate>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicyTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"configurationSettings", n => { ConfigurationSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dataProcessorServiceForWindowsFeaturesOnboarding", n => { DataProcessorServiceForWindowsFeaturesOnboarding = n.GetObjectValue<Microsoft.Graph.Beta.Models.DataProcessorServiceForWindowsFeaturesOnboarding>(Microsoft.Graph.Beta.Models.DataProcessorServiceForWindowsFeaturesOnboarding.CreateFromDiscriminatorValue); } },
                {"dataSharingConsents", n => { DataSharingConsents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DataSharingConsent>(Microsoft.Graph.Beta.Models.DataSharingConsent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"depOnboardingSettings", n => { DepOnboardingSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DepOnboardingSetting>(Microsoft.Graph.Beta.Models.DepOnboardingSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"derivedCredentials", n => { DerivedCredentials = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>(Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue)?.ToList(); } },
                {"detectedApps", n => { DetectedApps = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DetectedApp>(Microsoft.Graph.Beta.Models.DetectedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCategories", n => { DeviceCategories = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceCategory>(Microsoft.Graph.Beta.Models.DeviceCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicies", n => { DeviceCompliancePolicies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceCompliancePolicy>(Microsoft.Graph.Beta.Models.DeviceCompliancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicyDeviceStateSummary", n => { DeviceCompliancePolicyDeviceStateSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary>(Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceCompliancePolicySettingStateSummary>(Microsoft.Graph.Beta.Models.DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceComplianceReportSummarizationDateTime", n => { DeviceComplianceReportSummarizationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceComplianceScripts", n => { DeviceComplianceScripts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceComplianceScript>(Microsoft.Graph.Beta.Models.DeviceComplianceScript.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationConflictSummary", n => { DeviceConfigurationConflictSummary = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary>(Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationDeviceStateSummaries", n => { DeviceConfigurationDeviceStateSummaries = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceConfigurationDeviceStateSummary>(Microsoft.Graph.Beta.Models.DeviceConfigurationDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceConfigurationRestrictedAppsViolations", n => { DeviceConfigurationRestrictedAppsViolations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RestrictedAppsViolation>(Microsoft.Graph.Beta.Models.RestrictedAppsViolation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurations", n => { DeviceConfigurations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceConfiguration>(Microsoft.Graph.Beta.Models.DeviceConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationsAllManagedDeviceCertificateStates", n => { DeviceConfigurationsAllManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedAllDeviceCertificateState>(Microsoft.Graph.Beta.Models.ManagedAllDeviceCertificateState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationUserStateSummaries", n => { DeviceConfigurationUserStateSummaries = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceConfigurationUserStateSummary>(Microsoft.Graph.Beta.Models.DeviceConfigurationUserStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceCustomAttributeShellScripts", n => { DeviceCustomAttributeShellScripts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceCustomAttributeShellScript>(Microsoft.Graph.Beta.Models.DeviceCustomAttributeShellScript.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceEnrollmentConfigurations", n => { DeviceEnrollmentConfigurations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceEnrollmentConfiguration>(Microsoft.Graph.Beta.Models.DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceHealthScripts", n => { DeviceHealthScripts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceHealthScript>(Microsoft.Graph.Beta.Models.DeviceHealthScript.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceManagementPartners", n => { DeviceManagementPartners = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementPartner>(Microsoft.Graph.Beta.Models.DeviceManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceManagementScripts", n => { DeviceManagementScripts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementScript>(Microsoft.Graph.Beta.Models.DeviceManagementScript.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceProtectionOverview", n => { DeviceProtectionOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceProtectionOverview>(Microsoft.Graph.Beta.Models.DeviceProtectionOverview.CreateFromDiscriminatorValue); } },
                {"deviceShellScripts", n => { DeviceShellScripts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceShellScript>(Microsoft.Graph.Beta.Models.DeviceShellScript.CreateFromDiscriminatorValue)?.ToList(); } },
                {"domainJoinConnectors", n => { DomainJoinConnectors = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementDomainJoinConnector>(Microsoft.Graph.Beta.Models.DeviceManagementDomainJoinConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"embeddedSIMActivationCodePools", n => { EmbeddedSIMActivationCodePools = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.EmbeddedSIMActivationCodePool>(Microsoft.Graph.Beta.Models.EmbeddedSIMActivationCodePool.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exchangeConnectors", n => { ExchangeConnectors = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnector>(Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exchangeOnPremisesPolicies", n => { ExchangeOnPremisesPolicies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy>(Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exchangeOnPremisesPolicy", n => { ExchangeOnPremisesPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy>(Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy.CreateFromDiscriminatorValue); } },
                {"groupPolicyCategories", n => { GroupPolicyCategories = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyCategory>(Microsoft.Graph.Beta.Models.GroupPolicyCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupPolicyConfigurations", n => { GroupPolicyConfigurations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyConfiguration>(Microsoft.Graph.Beta.Models.GroupPolicyConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupPolicyDefinitionFiles", n => { GroupPolicyDefinitionFiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile>(Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupPolicyDefinitions", n => { GroupPolicyDefinitions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyDefinition>(Microsoft.Graph.Beta.Models.GroupPolicyDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupPolicyMigrationReports", n => { GroupPolicyMigrationReports = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport>(Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupPolicyObjectFiles", n => { GroupPolicyObjectFiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyObjectFile>(Microsoft.Graph.Beta.Models.GroupPolicyObjectFile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupPolicyUploadedDefinitionFiles", n => { GroupPolicyUploadedDefinitionFiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyUploadedDefinitionFile>(Microsoft.Graph.Beta.Models.GroupPolicyUploadedDefinitionFile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"importedDeviceIdentities", n => { ImportedDeviceIdentities = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ImportedDeviceIdentity>(Microsoft.Graph.Beta.Models.ImportedDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"importedWindowsAutopilotDeviceIdentities", n => { ImportedWindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentity>(Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intents", n => { Intents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntent>(Microsoft.Graph.Beta.Models.DeviceManagementIntent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intuneAccountId", n => { IntuneAccountId = n.GetGuidValue(); } },
                {"intuneBrand", n => { IntuneBrand = n.GetObjectValue<Microsoft.Graph.Beta.Models.IntuneBrand>(Microsoft.Graph.Beta.Models.IntuneBrand.CreateFromDiscriminatorValue); } },
                {"intuneBrandingProfiles", n => { IntuneBrandingProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IntuneBrandingProfile>(Microsoft.Graph.Beta.Models.IntuneBrandingProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"iosUpdateStatuses", n => { IosUpdateStatuses = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IosUpdateDeviceStatus>(Microsoft.Graph.Beta.Models.IosUpdateDeviceStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastReportAggregationDateTime", n => { LastReportAggregationDateTime = n.GetDateTimeOffsetValue(); } },
                {"legacyPcManangementEnabled", n => { LegacyPcManangementEnabled = n.GetBoolValue(); } },
                {"macOSSoftwareUpdateAccountSummaries", n => { MacOSSoftwareUpdateAccountSummaries = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateAccountSummary>(Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateAccountSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceCleanupSettings", n => { ManagedDeviceCleanupSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings>(Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings.CreateFromDiscriminatorValue); } },
                {"managedDeviceEncryptionStates", n => { ManagedDeviceEncryptionStates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedDeviceEncryptionState>(Microsoft.Graph.Beta.Models.ManagedDeviceEncryptionState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceOverview", n => { ManagedDeviceOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceOverview>(Microsoft.Graph.Beta.Models.ManagedDeviceOverview.CreateFromDiscriminatorValue); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedDevice>(Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"maximumDepTokens", n => { MaximumDepTokens = n.GetIntValue(); } },
                {"microsoftTunnelConfigurations", n => { MicrosoftTunnelConfigurations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>(Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"microsoftTunnelHealthThresholds", n => { MicrosoftTunnelHealthThresholds = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftTunnelHealthThreshold>(Microsoft.Graph.Beta.Models.MicrosoftTunnelHealthThreshold.CreateFromDiscriminatorValue)?.ToList(); } },
                {"microsoftTunnelServerLogCollectionResponses", n => { MicrosoftTunnelServerLogCollectionResponses = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftTunnelServerLogCollectionResponse>(Microsoft.Graph.Beta.Models.MicrosoftTunnelServerLogCollectionResponse.CreateFromDiscriminatorValue)?.ToList(); } },
                {"microsoftTunnelSites", n => { MicrosoftTunnelSites = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftTunnelSite>(Microsoft.Graph.Beta.Models.MicrosoftTunnelSite.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileAppTroubleshootingEvents", n => { MobileAppTroubleshootingEvents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent>(Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileThreatDefenseConnectors", n => { MobileThreatDefenseConnectors = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MobileThreatDefenseConnector>(Microsoft.Graph.Beta.Models.MobileThreatDefenseConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"monitoring", n => { Monitoring = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagement.Monitoring>(Microsoft.Graph.Beta.Models.DeviceManagement.Monitoring.CreateFromDiscriminatorValue); } },
                {"ndesConnectors", n => { NdesConnectors = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.NdesConnector>(Microsoft.Graph.Beta.Models.NdesConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"notificationMessageTemplates", n => { NotificationMessageTemplates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.NotificationMessageTemplate>(Microsoft.Graph.Beta.Models.NotificationMessageTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"oemWarrantyInformationOnboarding", n => { OemWarrantyInformationOnboarding = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding>(Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding.CreateFromDiscriminatorValue)?.ToList(); } },
                {"remoteActionAudits", n => { RemoteActionAudits = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RemoteActionAudit>(Microsoft.Graph.Beta.Models.RemoteActionAudit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"remoteAssistancePartners", n => { RemoteAssistancePartners = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RemoteAssistancePartner>(Microsoft.Graph.Beta.Models.RemoteAssistancePartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"remoteAssistanceSettings", n => { RemoteAssistanceSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.RemoteAssistanceSettings>(Microsoft.Graph.Beta.Models.RemoteAssistanceSettings.CreateFromDiscriminatorValue); } },
                {"reports", n => { Reports = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementReports>(Microsoft.Graph.Beta.Models.DeviceManagementReports.CreateFromDiscriminatorValue); } },
                {"resourceAccessProfiles", n => { ResourceAccessProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementResourceAccessProfileBase>(Microsoft.Graph.Beta.Models.DeviceManagementResourceAccessProfileBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resourceOperations", n => { ResourceOperations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ResourceOperation>(Microsoft.Graph.Beta.Models.ResourceOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reusablePolicySettings", n => { ReusablePolicySettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementReusablePolicySetting>(Microsoft.Graph.Beta.Models.DeviceManagementReusablePolicySetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reusableSettings", n => { ReusableSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceAndAppManagementRoleAssignment>(Microsoft.Graph.Beta.Models.DeviceAndAppManagementRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RoleDefinition>(Microsoft.Graph.Beta.Models.RoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleScopeTags", n => { RoleScopeTags = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RoleScopeTag>(Microsoft.Graph.Beta.Models.RoleScopeTag.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settingDefinitions", n => { SettingDefinitions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition>(Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementSettings>(Microsoft.Graph.Beta.Models.DeviceManagementSettings.CreateFromDiscriminatorValue); } },
                {"softwareUpdateStatusSummary", n => { SoftwareUpdateStatusSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary>(Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { Subscriptions = n.GetEnumValue<DeviceManagementSubscriptions>(); } },
                {"subscriptionState", n => { SubscriptionState = n.GetEnumValue<DeviceManagementSubscriptionState>(); } },
                {"telecomExpenseManagementPartners", n => { TelecomExpenseManagementPartners = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TelecomExpenseManagementPartner>(Microsoft.Graph.Beta.Models.TelecomExpenseManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templates", n => { Templates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementTemplate>(Microsoft.Graph.Beta.Models.DeviceManagementTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templateSettings", n => { TemplateSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingTemplate>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantAttachRBAC", n => { TenantAttachRBAC = n.GetObjectValue<Microsoft.Graph.Beta.Models.TenantAttachRBAC>(Microsoft.Graph.Beta.Models.TenantAttachRBAC.CreateFromDiscriminatorValue); } },
                {"termsAndConditions", n => { TermsAndConditions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TermsAndConditions>(Microsoft.Graph.Beta.Models.TermsAndConditions.CreateFromDiscriminatorValue)?.ToList(); } },
                {"troubleshootingEvents", n => { TroubleshootingEvents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent>(Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"unlicensedAdminstratorsEnabled", n => { UnlicensedAdminstratorsEnabled = n.GetBoolValue(); } },
                {"userExperienceAnalyticsAnomaly", n => { UserExperienceAnalyticsAnomaly = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomaly>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomaly.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAnomalyDevice", n => { UserExperienceAnalyticsAnomalyDevice = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyDevice>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAnomalySeverityOverview", n => { UserExperienceAnalyticsAnomalySeverityOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalySeverityOverview>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalySeverityOverview.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformance", n => { UserExperienceAnalyticsAppHealthApplicationPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDeviceModelPerformance", n => { UserExperienceAnalyticsAppHealthDeviceModelPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformance", n => { UserExperienceAnalyticsAppHealthDevicePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformanceDetails", n => { UserExperienceAnalyticsAppHealthDevicePerformanceDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthOSVersionPerformance", n => { UserExperienceAnalyticsAppHealthOSVersionPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthOverview", n => { UserExperienceAnalyticsAppHealthOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsBaselines", n => { UserExperienceAnalyticsBaselines = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBaseline>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBaseline.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsBatteryHealthAppImpact", n => { UserExperienceAnalyticsBatteryHealthAppImpact = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsBatteryHealthCapacityDetails", n => { UserExperienceAnalyticsBatteryHealthCapacityDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsBatteryHealthDeviceAppImpact", n => { UserExperienceAnalyticsBatteryHealthDeviceAppImpact = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsBatteryHealthDevicePerformance", n => { UserExperienceAnalyticsBatteryHealthDevicePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory", n => { UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsBatteryHealthModelPerformance", n => { UserExperienceAnalyticsBatteryHealthModelPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsBatteryHealthOsPerformance", n => { UserExperienceAnalyticsBatteryHealthOsPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsBatteryHealthRuntimeDetails", n => { UserExperienceAnalyticsBatteryHealthRuntimeDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsCategories", n => { UserExperienceAnalyticsCategories = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceMetricHistory", n => { UserExperienceAnalyticsDeviceMetricHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDevicePerformance", n => { UserExperienceAnalyticsDevicePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceScope", n => { UserExperienceAnalyticsDeviceScope = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsDeviceScopes", n => { UserExperienceAnalyticsDeviceScopes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceScores", n => { UserExperienceAnalyticsDeviceScores = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceStartupHistory", n => { UserExperienceAnalyticsDeviceStartupHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceStartupProcesses", n => { UserExperienceAnalyticsDeviceStartupProcesses = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcess>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcess.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceStartupProcessPerformance", n => { UserExperienceAnalyticsDeviceStartupProcessPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDevicesWithoutCloudIdentity", n => { UserExperienceAnalyticsDevicesWithoutCloudIdentity = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceWithoutCloudIdentity>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceWithoutCloudIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceTimelineEvents", n => { UserExperienceAnalyticsDeviceTimelineEvents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceTimelineEvents>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceTimelineEvents.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsImpactingProcess", n => { UserExperienceAnalyticsImpactingProcess = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsMetricHistory", n => { UserExperienceAnalyticsMetricHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsModelScores", n => { UserExperienceAnalyticsModelScores = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsNotAutopilotReadyDevice", n => { UserExperienceAnalyticsNotAutopilotReadyDevice = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsOverview", n => { UserExperienceAnalyticsOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsRemoteConnection", n => { UserExperienceAnalyticsRemoteConnection = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsResourcePerformance", n => { UserExperienceAnalyticsResourcePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsScoreHistory", n => { UserExperienceAnalyticsScoreHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsSettings", n => { UserExperienceAnalyticsSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", n => { UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsWorkFromAnywhereMetrics", n => { UserExperienceAnalyticsWorkFromAnywhereMetrics = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereMetric>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereMetric.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsWorkFromAnywhereModelPerformance", n => { UserExperienceAnalyticsWorkFromAnywhereModelPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userPfxCertificates", n => { UserPfxCertificates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserPFXCertificate>(Microsoft.Graph.Beta.Models.UserPFXCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"virtualEndpoint", n => { VirtualEndpoint = n.GetObjectValue<Microsoft.Graph.Beta.Models.VirtualEndpoint>(Microsoft.Graph.Beta.Models.VirtualEndpoint.CreateFromDiscriminatorValue); } },
                {"windowsAutopilotDeploymentProfiles", n => { WindowsAutopilotDeploymentProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>(Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsAutopilotDeviceIdentities", n => { WindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity>(Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsAutopilotSettings", n => { WindowsAutopilotSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsAutopilotSettings>(Microsoft.Graph.Beta.Models.WindowsAutopilotSettings.CreateFromDiscriminatorValue); } },
                {"windowsDriverUpdateProfiles", n => { WindowsDriverUpdateProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsDriverUpdateProfile>(Microsoft.Graph.Beta.Models.WindowsDriverUpdateProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsFeatureUpdateProfiles", n => { WindowsFeatureUpdateProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsFeatureUpdateProfile>(Microsoft.Graph.Beta.Models.WindowsFeatureUpdateProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionAppLearningSummaries", n => { WindowsInformationProtectionAppLearningSummaries = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsInformationProtectionAppLearningSummary>(Microsoft.Graph.Beta.Models.WindowsInformationProtectionAppLearningSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionNetworkLearningSummaries", n => { WindowsInformationProtectionNetworkLearningSummaries = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsInformationProtectionNetworkLearningSummary>(Microsoft.Graph.Beta.Models.WindowsInformationProtectionNetworkLearningSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsMalwareInformation", n => { WindowsMalwareInformation = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsMalwareInformation>(Microsoft.Graph.Beta.Models.WindowsMalwareInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsMalwareOverview", n => { WindowsMalwareOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsMalwareOverview>(Microsoft.Graph.Beta.Models.WindowsMalwareOverview.CreateFromDiscriminatorValue); } },
                {"windowsQualityUpdateProfiles", n => { WindowsQualityUpdateProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsQualityUpdateProfile>(Microsoft.Graph.Beta.Models.WindowsQualityUpdateProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsUpdateCatalogItems", n => { WindowsUpdateCatalogItems = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdateCatalogItem>(Microsoft.Graph.Beta.Models.WindowsUpdateCatalogItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"zebraFotaArtifacts", n => { ZebraFotaArtifacts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ZebraFotaArtifact>(Microsoft.Graph.Beta.Models.ZebraFotaArtifact.CreateFromDiscriminatorValue)?.ToList(); } },
                {"zebraFotaConnector", n => { ZebraFotaConnector = n.GetObjectValue<Microsoft.Graph.Beta.Models.ZebraFotaConnector>(Microsoft.Graph.Beta.Models.ZebraFotaConnector.CreateFromDiscriminatorValue); } },
                {"zebraFotaDeployments", n => { ZebraFotaDeployments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ZebraFotaDeployment>(Microsoft.Graph.Beta.Models.ZebraFotaDeployment.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("accountMoveCompletionDateTime", AccountMoveCompletionDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AdminConsent>("adminConsent", AdminConsent);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AdvancedThreatProtectionOnboardingStateSummary>("advancedThreatProtectionOnboardingStateSummary", AdvancedThreatProtectionOnboardingStateSummary);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidDeviceOwnerEnrollmentProfile>("androidDeviceOwnerEnrollmentProfiles", AndroidDeviceOwnerEnrollmentProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidForWorkAppConfigurationSchema>("androidForWorkAppConfigurationSchemas", AndroidForWorkAppConfigurationSchemas);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidForWorkEnrollmentProfile>("androidForWorkEnrollmentProfiles", AndroidForWorkEnrollmentProfiles);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AndroidForWorkSettings>("androidForWorkSettings", AndroidForWorkSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>("androidManagedStoreAccountEnterpriseSettings", AndroidManagedStoreAccountEnterpriseSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppConfigurationSchema>("androidManagedStoreAppConfigurationSchemas", AndroidManagedStoreAppConfigurationSchemas);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate>("applePushNotificationCertificate", ApplePushNotificationCertificate);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AppleUserInitiatedEnrollmentProfile>("appleUserInitiatedEnrollmentProfiles", AppleUserInitiatedEnrollmentProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter>("assignmentFilters", AssignmentFilters);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementAutopilotEvent>("autopilotEvents", AutopilotEvents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CartToClassAssociation>("cartToClassAssociations", CartToClassAssociations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementSettingCategory>("categories", Categories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CertificateConnectorDetails>("certificateConnectorDetails", CertificateConnectorDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings>("chromeOSOnboardingSettings", ChromeOSOnboardingSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CloudPCConnectivityIssue>("cloudPCConnectivityIssues", CloudPCConnectivityIssues);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedDevice>("comanagedDevices", ComanagedDevices);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ComanagementEligibleDevice>("comanagementEligibleDevices", ComanagementEligibleDevices);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory>("complianceCategories", ComplianceCategories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ComplianceManagementPartner>("complianceManagementPartners", ComplianceManagementPartners);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy>("compliancePolicies", CompliancePolicies);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>("complianceSettings", ComplianceSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.OnPremisesConditionalAccessSettings>("conditionalAccessSettings", ConditionalAccessSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConfigManagerCollection>("configManagerCollections", ConfigManagerCollections);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationCategory>("configurationCategories", ConfigurationCategories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicy>("configurationPolicies", ConfigurationPolicies);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicyTemplate>("configurationPolicyTemplates", ConfigurationPolicyTemplates);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>("configurationSettings", ConfigurationSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DataProcessorServiceForWindowsFeaturesOnboarding>("dataProcessorServiceForWindowsFeaturesOnboarding", DataProcessorServiceForWindowsFeaturesOnboarding);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DataSharingConsent>("dataSharingConsents", DataSharingConsents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DepOnboardingSetting>("depOnboardingSettings", DepOnboardingSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>("derivedCredentials", DerivedCredentials);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DetectedApp>("detectedApps", DetectedApps);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceCategory>("deviceCategories", DeviceCategories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceCompliancePolicy>("deviceCompliancePolicies", DeviceCompliancePolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary", DeviceCompliancePolicyDeviceStateSummary);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceComplianceScript>("deviceComplianceScripts", DeviceComplianceScripts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary>("deviceConfigurationConflictSummary", DeviceConfigurationConflictSummary);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceConfigurationDeviceStateSummary>("deviceConfigurationDeviceStateSummaries", DeviceConfigurationDeviceStateSummaries);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RestrictedAppsViolation>("deviceConfigurationRestrictedAppsViolations", DeviceConfigurationRestrictedAppsViolations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceConfiguration>("deviceConfigurations", DeviceConfigurations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedAllDeviceCertificateState>("deviceConfigurationsAllManagedDeviceCertificateStates", DeviceConfigurationsAllManagedDeviceCertificateStates);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceConfigurationUserStateSummary>("deviceConfigurationUserStateSummaries", DeviceConfigurationUserStateSummaries);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceCustomAttributeShellScript>("deviceCustomAttributeShellScripts", DeviceCustomAttributeShellScripts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceEnrollmentConfiguration>("deviceEnrollmentConfigurations", DeviceEnrollmentConfigurations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceHealthScript>("deviceHealthScripts", DeviceHealthScripts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementPartner>("deviceManagementPartners", DeviceManagementPartners);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementScript>("deviceManagementScripts", DeviceManagementScripts);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceProtectionOverview>("deviceProtectionOverview", DeviceProtectionOverview);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceShellScript>("deviceShellScripts", DeviceShellScripts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementDomainJoinConnector>("domainJoinConnectors", DomainJoinConnectors);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.EmbeddedSIMActivationCodePool>("embeddedSIMActivationCodePools", EmbeddedSIMActivationCodePools);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementExchangeConnector>("exchangeConnectors", ExchangeConnectors);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy>("exchangeOnPremisesPolicies", ExchangeOnPremisesPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementExchangeOnPremisesPolicy>("exchangeOnPremisesPolicy", ExchangeOnPremisesPolicy);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyCategory>("groupPolicyCategories", GroupPolicyCategories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyConfiguration>("groupPolicyConfigurations", GroupPolicyConfigurations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile>("groupPolicyDefinitionFiles", GroupPolicyDefinitionFiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyDefinition>("groupPolicyDefinitions", GroupPolicyDefinitions);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport>("groupPolicyMigrationReports", GroupPolicyMigrationReports);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyObjectFile>("groupPolicyObjectFiles", GroupPolicyObjectFiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GroupPolicyUploadedDefinitionFile>("groupPolicyUploadedDefinitionFiles", GroupPolicyUploadedDefinitionFiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ImportedDeviceIdentity>("importedDeviceIdentities", ImportedDeviceIdentities);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ImportedWindowsAutopilotDeviceIdentity>("importedWindowsAutopilotDeviceIdentities", ImportedWindowsAutopilotDeviceIdentities);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntent>("intents", Intents);
            writer.WriteGuidValue("intuneAccountId", IntuneAccountId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IntuneBrand>("intuneBrand", IntuneBrand);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IntuneBrandingProfile>("intuneBrandingProfiles", IntuneBrandingProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IosUpdateDeviceStatus>("iosUpdateStatuses", IosUpdateStatuses);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateAccountSummary>("macOSSoftwareUpdateAccountSummaries", MacOSSoftwareUpdateAccountSummaries);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings>("managedDeviceCleanupSettings", ManagedDeviceCleanupSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedDeviceEncryptionState>("managedDeviceEncryptionStates", ManagedDeviceEncryptionStates);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceOverview>("managedDeviceOverview", ManagedDeviceOverview);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteIntValue("maximumDepTokens", MaximumDepTokens);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>("microsoftTunnelConfigurations", MicrosoftTunnelConfigurations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftTunnelHealthThreshold>("microsoftTunnelHealthThresholds", MicrosoftTunnelHealthThresholds);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftTunnelServerLogCollectionResponse>("microsoftTunnelServerLogCollectionResponses", MicrosoftTunnelServerLogCollectionResponses);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftTunnelSite>("microsoftTunnelSites", MicrosoftTunnelSites);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent>("mobileAppTroubleshootingEvents", MobileAppTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MobileThreatDefenseConnector>("mobileThreatDefenseConnectors", MobileThreatDefenseConnectors);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagement.Monitoring>("monitoring", Monitoring);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.NdesConnector>("ndesConnectors", NdesConnectors);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.NotificationMessageTemplate>("notificationMessageTemplates", NotificationMessageTemplates);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding>("oemWarrantyInformationOnboarding", OemWarrantyInformationOnboarding);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RemoteActionAudit>("remoteActionAudits", RemoteActionAudits);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RemoteAssistancePartner>("remoteAssistancePartners", RemoteAssistancePartners);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RemoteAssistanceSettings>("remoteAssistanceSettings", RemoteAssistanceSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementResourceAccessProfileBase>("resourceAccessProfiles", ResourceAccessProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ResourceOperation>("resourceOperations", ResourceOperations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementReusablePolicySetting>("reusablePolicySettings", ReusablePolicySettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition>("reusableSettings", ReusableSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceAndAppManagementRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RoleScopeTag>("roleScopeTags", RoleScopeTags);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition>("settingDefinitions", SettingDefinitions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementSettings>("settings", Settings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary", SoftwareUpdateStatusSummary);
            writer.WriteEnumValue<DeviceManagementSubscriptions>("subscriptions", Subscriptions);
            writer.WriteEnumValue<DeviceManagementSubscriptionState>("subscriptionState", SubscriptionState);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TelecomExpenseManagementPartner>("telecomExpenseManagementPartners", TelecomExpenseManagementPartners);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementTemplate>("templates", Templates);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingTemplate>("templateSettings", TemplateSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TenantAttachRBAC>("tenantAttachRBAC", TenantAttachRBAC);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TermsAndConditions>("termsAndConditions", TermsAndConditions);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent>("troubleshootingEvents", TroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomaly>("userExperienceAnalyticsAnomaly", UserExperienceAnalyticsAnomaly);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalyDevice>("userExperienceAnalyticsAnomalyDevice", UserExperienceAnalyticsAnomalyDevice);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAnomalySeverityOverview>("userExperienceAnalyticsAnomalySeverityOverview", UserExperienceAnalyticsAnomalySeverityOverview);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>("userExperienceAnalyticsAppHealthApplicationPerformance", UserExperienceAnalyticsAppHealthApplicationPerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>("userExperienceAnalyticsAppHealthDeviceModelPerformance", UserExperienceAnalyticsAppHealthDeviceModelPerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance>("userExperienceAnalyticsAppHealthDevicePerformance", UserExperienceAnalyticsAppHealthDevicePerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>("userExperienceAnalyticsAppHealthDevicePerformanceDetails", UserExperienceAnalyticsAppHealthDevicePerformanceDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>("userExperienceAnalyticsAppHealthOSVersionPerformance", UserExperienceAnalyticsAppHealthOSVersionPerformance);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory>("userExperienceAnalyticsAppHealthOverview", UserExperienceAnalyticsAppHealthOverview);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBaseline>("userExperienceAnalyticsBaselines", UserExperienceAnalyticsBaselines);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact>("userExperienceAnalyticsBatteryHealthAppImpact", UserExperienceAnalyticsBatteryHealthAppImpact);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails>("userExperienceAnalyticsBatteryHealthCapacityDetails", UserExperienceAnalyticsBatteryHealthCapacityDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact>("userExperienceAnalyticsBatteryHealthDeviceAppImpact", UserExperienceAnalyticsBatteryHealthDeviceAppImpact);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance>("userExperienceAnalyticsBatteryHealthDevicePerformance", UserExperienceAnalyticsBatteryHealthDevicePerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory>("userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory", UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance>("userExperienceAnalyticsBatteryHealthModelPerformance", UserExperienceAnalyticsBatteryHealthModelPerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance>("userExperienceAnalyticsBatteryHealthOsPerformance", UserExperienceAnalyticsBatteryHealthOsPerformance);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails>("userExperienceAnalyticsBatteryHealthRuntimeDetails", UserExperienceAnalyticsBatteryHealthRuntimeDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsCategory>("userExperienceAnalyticsCategories", UserExperienceAnalyticsCategories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>("userExperienceAnalyticsDeviceMetricHistory", UserExperienceAnalyticsDeviceMetricHistory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance>("userExperienceAnalyticsDevicePerformance", UserExperienceAnalyticsDevicePerformance);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>("userExperienceAnalyticsDeviceScope", UserExperienceAnalyticsDeviceScope);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>("userExperienceAnalyticsDeviceScopes", UserExperienceAnalyticsDeviceScopes);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores>("userExperienceAnalyticsDeviceScores", UserExperienceAnalyticsDeviceScores);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory>("userExperienceAnalyticsDeviceStartupHistory", UserExperienceAnalyticsDeviceStartupHistory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcess>("userExperienceAnalyticsDeviceStartupProcesses", UserExperienceAnalyticsDeviceStartupProcesses);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance>("userExperienceAnalyticsDeviceStartupProcessPerformance", UserExperienceAnalyticsDeviceStartupProcessPerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceWithoutCloudIdentity>("userExperienceAnalyticsDevicesWithoutCloudIdentity", UserExperienceAnalyticsDevicesWithoutCloudIdentity);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceTimelineEvents>("userExperienceAnalyticsDeviceTimelineEvents", UserExperienceAnalyticsDeviceTimelineEvents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess>("userExperienceAnalyticsImpactingProcess", UserExperienceAnalyticsImpactingProcess);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>("userExperienceAnalyticsMetricHistory", UserExperienceAnalyticsMetricHistory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores>("userExperienceAnalyticsModelScores", UserExperienceAnalyticsModelScores);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice>("userExperienceAnalyticsNotAutopilotReadyDevice", UserExperienceAnalyticsNotAutopilotReadyDevice);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview>("userExperienceAnalyticsOverview", UserExperienceAnalyticsOverview);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection>("userExperienceAnalyticsRemoteConnection", UserExperienceAnalyticsRemoteConnection);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance>("userExperienceAnalyticsResourcePerformance", UserExperienceAnalyticsResourcePerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory>("userExperienceAnalyticsScoreHistory", UserExperienceAnalyticsScoreHistory);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings>("userExperienceAnalyticsSettings", UserExperienceAnalyticsSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereMetric>("userExperienceAnalyticsWorkFromAnywhereMetrics", UserExperienceAnalyticsWorkFromAnywhereMetrics);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>("userExperienceAnalyticsWorkFromAnywhereModelPerformance", UserExperienceAnalyticsWorkFromAnywhereModelPerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserPFXCertificate>("userPfxCertificates", UserPfxCertificates);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.VirtualEndpoint>("virtualEndpoint", VirtualEndpoint);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>("windowsAutopilotDeploymentProfiles", WindowsAutopilotDeploymentProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity>("windowsAutopilotDeviceIdentities", WindowsAutopilotDeviceIdentities);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsAutopilotSettings>("windowsAutopilotSettings", WindowsAutopilotSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsDriverUpdateProfile>("windowsDriverUpdateProfiles", WindowsDriverUpdateProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsFeatureUpdateProfile>("windowsFeatureUpdateProfiles", WindowsFeatureUpdateProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsInformationProtectionAppLearningSummary>("windowsInformationProtectionAppLearningSummaries", WindowsInformationProtectionAppLearningSummaries);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsInformationProtectionNetworkLearningSummary>("windowsInformationProtectionNetworkLearningSummaries", WindowsInformationProtectionNetworkLearningSummaries);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsMalwareInformation>("windowsMalwareInformation", WindowsMalwareInformation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsMalwareOverview>("windowsMalwareOverview", WindowsMalwareOverview);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsQualityUpdateProfile>("windowsQualityUpdateProfiles", WindowsQualityUpdateProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdateCatalogItem>("windowsUpdateCatalogItems", WindowsUpdateCatalogItems);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ZebraFotaArtifact>("zebraFotaArtifacts", ZebraFotaArtifacts);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ZebraFotaConnector>("zebraFotaConnector", ZebraFotaConnector);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ZebraFotaDeployment>("zebraFotaDeployments", ZebraFotaDeployments);
        }
    }
}
