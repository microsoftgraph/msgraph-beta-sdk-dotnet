using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents an item on the Android Device Owner Managed Home Screen (application, weblink or folder
    /// </summary>
    public class AndroidDeviceOwnerKioskModeFolderItem : AndroidDeviceOwnerKioskModeHomeScreenItem, IParsable {
        /// <summary>
        /// Instantiates a new androidDeviceOwnerKioskModeFolderItem and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerKioskModeFolderItem() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerKioskModeFolderItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerKioskModeFolderItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidDeviceOwnerKioskModeApp" => new AndroidDeviceOwnerKioskModeApp(),
                "#microsoft.graph.androidDeviceOwnerKioskModeWeblink" => new AndroidDeviceOwnerKioskModeWeblink(),
                _ => new AndroidDeviceOwnerKioskModeFolderItem(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
        }
    }
}
