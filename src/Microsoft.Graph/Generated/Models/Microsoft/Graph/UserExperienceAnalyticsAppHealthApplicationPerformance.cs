using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsAppHealthApplicationPerformance : Entity, IParsable {
        /// <summary>The number of devices where the app has been active. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount { get; set; }
        /// <summary>The number of crashes for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount { get; set; }
        /// <summary>The friendly name of the application.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>The number of hangs for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppHangCount { get; set; }
        /// <summary>The health score of the app. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? AppHealthScore { get; set; }
        /// <summary>The overall health status of the app.</summary>
        public string AppHealthStatus { get; set; }
        /// <summary>The name of the application.</summary>
        public string AppName { get; set; }
        /// <summary>The publisher of the application.</summary>
        public string AppPublisher { get; set; }
        /// <summary>The total usage time of the application in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AppUsageDuration { get; set; }
        /// <summary>The mean time to failure for the app in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeDeviceCount", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).ActiveDeviceCount = n.GetIntValue(); } },
                {"appCrashCount", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).AppCrashCount = n.GetIntValue(); } },
                {"appDisplayName", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).AppDisplayName = n.GetStringValue(); } },
                {"appHangCount", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).AppHangCount = n.GetIntValue(); } },
                {"appHealthScore", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).AppHealthScore = n.GetDoubleValue(); } },
                {"appHealthStatus", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).AppHealthStatus = n.GetStringValue(); } },
                {"appName", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).AppName = n.GetStringValue(); } },
                {"appPublisher", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).AppPublisher = n.GetStringValue(); } },
                {"appUsageDuration", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).AppUsageDuration = n.GetIntValue(); } },
                {"meanTimeToFailureInMinutes", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformance).MeanTimeToFailureInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDeviceCount", ActiveDeviceCount);
            writer.WriteIntValue("appCrashCount", AppCrashCount);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteIntValue("appHangCount", AppHangCount);
            writer.WriteDoubleValue("appHealthScore", AppHealthScore);
            writer.WriteStringValue("appHealthStatus", AppHealthStatus);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteIntValue("appUsageDuration", AppUsageDuration);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
        }
    }
}
