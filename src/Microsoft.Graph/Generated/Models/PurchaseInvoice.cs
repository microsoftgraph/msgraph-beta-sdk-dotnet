using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PurchaseInvoice : Entity, IParsable {
        /// <summary>The buyFromAddress property</summary>
        public PostalAddressType BuyFromAddress { get; set; }
        /// <summary>The currency property</summary>
        public Microsoft.Graph.Beta.Models.Currency Currency { get; set; }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode { get; set; }
        /// <summary>The currencyId property</summary>
        public string CurrencyId { get; set; }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount { get; set; }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax { get; set; }
        /// <summary>The dueDate property</summary>
        public Date? DueDate { get; set; }
        /// <summary>The invoiceDate property</summary>
        public Date? InvoiceDate { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The number property</summary>
        public string Number { get; set; }
        /// <summary>The payToAddress property</summary>
        public PostalAddressType PayToAddress { get; set; }
        /// <summary>The payToContact property</summary>
        public string PayToContact { get; set; }
        /// <summary>The payToName property</summary>
        public string PayToName { get; set; }
        /// <summary>The payToVendorId property</summary>
        public string PayToVendorId { get; set; }
        /// <summary>The payToVendorNumber property</summary>
        public string PayToVendorNumber { get; set; }
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax { get; set; }
        /// <summary>The purchaseInvoiceLines property</summary>
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
        /// <summary>The shipToAddress property</summary>
        public PostalAddressType ShipToAddress { get; set; }
        /// <summary>The shipToContact property</summary>
        public string ShipToContact { get; set; }
        /// <summary>The shipToName property</summary>
        public string ShipToName { get; set; }
        /// <summary>The status property</summary>
        public string Status { get; set; }
        /// <summary>The totalAmountExcludingTax property</summary>
        public decimal? TotalAmountExcludingTax { get; set; }
        /// <summary>The totalAmountIncludingTax property</summary>
        public decimal? TotalAmountIncludingTax { get; set; }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount { get; set; }
        /// <summary>The vendor property</summary>
        public Microsoft.Graph.Beta.Models.Vendor Vendor { get; set; }
        /// <summary>The vendorId property</summary>
        public string VendorId { get; set; }
        /// <summary>The vendorInvoiceNumber property</summary>
        public string VendorInvoiceNumber { get; set; }
        /// <summary>The vendorName property</summary>
        public string VendorName { get; set; }
        /// <summary>The vendorNumber property</summary>
        public string VendorNumber { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PurchaseInvoice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PurchaseInvoice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"buyFromAddress", (o,n) => { (o as PurchaseInvoice).BuyFromAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"currency", (o,n) => { (o as PurchaseInvoice).Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", (o,n) => { (o as PurchaseInvoice).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as PurchaseInvoice).CurrencyId = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as PurchaseInvoice).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as PurchaseInvoice).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"dueDate", (o,n) => { (o as PurchaseInvoice).DueDate = n.GetDateValue(); } },
                {"invoiceDate", (o,n) => { (o as PurchaseInvoice).InvoiceDate = n.GetDateValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as PurchaseInvoice).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as PurchaseInvoice).Number = n.GetStringValue(); } },
                {"payToAddress", (o,n) => { (o as PurchaseInvoice).PayToAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"payToContact", (o,n) => { (o as PurchaseInvoice).PayToContact = n.GetStringValue(); } },
                {"payToName", (o,n) => { (o as PurchaseInvoice).PayToName = n.GetStringValue(); } },
                {"payToVendorId", (o,n) => { (o as PurchaseInvoice).PayToVendorId = n.GetStringValue(); } },
                {"payToVendorNumber", (o,n) => { (o as PurchaseInvoice).PayToVendorNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", (o,n) => { (o as PurchaseInvoice).PricesIncludeTax = n.GetBoolValue(); } },
                {"purchaseInvoiceLines", (o,n) => { (o as PurchaseInvoice).PurchaseInvoiceLines = n.GetCollectionOfObjectValues<PurchaseInvoiceLine>(PurchaseInvoiceLine.CreateFromDiscriminatorValue).ToList(); } },
                {"shipToAddress", (o,n) => { (o as PurchaseInvoice).ShipToAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shipToContact", (o,n) => { (o as PurchaseInvoice).ShipToContact = n.GetStringValue(); } },
                {"shipToName", (o,n) => { (o as PurchaseInvoice).ShipToName = n.GetStringValue(); } },
                {"status", (o,n) => { (o as PurchaseInvoice).Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", (o,n) => { (o as PurchaseInvoice).TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", (o,n) => { (o as PurchaseInvoice).TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as PurchaseInvoice).TotalTaxAmount = n.GetDecimalValue(); } },
                {"vendor", (o,n) => { (o as PurchaseInvoice).Vendor = n.GetObjectValue<Microsoft.Graph.Beta.Models.Vendor>(Microsoft.Graph.Beta.Models.Vendor.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Currency>("currency", Currency);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Vendor>("vendor", Vendor);
            writer.WriteStringValue("vendorId", VendorId);
            writer.WriteStringValue("vendorInvoiceNumber", VendorInvoiceNumber);
            writer.WriteStringValue("vendorName", VendorName);
            writer.WriteStringValue("vendorNumber", VendorNumber);
        }
    }
}
