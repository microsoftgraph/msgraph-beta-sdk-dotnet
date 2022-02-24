using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SalesOrder : Entity, IParsable {
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
        public decimal? DiscountAmount { get; set; }
        public bool? DiscountAppliedBeforeTax { get; set; }
        public string Email { get; set; }
        public string ExternalDocumentNumber { get; set; }
        public bool? FullyShipped { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Number { get; set; }
        public Date? OrderDate { get; set; }
        public bool? PartialShipping { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public string PaymentTermsId { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PricesIncludeTax { get; set; }
        public Date? RequestedDeliveryDate { get; set; }
        public List<SalesOrderLine> SalesOrderLines { get; set; }
        public string Salesperson { get; set; }
        public PostalAddressType SellingPostalAddress { get; set; }
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
                {"billingPostalAddress", (o,n) => { (o as SalesOrder).BillingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"billToCustomerId", (o,n) => { (o as SalesOrder).BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", (o,n) => { (o as SalesOrder).BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", (o,n) => { (o as SalesOrder).BillToName = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as SalesOrder).Currency = n.GetObjectValue<Currency>(); } },
                {"currencyCode", (o,n) => { (o as SalesOrder).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as SalesOrder).CurrencyId = n.GetStringValue(); } },
                {"customer", (o,n) => { (o as SalesOrder).Customer = n.GetObjectValue<Customer>(); } },
                {"customerId", (o,n) => { (o as SalesOrder).CustomerId = n.GetStringValue(); } },
                {"customerName", (o,n) => { (o as SalesOrder).CustomerName = n.GetStringValue(); } },
                {"customerNumber", (o,n) => { (o as SalesOrder).CustomerNumber = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as SalesOrder).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as SalesOrder).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"email", (o,n) => { (o as SalesOrder).Email = n.GetStringValue(); } },
                {"externalDocumentNumber", (o,n) => { (o as SalesOrder).ExternalDocumentNumber = n.GetStringValue(); } },
                {"fullyShipped", (o,n) => { (o as SalesOrder).FullyShipped = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as SalesOrder).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as SalesOrder).Number = n.GetStringValue(); } },
                {"orderDate", (o,n) => { (o as SalesOrder).OrderDate = n.GetDateValue(); } },
                {"partialShipping", (o,n) => { (o as SalesOrder).PartialShipping = n.GetBoolValue(); } },
                {"paymentTerm", (o,n) => { (o as SalesOrder).PaymentTerm = n.GetObjectValue<PaymentTerm>(); } },
                {"paymentTermsId", (o,n) => { (o as SalesOrder).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as SalesOrder).PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", (o,n) => { (o as SalesOrder).PricesIncludeTax = n.GetBoolValue(); } },
                {"requestedDeliveryDate", (o,n) => { (o as SalesOrder).RequestedDeliveryDate = n.GetDateValue(); } },
                {"salesOrderLines", (o,n) => { (o as SalesOrder).SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>().ToList(); } },
                {"salesperson", (o,n) => { (o as SalesOrder).Salesperson = n.GetStringValue(); } },
                {"sellingPostalAddress", (o,n) => { (o as SalesOrder).SellingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"shippingPostalAddress", (o,n) => { (o as SalesOrder).ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"shipToContact", (o,n) => { (o as SalesOrder).ShipToContact = n.GetStringValue(); } },
                {"shipToName", (o,n) => { (o as SalesOrder).ShipToName = n.GetStringValue(); } },
                {"status", (o,n) => { (o as SalesOrder).Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", (o,n) => { (o as SalesOrder).TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", (o,n) => { (o as SalesOrder).TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as SalesOrder).TotalTaxAmount = n.GetDecimalValue(); } },
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
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteBoolValue("fullyShipped", FullyShipped);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteDateValue("orderDate", OrderDate);
            writer.WriteBoolValue("partialShipping", PartialShipping);
            writer.WriteObjectValue<PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteBoolValue("pricesIncludeTax", PricesIncludeTax);
            writer.WriteDateValue("requestedDeliveryDate", RequestedDeliveryDate);
            writer.WriteCollectionOfObjectValues<SalesOrderLine>("salesOrderLines", SalesOrderLines);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
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
