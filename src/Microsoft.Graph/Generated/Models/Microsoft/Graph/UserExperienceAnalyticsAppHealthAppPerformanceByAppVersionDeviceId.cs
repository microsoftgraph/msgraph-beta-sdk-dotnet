using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId : Entity, IParsable {
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
        /// <summary>The name of the device.</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>The id of the device.</summary>
        public string DeviceId { get; set; }
        /// <summary>The date and time when the statistics were last computed.</summary>
        public DateTimeOffset? ProcessedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appCrashCount", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId).AppCrashCount = n.GetIntValue(); } },
                {"appDisplayName", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId).AppDisplayName = n.GetStringValue(); } },
                {"appName", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId).AppName = n.GetStringValue(); } },
                {"appPublisher", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId).AppPublisher = n.GetStringValue(); } },
                {"appVersion", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId).AppVersion = n.GetStringValue(); } },
                {"deviceDisplayName", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId).DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId).DeviceId = n.GetStringValue(); } },
                {"processedDateTime", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId).ProcessedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("processedDateTime", ProcessedDateTime);
        }
    }
}
