// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class EducationalActivity : Microsoft.Graph.Beta.Models.ItemFacet, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The month and year the user graduated or completed the activity.</summary>
        public Date? CompletionMonthYear
        {
            get { return BackingStore?.Get<Date?>("completionMonthYear"); }
            set { BackingStore?.Set("completionMonthYear", value); }
        }
        /// <summary>The month and year the user completed the educational activity referenced.</summary>
        public Date? EndMonthYear
        {
            get { return BackingStore?.Get<Date?>("endMonthYear"); }
            set { BackingStore?.Set("endMonthYear", value); }
        }
        /// <summary>The institution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.InstitutionData? Institution
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InstitutionData?>("institution"); }
            set { BackingStore?.Set("institution", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.InstitutionData Institution
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InstitutionData>("institution"); }
            set { BackingStore?.Set("institution", value); }
        }
#endif
        /// <summary>The program property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.EducationalActivityDetail? Program
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EducationalActivityDetail?>("program"); }
            set { BackingStore?.Set("program", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.EducationalActivityDetail Program
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EducationalActivityDetail>("program"); }
            set { BackingStore?.Set("program", value); }
        }
#endif
        /// <summary>The month and year the user commenced the activity referenced.</summary>
        public Date? StartMonthYear
        {
            get { return BackingStore?.Get<Date?>("startMonthYear"); }
            set { BackingStore?.Set("startMonthYear", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.EducationalActivity"/> and sets the default values.
        /// </summary>
        public EducationalActivity() : base()
        {
            OdataType = "#microsoft.graph.educationalActivity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EducationalActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.EducationalActivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.EducationalActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completionMonthYear", n => { CompletionMonthYear = n.GetDateValue(); } },
                { "endMonthYear", n => { EndMonthYear = n.GetDateValue(); } },
                { "institution", n => { Institution = n.GetObjectValue<Microsoft.Graph.Beta.Models.InstitutionData>(Microsoft.Graph.Beta.Models.InstitutionData.CreateFromDiscriminatorValue); } },
                { "program", n => { Program = n.GetObjectValue<Microsoft.Graph.Beta.Models.EducationalActivityDetail>(Microsoft.Graph.Beta.Models.EducationalActivityDetail.CreateFromDiscriminatorValue); } },
                { "startMonthYear", n => { StartMonthYear = n.GetDateValue(); } },
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
            writer.WriteDateValue("completionMonthYear", CompletionMonthYear);
            writer.WriteDateValue("endMonthYear", EndMonthYear);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.InstitutionData>("institution", Institution);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EducationalActivityDetail>("program", Program);
            writer.WriteDateValue("startMonthYear", StartMonthYear);
        }
    }
}
