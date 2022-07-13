using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An item in the list of app positions that sets the order of items on the Managed Home Screen</summary>
    public class AndroidDeviceOwnerKioskModeAppPositionItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents an item on the Android Device Owner Managed Home Screen (application, weblink or folder</summary>
        public AndroidDeviceOwnerKioskModeHomeScreenItem Item {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskModeHomeScreenItem>("item"); }
            set { BackingStore?.Set("item", value); }
        }
        /// <summary>Position of the item on the grid. Valid values 0 to 9999999</summary>
        public int? Position {
            get { return BackingStore?.Get<int?>("position"); }
            set { BackingStore?.Set("position", value); }
        }
        /// <summary>
        /// Instantiates a new androidDeviceOwnerKioskModeAppPositionItem and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerKioskModeAppPositionItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AndroidDeviceOwnerKioskModeAppPositionItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerKioskModeAppPositionItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"item", n => { Item = n.GetObjectValue<AndroidDeviceOwnerKioskModeHomeScreenItem>(AndroidDeviceOwnerKioskModeHomeScreenItem.CreateFromDiscriminatorValue); } },
                {"position", n => { Position = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AndroidDeviceOwnerKioskModeHomeScreenItem>("item", Item);
            writer.WriteIntValue("position", Position);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
