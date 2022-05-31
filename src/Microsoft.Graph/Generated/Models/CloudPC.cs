using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class CloudPC : Entity, IParsable {
        /// <summary>The Azure Active Directory (Azure AD) device ID of the Cloud PC.</summary>
        public string AadDeviceId {
            get { return BackingStore?.Get<string>(nameof(AadDeviceId)); }
            set { BackingStore?.Set(nameof(AadDeviceId), value); }
        }
        /// <summary>The display name of the Cloud PC.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The date and time when the grace period ends and reprovisioning/deprovisioning happens. Required only if the status is inGracePeriod. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? GracePeriodEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(GracePeriodEndDateTime)); }
            set { BackingStore?.Set(nameof(GracePeriodEndDateTime), value); }
        }
        /// <summary>Name of the OS image that&apos;s on the Cloud PC.</summary>
        public string ImageDisplayName {
            get { return BackingStore?.Get<string>(nameof(ImageDisplayName)); }
            set { BackingStore?.Set(nameof(ImageDisplayName), value); }
        }
        /// <summary>The last login result of the Cloud PC. For example, { &apos;time&apos;: &apos;2014-01-01T00:00:00Z&apos;}.</summary>
        public CloudPcLoginResult LastLoginResult {
            get { return BackingStore?.Get<CloudPcLoginResult>(nameof(LastLoginResult)); }
            set { BackingStore?.Set(nameof(LastLoginResult), value); }
        }
        /// <summary>The last modified date and time of the Cloud PC. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The last remote action result of the enterprise Cloud PCs. The supported remote actions are: Reboot, Rename, Reprovision, Restore, and Troubleshoot.</summary>
        public CloudPcRemoteActionResult LastRemoteActionResult {
            get { return BackingStore?.Get<CloudPcRemoteActionResult>(nameof(LastRemoteActionResult)); }
            set { BackingStore?.Set(nameof(LastRemoteActionResult), value); }
        }
        /// <summary>The Intune device ID of the Cloud PC.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>The Intune device name of the Cloud PC.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceName)); }
            set { BackingStore?.Set(nameof(ManagedDeviceName), value); }
        }
        /// <summary>The Azure network connection that is applied during the provisioning of Cloud PCs.</summary>
        public string OnPremisesConnectionName {
            get { return BackingStore?.Get<string>(nameof(OnPremisesConnectionName)); }
            set { BackingStore?.Set(nameof(OnPremisesConnectionName), value); }
        }
        /// <summary>The version of the operating system (OS) to provision on Cloud PCs. Possible values are: windows10, windows11, and unknownFutureValue.</summary>
        public CloudPcOperatingSystem? OsVersion {
            get { return BackingStore?.Get<CloudPcOperatingSystem?>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>The provisioning policy ID of the Cloud PC.</summary>
        public string ProvisioningPolicyId {
            get { return BackingStore?.Get<string>(nameof(ProvisioningPolicyId)); }
            set { BackingStore?.Set(nameof(ProvisioningPolicyId), value); }
        }
        /// <summary>The provisioning policy that is applied during the provisioning of Cloud PCs.</summary>
        public string ProvisioningPolicyName {
            get { return BackingStore?.Get<string>(nameof(ProvisioningPolicyName)); }
            set { BackingStore?.Set(nameof(ProvisioningPolicyName), value); }
        }
        /// <summary>The service plan ID of the Cloud PC.</summary>
        public string ServicePlanId {
            get { return BackingStore?.Get<string>(nameof(ServicePlanId)); }
            set { BackingStore?.Set(nameof(ServicePlanId), value); }
        }
        /// <summary>The service plan name of the Cloud PC.</summary>
        public string ServicePlanName {
            get { return BackingStore?.Get<string>(nameof(ServicePlanName)); }
            set { BackingStore?.Set(nameof(ServicePlanName), value); }
        }
        /// <summary>The service plan type of the Cloud PC.</summary>
        public CloudPcServicePlanType? ServicePlanType {
            get { return BackingStore?.Get<CloudPcServicePlanType?>(nameof(ServicePlanType)); }
            set { BackingStore?.Set(nameof(ServicePlanType), value); }
        }
        /// <summary>The status of the Cloud PC. Possible values are: notProvisioned, provisioning, provisioned, upgrading, inGracePeriod, deprovisioning, failed, restoring.</summary>
        public CloudPcStatus? Status {
            get { return BackingStore?.Get<CloudPcStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The details of the Cloud PC status.</summary>
        public CloudPcStatusDetails StatusDetails {
            get { return BackingStore?.Get<CloudPcStatusDetails>(nameof(StatusDetails)); }
            set { BackingStore?.Set(nameof(StatusDetails), value); }
        }
        /// <summary>The account type of the user on provisioned Cloud PCs. Possible values are: standardUser, administrator, and unknownFutureValue.</summary>
        public CloudPcUserAccountType? UserAccountType {
            get { return BackingStore?.Get<CloudPcUserAccountType?>(nameof(UserAccountType)); }
            set { BackingStore?.Set(nameof(UserAccountType), value); }
        }
        /// <summary>The user principal name (UPN) of the user assigned to the Cloud PC.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
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
