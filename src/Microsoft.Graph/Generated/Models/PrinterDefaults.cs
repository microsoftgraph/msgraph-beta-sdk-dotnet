using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrinterDefaults : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default color mode to use when printing the document. Valid values are described in the following table.</summary>
        public PrintColorMode? ColorMode {
            get { return BackingStore?.Get<PrintColorMode?>(nameof(ColorMode)); }
            set { BackingStore?.Set(nameof(ColorMode), value); }
        }
        /// <summary>The default content (MIME) type to use when processing documents.</summary>
        public string ContentType {
            get { return BackingStore?.Get<string>(nameof(ContentType)); }
            set { BackingStore?.Set(nameof(ContentType), value); }
        }
        /// <summary>The default number of copies printed per job.</summary>
        public int? CopiesPerJob {
            get { return BackingStore?.Get<int?>(nameof(CopiesPerJob)); }
            set { BackingStore?.Set(nameof(CopiesPerJob), value); }
        }
        /// <summary>The documentMimeType property</summary>
        public string DocumentMimeType {
            get { return BackingStore?.Get<string>(nameof(DocumentMimeType)); }
            set { BackingStore?.Set(nameof(DocumentMimeType), value); }
        }
        /// <summary>The default resolution in DPI to use when printing the job.</summary>
        public int? Dpi {
            get { return BackingStore?.Get<int?>(nameof(Dpi)); }
            set { BackingStore?.Set(nameof(Dpi), value); }
        }
        /// <summary>The duplexConfiguration property</summary>
        public PrintDuplexConfiguration? DuplexConfiguration {
            get { return BackingStore?.Get<PrintDuplexConfiguration?>(nameof(DuplexConfiguration)); }
            set { BackingStore?.Set(nameof(DuplexConfiguration), value); }
        }
        /// <summary>The default duplex (double-sided) configuration to use when printing a document. Valid values are described in the following table.</summary>
        public PrintDuplexMode? DuplexMode {
            get { return BackingStore?.Get<PrintDuplexMode?>(nameof(DuplexMode)); }
            set { BackingStore?.Set(nameof(DuplexMode), value); }
        }
        /// <summary>The default set of finishings to apply to print jobs. Valid values are described in the following table.</summary>
        public List<string> Finishings {
            get { return BackingStore?.Get<List<string>>(nameof(Finishings)); }
            set { BackingStore?.Set(nameof(Finishings), value); }
        }
        /// <summary>The default fitPdfToPage setting. True to fit each page of a PDF document to a physical sheet of media; false to let the printer decide how to lay out impressions.</summary>
        public bool? FitPdfToPage {
            get { return BackingStore?.Get<bool?>(nameof(FitPdfToPage)); }
            set { BackingStore?.Set(nameof(FitPdfToPage), value); }
        }
        /// <summary>The default input bin that serves as the paper source.</summary>
        public string InputBin {
            get { return BackingStore?.Get<string>(nameof(InputBin)); }
            set { BackingStore?.Set(nameof(InputBin), value); }
        }
        /// <summary>The default media (such as paper) color to print the document on.</summary>
        public string MediaColor {
            get { return BackingStore?.Get<string>(nameof(MediaColor)); }
            set { BackingStore?.Set(nameof(MediaColor), value); }
        }
        /// <summary>The default media size to use. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.</summary>
        public string MediaSize {
            get { return BackingStore?.Get<string>(nameof(MediaSize)); }
            set { BackingStore?.Set(nameof(MediaSize), value); }
        }
        /// <summary>The default media (such as paper) type to print the document on.</summary>
        public string MediaType {
            get { return BackingStore?.Get<string>(nameof(MediaType)); }
            set { BackingStore?.Set(nameof(MediaType), value); }
        }
        /// <summary>The default direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.</summary>
        public PrintMultipageLayout? MultipageLayout {
            get { return BackingStore?.Get<PrintMultipageLayout?>(nameof(MultipageLayout)); }
            set { BackingStore?.Set(nameof(MultipageLayout), value); }
        }
        /// <summary>The default orientation to use when printing the document. Valid values are described in the following table.</summary>
        public PrintOrientation? Orientation {
            get { return BackingStore?.Get<PrintOrientation?>(nameof(Orientation)); }
            set { BackingStore?.Set(nameof(Orientation), value); }
        }
        /// <summary>The default output bin to place completed prints into. See the printer&apos;s capabilities for a list of supported output bins.</summary>
        public string OutputBin {
            get { return BackingStore?.Get<string>(nameof(OutputBin)); }
            set { BackingStore?.Set(nameof(OutputBin), value); }
        }
        /// <summary>The default number of document pages to print on each sheet.</summary>
        public int? PagesPerSheet {
            get { return BackingStore?.Get<int?>(nameof(PagesPerSheet)); }
            set { BackingStore?.Set(nameof(PagesPerSheet), value); }
        }
        /// <summary>The pdfFitToPage property</summary>
        public bool? PdfFitToPage {
            get { return BackingStore?.Get<bool?>(nameof(PdfFitToPage)); }
            set { BackingStore?.Set(nameof(PdfFitToPage), value); }
        }
        /// <summary>The presentationDirection property</summary>
        public PrintPresentationDirection? PresentationDirection {
            get { return BackingStore?.Get<PrintPresentationDirection?>(nameof(PresentationDirection)); }
            set { BackingStore?.Set(nameof(PresentationDirection), value); }
        }
        /// <summary>The printColorConfiguration property</summary>
        public Microsoft.Graph.Beta.Models.PrintColorConfiguration? PrintColorConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintColorConfiguration?>(nameof(PrintColorConfiguration)); }
            set { BackingStore?.Set(nameof(PrintColorConfiguration), value); }
        }
        /// <summary>The printQuality property</summary>
        public Microsoft.Graph.Beta.Models.PrintQuality? PrintQuality {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintQuality?>(nameof(PrintQuality)); }
            set { BackingStore?.Set(nameof(PrintQuality), value); }
        }
        /// <summary>The default quality to use when printing the document. Valid values are described in the following table.</summary>
        public Microsoft.Graph.Beta.Models.PrintQuality? Quality {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintQuality?>(nameof(Quality)); }
            set { BackingStore?.Set(nameof(Quality), value); }
        }
        /// <summary>Specifies how the printer scales the document data to fit the requested media. Valid values are described in the following table.</summary>
        public PrintScaling? Scaling {
            get { return BackingStore?.Get<PrintScaling?>(nameof(Scaling)); }
            set { BackingStore?.Set(nameof(Scaling), value); }
        }
        /// <summary>
        /// Instantiates a new printerDefaults and sets the default values.
        /// </summary>
        public PrinterDefaults() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrinterDefaults CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterDefaults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"colorMode", n => { ColorMode = n.GetEnumValue<PrintColorMode>(); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
                {"copiesPerJob", n => { CopiesPerJob = n.GetIntValue(); } },
                {"documentMimeType", n => { DocumentMimeType = n.GetStringValue(); } },
                {"dpi", n => { Dpi = n.GetIntValue(); } },
                {"duplexConfiguration", n => { DuplexConfiguration = n.GetEnumValue<PrintDuplexConfiguration>(); } },
                {"duplexMode", n => { DuplexMode = n.GetEnumValue<PrintDuplexMode>(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                {"inputBin", n => { InputBin = n.GetStringValue(); } },
                {"mediaColor", n => { MediaColor = n.GetStringValue(); } },
                {"mediaSize", n => { MediaSize = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"multipageLayout", n => { MultipageLayout = n.GetEnumValue<PrintMultipageLayout>(); } },
                {"orientation", n => { Orientation = n.GetEnumValue<PrintOrientation>(); } },
                {"outputBin", n => { OutputBin = n.GetStringValue(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetIntValue(); } },
                {"pdfFitToPage", n => { PdfFitToPage = n.GetBoolValue(); } },
                {"presentationDirection", n => { PresentationDirection = n.GetEnumValue<PrintPresentationDirection>(); } },
                {"printColorConfiguration", n => { PrintColorConfiguration = n.GetEnumValue<PrintColorConfiguration>(); } },
                {"printQuality", n => { PrintQuality = n.GetEnumValue<PrintQuality>(); } },
                {"quality", n => { Quality = n.GetEnumValue<PrintQuality>(); } },
                {"scaling", n => { Scaling = n.GetEnumValue<PrintScaling>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PrintColorMode>("colorMode", ColorMode);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteIntValue("copiesPerJob", CopiesPerJob);
            writer.WriteStringValue("documentMimeType", DocumentMimeType);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteEnumValue<PrintDuplexConfiguration>("duplexConfiguration", DuplexConfiguration);
            writer.WriteEnumValue<PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteCollectionOfPrimitiveValues<string>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteStringValue("mediaColor", MediaColor);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteEnumValue<PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteEnumValue<PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteBoolValue("pdfFitToPage", PdfFitToPage);
            writer.WriteEnumValue<PrintPresentationDirection>("presentationDirection", PresentationDirection);
            writer.WriteEnumValue<PrintColorConfiguration>("printColorConfiguration", PrintColorConfiguration);
            writer.WriteEnumValue<PrintQuality>("printQuality", PrintQuality);
            writer.WriteEnumValue<PrintQuality>("quality", Quality);
            writer.WriteEnumValue<PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
