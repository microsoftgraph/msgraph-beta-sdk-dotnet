using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SitePage : BaseItem, IParsable {
        /// <summary>The content type of the page.</summary>
        public ContentTypeInfo ContentType { get; set; }
        public string PageLayoutType { get; set; }
        public PublicationFacet PublishingState { get; set; }
        public string Title { get; set; }
        public List<WebPart> WebParts { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contentType", (o,n) => { (o as SitePage).ContentType = n.GetObjectValue<ContentTypeInfo>(); } },
                {"pageLayoutType", (o,n) => { (o as SitePage).PageLayoutType = n.GetStringValue(); } },
                {"publishingState", (o,n) => { (o as SitePage).PublishingState = n.GetObjectValue<PublicationFacet>(); } },
                {"title", (o,n) => { (o as SitePage).Title = n.GetStringValue(); } },
                {"webParts", (o,n) => { (o as SitePage).WebParts = n.GetCollectionOfObjectValues<WebPart>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ContentTypeInfo>("contentType", ContentType);
            writer.WriteStringValue("pageLayoutType", PageLayoutType);
            writer.WriteObjectValue<PublicationFacet>("publishingState", PublishingState);
            writer.WriteStringValue("title", Title);
            writer.WriteCollectionOfObjectValues<WebPart>("webParts", WebParts);
        }
    }
}
