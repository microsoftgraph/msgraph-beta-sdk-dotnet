using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ExpressionInputObject : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Definition of the test object.</summary>
        public ObjectDefinition Definition { get; set; }
        /// <summary>Property values of the test object.</summary>
        public List<StringKeyObjectValuePair> Properties { get; set; }
        /// <summary>
        /// Instantiates a new expressionInputObject and sets the default values.
        /// </summary>
        public ExpressionInputObject() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"definition", (o,n) => { (o as ExpressionInputObject).Definition = n.GetObjectValue<ObjectDefinition>(); } },
                {"properties", (o,n) => { (o as ExpressionInputObject).Properties = n.GetCollectionOfObjectValues<StringKeyObjectValuePair>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ObjectDefinition>("definition", Definition);
            writer.WriteCollectionOfObjectValues<StringKeyObjectValuePair>("properties", Properties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
