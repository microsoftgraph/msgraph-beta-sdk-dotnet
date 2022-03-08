using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class UserExperienceAnalyticsBatteryHealthDevicePerformance : Entity, IParsable {
        /// <summary>Estimated battery age. Unit in days. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryAgeInDays { get; set; }
        /// <summary>A weighted average of a device’s maximum capacity score and runtime estimate score. Values range from 0-100. Valid values -2147483648 to 2147483647</summary>
        public int? DeviceBatteryHealthScore { get; set; }
        /// <summary>The unique identifier of the device, Intune DeviceID.</summary>
        public string DeviceId { get; set; }
        /// <summary>Device friendly name.</summary>
        public string DeviceName { get; set; }
        /// <summary>The estimated runtime of the device when the battery is fully charged. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? EstimatedRuntimeInMinutes { get; set; }
        /// <summary>The overall battery health status of the device. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The manufacturer name of the device.</summary>
        public string Manufacturer { get; set; }
        /// <summary>Ratio of current capacity and design capacity of the battery with the lowest capacity. Unit in percentage and values range from 0-100. Valid values -2147483648 to 2147483647</summary>
        public int? MaxCapacityPercentage { get; set; }
        /// <summary>The model name of the device.</summary>
        public string Model { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsBatteryHealthDevicePerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthDevicePerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"batteryAgeInDays", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).BatteryAgeInDays = n.GetIntValue(); } },
                {"deviceBatteryHealthScore", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).DeviceBatteryHealthScore = n.GetIntValue(); } },
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).DeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).DeviceName = n.GetStringValue(); } },
                {"estimatedRuntimeInMinutes", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).EstimatedRuntimeInMinutes = n.GetIntValue(); } },
                {"healthStatus", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).Manufacturer = n.GetStringValue(); } },
                {"maxCapacityPercentage", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).MaxCapacityPercentage = n.GetIntValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDevicePerformance).Model = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("batteryAgeInDays", BatteryAgeInDays);
            writer.WriteIntValue("deviceBatteryHealthScore", DeviceBatteryHealthScore);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteIntValue("estimatedRuntimeInMinutes", EstimatedRuntimeInMinutes);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteIntValue("maxCapacityPercentage", MaxCapacityPercentage);
            writer.WriteStringValue("model", Model);
        }
    }
}
