using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskSingleUWPApp : WindowsKioskAppConfiguration, IParsable {
        /// <summary>The uwpApp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsKioskUWPApp? UwpApp {
            get { return BackingStore?.Get<WindowsKioskUWPApp?>("uwpApp"); }
            set { BackingStore?.Set("uwpApp", value); }
        }
#nullable restore
#else
        public WindowsKioskUWPApp UwpApp {
            get { return BackingStore?.Get<WindowsKioskUWPApp>("uwpApp"); }
            set { BackingStore?.Set("uwpApp", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new WindowsKioskSingleUWPApp and sets the default values.
        /// </summary>
        public WindowsKioskSingleUWPApp() : base() {
            OdataType = "#microsoft.graph.windowsKioskSingleUWPApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsKioskSingleUWPApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskSingleUWPApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"uwpApp", n => { UwpApp = n.GetObjectValue<WindowsKioskUWPApp>(WindowsKioskUWPApp.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WindowsKioskUWPApp>("uwpApp", UwpApp);
        }
    }
}
