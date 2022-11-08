using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerKioskModeManagedFolderReference : AndroidDeviceOwnerKioskModeHomeScreenItem, IParsable {
        /// <summary>Unique identifier for the folder</summary>
        public string FolderIdentifier {
            get { return BackingStore?.Get<string>("folderIdentifier"); }
            set { BackingStore?.Set("folderIdentifier", value); }
        }
        /// <summary>Name of the folder</summary>
        public string FolderName {
            get { return BackingStore?.Get<string>("folderName"); }
            set { BackingStore?.Set("folderName", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidDeviceOwnerKioskModeManagedFolderReference and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerKioskModeManagedFolderReference() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerKioskModeManagedFolderReference";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerKioskModeManagedFolderReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerKioskModeManagedFolderReference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"folderIdentifier", n => { FolderIdentifier = n.GetStringValue(); } },
                {"folderName", n => { FolderName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("folderIdentifier", FolderIdentifier);
            writer.WriteStringValue("folderName", FolderName);
        }
    }
}
