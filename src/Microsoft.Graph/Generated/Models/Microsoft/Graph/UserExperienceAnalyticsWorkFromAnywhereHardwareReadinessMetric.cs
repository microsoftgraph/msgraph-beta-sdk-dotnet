using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric : Entity, IParsable {
        /// <summary>The percentage of devices for which OS check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? OsCheckFailedPercentage { get; set; }
        /// <summary>The percentage of devices for which processor hardware 64-bit architecture check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? Processor64BitCheckFailedPercentage { get; set; }
        /// <summary>The percentage of devices for which processor hardware core count check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorCoreCountCheckFailedPercentage { get; set; }
        /// <summary>The percentage of devices for which processor hardware family check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorFamilyCheckFailedPercentage { get; set; }
        /// <summary>The percentage of devices for which processor hardware speed check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorSpeedCheckFailedPercentage { get; set; }
        /// <summary>The percentage of devices for which RAM hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? RamCheckFailedPercentage { get; set; }
        /// <summary>The percentage of devices for which secure boot hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? SecureBootCheckFailedPercentage { get; set; }
        /// <summary>The percentage of devices for which storage hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StorageCheckFailedPercentage { get; set; }
        /// <summary>The count of total devices in an organization. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDeviceCount { get; set; }
        /// <summary>The percentage of devices for which Trusted Platform Module (TPM) hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? TpmCheckFailedPercentage { get; set; }
        /// <summary>The count of devices in an organization eligible for windows upgrade. Valid values -2147483648 to 2147483647</summary>
        public int? UpgradeEligibleDeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"osCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).OsCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processor64BitCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).Processor64BitCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorCoreCountCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).ProcessorCoreCountCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorFamilyCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).ProcessorFamilyCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorSpeedCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).ProcessorSpeedCheckFailedPercentage = n.GetDoubleValue(); } },
                {"ramCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).RamCheckFailedPercentage = n.GetDoubleValue(); } },
                {"secureBootCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).SecureBootCheckFailedPercentage = n.GetDoubleValue(); } },
                {"storageCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).StorageCheckFailedPercentage = n.GetDoubleValue(); } },
                {"totalDeviceCount", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).TotalDeviceCount = n.GetIntValue(); } },
                {"tpmCheckFailedPercentage", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).TpmCheckFailedPercentage = n.GetDoubleValue(); } },
                {"upgradeEligibleDeviceCount", (o,n) => { (o as UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric).UpgradeEligibleDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("osCheckFailedPercentage", OsCheckFailedPercentage);
            writer.WriteDoubleValue("processor64BitCheckFailedPercentage", Processor64BitCheckFailedPercentage);
            writer.WriteDoubleValue("processorCoreCountCheckFailedPercentage", ProcessorCoreCountCheckFailedPercentage);
            writer.WriteDoubleValue("processorFamilyCheckFailedPercentage", ProcessorFamilyCheckFailedPercentage);
            writer.WriteDoubleValue("processorSpeedCheckFailedPercentage", ProcessorSpeedCheckFailedPercentage);
            writer.WriteDoubleValue("ramCheckFailedPercentage", RamCheckFailedPercentage);
            writer.WriteDoubleValue("secureBootCheckFailedPercentage", SecureBootCheckFailedPercentage);
            writer.WriteDoubleValue("storageCheckFailedPercentage", StorageCheckFailedPercentage);
            writer.WriteIntValue("totalDeviceCount", TotalDeviceCount);
            writer.WriteDoubleValue("tpmCheckFailedPercentage", TpmCheckFailedPercentage);
            writer.WriteIntValue("upgradeEligibleDeviceCount", UpgradeEligibleDeviceCount);
        }
    }
}
