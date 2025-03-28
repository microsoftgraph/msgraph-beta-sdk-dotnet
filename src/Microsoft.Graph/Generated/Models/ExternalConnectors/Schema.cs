// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Schema : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Must be set to microsoft.graph.externalItem. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseType
        {
            get { return BackingStore?.Get<string?>("baseType"); }
            set { BackingStore?.Set("baseType", value); }
        }
#nullable restore
#else
        public string BaseType
        {
            get { return BackingStore?.Get<string>("baseType"); }
            set { BackingStore?.Set("baseType", value); }
        }
#endif
        /// <summary>The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ExternalConnectors.Property>? Properties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExternalConnectors.Property>?>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ExternalConnectors.Property> Properties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExternalConnectors.Property>>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ExternalConnectors.Schema"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ExternalConnectors.Schema CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ExternalConnectors.Schema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "baseType", n => { BaseType = n.GetStringValue(); } },
                { "properties", n => { Properties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExternalConnectors.Property>(global::Microsoft.Graph.Beta.Models.ExternalConnectors.Property.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("baseType", BaseType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExternalConnectors.Property>("properties", Properties);
        }
    }
}
#pragma warning restore CS0618
