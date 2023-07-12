using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The base class for a type of apps
    /// </summary>
    public class WindowsKioskUWPApp : WindowsKioskAppBase, IParsable {
        /// <summary>This references an Intune App that will be target to the same assignments as Kiosk configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>This is the only Application User Model ID (AUMID) that will be available to launch use while in Kiosk Mode</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppUserModelId {
            get { return BackingStore?.Get<string?>("appUserModelId"); }
            set { BackingStore?.Set("appUserModelId", value); }
        }
#nullable restore
#else
        public string AppUserModelId {
            get { return BackingStore?.Get<string>("appUserModelId"); }
            set { BackingStore?.Set("appUserModelId", value); }
        }
#endif
        /// <summary>This references an contained App from an Intune App</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainedAppId {
            get { return BackingStore?.Get<string?>("containedAppId"); }
            set { BackingStore?.Set("containedAppId", value); }
        }
#nullable restore
#else
        public string ContainedAppId {
            get { return BackingStore?.Get<string>("containedAppId"); }
            set { BackingStore?.Set("containedAppId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windowsKioskUWPApp and sets the default values.
        /// </summary>
        public WindowsKioskUWPApp() : base() {
            OdataType = "#microsoft.graph.windowsKioskUWPApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsKioskUWPApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskUWPApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"appUserModelId", n => { AppUserModelId = n.GetStringValue(); } },
                {"containedAppId", n => { ContainedAppId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("appUserModelId", AppUserModelId);
            writer.WriteStringValue("containedAppId", ContainedAppId);
        }
    }
}
