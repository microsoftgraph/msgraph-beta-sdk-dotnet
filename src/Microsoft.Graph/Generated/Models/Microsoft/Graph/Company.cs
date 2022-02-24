using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Company : Entity, IParsable {
        public List<Account> Accounts { get; set; }
        public List<AgedAccountsPayable> AgedAccountsPayable { get; set; }
        public List<AgedAccountsReceivable> AgedAccountsReceivable { get; set; }
        public string BusinessProfileId { get; set; }
        public List<CompanyInformation> CompanyInformation { get; set; }
        public List<CountryRegion> CountriesRegions { get; set; }
        public List<Currency> Currencies { get; set; }
        public List<CustomerPaymentJournal> CustomerPaymentJournals { get; set; }
        public List<CustomerPayment> CustomerPayments { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Dimension> Dimensions { get; set; }
        public List<DimensionValue> DimensionValues { get; set; }
        public string DisplayName { get; set; }
        public List<Employee> Employees { get; set; }
        public List<GeneralLedgerEntry> GeneralLedgerEntries { get; set; }
        public List<ItemCategory> ItemCategories { get; set; }
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item> Items { get; set; }
        public List<JournalLine> JournalLines { get; set; }
        public List<Journal> Journals { get; set; }
        public string Name { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }
        public List<PaymentTerm> PaymentTerms { get; set; }
        public List<Picture> Picture { get; set; }
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
        public List<PurchaseInvoice> PurchaseInvoices { get; set; }
        public List<SalesCreditMemoLine> SalesCreditMemoLines { get; set; }
        public List<SalesCreditMemo> SalesCreditMemos { get; set; }
        public List<SalesInvoiceLine> SalesInvoiceLines { get; set; }
        public List<SalesInvoice> SalesInvoices { get; set; }
        public List<SalesOrderLine> SalesOrderLines { get; set; }
        public List<SalesOrder> SalesOrders { get; set; }
        public List<SalesQuoteLine> SalesQuoteLines { get; set; }
        public List<SalesQuote> SalesQuotes { get; set; }
        public List<ShipmentMethod> ShipmentMethods { get; set; }
        public string SystemVersion { get; set; }
        public List<TaxArea> TaxAreas { get; set; }
        public List<TaxGroup> TaxGroups { get; set; }
        public List<UnitOfMeasure> UnitsOfMeasure { get; set; }
        public List<Vendor> Vendors { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accounts", (o,n) => { (o as Company).Accounts = n.GetCollectionOfObjectValues<Account>().ToList(); } },
                {"agedAccountsPayable", (o,n) => { (o as Company).AgedAccountsPayable = n.GetCollectionOfObjectValues<AgedAccountsPayable>().ToList(); } },
                {"agedAccountsReceivable", (o,n) => { (o as Company).AgedAccountsReceivable = n.GetCollectionOfObjectValues<AgedAccountsReceivable>().ToList(); } },
                {"businessProfileId", (o,n) => { (o as Company).BusinessProfileId = n.GetStringValue(); } },
                {"companyInformation", (o,n) => { (o as Company).CompanyInformation = n.GetCollectionOfObjectValues<CompanyInformation>().ToList(); } },
                {"countriesRegions", (o,n) => { (o as Company).CountriesRegions = n.GetCollectionOfObjectValues<CountryRegion>().ToList(); } },
                {"currencies", (o,n) => { (o as Company).Currencies = n.GetCollectionOfObjectValues<Currency>().ToList(); } },
                {"customerPaymentJournals", (o,n) => { (o as Company).CustomerPaymentJournals = n.GetCollectionOfObjectValues<CustomerPaymentJournal>().ToList(); } },
                {"customerPayments", (o,n) => { (o as Company).CustomerPayments = n.GetCollectionOfObjectValues<CustomerPayment>().ToList(); } },
                {"customers", (o,n) => { (o as Company).Customers = n.GetCollectionOfObjectValues<Customer>().ToList(); } },
                {"dimensions", (o,n) => { (o as Company).Dimensions = n.GetCollectionOfObjectValues<Dimension>().ToList(); } },
                {"dimensionValues", (o,n) => { (o as Company).DimensionValues = n.GetCollectionOfObjectValues<DimensionValue>().ToList(); } },
                {"displayName", (o,n) => { (o as Company).DisplayName = n.GetStringValue(); } },
                {"employees", (o,n) => { (o as Company).Employees = n.GetCollectionOfObjectValues<Employee>().ToList(); } },
                {"generalLedgerEntries", (o,n) => { (o as Company).GeneralLedgerEntries = n.GetCollectionOfObjectValues<GeneralLedgerEntry>().ToList(); } },
                {"itemCategories", (o,n) => { (o as Company).ItemCategories = n.GetCollectionOfObjectValues<ItemCategory>().ToList(); } },
                {"items", (o,n) => { (o as Company).Items = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>().ToList(); } },
                {"journalLines", (o,n) => { (o as Company).JournalLines = n.GetCollectionOfObjectValues<JournalLine>().ToList(); } },
                {"journals", (o,n) => { (o as Company).Journals = n.GetCollectionOfObjectValues<Journal>().ToList(); } },
                {"name", (o,n) => { (o as Company).Name = n.GetStringValue(); } },
                {"paymentMethods", (o,n) => { (o as Company).PaymentMethods = n.GetCollectionOfObjectValues<PaymentMethod>().ToList(); } },
                {"paymentTerms", (o,n) => { (o as Company).PaymentTerms = n.GetCollectionOfObjectValues<PaymentTerm>().ToList(); } },
                {"picture", (o,n) => { (o as Company).Picture = n.GetCollectionOfObjectValues<Picture>().ToList(); } },
                {"purchaseInvoiceLines", (o,n) => { (o as Company).PurchaseInvoiceLines = n.GetCollectionOfObjectValues<PurchaseInvoiceLine>().ToList(); } },
                {"purchaseInvoices", (o,n) => { (o as Company).PurchaseInvoices = n.GetCollectionOfObjectValues<PurchaseInvoice>().ToList(); } },
                {"salesCreditMemoLines", (o,n) => { (o as Company).SalesCreditMemoLines = n.GetCollectionOfObjectValues<SalesCreditMemoLine>().ToList(); } },
                {"salesCreditMemos", (o,n) => { (o as Company).SalesCreditMemos = n.GetCollectionOfObjectValues<SalesCreditMemo>().ToList(); } },
                {"salesInvoiceLines", (o,n) => { (o as Company).SalesInvoiceLines = n.GetCollectionOfObjectValues<SalesInvoiceLine>().ToList(); } },
                {"salesInvoices", (o,n) => { (o as Company).SalesInvoices = n.GetCollectionOfObjectValues<SalesInvoice>().ToList(); } },
                {"salesOrderLines", (o,n) => { (o as Company).SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>().ToList(); } },
                {"salesOrders", (o,n) => { (o as Company).SalesOrders = n.GetCollectionOfObjectValues<SalesOrder>().ToList(); } },
                {"salesQuoteLines", (o,n) => { (o as Company).SalesQuoteLines = n.GetCollectionOfObjectValues<SalesQuoteLine>().ToList(); } },
                {"salesQuotes", (o,n) => { (o as Company).SalesQuotes = n.GetCollectionOfObjectValues<SalesQuote>().ToList(); } },
                {"shipmentMethods", (o,n) => { (o as Company).ShipmentMethods = n.GetCollectionOfObjectValues<ShipmentMethod>().ToList(); } },
                {"systemVersion", (o,n) => { (o as Company).SystemVersion = n.GetStringValue(); } },
                {"taxAreas", (o,n) => { (o as Company).TaxAreas = n.GetCollectionOfObjectValues<TaxArea>().ToList(); } },
                {"taxGroups", (o,n) => { (o as Company).TaxGroups = n.GetCollectionOfObjectValues<TaxGroup>().ToList(); } },
                {"unitsOfMeasure", (o,n) => { (o as Company).UnitsOfMeasure = n.GetCollectionOfObjectValues<UnitOfMeasure>().ToList(); } },
                {"vendors", (o,n) => { (o as Company).Vendors = n.GetCollectionOfObjectValues<Vendor>().ToList(); } },
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
            writer.WriteCollectionOfObjectValues<AgedAccountsPayable>("agedAccountsPayable", AgedAccountsPayable);
            writer.WriteCollectionOfObjectValues<AgedAccountsReceivable>("agedAccountsReceivable", AgedAccountsReceivable);
            writer.WriteStringValue("businessProfileId", BusinessProfileId);
            writer.WriteCollectionOfObjectValues<CompanyInformation>("companyInformation", CompanyInformation);
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
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>("items", Items);
            writer.WriteCollectionOfObjectValues<JournalLine>("journalLines", JournalLines);
            writer.WriteCollectionOfObjectValues<Journal>("journals", Journals);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<PaymentMethod>("paymentMethods", PaymentMethods);
            writer.WriteCollectionOfObjectValues<PaymentTerm>("paymentTerms", PaymentTerms);
            writer.WriteCollectionOfObjectValues<Picture>("picture", Picture);
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
