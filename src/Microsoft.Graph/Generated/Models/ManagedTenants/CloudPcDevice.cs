using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class CloudPcDevice : Entity, IParsable {
        /// <summary>The status of the cloud PC. Possible values are: notProvisioned, provisioning, provisioned, upgrading, inGracePeriod, deprovisioning, failed. Required. Read-only.</summary>
        public string CloudPcStatus {
            get { return BackingStore?.Get<string>("cloudPcStatus"); }
            set { BackingStore?.Set("cloudPcStatus", value); }
        }
        /// <summary>The specification of the cloud PC device. Required. Read-only.</summary>
        public string DeviceSpecification {
            get { return BackingStore?.Get<string>("deviceSpecification"); }
            set { BackingStore?.Set("deviceSpecification", value); }
        }
        /// <summary>The display name  of the cloud PC device. Required. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Required. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>The managed device identifier of the cloud PC device. Optional. Read-only.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>The managed device display name of the cloud PC device. Optional. Read-only.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
        /// <summary>The provisioning policy identifier for the cloud PC device. Required. Read-only.</summary>
        public string ProvisioningPolicyId {
            get { return BackingStore?.Get<string>("provisioningPolicyId"); }
            set { BackingStore?.Set("provisioningPolicyId", value); }
        }
        /// <summary>The service plan name of the cloud PC device. Required. Read-only.</summary>
        public string ServicePlanName {
            get { return BackingStore?.Get<string>("servicePlanName"); }
            set { BackingStore?.Set("servicePlanName", value); }
        }
        /// <summary>The service plan type of the cloud PC device. Required. Read-only.</summary>
        public string ServicePlanType {
            get { return BackingStore?.Get<string>("servicePlanType"); }
            set { BackingStore?.Set("servicePlanType", value); }
        }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>The user principal name (UPN) of the user assigned to the cloud PC device. Required. Read-only.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
