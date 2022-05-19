using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics hardware readiness entity contains account level information about hardware blockers for windows upgrade.</summary>
    public class UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric : Entity, IParsable {
        /// <summary>The percentage of devices for which OS check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? OsCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(OsCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(OsCheckFailedPercentage), value); }
        }
        /// <summary>The percentage of devices for which processor hardware 64-bit architecture check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? Processor64BitCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(Processor64BitCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(Processor64BitCheckFailedPercentage), value); }
        }
        /// <summary>The percentage of devices for which processor hardware core count check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorCoreCountCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(ProcessorCoreCountCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(ProcessorCoreCountCheckFailedPercentage), value); }
        }
        /// <summary>The percentage of devices for which processor hardware family check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorFamilyCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(ProcessorFamilyCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(ProcessorFamilyCheckFailedPercentage), value); }
        }
        /// <summary>The percentage of devices for which processor hardware speed check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ProcessorSpeedCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(ProcessorSpeedCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(ProcessorSpeedCheckFailedPercentage), value); }
        }
        /// <summary>The percentage of devices for which RAM hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? RamCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(RamCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(RamCheckFailedPercentage), value); }
        }
        /// <summary>The percentage of devices for which secure boot hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? SecureBootCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(SecureBootCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(SecureBootCheckFailedPercentage), value); }
        }
        /// <summary>The percentage of devices for which storage hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StorageCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(StorageCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(StorageCheckFailedPercentage), value); }
        }
        /// <summary>The count of total devices in an organization. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(TotalDeviceCount)); }
            set { BackingStore?.Set(nameof(TotalDeviceCount), value); }
        }
        /// <summary>The percentage of devices for which Trusted Platform Module (TPM) hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? TpmCheckFailedPercentage {
            get { return BackingStore?.Get<double?>(nameof(TpmCheckFailedPercentage)); }
            set { BackingStore?.Set(nameof(TpmCheckFailedPercentage), value); }
        }
        /// <summary>The count of devices in an organization eligible for windows upgrade. Valid values -2147483648 to 2147483647</summary>
        public int? UpgradeEligibleDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(UpgradeEligibleDeviceCount)); }
            set { BackingStore?.Set(nameof(UpgradeEligibleDeviceCount), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"osCheckFailedPercentage", n => { OsCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processor64BitCheckFailedPercentage", n => { Processor64BitCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorCoreCountCheckFailedPercentage", n => { ProcessorCoreCountCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorFamilyCheckFailedPercentage", n => { ProcessorFamilyCheckFailedPercentage = n.GetDoubleValue(); } },
                {"processorSpeedCheckFailedPercentage", n => { ProcessorSpeedCheckFailedPercentage = n.GetDoubleValue(); } },
                {"ramCheckFailedPercentage", n => { RamCheckFailedPercentage = n.GetDoubleValue(); } },
                {"secureBootCheckFailedPercentage", n => { SecureBootCheckFailedPercentage = n.GetDoubleValue(); } },
                {"storageCheckFailedPercentage", n => { StorageCheckFailedPercentage = n.GetDoubleValue(); } },
                {"totalDeviceCount", n => { TotalDeviceCount = n.GetIntValue(); } },
                {"tpmCheckFailedPercentage", n => { TpmCheckFailedPercentage = n.GetDoubleValue(); } },
                {"upgradeEligibleDeviceCount", n => { UpgradeEligibleDeviceCount = n.GetIntValue(); } },
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
