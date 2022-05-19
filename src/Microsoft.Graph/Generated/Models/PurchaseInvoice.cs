using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the financials singleton.</summary>
    public class PurchaseInvoice : Entity, IParsable {
        /// <summary>The buyFromAddress property</summary>
        public PostalAddressType BuyFromAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(BuyFromAddress)); }
            set { BackingStore?.Set(nameof(BuyFromAddress), value); }
        }
        /// <summary>The currency property</summary>
        public Microsoft.Graph.Beta.Models.Currency Currency {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Currency>(nameof(Currency)); }
            set { BackingStore?.Set(nameof(Currency), value); }
        }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode {
            get { return BackingStore?.Get<string>(nameof(CurrencyCode)); }
            set { BackingStore?.Set(nameof(CurrencyCode), value); }
        }
        /// <summary>The currencyId property</summary>
        public string CurrencyId {
            get { return BackingStore?.Get<string>(nameof(CurrencyId)); }
            set { BackingStore?.Set(nameof(CurrencyId), value); }
        }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount {
            get { return BackingStore?.Get<decimal?>(nameof(DiscountAmount)); }
            set { BackingStore?.Set(nameof(DiscountAmount), value); }
        }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax {
            get { return BackingStore?.Get<bool?>(nameof(DiscountAppliedBeforeTax)); }
            set { BackingStore?.Set(nameof(DiscountAppliedBeforeTax), value); }
        }
        /// <summary>The dueDate property</summary>
        public Date? DueDate {
            get { return BackingStore?.Get<Date?>(nameof(DueDate)); }
            set { BackingStore?.Set(nameof(DueDate), value); }
        }
        /// <summary>The invoiceDate property</summary>
        public Date? InvoiceDate {
            get { return BackingStore?.Get<Date?>(nameof(InvoiceDate)); }
            set { BackingStore?.Set(nameof(InvoiceDate), value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The number property</summary>
        public string Number {
            get { return BackingStore?.Get<string>(nameof(Number)); }
            set { BackingStore?.Set(nameof(Number), value); }
        }
        /// <summary>The payToAddress property</summary>
        public PostalAddressType PayToAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(PayToAddress)); }
            set { BackingStore?.Set(nameof(PayToAddress), value); }
        }
        /// <summary>The payToContact property</summary>
        public string PayToContact {
            get { return BackingStore?.Get<string>(nameof(PayToContact)); }
            set { BackingStore?.Set(nameof(PayToContact), value); }
        }
        /// <summary>The payToName property</summary>
        public string PayToName {
            get { return BackingStore?.Get<string>(nameof(PayToName)); }
            set { BackingStore?.Set(nameof(PayToName), value); }
        }
        /// <summary>The payToVendorId property</summary>
        public string PayToVendorId {
            get { return BackingStore?.Get<string>(nameof(PayToVendorId)); }
            set { BackingStore?.Set(nameof(PayToVendorId), value); }
        }
        /// <summary>The payToVendorNumber property</summary>
        public string PayToVendorNumber {
            get { return BackingStore?.Get<string>(nameof(PayToVendorNumber)); }
            set { BackingStore?.Set(nameof(PayToVendorNumber), value); }
        }
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax {
            get { return BackingStore?.Get<bool?>(nameof(PricesIncludeTax)); }
            set { BackingStore?.Set(nameof(PricesIncludeTax), value); }
        }
        /// <summary>The purchaseInvoiceLines property</summary>
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines {
            get { return BackingStore?.Get<List<PurchaseInvoiceLine>>(nameof(PurchaseInvoiceLines)); }
            set { BackingStore?.Set(nameof(PurchaseInvoiceLines), value); }
        }
        /// <summary>The shipToAddress property</summary>
        public PostalAddressType ShipToAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(ShipToAddress)); }
            set { BackingStore?.Set(nameof(ShipToAddress), value); }
        }
        /// <summary>The shipToContact property</summary>
        public string ShipToContact {
            get { return BackingStore?.Get<string>(nameof(ShipToContact)); }
            set { BackingStore?.Set(nameof(ShipToContact), value); }
        }
        /// <summary>The shipToName property</summary>
        public string ShipToName {
            get { return BackingStore?.Get<string>(nameof(ShipToName)); }
            set { BackingStore?.Set(nameof(ShipToName), value); }
        }
        /// <summary>The status property</summary>
        public string Status {
            get { return BackingStore?.Get<string>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The totalAmountExcludingTax property</summary>
        public decimal? TotalAmountExcludingTax {
            get { return BackingStore?.Get<decimal?>(nameof(TotalAmountExcludingTax)); }
            set { BackingStore?.Set(nameof(TotalAmountExcludingTax), value); }
        }
        /// <summary>The totalAmountIncludingTax property</summary>
        public decimal? TotalAmountIncludingTax {
            get { return BackingStore?.Get<decimal?>(nameof(TotalAmountIncludingTax)); }
            set { BackingStore?.Set(nameof(TotalAmountIncludingTax), value); }
        }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount {
            get { return BackingStore?.Get<decimal?>(nameof(TotalTaxAmount)); }
            set { BackingStore?.Set(nameof(TotalTaxAmount), value); }
        }
        /// <summary>The vendor property</summary>
        public Microsoft.Graph.Beta.Models.Vendor Vendor {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Vendor>(nameof(Vendor)); }
            set { BackingStore?.Set(nameof(Vendor), value); }
        }
        /// <summary>The vendorId property</summary>
        public string VendorId {
            get { return BackingStore?.Get<string>(nameof(VendorId)); }
            set { BackingStore?.Set(nameof(VendorId), value); }
        }
        /// <summary>The vendorInvoiceNumber property</summary>
        public string VendorInvoiceNumber {
            get { return BackingStore?.Get<string>(nameof(VendorInvoiceNumber)); }
            set { BackingStore?.Set(nameof(VendorInvoiceNumber), value); }
        }
        /// <summary>The vendorName property</summary>
        public string VendorName {
            get { return BackingStore?.Get<string>(nameof(VendorName)); }
            set { BackingStore?.Set(nameof(VendorName), value); }
        }
        /// <summary>The vendorNumber property</summary>
        public string VendorNumber {
            get { return BackingStore?.Get<string>(nameof(VendorNumber)); }
            set { BackingStore?.Set(nameof(VendorNumber), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buyFromAddress", n => { BuyFromAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"currency", n => { Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currencyId", n => { CurrencyId = n.GetStringValue(); } },
                {"discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", n => { DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"dueDate", n => { DueDate = n.GetDateValue(); } },
                {"invoiceDate", n => { InvoiceDate = n.GetDateValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"payToAddress", n => { PayToAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"payToContact", n => { PayToContact = n.GetStringValue(); } },
                {"payToName", n => { PayToName = n.GetStringValue(); } },
                {"payToVendorId", n => { PayToVendorId = n.GetStringValue(); } },
                {"payToVendorNumber", n => { PayToVendorNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", n => { PricesIncludeTax = n.GetBoolValue(); } },
                {"purchaseInvoiceLines", n => { PurchaseInvoiceLines = n.GetCollectionOfObjectValues<PurchaseInvoiceLine>(PurchaseInvoiceLine.CreateFromDiscriminatorValue).ToList(); } },
                {"shipToAddress", n => { ShipToAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shipToContact", n => { ShipToContact = n.GetStringValue(); } },
                {"shipToName", n => { ShipToName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", n => { TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", n => { TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
                {"vendor", n => { Vendor = n.GetObjectValue<Microsoft.Graph.Beta.Models.Vendor>(Microsoft.Graph.Beta.Models.Vendor.CreateFromDiscriminatorValue); } },
                {"vendorId", n => { VendorId = n.GetStringValue(); } },
                {"vendorInvoiceNumber", n => { VendorInvoiceNumber = n.GetStringValue(); } },
                {"vendorName", n => { VendorName = n.GetStringValue(); } },
                {"vendorNumber", n => { VendorNumber = n.GetStringValue(); } },
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
