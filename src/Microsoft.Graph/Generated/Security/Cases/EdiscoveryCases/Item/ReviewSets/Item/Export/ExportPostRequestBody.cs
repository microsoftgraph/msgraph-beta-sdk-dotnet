using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.Export {
    /// <summary>Provides operations to call the export method.</summary>
    public class ExportPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The azureBlobContainer property</summary>
        public string AzureBlobContainer {
            get { return BackingStore?.Get<string>(nameof(AzureBlobContainer)); }
            set { BackingStore?.Set(nameof(AzureBlobContainer), value); }
        }
        /// <summary>The azureBlobToken property</summary>
        public string AzureBlobToken {
            get { return BackingStore?.Get<string>(nameof(AzureBlobToken)); }
            set { BackingStore?.Set(nameof(AzureBlobToken), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The exportOptions property</summary>
        public Microsoft.Graph.Beta.Models.Security.ExportOptions? ExportOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ExportOptions?>(nameof(ExportOptions)); }
            set { BackingStore?.Set(nameof(ExportOptions), value); }
        }
        /// <summary>The exportStructure property</summary>
        public ExportFileStructure? ExportStructure {
            get { return BackingStore?.Get<ExportFileStructure?>(nameof(ExportStructure)); }
            set { BackingStore?.Set(nameof(ExportStructure), value); }
        }
        /// <summary>The outputName property</summary>
        public string OutputName {
            get { return BackingStore?.Get<string>(nameof(OutputName)); }
            set { BackingStore?.Set(nameof(OutputName), value); }
        }
        /// <summary>
        /// Instantiates a new exportPostRequestBody and sets the default values.
        /// </summary>
        public ExportPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"azureBlobContainer", n => { AzureBlobContainer = n.GetStringValue(); } },
                {"azureBlobToken", n => { AzureBlobToken = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"exportOptions", n => { ExportOptions = n.GetEnumValue<ExportOptions>(); } },
                {"exportStructure", n => { ExportStructure = n.GetEnumValue<ExportFileStructure>(); } },
                {"outputName", n => { OutputName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("azureBlobContainer", AzureBlobContainer);
            writer.WriteStringValue("azureBlobToken", AzureBlobToken);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
