using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics device startup process performance.</summary>
    public class UserExperienceAnalyticsDeviceStartupProcessPerformance : Entity, IParsable {
        /// <summary>User experience analytics device startup process summarized count.</summary>
        public long? DeviceCount {
            get { return BackingStore?.Get<long?>(nameof(DeviceCount)); }
            set { BackingStore?.Set(nameof(DeviceCount), value); }
        }
        /// <summary>User experience analytics device startup process median impact in milliseconds.</summary>
        public int? MedianImpactInMs {
            get { return BackingStore?.Get<int?>(nameof(MedianImpactInMs)); }
            set { BackingStore?.Set(nameof(MedianImpactInMs), value); }
        }
        /// <summary>User experience analytics device startup process median impact in milliseconds.</summary>
        public long? MedianImpactInMs2 {
            get { return BackingStore?.Get<long?>(nameof(MedianImpactInMs2)); }
            set { BackingStore?.Set(nameof(MedianImpactInMs2), value); }
        }
        /// <summary>User experience analytics device startup process name.</summary>
        public string ProcessName {
            get { return BackingStore?.Get<string>(nameof(ProcessName)); }
            set { BackingStore?.Set(nameof(ProcessName), value); }
        }
        /// <summary>The user experience analytics device startup process product name.</summary>
        public string ProductName {
            get { return BackingStore?.Get<string>(nameof(ProductName)); }
            set { BackingStore?.Set(nameof(ProductName), value); }
        }
        /// <summary>The User experience analytics device startup process publisher.</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>(nameof(Publisher)); }
            set { BackingStore?.Set(nameof(Publisher), value); }
        }
        /// <summary>User experience analytics device startup process total impact in milliseconds.</summary>
        public int? TotalImpactInMs {
            get { return BackingStore?.Get<int?>(nameof(TotalImpactInMs)); }
            set { BackingStore?.Set(nameof(TotalImpactInMs), value); }
        }
        /// <summary>User experience analytics device startup process total impact in milliseconds.</summary>
        public long? TotalImpactInMs2 {
            get { return BackingStore?.Get<long?>(nameof(TotalImpactInMs2)); }
            set { BackingStore?.Set(nameof(TotalImpactInMs2), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsDeviceStartupProcessPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceStartupProcessPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceCount", n => { DeviceCount = n.GetLongValue(); } },
                {"medianImpactInMs", n => { MedianImpactInMs = n.GetIntValue(); } },
                {"medianImpactInMs2", n => { MedianImpactInMs2 = n.GetLongValue(); } },
                {"processName", n => { ProcessName = n.GetStringValue(); } },
                {"productName", n => { ProductName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"totalImpactInMs", n => { TotalImpactInMs = n.GetIntValue(); } },
                {"totalImpactInMs2", n => { TotalImpactInMs2 = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("deviceCount", DeviceCount);
            writer.WriteIntValue("medianImpactInMs", MedianImpactInMs);
            writer.WriteLongValue("medianImpactInMs2", MedianImpactInMs2);
            writer.WriteStringValue("processName", ProcessName);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteIntValue("totalImpactInMs", TotalImpactInMs);
            writer.WriteLongValue("totalImpactInMs2", TotalImpactInMs2);
        }
    }
}
