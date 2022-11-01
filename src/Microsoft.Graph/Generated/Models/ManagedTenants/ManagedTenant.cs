using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagedTenant : Entity, IParsable {
        /// <summary>Aggregate view of device compliance policies across managed tenants.</summary>
        public List<AggregatedPolicyCompliance> AggregatedPolicyCompliances {
            get { return BackingStore?.Get<List<AggregatedPolicyCompliance>>("aggregatedPolicyCompliances"); }
            set { BackingStore?.Set("aggregatedPolicyCompliances", value); }
        }
        /// <summary>The collection of audit events across managed tenants.</summary>
        public List<AuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<AuditEvent>>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
        /// <summary>The collection of cloud PC connections across managed tenants.</summary>
        public List<CloudPcConnection> CloudPcConnections {
            get { return BackingStore?.Get<List<CloudPcConnection>>("cloudPcConnections"); }
            set { BackingStore?.Set("cloudPcConnections", value); }
        }
        /// <summary>The collection of cloud PC devices across managed tenants.</summary>
        public List<CloudPcDevice> CloudPcDevices {
            get { return BackingStore?.Get<List<CloudPcDevice>>("cloudPcDevices"); }
            set { BackingStore?.Set("cloudPcDevices", value); }
        }
        /// <summary>Overview of cloud PC information across managed tenants.</summary>
        public List<CloudPcOverview> CloudPcsOverview {
            get { return BackingStore?.Get<List<CloudPcOverview>>("cloudPcsOverview"); }
            set { BackingStore?.Set("cloudPcsOverview", value); }
        }
        /// <summary>Aggregate view of conditional access policy coverage across managed tenants.</summary>
        public List<ConditionalAccessPolicyCoverage> ConditionalAccessPolicyCoverages {
            get { return BackingStore?.Get<List<ConditionalAccessPolicyCoverage>>("conditionalAccessPolicyCoverages"); }
            set { BackingStore?.Set("conditionalAccessPolicyCoverages", value); }
        }
        /// <summary>Summary information for user registration for multi-factor authentication and self service password reset across managed tenants.</summary>
        public List<CredentialUserRegistrationsSummary> CredentialUserRegistrationsSummaries {
            get { return BackingStore?.Get<List<CredentialUserRegistrationsSummary>>("credentialUserRegistrationsSummaries"); }
            set { BackingStore?.Set("credentialUserRegistrationsSummaries", value); }
        }
        /// <summary>Summary information for device compliance policy setting states across managed tenants.</summary>
        public List<DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries {
            get { return BackingStore?.Get<List<DeviceCompliancePolicySettingStateSummary>>("deviceCompliancePolicySettingStateSummaries"); }
            set { BackingStore?.Set("deviceCompliancePolicySettingStateSummaries", value); }
        }
        /// <summary>The collection of compliance for managed devices across managed tenants.</summary>
        public List<ManagedDeviceCompliance> ManagedDeviceCompliances {
            get { return BackingStore?.Get<List<ManagedDeviceCompliance>>("managedDeviceCompliances"); }
            set { BackingStore?.Set("managedDeviceCompliances", value); }
        }
        /// <summary>Trend insights for device compliance across managed tenants.</summary>
        public List<ManagedDeviceComplianceTrend> ManagedDeviceComplianceTrends {
            get { return BackingStore?.Get<List<ManagedDeviceComplianceTrend>>("managedDeviceComplianceTrends"); }
            set { BackingStore?.Set("managedDeviceComplianceTrends", value); }
        }
        /// <summary>The managedTenantAlertLogs property</summary>
        public List<ManagedTenantAlertLog> ManagedTenantAlertLogs {
            get { return BackingStore?.Get<List<ManagedTenantAlertLog>>("managedTenantAlertLogs"); }
            set { BackingStore?.Set("managedTenantAlertLogs", value); }
        }
        /// <summary>The managedTenantAlertRuleDefinitions property</summary>
        public List<ManagedTenantAlertRuleDefinition> ManagedTenantAlertRuleDefinitions {
            get { return BackingStore?.Get<List<ManagedTenantAlertRuleDefinition>>("managedTenantAlertRuleDefinitions"); }
            set { BackingStore?.Set("managedTenantAlertRuleDefinitions", value); }
        }
        /// <summary>The managedTenantAlertRules property</summary>
        public List<ManagedTenantAlertRule> ManagedTenantAlertRules {
            get { return BackingStore?.Get<List<ManagedTenantAlertRule>>("managedTenantAlertRules"); }
            set { BackingStore?.Set("managedTenantAlertRules", value); }
        }
        /// <summary>The managedTenantAlerts property</summary>
        public List<ManagedTenantAlert> ManagedTenantAlerts {
            get { return BackingStore?.Get<List<ManagedTenantAlert>>("managedTenantAlerts"); }
            set { BackingStore?.Set("managedTenantAlerts", value); }
        }
        /// <summary>The managedTenantApiNotifications property</summary>
        public List<ManagedTenantApiNotification> ManagedTenantApiNotifications {
            get { return BackingStore?.Get<List<ManagedTenantApiNotification>>("managedTenantApiNotifications"); }
            set { BackingStore?.Set("managedTenantApiNotifications", value); }
        }
        /// <summary>The managedTenantEmailNotifications property</summary>
        public List<ManagedTenantEmailNotification> ManagedTenantEmailNotifications {
            get { return BackingStore?.Get<List<ManagedTenantEmailNotification>>("managedTenantEmailNotifications"); }
            set { BackingStore?.Set("managedTenantEmailNotifications", value); }
        }
        /// <summary>The managedTenantTicketingEndpoints property</summary>
        public List<ManagedTenantTicketingEndpoint> ManagedTenantTicketingEndpoints {
            get { return BackingStore?.Get<List<ManagedTenantTicketingEndpoint>>("managedTenantTicketingEndpoints"); }
            set { BackingStore?.Set("managedTenantTicketingEndpoints", value); }
        }
        /// <summary>The collection of baseline management actions across managed tenants.</summary>
        public List<ManagementAction> ManagementActions {
            get { return BackingStore?.Get<List<ManagementAction>>("managementActions"); }
            set { BackingStore?.Set("managementActions", value); }
        }
        /// <summary>The tenant level status of management actions across managed tenants.</summary>
        public List<ManagementActionTenantDeploymentStatus> ManagementActionTenantDeploymentStatuses {
            get { return BackingStore?.Get<List<ManagementActionTenantDeploymentStatus>>("managementActionTenantDeploymentStatuses"); }
            set { BackingStore?.Set("managementActionTenantDeploymentStatuses", value); }
        }
        /// <summary>The collection of baseline management intents across managed tenants.</summary>
        public List<ManagementIntent> ManagementIntents {
            get { return BackingStore?.Get<List<ManagementIntent>>("managementIntents"); }
            set { BackingStore?.Set("managementIntents", value); }
        }
        /// <summary>The managementTemplateCollections property</summary>
        public List<ManagementTemplateCollection> ManagementTemplateCollections {
            get { return BackingStore?.Get<List<ManagementTemplateCollection>>("managementTemplateCollections"); }
            set { BackingStore?.Set("managementTemplateCollections", value); }
        }
        /// <summary>The collection of baseline management templates across managed tenants.</summary>
        public List<ManagementTemplate> ManagementTemplates {
            get { return BackingStore?.Get<List<ManagementTemplate>>("managementTemplates"); }
            set { BackingStore?.Set("managementTemplates", value); }
        }
        /// <summary>The managementTemplateSteps property</summary>
        public List<ManagementTemplateStep> ManagementTemplateSteps {
            get { return BackingStore?.Get<List<ManagementTemplateStep>>("managementTemplateSteps"); }
            set { BackingStore?.Set("managementTemplateSteps", value); }
        }
        /// <summary>The managementTemplateStepVersions property</summary>
        public List<ManagementTemplateStepVersion> ManagementTemplateStepVersions {
            get { return BackingStore?.Get<List<ManagementTemplateStepVersion>>("managementTemplateStepVersions"); }
            set { BackingStore?.Set("managementTemplateStepVersions", value); }
        }
        /// <summary>The collection of role assignments to a signed-in user for a managed tenant.</summary>
        public List<MyRole> MyRoles {
            get { return BackingStore?.Get<List<MyRole>>("myRoles"); }
            set { BackingStore?.Set("myRoles", value); }
        }
        /// <summary>The collection of a logical grouping of managed tenants used by the multi-tenant management platform.</summary>
        public List<TenantGroup> TenantGroups {
            get { return BackingStore?.Get<List<TenantGroup>>("tenantGroups"); }
            set { BackingStore?.Set("tenantGroups", value); }
        }
        /// <summary>The collection of tenants associated with the managing entity.</summary>
        public List<Tenant> Tenants {
            get { return BackingStore?.Get<List<Tenant>>("tenants"); }
            set { BackingStore?.Set("tenants", value); }
        }
        /// <summary>The collection of tenant level customized information across managed tenants.</summary>
        public List<TenantCustomizedInformation> TenantsCustomizedInformation {
            get { return BackingStore?.Get<List<TenantCustomizedInformation>>("tenantsCustomizedInformation"); }
            set { BackingStore?.Set("tenantsCustomizedInformation", value); }
        }
        /// <summary>The collection tenant level detailed information across managed tenants.</summary>
        public List<TenantDetailedInformation> TenantsDetailedInformation {
            get { return BackingStore?.Get<List<TenantDetailedInformation>>("tenantsDetailedInformation"); }
            set { BackingStore?.Set("tenantsDetailedInformation", value); }
        }
        /// <summary>The collection of tenant tags across managed tenants.</summary>
        public List<TenantTag> TenantTags {
            get { return BackingStore?.Get<List<TenantTag>>("tenantTags"); }
            set { BackingStore?.Set("tenantTags", value); }
        }
        /// <summary>The state of malware for Windows devices, registered with Microsoft Endpoint Manager, across managed tenants.</summary>
        public List<WindowsDeviceMalwareState> WindowsDeviceMalwareStates {
            get { return BackingStore?.Get<List<WindowsDeviceMalwareState>>("windowsDeviceMalwareStates"); }
            set { BackingStore?.Set("windowsDeviceMalwareStates", value); }
        }
        /// <summary>The protection state for Windows devices, registered with Microsoft Endpoint Manager, across managed tenants.</summary>
        public List<WindowsProtectionState> WindowsProtectionStates {
            get { return BackingStore?.Get<List<WindowsProtectionState>>("windowsProtectionStates"); }
            set { BackingStore?.Set("windowsProtectionStates", value); }
        }
        /// <summary>
        /// Instantiates a new managedTenant and sets the default values.
        /// </summary>
        public ManagedTenant() : base() {
            OdataType = "#microsoft.graph.managedTenants.managedTenant";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedTenant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedTenant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aggregatedPolicyCompliances", n => { AggregatedPolicyCompliances = n.GetCollectionOfObjectValues<AggregatedPolicyCompliance>(AggregatedPolicyCompliance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>(AuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPcConnections", n => { CloudPcConnections = n.GetCollectionOfObjectValues<CloudPcConnection>(CloudPcConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPcDevices", n => { CloudPcDevices = n.GetCollectionOfObjectValues<CloudPcDevice>(CloudPcDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPcsOverview", n => { CloudPcsOverview = n.GetCollectionOfObjectValues<CloudPcOverview>(CloudPcOverview.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccessPolicyCoverages", n => { ConditionalAccessPolicyCoverages = n.GetCollectionOfObjectValues<ConditionalAccessPolicyCoverage>(ConditionalAccessPolicyCoverage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"credentialUserRegistrationsSummaries", n => { CredentialUserRegistrationsSummaries = n.GetCollectionOfObjectValues<CredentialUserRegistrationsSummary>(CredentialUserRegistrationsSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>(DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceCompliances", n => { ManagedDeviceCompliances = n.GetCollectionOfObjectValues<ManagedDeviceCompliance>(ManagedDeviceCompliance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceComplianceTrends", n => { ManagedDeviceComplianceTrends = n.GetCollectionOfObjectValues<ManagedDeviceComplianceTrend>(ManagedDeviceComplianceTrend.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantAlertLogs", n => { ManagedTenantAlertLogs = n.GetCollectionOfObjectValues<ManagedTenantAlertLog>(ManagedTenantAlertLog.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantAlertRuleDefinitions", n => { ManagedTenantAlertRuleDefinitions = n.GetCollectionOfObjectValues<ManagedTenantAlertRuleDefinition>(ManagedTenantAlertRuleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantAlertRules", n => { ManagedTenantAlertRules = n.GetCollectionOfObjectValues<ManagedTenantAlertRule>(ManagedTenantAlertRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantAlerts", n => { ManagedTenantAlerts = n.GetCollectionOfObjectValues<ManagedTenantAlert>(ManagedTenantAlert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantApiNotifications", n => { ManagedTenantApiNotifications = n.GetCollectionOfObjectValues<ManagedTenantApiNotification>(ManagedTenantApiNotification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantEmailNotifications", n => { ManagedTenantEmailNotifications = n.GetCollectionOfObjectValues<ManagedTenantEmailNotification>(ManagedTenantEmailNotification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantTicketingEndpoints", n => { ManagedTenantTicketingEndpoints = n.GetCollectionOfObjectValues<ManagedTenantTicketingEndpoint>(ManagedTenantTicketingEndpoint.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementActions", n => { ManagementActions = n.GetCollectionOfObjectValues<ManagementAction>(ManagementAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementActionTenantDeploymentStatuses", n => { ManagementActionTenantDeploymentStatuses = n.GetCollectionOfObjectValues<ManagementActionTenantDeploymentStatus>(ManagementActionTenantDeploymentStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementIntents", n => { ManagementIntents = n.GetCollectionOfObjectValues<ManagementIntent>(ManagementIntent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplateCollections", n => { ManagementTemplateCollections = n.GetCollectionOfObjectValues<ManagementTemplateCollection>(ManagementTemplateCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplates", n => { ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplate>(ManagementTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplateSteps", n => { ManagementTemplateSteps = n.GetCollectionOfObjectValues<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplateStepVersions", n => { ManagementTemplateStepVersions = n.GetCollectionOfObjectValues<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"myRoles", n => { MyRoles = n.GetCollectionOfObjectValues<MyRole>(MyRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantGroups", n => { TenantGroups = n.GetCollectionOfObjectValues<TenantGroup>(TenantGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenants", n => { Tenants = n.GetCollectionOfObjectValues<Tenant>(Tenant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantsCustomizedInformation", n => { TenantsCustomizedInformation = n.GetCollectionOfObjectValues<TenantCustomizedInformation>(TenantCustomizedInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantsDetailedInformation", n => { TenantsDetailedInformation = n.GetCollectionOfObjectValues<TenantDetailedInformation>(TenantDetailedInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantTags", n => { TenantTags = n.GetCollectionOfObjectValues<TenantTag>(TenantTag.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsDeviceMalwareStates", n => { WindowsDeviceMalwareStates = n.GetCollectionOfObjectValues<WindowsDeviceMalwareState>(WindowsDeviceMalwareState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsProtectionStates", n => { WindowsProtectionStates = n.GetCollectionOfObjectValues<WindowsProtectionState>(WindowsProtectionState.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AggregatedPolicyCompliance>("aggregatedPolicyCompliances", AggregatedPolicyCompliances);
            writer.WriteCollectionOfObjectValues<AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<CloudPcConnection>("cloudPcConnections", CloudPcConnections);
            writer.WriteCollectionOfObjectValues<CloudPcDevice>("cloudPcDevices", CloudPcDevices);
            writer.WriteCollectionOfObjectValues<CloudPcOverview>("cloudPcsOverview", CloudPcsOverview);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicyCoverage>("conditionalAccessPolicyCoverages", ConditionalAccessPolicyCoverages);
            writer.WriteCollectionOfObjectValues<CredentialUserRegistrationsSummary>("credentialUserRegistrationsSummaries", CredentialUserRegistrationsSummaries);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCompliance>("managedDeviceCompliances", ManagedDeviceCompliances);
            writer.WriteCollectionOfObjectValues<ManagedDeviceComplianceTrend>("managedDeviceComplianceTrends", ManagedDeviceComplianceTrends);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlertLog>("managedTenantAlertLogs", ManagedTenantAlertLogs);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlertRuleDefinition>("managedTenantAlertRuleDefinitions", ManagedTenantAlertRuleDefinitions);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlertRule>("managedTenantAlertRules", ManagedTenantAlertRules);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlert>("managedTenantAlerts", ManagedTenantAlerts);
            writer.WriteCollectionOfObjectValues<ManagedTenantApiNotification>("managedTenantApiNotifications", ManagedTenantApiNotifications);
            writer.WriteCollectionOfObjectValues<ManagedTenantEmailNotification>("managedTenantEmailNotifications", ManagedTenantEmailNotifications);
            writer.WriteCollectionOfObjectValues<ManagedTenantTicketingEndpoint>("managedTenantTicketingEndpoints", ManagedTenantTicketingEndpoints);
            writer.WriteCollectionOfObjectValues<ManagementAction>("managementActions", ManagementActions);
            writer.WriteCollectionOfObjectValues<ManagementActionTenantDeploymentStatus>("managementActionTenantDeploymentStatuses", ManagementActionTenantDeploymentStatuses);
            writer.WriteCollectionOfObjectValues<ManagementIntent>("managementIntents", ManagementIntents);
            writer.WriteCollectionOfObjectValues<ManagementTemplateCollection>("managementTemplateCollections", ManagementTemplateCollections);
            writer.WriteCollectionOfObjectValues<ManagementTemplate>("managementTemplates", ManagementTemplates);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStep>("managementTemplateSteps", ManagementTemplateSteps);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepVersion>("managementTemplateStepVersions", ManagementTemplateStepVersions);
            writer.WriteCollectionOfObjectValues<MyRole>("myRoles", MyRoles);
            writer.WriteCollectionOfObjectValues<TenantGroup>("tenantGroups", TenantGroups);
            writer.WriteCollectionOfObjectValues<Tenant>("tenants", Tenants);
            writer.WriteCollectionOfObjectValues<TenantCustomizedInformation>("tenantsCustomizedInformation", TenantsCustomizedInformation);
            writer.WriteCollectionOfObjectValues<TenantDetailedInformation>("tenantsDetailedInformation", TenantsDetailedInformation);
            writer.WriteCollectionOfObjectValues<TenantTag>("tenantTags", TenantTags);
            writer.WriteCollectionOfObjectValues<WindowsDeviceMalwareState>("windowsDeviceMalwareStates", WindowsDeviceMalwareStates);
            writer.WriteCollectionOfObjectValues<WindowsProtectionState>("windowsProtectionStates", WindowsProtectionStates);
        }
    }
}
