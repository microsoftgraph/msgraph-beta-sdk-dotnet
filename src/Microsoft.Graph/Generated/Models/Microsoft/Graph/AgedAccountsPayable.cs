using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AgedAccountsPayable : Entity, IParsable {
        public Date? AgedAsOfDate { get; set; }
        public decimal? BalanceDue { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrentAmount { get; set; }
        public string Name { get; set; }
        public decimal? Period1Amount { get; set; }
        public decimal? Period2Amount { get; set; }
        public decimal? Period3Amount { get; set; }
        public string PeriodLengthFilter { get; set; }
        public string VendorNumber { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agedAsOfDate", (o,n) => { (o as AgedAccountsPayable).AgedAsOfDate = n.GetDateValue(); } },
                {"balanceDue", (o,n) => { (o as AgedAccountsPayable).BalanceDue = n.GetDecimalValue(); } },
                {"currencyCode", (o,n) => { (o as AgedAccountsPayable).CurrencyCode = n.GetStringValue(); } },
                {"currentAmount", (o,n) => { (o as AgedAccountsPayable).CurrentAmount = n.GetDecimalValue(); } },
                {"name", (o,n) => { (o as AgedAccountsPayable).Name = n.GetStringValue(); } },
                {"period1Amount", (o,n) => { (o as AgedAccountsPayable).Period1Amount = n.GetDecimalValue(); } },
                {"period2Amount", (o,n) => { (o as AgedAccountsPayable).Period2Amount = n.GetDecimalValue(); } },
                {"period3Amount", (o,n) => { (o as AgedAccountsPayable).Period3Amount = n.GetDecimalValue(); } },
                {"periodLengthFilter", (o,n) => { (o as AgedAccountsPayable).PeriodLengthFilter = n.GetStringValue(); } },
                {"vendorNumber", (o,n) => { (o as AgedAccountsPayable).VendorNumber = n.GetStringValue(); } },
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
