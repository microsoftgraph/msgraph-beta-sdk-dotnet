using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Company : Entity, IParsable {
        /// <summary>The accounts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Account>? Accounts {
            get { return BackingStore?.Get<List<Account>?>("accounts"); }
            set { BackingStore?.Set("accounts", value); }
        }
#else
        public List<Account> Accounts {
            get { return BackingStore?.Get<List<Account>>("accounts"); }
            set { BackingStore?.Set("accounts", value); }
        }
#endif
        /// <summary>The agedAccountsPayable property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Beta.Models.AgedAccountsPayable>? AgedAccountsPayable {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AgedAccountsPayable>?>("agedAccountsPayable"); }
            set { BackingStore?.Set("agedAccountsPayable", value); }
        }
#else
        public List<Microsoft.Graph.Beta.Models.AgedAccountsPayable> AgedAccountsPayable {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AgedAccountsPayable>>("agedAccountsPayable"); }
            set { BackingStore?.Set("agedAccountsPayable", value); }
        }
#endif
        /// <summary>The agedAccountsReceivable property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Beta.Models.AgedAccountsReceivable>? AgedAccountsReceivable {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AgedAccountsReceivable>?>("agedAccountsReceivable"); }
            set { BackingStore?.Set("agedAccountsReceivable", value); }
        }
#else
        public List<Microsoft.Graph.Beta.Models.AgedAccountsReceivable> AgedAccountsReceivable {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AgedAccountsReceivable>>("agedAccountsReceivable"); }
            set { BackingStore?.Set("agedAccountsReceivable", value); }
        }
#endif
        /// <summary>The businessProfileId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? BusinessProfileId {
            get { return BackingStore?.Get<string?>("businessProfileId"); }
            set { BackingStore?.Set("businessProfileId", value); }
        }
#else
        public string BusinessProfileId {
            get { return BackingStore?.Get<string>("businessProfileId"); }
            set { BackingStore?.Set("businessProfileId", value); }
        }
#endif
        /// <summary>The companyInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Beta.Models.CompanyInformation>? CompanyInformation {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CompanyInformation>?>("companyInformation"); }
            set { BackingStore?.Set("companyInformation", value); }
        }
#else
        public List<Microsoft.Graph.Beta.Models.CompanyInformation> CompanyInformation {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CompanyInformation>>("companyInformation"); }
            set { BackingStore?.Set("companyInformation", value); }
        }
#endif
        /// <summary>The countriesRegions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<CountryRegion>? CountriesRegions {
            get { return BackingStore?.Get<List<CountryRegion>?>("countriesRegions"); }
            set { BackingStore?.Set("countriesRegions", value); }
        }
#else
        public List<CountryRegion> CountriesRegions {
            get { return BackingStore?.Get<List<CountryRegion>>("countriesRegions"); }
            set { BackingStore?.Set("countriesRegions", value); }
        }
#endif
        /// <summary>The currencies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Currency>? Currencies {
            get { return BackingStore?.Get<List<Currency>?>("currencies"); }
            set { BackingStore?.Set("currencies", value); }
        }
#else
        public List<Currency> Currencies {
            get { return BackingStore?.Get<List<Currency>>("currencies"); }
            set { BackingStore?.Set("currencies", value); }
        }
#endif
        /// <summary>The customerPaymentJournals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<CustomerPaymentJournal>? CustomerPaymentJournals {
            get { return BackingStore?.Get<List<CustomerPaymentJournal>?>("customerPaymentJournals"); }
            set { BackingStore?.Set("customerPaymentJournals", value); }
        }
#else
        public List<CustomerPaymentJournal> CustomerPaymentJournals {
            get { return BackingStore?.Get<List<CustomerPaymentJournal>>("customerPaymentJournals"); }
            set { BackingStore?.Set("customerPaymentJournals", value); }
        }
#endif
        /// <summary>The customerPayments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<CustomerPayment>? CustomerPayments {
            get { return BackingStore?.Get<List<CustomerPayment>?>("customerPayments"); }
            set { BackingStore?.Set("customerPayments", value); }
        }
#else
        public List<CustomerPayment> CustomerPayments {
            get { return BackingStore?.Get<List<CustomerPayment>>("customerPayments"); }
            set { BackingStore?.Set("customerPayments", value); }
        }
