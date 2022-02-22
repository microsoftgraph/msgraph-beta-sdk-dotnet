using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails : Entity, IParsable {
        /// <summary>The number of crashes for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount { get; set; }
        /// <summary>The friendly name of the application.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>The name of the application.</summary>
        public string AppName { get; set; }
        /// <summary>The publisher of the application.</summary>
        public string AppPublisher { get; set; }
        /// <summary>The version of the application.</summary>
        public string AppVersion { get; set; }
        /// <summary>The total number of devices that have reported one or more application crashes for this application and version. Valid values -2147483648 to 2147483647</summary>
        public int? DeviceCountWithCrashes { get; set; }
        /// <summary>Is the version of application the latest version for that app that is in use.</summary>
        public bool? IsLatestUsedVersion { get; set; }
        /// <summary>Is the version of application the most used version for that app.</summary>
        public bool? IsMostUsedVersion { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appCrashCount", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails).AppCrashCount = n.GetIntValue(); } },
                {"appDisplayName", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails).AppDisplayName = n.GetStringValue(); } },
                {"appName", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails).AppName = n.GetStringValue(); } },
                {"appPublisher", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails).AppPublisher = n.GetStringValue(); } },
                {"appVersion", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails).AppVersion = n.GetStringValue(); } },
                {"deviceCountWithCrashes", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails).DeviceCountWithCrashes = n.GetIntValue(); } },
                {"isLatestUsedVersion", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails).IsLatestUsedVersion = n.GetBoolValue(); } },
                {"isMostUsedVersion", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails).IsMostUsedVersion = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("appCrashCount", AppCrashCount);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteIntValue("deviceCountWithCrashes", DeviceCountWithCrashes);
            writer.WriteBoolValue("isLatestUsedVersion", IsLatestUsedVersion);
            writer.WriteBoolValue("isMostUsedVersion", IsMostUsedVersion);
        }
    }
}
