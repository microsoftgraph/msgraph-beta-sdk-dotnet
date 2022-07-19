using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A folder containing pages of apps and weblinks on the Managed Home Screen</summary>
    public class AndroidDeviceOwnerKioskModeManagedFolder : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Unique identifier for the folder</summary>
        public string FolderIdentifier {
            get { return BackingStore?.Get<string>("folderIdentifier"); }
            set { BackingStore?.Set("folderIdentifier", value); }
        }
        /// <summary>Display name for the folder</summary>
        public string FolderName {
            get { return BackingStore?.Get<string>("folderName"); }
            set { BackingStore?.Set("folderName", value); }
        }
        /// <summary>Items to be added to managed folder. This collection can contain a maximum of 500 elements.</summary>
        public List<AndroidDeviceOwnerKioskModeFolderItem> Items {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeFolderItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new androidDeviceOwnerKioskModeManagedFolder and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerKioskModeManagedFolder() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.androidDeviceOwnerKioskModeManagedFolder";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AndroidDeviceOwnerKioskModeManagedFolder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerKioskModeManagedFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"folderIdentifier", n => { FolderIdentifier = n.GetStringValue(); } },
                {"folderName", n => { FolderName = n.GetStringValue(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<AndroidDeviceOwnerKioskModeFolderItem>(AndroidDeviceOwnerKioskModeFolderItem.CreateFromDiscriminatorValue).ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("folderIdentifier", FolderIdentifier);
            writer.WriteStringValue("folderName", FolderName);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerKioskModeFolderItem>("items", Items);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