#endif
        /// <summary>The customers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Customer>? Customers {
            get { return BackingStore?.Get<List<Customer>?>("customers"); }
            set { BackingStore?.Set("customers", value); }
        }
#else
        public List<Customer> Customers {
            get { return BackingStore?.Get<List<Customer>>("customers"); }
            set { BackingStore?.Set("customers", value); }
        }
#endif
        /// <summary>The dimensions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Dimension>? Dimensions {
            get { return BackingStore?.Get<List<Dimension>?>("dimensions"); }
            set { BackingStore?.Set("dimensions", value); }
        }
#else
        public List<Dimension> Dimensions {
            get { return BackingStore?.Get<List<Dimension>>("dimensions"); }
            set { BackingStore?.Set("dimensions", value); }
        }
#endif
        /// <summary>The dimensionValues property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DimensionValue>? DimensionValues {
            get { return BackingStore?.Get<List<DimensionValue>?>("dimensionValues"); }
            set { BackingStore?.Set("dimensionValues", value); }
        }
#else
        public List<DimensionValue> DimensionValues {
            get { return BackingStore?.Get<List<DimensionValue>>("dimensionValues"); }
            set { BackingStore?.Set("dimensionValues", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The employees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Employee>? Employees {
            get { return BackingStore?.Get<List<Employee>?>("employees"); }
            set { BackingStore?.Set("employees", value); }
        }
#else
        public List<Employee> Employees {
            get { return BackingStore?.Get<List<Employee>>("employees"); }
            set { BackingStore?.Set("employees", value); }
        }
#endif
        /// <summary>The generalLedgerEntries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<GeneralLedgerEntry>? GeneralLedgerEntries {
            get { return BackingStore?.Get<List<GeneralLedgerEntry>?>("generalLedgerEntries"); }
            set { BackingStore?.Set("generalLedgerEntries", value); }
        }
#else
        public List<GeneralLedgerEntry> GeneralLedgerEntries {
            get { return BackingStore?.Get<List<GeneralLedgerEntry>>("generalLedgerEntries"); }
            set { BackingStore?.Set("generalLedgerEntries", value); }
        }
#endif
        /// <summary>The itemCategories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ItemCategory>? ItemCategories {
            get { return BackingStore?.Get<List<ItemCategory>?>("itemCategories"); }
            set { BackingStore?.Set("itemCategories", value); }
        }
#else
        public List<ItemCategory> ItemCategories {
            get { return BackingStore?.Get<List<ItemCategory>>("itemCategories"); }
            set { BackingStore?.Set("itemCategories", value); }
        }
#endif
        /// <summary>The items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Item>? Items {
            get { return BackingStore?.Get<List<Item>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#else
        public List<Item> Items {
            get { return BackingStore?.Get<List<Item>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>The journalLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<JournalLine>? JournalLines {
            get { return BackingStore?.Get<List<JournalLine>?>("journalLines"); }
            set { BackingStore?.Set("journalLines", value); }
        }
#else
        public List<JournalLine> JournalLines {
            get { return BackingStore?.Get<List<JournalLine>>("journalLines"); }
            set { BackingStore?.Set("journalLines", value); }
        }
#endif
        /// <summary>The journals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Journal>? Journals {
            get { return BackingStore?.Get<List<Journal>?>("journals"); }
            set { BackingStore?.Set("journals", value); }
        }
#else
        public List<Journal> Journals {
            get { return BackingStore?.Get<List<Journal>>("journals"); }
            set { BackingStore?.Set("journals", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The paymentMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<PaymentMethod>? PaymentMethods {
            get { return BackingStore?.Get<List<PaymentMethod>?>("paymentMethods"); }
            set { BackingStore?.Set("paymentMethods", value); }
        }
#else
        public List<PaymentMethod> PaymentMethods {
            get { return BackingStore?.Get<List<PaymentMethod>>("paymentMethods"); }
            set { BackingStore?.Set("paymentMethods", value); }
        }
#endif
        /// <summary>The paymentTerms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<PaymentTerm>? PaymentTerms {
            get { return BackingStore?.Get<List<PaymentTerm>?>("paymentTerms"); }
            set { BackingStore?.Set("paymentTerms", value); }
        }
#else
        public List<PaymentTerm> PaymentTerms {
            get { return BackingStore?.Get<List<PaymentTerm>>("paymentTerms"); }
            set { BackingStore?.Set("paymentTerms", value); }
        }
#endif
        /// <summary>The picture property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Beta.Models.Picture>? Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>?>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
#else
        public List<Microsoft.Graph.Beta.Models.Picture> Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
#endif
        /// <summary>The purchaseInvoiceLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<PurchaseInvoiceLine>? PurchaseInvoiceLines {
            get { return BackingStore?.Get<List<PurchaseInvoiceLine>?>("purchaseInvoiceLines"); }
            set { BackingStore?.Set("purchaseInvoiceLines", value); }
        }
#else
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines {
            get { return BackingStore?.Get<List<PurchaseInvoiceLine>>("purchaseInvoiceLines"); }
            set { BackingStore?.Set("purchaseInvoiceLines", value); }
        }
#endif
        /// <summary>The purchaseInvoices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<PurchaseInvoice>? PurchaseInvoices {
            get { return BackingStore?.Get<List<PurchaseInvoice>?>("purchaseInvoices"); }
            set { BackingStore?.Set("purchaseInvoices", value); }
        }
#else
        public List<PurchaseInvoice> PurchaseInvoices {
            get { return BackingStore?.Get<List<PurchaseInvoice>>("purchaseInvoices"); }
            set { BackingStore?.Set("purchaseInvoices", value); }
        }
#endif
        /// <summary>The salesCreditMemoLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SalesCreditMemoLine>? SalesCreditMemoLines {
            get { return BackingStore?.Get<List<SalesCreditMemoLine>?>("salesCreditMemoLines"); }
            set { BackingStore?.Set("salesCreditMemoLines", value); }
        }
#else
        public List<SalesCreditMemoLine> SalesCreditMemoLines {
            get { return BackingStore?.Get<List<SalesCreditMemoLine>>("salesCreditMemoLines"); }
            set { BackingStore?.Set("salesCreditMemoLines", value); }
        }
#endif
        /// <summary>The salesCreditMemos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SalesCreditMemo>? SalesCreditMemos {
            get { return BackingStore?.Get<List<SalesCreditMemo>?>("salesCreditMemos"); }
            set { BackingStore?.Set("salesCreditMemos", value); }
        }
#else
        public List<SalesCreditMemo> SalesCreditMemos {
            get { return BackingStore?.Get<List<SalesCreditMemo>>("salesCreditMemos"); }
            set { BackingStore?.Set("salesCreditMemos", value); }
        }
#endif
        /// <summary>The salesInvoiceLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SalesInvoiceLine>? SalesInvoiceLines {
            get { return BackingStore?.Get<List<SalesInvoiceLine>?>("salesInvoiceLines"); }
            set { BackingStore?.Set("salesInvoiceLines", value); }
        }
