using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SalesInvoice : Entity, IParsable {
        public PostalAddressType BillingPostalAddress { get; set; }
        public string BillToCustomerId { get; set; }
        public string BillToCustomerNumber { get; set; }
        public string BillToName { get; set; }
        public Currency Currency { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyId { get; set; }
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerPurchaseOrderReference { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? DiscountAppliedBeforeTax { get; set; }
        public Date? DueDate { get; set; }
        public string Email { get; set; }
        public string ExternalDocumentNumber { get; set; }
        public Date? InvoiceDate { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Number { get; set; }
        public string OrderId { get; set; }
        public string OrderNumber { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public string PaymentTermsId { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PricesIncludeTax { get; set; }
        public List<SalesInvoiceLine> SalesInvoiceLines { get; set; }
        public string Salesperson { get; set; }
        public PostalAddressType SellingPostalAddress { get; set; }
        public ShipmentMethod ShipmentMethod { get; set; }
        public string ShipmentMethodId { get; set; }
        public PostalAddressType ShippingPostalAddress { get; set; }
        public string ShipToContact { get; set; }
        public string ShipToName { get; set; }
        public string Status { get; set; }
        public decimal? TotalAmountExcludingTax { get; set; }
        public decimal? TotalAmountIncludingTax { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"billingPostalAddress", (o,n) => { (o as SalesInvoice).BillingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"billToCustomerId", (o,n) => { (o as SalesInvoice).BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", (o,n) => { (o as SalesInvoice).BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", (o,n) => { (o as SalesInvoice).BillToName = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as SalesInvoice).Currency = n.GetObjectValue<Currency>(); } },
                {"currencyCode", (o,n) => { (o as SalesInvoice).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as SalesInvoice).CurrencyId = n.GetStringValue(); } },
                {"customer", (o,n) => { (o as SalesInvoice).Customer = n.GetObjectValue<Customer>(); } },
                {"customerId", (o,n) => { (o as SalesInvoice).CustomerId = n.GetStringValue(); } },
                {"customerName", (o,n) => { (o as SalesInvoice).CustomerName = n.GetStringValue(); } },
                {"customerNumber", (o,n) => { (o as SalesInvoice).CustomerNumber = n.GetStringValue(); } },
                {"customerPurchaseOrderReference", (o,n) => { (o as SalesInvoice).CustomerPurchaseOrderReference = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as SalesInvoice).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as SalesInvoice).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"dueDate", (o,n) => { (o as SalesInvoice).DueDate = n.GetDateValue(); } },
                {"email", (o,n) => { (o as SalesInvoice).Email = n.GetStringValue(); } },
                {"externalDocumentNumber", (o,n) => { (o as SalesInvoice).ExternalDocumentNumber = n.GetStringValue(); } },
                {"invoiceDate", (o,n) => { (o as SalesInvoice).InvoiceDate = n.GetDateValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as SalesInvoice).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as SalesInvoice).Number = n.GetStringValue(); } },
                {"orderId", (o,n) => { (o as SalesInvoice).OrderId = n.GetStringValue(); } },
                {"orderNumber", (o,n) => { (o as SalesInvoice).OrderNumber = n.GetStringValue(); } },
                {"paymentTerm", (o,n) => { (o as SalesInvoice).PaymentTerm = n.GetObjectValue<PaymentTerm>(); } },
                {"paymentTermsId", (o,n) => { (o as SalesInvoice).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as SalesInvoice).PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", (o,n) => { (o as SalesInvoice).PricesIncludeTax = n.GetBoolValue(); } },
                {"salesInvoiceLines", (o,n) => { (o as SalesInvoice).SalesInvoiceLines = n.GetCollectionOfObjectValues<SalesInvoiceLine>().ToList(); } },
                {"salesperson", (o,n) => { (o as SalesInvoice).Salesperson = n.GetStringValue(); } },
                {"sellingPostalAddress", (o,n) => { (o as SalesInvoice).SellingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"shipmentMethod", (o,n) => { (o as SalesInvoice).ShipmentMethod = n.GetObjectValue<ShipmentMethod>(); } },
                {"shipmentMethodId", (o,n) => { (o as SalesInvoice).ShipmentMethodId = n.GetStringValue(); } },
                {"shippingPostalAddress", (o,n) => { (o as SalesInvoice).ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"shipToContact", (o,n) => { (o as SalesInvoice).ShipToContact = n.GetStringValue(); } },
                {"shipToName", (o,n) => { (o as SalesInvoice).ShipToName = n.GetStringValue(); } },
                {"status", (o,n) => { (o as SalesInvoice).Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", (o,n) => { (o as SalesInvoice).TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", (o,n) => { (o as SalesInvoice).TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as SalesInvoice).TotalTaxAmount = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PostalAddressType>("billingPostalAddress", BillingPostalAddress);
            writer.WriteStringValue("billToCustomerId", BillToCustomerId);
            writer.WriteStringValue("billToCustomerNumber", BillToCustomerNumber);
            writer.WriteStringValue("billToName", BillToName);
            writer.WriteObjectValue<Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteObjectValue<Customer>("customer", Customer);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteStringValue("customerPurchaseOrderReference", CustomerPurchaseOrderReference);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteDateValue("invoiceDate", InvoiceDate);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("orderId", OrderId);
            writer.WriteStringValue("orderNumber", OrderNumber);
            writer.WriteObjectValue<PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteBoolValue("pricesIncludeTax", PricesIncludeTax);
            writer.WriteCollectionOfObjectValues<SalesInvoiceLine>("salesInvoiceLines", SalesInvoiceLines);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
            writer.WriteObjectValue<ShipmentMethod>("shipmentMethod", ShipmentMethod);
            writer.WriteStringValue("shipmentMethodId", ShipmentMethodId);
            writer.WriteObjectValue<PostalAddressType>("shippingPostalAddress", ShippingPostalAddress);
            writer.WriteStringValue("shipToContact", ShipToContact);
            writer.WriteStringValue("shipToName", ShipToName);
            writer.WriteStringValue("status", Status);
            writer.WriteDecimalValue("totalAmountExcludingTax", TotalAmountExcludingTax);
            writer.WriteDecimalValue("totalAmountIncludingTax", TotalAmountIncludingTax);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
        }
    }
}
