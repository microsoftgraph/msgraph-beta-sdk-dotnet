using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The windowsAutopilotDeviceIdentity resource represents a Windows Autopilot Device.</summary>
    public class WindowsAutopilotDeviceIdentity : Entity, IParsable {
        /// <summary>Addressable user name.</summary>
        public string AddressableUserName {
            get { return BackingStore?.Get<string>(nameof(AddressableUserName)); }
            set { BackingStore?.Set(nameof(AddressableUserName), value); }
        }
        /// <summary>AAD Device ID - to be deprecated</summary>
        public string AzureActiveDirectoryDeviceId {
            get { return BackingStore?.Get<string>(nameof(AzureActiveDirectoryDeviceId)); }
            set { BackingStore?.Set(nameof(AzureActiveDirectoryDeviceId), value); }
        }
        /// <summary>AAD Device ID</summary>
        public string AzureAdDeviceId {
            get { return BackingStore?.Get<string>(nameof(AzureAdDeviceId)); }
            set { BackingStore?.Set(nameof(AzureAdDeviceId), value); }
        }
        /// <summary>Deployment profile currently assigned to the Windows autopilot device.</summary>
        public WindowsAutopilotDeploymentProfile DeploymentProfile {
            get { return BackingStore?.Get<WindowsAutopilotDeploymentProfile>(nameof(DeploymentProfile)); }
            set { BackingStore?.Set(nameof(DeploymentProfile), value); }
        }
        /// <summary>Profile set time of the Windows autopilot device.</summary>
        public DateTimeOffset? DeploymentProfileAssignedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DeploymentProfileAssignedDateTime)); }
            set { BackingStore?.Set(nameof(DeploymentProfileAssignedDateTime), value); }
        }
        /// <summary>Profile assignment detailed status of the Windows autopilot device. Possible values are: none, hardwareRequirementsNotMet, surfaceHubProfileNotSupported, holoLensProfileNotSupported, windowsPcProfileNotSupported, surfaceHub2SProfileNotSupported, unknownFutureValue.</summary>
        public WindowsAutopilotProfileAssignmentDetailedStatus? DeploymentProfileAssignmentDetailedStatus {
            get { return BackingStore?.Get<WindowsAutopilotProfileAssignmentDetailedStatus?>(nameof(DeploymentProfileAssignmentDetailedStatus)); }
            set { BackingStore?.Set(nameof(DeploymentProfileAssignmentDetailedStatus), value); }
        }
        /// <summary>Profile assignment status of the Windows autopilot device. Possible values are: unknown, assignedInSync, assignedOutOfSync, assignedUnkownSyncState, notAssigned, pending, failed.</summary>
        public WindowsAutopilotProfileAssignmentStatus? DeploymentProfileAssignmentStatus {
            get { return BackingStore?.Get<WindowsAutopilotProfileAssignmentStatus?>(nameof(DeploymentProfileAssignmentStatus)); }
            set { BackingStore?.Set(nameof(DeploymentProfileAssignmentStatus), value); }
        }
        /// <summary>Surface Hub Device Account Password</summary>
        public string DeviceAccountPassword {
            get { return BackingStore?.Get<string>(nameof(DeviceAccountPassword)); }
            set { BackingStore?.Set(nameof(DeviceAccountPassword), value); }
        }
        /// <summary>Surface Hub Device Account Upn</summary>
        public string DeviceAccountUpn {
            get { return BackingStore?.Get<string>(nameof(DeviceAccountUpn)); }
            set { BackingStore?.Set(nameof(DeviceAccountUpn), value); }
        }
        /// <summary>Surface Hub Device Friendly Name</summary>
        public string DeviceFriendlyName {
            get { return BackingStore?.Get<string>(nameof(DeviceFriendlyName)); }
            set { BackingStore?.Set(nameof(DeviceFriendlyName), value); }
        }
        /// <summary>Display Name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Intune enrollment state of the Windows autopilot device. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EnrollmentState?>(nameof(EnrollmentState)); }
            set { BackingStore?.Set(nameof(EnrollmentState), value); }
        }
        /// <summary>Group Tag of the Windows autopilot device.</summary>
        public string GroupTag {
            get { return BackingStore?.Get<string>(nameof(GroupTag)); }
            set { BackingStore?.Set(nameof(GroupTag), value); }
        }
        /// <summary>Deployment profile intended to be assigned to the Windows autopilot device.</summary>
        public WindowsAutopilotDeploymentProfile IntendedDeploymentProfile {
            get { return BackingStore?.Get<WindowsAutopilotDeploymentProfile>(nameof(IntendedDeploymentProfile)); }
            set { BackingStore?.Set(nameof(IntendedDeploymentProfile), value); }
        }
        /// <summary>Intune Last Contacted Date Time of the Windows autopilot device.</summary>
        public DateTimeOffset? LastContactedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastContactedDateTime)); }
            set { BackingStore?.Set(nameof(LastContactedDateTime), value); }
        }
        /// <summary>Managed Device ID</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>Oem manufacturer of the Windows autopilot device.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>Model name of the Windows autopilot device.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>Product Key of the Windows autopilot device.</summary>
        public string ProductKey {
            get { return BackingStore?.Get<string>(nameof(ProductKey)); }
            set { BackingStore?.Set(nameof(ProductKey), value); }
        }
        /// <summary>Purchase Order Identifier of the Windows autopilot device.</summary>
        public string PurchaseOrderIdentifier {
            get { return BackingStore?.Get<string>(nameof(PurchaseOrderIdentifier)); }
            set { BackingStore?.Set(nameof(PurchaseOrderIdentifier), value); }
        }
        /// <summary>Device Remediation State. Possible values are: unknown, noRemediationRequired, automaticRemediationRequired, manualRemediationRequired, unknownFutureValue.</summary>
        public WindowsAutopilotDeviceRemediationState? RemediationState {
            get { return BackingStore?.Get<WindowsAutopilotDeviceRemediationState?>(nameof(RemediationState)); }
            set { BackingStore?.Set(nameof(RemediationState), value); }
        }
        /// <summary>RemediationState set time of Autopilot device.</summary>
        public DateTimeOffset? RemediationStateLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RemediationStateLastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(RemediationStateLastModifiedDateTime), value); }
        }
        /// <summary>Resource Name.</summary>
        public string ResourceName {
            get { return BackingStore?.Get<string>(nameof(ResourceName)); }
            set { BackingStore?.Set(nameof(ResourceName), value); }
        }
        /// <summary>Serial number of the Windows autopilot device.</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>(nameof(SerialNumber)); }
            set { BackingStore?.Set(nameof(SerialNumber), value); }
        }
        /// <summary>SKU Number</summary>
        public string SkuNumber {
            get { return BackingStore?.Get<string>(nameof(SkuNumber)); }
            set { BackingStore?.Set(nameof(SkuNumber), value); }
        }
        /// <summary>System Family</summary>
        public string SystemFamily {
            get { return BackingStore?.Get<string>(nameof(SystemFamily)); }
            set { BackingStore?.Set(nameof(SystemFamily), value); }
        }
        /// <summary>User Principal Name.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
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
                {"remediationState", n => { RemediationState = n.GetEnumValue<WindowsAutopilotDeviceRemediationState>(); } },
                {"remediationStateLastModifiedDateTime", n => { RemediationStateLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteEnumValue<WindowsAutopilotDeviceRemediationState>("remediationState", RemediationState);
            writer.WriteDateTimeOffsetValue("remediationStateLastModifiedDateTime", RemediationStateLastModifiedDateTime);
            writer.WriteStringValue("resourceName", ResourceName);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("skuNumber", SkuNumber);
            writer.WriteStringValue("systemFamily", SystemFamily);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