#else
        public List<SalesInvoiceLine> SalesInvoiceLines {
            get { return BackingStore?.Get<List<SalesInvoiceLine>>("salesInvoiceLines"); }
            set { BackingStore?.Set("salesInvoiceLines", value); }
        }
#endif
        /// <summary>The salesInvoices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SalesInvoice>? SalesInvoices {
            get { return BackingStore?.Get<List<SalesInvoice>?>("salesInvoices"); }
            set { BackingStore?.Set("salesInvoices", value); }
        }
#else
        public List<SalesInvoice> SalesInvoices {
            get { return BackingStore?.Get<List<SalesInvoice>>("salesInvoices"); }
            set { BackingStore?.Set("salesInvoices", value); }
        }
#endif
        /// <summary>The salesOrderLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SalesOrderLine>? SalesOrderLines {
            get { return BackingStore?.Get<List<SalesOrderLine>?>("salesOrderLines"); }
            set { BackingStore?.Set("salesOrderLines", value); }
        }
#else
        public List<SalesOrderLine> SalesOrderLines {
            get { return BackingStore?.Get<List<SalesOrderLine>>("salesOrderLines"); }
            set { BackingStore?.Set("salesOrderLines", value); }
        }
#endif
        /// <summary>The salesOrders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SalesOrder>? SalesOrders {
            get { return BackingStore?.Get<List<SalesOrder>?>("salesOrders"); }
            set { BackingStore?.Set("salesOrders", value); }
        }
