// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ICompanyRequestBuilder.
    /// </summary>
    public partial interface ICompanyRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ICompanyRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ICompanyRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Accounts.
        /// </summary>
        /// <returns>The <see cref="ICompanyAccountsCollectionRequestBuilder"/>.</returns>
        ICompanyAccountsCollectionRequestBuilder Accounts { get; }

        /// <summary>
        /// Gets the request builder for AgedAccountsPayable.
        /// </summary>
        /// <returns>The <see cref="ICompanyAgedAccountsPayableCollectionRequestBuilder"/>.</returns>
        ICompanyAgedAccountsPayableCollectionRequestBuilder AgedAccountsPayable { get; }

        /// <summary>
        /// Gets the request builder for AgedAccountsReceivable.
        /// </summary>
        /// <returns>The <see cref="ICompanyAgedAccountsReceivableCollectionRequestBuilder"/>.</returns>
        ICompanyAgedAccountsReceivableCollectionRequestBuilder AgedAccountsReceivable { get; }

        /// <summary>
        /// Gets the request builder for CompanyInformation.
        /// </summary>
        /// <returns>The <see cref="ICompanyCompanyInformationCollectionRequestBuilder"/>.</returns>
        ICompanyCompanyInformationCollectionRequestBuilder CompanyInformation { get; }

        /// <summary>
        /// Gets the request builder for CountriesRegions.
        /// </summary>
        /// <returns>The <see cref="ICompanyCountriesRegionsCollectionRequestBuilder"/>.</returns>
        ICompanyCountriesRegionsCollectionRequestBuilder CountriesRegions { get; }

        /// <summary>
        /// Gets the request builder for Currencies.
        /// </summary>
        /// <returns>The <see cref="ICompanyCurrenciesCollectionRequestBuilder"/>.</returns>
        ICompanyCurrenciesCollectionRequestBuilder Currencies { get; }

        /// <summary>
        /// Gets the request builder for CustomerPaymentJournals.
        /// </summary>
        /// <returns>The <see cref="ICompanyCustomerPaymentJournalsCollectionRequestBuilder"/>.</returns>
        ICompanyCustomerPaymentJournalsCollectionRequestBuilder CustomerPaymentJournals { get; }

        /// <summary>
        /// Gets the request builder for CustomerPayments.
        /// </summary>
        /// <returns>The <see cref="ICompanyCustomerPaymentsCollectionRequestBuilder"/>.</returns>
        ICompanyCustomerPaymentsCollectionRequestBuilder CustomerPayments { get; }

        /// <summary>
        /// Gets the request builder for Customers.
        /// </summary>
        /// <returns>The <see cref="ICompanyCustomersCollectionRequestBuilder"/>.</returns>
        ICompanyCustomersCollectionRequestBuilder Customers { get; }

        /// <summary>
        /// Gets the request builder for Dimensions.
        /// </summary>
        /// <returns>The <see cref="ICompanyDimensionsCollectionRequestBuilder"/>.</returns>
        ICompanyDimensionsCollectionRequestBuilder Dimensions { get; }

        /// <summary>
        /// Gets the request builder for DimensionValues.
        /// </summary>
        /// <returns>The <see cref="ICompanyDimensionValuesCollectionRequestBuilder"/>.</returns>
        ICompanyDimensionValuesCollectionRequestBuilder DimensionValues { get; }

        /// <summary>
        /// Gets the request builder for Employees.
        /// </summary>
        /// <returns>The <see cref="ICompanyEmployeesCollectionRequestBuilder"/>.</returns>
        ICompanyEmployeesCollectionRequestBuilder Employees { get; }

        /// <summary>
        /// Gets the request builder for GeneralLedgerEntries.
        /// </summary>
        /// <returns>The <see cref="ICompanyGeneralLedgerEntriesCollectionRequestBuilder"/>.</returns>
        ICompanyGeneralLedgerEntriesCollectionRequestBuilder GeneralLedgerEntries { get; }

        /// <summary>
        /// Gets the request builder for ItemCategories.
        /// </summary>
        /// <returns>The <see cref="ICompanyItemCategoriesCollectionRequestBuilder"/>.</returns>
        ICompanyItemCategoriesCollectionRequestBuilder ItemCategories { get; }

        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="ICompanyItemsCollectionRequestBuilder"/>.</returns>
        ICompanyItemsCollectionRequestBuilder Items { get; }

        /// <summary>
        /// Gets the request builder for JournalLines.
        /// </summary>
        /// <returns>The <see cref="ICompanyJournalLinesCollectionRequestBuilder"/>.</returns>
        ICompanyJournalLinesCollectionRequestBuilder JournalLines { get; }

        /// <summary>
        /// Gets the request builder for Journals.
        /// </summary>
        /// <returns>The <see cref="ICompanyJournalsCollectionRequestBuilder"/>.</returns>
        ICompanyJournalsCollectionRequestBuilder Journals { get; }

        /// <summary>
        /// Gets the request builder for PaymentMethods.
        /// </summary>
        /// <returns>The <see cref="ICompanyPaymentMethodsCollectionRequestBuilder"/>.</returns>
        ICompanyPaymentMethodsCollectionRequestBuilder PaymentMethods { get; }

        /// <summary>
        /// Gets the request builder for PaymentTerms.
        /// </summary>
        /// <returns>The <see cref="ICompanyPaymentTermsCollectionRequestBuilder"/>.</returns>
        ICompanyPaymentTermsCollectionRequestBuilder PaymentTerms { get; }

        /// <summary>
        /// Gets the request builder for Picture.
        /// </summary>
        /// <returns>The <see cref="ICompanyPictureCollectionRequestBuilder"/>.</returns>
        ICompanyPictureCollectionRequestBuilder Picture { get; }

        /// <summary>
        /// Gets the request builder for PurchaseInvoiceLines.
        /// </summary>
        /// <returns>The <see cref="ICompanyPurchaseInvoiceLinesCollectionRequestBuilder"/>.</returns>
        ICompanyPurchaseInvoiceLinesCollectionRequestBuilder PurchaseInvoiceLines { get; }

        /// <summary>
        /// Gets the request builder for PurchaseInvoices.
        /// </summary>
        /// <returns>The <see cref="ICompanyPurchaseInvoicesCollectionRequestBuilder"/>.</returns>
        ICompanyPurchaseInvoicesCollectionRequestBuilder PurchaseInvoices { get; }

        /// <summary>
        /// Gets the request builder for SalesCreditMemoLines.
        /// </summary>
        /// <returns>The <see cref="ICompanySalesCreditMemoLinesCollectionRequestBuilder"/>.</returns>
        ICompanySalesCreditMemoLinesCollectionRequestBuilder SalesCreditMemoLines { get; }

        /// <summary>
        /// Gets the request builder for SalesCreditMemos.
        /// </summary>
        /// <returns>The <see cref="ICompanySalesCreditMemosCollectionRequestBuilder"/>.</returns>
        ICompanySalesCreditMemosCollectionRequestBuilder SalesCreditMemos { get; }

        /// <summary>
        /// Gets the request builder for SalesInvoiceLines.
        /// </summary>
        /// <returns>The <see cref="ICompanySalesInvoiceLinesCollectionRequestBuilder"/>.</returns>
        ICompanySalesInvoiceLinesCollectionRequestBuilder SalesInvoiceLines { get; }

        /// <summary>
        /// Gets the request builder for SalesInvoices.
        /// </summary>
        /// <returns>The <see cref="ICompanySalesInvoicesCollectionRequestBuilder"/>.</returns>
        ICompanySalesInvoicesCollectionRequestBuilder SalesInvoices { get; }

        /// <summary>
        /// Gets the request builder for SalesOrderLines.
        /// </summary>
        /// <returns>The <see cref="ICompanySalesOrderLinesCollectionRequestBuilder"/>.</returns>
        ICompanySalesOrderLinesCollectionRequestBuilder SalesOrderLines { get; }

        /// <summary>
        /// Gets the request builder for SalesOrders.
        /// </summary>
        /// <returns>The <see cref="ICompanySalesOrdersCollectionRequestBuilder"/>.</returns>
        ICompanySalesOrdersCollectionRequestBuilder SalesOrders { get; }

        /// <summary>
        /// Gets the request builder for SalesQuoteLines.
        /// </summary>
        /// <returns>The <see cref="ICompanySalesQuoteLinesCollectionRequestBuilder"/>.</returns>
        ICompanySalesQuoteLinesCollectionRequestBuilder SalesQuoteLines { get; }

        /// <summary>
        /// Gets the request builder for SalesQuotes.
        /// </summary>
        /// <returns>The <see cref="ICompanySalesQuotesCollectionRequestBuilder"/>.</returns>
        ICompanySalesQuotesCollectionRequestBuilder SalesQuotes { get; }

        /// <summary>
        /// Gets the request builder for ShipmentMethods.
        /// </summary>
        /// <returns>The <see cref="ICompanyShipmentMethodsCollectionRequestBuilder"/>.</returns>
        ICompanyShipmentMethodsCollectionRequestBuilder ShipmentMethods { get; }

        /// <summary>
        /// Gets the request builder for TaxAreas.
        /// </summary>
        /// <returns>The <see cref="ICompanyTaxAreasCollectionRequestBuilder"/>.</returns>
        ICompanyTaxAreasCollectionRequestBuilder TaxAreas { get; }

        /// <summary>
        /// Gets the request builder for TaxGroups.
        /// </summary>
        /// <returns>The <see cref="ICompanyTaxGroupsCollectionRequestBuilder"/>.</returns>
        ICompanyTaxGroupsCollectionRequestBuilder TaxGroups { get; }

        /// <summary>
        /// Gets the request builder for UnitsOfMeasure.
        /// </summary>
        /// <returns>The <see cref="ICompanyUnitsOfMeasureCollectionRequestBuilder"/>.</returns>
        ICompanyUnitsOfMeasureCollectionRequestBuilder UnitsOfMeasure { get; }

        /// <summary>
        /// Gets the request builder for Vendors.
        /// </summary>
        /// <returns>The <see cref="ICompanyVendorsCollectionRequestBuilder"/>.</returns>
        ICompanyVendorsCollectionRequestBuilder Vendors { get; }
    
    }
}
