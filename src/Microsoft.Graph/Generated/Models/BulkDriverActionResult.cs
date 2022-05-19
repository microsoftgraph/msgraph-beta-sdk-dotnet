using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A complex type to represent the result of bulk driver action.</summary>
    public class BulkDriverActionResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of driver Ids where the action is failed.</summary>
        public List<string> FailedDriverIds {
            get { return BackingStore?.Get<List<string>>(nameof(FailedDriverIds)); }
            set { BackingStore?.Set(nameof(FailedDriverIds), value); }
        }
        /// <summary>List of driver Ids that are not found.</summary>
        public List<string> NotFoundDriverIds {
            get { return BackingStore?.Get<List<string>>(nameof(NotFoundDriverIds)); }
            set { BackingStore?.Set(nameof(NotFoundDriverIds), value); }
        }
        /// <summary>List of driver Ids where the action is successful.</summary>
        public List<string> SuccessfulDriverIds {
            get { return BackingStore?.Get<List<string>>(nameof(SuccessfulDriverIds)); }
            set { BackingStore?.Set(nameof(SuccessfulDriverIds), value); }
        }
        /// <summary>
        /// Instantiates a new BulkDriverActionResult and sets the default values.
        /// </summary>
        public BulkDriverActionResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BulkDriverActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkDriverActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedDriverIds", n => { FailedDriverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notFoundDriverIds", n => { NotFoundDriverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"successfulDriverIds", n => { SuccessfulDriverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("failedDriverIds", FailedDriverIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notFoundDriverIds", NotFoundDriverIds);
            writer.WriteCollectionOfPrimitiveValues<string>("successfulDriverIds", SuccessfulDriverIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
