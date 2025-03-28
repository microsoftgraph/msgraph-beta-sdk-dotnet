// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The user experience analytics battery health capacity entity contains count of devices broken down into 3 categories - devices with capacity &gt; 80%, devices with capacity 50-80% and devices with capacity &lt; 50 %.This API provides the count of devices in these 3 categories..
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserExperienceAnalyticsBatteryHealthCapacityDetails : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Number of active devices within the tenant. Valid values 0 to 2147483647</summary>
        public int? ActiveDevices
        {
            get { return BackingStore?.Get<int?>("activeDevices"); }
            set { BackingStore?.Set("activeDevices", value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is greater than 50% but lesser than 80%. Valid values 0 to 2147483647</summary>
        public int? BatteryCapacityFair
        {
            get { return BackingStore?.Get<int?>("batteryCapacityFair"); }
            set { BackingStore?.Set("batteryCapacityFair", value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is greater than 80%. Valid values 0 to 2147483647</summary>
        public int? BatteryCapacityGood
        {
            get { return BackingStore?.Get<int?>("batteryCapacityGood"); }
            set { BackingStore?.Set("batteryCapacityGood", value); }
        }
        /// <summary>Number of devices whose battery maximum capacity is lesser than 50%. Valid values 0 to 2147483647</summary>
        public int? BatteryCapacityPoor
        {
            get { return BackingStore?.Get<int?>("batteryCapacityPoor"); }
            set { BackingStore?.Set("batteryCapacityPoor", value); }
        }
        /// <summary>Recorded date time of this capacity details instance.</summary>
        public DateTimeOffset? LastRefreshedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthCapacityDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeDevices", n => { ActiveDevices = n.GetIntValue(); } },
                { "batteryCapacityFair", n => { BatteryCapacityFair = n.GetIntValue(); } },
                { "batteryCapacityGood", n => { BatteryCapacityGood = n.GetIntValue(); } },
                { "batteryCapacityPoor", n => { BatteryCapacityPoor = n.GetIntValue(); } },
                { "lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
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
#pragma warning restore CS0618
