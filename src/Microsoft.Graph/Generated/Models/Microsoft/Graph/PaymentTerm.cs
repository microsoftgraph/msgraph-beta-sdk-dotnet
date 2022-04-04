using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PaymentTerm : Entity, IParsable {
        /// <summary>The calculateDiscountOnCreditMemos property</summary>
        public bool? CalculateDiscountOnCreditMemos { get; set; }
        /// <summary>The code property</summary>
        public string Code { get; set; }
        /// <summary>The discountDateCalculation property</summary>
        public string DiscountDateCalculation { get; set; }
        /// <summary>The discountPercent property</summary>
        public decimal? DiscountPercent { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The dueDateCalculation property</summary>
        public string DueDateCalculation { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PaymentTerm CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PaymentTerm();
        }
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
