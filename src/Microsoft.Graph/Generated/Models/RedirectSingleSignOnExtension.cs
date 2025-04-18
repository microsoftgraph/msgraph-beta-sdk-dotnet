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
    /// Represents an Apple Single Sign-On Extension.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RedirectSingleSignOnExtension : global::Microsoft.Graph.Beta.Models.SingleSignOnExtension, IParsable
    {
        /// <summary>Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>? Configurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>?>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair> Configurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
#endif
        /// <summary>Gets or sets the bundle ID of the app extension that performs SSO for the specified URLs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionIdentifier
        {
            get { return BackingStore?.Get<string?>("extensionIdentifier"); }
            set { BackingStore?.Set("extensionIdentifier", value); }
        }
#nullable restore
#else
        public string ExtensionIdentifier
        {
            get { return BackingStore?.Get<string>("extensionIdentifier"); }
            set { BackingStore?.Set("extensionIdentifier", value); }
        }
#endif
        /// <summary>Gets or sets the team ID of the app extension that performs SSO for the specified URLs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamIdentifier
        {
            get { return BackingStore?.Get<string?>("teamIdentifier"); }
            set { BackingStore?.Set("teamIdentifier", value); }
        }
#nullable restore
#else
        public string TeamIdentifier
        {
            get { return BackingStore?.Get<string>("teamIdentifier"); }
            set { BackingStore?.Set("teamIdentifier", value); }
        }
#endif
        /// <summary>One or more URL prefixes of identity providers on whose behalf the app extension performs single sign-on. URLs must begin with http:// or https://. All URL prefixes must be unique for all profiles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UrlPrefixes
        {
            get { return BackingStore?.Get<List<string>?>("urlPrefixes"); }
            set { BackingStore?.Set("urlPrefixes", value); }
        }
#nullable restore
#else
        public List<string> UrlPrefixes
        {
            get { return BackingStore?.Get<List<string>>("urlPrefixes"); }
            set { BackingStore?.Set("urlPrefixes", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.RedirectSingleSignOnExtension"/> and sets the default values.
        /// </summary>
        public RedirectSingleSignOnExtension() : base()
        {
            OdataType = "#microsoft.graph.redirectSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.RedirectSingleSignOnExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.RedirectSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.RedirectSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configurations", n => { Configurations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>(global::Microsoft.Graph.Beta.Models.KeyTypedValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "extensionIdentifier", n => { ExtensionIdentifier = n.GetStringValue(); } },
                { "teamIdentifier", n => { TeamIdentifier = n.GetStringValue(); } },
                { "urlPrefixes", n => { UrlPrefixes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>("configurations", Configurations);
            writer.WriteStringValue("extensionIdentifier", ExtensionIdentifier);
            writer.WriteStringValue("teamIdentifier", TeamIdentifier);
            writer.WriteCollectionOfPrimitiveValues<string>("urlPrefixes", UrlPrefixes);
        }
    }
}
#pragma warning restore CS0618
