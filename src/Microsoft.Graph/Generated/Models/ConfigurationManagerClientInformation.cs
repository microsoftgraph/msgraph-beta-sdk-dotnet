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
    /// Configuration Manager client information synced from SCCM
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ConfigurationManagerClientInformation : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Configuration Manager Client Id from SCCM</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientIdentifier
        {
            get { return BackingStore?.Get<string?>("clientIdentifier"); }
            set { BackingStore?.Set("clientIdentifier", value); }
        }
#nullable restore
#else
        public string ClientIdentifier
        {
            get { return BackingStore?.Get<string>("clientIdentifier"); }
            set { BackingStore?.Set("clientIdentifier", value); }
        }
#endif
        /// <summary>Configuration Manager Client version from SCCM</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientVersion
        {
            get { return BackingStore?.Get<string?>("clientVersion"); }
            set { BackingStore?.Set("clientVersion", value); }
        }
#nullable restore
#else
        public string ClientVersion
        {
            get { return BackingStore?.Get<string>("clientVersion"); }
            set { BackingStore?.Set("clientVersion", value); }
        }
#endif
        /// <summary>Configuration Manager Client blocked status from SCCM</summary>
        public bool? IsBlocked
        {
            get { return BackingStore?.Get<bool?>("isBlocked"); }
            set { BackingStore?.Set("isBlocked", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation"/> and sets the default values.
        /// </summary>
        public ConfigurationManagerClientInformation()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "clientIdentifier", n => { ClientIdentifier = n.GetStringValue(); } },
                { "clientVersion", n => { ClientVersion = n.GetStringValue(); } },
                { "isBlocked", n => { IsBlocked = n.GetBoolValue(); } },
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
            writer.WriteStringValue("clientIdentifier", ClientIdentifier);
            writer.WriteStringValue("clientVersion", ClientVersion);
            writer.WriteBoolValue("isBlocked", IsBlocked);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
