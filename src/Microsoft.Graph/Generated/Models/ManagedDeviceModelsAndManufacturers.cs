using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Models and Manufactures meatadata for managed devices in the account</summary>
    public class ManagedDeviceModelsAndManufacturers : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of Manufactures for managed devices in the account</summary>
        public List<string> DeviceManufacturers {
            get { return BackingStore?.Get<List<string>>("deviceManufacturers"); }
            set { BackingStore?.Set("deviceManufacturers", value); }
        }
        /// <summary>List of Models for managed devices in the account</summary>
        public List<string> DeviceModels {
            get { return BackingStore?.Get<List<string>>("deviceModels"); }
            set { BackingStore?.Set("deviceModels", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new managedDeviceModelsAndManufacturers and sets the default values.
        /// </summary>
        public ManagedDeviceModelsAndManufacturers() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ManagedDeviceModelsAndManufacturers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceModelsAndManufacturers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceManufacturers", n => { DeviceManufacturers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"deviceModels", n => { DeviceModels = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("deviceManufacturers", DeviceManufacturers);
            writer.WriteCollectionOfPrimitiveValues<string>("deviceModels", DeviceModels);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
