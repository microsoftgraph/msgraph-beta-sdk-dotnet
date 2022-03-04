using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Financials.Companies.Item.Accounts;
using MicrosoftGraphSdk.Financials.Companies.Item.AgedAccountsPayable;
using MicrosoftGraphSdk.Financials.Companies.Item.AgedAccountsReceivable;
using MicrosoftGraphSdk.Financials.Companies.Item.CompanyInformation;
using MicrosoftGraphSdk.Financials.Companies.Item.CountriesRegions;
using MicrosoftGraphSdk.Financials.Companies.Item.Currencies;
using MicrosoftGraphSdk.Financials.Companies.Item.CustomerPaymentJournals;
using MicrosoftGraphSdk.Financials.Companies.Item.CustomerPayments;
using MicrosoftGraphSdk.Financials.Companies.Item.Customers;
using MicrosoftGraphSdk.Financials.Companies.Item.Dimensions;
using MicrosoftGraphSdk.Financials.Companies.Item.DimensionValues;
using MicrosoftGraphSdk.Financials.Companies.Item.Employees;
using MicrosoftGraphSdk.Financials.Companies.Item.GeneralLedgerEntries;
using MicrosoftGraphSdk.Financials.Companies.Item.ItemCategories;
using MicrosoftGraphSdk.Financials.Companies.Item.Items;
using MicrosoftGraphSdk.Financials.Companies.Item.JournalLines;
using MicrosoftGraphSdk.Financials.Companies.Item.Journals;
using MicrosoftGraphSdk.Financials.Companies.Item.PaymentMethods;
using MicrosoftGraphSdk.Financials.Companies.Item.PaymentTerms;
using MicrosoftGraphSdk.Financials.Companies.Item.Picture;
using MicrosoftGraphSdk.Financials.Companies.Item.PurchaseInvoiceLines;
using MicrosoftGraphSdk.Financials.Companies.Item.PurchaseInvoices;
using MicrosoftGraphSdk.Financials.Companies.Item.SalesCreditMemoLines;
using MicrosoftGraphSdk.Financials.Companies.Item.SalesCreditMemos;
using MicrosoftGraphSdk.Financials.Companies.Item.SalesInvoiceLines;
using MicrosoftGraphSdk.Financials.Companies.Item.SalesInvoices;
using MicrosoftGraphSdk.Financials.Companies.Item.SalesOrderLines;
using MicrosoftGraphSdk.Financials.Companies.Item.SalesOrders;
using MicrosoftGraphSdk.Financials.Companies.Item.SalesQuoteLines;
using MicrosoftGraphSdk.Financials.Companies.Item.SalesQuotes;
using MicrosoftGraphSdk.Financials.Companies.Item.ShipmentMethods;
using MicrosoftGraphSdk.Financials.Companies.Item.TaxAreas;
using MicrosoftGraphSdk.Financials.Companies.Item.TaxGroups;
using MicrosoftGraphSdk.Financials.Companies.Item.UnitsOfMeasure;
using MicrosoftGraphSdk.Financials.Companies.Item.Vendors;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Financials.Companies.Item {
    /// <summary>Builds and executes requests for operations under \financials\companies\{company-id}</summary>
    public class CompanyItemRequestBuilder {
        public AccountsRequestBuilder Accounts { get =>
            new AccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AgedAccountsPayableRequestBuilder AgedAccountsPayable { get =>
            new AgedAccountsPayableRequestBuilder(PathParameters, RequestAdapter);
        }
        public AgedAccountsReceivableRequestBuilder AgedAccountsReceivable { get =>
            new AgedAccountsReceivableRequestBuilder(PathParameters, RequestAdapter);
        }
        public CompanyInformationRequestBuilder CompanyInformation { get =>
            new CompanyInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        public CountriesRegionsRequestBuilder CountriesRegions { get =>
            new CountriesRegionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CurrenciesRequestBuilder Currencies { get =>
            new CurrenciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public CustomerPaymentJournalsRequestBuilder CustomerPaymentJournals { get =>
            new CustomerPaymentJournalsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CustomerPaymentsRequestBuilder CustomerPayments { get =>
            new CustomerPaymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CustomersRequestBuilder Customers { get =>
            new CustomersRequestBuilder(PathParameters, RequestAdapter);
        }
        public DimensionsRequestBuilder Dimensions { get =>
            new DimensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DimensionValuesRequestBuilder DimensionValues { get =>
            new DimensionValuesRequestBuilder(PathParameters, RequestAdapter);
        }
        public EmployeesRequestBuilder Employees { get =>
            new EmployeesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GeneralLedgerEntriesRequestBuilder GeneralLedgerEntries { get =>
            new GeneralLedgerEntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ItemCategoriesRequestBuilder ItemCategories { get =>
            new ItemCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ItemsRequestBuilder Items { get =>
            new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        public JournalLinesRequestBuilder JournalLines { get =>
            new JournalLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        public JournalsRequestBuilder Journals { get =>
            new JournalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PaymentMethodsRequestBuilder PaymentMethods { get =>
            new PaymentMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PaymentTermsRequestBuilder PaymentTerms { get =>
            new PaymentTermsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PictureRequestBuilder Picture { get =>
            new PictureRequestBuilder(PathParameters, RequestAdapter);
        }
        public PurchaseInvoiceLinesRequestBuilder PurchaseInvoiceLines { get =>
            new PurchaseInvoiceLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        public PurchaseInvoicesRequestBuilder PurchaseInvoices { get =>
            new PurchaseInvoicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SalesCreditMemoLinesRequestBuilder SalesCreditMemoLines { get =>
            new SalesCreditMemoLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SalesCreditMemosRequestBuilder SalesCreditMemos { get =>
            new SalesCreditMemosRequestBuilder(PathParameters, RequestAdapter);
        }
        public SalesInvoiceLinesRequestBuilder SalesInvoiceLines { get =>
            new SalesInvoiceLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SalesInvoicesRequestBuilder SalesInvoices { get =>
            new SalesInvoicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SalesOrderLinesRequestBuilder SalesOrderLines { get =>
            new SalesOrderLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SalesOrdersRequestBuilder SalesOrders { get =>
            new SalesOrdersRequestBuilder(PathParameters, RequestAdapter);
        }
        public SalesQuoteLinesRequestBuilder SalesQuoteLines { get =>
            new SalesQuoteLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SalesQuotesRequestBuilder SalesQuotes { get =>
            new SalesQuotesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ShipmentMethodsRequestBuilder ShipmentMethods { get =>
            new ShipmentMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TaxAreasRequestBuilder TaxAreas { get =>
            new TaxAreasRequestBuilder(PathParameters, RequestAdapter);
        }
        public TaxGroupsRequestBuilder TaxGroups { get =>
            new TaxGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UnitsOfMeasureRequestBuilder UnitsOfMeasure { get =>
            new UnitsOfMeasureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public VendorsRequestBuilder Vendors { get =>
            new VendorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CompanyItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public CompanyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/financials/companies/{company_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new CompanyItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public CompanyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/financials/companies/{company_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property companies for financials
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get companies from financials
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property companies in financials
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Company body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property companies for financials
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Get companies from financials
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Company> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Company>(requestInfo, Company.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property companies in financials
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Company body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>Get companies from financials</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
