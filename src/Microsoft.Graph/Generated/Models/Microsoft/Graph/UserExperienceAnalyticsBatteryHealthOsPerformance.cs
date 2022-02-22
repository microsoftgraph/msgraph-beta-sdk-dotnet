using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsBatteryHealthOsPerformance : Entity, IParsable {
        /// <summary>Number of active devices for that os version. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices { get; set; }
        /// <summary>The mean of the battery age for all devices running a particular operating system version in a tenant. Unit in days. Valid values -2147483648 to 2147483647</summary>
        public int? AverageBatteryAgeInDays { get; set; }
        /// <summary>The mean of the estimated runtimes on full charge for all devices running a particular operating system version. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AverageEstimatedRuntimeInMinutes { get; set; }
        /// <summary>The mean of the maximum capacity for all devices running a particular operating system version. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values -2147483648 to 2147483647</summary>
        public int? AverageMaxCapacityPercentage { get; set; }
        /// <summary>Build number of the operating system.</summary>
        public string OsBuildNumber { get; set; }
        /// <summary>Version of the operating system.</summary>
        public string OsVersion { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeDevices", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthOsPerformance).ActiveDevices = n.GetIntValue(); } },
                {"averageBatteryAgeInDays", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthOsPerformance).AverageBatteryAgeInDays = n.GetIntValue(); } },
                {"averageEstimatedRuntimeInMinutes", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthOsPerformance).AverageEstimatedRuntimeInMinutes = n.GetIntValue(); } },
                {"averageMaxCapacityPercentage", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthOsPerformance).AverageMaxCapacityPercentage = n.GetIntValue(); } },
                {"osBuildNumber", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthOsPerformance).OsBuildNumber = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthOsPerformance).OsVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDevices", ActiveDevices);
            writer.WriteIntValue("averageBatteryAgeInDays", AverageBatteryAgeInDays);
            writer.WriteIntValue("averageEstimatedRuntimeInMinutes", AverageEstimatedRuntimeInMinutes);
            writer.WriteIntValue("averageMaxCapacityPercentage", AverageMaxCapacityPercentage);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteStringValue("osVersion", OsVersion);
        }
    }
}
