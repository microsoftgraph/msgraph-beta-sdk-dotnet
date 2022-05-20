using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics resource performance entity.</summary>
    public class UserExperienceAnalyticsResourcePerformance : Entity, IParsable {
        /// <summary>AverageSpikeTimeScore of a device or a model type. Valid values 0 to 100</summary>
        public int? AverageSpikeTimeScore {
            get { return BackingStore?.Get<int?>(nameof(AverageSpikeTimeScore)); }
            set { BackingStore?.Set(nameof(AverageSpikeTimeScore), value); }
        }
        /// <summary>CPU spike time in percentage. Valid values 0 to 100</summary>
        public double? CpuSpikeTimePercentage {
            get { return BackingStore?.Get<double?>(nameof(CpuSpikeTimePercentage)); }
            set { BackingStore?.Set(nameof(CpuSpikeTimePercentage), value); }
        }
        /// <summary>Threshold of cpuSpikeTimeScore. Valid values 0 to 100</summary>
        public double? CpuSpikeTimePercentageThreshold {
            get { return BackingStore?.Get<double?>(nameof(CpuSpikeTimePercentageThreshold)); }
            set { BackingStore?.Set(nameof(CpuSpikeTimePercentageThreshold), value); }
        }
        /// <summary>The user experience analytics device CPU spike time score. Valid values 0 to 100</summary>
        public int? CpuSpikeTimeScore {
            get { return BackingStore?.Get<int?>(nameof(CpuSpikeTimeScore)); }
            set { BackingStore?.Set(nameof(CpuSpikeTimeScore), value); }
        }
        /// <summary>User experience analytics summarized device count.</summary>
        public long? DeviceCount {
            get { return BackingStore?.Get<long?>(nameof(DeviceCount)); }
            set { BackingStore?.Set(nameof(DeviceCount), value); }
        }
        /// <summary>The id of the device.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>The name of the device.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>Resource performance score of a specific device. Valid values 0 to 100</summary>
        public int? DeviceResourcePerformanceScore {
            get { return BackingStore?.Get<int?>(nameof(DeviceResourcePerformanceScore)); }
            set { BackingStore?.Set(nameof(DeviceResourcePerformanceScore), value); }
        }
        /// <summary>The user experience analytics device manufacturer.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>The user experience analytics device model.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>RAM spike time in percentage. Valid values 0 to 100</summary>
        public double? RamSpikeTimePercentage {
            get { return BackingStore?.Get<double?>(nameof(RamSpikeTimePercentage)); }
            set { BackingStore?.Set(nameof(RamSpikeTimePercentage), value); }
        }
        /// <summary>Threshold of ramSpikeTimeScore. Valid values 0 to 100</summary>
        public double? RamSpikeTimePercentageThreshold {
            get { return BackingStore?.Get<double?>(nameof(RamSpikeTimePercentageThreshold)); }
            set { BackingStore?.Set(nameof(RamSpikeTimePercentageThreshold), value); }
        }
        /// <summary>The user experience analytics device RAM spike time score. Valid values 0 to 100</summary>
        public int? RamSpikeTimeScore {
            get { return BackingStore?.Get<int?>(nameof(RamSpikeTimeScore)); }
            set { BackingStore?.Set(nameof(RamSpikeTimeScore), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsResourcePerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsResourcePerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"averageSpikeTimeScore", n => { AverageSpikeTimeScore = n.GetIntValue(); } },
                {"cpuSpikeTimePercentage", n => { CpuSpikeTimePercentage = n.GetDoubleValue(); } },
                {"cpuSpikeTimePercentageThreshold", n => { CpuSpikeTimePercentageThreshold = n.GetDoubleValue(); } },
                {"cpuSpikeTimeScore", n => { CpuSpikeTimeScore = n.GetIntValue(); } },
                {"deviceCount", n => { DeviceCount = n.GetLongValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceResourcePerformanceScore", n => { DeviceResourcePerformanceScore = n.GetIntValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"ramSpikeTimePercentage", n => { RamSpikeTimePercentage = n.GetDoubleValue(); } },
                {"ramSpikeTimePercentageThreshold", n => { RamSpikeTimePercentageThreshold = n.GetDoubleValue(); } },
                {"ramSpikeTimeScore", n => { RamSpikeTimeScore = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("averageSpikeTimeScore", AverageSpikeTimeScore);
            writer.WriteDoubleValue("cpuSpikeTimePercentage", CpuSpikeTimePercentage);
            writer.WriteDoubleValue("cpuSpikeTimePercentageThreshold", CpuSpikeTimePercentageThreshold);
            writer.WriteIntValue("cpuSpikeTimeScore", CpuSpikeTimeScore);
            writer.WriteLongValue("deviceCount", DeviceCount);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteIntValue("deviceResourcePerformanceScore", DeviceResourcePerformanceScore);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteDoubleValue("ramSpikeTimePercentage", RamSpikeTimePercentage);
            writer.WriteDoubleValue("ramSpikeTimePercentageThreshold", RamSpikeTimePercentageThreshold);
            writer.WriteIntValue("ramSpikeTimeScore", RamSpikeTimeScore);
        }
    }
}
