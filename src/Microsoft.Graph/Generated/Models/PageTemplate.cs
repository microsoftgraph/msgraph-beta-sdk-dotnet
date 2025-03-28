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
    public partial class PageTemplate : global::Microsoft.Graph.Beta.Models.BaseSitePage, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The layout of the content in a given SharePoint page template, including horizontal sections and vertical sections.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CanvasLayout? CanvasLayout
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CanvasLayout?>("canvasLayout"); }
            set { BackingStore?.Set("canvasLayout", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CanvasLayout CanvasLayout
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CanvasLayout>("canvasLayout"); }
            set { BackingStore?.Set("canvasLayout", value); }
        }
#endif
        /// <summary>The title area on the SharePoint page template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TitleArea? TitleArea
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TitleArea?>("titleArea"); }
            set { BackingStore?.Set("titleArea", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TitleArea TitleArea
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TitleArea>("titleArea"); }
            set { BackingStore?.Set("titleArea", value); }
        }
#endif
        /// <summary>The collection of web parts on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WebPart>? WebParts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WebPart>?>("webParts"); }
            set { BackingStore?.Set("webParts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WebPart> WebParts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WebPart>>("webParts"); }
            set { BackingStore?.Set("webParts", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PageTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.PageTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PageTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "canvasLayout", n => { CanvasLayout = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CanvasLayout>(global::Microsoft.Graph.Beta.Models.CanvasLayout.CreateFromDiscriminatorValue); } },
                { "titleArea", n => { TitleArea = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TitleArea>(global::Microsoft.Graph.Beta.Models.TitleArea.CreateFromDiscriminatorValue); } },
                { "webParts", n => { WebParts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WebPart>(global::Microsoft.Graph.Beta.Models.WebPart.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CanvasLayout>("canvasLayout", CanvasLayout);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TitleArea>("titleArea", TitleArea);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WebPart>("webParts", WebParts);
        }
    }
}
#pragma warning restore CS0618
