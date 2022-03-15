using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class ItemPublication : ItemFacet, IParsable {
        /// <summary>Description of the publication.</summary>
        public string Description { get; set; }
        /// <summary>Title of the publication.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date that the publication was published.</summary>
        public Date? PublishedDate { get; set; }
        /// <summary>Publication or publisher for the publication.</summary>
        public string Publisher { get; set; }
        /// <summary>URL referencing a thumbnail of the publication.</summary>
        public string ThumbnailUrl { get; set; }
        /// <summary>URL referencing the publication.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemPublication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemPublication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as ItemPublication).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ItemPublication).DisplayName = n.GetStringValue(); } },
                {"publishedDate", (o,n) => { (o as ItemPublication).PublishedDate = n.GetDateValue(); } },
                {"publisher", (o,n) => { (o as ItemPublication).Publisher = n.GetStringValue(); } },
                {"thumbnailUrl", (o,n) => { (o as ItemPublication).ThumbnailUrl = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as ItemPublication).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("publishedDate", PublishedDate);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
