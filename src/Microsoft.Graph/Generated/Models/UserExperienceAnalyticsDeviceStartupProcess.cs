using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics device startup process details.
    /// </summary>
    public class UserExperienceAnalyticsDeviceStartupProcess : Entity, IParsable {
        /// <summary>The user experience analytics device id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
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
        /// <summary>User experience analytics device startup process impact in milliseconds.</summary>
        public int? StartupImpactInMs {
            get { return BackingStore?.Get<int?>("startupImpactInMs"); }
            set { BackingStore?.Set("startupImpactInMs", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
