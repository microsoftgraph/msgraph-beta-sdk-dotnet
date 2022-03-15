using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class UserExperienceAnalyticsDeviceStartupProcessPerformance : Entity, IParsable {
        /// <summary>User experience analytics device startup process summarized count.</summary>
        public int? DeviceCount { get; set; }
        /// <summary>User experience analytics device startup process median impact in milliseconds.</summary>
        public int? MedianImpactInMs { get; set; }
        /// <summary>User experience analytics device startup process median impact in milliseconds.</summary>
        public int? MedianImpactInMs2 { get; set; }
        /// <summary>User experience analytics device startup process name.</summary>
        public string ProcessName { get; set; }
        /// <summary>The user experience analytics device startup process product name.</summary>
        public string ProductName { get; set; }
        /// <summary>The User experience analytics device startup process publisher.</summary>
        public string Publisher { get; set; }
        /// <summary>User experience analytics device startup process total impact in milliseconds.</summary>
        public int? TotalImpactInMs { get; set; }
        /// <summary>User experience analytics device startup process total impact in milliseconds.</summary>
        public int? TotalImpactInMs2 { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceCount", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcessPerformance).DeviceCount = n.GetIntValue(); } },
                {"medianImpactInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcessPerformance).MedianImpactInMs = n.GetIntValue(); } },
                {"medianImpactInMs2", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcessPerformance).MedianImpactInMs2 = n.GetIntValue(); } },
                {"processName", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcessPerformance).ProcessName = n.GetStringValue(); } },
                {"productName", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcessPerformance).ProductName = n.GetStringValue(); } },
                {"publisher", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcessPerformance).Publisher = n.GetStringValue(); } },
                {"totalImpactInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcessPerformance).TotalImpactInMs = n.GetIntValue(); } },
                {"totalImpactInMs2", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcessPerformance).TotalImpactInMs2 = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteIntValue("medianImpactInMs", MedianImpactInMs);
            writer.WriteIntValue("medianImpactInMs2", MedianImpactInMs2);
            writer.WriteStringValue("processName", ProcessName);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteIntValue("totalImpactInMs", TotalImpactInMs);
            writer.WriteIntValue("totalImpactInMs2", TotalImpactInMs2);
        }
    }
}
