using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagement : Entity, IParsable {
        /// <summary>The date &amp; time when tenant data moved between scaleunits.</summary>
        public DateTimeOffset? AccountMoveCompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(AccountMoveCompletionDateTime)); }
            set { BackingStore?.Set(nameof(AccountMoveCompletionDateTime), value); }
        }
        /// <summary>Admin consent information.</summary>
        public Microsoft.Graph.Beta.Models.AdminConsent AdminConsent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdminConsent>(nameof(AdminConsent)); }
            set { BackingStore?.Set(nameof(AdminConsent), value); }
        }
        /// <summary>The summary state of ATP onboarding state for this account.</summary>
        public Microsoft.Graph.Beta.Models.AdvancedThreatProtectionOnboardingStateSummary AdvancedThreatProtectionOnboardingStateSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdvancedThreatProtectionOnboardingStateSummary>(nameof(AdvancedThreatProtectionOnboardingStateSummary)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionOnboardingStateSummary), value); }
        }
        /// <summary>Android device owner enrollment profile entities.</summary>
        public List<AndroidDeviceOwnerEnrollmentProfile> AndroidDeviceOwnerEnrollmentProfiles {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerEnrollmentProfile>>(nameof(AndroidDeviceOwnerEnrollmentProfiles)); }
            set { BackingStore?.Set(nameof(AndroidDeviceOwnerEnrollmentProfiles), value); }
        }
        /// <summary>Android for Work app configuration schema entities.</summary>
        public List<AndroidForWorkAppConfigurationSchema> AndroidForWorkAppConfigurationSchemas {
            get { return BackingStore?.Get<List<AndroidForWorkAppConfigurationSchema>>(nameof(AndroidForWorkAppConfigurationSchemas)); }
            set { BackingStore?.Set(nameof(AndroidForWorkAppConfigurationSchemas), value); }
        }
        /// <summary>Android for Work enrollment profile entities.</summary>
        public List<AndroidForWorkEnrollmentProfile> AndroidForWorkEnrollmentProfiles {
            get { return BackingStore?.Get<List<AndroidForWorkEnrollmentProfile>>(nameof(AndroidForWorkEnrollmentProfiles)); }
            set { BackingStore?.Set(nameof(AndroidForWorkEnrollmentProfiles), value); }
        }
        /// <summary>The singleton Android for Work settings entity.</summary>
        public Microsoft.Graph.Beta.Models.AndroidForWorkSettings AndroidForWorkSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AndroidForWorkSettings>(nameof(AndroidForWorkSettings)); }
            set { BackingStore?.Set(nameof(AndroidForWorkSettings), value); }
        }
        /// <summary>The singleton Android managed store account enterprise settings entity.</summary>
        public Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings AndroidManagedStoreAccountEnterpriseSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>(nameof(AndroidManagedStoreAccountEnterpriseSettings)); }
            set { BackingStore?.Set(nameof(AndroidManagedStoreAccountEnterpriseSettings), value); }
        }
        /// <summary>Android Enterprise app configuration schema entities.</summary>
        public List<AndroidManagedStoreAppConfigurationSchema> AndroidManagedStoreAppConfigurationSchemas {
            get { return BackingStore?.Get<List<AndroidManagedStoreAppConfigurationSchema>>(nameof(AndroidManagedStoreAppConfigurationSchemas)); }
            set { BackingStore?.Set(nameof(AndroidManagedStoreAppConfigurationSchemas), value); }
        }
        /// <summary>Apple push notification certificate.</summary>
        public Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate ApplePushNotificationCertificate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate>(nameof(ApplePushNotificationCertificate)); }
            set { BackingStore?.Set(nameof(ApplePushNotificationCertificate), value); }
        }
        /// <summary>Apple user initiated enrollment profiles</summary>
        public List<AppleUserInitiatedEnrollmentProfile> AppleUserInitiatedEnrollmentProfiles {
            get { return BackingStore?.Get<List<AppleUserInitiatedEnrollmentProfile>>(nameof(AppleUserInitiatedEnrollmentProfiles)); }
            set { BackingStore?.Set(nameof(AppleUserInitiatedEnrollmentProfiles), value); }
        }
        /// <summary>The list of assignment filters</summary>
        public List<DeviceAndAppManagementAssignmentFilter> AssignmentFilters {
            get { return BackingStore?.Get<List<DeviceAndAppManagementAssignmentFilter>>(nameof(AssignmentFilters)); }
            set { BackingStore?.Set(nameof(AssignmentFilters), value); }
        }
        /// <summary>The Audit Events</summary>
        public List<AuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<AuditEvent>>(nameof(AuditEvents)); }
            set { BackingStore?.Set(nameof(AuditEvents), value); }
        }
        /// <summary>The list of autopilot events for the tenant.</summary>
        public List<DeviceManagementAutopilotEvent> AutopilotEvents {
            get { return BackingStore?.Get<List<DeviceManagementAutopilotEvent>>(nameof(AutopilotEvents)); }
            set { BackingStore?.Set(nameof(AutopilotEvents), value); }
        }
        /// <summary>The Cart To Class Associations.</summary>
        public List<CartToClassAssociation> CartToClassAssociations {
            get { return BackingStore?.Get<List<CartToClassAssociation>>(nameof(CartToClassAssociations)); }
            set { BackingStore?.Set(nameof(CartToClassAssociations), value); }
        }
        /// <summary>The available categories</summary>
        public List<DeviceManagementSettingCategory> Categories {
            get { return BackingStore?.Get<List<DeviceManagementSettingCategory>>(nameof(Categories)); }
            set { BackingStore?.Set(nameof(Categories), value); }
        }
        /// <summary>Collection of certificate connector details, each associated with a corresponding Intune Certificate Connector.</summary>
        public List<Microsoft.Graph.Beta.Models.CertificateConnectorDetails> CertificateConnectorDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CertificateConnectorDetails>>(nameof(CertificateConnectorDetails)); }
            set { BackingStore?.Set(nameof(CertificateConnectorDetails), value); }
        }
        /// <summary>Collection of ChromeOSOnboardingSettings settings associated with account.</summary>
        public List<Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings> ChromeOSOnboardingSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings>>(nameof(ChromeOSOnboardingSettings)); }
            set { BackingStore?.Set(nameof(ChromeOSOnboardingSettings), value); }
        }
        /// <summary>The list of CloudPC Connectivity Issue.</summary>
        public List<CloudPCConnectivityIssue> CloudPCConnectivityIssues {
            get { return BackingStore?.Get<List<CloudPCConnectivityIssue>>(nameof(CloudPCConnectivityIssues)); }
            set { BackingStore?.Set(nameof(CloudPCConnectivityIssues), value); }
        }
        /// <summary>The list of co-managed devices report</summary>
        public List<ManagedDevice> ComanagedDevices {
            get { return BackingStore?.Get<List<ManagedDevice>>(nameof(ComanagedDevices)); }
            set { BackingStore?.Set(nameof(ComanagedDevices), value); }
        }
        /// <summary>The list of co-management eligible devices report</summary>
        public List<ComanagementEligibleDevice> ComanagementEligibleDevices {
            get { return BackingStore?.Get<List<ComanagementEligibleDevice>>(nameof(ComanagementEligibleDevices)); }
            set { BackingStore?.Set(nameof(ComanagementEligibleDevices), value); }
        }
        /// <summary>List of all compliance categories</summary>
        public List<DeviceManagementConfigurationCategory> ComplianceCategories {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationCategory>>(nameof(ComplianceCategories)); }
            set { BackingStore?.Set(nameof(ComplianceCategories), value); }
        }
        /// <summary>The list of Compliance Management Partners configured by the tenant.</summary>
        public List<ComplianceManagementPartner> ComplianceManagementPartners {
            get { return BackingStore?.Get<List<ComplianceManagementPartner>>(nameof(ComplianceManagementPartners)); }
            set { BackingStore?.Set(nameof(ComplianceManagementPartners), value); }
        }
        /// <summary>List of all compliance policies</summary>
        public List<DeviceManagementCompliancePolicy> CompliancePolicies {
            get { return BackingStore?.Get<List<DeviceManagementCompliancePolicy>>(nameof(CompliancePolicies)); }
            set { BackingStore?.Set(nameof(CompliancePolicies), value); }
        }
        /// <summary>List of all ComplianceSettings</summary>
        public List<DeviceManagementConfigurationSettingDefinition> ComplianceSettings {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDefinition>>(nameof(ComplianceSettings)); }
            set { BackingStore?.Set(nameof(ComplianceSettings), value); }
        }
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings {
            get { return BackingStore?.Get<OnPremisesConditionalAccessSettings>(nameof(ConditionalAccessSettings)); }
            set { BackingStore?.Set(nameof(ConditionalAccessSettings), value); }
        }
        /// <summary>A list of ConfigManagerCollection</summary>
        public List<ConfigManagerCollection> ConfigManagerCollections {
            get { return BackingStore?.Get<List<ConfigManagerCollection>>(nameof(ConfigManagerCollections)); }
            set { BackingStore?.Set(nameof(ConfigManagerCollections), value); }
        }
        /// <summary>List of all Configuration Categories</summary>
        public List<DeviceManagementConfigurationCategory> ConfigurationCategories {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationCategory>>(nameof(ConfigurationCategories)); }
            set { BackingStore?.Set(nameof(ConfigurationCategories), value); }
        }
        /// <summary>List of all Configuration policies</summary>
        public List<DeviceManagementConfigurationPolicy> ConfigurationPolicies {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationPolicy>>(nameof(ConfigurationPolicies)); }
            set { BackingStore?.Set(nameof(ConfigurationPolicies), value); }
        }
        /// <summary>List of all templates</summary>
        public List<DeviceManagementConfigurationPolicyTemplate> ConfigurationPolicyTemplates {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationPolicyTemplate>>(nameof(ConfigurationPolicyTemplates)); }
            set { BackingStore?.Set(nameof(ConfigurationPolicyTemplates), value); }
        }
        /// <summary>List of all ConfigurationSettings</summary>
        public List<DeviceManagementConfigurationSettingDefinition> ConfigurationSettings {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDefinition>>(nameof(ConfigurationSettings)); }
            set { BackingStore?.Set(nameof(ConfigurationSettings), value); }
        }
        /// <summary>Data sharing consents.</summary>
        public List<DataSharingConsent> DataSharingConsents {
            get { return BackingStore?.Get<List<DataSharingConsent>>(nameof(DataSharingConsents)); }
            set { BackingStore?.Set(nameof(DataSharingConsents), value); }
        }
        /// <summary>This collections of multiple DEP tokens per-tenant.</summary>
        public List<DepOnboardingSetting> DepOnboardingSettings {
            get { return BackingStore?.Get<List<DepOnboardingSetting>>(nameof(DepOnboardingSettings)); }
            set { BackingStore?.Set(nameof(DepOnboardingSettings), value); }
        }
        /// <summary>Collection of Derived credential settings associated with account.</summary>
        public List<DeviceManagementDerivedCredentialSettings> DerivedCredentials {
            get { return BackingStore?.Get<List<DeviceManagementDerivedCredentialSettings>>(nameof(DerivedCredentials)); }
            set { BackingStore?.Set(nameof(DerivedCredentials), value); }
        }
        /// <summary>The list of detected apps associated with a device.</summary>
        public List<DetectedApp> DetectedApps {
            get { return BackingStore?.Get<List<DetectedApp>>(nameof(DetectedApps)); }
            set { BackingStore?.Set(nameof(DetectedApps), value); }
        }
        /// <summary>The list of device categories with the tenant.</summary>
        public List<DeviceCategory> DeviceCategories {
            get { return BackingStore?.Get<List<DeviceCategory>>(nameof(DeviceCategories)); }
            set { BackingStore?.Set(nameof(DeviceCategories), value); }
        }
        /// <summary>The device compliance policies.</summary>
        public List<DeviceCompliancePolicy> DeviceCompliancePolicies {
            get { return BackingStore?.Get<List<DeviceCompliancePolicy>>(nameof(DeviceCompliancePolicies)); }
            set { BackingStore?.Set(nameof(DeviceCompliancePolicies), value); }
        }
        /// <summary>The device compliance state summary for this account.</summary>
        public Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary>(nameof(DeviceCompliancePolicyDeviceStateSummary)); }
            set { BackingStore?.Set(nameof(DeviceCompliancePolicyDeviceStateSummary), value); }
        }
        /// <summary>The summary states of compliance policy settings for this account.</summary>
        public List<DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries {
            get { return BackingStore?.Get<List<DeviceCompliancePolicySettingStateSummary>>(nameof(DeviceCompliancePolicySettingStateSummaries)); }
            set { BackingStore?.Set(nameof(DeviceCompliancePolicySettingStateSummaries), value); }
        }
        /// <summary>The last requested time of device compliance reporting for this account. This property is read-only.</summary>
        public DateTimeOffset? DeviceComplianceReportSummarizationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DeviceComplianceReportSummarizationDateTime)); }
            set { BackingStore?.Set(nameof(DeviceComplianceReportSummarizationDateTime), value); }
        }
        /// <summary>The list of device compliance scripts associated with the tenant.</summary>
        public List<DeviceComplianceScript> DeviceComplianceScripts {
            get { return BackingStore?.Get<List<DeviceComplianceScript>>(nameof(DeviceComplianceScripts)); }
            set { BackingStore?.Set(nameof(DeviceComplianceScripts), value); }
        }
        /// <summary>Summary of policies in conflict state for this account.</summary>
        public List<Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary> DeviceConfigurationConflictSummary {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary>>(nameof(DeviceConfigurationConflictSummary)); }
            set { BackingStore?.Set(nameof(DeviceConfigurationConflictSummary), value); }
        }
        /// <summary>The device configuration device state summary for this account.</summary>
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries {
            get { return BackingStore?.Get<DeviceConfigurationDeviceStateSummary>(nameof(DeviceConfigurationDeviceStateSummaries)); }
            set { BackingStore?.Set(nameof(DeviceConfigurationDeviceStateSummaries), value); }
        }
        /// <summary>Restricted apps violations for this account.</summary>
        public List<RestrictedAppsViolation> DeviceConfigurationRestrictedAppsViolations {
            get { return BackingStore?.Get<List<RestrictedAppsViolation>>(nameof(DeviceConfigurationRestrictedAppsViolations)); }
            set { BackingStore?.Set(nameof(DeviceConfigurationRestrictedAppsViolations), value); }
        }
        /// <summary>The device configurations.</summary>
        public List<DeviceConfiguration> DeviceConfigurations {
            get { return BackingStore?.Get<List<DeviceConfiguration>>(nameof(DeviceConfigurations)); }
            set { BackingStore?.Set(nameof(DeviceConfigurations), value); }
        }
        /// <summary>Summary of all certificates for all devices.</summary>
        public List<ManagedAllDeviceCertificateState> DeviceConfigurationsAllManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<ManagedAllDeviceCertificateState>>(nameof(DeviceConfigurationsAllManagedDeviceCertificateStates)); }
            set { BackingStore?.Set(nameof(DeviceConfigurationsAllManagedDeviceCertificateStates), value); }
        }
        /// <summary>The device configuration user state summary for this account.</summary>
        public DeviceConfigurationUserStateSummary DeviceConfigurationUserStateSummaries {
            get { return BackingStore?.Get<DeviceConfigurationUserStateSummary>(nameof(DeviceConfigurationUserStateSummaries)); }
            set { BackingStore?.Set(nameof(DeviceConfigurationUserStateSummaries), value); }
        }
        /// <summary>The list of device custom attribute shell scripts associated with the tenant.</summary>
        public List<DeviceCustomAttributeShellScript> DeviceCustomAttributeShellScripts {
            get { return BackingStore?.Get<List<DeviceCustomAttributeShellScript>>(nameof(DeviceCustomAttributeShellScripts)); }
            set { BackingStore?.Set(nameof(DeviceCustomAttributeShellScripts), value); }
        }
        /// <summary>The list of device enrollment configurations</summary>
        public List<DeviceEnrollmentConfiguration> DeviceEnrollmentConfigurations {
            get { return BackingStore?.Get<List<DeviceEnrollmentConfiguration>>(nameof(DeviceEnrollmentConfigurations)); }
            set { BackingStore?.Set(nameof(DeviceEnrollmentConfigurations), value); }
        }
        /// <summary>The list of device health scripts associated with the tenant.</summary>
        public List<DeviceHealthScript> DeviceHealthScripts {
            get { return BackingStore?.Get<List<DeviceHealthScript>>(nameof(DeviceHealthScripts)); }
            set { BackingStore?.Set(nameof(DeviceHealthScripts), value); }
        }
        /// <summary>The list of Device Management Partners configured by the tenant.</summary>
        public List<DeviceManagementPartner> DeviceManagementPartners {
            get { return BackingStore?.Get<List<DeviceManagementPartner>>(nameof(DeviceManagementPartners)); }
            set { BackingStore?.Set(nameof(DeviceManagementPartners), value); }
        }
        /// <summary>The list of device management scripts associated with the tenant.</summary>
        public List<DeviceManagementScript> DeviceManagementScripts {
            get { return BackingStore?.Get<List<DeviceManagementScript>>(nameof(DeviceManagementScripts)); }
            set { BackingStore?.Set(nameof(DeviceManagementScripts), value); }
        }
        /// <summary>Device protection overview.</summary>
        public Microsoft.Graph.Beta.Models.DeviceProtectionOverview DeviceProtectionOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceProtectionOverview>(nameof(DeviceProtectionOverview)); }
            set { BackingStore?.Set(nameof(DeviceProtectionOverview), value); }
        }
        /// <summary>The list of device shell scripts associated with the tenant.</summary>
        public List<DeviceShellScript> DeviceShellScripts {
            get { return BackingStore?.Get<List<DeviceShellScript>>(nameof(DeviceShellScripts)); }
            set { BackingStore?.Set(nameof(DeviceShellScripts), value); }
        }
        /// <summary>A list of connector objects.</summary>
        public List<DeviceManagementDomainJoinConnector> DomainJoinConnectors {
            get { return BackingStore?.Get<List<DeviceManagementDomainJoinConnector>>(nameof(DomainJoinConnectors)); }
            set { BackingStore?.Set(nameof(DomainJoinConnectors), value); }
        }
        /// <summary>The embedded SIM activation code pools created by this account.</summary>
        public List<EmbeddedSIMActivationCodePool> EmbeddedSIMActivationCodePools {
            get { return BackingStore?.Get<List<EmbeddedSIMActivationCodePool>>(nameof(EmbeddedSIMActivationCodePools)); }
            set { BackingStore?.Set(nameof(EmbeddedSIMActivationCodePools), value); }
        }
        /// <summary>The list of Exchange Connectors configured by the tenant.</summary>
        public List<DeviceManagementExchangeConnector> ExchangeConnectors {
            get { return BackingStore?.Get<List<DeviceManagementExchangeConnector>>(nameof(ExchangeConnectors)); }
            set { BackingStore?.Set(nameof(ExchangeConnectors), value); }
        }
        /// <summary>The list of Exchange On Premisis policies configured by the tenant.</summary>
        public List<DeviceManagementExchangeOnPremisesPolicy> ExchangeOnPremisesPolicies {
            get { return BackingStore?.Get<List<DeviceManagementExchangeOnPremisesPolicy>>(nameof(ExchangeOnPremisesPolicies)); }
            set { BackingStore?.Set(nameof(ExchangeOnPremisesPolicies), value); }
        }
        /// <summary>The policy which controls mobile device access to Exchange On Premises</summary>
        public DeviceManagementExchangeOnPremisesPolicy ExchangeOnPremisesPolicy {
            get { return BackingStore?.Get<DeviceManagementExchangeOnPremisesPolicy>(nameof(ExchangeOnPremisesPolicy)); }
            set { BackingStore?.Set(nameof(ExchangeOnPremisesPolicy), value); }
        }
        /// <summary>The available group policy categories for this account.</summary>
        public List<GroupPolicyCategory> GroupPolicyCategories {
            get { return BackingStore?.Get<List<GroupPolicyCategory>>(nameof(GroupPolicyCategories)); }
            set { BackingStore?.Set(nameof(GroupPolicyCategories), value); }
        }
        /// <summary>The group policy configurations created by this account.</summary>
        public List<GroupPolicyConfiguration> GroupPolicyConfigurations {
            get { return BackingStore?.Get<List<GroupPolicyConfiguration>>(nameof(GroupPolicyConfigurations)); }
            set { BackingStore?.Set(nameof(GroupPolicyConfigurations), value); }
        }
        /// <summary>The available group policy definition files for this account.</summary>
        public List<GroupPolicyDefinitionFile> GroupPolicyDefinitionFiles {
            get { return BackingStore?.Get<List<GroupPolicyDefinitionFile>>(nameof(GroupPolicyDefinitionFiles)); }
            set { BackingStore?.Set(nameof(GroupPolicyDefinitionFiles), value); }
        }
        /// <summary>The available group policy definitions for this account.</summary>
        public List<GroupPolicyDefinition> GroupPolicyDefinitions {
            get { return BackingStore?.Get<List<GroupPolicyDefinition>>(nameof(GroupPolicyDefinitions)); }
            set { BackingStore?.Set(nameof(GroupPolicyDefinitions), value); }
        }
        /// <summary>A list of Group Policy migration reports.</summary>
        public List<GroupPolicyMigrationReport> GroupPolicyMigrationReports {
            get { return BackingStore?.Get<List<GroupPolicyMigrationReport>>(nameof(GroupPolicyMigrationReports)); }
            set { BackingStore?.Set(nameof(GroupPolicyMigrationReports), value); }
        }
        /// <summary>A list of Group Policy Object files uploaded.</summary>
        public List<GroupPolicyObjectFile> GroupPolicyObjectFiles {
            get { return BackingStore?.Get<List<GroupPolicyObjectFile>>(nameof(GroupPolicyObjectFiles)); }
            set { BackingStore?.Set(nameof(GroupPolicyObjectFiles), value); }
        }
        /// <summary>The available group policy uploaded definition files for this account.</summary>
        public List<GroupPolicyUploadedDefinitionFile> GroupPolicyUploadedDefinitionFiles {
            get { return BackingStore?.Get<List<GroupPolicyUploadedDefinitionFile>>(nameof(GroupPolicyUploadedDefinitionFiles)); }
            set { BackingStore?.Set(nameof(GroupPolicyUploadedDefinitionFiles), value); }
        }
        /// <summary>The imported device identities.</summary>
        public List<ImportedDeviceIdentity> ImportedDeviceIdentities {
            get { return BackingStore?.Get<List<ImportedDeviceIdentity>>(nameof(ImportedDeviceIdentities)); }
            set { BackingStore?.Set(nameof(ImportedDeviceIdentities), value); }
        }
        /// <summary>Collection of imported Windows autopilot devices.</summary>
        public List<ImportedWindowsAutopilotDeviceIdentity> ImportedWindowsAutopilotDeviceIdentities {
            get { return BackingStore?.Get<List<ImportedWindowsAutopilotDeviceIdentity>>(nameof(ImportedWindowsAutopilotDeviceIdentities)); }
            set { BackingStore?.Set(nameof(ImportedWindowsAutopilotDeviceIdentities), value); }
        }
        /// <summary>The device management intents</summary>
        public List<DeviceManagementIntent> Intents {
            get { return BackingStore?.Get<List<DeviceManagementIntent>>(nameof(Intents)); }
            set { BackingStore?.Set(nameof(Intents), value); }
        }
        /// <summary>Intune Account ID for given tenant</summary>
        public string IntuneAccountId {
            get { return BackingStore?.Get<string>(nameof(IntuneAccountId)); }
            set { BackingStore?.Set(nameof(IntuneAccountId), value); }
        }
        /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
        public Microsoft.Graph.Beta.Models.IntuneBrand IntuneBrand {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IntuneBrand>(nameof(IntuneBrand)); }
            set { BackingStore?.Set(nameof(IntuneBrand), value); }
        }
        /// <summary>Intune branding profiles targeted to AAD groups</summary>
        public List<IntuneBrandingProfile> IntuneBrandingProfiles {
            get { return BackingStore?.Get<List<IntuneBrandingProfile>>(nameof(IntuneBrandingProfiles)); }
            set { BackingStore?.Set(nameof(IntuneBrandingProfiles), value); }
        }
        /// <summary>The IOS software update installation statuses for this account.</summary>
        public List<IosUpdateDeviceStatus> IosUpdateStatuses {
            get { return BackingStore?.Get<List<IosUpdateDeviceStatus>>(nameof(IosUpdateStatuses)); }
            set { BackingStore?.Set(nameof(IosUpdateStatuses), value); }
        }
        /// <summary>The last modified time of reporting for this account. This property is read-only.</summary>
        public DateTimeOffset? LastReportAggregationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastReportAggregationDateTime)); }
            set { BackingStore?.Set(nameof(LastReportAggregationDateTime), value); }
        }
        /// <summary>The property to enable Non-MDM managed legacy PC management for this account. This property is read-only.</summary>
        public bool? LegacyPcManangementEnabled {
            get { return BackingStore?.Get<bool?>(nameof(LegacyPcManangementEnabled)); }
            set { BackingStore?.Set(nameof(LegacyPcManangementEnabled), value); }
        }
        /// <summary>The MacOS software update account summaries for this account.</summary>
        public List<MacOSSoftwareUpdateAccountSummary> MacOSSoftwareUpdateAccountSummaries {
            get { return BackingStore?.Get<List<MacOSSoftwareUpdateAccountSummary>>(nameof(MacOSSoftwareUpdateAccountSummaries)); }
            set { BackingStore?.Set(nameof(MacOSSoftwareUpdateAccountSummaries), value); }
        }
        /// <summary>Device cleanup rule</summary>
        public Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings ManagedDeviceCleanupSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings>(nameof(ManagedDeviceCleanupSettings)); }
            set { BackingStore?.Set(nameof(ManagedDeviceCleanupSettings), value); }
        }
        /// <summary>Encryption report for devices in this account</summary>
        public List<ManagedDeviceEncryptionState> ManagedDeviceEncryptionStates {
            get { return BackingStore?.Get<List<ManagedDeviceEncryptionState>>(nameof(ManagedDeviceEncryptionStates)); }
            set { BackingStore?.Set(nameof(ManagedDeviceEncryptionStates), value); }
        }
        /// <summary>Device overview</summary>
        public Microsoft.Graph.Beta.Models.ManagedDeviceOverview ManagedDeviceOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDeviceOverview>(nameof(ManagedDeviceOverview)); }
            set { BackingStore?.Set(nameof(ManagedDeviceOverview), value); }
        }
        /// <summary>The list of managed devices.</summary>
        public List<ManagedDevice> ManagedDevices {
            get { return BackingStore?.Get<List<ManagedDevice>>(nameof(ManagedDevices)); }
            set { BackingStore?.Set(nameof(ManagedDevices), value); }
        }
        /// <summary>Maximum number of DEP tokens allowed per-tenant.</summary>
        public int? MaximumDepTokens {
            get { return BackingStore?.Get<int?>(nameof(MaximumDepTokens)); }
            set { BackingStore?.Set(nameof(MaximumDepTokens), value); }
        }
        /// <summary>Collection of MicrosoftTunnelConfiguration settings associated with account.</summary>
        public List<MicrosoftTunnelConfiguration> MicrosoftTunnelConfigurations {
            get { return BackingStore?.Get<List<MicrosoftTunnelConfiguration>>(nameof(MicrosoftTunnelConfigurations)); }
            set { BackingStore?.Set(nameof(MicrosoftTunnelConfigurations), value); }
        }
        /// <summary>Collection of MicrosoftTunnelHealthThreshold settings associated with account.</summary>
        public List<MicrosoftTunnelHealthThreshold> MicrosoftTunnelHealthThresholds {
            get { return BackingStore?.Get<List<MicrosoftTunnelHealthThreshold>>(nameof(MicrosoftTunnelHealthThresholds)); }
            set { BackingStore?.Set(nameof(MicrosoftTunnelHealthThresholds), value); }
        }
        /// <summary>Collection of MicrosoftTunnelServerLogCollectionResponse settings associated with account.</summary>
        public List<MicrosoftTunnelServerLogCollectionResponse> MicrosoftTunnelServerLogCollectionResponses {
            get { return BackingStore?.Get<List<MicrosoftTunnelServerLogCollectionResponse>>(nameof(MicrosoftTunnelServerLogCollectionResponses)); }
            set { BackingStore?.Set(nameof(MicrosoftTunnelServerLogCollectionResponses), value); }
        }
        /// <summary>Collection of MicrosoftTunnelSite settings associated with account.</summary>
        public List<MicrosoftTunnelSite> MicrosoftTunnelSites {
            get { return BackingStore?.Get<List<MicrosoftTunnelSite>>(nameof(MicrosoftTunnelSites)); }
            set { BackingStore?.Set(nameof(MicrosoftTunnelSites), value); }
        }
        /// <summary>The collection property of MobileAppTroubleshootingEvent.</summary>
        public List<MobileAppTroubleshootingEvent> MobileAppTroubleshootingEvents {
            get { return BackingStore?.Get<List<MobileAppTroubleshootingEvent>>(nameof(MobileAppTroubleshootingEvents)); }
            set { BackingStore?.Set(nameof(MobileAppTroubleshootingEvents), value); }
        }
        /// <summary>The list of Mobile threat Defense connectors configured by the tenant.</summary>
        public List<MobileThreatDefenseConnector> MobileThreatDefenseConnectors {
            get { return BackingStore?.Get<List<MobileThreatDefenseConnector>>(nameof(MobileThreatDefenseConnectors)); }
            set { BackingStore?.Set(nameof(MobileThreatDefenseConnectors), value); }
        }
        /// <summary>The collection of Ndes connectors for this account.</summary>
        public List<NdesConnector> NdesConnectors {
            get { return BackingStore?.Get<List<NdesConnector>>(nameof(NdesConnectors)); }
            set { BackingStore?.Set(nameof(NdesConnectors), value); }
        }
        /// <summary>The Notification Message Templates.</summary>
        public List<NotificationMessageTemplate> NotificationMessageTemplates {
            get { return BackingStore?.Get<List<NotificationMessageTemplate>>(nameof(NotificationMessageTemplates)); }
            set { BackingStore?.Set(nameof(NotificationMessageTemplates), value); }
        }
        /// <summary>List of OEM Warranty Statuses</summary>
        public List<Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding> OemWarrantyInformationOnboarding {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding>>(nameof(OemWarrantyInformationOnboarding)); }
            set { BackingStore?.Set(nameof(OemWarrantyInformationOnboarding), value); }
        }
        /// <summary>The list of device remote action audits with the tenant.</summary>
        public List<RemoteActionAudit> RemoteActionAudits {
            get { return BackingStore?.Get<List<RemoteActionAudit>>(nameof(RemoteActionAudits)); }
            set { BackingStore?.Set(nameof(RemoteActionAudits), value); }
        }
        /// <summary>The remote assist partners.</summary>
        public List<RemoteAssistancePartner> RemoteAssistancePartners {
            get { return BackingStore?.Get<List<RemoteAssistancePartner>>(nameof(RemoteAssistancePartners)); }
            set { BackingStore?.Set(nameof(RemoteAssistancePartners), value); }
        }
        /// <summary>The remote assistance settings singleton</summary>
        public Microsoft.Graph.Beta.Models.RemoteAssistanceSettings RemoteAssistanceSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RemoteAssistanceSettings>(nameof(RemoteAssistanceSettings)); }
            set { BackingStore?.Set(nameof(RemoteAssistanceSettings), value); }
        }
        /// <summary>Reports singleton</summary>
        public DeviceManagementReports Reports {
            get { return BackingStore?.Get<DeviceManagementReports>(nameof(Reports)); }
            set { BackingStore?.Set(nameof(Reports), value); }
        }
        /// <summary>Collection of resource access settings associated with account.</summary>
        public List<DeviceManagementResourceAccessProfileBase> ResourceAccessProfiles {
            get { return BackingStore?.Get<List<DeviceManagementResourceAccessProfileBase>>(nameof(ResourceAccessProfiles)); }
            set { BackingStore?.Set(nameof(ResourceAccessProfiles), value); }
        }
        /// <summary>The Resource Operations.</summary>
        public List<ResourceOperation> ResourceOperations {
            get { return BackingStore?.Get<List<ResourceOperation>>(nameof(ResourceOperations)); }
            set { BackingStore?.Set(nameof(ResourceOperations), value); }
        }
        /// <summary>List of all reusable settings that can be referred in a policy</summary>
        public List<DeviceManagementReusablePolicySetting> ReusablePolicySettings {
            get { return BackingStore?.Get<List<DeviceManagementReusablePolicySetting>>(nameof(ReusablePolicySettings)); }
            set { BackingStore?.Set(nameof(ReusablePolicySettings), value); }
        }
        /// <summary>List of all reusable settings</summary>
        public List<DeviceManagementConfigurationSettingDefinition> ReusableSettings {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDefinition>>(nameof(ReusableSettings)); }
            set { BackingStore?.Set(nameof(ReusableSettings), value); }
        }
        /// <summary>The Role Assignments.</summary>
        public List<DeviceAndAppManagementRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<DeviceAndAppManagementRoleAssignment>>(nameof(RoleAssignments)); }
            set { BackingStore?.Set(nameof(RoleAssignments), value); }
        }
        /// <summary>The Role Definitions.</summary>
        public List<RoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<RoleDefinition>>(nameof(RoleDefinitions)); }
            set { BackingStore?.Set(nameof(RoleDefinitions), value); }
        }
        /// <summary>The Role Scope Tags.</summary>
        public List<RoleScopeTag> RoleScopeTags {
            get { return BackingStore?.Get<List<RoleScopeTag>>(nameof(RoleScopeTags)); }
            set { BackingStore?.Set(nameof(RoleScopeTags), value); }
        }
        /// <summary>The device management intent setting definitions</summary>
        public List<DeviceManagementSettingDefinition> SettingDefinitions {
            get { return BackingStore?.Get<List<DeviceManagementSettingDefinition>>(nameof(SettingDefinitions)); }
            set { BackingStore?.Set(nameof(SettingDefinitions), value); }
        }
        /// <summary>Account level settings.</summary>
        public DeviceManagementSettings Settings {
            get { return BackingStore?.Get<DeviceManagementSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>The software update status summary.</summary>
        public Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary>(nameof(SoftwareUpdateStatusSummary)); }
            set { BackingStore?.Set(nameof(SoftwareUpdateStatusSummary), value); }
        }
        /// <summary>Tenant&apos;s Subscription. Possible values are: none, intune, office365, intunePremium, intune_EDU, intune_SMB.</summary>
        public DeviceManagementSubscriptions? Subscriptions {
            get { return BackingStore?.Get<DeviceManagementSubscriptions?>(nameof(Subscriptions)); }
            set { BackingStore?.Set(nameof(Subscriptions), value); }
        }
        /// <summary>Tenant mobile device management subscription state. Possible values are: pending, active, warning, disabled, deleted, blocked, lockedOut.</summary>
        public DeviceManagementSubscriptionState? SubscriptionState {
            get { return BackingStore?.Get<DeviceManagementSubscriptionState?>(nameof(SubscriptionState)); }
            set { BackingStore?.Set(nameof(SubscriptionState), value); }
        }
        /// <summary>The telecom expense management partners.</summary>
        public List<TelecomExpenseManagementPartner> TelecomExpenseManagementPartners {
            get { return BackingStore?.Get<List<TelecomExpenseManagementPartner>>(nameof(TelecomExpenseManagementPartners)); }
            set { BackingStore?.Set(nameof(TelecomExpenseManagementPartners), value); }
        }
        /// <summary>The available templates</summary>
        public List<DeviceManagementTemplate> Templates {
            get { return BackingStore?.Get<List<DeviceManagementTemplate>>(nameof(Templates)); }
            set { BackingStore?.Set(nameof(Templates), value); }
        }
        /// <summary>List of all TemplateSettings</summary>
        public List<DeviceManagementConfigurationSettingTemplate> TemplateSettings {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingTemplate>>(nameof(TemplateSettings)); }
            set { BackingStore?.Set(nameof(TemplateSettings), value); }
        }
        /// <summary>TenantAttach RBAC Enablement</summary>
        public Microsoft.Graph.Beta.Models.TenantAttachRBAC TenantAttachRBAC {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAttachRBAC>(nameof(TenantAttachRBAC)); }
            set { BackingStore?.Set(nameof(TenantAttachRBAC), value); }
        }
        /// <summary>The terms and conditions associated with device management of the company.</summary>
        public List<Microsoft.Graph.Beta.Models.TermsAndConditions> TermsAndConditions {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TermsAndConditions>>(nameof(TermsAndConditions)); }
            set { BackingStore?.Set(nameof(TermsAndConditions), value); }
        }
        /// <summary>The list of troubleshooting events for the tenant.</summary>
        public List<DeviceManagementTroubleshootingEvent> TroubleshootingEvents {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingEvent>>(nameof(TroubleshootingEvents)); }
            set { BackingStore?.Set(nameof(TroubleshootingEvents), value); }
        }
        /// <summary>When enabled, users assigned as administrators via Role Assignment Memberships do not require an assigned Intune license. Prior to this, only Intune licensed users were granted permissions with an Intune role unless they were assigned a role via Azure Active Directory. You are limited to 350 unlicensed direct members for each AAD security group in a role assignment, but you can assign multiple AAD security groups to a role if you need to support more than 350 unlicensed administrators. Licensed administrators are unaffected, do not have to be direct members, nor does the 350 member limit apply. This property is read-only.</summary>
        public bool? UnlicensedAdminstratorsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(UnlicensedAdminstratorsEnabled)); }
            set { BackingStore?.Set(nameof(UnlicensedAdminstratorsEnabled), value); }
        }
        /// <summary>User experience analytics appHealth Application Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance> UserExperienceAnalyticsAppHealthApplicationPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>>(nameof(UserExperienceAnalyticsAppHealthApplicationPerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthApplicationPerformance), value); }
        }
        /// <summary>User experience analytics appHealth Application Performance by App Version</summary>
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>>(nameof(UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion), value); }
        }
        /// <summary>User experience analytics appHealth Application Performance by App Version details</summary>
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>>(nameof(UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails), value); }
        }
        /// <summary>User experience analytics appHealth Application Performance by App Version Device Id</summary>
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>>(nameof(UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId), value); }
        }
        /// <summary>User experience analytics appHealth Application Performance by OS Version</summary>
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion> UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>>(nameof(UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion), value); }
        }
        /// <summary>User experience analytics appHealth Model Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance> UserExperienceAnalyticsAppHealthDeviceModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>>(nameof(UserExperienceAnalyticsAppHealthDeviceModelPerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthDeviceModelPerformance), value); }
        }
        /// <summary>User experience analytics appHealth Device Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance> UserExperienceAnalyticsAppHealthDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance>>(nameof(UserExperienceAnalyticsAppHealthDevicePerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthDevicePerformance), value); }
        }
        /// <summary>User experience analytics device performance details</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails> UserExperienceAnalyticsAppHealthDevicePerformanceDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>>(nameof(UserExperienceAnalyticsAppHealthDevicePerformanceDetails)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthDevicePerformanceDetails), value); }
        }
        /// <summary>User experience analytics appHealth OS version Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance> UserExperienceAnalyticsAppHealthOSVersionPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>>(nameof(UserExperienceAnalyticsAppHealthOSVersionPerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthOSVersionPerformance), value); }
        }
        /// <summary>User experience analytics appHealth overview</summary>
        public UserExperienceAnalyticsCategory UserExperienceAnalyticsAppHealthOverview {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>(nameof(UserExperienceAnalyticsAppHealthOverview)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsAppHealthOverview), value); }
        }
        /// <summary>User experience analytics baselines</summary>
        public List<UserExperienceAnalyticsBaseline> UserExperienceAnalyticsBaselines {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsBaseline>>(nameof(UserExperienceAnalyticsBaselines)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBaselines), value); }
        }
        /// <summary>User Experience Analytics Battery Health App Impact</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact> UserExperienceAnalyticsBatteryHealthAppImpact {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact>>(nameof(UserExperienceAnalyticsBatteryHealthAppImpact)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBatteryHealthAppImpact), value); }
        }
        /// <summary>User Experience Analytics Battery Health Capacity Details</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails UserExperienceAnalyticsBatteryHealthCapacityDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails>(nameof(UserExperienceAnalyticsBatteryHealthCapacityDetails)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBatteryHealthCapacityDetails), value); }
        }
        /// <summary>User Experience Analytics Battery Health Device App Impact</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact> UserExperienceAnalyticsBatteryHealthDeviceAppImpact {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact>>(nameof(UserExperienceAnalyticsBatteryHealthDeviceAppImpact)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBatteryHealthDeviceAppImpact), value); }
        }
        /// <summary>User Experience Analytics Battery Health Device Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance> UserExperienceAnalyticsBatteryHealthDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance>>(nameof(UserExperienceAnalyticsBatteryHealthDevicePerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBatteryHealthDevicePerformance), value); }
        }
        /// <summary>User Experience Analytics Battery Health Device Runtime History</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory> UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory>>(nameof(UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory), value); }
        }
        /// <summary>User Experience Analytics Battery Health Model Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance> UserExperienceAnalyticsBatteryHealthModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance>>(nameof(UserExperienceAnalyticsBatteryHealthModelPerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBatteryHealthModelPerformance), value); }
        }
        /// <summary>User Experience Analytics Battery Health Os Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance> UserExperienceAnalyticsBatteryHealthOsPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance>>(nameof(UserExperienceAnalyticsBatteryHealthOsPerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBatteryHealthOsPerformance), value); }
        }
        /// <summary>User Experience Analytics Battery Health Runtime Details</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails UserExperienceAnalyticsBatteryHealthRuntimeDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails>(nameof(UserExperienceAnalyticsBatteryHealthRuntimeDetails)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsBatteryHealthRuntimeDetails), value); }
        }
        /// <summary>User experience analytics categories</summary>
        public List<UserExperienceAnalyticsCategory> UserExperienceAnalyticsCategories {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsCategory>>(nameof(UserExperienceAnalyticsCategories)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsCategories), value); }
        }
        /// <summary>User experience analytics device metric history</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory> UserExperienceAnalyticsDeviceMetricHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>>(nameof(UserExperienceAnalyticsDeviceMetricHistory)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDeviceMetricHistory), value); }
        }
        /// <summary>User experience analytics device performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance> UserExperienceAnalyticsDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance>>(nameof(UserExperienceAnalyticsDevicePerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDevicePerformance), value); }
        }
        /// <summary>The user experience analytics device scope entity endpoint to trigger on the service to either START or STOP computing metrics data based on a device scope configuration.</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope UserExperienceAnalyticsDeviceScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>(nameof(UserExperienceAnalyticsDeviceScope)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDeviceScope), value); }
        }
        /// <summary>The user experience analytics device scope entity contains device scope configuration use to apply filtering on the endpoint analytics reports.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope> UserExperienceAnalyticsDeviceScopes {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>>(nameof(UserExperienceAnalyticsDeviceScopes)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDeviceScopes), value); }
        }
        /// <summary>User experience analytics device scores</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores> UserExperienceAnalyticsDeviceScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores>>(nameof(UserExperienceAnalyticsDeviceScores)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDeviceScores), value); }
        }
        /// <summary>User experience analytics device Startup History</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory> UserExperienceAnalyticsDeviceStartupHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory>>(nameof(UserExperienceAnalyticsDeviceStartupHistory)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDeviceStartupHistory), value); }
        }
        /// <summary>User experience analytics device Startup Processes</summary>
        public List<UserExperienceAnalyticsDeviceStartupProcess> UserExperienceAnalyticsDeviceStartupProcesses {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsDeviceStartupProcess>>(nameof(UserExperienceAnalyticsDeviceStartupProcesses)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDeviceStartupProcesses), value); }
        }
        /// <summary>User experience analytics device Startup Process Performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance> UserExperienceAnalyticsDeviceStartupProcessPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance>>(nameof(UserExperienceAnalyticsDeviceStartupProcessPerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDeviceStartupProcessPerformance), value); }
        }
        /// <summary>User experience analytics devices without cloud identity.</summary>
        public List<UserExperienceAnalyticsDeviceWithoutCloudIdentity> UserExperienceAnalyticsDevicesWithoutCloudIdentity {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsDeviceWithoutCloudIdentity>>(nameof(UserExperienceAnalyticsDevicesWithoutCloudIdentity)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsDevicesWithoutCloudIdentity), value); }
        }
        /// <summary>User experience analytics impacting process</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess> UserExperienceAnalyticsImpactingProcess {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess>>(nameof(UserExperienceAnalyticsImpactingProcess)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsImpactingProcess), value); }
        }
        /// <summary>User experience analytics metric history</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory> UserExperienceAnalyticsMetricHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>>(nameof(UserExperienceAnalyticsMetricHistory)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsMetricHistory), value); }
        }
        /// <summary>User experience analytics model scores</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores> UserExperienceAnalyticsModelScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores>>(nameof(UserExperienceAnalyticsModelScores)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsModelScores), value); }
        }
        /// <summary>User experience analytics devices not Windows Autopilot ready.</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice> UserExperienceAnalyticsNotAutopilotReadyDevice {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice>>(nameof(UserExperienceAnalyticsNotAutopilotReadyDevice)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsNotAutopilotReadyDevice), value); }
        }
        /// <summary>User experience analytics overview</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview UserExperienceAnalyticsOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview>(nameof(UserExperienceAnalyticsOverview)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsOverview), value); }
        }
        /// <summary>User experience analytics regression summary</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRegressionSummary UserExperienceAnalyticsRegressionSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRegressionSummary>(nameof(UserExperienceAnalyticsRegressionSummary)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsRegressionSummary), value); }
        }
        /// <summary>User experience analytics remote connection</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection> UserExperienceAnalyticsRemoteConnection {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection>>(nameof(UserExperienceAnalyticsRemoteConnection)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsRemoteConnection), value); }
        }
        /// <summary>User experience analytics resource performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance> UserExperienceAnalyticsResourcePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance>>(nameof(UserExperienceAnalyticsResourcePerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsResourcePerformance), value); }
        }
        /// <summary>User experience analytics device Startup Score History</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory> UserExperienceAnalyticsScoreHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory>>(nameof(UserExperienceAnalyticsScoreHistory)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsScoreHistory), value); }
        }
        /// <summary>User experience analytics device settings</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings UserExperienceAnalyticsSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings>(nameof(UserExperienceAnalyticsSettings)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsSettings), value); }
        }
        /// <summary>User experience analytics work from anywhere hardware readiness metrics.</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>(nameof(UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric), value); }
        }
        /// <summary>User experience analytics work from anywhere metrics.</summary>
        public List<UserExperienceAnalyticsWorkFromAnywhereMetric> UserExperienceAnalyticsWorkFromAnywhereMetrics {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsWorkFromAnywhereMetric>>(nameof(UserExperienceAnalyticsWorkFromAnywhereMetrics)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsWorkFromAnywhereMetrics), value); }
        }
        /// <summary>The user experience analytics work from anywhere model performance</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance> UserExperienceAnalyticsWorkFromAnywhereModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>>(nameof(UserExperienceAnalyticsWorkFromAnywhereModelPerformance)); }
            set { BackingStore?.Set(nameof(UserExperienceAnalyticsWorkFromAnywhereModelPerformance), value); }
        }
        /// <summary>Collection of PFX certificates associated with a user.</summary>
        public List<UserPFXCertificate> UserPfxCertificates {
            get { return BackingStore?.Get<List<UserPFXCertificate>>(nameof(UserPfxCertificates)); }
            set { BackingStore?.Set(nameof(UserPfxCertificates), value); }
        }
        /// <summary>The virtualEndpoint property</summary>
        public Microsoft.Graph.Beta.Models.VirtualEndpoint VirtualEndpoint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VirtualEndpoint>(nameof(VirtualEndpoint)); }
            set { BackingStore?.Set(nameof(VirtualEndpoint), value); }
        }
        /// <summary>Windows auto pilot deployment profiles</summary>
        public List<WindowsAutopilotDeploymentProfile> WindowsAutopilotDeploymentProfiles {
            get { return BackingStore?.Get<List<WindowsAutopilotDeploymentProfile>>(nameof(WindowsAutopilotDeploymentProfiles)); }
            set { BackingStore?.Set(nameof(WindowsAutopilotDeploymentProfiles), value); }
        }
        /// <summary>The Windows autopilot device identities contained collection.</summary>
        public List<WindowsAutopilotDeviceIdentity> WindowsAutopilotDeviceIdentities {
            get { return BackingStore?.Get<List<WindowsAutopilotDeviceIdentity>>(nameof(WindowsAutopilotDeviceIdentities)); }
            set { BackingStore?.Set(nameof(WindowsAutopilotDeviceIdentities), value); }
        }
        /// <summary>The Windows autopilot account settings.</summary>
        public Microsoft.Graph.Beta.Models.WindowsAutopilotSettings WindowsAutopilotSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotSettings>(nameof(WindowsAutopilotSettings)); }
            set { BackingStore?.Set(nameof(WindowsAutopilotSettings), value); }
        }
        /// <summary>A collection of windows driver update profiles</summary>
        public List<WindowsDriverUpdateProfile> WindowsDriverUpdateProfiles {
            get { return BackingStore?.Get<List<WindowsDriverUpdateProfile>>(nameof(WindowsDriverUpdateProfiles)); }
            set { BackingStore?.Set(nameof(WindowsDriverUpdateProfiles), value); }
        }
        /// <summary>A collection of windows feature update profiles</summary>
        public List<WindowsFeatureUpdateProfile> WindowsFeatureUpdateProfiles {
            get { return BackingStore?.Get<List<WindowsFeatureUpdateProfile>>(nameof(WindowsFeatureUpdateProfiles)); }
            set { BackingStore?.Set(nameof(WindowsFeatureUpdateProfiles), value); }
        }
        /// <summary>The windows information protection app learning summaries.</summary>
        public List<WindowsInformationProtectionAppLearningSummary> WindowsInformationProtectionAppLearningSummaries {
            get { return BackingStore?.Get<List<WindowsInformationProtectionAppLearningSummary>>(nameof(WindowsInformationProtectionAppLearningSummaries)); }
            set { BackingStore?.Set(nameof(WindowsInformationProtectionAppLearningSummaries), value); }
        }
        /// <summary>The windows information protection network learning summaries.</summary>
        public List<WindowsInformationProtectionNetworkLearningSummary> WindowsInformationProtectionNetworkLearningSummaries {
            get { return BackingStore?.Get<List<WindowsInformationProtectionNetworkLearningSummary>>(nameof(WindowsInformationProtectionNetworkLearningSummaries)); }
            set { BackingStore?.Set(nameof(WindowsInformationProtectionNetworkLearningSummaries), value); }
        }
        /// <summary>The list of affected malware in the tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.WindowsMalwareInformation> WindowsMalwareInformation {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsMalwareInformation>>(nameof(WindowsMalwareInformation)); }
            set { BackingStore?.Set(nameof(WindowsMalwareInformation), value); }
        }
        /// <summary>Malware overview for windows devices.</summary>
        public Microsoft.Graph.Beta.Models.WindowsMalwareOverview WindowsMalwareOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsMalwareOverview>(nameof(WindowsMalwareOverview)); }
            set { BackingStore?.Set(nameof(WindowsMalwareOverview), value); }
        }
        /// <summary>A collection of windows quality update profiles</summary>
        public List<WindowsQualityUpdateProfile> WindowsQualityUpdateProfiles {
            get { return BackingStore?.Get<List<WindowsQualityUpdateProfile>>(nameof(WindowsQualityUpdateProfiles)); }
            set { BackingStore?.Set(nameof(WindowsQualityUpdateProfiles), value); }
        }
        /// <summary>A collection of windows update catalog items (fetaure updates item , quality updates item)</summary>
        public List<WindowsUpdateCatalogItem> WindowsUpdateCatalogItems {
            get { return BackingStore?.Get<List<WindowsUpdateCatalogItem>>(nameof(WindowsUpdateCatalogItems)); }
            set { BackingStore?.Set(nameof(WindowsUpdateCatalogItems), value); }
        }
        /// <summary>The Collection of ZebraFotaArtifacts.</summary>
        public List<ZebraFotaArtifact> ZebraFotaArtifacts {
            get { return BackingStore?.Get<List<ZebraFotaArtifact>>(nameof(ZebraFotaArtifacts)); }
            set { BackingStore?.Set(nameof(ZebraFotaArtifacts), value); }
        }
        /// <summary>The singleton ZebraFotaConnector associated with account.</summary>
        public Microsoft.Graph.Beta.Models.ZebraFotaConnector ZebraFotaConnector {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ZebraFotaConnector>(nameof(ZebraFotaConnector)); }
            set { BackingStore?.Set(nameof(ZebraFotaConnector), value); }
        }
        /// <summary>Collection of ZebraFotaDeployments associated with account.</summary>
        public List<ZebraFotaDeployment> ZebraFotaDeployments {
            get { return BackingStore?.Get<List<ZebraFotaDeployment>>(nameof(ZebraFotaDeployments)); }
            set { BackingStore?.Set(nameof(ZebraFotaDeployments), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"androidDeviceOwnerEnrollmentProfiles", n => { AndroidDeviceOwnerEnrollmentProfiles = n.GetCollectionOfObjectValues<AndroidDeviceOwnerEnrollmentProfile>(AndroidDeviceOwnerEnrollmentProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"androidForWorkAppConfigurationSchemas", n => { AndroidForWorkAppConfigurationSchemas = n.GetCollectionOfObjectValues<AndroidForWorkAppConfigurationSchema>(AndroidForWorkAppConfigurationSchema.CreateFromDiscriminatorValue).ToList(); } },
                {"androidForWorkEnrollmentProfiles", n => { AndroidForWorkEnrollmentProfiles = n.GetCollectionOfObjectValues<AndroidForWorkEnrollmentProfile>(AndroidForWorkEnrollmentProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"androidForWorkSettings", n => { AndroidForWorkSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.AndroidForWorkSettings>(Microsoft.Graph.Beta.Models.AndroidForWorkSettings.CreateFromDiscriminatorValue); } },
                {"androidManagedStoreAccountEnterpriseSettings", n => { AndroidManagedStoreAccountEnterpriseSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>(Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings.CreateFromDiscriminatorValue); } },
                {"androidManagedStoreAppConfigurationSchemas", n => { AndroidManagedStoreAppConfigurationSchemas = n.GetCollectionOfObjectValues<AndroidManagedStoreAppConfigurationSchema>(AndroidManagedStoreAppConfigurationSchema.CreateFromDiscriminatorValue).ToList(); } },
                {"applePushNotificationCertificate", n => { ApplePushNotificationCertificate = n.GetObjectValue<Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate>(Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate.CreateFromDiscriminatorValue); } },
                {"appleUserInitiatedEnrollmentProfiles", n => { AppleUserInitiatedEnrollmentProfiles = n.GetCollectionOfObjectValues<AppleUserInitiatedEnrollmentProfile>(AppleUserInitiatedEnrollmentProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"assignmentFilters", n => { AssignmentFilters = n.GetCollectionOfObjectValues<DeviceAndAppManagementAssignmentFilter>(DeviceAndAppManagementAssignmentFilter.CreateFromDiscriminatorValue).ToList(); } },
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>(AuditEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"autopilotEvents", n => { AutopilotEvents = n.GetCollectionOfObjectValues<DeviceManagementAutopilotEvent>(DeviceManagementAutopilotEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"cartToClassAssociations", n => { CartToClassAssociations = n.GetCollectionOfObjectValues<CartToClassAssociation>(CartToClassAssociation.CreateFromDiscriminatorValue).ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<DeviceManagementSettingCategory>(DeviceManagementSettingCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"certificateConnectorDetails", n => { CertificateConnectorDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CertificateConnectorDetails>(Microsoft.Graph.Beta.Models.CertificateConnectorDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"chromeOSOnboardingSettings", n => { ChromeOSOnboardingSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings>(Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPCConnectivityIssues", n => { CloudPCConnectivityIssues = n.GetCollectionOfObjectValues<CloudPCConnectivityIssue>(CloudPCConnectivityIssue.CreateFromDiscriminatorValue).ToList(); } },
                {"comanagedDevices", n => { ComanagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"comanagementEligibleDevices", n => { ComanagementEligibleDevices = n.GetCollectionOfObjectValues<ComanagementEligibleDevice>(ComanagementEligibleDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"complianceCategories", n => { ComplianceCategories = n.GetCollectionOfObjectValues<DeviceManagementConfigurationCategory>(DeviceManagementConfigurationCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"complianceManagementPartners", n => { ComplianceManagementPartners = n.GetCollectionOfObjectValues<ComplianceManagementPartner>(ComplianceManagementPartner.CreateFromDiscriminatorValue).ToList(); } },
                {"compliancePolicies", n => { CompliancePolicies = n.GetCollectionOfObjectValues<DeviceManagementCompliancePolicy>(DeviceManagementCompliancePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"complianceSettings", n => { ComplianceSettings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>(DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccessSettings", n => { ConditionalAccessSettings = n.GetObjectValue<OnPremisesConditionalAccessSettings>(OnPremisesConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                {"configManagerCollections", n => { ConfigManagerCollections = n.GetCollectionOfObjectValues<ConfigManagerCollection>(ConfigManagerCollection.CreateFromDiscriminatorValue).ToList(); } },
                {"configurationCategories", n => { ConfigurationCategories = n.GetCollectionOfObjectValues<DeviceManagementConfigurationCategory>(DeviceManagementConfigurationCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"configurationPolicies", n => { ConfigurationPolicies = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicy>(DeviceManagementConfigurationPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"configurationPolicyTemplates", n => { ConfigurationPolicyTemplates = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicyTemplate>(DeviceManagementConfigurationPolicyTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"configurationSettings", n => { ConfigurationSettings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>(DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"dataSharingConsents", n => { DataSharingConsents = n.GetCollectionOfObjectValues<DataSharingConsent>(DataSharingConsent.CreateFromDiscriminatorValue).ToList(); } },
                {"depOnboardingSettings", n => { DepOnboardingSettings = n.GetCollectionOfObjectValues<DepOnboardingSetting>(DepOnboardingSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"derivedCredentials", n => { DerivedCredentials = n.GetCollectionOfObjectValues<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue).ToList(); } },
                {"detectedApps", n => { DetectedApps = n.GetCollectionOfObjectValues<DetectedApp>(DetectedApp.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCategories", n => { DeviceCategories = n.GetCollectionOfObjectValues<DeviceCategory>(DeviceCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCompliancePolicies", n => { DeviceCompliancePolicies = n.GetCollectionOfObjectValues<DeviceCompliancePolicy>(DeviceCompliancePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCompliancePolicyDeviceStateSummary", n => { DeviceCompliancePolicyDeviceStateSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary>(Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>(DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceComplianceReportSummarizationDateTime", n => { DeviceComplianceReportSummarizationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceComplianceScripts", n => { DeviceComplianceScripts = n.GetCollectionOfObjectValues<DeviceComplianceScript>(DeviceComplianceScript.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationConflictSummary", n => { DeviceConfigurationConflictSummary = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary>(Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationDeviceStateSummaries", n => { DeviceConfigurationDeviceStateSummaries = n.GetObjectValue<DeviceConfigurationDeviceStateSummary>(DeviceConfigurationDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceConfigurationRestrictedAppsViolations", n => { DeviceConfigurationRestrictedAppsViolations = n.GetCollectionOfObjectValues<RestrictedAppsViolation>(RestrictedAppsViolation.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurations", n => { DeviceConfigurations = n.GetCollectionOfObjectValues<DeviceConfiguration>(DeviceConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationsAllManagedDeviceCertificateStates", n => { DeviceConfigurationsAllManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedAllDeviceCertificateState>(ManagedAllDeviceCertificateState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationUserStateSummaries", n => { DeviceConfigurationUserStateSummaries = n.GetObjectValue<DeviceConfigurationUserStateSummary>(DeviceConfigurationUserStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceCustomAttributeShellScripts", n => { DeviceCustomAttributeShellScripts = n.GetCollectionOfObjectValues<DeviceCustomAttributeShellScript>(DeviceCustomAttributeShellScript.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceEnrollmentConfigurations", n => { DeviceEnrollmentConfigurations = n.GetCollectionOfObjectValues<DeviceEnrollmentConfiguration>(DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceHealthScripts", n => { DeviceHealthScripts = n.GetCollectionOfObjectValues<DeviceHealthScript>(DeviceHealthScript.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceManagementPartners", n => { DeviceManagementPartners = n.GetCollectionOfObjectValues<DeviceManagementPartner>(DeviceManagementPartner.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceManagementScripts", n => { DeviceManagementScripts = n.GetCollectionOfObjectValues<DeviceManagementScript>(DeviceManagementScript.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceProtectionOverview", n => { DeviceProtectionOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceProtectionOverview>(Microsoft.Graph.Beta.Models.DeviceProtectionOverview.CreateFromDiscriminatorValue); } },
                {"deviceShellScripts", n => { DeviceShellScripts = n.GetCollectionOfObjectValues<DeviceShellScript>(DeviceShellScript.CreateFromDiscriminatorValue).ToList(); } },
                {"domainJoinConnectors", n => { DomainJoinConnectors = n.GetCollectionOfObjectValues<DeviceManagementDomainJoinConnector>(DeviceManagementDomainJoinConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"embeddedSIMActivationCodePools", n => { EmbeddedSIMActivationCodePools = n.GetCollectionOfObjectValues<EmbeddedSIMActivationCodePool>(EmbeddedSIMActivationCodePool.CreateFromDiscriminatorValue).ToList(); } },
                {"exchangeConnectors", n => { ExchangeConnectors = n.GetCollectionOfObjectValues<DeviceManagementExchangeConnector>(DeviceManagementExchangeConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"exchangeOnPremisesPolicies", n => { ExchangeOnPremisesPolicies = n.GetCollectionOfObjectValues<DeviceManagementExchangeOnPremisesPolicy>(DeviceManagementExchangeOnPremisesPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"exchangeOnPremisesPolicy", n => { ExchangeOnPremisesPolicy = n.GetObjectValue<DeviceManagementExchangeOnPremisesPolicy>(DeviceManagementExchangeOnPremisesPolicy.CreateFromDiscriminatorValue); } },
                {"groupPolicyCategories", n => { GroupPolicyCategories = n.GetCollectionOfObjectValues<GroupPolicyCategory>(GroupPolicyCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"groupPolicyConfigurations", n => { GroupPolicyConfigurations = n.GetCollectionOfObjectValues<GroupPolicyConfiguration>(GroupPolicyConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"groupPolicyDefinitionFiles", n => { GroupPolicyDefinitionFiles = n.GetCollectionOfObjectValues<GroupPolicyDefinitionFile>(GroupPolicyDefinitionFile.CreateFromDiscriminatorValue).ToList(); } },
                {"groupPolicyDefinitions", n => { GroupPolicyDefinitions = n.GetCollectionOfObjectValues<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"groupPolicyMigrationReports", n => { GroupPolicyMigrationReports = n.GetCollectionOfObjectValues<GroupPolicyMigrationReport>(GroupPolicyMigrationReport.CreateFromDiscriminatorValue).ToList(); } },
                {"groupPolicyObjectFiles", n => { GroupPolicyObjectFiles = n.GetCollectionOfObjectValues<GroupPolicyObjectFile>(GroupPolicyObjectFile.CreateFromDiscriminatorValue).ToList(); } },
                {"groupPolicyUploadedDefinitionFiles", n => { GroupPolicyUploadedDefinitionFiles = n.GetCollectionOfObjectValues<GroupPolicyUploadedDefinitionFile>(GroupPolicyUploadedDefinitionFile.CreateFromDiscriminatorValue).ToList(); } },
                {"importedDeviceIdentities", n => { ImportedDeviceIdentities = n.GetCollectionOfObjectValues<ImportedDeviceIdentity>(ImportedDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"importedWindowsAutopilotDeviceIdentities", n => { ImportedWindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>(ImportedWindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"intents", n => { Intents = n.GetCollectionOfObjectValues<DeviceManagementIntent>(DeviceManagementIntent.CreateFromDiscriminatorValue).ToList(); } },
                {"intuneAccountId", n => { IntuneAccountId = n.GetStringValue(); } },
                {"intuneBrand", n => { IntuneBrand = n.GetObjectValue<Microsoft.Graph.Beta.Models.IntuneBrand>(Microsoft.Graph.Beta.Models.IntuneBrand.CreateFromDiscriminatorValue); } },
                {"intuneBrandingProfiles", n => { IntuneBrandingProfiles = n.GetCollectionOfObjectValues<IntuneBrandingProfile>(IntuneBrandingProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"iosUpdateStatuses", n => { IosUpdateStatuses = n.GetCollectionOfObjectValues<IosUpdateDeviceStatus>(IosUpdateDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"lastReportAggregationDateTime", n => { LastReportAggregationDateTime = n.GetDateTimeOffsetValue(); } },
                {"legacyPcManangementEnabled", n => { LegacyPcManangementEnabled = n.GetBoolValue(); } },
                {"macOSSoftwareUpdateAccountSummaries", n => { MacOSSoftwareUpdateAccountSummaries = n.GetCollectionOfObjectValues<MacOSSoftwareUpdateAccountSummary>(MacOSSoftwareUpdateAccountSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceCleanupSettings", n => { ManagedDeviceCleanupSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings>(Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings.CreateFromDiscriminatorValue); } },
                {"managedDeviceEncryptionStates", n => { ManagedDeviceEncryptionStates = n.GetCollectionOfObjectValues<ManagedDeviceEncryptionState>(ManagedDeviceEncryptionState.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceOverview", n => { ManagedDeviceOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceOverview>(Microsoft.Graph.Beta.Models.ManagedDeviceOverview.CreateFromDiscriminatorValue); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"maximumDepTokens", n => { MaximumDepTokens = n.GetIntValue(); } },
                {"microsoftTunnelConfigurations", n => { MicrosoftTunnelConfigurations = n.GetCollectionOfObjectValues<MicrosoftTunnelConfiguration>(MicrosoftTunnelConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftTunnelHealthThresholds", n => { MicrosoftTunnelHealthThresholds = n.GetCollectionOfObjectValues<MicrosoftTunnelHealthThreshold>(MicrosoftTunnelHealthThreshold.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftTunnelServerLogCollectionResponses", n => { MicrosoftTunnelServerLogCollectionResponses = n.GetCollectionOfObjectValues<MicrosoftTunnelServerLogCollectionResponse>(MicrosoftTunnelServerLogCollectionResponse.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftTunnelSites", n => { MicrosoftTunnelSites = n.GetCollectionOfObjectValues<MicrosoftTunnelSite>(MicrosoftTunnelSite.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileAppTroubleshootingEvents", n => { MobileAppTroubleshootingEvents = n.GetCollectionOfObjectValues<MobileAppTroubleshootingEvent>(MobileAppTroubleshootingEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileThreatDefenseConnectors", n => { MobileThreatDefenseConnectors = n.GetCollectionOfObjectValues<MobileThreatDefenseConnector>(MobileThreatDefenseConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"ndesConnectors", n => { NdesConnectors = n.GetCollectionOfObjectValues<NdesConnector>(NdesConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"notificationMessageTemplates", n => { NotificationMessageTemplates = n.GetCollectionOfObjectValues<NotificationMessageTemplate>(NotificationMessageTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"oemWarrantyInformationOnboarding", n => { OemWarrantyInformationOnboarding = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding>(Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding.CreateFromDiscriminatorValue).ToList(); } },
                {"remoteActionAudits", n => { RemoteActionAudits = n.GetCollectionOfObjectValues<RemoteActionAudit>(RemoteActionAudit.CreateFromDiscriminatorValue).ToList(); } },
                {"remoteAssistancePartners", n => { RemoteAssistancePartners = n.GetCollectionOfObjectValues<RemoteAssistancePartner>(RemoteAssistancePartner.CreateFromDiscriminatorValue).ToList(); } },
                {"remoteAssistanceSettings", n => { RemoteAssistanceSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.RemoteAssistanceSettings>(Microsoft.Graph.Beta.Models.RemoteAssistanceSettings.CreateFromDiscriminatorValue); } },
                {"reports", n => { Reports = n.GetObjectValue<DeviceManagementReports>(DeviceManagementReports.CreateFromDiscriminatorValue); } },
                {"resourceAccessProfiles", n => { ResourceAccessProfiles = n.GetCollectionOfObjectValues<DeviceManagementResourceAccessProfileBase>(DeviceManagementResourceAccessProfileBase.CreateFromDiscriminatorValue).ToList(); } },
                {"resourceOperations", n => { ResourceOperations = n.GetCollectionOfObjectValues<ResourceOperation>(ResourceOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"reusablePolicySettings", n => { ReusablePolicySettings = n.GetCollectionOfObjectValues<DeviceManagementReusablePolicySetting>(DeviceManagementReusablePolicySetting.CreateFromDiscriminatorValue).ToList(); } },
                {"reusableSettings", n => { ReusableSettings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>(DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>(DeviceAndAppManagementRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<RoleDefinition>(RoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"roleScopeTags", n => { RoleScopeTags = n.GetCollectionOfObjectValues<RoleScopeTag>(RoleScopeTag.CreateFromDiscriminatorValue).ToList(); } },
                {"settingDefinitions", n => { SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementSettingDefinition>(DeviceManagementSettingDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<DeviceManagementSettings>(DeviceManagementSettings.CreateFromDiscriminatorValue); } },
                {"softwareUpdateStatusSummary", n => { SoftwareUpdateStatusSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary>(Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { Subscriptions = n.GetEnumValue<DeviceManagementSubscriptions>(); } },
                {"subscriptionState", n => { SubscriptionState = n.GetEnumValue<DeviceManagementSubscriptionState>(); } },
                {"telecomExpenseManagementPartners", n => { TelecomExpenseManagementPartners = n.GetCollectionOfObjectValues<TelecomExpenseManagementPartner>(TelecomExpenseManagementPartner.CreateFromDiscriminatorValue).ToList(); } },
                {"templates", n => { Templates = n.GetCollectionOfObjectValues<DeviceManagementTemplate>(DeviceManagementTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"templateSettings", n => { TemplateSettings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingTemplate>(DeviceManagementConfigurationSettingTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantAttachRBAC", n => { TenantAttachRBAC = n.GetObjectValue<Microsoft.Graph.Beta.Models.TenantAttachRBAC>(Microsoft.Graph.Beta.Models.TenantAttachRBAC.CreateFromDiscriminatorValue); } },
                {"termsAndConditions", n => { TermsAndConditions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TermsAndConditions>(Microsoft.Graph.Beta.Models.TermsAndConditions.CreateFromDiscriminatorValue).ToList(); } },
                {"troubleshootingEvents", n => { TroubleshootingEvents = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>(DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"unlicensedAdminstratorsEnabled", n => { UnlicensedAdminstratorsEnabled = n.GetBoolValue(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformance", n => { UserExperienceAnalyticsAppHealthApplicationPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>(UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthDeviceModelPerformance", n => { UserExperienceAnalyticsAppHealthDeviceModelPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformance", n => { UserExperienceAnalyticsAppHealthDevicePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformanceDetails", n => { UserExperienceAnalyticsAppHealthDevicePerformanceDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthOSVersionPerformance", n => { UserExperienceAnalyticsAppHealthOSVersionPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsAppHealthOverview", n => { UserExperienceAnalyticsAppHealthOverview = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsBaselines", n => { UserExperienceAnalyticsBaselines = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBaseline>(UserExperienceAnalyticsBaseline.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsBatteryHealthAppImpact", n => { UserExperienceAnalyticsBatteryHealthAppImpact = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsBatteryHealthCapacityDetails", n => { UserExperienceAnalyticsBatteryHealthCapacityDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsBatteryHealthDeviceAppImpact", n => { UserExperienceAnalyticsBatteryHealthDeviceAppImpact = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsBatteryHealthDevicePerformance", n => { UserExperienceAnalyticsBatteryHealthDevicePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory", n => { UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsBatteryHealthModelPerformance", n => { UserExperienceAnalyticsBatteryHealthModelPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsBatteryHealthOsPerformance", n => { UserExperienceAnalyticsBatteryHealthOsPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsBatteryHealthRuntimeDetails", n => { UserExperienceAnalyticsBatteryHealthRuntimeDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsCategories", n => { UserExperienceAnalyticsCategories = n.GetCollectionOfObjectValues<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsDeviceMetricHistory", n => { UserExperienceAnalyticsDeviceMetricHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsDevicePerformance", n => { UserExperienceAnalyticsDevicePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsDeviceScope", n => { UserExperienceAnalyticsDeviceScope = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsDeviceScopes", n => { UserExperienceAnalyticsDeviceScopes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsDeviceScores", n => { UserExperienceAnalyticsDeviceScores = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsDeviceStartupHistory", n => { UserExperienceAnalyticsDeviceStartupHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsDeviceStartupProcesses", n => { UserExperienceAnalyticsDeviceStartupProcesses = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcess>(UserExperienceAnalyticsDeviceStartupProcess.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsDeviceStartupProcessPerformance", n => { UserExperienceAnalyticsDeviceStartupProcessPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsDevicesWithoutCloudIdentity", n => { UserExperienceAnalyticsDevicesWithoutCloudIdentity = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(UserExperienceAnalyticsDeviceWithoutCloudIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsImpactingProcess", n => { UserExperienceAnalyticsImpactingProcess = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsMetricHistory", n => { UserExperienceAnalyticsMetricHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsModelScores", n => { UserExperienceAnalyticsModelScores = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsNotAutopilotReadyDevice", n => { UserExperienceAnalyticsNotAutopilotReadyDevice = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsOverview", n => { UserExperienceAnalyticsOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsRegressionSummary", n => { UserExperienceAnalyticsRegressionSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRegressionSummary>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRegressionSummary.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsRemoteConnection", n => { UserExperienceAnalyticsRemoteConnection = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsResourcePerformance", n => { UserExperienceAnalyticsResourcePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsScoreHistory", n => { UserExperienceAnalyticsScoreHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsSettings", n => { UserExperienceAnalyticsSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", n => { UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsWorkFromAnywhereMetrics", n => { UserExperienceAnalyticsWorkFromAnywhereMetrics = n.GetCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereMetric>(UserExperienceAnalyticsWorkFromAnywhereMetric.CreateFromDiscriminatorValue).ToList(); } },
                {"userExperienceAnalyticsWorkFromAnywhereModelPerformance", n => { UserExperienceAnalyticsWorkFromAnywhereModelPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance.CreateFromDiscriminatorValue).ToList(); } },
                {"userPfxCertificates", n => { UserPfxCertificates = n.GetCollectionOfObjectValues<UserPFXCertificate>(UserPFXCertificate.CreateFromDiscriminatorValue).ToList(); } },
                {"virtualEndpoint", n => { VirtualEndpoint = n.GetObjectValue<Microsoft.Graph.Beta.Models.VirtualEndpoint>(Microsoft.Graph.Beta.Models.VirtualEndpoint.CreateFromDiscriminatorValue); } },
                {"windowsAutopilotDeploymentProfiles", n => { WindowsAutopilotDeploymentProfiles = n.GetCollectionOfObjectValues<WindowsAutopilotDeploymentProfile>(WindowsAutopilotDeploymentProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsAutopilotDeviceIdentities", n => { WindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>(WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsAutopilotSettings", n => { WindowsAutopilotSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsAutopilotSettings>(Microsoft.Graph.Beta.Models.WindowsAutopilotSettings.CreateFromDiscriminatorValue); } },
                {"windowsDriverUpdateProfiles", n => { WindowsDriverUpdateProfiles = n.GetCollectionOfObjectValues<WindowsDriverUpdateProfile>(WindowsDriverUpdateProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsFeatureUpdateProfiles", n => { WindowsFeatureUpdateProfiles = n.GetCollectionOfObjectValues<WindowsFeatureUpdateProfile>(WindowsFeatureUpdateProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionAppLearningSummaries", n => { WindowsInformationProtectionAppLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>(WindowsInformationProtectionAppLearningSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionNetworkLearningSummaries", n => { WindowsInformationProtectionNetworkLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>(WindowsInformationProtectionNetworkLearningSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsMalwareInformation", n => { WindowsMalwareInformation = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsMalwareInformation>(Microsoft.Graph.Beta.Models.WindowsMalwareInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsMalwareOverview", n => { WindowsMalwareOverview = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsMalwareOverview>(Microsoft.Graph.Beta.Models.WindowsMalwareOverview.CreateFromDiscriminatorValue); } },
                {"windowsQualityUpdateProfiles", n => { WindowsQualityUpdateProfiles = n.GetCollectionOfObjectValues<WindowsQualityUpdateProfile>(WindowsQualityUpdateProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsUpdateCatalogItems", n => { WindowsUpdateCatalogItems = n.GetCollectionOfObjectValues<WindowsUpdateCatalogItem>(WindowsUpdateCatalogItem.CreateFromDiscriminatorValue).ToList(); } },
                {"zebraFotaArtifacts", n => { ZebraFotaArtifacts = n.GetCollectionOfObjectValues<ZebraFotaArtifact>(ZebraFotaArtifact.CreateFromDiscriminatorValue).ToList(); } },
                {"zebraFotaConnector", n => { ZebraFotaConnector = n.GetObjectValue<Microsoft.Graph.Beta.Models.ZebraFotaConnector>(Microsoft.Graph.Beta.Models.ZebraFotaConnector.CreateFromDiscriminatorValue); } },
                {"zebraFotaDeployments", n => { ZebraFotaDeployments = n.GetCollectionOfObjectValues<ZebraFotaDeployment>(ZebraFotaDeployment.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AdminConsent>("adminConsent", AdminConsent);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AdvancedThreatProtectionOnboardingStateSummary>("advancedThreatProtectionOnboardingStateSummary", AdvancedThreatProtectionOnboardingStateSummary);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerEnrollmentProfile>("androidDeviceOwnerEnrollmentProfiles", AndroidDeviceOwnerEnrollmentProfiles);
            writer.WriteCollectionOfObjectValues<AndroidForWorkAppConfigurationSchema>("androidForWorkAppConfigurationSchemas", AndroidForWorkAppConfigurationSchemas);
            writer.WriteCollectionOfObjectValues<AndroidForWorkEnrollmentProfile>("androidForWorkEnrollmentProfiles", AndroidForWorkEnrollmentProfiles);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AndroidForWorkSettings>("androidForWorkSettings", AndroidForWorkSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AndroidManagedStoreAccountEnterpriseSettings>("androidManagedStoreAccountEnterpriseSettings", AndroidManagedStoreAccountEnterpriseSettings);
            writer.WriteCollectionOfObjectValues<AndroidManagedStoreAppConfigurationSchema>("androidManagedStoreAppConfigurationSchemas", AndroidManagedStoreAppConfigurationSchemas);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ApplePushNotificationCertificate>("applePushNotificationCertificate", ApplePushNotificationCertificate);
            writer.WriteCollectionOfObjectValues<AppleUserInitiatedEnrollmentProfile>("appleUserInitiatedEnrollmentProfiles", AppleUserInitiatedEnrollmentProfiles);
            writer.WriteCollectionOfObjectValues<DeviceAndAppManagementAssignmentFilter>("assignmentFilters", AssignmentFilters);
            writer.WriteCollectionOfObjectValues<AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<DeviceManagementAutopilotEvent>("autopilotEvents", AutopilotEvents);
            writer.WriteCollectionOfObjectValues<CartToClassAssociation>("cartToClassAssociations", CartToClassAssociations);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingCategory>("categories", Categories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CertificateConnectorDetails>("certificateConnectorDetails", CertificateConnectorDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ChromeOSOnboardingSettings>("chromeOSOnboardingSettings", ChromeOSOnboardingSettings);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary", DeviceCompliancePolicyDeviceStateSummary);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteDateTimeOffsetValue("deviceComplianceReportSummarizationDateTime", DeviceComplianceReportSummarizationDateTime);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScript>("deviceComplianceScripts", DeviceComplianceScripts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceConfigurationConflictSummary>("deviceConfigurationConflictSummary", DeviceConfigurationConflictSummary);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceProtectionOverview>("deviceProtectionOverview", DeviceProtectionOverview);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IntuneBrand>("intuneBrand", IntuneBrand);
            writer.WriteCollectionOfObjectValues<IntuneBrandingProfile>("intuneBrandingProfiles", IntuneBrandingProfiles);
            writer.WriteCollectionOfObjectValues<IosUpdateDeviceStatus>("iosUpdateStatuses", IosUpdateStatuses);
            writer.WriteDateTimeOffsetValue("lastReportAggregationDateTime", LastReportAggregationDateTime);
            writer.WriteBoolValue("legacyPcManangementEnabled", LegacyPcManangementEnabled);
            writer.WriteCollectionOfObjectValues<MacOSSoftwareUpdateAccountSummary>("macOSSoftwareUpdateAccountSummaries", MacOSSoftwareUpdateAccountSummaries);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceCleanupSettings>("managedDeviceCleanupSettings", ManagedDeviceCleanupSettings);
            writer.WriteCollectionOfObjectValues<ManagedDeviceEncryptionState>("managedDeviceEncryptionStates", ManagedDeviceEncryptionStates);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceOverview>("managedDeviceOverview", ManagedDeviceOverview);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteIntValue("maximumDepTokens", MaximumDepTokens);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelConfiguration>("microsoftTunnelConfigurations", MicrosoftTunnelConfigurations);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelHealthThreshold>("microsoftTunnelHealthThresholds", MicrosoftTunnelHealthThresholds);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelServerLogCollectionResponse>("microsoftTunnelServerLogCollectionResponses", MicrosoftTunnelServerLogCollectionResponses);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelSite>("microsoftTunnelSites", MicrosoftTunnelSites);
            writer.WriteCollectionOfObjectValues<MobileAppTroubleshootingEvent>("mobileAppTroubleshootingEvents", MobileAppTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<MobileThreatDefenseConnector>("mobileThreatDefenseConnectors", MobileThreatDefenseConnectors);
            writer.WriteCollectionOfObjectValues<NdesConnector>("ndesConnectors", NdesConnectors);
            writer.WriteCollectionOfObjectValues<NotificationMessageTemplate>("notificationMessageTemplates", NotificationMessageTemplates);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OemWarrantyInformationOnboarding>("oemWarrantyInformationOnboarding", OemWarrantyInformationOnboarding);
            writer.WriteCollectionOfObjectValues<RemoteActionAudit>("remoteActionAudits", RemoteActionAudits);
            writer.WriteCollectionOfObjectValues<RemoteAssistancePartner>("remoteAssistancePartners", RemoteAssistancePartners);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RemoteAssistanceSettings>("remoteAssistanceSettings", RemoteAssistanceSettings);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary", SoftwareUpdateStatusSummary);
            writer.WriteEnumValue<DeviceManagementSubscriptions>("subscriptions", Subscriptions);
            writer.WriteEnumValue<DeviceManagementSubscriptionState>("subscriptionState", SubscriptionState);
            writer.WriteCollectionOfObjectValues<TelecomExpenseManagementPartner>("telecomExpenseManagementPartners", TelecomExpenseManagementPartners);
            writer.WriteCollectionOfObjectValues<DeviceManagementTemplate>("templates", Templates);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingTemplate>("templateSettings", TemplateSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TenantAttachRBAC>("tenantAttachRBAC", TenantAttachRBAC);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TermsAndConditions>("termsAndConditions", TermsAndConditions);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>("troubleshootingEvents", TroubleshootingEvents);
            writer.WriteBoolValue("unlicensedAdminstratorsEnabled", UnlicensedAdminstratorsEnabled);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>("userExperienceAnalyticsAppHealthApplicationPerformance", UserExperienceAnalyticsAppHealthApplicationPerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>("userExperienceAnalyticsAppHealthDeviceModelPerformance", UserExperienceAnalyticsAppHealthDeviceModelPerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformance>("userExperienceAnalyticsAppHealthDevicePerformance", UserExperienceAnalyticsAppHealthDevicePerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>("userExperienceAnalyticsAppHealthDevicePerformanceDetails", UserExperienceAnalyticsAppHealthDevicePerformanceDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>("userExperienceAnalyticsAppHealthOSVersionPerformance", UserExperienceAnalyticsAppHealthOSVersionPerformance);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("userExperienceAnalyticsAppHealthOverview", UserExperienceAnalyticsAppHealthOverview);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBaseline>("userExperienceAnalyticsBaselines", UserExperienceAnalyticsBaselines);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthAppImpact>("userExperienceAnalyticsBatteryHealthAppImpact", UserExperienceAnalyticsBatteryHealthAppImpact);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails>("userExperienceAnalyticsBatteryHealthCapacityDetails", UserExperienceAnalyticsBatteryHealthCapacityDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceAppImpact>("userExperienceAnalyticsBatteryHealthDeviceAppImpact", UserExperienceAnalyticsBatteryHealthDeviceAppImpact);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDevicePerformance>("userExperienceAnalyticsBatteryHealthDevicePerformance", UserExperienceAnalyticsBatteryHealthDevicePerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory>("userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory", UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance>("userExperienceAnalyticsBatteryHealthModelPerformance", UserExperienceAnalyticsBatteryHealthModelPerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthOsPerformance>("userExperienceAnalyticsBatteryHealthOsPerformance", UserExperienceAnalyticsBatteryHealthOsPerformance);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails>("userExperienceAnalyticsBatteryHealthRuntimeDetails", UserExperienceAnalyticsBatteryHealthRuntimeDetails);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsCategory>("userExperienceAnalyticsCategories", UserExperienceAnalyticsCategories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>("userExperienceAnalyticsDeviceMetricHistory", UserExperienceAnalyticsDeviceMetricHistory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDevicePerformance>("userExperienceAnalyticsDevicePerformance", UserExperienceAnalyticsDevicePerformance);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>("userExperienceAnalyticsDeviceScope", UserExperienceAnalyticsDeviceScope);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScope>("userExperienceAnalyticsDeviceScopes", UserExperienceAnalyticsDeviceScopes);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceScores>("userExperienceAnalyticsDeviceScores", UserExperienceAnalyticsDeviceScores);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupHistory>("userExperienceAnalyticsDeviceStartupHistory", UserExperienceAnalyticsDeviceStartupHistory);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcess>("userExperienceAnalyticsDeviceStartupProcesses", UserExperienceAnalyticsDeviceStartupProcesses);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsDeviceStartupProcessPerformance>("userExperienceAnalyticsDeviceStartupProcessPerformance", UserExperienceAnalyticsDeviceStartupProcessPerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceWithoutCloudIdentity>("userExperienceAnalyticsDevicesWithoutCloudIdentity", UserExperienceAnalyticsDevicesWithoutCloudIdentity);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsImpactingProcess>("userExperienceAnalyticsImpactingProcess", UserExperienceAnalyticsImpactingProcess);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsMetricHistory>("userExperienceAnalyticsMetricHistory", UserExperienceAnalyticsMetricHistory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsModelScores>("userExperienceAnalyticsModelScores", UserExperienceAnalyticsModelScores);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsNotAutopilotReadyDevice>("userExperienceAnalyticsNotAutopilotReadyDevice", UserExperienceAnalyticsNotAutopilotReadyDevice);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsOverview>("userExperienceAnalyticsOverview", UserExperienceAnalyticsOverview);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRegressionSummary>("userExperienceAnalyticsRegressionSummary", UserExperienceAnalyticsRegressionSummary);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsRemoteConnection>("userExperienceAnalyticsRemoteConnection", UserExperienceAnalyticsRemoteConnection);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance>("userExperienceAnalyticsResourcePerformance", UserExperienceAnalyticsResourcePerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsScoreHistory>("userExperienceAnalyticsScoreHistory", UserExperienceAnalyticsScoreHistory);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsSettings>("userExperienceAnalyticsSettings", UserExperienceAnalyticsSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereMetric>("userExperienceAnalyticsWorkFromAnywhereMetrics", UserExperienceAnalyticsWorkFromAnywhereMetrics);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>("userExperienceAnalyticsWorkFromAnywhereModelPerformance", UserExperienceAnalyticsWorkFromAnywhereModelPerformance);
            writer.WriteCollectionOfObjectValues<UserPFXCertificate>("userPfxCertificates", UserPfxCertificates);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.VirtualEndpoint>("virtualEndpoint", VirtualEndpoint);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeploymentProfile>("windowsAutopilotDeploymentProfiles", WindowsAutopilotDeploymentProfiles);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>("windowsAutopilotDeviceIdentities", WindowsAutopilotDeviceIdentities);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsAutopilotSettings>("windowsAutopilotSettings", WindowsAutopilotSettings);
            writer.WriteCollectionOfObjectValues<WindowsDriverUpdateProfile>("windowsDriverUpdateProfiles", WindowsDriverUpdateProfiles);
            writer.WriteCollectionOfObjectValues<WindowsFeatureUpdateProfile>("windowsFeatureUpdateProfiles", WindowsFeatureUpdateProfiles);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>("windowsInformationProtectionAppLearningSummaries", WindowsInformationProtectionAppLearningSummaries);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>("windowsInformationProtectionNetworkLearningSummaries", WindowsInformationProtectionNetworkLearningSummaries);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsMalwareInformation>("windowsMalwareInformation", WindowsMalwareInformation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsMalwareOverview>("windowsMalwareOverview", WindowsMalwareOverview);
            writer.WriteCollectionOfObjectValues<WindowsQualityUpdateProfile>("windowsQualityUpdateProfiles", WindowsQualityUpdateProfiles);
            writer.WriteCollectionOfObjectValues<WindowsUpdateCatalogItem>("windowsUpdateCatalogItems", WindowsUpdateCatalogItems);
            writer.WriteCollectionOfObjectValues<ZebraFotaArtifact>("zebraFotaArtifacts", ZebraFotaArtifacts);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ZebraFotaConnector>("zebraFotaConnector", ZebraFotaConnector);
            writer.WriteCollectionOfObjectValues<ZebraFotaDeployment>("zebraFotaDeployments", ZebraFotaDeployments);
        }
    }
}
