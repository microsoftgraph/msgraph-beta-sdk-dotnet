using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SearchRequest : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Contains one or more filters to obtain search results aggregated and filtered to a specific value of a field. Optional.Build this filter based on a prior search that aggregates by the same field. From the response of the prior search, identify the searchBucket that filters results to the specific value of the field, use the string in its aggregationFilterToken property, and build an aggregation filter string in the format &apos;{field}:/&apos;{aggregationFilterToken}/&apos;&apos;. If multiple values for the same field need to be provided, use the strings in its aggregationFilterToken property and build an aggregation filter string in the format &apos;{field}:or(/&apos;{aggregationFilterToken1}/&apos;,/&apos;{aggregationFilterToken2}/&apos;)&apos;. For example, searching and aggregating drive items by file type returns a searchBucket for the file type docx in the response. You can conveniently use the aggregationFilterToken returned for this searchBucket in a subsequent search query and filter matches down to drive items of the docx file type. Example 1 and example 2 show the actual requests and responses.</summary>
        public List<string> AggregationFilters {
            get { return BackingStore?.Get<List<string>>(nameof(AggregationFilters)); }
            set { BackingStore?.Set(nameof(AggregationFilters), value); }
        }
        /// <summary>Specifies aggregations (also known as refiners) to be returned alongside search results. Optional.</summary>
        public List<AggregationOption> Aggregations {
            get { return BackingStore?.Get<List<AggregationOption>>(nameof(Aggregations)); }
            set { BackingStore?.Set(nameof(Aggregations), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Contains the connection to be targeted. Respects the following format : /external/connections/connectionid where connectionid is the ConnectionId defined in the Connectors Administration.  Note: contentSource is only applicable when entityType=externalItem. Optional.</summary>
        public List<string> ContentSources {
            get { return BackingStore?.Get<List<string>>(nameof(ContentSources)); }
            set { BackingStore?.Set(nameof(ContentSources), value); }
        }
        /// <summary>This triggers hybrid sort for messages: the first 3 messages are the most relevant. This property is only applicable to entityType=message. Optional.</summary>
        public bool? EnableTopResults {
            get { return BackingStore?.Get<bool?>(nameof(EnableTopResults)); }
            set { BackingStore?.Set(nameof(EnableTopResults), value); }
        }
        /// <summary>One or more types of resources expected in the response. Possible values are: list, site, listItem, message, event, drive, driveItem, person, externalItem. See known limitations for those combinations of two or more entity types that are supported in the same search request. Required.</summary>
        public List<string> EntityTypes {
            get { return BackingStore?.Get<List<string>>(nameof(EntityTypes)); }
            set { BackingStore?.Set(nameof(EntityTypes), value); }
        }
        /// <summary>Contains the fields to be returned for each resource object specified in entityTypes, allowing customization of the fields returned by default otherwise, including additional fields such as custom managed properties from SharePoint and OneDrive, or custom fields in externalItem from content that Microsoft Graph connectors bring in. The fields property can be using the semantic labels applied to properties. For example, if a property is label as title, you can retrieve it using the following syntax : label_title.Optional.</summary>
        public List<string> Fields {
            get { return BackingStore?.Get<List<string>>(nameof(Fields)); }
            set { BackingStore?.Set(nameof(Fields), value); }
        }
        /// <summary>Specifies the offset for the search results. Offset 0 returns the very first result. Optional.</summary>
        public int? From {
            get { return BackingStore?.Get<int?>(nameof(From)); }
            set { BackingStore?.Set(nameof(From), value); }
        }
        /// <summary>The query property</summary>
        public SearchQuery Query {
            get { return BackingStore?.Get<SearchQuery>(nameof(Query)); }
            set { BackingStore?.Set(nameof(Query), value); }
        }
        /// <summary>Provides query alteration options formatted as a JSON blob that contains two optional flags related to spelling correction. Optional.</summary>
        public SearchAlterationOptions QueryAlterationOptions {
            get { return BackingStore?.Get<SearchAlterationOptions>(nameof(QueryAlterationOptions)); }
            set { BackingStore?.Set(nameof(QueryAlterationOptions), value); }
        }
        /// <summary>The region property</summary>
        public string Region {
            get { return BackingStore?.Get<string>(nameof(Region)); }
            set { BackingStore?.Set(nameof(Region), value); }
        }
        /// <summary>Provides the search result templates options for rendering connectors search results.</summary>
        public ResultTemplateOption ResultTemplateOptions {
            get { return BackingStore?.Get<ResultTemplateOption>(nameof(ResultTemplateOptions)); }
            set { BackingStore?.Set(nameof(ResultTemplateOptions), value); }
        }
        /// <summary>The size of the page to be retrieved. Optional.</summary>
        public int? Size {
            get { return BackingStore?.Get<int?>(nameof(Size)); }
            set { BackingStore?.Set(nameof(Size), value); }
        }
        /// <summary>Contains the ordered collection of fields and direction to sort results. There can be at most 5 sort properties in the collection. Optional.</summary>
        public List<SortProperty> SortProperties {
            get { return BackingStore?.Get<List<SortProperty>>(nameof(SortProperties)); }
            set { BackingStore?.Set(nameof(SortProperties), value); }
        }
        /// <summary>The stored_fields property</summary>
        public List<string> Stored_fields {
            get { return BackingStore?.Get<List<string>>(nameof(Stored_fields)); }
            set { BackingStore?.Set(nameof(Stored_fields), value); }
        }
        /// <summary>Indicates whether to trim away the duplicate SharePoint files from search results. Default value is false. Optional.</summary>
        public bool? TrimDuplicates {
            get { return BackingStore?.Get<bool?>(nameof(TrimDuplicates)); }
            set { BackingStore?.Set(nameof(TrimDuplicates), value); }
        }
        /// <summary>
        /// Instantiates a new searchRequest and sets the default values.
        /// </summary>
        public SearchRequest() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SearchRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aggregationFilters", n => { AggregationFilters = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"aggregations", n => { Aggregations = n.GetCollectionOfObjectValues<AggregationOption>(AggregationOption.CreateFromDiscriminatorValue).ToList(); } },
                {"contentSources", n => { ContentSources = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"enableTopResults", n => { EnableTopResults = n.GetBoolValue(); } },
                {"entityTypes", n => { EntityTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fields", n => { Fields = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"from", n => { From = n.GetIntValue(); } },
                {"query", n => { Query = n.GetObjectValue<SearchQuery>(SearchQuery.CreateFromDiscriminatorValue); } },
                {"queryAlterationOptions", n => { QueryAlterationOptions = n.GetObjectValue<SearchAlterationOptions>(SearchAlterationOptions.CreateFromDiscriminatorValue); } },
                {"region", n => { Region = n.GetStringValue(); } },
                {"resultTemplateOptions", n => { ResultTemplateOptions = n.GetObjectValue<ResultTemplateOption>(ResultTemplateOption.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetIntValue(); } },
                {"sortProperties", n => { SortProperties = n.GetCollectionOfObjectValues<SortProperty>(SortProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"stored_fields", n => { Stored_fields = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"trimDuplicates", n => { TrimDuplicates = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aggregationFilters", AggregationFilters);
            writer.WriteCollectionOfObjectValues<AggregationOption>("aggregations", Aggregations);
            writer.WriteCollectionOfPrimitiveValues<string>("contentSources", ContentSources);
            writer.WriteBoolValue("enableTopResults", EnableTopResults);
            writer.WriteCollectionOfPrimitiveValues<string>("entityTypes", EntityTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("fields", Fields);
            writer.WriteIntValue("from", From);
            writer.WriteObjectValue<SearchQuery>("query", Query);
            writer.WriteObjectValue<SearchAlterationOptions>("queryAlterationOptions", QueryAlterationOptions);
            writer.WriteStringValue("region", Region);
            writer.WriteObjectValue<ResultTemplateOption>("resultTemplateOptions", ResultTemplateOptions);
            writer.WriteIntValue("size", Size);
            writer.WriteCollectionOfObjectValues<SortProperty>("sortProperties", SortProperties);
            writer.WriteCollectionOfPrimitiveValues<string>("stored_fields", Stored_fields);
            writer.WriteBoolValue("trimDuplicates", TrimDuplicates);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
