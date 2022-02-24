using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsWorkFromAnywhereDevice : Entity, IParsable {
        /// <summary>The user experience analytics work from anywhere intune device's autopilotProfileAssigned.</summary>
        public bool? AutoPilotProfileAssigned { get; set; }
        /// <summary>The user experience work from anywhere intune device's autopilotRegistered.</summary>
        public bool? AutoPilotRegistered { get; set; }
        /// <summary>The user experience work from anywhere azure Ad device Id.</summary>
        public string AzureAdDeviceId { get; set; }
        /// <summary>The user experience work from anywhere device's azure Ad joinType.</summary>
        public string AzureAdJoinType { get; set; }
        /// <summary>The user experience work from anywhere device's azureAdRegistered.</summary>
        public bool? AzureAdRegistered { get; set; }
        /// <summary>The user experience work from anywhere per device cloud identity score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudIdentityScore { get; set; }
        /// <summary>The user experience work from anywhere per device cloud management score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudManagementScore { get; set; }
        /// <summary>The user experience work from anywhere per device cloud provisioning score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudProvisioningScore { get; set; }
        /// <summary>The user experience work from anywhere device's compliancePolicySetToIntune.</summary>
        public bool? CompliancePolicySetToIntune { get; set; }
        /// <summary>The user experience work from anywhere device Id.</summary>
        public string DeviceId { get; set; }
        /// <summary>The work from anywhere device's name.</summary>
        public string DeviceName { get; set; }
        /// <summary>The user experience work from anywhere per device health status. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The user experience work from anywhere device's Cloud Management Gateway for Configuration Manager is enabled.</summary>
        public bool? IsCloudManagedGatewayEnabled { get; set; }
        /// <summary>The user experience work from anywhere management agent of the device.</summary>
        public string ManagedBy { get; set; }
        /// <summary>The user experience work from anywhere device's manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The user experience work from anywhere device's model.</summary>
        public string Model { get; set; }
        /// <summary>The user experience work from anywhere device, Is OS check failed for device to upgrade to the latest version of windows.</summary>
        public bool? OsCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device's OS Description.</summary>
        public string OsDescription { get; set; }
        /// <summary>The user experience work from anywhere device's OS Version.</summary>
        public string OsVersion { get; set; }
        /// <summary>The user experience work from anywhere device's otherWorkloadsSetToIntune.</summary>
        public bool? OtherWorkloadsSetToIntune { get; set; }
        /// <summary>The user experience work from anywhere device's ownership.</summary>
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
        /// <summary>The user experience work from anywhere device's serial number.</summary>
        public string SerialNumber { get; set; }
        /// <summary>The user experience work from anywhere device, Is storage hardware check failed for device to upgrade to the latest version of windows.</summary>
        public bool? StorageCheckFailed { get; set; }
        /// <summary>The user experience work from anywhere device's tenantAttached.</summary>
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"autoPilotProfileAssigned", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).AutoPilotProfileAssigned = n.GetBoolValue(); } },
                {"autoPilotRegistered", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).AutoPilotRegistered = n.GetBoolValue(); } },
                {"azureAdDeviceId", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).AzureAdDeviceId = n.GetStringValue(); } },
                {"azureAdJoinType", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).AzureAdJoinType = n.GetStringValue(); } },
                {"azureAdRegistered", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).AzureAdRegistered = n.GetBoolValue(); } },
                {"cloudIdentityScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).CloudIdentityScore = n.GetDoubleValue(); } },
                {"cloudManagementScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).CloudManagementScore = n.GetDoubleValue(); } },
                {"cloudProvisioningScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).CloudProvisioningScore = n.GetDoubleValue(); } },
                {"compliancePolicySetToIntune", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).CompliancePolicySetToIntune = n.GetBoolValue(); } },
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).DeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).DeviceName = n.GetStringValue(); } },
                {"healthStatus", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"isCloudManagedGatewayEnabled", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).IsCloudManagedGatewayEnabled = n.GetBoolValue(); } },
                {"managedBy", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).ManagedBy = n.GetStringValue(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).Model = n.GetStringValue(); } },
                {"osCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).OsCheckFailed = n.GetBoolValue(); } },
                {"osDescription", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).OsDescription = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).OsVersion = n.GetStringValue(); } },
                {"otherWorkloadsSetToIntune", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).OtherWorkloadsSetToIntune = n.GetBoolValue(); } },
                {"ownership", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).Ownership = n.GetStringValue(); } },
                {"processor64BitCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).Processor64BitCheckFailed = n.GetBoolValue(); } },
                {"processorCoreCountCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).ProcessorCoreCountCheckFailed = n.GetBoolValue(); } },
                {"processorFamilyCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).ProcessorFamilyCheckFailed = n.GetBoolValue(); } },
                {"processorSpeedCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).ProcessorSpeedCheckFailed = n.GetBoolValue(); } },
                {"ramCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).RamCheckFailed = n.GetBoolValue(); } },
                {"secureBootCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).SecureBootCheckFailed = n.GetBoolValue(); } },
                {"serialNumber", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).SerialNumber = n.GetStringValue(); } },
                {"storageCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).StorageCheckFailed = n.GetBoolValue(); } },
                {"tenantAttached", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).TenantAttached = n.GetBoolValue(); } },
                {"tpmCheckFailed", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).TpmCheckFailed = n.GetBoolValue(); } },
                {"upgradeEligibility", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).UpgradeEligibility = n.GetEnumValue<OperatingSystemUpgradeEligibility>(); } },
                {"windowsScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).WindowsScore = n.GetDoubleValue(); } },
                {"workFromAnywhereScore", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereDevice).WorkFromAnywhereScore = n.GetDoubleValue(); } },
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
