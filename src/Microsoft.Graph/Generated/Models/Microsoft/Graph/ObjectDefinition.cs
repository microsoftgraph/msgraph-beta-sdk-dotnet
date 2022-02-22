using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ObjectDefinition : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<AttributeDefinition> Attributes { get; set; }
        public List<MetadataEntry> Metadata { get; set; }
        public string Name { get; set; }
        public List<string> SupportedApis { get; set; }
        /// <summary>
        /// Instantiates a new objectDefinition and sets the default values.
        /// </summary>
        public ObjectDefinition() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attributes", (o,n) => { (o as ObjectDefinition).Attributes = n.GetCollectionOfObjectValues<AttributeDefinition>().ToList(); } },
                {"metadata", (o,n) => { (o as ObjectDefinition).Metadata = n.GetCollectionOfObjectValues<MetadataEntry>().ToList(); } },
                {"name", (o,n) => { (o as ObjectDefinition).Name = n.GetStringValue(); } },
                {"supportedApis", (o,n) => { (o as ObjectDefinition).SupportedApis = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AttributeDefinition>("attributes", Attributes);
            writer.WriteCollectionOfObjectValues<MetadataEntry>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedApis", SupportedApis);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
