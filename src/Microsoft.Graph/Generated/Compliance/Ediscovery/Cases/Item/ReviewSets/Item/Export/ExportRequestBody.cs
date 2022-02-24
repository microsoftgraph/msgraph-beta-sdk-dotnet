using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.Export {
    public class ExportRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string AzureBlobContainer { get; set; }
        public string AzureBlobToken { get; set; }
        public string Description { get; set; }
        public ExportOptions? ExportOptions { get; set; }
        public ExportFileStructure? ExportStructure { get; set; }
        public string OutputName { get; set; }
        /// <summary>
        /// Instantiates a new exportRequestBody and sets the default values.
        /// </summary>
        public ExportRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"azureBlobContainer", (o,n) => { (o as ExportRequestBody).AzureBlobContainer = n.GetStringValue(); } },
                {"azureBlobToken", (o,n) => { (o as ExportRequestBody).AzureBlobToken = n.GetStringValue(); } },
                {"description", (o,n) => { (o as ExportRequestBody).Description = n.GetStringValue(); } },
                {"exportOptions", (o,n) => { (o as ExportRequestBody).ExportOptions = n.GetEnumValue<ExportOptions>(); } },
                {"exportStructure", (o,n) => { (o as ExportRequestBody).ExportStructure = n.GetEnumValue<ExportFileStructure>(); } },
                {"outputName", (o,n) => { (o as ExportRequestBody).OutputName = n.GetStringValue(); } },
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
