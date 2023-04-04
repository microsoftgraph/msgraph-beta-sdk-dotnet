using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics battery health device performance entity contains device level battery information.
    /// </summary>
    public class UserExperienceAnalyticsBatteryHealthDevicePerformance : Entity, IParsable {
        /// <summary>Estimated battery age. Unit in days. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryAgeInDays {
            get { return BackingStore?.Get<int?>("batteryAgeInDays"); }
            set { BackingStore?.Set("batteryAgeInDays", value); }
        }
        /// <summary>A weighted average of a device’s maximum capacity score and runtime estimate score. Values range from 0-100. Valid values -2147483648 to 2147483647</summary>
        public int? DeviceBatteryHealthScore {
            get { return BackingStore?.Get<int?>("deviceBatteryHealthScore"); }
            set { BackingStore?.Set("deviceBatteryHealthScore", value); }
        }
        /// <summary>The unique identifier of the device, Intune DeviceID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>Device friendly name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The estimated runtime of the device when the battery is fully charged. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? EstimatedRuntimeInMinutes {
            get { return BackingStore?.Get<int?>("estimatedRuntimeInMinutes"); }
            set { BackingStore?.Set("estimatedRuntimeInMinutes", value); }
        }
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus {
            get { return BackingStore?.Get<UserExperienceAnalyticsHealthState?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>The manufacturer name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>Ratio of current capacity and design capacity of the battery with the lowest capacity. Unit in percentage and values range from 0-100. Valid values -2147483648 to 2147483647</summary>
        public int? MaxCapacityPercentage {
            get { return BackingStore?.Get<int?>("maxCapacityPercentage"); }
            set { BackingStore?.Set("maxCapacityPercentage", value); }
        }
        /// <summary>The model name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
