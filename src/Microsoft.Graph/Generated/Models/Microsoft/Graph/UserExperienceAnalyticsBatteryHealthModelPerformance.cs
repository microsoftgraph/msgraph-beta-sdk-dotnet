using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsBatteryHealthModelPerformance : Entity, IParsable {
        /// <summary>Number of active devices for that model. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices { get; set; }
        /// <summary>The mean of the battery age for all devices of a given model in a tenant. Unit in days. Valid values -2147483648 to 2147483647</summary>
        public int? AverageBatteryAgeInDays { get; set; }
        /// <summary>The mean of the estimated runtimes on full charge for all devices of a given model. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AverageEstimatedRuntimeInMinutes { get; set; }
        /// <summary>The mean of the maximum capacity for all devices of a given model. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values -2147483648 to 2147483647</summary>
        public int? AverageMaxCapacityPercentage { get; set; }
        /// <summary>Name of the device manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The model name of the device.</summary>
        public string Model { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsBatteryHealthModelPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthModelPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeDevices", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthModelPerformance).ActiveDevices = n.GetIntValue(); } },
                {"averageBatteryAgeInDays", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthModelPerformance).AverageBatteryAgeInDays = n.GetIntValue(); } },
                {"averageEstimatedRuntimeInMinutes", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthModelPerformance).AverageEstimatedRuntimeInMinutes = n.GetIntValue(); } },
                {"averageMaxCapacityPercentage", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthModelPerformance).AverageMaxCapacityPercentage = n.GetIntValue(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthModelPerformance).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthModelPerformance).Model = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDevices", ActiveDevices);
            writer.WriteIntValue("averageBatteryAgeInDays", AverageBatteryAgeInDays);
            writer.WriteIntValue("averageEstimatedRuntimeInMinutes", AverageEstimatedRuntimeInMinutes);
            writer.WriteIntValue("averageMaxCapacityPercentage", AverageMaxCapacityPercentage);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
        }
    }
}
