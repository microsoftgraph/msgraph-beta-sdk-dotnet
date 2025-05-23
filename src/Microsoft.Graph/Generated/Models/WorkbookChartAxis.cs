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
    public partial class WorkbookChartAxis : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the formatting of a chart object, which includes line and font formatting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WorkbookChartAxisFormat? Format
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartAxisFormat?>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WorkbookChartAxisFormat Format
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartAxisFormat>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#endif
        /// <summary>Returns a gridlines object that represents the major gridlines for the specified axis. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines? MajorGridlines
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines?>("majorGridlines"); }
            set { BackingStore?.Set("majorGridlines", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines MajorGridlines
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines>("majorGridlines"); }
            set { BackingStore?.Set("majorGridlines", value); }
        }
#endif
        /// <summary>Represents the interval between two major tick marks. Can be set to a numeric value or an empty string.  The returned value is always a number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? MajorUnit
        {
            get { return BackingStore?.Get<UntypedNode?>("majorUnit"); }
            set { BackingStore?.Set("majorUnit", value); }
        }
#nullable restore
#else
        public UntypedNode MajorUnit
        {
            get { return BackingStore?.Get<UntypedNode>("majorUnit"); }
            set { BackingStore?.Set("majorUnit", value); }
        }
#endif
        /// <summary>Represents the maximum value on the value axis.  Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Maximum
        {
            get { return BackingStore?.Get<UntypedNode?>("maximum"); }
            set { BackingStore?.Set("maximum", value); }
        }
#nullable restore
#else
        public UntypedNode Maximum
        {
            get { return BackingStore?.Get<UntypedNode>("maximum"); }
            set { BackingStore?.Set("maximum", value); }
        }
#endif
        /// <summary>Represents the minimum value on the value axis. Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Minimum
        {
            get { return BackingStore?.Get<UntypedNode?>("minimum"); }
            set { BackingStore?.Set("minimum", value); }
        }
#nullable restore
#else
        public UntypedNode Minimum
        {
            get { return BackingStore?.Get<UntypedNode>("minimum"); }
            set { BackingStore?.Set("minimum", value); }
        }
#endif
        /// <summary>Returns a Gridlines object that represents the minor gridlines for the specified axis. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines? MinorGridlines
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines?>("minorGridlines"); }
            set { BackingStore?.Set("minorGridlines", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines MinorGridlines
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines>("minorGridlines"); }
            set { BackingStore?.Set("minorGridlines", value); }
        }
#endif
        /// <summary>Represents the interval between two minor tick marks. &apos;Can be set to a numeric value or an empty string (for automatic axis values). The returned value is always a number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? MinorUnit
        {
            get { return BackingStore?.Get<UntypedNode?>("minorUnit"); }
            set { BackingStore?.Set("minorUnit", value); }
        }
#nullable restore
#else
        public UntypedNode MinorUnit
        {
            get { return BackingStore?.Get<UntypedNode>("minorUnit"); }
            set { BackingStore?.Set("minorUnit", value); }
        }
#endif
        /// <summary>Represents the axis title. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WorkbookChartAxisTitle? Title
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartAxisTitle?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WorkbookChartAxisTitle Title
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartAxisTitle>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WorkbookChartAxis"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WorkbookChartAxis CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WorkbookChartAxis();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "format", n => { Format = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartAxisFormat>(global::Microsoft.Graph.Beta.Models.WorkbookChartAxisFormat.CreateFromDiscriminatorValue); } },
                { "majorGridlines", n => { MajorGridlines = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines>(global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines.CreateFromDiscriminatorValue); } },
                { "majorUnit", n => { MajorUnit = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "maximum", n => { Maximum = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "minimum", n => { Minimum = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "minorGridlines", n => { MinorGridlines = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines>(global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines.CreateFromDiscriminatorValue); } },
                { "minorUnit", n => { MinorUnit = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "title", n => { Title = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartAxisTitle>(global::Microsoft.Graph.Beta.Models.WorkbookChartAxisTitle.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartAxisFormat>("format", Format);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines>("majorGridlines", MajorGridlines);
            writer.WriteObjectValue<UntypedNode>("majorUnit", MajorUnit);
            writer.WriteObjectValue<UntypedNode>("maximum", Maximum);
            writer.WriteObjectValue<UntypedNode>("minimum", Minimum);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartGridlines>("minorGridlines", MinorGridlines);
            writer.WriteObjectValue<UntypedNode>("minorUnit", MinorUnit);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartAxisTitle>("title", Title);
        }
    }
}
#pragma warning restore CS0618
