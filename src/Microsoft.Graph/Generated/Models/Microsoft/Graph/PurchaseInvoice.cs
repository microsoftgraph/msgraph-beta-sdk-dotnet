using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PurchaseInvoice : Entity, IParsable {
        public PostalAddressType BuyFromAddress { get; set; }
        public Currency Currency { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyId { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? DiscountAppliedBeforeTax { get; set; }
        public Date? DueDate { get; set; }
        public Date? InvoiceDate { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Number { get; set; }
        public PostalAddressType PayToAddress { get; set; }
        public string PayToContact { get; set; }
        public string PayToName { get; set; }
        public string PayToVendorId { get; set; }
        public string PayToVendorNumber { get; set; }
        public bool? PricesIncludeTax { get; set; }
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
        public PostalAddressType ShipToAddress { get; set; }
        public string ShipToContact { get; set; }
        public string ShipToName { get; set; }
        public string Status { get; set; }
        public decimal? TotalAmountExcludingTax { get; set; }
        public decimal? TotalAmountIncludingTax { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public Vendor Vendor { get; set; }
        public string VendorId { get; set; }
        public string VendorInvoiceNumber { get; set; }
        public string VendorName { get; set; }
        public string VendorNumber { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"buyFromAddress", (o,n) => { (o as PurchaseInvoice).BuyFromAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"currency", (o,n) => { (o as PurchaseInvoice).Currency = n.GetObjectValue<Currency>(); } },
                {"currencyCode", (o,n) => { (o as PurchaseInvoice).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as PurchaseInvoice).CurrencyId = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as PurchaseInvoice).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as PurchaseInvoice).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"dueDate", (o,n) => { (o as PurchaseInvoice).DueDate = n.GetDateValue(); } },
                {"invoiceDate", (o,n) => { (o as PurchaseInvoice).InvoiceDate = n.GetDateValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as PurchaseInvoice).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as PurchaseInvoice).Number = n.GetStringValue(); } },
                {"payToAddress", (o,n) => { (o as PurchaseInvoice).PayToAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"payToContact", (o,n) => { (o as PurchaseInvoice).PayToContact = n.GetStringValue(); } },
                {"payToName", (o,n) => { (o as PurchaseInvoice).PayToName = n.GetStringValue(); } },
                {"payToVendorId", (o,n) => { (o as PurchaseInvoice).PayToVendorId = n.GetStringValue(); } },
                {"payToVendorNumber", (o,n) => { (o as PurchaseInvoice).PayToVendorNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", (o,n) => { (o as PurchaseInvoice).PricesIncludeTax = n.GetBoolValue(); } },
                {"purchaseInvoiceLines", (o,n) => { (o as PurchaseInvoice).PurchaseInvoiceLines = n.GetCollectionOfObjectValues<PurchaseInvoiceLine>().ToList(); } },
                {"shipToAddress", (o,n) => { (o as PurchaseInvoice).ShipToAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"shipToContact", (o,n) => { (o as PurchaseInvoice).ShipToContact = n.GetStringValue(); } },
                {"shipToName", (o,n) => { (o as PurchaseInvoice).ShipToName = n.GetStringValue(); } },
                {"status", (o,n) => { (o as PurchaseInvoice).Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", (o,n) => { (o as PurchaseInvoice).TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", (o,n) => { (o as PurchaseInvoice).TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as PurchaseInvoice).TotalTaxAmount = n.GetDecimalValue(); } },
                {"vendor", (o,n) => { (o as PurchaseInvoice).Vendor = n.GetObjectValue<Vendor>(); } },
                {"vendorId", (o,n) => { (o as PurchaseInvoice).VendorId = n.GetStringValue(); } },
                {"vendorInvoiceNumber", (o,n) => { (o as PurchaseInvoice).VendorInvoiceNumber = n.GetStringValue(); } },
                {"vendorName", (o,n) => { (o as PurchaseInvoice).VendorName = n.GetStringValue(); } },
                {"vendorNumber", (o,n) => { (o as PurchaseInvoice).VendorNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PostalAddressType>("buyFromAddress", BuyFromAddress);
            writer.WriteObjectValue<Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteDateValue("invoiceDate", InvoiceDate);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteObjectValue<PostalAddressType>("payToAddress", PayToAddress);
            writer.WriteStringValue("payToContact", PayToContact);
            writer.WriteStringValue("payToName", PayToName);
            writer.WriteStringValue("payToVendorId", PayToVendorId);
            writer.WriteStringValue("payToVendorNumber", PayToVendorNumber);
            writer.WriteBoolValue("pricesIncludeTax", PricesIncludeTax);
            writer.WriteCollectionOfObjectValues<PurchaseInvoiceLine>("purchaseInvoiceLines", PurchaseInvoiceLines);
            writer.WriteObjectValue<PostalAddressType>("shipToAddress", ShipToAddress);
            writer.WriteStringValue("shipToContact", ShipToContact);
            writer.WriteStringValue("shipToName", ShipToName);
            writer.WriteStringValue("status", Status);
            writer.WriteDecimalValue("totalAmountExcludingTax", TotalAmountExcludingTax);
            writer.WriteDecimalValue("totalAmountIncludingTax", TotalAmountIncludingTax);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteObjectValue<Vendor>("vendor", Vendor);
            writer.WriteStringValue("vendorId", VendorId);
            writer.WriteStringValue("vendorInvoiceNumber", VendorInvoiceNumber);
            writer.WriteStringValue("vendorName", VendorName);
            writer.WriteStringValue("vendorNumber", VendorNumber);
        }
    }
}
