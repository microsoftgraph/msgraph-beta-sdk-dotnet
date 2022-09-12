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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The collate property</summary>
        public bool? Collate {
            get { return BackingStore?.Get<bool?>("collate"); }
            set { BackingStore?.Set("collate", value); }
        }
        /// <summary>The colorMode property</summary>
        public PrintColorMode? ColorMode {
            get { return BackingStore?.Get<PrintColorMode?>("colorMode"); }
            set { BackingStore?.Set("colorMode", value); }
        }
        /// <summary>The copies property</summary>
        public int? Copies {
            get { return BackingStore?.Get<int?>("copies"); }
            set { BackingStore?.Set("copies", value); }
        }
        /// <summary>The dpi property</summary>
        public int? Dpi {
            get { return BackingStore?.Get<int?>("dpi"); }
            set { BackingStore?.Set("dpi", value); }
        }
        /// <summary>The duplexMode property</summary>
        public PrintDuplexMode? DuplexMode {
            get { return BackingStore?.Get<PrintDuplexMode?>("duplexMode"); }
            set { BackingStore?.Set("duplexMode", value); }
        }
        /// <summary>The feedDirection property</summary>
        public PrinterFeedDirection? FeedDirection {
            get { return BackingStore?.Get<PrinterFeedDirection?>("feedDirection"); }
            set { BackingStore?.Set("feedDirection", value); }
        }
        /// <summary>The feedOrientation property</summary>
        public PrinterFeedOrientation? FeedOrientation {
            get { return BackingStore?.Get<PrinterFeedOrientation?>("feedOrientation"); }
            set { BackingStore?.Set("feedOrientation", value); }
        }
        /// <summary>The finishings property</summary>
        public List<string> Finishings {
            get { return BackingStore?.Get<List<string>>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
        /// <summary>The fitPdfToPage property</summary>
        public bool? FitPdfToPage {
            get { return BackingStore?.Get<bool?>("fitPdfToPage"); }
            set { BackingStore?.Set("fitPdfToPage", value); }
        }
        /// <summary>The inputBin property</summary>
        public string InputBin {
            get { return BackingStore?.Get<string>("inputBin"); }
            set { BackingStore?.Set("inputBin", value); }
        }
        /// <summary>The margin property</summary>
        public PrintMargin Margin {
            get { return BackingStore?.Get<PrintMargin>("margin"); }
            set { BackingStore?.Set("margin", value); }
        }
        /// <summary>The mediaSize property</summary>
        public string MediaSize {
            get { return BackingStore?.Get<string>("mediaSize"); }
            set { BackingStore?.Set("mediaSize", value); }
        }
        /// <summary>The mediaType property</summary>
        public string MediaType {
            get { return BackingStore?.Get<string>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
        /// <summary>The multipageLayout property</summary>
        public PrintMultipageLayout? MultipageLayout {
            get { return BackingStore?.Get<PrintMultipageLayout?>("multipageLayout"); }
            set { BackingStore?.Set("multipageLayout", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The orientation property</summary>
        public PrintOrientation? Orientation {
            get { return BackingStore?.Get<PrintOrientation?>("orientation"); }
            set { BackingStore?.Set("orientation", value); }
        }
        /// <summary>The outputBin property</summary>
        public string OutputBin {
            get { return BackingStore?.Get<string>("outputBin"); }
            set { BackingStore?.Set("outputBin", value); }
        }
        /// <summary>The pageRanges property</summary>
        public List<IntegerRange> PageRanges {
            get { return BackingStore?.Get<List<IntegerRange>>("pageRanges"); }
            set { BackingStore?.Set("pageRanges", value); }
        }
        /// <summary>The pagesPerSheet property</summary>
        public int? PagesPerSheet {
            get { return BackingStore?.Get<int?>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
        /// <summary>The quality property</summary>
        public PrintQuality? Quality {
            get { return BackingStore?.Get<PrintQuality?>("quality"); }
            set { BackingStore?.Set("quality", value); }
        }
        /// <summary>The scaling property</summary>
        public PrintScaling? Scaling {
            get { return BackingStore?.Get<PrintScaling?>("scaling"); }
            set { BackingStore?.Set("scaling", value); }
        }
        /// <summary>
        /// Instantiates a new printerDocumentConfiguration and sets the default values.
        /// </summary>
        public PrinterDocumentConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.printerDocumentConfiguration";
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
                {"finishings", n => { Finishings = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                {"inputBin", n => { InputBin = n.GetStringValue(); } },
                {"margin", n => { Margin = n.GetObjectValue<PrintMargin>(PrintMargin.CreateFromDiscriminatorValue); } },
                {"mediaSize", n => { MediaSize = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"multipageLayout", n => { MultipageLayout = n.GetEnumValue<PrintMultipageLayout>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"orientation", n => { Orientation = n.GetEnumValue<PrintOrientation>(); } },
                {"outputBin", n => { OutputBin = n.GetStringValue(); } },
                {"pageRanges", n => { PageRanges = n.GetCollectionOfObjectValues<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
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
