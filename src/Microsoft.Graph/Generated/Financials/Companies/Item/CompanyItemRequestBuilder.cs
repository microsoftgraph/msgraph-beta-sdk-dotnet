using Microsoft.Graph.Beta.Financials.Companies.Item.Accounts;
using Microsoft.Graph.Beta.Financials.Companies.Item.AgedAccountsPayable;
using Microsoft.Graph.Beta.Financials.Companies.Item.AgedAccountsReceivable;
using Microsoft.Graph.Beta.Financials.Companies.Item.CompanyInformation;
using Microsoft.Graph.Beta.Financials.Companies.Item.CountriesRegions;
using Microsoft.Graph.Beta.Financials.Companies.Item.Currencies;
using Microsoft.Graph.Beta.Financials.Companies.Item.CustomerPaymentJournals;
using Microsoft.Graph.Beta.Financials.Companies.Item.CustomerPayments;
using Microsoft.Graph.Beta.Financials.Companies.Item.Customers;
using Microsoft.Graph.Beta.Financials.Companies.Item.Dimensions;
using Microsoft.Graph.Beta.Financials.Companies.Item.DimensionValues;
using Microsoft.Graph.Beta.Financials.Companies.Item.Employees;
using Microsoft.Graph.Beta.Financials.Companies.Item.GeneralLedgerEntries;
using Microsoft.Graph.Beta.Financials.Companies.Item.ItemCategories;
using Microsoft.Graph.Beta.Financials.Companies.Item.Items;
using Microsoft.Graph.Beta.Financials.Companies.Item.JournalLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.Journals;
using Microsoft.Graph.Beta.Financials.Companies.Item.PaymentMethods;
using Microsoft.Graph.Beta.Financials.Companies.Item.PaymentTerms;
using Microsoft.Graph.Beta.Financials.Companies.Item.Picture;
using Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoiceLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemos;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoiceLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesOrderLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesOrders;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesQuoteLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesQuotes;
using Microsoft.Graph.Beta.Financials.Companies.Item.ShipmentMethods;
using Microsoft.Graph.Beta.Financials.Companies.Item.TaxAreas;
using Microsoft.Graph.Beta.Financials.Companies.Item.TaxGroups;
using Microsoft.Graph.Beta.Financials.Companies.Item.UnitsOfMeasure;
using Microsoft.Graph.Beta.Financials.Companies.Item.Vendors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Financials.Companies.Item {
    /// <summary>Provides operations to manage the companies property of the microsoft.graph.financials entity.</summary>
    public class CompanyItemRequestBuilder {
        /// <summary>The accounts property</summary>
        public AccountsRequestBuilder Accounts { get =>
            new AccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The agedAccountsPayable property</summary>
        public AgedAccountsPayableRequestBuilder AgedAccountsPayable { get =>
            new AgedAccountsPayableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The agedAccountsReceivable property</summary>
        public AgedAccountsReceivableRequestBuilder AgedAccountsReceivable { get =>
            new AgedAccountsReceivableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The companyInformation property</summary>
        public CompanyInformationRequestBuilder CompanyInformation { get =>
            new CompanyInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The countriesRegions property</summary>
        public CountriesRegionsRequestBuilder CountriesRegions { get =>
            new CountriesRegionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The currencies property</summary>
        public CurrenciesRequestBuilder Currencies { get =>
            new CurrenciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The customerPaymentJournals property</summary>
        public CustomerPaymentJournalsRequestBuilder CustomerPaymentJournals { get =>
            new CustomerPaymentJournalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The customerPayments property</summary>
        public CustomerPaymentsRequestBuilder CustomerPayments { get =>
            new CustomerPaymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The customers property</summary>
        public CustomersRequestBuilder Customers { get =>
            new CustomersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dimensions property</summary>
        public DimensionsRequestBuilder Dimensions { get =>
            new DimensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dimensionValues property</summary>
        public DimensionValuesRequestBuilder DimensionValues { get =>
            new DimensionValuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The employees property</summary>
        public EmployeesRequestBuilder Employees { get =>
            new EmployeesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The generalLedgerEntries property</summary>
        public GeneralLedgerEntriesRequestBuilder GeneralLedgerEntries { get =>
            new GeneralLedgerEntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The itemCategories property</summary>
        public ItemCategoriesRequestBuilder ItemCategories { get =>
            new ItemCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The items property</summary>
        public ItemsRequestBuilder Items { get =>
            new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The journalLines property</summary>
        public JournalLinesRequestBuilder JournalLines { get =>
            new JournalLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The journals property</summary>
        public JournalsRequestBuilder Journals { get =>
            new JournalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The paymentMethods property</summary>
        public PaymentMethodsRequestBuilder PaymentMethods { get =>
            new PaymentMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The paymentTerms property</summary>
        public PaymentTermsRequestBuilder PaymentTerms { get =>
            new PaymentTermsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The picture property</summary>
        public PictureRequestBuilder Picture { get =>
            new PictureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The purchaseInvoiceLines property</summary>
        public PurchaseInvoiceLinesRequestBuilder PurchaseInvoiceLines { get =>
            new PurchaseInvoiceLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The purchaseInvoices property</summary>
        public PurchaseInvoicesRequestBuilder PurchaseInvoices { get =>
            new PurchaseInvoicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The salesCreditMemoLines property</summary>
        public SalesCreditMemoLinesRequestBuilder SalesCreditMemoLines { get =>
            new SalesCreditMemoLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The salesCreditMemos property</summary>
        public SalesCreditMemosRequestBuilder SalesCreditMemos { get =>
            new SalesCreditMemosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The salesInvoiceLines property</summary>
        public SalesInvoiceLinesRequestBuilder SalesInvoiceLines { get =>
            new SalesInvoiceLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The salesInvoices property</summary>
        public SalesInvoicesRequestBuilder SalesInvoices { get =>
            new SalesInvoicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The salesOrderLines property</summary>
        public SalesOrderLinesRequestBuilder SalesOrderLines { get =>
            new SalesOrderLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The salesOrders property</summary>
        public SalesOrdersRequestBuilder SalesOrders { get =>
            new SalesOrdersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The salesQuoteLines property</summary>
        public SalesQuoteLinesRequestBuilder SalesQuoteLines { get =>
            new SalesQuoteLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The salesQuotes property</summary>
        public SalesQuotesRequestBuilder SalesQuotes { get =>
            new SalesQuotesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The shipmentMethods property</summary>
        public ShipmentMethodsRequestBuilder ShipmentMethods { get =>
            new ShipmentMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The taxAreas property</summary>
        public TaxAreasRequestBuilder TaxAreas { get =>
            new TaxAreasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The taxGroups property</summary>
        public TaxGroupsRequestBuilder TaxGroups { get =>
            new TaxGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The unitsOfMeasure property</summary>
        public UnitsOfMeasureRequestBuilder UnitsOfMeasure { get =>
            new UnitsOfMeasureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The vendors property</summary>
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
            UrlTemplate = "{+baseurl}/financials/companies/{company%2Did}{?%24select,%24expand}";
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
            UrlTemplate = "{+baseurl}/financials/companies/{company%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property companies for financials
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<CompanyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CompanyItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get companies from financials
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<CompanyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CompanyItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property companies in financials
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Company body, Action<CompanyItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new CompanyItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property companies for financials
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<CompanyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get companies from financials
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Company> GetAsync(Action<CompanyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Company>(requestInfo, Company.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property companies in financials
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Company body, Action<CompanyItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class CompanyItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new companyItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public CompanyItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Get companies from financials</summary>
        public class CompanyItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class CompanyItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CompanyItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CompanyItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new companyItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CompanyItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class CompanyItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new companyItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public CompanyItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
