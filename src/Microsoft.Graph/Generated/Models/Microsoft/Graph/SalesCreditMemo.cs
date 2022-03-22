using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SalesCreditMemo : Entity, IParsable {
        public PostalAddressType BillingPostalAddress { get; set; }
        public string BillToCustomerId { get; set; }
        public string BillToCustomerNumber { get; set; }
        public string BillToName { get; set; }
        public Date? CreditMemoDate { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Currency Currency { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyId { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? DiscountAppliedBeforeTax { get; set; }
        public Date? DueDate { get; set; }
        public string Email { get; set; }
        public string ExternalDocumentNumber { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Number { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm PaymentTerm { get; set; }
        public string PaymentTermsId { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PricesIncludeTax { get; set; }
        public List<SalesCreditMemoLine> SalesCreditMemoLines { get; set; }
        public string Salesperson { get; set; }
        public PostalAddressType SellingPostalAddress { get; set; }
        public string Status { get; set; }
        public decimal? TotalAmountExcludingTax { get; set; }
        public decimal? TotalAmountIncludingTax { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesCreditMemo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesCreditMemo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"billingPostalAddress", (o,n) => { (o as SalesCreditMemo).BillingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"billToCustomerId", (o,n) => { (o as SalesCreditMemo).BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", (o,n) => { (o as SalesCreditMemo).BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", (o,n) => { (o as SalesCreditMemo).BillToName = n.GetStringValue(); } },
                {"creditMemoDate", (o,n) => { (o as SalesCreditMemo).CreditMemoDate = n.GetDateValue(); } },
                {"currency", (o,n) => { (o as SalesCreditMemo).Currency = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Currency>(MicrosoftGraphSdk.Models.Microsoft.Graph.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", (o,n) => { (o as SalesCreditMemo).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as SalesCreditMemo).CurrencyId = n.GetStringValue(); } },
                {"customer", (o,n) => { (o as SalesCreditMemo).Customer = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Customer>(MicrosoftGraphSdk.Models.Microsoft.Graph.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", (o,n) => { (o as SalesCreditMemo).CustomerId = n.GetStringValue(); } },
                {"customerName", (o,n) => { (o as SalesCreditMemo).CustomerName = n.GetStringValue(); } },
                {"customerNumber", (o,n) => { (o as SalesCreditMemo).CustomerNumber = n.GetStringValue(); } },
                {"discountAmount", (o,n) => { (o as SalesCreditMemo).DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", (o,n) => { (o as SalesCreditMemo).DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"dueDate", (o,n) => { (o as SalesCreditMemo).DueDate = n.GetDateValue(); } },
                {"email", (o,n) => { (o as SalesCreditMemo).Email = n.GetStringValue(); } },
                {"externalDocumentNumber", (o,n) => { (o as SalesCreditMemo).ExternalDocumentNumber = n.GetStringValue(); } },
                {"invoiceId", (o,n) => { (o as SalesCreditMemo).InvoiceId = n.GetStringValue(); } },
                {"invoiceNumber", (o,n) => { (o as SalesCreditMemo).InvoiceNumber = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as SalesCreditMemo).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as SalesCreditMemo).Number = n.GetStringValue(); } },
                {"paymentTerm", (o,n) => { (o as SalesCreditMemo).PaymentTerm = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm>(MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", (o,n) => { (o as SalesCreditMemo).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as SalesCreditMemo).PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", (o,n) => { (o as SalesCreditMemo).PricesIncludeTax = n.GetBoolValue(); } },
                {"salesCreditMemoLines", (o,n) => { (o as SalesCreditMemo).SalesCreditMemoLines = n.GetCollectionOfObjectValues<SalesCreditMemoLine>(SalesCreditMemoLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesperson", (o,n) => { (o as SalesCreditMemo).Salesperson = n.GetStringValue(); } },
                {"sellingPostalAddress", (o,n) => { (o as SalesCreditMemo).SellingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as SalesCreditMemo).Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", (o,n) => { (o as SalesCreditMemo).TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", (o,n) => { (o as SalesCreditMemo).TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", (o,n) => { (o as SalesCreditMemo).TotalTaxAmount = n.GetDecimalValue(); } },
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
            writer.WriteDateValue("creditMemoDate", CreditMemoDate);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Customer>("customer", Customer);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteStringValue("invoiceId", InvoiceId);
            writer.WriteStringValue("invoiceNumber", InvoiceNumber);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteBoolValue("pricesIncludeTax", PricesIncludeTax);
            writer.WriteCollectionOfObjectValues<SalesCreditMemoLine>("salesCreditMemoLines", SalesCreditMemoLines);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
            writer.WriteStringValue("status", Status);
            writer.WriteDecimalValue("totalAmountExcludingTax", TotalAmountExcludingTax);
            writer.WriteDecimalValue("totalAmountIncludingTax", TotalAmountIncludingTax);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
        }
    }
}
