using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsBatteryHealthModelPerformance : Entity, IParsable {
        /// <summary>Number of active devices for that model. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices {
            get { return BackingStore?.Get<int?>("activeDevices"); }
            set { BackingStore?.Set("activeDevices", value); }
        }
        /// <summary>The mean of the battery age for all devices of a given model in a tenant. Unit in days. Valid values -2147483648 to 2147483647</summary>
        public int? AverageBatteryAgeInDays {
            get { return BackingStore?.Get<int?>("averageBatteryAgeInDays"); }
            set { BackingStore?.Set("averageBatteryAgeInDays", value); }
        }
        /// <summary>The mean of the estimated runtimes on full charge for all devices of a given model. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AverageEstimatedRuntimeInMinutes {
            get { return BackingStore?.Get<int?>("averageEstimatedRuntimeInMinutes"); }
            set { BackingStore?.Set("averageEstimatedRuntimeInMinutes", value); }
        }
        /// <summary>The mean of the maximum capacity for all devices of a given model. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values -2147483648 to 2147483647</summary>
        public int? AverageMaxCapacityPercentage {
            get { return BackingStore?.Get<int?>("averageMaxCapacityPercentage"); }
            set { BackingStore?.Set("averageMaxCapacityPercentage", value); }
        }
        /// <summary>Name of the device manufacturer.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
        /// <summary>The model name of the device.</summary>
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
        /// <summary>A weighted average of a model’s maximum capacity score and runtime estimate score. Values range from 0-100. Valid values -2147483648 to 2147483647</summary>
        public int? ModelBatteryHealthScore {
            get { return BackingStore?.Get<int?>("modelBatteryHealthScore"); }
            set { BackingStore?.Set("modelBatteryHealthScore", value); }
        }
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsBatteryHealthModelPerformance and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsBatteryHealthModelPerformance() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsBatteryHealthModelPerformance";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDevices", n => { ActiveDevices = n.GetIntValue(); } },
                {"averageBatteryAgeInDays", n => { AverageBatteryAgeInDays = n.GetIntValue(); } },
                {"averageEstimatedRuntimeInMinutes", n => { AverageEstimatedRuntimeInMinutes = n.GetIntValue(); } },
                {"averageMaxCapacityPercentage", n => { AverageMaxCapacityPercentage = n.GetIntValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"modelBatteryHealthScore", n => { ModelBatteryHealthScore = n.GetIntValue(); } },
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
            writer.WriteIntValue("modelBatteryHealthScore", ModelBatteryHealthScore);
        }
    }
}
