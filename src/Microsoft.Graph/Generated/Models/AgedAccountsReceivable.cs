using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AgedAccountsReceivable : Entity, IParsable {
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode {
            get { return BackingStore?.Get<string?>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#nullable restore
#else
        public string CurrencyCode {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#endif
        /// <summary>The currentAmount property</summary>
        public decimal? CurrentAmount {
            get { return BackingStore?.Get<decimal?>("currentAmount"); }
            set { BackingStore?.Set("currentAmount", value); }
        }
        /// <summary>The customerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNumber {
            get { return BackingStore?.Get<string?>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
#nullable restore
#else
        public string CustomerNumber {
            get { return BackingStore?.Get<string>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PeriodLengthFilter {
            get { return BackingStore?.Get<string?>("periodLengthFilter"); }
            set { BackingStore?.Set("periodLengthFilter", value); }
        }
#nullable restore
#else
        public string PeriodLengthFilter {
            get { return BackingStore?.Get<string>("periodLengthFilter"); }
            set { BackingStore?.Set("periodLengthFilter", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AgedAccountsReceivable CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AgedAccountsReceivable();
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
                {"customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"period1Amount", n => { Period1Amount = n.GetDecimalValue(); } },
                {"period2Amount", n => { Period2Amount = n.GetDecimalValue(); } },
                {"period3Amount", n => { Period3Amount = n.GetDecimalValue(); } },
                {"periodLengthFilter", n => { PeriodLengthFilter = n.GetStringValue(); } },
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
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteStringValue("name", Name);
            writer.WriteDecimalValue("period1Amount", Period1Amount);
            writer.WriteDecimalValue("period2Amount", Period2Amount);
            writer.WriteDecimalValue("period3Amount", Period3Amount);
            writer.WriteStringValue("periodLengthFilter", PeriodLengthFilter);
        }
    }
}
