using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
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
        public List<ManagementTemplateCollection> ManagementTemplateCollections { get; set; }
        /// <summary>The collection of baseline management templates across managed tenants.</summary>
        public List<ManagementTemplate> ManagementTemplates { get; set; }
        public List<ManagementTemplateStep> ManagementTemplateSteps { get; set; }
        public List<ManagementTemplateStepVersion> ManagementTemplateStepVersions { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"aggregatedPolicyCompliances", (o,n) => { (o as ManagedTenant).AggregatedPolicyCompliances = n.GetCollectionOfObjectValues<AggregatedPolicyCompliance>(AggregatedPolicyCompliance.CreateFromDiscriminatorValue).ToList(); } },
                {"auditEvents", (o,n) => { (o as ManagedTenant).AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>(AuditEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcConnections", (o,n) => { (o as ManagedTenant).CloudPcConnections = n.GetCollectionOfObjectValues<CloudPcConnection>(CloudPcConnection.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcDevices", (o,n) => { (o as ManagedTenant).CloudPcDevices = n.GetCollectionOfObjectValues<CloudPcDevice>(CloudPcDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcsOverview", (o,n) => { (o as ManagedTenant).CloudPcsOverview = n.GetCollectionOfObjectValues<CloudPcOverview>(CloudPcOverview.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccessPolicyCoverages", (o,n) => { (o as ManagedTenant).ConditionalAccessPolicyCoverages = n.GetCollectionOfObjectValues<ConditionalAccessPolicyCoverage>(ConditionalAccessPolicyCoverage.CreateFromDiscriminatorValue).ToList(); } },
                {"credentialUserRegistrationsSummaries", (o,n) => { (o as ManagedTenant).CredentialUserRegistrationsSummaries = n.GetCollectionOfObjectValues<CredentialUserRegistrationsSummary>(CredentialUserRegistrationsSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCompliancePolicySettingStateSummaries", (o,n) => { (o as ManagedTenant).DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>(DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceCompliances", (o,n) => { (o as ManagedTenant).ManagedDeviceCompliances = n.GetCollectionOfObjectValues<ManagedDeviceCompliance>(ManagedDeviceCompliance.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceComplianceTrends", (o,n) => { (o as ManagedTenant).ManagedDeviceComplianceTrends = n.GetCollectionOfObjectValues<ManagedDeviceComplianceTrend>(ManagedDeviceComplianceTrend.CreateFromDiscriminatorValue).ToList(); } },
                {"managementActions", (o,n) => { (o as ManagedTenant).ManagementActions = n.GetCollectionOfObjectValues<ManagementAction>(ManagementAction.CreateFromDiscriminatorValue).ToList(); } },
                {"managementActionTenantDeploymentStatuses", (o,n) => { (o as ManagedTenant).ManagementActionTenantDeploymentStatuses = n.GetCollectionOfObjectValues<ManagementActionTenantDeploymentStatus>(ManagementActionTenantDeploymentStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"managementIntents", (o,n) => { (o as ManagedTenant).ManagementIntents = n.GetCollectionOfObjectValues<ManagementIntent>(ManagementIntent.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplateCollections", (o,n) => { (o as ManagedTenant).ManagementTemplateCollections = n.GetCollectionOfObjectValues<ManagementTemplateCollection>(ManagementTemplateCollection.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplates", (o,n) => { (o as ManagedTenant).ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplate>(ManagementTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplateSteps", (o,n) => { (o as ManagedTenant).ManagementTemplateSteps = n.GetCollectionOfObjectValues<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplateStepVersions", (o,n) => { (o as ManagedTenant).ManagementTemplateStepVersions = n.GetCollectionOfObjectValues<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantGroups", (o,n) => { (o as ManagedTenant).TenantGroups = n.GetCollectionOfObjectValues<TenantGroup>(TenantGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"tenants", (o,n) => { (o as ManagedTenant).Tenants = n.GetCollectionOfObjectValues<Tenant>(Tenant.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantsCustomizedInformation", (o,n) => { (o as ManagedTenant).TenantsCustomizedInformation = n.GetCollectionOfObjectValues<TenantCustomizedInformation>(TenantCustomizedInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantsDetailedInformation", (o,n) => { (o as ManagedTenant).TenantsDetailedInformation = n.GetCollectionOfObjectValues<TenantDetailedInformation>(TenantDetailedInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantTags", (o,n) => { (o as ManagedTenant).TenantTags = n.GetCollectionOfObjectValues<TenantTag>(TenantTag.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsDeviceMalwareStates", (o,n) => { (o as ManagedTenant).WindowsDeviceMalwareStates = n.GetCollectionOfObjectValues<WindowsDeviceMalwareState>(WindowsDeviceMalwareState.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsProtectionStates", (o,n) => { (o as ManagedTenant).WindowsProtectionStates = n.GetCollectionOfObjectValues<WindowsProtectionState>(WindowsProtectionState.CreateFromDiscriminatorValue).ToList(); } },
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
