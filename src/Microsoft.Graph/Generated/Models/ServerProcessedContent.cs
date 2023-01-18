using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ServerProcessedContent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A key-value map where keys are string identifiers and values are component ids. SharePoint servers might decide to use this hint to preload the script for corresponding components for performance boost.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MetaDataKeyStringPair>? ComponentDependencies {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>?>("componentDependencies"); }
            set { BackingStore?.Set("componentDependencies", value); }
        }
#else
        public List<MetaDataKeyStringPair> ComponentDependencies {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>>("componentDependencies"); }
            set { BackingStore?.Set("componentDependencies", value); }
        }
#endif
        /// <summary>A key-value map where keys are string identifier and values are object of custom key-value pair.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MetaDataKeyValuePair>? CustomMetadata {
            get { return BackingStore?.Get<List<MetaDataKeyValuePair>?>("customMetadata"); }
            set { BackingStore?.Set("customMetadata", value); }
        }
#else
        public List<MetaDataKeyValuePair> CustomMetadata {
            get { return BackingStore?.Get<List<MetaDataKeyValuePair>>("customMetadata"); }
            set { BackingStore?.Set("customMetadata", value); }
        }
#endif
        /// <summary>A key-value map where keys are string identifiers and values are rich text with HTML format. SharePoint servers treat the values as HTML content and run services like safety checks, search index and link fixup on them.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MetaDataKeyStringPair>? HtmlStrings {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>?>("htmlStrings"); }
            set { BackingStore?.Set("htmlStrings", value); }
        }
#else
        public List<MetaDataKeyStringPair> HtmlStrings {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>>("htmlStrings"); }
            set { BackingStore?.Set("htmlStrings", value); }
        }
#endif
        /// <summary>A key-value map where keys are string identifiers and values are image sources. SharePoint servers treat the values as image sources and run services like search index and link fixup on them.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MetaDataKeyStringPair>? ImageSources {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>?>("imageSources"); }
            set { BackingStore?.Set("imageSources", value); }
        }
#else
        public List<MetaDataKeyStringPair> ImageSources {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>>("imageSources"); }
            set { BackingStore?.Set("imageSources", value); }
        }
#endif
        /// <summary>A key-value map where keys are string identifiers and values are links. SharePoint servers treat the values as links and run services like link fixup on them.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MetaDataKeyStringPair>? Links {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>?>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#else
        public List<MetaDataKeyStringPair> Links {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>A key-value map where keys are string identifiers and values are strings that should be search indexed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MetaDataKeyStringPair>? SearchablePlainTexts {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>?>("searchablePlainTexts"); }
            set { BackingStore?.Set("searchablePlainTexts", value); }
        }
#else
        public List<MetaDataKeyStringPair> SearchablePlainTexts {
            get { return BackingStore?.Get<List<MetaDataKeyStringPair>>("searchablePlainTexts"); }
            set { BackingStore?.Set("searchablePlainTexts", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new serverProcessedContent and sets the default values.
        /// </summary>
        public ServerProcessedContent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ServerProcessedContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServerProcessedContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"componentDependencies", n => { ComponentDependencies = n.GetCollectionOfObjectValues<MetaDataKeyStringPair>(MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customMetadata", n => { CustomMetadata = n.GetCollectionOfObjectValues<MetaDataKeyValuePair>(MetaDataKeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"htmlStrings", n => { HtmlStrings = n.GetCollectionOfObjectValues<MetaDataKeyStringPair>(MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"imageSources", n => { ImageSources = n.GetCollectionOfObjectValues<MetaDataKeyStringPair>(MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"links", n => { Links = n.GetCollectionOfObjectValues<MetaDataKeyStringPair>(MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"searchablePlainTexts", n => { SearchablePlainTexts = n.GetCollectionOfObjectValues<MetaDataKeyStringPair>(MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MetaDataKeyStringPair>("componentDependencies", ComponentDependencies);
            writer.WriteCollectionOfObjectValues<MetaDataKeyValuePair>("customMetadata", CustomMetadata);
            writer.WriteCollectionOfObjectValues<MetaDataKeyStringPair>("htmlStrings", HtmlStrings);
            writer.WriteCollectionOfObjectValues<MetaDataKeyStringPair>("imageSources", ImageSources);
            writer.WriteCollectionOfObjectValues<MetaDataKeyStringPair>("links", Links);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<MetaDataKeyStringPair>("searchablePlainTexts", SearchablePlainTexts);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
