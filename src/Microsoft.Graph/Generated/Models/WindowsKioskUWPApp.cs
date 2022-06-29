using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskUWPApp : WindowsKioskAppBase, IParsable {
        /// <summary>This references an Intune App that will be target to the same assignments as Kiosk configuration</summary>
        public string AppId {
            get { return BackingStore?.Get<string>(nameof(AppId)); }
            set { BackingStore?.Set(nameof(AppId), value); }
        }
        /// <summary>This is the only Application User Model ID (AUMID) that will be available to launch use while in Kiosk Mode</summary>
        public string AppUserModelId {
            get { return BackingStore?.Get<string>(nameof(AppUserModelId)); }
            set { BackingStore?.Set(nameof(AppUserModelId), value); }
        }
        /// <summary>This references an contained App from an Intune App</summary>
        public string ContainedAppId {
            get { return BackingStore?.Get<string>(nameof(ContainedAppId)); }
            set { BackingStore?.Set(nameof(ContainedAppId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("appUserModelId", AppUserModelId);
            writer.WriteStringValue("containedAppId", ContainedAppId);
        }
    }
}
