using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows Log Collection request entity.</summary>
    public class DeviceLogCollectionRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier</summary>
        public string Id { get; set; }
        /// <summary>The template type that is sent with the collection request. Possible values are: predefined.</summary>
        public DeviceLogCollectionTemplateType? TemplateType { get; set; }
        /// <summary>
        /// Instantiates a new deviceLogCollectionRequest and sets the default values.
        /// </summary>
        public DeviceLogCollectionRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceLogCollectionRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceLogCollectionRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"id", (o,n) => { (o as DeviceLogCollectionRequest).Id = n.GetStringValue(); } },
                {"templateType", (o,n) => { (o as DeviceLogCollectionRequest).TemplateType = n.GetEnumValue<DeviceLogCollectionTemplateType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<DeviceLogCollectionTemplateType>("templateType", TemplateType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
