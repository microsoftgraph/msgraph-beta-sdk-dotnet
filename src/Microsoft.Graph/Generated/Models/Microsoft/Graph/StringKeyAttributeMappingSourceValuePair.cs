using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class StringKeyAttributeMappingSourceValuePair : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the parameter.</summary>
        public string Key { get; set; }
        /// <summary>The value of the parameter.</summary>
        public AttributeMappingSource Value { get; set; }
        /// <summary>
        /// Instantiates a new stringKeyAttributeMappingSourceValuePair and sets the default values.
        /// </summary>
        public StringKeyAttributeMappingSourceValuePair() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static StringKeyAttributeMappingSourceValuePair CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StringKeyAttributeMappingSourceValuePair();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"key", (o,n) => { (o as StringKeyAttributeMappingSourceValuePair).Key = n.GetStringValue(); } },
                {"value", (o,n) => { (o as StringKeyAttributeMappingSourceValuePair).Value = n.GetObjectValue<AttributeMappingSource>(AttributeMappingSource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("key", Key);
            writer.WriteObjectValue<AttributeMappingSource>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
