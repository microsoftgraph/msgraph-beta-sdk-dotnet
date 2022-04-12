using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsAppHealthDevicePerformance : Entity, IParsable {
        /// <summary>The number of app crashes for the device. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount { get; set; }
        /// <summary>The number of app hangs for the device. Valid values -2147483648 to 2147483647</summary>
        public int? AppHangCount { get; set; }
        /// <summary>The number of distinct app crashes for the device. Valid values -2147483648 to 2147483647</summary>
        public int? CrashedAppCount { get; set; }
        /// <summary>The app health score of the device. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? DeviceAppHealthScore { get; set; }
        /// <summary>The overall app health status of the device.</summary>
        public string DeviceAppHealthStatus { get; set; }
        /// <summary>The name of the device.</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>The id of the device.</summary>
        public string DeviceId { get; set; }
        /// <summary>The manufacturer name of the device.</summary>
        public string DeviceManufacturer { get; set; }
        /// <summary>The model name of the device.</summary>
        public string DeviceModel { get; set; }
        /// <summary>The health state of the user experience analytics device. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The mean time to failure for the device in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes { get; set; }
        /// <summary>The date and time when the statistics were last computed.</summary>
        public DateTimeOffset? ProcessedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthDevicePerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthDevicePerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appCrashCount", n => { AppCrashCount = n.GetIntValue(); } },
                {"appHangCount", n => { AppHangCount = n.GetIntValue(); } },
                {"crashedAppCount", n => { CrashedAppCount = n.GetIntValue(); } },
                {"deviceAppHealthScore", n => { DeviceAppHealthScore = n.GetDoubleValue(); } },
                {"deviceAppHealthStatus", n => { DeviceAppHealthStatus = n.GetStringValue(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                {"processedDateTime", n => { ProcessedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteIntValue("appHangCount", AppHangCount);
            writer.WriteIntValue("crashedAppCount", CrashedAppCount);
            writer.WriteDoubleValue("deviceAppHealthScore", DeviceAppHealthScore);
            writer.WriteStringValue("deviceAppHealthStatus", DeviceAppHealthStatus);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteDateTimeOffsetValue("processedDateTime", ProcessedDateTime);
        }
    }
}
