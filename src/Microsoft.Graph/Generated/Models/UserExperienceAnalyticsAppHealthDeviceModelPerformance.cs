using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics device model performance entity contains device model performance details.</summary>
    public class UserExperienceAnalyticsAppHealthDeviceModelPerformance : Entity, IParsable {
        /// <summary>The number of active devices for the model. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ActiveDeviceCount)); }
            set { BackingStore?.Set(nameof(ActiveDeviceCount), value); }
        }
        /// <summary>The manufacturer name of the device.</summary>
        public string DeviceManufacturer {
            get { return BackingStore?.Get<string>(nameof(DeviceManufacturer)); }
            set { BackingStore?.Set(nameof(DeviceManufacturer), value); }
        }
        /// <summary>The model name of the device.</summary>
        public string DeviceModel {
            get { return BackingStore?.Get<string>(nameof(DeviceModel)); }
            set { BackingStore?.Set(nameof(DeviceModel), value); }
        }
        /// <summary>The health state of the user experience analytics model. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus {
            get { return BackingStore?.Get<UserExperienceAnalyticsHealthState?>(nameof(HealthStatus)); }
            set { BackingStore?.Set(nameof(HealthStatus), value); }
        }
        /// <summary>The mean time to failure for the model device in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes {
            get { return BackingStore?.Get<int?>(nameof(MeanTimeToFailureInMinutes)); }
            set { BackingStore?.Set(nameof(MeanTimeToFailureInMinutes), value); }
        }
        /// <summary>The app health score of the device model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ModelAppHealthScore {
            get { return BackingStore?.Get<double?>(nameof(ModelAppHealthScore)); }
            set { BackingStore?.Set(nameof(ModelAppHealthScore), value); }
        }
        /// <summary>The overall app health status of the device model.</summary>
        public string ModelAppHealthStatus {
            get { return BackingStore?.Get<string>(nameof(ModelAppHealthStatus)); }
            set { BackingStore?.Set(nameof(ModelAppHealthStatus), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsAppHealthDeviceModelPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthDeviceModelPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                {"deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                {"modelAppHealthScore", n => { ModelAppHealthScore = n.GetDoubleValue(); } },
                {"modelAppHealthStatus", n => { ModelAppHealthStatus = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteDoubleValue("modelAppHealthScore", ModelAppHealthScore);
            writer.WriteStringValue("modelAppHealthStatus", ModelAppHealthStatus);
        }
    }
}
