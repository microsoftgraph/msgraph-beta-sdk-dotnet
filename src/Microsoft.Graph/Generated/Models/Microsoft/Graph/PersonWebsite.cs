using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PersonWebsite : ItemFacet, IParsable {
        /// <summary>Contains categories a user has associated with the website (for example, personal, recipes).</summary>
        public List<string> Categories { get; set; }
        /// <summary>Contains a description of the website.</summary>
        public string Description { get; set; }
        /// <summary>Contains a friendly name for the website.</summary>
        public string DisplayName { get; set; }
        public string ThumbnailUrl { get; set; }
        /// <summary>Contains a link to the website itself.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as PersonWebsite).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", (o,n) => { (o as PersonWebsite).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PersonWebsite).DisplayName = n.GetStringValue(); } },
                {"thumbnailUrl", (o,n) => { (o as PersonWebsite).ThumbnailUrl = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as PersonWebsite).WebUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
