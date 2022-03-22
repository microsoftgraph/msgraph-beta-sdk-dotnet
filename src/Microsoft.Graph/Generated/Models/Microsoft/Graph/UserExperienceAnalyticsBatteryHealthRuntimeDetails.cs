using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsBatteryHealthRuntimeDetails : Entity, IParsable {
        /// <summary>Number of active devices within the tenant. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices { get; set; }
        /// <summary>Number of devices whose active runtime is greater than 3 hours but lesser than 5 hours. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryRuntimeFair { get; set; }
        /// <summary>Number of devices  whose active runtime is greater than 5 hours. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryRuntimeGood { get; set; }
        /// <summary>Number of devices whose active runtime is lesser than 3 hours. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryRuntimePoor { get; set; }
        /// <summary>Recorded date time of this runtime details instance.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsBatteryHealthRuntimeDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthRuntimeDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeDevices", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthRuntimeDetails).ActiveDevices = n.GetIntValue(); } },
                {"batteryRuntimeFair", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthRuntimeDetails).BatteryRuntimeFair = n.GetIntValue(); } },
                {"batteryRuntimeGood", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthRuntimeDetails).BatteryRuntimeGood = n.GetIntValue(); } },
                {"batteryRuntimePoor", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthRuntimeDetails).BatteryRuntimePoor = n.GetIntValue(); } },
                {"lastRefreshedDateTime", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthRuntimeDetails).LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteIntValue("batteryRuntimeFair", BatteryRuntimeFair);
            writer.WriteIntValue("batteryRuntimeGood", BatteryRuntimeGood);
            writer.WriteIntValue("batteryRuntimePoor", BatteryRuntimePoor);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
        }
    }
}
