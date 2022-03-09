using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Sites.Item.ContentTypes.AddCopyFromContentTypeHub {
    /// <summary>Provides operations to call the addCopyFromContentTypeHub method.</summary>
    public class AddCopyFromContentTypeHubRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ContentTypeId { get; set; }
        /// <summary>
        /// Instantiates a new addCopyFromContentTypeHubRequestBody and sets the default values.
        /// </summary>
        public AddCopyFromContentTypeHubRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AddCopyFromContentTypeHubRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddCopyFromContentTypeHubRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentTypeId", (o,n) => { (o as AddCopyFromContentTypeHubRequestBody).ContentTypeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contentTypeId", ContentTypeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
