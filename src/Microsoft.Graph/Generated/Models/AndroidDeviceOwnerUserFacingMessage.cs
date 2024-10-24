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
    /// <summary>
    /// Represents a user-facing message with locale information as well as a default message to be used if the user&apos;s locale doesn&apos;t match with any of the localized messages
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidDeviceOwnerUserFacingMessage : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default message displayed if the user&apos;s locale doesn&apos;t match with any of the localized messages</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultMessage
        {
            get { return BackingStore?.Get<string?>("defaultMessage"); }
            set { BackingStore?.Set("defaultMessage", value); }
        }
#nullable restore
#else
        public string DefaultMessage
        {
            get { return BackingStore?.Get<string>("defaultMessage"); }
            set { BackingStore?.Set("defaultMessage", value); }
        }
#endif
        /// <summary>The list of &lt;locale, message&gt; pairs. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.KeyValuePair>? LocalizedMessages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValuePair>?>("localizedMessages"); }
            set { BackingStore?.Set("localizedMessages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.KeyValuePair> LocalizedMessages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValuePair>>("localizedMessages"); }
            set { BackingStore?.Set("localizedMessages", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerUserFacingMessage"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerUserFacingMessage()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerUserFacingMessage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerUserFacingMessage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerUserFacingMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "defaultMessage", n => { DefaultMessage = n.GetStringValue(); } },
                { "localizedMessages", n => { LocalizedMessages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValuePair>(global::Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultMessage", DefaultMessage);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValuePair>("localizedMessages", LocalizedMessages);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
