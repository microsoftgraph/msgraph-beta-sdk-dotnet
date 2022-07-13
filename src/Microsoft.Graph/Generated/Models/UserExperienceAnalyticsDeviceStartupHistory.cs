using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics device startup history entity contains device boot performance history details.</summary>
    public class UserExperienceAnalyticsDeviceStartupHistory : Entity, IParsable {
        /// <summary>The user experience analytics device core boot time in milliseconds.</summary>
        public int? CoreBootTimeInMs {
            get { return BackingStore?.Get<int?>("coreBootTimeInMs"); }
            set { BackingStore?.Set("coreBootTimeInMs", value); }
        }
        /// <summary>The user experience analytics device core login time in milliseconds.</summary>
        public int? CoreLoginTimeInMs {
            get { return BackingStore?.Get<int?>("coreLoginTimeInMs"); }
            set { BackingStore?.Set("coreLoginTimeInMs", value); }
        }
        /// <summary>The user experience analytics device id.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The user experience analytics device feature update time in milliseconds.</summary>
        public int? FeatureUpdateBootTimeInMs {
            get { return BackingStore?.Get<int?>("featureUpdateBootTimeInMs"); }
            set { BackingStore?.Set("featureUpdateBootTimeInMs", value); }
        }
        /// <summary>The User experience analytics Device group policy boot time in milliseconds.</summary>
        public int? GroupPolicyBootTimeInMs {
            get { return BackingStore?.Get<int?>("groupPolicyBootTimeInMs"); }
            set { BackingStore?.Set("groupPolicyBootTimeInMs", value); }
        }
        /// <summary>The User experience analytics Device group policy login time in milliseconds.</summary>
        public int? GroupPolicyLoginTimeInMs {
            get { return BackingStore?.Get<int?>("groupPolicyLoginTimeInMs"); }
            set { BackingStore?.Set("groupPolicyLoginTimeInMs", value); }
        }
        /// <summary>The user experience analytics device boot record is a feature update.</summary>
        public bool? IsFeatureUpdate {
            get { return BackingStore?.Get<bool?>("isFeatureUpdate"); }
            set { BackingStore?.Set("isFeatureUpdate", value); }
        }
        /// <summary>The user experience analytics device first login.</summary>
        public bool? IsFirstLogin {
            get { return BackingStore?.Get<bool?>("isFirstLogin"); }
            set { BackingStore?.Set("isFirstLogin", value); }
        }
        /// <summary>The user experience analytics device boot record&apos;s operating system version.</summary>
        public string OperatingSystemVersion {
            get { return BackingStore?.Get<string>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
        /// <summary>The user experience analytics responsive desktop time in milliseconds.</summary>
        public int? ResponsiveDesktopTimeInMs {
            get { return BackingStore?.Get<int?>("responsiveDesktopTimeInMs"); }
            set { BackingStore?.Set("responsiveDesktopTimeInMs", value); }
        }
        /// <summary>Operating System restart category</summary>
        public UserExperienceAnalyticsOperatingSystemRestartCategory? RestartCategory {
            get { return BackingStore?.Get<UserExperienceAnalyticsOperatingSystemRestartCategory?>("restartCategory"); }
            set { BackingStore?.Set("restartCategory", value); }
        }
        /// <summary>OS restart fault bucket. The fault bucket is used to find additional information about a system crash.</summary>
        public string RestartFaultBucket {
            get { return BackingStore?.Get<string>("restartFaultBucket"); }
            set { BackingStore?.Set("restartFaultBucket", value); }
        }
        /// <summary>OS restart stop code. This shows the bug check code which can be used to look up the blue screen reason.</summary>
        public string RestartStopCode {
            get { return BackingStore?.Get<string>("restartStopCode"); }
            set { BackingStore?.Set("restartStopCode", value); }
        }
        /// <summary>The user experience analytics device boot start time.</summary>
        public DateTimeOffset? StartTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startTime"); }
            set { BackingStore?.Set("startTime", value); }
        }
        /// <summary>The user experience analytics device total boot time in milliseconds.</summary>
        public int? TotalBootTimeInMs {
            get { return BackingStore?.Get<int?>("totalBootTimeInMs"); }
            set { BackingStore?.Set("totalBootTimeInMs", value); }
        }
        /// <summary>The user experience analytics device total login time in milliseconds.</summary>
        public int? TotalLoginTimeInMs {
            get { return BackingStore?.Get<int?>("totalLoginTimeInMs"); }
            set { BackingStore?.Set("totalLoginTimeInMs", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsDeviceStartupHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceStartupHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"coreBootTimeInMs", n => { CoreBootTimeInMs = n.GetIntValue(); } },
                {"coreLoginTimeInMs", n => { CoreLoginTimeInMs = n.GetIntValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"featureUpdateBootTimeInMs", n => { FeatureUpdateBootTimeInMs = n.GetIntValue(); } },
                {"groupPolicyBootTimeInMs", n => { GroupPolicyBootTimeInMs = n.GetIntValue(); } },
                {"groupPolicyLoginTimeInMs", n => { GroupPolicyLoginTimeInMs = n.GetIntValue(); } },
                {"isFeatureUpdate", n => { IsFeatureUpdate = n.GetBoolValue(); } },
                {"isFirstLogin", n => { IsFirstLogin = n.GetBoolValue(); } },
                {"operatingSystemVersion", n => { OperatingSystemVersion = n.GetStringValue(); } },
                {"responsiveDesktopTimeInMs", n => { ResponsiveDesktopTimeInMs = n.GetIntValue(); } },
                {"restartCategory", n => { RestartCategory = n.GetEnumValue<UserExperienceAnalyticsOperatingSystemRestartCategory>(); } },
                {"restartFaultBucket", n => { RestartFaultBucket = n.GetStringValue(); } },
                {"restartStopCode", n => { RestartStopCode = n.GetStringValue(); } },
                {"startTime", n => { StartTime = n.GetDateTimeOffsetValue(); } },
                {"totalBootTimeInMs", n => { TotalBootTimeInMs = n.GetIntValue(); } },
                {"totalLoginTimeInMs", n => { TotalLoginTimeInMs = n.GetIntValue(); } },
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
