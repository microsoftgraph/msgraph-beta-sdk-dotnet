using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsDeviceStartupHistory : Entity, IParsable {
        /// <summary>The user experience analytics device core boot time in milliseconds.</summary>
        public int? CoreBootTimeInMs { get; set; }
        /// <summary>The user experience analytics device core login time in milliseconds.</summary>
        public int? CoreLoginTimeInMs { get; set; }
        /// <summary>The user experience analytics device id.</summary>
        public string DeviceId { get; set; }
        /// <summary>The user experience analytics device feature update time in milliseconds.</summary>
        public int? FeatureUpdateBootTimeInMs { get; set; }
        /// <summary>The User experience analytics Device group policy boot time in milliseconds.</summary>
        public int? GroupPolicyBootTimeInMs { get; set; }
        /// <summary>The User experience analytics Device group policy login time in milliseconds.</summary>
        public int? GroupPolicyLoginTimeInMs { get; set; }
        /// <summary>The user experience analytics device boot record is a feature update.</summary>
        public bool? IsFeatureUpdate { get; set; }
        /// <summary>The user experience analytics device first login.</summary>
        public bool? IsFirstLogin { get; set; }
        /// <summary>The user experience analytics device boot record's operating system version.</summary>
        public string OperatingSystemVersion { get; set; }
        /// <summary>The user experience analytics responsive desktop time in milliseconds.</summary>
        public int? ResponsiveDesktopTimeInMs { get; set; }
        /// <summary>OS restart category. Possible values are: unknown, restartWithUpdate, restartWithoutUpdate, blueScreen, shutdownWithUpdate, shutdownWithoutUpdate, longPowerButtonPress, bootError, update.</summary>
        public UserExperienceAnalyticsOperatingSystemRestartCategory? RestartCategory { get; set; }
        /// <summary>OS restart fault bucket. The fault bucket is used to find additional information about a system crash.</summary>
        public string RestartFaultBucket { get; set; }
        /// <summary>OS restart stop code. This shows the bug check code which can be used to look up the blue screen reason.</summary>
        public string RestartStopCode { get; set; }
        /// <summary>The user experience analytics device boot start time.</summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary>The user experience analytics device total boot time in milliseconds.</summary>
        public int? TotalBootTimeInMs { get; set; }
        /// <summary>The user experience analytics device total login time in milliseconds.</summary>
        public int? TotalLoginTimeInMs { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"coreBootTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).CoreBootTimeInMs = n.GetIntValue(); } },
                {"coreLoginTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).CoreLoginTimeInMs = n.GetIntValue(); } },
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).DeviceId = n.GetStringValue(); } },
                {"featureUpdateBootTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).FeatureUpdateBootTimeInMs = n.GetIntValue(); } },
                {"groupPolicyBootTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).GroupPolicyBootTimeInMs = n.GetIntValue(); } },
                {"groupPolicyLoginTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).GroupPolicyLoginTimeInMs = n.GetIntValue(); } },
                {"isFeatureUpdate", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).IsFeatureUpdate = n.GetBoolValue(); } },
                {"isFirstLogin", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).IsFirstLogin = n.GetBoolValue(); } },
                {"operatingSystemVersion", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).OperatingSystemVersion = n.GetStringValue(); } },
                {"responsiveDesktopTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).ResponsiveDesktopTimeInMs = n.GetIntValue(); } },
                {"restartCategory", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).RestartCategory = n.GetEnumValue<UserExperienceAnalyticsOperatingSystemRestartCategory>(); } },
                {"restartFaultBucket", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).RestartFaultBucket = n.GetStringValue(); } },
                {"restartStopCode", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).RestartStopCode = n.GetStringValue(); } },
                {"startTime", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).StartTime = n.GetDateTimeOffsetValue(); } },
                {"totalBootTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).TotalBootTimeInMs = n.GetIntValue(); } },
                {"totalLoginTimeInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupHistory).TotalLoginTimeInMs = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("coreBootTimeInMs", CoreBootTimeInMs);
            writer.WriteIntValue("coreLoginTimeInMs", CoreLoginTimeInMs);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteIntValue("featureUpdateBootTimeInMs", FeatureUpdateBootTimeInMs);
            writer.WriteIntValue("groupPolicyBootTimeInMs", GroupPolicyBootTimeInMs);
            writer.WriteIntValue("groupPolicyLoginTimeInMs", GroupPolicyLoginTimeInMs);
            writer.WriteBoolValue("isFeatureUpdate", IsFeatureUpdate);
            writer.WriteBoolValue("isFirstLogin", IsFirstLogin);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteIntValue("responsiveDesktopTimeInMs", ResponsiveDesktopTimeInMs);
            writer.WriteEnumValue<UserExperienceAnalyticsOperatingSystemRestartCategory>("restartCategory", RestartCategory);
            writer.WriteStringValue("restartFaultBucket", RestartFaultBucket);
            writer.WriteStringValue("restartStopCode", RestartStopCode);
            writer.WriteDateTimeOffsetValue("startTime", StartTime);
            writer.WriteIntValue("totalBootTimeInMs", TotalBootTimeInMs);
            writer.WriteIntValue("totalLoginTimeInMs", TotalLoginTimeInMs);
        }
    }
}
