using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Company : Entity, IParsable {
        /// <summary>The accounts property</summary>
        public List<Account> Accounts {
            get { return BackingStore?.Get<List<Account>>(nameof(Accounts)); }
            set { BackingStore?.Set(nameof(Accounts), value); }
        }
        /// <summary>The agedAccountsPayable property</summary>
        public List<Microsoft.Graph.Beta.Models.AgedAccountsPayable> AgedAccountsPayable {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AgedAccountsPayable>>(nameof(AgedAccountsPayable)); }
            set { BackingStore?.Set(nameof(AgedAccountsPayable), value); }
        }
        /// <summary>The agedAccountsReceivable property</summary>
        public List<Microsoft.Graph.Beta.Models.AgedAccountsReceivable> AgedAccountsReceivable {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AgedAccountsReceivable>>(nameof(AgedAccountsReceivable)); }
            set { BackingStore?.Set(nameof(AgedAccountsReceivable), value); }
        }
        /// <summary>The businessProfileId property</summary>
        public string BusinessProfileId {
            get { return BackingStore?.Get<string>(nameof(BusinessProfileId)); }
            set { BackingStore?.Set(nameof(BusinessProfileId), value); }
        }
        /// <summary>The companyInformation property</summary>
        public List<Microsoft.Graph.Beta.Models.CompanyInformation> CompanyInformation {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CompanyInformation>>(nameof(CompanyInformation)); }
            set { BackingStore?.Set(nameof(CompanyInformation), value); }
        }
        /// <summary>The countriesRegions property</summary>
        public List<CountryRegion> CountriesRegions {
            get { return BackingStore?.Get<List<CountryRegion>>(nameof(CountriesRegions)); }
            set { BackingStore?.Set(nameof(CountriesRegions), value); }
        }
        /// <summary>The currencies property</summary>
        public List<Currency> Currencies {
            get { return BackingStore?.Get<List<Currency>>(nameof(Currencies)); }
            set { BackingStore?.Set(nameof(Currencies), value); }
        }
        /// <summary>The customerPaymentJournals property</summary>
        public List<CustomerPaymentJournal> CustomerPaymentJournals {
            get { return BackingStore?.Get<List<CustomerPaymentJournal>>(nameof(CustomerPaymentJournals)); }
            set { BackingStore?.Set(nameof(CustomerPaymentJournals), value); }
        }
        /// <summary>The customerPayments property</summary>
        public List<CustomerPayment> CustomerPayments {
            get { return BackingStore?.Get<List<CustomerPayment>>(nameof(CustomerPayments)); }
            set { BackingStore?.Set(nameof(CustomerPayments), value); }
        }
        /// <summary>The customers property</summary>
        public List<Customer> Customers {
            get { return BackingStore?.Get<List<Customer>>(nameof(Customers)); }
            set { BackingStore?.Set(nameof(Customers), value); }
        }
        /// <summary>The dimensions property</summary>
        public List<Dimension> Dimensions {
            get { return BackingStore?.Get<List<Dimension>>(nameof(Dimensions)); }
            set { BackingStore?.Set(nameof(Dimensions), value); }
        }
        /// <summary>The dimensionValues property</summary>
        public List<DimensionValue> DimensionValues {
            get { return BackingStore?.Get<List<DimensionValue>>(nameof(DimensionValues)); }
            set { BackingStore?.Set(nameof(DimensionValues), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The employees property</summary>
        public List<Employee> Employees {
            get { return BackingStore?.Get<List<Employee>>(nameof(Employees)); }
            set { BackingStore?.Set(nameof(Employees), value); }
        }
        /// <summary>The generalLedgerEntries property</summary>
        public List<GeneralLedgerEntry> GeneralLedgerEntries {
            get { return BackingStore?.Get<List<GeneralLedgerEntry>>(nameof(GeneralLedgerEntries)); }
            set { BackingStore?.Set(nameof(GeneralLedgerEntries), value); }
        }
        /// <summary>The itemCategories property</summary>
        public List<ItemCategory> ItemCategories {
            get { return BackingStore?.Get<List<ItemCategory>>(nameof(ItemCategories)); }
            set { BackingStore?.Set(nameof(ItemCategories), value); }
        }
        /// <summary>The items property</summary>
        public List<Item> Items {
            get { return BackingStore?.Get<List<Item>>(nameof(Items)); }
            set { BackingStore?.Set(nameof(Items), value); }
        }
        /// <summary>The journalLines property</summary>
        public List<JournalLine> JournalLines {
            get { return BackingStore?.Get<List<JournalLine>>(nameof(JournalLines)); }
            set { BackingStore?.Set(nameof(JournalLines), value); }
        }
        /// <summary>The journals property</summary>
        public List<Journal> Journals {
            get { return BackingStore?.Get<List<Journal>>(nameof(Journals)); }
            set { BackingStore?.Set(nameof(Journals), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The paymentMethods property</summary>
        public List<PaymentMethod> PaymentMethods {
            get { return BackingStore?.Get<List<PaymentMethod>>(nameof(PaymentMethods)); }
            set { BackingStore?.Set(nameof(PaymentMethods), value); }
        }
        /// <summary>The paymentTerms property</summary>
        public List<PaymentTerm> PaymentTerms {
            get { return BackingStore?.Get<List<PaymentTerm>>(nameof(PaymentTerms)); }
            set { BackingStore?.Set(nameof(PaymentTerms), value); }
        }
        /// <summary>The picture property</summary>
        public List<Microsoft.Graph.Beta.Models.Picture> Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>>(nameof(Picture)); }
            set { BackingStore?.Set(nameof(Picture), value); }
        }
        /// <summary>The purchaseInvoiceLines property</summary>
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines {
            get { return BackingStore?.Get<List<PurchaseInvoiceLine>>(nameof(PurchaseInvoiceLines)); }
            set { BackingStore?.Set(nameof(PurchaseInvoiceLines), value); }
        }
        /// <summary>The purchaseInvoices property</summary>
        public List<PurchaseInvoice> PurchaseInvoices {
            get { return BackingStore?.Get<List<PurchaseInvoice>>(nameof(PurchaseInvoices)); }
            set { BackingStore?.Set(nameof(PurchaseInvoices), value); }
        }
        /// <summary>The salesCreditMemoLines property</summary>
        public List<SalesCreditMemoLine> SalesCreditMemoLines {
            get { return BackingStore?.Get<List<SalesCreditMemoLine>>(nameof(SalesCreditMemoLines)); }
            set { BackingStore?.Set(nameof(SalesCreditMemoLines), value); }
        }
        /// <summary>The salesCreditMemos property</summary>
        public List<SalesCreditMemo> SalesCreditMemos {
            get { return BackingStore?.Get<List<SalesCreditMemo>>(nameof(SalesCreditMemos)); }
            set { BackingStore?.Set(nameof(SalesCreditMemos), value); }
        }
        /// <summary>The salesInvoiceLines property</summary>
        public List<SalesInvoiceLine> SalesInvoiceLines {
            get { return BackingStore?.Get<List<SalesInvoiceLine>>(nameof(SalesInvoiceLines)); }
            set { BackingStore?.Set(nameof(SalesInvoiceLines), value); }
        }
        /// <summary>The salesInvoices property</summary>
        public List<SalesInvoice> SalesInvoices {
            get { return BackingStore?.Get<List<SalesInvoice>>(nameof(SalesInvoices)); }
            set { BackingStore?.Set(nameof(SalesInvoices), value); }
        }
        /// <summary>The salesOrderLines property</summary>
        public List<SalesOrderLine> SalesOrderLines {
            get { return BackingStore?.Get<List<SalesOrderLine>>(nameof(SalesOrderLines)); }
            set { BackingStore?.Set(nameof(SalesOrderLines), value); }
        }
        /// <summary>The salesOrders property</summary>
        public List<SalesOrder> SalesOrders {
            get { return BackingStore?.Get<List<SalesOrder>>(nameof(SalesOrders)); }
            set { BackingStore?.Set(nameof(SalesOrders), value); }
        }
        /// <summary>The salesQuoteLines property</summary>
        public List<SalesQuoteLine> SalesQuoteLines {
            get { return BackingStore?.Get<List<SalesQuoteLine>>(nameof(SalesQuoteLines)); }
            set { BackingStore?.Set(nameof(SalesQuoteLines), value); }
        }
        /// <summary>The salesQuotes property</summary>
        public List<SalesQuote> SalesQuotes {
            get { return BackingStore?.Get<List<SalesQuote>>(nameof(SalesQuotes)); }
            set { BackingStore?.Set(nameof(SalesQuotes), value); }
        }
        /// <summary>The shipmentMethods property</summary>
        public List<ShipmentMethod> ShipmentMethods {
            get { return BackingStore?.Get<List<ShipmentMethod>>(nameof(ShipmentMethods)); }
            set { BackingStore?.Set(nameof(ShipmentMethods), value); }
        }
        /// <summary>The systemVersion property</summary>
        public string SystemVersion {
            get { return BackingStore?.Get<string>(nameof(SystemVersion)); }
            set { BackingStore?.Set(nameof(SystemVersion), value); }
        }
        /// <summary>The taxAreas property</summary>
        public List<TaxArea> TaxAreas {
            get { return BackingStore?.Get<List<TaxArea>>(nameof(TaxAreas)); }
            set { BackingStore?.Set(nameof(TaxAreas), value); }
        }
        /// <summary>The taxGroups property</summary>
        public List<TaxGroup> TaxGroups {
            get { return BackingStore?.Get<List<TaxGroup>>(nameof(TaxGroups)); }
            set { BackingStore?.Set(nameof(TaxGroups), value); }
        }
        /// <summary>The unitsOfMeasure property</summary>
        public List<UnitOfMeasure> UnitsOfMeasure {
            get { return BackingStore?.Get<List<UnitOfMeasure>>(nameof(UnitsOfMeasure)); }
            set { BackingStore?.Set(nameof(UnitsOfMeasure), value); }
        }
        /// <summary>The vendors property</summary>
        public List<Vendor> Vendors {
            get { return BackingStore?.Get<List<Vendor>>(nameof(Vendors)); }
            set { BackingStore?.Set(nameof(Vendors), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Company CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Company();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accounts", n => { Accounts = n.GetCollectionOfObjectValues<Account>(Account.CreateFromDiscriminatorValue).ToList(); } },
                {"agedAccountsPayable", n => { AgedAccountsPayable = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AgedAccountsPayable>(Microsoft.Graph.Beta.Models.AgedAccountsPayable.CreateFromDiscriminatorValue).ToList(); } },
                {"agedAccountsReceivable", n => { AgedAccountsReceivable = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AgedAccountsReceivable>(Microsoft.Graph.Beta.Models.AgedAccountsReceivable.CreateFromDiscriminatorValue).ToList(); } },
                {"businessProfileId", n => { BusinessProfileId = n.GetStringValue(); } },
                {"companyInformation", n => { CompanyInformation = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CompanyInformation>(Microsoft.Graph.Beta.Models.CompanyInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"countriesRegions", n => { CountriesRegions = n.GetCollectionOfObjectValues<CountryRegion>(CountryRegion.CreateFromDiscriminatorValue).ToList(); } },
                {"currencies", n => { Currencies = n.GetCollectionOfObjectValues<Currency>(Currency.CreateFromDiscriminatorValue).ToList(); } },
                {"customerPaymentJournals", n => { CustomerPaymentJournals = n.GetCollectionOfObjectValues<CustomerPaymentJournal>(CustomerPaymentJournal.CreateFromDiscriminatorValue).ToList(); } },
                {"customerPayments", n => { CustomerPayments = n.GetCollectionOfObjectValues<CustomerPayment>(CustomerPayment.CreateFromDiscriminatorValue).ToList(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<Customer>(Customer.CreateFromDiscriminatorValue).ToList(); } },
                {"dimensions", n => { Dimensions = n.GetCollectionOfObjectValues<Dimension>(Dimension.CreateFromDiscriminatorValue).ToList(); } },
                {"dimensionValues", n => { DimensionValues = n.GetCollectionOfObjectValues<DimensionValue>(DimensionValue.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"employees", n => { Employees = n.GetCollectionOfObjectValues<Employee>(Employee.CreateFromDiscriminatorValue).ToList(); } },
                {"generalLedgerEntries", n => { GeneralLedgerEntries = n.GetCollectionOfObjectValues<GeneralLedgerEntry>(GeneralLedgerEntry.CreateFromDiscriminatorValue).ToList(); } },
                {"itemCategories", n => { ItemCategories = n.GetCollectionOfObjectValues<ItemCategory>(ItemCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<Item>(Item.CreateFromDiscriminatorValue).ToList(); } },
                {"journalLines", n => { JournalLines = n.GetCollectionOfObjectValues<JournalLine>(JournalLine.CreateFromDiscriminatorValue).ToList(); } },
                {"journals", n => { Journals = n.GetCollectionOfObjectValues<Journal>(Journal.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"paymentMethods", n => { PaymentMethods = n.GetCollectionOfObjectValues<PaymentMethod>(PaymentMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"paymentTerms", n => { PaymentTerms = n.GetCollectionOfObjectValues<PaymentTerm>(PaymentTerm.CreateFromDiscriminatorValue).ToList(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue).ToList(); } },
                {"purchaseInvoiceLines", n => { PurchaseInvoiceLines = n.GetCollectionOfObjectValues<PurchaseInvoiceLine>(PurchaseInvoiceLine.CreateFromDiscriminatorValue).ToList(); } },
                {"purchaseInvoices", n => { PurchaseInvoices = n.GetCollectionOfObjectValues<PurchaseInvoice>(PurchaseInvoice.CreateFromDiscriminatorValue).ToList(); } },
                {"salesCreditMemoLines", n => { SalesCreditMemoLines = n.GetCollectionOfObjectValues<SalesCreditMemoLine>(SalesCreditMemoLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesCreditMemos", n => { SalesCreditMemos = n.GetCollectionOfObjectValues<SalesCreditMemo>(SalesCreditMemo.CreateFromDiscriminatorValue).ToList(); } },
                {"salesInvoiceLines", n => { SalesInvoiceLines = n.GetCollectionOfObjectValues<SalesInvoiceLine>(SalesInvoiceLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesInvoices", n => { SalesInvoices = n.GetCollectionOfObjectValues<SalesInvoice>(SalesInvoice.CreateFromDiscriminatorValue).ToList(); } },
                {"salesOrderLines", n => { SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>(SalesOrderLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesOrders", n => { SalesOrders = n.GetCollectionOfObjectValues<SalesOrder>(SalesOrder.CreateFromDiscriminatorValue).ToList(); } },
                {"salesQuoteLines", n => { SalesQuoteLines = n.GetCollectionOfObjectValues<SalesQuoteLine>(SalesQuoteLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesQuotes", n => { SalesQuotes = n.GetCollectionOfObjectValues<SalesQuote>(SalesQuote.CreateFromDiscriminatorValue).ToList(); } },
                {"shipmentMethods", n => { ShipmentMethods = n.GetCollectionOfObjectValues<ShipmentMethod>(ShipmentMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"systemVersion", n => { SystemVersion = n.GetStringValue(); } },
                {"taxAreas", n => { TaxAreas = n.GetCollectionOfObjectValues<TaxArea>(TaxArea.CreateFromDiscriminatorValue).ToList(); } },
                {"taxGroups", n => { TaxGroups = n.GetCollectionOfObjectValues<TaxGroup>(TaxGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"unitsOfMeasure", n => { UnitsOfMeasure = n.GetCollectionOfObjectValues<UnitOfMeasure>(UnitOfMeasure.CreateFromDiscriminatorValue).ToList(); } },
                {"vendors", n => { Vendors = n.GetCollectionOfObjectValues<Vendor>(Vendor.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
