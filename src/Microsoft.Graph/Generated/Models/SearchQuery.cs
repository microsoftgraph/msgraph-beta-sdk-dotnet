using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SearchQuery : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The query_string property</summary>
        public SearchQueryString Query_string {
            get { return BackingStore?.Get<SearchQueryString>("query_string"); }
            set { BackingStore?.Set("query_string", value); }
        }
        /// <summary>The search query containing the search terms. Required.</summary>
        public string QueryString {
            get { return BackingStore?.Get<string>("queryString"); }
            set { BackingStore?.Set("queryString", value); }
        }
        /// <summary>Provides a way to decorate the query string. Supports both KQL and query variables. Optional.</summary>
        public string QueryTemplate {
            get { return BackingStore?.Get<string>("queryTemplate"); }
            set { BackingStore?.Set("queryTemplate", value); }
        }
        /// <summary>
        /// Instantiates a new searchQuery and sets the default values.
        /// </summary>
        public SearchQuery() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.searchQuery";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchQuery CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchQuery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"query_string", n => { Query_string = n.GetObjectValue<SearchQueryString>(SearchQueryString.CreateFromDiscriminatorValue); } },
                {"queryString", n => { QueryString = n.GetStringValue(); } },
                {"queryTemplate", n => { QueryTemplate = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<SearchQueryString>("query_string", Query_string);
            writer.WriteStringValue("queryString", QueryString);
            writer.WriteStringValue("queryTemplate", QueryTemplate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
