using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails : Entity, IParsable {
        /// <summary>The number of crashes for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount { get; set; }
        /// <summary>The friendly name of the application.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>The name of the application.</summary>
        public string AppName { get; set; }
        /// <summary>The publisher of the application.</summary>
        public string AppPublisher { get; set; }
        /// <summary>The version of the application.</summary>
        public string AppVersion { get; set; }
        /// <summary>The total number of devices that have reported one or more application crashes for this application and version. Valid values -2147483648 to 2147483647</summary>
        public int? DeviceCountWithCrashes { get; set; }
        /// <summary>Is the version of application the latest version for that app that is in use.</summary>
        public bool? IsLatestUsedVersion { get; set; }
        /// <summary>Is the version of application the most used version for that app.</summary>
        public bool? IsMostUsedVersion { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails();
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
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
                {"deviceCountWithCrashes", n => { DeviceCountWithCrashes = n.GetIntValue(); } },
                {"isLatestUsedVersion", n => { IsLatestUsedVersion = n.GetBoolValue(); } },
                {"isMostUsedVersion", n => { IsMostUsedVersion = n.GetBoolValue(); } },
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
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteIntValue("deviceCountWithCrashes", DeviceCountWithCrashes);
            writer.WriteBoolValue("isLatestUsedVersion", IsLatestUsedVersion);
            writer.WriteBoolValue("isMostUsedVersion", IsMostUsedVersion);
        }
    }
}
