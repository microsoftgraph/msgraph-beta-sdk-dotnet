using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class EducationalActivity : ItemFacet, IParsable {
        /// <summary>The month and year the user graduated or completed the activity.</summary>
        public Date? CompletionMonthYear { get; set; }
        /// <summary>The month and year the user completed the educational activity referenced.</summary>
        public Date? EndMonthYear { get; set; }
        public InstitutionData Institution { get; set; }
        public EducationalActivityDetail Program { get; set; }
        /// <summary>The month and year the user commenced the activity referenced.</summary>
        public Date? StartMonthYear { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"completionMonthYear", (o,n) => { (o as EducationalActivity).CompletionMonthYear = n.GetDateValue(); } },
                {"endMonthYear", (o,n) => { (o as EducationalActivity).EndMonthYear = n.GetDateValue(); } },
                {"institution", (o,n) => { (o as EducationalActivity).Institution = n.GetObjectValue<InstitutionData>(); } },
                {"program", (o,n) => { (o as EducationalActivity).Program = n.GetObjectValue<EducationalActivityDetail>(); } },
                {"startMonthYear", (o,n) => { (o as EducationalActivity).StartMonthYear = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("completionMonthYear", CompletionMonthYear);
            writer.WriteDateValue("endMonthYear", EndMonthYear);
            writer.WriteObjectValue<InstitutionData>("institution", Institution);
            writer.WriteObjectValue<EducationalActivityDetail>("program", Program);
            writer.WriteDateValue("startMonthYear", StartMonthYear);
        }
    }
}
