using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsBatteryHealthOsPerformance : Entity, IParsable {
        /// <summary>Number of active devices for that os version. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices {
            get { return BackingStore?.Get<int?>("activeDevices"); }
            set { BackingStore?.Set("activeDevices", value); }
        }
        /// <summary>The mean of the battery age for all devices running a particular operating system version in a tenant. Unit in days. Valid values -2147483648 to 2147483647</summary>
        public int? AverageBatteryAgeInDays {
            get { return BackingStore?.Get<int?>("averageBatteryAgeInDays"); }
            set { BackingStore?.Set("averageBatteryAgeInDays", value); }
        }
        /// <summary>The mean of the estimated runtimes on full charge for all devices running a particular operating system version. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AverageEstimatedRuntimeInMinutes {
            get { return BackingStore?.Get<int?>("averageEstimatedRuntimeInMinutes"); }
            set { BackingStore?.Set("averageEstimatedRuntimeInMinutes", value); }
        }
        /// <summary>The mean of the maximum capacity for all devices running a particular operating system version. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values -2147483648 to 2147483647</summary>
        public int? AverageMaxCapacityPercentage {
            get { return BackingStore?.Get<int?>("averageMaxCapacityPercentage"); }
            set { BackingStore?.Set("averageMaxCapacityPercentage", value); }
        }
        /// <summary>Build number of the operating system.</summary>
        public string OsBuildNumber {
            get { return BackingStore?.Get<string>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
        /// <summary>Version of the operating system.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsBatteryHealthOsPerformance and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsBatteryHealthOsPerformance() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsBatteryHealthOsPerformance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsBatteryHealthOsPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthOsPerformance();
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
                {"osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
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
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteStringValue("osVersion", OsVersion);
        }
    }
}
