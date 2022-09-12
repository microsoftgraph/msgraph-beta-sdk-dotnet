using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class SitePage : BaseItem, IParsable {
        /// <summary>The content type of the page.</summary>
        public ContentTypeInfo ContentType {
            get { return BackingStore?.Get<ContentTypeInfo>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
        /// <summary>The pageLayoutType property</summary>
        public string PageLayoutType {
            get { return BackingStore?.Get<string>("pageLayoutType"); }
            set { BackingStore?.Set("pageLayoutType", value); }
        }
        /// <summary>The publishingState property</summary>
        public PublicationFacet PublishingState {
            get { return BackingStore?.Get<PublicationFacet>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
        /// <summary>The title property</summary>
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
        /// <summary>The webParts property</summary>
        public List<WebPart> WebParts {
            get { return BackingStore?.Get<List<WebPart>>("webParts"); }
            set { BackingStore?.Set("webParts", value); }
        }
        /// <summary>
        /// Instantiates a new sitePage and sets the default values.
        /// </summary>
        public SitePage() : base() {
            OdataType = "#microsoft.graph.sitePage";
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
                {"webParts", n => { WebParts = n.GetCollectionOfObjectValues<WebPart>(WebPart.CreateFromDiscriminatorValue)?.ToList(); } },
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
