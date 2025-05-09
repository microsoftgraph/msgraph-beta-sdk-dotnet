// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Templates.DeviceTemplates.Item.CreateDeviceFromTemplate
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CreateDeviceFromTemplatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accountEnabled property</summary>
        public bool? AccountEnabled
        {
            get { return BackingStore?.Get<bool?>("accountEnabled"); }
            set { BackingStore?.Set("accountEnabled", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The alternativeNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AlternativeNames
        {
            get { return BackingStore?.Get<List<string>?>("alternativeNames"); }
            set { BackingStore?.Set("alternativeNames", value); }
        }
#nullable restore
#else
        public List<string> AlternativeNames
        {
            get { return BackingStore?.Get<List<string>>("alternativeNames"); }
            set { BackingStore?.Set("alternativeNames", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The externalDeviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalDeviceId
        {
            get { return BackingStore?.Get<string?>("externalDeviceId"); }
            set { BackingStore?.Set("externalDeviceId", value); }
        }
#nullable restore
#else
        public string ExternalDeviceId
        {
            get { return BackingStore?.Get<string>("externalDeviceId"); }
            set { BackingStore?.Set("externalDeviceId", value); }
        }
#endif
        /// <summary>The externalSourceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalSourceName
        {
            get { return BackingStore?.Get<string?>("externalSourceName"); }
            set { BackingStore?.Set("externalSourceName", value); }
        }
#nullable restore
#else
        public string ExternalSourceName
        {
            get { return BackingStore?.Get<string>("externalSourceName"); }
            set { BackingStore?.Set("externalSourceName", value); }
        }
#endif
        /// <summary>The keyCredential property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.KeyCredential? KeyCredential
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.KeyCredential?>("keyCredential"); }
            set { BackingStore?.Set("keyCredential", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.KeyCredential KeyCredential
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.KeyCredential>("keyCredential"); }
            set { BackingStore?.Set("keyCredential", value); }
        }
#endif
        /// <summary>The operatingSystemVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystemVersion
        {
            get { return BackingStore?.Get<string?>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
#nullable restore
#else
        public string OperatingSystemVersion
        {
            get { return BackingStore?.Get<string>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Templates.DeviceTemplates.Item.CreateDeviceFromTemplate.CreateDeviceFromTemplatePostRequestBody"/> and sets the default values.
        /// </summary>
        public CreateDeviceFromTemplatePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Templates.DeviceTemplates.Item.CreateDeviceFromTemplate.CreateDeviceFromTemplatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Templates.DeviceTemplates.Item.CreateDeviceFromTemplate.CreateDeviceFromTemplatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Templates.DeviceTemplates.Item.CreateDeviceFromTemplate.CreateDeviceFromTemplatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                { "alternativeNames", n => { AlternativeNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "externalDeviceId", n => { ExternalDeviceId = n.GetStringValue(); } },
                { "externalSourceName", n => { ExternalSourceName = n.GetStringValue(); } },
                { "keyCredential", n => { KeyCredential = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.KeyCredential>(global::Microsoft.Graph.Beta.Models.KeyCredential.CreateFromDiscriminatorValue); } },
                { "operatingSystemVersion", n => { OperatingSystemVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("alternativeNames", AlternativeNames);
            writer.WriteStringValue("externalDeviceId", ExternalDeviceId);
            writer.WriteStringValue("externalSourceName", ExternalSourceName);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.KeyCredential>("keyCredential", KeyCredential);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
