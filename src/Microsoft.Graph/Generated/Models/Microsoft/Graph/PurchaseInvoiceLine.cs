using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PurchaseInvoiceLine : Entity, IParsable {
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Account Account { get; set; }
        public string AccountId { get; set; }
        public decimal? AmountExcludingTax { get; set; }
        public decimal? AmountIncludingTax { get; set; }
        public string Description { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? DiscountAppliedBeforeTax { get; set; }
        public decimal? DiscountPercent { get; set; }
        public string DocumentId { get; set; }
        public Date? ExpectedReceiptDate { get; set; }
        public decimal? InvoiceDiscountAllocation { get; set; }
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
        public decimal? UnitCost { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PurchaseInvoiceLine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PurchaseInvoiceLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as PurchaseInvoiceLine).Account = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Account>(MicrosoftGraphSdk.Models.Microsoft.Graph.Account.CreateFromDiscriminatorValue); } },
                {"accountId", (o,n) => { (o as PurchaseInvoiceLine).AccountId = n.GetStringValue(); } },
                {"amountExcludingTax", (o,n) => { (o as PurchaseInvoiceLine).AmountExcludingTax = n.GetDecimalValue(); } },
                {"amountIncludingTax", (o,n) => { (o as PurchaseInvoiceLine).AmountIncludingTax = n.GetDecimalValue(); } },
                {"description", (o,n) => { (o as PurchaseInvoiceLine).Description = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as PurchaseInvoiceLine).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as PurchaseInvoiceLine).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"discountPercent", (o,n) => { (o as PurchaseInvoiceLine).DiscountPercent = n.GetDecimalValue(); } },
                {"documentId", (o,n) => { (o as PurchaseInvoiceLine).DocumentId = n.GetStringValue(); } },
                {"expectedReceiptDate", (o,n) => { (o as PurchaseInvoiceLine).ExpectedReceiptDate = n.GetDateValue(); } },
                {"invoiceDiscountAllocation", (o,n) => { (o as PurchaseInvoiceLine).InvoiceDiscountAllocation = n.GetDecimalValue(); } },
                {"item", (o,n) => { (o as PurchaseInvoiceLine).Item = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>(MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item.CreateFromDiscriminatorValue); } },
                {"itemId", (o,n) => { (o as PurchaseInvoiceLine).ItemId = n.GetStringValue(); } },
                {"lineType", (o,n) => { (o as PurchaseInvoiceLine).LineType = n.GetStringValue(); } },
                {"netAmount", (o,n) => { (o as PurchaseInvoiceLine).NetAmount = n.GetDecimalValue(); } },
                {"netAmountIncludingTax", (o,n) => { (o as PurchaseInvoiceLine).NetAmountIncludingTax = n.GetDecimalValue(); } },
                {"netTaxAmount", (o,n) => { (o as PurchaseInvoiceLine).NetTaxAmount = n.GetDecimalValue(); } },
                {"quantity", (o,n) => { (o as PurchaseInvoiceLine).Quantity = n.GetDecimalValue(); } },
                {"sequence", (o,n) => { (o as PurchaseInvoiceLine).Sequence = n.GetIntValue(); } },
                {"taxCode", (o,n) => { (o as PurchaseInvoiceLine).TaxCode = n.GetStringValue(); } },
                {"taxPercent", (o,n) => { (o as PurchaseInvoiceLine).TaxPercent = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as PurchaseInvoiceLine).TotalTaxAmount = n.GetDecimalValue(); } },
                {"unitCost", (o,n) => { (o as PurchaseInvoiceLine).UnitCost = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Account>("account", Account);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteDecimalValue("amountExcludingTax", AmountExcludingTax);
            writer.WriteDecimalValue("amountIncludingTax", AmountIncludingTax);
            writer.WriteStringValue("description", Description);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDecimalValue("discountPercent", DiscountPercent);
            writer.WriteStringValue("documentId", DocumentId);
            writer.WriteDateValue("expectedReceiptDate", ExpectedReceiptDate);
            writer.WriteDecimalValue("invoiceDiscountAllocation", InvoiceDiscountAllocation);
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
            writer.WriteDecimalValue("unitCost", UnitCost);
        }
    }
}
