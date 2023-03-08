using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPC : Entity, IParsable {
        /// <summary>The Azure Active Directory (Azure AD) device ID of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AadDeviceId {
            get { return BackingStore?.Get<string?>("aadDeviceId"); }
            set { BackingStore?.Set("aadDeviceId", value); }
        }
#nullable restore
#else
        public string AadDeviceId {
            get { return BackingStore?.Get<string>("aadDeviceId"); }
            set { BackingStore?.Set("aadDeviceId", value); }
        }
#endif
        /// <summary>The connectivity health check result of a Cloud PC, including the updated timestamp and whether the Cloud PC is able to be connected or not.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcConnectivityResult? ConnectivityResult {
            get { return BackingStore?.Get<CloudPcConnectivityResult?>("connectivityResult"); }
            set { BackingStore?.Set("connectivityResult", value); }
        }
#nullable restore
#else
        public CloudPcConnectivityResult ConnectivityResult {
            get { return BackingStore?.Get<CloudPcConnectivityResult>("connectivityResult"); }
            set { BackingStore?.Set("connectivityResult", value); }
        }
#endif
        /// <summary>The disk encryption applied to the Cloud PC. Possible values: notAvailable, notEncrypted, encryptedUsingPlatformManagedKey, encryptedUsingCustomerManagedKey, and unknownFutureValue.</summary>
        public CloudPcDiskEncryptionState? DiskEncryptionState {
            get { return BackingStore?.Get<CloudPcDiskEncryptionState?>("diskEncryptionState"); }
            set { BackingStore?.Set("diskEncryptionState", value); }
        }
        /// <summary>The display name of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The date and time when the grace period ends and reprovisioning/deprovisioning happens. Required only if the status is inGracePeriod. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? GracePeriodEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("gracePeriodEndDateTime"); }
            set { BackingStore?.Set("gracePeriodEndDateTime", value); }
        }
        /// <summary>Name of the OS image that&apos;s on the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageDisplayName {
            get { return BackingStore?.Get<string?>("imageDisplayName"); }
            set { BackingStore?.Set("imageDisplayName", value); }
        }
#nullable restore
#else
        public string ImageDisplayName {
            get { return BackingStore?.Get<string>("imageDisplayName"); }
            set { BackingStore?.Set("imageDisplayName", value); }
        }
#endif
        /// <summary>The last login result of the Cloud PC. For example, { &apos;time&apos;: &apos;2014-01-01T00:00:00Z&apos;}.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcLoginResult? LastLoginResult {
            get { return BackingStore?.Get<CloudPcLoginResult?>("lastLoginResult"); }
            set { BackingStore?.Set("lastLoginResult", value); }
        }
#nullable restore
#else
        public CloudPcLoginResult LastLoginResult {
            get { return BackingStore?.Get<CloudPcLoginResult>("lastLoginResult"); }
            set { BackingStore?.Set("lastLoginResult", value); }
        }
#endif
        /// <summary>The last modified date and time of the Cloud PC. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The last remote action result of the enterprise Cloud PCs. The supported remote actions are: Reboot, Rename, Reprovision, Restore, and Troubleshoot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcRemoteActionResult? LastRemoteActionResult {
            get { return BackingStore?.Get<CloudPcRemoteActionResult?>("lastRemoteActionResult"); }
            set { BackingStore?.Set("lastRemoteActionResult", value); }
        }
#nullable restore
#else
        public CloudPcRemoteActionResult LastRemoteActionResult {
            get { return BackingStore?.Get<CloudPcRemoteActionResult>("lastRemoteActionResult"); }
            set { BackingStore?.Set("lastRemoteActionResult", value); }
        }
#endif
        /// <summary>The Intune device ID of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
        /// <summary>The Intune device name of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceName {
            get { return BackingStore?.Get<string?>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
#nullable restore
#else
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
#endif
        /// <summary>The Azure network connection that is applied during the provisioning of Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesConnectionName {
            get { return BackingStore?.Get<string?>("onPremisesConnectionName"); }
            set { BackingStore?.Set("onPremisesConnectionName", value); }
        }
#nullable restore
#else
        public string OnPremisesConnectionName {
            get { return BackingStore?.Get<string>("onPremisesConnectionName"); }
            set { BackingStore?.Set("onPremisesConnectionName", value); }
        }
