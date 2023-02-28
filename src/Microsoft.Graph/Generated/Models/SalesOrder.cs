using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SalesOrder : Entity, IParsable {
        /// <summary>The billingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? BillingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType?>("billingPostalAddress"); }
            set { BackingStore?.Set("billingPostalAddress", value); }
        }
#nullable restore
#else
        public PostalAddressType BillingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>("billingPostalAddress"); }
            set { BackingStore?.Set("billingPostalAddress", value); }
        }
#endif
        /// <summary>The billToCustomerId property</summary>
        public Guid? BillToCustomerId {
            get { return BackingStore?.Get<Guid?>("billToCustomerId"); }
            set { BackingStore?.Set("billToCustomerId", value); }
        }
        /// <summary>The billToCustomerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillToCustomerNumber {
            get { return BackingStore?.Get<string?>("billToCustomerNumber"); }
            set { BackingStore?.Set("billToCustomerNumber", value); }
        }
#nullable restore
#else
        public string BillToCustomerNumber {
            get { return BackingStore?.Get<string>("billToCustomerNumber"); }
            set { BackingStore?.Set("billToCustomerNumber", value); }
        }
#endif
        /// <summary>The billToName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillToName {
            get { return BackingStore?.Get<string?>("billToName"); }
            set { BackingStore?.Set("billToName", value); }
        }
#nullable restore
#else
        public string BillToName {
            get { return BackingStore?.Get<string>("billToName"); }
            set { BackingStore?.Set("billToName", value); }
        }
