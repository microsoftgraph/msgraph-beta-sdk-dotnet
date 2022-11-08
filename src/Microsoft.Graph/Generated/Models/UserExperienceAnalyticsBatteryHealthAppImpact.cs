using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics battery health app impact entity contains battery usage related information at an app level for the tenant.</summary>
    public class UserExperienceAnalyticsBatteryHealthAppImpact : Entity, IParsable {
        /// <summary>Number of active devices for using that app over a 14-day period. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices {
            get { return BackingStore?.Get<int?>("activeDevices"); }
            set { BackingStore?.Set("activeDevices", value); }
        }
        /// <summary>User friendly display name for the app. Eg: Outlook</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
        /// <summary>App name. Eg: oltk.exe</summary>
        public string AppName {
            get { return BackingStore?.Get<string>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
        /// <summary>App publisher. Eg: Microsoft Corporation</summary>
        public string AppPublisher {
            get { return BackingStore?.Get<string>("appPublisher"); }
            set { BackingStore?.Set("appPublisher", value); }
        }
        /// <summary>The percent of total battery power used by this application when the device was not plugged into AC power, over 14 days computed across all devices in the tenant. Unit in percentage. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? BatteryUsagePercentage {
            get { return BackingStore?.Get<double?>("batteryUsagePercentage"); }
            set { BackingStore?.Set("batteryUsagePercentage", value); }
        }
        /// <summary>true if the user had active interaction with the app.</summary>
        public bool? IsForegroundApp {
            get { return BackingStore?.Get<bool?>("isForegroundApp"); }
            set { BackingStore?.Set("isForegroundApp", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsBatteryHealthAppImpact and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsBatteryHealthAppImpact() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsBatteryHealthAppImpact";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsBatteryHealthAppImpact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthAppImpact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDevices", n => { ActiveDevices = n.GetIntValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                {"batteryUsagePercentage", n => { BatteryUsagePercentage = n.GetDoubleValue(); } },
                {"isForegroundApp", n => { IsForegroundApp = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDevices", ActiveDevices);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteDoubleValue("batteryUsagePercentage", BatteryUsagePercentage);
            writer.WriteBoolValue("isForegroundApp", IsForegroundApp);
        }
    }
}
