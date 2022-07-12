using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoveryExportOperation : CaseOperation, IParsable {
        /// <summary>The name of the Azure storage location where the export will be stored. This only applies to exports stored in your own Azure storage location.</summary>
        public string AzureBlobContainer {
            get { return BackingStore?.Get<string>("azureBlobContainer"); }
            set { BackingStore?.Set("azureBlobContainer", value); }
        }
        /// <summary>The SAS token for the Azure storage location.  This only applies to exports stored in your own Azure storage location.</summary>
        public string AzureBlobToken {
            get { return BackingStore?.Get<string>("azureBlobToken"); }
            set { BackingStore?.Set("azureBlobToken", value); }
        }
        /// <summary>The description provided for the export.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The options provided for the export. For more details, see reviewSet: export. Possible values are: originalFiles, text, pdfReplacement, fileInfo, tags.</summary>
        public Microsoft.Graph.Beta.Models.Security.ExportOptions? ExportOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ExportOptions?>("exportOptions"); }
            set { BackingStore?.Set("exportOptions", value); }
        }
        /// <summary>The options provided that specify the structure of the export. For more details, see reviewSet: export. Possible values are: none, directory, pst.</summary>
        public ExportFileStructure? ExportStructure {
            get { return BackingStore?.Get<ExportFileStructure?>("exportStructure"); }
            set { BackingStore?.Set("exportStructure", value); }
        }
        /// <summary>The outputFolderId property</summary>
        public string OutputFolderId {
            get { return BackingStore?.Get<string>("outputFolderId"); }
            set { BackingStore?.Set("outputFolderId", value); }
        }
        /// <summary>The name provided for the export.</summary>
        public string OutputName {
            get { return BackingStore?.Get<string>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
        /// <summary>Review set from where documents are exported.</summary>
        public EdiscoveryReviewSet ReviewSet {
            get { return BackingStore?.Get<EdiscoveryReviewSet>("reviewSet"); }
            set { BackingStore?.Set("reviewSet", value); }
        }
        /// <summary>The review set query which is used to filter the documents for export.</summary>
        public EdiscoveryReviewSetQuery ReviewSetQuery {
            get { return BackingStore?.Get<EdiscoveryReviewSetQuery>("reviewSetQuery"); }
            set { BackingStore?.Set("reviewSetQuery", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryExportOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryExportOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureBlobContainer", n => { AzureBlobContainer = n.GetStringValue(); } },
                {"azureBlobToken", n => { AzureBlobToken = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"exportOptions", n => { ExportOptions = n.GetEnumValue<ExportOptions>(); } },
                {"exportStructure", n => { ExportStructure = n.GetEnumValue<ExportFileStructure>(); } },
                {"outputFolderId", n => { OutputFolderId = n.GetStringValue(); } },
                {"outputName", n => { OutputName = n.GetStringValue(); } },
                {"reviewSet", n => { ReviewSet = n.GetObjectValue<EdiscoveryReviewSet>(EdiscoveryReviewSet.CreateFromDiscriminatorValue); } },
                {"reviewSetQuery", n => { ReviewSetQuery = n.GetObjectValue<EdiscoveryReviewSetQuery>(EdiscoveryReviewSetQuery.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureBlobContainer", AzureBlobContainer);
            writer.WriteStringValue("azureBlobToken", AzureBlobToken);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputFolderId", OutputFolderId);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteObjectValue<EdiscoveryReviewSet>("reviewSet", ReviewSet);
            writer.WriteObjectValue<EdiscoveryReviewSetQuery>("reviewSetQuery", ReviewSetQuery);
        }
    }
}
