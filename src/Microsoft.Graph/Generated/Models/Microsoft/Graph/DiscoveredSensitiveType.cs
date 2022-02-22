using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DiscoveredSensitiveType : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ClassificationAttribute> ClassificationAttributes { get; set; }
        public int? Confidence { get; set; }
        public int? Count { get; set; }
        public string Id { get; set; }
        /// <summary>
        /// Instantiates a new discoveredSensitiveType and sets the default values.
        /// </summary>
        public DiscoveredSensitiveType() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classificationAttributes", (o,n) => { (o as DiscoveredSensitiveType).ClassificationAttributes = n.GetCollectionOfObjectValues<ClassificationAttribute>().ToList(); } },
                {"confidence", (o,n) => { (o as DiscoveredSensitiveType).Confidence = n.GetIntValue(); } },
                {"count", (o,n) => { (o as DiscoveredSensitiveType).Count = n.GetIntValue(); } },
                {"id", (o,n) => { (o as DiscoveredSensitiveType).Id = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClassificationAttribute>("classificationAttributes", ClassificationAttributes);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteIntValue("count", Count);
            writer.WriteStringValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
