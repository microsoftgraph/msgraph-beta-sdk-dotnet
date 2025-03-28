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
    /// Represents an AirPrint destination.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AirPrintDestination : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>If true AirPrint connections are secured by Transport Layer Security (TLS). Default is false. Available in iOS 11.0 and later.</summary>
        public bool? ForceTls
        {
            get { return BackingStore?.Get<bool?>("forceTls"); }
            set { BackingStore?.Set("forceTls", value); }
        }
        /// <summary>The IP Address of the AirPrint destination.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress
        {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress
        {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
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
        /// <summary>The listening port of the AirPrint destination. If this key is not specified AirPrint will use the default port. Available in iOS 11.0 and later.</summary>
        public int? Port
        {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>The Resource Path associated with the printer. This corresponds to the rp parameter of the ipps.tcp Bonjour record. For example: printers/CanonMG5300series, printers/XeroxPhaser7600, ipp/print, EpsonIPPPrinter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourcePath
        {
            get { return BackingStore?.Get<string?>("resourcePath"); }
            set { BackingStore?.Set("resourcePath", value); }
        }
#nullable restore
#else
        public string ResourcePath
        {
            get { return BackingStore?.Get<string>("resourcePath"); }
            set { BackingStore?.Set("resourcePath", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AirPrintDestination"/> and sets the default values.
        /// </summary>
        public AirPrintDestination()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AirPrintDestination"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AirPrintDestination CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AirPrintDestination();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "forceTls", n => { ForceTls = n.GetBoolValue(); } },
                { "ipAddress", n => { IpAddress = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "port", n => { Port = n.GetIntValue(); } },
                { "resourcePath", n => { ResourcePath = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("forceTls", ForceTls);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("port", Port);
            writer.WriteStringValue("resourcePath", ResourcePath);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
