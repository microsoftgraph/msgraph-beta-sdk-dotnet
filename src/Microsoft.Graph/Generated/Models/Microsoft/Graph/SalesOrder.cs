using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SalesOrder : Entity, IParsable {
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
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax { get; set; }
        /// <summary>The email property</summary>
        public string Email { get; set; }
        /// <summary>The externalDocumentNumber property</summary>
        public string ExternalDocumentNumber { get; set; }
        /// <summary>The fullyShipped property</summary>
        public bool? FullyShipped { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The number property</summary>
        public string Number { get; set; }
        /// <summary>The orderDate property</summary>
        public Date? OrderDate { get; set; }
        /// <summary>The partialShipping property</summary>
        public bool? PartialShipping { get; set; }
        /// <summary>The paymentTerm property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm PaymentTerm { get; set; }
        /// <summary>The paymentTermsId property</summary>
        public string PaymentTermsId { get; set; }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber { get; set; }
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax { get; set; }
        /// <summary>The requestedDeliveryDate property</summary>
        public Date? RequestedDeliveryDate { get; set; }
        /// <summary>The salesOrderLines property</summary>
        public List<SalesOrderLine> SalesOrderLines { get; set; }
        /// <summary>The salesperson property</summary>
        public string Salesperson { get; set; }
        /// <summary>The sellingPostalAddress property</summary>
        public PostalAddressType SellingPostalAddress { get; set; }
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesOrder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesOrder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"billingPostalAddress", (o,n) => { (o as SalesOrder).BillingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"billToCustomerId", (o,n) => { (o as SalesOrder).BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", (o,n) => { (o as SalesOrder).BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", (o,n) => { (o as SalesOrder).BillToName = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as SalesOrder).Currency = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Currency>(MicrosoftGraphSdk.Models.Microsoft.Graph.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", (o,n) => { (o as SalesOrder).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as SalesOrder).CurrencyId = n.GetStringValue(); } },
                {"customer", (o,n) => { (o as SalesOrder).Customer = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Customer>(MicrosoftGraphSdk.Models.Microsoft.Graph.Customer.CreateFromDiscriminatorValue); } },
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
                {"paymentTerm", (o,n) => { (o as SalesOrder).PaymentTerm = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm>(MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", (o,n) => { (o as SalesOrder).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as SalesOrder).PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", (o,n) => { (o as SalesOrder).PricesIncludeTax = n.GetBoolValue(); } },
                {"requestedDeliveryDate", (o,n) => { (o as SalesOrder).RequestedDeliveryDate = n.GetDateValue(); } },
                {"salesOrderLines", (o,n) => { (o as SalesOrder).SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>(SalesOrderLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesperson", (o,n) => { (o as SalesOrder).Salesperson = n.GetStringValue(); } },
                {"sellingPostalAddress", (o,n) => { (o as SalesOrder).SellingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shippingPostalAddress", (o,n) => { (o as SalesOrder).ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Customer>("customer", Customer);
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm>("paymentTerm", PaymentTerm);
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
