using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics device startup process details.</summary>
    public class UserExperienceAnalyticsDeviceStartupProcess : Entity, IParsable {
        /// <summary>The user experience analytics device id.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
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
        /// <summary>User experience analytics device startup process impact in milliseconds.</summary>
        public int? StartupImpactInMs {
            get { return BackingStore?.Get<int?>(nameof(StartupImpactInMs)); }
            set { BackingStore?.Set(nameof(StartupImpactInMs), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsDeviceStartupProcess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceStartupProcess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"processName", n => { ProcessName = n.GetStringValue(); } },
                {"productName", n => { ProductName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"startupImpactInMs", n => { StartupImpactInMs = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("processName", ProcessName);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteIntValue("startupImpactInMs", StartupImpactInMs);
        }
    }
}
