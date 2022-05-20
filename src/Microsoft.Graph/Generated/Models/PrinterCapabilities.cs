using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrinterCapabilities : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A list of supported bottom margins(in microns) for the printer.</summary>
        public List<int?> BottomMargins {
            get { return BackingStore?.Get<List<int?>>(nameof(BottomMargins)); }
            set { BackingStore?.Set(nameof(BottomMargins), value); }
        }
        /// <summary>True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.</summary>
        public bool? Collation {
            get { return BackingStore?.Get<bool?>(nameof(Collation)); }
            set { BackingStore?.Set(nameof(Collation), value); }
        }
        /// <summary>The color modes supported by the printer. Valid values are described in the following table.</summary>
        public List<string> ColorModes {
            get { return BackingStore?.Get<List<string>>(nameof(ColorModes)); }
            set { BackingStore?.Set(nameof(ColorModes), value); }
        }
        /// <summary>A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.</summary>
        public List<string> ContentTypes {
            get { return BackingStore?.Get<List<string>>(nameof(ContentTypes)); }
            set { BackingStore?.Set(nameof(ContentTypes), value); }
        }
        /// <summary>The range of copies per job supported by the printer.</summary>
        public IntegerRange CopiesPerJob {
            get { return BackingStore?.Get<IntegerRange>(nameof(CopiesPerJob)); }
            set { BackingStore?.Set(nameof(CopiesPerJob), value); }
        }
        /// <summary>The list of print resolutions in DPI that are supported by the printer.</summary>
        public List<int?> Dpis {
            get { return BackingStore?.Get<List<int?>>(nameof(Dpis)); }
            set { BackingStore?.Set(nameof(Dpis), value); }
        }
        /// <summary>The list of duplex modes that are supported by the printer. Valid values are described in the following table.</summary>
        public List<string> DuplexModes {
            get { return BackingStore?.Get<List<string>>(nameof(DuplexModes)); }
            set { BackingStore?.Set(nameof(DuplexModes), value); }
        }
        /// <summary>The feedDirections property</summary>
        public List<string> FeedDirections {
            get { return BackingStore?.Get<List<string>>(nameof(FeedDirections)); }
            set { BackingStore?.Set(nameof(FeedDirections), value); }
        }
        /// <summary>The list of feed orientations that are supported by the printer.</summary>
        public List<string> FeedOrientations {
            get { return BackingStore?.Get<List<string>>(nameof(FeedOrientations)); }
            set { BackingStore?.Set(nameof(FeedOrientations), value); }
        }
        /// <summary>Finishing processes the printer supports for a printed document.</summary>
        public List<string> Finishings {
            get { return BackingStore?.Get<List<string>>(nameof(Finishings)); }
            set { BackingStore?.Set(nameof(Finishings), value); }
        }
        /// <summary>Supported input bins for the printer.</summary>
        public List<string> InputBins {
            get { return BackingStore?.Get<List<string>>(nameof(InputBins)); }
            set { BackingStore?.Set(nameof(InputBins), value); }
        }
        /// <summary>True if color printing is supported by the printer; false otherwise. Read-only.</summary>
        public bool? IsColorPrintingSupported {
            get { return BackingStore?.Get<bool?>(nameof(IsColorPrintingSupported)); }
            set { BackingStore?.Set(nameof(IsColorPrintingSupported), value); }
        }
        /// <summary>True if the printer supports printing by page ranges; false otherwise.</summary>
        public bool? IsPageRangeSupported {
            get { return BackingStore?.Get<bool?>(nameof(IsPageRangeSupported)); }
            set { BackingStore?.Set(nameof(IsPageRangeSupported), value); }
        }
        /// <summary>A list of supported left margins(in microns) for the printer.</summary>
        public List<int?> LeftMargins {
            get { return BackingStore?.Get<List<int?>>(nameof(LeftMargins)); }
            set { BackingStore?.Set(nameof(LeftMargins), value); }
        }
        /// <summary>The media (i.e., paper) colors supported by the printer.</summary>
        public List<string> MediaColors {
            get { return BackingStore?.Get<List<string>>(nameof(MediaColors)); }
            set { BackingStore?.Set(nameof(MediaColors), value); }
        }
        /// <summary>The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.</summary>
        public List<string> MediaSizes {
            get { return BackingStore?.Get<List<string>>(nameof(MediaSizes)); }
            set { BackingStore?.Set(nameof(MediaSizes), value); }
        }
        /// <summary>The media types supported by the printer.</summary>
        public List<string> MediaTypes {
            get { return BackingStore?.Get<List<string>>(nameof(MediaTypes)); }
            set { BackingStore?.Set(nameof(MediaTypes), value); }
        }
        /// <summary>The presentation directions supported by the printer. Supported values are described in the following table.</summary>
        public List<string> MultipageLayouts {
            get { return BackingStore?.Get<List<string>>(nameof(MultipageLayouts)); }
            set { BackingStore?.Set(nameof(MultipageLayouts), value); }
        }
        /// <summary>The print orientations supported by the printer. Valid values are described in the following table.</summary>
        public List<string> Orientations {
            get { return BackingStore?.Get<List<string>>(nameof(Orientations)); }
            set { BackingStore?.Set(nameof(Orientations), value); }
        }
        /// <summary>The printer&apos;s supported output bins (trays).</summary>
        public List<string> OutputBins {
            get { return BackingStore?.Get<List<string>>(nameof(OutputBins)); }
            set { BackingStore?.Set(nameof(OutputBins), value); }
        }
        /// <summary>Supported number of Input Pages to impose upon a single Impression.</summary>
        public List<int?> PagesPerSheet {
            get { return BackingStore?.Get<List<int?>>(nameof(PagesPerSheet)); }
            set { BackingStore?.Set(nameof(PagesPerSheet), value); }
        }
        /// <summary>The print qualities supported by the printer.</summary>
        public List<string> Qualities {
            get { return BackingStore?.Get<List<string>>(nameof(Qualities)); }
            set { BackingStore?.Set(nameof(Qualities), value); }
        }
        /// <summary>A list of supported right margins(in microns) for the printer.</summary>
        public List<int?> RightMargins {
            get { return BackingStore?.Get<List<int?>>(nameof(RightMargins)); }
            set { BackingStore?.Set(nameof(RightMargins), value); }
        }
        /// <summary>Supported print scalings.</summary>
        public List<string> Scalings {
            get { return BackingStore?.Get<List<string>>(nameof(Scalings)); }
            set { BackingStore?.Set(nameof(Scalings), value); }
        }
        /// <summary>The supportedColorConfigurations property</summary>
        public List<string> SupportedColorConfigurations {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedColorConfigurations)); }
            set { BackingStore?.Set(nameof(SupportedColorConfigurations), value); }
        }
        /// <summary>The supportedCopiesPerJob property</summary>
        public IntegerRange SupportedCopiesPerJob {
            get { return BackingStore?.Get<IntegerRange>(nameof(SupportedCopiesPerJob)); }
            set { BackingStore?.Set(nameof(SupportedCopiesPerJob), value); }
        }
        /// <summary>The supportedDocumentMimeTypes property</summary>
        public List<string> SupportedDocumentMimeTypes {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedDocumentMimeTypes)); }
            set { BackingStore?.Set(nameof(SupportedDocumentMimeTypes), value); }
        }
        /// <summary>The supportedDuplexConfigurations property</summary>
        public List<string> SupportedDuplexConfigurations {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedDuplexConfigurations)); }
            set { BackingStore?.Set(nameof(SupportedDuplexConfigurations), value); }
        }
        /// <summary>The supportedFinishings property</summary>
        public List<string> SupportedFinishings {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedFinishings)); }
            set { BackingStore?.Set(nameof(SupportedFinishings), value); }
        }
        /// <summary>The supportedMediaColors property</summary>
        public List<string> SupportedMediaColors {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedMediaColors)); }
            set { BackingStore?.Set(nameof(SupportedMediaColors), value); }
        }
        /// <summary>The supportedMediaSizes property</summary>
        public List<string> SupportedMediaSizes {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedMediaSizes)); }
            set { BackingStore?.Set(nameof(SupportedMediaSizes), value); }
        }
        /// <summary>The supportedMediaTypes property</summary>
        public List<string> SupportedMediaTypes {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedMediaTypes)); }
            set { BackingStore?.Set(nameof(SupportedMediaTypes), value); }
        }
        /// <summary>The supportedOrientations property</summary>
        public List<string> SupportedOrientations {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedOrientations)); }
            set { BackingStore?.Set(nameof(SupportedOrientations), value); }
        }
        /// <summary>The supportedOutputBins property</summary>
        public List<string> SupportedOutputBins {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedOutputBins)); }
            set { BackingStore?.Set(nameof(SupportedOutputBins), value); }
        }
        /// <summary>The supportedPagesPerSheet property</summary>
        public IntegerRange SupportedPagesPerSheet {
            get { return BackingStore?.Get<IntegerRange>(nameof(SupportedPagesPerSheet)); }
            set { BackingStore?.Set(nameof(SupportedPagesPerSheet), value); }
        }
        /// <summary>The supportedPresentationDirections property</summary>
        public List<string> SupportedPresentationDirections {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedPresentationDirections)); }
            set { BackingStore?.Set(nameof(SupportedPresentationDirections), value); }
        }
        /// <summary>The supportedPrintQualities property</summary>
        public List<string> SupportedPrintQualities {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedPrintQualities)); }
            set { BackingStore?.Set(nameof(SupportedPrintQualities), value); }
        }
        /// <summary>True if the printer supports scaling PDF pages to match the print media size; false otherwise.</summary>
        public bool? SupportsFitPdfToPage {
            get { return BackingStore?.Get<bool?>(nameof(SupportsFitPdfToPage)); }
            set { BackingStore?.Set(nameof(SupportsFitPdfToPage), value); }
        }
        /// <summary>A list of supported top margins(in microns) for the printer.</summary>
        public List<int?> TopMargins {
            get { return BackingStore?.Get<List<int?>>(nameof(TopMargins)); }
            set { BackingStore?.Set(nameof(TopMargins), value); }
        }
        /// <summary>
        /// Instantiates a new printerCapabilities and sets the default values.
        /// </summary>
        public PrinterCapabilities() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrinterCapabilities CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bottomMargins", n => { BottomMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"collation", n => { Collation = n.GetBoolValue(); } },
                {"colorModes", n => { ColorModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"copiesPerJob", n => { CopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"dpis", n => { Dpis = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"duplexModes", n => { DuplexModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"feedDirections", n => { FeedDirections = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"feedOrientations", n => { FeedOrientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inputBins", n => { InputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isColorPrintingSupported", n => { IsColorPrintingSupported = n.GetBoolValue(); } },
                {"isPageRangeSupported", n => { IsPageRangeSupported = n.GetBoolValue(); } },
                {"leftMargins", n => { LeftMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"mediaColors", n => { MediaColors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaSizes", n => { MediaSizes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaTypes", n => { MediaTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"multipageLayouts", n => { MultipageLayouts = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"orientations", n => { Orientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"outputBins", n => { OutputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"qualities", n => { Qualities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rightMargins", n => { RightMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"scalings", n => { Scalings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedColorConfigurations", n => { SupportedColorConfigurations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedCopiesPerJob", n => { SupportedCopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"supportedDocumentMimeTypes", n => { SupportedDocumentMimeTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedDuplexConfigurations", n => { SupportedDuplexConfigurations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedFinishings", n => { SupportedFinishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedMediaColors", n => { SupportedMediaColors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedMediaSizes", n => { SupportedMediaSizes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedMediaTypes", n => { SupportedMediaTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedOrientations", n => { SupportedOrientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedOutputBins", n => { SupportedOutputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedPagesPerSheet", n => { SupportedPagesPerSheet = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"supportedPresentationDirections", n => { SupportedPresentationDirections = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedPrintQualities", n => { SupportedPrintQualities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportsFitPdfToPage", n => { SupportsFitPdfToPage = n.GetBoolValue(); } },
                {"topMargins", n => { TopMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("bottomMargins", BottomMargins);
            writer.WriteBoolValue("collation", Collation);
            writer.WriteCollectionOfPrimitiveValues<string>("colorModes", ColorModes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentTypes", ContentTypes);
            writer.WriteObjectValue<IntegerRange>("copiesPerJob", CopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<int?>("dpis", Dpis);
            writer.WriteCollectionOfPrimitiveValues<string>("duplexModes", DuplexModes);
            writer.WriteCollectionOfPrimitiveValues<string>("feedDirections", FeedDirections);
            writer.WriteCollectionOfPrimitiveValues<string>("feedOrientations", FeedOrientations);
            writer.WriteCollectionOfPrimitiveValues<string>("finishings", Finishings);
            writer.WriteCollectionOfPrimitiveValues<string>("inputBins", InputBins);
            writer.WriteBoolValue("isColorPrintingSupported", IsColorPrintingSupported);
            writer.WriteBoolValue("isPageRangeSupported", IsPageRangeSupported);
            writer.WriteCollectionOfPrimitiveValues<int?>("leftMargins", LeftMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaColors", MediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaSizes", MediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaTypes", MediaTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("multipageLayouts", MultipageLayouts);
            writer.WriteCollectionOfPrimitiveValues<string>("orientations", Orientations);
            writer.WriteCollectionOfPrimitiveValues<string>("outputBins", OutputBins);
            writer.WriteCollectionOfPrimitiveValues<int?>("pagesPerSheet", PagesPerSheet);
            writer.WriteCollectionOfPrimitiveValues<string>("qualities", Qualities);
            writer.WriteCollectionOfPrimitiveValues<int?>("rightMargins", RightMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("scalings", Scalings);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedColorConfigurations", SupportedColorConfigurations);
            writer.WriteObjectValue<IntegerRange>("supportedCopiesPerJob", SupportedCopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDocumentMimeTypes", SupportedDocumentMimeTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDuplexConfigurations", SupportedDuplexConfigurations);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedFinishings", SupportedFinishings);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedMediaColors", SupportedMediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedMediaSizes", SupportedMediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedMediaTypes", SupportedMediaTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedOrientations", SupportedOrientations);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedOutputBins", SupportedOutputBins);
            writer.WriteObjectValue<IntegerRange>("supportedPagesPerSheet", SupportedPagesPerSheet);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedPresentationDirections", SupportedPresentationDirections);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedPrintQualities", SupportedPrintQualities);
            writer.WriteBoolValue("supportsFitPdfToPage", SupportsFitPdfToPage);
            writer.WriteCollectionOfPrimitiveValues<int?>("topMargins", TopMargins);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
