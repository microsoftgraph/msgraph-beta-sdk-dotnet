using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics application performance entity contains app performance details.</summary>
    public class UserExperienceAnalyticsAppHealthApplicationPerformance : Entity, IParsable {
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
        /// <summary>The number of hangs for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppHangCount {
            get { return BackingStore?.Get<int?>(nameof(AppHangCount)); }
            set { BackingStore?.Set(nameof(AppHangCount), value); }
        }
        /// <summary>The health score of the app. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? AppHealthScore {
            get { return BackingStore?.Get<double?>(nameof(AppHealthScore)); }
            set { BackingStore?.Set(nameof(AppHealthScore), value); }
        }
        /// <summary>The overall health status of the app.</summary>
        public string AppHealthStatus {
            get { return BackingStore?.Get<string>(nameof(AppHealthStatus)); }
            set { BackingStore?.Set(nameof(AppHealthStatus), value); }
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthApplicationPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthApplicationPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                {"appCrashCount", n => { AppCrashCount = n.GetIntValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appHangCount", n => { AppHangCount = n.GetIntValue(); } },
                {"appHealthScore", n => { AppHealthScore = n.GetDoubleValue(); } },
                {"appHealthStatus", n => { AppHealthStatus = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                {"appUsageDuration", n => { AppUsageDuration = n.GetIntValue(); } },
                {"meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
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
            writer.WriteIntValue("appHangCount", AppHangCount);
            writer.WriteDoubleValue("appHealthScore", AppHealthScore);
            writer.WriteStringValue("appHealthStatus", AppHealthStatus);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteIntValue("appUsageDuration", AppUsageDuration);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
        }
    }
}
