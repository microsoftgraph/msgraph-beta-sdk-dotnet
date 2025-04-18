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
    /// A complex type to store the product code and version rule data for a Win32 LOB app. This rule is not supported as a requirement rule.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Win32LobAppProductCodeRule : global::Microsoft.Graph.Beta.Models.Win32LobAppRule, IParsable
    {
        /// <summary>The product code of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductCode
        {
            get { return BackingStore?.Get<string?>("productCode"); }
            set { BackingStore?.Set("productCode", value); }
        }
#nullable restore
#else
        public string ProductCode
        {
            get { return BackingStore?.Get<string>("productCode"); }
            set { BackingStore?.Set("productCode", value); }
        }
#endif
        /// <summary>The product version comparison value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductVersion
        {
            get { return BackingStore?.Get<string?>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
#nullable restore
#else
        public string ProductVersion
        {
            get { return BackingStore?.Get<string>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
#endif
        /// <summary>Contains properties for detection operator.</summary>
        public global::Microsoft.Graph.Beta.Models.Win32LobAppRuleOperator? ProductVersionOperator
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Win32LobAppRuleOperator?>("productVersionOperator"); }
            set { BackingStore?.Set("productVersionOperator", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Win32LobAppProductCodeRule"/> and sets the default values.
        /// </summary>
        public Win32LobAppProductCodeRule() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppProductCodeRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Win32LobAppProductCodeRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Win32LobAppProductCodeRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Win32LobAppProductCodeRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "productCode", n => { ProductCode = n.GetStringValue(); } },
                { "productVersion", n => { ProductVersion = n.GetStringValue(); } },
                { "productVersionOperator", n => { ProductVersionOperator = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Win32LobAppRuleOperator>(); } },
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
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Win32LobAppRuleOperator>("productVersionOperator", ProductVersionOperator);
        }
    }
}
#pragma warning restore CS0618
