using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The identifier for a mobile app.
    /// </summary>
    public class WindowsAppIdentifier : MobileAppIdentifier, IParsable {
        /// <summary>The identifier for an app, as specified in the app store.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WindowsAppId {
            get { return BackingStore?.Get<string?>("windowsAppId"); }
            set { BackingStore?.Set("windowsAppId", value); }
        }
#nullable restore
#else
        public string WindowsAppId {
            get { return BackingStore?.Get<string>("windowsAppId"); }
            set { BackingStore?.Set("windowsAppId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windowsAppIdentifier and sets the default values.
        /// </summary>
        public WindowsAppIdentifier() : base() {
            OdataType = "#microsoft.graph.windowsAppIdentifier";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsAppIdentifier CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAppIdentifier();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"windowsAppId", n => { WindowsAppId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("windowsAppId", WindowsAppId);
        }
    }
}
