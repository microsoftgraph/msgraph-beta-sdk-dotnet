using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsBatteryHealthDeviceAppImpact : Entity, IParsable {
        /// <summary>User friendly display name for the app. Eg: Outlook</summary>
        public string AppDisplayName { get; set; }
        /// <summary>App name. Eg: oltk.exe</summary>
        public string AppName { get; set; }
        /// <summary>App publisher. Eg: Microsoft Corporation</summary>
        public string AppPublisher { get; set; }
        /// <summary>The percent of total battery power used by this application when the device was not plugged into AC power, over 14 days. Unit in percentage. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? BatteryUsagePercentage { get; set; }
        /// <summary>The unique identifier of the device, Intune DeviceID or SCCM device id.</summary>
        public string DeviceId { get; set; }
        /// <summary>true if the user had active interaction with the app.</summary>
        public bool? IsForegroundApp { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsBatteryHealthDeviceAppImpact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthDeviceAppImpact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDisplayName", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceAppImpact).AppDisplayName = n.GetStringValue(); } },
                {"appName", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceAppImpact).AppName = n.GetStringValue(); } },
                {"appPublisher", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceAppImpact).AppPublisher = n.GetStringValue(); } },
                {"batteryUsagePercentage", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceAppImpact).BatteryUsagePercentage = n.GetDoubleValue(); } },
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceAppImpact).DeviceId = n.GetStringValue(); } },
                {"isForegroundApp", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthDeviceAppImpact).IsForegroundApp = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteDoubleValue("batteryUsagePercentage", BatteryUsagePercentage);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteBoolValue("isForegroundApp", IsForegroundApp);
        }
    }
}
