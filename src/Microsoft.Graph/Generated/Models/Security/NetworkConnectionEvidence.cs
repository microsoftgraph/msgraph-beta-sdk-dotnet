// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class NetworkConnectionEvidence : global::Microsoft.Graph.Beta.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The destinationAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.IpEvidence? DestinationAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.IpEvidence?>("destinationAddress"); }
            set { BackingStore?.Set("destinationAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.IpEvidence DestinationAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>("destinationAddress"); }
            set { BackingStore?.Set("destinationAddress", value); }
        }
#endif
        /// <summary>The destinationPort property</summary>
        public int? DestinationPort
        {
            get { return BackingStore?.Get<int?>("destinationPort"); }
            set { BackingStore?.Set("destinationPort", value); }
        }
        /// <summary>The protocol property</summary>
        public global::Microsoft.Graph.Beta.Models.Security.ProtocolType? Protocol
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.ProtocolType?>("protocol"); }
            set { BackingStore?.Set("protocol", value); }
        }
        /// <summary>The sourceAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.IpEvidence? SourceAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.IpEvidence?>("sourceAddress"); }
            set { BackingStore?.Set("sourceAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.IpEvidence SourceAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>("sourceAddress"); }
            set { BackingStore?.Set("sourceAddress", value); }
        }
#endif
        /// <summary>The sourcePort property</summary>
        public int? SourcePort
        {
            get { return BackingStore?.Get<int?>("sourcePort"); }
            set { BackingStore?.Set("sourcePort", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.NetworkConnectionEvidence"/> and sets the default values.
        /// </summary>
        public NetworkConnectionEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.networkConnectionEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.NetworkConnectionEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.NetworkConnectionEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.NetworkConnectionEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "destinationAddress", n => { DestinationAddress = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>(global::Microsoft.Graph.Beta.Models.Security.IpEvidence.CreateFromDiscriminatorValue); } },
                { "destinationPort", n => { DestinationPort = n.GetIntValue(); } },
                { "protocol", n => { Protocol = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.ProtocolType>(); } },
                { "sourceAddress", n => { SourceAddress = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>(global::Microsoft.Graph.Beta.Models.Security.IpEvidence.CreateFromDiscriminatorValue); } },
                { "sourcePort", n => { SourcePort = n.GetIntValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>("destinationAddress", DestinationAddress);
            writer.WriteIntValue("destinationPort", DestinationPort);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.ProtocolType>("protocol", Protocol);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>("sourceAddress", SourceAddress);
            writer.WriteIntValue("sourcePort", SourcePort);
        }
    }
}
#pragma warning restore CS0618
