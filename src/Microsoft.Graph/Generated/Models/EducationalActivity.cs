using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationalActivity : ItemFacet, IParsable {
        /// <summary>The month and year the user graduated or completed the activity.</summary>
        public Date? CompletionMonthYear {
            get { return BackingStore?.Get<Date?>("completionMonthYear"); }
            set { BackingStore?.Set("completionMonthYear", value); }
        }
        /// <summary>The month and year the user completed the educational activity referenced.</summary>
        public Date? EndMonthYear {
            get { return BackingStore?.Get<Date?>("endMonthYear"); }
            set { BackingStore?.Set("endMonthYear", value); }
        }
        /// <summary>The institution property</summary>
        public InstitutionData Institution {
            get { return BackingStore?.Get<InstitutionData>("institution"); }
            set { BackingStore?.Set("institution", value); }
        }
        /// <summary>The program property</summary>
        public EducationalActivityDetail Program {
            get { return BackingStore?.Get<EducationalActivityDetail>("program"); }
            set { BackingStore?.Set("program", value); }
        }
        /// <summary>The month and year the user commenced the activity referenced.</summary>
        public Date? StartMonthYear {
            get { return BackingStore?.Get<Date?>("startMonthYear"); }
            set { BackingStore?.Set("startMonthYear", value); }
        }
        /// <summary>
        /// Instantiates a new EducationalActivity and sets the default values.
        /// </summary>
        public EducationalActivity() : base() {
            OdataType = "#microsoft.graph.educationalActivity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationalActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationalActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completionMonthYear", n => { CompletionMonthYear = n.GetDateValue(); } },
                {"endMonthYear", n => { EndMonthYear = n.GetDateValue(); } },
                {"institution", n => { Institution = n.GetObjectValue<InstitutionData>(InstitutionData.CreateFromDiscriminatorValue); } },
                {"program", n => { Program = n.GetObjectValue<EducationalActivityDetail>(EducationalActivityDetail.CreateFromDiscriminatorValue); } },
                {"startMonthYear", n => { StartMonthYear = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
