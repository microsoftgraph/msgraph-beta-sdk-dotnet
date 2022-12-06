using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AgedAccountsPayable : Entity, IParsable {
        /// <summary>The agedAsOfDate property</summary>
        public Date? AgedAsOfDate {
            get { return BackingStore?.Get<Date?>("agedAsOfDate"); }
            set { BackingStore?.Set("agedAsOfDate", value); }
        }
        /// <summary>The balanceDue property</summary>
        public decimal? BalanceDue {
            get { return BackingStore?.Get<decimal?>("balanceDue"); }
            set { BackingStore?.Set("balanceDue", value); }
        }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
        /// <summary>The currentAmount property</summary>
        public decimal? CurrentAmount {
            get { return BackingStore?.Get<decimal?>("currentAmount"); }
            set { BackingStore?.Set("currentAmount", value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The period1Amount property</summary>
        public decimal? Period1Amount {
            get { return BackingStore?.Get<decimal?>("period1Amount"); }
            set { BackingStore?.Set("period1Amount", value); }
        }
        /// <summary>The period2Amount property</summary>
        public decimal? Period2Amount {
            get { return BackingStore?.Get<decimal?>("period2Amount"); }
            set { BackingStore?.Set("period2Amount", value); }
        }
        /// <summary>The period3Amount property</summary>
        public decimal? Period3Amount {
            get { return BackingStore?.Get<decimal?>("period3Amount"); }
            set { BackingStore?.Set("period3Amount", value); }
        }
        /// <summary>The periodLengthFilter property</summary>
        public string PeriodLengthFilter {
            get { return BackingStore?.Get<string>("periodLengthFilter"); }
            set { BackingStore?.Set("periodLengthFilter", value); }
        }
        /// <summary>The vendorNumber property</summary>
        public string VendorNumber {
            get { return BackingStore?.Get<string>("vendorNumber"); }
            set { BackingStore?.Set("vendorNumber", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
