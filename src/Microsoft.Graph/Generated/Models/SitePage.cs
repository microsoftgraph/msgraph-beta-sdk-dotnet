using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class SitePage : BaseItem, IParsable {
        /// <summary>The content type of the page.</summary>
        public ContentTypeInfo ContentType {
            get { return BackingStore?.Get<ContentTypeInfo>(nameof(ContentType)); }
            set { BackingStore?.Set(nameof(ContentType), value); }
        }
        /// <summary>The pageLayoutType property</summary>
        public string PageLayoutType {
            get { return BackingStore?.Get<string>(nameof(PageLayoutType)); }
            set { BackingStore?.Set(nameof(PageLayoutType), value); }
        }
        /// <summary>The publishingState property</summary>
        public PublicationFacet PublishingState {
            get { return BackingStore?.Get<PublicationFacet>(nameof(PublishingState)); }
            set { BackingStore?.Set(nameof(PublishingState), value); }
        }
        /// <summary>The title property</summary>
        public string Title {
            get { return BackingStore?.Get<string>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
        }
        /// <summary>The webParts property</summary>
        public List<WebPart> WebParts {
            get { return BackingStore?.Get<List<WebPart>>(nameof(WebParts)); }
            set { BackingStore?.Set(nameof(WebParts), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentType", n => { ContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"pageLayoutType", n => { PageLayoutType = n.GetStringValue(); } },
                {"publishingState", n => { PublishingState = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"webParts", n => { WebParts = n.GetCollectionOfObjectValues<WebPart>(WebPart.CreateFromDiscriminatorValue).ToList(); } },
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
