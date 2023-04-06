using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SitePage : BaseItem, IParsable {
        /// <summary>Indicates the layout of the content in a given SharePoint page, including horizontal sections and vertical section</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CanvasLayout? CanvasLayout {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CanvasLayout?>("canvasLayout"); }
            set { BackingStore?.Set("canvasLayout", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CanvasLayout CanvasLayout {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CanvasLayout>("canvasLayout"); }
            set { BackingStore?.Set("canvasLayout", value); }
        }
#endif
        /// <summary>Inherited from baseItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentTypeInfo? ContentType {
            get { return BackingStore?.Get<ContentTypeInfo?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#nullable restore
#else
        public ContentTypeInfo ContentType {
            get { return BackingStore?.Get<ContentTypeInfo>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#endif
        /// <summary>The name of the page layout of the page. The possible values are: microsoftReserved, article, home, unknownFutureValue.</summary>
        public PageLayoutType? PageLayout {
            get { return BackingStore?.Get<PageLayoutType?>("pageLayout"); }
            set { BackingStore?.Set("pageLayout", value); }
        }
        /// <summary>Indicates the promotion kind of the sitePage. The possible values are: microsoftReserved, page, newsPost, unknownFutureValue.</summary>
        public PagePromotionType? PromotionKind {
            get { return BackingStore?.Get<PagePromotionType?>("promotionKind"); }
            set { BackingStore?.Set("promotionKind", value); }
        }
        /// <summary>The publishing status and the MM.mm version of the page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicationFacet? PublishingState {
            get { return BackingStore?.Get<PublicationFacet?>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
#nullable restore
#else
        public PublicationFacet PublishingState {
            get { return BackingStore?.Get<PublicationFacet>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
#endif
        /// <summary>Reactions information for the page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ReactionsFacet? Reactions {
            get { return BackingStore?.Get<ReactionsFacet?>("reactions"); }
            set { BackingStore?.Set("reactions", value); }
        }
#nullable restore
#else
        public ReactionsFacet Reactions {
            get { return BackingStore?.Get<ReactionsFacet>("reactions"); }
            set { BackingStore?.Set("reactions", value); }
        }
#endif
        /// <summary>Determines whether or not to show comments at the bottom of the page.</summary>
        public bool? ShowComments {
            get { return BackingStore?.Get<bool?>("showComments"); }
            set { BackingStore?.Set("showComments", value); }
        }
        /// <summary>Determines whether or not to show recommended pages at the bottom of the page.</summary>
        public bool? ShowRecommendedPages {
            get { return BackingStore?.Get<bool?>("showRecommendedPages"); }
            set { BackingStore?.Set("showRecommendedPages", value); }
        }
        /// <summary>Url of the sitePage&apos;s thumbnail image</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailWebUrl {
            get { return BackingStore?.Get<string?>("thumbnailWebUrl"); }
            set { BackingStore?.Set("thumbnailWebUrl", value); }
        }
#nullable restore
#else
        public string ThumbnailWebUrl {
            get { return BackingStore?.Get<string>("thumbnailWebUrl"); }
            set { BackingStore?.Set("thumbnailWebUrl", value); }
        }
#endif
        /// <summary>Title of the sitePage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>Title area on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TitleArea? TitleArea {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TitleArea?>("titleArea"); }
            set { BackingStore?.Set("titleArea", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TitleArea TitleArea {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TitleArea>("titleArea"); }
            set { BackingStore?.Set("titleArea", value); }
        }
#endif
        /// <summary>Collection of webparts on the SharePoint page</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WebPart>? WebParts {
            get { return BackingStore?.Get<List<WebPart>?>("webParts"); }
            set { BackingStore?.Set("webParts", value); }
        }
#nullable restore
#else
        public List<WebPart> WebParts {
            get { return BackingStore?.Get<List<WebPart>>("webParts"); }
            set { BackingStore?.Set("webParts", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new sitePage and sets the default values.
        /// </summary>
        public SitePage() : base() {
            OdataType = "#microsoft.graph.sitePage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SitePage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SitePage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"canvasLayout", n => { CanvasLayout = n.GetObjectValue<Microsoft.Graph.Beta.Models.CanvasLayout>(Microsoft.Graph.Beta.Models.CanvasLayout.CreateFromDiscriminatorValue); } },
                {"contentType", n => { ContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"pageLayout", n => { PageLayout = n.GetEnumValue<PageLayoutType>(); } },
                {"promotionKind", n => { PromotionKind = n.GetEnumValue<PagePromotionType>(); } },
                {"publishingState", n => { PublishingState = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"reactions", n => { Reactions = n.GetObjectValue<ReactionsFacet>(ReactionsFacet.CreateFromDiscriminatorValue); } },
                {"showComments", n => { ShowComments = n.GetBoolValue(); } },
                {"showRecommendedPages", n => { ShowRecommendedPages = n.GetBoolValue(); } },
                {"thumbnailWebUrl", n => { ThumbnailWebUrl = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"titleArea", n => { TitleArea = n.GetObjectValue<Microsoft.Graph.Beta.Models.TitleArea>(Microsoft.Graph.Beta.Models.TitleArea.CreateFromDiscriminatorValue); } },
                {"webParts", n => { WebParts = n.GetCollectionOfObjectValues<WebPart>(WebPart.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CanvasLayout>("canvasLayout", CanvasLayout);
            writer.WriteObjectValue<ContentTypeInfo>("contentType", ContentType);
            writer.WriteEnumValue<PageLayoutType>("pageLayout", PageLayout);
            writer.WriteEnumValue<PagePromotionType>("promotionKind", PromotionKind);
            writer.WriteObjectValue<PublicationFacet>("publishingState", PublishingState);
            writer.WriteObjectValue<ReactionsFacet>("reactions", Reactions);
            writer.WriteBoolValue("showComments", ShowComments);
            writer.WriteBoolValue("showRecommendedPages", ShowRecommendedPages);
            writer.WriteStringValue("thumbnailWebUrl", ThumbnailWebUrl);
            writer.WriteStringValue("title", Title);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TitleArea>("titleArea", TitleArea);
            writer.WriteCollectionOfObjectValues<WebPart>("webParts", WebParts);
        }
    }
}
