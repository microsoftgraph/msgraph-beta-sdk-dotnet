using Microsoft.Graph.Beta.Models.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SalesQuoteLine : Entity, IParsable {
        /// <summary>The account property</summary>
        public Microsoft.Graph.Beta.Models.Account Account { get; set; }
        /// <summary>The accountId property</summary>
        public string AccountId { get; set; }
        /// <summary>The amountExcludingTax property</summary>
        public decimal? AmountExcludingTax { get; set; }
        /// <summary>The amountIncludingTax property</summary>
        public decimal? AmountIncludingTax { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount { get; set; }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax { get; set; }
        /// <summary>The discountPercent property</summary>
        public decimal? DiscountPercent { get; set; }
        /// <summary>The documentId property</summary>
        public string DocumentId { get; set; }
        /// <summary>The item property</summary>
        public Microsoft.Graph.Beta.Models.Item.Item Item { get; set; }
        /// <summary>The itemId property</summary>
        public string ItemId { get; set; }
        /// <summary>The lineType property</summary>
        public string LineType { get; set; }
        /// <summary>The netAmount property</summary>
        public decimal? NetAmount { get; set; }
        /// <summary>The netAmountIncludingTax property</summary>
        public decimal? NetAmountIncludingTax { get; set; }
        /// <summary>The netTaxAmount property</summary>
        public decimal? NetTaxAmount { get; set; }
        /// <summary>The quantity property</summary>
        public decimal? Quantity { get; set; }
        /// <summary>The sequence property</summary>
        public int? Sequence { get; set; }
        /// <summary>The taxCode property</summary>
        public string TaxCode { get; set; }
        /// <summary>The taxPercent property</summary>
        public decimal? TaxPercent { get; set; }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount { get; set; }
        /// <summary>The unitOfMeasureId property</summary>
        public string UnitOfMeasureId { get; set; }
        /// <summary>The unitPrice property</summary>
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesQuoteLine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesQuoteLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"account", n => { Account = n.GetObjectValue<Microsoft.Graph.Beta.Models.Account>(Microsoft.Graph.Beta.Models.Account.CreateFromDiscriminatorValue); } },
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"amountExcludingTax", n => { AmountExcludingTax = n.GetDecimalValue(); } },
                {"amountIncludingTax", n => { AmountIncludingTax = n.GetDecimalValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", n => { DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"discountPercent", n => { DiscountPercent = n.GetDecimalValue(); } },
                {"documentId", n => { DocumentId = n.GetStringValue(); } },
                {"item", n => { Item = n.GetObjectValue<Microsoft.Graph.Beta.Models.Item.Item>(Microsoft.Graph.Beta.Models.Item.Item.CreateFromDiscriminatorValue); } },
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"lineType", n => { LineType = n.GetStringValue(); } },
                {"netAmount", n => { NetAmount = n.GetDecimalValue(); } },
                {"netAmountIncludingTax", n => { NetAmountIncludingTax = n.GetDecimalValue(); } },
                {"netTaxAmount", n => { NetTaxAmount = n.GetDecimalValue(); } },
                {"quantity", n => { Quantity = n.GetDecimalValue(); } },
                {"sequence", n => { Sequence = n.GetIntValue(); } },
                {"taxCode", n => { TaxCode = n.GetStringValue(); } },
                {"taxPercent", n => { TaxPercent = n.GetDecimalValue(); } },
                {"totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
                {"unitOfMeasureId", n => { UnitOfMeasureId = n.GetStringValue(); } },
                {"unitPrice", n => { UnitPrice = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Account>("account", Account);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteDecimalValue("amountExcludingTax", AmountExcludingTax);
            writer.WriteDecimalValue("amountIncludingTax", AmountIncludingTax);
            writer.WriteStringValue("description", Description);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDecimalValue("discountPercent", DiscountPercent);
            writer.WriteStringValue("documentId", DocumentId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Item.Item>("item", Item);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("lineType", LineType);
            writer.WriteDecimalValue("netAmount", NetAmount);
            writer.WriteDecimalValue("netAmountIncludingTax", NetAmountIncludingTax);
            writer.WriteDecimalValue("netTaxAmount", NetTaxAmount);
            writer.WriteDecimalValue("quantity", Quantity);
            writer.WriteIntValue("sequence", Sequence);
            writer.WriteStringValue("taxCode", TaxCode);
            writer.WriteDecimalValue("taxPercent", TaxPercent);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteStringValue("unitOfMeasureId", UnitOfMeasureId);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
