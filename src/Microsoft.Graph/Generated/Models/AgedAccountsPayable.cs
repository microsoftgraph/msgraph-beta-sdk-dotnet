using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AgedAccountsPayable : Entity, IParsable {
        /// <summary>The agedAsOfDate property</summary>
        public Date? AgedAsOfDate { get; set; }
        /// <summary>The balanceDue property</summary>
        public decimal? BalanceDue { get; set; }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode { get; set; }
        /// <summary>The currentAmount property</summary>
        public decimal? CurrentAmount { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The period1Amount property</summary>
        public decimal? Period1Amount { get; set; }
        /// <summary>The period2Amount property</summary>
        public decimal? Period2Amount { get; set; }
        /// <summary>The period3Amount property</summary>
        public decimal? Period3Amount { get; set; }
        /// <summary>The periodLengthFilter property</summary>
        public string PeriodLengthFilter { get; set; }
        /// <summary>The vendorNumber property</summary>
        public string VendorNumber { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AgedAccountsPayable CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AgedAccountsPayable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agedAsOfDate", n => { AgedAsOfDate = n.GetDateValue(); } },
                {"balanceDue", n => { BalanceDue = n.GetDecimalValue(); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currentAmount", n => { CurrentAmount = n.GetDecimalValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"period1Amount", n => { Period1Amount = n.GetDecimalValue(); } },
                {"period2Amount", n => { Period2Amount = n.GetDecimalValue(); } },
                {"period3Amount", n => { Period3Amount = n.GetDecimalValue(); } },
                {"periodLengthFilter", n => { PeriodLengthFilter = n.GetStringValue(); } },
                {"vendorNumber", n => { VendorNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("agedAsOfDate", AgedAsOfDate);
            writer.WriteDecimalValue("balanceDue", BalanceDue);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteDecimalValue("currentAmount", CurrentAmount);
            writer.WriteStringValue("name", Name);
            writer.WriteDecimalValue("period1Amount", Period1Amount);
            writer.WriteDecimalValue("period2Amount", Period2Amount);
            writer.WriteDecimalValue("period3Amount", Period3Amount);
            writer.WriteStringValue("periodLengthFilter", PeriodLengthFilter);
            writer.WriteStringValue("vendorNumber", VendorNumber);
        }
    }
}
