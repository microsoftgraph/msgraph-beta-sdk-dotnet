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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Exception information indicates if check for this item was successful or not.Empty string for no error.</summary>
        public string Error {
            get { return BackingStore?.Get<string>("error"); }
            set { BackingStore?.Set("error", value); }
        }
        /// <summary>Indicate whether a payload has any link or not.</summary>
        public bool? HasLink {
            get { return BackingStore?.Get<bool?>("hasLink"); }
            set { BackingStore?.Set("hasLink", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Key of the Payload, In the format of Guid.</summary>
        public string PayloadId {
            get { return BackingStore?.Get<string>("payloadId"); }
            set { BackingStore?.Set("payloadId", value); }
        }
        /// <summary>The reason where the link comes from.</summary>
        public List<DeviceAndAppManagementAssignmentSource?> Sources {
            get { return BackingStore?.Get<List<DeviceAndAppManagementAssignmentSource?>>("sources"); }
            set { BackingStore?.Set("sources", value); }
        }
        /// <summary>
        /// Instantiates a new hasPayloadLinkResultItem and sets the default values.
        /// </summary>
        public HasPayloadLinkResultItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.hasPayloadLinkResultItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"payloadId", n => { PayloadId = n.GetStringValue(); } },
                {"sources", n => { Sources = n.GetCollectionOfEnumValues<DeviceAndAppManagementAssignmentSource>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("error", Error);
            writer.WriteBoolValue("hasLink", HasLink);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("payloadId", PayloadId);
            writer.WriteCollectionOfEnumValues<DeviceAndAppManagementAssignmentSource>("sources", Sources);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
