using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CloudPC : Entity, IParsable {
        /// <summary>The Azure Active Directory (Azure AD) device ID of the Cloud PC.</summary>
        public string AadDeviceId { get; set; }
        /// <summary>The display name of the Cloud PC.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time when the grace period ends and reprovisioning/deprovisioning happens. Required only if the status is inGracePeriod. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? GracePeriodEndDateTime { get; set; }
        /// <summary>Name of the OS image that's on the Cloud PC.</summary>
        public string ImageDisplayName { get; set; }
        /// <summary>The last login result of the Cloud PC. For example, { 'time': '2014-01-01T00:00:00Z'}.</summary>
        public CloudPcLoginResult LastLoginResult { get; set; }
        /// <summary>The last modified date and time of the Cloud PC. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The last remote action result of the enterprise Cloud PCs. The supported remote actions are: Reboot, Rename, Reprovision, Restore, and Troubleshoot.</summary>
        public CloudPcRemoteActionResult LastRemoteActionResult { get; set; }
        /// <summary>The Intune device ID of the Cloud PC.</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>The Intune device name of the Cloud PC.</summary>
        public string ManagedDeviceName { get; set; }
        /// <summary>The on-premises connection that is applied during the provisioning of Cloud PCs.</summary>
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"aadDeviceId", (o,n) => { (o as CloudPC).AadDeviceId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CloudPC).DisplayName = n.GetStringValue(); } },
                {"gracePeriodEndDateTime", (o,n) => { (o as CloudPC).GracePeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"imageDisplayName", (o,n) => { (o as CloudPC).ImageDisplayName = n.GetStringValue(); } },
                {"lastLoginResult", (o,n) => { (o as CloudPC).LastLoginResult = n.GetObjectValue<CloudPcLoginResult>(CloudPcLoginResult.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as CloudPC).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRemoteActionResult", (o,n) => { (o as CloudPC).LastRemoteActionResult = n.GetObjectValue<CloudPcRemoteActionResult>(CloudPcRemoteActionResult.CreateFromDiscriminatorValue); } },
                {"managedDeviceId", (o,n) => { (o as CloudPC).ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", (o,n) => { (o as CloudPC).ManagedDeviceName = n.GetStringValue(); } },
                {"onPremisesConnectionName", (o,n) => { (o as CloudPC).OnPremisesConnectionName = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as CloudPC).OsVersion = n.GetEnumValue<CloudPcOperatingSystem>(); } },
                {"provisioningPolicyId", (o,n) => { (o as CloudPC).ProvisioningPolicyId = n.GetStringValue(); } },
                {"provisioningPolicyName", (o,n) => { (o as CloudPC).ProvisioningPolicyName = n.GetStringValue(); } },
                {"servicePlanId", (o,n) => { (o as CloudPC).ServicePlanId = n.GetStringValue(); } },
                {"servicePlanName", (o,n) => { (o as CloudPC).ServicePlanName = n.GetStringValue(); } },
                {"servicePlanType", (o,n) => { (o as CloudPC).ServicePlanType = n.GetEnumValue<CloudPcServicePlanType>(); } },
                {"status", (o,n) => { (o as CloudPC).Status = n.GetEnumValue<CloudPcStatus>(); } },
                {"statusDetails", (o,n) => { (o as CloudPC).StatusDetails = n.GetObjectValue<CloudPcStatusDetails>(CloudPcStatusDetails.CreateFromDiscriminatorValue); } },
                {"userAccountType", (o,n) => { (o as CloudPC).UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
                {"userPrincipalName", (o,n) => { (o as CloudPC).UserPrincipalName = n.GetStringValue(); } },
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
