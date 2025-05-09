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
    /// Unsupported Group Policy Extension.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UnsupportedGroupPolicyExtension : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>ExtensionType of the unsupported extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionType
        {
            get { return BackingStore?.Get<string?>("extensionType"); }
            set { BackingStore?.Set("extensionType", value); }
        }
#nullable restore
#else
        public string ExtensionType
        {
            get { return BackingStore?.Get<string>("extensionType"); }
            set { BackingStore?.Set("extensionType", value); }
        }
#endif
        /// <summary>Namespace Url of the unsupported extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NamespaceUrl
        {
            get { return BackingStore?.Get<string?>("namespaceUrl"); }
            set { BackingStore?.Set("namespaceUrl", value); }
        }
#nullable restore
#else
        public string NamespaceUrl
        {
            get { return BackingStore?.Get<string>("namespaceUrl"); }
            set { BackingStore?.Set("namespaceUrl", value); }
        }
#endif
        /// <summary>Node name of the unsupported extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeName
        {
            get { return BackingStore?.Get<string?>("nodeName"); }
            set { BackingStore?.Set("nodeName", value); }
        }
#nullable restore
#else
        public string NodeName
        {
            get { return BackingStore?.Get<string>("nodeName"); }
            set { BackingStore?.Set("nodeName", value); }
        }
#endif
        /// <summary>Scope of the group policy setting.</summary>
        public global::Microsoft.Graph.Beta.Models.GroupPolicySettingScope? SettingScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GroupPolicySettingScope?>("settingScope"); }
            set { BackingStore?.Set("settingScope", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.UnsupportedGroupPolicyExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.UnsupportedGroupPolicyExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.UnsupportedGroupPolicyExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "extensionType", n => { ExtensionType = n.GetStringValue(); } },
                { "namespaceUrl", n => { NamespaceUrl = n.GetStringValue(); } },
                { "nodeName", n => { NodeName = n.GetStringValue(); } },
                { "settingScope", n => { SettingScope = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.GroupPolicySettingScope>(); } },
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
            writer.WriteStringValue("extensionType", ExtensionType);
            writer.WriteStringValue("namespaceUrl", NamespaceUrl);
            writer.WriteStringValue("nodeName", NodeName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.GroupPolicySettingScope>("settingScope", SettingScope);
        }
    }
}
#pragma warning restore CS0618
