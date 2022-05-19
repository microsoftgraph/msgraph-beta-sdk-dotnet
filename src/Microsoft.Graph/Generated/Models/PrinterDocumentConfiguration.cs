using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrinterDocumentConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The collate property</summary>
        public bool? Collate {
            get { return BackingStore?.Get<bool?>(nameof(Collate)); }
            set { BackingStore?.Set(nameof(Collate), value); }
        }
        /// <summary>The colorMode property</summary>
        public PrintColorMode? ColorMode {
            get { return BackingStore?.Get<PrintColorMode?>(nameof(ColorMode)); }
            set { BackingStore?.Set(nameof(ColorMode), value); }
        }
        /// <summary>The copies property</summary>
        public int? Copies {
            get { return BackingStore?.Get<int?>(nameof(Copies)); }
            set { BackingStore?.Set(nameof(Copies), value); }
        }
        /// <summary>The dpi property</summary>
        public int? Dpi {
            get { return BackingStore?.Get<int?>(nameof(Dpi)); }
            set { BackingStore?.Set(nameof(Dpi), value); }
        }
        /// <summary>The duplexMode property</summary>
        public PrintDuplexMode? DuplexMode {
            get { return BackingStore?.Get<PrintDuplexMode?>(nameof(DuplexMode)); }
            set { BackingStore?.Set(nameof(DuplexMode), value); }
        }
        /// <summary>The feedDirection property</summary>
        public PrinterFeedDirection? FeedDirection {
            get { return BackingStore?.Get<PrinterFeedDirection?>(nameof(FeedDirection)); }
            set { BackingStore?.Set(nameof(FeedDirection), value); }
        }
        /// <summary>The feedOrientation property</summary>
        public PrinterFeedOrientation? FeedOrientation {
            get { return BackingStore?.Get<PrinterFeedOrientation?>(nameof(FeedOrientation)); }
            set { BackingStore?.Set(nameof(FeedOrientation), value); }
        }
        /// <summary>The finishings property</summary>
        public List<string> Finishings {
            get { return BackingStore?.Get<List<string>>(nameof(Finishings)); }
            set { BackingStore?.Set(nameof(Finishings), value); }
        }
        /// <summary>The fitPdfToPage property</summary>
        public bool? FitPdfToPage {
            get { return BackingStore?.Get<bool?>(nameof(FitPdfToPage)); }
            set { BackingStore?.Set(nameof(FitPdfToPage), value); }
        }
        /// <summary>The inputBin property</summary>
        public string InputBin {
            get { return BackingStore?.Get<string>(nameof(InputBin)); }
            set { BackingStore?.Set(nameof(InputBin), value); }
        }
        /// <summary>The margin property</summary>
        public PrintMargin Margin {
            get { return BackingStore?.Get<PrintMargin>(nameof(Margin)); }
            set { BackingStore?.Set(nameof(Margin), value); }
        }
        /// <summary>The mediaSize property</summary>
        public string MediaSize {
            get { return BackingStore?.Get<string>(nameof(MediaSize)); }
            set { BackingStore?.Set(nameof(MediaSize), value); }
        }
        /// <summary>The mediaType property</summary>
        public string MediaType {
            get { return BackingStore?.Get<string>(nameof(MediaType)); }
            set { BackingStore?.Set(nameof(MediaType), value); }
        }
        /// <summary>The multipageLayout property</summary>
        public PrintMultipageLayout? MultipageLayout {
            get { return BackingStore?.Get<PrintMultipageLayout?>(nameof(MultipageLayout)); }
            set { BackingStore?.Set(nameof(MultipageLayout), value); }
        }
        /// <summary>The orientation property</summary>
        public PrintOrientation? Orientation {
            get { return BackingStore?.Get<PrintOrientation?>(nameof(Orientation)); }
            set { BackingStore?.Set(nameof(Orientation), value); }
        }
        /// <summary>The outputBin property</summary>
        public string OutputBin {
            get { return BackingStore?.Get<string>(nameof(OutputBin)); }
            set { BackingStore?.Set(nameof(OutputBin), value); }
        }
        /// <summary>The pageRanges property</summary>
        public List<IntegerRange> PageRanges {
            get { return BackingStore?.Get<List<IntegerRange>>(nameof(PageRanges)); }
            set { BackingStore?.Set(nameof(PageRanges), value); }
        }
        /// <summary>The pagesPerSheet property</summary>
        public int? PagesPerSheet {
            get { return BackingStore?.Get<int?>(nameof(PagesPerSheet)); }
            set { BackingStore?.Set(nameof(PagesPerSheet), value); }
        }
        /// <summary>The quality property</summary>
        public PrintQuality? Quality {
            get { return BackingStore?.Get<PrintQuality?>(nameof(Quality)); }
            set { BackingStore?.Set(nameof(Quality), value); }
        }
        /// <summary>The scaling property</summary>
        public PrintScaling? Scaling {
            get { return BackingStore?.Get<PrintScaling?>(nameof(Scaling)); }
            set { BackingStore?.Set(nameof(Scaling), value); }
        }
        /// <summary>
        /// Instantiates a new printerDocumentConfiguration and sets the default values.
        /// </summary>
        public PrinterDocumentConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrinterDocumentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterDocumentConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"collate", n => { Collate = n.GetBoolValue(); } },
                {"colorMode", n => { ColorMode = n.GetEnumValue<PrintColorMode>(); } },
                {"copies", n => { Copies = n.GetIntValue(); } },
                {"dpi", n => { Dpi = n.GetIntValue(); } },
                {"duplexMode", n => { DuplexMode = n.GetEnumValue<PrintDuplexMode>(); } },
                {"feedDirection", n => { FeedDirection = n.GetEnumValue<PrinterFeedDirection>(); } },
                {"feedOrientation", n => { FeedOrientation = n.GetEnumValue<PrinterFeedOrientation>(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                {"inputBin", n => { InputBin = n.GetStringValue(); } },
                {"margin", n => { Margin = n.GetObjectValue<PrintMargin>(PrintMargin.CreateFromDiscriminatorValue); } },
                {"mediaSize", n => { MediaSize = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"multipageLayout", n => { MultipageLayout = n.GetEnumValue<PrintMultipageLayout>(); } },
                {"orientation", n => { Orientation = n.GetEnumValue<PrintOrientation>(); } },
                {"outputBin", n => { OutputBin = n.GetStringValue(); } },
                {"pageRanges", n => { PageRanges = n.GetCollectionOfObjectValues<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue).ToList(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetIntValue(); } },
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
            writer.WriteBoolValue("collate", Collate);
            writer.WriteEnumValue<PrintColorMode>("colorMode", ColorMode);
            writer.WriteIntValue("copies", Copies);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteEnumValue<PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteEnumValue<PrinterFeedDirection>("feedDirection", FeedDirection);
            writer.WriteEnumValue<PrinterFeedOrientation>("feedOrientation", FeedOrientation);
            writer.WriteCollectionOfPrimitiveValues<string>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteObjectValue<PrintMargin>("margin", Margin);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteEnumValue<PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteEnumValue<PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteCollectionOfObjectValues<IntegerRange>("pageRanges", PageRanges);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteEnumValue<PrintQuality>("quality", Quality);
            writer.WriteEnumValue<PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
