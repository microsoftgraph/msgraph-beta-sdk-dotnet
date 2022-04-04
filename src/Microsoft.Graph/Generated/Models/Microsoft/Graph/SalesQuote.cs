using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SalesQuote : Entity, IParsable {
        /// <summary>The acceptedDate property</summary>
        public Date? AcceptedDate { get; set; }
        /// <summary>The billingPostalAddress property</summary>
        public PostalAddressType BillingPostalAddress { get; set; }
        /// <summary>The billToCustomerId property</summary>
        public string BillToCustomerId { get; set; }
        /// <summary>The billToCustomerNumber property</summary>
        public string BillToCustomerNumber { get; set; }
        /// <summary>The billToName property</summary>
        public string BillToName { get; set; }
        /// <summary>The currency property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Currency Currency { get; set; }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode { get; set; }
        /// <summary>The currencyId property</summary>
        public string CurrencyId { get; set; }
        /// <summary>The customer property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Customer Customer { get; set; }
        /// <summary>The customerId property</summary>
        public string CustomerId { get; set; }
        /// <summary>The customerName property</summary>
        public string CustomerName { get; set; }
        /// <summary>The customerNumber property</summary>
        public string CustomerNumber { get; set; }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount { get; set; }
        /// <summary>The documentDate property</summary>
        public Date? DocumentDate { get; set; }
        /// <summary>The dueDate property</summary>
        public Date? DueDate { get; set; }
        /// <summary>The email property</summary>
        public string Email { get; set; }
        /// <summary>The externalDocumentNumber property</summary>
        public string ExternalDocumentNumber { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The number property</summary>
        public string Number { get; set; }
        /// <summary>The paymentTerm property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm PaymentTerm { get; set; }
        /// <summary>The paymentTermsId property</summary>
        public string PaymentTermsId { get; set; }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber { get; set; }
        /// <summary>The salesperson property</summary>
        public string Salesperson { get; set; }
        /// <summary>The salesQuoteLines property</summary>
        public List<SalesQuoteLine> SalesQuoteLines { get; set; }
        /// <summary>The sellingPostalAddress property</summary>
        public PostalAddressType SellingPostalAddress { get; set; }
        /// <summary>The sentDate property</summary>
        public DateTimeOffset? SentDate { get; set; }
        /// <summary>The shipmentMethod property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ShipmentMethod ShipmentMethod { get; set; }
        /// <summary>The shipmentMethodId property</summary>
        public string ShipmentMethodId { get; set; }
        /// <summary>The shippingPostalAddress property</summary>
        public PostalAddressType ShippingPostalAddress { get; set; }
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
        /// <summary>The validUntilDate property</summary>
        public Date? ValidUntilDate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesQuote CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesQuote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acceptedDate", (o,n) => { (o as SalesQuote).AcceptedDate = n.GetDateValue(); } },
                {"billingPostalAddress", (o,n) => { (o as SalesQuote).BillingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"billToCustomerId", (o,n) => { (o as SalesQuote).BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", (o,n) => { (o as SalesQuote).BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", (o,n) => { (o as SalesQuote).BillToName = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as SalesQuote).Currency = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Currency>(MicrosoftGraphSdk.Models.Microsoft.Graph.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", (o,n) => { (o as SalesQuote).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as SalesQuote).CurrencyId = n.GetStringValue(); } },
                {"customer", (o,n) => { (o as SalesQuote).Customer = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Customer>(MicrosoftGraphSdk.Models.Microsoft.Graph.Customer.CreateFromDiscriminatorValue); } },
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
                {"paymentTerm", (o,n) => { (o as SalesQuote).PaymentTerm = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm>(MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", (o,n) => { (o as SalesQuote).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as SalesQuote).PhoneNumber = n.GetStringValue(); } },
                {"salesperson", (o,n) => { (o as SalesQuote).Salesperson = n.GetStringValue(); } },
                {"salesQuoteLines", (o,n) => { (o as SalesQuote).SalesQuoteLines = n.GetCollectionOfObjectValues<SalesQuoteLine>(SalesQuoteLine.CreateFromDiscriminatorValue).ToList(); } },
                {"sellingPostalAddress", (o,n) => { (o as SalesQuote).SellingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"sentDate", (o,n) => { (o as SalesQuote).SentDate = n.GetDateTimeOffsetValue(); } },
                {"shipmentMethod", (o,n) => { (o as SalesQuote).ShipmentMethod = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ShipmentMethod>(MicrosoftGraphSdk.Models.Microsoft.Graph.ShipmentMethod.CreateFromDiscriminatorValue); } },
                {"shipmentMethodId", (o,n) => { (o as SalesQuote).ShipmentMethodId = n.GetStringValue(); } },
                {"shippingPostalAddress", (o,n) => { (o as SalesQuote).ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Customer>("customer", Customer);
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteCollectionOfObjectValues<SalesQuoteLine>("salesQuoteLines", SalesQuoteLines);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
            writer.WriteDateTimeOffsetValue("sentDate", SentDate);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ShipmentMethod>("shipmentMethod", ShipmentMethod);
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
