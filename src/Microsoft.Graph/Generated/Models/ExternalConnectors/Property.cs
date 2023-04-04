using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public class Property : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>A set of aliases or a friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string might not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &amp;, ?, @, #, /, ~, &apos;, &apos;, &lt;, &gt;, `, ^. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Aliases {
            get { return BackingStore?.Get<List<string>?>("aliases"); }
            set { BackingStore?.Set("aliases", value); }
        }
#nullable restore
#else
        public List<string> Aliases {
            get { return BackingStore?.Get<List<string>>("aliases"); }
            set { BackingStore?.Set("aliases", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies if the property will be matched exactly for queries. Exact matching can only be set to true for non-searchable properties of type string or stringCollection. Optional.</summary>
        public bool? IsExactMatchRequired {
            get { return BackingStore?.Get<bool?>("isExactMatchRequired"); }
            set { BackingStore?.Set("isExactMatchRequired", value); }
        }
        /// <summary>Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.</summary>
        public bool? IsQueryable {
            get { return BackingStore?.Get<bool?>("isQueryable"); }
            set { BackingStore?.Set("isQueryable", value); }
        }
        /// <summary>Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.</summary>
        public bool? IsRefinable {
            get { return BackingStore?.Get<bool?>("isRefinable"); }
            set { BackingStore?.Set("isRefinable", value); }
        }
        /// <summary>Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.</summary>
        public bool? IsRetrievable {
            get { return BackingStore?.Get<bool?>("isRetrievable"); }
            set { BackingStore?.Set("isRetrievable", value); }
        }
        /// <summary>Specifies if the property is searchable. Only properties of type string or stringCollection can be searchable. Non-searchable properties are not added to the search index. Optional.</summary>
        public bool? IsSearchable {
            get { return BackingStore?.Get<bool?>("isSearchable"); }
            set { BackingStore?.Set("isSearchable", value); }
        }
        /// <summary>Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (e.g. better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, iconUrl, containerName, containerUrl. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: iconUrl, containerName, containerUrl.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Label?>? Labels {
            get { return BackingStore?.Get<List<Label?>?>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#nullable restore
#else
        public List<Label?> Labels {
            get { return BackingStore?.Get<List<Label?>>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#endif
        /// <summary>The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, the property name may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &amp;, ?, @, #, /, ~, &apos;, &apos;, &lt;, &gt;, `, ^.  Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The type property</summary>
        public PropertyType? Type {
            get { return BackingStore?.Get<PropertyType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new property and sets the default values.
        /// </summary>
        public Property() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Property CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Property();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aliases", n => { Aliases = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"isExactMatchRequired", n => { IsExactMatchRequired = n.GetBoolValue(); } },
                {"isQueryable", n => { IsQueryable = n.GetBoolValue(); } },
                {"isRefinable", n => { IsRefinable = n.GetBoolValue(); } },
                {"isRetrievable", n => { IsRetrievable = n.GetBoolValue(); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"labels", n => { Labels = n.GetCollectionOfEnumValues<Label>()?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<PropertyType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aliases", Aliases);
            writer.WriteBoolValue("isExactMatchRequired", IsExactMatchRequired);
            writer.WriteBoolValue("isQueryable", IsQueryable);
            writer.WriteBoolValue("isRefinable", IsRefinable);
            writer.WriteBoolValue("isRetrievable", IsRetrievable);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteCollectionOfEnumValues<Label>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<PropertyType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
