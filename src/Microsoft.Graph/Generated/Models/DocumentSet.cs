// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DocumentSet : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Content types allowed in document set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>? AllowedContentTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>?>("allowedContentTypes"); }
            set { BackingStore?.Set("allowedContentTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ContentTypeInfo> AllowedContentTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>>("allowedContentTypes"); }
            set { BackingStore?.Set("allowedContentTypes", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Default contents of document set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DocumentSetContent>? DefaultContents
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DocumentSetContent>?>("defaultContents"); }
            set { BackingStore?.Set("defaultContents", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DocumentSetContent> DefaultContents
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DocumentSetContent>>("defaultContents"); }
            set { BackingStore?.Set("defaultContents", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Indicates whether to add the name of the document set to each file name.</summary>
        public bool? PropagateWelcomePageChanges
        {
            get { return BackingStore?.Get<bool?>("propagateWelcomePageChanges"); }
            set { BackingStore?.Set("propagateWelcomePageChanges", value); }
        }
        /// <summary>The sharedColumns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>? SharedColumns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>?>("sharedColumns"); }
            set { BackingStore?.Set("sharedColumns", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ColumnDefinition> SharedColumns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>>("sharedColumns"); }
            set { BackingStore?.Set("sharedColumns", value); }
        }
#endif
        /// <summary>Add the name of the Document Set to each file name.</summary>
        public bool? ShouldPrefixNameToFile
        {
            get { return BackingStore?.Get<bool?>("shouldPrefixNameToFile"); }
            set { BackingStore?.Set("shouldPrefixNameToFile", value); }
        }
        /// <summary>The welcomePageColumns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>? WelcomePageColumns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>?>("welcomePageColumns"); }
            set { BackingStore?.Set("welcomePageColumns", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ColumnDefinition> WelcomePageColumns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>>("welcomePageColumns"); }
            set { BackingStore?.Set("welcomePageColumns", value); }
        }
#endif
        /// <summary>Welcome page absolute URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WelcomePageUrl
        {
            get { return BackingStore?.Get<string?>("welcomePageUrl"); }
            set { BackingStore?.Set("welcomePageUrl", value); }
        }
#nullable restore
#else
        public string WelcomePageUrl
        {
            get { return BackingStore?.Get<string>("welcomePageUrl"); }
            set { BackingStore?.Set("welcomePageUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DocumentSet"/> and sets the default values.
        /// </summary>
        public DocumentSet()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DocumentSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.DocumentSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DocumentSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowedContentTypes", n => { AllowedContentTypes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>(global::Microsoft.Graph.Beta.Models.ContentTypeInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "defaultContents", n => { DefaultContents = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DocumentSetContent>(global::Microsoft.Graph.Beta.Models.DocumentSetContent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "propagateWelcomePageChanges", n => { PropagateWelcomePageChanges = n.GetBoolValue(); } },
                { "sharedColumns", n => { SharedColumns = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnDefinition>(global::Microsoft.Graph.Beta.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "shouldPrefixNameToFile", n => { ShouldPrefixNameToFile = n.GetBoolValue(); } },
                { "welcomePageColumns", n => { WelcomePageColumns = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnDefinition>(global::Microsoft.Graph.Beta.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "welcomePageUrl", n => { WelcomePageUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>("allowedContentTypes", AllowedContentTypes);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DocumentSetContent>("defaultContents", DefaultContents);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("propagateWelcomePageChanges", PropagateWelcomePageChanges);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnDefinition>("sharedColumns", SharedColumns);
            writer.WriteBoolValue("shouldPrefixNameToFile", ShouldPrefixNameToFile);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnDefinition>("welcomePageColumns", WelcomePageColumns);
            writer.WriteStringValue("welcomePageUrl", WelcomePageUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
