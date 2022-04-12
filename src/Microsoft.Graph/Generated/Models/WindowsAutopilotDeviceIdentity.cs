using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsAutopilotDeviceIdentity : Entity, IParsable {
        /// <summary>Addressable user name.</summary>
        public string AddressableUserName { get; set; }
        /// <summary>AAD Device ID - to be deprecated</summary>
        public string AzureActiveDirectoryDeviceId { get; set; }
        /// <summary>AAD Device ID</summary>
        public string AzureAdDeviceId { get; set; }
        /// <summary>Deployment profile currently assigned to the Windows autopilot device.</summary>
        public WindowsAutopilotDeploymentProfile DeploymentProfile { get; set; }
        /// <summary>Profile set time of the Windows autopilot device.</summary>
        public DateTimeOffset? DeploymentProfileAssignedDateTime { get; set; }
        /// <summary>Profile assignment detailed status of the Windows autopilot device. Possible values are: none, hardwareRequirementsNotMet, surfaceHubProfileNotSupported, holoLensProfileNotSupported, windowsPcProfileNotSupported, surfaceHub2SProfileNotSupported, unknownFutureValue.</summary>
        public WindowsAutopilotProfileAssignmentDetailedStatus? DeploymentProfileAssignmentDetailedStatus { get; set; }
        /// <summary>Profile assignment status of the Windows autopilot device. Possible values are: unknown, assignedInSync, assignedOutOfSync, assignedUnkownSyncState, notAssigned, pending, failed.</summary>
        public WindowsAutopilotProfileAssignmentStatus? DeploymentProfileAssignmentStatus { get; set; }
        /// <summary>Surface Hub Device Account Password</summary>
        public string DeviceAccountPassword { get; set; }
        /// <summary>Surface Hub Device Account Upn</summary>
        public string DeviceAccountUpn { get; set; }
        /// <summary>Surface Hub Device Friendly Name</summary>
        public string DeviceFriendlyName { get; set; }
        /// <summary>Display Name</summary>
        public string DisplayName { get; set; }
        /// <summary>Intune enrollment state of the Windows autopilot device. Possible values are: unknown, enrolled, pendingReset, failed, notContacted.</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState { get; set; }
        /// <summary>Group Tag of the Windows autopilot device.</summary>
        public string GroupTag { get; set; }
        /// <summary>Deployment profile intended to be assigned to the Windows autopilot device.</summary>
        public WindowsAutopilotDeploymentProfile IntendedDeploymentProfile { get; set; }
        /// <summary>Intune Last Contacted Date Time of the Windows autopilot device.</summary>
        public DateTimeOffset? LastContactedDateTime { get; set; }
        /// <summary>Managed Device ID</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>Oem manufacturer of the Windows autopilot device.</summary>
        public string Manufacturer { get; set; }
        /// <summary>Model name of the Windows autopilot device.</summary>
        public string Model { get; set; }
        /// <summary>Product Key of the Windows autopilot device.</summary>
        public string ProductKey { get; set; }
        /// <summary>Purchase Order Identifier of the Windows autopilot device.</summary>
        public string PurchaseOrderIdentifier { get; set; }
        /// <summary>Resource Name.</summary>
        public string ResourceName { get; set; }
        /// <summary>Serial number of the Windows autopilot device.</summary>
        public string SerialNumber { get; set; }
        /// <summary>SKU Number</summary>
        public string SkuNumber { get; set; }
        /// <summary>System Family</summary>
        public string SystemFamily { get; set; }
        /// <summary>User Principal Name.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsAutopilotDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAutopilotDeviceIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addressableUserName", n => { AddressableUserName = n.GetStringValue(); } },
                {"azureActiveDirectoryDeviceId", n => { AzureActiveDirectoryDeviceId = n.GetStringValue(); } },
                {"azureAdDeviceId", n => { AzureAdDeviceId = n.GetStringValue(); } },
                {"deploymentProfile", n => { DeploymentProfile = n.GetObjectValue<WindowsAutopilotDeploymentProfile>(WindowsAutopilotDeploymentProfile.CreateFromDiscriminatorValue); } },
                {"deploymentProfileAssignedDateTime", n => { DeploymentProfileAssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentProfileAssignmentDetailedStatus", n => { DeploymentProfileAssignmentDetailedStatus = n.GetEnumValue<WindowsAutopilotProfileAssignmentDetailedStatus>(); } },
                {"deploymentProfileAssignmentStatus", n => { DeploymentProfileAssignmentStatus = n.GetEnumValue<WindowsAutopilotProfileAssignmentStatus>(); } },
                {"deviceAccountPassword", n => { DeviceAccountPassword = n.GetStringValue(); } },
                {"deviceAccountUpn", n => { DeviceAccountUpn = n.GetStringValue(); } },
                {"deviceFriendlyName", n => { DeviceFriendlyName = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrollmentState", n => { EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"groupTag", n => { GroupTag = n.GetStringValue(); } },
                {"intendedDeploymentProfile", n => { IntendedDeploymentProfile = n.GetObjectValue<WindowsAutopilotDeploymentProfile>(WindowsAutopilotDeploymentProfile.CreateFromDiscriminatorValue); } },
                {"lastContactedDateTime", n => { LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"productKey", n => { ProductKey = n.GetStringValue(); } },
                {"purchaseOrderIdentifier", n => { PurchaseOrderIdentifier = n.GetStringValue(); } },
                {"resourceName", n => { ResourceName = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"skuNumber", n => { SkuNumber = n.GetStringValue(); } },
                {"systemFamily", n => { SystemFamily = n.GetStringValue(); } },
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
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("azureActiveDirectoryDeviceId", AzureActiveDirectoryDeviceId);
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteObjectValue<WindowsAutopilotDeploymentProfile>("deploymentProfile", DeploymentProfile);
            writer.WriteDateTimeOffsetValue("deploymentProfileAssignedDateTime", DeploymentProfileAssignedDateTime);
            writer.WriteEnumValue<WindowsAutopilotProfileAssignmentDetailedStatus>("deploymentProfileAssignmentDetailedStatus", DeploymentProfileAssignmentDetailedStatus);
            writer.WriteEnumValue<WindowsAutopilotProfileAssignmentStatus>("deploymentProfileAssignmentStatus", DeploymentProfileAssignmentStatus);
            writer.WriteStringValue("deviceAccountPassword", DeviceAccountPassword);
            writer.WriteStringValue("deviceAccountUpn", DeviceAccountUpn);
            writer.WriteStringValue("deviceFriendlyName", DeviceFriendlyName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteObjectValue<WindowsAutopilotDeploymentProfile>("intendedDeploymentProfile", IntendedDeploymentProfile);
            writer.WriteDateTimeOffsetValue("lastContactedDateTime", LastContactedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteStringValue("purchaseOrderIdentifier", PurchaseOrderIdentifier);
            writer.WriteStringValue("resourceName", ResourceName);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("skuNumber", SkuNumber);
            writer.WriteStringValue("systemFamily", SystemFamily);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
