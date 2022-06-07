using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics battery health model performance entity contains battery related information for all unique device models in their organization.</summary>
    public class UserExperienceAnalyticsBatteryHealthModelPerformance : Entity, IParsable {
        /// <summary>Number of active devices for that model. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices {
            get { return BackingStore?.Get<int?>(nameof(ActiveDevices)); }
            set { BackingStore?.Set(nameof(ActiveDevices), value); }
        }
        /// <summary>The mean of the battery age for all devices of a given model in a tenant. Unit in days. Valid values -2147483648 to 2147483647</summary>
        public int? AverageBatteryAgeInDays {
            get { return BackingStore?.Get<int?>(nameof(AverageBatteryAgeInDays)); }
            set { BackingStore?.Set(nameof(AverageBatteryAgeInDays), value); }
        }
        /// <summary>The mean of the estimated runtimes on full charge for all devices of a given model. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AverageEstimatedRuntimeInMinutes {
            get { return BackingStore?.Get<int?>(nameof(AverageEstimatedRuntimeInMinutes)); }
            set { BackingStore?.Set(nameof(AverageEstimatedRuntimeInMinutes), value); }
        }
        /// <summary>The mean of the maximum capacity for all devices of a given model. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values -2147483648 to 2147483647</summary>
        public int? AverageMaxCapacityPercentage {
            get { return BackingStore?.Get<int?>(nameof(AverageMaxCapacityPercentage)); }
            set { BackingStore?.Set(nameof(AverageMaxCapacityPercentage), value); }
        }
        /// <summary>Name of the device manufacturer.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>The model name of the device.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>A weighted average of a model’s maximum capacity score and runtime estimate score. Values range from 0-100. Valid values -2147483648 to 2147483647</summary>
        public int? ModelBatteryHealthScore {
            get { return BackingStore?.Get<int?>(nameof(ModelBatteryHealthScore)); }
            set { BackingStore?.Set(nameof(ModelBatteryHealthScore), value); }
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
