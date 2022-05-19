using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcBulkRemoteActionResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A list of all the Intune managed device IDs that completed the bulk action with a failure.</summary>
        public List<string> FailedDeviceIds {
            get { return BackingStore?.Get<List<string>>(nameof(FailedDeviceIds)); }
            set { BackingStore?.Set(nameof(FailedDeviceIds), value); }
        }
        /// <summary>A list of all the Intune managed device IDs that were not found when the bulk action was attempted.</summary>
        public List<string> NotFoundDeviceIds {
            get { return BackingStore?.Get<List<string>>(nameof(NotFoundDeviceIds)); }
            set { BackingStore?.Set(nameof(NotFoundDeviceIds), value); }
        }
        /// <summary>A list of all the Intune managed device IDs that were identified as unsupported for the bulk action.</summary>
        public List<string> NotSupportedDeviceIds {
            get { return BackingStore?.Get<List<string>>(nameof(NotSupportedDeviceIds)); }
            set { BackingStore?.Set(nameof(NotSupportedDeviceIds), value); }
        }
        /// <summary>A list of all the Intune managed device IDs that completed the bulk action successfully.</summary>
        public List<string> SuccessfulDeviceIds {
            get { return BackingStore?.Get<List<string>>(nameof(SuccessfulDeviceIds)); }
            set { BackingStore?.Set(nameof(SuccessfulDeviceIds), value); }
        }
        /// <summary>
        /// Instantiates a new CloudPcBulkRemoteActionResult and sets the default values.
        /// </summary>
        public CloudPcBulkRemoteActionResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcBulkRemoteActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcBulkRemoteActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedDeviceIds", n => { FailedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notFoundDeviceIds", n => { NotFoundDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notSupportedDeviceIds", n => { NotSupportedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"successfulDeviceIds", n => { SuccessfulDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("successfulDeviceIds", SuccessfulDeviceIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
