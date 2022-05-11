using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagedTenant : Entity, IParsable {
        /// <summary>Aggregate view of device compliance policies across managed tenants.</summary>
        public List<AggregatedPolicyCompliance> AggregatedPolicyCompliances { get; set; }
        /// <summary>The collection of audit events across managed tenants.</summary>
        public List<AuditEvent> AuditEvents { get; set; }
        /// <summary>The collection of cloud PC connections across managed tenants.</summary>
        public List<CloudPcConnection> CloudPcConnections { get; set; }
        /// <summary>The collection of cloud PC devices across managed tenants.</summary>
        public List<CloudPcDevice> CloudPcDevices { get; set; }
        /// <summary>Overview of cloud PC information across managed tenants.</summary>
        public List<CloudPcOverview> CloudPcsOverview { get; set; }
        /// <summary>Aggregate view of conditional access policy coverage across managed tenants.</summary>
        public List<ConditionalAccessPolicyCoverage> ConditionalAccessPolicyCoverages { get; set; }
        /// <summary>Summary information for user registration for multi-factor authentication and self service password reset across managed tenants.</summary>
        public List<CredentialUserRegistrationsSummary> CredentialUserRegistrationsSummaries { get; set; }
        /// <summary>Summary information for device compliance policy setting states across managed tenants.</summary>
        public List<DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries { get; set; }
        /// <summary>The collection of compliance for managed devices across managed tenants.</summary>
        public List<ManagedDeviceCompliance> ManagedDeviceCompliances { get; set; }
        /// <summary>Trend insights for device compliance across managed tenants.</summary>
        public List<ManagedDeviceComplianceTrend> ManagedDeviceComplianceTrends { get; set; }
        /// <summary>The collection of baseline management actions across managed tenants.</summary>
        public List<ManagementAction> ManagementActions { get; set; }
        /// <summary>The tenant level status of management actions across managed tenants.</summary>
        public List<ManagementActionTenantDeploymentStatus> ManagementActionTenantDeploymentStatuses { get; set; }
        /// <summary>The collection of baseline management intents across managed tenants.</summary>
        public List<ManagementIntent> ManagementIntents { get; set; }
        /// <summary>The managementTemplateCollections property</summary>
        public List<ManagementTemplateCollection> ManagementTemplateCollections { get; set; }
        /// <summary>The collection of baseline management templates across managed tenants.</summary>
        public List<ManagementTemplate> ManagementTemplates { get; set; }
        /// <summary>The managementTemplateSteps property</summary>
        public List<ManagementTemplateStep> ManagementTemplateSteps { get; set; }
        /// <summary>The managementTemplateStepVersions property</summary>
        public List<ManagementTemplateStepVersion> ManagementTemplateStepVersions { get; set; }
        /// <summary>The myRoles property</summary>
        public List<MyRole> MyRoles { get; set; }
        /// <summary>The collection of a logical grouping of managed tenants used by the multi-tenant management platform.</summary>
        public List<TenantGroup> TenantGroups { get; set; }
        /// <summary>The collection of tenants associated with the managing entity.</summary>
        public List<Tenant> Tenants { get; set; }
        /// <summary>The collection of tenant level customized information across managed tenants.</summary>
        public List<TenantCustomizedInformation> TenantsCustomizedInformation { get; set; }
        /// <summary>The collection tenant level detailed information across managed tenants.</summary>
        public List<TenantDetailedInformation> TenantsDetailedInformation { get; set; }
        /// <summary>The collection of tenant tags across managed tenants.</summary>
        public List<TenantTag> TenantTags { get; set; }
        /// <summary>The state of malware for Windows devices, registered with Microsoft Endpoint Manager, across managed tenants.</summary>
        public List<WindowsDeviceMalwareState> WindowsDeviceMalwareStates { get; set; }
        /// <summary>The protection state for Windows devices, registered with Microsoft Endpoint Manager, across managed tenants.</summary>
        public List<WindowsProtectionState> WindowsProtectionStates { get; set; }
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
                {"aggregatedPolicyCompliances", n => { AggregatedPolicyCompliances = n.GetCollectionOfObjectValues<AggregatedPolicyCompliance>(AggregatedPolicyCompliance.CreateFromDiscriminatorValue).ToList(); } },
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>(AuditEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcConnections", n => { CloudPcConnections = n.GetCollectionOfObjectValues<CloudPcConnection>(CloudPcConnection.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcDevices", n => { CloudPcDevices = n.GetCollectionOfObjectValues<CloudPcDevice>(CloudPcDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcsOverview", n => { CloudPcsOverview = n.GetCollectionOfObjectValues<CloudPcOverview>(CloudPcOverview.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccessPolicyCoverages", n => { ConditionalAccessPolicyCoverages = n.GetCollectionOfObjectValues<ConditionalAccessPolicyCoverage>(ConditionalAccessPolicyCoverage.CreateFromDiscriminatorValue).ToList(); } },
                {"credentialUserRegistrationsSummaries", n => { CredentialUserRegistrationsSummaries = n.GetCollectionOfObjectValues<CredentialUserRegistrationsSummary>(CredentialUserRegistrationsSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>(DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceCompliances", n => { ManagedDeviceCompliances = n.GetCollectionOfObjectValues<ManagedDeviceCompliance>(ManagedDeviceCompliance.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceComplianceTrends", n => { ManagedDeviceComplianceTrends = n.GetCollectionOfObjectValues<ManagedDeviceComplianceTrend>(ManagedDeviceComplianceTrend.CreateFromDiscriminatorValue).ToList(); } },
                {"managementActions", n => { ManagementActions = n.GetCollectionOfObjectValues<ManagementAction>(ManagementAction.CreateFromDiscriminatorValue).ToList(); } },
                {"managementActionTenantDeploymentStatuses", n => { ManagementActionTenantDeploymentStatuses = n.GetCollectionOfObjectValues<ManagementActionTenantDeploymentStatus>(ManagementActionTenantDeploymentStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"managementIntents", n => { ManagementIntents = n.GetCollectionOfObjectValues<ManagementIntent>(ManagementIntent.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplateCollections", n => { ManagementTemplateCollections = n.GetCollectionOfObjectValues<ManagementTemplateCollection>(ManagementTemplateCollection.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplates", n => { ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplate>(ManagementTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplateSteps", n => { ManagementTemplateSteps = n.GetCollectionOfObjectValues<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplateStepVersions", n => { ManagementTemplateStepVersions = n.GetCollectionOfObjectValues<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue).ToList(); } },
                {"myRoles", n => { MyRoles = n.GetCollectionOfObjectValues<MyRole>(MyRole.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantGroups", n => { TenantGroups = n.GetCollectionOfObjectValues<TenantGroup>(TenantGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"tenants", n => { Tenants = n.GetCollectionOfObjectValues<Tenant>(Tenant.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantsCustomizedInformation", n => { TenantsCustomizedInformation = n.GetCollectionOfObjectValues<TenantCustomizedInformation>(TenantCustomizedInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantsDetailedInformation", n => { TenantsDetailedInformation = n.GetCollectionOfObjectValues<TenantDetailedInformation>(TenantDetailedInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantTags", n => { TenantTags = n.GetCollectionOfObjectValues<TenantTag>(TenantTag.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsDeviceMalwareStates", n => { WindowsDeviceMalwareStates = n.GetCollectionOfObjectValues<WindowsDeviceMalwareState>(WindowsDeviceMalwareState.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsProtectionStates", n => { WindowsProtectionStates = n.GetCollectionOfObjectValues<WindowsProtectionState>(WindowsProtectionState.CreateFromDiscriminatorValue).ToList(); } },
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
