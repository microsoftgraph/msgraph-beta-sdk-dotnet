using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class CloudPcDevice : Entity, IParsable {
        /// <summary>The status of the cloud PC. Possible values are: notProvisioned, provisioning, provisioned, upgrading, inGracePeriod, deprovisioning, failed. Required. Read-only.</summary>
        public string CloudPcStatus { get; set; }
        /// <summary>The deviceSpecification property</summary>
        public string DeviceSpecification { get; set; }
        /// <summary>The display name for the cloud PC. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Required. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The managed device identifier for the cloud PC. Optional. Read-only.</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>The managed device display name for the cloud PC. Optional. Read-only.</summary>
        public string ManagedDeviceName { get; set; }
        /// <summary>The provisioning policy identifier for the cloud PC. Required. Read-only.</summary>
        public string ProvisioningPolicyId { get; set; }
        /// <summary>The service plan name for the cloud PC. Required. Read-only.</summary>
        public string ServicePlanName { get; set; }
        /// <summary>The servicePlanType property</summary>
        public string ServicePlanType { get; set; }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>The user principal name (UPN) of the user assigned to the cloud PC. Required. Read-only.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cloudPcStatus", n => { CloudPcStatus = n.GetStringValue(); } },
                {"deviceSpecification", n => { DeviceSpecification = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"provisioningPolicyId", n => { ProvisioningPolicyId = n.GetStringValue(); } },
                {"servicePlanName", n => { ServicePlanName = n.GetStringValue(); } },
                {"servicePlanType", n => { ServicePlanType = n.GetStringValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("cloudPcStatus", CloudPcStatus);
            writer.WriteStringValue("deviceSpecification", DeviceSpecification);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteStringValue("provisioningPolicyId", ProvisioningPolicyId);
            writer.WriteStringValue("servicePlanName", ServicePlanName);
            writer.WriteStringValue("servicePlanType", ServicePlanType);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
