using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsDevicePerformance : Entity, IParsable {
        /// <summary>Average (mean) number of Blue Screens per device in the last 14 days. Valid values 0 to 9999999</summary>
        public double? AverageBlueScreens { get; set; }
        /// <summary>Average (mean) number of Restarts per device in the last 14 days. Valid values 0 to 9999999</summary>
        public double? AverageRestarts { get; set; }
        /// <summary>Number of Blue Screens in the last 14 days. Valid values 0 to 9999999</summary>
        public int? BlueScreenCount { get; set; }
        /// <summary>The user experience analytics device boot score.</summary>
        public int? BootScore { get; set; }
        /// <summary>The user experience analytics device core boot time in milliseconds.</summary>
        public int? CoreBootTimeInMs { get; set; }
        /// <summary>The user experience analytics device core login time in milliseconds.</summary>
        public int? CoreLoginTimeInMs { get; set; }
        /// <summary>User experience analytics summarized device count.</summary>
        public long? DeviceCount { get; set; }
        /// <summary>The user experience analytics device name.</summary>
        public string DeviceName { get; set; }
        /// <summary>The user experience analytics device disk type. Possible values are: unknown, hdd, ssd, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DiskType? DiskType { get; set; }
        /// <summary>The user experience analytics device group policy boot time in milliseconds.</summary>
        public int? GroupPolicyBootTimeInMs { get; set; }
        /// <summary>The user experience analytics device group policy login time in milliseconds.</summary>
        public int? GroupPolicyLoginTimeInMs { get; set; }
        /// <summary>The health state of the user experience analytics device. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The user experience analytics device login score.</summary>
        public int? LoginScore { get; set; }
        /// <summary>The user experience analytics device manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The user experience analytics device model.</summary>
        public string Model { get; set; }
        /// <summary>The user experience analytics model level startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ModelStartupPerformanceScore { get; set; }
        /// <summary>The user experience analytics device Operating System version.</summary>
        public string OperatingSystemVersion { get; set; }
        /// <summary>The user experience analytics responsive desktop time in milliseconds.</summary>
        public int? ResponsiveDesktopTimeInMs { get; set; }
        /// <summary>Number of Restarts in the last 14 days. Valid values 0 to 9999999</summary>
        public int? RestartCount { get; set; }
        /// <summary>The user experience analytics device startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StartupPerformanceScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsDevicePerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDevicePerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"averageBlueScreens", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).AverageBlueScreens = n.GetDoubleValue(); } },
                {"averageRestarts", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).AverageRestarts = n.GetDoubleValue(); } },
                {"blueScreenCount", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).BlueScreenCount = n.GetIntValue(); } },
                {"bootScore", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).BootScore = n.GetIntValue(); } },
                {"coreBootTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).CoreBootTimeInMs = n.GetIntValue(); } },
                {"coreLoginTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).CoreLoginTimeInMs = n.GetIntValue(); } },
                {"deviceCount", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).DeviceCount = n.GetLongValue(); } },
                {"deviceName", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).DeviceName = n.GetStringValue(); } },
                {"diskType", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).DiskType = n.GetEnumValue<DiskType>(); } },
                {"groupPolicyBootTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).GroupPolicyBootTimeInMs = n.GetIntValue(); } },
                {"groupPolicyLoginTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).GroupPolicyLoginTimeInMs = n.GetIntValue(); } },
                {"healthStatus", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"loginScore", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).LoginScore = n.GetIntValue(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).Model = n.GetStringValue(); } },
                {"modelStartupPerformanceScore", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).ModelStartupPerformanceScore = n.GetDoubleValue(); } },
                {"operatingSystemVersion", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).OperatingSystemVersion = n.GetStringValue(); } },
                {"responsiveDesktopTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).ResponsiveDesktopTimeInMs = n.GetIntValue(); } },
                {"restartCount", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).RestartCount = n.GetIntValue(); } },
                {"startupPerformanceScore", (o,n) => { (o as UserExperienceAnalyticsDevicePerformance).StartupPerformanceScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("averageBlueScreens", AverageBlueScreens);
            writer.WriteDoubleValue("averageRestarts", AverageRestarts);
            writer.WriteIntValue("blueScreenCount", BlueScreenCount);
            writer.WriteIntValue("bootScore", BootScore);
            writer.WriteIntValue("coreBootTimeInMs", CoreBootTimeInMs);
            writer.WriteIntValue("coreLoginTimeInMs", CoreLoginTimeInMs);
            writer.WriteLongValue("deviceCount", DeviceCount);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DiskType>("diskType", DiskType);
            writer.WriteIntValue("groupPolicyBootTimeInMs", GroupPolicyBootTimeInMs);
            writer.WriteIntValue("groupPolicyLoginTimeInMs", GroupPolicyLoginTimeInMs);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteIntValue("loginScore", LoginScore);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteDoubleValue("modelStartupPerformanceScore", ModelStartupPerformanceScore);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteIntValue("responsiveDesktopTimeInMs", ResponsiveDesktopTimeInMs);
            writer.WriteIntValue("restartCount", RestartCount);
            writer.WriteDoubleValue("startupPerformanceScore", StartupPerformanceScore);
        }
    }
}
