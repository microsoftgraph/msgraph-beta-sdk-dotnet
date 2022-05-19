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
            get { return BackingStore?.Get<int?>(nameof(AppCrashCount)); }
            set { BackingStore?.Set(nameof(AppCrashCount), value); }
        }
        /// <summary>The number of app hangs for the device. Valid values -2147483648 to 2147483647</summary>
        public int? AppHangCount {
            get { return BackingStore?.Get<int?>(nameof(AppHangCount)); }
            set { BackingStore?.Set(nameof(AppHangCount), value); }
        }
        /// <summary>The number of distinct app crashes for the device. Valid values -2147483648 to 2147483647</summary>
        public int? CrashedAppCount {
            get { return BackingStore?.Get<int?>(nameof(CrashedAppCount)); }
            set { BackingStore?.Set(nameof(CrashedAppCount), value); }
        }
        /// <summary>The app health score of the device. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? DeviceAppHealthScore {
            get { return BackingStore?.Get<double?>(nameof(DeviceAppHealthScore)); }
            set { BackingStore?.Set(nameof(DeviceAppHealthScore), value); }
        }
        /// <summary>The overall app health status of the device.</summary>
        public string DeviceAppHealthStatus {
            get { return BackingStore?.Get<string>(nameof(DeviceAppHealthStatus)); }
            set { BackingStore?.Set(nameof(DeviceAppHealthStatus), value); }
        }
        /// <summary>The name of the device.</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>(nameof(DeviceDisplayName)); }
            set { BackingStore?.Set(nameof(DeviceDisplayName), value); }
        }
        /// <summary>The id of the device.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>The manufacturer name of the device.</summary>
        public string DeviceManufacturer {
            get { return BackingStore?.Get<string>(nameof(DeviceManufacturer)); }
            set { BackingStore?.Set(nameof(DeviceManufacturer), value); }
        }
        /// <summary>The model name of the device.</summary>
        public string DeviceModel {
            get { return BackingStore?.Get<string>(nameof(DeviceModel)); }
            set { BackingStore?.Set(nameof(DeviceModel), value); }
        }
        /// <summary>The health state of the user experience analytics device. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus {
            get { return BackingStore?.Get<UserExperienceAnalyticsHealthState?>(nameof(HealthStatus)); }
            set { BackingStore?.Set(nameof(HealthStatus), value); }
        }
        /// <summary>The mean time to failure for the device in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes {
            get { return BackingStore?.Get<int?>(nameof(MeanTimeToFailureInMinutes)); }
            set { BackingStore?.Set(nameof(MeanTimeToFailureInMinutes), value); }
        }
        /// <summary>The date and time when the statistics were last computed.</summary>
        public DateTimeOffset? ProcessedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ProcessedDateTime)); }
            set { BackingStore?.Set(nameof(ProcessedDateTime), value); }
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
