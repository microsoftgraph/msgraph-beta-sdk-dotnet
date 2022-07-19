using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskDesktopApp : WindowsKioskAppBase, IParsable {
        /// <summary>Define the DesktopApplicationID of the app</summary>
        public string DesktopApplicationId {
            get { return BackingStore?.Get<string>("desktopApplicationId"); }
            set { BackingStore?.Set("desktopApplicationId", value); }
        }
        /// <summary>Define the DesktopApplicationLinkPath of the app</summary>
        public string DesktopApplicationLinkPath {
            get { return BackingStore?.Get<string>("desktopApplicationLinkPath"); }
            set { BackingStore?.Set("desktopApplicationLinkPath", value); }
        }
        /// <summary>Define the path of a desktop app</summary>
        public string PathObject {
            get { return BackingStore?.Get<string>("path"); }
            set { BackingStore?.Set("path", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsKioskDesktopApp and sets the default values.
        /// </summary>
        public WindowsKioskDesktopApp() : base() {
            OdataType = "#microsoft.graph.windowsKioskDesktopApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsKioskDesktopApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskDesktopApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"desktopApplicationId", n => { DesktopApplicationId = n.GetStringValue(); } },
                {"desktopApplicationLinkPath", n => { DesktopApplicationLinkPath = n.GetStringValue(); } },
                {"path", n => { PathObject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("desktopApplicationId", DesktopApplicationId);
            writer.WriteStringValue("desktopApplicationLinkPath", DesktopApplicationLinkPath);
            writer.WriteStringValue("path", PathObject);
        }
    }
}