#else
        public List<SalesOrder> SalesOrders {
            get { return BackingStore?.Get<List<SalesOrder>>("salesOrders"); }
            set { BackingStore?.Set("salesOrders", value); }
        }
#endif
        /// <summary>The salesQuoteLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SalesQuoteLine>? SalesQuoteLines {
            get { return BackingStore?.Get<List<SalesQuoteLine>?>("salesQuoteLines"); }
            set { BackingStore?.Set("salesQuoteLines", value); }
        }
#else
        public List<SalesQuoteLine> SalesQuoteLines {
            get { return BackingStore?.Get<List<SalesQuoteLine>>("salesQuoteLines"); }
            set { BackingStore?.Set("salesQuoteLines", value); }
        }
#endif
        /// <summary>The salesQuotes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SalesQuote>? SalesQuotes {
            get { return BackingStore?.Get<List<SalesQuote>?>("salesQuotes"); }
            set { BackingStore?.Set("salesQuotes", value); }
        }
#else
        public List<SalesQuote> SalesQuotes {
            get { return BackingStore?.Get<List<SalesQuote>>("salesQuotes"); }
            set { BackingStore?.Set("salesQuotes", value); }
        }
#endif
        /// <summary>The shipmentMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ShipmentMethod>? ShipmentMethods {
            get { return BackingStore?.Get<List<ShipmentMethod>?>("shipmentMethods"); }
            set { BackingStore?.Set("shipmentMethods", value); }
        }
#else
        public List<ShipmentMethod> ShipmentMethods {
            get { return BackingStore?.Get<List<ShipmentMethod>>("shipmentMethods"); }
            set { BackingStore?.Set("shipmentMethods", value); }
        }
#endif
        /// <summary>The systemVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SystemVersion {
            get { return BackingStore?.Get<string?>("systemVersion"); }
            set { BackingStore?.Set("systemVersion", value); }
        }
#else
        public string SystemVersion {
            get { return BackingStore?.Get<string>("systemVersion"); }
            set { BackingStore?.Set("systemVersion", value); }
        }
#endif
        /// <summary>The taxAreas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<TaxArea>? TaxAreas {
            get { return BackingStore?.Get<List<TaxArea>?>("taxAreas"); }
            set { BackingStore?.Set("taxAreas", value); }
        }
#else
        public List<TaxArea> TaxAreas {
            get { return BackingStore?.Get<List<TaxArea>>("taxAreas"); }
            set { BackingStore?.Set("taxAreas", value); }
        }
#endif
        /// <summary>The taxGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<TaxGroup>? TaxGroups {
            get { return BackingStore?.Get<List<TaxGroup>?>("taxGroups"); }
            set { BackingStore?.Set("taxGroups", value); }
        }
#else
        public List<TaxGroup> TaxGroups {
            get { return BackingStore?.Get<List<TaxGroup>>("taxGroups"); }
            set { BackingStore?.Set("taxGroups", value); }
        }
#endif
        /// <summary>The unitsOfMeasure property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<UnitOfMeasure>? UnitsOfMeasure {
            get { return BackingStore?.Get<List<UnitOfMeasure>?>("unitsOfMeasure"); }
            set { BackingStore?.Set("unitsOfMeasure", value); }
        }
#else
        public List<UnitOfMeasure> UnitsOfMeasure {
            get { return BackingStore?.Get<List<UnitOfMeasure>>("unitsOfMeasure"); }
            set { BackingStore?.Set("unitsOfMeasure", value); }
        }
#endif
        /// <summary>The vendors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Vendor>? Vendors {
            get { return BackingStore?.Get<List<Vendor>?>("vendors"); }
            set { BackingStore?.Set("vendors", value); }
        }
