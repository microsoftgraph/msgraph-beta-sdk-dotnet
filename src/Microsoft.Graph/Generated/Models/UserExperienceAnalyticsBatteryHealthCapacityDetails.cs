using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsBatteryHealthCapacityDetails : Entity, IParsable {
        /// <summary>Number of active devices within the tenant. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices { get; set; }
        /// <summary>Number of devices whose battery maximum capacity is greater than 50% but lesser than 80%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityFair { get; set; }
        /// <summary>Number of devices whose battery maximum capacity is greater than 80%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityGood { get; set; }
        /// <summary>Number of devices whose battery maximum capacity is lesser than 50%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityPoor { get; set; }
        /// <summary>Recorded date time of this capacity details instance.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsBatteryHealthCapacityDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthCapacityDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeDevices", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthCapacityDetails).ActiveDevices = n.GetIntValue(); } },
                {"batteryCapacityFair", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthCapacityDetails).BatteryCapacityFair = n.GetIntValue(); } },
                {"batteryCapacityGood", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthCapacityDetails).BatteryCapacityGood = n.GetIntValue(); } },
                {"batteryCapacityPoor", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthCapacityDetails).BatteryCapacityPoor = n.GetIntValue(); } },
                {"lastRefreshedDateTime", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthCapacityDetails).LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteIntValue("batteryCapacityFair", BatteryCapacityFair);
            writer.WriteIntValue("batteryCapacityGood", BatteryCapacityGood);
            writer.WriteIntValue("batteryCapacityPoor", BatteryCapacityPoor);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
        }
    }
}
