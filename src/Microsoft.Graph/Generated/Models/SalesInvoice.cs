using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SalesInvoice : Entity, IParsable {
        /// <summary>The billingPostalAddress property</summary>
        public PostalAddressType BillingPostalAddress { get; set; }
        /// <summary>The billToCustomerId property</summary>
        public string BillToCustomerId { get; set; }
        /// <summary>The billToCustomerNumber property</summary>
        public string BillToCustomerNumber { get; set; }
        /// <summary>The billToName property</summary>
        public string BillToName { get; set; }
        /// <summary>The currency property</summary>
        public Microsoft.Graph.Beta.Models.Currency Currency { get; set; }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode { get; set; }
        /// <summary>The currencyId property</summary>
        public string CurrencyId { get; set; }
        /// <summary>The customer property</summary>
        public Microsoft.Graph.Beta.Models.Customer Customer { get; set; }
        /// <summary>The customerId property</summary>
        public string CustomerId { get; set; }
        /// <summary>The customerName property</summary>
        public string CustomerName { get; set; }
        /// <summary>The customerNumber property</summary>
        public string CustomerNumber { get; set; }
        /// <summary>The customerPurchaseOrderReference property</summary>
        public string CustomerPurchaseOrderReference { get; set; }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount { get; set; }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax { get; set; }
        /// <summary>The dueDate property</summary>
        public Date? DueDate { get; set; }
        /// <summary>The email property</summary>
        public string Email { get; set; }
        /// <summary>The externalDocumentNumber property</summary>
        public string ExternalDocumentNumber { get; set; }
        /// <summary>The invoiceDate property</summary>
        public Date? InvoiceDate { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The number property</summary>
        public string Number { get; set; }
        /// <summary>The orderId property</summary>
        public string OrderId { get; set; }
        /// <summary>The orderNumber property</summary>
        public string OrderNumber { get; set; }
        /// <summary>The paymentTerm property</summary>
        public Microsoft.Graph.Beta.Models.PaymentTerm PaymentTerm { get; set; }
        /// <summary>The paymentTermsId property</summary>
        public string PaymentTermsId { get; set; }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber { get; set; }
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax { get; set; }
        /// <summary>The salesInvoiceLines property</summary>
        public List<SalesInvoiceLine> SalesInvoiceLines { get; set; }
        /// <summary>The salesperson property</summary>
        public string Salesperson { get; set; }
        /// <summary>The sellingPostalAddress property</summary>
        public PostalAddressType SellingPostalAddress { get; set; }
        /// <summary>The shipmentMethod property</summary>
        public Microsoft.Graph.Beta.Models.ShipmentMethod ShipmentMethod { get; set; }
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesInvoice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesInvoice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"billingPostalAddress", (o,n) => { (o as SalesInvoice).BillingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"billToCustomerId", (o,n) => { (o as SalesInvoice).BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", (o,n) => { (o as SalesInvoice).BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", (o,n) => { (o as SalesInvoice).BillToName = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as SalesInvoice).Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", (o,n) => { (o as SalesInvoice).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as SalesInvoice).CurrencyId = n.GetStringValue(); } },
                {"customer", (o,n) => { (o as SalesInvoice).Customer = n.GetObjectValue<Microsoft.Graph.Beta.Models.Customer>(Microsoft.Graph.Beta.Models.Customer.CreateFromDiscriminatorValue); } },
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
                {"paymentTerm", (o,n) => { (o as SalesInvoice).PaymentTerm = n.GetObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>(Microsoft.Graph.Beta.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", (o,n) => { (o as SalesInvoice).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as SalesInvoice).PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", (o,n) => { (o as SalesInvoice).PricesIncludeTax = n.GetBoolValue(); } },
                {"salesInvoiceLines", (o,n) => { (o as SalesInvoice).SalesInvoiceLines = n.GetCollectionOfObjectValues<SalesInvoiceLine>(SalesInvoiceLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesperson", (o,n) => { (o as SalesInvoice).Salesperson = n.GetStringValue(); } },
                {"sellingPostalAddress", (o,n) => { (o as SalesInvoice).SellingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shipmentMethod", (o,n) => { (o as SalesInvoice).ShipmentMethod = n.GetObjectValue<Microsoft.Graph.Beta.Models.ShipmentMethod>(Microsoft.Graph.Beta.Models.ShipmentMethod.CreateFromDiscriminatorValue); } },
                {"shipmentMethodId", (o,n) => { (o as SalesInvoice).ShipmentMethodId = n.GetStringValue(); } },
                {"shippingPostalAddress", (o,n) => { (o as SalesInvoice).ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Customer>("customer", Customer);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteBoolValue("pricesIncludeTax", PricesIncludeTax);
            writer.WriteCollectionOfObjectValues<SalesInvoiceLine>("salesInvoiceLines", SalesInvoiceLines);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ShipmentMethod>("shipmentMethod", ShipmentMethod);
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
