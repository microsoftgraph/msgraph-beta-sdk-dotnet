using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsBatteryHealthCapacityDetails : Entity, IParsable {
        /// <summary>Number of active devices within the tenant. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices {
            get { return BackingStore?.Get<int?>("activeDevices"); }
            set { BackingStore?.Set("activeDevices", value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is greater than 50% but lesser than 80%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityFair {
            get { return BackingStore?.Get<int?>("batteryCapacityFair"); }
            set { BackingStore?.Set("batteryCapacityFair", value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is greater than 80%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityGood {
            get { return BackingStore?.Get<int?>("batteryCapacityGood"); }
            set { BackingStore?.Set("batteryCapacityGood", value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is lesser than 50%. Valid values -2147483648 to 2147483647</summary>
        public int? BatteryCapacityPoor {
            get { return BackingStore?.Get<int?>("batteryCapacityPoor"); }
            set { BackingStore?.Set("batteryCapacityPoor", value); }
        }
        /// <summary>Recorded date time of this capacity details instance.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsBatteryHealthCapacityDetails and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsBatteryHealthCapacityDetails() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsBatteryHealthCapacityDetails";
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