#endif
        /// <summary>The version of the operating system (OS) to provision on Cloud PCs. Possible values are: windows10, windows11, and unknownFutureValue.</summary>
        public CloudPcOperatingSystem? OsVersion {
            get { return BackingStore?.Get<CloudPcOperatingSystem?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>The results of every partner agent&apos;s installation status on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcPartnerAgentInstallResult>? PartnerAgentInstallResults {
            get { return BackingStore?.Get<List<CloudPcPartnerAgentInstallResult>?>("partnerAgentInstallResults"); }
            set { BackingStore?.Set("partnerAgentInstallResults", value); }
        }
#nullable restore
#else
        public List<CloudPcPartnerAgentInstallResult> PartnerAgentInstallResults {
            get { return BackingStore?.Get<List<CloudPcPartnerAgentInstallResult>>("partnerAgentInstallResults"); }
            set { BackingStore?.Set("partnerAgentInstallResults", value); }
        }
#endif
        /// <summary>The provisioning policy ID of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningPolicyId {
            get { return BackingStore?.Get<string?>("provisioningPolicyId"); }
            set { BackingStore?.Set("provisioningPolicyId", value); }
        }
#nullable restore
#else
        public string ProvisioningPolicyId {
            get { return BackingStore?.Get<string>("provisioningPolicyId"); }
            set { BackingStore?.Set("provisioningPolicyId", value); }
        }
#endif
        /// <summary>The provisioning policy that is applied during the provisioning of Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningPolicyName {
            get { return BackingStore?.Get<string?>("provisioningPolicyName"); }
            set { BackingStore?.Set("provisioningPolicyName", value); }
        }
#nullable restore
#else
        public string ProvisioningPolicyName {
            get { return BackingStore?.Get<string>("provisioningPolicyName"); }
            set { BackingStore?.Set("provisioningPolicyName", value); }
        }
#endif
        /// <summary>The type of licenses to be used when provisioning Cloud PCs using this policy. Possible values are: dedicated, shared, unknownFutureValue. Default value is dedicated.</summary>
        public CloudPcProvisioningType? ProvisioningType {
            get { return BackingStore?.Get<CloudPcProvisioningType?>("provisioningType"); }
            set { BackingStore?.Set("provisioningType", value); }
        }
        /// <summary>The service plan ID of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePlanId {
            get { return BackingStore?.Get<string?>("servicePlanId"); }
            set { BackingStore?.Set("servicePlanId", value); }
        }
#nullable restore
#else
        public string ServicePlanId {
            get { return BackingStore?.Get<string>("servicePlanId"); }
            set { BackingStore?.Set("servicePlanId", value); }
        }
#endif
        /// <summary>The service plan name of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePlanName {
            get { return BackingStore?.Get<string?>("servicePlanName"); }
            set { BackingStore?.Set("servicePlanName", value); }
        }
#nullable restore
#else
        public string ServicePlanName {
            get { return BackingStore?.Get<string>("servicePlanName"); }
            set { BackingStore?.Set("servicePlanName", value); }
        }
#endif
        /// <summary>The service plan type of the Cloud PC.</summary>
        public CloudPcServicePlanType? ServicePlanType {
            get { return BackingStore?.Get<CloudPcServicePlanType?>("servicePlanType"); }
            set { BackingStore?.Set("servicePlanType", value); }
        }
        /// <summary>The status property</summary>
        public CloudPcStatus? Status {
            get { return BackingStore?.Get<CloudPcStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The details of the Cloud PC status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcStatusDetails? StatusDetails {
            get { return BackingStore?.Get<CloudPcStatusDetails?>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#nullable restore
#else
        public CloudPcStatusDetails StatusDetails {
            get { return BackingStore?.Get<CloudPcStatusDetails>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#endif
        /// <summary>The account type of the user on provisioned Cloud PCs. Possible values are: standardUser, administrator, and unknownFutureValue.</summary>
        public CloudPcUserAccountType? UserAccountType {
            get { return BackingStore?.Get<CloudPcUserAccountType?>("userAccountType"); }
            set { BackingStore?.Set("userAccountType", value); }
        }
        /// <summary>The user principal name (UPN) of the user assigned to the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"connectivityResult", n => { ConnectivityResult = n.GetObjectValue<CloudPcConnectivityResult>(CloudPcConnectivityResult.CreateFromDiscriminatorValue); } },
                {"diskEncryptionState", n => { DiskEncryptionState = n.GetEnumValue<CloudPcDiskEncryptionState>(); } },
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
                {"partnerAgentInstallResults", n => { PartnerAgentInstallResults = n.GetCollectionOfObjectValues<CloudPcPartnerAgentInstallResult>(CloudPcPartnerAgentInstallResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"provisioningPolicyId", n => { ProvisioningPolicyId = n.GetStringValue(); } },
                {"provisioningPolicyName", n => { ProvisioningPolicyName = n.GetStringValue(); } },
                {"provisioningType", n => { ProvisioningType = n.GetEnumValue<CloudPcProvisioningType>(); } },
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aadDeviceId", AadDeviceId);
            writer.WriteObjectValue<CloudPcConnectivityResult>("connectivityResult", ConnectivityResult);
            writer.WriteEnumValue<CloudPcDiskEncryptionState>("diskEncryptionState", DiskEncryptionState);
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
            writer.WriteCollectionOfObjectValues<CloudPcPartnerAgentInstallResult>("partnerAgentInstallResults", PartnerAgentInstallResults);
            writer.WriteStringValue("provisioningPolicyId", ProvisioningPolicyId);
            writer.WriteStringValue("provisioningPolicyName", ProvisioningPolicyName);
            writer.WriteEnumValue<CloudPcProvisioningType>("provisioningType", ProvisioningType);
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
