using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph.Ediscovery;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.Queries.Item.ApplyTags {
    public class ApplyTagsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<Tag> TagsToAdd { get; set; }
        public List<Tag> TagsToRemove { get; set; }
        /// <summary>
        /// Instantiates a new applyTagsRequestBody and sets the default values.
        /// </summary>
        public ApplyTagsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"tagsToAdd", (o,n) => { (o as ApplyTagsRequestBody).TagsToAdd = n.GetCollectionOfObjectValues<Tag>().ToList(); } },
                {"tagsToRemove", (o,n) => { (o as ApplyTagsRequestBody).TagsToRemove = n.GetCollectionOfObjectValues<Tag>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Tag>("tagsToAdd", TagsToAdd);
            writer.WriteCollectionOfObjectValues<Tag>("tagsToRemove", TagsToRemove);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
