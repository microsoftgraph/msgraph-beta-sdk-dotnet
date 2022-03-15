using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class SitePage : BaseItem, IParsable {
        /// <summary>The content type of the page.</summary>
        public ContentTypeInfo ContentType { get; set; }
        public string PageLayoutType { get; set; }
        public PublicationFacet PublishingState { get; set; }
        public string Title { get; set; }
        public List<WebPart> WebParts { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SitePage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SitePage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contentType", (o,n) => { (o as SitePage).ContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"pageLayoutType", (o,n) => { (o as SitePage).PageLayoutType = n.GetStringValue(); } },
                {"publishingState", (o,n) => { (o as SitePage).PublishingState = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"title", (o,n) => { (o as SitePage).Title = n.GetStringValue(); } },
                {"webParts", (o,n) => { (o as SitePage).WebParts = n.GetCollectionOfObjectValues<WebPart>(WebPart.CreateFromDiscriminatorValue).ToList(); } },
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
