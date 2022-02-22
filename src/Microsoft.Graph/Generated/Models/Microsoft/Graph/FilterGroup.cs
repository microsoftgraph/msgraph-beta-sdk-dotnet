using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class FilterGroup : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Filter clauses (conditions) of this group. All clauses in a group must be satisfied in order for the filter group to evaluate to true.</summary>
        public List<FilterClause> Clauses { get; set; }
        /// <summary>Human-readable name of the filter group.</summary>
        public string Name { get; set; }
        /// <summary>
        /// Instantiates a new filterGroup and sets the default values.
        /// </summary>
        public FilterGroup() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clauses", (o,n) => { (o as FilterGroup).Clauses = n.GetCollectionOfObjectValues<FilterClause>().ToList(); } },
                {"name", (o,n) => { (o as FilterGroup).Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<FilterClause>("clauses", Clauses);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
