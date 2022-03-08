using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the financials singleton.</summary>
    public class SalesOrderLine : Entity, IParsable {
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Account Account { get; set; }
        public string AccountId { get; set; }
        public decimal? AmountExcludingTax { get; set; }
        public decimal? AmountIncludingTax { get; set; }
        public string Description { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? DiscountAppliedBeforeTax { get; set; }
        public decimal? DiscountPercent { get; set; }
        public string DocumentId { get; set; }
        public decimal? InvoiceDiscountAllocation { get; set; }
        public decimal? InvoicedQuantity { get; set; }
        public decimal? InvoiceQuantity { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item Item { get; set; }
        public string ItemId { get; set; }
        public string LineType { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? NetAmountIncludingTax { get; set; }
        public decimal? NetTaxAmount { get; set; }
        public decimal? Quantity { get; set; }
        public int? Sequence { get; set; }
        public Date? ShipmentDate { get; set; }
        public decimal? ShippedQuantity { get; set; }
        public decimal? ShipQuantity { get; set; }
        public string TaxCode { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public string UnitOfMeasureId { get; set; }
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesOrderLine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesOrderLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as SalesOrderLine).Account = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Account>(MicrosoftGraphSdk.Models.Microsoft.Graph.Account.CreateFromDiscriminatorValue); } },
                {"accountId", (o,n) => { (o as SalesOrderLine).AccountId = n.GetStringValue(); } },
                {"amountExcludingTax", (o,n) => { (o as SalesOrderLine).AmountExcludingTax = n.GetDecimalValue(); } },
                {"amountIncludingTax", (o,n) => { (o as SalesOrderLine).AmountIncludingTax = n.GetDecimalValue(); } },
                {"description", (o,n) => { (o as SalesOrderLine).Description = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as SalesOrderLine).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as SalesOrderLine).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"discountPercent", (o,n) => { (o as SalesOrderLine).DiscountPercent = n.GetDecimalValue(); } },
                {"documentId", (o,n) => { (o as SalesOrderLine).DocumentId = n.GetStringValue(); } },
                {"invoiceDiscountAllocation", (o,n) => { (o as SalesOrderLine).InvoiceDiscountAllocation = n.GetDecimalValue(); } },
                {"invoicedQuantity", (o,n) => { (o as SalesOrderLine).InvoicedQuantity = n.GetDecimalValue(); } },
                {"invoiceQuantity", (o,n) => { (o as SalesOrderLine).InvoiceQuantity = n.GetDecimalValue(); } },
                {"item", (o,n) => { (o as SalesOrderLine).Item = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>(MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item.CreateFromDiscriminatorValue); } },
                {"itemId", (o,n) => { (o as SalesOrderLine).ItemId = n.GetStringValue(); } },
                {"lineType", (o,n) => { (o as SalesOrderLine).LineType = n.GetStringValue(); } },
                {"netAmount", (o,n) => { (o as SalesOrderLine).NetAmount = n.GetDecimalValue(); } },
                {"netAmountIncludingTax", (o,n) => { (o as SalesOrderLine).NetAmountIncludingTax = n.GetDecimalValue(); } },
                {"netTaxAmount", (o,n) => { (o as SalesOrderLine).NetTaxAmount = n.GetDecimalValue(); } },
                {"quantity", (o,n) => { (o as SalesOrderLine).Quantity = n.GetDecimalValue(); } },
                {"sequence", (o,n) => { (o as SalesOrderLine).Sequence = n.GetIntValue(); } },
                {"shipmentDate", (o,n) => { (o as SalesOrderLine).ShipmentDate = n.GetDateValue(); } },
                {"shippedQuantity", (o,n) => { (o as SalesOrderLine).ShippedQuantity = n.GetDecimalValue(); } },
                {"shipQuantity", (o,n) => { (o as SalesOrderLine).ShipQuantity = n.GetDecimalValue(); } },
                {"taxCode", (o,n) => { (o as SalesOrderLine).TaxCode = n.GetStringValue(); } },
                {"taxPercent", (o,n) => { (o as SalesOrderLine).TaxPercent = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as SalesOrderLine).TotalTaxAmount = n.GetDecimalValue(); } },
                {"unitOfMeasureId", (o,n) => { (o as SalesOrderLine).UnitOfMeasureId = n.GetStringValue(); } },
                {"unitPrice", (o,n) => { (o as SalesOrderLine).UnitPrice = n.GetDecimalValue(); } },
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
            writer.WriteDecimalValue("invoiceDiscountAllocation", InvoiceDiscountAllocation);
            writer.WriteDecimalValue("invoicedQuantity", InvoicedQuantity);
            writer.WriteDecimalValue("invoiceQuantity", InvoiceQuantity);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>("item", Item);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("lineType", LineType);
            writer.WriteDecimalValue("netAmount", NetAmount);
            writer.WriteDecimalValue("netAmountIncludingTax", NetAmountIncludingTax);
            writer.WriteDecimalValue("netTaxAmount", NetTaxAmount);
            writer.WriteDecimalValue("quantity", Quantity);
            writer.WriteIntValue("sequence", Sequence);
            writer.WriteDateValue("shipmentDate", ShipmentDate);
            writer.WriteDecimalValue("shippedQuantity", ShippedQuantity);
            writer.WriteDecimalValue("shipQuantity", ShipQuantity);
            writer.WriteStringValue("taxCode", TaxCode);
            writer.WriteDecimalValue("taxPercent", TaxPercent);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteStringValue("unitOfMeasureId", UnitOfMeasureId);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