#else
        public List<Vendor> Vendors {
            get { return BackingStore?.Get<List<Vendor>>("vendors"); }
            set { BackingStore?.Set("vendors", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Company CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Company();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accounts", n => { Accounts = n.GetCollectionOfObjectValues<Account>(Account.CreateFromDiscriminatorValue)?.ToList(); } },
                {"agedAccountsPayable", n => { AgedAccountsPayable = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AgedAccountsPayable>(Microsoft.Graph.Beta.Models.AgedAccountsPayable.CreateFromDiscriminatorValue)?.ToList(); } },
                {"agedAccountsReceivable", n => { AgedAccountsReceivable = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AgedAccountsReceivable>(Microsoft.Graph.Beta.Models.AgedAccountsReceivable.CreateFromDiscriminatorValue)?.ToList(); } },
                {"businessProfileId", n => { BusinessProfileId = n.GetStringValue(); } },
                {"companyInformation", n => { CompanyInformation = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CompanyInformation>(Microsoft.Graph.Beta.Models.CompanyInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"countriesRegions", n => { CountriesRegions = n.GetCollectionOfObjectValues<CountryRegion>(CountryRegion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"currencies", n => { Currencies = n.GetCollectionOfObjectValues<Currency>(Currency.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customerPaymentJournals", n => { CustomerPaymentJournals = n.GetCollectionOfObjectValues<CustomerPaymentJournal>(CustomerPaymentJournal.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customerPayments", n => { CustomerPayments = n.GetCollectionOfObjectValues<CustomerPayment>(CustomerPayment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<Customer>(Customer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dimensions", n => { Dimensions = n.GetCollectionOfObjectValues<Dimension>(Dimension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dimensionValues", n => { DimensionValues = n.GetCollectionOfObjectValues<DimensionValue>(DimensionValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"employees", n => { Employees = n.GetCollectionOfObjectValues<Employee>(Employee.CreateFromDiscriminatorValue)?.ToList(); } },
                {"generalLedgerEntries", n => { GeneralLedgerEntries = n.GetCollectionOfObjectValues<GeneralLedgerEntry>(GeneralLedgerEntry.CreateFromDiscriminatorValue)?.ToList(); } },
                {"itemCategories", n => { ItemCategories = n.GetCollectionOfObjectValues<ItemCategory>(ItemCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<Item>(Item.CreateFromDiscriminatorValue)?.ToList(); } },
                {"journalLines", n => { JournalLines = n.GetCollectionOfObjectValues<JournalLine>(JournalLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"journals", n => { Journals = n.GetCollectionOfObjectValues<Journal>(Journal.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"paymentMethods", n => { PaymentMethods = n.GetCollectionOfObjectValues<PaymentMethod>(PaymentMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                {"paymentTerms", n => { PaymentTerms = n.GetCollectionOfObjectValues<PaymentTerm>(PaymentTerm.CreateFromDiscriminatorValue)?.ToList(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue)?.ToList(); } },
                {"purchaseInvoiceLines", n => { PurchaseInvoiceLines = n.GetCollectionOfObjectValues<PurchaseInvoiceLine>(PurchaseInvoiceLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"purchaseInvoices", n => { PurchaseInvoices = n.GetCollectionOfObjectValues<PurchaseInvoice>(PurchaseInvoice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesCreditMemoLines", n => { SalesCreditMemoLines = n.GetCollectionOfObjectValues<SalesCreditMemoLine>(SalesCreditMemoLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesCreditMemos", n => { SalesCreditMemos = n.GetCollectionOfObjectValues<SalesCreditMemo>(SalesCreditMemo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesInvoiceLines", n => { SalesInvoiceLines = n.GetCollectionOfObjectValues<SalesInvoiceLine>(SalesInvoiceLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesInvoices", n => { SalesInvoices = n.GetCollectionOfObjectValues<SalesInvoice>(SalesInvoice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesOrderLines", n => { SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>(SalesOrderLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesOrders", n => { SalesOrders = n.GetCollectionOfObjectValues<SalesOrder>(SalesOrder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesQuoteLines", n => { SalesQuoteLines = n.GetCollectionOfObjectValues<SalesQuoteLine>(SalesQuoteLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesQuotes", n => { SalesQuotes = n.GetCollectionOfObjectValues<SalesQuote>(SalesQuote.CreateFromDiscriminatorValue)?.ToList(); } },
                {"shipmentMethods", n => { ShipmentMethods = n.GetCollectionOfObjectValues<ShipmentMethod>(ShipmentMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemVersion", n => { SystemVersion = n.GetStringValue(); } },
                {"taxAreas", n => { TaxAreas = n.GetCollectionOfObjectValues<TaxArea>(TaxArea.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taxGroups", n => { TaxGroups = n.GetCollectionOfObjectValues<TaxGroup>(TaxGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"unitsOfMeasure", n => { UnitsOfMeasure = n.GetCollectionOfObjectValues<UnitOfMeasure>(UnitOfMeasure.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vendors", n => { Vendors = n.GetCollectionOfObjectValues<Vendor>(Vendor.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Account>("accounts", Accounts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AgedAccountsPayable>("agedAccountsPayable", AgedAccountsPayable);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AgedAccountsReceivable>("agedAccountsReceivable", AgedAccountsReceivable);
            writer.WriteStringValue("businessProfileId", BusinessProfileId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CompanyInformation>("companyInformation", CompanyInformation);
            writer.WriteCollectionOfObjectValues<CountryRegion>("countriesRegions", CountriesRegions);
            writer.WriteCollectionOfObjectValues<Currency>("currencies", Currencies);
            writer.WriteCollectionOfObjectValues<CustomerPaymentJournal>("customerPaymentJournals", CustomerPaymentJournals);
            writer.WriteCollectionOfObjectValues<CustomerPayment>("customerPayments", CustomerPayments);
            writer.WriteCollectionOfObjectValues<Customer>("customers", Customers);
            writer.WriteCollectionOfObjectValues<Dimension>("dimensions", Dimensions);
            writer.WriteCollectionOfObjectValues<DimensionValue>("dimensionValues", DimensionValues);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Employee>("employees", Employees);
            writer.WriteCollectionOfObjectValues<GeneralLedgerEntry>("generalLedgerEntries", GeneralLedgerEntries);
            writer.WriteCollectionOfObjectValues<ItemCategory>("itemCategories", ItemCategories);
            writer.WriteCollectionOfObjectValues<Item>("items", Items);
            writer.WriteCollectionOfObjectValues<JournalLine>("journalLines", JournalLines);
            writer.WriteCollectionOfObjectValues<Journal>("journals", Journals);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<PaymentMethod>("paymentMethods", PaymentMethods);
            writer.WriteCollectionOfObjectValues<PaymentTerm>("paymentTerms", PaymentTerms);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>("picture", Picture);
            writer.WriteCollectionOfObjectValues<PurchaseInvoiceLine>("purchaseInvoiceLines", PurchaseInvoiceLines);
            writer.WriteCollectionOfObjectValues<PurchaseInvoice>("purchaseInvoices", PurchaseInvoices);
            writer.WriteCollectionOfObjectValues<SalesCreditMemoLine>("salesCreditMemoLines", SalesCreditMemoLines);
            writer.WriteCollectionOfObjectValues<SalesCreditMemo>("salesCreditMemos", SalesCreditMemos);
            writer.WriteCollectionOfObjectValues<SalesInvoiceLine>("salesInvoiceLines", SalesInvoiceLines);
            writer.WriteCollectionOfObjectValues<SalesInvoice>("salesInvoices", SalesInvoices);
            writer.WriteCollectionOfObjectValues<SalesOrderLine>("salesOrderLines", SalesOrderLines);
            writer.WriteCollectionOfObjectValues<SalesOrder>("salesOrders", SalesOrders);
            writer.WriteCollectionOfObjectValues<SalesQuoteLine>("salesQuoteLines", SalesQuoteLines);
            writer.WriteCollectionOfObjectValues<SalesQuote>("salesQuotes", SalesQuotes);
            writer.WriteCollectionOfObjectValues<ShipmentMethod>("shipmentMethods", ShipmentMethods);
            writer.WriteStringValue("systemVersion", SystemVersion);
            writer.WriteCollectionOfObjectValues<TaxArea>("taxAreas", TaxAreas);
            writer.WriteCollectionOfObjectValues<TaxGroup>("taxGroups", TaxGroups);
            writer.WriteCollectionOfObjectValues<UnitOfMeasure>("unitsOfMeasure", UnitsOfMeasure);
            writer.WriteCollectionOfObjectValues<Vendor>("vendors", Vendors);
        }
    }
}
