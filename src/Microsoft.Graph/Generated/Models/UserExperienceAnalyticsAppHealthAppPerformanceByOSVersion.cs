using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics application performance entity contains app performance details by OS version.</summary>
    public class UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion : Entity, IParsable {
        /// <summary>The number of devices where the app has been active. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ActiveDeviceCount)); }
            set { BackingStore?.Set(nameof(ActiveDeviceCount), value); }
        }
        /// <summary>The number of crashes for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount {
            get { return BackingStore?.Get<int?>(nameof(AppCrashCount)); }
            set { BackingStore?.Set(nameof(AppCrashCount), value); }
        }
        /// <summary>The friendly name of the application.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>(nameof(AppDisplayName)); }
            set { BackingStore?.Set(nameof(AppDisplayName), value); }
        }
        /// <summary>The name of the application.</summary>
        public string AppName {
            get { return BackingStore?.Get<string>(nameof(AppName)); }
            set { BackingStore?.Set(nameof(AppName), value); }
        }
        /// <summary>The publisher of the application.</summary>
        public string AppPublisher {
            get { return BackingStore?.Get<string>(nameof(AppPublisher)); }
            set { BackingStore?.Set(nameof(AppPublisher), value); }
        }
        /// <summary>The total usage time of the application in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AppUsageDuration {
            get { return BackingStore?.Get<int?>(nameof(AppUsageDuration)); }
            set { BackingStore?.Set(nameof(AppUsageDuration), value); }
        }
        /// <summary>The mean time to failure for the app in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes {
            get { return BackingStore?.Get<int?>(nameof(MeanTimeToFailureInMinutes)); }
            set { BackingStore?.Set(nameof(MeanTimeToFailureInMinutes), value); }
        }
        /// <summary>The os build number of the application.</summary>
        public string OsBuildNumber {
            get { return BackingStore?.Get<string>(nameof(OsBuildNumber)); }
            set { BackingStore?.Set(nameof(OsBuildNumber), value); }
        }
        /// <summary>The os version of the application.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                {"appCrashCount", n => { AppCrashCount = n.GetIntValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                {"appUsageDuration", n => { AppUsageDuration = n.GetIntValue(); } },
                {"meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                {"osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
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
            writer.WriteIntValue("appCrashCount", AppCrashCount);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteIntValue("appUsageDuration", AppUsageDuration);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteStringValue("osVersion", OsVersion);
        }
    }
}
