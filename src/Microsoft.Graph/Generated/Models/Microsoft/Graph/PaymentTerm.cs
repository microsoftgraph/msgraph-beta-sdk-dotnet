using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PaymentTerm : Entity, IParsable {
        public bool? CalculateDiscountOnCreditMemos { get; set; }
        public string Code { get; set; }
        public string DiscountDateCalculation { get; set; }
        public decimal? DiscountPercent { get; set; }
        public string DisplayName { get; set; }
        public string DueDateCalculation { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"calculateDiscountOnCreditMemos", (o,n) => { (o as PaymentTerm).CalculateDiscountOnCreditMemos = n.GetBoolValue(); } },
                {"code", (o,n) => { (o as PaymentTerm).Code = n.GetStringValue(); } },
                {"discountDateCalculation", (o,n) => { (o as PaymentTerm).DiscountDateCalculation = n.GetStringValue(); } },
                {"discountPercent", (o,n) => { (o as PaymentTerm).DiscountPercent = n.GetDecimalValue(); } },
                {"displayName", (o,n) => { (o as PaymentTerm).DisplayName = n.GetStringValue(); } },
                {"dueDateCalculation", (o,n) => { (o as PaymentTerm).DueDateCalculation = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as PaymentTerm).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("calculateDiscountOnCreditMemos", CalculateDiscountOnCreditMemos);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("discountDateCalculation", DiscountDateCalculation);
            writer.WriteDecimalValue("discountPercent", DiscountPercent);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("dueDateCalculation", DueDateCalculation);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
