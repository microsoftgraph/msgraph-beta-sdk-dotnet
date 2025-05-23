// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.Ediscovery;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.MicrosoftGraphEdiscoveryExport
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ExportPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The azureBlobContainer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureBlobContainer
        {
            get { return BackingStore?.Get<string?>("azureBlobContainer"); }
            set { BackingStore?.Set("azureBlobContainer", value); }
        }
#nullable restore
#else
        public string AzureBlobContainer
        {
            get { return BackingStore?.Get<string>("azureBlobContainer"); }
            set { BackingStore?.Set("azureBlobContainer", value); }
        }
#endif
        /// <summary>The azureBlobToken property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureBlobToken
        {
            get { return BackingStore?.Get<string?>("azureBlobToken"); }
            set { BackingStore?.Set("azureBlobToken", value); }
        }
#nullable restore
#else
        public string AzureBlobToken
        {
            get { return BackingStore?.Get<string>("azureBlobToken"); }
            set { BackingStore?.Set("azureBlobToken", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The exportOptions property</summary>
        public global::Microsoft.Graph.Beta.Models.Ediscovery.ExportOptions? ExportOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Ediscovery.ExportOptions?>("exportOptions"); }
            set { BackingStore?.Set("exportOptions", value); }
        }
        /// <summary>The exportStructure property</summary>
        public global::Microsoft.Graph.Beta.Models.Ediscovery.ExportFileStructure? ExportStructure
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Ediscovery.ExportFileStructure?>("exportStructure"); }
            set { BackingStore?.Set("exportStructure", value); }
        }
        /// <summary>The outputName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputName
        {
            get { return BackingStore?.Get<string?>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
#nullable restore
#else
        public string OutputName
        {
            get { return BackingStore?.Get<string>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.MicrosoftGraphEdiscoveryExport.ExportPostRequestBody"/> and sets the default values.
        /// </summary>
        public ExportPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.MicrosoftGraphEdiscoveryExport.ExportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.MicrosoftGraphEdiscoveryExport.ExportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.MicrosoftGraphEdiscoveryExport.ExportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "azureBlobContainer", n => { AzureBlobContainer = n.GetStringValue(); } },
                { "azureBlobToken", n => { AzureBlobToken = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "exportOptions", n => { ExportOptions = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Ediscovery.ExportOptions>(); } },
                { "exportStructure", n => { ExportStructure = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Ediscovery.ExportFileStructure>(); } },
                { "outputName", n => { OutputName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("azureBlobContainer", AzureBlobContainer);
            writer.WriteStringValue("azureBlobToken", AzureBlobToken);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Ediscovery.ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Ediscovery.ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
