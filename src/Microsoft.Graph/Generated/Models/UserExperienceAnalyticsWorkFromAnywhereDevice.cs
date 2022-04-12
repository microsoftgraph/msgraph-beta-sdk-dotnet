using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsWorkFromAnywhereDevice : Entity, IParsable {
        /// <summary>The user experience analytics work from anywhere intune device&apos;s autopilotProfileAssigned.</summary>
        public bool? AutoPilotProfileAssigned { get; set; }
        /// <summary>The user experience work from anywhere intune device&apos;s autopilotRegistered.</summary>
        public bool? AutoPilotRegistered { get; set; }
        /// <summary>The user experience work from anywhere azure Ad device Id.</summary>
        public string AzureAdDeviceId { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s azure Ad joinType.</summary>
        public string AzureAdJoinType { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s azureAdRegistered.</summary>
        public bool? AzureAdRegistered { get; set; }
        /// <summary>The user experience work from anywhere per device cloud identity score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudIdentityScore { get; set; }
        /// <summary>The user experience work from anywhere per device cloud management score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudManagementScore { get; set; }
        /// <summary>The user experience work from anywhere per device cloud provisioning score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudProvisioningScore { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s compliancePolicySetToIntune.</summary>
        public bool? CompliancePolicySetToIntune { get; set; }
        /// <summary>The user experience work from anywhere device Id.</summary>
        public string DeviceId { get; set; }
        /// <summary>The work from anywhere device&apos;s name.</summary>
        public string DeviceName { get; set; }
        /// <summary>The user experience work from anywhere per device health status. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s Cloud Management Gateway for Configuration Manager is enabled.</summary>
        public bool? IsCloudManagedGatewayEnabled { get; set; }
        /// <summary>The user experience work from anywhere management agent of the device.</summary>
        public string ManagedBy { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s model.</summary>
        public string Model { get; set; }
        /// <summary>The user experience work from anywhere device, Is OS check failed for device to upgrade to the latest version of windows.</summary>
        public bool? OsCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s OS Description.</summary>
        public string OsDescription { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s OS Version.</summary>
        public string OsVersion { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s otherWorkloadsSetToIntune.</summary>
        public bool? OtherWorkloadsSetToIntune { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s ownership.</summary>
        public string Ownership { get; set; }
        /// <summary>The user experience work from anywhere device, Is processor hardware 64-bit architecture check failed for device to upgrade to the latest version of windows.</summary>
        public bool? Processor64BitCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device, Is processor hardware core count check failed for device to upgrade to the latest version of windows.</summary>
        public bool? ProcessorCoreCountCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device, Is processor hardware family check failed for device to upgrade to the latest version of windows.</summary>
        public bool? ProcessorFamilyCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device, Is processor hardware speed check failed for device to upgrade to the latest version of windows.</summary>
        public bool? ProcessorSpeedCheckFailed { get; set; }
        /// <summary>Is the user experience analytics work from anywhere device RAM hardware check failed for device to upgrade to the latest version of windows</summary>
        public bool? RamCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device, Is secure boot hardware check failed for device to upgrade to the latest version of windows.</summary>
        public bool? SecureBootCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s serial number.</summary>
        public string SerialNumber { get; set; }
        /// <summary>The user experience work from anywhere device, Is storage hardware check failed for device to upgrade to the latest version of windows.</summary>
        public bool? StorageCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device&apos;s tenantAttached.</summary>
        public bool? TenantAttached { get; set; }
        /// <summary>The user experience work from anywhere device, Is Trusted Platform Module (TPM) hardware check failed for device to the latest version of upgrade to windows.</summary>
        public bool? TpmCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere windows upgrade eligibility status of device. Possible values are: upgraded, unknown, notCapable, capable.</summary>
        public OperatingSystemUpgradeEligibility? UpgradeEligibility { get; set; }
        /// <summary>The user experience work from anywhere per device windows score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WindowsScore { get; set; }
        /// <summary>The user experience work from anywhere per device overall score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsWorkFromAnywhereDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"autoPilotProfileAssigned", n => { AutoPilotProfileAssigned = n.GetBoolValue(); } },
                {"autoPilotRegistered", n => { AutoPilotRegistered = n.GetBoolValue(); } },
                {"azureAdDeviceId", n => { AzureAdDeviceId = n.GetStringValue(); } },
                {"azureAdJoinType", n => { AzureAdJoinType = n.GetStringValue(); } },
                {"azureAdRegistered", n => { AzureAdRegistered = n.GetBoolValue(); } },
                {"cloudIdentityScore", n => { CloudIdentityScore = n.GetDoubleValue(); } },
                {"cloudManagementScore", n => { CloudManagementScore = n.GetDoubleValue(); } },
                {"cloudProvisioningScore", n => { CloudProvisioningScore = n.GetDoubleValue(); } },
                {"compliancePolicySetToIntune", n => { CompliancePolicySetToIntune = n.GetBoolValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"isCloudManagedGatewayEnabled", n => { IsCloudManagedGatewayEnabled = n.GetBoolValue(); } },
                {"managedBy", n => { ManagedBy = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"osCheckFailed", n => { OsCheckFailed = n.GetBoolValue(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"otherWorkloadsSetToIntune", n => { OtherWorkloadsSetToIntune = n.GetBoolValue(); } },
                {"ownership", n => { Ownership = n.GetStringValue(); } },
                {"processor64BitCheckFailed", n => { Processor64BitCheckFailed = n.GetBoolValue(); } },
                {"processorCoreCountCheckFailed", n => { ProcessorCoreCountCheckFailed = n.GetBoolValue(); } },
                {"processorFamilyCheckFailed", n => { ProcessorFamilyCheckFailed = n.GetBoolValue(); } },
                {"processorSpeedCheckFailed", n => { ProcessorSpeedCheckFailed = n.GetBoolValue(); } },
                {"ramCheckFailed", n => { RamCheckFailed = n.GetBoolValue(); } },
                {"secureBootCheckFailed", n => { SecureBootCheckFailed = n.GetBoolValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"storageCheckFailed", n => { StorageCheckFailed = n.GetBoolValue(); } },
                {"tenantAttached", n => { TenantAttached = n.GetBoolValue(); } },
                {"tpmCheckFailed", n => { TpmCheckFailed = n.GetBoolValue(); } },
                {"upgradeEligibility", n => { UpgradeEligibility = n.GetEnumValue<OperatingSystemUpgradeEligibility>(); } },
                {"windowsScore", n => { WindowsScore = n.GetDoubleValue(); } },
                {"workFromAnywhereScore", n => { WorkFromAnywhereScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("autoPilotProfileAssigned", AutoPilotProfileAssigned);
            writer.WriteBoolValue("autoPilotRegistered", AutoPilotRegistered);
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteStringValue("azureAdJoinType", AzureAdJoinType);
            writer.WriteBoolValue("azureAdRegistered", AzureAdRegistered);
            writer.WriteDoubleValue("cloudIdentityScore", CloudIdentityScore);
            writer.WriteDoubleValue("cloudManagementScore", CloudManagementScore);
            writer.WriteDoubleValue("cloudProvisioningScore", CloudProvisioningScore);
            writer.WriteBoolValue("compliancePolicySetToIntune", CompliancePolicySetToIntune);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteBoolValue("isCloudManagedGatewayEnabled", IsCloudManagedGatewayEnabled);
            writer.WriteStringValue("managedBy", ManagedBy);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteBoolValue("osCheckFailed", OsCheckFailed);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteBoolValue("otherWorkloadsSetToIntune", OtherWorkloadsSetToIntune);
            writer.WriteStringValue("ownership", Ownership);
            writer.WriteBoolValue("processor64BitCheckFailed", Processor64BitCheckFailed);
            writer.WriteBoolValue("processorCoreCountCheckFailed", ProcessorCoreCountCheckFailed);
            writer.WriteBoolValue("processorFamilyCheckFailed", ProcessorFamilyCheckFailed);
            writer.WriteBoolValue("processorSpeedCheckFailed", ProcessorSpeedCheckFailed);
            writer.WriteBoolValue("ramCheckFailed", RamCheckFailed);
            writer.WriteBoolValue("secureBootCheckFailed", SecureBootCheckFailed);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteBoolValue("storageCheckFailed", StorageCheckFailed);
            writer.WriteBoolValue("tenantAttached", TenantAttached);
            writer.WriteBoolValue("tpmCheckFailed", TpmCheckFailed);
            writer.WriteEnumValue<OperatingSystemUpgradeEligibility>("upgradeEligibility", UpgradeEligibility);
            writer.WriteDoubleValue("windowsScore", WindowsScore);
            writer.WriteDoubleValue("workFromAnywhereScore", WorkFromAnywhereScore);
        }
    }
}
