using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Search;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SearchEntity : Entity, IParsable {
        /// <summary>Administrative answer in Microsoft Search results to define common acronyms in a organization.</summary>
        public List<Acronym> Acronyms { get; set; }
        /// <summary>Administrative answer in Microsoft Search results for common search queries in an organization.</summary>
        public List<Bookmark> Bookmarks { get; set; }
        /// <summary>Administrative answer in Microsoft Search results which provide answers for specific search keywords in an organization.</summary>
        public List<Qna> Qnas { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SearchEntity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchEntity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acronyms", (o,n) => { (o as SearchEntity).Acronyms = n.GetCollectionOfObjectValues<Acronym>(Acronym.CreateFromDiscriminatorValue).ToList(); } },
                {"bookmarks", (o,n) => { (o as SearchEntity).Bookmarks = n.GetCollectionOfObjectValues<Bookmark>(Bookmark.CreateFromDiscriminatorValue).ToList(); } },
                {"qnas", (o,n) => { (o as SearchEntity).Qnas = n.GetCollectionOfObjectValues<Qna>(Qna.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Acronym>("acronyms", Acronyms);
            writer.WriteCollectionOfObjectValues<Bookmark>("bookmarks", Bookmarks);
            writer.WriteCollectionOfObjectValues<Qna>("qnas", Qnas);
        }
    }
}
