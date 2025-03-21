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
    public partial class UserInsightsRoot : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Summaries of daily user activities on apps registered in your tenant that is configured for Microsoft Entra External ID for customers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot? Daily
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot?>("daily"); }
            set { BackingStore?.Set("daily", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot Daily
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot>("daily"); }
            set { BackingStore?.Set("daily", value); }
        }
#endif
        /// <summary>Summaries of monthly user activities on apps registered in your tenant that is configured for Microsoft Entra External ID for customers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot? Monthly
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot?>("monthly"); }
            set { BackingStore?.Set("monthly", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot Monthly
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot>("monthly"); }
            set { BackingStore?.Set("monthly", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.UserInsightsRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.UserInsightsRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.UserInsightsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "daily", n => { Daily = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot>(global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot.CreateFromDiscriminatorValue); } },
                { "monthly", n => { Monthly = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot>(global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot>("daily", Daily);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot>("monthly", Monthly);
        }
    }
}
#pragma warning restore CS0618
