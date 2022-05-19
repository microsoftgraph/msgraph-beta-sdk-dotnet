using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics battery health capacity entity contains count of devices broken down into 3 categories - devices with capacity &gt; 80%, devices with capacity 50-80% and devices with capacity &lt; 50 %.This API provides the count of devices in these 3 categories..</summary>
    public class UserExperienceAnalyticsBatteryHealthCapacityDetails : Entity, IParsable {
        /// <summary>Number of active devices within the tenant. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices {
            get { return BackingStore?.Get<int?>(nameof(ActiveDevices)); }
            set { BackingStore?.Set(nameof(ActiveDevices), value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is greater than 50% but lesser than 80%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityFair {
            get { return BackingStore?.Get<int?>(nameof(BatteryCapacityFair)); }
            set { BackingStore?.Set(nameof(BatteryCapacityFair), value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is greater than 80%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityGood {
            get { return BackingStore?.Get<int?>(nameof(BatteryCapacityGood)); }
            set { BackingStore?.Set(nameof(BatteryCapacityGood), value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is lesser than 50%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityPoor {
            get { return BackingStore?.Get<int?>(nameof(BatteryCapacityPoor)); }
            set { BackingStore?.Set(nameof(BatteryCapacityPoor), value); }
        }
        /// <summary>Recorded date time of this capacity details instance.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastRefreshedDateTime)); }
            set { BackingStore?.Set(nameof(LastRefreshedDateTime), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDevices", n => { ActiveDevices = n.GetIntValue(); } },
                {"batteryCapacityFair", n => { BatteryCapacityFair = n.GetIntValue(); } },
                {"batteryCapacityGood", n => { BatteryCapacityGood = n.GetIntValue(); } },
                {"batteryCapacityPoor", n => { BatteryCapacityPoor = n.GetIntValue(); } },
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
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
