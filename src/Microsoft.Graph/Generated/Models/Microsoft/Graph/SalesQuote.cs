using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SalesQuote : Entity, IParsable {
        public Date? AcceptedDate { get; set; }
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
        public Date? DocumentDate { get; set; }
        public Date? DueDate { get; set; }
        public string Email { get; set; }
        public string ExternalDocumentNumber { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Number { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public string PaymentTermsId { get; set; }
        public string PhoneNumber { get; set; }
        public string Salesperson { get; set; }
        public List<SalesQuoteLine> SalesQuoteLines { get; set; }
        public PostalAddressType SellingPostalAddress { get; set; }
        public DateTimeOffset? SentDate { get; set; }
        public ShipmentMethod ShipmentMethod { get; set; }
        public string ShipmentMethodId { get; set; }
        public PostalAddressType ShippingPostalAddress { get; set; }
        public string ShipToContact { get; set; }
        public string ShipToName { get; set; }
        public string Status { get; set; }
        public decimal? TotalAmountExcludingTax { get; set; }
        public decimal? TotalAmountIncludingTax { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public Date? ValidUntilDate { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acceptedDate", (o,n) => { (o as SalesQuote).AcceptedDate = n.GetDateValue(); } },
                {"billingPostalAddress", (o,n) => { (o as SalesQuote).BillingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"billToCustomerId", (o,n) => { (o as SalesQuote).BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", (o,n) => { (o as SalesQuote).BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", (o,n) => { (o as SalesQuote).BillToName = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as SalesQuote).Currency = n.GetObjectValue<Currency>(); } },
                {"currencyCode", (o,n) => { (o as SalesQuote).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as SalesQuote).CurrencyId = n.GetStringValue(); } },
                {"customer", (o,n) => { (o as SalesQuote).Customer = n.GetObjectValue<Customer>(); } },
                {"customerId", (o,n) => { (o as SalesQuote).CustomerId = n.GetStringValue(); } },
                {"customerName", (o,n) => { (o as SalesQuote).CustomerName = n.GetStringValue(); } },
                {"customerNumber", (o,n) => { (o as SalesQuote).CustomerNumber = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as SalesQuote).DiscountAmount = n.GetDecimalValue(); } },
                {"documentDate", (o,n) => { (o as SalesQuote).DocumentDate = n.GetDateValue(); } },
                {"dueDate", (o,n) => { (o as SalesQuote).DueDate = n.GetDateValue(); } },
                {"email", (o,n) => { (o as SalesQuote).Email = n.GetStringValue(); } },
                {"externalDocumentNumber", (o,n) => { (o as SalesQuote).ExternalDocumentNumber = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as SalesQuote).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as SalesQuote).Number = n.GetStringValue(); } },
                {"paymentTerm", (o,n) => { (o as SalesQuote).PaymentTerm = n.GetObjectValue<PaymentTerm>(); } },
                {"paymentTermsId", (o,n) => { (o as SalesQuote).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as SalesQuote).PhoneNumber = n.GetStringValue(); } },
                {"salesperson", (o,n) => { (o as SalesQuote).Salesperson = n.GetStringValue(); } },
                {"salesQuoteLines", (o,n) => { (o as SalesQuote).SalesQuoteLines = n.GetCollectionOfObjectValues<SalesQuoteLine>().ToList(); } },
                {"sellingPostalAddress", (o,n) => { (o as SalesQuote).SellingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"sentDate", (o,n) => { (o as SalesQuote).SentDate = n.GetDateTimeOffsetValue(); } },
                {"shipmentMethod", (o,n) => { (o as SalesQuote).ShipmentMethod = n.GetObjectValue<ShipmentMethod>(); } },
                {"shipmentMethodId", (o,n) => { (o as SalesQuote).ShipmentMethodId = n.GetStringValue(); } },
                {"shippingPostalAddress", (o,n) => { (o as SalesQuote).ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(); } },
                {"shipToContact", (o,n) => { (o as SalesQuote).ShipToContact = n.GetStringValue(); } },
                {"shipToName", (o,n) => { (o as SalesQuote).ShipToName = n.GetStringValue(); } },
                {"status", (o,n) => { (o as SalesQuote).Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", (o,n) => { (o as SalesQuote).TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", (o,n) => { (o as SalesQuote).TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as SalesQuote).TotalTaxAmount = n.GetDecimalValue(); } },
                {"validUntilDate", (o,n) => { (o as SalesQuote).ValidUntilDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("acceptedDate", AcceptedDate);
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
            writer.WriteDateValue("documentDate", DocumentDate);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteObjectValue<PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteCollectionOfObjectValues<SalesQuoteLine>("salesQuoteLines", SalesQuoteLines);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
            writer.WriteDateTimeOffsetValue("sentDate", SentDate);
            writer.WriteObjectValue<ShipmentMethod>("shipmentMethod", ShipmentMethod);
            writer.WriteStringValue("shipmentMethodId", ShipmentMethodId);
            writer.WriteObjectValue<PostalAddressType>("shippingPostalAddress", ShippingPostalAddress);
            writer.WriteStringValue("shipToContact", ShipToContact);
            writer.WriteStringValue("shipToName", ShipToName);
            writer.WriteStringValue("status", Status);
            writer.WriteDecimalValue("totalAmountExcludingTax", TotalAmountExcludingTax);
            writer.WriteDecimalValue("totalAmountIncludingTax", TotalAmountIncludingTax);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteDateValue("validUntilDate", ValidUntilDate);
        }
    }
}
