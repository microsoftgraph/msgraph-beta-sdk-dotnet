using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SearchHit : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The _id property</summary>
        public string _id {
            get { return BackingStore?.Get<string>(nameof(_id)); }
            set { BackingStore?.Set(nameof(_id), value); }
        }
        /// <summary>The _score property</summary>
        public int? _score {
            get { return BackingStore?.Get<int?>(nameof(_score)); }
            set { BackingStore?.Set(nameof(_score), value); }
        }
        /// <summary>The _source property</summary>
        public Entity _source {
            get { return BackingStore?.Get<Entity>(nameof(_source)); }
            set { BackingStore?.Set(nameof(_source), value); }
        }
        /// <summary>The _summary property</summary>
        public string _summary {
            get { return BackingStore?.Get<string>(nameof(_summary)); }
            set { BackingStore?.Set(nameof(_summary), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of the content source which the externalItem is part of .</summary>
        public string ContentSource {
            get { return BackingStore?.Get<string>(nameof(ContentSource)); }
            set { BackingStore?.Set(nameof(ContentSource), value); }
        }
        /// <summary>The internal identifier for the item.</summary>
        public string HitId {
            get { return BackingStore?.Get<string>(nameof(HitId)); }
            set { BackingStore?.Set(nameof(HitId), value); }
        }
        /// <summary>The rank or the order of the result.</summary>
        public int? Rank {
            get { return BackingStore?.Get<int?>(nameof(Rank)); }
            set { BackingStore?.Set(nameof(Rank), value); }
        }
        /// <summary>The resource property</summary>
        public Entity Resource {
            get { return BackingStore?.Get<Entity>(nameof(Resource)); }
            set { BackingStore?.Set(nameof(Resource), value); }
        }
        /// <summary>ID of the result template for rendering the search result. This ID must map to a display layout in the resultTemplates dictionary, included in the searchresponse as well.</summary>
        public string ResultTemplateId {
            get { return BackingStore?.Get<string>(nameof(ResultTemplateId)); }
            set { BackingStore?.Set(nameof(ResultTemplateId), value); }
        }
        /// <summary>A summary of the result, if a summary is available.</summary>
        public string Summary {
            get { return BackingStore?.Get<string>(nameof(Summary)); }
            set { BackingStore?.Set(nameof(Summary), value); }
        }
        /// <summary>
        /// Instantiates a new searchHit and sets the default values.
        /// </summary>
        public SearchHit() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SearchHit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchHit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"_id", n => { _id = n.GetStringValue(); } },
                {"_score", n => { _score = n.GetIntValue(); } },
                {"_source", n => { _source = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"_summary", n => { _summary = n.GetStringValue(); } },
                {"contentSource", n => { ContentSource = n.GetStringValue(); } },
                {"hitId", n => { HitId = n.GetStringValue(); } },
                {"rank", n => { Rank = n.GetIntValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resultTemplateId", n => { ResultTemplateId = n.GetStringValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("_id", _id);
            writer.WriteIntValue("_score", _score);
            writer.WriteObjectValue<Entity>("_source", _source);
            writer.WriteStringValue("_summary", _summary);
            writer.WriteStringValue("contentSource", ContentSource);
            writer.WriteStringValue("hitId", HitId);
            writer.WriteIntValue("rank", Rank);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteStringValue("resultTemplateId", ResultTemplateId);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
