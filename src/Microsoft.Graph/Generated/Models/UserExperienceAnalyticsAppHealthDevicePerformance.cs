using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics device performance entity contains device performance details.</summary>
    public class UserExperienceAnalyticsAppHealthDevicePerformance : Entity, IParsable {
        /// <summary>The number of app crashes for the device. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount {
            get { return BackingStore?.Get<int?>("appCrashCount"); }
            set { BackingStore?.Set("appCrashCount", value); }
        }
        /// <summary>The number of app hangs for the device. Valid values -2147483648 to 2147483647</summary>
        public int? AppHangCount {
            get { return BackingStore?.Get<int?>("appHangCount"); }
            set { BackingStore?.Set("appHangCount", value); }
        }
        /// <summary>The number of distinct app crashes for the device. Valid values -2147483648 to 2147483647</summary>
        public int? CrashedAppCount {
            get { return BackingStore?.Get<int?>("crashedAppCount"); }
            set { BackingStore?.Set("crashedAppCount", value); }
        }
        /// <summary>The app health score of the device. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? DeviceAppHealthScore {
            get { return BackingStore?.Get<double?>("deviceAppHealthScore"); }
            set { BackingStore?.Set("deviceAppHealthScore", value); }
        }
        /// <summary>The overall app health status of the device.</summary>
        public string DeviceAppHealthStatus {
            get { return BackingStore?.Get<string>("deviceAppHealthStatus"); }
            set { BackingStore?.Set("deviceAppHealthStatus", value); }
        }
        /// <summary>The name of the device.</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
        /// <summary>The id of the device.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The manufacturer name of the device.</summary>
        public string DeviceManufacturer {
            get { return BackingStore?.Get<string>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
        /// <summary>The model name of the device.</summary>
        public string DeviceModel {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus {
            get { return BackingStore?.Get<UserExperienceAnalyticsHealthState?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>The mean time to failure for the device in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes {
            get { return BackingStore?.Get<int?>("meanTimeToFailureInMinutes"); }
            set { BackingStore?.Set("meanTimeToFailureInMinutes", value); }
        }
        /// <summary>The date and time when the statistics were last computed.</summary>
        public DateTimeOffset? ProcessedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("processedDateTime"); }
            set { BackingStore?.Set("processedDateTime", value); }
        }
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
