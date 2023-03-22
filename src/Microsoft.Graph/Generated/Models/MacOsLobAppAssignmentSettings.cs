using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOsLobAppAssignmentSettings : MobileAppAssignmentSettings, IParsable {
        /// <summary>Whether or not to uninstall the app when device is removed from Intune.</summary>
        public bool? UninstallOnDeviceRemoval {
            get { return BackingStore?.Get<bool?>("uninstallOnDeviceRemoval"); }
            set { BackingStore?.Set("uninstallOnDeviceRemoval", value); }
        }
        /// <summary>
        /// Instantiates a new MacOsLobAppAssignmentSettings and sets the default values.
        /// </summary>
        public MacOsLobAppAssignmentSettings() : base() {
            OdataType = "#microsoft.graph.macOsLobAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOsLobAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOsLobAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"uninstallOnDeviceRemoval", n => { UninstallOnDeviceRemoval = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("uninstallOnDeviceRemoval", UninstallOnDeviceRemoval);
        }
    }
}
