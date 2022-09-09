using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class CloudPC : Entity, IParsable {
        /// <summary>The Azure Active Directory (Azure AD) device ID of the Cloud PC.</summary>
        public string AadDeviceId {
            get { return BackingStore?.Get<string>("aadDeviceId"); }
            set { BackingStore?.Set("aadDeviceId", value); }
        }
        /// <summary>The connectivity health check result of a Cloud PC, including the updated timestamp and whether the Cloud PC is able to be connected or not.</summary>
        public CloudPcConnectivityResult ConnectivityResult {
            get { return BackingStore?.Get<CloudPcConnectivityResult>("connectivityResult"); }
            set { BackingStore?.Set("connectivityResult", value); }
        }
        /// <summary>The display name of the Cloud PC.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The date and time when the grace period ends and reprovisioning/deprovisioning happens. Required only if the status is inGracePeriod. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? GracePeriodEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("gracePeriodEndDateTime"); }
            set { BackingStore?.Set("gracePeriodEndDateTime", value); }
        }
        /// <summary>Name of the OS image that&apos;s on the Cloud PC.</summary>
        public string ImageDisplayName {
            get { return BackingStore?.Get<string>("imageDisplayName"); }
            set { BackingStore?.Set("imageDisplayName", value); }
        }
        /// <summary>The last login result of the Cloud PC. For example, { &apos;time&apos;: &apos;2014-01-01T00:00:00Z&apos;}.</summary>
        public CloudPcLoginResult LastLoginResult {
            get { return BackingStore?.Get<CloudPcLoginResult>("lastLoginResult"); }
            set { BackingStore?.Set("lastLoginResult", value); }
        }
        /// <summary>The last modified date and time of the Cloud PC. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The last remote action result of the enterprise Cloud PCs. The supported remote actions are: Reboot, Rename, Reprovision, Restore, and Troubleshoot.</summary>
        public CloudPcRemoteActionResult LastRemoteActionResult {
            get { return BackingStore?.Get<CloudPcRemoteActionResult>("lastRemoteActionResult"); }
            set { BackingStore?.Set("lastRemoteActionResult", value); }
        }
        /// <summary>The Intune device ID of the Cloud PC.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>The Intune device name of the Cloud PC.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
        /// <summary>The Azure network connection that is applied during the provisioning of Cloud PCs.</summary>
        public string OnPremisesConnectionName {
            get { return BackingStore?.Get<string>("onPremisesConnectionName"); }
            set { BackingStore?.Set("onPremisesConnectionName", value); }
        }
        /// <summary>The version of the operating system (OS) to provision on Cloud PCs. Possible values are: windows10, windows11, and unknownFutureValue.</summary>
        public CloudPcOperatingSystem? OsVersion {
            get { return BackingStore?.Get<CloudPcOperatingSystem?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>The provisioning policy ID of the Cloud PC.</summary>
        public string ProvisioningPolicyId {
            get { return BackingStore?.Get<string>("provisioningPolicyId"); }
            set { BackingStore?.Set("provisioningPolicyId", value); }
        }
        /// <summary>The provisioning policy that is applied during the provisioning of Cloud PCs.</summary>
        public string ProvisioningPolicyName {
            get { return BackingStore?.Get<string>("provisioningPolicyName"); }
            set { BackingStore?.Set("provisioningPolicyName", value); }
        }
        /// <summary>The service plan ID of the Cloud PC.</summary>
        public string ServicePlanId {
            get { return BackingStore?.Get<string>("servicePlanId"); }
            set { BackingStore?.Set("servicePlanId", value); }
        }
        /// <summary>The service plan name of the Cloud PC.</summary>
        public string ServicePlanName {
            get { return BackingStore?.Get<string>("servicePlanName"); }
            set { BackingStore?.Set("servicePlanName", value); }
        }
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
        public CloudPcStatusDetails StatusDetails {
            get { return BackingStore?.Get<CloudPcStatusDetails>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
        /// <summary>The account type of the user on provisioned Cloud PCs. Possible values are: standardUser, administrator, and unknownFutureValue.</summary>
        public CloudPcUserAccountType? UserAccountType {
            get { return BackingStore?.Get<CloudPcUserAccountType?>("userAccountType"); }
            set { BackingStore?.Set("userAccountType", value); }
        }
        /// <summary>The user principal name (UPN) of the user assigned to the Cloud PC.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPC and sets the default values.
        /// </summary>
        public CloudPC() : base() {
            OdataType = "#microsoft.graph.cloudPC";
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
                {"connectivityResult", n => { ConnectivityResult = n.GetObjectValue<CloudPcConnectivityResult>(CloudPcConnectivityResult.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<CloudPcConnectivityResult>("connectivityResult", ConnectivityResult);
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
