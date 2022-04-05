using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PositionDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Detail about the company or employer.</summary>
        public CompanyDetail Company { get; set; }
        /// <summary>Description of the position in question.</summary>
        public string Description { get; set; }
        /// <summary>When the position ended.</summary>
        public Date? EndMonthYear { get; set; }
        /// <summary>The title held when in that position.</summary>
        public string JobTitle { get; set; }
        /// <summary>The role the position entailed.</summary>
        public string Role { get; set; }
        /// <summary>The start month and year of the position.</summary>
        public Date? StartMonthYear { get; set; }
        /// <summary>Short summary of the position.</summary>
        public string Summary { get; set; }
        /// <summary>
        /// Instantiates a new positionDetail and sets the default values.
        /// </summary>
        public PositionDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PositionDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PositionDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"company", (o,n) => { (o as PositionDetail).Company = n.GetObjectValue<CompanyDetail>(CompanyDetail.CreateFromDiscriminatorValue); } },
                {"description", (o,n) => { (o as PositionDetail).Description = n.GetStringValue(); } },
                {"endMonthYear", (o,n) => { (o as PositionDetail).EndMonthYear = n.GetDateValue(); } },
                {"jobTitle", (o,n) => { (o as PositionDetail).JobTitle = n.GetStringValue(); } },
                {"role", (o,n) => { (o as PositionDetail).Role = n.GetStringValue(); } },
                {"startMonthYear", (o,n) => { (o as PositionDetail).StartMonthYear = n.GetDateValue(); } },
                {"summary", (o,n) => { (o as PositionDetail).Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CompanyDetail>("company", Company);
            writer.WriteStringValue("description", Description);
            writer.WriteDateValue("endMonthYear", EndMonthYear);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("role", Role);
            writer.WriteDateValue("startMonthYear", StartMonthYear);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
