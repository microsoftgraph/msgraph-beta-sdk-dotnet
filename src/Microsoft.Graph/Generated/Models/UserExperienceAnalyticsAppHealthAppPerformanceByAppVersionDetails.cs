using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics application performance entity contains app performance by app version details.
    /// </summary>
    public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails : Entity, IParsable {
        /// <summary>The number of crashes for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount {
            get { return BackingStore?.Get<int?>("appCrashCount"); }
            set { BackingStore?.Set("appCrashCount", value); }
        }
        /// <summary>The friendly name of the application.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
        /// <summary>The name of the application.</summary>
        public string AppName {
            get { return BackingStore?.Get<string>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
        /// <summary>The publisher of the application.</summary>
        public string AppPublisher {
            get { return BackingStore?.Get<string>("appPublisher"); }
            set { BackingStore?.Set("appPublisher", value); }
        }
        /// <summary>The version of the application.</summary>
        public string AppVersion {
            get { return BackingStore?.Get<string>("appVersion"); }
            set { BackingStore?.Set("appVersion", value); }
        }
        /// <summary>The total number of devices that have reported one or more application crashes for this application and version. Valid values -2147483648 to 2147483647</summary>
        public int? DeviceCountWithCrashes {
            get { return BackingStore?.Get<int?>("deviceCountWithCrashes"); }
            set { BackingStore?.Set("deviceCountWithCrashes", value); }
        }
        /// <summary>Is the version of application the latest version for that app that is in use.</summary>
        public bool? IsLatestUsedVersion {
            get { return BackingStore?.Get<bool?>("isLatestUsedVersion"); }
            set { BackingStore?.Set("isLatestUsedVersion", value); }
        }
        /// <summary>Is the version of application the most used version for that app.</summary>
        public bool? IsMostUsedVersion {
            get { return BackingStore?.Get<bool?>("isMostUsedVersion"); }
            set { BackingStore?.Set("isMostUsedVersion", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
