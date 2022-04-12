using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DocumentSetVersionItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The itemId property</summary>
        public string ItemId { get; set; }
        /// <summary>The title property</summary>
        public string Title { get; set; }
        /// <summary>The versionId property</summary>
        public string VersionId { get; set; }
        /// <summary>
        /// Instantiates a new documentSetVersionItem and sets the default values.
        /// </summary>
        public DocumentSetVersionItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DocumentSetVersionItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocumentSetVersionItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"versionId", n => { VersionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("versionId", VersionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
