using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskMultipleApps : WindowsKioskAppConfiguration, IParsable {
        /// <summary>This setting allows access to Downloads folder in file explorer.</summary>
        public bool? AllowAccessToDownloadsFolder {
            get { return BackingStore?.Get<bool?>(nameof(AllowAccessToDownloadsFolder)); }
            set { BackingStore?.Set(nameof(AllowAccessToDownloadsFolder), value); }
        }
        /// <summary>These are the only Windows Store Apps that will be available to launch from the Start menu. This collection can contain a maximum of 128 elements.</summary>
        public List<WindowsKioskAppBase> Apps {
            get { return BackingStore?.Get<List<WindowsKioskAppBase>>(nameof(Apps)); }
            set { BackingStore?.Set(nameof(Apps), value); }
        }
        /// <summary>This setting indicates that desktop apps are allowed. Default to true.</summary>
        public bool? DisallowDesktopApps {
            get { return BackingStore?.Get<bool?>(nameof(DisallowDesktopApps)); }
            set { BackingStore?.Set(nameof(DisallowDesktopApps), value); }
        }
        /// <summary>This setting allows the admin to specify whether the Task Bar is shown or not.</summary>
        public bool? ShowTaskBar {
            get { return BackingStore?.Get<bool?>(nameof(ShowTaskBar)); }
            set { BackingStore?.Set(nameof(ShowTaskBar), value); }
        }
        /// <summary>Allows admins to override the default Start layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in Binary format.</summary>
        public byte[] StartMenuLayoutXml {
            get { return BackingStore?.Get<byte[]>(nameof(StartMenuLayoutXml)); }
            set { BackingStore?.Set(nameof(StartMenuLayoutXml), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsKioskMultipleApps CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskMultipleApps();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAccessToDownloadsFolder", n => { AllowAccessToDownloadsFolder = n.GetBoolValue(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<WindowsKioskAppBase>(WindowsKioskAppBase.CreateFromDiscriminatorValue).ToList(); } },
                {"disallowDesktopApps", n => { DisallowDesktopApps = n.GetBoolValue(); } },
                {"showTaskBar", n => { ShowTaskBar = n.GetBoolValue(); } },
                {"startMenuLayoutXml", n => { StartMenuLayoutXml = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAccessToDownloadsFolder", AllowAccessToDownloadsFolder);
            writer.WriteCollectionOfObjectValues<WindowsKioskAppBase>("apps", Apps);
            writer.WriteBoolValue("disallowDesktopApps", DisallowDesktopApps);
            writer.WriteBoolValue("showTaskBar", ShowTaskBar);
            writer.WriteByteArrayValue("startMenuLayoutXml", StartMenuLayoutXml);
        }
    }
}
