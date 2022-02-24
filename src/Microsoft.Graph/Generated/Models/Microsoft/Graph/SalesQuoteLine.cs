using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SalesQuoteLine : Entity, IParsable {
        public Account Account { get; set; }
        public string AccountId { get; set; }
        public decimal? AmountExcludingTax { get; set; }
        public decimal? AmountIncludingTax { get; set; }
        public string Description { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? DiscountAppliedBeforeTax { get; set; }
        public decimal? DiscountPercent { get; set; }
        public string DocumentId { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item Item { get; set; }
        public string ItemId { get; set; }
        public string LineType { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? NetAmountIncludingTax { get; set; }
        public decimal? NetTaxAmount { get; set; }
        public decimal? Quantity { get; set; }
        public int? Sequence { get; set; }
        public string TaxCode { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public string UnitOfMeasureId { get; set; }
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as SalesQuoteLine).Account = n.GetObjectValue<Account>(); } },
                {"accountId", (o,n) => { (o as SalesQuoteLine).AccountId = n.GetStringValue(); } },
                {"amountExcludingTax", (o,n) => { (o as SalesQuoteLine).AmountExcludingTax = n.GetDecimalValue(); } },
                {"amountIncludingTax", (o,n) => { (o as SalesQuoteLine).AmountIncludingTax = n.GetDecimalValue(); } },
                {"description", (o,n) => { (o as SalesQuoteLine).Description = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as SalesQuoteLine).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as SalesQuoteLine).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"discountPercent", (o,n) => { (o as SalesQuoteLine).DiscountPercent = n.GetDecimalValue(); } },
                {"documentId", (o,n) => { (o as SalesQuoteLine).DocumentId = n.GetStringValue(); } },
                {"item", (o,n) => { (o as SalesQuoteLine).Item = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>(); } },
                {"itemId", (o,n) => { (o as SalesQuoteLine).ItemId = n.GetStringValue(); } },
                {"lineType", (o,n) => { (o as SalesQuoteLine).LineType = n.GetStringValue(); } },
                {"netAmount", (o,n) => { (o as SalesQuoteLine).NetAmount = n.GetDecimalValue(); } },
                {"netAmountIncludingTax", (o,n) => { (o as SalesQuoteLine).NetAmountIncludingTax = n.GetDecimalValue(); } },
                {"netTaxAmount", (o,n) => { (o as SalesQuoteLine).NetTaxAmount = n.GetDecimalValue(); } },
                {"quantity", (o,n) => { (o as SalesQuoteLine).Quantity = n.GetDecimalValue(); } },
                {"sequence", (o,n) => { (o as SalesQuoteLine).Sequence = n.GetIntValue(); } },
                {"taxCode", (o,n) => { (o as SalesQuoteLine).TaxCode = n.GetStringValue(); } },
                {"taxPercent", (o,n) => { (o as SalesQuoteLine).TaxPercent = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as SalesQuoteLine).TotalTaxAmount = n.GetDecimalValue(); } },
                {"unitOfMeasureId", (o,n) => { (o as SalesQuoteLine).UnitOfMeasureId = n.GetStringValue(); } },
                {"unitPrice", (o,n) => { (o as SalesQuoteLine).UnitPrice = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Account>("account", Account);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteDecimalValue("amountExcludingTax", AmountExcludingTax);
            writer.WriteDecimalValue("amountIncludingTax", AmountIncludingTax);
            writer.WriteStringValue("description", Description);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDecimalValue("discountPercent", DiscountPercent);
            writer.WriteStringValue("documentId", DocumentId);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>("item", Item);
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
