// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class InactiveUsersByApplicationMetricBase : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The appId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>The factDate property</summary>
        public Date? FactDate
        {
            get { return BackingStore?.Get<Date?>("factDate"); }
            set { BackingStore?.Set("factDate", value); }
        }
        /// <summary>The inactive30DayCount property</summary>
        public long? Inactive30DayCount
        {
            get { return BackingStore?.Get<long?>("inactive30DayCount"); }
            set { BackingStore?.Set("inactive30DayCount", value); }
        }
        /// <summary>The inactive60DayCount property</summary>
        public long? Inactive60DayCount
        {
            get { return BackingStore?.Get<long?>("inactive60DayCount"); }
            set { BackingStore?.Set("inactive60DayCount", value); }
        }
        /// <summary>The inactive90DayCount property</summary>
        public long? Inactive90DayCount
        {
            get { return BackingStore?.Get<long?>("inactive90DayCount"); }
            set { BackingStore?.Set("inactive90DayCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.InactiveUsersByApplicationMetricBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.InactiveUsersByApplicationMetricBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.dailyInactiveUsersByApplicationMetric" => new global::Microsoft.Graph.Beta.Models.DailyInactiveUsersByApplicationMetric(),
                "#microsoft.graph.monthlyInactiveUsersByApplicationMetric" => new global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric(),
                _ => new global::Microsoft.Graph.Beta.Models.InactiveUsersByApplicationMetricBase(),
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
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "factDate", n => { FactDate = n.GetDateValue(); } },
                { "inactive30DayCount", n => { Inactive30DayCount = n.GetLongValue(); } },
                { "inactive60DayCount", n => { Inactive60DayCount = n.GetLongValue(); } },
                { "inactive90DayCount", n => { Inactive90DayCount = n.GetLongValue(); } },
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
            writer.WriteStringValue("appId", AppId);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteLongValue("inactive30DayCount", Inactive30DayCount);
            writer.WriteLongValue("inactive60DayCount", Inactive60DayCount);
            writer.WriteLongValue("inactive90DayCount", Inactive90DayCount);
        }
    }
}
#pragma warning restore CS0618
