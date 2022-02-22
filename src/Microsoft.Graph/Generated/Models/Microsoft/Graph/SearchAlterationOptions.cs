using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SearchAlterationOptions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether spelling modifications are enabled. If enabled, the user will get the search results for the corrected query in case of no results for the original query with typos. The response will also include the spelling modification information in the queryAlterationResponse property. Optional.</summary>
        public bool? EnableModification { get; set; }
        /// <summary>Indicates whether spelling suggestions are enabled. If enabled, the user will get the search results for the original search query and suggestions for spelling correction in the queryAlterationResponse property of the response for the typos in the query. Optional.</summary>
        public bool? EnableSuggestion { get; set; }
        /// <summary>
        /// Instantiates a new searchAlterationOptions and sets the default values.
        /// </summary>
        public SearchAlterationOptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"enableModification", (o,n) => { (o as SearchAlterationOptions).EnableModification = n.GetBoolValue(); } },
                {"enableSuggestion", (o,n) => { (o as SearchAlterationOptions).EnableSuggestion = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enableModification", EnableModification);
            writer.WriteBoolValue("enableSuggestion", EnableSuggestion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
