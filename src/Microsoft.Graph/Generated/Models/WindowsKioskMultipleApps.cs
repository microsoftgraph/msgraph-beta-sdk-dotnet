using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskMultipleApps : WindowsKioskAppConfiguration, IParsable {
        /// <summary>This setting allows access to Downloads folder in file explorer.</summary>
        public bool? AllowAccessToDownloadsFolder {
            get { return BackingStore?.Get<bool?>("allowAccessToDownloadsFolder"); }
            set { BackingStore?.Set("allowAccessToDownloadsFolder", value); }
        }
        /// <summary>These are the only Windows Store Apps that will be available to launch from the Start menu. This collection can contain a maximum of 128 elements.</summary>
        public List<WindowsKioskAppBase> Apps {
            get { return BackingStore?.Get<List<WindowsKioskAppBase>>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
        /// <summary>This setting indicates that desktop apps are allowed. Default to true.</summary>
        public bool? DisallowDesktopApps {
            get { return BackingStore?.Get<bool?>("disallowDesktopApps"); }
            set { BackingStore?.Set("disallowDesktopApps", value); }
        }
        /// <summary>This setting allows the admin to specify whether the Task Bar is shown or not.</summary>
        public bool? ShowTaskBar {
            get { return BackingStore?.Get<bool?>("showTaskBar"); }
            set { BackingStore?.Set("showTaskBar", value); }
        }
        /// <summary>Allows admins to override the default Start layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in Binary format.</summary>
        public byte[] StartMenuLayoutXml {
            get { return BackingStore?.Get<byte[]>("startMenuLayoutXml"); }
            set { BackingStore?.Set("startMenuLayoutXml", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsKioskMultipleApps and sets the default values.
        /// </summary>
        public WindowsKioskMultipleApps() : base() {
            OdataType = "#microsoft.graph.windowsKioskMultipleApps";
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
