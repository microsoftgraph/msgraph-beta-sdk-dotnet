using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AttributeMappingSource : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Expression { get; set; }
        public string Name { get; set; }
        public List<StringKeyAttributeMappingSourceValuePair> Parameters { get; set; }
        public AttributeMappingSourceType? Type { get; set; }
        /// <summary>
        /// Instantiates a new attributeMappingSource and sets the default values.
        /// </summary>
        public AttributeMappingSource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expression", (o,n) => { (o as AttributeMappingSource).Expression = n.GetStringValue(); } },
                {"name", (o,n) => { (o as AttributeMappingSource).Name = n.GetStringValue(); } },
                {"parameters", (o,n) => { (o as AttributeMappingSource).Parameters = n.GetCollectionOfObjectValues<StringKeyAttributeMappingSourceValuePair>().ToList(); } },
                {"type", (o,n) => { (o as AttributeMappingSource).Type = n.GetEnumValue<AttributeMappingSourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expression", Expression);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<StringKeyAttributeMappingSourceValuePair>("parameters", Parameters);
            writer.WriteEnumValue<AttributeMappingSourceType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
