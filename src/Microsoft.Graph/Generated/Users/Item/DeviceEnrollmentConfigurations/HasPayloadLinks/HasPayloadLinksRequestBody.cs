using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Users.Item.DeviceEnrollmentConfigurations.HasPayloadLinks {
    /// <summary>Provides operations to call the hasPayloadLinks method.</summary>
    public class HasPayloadLinksRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> PayloadIds { get; set; }
        /// <summary>
        /// Instantiates a new hasPayloadLinksRequestBody and sets the default values.
        /// </summary>
        public HasPayloadLinksRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static HasPayloadLinksRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HasPayloadLinksRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"payloadIds", (o,n) => { (o as HasPayloadLinksRequestBody).PayloadIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("payloadIds", PayloadIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
