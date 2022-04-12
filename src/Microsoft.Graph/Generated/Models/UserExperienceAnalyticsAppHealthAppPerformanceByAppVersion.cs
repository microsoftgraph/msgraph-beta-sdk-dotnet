using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion : Entity, IParsable {
        /// <summary>The number of crashes for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount { get; set; }
        /// <summary>The friendly name of the application.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>The name of the application.</summary>
        public string AppName { get; set; }
        /// <summary>The publisher of the application.</summary>
        public string AppPublisher { get; set; }
        /// <summary>The total usage time of the application in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AppUsageDuration { get; set; }
        /// <summary>The version of the application.</summary>
        public string AppVersion { get; set; }
        /// <summary>The mean time to failure for the app in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appCrashCount", n => { AppCrashCount = n.GetIntValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                {"appUsageDuration", n => { AppUsageDuration = n.GetIntValue(); } },
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
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
            writer.WriteIntValue("appCrashCount", AppCrashCount);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteIntValue("appUsageDuration", AppUsageDuration);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
        }
    }
}
