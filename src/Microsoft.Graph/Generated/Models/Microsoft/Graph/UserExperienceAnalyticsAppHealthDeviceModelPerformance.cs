using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsAppHealthDeviceModelPerformance : Entity, IParsable {
        /// <summary>The number of active devices for the model. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount { get; set; }
        /// <summary>The manufacturer name of the device.</summary>
        public string DeviceManufacturer { get; set; }
        /// <summary>The model name of the device.</summary>
        public string DeviceModel { get; set; }
        /// <summary>The health state of the user experience analytics model. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The mean time to failure for the model device in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes { get; set; }
        /// <summary>The app health score of the device model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ModelAppHealthScore { get; set; }
        /// <summary>The overall app health status of the device model.</summary>
        public string ModelAppHealthStatus { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeDeviceCount", (o,n) => { (o as UserExperienceAnalyticsAppHealthDeviceModelPerformance).ActiveDeviceCount = n.GetIntValue(); } },
                {"deviceManufacturer", (o,n) => { (o as UserExperienceAnalyticsAppHealthDeviceModelPerformance).DeviceManufacturer = n.GetStringValue(); } },
                {"deviceModel", (o,n) => { (o as UserExperienceAnalyticsAppHealthDeviceModelPerformance).DeviceModel = n.GetStringValue(); } },
                {"healthStatus", (o,n) => { (o as UserExperienceAnalyticsAppHealthDeviceModelPerformance).HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"meanTimeToFailureInMinutes", (o,n) => { (o as UserExperienceAnalyticsAppHealthDeviceModelPerformance).MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                {"modelAppHealthScore", (o,n) => { (o as UserExperienceAnalyticsAppHealthDeviceModelPerformance).ModelAppHealthScore = n.GetDoubleValue(); } },
                {"modelAppHealthStatus", (o,n) => { (o as UserExperienceAnalyticsAppHealthDeviceModelPerformance).ModelAppHealthStatus = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteDoubleValue("modelAppHealthScore", ModelAppHealthScore);
            writer.WriteStringValue("modelAppHealthStatus", ModelAppHealthStatus);
        }
    }
}
