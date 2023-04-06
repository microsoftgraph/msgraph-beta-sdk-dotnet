using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics device startup process performance.
    /// </summary>
    public class UserExperienceAnalyticsDeviceStartupProcessPerformance : Entity, IParsable {
        /// <summary>User experience analytics device startup process summarized count.</summary>
        public long? DeviceCount {
            get { return BackingStore?.Get<long?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
        }
        /// <summary>User experience analytics device startup process median impact in milliseconds.</summary>
        public int? MedianImpactInMs {
            get { return BackingStore?.Get<int?>("medianImpactInMs"); }
            set { BackingStore?.Set("medianImpactInMs", value); }
        }
        /// <summary>User experience analytics device startup process median impact in milliseconds.</summary>
        public long? MedianImpactInMs2 {
            get { return BackingStore?.Get<long?>("medianImpactInMs2"); }
            set { BackingStore?.Set("medianImpactInMs2", value); }
        }
        /// <summary>User experience analytics device startup process name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcessName {
            get { return BackingStore?.Get<string?>("processName"); }
            set { BackingStore?.Set("processName", value); }
        }
#nullable restore
#else
        public string ProcessName {
            get { return BackingStore?.Get<string>("processName"); }
            set { BackingStore?.Set("processName", value); }
        }
#endif
        /// <summary>The user experience analytics device startup process product name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName {
            get { return BackingStore?.Get<string?>("productName"); }
            set { BackingStore?.Set("productName", value); }
        }
#nullable restore
#else
        public string ProductName {
            get { return BackingStore?.Get<string>("productName"); }
            set { BackingStore?.Set("productName", value); }
        }
#endif
        /// <summary>The User experience analytics device startup process publisher.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>User experience analytics device startup process total impact in milliseconds.</summary>
        public int? TotalImpactInMs {
            get { return BackingStore?.Get<int?>("totalImpactInMs"); }
            set { BackingStore?.Set("totalImpactInMs", value); }
        }
        /// <summary>User experience analytics device startup process total impact in milliseconds.</summary>
        public long? TotalImpactInMs2 {
            get { return BackingStore?.Get<long?>("totalImpactInMs2"); }
            set { BackingStore?.Set("totalImpactInMs2", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
