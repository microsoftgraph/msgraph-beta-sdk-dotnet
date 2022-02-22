using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ExactDataMatchStoreColumn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> IgnoredDelimiters { get; set; }
        public bool? IsCaseInsensitive { get; set; }
        public bool? IsSearchable { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Instantiates a new exactDataMatchStoreColumn and sets the default values.
        /// </summary>
        public ExactDataMatchStoreColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ignoredDelimiters", (o,n) => { (o as ExactDataMatchStoreColumn).IgnoredDelimiters = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isCaseInsensitive", (o,n) => { (o as ExactDataMatchStoreColumn).IsCaseInsensitive = n.GetBoolValue(); } },
                {"isSearchable", (o,n) => { (o as ExactDataMatchStoreColumn).IsSearchable = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as ExactDataMatchStoreColumn).Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("ignoredDelimiters", IgnoredDelimiters);
            writer.WriteBoolValue("isCaseInsensitive", IsCaseInsensitive);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
