using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class SalesOrder : Entity, IParsable {
        /// <summary>The billingPostalAddress property</summary>
        public PostalAddressType BillingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(BillingPostalAddress)); }
            set { BackingStore?.Set(nameof(BillingPostalAddress), value); }
        }
        /// <summary>The billToCustomerId property</summary>
        public string BillToCustomerId {
            get { return BackingStore?.Get<string>(nameof(BillToCustomerId)); }
            set { BackingStore?.Set(nameof(BillToCustomerId), value); }
        }
        /// <summary>The billToCustomerNumber property</summary>
        public string BillToCustomerNumber {
            get { return BackingStore?.Get<string>(nameof(BillToCustomerNumber)); }
            set { BackingStore?.Set(nameof(BillToCustomerNumber), value); }
        }
        /// <summary>The billToName property</summary>
        public string BillToName {
            get { return BackingStore?.Get<string>(nameof(BillToName)); }
            set { BackingStore?.Set(nameof(BillToName), value); }
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
        /// <summary>The customer property</summary>
        public Microsoft.Graph.Beta.Models.Customer Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer>(nameof(Customer)); }
            set { BackingStore?.Set(nameof(Customer), value); }
        }
        /// <summary>The customerId property</summary>
        public string CustomerId {
            get { return BackingStore?.Get<string>(nameof(CustomerId)); }
            set { BackingStore?.Set(nameof(CustomerId), value); }
        }
        /// <summary>The customerName property</summary>
        public string CustomerName {
            get { return BackingStore?.Get<string>(nameof(CustomerName)); }
            set { BackingStore?.Set(nameof(CustomerName), value); }
        }
        /// <summary>The customerNumber property</summary>
        public string CustomerNumber {
            get { return BackingStore?.Get<string>(nameof(CustomerNumber)); }
            set { BackingStore?.Set(nameof(CustomerNumber), value); }
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
        /// <summary>The email property</summary>
        public string Email {
            get { return BackingStore?.Get<string>(nameof(Email)); }
            set { BackingStore?.Set(nameof(Email), value); }
        }
        /// <summary>The externalDocumentNumber property</summary>
        public string ExternalDocumentNumber {
            get { return BackingStore?.Get<string>(nameof(ExternalDocumentNumber)); }
            set { BackingStore?.Set(nameof(ExternalDocumentNumber), value); }
        }
        /// <summary>The fullyShipped property</summary>
        public bool? FullyShipped {
            get { return BackingStore?.Get<bool?>(nameof(FullyShipped)); }
            set { BackingStore?.Set(nameof(FullyShipped), value); }
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
        /// <summary>The orderDate property</summary>
        public Date? OrderDate {
            get { return BackingStore?.Get<Date?>(nameof(OrderDate)); }
            set { BackingStore?.Set(nameof(OrderDate), value); }
        }
        /// <summary>The partialShipping property</summary>
        public bool? PartialShipping {
            get { return BackingStore?.Get<bool?>(nameof(PartialShipping)); }
            set { BackingStore?.Set(nameof(PartialShipping), value); }
        }
        /// <summary>The paymentTerm property</summary>
        public Microsoft.Graph.Beta.Models.PaymentTerm PaymentTerm {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PaymentTerm>(nameof(PaymentTerm)); }
            set { BackingStore?.Set(nameof(PaymentTerm), value); }
        }
        /// <summary>The paymentTermsId property</summary>
        public string PaymentTermsId {
            get { return BackingStore?.Get<string>(nameof(PaymentTermsId)); }
            set { BackingStore?.Set(nameof(PaymentTermsId), value); }
        }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>(nameof(PhoneNumber)); }
            set { BackingStore?.Set(nameof(PhoneNumber), value); }
        }
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax {
            get { return BackingStore?.Get<bool?>(nameof(PricesIncludeTax)); }
            set { BackingStore?.Set(nameof(PricesIncludeTax), value); }
        }
        /// <summary>The requestedDeliveryDate property</summary>
        public Date? RequestedDeliveryDate {
            get { return BackingStore?.Get<Date?>(nameof(RequestedDeliveryDate)); }
            set { BackingStore?.Set(nameof(RequestedDeliveryDate), value); }
        }
        /// <summary>The salesOrderLines property</summary>
        public List<SalesOrderLine> SalesOrderLines {
            get { return BackingStore?.Get<List<SalesOrderLine>>(nameof(SalesOrderLines)); }
            set { BackingStore?.Set(nameof(SalesOrderLines), value); }
        }
        /// <summary>The salesperson property</summary>
        public string Salesperson {
            get { return BackingStore?.Get<string>(nameof(Salesperson)); }
            set { BackingStore?.Set(nameof(Salesperson), value); }
        }
        /// <summary>The sellingPostalAddress property</summary>
        public PostalAddressType SellingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(SellingPostalAddress)); }
            set { BackingStore?.Set(nameof(SellingPostalAddress), value); }
        }
        /// <summary>The shippingPostalAddress property</summary>
        public PostalAddressType ShippingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(ShippingPostalAddress)); }
            set { BackingStore?.Set(nameof(ShippingPostalAddress), value); }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"billingPostalAddress", n => { BillingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"billToCustomerId", n => { BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", n => { BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", n => { BillToName = n.GetStringValue(); } },
                {"currency", n => { Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currencyId", n => { CurrencyId = n.GetStringValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<Microsoft.Graph.Beta.Models.Customer>(Microsoft.Graph.Beta.Models.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerName", n => { CustomerName = n.GetStringValue(); } },
                {"customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", n => { DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"externalDocumentNumber", n => { ExternalDocumentNumber = n.GetStringValue(); } },
                {"fullyShipped", n => { FullyShipped = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"orderDate", n => { OrderDate = n.GetDateValue(); } },
                {"partialShipping", n => { PartialShipping = n.GetBoolValue(); } },
                {"paymentTerm", n => { PaymentTerm = n.GetObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>(Microsoft.Graph.Beta.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", n => { PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", n => { PricesIncludeTax = n.GetBoolValue(); } },
                {"requestedDeliveryDate", n => { RequestedDeliveryDate = n.GetDateValue(); } },
                {"salesOrderLines", n => { SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>(SalesOrderLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesperson", n => { Salesperson = n.GetStringValue(); } },
                {"sellingPostalAddress", n => { SellingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shippingPostalAddress", n => { ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shipToContact", n => { ShipToContact = n.GetStringValue(); } },
                {"shipToName", n => { ShipToName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", n => { TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", n => { TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
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
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteBoolValue("fullyShipped", FullyShipped);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteDateValue("orderDate", OrderDate);
            writer.WriteBoolValue("partialShipping", PartialShipping);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm", PaymentTerm);
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
