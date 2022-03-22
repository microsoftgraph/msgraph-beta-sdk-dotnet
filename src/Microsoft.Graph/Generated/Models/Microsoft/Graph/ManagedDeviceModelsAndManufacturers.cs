using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Models and Manufactures meatadata for managed devices in the account</summary>
    public class ManagedDeviceModelsAndManufacturers : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of Manufactures for managed devices in the account</summary>
        public List<string> DeviceManufacturers { get; set; }
        /// <summary>List of Models for managed devices in the account</summary>
        public List<string> DeviceModels { get; set; }
        /// <summary>
        /// Instantiates a new managedDeviceModelsAndManufacturers and sets the default values.
        /// </summary>
        public ManagedDeviceModelsAndManufacturers() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagedDeviceModelsAndManufacturers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceModelsAndManufacturers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceManufacturers", (o,n) => { (o as ManagedDeviceModelsAndManufacturers).DeviceManufacturers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"deviceModels", (o,n) => { (o as ManagedDeviceModelsAndManufacturers).DeviceModels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("deviceManufacturers", DeviceManufacturers);
            writer.WriteCollectionOfPrimitiveValues<string>("deviceModels", DeviceModels);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
