using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PurchaseInvoice : Entity, IParsable {
        /// <summary>The buyFromAddress property</summary>
        public PostalAddressType BuyFromAddress {
            get { return BackingStore?.Get<PostalAddressType>("buyFromAddress"); }
            set { BackingStore?.Set("buyFromAddress", value); }
        }
        /// <summary>The currency property</summary>
        public Microsoft.Graph.Beta.Models.Currency Currency {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Currency>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
        /// <summary>The currencyId property</summary>
        public string CurrencyId {
            get { return BackingStore?.Get<string>("currencyId"); }
            set { BackingStore?.Set("currencyId", value); }
        }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount {
            get { return BackingStore?.Get<decimal?>("discountAmount"); }
            set { BackingStore?.Set("discountAmount", value); }
        }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax {
            get { return BackingStore?.Get<bool?>("discountAppliedBeforeTax"); }
            set { BackingStore?.Set("discountAppliedBeforeTax", value); }
        }
        /// <summary>The dueDate property</summary>
        public Date? DueDate {
            get { return BackingStore?.Get<Date?>("dueDate"); }
            set { BackingStore?.Set("dueDate", value); }
        }
        /// <summary>The invoiceDate property</summary>
        public Date? InvoiceDate {
            get { return BackingStore?.Get<Date?>("invoiceDate"); }
            set { BackingStore?.Set("invoiceDate", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The number property</summary>
        public string Number {
            get { return BackingStore?.Get<string>("number"); }
            set { BackingStore?.Set("number", value); }
        }
        /// <summary>The payToAddress property</summary>
        public PostalAddressType PayToAddress {
            get { return BackingStore?.Get<PostalAddressType>("payToAddress"); }
            set { BackingStore?.Set("payToAddress", value); }
        }
        /// <summary>The payToContact property</summary>
        public string PayToContact {
            get { return BackingStore?.Get<string>("payToContact"); }
            set { BackingStore?.Set("payToContact", value); }
        }
        /// <summary>The payToName property</summary>
        public string PayToName {
            get { return BackingStore?.Get<string>("payToName"); }
            set { BackingStore?.Set("payToName", value); }
        }
        /// <summary>The payToVendorId property</summary>
        public string PayToVendorId {
            get { return BackingStore?.Get<string>("payToVendorId"); }
            set { BackingStore?.Set("payToVendorId", value); }
        }
        /// <summary>The payToVendorNumber property</summary>
        public string PayToVendorNumber {
            get { return BackingStore?.Get<string>("payToVendorNumber"); }
            set { BackingStore?.Set("payToVendorNumber", value); }
        }
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax {
            get { return BackingStore?.Get<bool?>("pricesIncludeTax"); }
            set { BackingStore?.Set("pricesIncludeTax", value); }
        }
        /// <summary>The purchaseInvoiceLines property</summary>
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines {
            get { return BackingStore?.Get<List<PurchaseInvoiceLine>>("purchaseInvoiceLines"); }
            set { BackingStore?.Set("purchaseInvoiceLines", value); }
        }
        /// <summary>The shipToAddress property</summary>
        public PostalAddressType ShipToAddress {
            get { return BackingStore?.Get<PostalAddressType>("shipToAddress"); }
            set { BackingStore?.Set("shipToAddress", value); }
        }
        /// <summary>The shipToContact property</summary>
        public string ShipToContact {
            get { return BackingStore?.Get<string>("shipToContact"); }
            set { BackingStore?.Set("shipToContact", value); }
        }
        /// <summary>The shipToName property</summary>
        public string ShipToName {
            get { return BackingStore?.Get<string>("shipToName"); }
            set { BackingStore?.Set("shipToName", value); }
        }
        /// <summary>The status property</summary>
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The totalAmountExcludingTax property</summary>
        public decimal? TotalAmountExcludingTax {
            get { return BackingStore?.Get<decimal?>("totalAmountExcludingTax"); }
            set { BackingStore?.Set("totalAmountExcludingTax", value); }
        }
        /// <summary>The totalAmountIncludingTax property</summary>
        public decimal? TotalAmountIncludingTax {
            get { return BackingStore?.Get<decimal?>("totalAmountIncludingTax"); }
            set { BackingStore?.Set("totalAmountIncludingTax", value); }
        }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount {
            get { return BackingStore?.Get<decimal?>("totalTaxAmount"); }
            set { BackingStore?.Set("totalTaxAmount", value); }
        }
        /// <summary>The vendor property</summary>
        public Microsoft.Graph.Beta.Models.Vendor Vendor {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Vendor>("vendor"); }
            set { BackingStore?.Set("vendor", value); }
        }
        /// <summary>The vendorId property</summary>
        public string VendorId {
            get { return BackingStore?.Get<string>("vendorId"); }
            set { BackingStore?.Set("vendorId", value); }
        }
        /// <summary>The vendorInvoiceNumber property</summary>
        public string VendorInvoiceNumber {
            get { return BackingStore?.Get<string>("vendorInvoiceNumber"); }
            set { BackingStore?.Set("vendorInvoiceNumber", value); }
        }
        /// <summary>The vendorName property</summary>
        public string VendorName {
            get { return BackingStore?.Get<string>("vendorName"); }
            set { BackingStore?.Set("vendorName", value); }
        }
        /// <summary>The vendorNumber property</summary>
        public string VendorNumber {
            get { return BackingStore?.Get<string>("vendorNumber"); }
            set { BackingStore?.Set("vendorNumber", value); }
        }
        /// <summary>
        /// Instantiates a new PurchaseInvoice and sets the default values.
        /// </summary>
        public PurchaseInvoice() : base() {
            OdataType = "#microsoft.graph.purchaseInvoice";
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
