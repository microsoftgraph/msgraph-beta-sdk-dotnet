using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class containing the result of HasPayloadLinks action.</summary>
    public class HasPayloadLinkResultItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Exception information indicates if check for this item was successful or not.Empty string for no error.</summary>
        public string Error {
            get { return BackingStore?.Get<string>(nameof(Error)); }
            set { BackingStore?.Set(nameof(Error), value); }
        }
        /// <summary>Indicate whether a payload has any link or not.</summary>
        public bool? HasLink {
            get { return BackingStore?.Get<bool?>(nameof(HasLink)); }
            set { BackingStore?.Set(nameof(HasLink), value); }
        }
        /// <summary>Key of the Payload, In the format of Guid.</summary>
        public string PayloadId {
            get { return BackingStore?.Get<string>(nameof(PayloadId)); }
            set { BackingStore?.Set(nameof(PayloadId), value); }
        }
        /// <summary>The reason where the link comes from.</summary>
        public List<string> Sources {
            get { return BackingStore?.Get<List<string>>(nameof(Sources)); }
            set { BackingStore?.Set(nameof(Sources), value); }
        }
        /// <summary>
        /// Instantiates a new hasPayloadLinkResultItem and sets the default values.
        /// </summary>
        public HasPayloadLinkResultItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static HasPayloadLinkResultItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HasPayloadLinkResultItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"error", n => { Error = n.GetStringValue(); } },
                {"hasLink", n => { HasLink = n.GetBoolValue(); } },
                {"payloadId", n => { PayloadId = n.GetStringValue(); } },
                {"sources", n => { Sources = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("error", Error);
            writer.WriteBoolValue("hasLink", HasLink);
            writer.WriteStringValue("payloadId", PayloadId);
            writer.WriteCollectionOfPrimitiveValues<string>("sources", Sources);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
