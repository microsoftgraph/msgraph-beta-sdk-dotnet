using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsResourcePerformance : Entity, IParsable {
        /// <summary>AverageSpikeTimeScore of a device or a model type. Valid values 0 to 100</summary>
        public int? AverageSpikeTimeScore { get; set; }
        /// <summary>CPU spike time in percentage. Valid values 0 to 100</summary>
        public double? CpuSpikeTimePercentage { get; set; }
        /// <summary>Threshold of cpuSpikeTimeScore. Valid values 0 to 100</summary>
        public double? CpuSpikeTimePercentageThreshold { get; set; }
        /// <summary>The user experience analytics device CPU spike time score. Valid values 0 to 100</summary>
        public int? CpuSpikeTimeScore { get; set; }
        /// <summary>User experience analytics summarized device count.</summary>
        public long? DeviceCount { get; set; }
        /// <summary>The id of the device.</summary>
        public string DeviceId { get; set; }
        /// <summary>The name of the device.</summary>
        public string DeviceName { get; set; }
        /// <summary>Resource performance score of a specific device. Valid values 0 to 100</summary>
        public int? DeviceResourcePerformanceScore { get; set; }
        /// <summary>The user experience analytics device manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The user experience analytics device model.</summary>
        public string Model { get; set; }
        /// <summary>RAM spike time in percentage. Valid values 0 to 100</summary>
        public double? RamSpikeTimePercentage { get; set; }
        /// <summary>Threshold of ramSpikeTimeScore. Valid values 0 to 100</summary>
        public double? RamSpikeTimePercentageThreshold { get; set; }
        /// <summary>The user experience analytics device RAM spike time score. Valid values 0 to 100</summary>
        public int? RamSpikeTimeScore { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"averageSpikeTimeScore", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).AverageSpikeTimeScore = n.GetIntValue(); } },
                {"cpuSpikeTimePercentage", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).CpuSpikeTimePercentage = n.GetDoubleValue(); } },
                {"cpuSpikeTimePercentageThreshold", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).CpuSpikeTimePercentageThreshold = n.GetDoubleValue(); } },
                {"cpuSpikeTimeScore", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).CpuSpikeTimeScore = n.GetIntValue(); } },
                {"deviceCount", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).DeviceCount = n.GetLongValue(); } },
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).DeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).DeviceName = n.GetStringValue(); } },
                {"deviceResourcePerformanceScore", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).DeviceResourcePerformanceScore = n.GetIntValue(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).Model = n.GetStringValue(); } },
                {"ramSpikeTimePercentage", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).RamSpikeTimePercentage = n.GetDoubleValue(); } },
                {"ramSpikeTimePercentageThreshold", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).RamSpikeTimePercentageThreshold = n.GetDoubleValue(); } },
                {"ramSpikeTimeScore", (o,n) => { (o as UserExperienceAnalyticsResourcePerformance).RamSpikeTimeScore = n.GetIntValue(); } },
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