#endif
        /// <summary>The currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Currency? Currency {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Currency?>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Currency Currency {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Currency>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#endif
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode {
            get { return BackingStore?.Get<string?>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#nullable restore
#else
        public string CurrencyCode {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#endif
        /// <summary>The currencyId property</summary>
        public Guid? CurrencyId {
            get { return BackingStore?.Get<Guid?>("currencyId"); }
            set { BackingStore?.Set("currencyId", value); }
        }
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Customer? Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer?>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Customer Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
#endif
        /// <summary>The customerId property</summary>
        public Guid? CustomerId {
            get { return BackingStore?.Get<Guid?>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
        /// <summary>The customerName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerName {
            get { return BackingStore?.Get<string?>("customerName"); }
            set { BackingStore?.Set("customerName", value); }
        }
#nullable restore
#else
        public string CustomerName {
            get { return BackingStore?.Get<string>("customerName"); }
            set { BackingStore?.Set("customerName", value); }
        }
#endif
        /// <summary>The customerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNumber {
            get { return BackingStore?.Get<string?>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
#nullable restore
#else
        public string CustomerNumber {
            get { return BackingStore?.Get<string>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
#endif
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
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The externalDocumentNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalDocumentNumber {
            get { return BackingStore?.Get<string?>("externalDocumentNumber"); }
            set { BackingStore?.Set("externalDocumentNumber", value); }
        }
#nullable restore
#else
        public string ExternalDocumentNumber {
            get { return BackingStore?.Get<string>("externalDocumentNumber"); }
            set { BackingStore?.Set("externalDocumentNumber", value); }
        }
#endif
        /// <summary>The fullyShipped property</summary>
        public bool? FullyShipped {
            get { return BackingStore?.Get<bool?>("fullyShipped"); }
            set { BackingStore?.Set("fullyShipped", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number {
            get { return BackingStore?.Get<string?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public string Number {
            get { return BackingStore?.Get<string>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>The orderDate property</summary>
        public Date? OrderDate {
            get { return BackingStore?.Get<Date?>("orderDate"); }
            set { BackingStore?.Set("orderDate", value); }
        }
        /// <summary>The partialShipping property</summary>
        public bool? PartialShipping {
            get { return BackingStore?.Get<bool?>("partialShipping"); }
            set { BackingStore?.Set("partialShipping", value); }
        }
        /// <summary>The paymentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PaymentTerm? PaymentTerm {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PaymentTerm?>("paymentTerm"); }
            set { BackingStore?.Set("paymentTerm", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PaymentTerm PaymentTerm {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm"); }
            set { BackingStore?.Set("paymentTerm", value); }
        }
#endif
        /// <summary>The paymentTermsId property</summary>
        public Guid? PaymentTermsId {
            get { return BackingStore?.Get<Guid?>("paymentTermsId"); }
            set { BackingStore?.Set("paymentTermsId", value); }
        }
        /// <summary>The phoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber {
            get { return BackingStore?.Get<string?>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#nullable restore
#else
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#endif
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax {
            get { return BackingStore?.Get<bool?>("pricesIncludeTax"); }
            set { BackingStore?.Set("pricesIncludeTax", value); }
        }
        /// <summary>The requestedDeliveryDate property</summary>
        public Date? RequestedDeliveryDate {
            get { return BackingStore?.Get<Date?>("requestedDeliveryDate"); }
            set { BackingStore?.Set("requestedDeliveryDate", value); }
        }
        /// <summary>The salesOrderLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesOrderLine>? SalesOrderLines {
            get { return BackingStore?.Get<List<SalesOrderLine>?>("salesOrderLines"); }
            set { BackingStore?.Set("salesOrderLines", value); }
        }
#nullable restore
#else
        public List<SalesOrderLine> SalesOrderLines {
            get { return BackingStore?.Get<List<SalesOrderLine>>("salesOrderLines"); }
            set { BackingStore?.Set("salesOrderLines", value); }
        }
#endif
        /// <summary>The salesperson property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Salesperson {
            get { return BackingStore?.Get<string?>("salesperson"); }
            set { BackingStore?.Set("salesperson", value); }
        }
#nullable restore
#else
        public string Salesperson {
            get { return BackingStore?.Get<string>("salesperson"); }
            set { BackingStore?.Set("salesperson", value); }
        }
#endif
        /// <summary>The sellingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? SellingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType?>("sellingPostalAddress"); }
            set { BackingStore?.Set("sellingPostalAddress", value); }
        }
#nullable restore
#else
        public PostalAddressType SellingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>("sellingPostalAddress"); }
            set { BackingStore?.Set("sellingPostalAddress", value); }
        }
#endif
        /// <summary>The shippingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? ShippingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType?>("shippingPostalAddress"); }
            set { BackingStore?.Set("shippingPostalAddress", value); }
        }
#nullable restore
#else
        public PostalAddressType ShippingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>("shippingPostalAddress"); }
            set { BackingStore?.Set("shippingPostalAddress", value); }
        }
#endif
        /// <summary>The shipToContact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShipToContact {
            get { return BackingStore?.Get<string?>("shipToContact"); }
            set { BackingStore?.Set("shipToContact", value); }
        }
#nullable restore
#else
        public string ShipToContact {
            get { return BackingStore?.Get<string>("shipToContact"); }
            set { BackingStore?.Set("shipToContact", value); }
        }
#endif
        /// <summary>The shipToName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShipToName {
            get { return BackingStore?.Get<string?>("shipToName"); }
            set { BackingStore?.Set("shipToName", value); }
        }
#nullable restore
#else
        public string ShipToName {
            get { return BackingStore?.Get<string>("shipToName"); }
            set { BackingStore?.Set("shipToName", value); }
        }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"billToCustomerId", n => { BillToCustomerId = n.GetGuidValue(); } },
                {"billToCustomerNumber", n => { BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", n => { BillToName = n.GetStringValue(); } },
                {"currency", n => { Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currencyId", n => { CurrencyId = n.GetGuidValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<Microsoft.Graph.Beta.Models.Customer>(Microsoft.Graph.Beta.Models.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", n => { CustomerId = n.GetGuidValue(); } },
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
                {"paymentTermsId", n => { PaymentTermsId = n.GetGuidValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", n => { PricesIncludeTax = n.GetBoolValue(); } },
                {"requestedDeliveryDate", n => { RequestedDeliveryDate = n.GetDateValue(); } },
                {"salesOrderLines", n => { SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>(SalesOrderLine.CreateFromDiscriminatorValue)?.ToList(); } },
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PostalAddressType>("billingPostalAddress", BillingPostalAddress);
            writer.WriteGuidValue("billToCustomerId", BillToCustomerId);
            writer.WriteStringValue("billToCustomerNumber", BillToCustomerNumber);
            writer.WriteStringValue("billToName", BillToName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteGuidValue("currencyId", CurrencyId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Customer>("customer", Customer);
            writer.WriteGuidValue("customerId", CustomerId);
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
            writer.WriteGuidValue("paymentTermsId", PaymentTermsId);
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
