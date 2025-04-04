// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Connector : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The external IP address as detected by the connector server. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalIp
        {
            get { return BackingStore?.Get<string?>("externalIp"); }
            set { BackingStore?.Set("externalIp", value); }
        }
#nullable restore
#else
        public string ExternalIp
        {
            get { return BackingStore?.Get<string>("externalIp"); }
            set { BackingStore?.Set("externalIp", value); }
        }
#endif
        /// <summary>The name of the computer on which the connector is installed and runs on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MachineName
        {
            get { return BackingStore?.Get<string?>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
#nullable restore
#else
        public string MachineName
        {
            get { return BackingStore?.Get<string>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
#endif
        /// <summary>The connectorGroup that the connector is a member of. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ConnectorGroup>? MemberOf
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ConnectorGroup>?>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ConnectorGroup> MemberOf
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ConnectorGroup>>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#endif
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Beta.Models.ConnectorStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConnectorStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The version of the connector. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Connector"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Connector CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Connector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "externalIp", n => { ExternalIp = n.GetStringValue(); } },
                { "machineName", n => { MachineName = n.GetStringValue(); } },
                { "memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ConnectorGroup>(global::Microsoft.Graph.Beta.Models.ConnectorGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ConnectorStatus>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteStringValue("externalIp", ExternalIp);
            writer.WriteStringValue("machineName", MachineName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ConnectorGroup>("memberOf", MemberOf);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ConnectorStatus>("status", Status);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
