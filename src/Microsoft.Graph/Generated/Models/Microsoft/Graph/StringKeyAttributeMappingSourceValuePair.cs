using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class StringKeyAttributeMappingSourceValuePair : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"key", (o,n) => { (o as StringKeyAttributeMappingSourceValuePair).Key = n.GetStringValue(); } },
                {"value", (o,n) => { (o as StringKeyAttributeMappingSourceValuePair).Value = n.GetObjectValue<AttributeMappingSource>(); } },
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
