using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BulkManagedDeviceActionResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Failed devices</summary>
        public List<string> FailedDeviceIds {
            get { return BackingStore?.Get<List<string>>("failedDeviceIds"); }
            set { BackingStore?.Set("failedDeviceIds", value); }
        }
        /// <summary>Not found devices</summary>
        public List<string> NotFoundDeviceIds {
            get { return BackingStore?.Get<List<string>>("notFoundDeviceIds"); }
            set { BackingStore?.Set("notFoundDeviceIds", value); }
        }
        /// <summary>Not supported devices</summary>
        public List<string> NotSupportedDeviceIds {
            get { return BackingStore?.Get<List<string>>("notSupportedDeviceIds"); }
            set { BackingStore?.Set("notSupportedDeviceIds", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Successful devices</summary>
        public List<string> SuccessfulDeviceIds {
            get { return BackingStore?.Get<List<string>>("successfulDeviceIds"); }
            set { BackingStore?.Set("successfulDeviceIds", value); }
        }
        /// <summary>
        /// Instantiates a new bulkManagedDeviceActionResult and sets the default values.
        /// </summary>
        public BulkManagedDeviceActionResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.bulkManagedDeviceActionResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BulkManagedDeviceActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkManagedDeviceActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedDeviceIds", n => { FailedDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"notFoundDeviceIds", n => { NotFoundDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"notSupportedDeviceIds", n => { NotSupportedDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"successfulDeviceIds", n => { SuccessfulDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("failedDeviceIds", FailedDeviceIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notFoundDeviceIds", NotFoundDeviceIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notSupportedDeviceIds", NotSupportedDeviceIds);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("successfulDeviceIds", SuccessfulDeviceIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
