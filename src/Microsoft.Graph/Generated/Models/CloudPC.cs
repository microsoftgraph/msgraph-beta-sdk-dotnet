using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPC : Entity, IParsable {
        /// <summary>The Azure Active Directory (Azure AD) device ID of the Cloud PC.</summary>
        public string AadDeviceId { get; set; }
        /// <summary>The display name of the Cloud PC.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time when the grace period ends and reprovisioning/deprovisioning happens. Required only if the status is inGracePeriod. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? GracePeriodEndDateTime { get; set; }
        /// <summary>Name of the OS image that&apos;s on the Cloud PC.</summary>
        public string ImageDisplayName { get; set; }
        /// <summary>The last login result of the Cloud PC. For example, { &apos;time&apos;: &apos;2014-01-01T00:00:00Z&apos;}.</summary>
        public CloudPcLoginResult LastLoginResult { get; set; }
        /// <summary>The last modified date and time of the Cloud PC. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The last remote action result of the enterprise Cloud PCs. The supported remote actions are: Reboot, Rename, Reprovision, Restore, and Troubleshoot.</summary>
        public CloudPcRemoteActionResult LastRemoteActionResult { get; set; }
        /// <summary>The Intune device ID of the Cloud PC.</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>The Intune device name of the Cloud PC.</summary>
        public string ManagedDeviceName { get; set; }
        /// <summary>The Azure network connection that is applied during the provisioning of Cloud PCs.</summary>
        public string OnPremisesConnectionName { get; set; }
        /// <summary>The version of the operating system (OS) to provision on Cloud PCs. Possible values are: windows10, windows11, and unknownFutureValue.</summary>
        public CloudPcOperatingSystem? OsVersion { get; set; }
        /// <summary>The provisioning policy ID of the Cloud PC.</summary>
        public string ProvisioningPolicyId { get; set; }
        /// <summary>The provisioning policy that is applied during the provisioning of Cloud PCs.</summary>
        public string ProvisioningPolicyName { get; set; }
        /// <summary>The service plan ID of the Cloud PC.</summary>
        public string ServicePlanId { get; set; }
        /// <summary>The service plan name of the Cloud PC.</summary>
        public string ServicePlanName { get; set; }
        /// <summary>The service plan type of the Cloud PC.</summary>
        public CloudPcServicePlanType? ServicePlanType { get; set; }
        /// <summary>The status of the Cloud PC. Possible values are: notProvisioned, provisioning, provisioned, upgrading, inGracePeriod, deprovisioning, failed, restoring.</summary>
        public CloudPcStatus? Status { get; set; }
        /// <summary>The details of the Cloud PC status.</summary>
        public CloudPcStatusDetails StatusDetails { get; set; }
        /// <summary>The account type of the user on provisioned Cloud PCs. Possible values are: standardUser, administrator, and unknownFutureValue.</summary>
        public CloudPcUserAccountType? UserAccountType { get; set; }
        /// <summary>The user principal name (UPN) of the user assigned to the Cloud PC.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPC CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPC();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aadDeviceId", n => { AadDeviceId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"gracePeriodEndDateTime", n => { GracePeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"imageDisplayName", n => { ImageDisplayName = n.GetStringValue(); } },
                {"lastLoginResult", n => { LastLoginResult = n.GetObjectValue<CloudPcLoginResult>(CloudPcLoginResult.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRemoteActionResult", n => { LastRemoteActionResult = n.GetObjectValue<CloudPcRemoteActionResult>(CloudPcRemoteActionResult.CreateFromDiscriminatorValue); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"onPremisesConnectionName", n => { OnPremisesConnectionName = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetEnumValue<CloudPcOperatingSystem>(); } },
                {"provisioningPolicyId", n => { ProvisioningPolicyId = n.GetStringValue(); } },
                {"provisioningPolicyName", n => { ProvisioningPolicyName = n.GetStringValue(); } },
                {"servicePlanId", n => { ServicePlanId = n.GetStringValue(); } },
                {"servicePlanName", n => { ServicePlanName = n.GetStringValue(); } },
                {"servicePlanType", n => { ServicePlanType = n.GetEnumValue<CloudPcServicePlanType>(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcStatus>(); } },
                {"statusDetails", n => { StatusDetails = n.GetObjectValue<CloudPcStatusDetails>(CloudPcStatusDetails.CreateFromDiscriminatorValue); } },
                {"userAccountType", n => { UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
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
            writer.WriteStringValue("aadDeviceId", AadDeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("gracePeriodEndDateTime", GracePeriodEndDateTime);
            writer.WriteStringValue("imageDisplayName", ImageDisplayName);
            writer.WriteObjectValue<CloudPcLoginResult>("lastLoginResult", LastLoginResult);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<CloudPcRemoteActionResult>("lastRemoteActionResult", LastRemoteActionResult);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteStringValue("onPremisesConnectionName", OnPremisesConnectionName);
            writer.WriteEnumValue<CloudPcOperatingSystem>("osVersion", OsVersion);
            writer.WriteStringValue("provisioningPolicyId", ProvisioningPolicyId);
            writer.WriteStringValue("provisioningPolicyName", ProvisioningPolicyName);
            writer.WriteStringValue("servicePlanId", ServicePlanId);
            writer.WriteStringValue("servicePlanName", ServicePlanName);
            writer.WriteEnumValue<CloudPcServicePlanType>("servicePlanType", ServicePlanType);
            writer.WriteEnumValue<CloudPcStatus>("status", Status);
            writer.WriteObjectValue<CloudPcStatusDetails>("statusDetails", StatusDetails);
            writer.WriteEnumValue<CloudPcUserAccountType>("userAccountType", UserAccountType);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
