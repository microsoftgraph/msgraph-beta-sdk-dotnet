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
    public partial class ConfigurationUri : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The single sign-on mode that the URI is configured for. Possible values are: saml, password.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppliesToSingleSignOnMode
        {
            get { return BackingStore?.Get<string?>("appliesToSingleSignOnMode"); }
            set { BackingStore?.Set("appliesToSingleSignOnMode", value); }
        }
#nullable restore
#else
        public string AppliesToSingleSignOnMode
        {
            get { return BackingStore?.Get<string>("appliesToSingleSignOnMode"); }
            set { BackingStore?.Set("appliesToSingleSignOnMode", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The various formats that the URI should follow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Examples
        {
            get { return BackingStore?.Get<List<string>?>("examples"); }
            set { BackingStore?.Set("examples", value); }
        }
#nullable restore
#else
        public List<string> Examples
        {
            get { return BackingStore?.Get<List<string>>("examples"); }
            set { BackingStore?.Set("examples", value); }
        }
#endif
        /// <summary>Indicates whether this URI is required for the single sign-on configuration.</summary>
        public bool? IsRequired
        {
            get { return BackingStore?.Get<bool?>("isRequired"); }
            set { BackingStore?.Set("isRequired", value); }
        }
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
        /// <summary>The usage property</summary>
        public global::Microsoft.Graph.Beta.Models.UriUsageType? Usage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.UriUsageType?>("usage"); }
            set { BackingStore?.Set("usage", value); }
        }
        /// <summary>The suggested values for the URI. Developers may need to customize these values for their tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Values
        {
            get { return BackingStore?.Get<List<string>?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public List<string> Values
        {
            get { return BackingStore?.Get<List<string>>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ConfigurationUri"/> and sets the default values.
        /// </summary>
        public ConfigurationUri()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ConfigurationUri"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.ConfigurationUri CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ConfigurationUri();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appliesToSingleSignOnMode", n => { AppliesToSingleSignOnMode = n.GetStringValue(); } },
                { "examples", n => { Examples = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "isRequired", n => { IsRequired = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "usage", n => { Usage = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.UriUsageType>(); } },
                { "values", n => { Values = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appliesToSingleSignOnMode", AppliesToSingleSignOnMode);
            writer.WriteCollectionOfPrimitiveValues<string>("examples", Examples);
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.UriUsageType>("usage", Usage);
            writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
