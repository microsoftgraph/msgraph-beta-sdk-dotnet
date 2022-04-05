using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class containing the result of HasPayloadLinks action.</summary>
    public class HasPayloadLinkResultItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Exception information indicates if check for this item was successful or not.Empty string for no error.</summary>
        public string Error { get; set; }
        /// <summary>Indicate whether a payload has any link or not.</summary>
        public bool? HasLink { get; set; }
        /// <summary>Key of the Payload, In the format of Guid.</summary>
        public string PayloadId { get; set; }
        /// <summary>The reason where the link comes from.</summary>
        public List<DeviceAndAppManagementAssignmentSource?> Sources { get; set; }
        /// <summary>
        /// Instantiates a new hasPayloadLinkResultItem and sets the default values.
        /// </summary>
        public HasPayloadLinkResultItem() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"error", (o,n) => { (o as HasPayloadLinkResultItem).Error = n.GetStringValue(); } },
                {"hasLink", (o,n) => { (o as HasPayloadLinkResultItem).HasLink = n.GetBoolValue(); } },
                {"payloadId", (o,n) => { (o as HasPayloadLinkResultItem).PayloadId = n.GetStringValue(); } },
                {"sources", (o,n) => { (o as HasPayloadLinkResultItem).Sources = n.GetCollectionOfEnumValues<DeviceAndAppManagementAssignmentSource>().ToList(); } },
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
            writer.WriteCollectionOfEnumValues<DeviceAndAppManagementAssignmentSource>("sources", Sources);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
