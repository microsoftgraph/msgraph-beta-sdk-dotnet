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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addressableUserName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).AddressableUserName = n.GetStringValue(); } },
                {"azureActiveDirectoryDeviceId", (o,n) => { (o as WindowsAutopilotDeviceIdentity).AzureActiveDirectoryDeviceId = n.GetStringValue(); } },
                {"azureAdDeviceId", (o,n) => { (o as WindowsAutopilotDeviceIdentity).AzureAdDeviceId = n.GetStringValue(); } },
                {"deploymentProfile", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DeploymentProfile = n.GetObjectValue<WindowsAutopilotDeploymentProfile>(WindowsAutopilotDeploymentProfile.CreateFromDiscriminatorValue); } },
                {"deploymentProfileAssignedDateTime", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DeploymentProfileAssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentProfileAssignmentDetailedStatus", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DeploymentProfileAssignmentDetailedStatus = n.GetEnumValue<WindowsAutopilotProfileAssignmentDetailedStatus>(); } },
                {"deploymentProfileAssignmentStatus", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DeploymentProfileAssignmentStatus = n.GetEnumValue<WindowsAutopilotProfileAssignmentStatus>(); } },
                {"deviceAccountPassword", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DeviceAccountPassword = n.GetStringValue(); } },
                {"deviceAccountUpn", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DeviceAccountUpn = n.GetStringValue(); } },
                {"deviceFriendlyName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DeviceFriendlyName = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DisplayName = n.GetStringValue(); } },
                {"enrollmentState", (o,n) => { (o as WindowsAutopilotDeviceIdentity).EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"groupTag", (o,n) => { (o as WindowsAutopilotDeviceIdentity).GroupTag = n.GetStringValue(); } },
                {"intendedDeploymentProfile", (o,n) => { (o as WindowsAutopilotDeviceIdentity).IntendedDeploymentProfile = n.GetObjectValue<WindowsAutopilotDeploymentProfile>(WindowsAutopilotDeploymentProfile.CreateFromDiscriminatorValue); } },
                {"lastContactedDateTime", (o,n) => { (o as WindowsAutopilotDeviceIdentity).LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", (o,n) => { (o as WindowsAutopilotDeviceIdentity).ManagedDeviceId = n.GetStringValue(); } },
                {"manufacturer", (o,n) => { (o as WindowsAutopilotDeviceIdentity).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as WindowsAutopilotDeviceIdentity).Model = n.GetStringValue(); } },
                {"productKey", (o,n) => { (o as WindowsAutopilotDeviceIdentity).ProductKey = n.GetStringValue(); } },
                {"purchaseOrderIdentifier", (o,n) => { (o as WindowsAutopilotDeviceIdentity).PurchaseOrderIdentifier = n.GetStringValue(); } },
                {"resourceName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).ResourceName = n.GetStringValue(); } },
                {"serialNumber", (o,n) => { (o as WindowsAutopilotDeviceIdentity).SerialNumber = n.GetStringValue(); } },
                {"skuNumber", (o,n) => { (o as WindowsAutopilotDeviceIdentity).SkuNumber = n.GetStringValue(); } },
                {"systemFamily", (o,n) => { (o as WindowsAutopilotDeviceIdentity).SystemFamily = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).UserPrincipalName = n.GetStringValue(); } },
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
