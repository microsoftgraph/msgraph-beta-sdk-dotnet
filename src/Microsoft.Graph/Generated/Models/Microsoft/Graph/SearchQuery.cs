using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SearchQuery : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The query_string property</summary>
        public SearchQueryString Query_string { get; set; }
        /// <summary>The search query containing the search terms. Required.</summary>
        public string QueryString { get; set; }
        /// <summary>Provides a way to decorate the query string. Supports both KQL and query variables. Optional.</summary>
        public string QueryTemplate { get; set; }
        /// <summary>
        /// Instantiates a new searchQuery and sets the default values.
        /// </summary>
        public SearchQuery() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SearchQuery CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchQuery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"query_string", (o,n) => { (o as SearchQuery).Query_string = n.GetObjectValue<SearchQueryString>(SearchQueryString.CreateFromDiscriminatorValue); } },
                {"queryString", (o,n) => { (o as SearchQuery).QueryString = n.GetStringValue(); } },
                {"queryTemplate", (o,n) => { (o as SearchQuery).QueryTemplate = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SearchQueryString>("query_string", Query_string);
            writer.WriteStringValue("queryString", QueryString);
            writer.WriteStringValue("queryTemplate", QueryTemplate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
