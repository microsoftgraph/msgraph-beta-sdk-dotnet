using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"batteryAgeInDays", n => { BatteryAgeInDays = n.GetIntValue(); } },
                {"deviceBatteryHealthScore", n => { DeviceBatteryHealthScore = n.GetIntValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"estimatedRuntimeInMinutes", n => { EstimatedRuntimeInMinutes = n.GetIntValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"maxCapacityPercentage", n => { MaxCapacityPercentage = n.GetIntValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
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
