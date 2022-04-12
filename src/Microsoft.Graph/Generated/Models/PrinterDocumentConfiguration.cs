using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrinterDocumentConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The collate property</summary>
        public bool? Collate { get; set; }
        /// <summary>The colorMode property</summary>
        public PrintColorMode? ColorMode { get; set; }
        /// <summary>The copies property</summary>
        public int? Copies { get; set; }
        /// <summary>The dpi property</summary>
        public int? Dpi { get; set; }
        /// <summary>The duplexMode property</summary>
        public PrintDuplexMode? DuplexMode { get; set; }
        /// <summary>The feedDirection property</summary>
        public PrinterFeedDirection? FeedDirection { get; set; }
        /// <summary>The feedOrientation property</summary>
        public PrinterFeedOrientation? FeedOrientation { get; set; }
        /// <summary>The finishings property</summary>
        public List<PrintFinishing?> Finishings { get; set; }
        /// <summary>The fitPdfToPage property</summary>
        public bool? FitPdfToPage { get; set; }
        /// <summary>The inputBin property</summary>
        public string InputBin { get; set; }
        /// <summary>The margin property</summary>
        public PrintMargin Margin { get; set; }
        /// <summary>The mediaSize property</summary>
        public string MediaSize { get; set; }
        /// <summary>The mediaType property</summary>
        public string MediaType { get; set; }
        /// <summary>The multipageLayout property</summary>
        public PrintMultipageLayout? MultipageLayout { get; set; }
        /// <summary>The orientation property</summary>
        public PrintOrientation? Orientation { get; set; }
        /// <summary>The outputBin property</summary>
        public string OutputBin { get; set; }
        /// <summary>The pageRanges property</summary>
        public List<IntegerRange> PageRanges { get; set; }
        /// <summary>The pagesPerSheet property</summary>
        public int? PagesPerSheet { get; set; }
        /// <summary>The quality property</summary>
        public PrintQuality? Quality { get; set; }
        /// <summary>The scaling property</summary>
        public PrintScaling? Scaling { get; set; }
        /// <summary>
        /// Instantiates a new printerDocumentConfiguration and sets the default values.
        /// </summary>
        public PrinterDocumentConfiguration() {
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
                {"finishings", n => { Finishings = n.GetCollectionOfEnumValues<PrintFinishing>().ToList(); } },
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
            writer.WriteCollectionOfEnumValues<PrintFinishing>("finishings", Finishings);
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
