using Microsoft.Graph.Beta.Models.Item;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SalesInvoiceLine : Entity, IParsable {
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
        /// <summary>The invoiceDiscountAllocation property</summary>
        public decimal? InvoiceDiscountAllocation { get; set; }
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
        /// <summary>The shipmentDate property</summary>
        public Date? ShipmentDate { get; set; }
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
        public static new SalesInvoiceLine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesInvoiceLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as SalesInvoiceLine).Account = n.GetObjectValue<Microsoft.Graph.Beta.Models.Account>(Microsoft.Graph.Beta.Models.Account.CreateFromDiscriminatorValue); } },
                {"accountId", (o,n) => { (o as SalesInvoiceLine).AccountId = n.GetStringValue(); } },
                {"amountExcludingTax", (o,n) => { (o as SalesInvoiceLine).AmountExcludingTax = n.GetDecimalValue(); } },
                {"amountIncludingTax", (o,n) => { (o as SalesInvoiceLine).AmountIncludingTax = n.GetDecimalValue(); } },
                {"description", (o,n) => { (o as SalesInvoiceLine).Description = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as SalesInvoiceLine).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as SalesInvoiceLine).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"discountPercent", (o,n) => { (o as SalesInvoiceLine).DiscountPercent = n.GetDecimalValue(); } },
                {"documentId", (o,n) => { (o as SalesInvoiceLine).DocumentId = n.GetStringValue(); } },
                {"invoiceDiscountAllocation", (o,n) => { (o as SalesInvoiceLine).InvoiceDiscountAllocation = n.GetDecimalValue(); } },
                {"item", (o,n) => { (o as SalesInvoiceLine).Item = n.GetObjectValue<Microsoft.Graph.Beta.Models.Item.Item>(Microsoft.Graph.Beta.Models.Item.Item.CreateFromDiscriminatorValue); } },
                {"itemId", (o,n) => { (o as SalesInvoiceLine).ItemId = n.GetStringValue(); } },
                {"lineType", (o,n) => { (o as SalesInvoiceLine).LineType = n.GetStringValue(); } },
                {"netAmount", (o,n) => { (o as SalesInvoiceLine).NetAmount = n.GetDecimalValue(); } },
                {"netAmountIncludingTax", (o,n) => { (o as SalesInvoiceLine).NetAmountIncludingTax = n.GetDecimalValue(); } },
                {"netTaxAmount", (o,n) => { (o as SalesInvoiceLine).NetTaxAmount = n.GetDecimalValue(); } },
                {"quantity", (o,n) => { (o as SalesInvoiceLine).Quantity = n.GetDecimalValue(); } },
                {"sequence", (o,n) => { (o as SalesInvoiceLine).Sequence = n.GetIntValue(); } },
                {"shipmentDate", (o,n) => { (o as SalesInvoiceLine).ShipmentDate = n.GetDateValue(); } },
                {"taxCode", (o,n) => { (o as SalesInvoiceLine).TaxCode = n.GetStringValue(); } },
                {"taxPercent", (o,n) => { (o as SalesInvoiceLine).TaxPercent = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as SalesInvoiceLine).TotalTaxAmount = n.GetDecimalValue(); } },
                {"unitOfMeasureId", (o,n) => { (o as SalesInvoiceLine).UnitOfMeasureId = n.GetStringValue(); } },
                {"unitPrice", (o,n) => { (o as SalesInvoiceLine).UnitPrice = n.GetDecimalValue(); } },
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
            writer.WriteDecimalValue("invoiceDiscountAllocation", InvoiceDiscountAllocation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Item.Item>("item", Item);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("lineType", LineType);
            writer.WriteDecimalValue("netAmount", NetAmount);
            writer.WriteDecimalValue("netAmountIncludingTax", NetAmountIncludingTax);
            writer.WriteDecimalValue("netTaxAmount", NetTaxAmount);
            writer.WriteDecimalValue("quantity", Quantity);
            writer.WriteIntValue("sequence", Sequence);
            writer.WriteDateValue("shipmentDate", ShipmentDate);
            writer.WriteStringValue("taxCode", TaxCode);
            writer.WriteDecimalValue("taxPercent", TaxPercent);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteStringValue("unitOfMeasureId", UnitOfMeasureId);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
