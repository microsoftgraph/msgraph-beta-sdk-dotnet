// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Windows VPN configuration profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsVpnConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Connection name displayed to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionName
        {
            get { return BackingStore?.Get<string?>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
#nullable restore
#else
        public string ConnectionName
        {
            get { return BackingStore?.Get<string>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
#endif
        /// <summary>Custom XML commands that configures the VPN connection. (UTF8 encoded byte array)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? CustomXml
        {
            get { return BackingStore?.Get<byte[]?>("customXml"); }
            set { BackingStore?.Set("customXml", value); }
        }
#nullable restore
#else
        public byte[] CustomXml
        {
            get { return BackingStore?.Get<byte[]>("customXml"); }
            set { BackingStore?.Set("customXml", value); }
        }
#endif
        /// <summary>List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VpnServer>? Servers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VpnServer>?>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VpnServer> Servers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VpnServer>>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsVpnConfiguration"/> and sets the default values.
        /// </summary>
        public WindowsVpnConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windowsVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsVpnConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.windows10VpnConfiguration" => new global::Microsoft.Graph.Beta.Models.Windows10VpnConfiguration(),
                "#microsoft.graph.windows81VpnConfiguration" => new global::Microsoft.Graph.Beta.Models.Windows81VpnConfiguration(),
                "#microsoft.graph.windowsPhone81VpnConfiguration" => new global::Microsoft.Graph.Beta.Models.WindowsPhone81VpnConfiguration(),
                _ => new global::Microsoft.Graph.Beta.Models.WindowsVpnConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "connectionName", n => { ConnectionName = n.GetStringValue(); } },
                { "customXml", n => { CustomXml = n.GetByteArrayValue(); } },
                { "servers", n => { Servers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VpnServer>(global::Microsoft.Graph.Beta.Models.VpnServer.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("connectionName", ConnectionName);
            writer.WriteByteArrayValue("customXml", CustomXml);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VpnServer>("servers", Servers);
        }
    }
}
#pragma warning restore CS0618
