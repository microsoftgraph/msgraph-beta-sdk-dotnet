using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics Device for work from anywhere report
    /// </summary>
    public class UserExperienceAnalyticsWorkFromAnywhereDevice : Entity, IParsable {
        /// <summary>The user experience analytics work from anywhere intune device&apos;s autopilotProfileAssigned.</summary>
        public bool? AutoPilotProfileAssigned {
            get { return BackingStore?.Get<bool?>("autoPilotProfileAssigned"); }
            set { BackingStore?.Set("autoPilotProfileAssigned", value); }
        }
        /// <summary>The user experience work from anywhere intune device&apos;s autopilotRegistered.</summary>
        public bool? AutoPilotRegistered {
            get { return BackingStore?.Get<bool?>("autoPilotRegistered"); }
            set { BackingStore?.Set("autoPilotRegistered", value); }
        }
        /// <summary>The user experience work from anywhere azure Ad device Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureAdDeviceId {
            get { return BackingStore?.Get<string?>("azureAdDeviceId"); }
            set { BackingStore?.Set("azureAdDeviceId", value); }
        }
#nullable restore
#else
        public string AzureAdDeviceId {
            get { return BackingStore?.Get<string>("azureAdDeviceId"); }
            set { BackingStore?.Set("azureAdDeviceId", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device&apos;s azure Ad joinType.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureAdJoinType {
            get { return BackingStore?.Get<string?>("azureAdJoinType"); }
            set { BackingStore?.Set("azureAdJoinType", value); }
        }
#nullable restore
#else
        public string AzureAdJoinType {
            get { return BackingStore?.Get<string>("azureAdJoinType"); }
            set { BackingStore?.Set("azureAdJoinType", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device&apos;s azureAdRegistered.</summary>
        public bool? AzureAdRegistered {
            get { return BackingStore?.Get<bool?>("azureAdRegistered"); }
            set { BackingStore?.Set("azureAdRegistered", value); }
        }
        /// <summary>The user experience work from anywhere per device cloud identity score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudIdentityScore {
            get { return BackingStore?.Get<double?>("cloudIdentityScore"); }
            set { BackingStore?.Set("cloudIdentityScore", value); }
        }
        /// <summary>The user experience work from anywhere per device cloud management score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudManagementScore {
            get { return BackingStore?.Get<double?>("cloudManagementScore"); }
            set { BackingStore?.Set("cloudManagementScore", value); }
        }
        /// <summary>The user experience work from anywhere per device cloud provisioning score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudProvisioningScore {
            get { return BackingStore?.Get<double?>("cloudProvisioningScore"); }
            set { BackingStore?.Set("cloudProvisioningScore", value); }
        }
        /// <summary>The user experience work from anywhere device&apos;s compliancePolicySetToIntune.</summary>
        public bool? CompliancePolicySetToIntune {
            get { return BackingStore?.Get<bool?>("compliancePolicySetToIntune"); }
            set { BackingStore?.Set("compliancePolicySetToIntune", value); }
        }
        /// <summary>The user experience work from anywhere device Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The work from anywhere device&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus {
            get { return BackingStore?.Get<UserExperienceAnalyticsHealthState?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>The user experience work from anywhere device&apos;s Cloud Management Gateway for Configuration Manager is enabled.</summary>
        public bool? IsCloudManagedGatewayEnabled {
            get { return BackingStore?.Get<bool?>("isCloudManagedGatewayEnabled"); }
            set { BackingStore?.Set("isCloudManagedGatewayEnabled", value); }
        }
        /// <summary>The user experience work from anywhere management agent of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedBy {
            get { return BackingStore?.Get<string?>("managedBy"); }
            set { BackingStore?.Set("managedBy", value); }
        }
#nullable restore
#else
        public string ManagedBy {
            get { return BackingStore?.Get<string>("managedBy"); }
            set { BackingStore?.Set("managedBy", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device&apos;s manufacturer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device&apos;s model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device, Is OS check failed for device to upgrade to the latest version of windows.</summary>
        public bool? OsCheckFailed {
            get { return BackingStore?.Get<bool?>("osCheckFailed"); }
            set { BackingStore?.Set("osCheckFailed", value); }
        }
        /// <summary>The user experience work from anywhere device&apos;s OS Description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsDescription {
            get { return BackingStore?.Get<string?>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
#nullable restore
#else
        public string OsDescription {
            get { return BackingStore?.Get<string>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device&apos;s OS Version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device&apos;s otherWorkloadsSetToIntune.</summary>
        public bool? OtherWorkloadsSetToIntune {
            get { return BackingStore?.Get<bool?>("otherWorkloadsSetToIntune"); }
            set { BackingStore?.Set("otherWorkloadsSetToIntune", value); }
        }
        /// <summary>The user experience work from anywhere device&apos;s ownership.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ownership {
            get { return BackingStore?.Get<string?>("ownership"); }
            set { BackingStore?.Set("ownership", value); }
        }
#nullable restore
#else
        public string Ownership {
            get { return BackingStore?.Get<string>("ownership"); }
            set { BackingStore?.Set("ownership", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device, Is processor hardware 64-bit architecture check failed for device to upgrade to the latest version of windows.</summary>
        public bool? Processor64BitCheckFailed {
            get { return BackingStore?.Get<bool?>("processor64BitCheckFailed"); }
            set { BackingStore?.Set("processor64BitCheckFailed", value); }
        }
        /// <summary>The user experience work from anywhere device, Is processor hardware core count check failed for device to upgrade to the latest version of windows.</summary>
        public bool? ProcessorCoreCountCheckFailed {
            get { return BackingStore?.Get<bool?>("processorCoreCountCheckFailed"); }
            set { BackingStore?.Set("processorCoreCountCheckFailed", value); }
        }
        /// <summary>The user experience work from anywhere device, Is processor hardware family check failed for device to upgrade to the latest version of windows.</summary>
        public bool? ProcessorFamilyCheckFailed {
            get { return BackingStore?.Get<bool?>("processorFamilyCheckFailed"); }
            set { BackingStore?.Set("processorFamilyCheckFailed", value); }
        }
        /// <summary>The user experience work from anywhere device, Is processor hardware speed check failed for device to upgrade to the latest version of windows.</summary>
        public bool? ProcessorSpeedCheckFailed {
            get { return BackingStore?.Get<bool?>("processorSpeedCheckFailed"); }
            set { BackingStore?.Set("processorSpeedCheckFailed", value); }
        }
        /// <summary>Is the user experience analytics work from anywhere device RAM hardware check failed for device to upgrade to the latest version of windows</summary>
        public bool? RamCheckFailed {
            get { return BackingStore?.Get<bool?>("ramCheckFailed"); }
            set { BackingStore?.Set("ramCheckFailed", value); }
        }
        /// <summary>The user experience work from anywhere device, Is secure boot hardware check failed for device to upgrade to the latest version of windows.</summary>
        public bool? SecureBootCheckFailed {
            get { return BackingStore?.Get<bool?>("secureBootCheckFailed"); }
            set { BackingStore?.Set("secureBootCheckFailed", value); }
        }
        /// <summary>The user experience work from anywhere device&apos;s serial number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>The user experience work from anywhere device, Is storage hardware check failed for device to upgrade to the latest version of windows.</summary>
        public bool? StorageCheckFailed {
            get { return BackingStore?.Get<bool?>("storageCheckFailed"); }
            set { BackingStore?.Set("storageCheckFailed", value); }
        }
        /// <summary>The user experience work from anywhere device&apos;s tenantAttached.</summary>
        public bool? TenantAttached {
            get { return BackingStore?.Get<bool?>("tenantAttached"); }
            set { BackingStore?.Set("tenantAttached", value); }
        }
        /// <summary>The user experience work from anywhere device, Is Trusted Platform Module (TPM) hardware check failed for device to the latest version of upgrade to windows.</summary>
        public bool? TpmCheckFailed {
            get { return BackingStore?.Get<bool?>("tpmCheckFailed"); }
            set { BackingStore?.Set("tpmCheckFailed", value); }
        }
        /// <summary>Work From Anywhere windows device upgrade eligibility status</summary>
        public OperatingSystemUpgradeEligibility? UpgradeEligibility {
            get { return BackingStore?.Get<OperatingSystemUpgradeEligibility?>("upgradeEligibility"); }
            set { BackingStore?.Set("upgradeEligibility", value); }
        }
        /// <summary>The user experience work from anywhere per device windows score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WindowsScore {
            get { return BackingStore?.Get<double?>("windowsScore"); }
            set { BackingStore?.Set("windowsScore", value); }
        }
        /// <summary>The user experience work from anywhere per device overall score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore {
            get { return BackingStore?.Get<double?>("workFromAnywhereScore"); }
            set { BackingStore?.Set("workFromAnywhereScore", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
