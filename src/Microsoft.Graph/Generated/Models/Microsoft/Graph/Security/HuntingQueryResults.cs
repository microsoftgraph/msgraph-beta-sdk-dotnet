using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Security {
    public class HuntingQueryResults : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<HuntingRowResult> Results { get; set; }
        public List<SinglePropertySchema> Schema { get; set; }
        /// <summary>
        /// Instantiates a new huntingQueryResults and sets the default values.
        /// </summary>
        public HuntingQueryResults() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"results", (o,n) => { (o as HuntingQueryResults).Results = n.GetCollectionOfObjectValues<HuntingRowResult>().ToList(); } },
                {"schema", (o,n) => { (o as HuntingQueryResults).Schema = n.GetCollectionOfObjectValues<SinglePropertySchema>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<HuntingRowResult>("results", Results);
            writer.WriteCollectionOfObjectValues<SinglePropertySchema>("schema", Schema);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
