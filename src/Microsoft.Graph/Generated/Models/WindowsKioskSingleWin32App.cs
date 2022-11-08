using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskSingleWin32App : WindowsKioskAppConfiguration, IParsable {
        /// <summary>The win32App property</summary>
        public WindowsKioskWin32App Win32App {
            get { return BackingStore?.Get<WindowsKioskWin32App>("win32App"); }
            set { BackingStore?.Set("win32App", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsKioskSingleWin32App and sets the default values.
        /// </summary>
        public WindowsKioskSingleWin32App() : base() {
            OdataType = "#microsoft.graph.windowsKioskSingleWin32App";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsKioskSingleWin32App CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskSingleWin32App();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"win32App", n => { Win32App = n.GetObjectValue<WindowsKioskWin32App>(WindowsKioskWin32App.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WindowsKioskWin32App>("win32App", Win32App);
        }
    }
}
