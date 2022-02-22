using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PersonInterest : ItemFacet, IParsable {
        /// <summary>Contains categories a user has associated with the interest (for example, personal, recipies).</summary>
        public List<string> Categories { get; set; }
        /// <summary>Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.</summary>
        public List<string> CollaborationTags { get; set; }
        /// <summary>Contains a description of the interest.</summary>
        public string Description { get; set; }
        /// <summary>Contains a friendly name for the interest.</summary>
        public string DisplayName { get; set; }
        public string ThumbnailUrl { get; set; }
        /// <summary>Contains a link to a web page or resource about the interest.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as PersonInterest).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"collaborationTags", (o,n) => { (o as PersonInterest).CollaborationTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", (o,n) => { (o as PersonInterest).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PersonInterest).DisplayName = n.GetStringValue(); } },
                {"thumbnailUrl", (o,n) => { (o as PersonInterest).ThumbnailUrl = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as PersonInterest).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfPrimitiveValues<string>("collaborationTags", CollaborationTags);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
